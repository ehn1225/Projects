//2022-11-25 아두이노 나노 워터펌프
unsigned long last_time = 0; //마지막으로 동작한 시각
unsigned long run_time = 0;  //펌프가 작동 시작한 시각
unsigned long before_time = 0; //ERR 표시용

boolean is_run = false; //펌프 동작 여부
boolean is_err = false; //에러 발생 여부

int pin_run = 5;      //릴레이
int pin_beep = 4;    //부저
int pin_lowSensor = 2;
int pin_highSensor = 3;

void pump_run() {
  is_run = true;
  run_time = millis();
  digitalWrite(pin_run, HIGH);
  //Serial.println("Pump Start");
}
void pump_stop() {
  is_run = false;
  last_time = millis();
  digitalWrite(pin_run, LOW);
  //Serial.println("Pump Stop");
}

void setup() {
  //Serial.begin(115200);
  pinMode(pin_run, OUTPUT);
  pinMode(pin_beep, OUTPUT);
  pinMode(pin_lowSensor, INPUT_PULLUP);
  pinMode(pin_highSensor, INPUT_PULLUP);

  delay(100);
}

void loop() {
  if (digitalRead(pin_highSensor) == LOW && digitalRead(pin_lowSensor) == LOW) {
    if (!is_run) pump_run();
  }

  if (is_run) { //작동 중일때
    if (millis() - run_time > 180000) { //타임아웃일 경우
      digitalWrite(pin_run, LOW);
      is_err = true;
    }
  }

  if (digitalRead(pin_lowSensor) == HIGH) { //수위가 최저 수위일 경우
    if (is_run) pump_stop();
  }

  if (is_err) { //에러발생시 LED와 BEEP로 경고.
    //Serial.println("ERROR OCCURE");
    if (before_time + 500 < millis()) {
      tone(pin_beep, 400);
    }
    if (before_time + 1000 < millis()) {
      before_time = millis();
      noTone(pin_beep);
    }
  }
  delay(100);
}
