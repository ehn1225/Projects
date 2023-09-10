#include <LiquidCrystal_I2C.h>
#include <Wire.h>
LiquidCrystal_I2C lcd(0x3F, 16, 2);  // I2C LCD 객체 선언
#include <DHT11.h>

int temppin=4; // 온도센서 핀
int change = 0;
DHT11 dht11(temppin); 
int dustPin = A0;
float dustVal = 0;
float dustDensityug=0;
float voMeasured = 0;
float calcVoltage = 0;

int ledPower = 12;
float offTime = 9680;

void setup(){
	Serial.begin(9600);
	pinMode(ledPower,OUTPUT);
	pinMode(4, OUTPUT);
	lcd.begin(); // lcd를 사용을 시작합니다.
	lcd.backlight(); // backlight를 On 시킵니다.
	//lcd.print("Hello, world!"); // 화면에 Hello, world!를 출력합니다.
}

void loop(){
	// ledPower is any digital pin on the arduino connected to Pin 3 on the sensor
	digitalWrite(ledPower, LOW); // power on the LED
	delayMicroseconds(280);
	dustVal=analogRead(dustPin); // read the dust value via pin 5 on the sensor
	calcVoltage = dustVal * (5.0 / 1024); 
	delayMicroseconds(40);
	digitalWrite(ledPower, HIGH); // turn the LED off
	delayMicroseconds(offTime);

	delay(5000); //미세먼지 센싱 주기

	dustDensityug = (0.17 * calcVoltage - 0.1)*1000; 
	Serial.print("Dust Density [ug/m3]: ");
	Serial.println(dustDensityug);

	int err;
	float temp, humi;
	if((err=dht11.read(humi, temp))==0)
	{
		Serial.print("Temp : ");
		Serial.print(temp);
		Serial.print("℃ ");
		Serial.print("Dust : ");
		Serial.print(humi);
		Serial.print("％");
		Serial.println();

		if(change){
			lcd.clear();
			lcd.setCursor(2,0);
			lcd.print("Temp : "); 
			lcd.print(temp); 
			lcd.setCursor(2,1);
			lcd.print("Humi : ");
			lcd.print(humi);
			change = 0; 
		}
		else
		{
			lcd.clear();
			lcd.setCursor(2,0);
			lcd.print("Dust Density"); 
			lcd.setCursor(2,1);
			lcd.print(dustDensityug); 
			lcd.print("[ug/m3]"); 
			change = 1; 
		}
	}
	else
	{
		Serial.print("Error No :");
		Serial.print(err);
		Serial.println();    
	}

}
