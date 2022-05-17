<!-- #include virtual="common.asp" -->
<!DOCTYPE html>
<html>
    <head>
        <title>ITS | 서울과학기술대학교 공지사항 수신기</title>
        <meta charset="utf-8">
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta http-equiv="refresh" content="30">
        <link href="_include/css/main.css" rel="stylesheet" type="text/css">
        <link href="_include/css/weather.css" rel="stylesheet" type="text/css">
        <link href='http://fonts.googleapis.com/css?family=Titillium+Web:400,200,200italic,300,300italic,400italic,600,600italic,700,700italic,900' rel='stylesheet' type='text/css'>
        <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
        <script src="_include/js/main.js"></script>
    </head>
    <body>
        <header>
            <div class="mobile_nav">        
                <div id="logo">
                    <a href="#weather">ITS</a>
                </div>
                <nav>
                    <div id="menu"></div>
                    <ul id="menu_nav">
                        <li><a href="#weather">Home</a></li>
                        <li><a href="#notice">Notice</a></li>
                        <li><a href="#info">Info</a></li>
                    </ul> 
                </nav>              
            </div>
        </header>

        <section id="weather" class="page">
            <%
                set weather=server.createobject("ADODB.recordset")
                q="select * from weather;"
                weather.open q, cnn, 3, 3
            %>
            <div class="container">
                <div class="wt_status">
                    <div class="status"> 
                        <div class="wt_img">
                            <span class="<% =weather("img")%>"></span>
                        </div>
                        <div class="wt_text">
                            <strong><em class="figure degree_code"><% =weather("temperature")%></em></strong>      
                            <span class="chill_temp"><span class="min"><% =weather("min")%>˚</span><span class="slash">/</span><span class="max"><% =weather("max")%>˚</span></span></span>                         
                        </div>
                        <div class="wt_summary">
                            <p class="main"><% =weather("cast_txt")%></p>
                            <span class="link_dust">미세먼지 <em class="figure <% =weather("dustlv")%>"><% =weather("dust")%></em></span><br>
                            <span class="link_dust">초미세먼지 <em class="figure <% =weather("microdustlv")%>"><% =weather("microdust")%></em></span>
                        </div> 
                    </div>
                    <div class="status_list">
                        <ul>
                            <li><strong><% if instr(weather("ultraviolet"), "mm") = 0 then response.write "자외선" else response.write "시간당 강수량" end if %></strong><span><% =weather("ultraviolet")%></span></li>
                            <li><strong>오존지수</strong><span><font class="<% =weather("ozonelv")%>"><% =weather("ozone")%></font></span></li>
                            <li><strong>한강수온</strong><span><% =weather("hanriver")%>℃</span></li>
                        </ul> 
                    </div>
                </div>
            </div>  
        </section>

        <div id="notice" class="page-alternate">
            <div class="container">
                <div class="row">
                    <div class="title-page">
                        <h2 class="title">TODAY'S NOTICE</h2>
                        <h3 class="title-description"><% =weather("updatetime")%></h3>
                    </div>
                </div>
                <div class="row">
                    <%
                        set rs=server.createobject("ADODB.recordset")
                        q="select * from notice;"
                        rs.open q, cnn, 3, 3
                        count = rs.recordcount
                        if count=0 then
                            response.write "<h3 align=center>오늘의 새 공지사항이 없습니다.</h3>"
                        end if
                        for i = 1 to count
                    %>
                    <div class="profile">
                        <h3 class="profile-name"><% =rs("category") %><% if rs("num")=0 then
                                response.write " - <font id='font_notice'>Notice</font>" 
                            end if %></h3>
                        <p class="profile-description">
                            <a href="<% =rs("URL") %>" target="_blank"><% =rs("title") %></a><br>
                            <small><% =rs("uploader") %></small>
                        </p>
                    </div>
                    <%
                        rs.movenext
                        next
                    %>     
                </div>
            </div>
        </div>

        <div id="info" class="page">
            <div class="container">
                <div class="title-page">
                    <h2 class="title">User Guide</h2>
                    <h3 class="title-description">사용안내</h3>
                </div>
                    <ul class="nav-tabs" id="tab">
                        <li class="active"><a>Info</a></li>
                        <li><a>Dev</a></li>
                        <li><a>Source</a></li>  
                    </ul>
                    <div class="tab-content" id="tab_con">
                        <div class="tab-pane active">
                            이 홈페이지는 서울과학기술대학교의 모든 공지사항을 한번에 보고자 제작되었습니다.<br>
                            게시글 및 날씨 정보는 5분 간격으로 재갱신 됩니다.<br>
                            더 많은 게시글을 보시려면, 하단의 ITS를 방문하여 공지사항수신기 프로그램을 이용하시기 바랍니다.<br>
                            [이 페이지는 모바일 전용 입니다.]
                        </div>
                        <div class="tab-pane">
                            개발 : 컴퓨터공학과 동아리 ITS<br>
                            서울특별시 노원구 공릉로 232 서울과학기술대학교 미래관 319호 ITS<br>
                            <2019.06.18> 서비스 시작<br>
                            <2019.06.20> 소스 최적화 및 검색 범위 전교로 확대<br>
                            <2019.07.02> 소스 최적화(140KB 감소)<br>
                            <2019.10.25> 가독성 향상 및 DB개선<br>
                        </div>
                        <div class="tab-pane">
                            <p>네이버 날씨 (https://weather.naver.com/)</p>
                            <p>디자인 : brushed (http://www.alessioatzeni.com/blog/brushed-template/)</p>
                            <p>서울과학기술대학교 (http://www.seoultech.ac.kr/index.jsp)</p>
                            퐁당 (http://hangang.dkserver.wo.tc)
                        </div>  
                    </div>
                <div class="links">
                    <a class="button" href="https://its319.tistory.com/"title="ITS 블로그" target="_blank">ITS</a>
                    <a class="button" href="http://www.seoultech.ac.kr/index.jsp"title="학교 홈페이지" target="_blank">SEOULTECH</a>
                </div>
            </div>
        </div>
        </div>
           
        <footer>
            <p class="credits">
                서울과학기술대학교 공지사항 수신기 for Web<br>
                서울시 노원구 공릉로 232 서울과학기술대학교 미래관 319호 ITS<br>
            </p>
        </footer>
    </body>
</html>