# MicroDust and Temperature Monitor

### 현재 대기중의 온도, 습도, PM10, PM2.5 농도를 LCD를 통해 보여줍니다.
- 센서를 통해 현재 대기중의 온도, 습도, PM10, PM2.5 농도를 측정하고, 결과를 LCD와 시리얼 모니터에 출력합니다.
- DTH11 : 온도, 습도 센서
- GP2Y10 : 미세먼지 센서
- I2C 1602 Serial LCD Module : LCD 모듈
- 개발 일자 : 2018.07

## 배선 연결 방법
- LCD
  - SDA -> A4
  - SCL -> A5
  - VCC -> +5v
  - GND -> GND

- 온도센서
  - VCC -> +5v
  - GND -> GND
  - OUT -> D4

- 미세먼지센서
  - 아래 Reference 블로그 참고

## Images
<img src="https://github.com/ehn1225/Projects/assets/5174517/43ad7e83-2cca-4817-8af8-141076597695" width="700"/>

## Reference
[온습도 센서 DTH11](http://deneb21.tistory.com/207)
[미세먼지센서](https://m.blog.naver.com/dokkosam/221038484240)