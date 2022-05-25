#include <LowPower.h>

//Develop Ver. 180728

#define MAX 2^32-1
int Watersenser_pin = A2;      //수위센서
int Speaker_pin = 2; //부저
int LED_pin = 3; // 에러 led
int Swich_pin = 4; //수동 스위치
int Pump_pin = 5; //릴레이
int Runtime = 3000; //작동시간(1s = 1000)
int Water_depth(void){return analogRead(Watersenser_pin);}
unsigned long Pre_Time = 0;

void PUMP(int RunTime){//펌프에 RunTime만큼 전원을 인가함.
   digitalWrite(Pump_pin, HIGH);
   delay(RunTime);
   digitalWrite(Pump_pin, LOW);
  }

unsigned long Compare(unsigned long now, unsigned long prev)
{
  if (now>prev) return (now-prev);
  else return (((MAX-prev)+now+1));
}

void setup() {
  pinMode(LED_pin, OUTPUT); 
  pinMode(Pump_pin, OUTPUT);
  pinMode(Swich_pin, INPUT_PULLUP);
}

void loop(){
  int Depth_of_water = Water_depth();
  unsigned long NowTime = millis();

  if(Depth_of_water >= 300){//수위감지센서의 아날로그 값이 300 이상일 경우(물이 닿을 경우)
    if(Compare(NowTime, Pre_Time) >= Runtime * 2 && digitalRead(LED_pin) == LOW){//작동이 연달아 되지 않고 에러상태가 아닐 때
      PUMP(Runtime);
      Pre_Time = NowTime;}
     else{digitalWrite(LED_pin, HIGH);}//에러발생
   }
   
    if(digitalRead(LED_pin) == HIGH){//에러가 발생할 경우 LED를 깜빡이며 부저로 알림
        digitalWrite(LED_pin, LOW);
        delay(1000);
        digitalWrite(LED_pin, HIGH);
        tone(Speaker_pin,750,500);
        if(Depth_of_water == 0){ //오류 중  수위감지센서에서 물이 없어진다면 오류에서 벗어남
          delay(1000);
          digitalWrite(LED_pin, LOW);}
        }
  
    if(digitalRead(Swich_pin) == LOW){ //수동조작 버튼으로 펌프 작동
        digitalWrite(LED_pin, LOW);
        PUMP(Runtime);}  //수동조작
        
delay(1000);
}

