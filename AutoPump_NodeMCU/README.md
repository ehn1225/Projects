# Auto Pump - NodeMCU

### 이 프로그램은 NodeMCU를 이용한 보일러 응축수 배출 장치입니다.
- 보일러를 사용하면 응축수가 배출되는데, 응축수를 배수하기 위해 하수관까지 10m길이의 긴 호스로 연결하니 겨울철에 얼어서 막히는 경우가 있었습니다.
- 그래서 큰 통에 응축수를 모으고, 어느 정도 응축수가 모이면 펌프를 이용해 자동으로 배출하는 프로젝트입니다.
- 초음파 센서로 수위를 모니터링하며, 특정 수위가 넘을 경우 릴레이를 이용하여 전기 펌프를 동작시킴으로써 응축수를 배출합니다.
- 웹페이지에서 펌프를 수동동작/수동정지하거나 수위를 모니터링할 수 있습니다.
- 초음파 센서의 측정 오차로 노이즈가 들어오는 경우가 발생하여 Median Filter 사용
- 개발 일자 : 2018.07
 
 ## Images
<div>
    ![IMG_20220405_234418](https://github.com/ehn1225/Arduino_Codes/assets/5174517/e22a0d72-441a-480d-8ff5-cd558ac58f27)
    ![IMG_20220405_230748](https://github.com/ehn1225/Arduino_Codes/assets/5174517/b830cec9-ef51-4328-aee5-e215d8564234)
    ![IMG_20220405_234405](https://github.com/ehn1225/Arduino_Codes/assets/5174517/94e36893-b0e5-4090-828d-d72e54dd2d10)
</div>