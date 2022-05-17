import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.util.Iterator;
import java.util.Vector;

import org.jsoup.Jsoup;
import org.jsoup.nodes.Document;
import org.jsoup.select.Elements;

public class KISA {
	Vector <ITEM> itemlist= new Vector<ITEM>();

	void Load(){
		try {
			Document doc = Jsoup.connect("https://www.kisa.or.kr/notice/notice_List.jsp").timeout(1000).validateTLSCertificates(false).get();
			Makeitem(doc.select("tbody").select("tr"), "공지사항");
			doc = Jsoup.connect("https://www.kisa.or.kr/notice/press_List.jsp").timeout(1000).validateTLSCertificates(false).get();
			Makeitem(doc.select("tbody").select("tr"), "보도자료");
		}
	 	catch(Exception e){
			MANAGER.Logwriter("KISA::Load", "<Exception> " + e);
			System.out.println(e);
	 	}
	}
	void Makeitem(Elements body, String category){
		ITEM item;
		try {
			int count = body.size();
			for(int i = 0; i < count; i++) {
				Elements temp = body.get(i).select("td");
				if (MANAGER.date.compareTo(temp.get(2).text()) != 0) continue; //당일이 아니라면 스킵(!= : 스킵)
				String number = temp.get(0).text();
				String itemurl = temp.get(1).select("a").attr("abs:href"); //abs:절대주소
				String title = temp.get(1).select("a").text();
				item = new ITEM(number, title, category,itemurl);
				itemlist.add(item);
			}
		}
 		catch(Exception e){
			MANAGER.Logwriter("KISA::Makeitem", "<Exception> " + e);
			System.out.println(e);
 		}
	}
	
	void Upload() {
		try {
			Class.forName("com.mysql.jdbc.Driver");
			Connection conn;
			conn = DriverManager.getConnection("jdbc:mysql://"+ MAIN.DBADDR, MAIN.DBID, MAIN.DBPW);
			
	        java.sql.Statement stmt = conn.createStatement();
			stmt.execute("TRUNCATE TABLE kisa");
			PreparedStatement pstmt = null;
	        String sql = "insert into kisa values(?,?,?,?,?);";
			
			int i = 1;
			Iterator<ITEM> seek = itemlist.iterator();
			while(seek.hasNext()) {
				ITEM item = seek.next();
				 pstmt = conn.prepareStatement(sql);
			     pstmt.setInt(1, i++);
			     pstmt.setString(2, item.uploader);
			     pstmt.setInt(3, item.num);
			     pstmt.setString(4, item.title);
			     pstmt.setString(5, item.url);
			     pstmt.executeUpdate();
			}
			stmt.executeUpdate("UPDATE updatetime SET time = '" + MANAGER.Gettime() + "' WHERE name = 'kisa'");		
			stmt.close();
			itemlist.clear();
			if (pstmt != null && !pstmt.isClosed())
                 pstmt.close();
		}
	    catch (ClassNotFoundException e) {
	    	MANAGER.Logwriter("KISA::Upload", "<ClassNotFoundException>"+e);
	        System.out.println(e);
	    }
		catch (SQLException e) {
	    	MANAGER.Logwriter("KISA::Upload", "<SQLException>"+e);
        }
		catch (Exception e) {
			MANAGER.Logwriter("KISA::Upload", "<Exception>"+e);
			System.out.println(e);
		}
	}
}
