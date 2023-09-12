# Auto Pump - NodeMCU

### 이 프로그램은 NodeMCU를 이용한 보일러 응축수 배출 장치입니다.
- 보일러를 사용하면 응축수가 배출되는데, 응축수를 배수하기 위해 하수관까지 10m길이의 긴 호스로 연결하니 겨울철에 얼어서 막히는 경우가 있었습니다. 이를 해결하기 위해 우선 큰 통에 응축수를 모으고, 어느 정도 응축수가 모이면 펌프를 이용해 자동으로 배출하는 프로젝트입니다.
- 초음파 센서로 수위를 모니터링하며, 특정 수위가 넘을 경우 릴레이를 이용하여 전기 펌프를 동작시킴으로써 응축수를 배출합니다.
  - 초음파 센서의 측정 오차로 노이즈가 들어오는 경우가 발생하여 Median Filter를 적용
- 웹페이지에서 펌프를 수동동작/수동정지하거나 수위를 모니터링할 수 있습니다.
- 펌프를 동작시켰음에도 수위가 줄어들지 않을 경우, 부저와 적색 LED를 통해 알려줍니다.
- 개발 일자 : 2022.04

## Images
<img src="https://github.com/ehn1225/Projects/assets/5174517/9ed4ba65-2c2c-43e4-95d0-e9320f31e9bb" width="700"/>

## Reference
[MedianFilterLib](https://www.arduino.cc/reference/en/libraries/medianfilterlib/)
