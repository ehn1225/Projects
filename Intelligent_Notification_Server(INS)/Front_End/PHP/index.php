<!DOCTYPE html>
<html>
    <head>
        <title>ITS | 서울과학기술대학교 공지사항 수신기</title>
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta http-equiv="refresh" content="60">
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
                        <li><a href="#notice">SEOULTECH NOTICE</a></li>
                        <li><a href="#kisa">KISA Notice</a></li>
                        <li><a href="#info">Info</a></li>
                    </ul> 
                </nav>              
            </div>
        </header>

        <section id="weather" class="page">
	<?php
		$conn = mysqli_connect('localhost', 'notice', '1234', 'NOTICE');
		$sql = "SELECT * FROM weather";
		$result = mysqli_query($conn, $sql);
		$info=mysqli_fetch_assoc($result);
        ?>
		<div class="container">
				<div class="wt_status">
                    <div class="status"> 
                        <div class="wt_img">
                            <span class="<?php echo $info['img']; ?>"></span>
                        </div>
                        <div class="wt_text">
                            <strong><em class="figure degree_code"><?php echo $info['temperature']; ?></em></strong>      
                            <span class="chill_temp"><span class="min"><?php echo $info['min']; ?>˚</span><span class="slash">/</span><span class="max"><?php echo $info['max']; ?>˚</span></span></span>
                        </div>
                        <div class="wt_summary">
                            <p class="main"><?php echo $info['cast_txt']; ?></p>
                            <span class="link_dust">미세먼지 <em class="figure <?php echo $info['dustlv']; ?>"><?php echo $info['dust']; ?></em></span><br>
                            <span class="link_dust">초미세먼지 <em class="figure <?php echo $info['microdustlv'] ?>"><?php echo $info['microdust'] ?></em></span>
                        </div> 
                    </div>
                    <div class="status_list">
                        <ul>
							<li><strong><?php if(strcmp($info['uvclass'],"indicator")==0){echo "자외선";}else{echo "시간당 강수량";} ?></strong><?php echo $info['uv'];?></li>
                            <li><strong>오존지수</strong><span><font class="<?php echo $info['ozonelv']; ?>"><?php echo $info['ozone']; ?></font></span></li>
                            <li><strong>한강수온</strong><span><?php echo $info['hanriver']; ?> ℃</span></li>
                        </ul> 
                    </div>
                </div>
            </div>  
        </section>

        <div id="notice" class="page">
            <div class="container">
                <div class="row">
                    <div class="title-page">
                        <h2 class="title">TODAY'S NOTICE</h2>
		<?php
			$sql = "SELECT time FROM updatetime where name = 'notice'";
			$result = mysqli_query($conn, $sql);
			$info=mysqli_fetch_assoc($result);
        	?>
				<h3 class="title-description"><?php echo $info['time']; ?></h3>
                    </div>
                </div>
                <div class="row">
 		<?php
                        $sql = "SELECT * FROM notice";
                        $result = mysqli_query($conn, $sql);
                        $count = mysqli_num_rows($result);
                        if($count == 0){
                            echo "			<h3 align=center>오늘의 새 공지사항이 없습니다.</h3>";}
		?>

 		<?php
                        $sql = "SELECT * FROM notice where ismain = '5' order by category, num";
                        $result = mysqli_query($conn, $sql);
			while($info=mysqli_fetch_array($result)){
		?>
<div class="profile">
                        <h3 class="profile-name"><?php echo $info['category']; if($info['num'] == 0){
                                 echo " - <font id='font_notice'>Notice</font>";} ?></h3>
                        <p class="profile-description">
                            <a href="<?php echo $info['URL']; ?>" target="_blank"><?php echo $info['title']; ?></a><br>
                            <small><?php echo $info['uploader']; ?></small>
                        </p>
                    </div>
                    <?php
			}
                    ?>     
 		<?php
                        $sql = "SELECT * FROM notice where ismain = '3' order by category, num";
                        $result = mysqli_query($conn, $sql);
			while($info=mysqli_fetch_array($result)){
		?>
<div class="profile">
                        <h3 class="profile-name"><?php echo $info['category']; if($info['num'] == 0){
                                 echo " - <font id='font_notice'>Notice</font>";} ?></h3>
                        <p class="profile-description">
                            <a href="<?php echo $info['URL']; ?>" target="_blank"><?php echo $info['title']; ?></a><br>
                            <small><?php echo $info['uploader']; ?></small>
                        </p>
                    </div>
                    <?php
			}
                    ?>     
                </div>
            </div>
        </div>

		<div id="kisa" class="page-alternate">
            <div class="container">
                <div class="row">
                    <div class="title-page">
                        <h2 class="title">KISA NOTICE</h2>
		<?php
			$sql = "SELECT time FROM updatetime where name = 'kisa'";
                        $result = mysqli_query($conn, $sql);
                        $info=mysqli_fetch_assoc($result);
                ?>
				<h3 class="title-description"><?php echo $info['time']; ?></h3>
                    </div>
                </div>
                <div class="row">
                <?php
                        $sql = "SELECT * FROM kisa";
                        $result = mysqli_query($conn, $sql);
                        $count = mysqli_num_rows($result);
                        if($count == 0){
                            echo "	<h3 align=center>오늘의 새 공지사항이 없습니다.</h3>";}
                        while($info=mysqli_fetch_array($result)){
		?>
                    <div class="profile">
                        <h3 class="profile-name"><?php echo $info['category']; ?></h3>
                        <p class="profile-description">
                            <a href="<?php echo $info['URL']; ?>" target="_blank"><?php echo $info['title']; ?></a><br>
                        </p>
                    </div>
                    <?php
                        }
                        mysqli_close($conn);
                    ?>

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
                            게시글 및 날씨 정보는 5분 간격으로 재갱신 됩니다.<br>
                            더 많은 공지사항을  보려면, 공지사항수신기 프로그램을 이용하시기 바랍니다.<br>
                            이 페이지는 모바일에 최적화되었습니다.
                        </div>
                        <div class="tab-pane">
                            개발 : 서울과학기술대학교 컴퓨터공학과 동아리 ITS<br>
                            <2019.06.18> 서비스 시작<br>
                            <2019.06.20> 소스 최적화 및 검색 범위 전교로 확대<br>
                            <2019.07.02> 소스 최적화<br>
                            <2019.10.25> 가독성 향상 및 DB개선<br>
                            <2020.01.02> 서버 이전 및 KISA추가<br>
                            <2020.03.16> 일부 버그 수정 및 최적화<br>
                            <2020.05.12> DB 관련버그수정<br>
                        </div>
                        <div class="tab-pane">
                            <p>네이버 날씨 (https://weather.naver.com/)</p>
                            <p>디자인 : brushed (http://www.alessioatzeni.com/blog/brushed-template/)</p>
                            <p>서울과학기술대학교 (http://www.seoultech.ac.kr/index.jsp)</p>
                            <p>한국인터넷진흥원 (https://www.kisa.or.kr/notice/notice_List.jsp)</p>
                            퐁당 (http://hangang.dkserver.wo.tc)
                        </div>  
                    </div>
                <div class="links">
                    <a class="button" href="https://its319.tistory.com/"title="ITS 블로그" target="_blank">ITS</a>
                    <a class="button" href="http://www.seoultech.ac.kr/index.jsp"title="학교 홈페이지" target="_blank">SEOULTECH</a>
                </div>
            </div>
        </div>
           
        <footer>
            <p class="credits">
                서울과학기술대학교 공지사항 수신기 for Web<br>
                서울시 노원구 공릉로 232 서울과학기술대학교 미래관 319호 ITS<br>
				[ LYC | INS Project ]
            </p>
        </footer>
    </body>
</html>
