//2022-04-05 NodeMCU ESP8266 자동배수장치 프로젝트 이예찬
//2022-05-02 초음파 센서 에러로 인한 유지보수. 센싱 딜레이 추가 및 온보드 LED 상시 꺼짐.
#include <ESP8266WiFi.h>
#include <ESP8266WebServer.h>
#include <MedianFilterLib.h> //초음파 센서 노이즈로 인한 오작동 방지

//접속할 공유기 설정
const char* ssid = "AP NAME";  // Enter SSID here
const char* password = "AP PASSWORD";  //Enter Password here

ESP8266WebServer server(80);

//저수통 제원 : 세로 길이 : 32cm, 초음파 센서 기준 펌프 작동 최저수위 : 26cm, 작동 수위 : 6cm 임계 수위 : 3cm, 25L 저수용량.
const int MIN_LEVEL = 6; //펌프 정지 수위(최저, 바닥 기준 6cm, 초음파 거리 기준 26cm)
const int RUN_LEVEL = 26; //펌프 동작 수위(작동 역치, 바닥 기준 26cm, 초음파 거리 기준 6cm)
const int WARNING_LEVEL = 28; //물 넘침 경고 수위(한계, 바닥 기준 28cm, 초음파 거리 기준 4cm)
const int MAX_LEVEL = 32; //물 저장 한계
const int TIME_OUT = 180000; //펌프 동작 타임아웃. 이 시간을 초과해서 작동할 경우, 고장으로 판단함. 3min = 180000
const int SENSING_DELAY = 1000; //초음파 센서를 이용한 센싱 주기
float now_level = MIN_LEVEL + 10;
unsigned long last_time = 0; //마지막으로 동작한 시각
unsigned long run_time = 0;  //펌프가 작동 시작한 시각
unsigned long last_sensing = 0;  //주기적 센싱을 위한 시간 기록
unsigned long before_time = 0; //ERR 표시용
String ERR_MSG = "";

boolean is_run = false; //펌프 동작 여부
boolean is_err = false; //에러 발생 여부

int pin_run = 5;      //릴레이              D1
int pin_led = 16;     //LED                D0  정상 : 켜짐, 오류 : 점멸
int pin_beep = 14;    //부저                D5
int pin_rst = 12;     //시스템 Reset        D6 <-> RST, 업로드 중일땐 제거해야함.
int pin_trig = 0;     //초음파센서 TRIG      D3
int pin_echo = 4;     //초음파센서 ECHO      D2

String GetDiffTime(unsigned long t);

