# Intelligent Notification Server(INS)

### 서울과학기술대학교 홈페이지에 올라오는 공지사항을 요약해서 보여주는 프로젝트
- INS 프로젝트란 윈도우 기반에서 작동하던 서울과학기술대학교 공지사항 수신기(Seoultech_Notice 프로젝트)를 웹으로 서비스함으로써 언제 어디서든 쉽게 교내 공지사항을 확인할 수 있도록 하는 프로젝트입니다.
- 학교 메인 홈페이지와 부속 학과 홈페이지 등 50여개의 홈페이지에 실시간으로 업로드 되는 공지사항을 확인할 수 있습니다.
- 초기 버전은 VB.NET과 ASP, MS SQL를 이용하여 윈도우 기반으로 개발하였습니다.
- 이후 JAVA와 PHP, MySQL를 이용하여 라즈베리파이 환경에서 운영할 수 있게 개선하였습니다.
  - 기존에 윈도우 환경에서 리눅스 환경으로 이동하면서 더욱 운영이 편리해짐
  - Java 언어를 배우는 입장에서, 기존에 만든 것을 Java 언어로 다시 만들면서 언어에 익숙해지는 목적이 있음
- 개발 일자 : 2019.05
- 서비스 운영 기간 : 2019.07 ~ 2020.08 (군 입대로 인한 서비스 종료)
- Upgrade Version : [SNUST_Notification_Collector](https://github.com/ehn1225/SNUST_Notification_Collector)

## 기능
- 학교 메인 홈페이지 및 부속 학과 홈페이지에서 최신 게시글을 파싱
- 실시간 날씨 제공(네이버 날씨 파싱)
- 한국인터넷진흥원(KISA) 공지사항 파싱
- 게시글이 삭제될 경우, DB에서도 삭제함
- 5분 주기로 동작

## 실행 화면
- Front-End 웹페이지
  - <img src="https://github.com/ehn1225/Projects/assets/5174517/3a8660f7-90bb-4289-acba-192e05064d04" width="700"/>

- Back-End VB.Net 프로그램(Parser)
  - <img src="https://github.com/ehn1225/Projects/assets/5174517/f38d5d3b-094e-4132-be9e-6aa8d800abc1" width="700"/>

- Back-End 데이터베이스 테이블 구조
  - ```weather``` 날씨 테이블
    - <img src="https://github.com/ehn1225/Projects/assets/5174517/9ee05da1-3308-48cd-ab9d-7cd5925627fc" width="700"/>
  - ```notice``` 게시글 테이블
    - <img src="https://github.com/ehn1225/Projects/assets/5174517/f984bb95-414f-440c-a9a5-277dbfd4be9f" width="700"/>

## 참고자료
[Template Brushed, by Alessio Atzeni](https://www.alessioatzeni.com/blog/brushed-template/)
