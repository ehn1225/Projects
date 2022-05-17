
public class HOMEPAGE {
    String URL="";
    String bnum="";
	short ismain = 3; //Main : 5, Sub : 3
	String category = "";
	HOMEPAGE(String URL){
		this.URL = URL;
		ismain = (URL.split("www.seoultech.ac.kr/service/info/").length - 1) == 1?(short)5:3; //메인홈페이지인지 검사, Main : 5, Sub : 3
	}
}