String SendHTML(boolean state, int redirect_time){
  String ptr = "<!DOCTYPE html> <html>\n";
  float percent = now_level / MAX_LEVEL;
  ptr +="<head><meta charset=\"utf-8\">\n";
  ptr +="<meta http-equiv='refresh' content='"+ String(redirect_time)+";url=/'>\n";
  ptr +="<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0, user-scalable=no\">\n";
  ptr +="<link href=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css\" rel=\"stylesheet\" integrity=\"sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3\" crossorigin=\"anonymous\">\n";
  ptr +="<script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js\" integrity=\"sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p\" crossorigin=\"anonymous\"></script>\n";
  ptr +="<title>자동배수시스템</title>\n";
  
  ptr +="<style>html, body{height:100%;margin:0;}\n";
  //ptr +="iframe{width:100%;height:100%;}\n";
  ptr +=".progress_fild{display:flex;margin:0 -10px;justify-content:space-between;align-items:center;}\n";
  ptr +="#night_mode{display:block;position:absolute;width:100%;height:200%;background:rgba(0,0,0,0.7);z-index:5;}\n";
  ptr +="</style>\n<script>\n";
  
  ptr +="function night_mode(){var mode = document.getElementById('night_mode');mode.style.visibility = \"visible\";}\n";
  ptr +="window.onload = function(){var now = new Date;if(now.getHours() > 20 || now.getHours() < 7){night_mode();}}\n";
  ptr +="</script>\n</head>\n";

  ptr +="<body>\n";

  //ptr +="<div id=\"night_mode\"></div>\n";
  //ptr +="<div class=\"container\" style=\"height: 100%\">\n";
  //ptr +="<iframe src=\"https://vclock.kr/embed/time/#theme=0&ampm=2&showdate=1\" frameborder=\"0\" ></iframe>\n";
  //ptr +="</div>\n";
  ptr +="<div class=\"container d-flex align-items-center\" style=\"height: 100%\">\n";
  ptr +="<div style=\"width:100%\">\n";
  ptr +="<div class=\"progress\" style=\"height : 40px;font-size: 1.3em;\">\n";
  ptr +="<div class=\"progress-bar progress-bar-animated progress-bar-striped\" role=\"progressbar\" aria-valuenow=\"" + String(percent*100) + "\" aria-valuemin=\"0\" aria-valuemax=\"100\" style=\"width:" + String(percent*100) + "%\">" + String(percent*100) + "%" + String((is_run)?"(작동중)":"") +"</div>\n";
  ptr +="</div>\n";
  ptr +="<div class=\"progress_fild \" style=\"margin : 0 auto;\">\n";
  ptr +="<span style=\"float:left\">마지막 동작 : " + GetDiffTime(last_time) + "</span>\n";
  ptr +="<span style=\"float:right\">" + String(percent * 25) +"L / 25L</span>\n";
  //ptr +="<span style=\"float:right\">now_level = " + String(now_level) + "</span>\n";
  ptr +="</div>\n";
  ptr +="<div class=\"list-group\" style=\"margin-top: 10%;\">\n";
  
  if(is_err){
    ptr +="<div class=\"list-group-item list-group-item-danger\">시스템 상태 : 오류 발생</div>\n";
    ptr +="<div class=\"list-group-item list-group-item-danger\">배수펌프작동 및 호스연결상태를 점검하고, 수동작동 또는 재부팅을 실시하세요. <br>에러 내용 : " +  ERR_MSG +"</div>\n";
  }
  else{
    ptr +="<div class=\"list-group-item list-group-item-success\">시스템 상태 : 정상</div>\n";  
  }
  ptr +="<div class=\"list-group-item\">시스템 모니터링(현재 : "+ String(now_level) + "cm, 최소 : " + String(MIN_LEVEL) + "cm, 동작 : " + String(RUN_LEVEL) + "cm, 경고 : " + String(WARNING_LEVEL)+ "cm, 최대 : " + String(MAX_LEVEL) + "cm)</div>\n";  

  if(is_run){
    ptr +="<a href=\"manual_stop\" class=\"list-group-item list-group-item-action list-group-item-orimary\">수동 작동 중지</a>\n";  
  }
  else{
    ptr +="<a href=\"manual_run\" class=\"list-group-item list-group-item-action list-group-item-orimary\">수동 작동 시작</a>\n";  
  }
  
  ptr +="<a href=\"/reset\" class=\"list-group-item list-group-item-action list-group-item-orimary\">시스템 재부팅</a>\n";
  ptr +="</body>\n";
  ptr +="</html>\n"; 
  return ptr;
}

String GetDiffTime(unsigned long t){
  String tmp = "";
  unsigned long diff = 0;
  unsigned long now = millis();
  int day=0, hour = 0;
  if(t > now){
    t = 0;
  }
  diff = now - t;
  diff /= 1000; //ms-> s;
  //return String(diff) + "초전"; //임시, 없앨예정.

  if(diff >= 86400){
      day = diff / 86400;
      diff -= (86400*day);
  }
  if(diff >= 3600){
    hour = diff / 3600;
  }
  tmp += (String(day) + "일 " + String(hour) + "시간전");
  return tmp;  
} 


void pump_run(){
  is_run = true;
  run_time = millis();
  digitalWrite(pin_run, HIGH);
  //Serial.println("Pump Start");
}
void pump_stop(){
  is_run = false;
  last_time = millis();
  digitalWrite(pin_run, LOW);
  //Serial.println("Pump Stop");
}

void handle_OnConnect() {
  //Serial.println("Main Page");
  server.send(200, "text/html", SendHTML(is_run, 30));
}

void handle_NotFound(){
  server.send(404, "text/plain", "Not found");
}

void manual_run() {
  //Serial.println("MANUAL_RUN");
  is_err = false;
  ERR_MSG = "";
  digitalWrite(pin_led, LOW);
  noTone(pin_beep);
  pump_run();
  server.send(200, "text/html", SendHTML(is_run, 0));
}
void manual_stop() {
  //Serial.println("MANUAL_STOP");
  digitalWrite(pin_led, HIGH);
  pump_stop();
  server.send(200, "text/html", SendHTML(is_run, 0));
}
void system_reset() {

 String ptr = "<!DOCTYPE html> <html>\n";
  ptr +="<head><meta charset=\"utf-8\">\n";
  ptr +="<meta http-equiv='refresh' content='5;url=/'>\n";
  ptr +="<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0, user-scalable=no\">\n";
  ptr +="<title>자동배수시스템</title>\n";
  ptr +="</head>\n";
  ptr +="<body>\n";
  ptr +="<h3>시스템 재부팅 중... 재부팅이 완료되면 10초 이내로 자동으로 연결됩니다.</h3>";
  ptr +="<h3>자동으로 연결이 안될 경우, <a href=\"/\">여기</a>를 클릭하세요.</h3>";
  ptr +="</body>\n";
  ptr +="</html>\n"; 
  
  //Serial.println("SYSTEM Reset");
  server.send(200, "text/html", ptr);
  delay(500);
  digitalWrite(pin_rst, LOW);
}
float Get_now_level(){
    digitalWrite(pin_trig, LOW);
    digitalWrite(pin_echo, LOW);
    delayMicroseconds(2);
    digitalWrite(pin_trig, HIGH);
    delayMicroseconds(10);
    digitalWrite(pin_trig, LOW);

    unsigned long duration = pulseIn(pin_echo, HIGH); 
    float distance = ((float)(340 * duration) / 10000) / 2;
    
    return distance;
}

