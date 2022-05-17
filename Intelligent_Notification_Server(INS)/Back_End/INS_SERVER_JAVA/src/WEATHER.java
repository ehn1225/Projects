import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import org.jsoup.Jsoup;
import org.jsoup.nodes.Document;
import org.jsoup.select.Elements;

public class WEATHER {
	String img, cast_txt, uv, uvclass, dust, dustlv, microdust, microdustlv, ozone, ozonelv;
	int temperature, min, max;
    double hanriver;
    String url = "https://search.naver.com/search.naver?sm=top_hty&fbm=1&ie=utf8&query=%EA%B3%B5%EB%A6%89+%EB%82%A0%EC%94%A8";
    void Getweather() {
        try {
        	Document doc = Jsoup.connect(url).get();
        	Elements body = doc.select("div[class=main_info]");
        	temperature = Integer.parseInt(body.select("span[class=todaytemp]").first().text()); //현재온도
        	img = (body.select("div[class=main_info]").select("span").first().attr("class")); //img
        	cast_txt = (body.select("p[class=cast_txt]").first().text()); //캐스트텍스트
        	min = Integer.parseInt(body.select("span[class=num]").get(0).text()); //최저온도
        	max = Integer.parseInt(body.select("span[class=num]").get(1).text()); //최고온도
        	uvclass= body.select("ul[class=info_list]").select("li").get(2).select("span").attr("class"); //클래스 식별
        	if(uvclass.compareTo("indicator") == 0) { //참이면 자외선
            	uv = body.select("span[class=indicator]").select("span").get(0).select("span").get(1).toString(); //자외선
        	}else {
        		uv = body.select("span[class=rainfall]").select("em").toString();
        	}
        	uvclass= body.select("ul[class=info_list]").select("li").get(2).select("span").attr("class"); //클래스 식별
        	body = doc.select("div[class=sub_info]");
        	dust= (body.select("dd").get(0).text()); //미세먼지
        	dustlv = (body.select("dd").get(0).attr("class")); //미세먼지 레벨
        	microdust = (body.select("dd").get(1).text()); //초미세먼지
        	microdustlv = (body.select("dd").get(1).attr("class")); //초미세먼지 레벨
        	ozone = (body.select("span[class=num]").get(2).text()); //오존
        	ozonelv = (body.select("dd").get(2).attr("class")); //오존 레벨
        	doc = Jsoup.connect("http://hangang.dkserver.wo.tc/").get();
        	hanriver = Double.parseDouble(doc.text().split(":\"")[2].split("\",")[0]); //한강수온
    	}
    	catch(Exception e){
    		MANAGER.Logwriter("WEATHER::Getweather", "<Exception> " + e);
    		System.out.println(e);
    	}
    }
    
    void Upload() {
		try {
			Class.forName("com.mysql.jdbc.Driver");
			Connection conn;
			conn = DriverManager.getConnection("jdbc:mysql://"+ MAIN.DBADDR, MAIN.DBID,MAIN.DBPW);
	        java.sql.Statement stmt = conn.createStatement();
			stmt.execute("TRUNCATE TABLE weather");
			stmt.close();
			PreparedStatement pstmt = null;
	        String sql = "insert into weather values(?,?,?,?,?,?,?,?,?,?,?,?,?,?);";
		
			pstmt = conn.prepareStatement(sql);
			pstmt.setInt(1,temperature);
			pstmt.setString(2, img);
			pstmt.setInt(3, min);
			pstmt.setInt(4, max);
			pstmt.setString(5, cast_txt);
			pstmt.setString(6, uv);
			pstmt.setString(7, uvclass);
			pstmt.setString(8, dust);
			pstmt.setString(9, dustlv);
			pstmt.setString(10, microdust);
			pstmt.setString(11, microdustlv);
			pstmt.setString(12, ozone);
			pstmt.setString(13, ozonelv);
			pstmt.setDouble(14, hanriver);
			pstmt.executeUpdate();
			if (pstmt != null && !pstmt.isClosed())
                 pstmt.close();
		}
	    catch (ClassNotFoundException e) {
	    	MANAGER.Logwriter("WEATHER::Upload", "<ClassNotFoundException>");
	        System.out.println(e);
	    }
		catch (SQLException e) {
	    	MANAGER.Logwriter("WEATHER::Upload", "<SQLException>");
	        System.out.println(e);
        }
		catch (Exception e) {
			MANAGER.Logwriter("WEATHER::Upload", "<Exception>");
			System.out.println(e);
		}
	} 
    void Printweather() {
    	MANAGER.Logwriter("WEATHER::Printweather", "temperature : " + temperature);
    	MANAGER.Logwriter("WEATHER::Printweather", "img : " + img);
    	MANAGER.Logwriter("WEATHER::Printweather", "min : " + min);
    	MANAGER.Logwriter("WEATHER::Printweather", "max : " + max);
    	MANAGER.Logwriter("WEATHER::Printweather", "cast_txt : " + cast_txt);
    	MANAGER.Logwriter("WEATHER::Printweather", "uv : " + uv );
    	MANAGER.Logwriter("WEATHER::Printweather", "uvclass : " + uvclass);
    	MANAGER.Logwriter("WEATHER::Printweather", "dust : " + dust);
    	MANAGER.Logwriter("WEATHER::Printweather", "dustlv : " + dustlv);
    	MANAGER.Logwriter("WEATHER::Printweather", "microdust : " + microdust);
    	MANAGER.Logwriter("WEATHER::Printweather", "microdustlv : " + microdustlv);
    	MANAGER.Logwriter("WEATHER::Printweather", "ozone : " + ozone);
    	MANAGER.Logwriter("WEATHER::Printweather", "ozonelv : " + ozonelv);
    	MANAGER.Logwriter("WEATHER::Printweather", "hanriver : " + hanriver);
    }
}
