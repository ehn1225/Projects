# Intelligent Notification Server(INS)

### 서울과학기술대학교 홈페이지에 올라오는 공지사항을 요약해서 보여주는 프로젝트
- INS 프로젝트란 윈도우 기반에서 작동하던 서울과학기술대학교 공지사항 수신기(Seoultech_Notice 프로젝트)를 웹으로 서비스함으로써 언제 어디서든 쉽게 교내 공지사항과 소식을 접할 수 있도록 하는 프로젝트입니다.
- 학교 메인 홈페이지와 부속 홈페이지 등 50여개의 홈페이지에 실시간으로 업로드 되는 공지사항을 확인할 수 있습니다.
- 초기 버전은 VB.NET과 ASP를 이용하여 윈도우 기반으로 개발하였습니다.
- 이후 JAVA와 PHP를 이용하여 라즈베리파이 환경에서 운영할 수 있게 개선하였습니다.
  - 기존에 윈도우 환경에서 리눅스 환경으로 이동하면서 더욱 운영이 편리해짐
  - Java 언어를 배우는 입장에서, 기존에 만든 것을 Java 언어로 다시 만들면서 언어에 익숙해지는 목적이 있음
- 개발 일자 : 2019.05
- 서비스 운영 기간 : 2019.07 ~ 2020.08 (군 입대로 인한 서비스 종료)

## 기능
- ```URL.txt``` 파일을 읽어 조회할 게시판 목록 로드
- 해당 게시판을 방문하여 당일 올라온 게시글의 게시글번호, 제목, 등록자, 조회수, URL을 파싱
- 파싱한 내용을 DB에 저장
- DB에 저장된 내용을 웹페이지를 통해 사용자에게 제공
- 실시간 날씨 제공(네이버 날씨 파싱)
- 5분 주기로 동작

## 실행 화면
- Front-End 웹페이지
  - <img src="https://github.com/ehn1225/Projects/assets/5174517/3a8660f7-90bb-4289-acba-192e05064d04" width="700"/>

- VB.Net 프로그램
  - <img src="https://github.com/ehn1225/Projects/assets/5174517/f38d5d3b-094e-4132-be9e-6aa8d800abc1" width="700"/>

## 참고자료
[Template Brushed, by Alessio Atzeni](https://www.alessioatzeni.com/blog/brushed-template/)