MedianFilter<float> medianFilter(10);

void setup() {
  digitalWrite(pin_rst, HIGH);
  digitalWrite(pin_led, HIGH);

  //Serial.begin(115200);
  pinMode(pin_run, OUTPUT);
  pinMode(pin_led, OUTPUT);
  pinMode(pin_rst, OUTPUT);
  pinMode(pin_beep, OUTPUT);
  pinMode(pin_trig, OUTPUT);
  pinMode(pin_echo, INPUT);

  delay(100);
  //Serial.println("Connecting to ");
  //Serial.println(ssid);

  //connect to your local wi-fi network
  WiFi.begin(ssid, password);

  //check wi-fi is connected to wi-fi network
  while (WiFi.status() != WL_CONNECTED) {
    delay(2000);
    //Serial.print(".");
  }
  //Serial.println("");
  //Serial.println("WiFi connected..!");
  //Serial.print("Got IP: ");  Serial.println(WiFi.localIP());

  server.on("/", handle_OnConnect);
  server.on("/manual_run", manual_run);
  server.on("/manual_stop", manual_stop);
  server.on("/reset", system_reset);
  server.onNotFound(handle_NotFound);
  server.begin();
  //Serial.println("HTTP server started");
}

void loop() {
  server.handleClient();
  
  //now_level = medianFilter.AddValue(MAX_LEVEL - Get_now_level());//바닥면을 기준으로 현재 수위를 측정. 센서값이 튀는 경우가 있어 메디안 필터 적용.
  //Serial.println("run : " + String(is_run) + ", err : " + String(is_err) + ", now_level : " + String(now_level));

  if(last_sensing + SENSING_DELAY < millis()){//SENSING_DELAY 간격으로 초음파 센서로 수위 측정.
      now_level = medianFilter.AddValue(MAX_LEVEL - Get_now_level());//바닥면을 기준으로 현재 수위를 측정. 센서값이 튀는 경우가 있어 메디안 필터 적용.
      //Serial.println("run : " + String(is_run) + ", err : " + String(is_err) + ", now_level : " + String(now_level));
      last_sensing = millis();
  }

  if(now_level < 0){//측정 수위가 음수가 나오면 다시 측정함.
      //Serial.println("now_level is minus value : " + String(now_level));
      delay(200);
      return;
  }

  if(now_level > WARNING_LEVEL){//물통의 경고수위를 넘을 때 에러 발생 
    is_err = true;
    ERR_MSG = "최고 수위 초과(측정 수위 : " + String(now_level)+"cm)";
  }
    
  if(now_level >= RUN_LEVEL){//현재 수위가 작동 수위를 넘었을 때 펌프를 가동시킴.
    if(!is_run && !is_err) pump_run();
  }
        
  if(is_run){//작동 중일때
    if(millis() - run_time > TIME_OUT){ //타임아웃일 경우
      if(now_level <= (MIN_LEVEL + RUN_LEVEL)/2){//물이 절반이라도 빠졌다면
          run_time = millis(); //다시 기회를 줌
      }
      else{//물이 절반도 안빠졌다면 에러로 간주
          is_err = true;
          ERR_MSG = "펌프 동작시간 초과(배수가 원활하지 않습니다.)";
      }
    }
  }

  if(now_level <= MIN_LEVEL || is_err){//현재 수위가 최저수위보다 낮거나, 에러 발생시 펌프 정지
    if(is_run) pump_stop();
  }
  
  if(is_err){//에러발생시 LED와 BEEP로 경고.
    //Serial.println("ERROR OCCURE");
    if(before_time + 500 < millis()){
      digitalWrite(pin_led, LOW);
      tone(pin_beep, 400);
    }
    if(before_time + 1000 < millis()){
      before_time = millis();
      noTone(pin_beep);
      digitalWrite(pin_led, HIGH);
    }
 }
   delay(100);
}
