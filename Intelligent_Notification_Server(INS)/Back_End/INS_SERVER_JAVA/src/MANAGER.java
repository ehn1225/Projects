import java.io.*;
import java.sql.Connection;
import java.sql.DriverManager;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Iterator;
import java.util.Vector;

import org.jsoup.Jsoup;
import org.jsoup.nodes.Document;
import org.jsoup.select.Elements;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

public class MANAGER {
	int total = 0;
	HOMEPAGE pagelist []; //페이지 배열
	static String date = "";
	static WEATHER weather;
	static KISA kisa;
	Vector <ITEM> itemlist= new Vector<ITEM>();

	void Getnotice() {
		try {
			Class.forName("com.mysql.jdbc.Driver");
			Connection conn;
			conn = DriverManager.getConnection("jdbc:mysql://"+ MAIN.DBADDR, MAIN.DBID,MAIN.DBPW);
	        java.sql.Statement stmt = conn.createStatement();			
			for(HOMEPAGE page : pagelist) {
				itemlist.clear();
				HOMEPAGE temp = page;
				int pagenum = 2;
				while(Makeitem(temp)) {
					page.bnum = itemlist.get(0).url.split("&bidx")[0].split("&bnum=")[1];
					String suburl = page.URL + "?bidx=" + page.bnum + "&bnum=" + page.bnum + "&allboard=false&page=" + pagenum++;
					temp = new HOMEPAGE(suburl);
					if(pagenum > 5) {Logwriter("MANAGER::Getnotice", "pagenum이 5를 초과함!"); break;};
				}
			if(itemlist.size() > 0) Upload(page);
			//if(itemlist.size() > 0) Print(page);

			}
			stmt.executeUpdate("UPDATE updatetime SET time = '" + MANAGER.Gettime() + "' WHERE name = 'notice'");		
			stmt.close();
		}
		catch (ClassNotFoundException e) {
		  	Logwriter("MANAGER::Getnotice", "<ClassNotFoundException>");
		    System.out.println(e);
		}
		catch (SQLException e) {
			Logwriter("MANAGER::Getnotice", "<SQLException>");
		    System.out.println(e);
	    }
		catch (java.lang.ArrayIndexOutOfBoundsException e) {
			Logwriter("MANAGER::Getnotice", "<ArrayIndexOutOfBoundsException>");
		    System.out.println(e + "잠긴 글");
		}
		catch (Exception e) {
			Logwriter("MANAGER::Getnotice", "<Exception>");
			System.out.println(e);
		}
		
	}
	void Print(HOMEPAGE page){		
		Iterator<ITEM> seek = itemlist.iterator();
		ITEM item = null;
		while(seek.hasNext()){
			item = seek.next();
			MANAGER.Logwriter("HOMEPAGE::Print", page.category + " | " + item.num + " | " + item.title + " | " + item.uploader + " | " + item.url);
		}
	}
	
	boolean Makeitem(HOMEPAGE page) {
		try {
			Document doc = Jsoup.connect(page.URL).get();
			Elements body = doc.select(".body_tr");
			int count = body.size();
			ITEM item;
			for(int i = 0; i < count; i++) {
				Elements temp = body.get(i).select("td");
				if (MANAGER.date.compareTo(temp.get(4).text()) != 0) continue; //당일이 아니라면 스킵(!= : 스킵)
				String number = temp.get(0).text();
				String itemurl = temp.get(1).select("a").attr("href"); //abs:절대주소
				String title = temp.get(1).text();
				String uploader = temp.get(page.ismain).text();
				if(page.category == "" && number.length() == 0)	continue; //다음페이지이고, 공지일 경우 스킵
				item = new ITEM(number,title,uploader,itemurl);
				itemlist.add(item);
				if(i == count -1) return true; //마지막 게시물이 당일일 경우 다음 페이지를 읽어옵니다.
			}
		}
		catch(IOException e){
 			MANAGER.Logwriter("HOMEPAGE::Load", "<Exception> " + page.category +"("+ page.URL + ")" + e);
 		}
 		catch(Exception e){
 			MANAGER.Logwriter("HOMEPAGE::Load", "<Exception> " + page.category +"("+page.URL + ")" + e);
 		}
     	return false;     	
     }
	void truncate() {
		try{
			Class.forName("com.mysql.jdbc.Driver");
			Connection conn;
			conn = DriverManager.getConnection("jdbc:mysql://"+ MAIN.DBADDR, MAIN.DBID, MAIN.DBPW);
	        java.sql.Statement stmt = conn.createStatement();
			stmt.execute("TRUNCATE TABLE kisa");
			stmt.execute("TRUNCATE TABLE notice");
		   	MANAGER.Logwriter("MANAGER::truncate", "Truncate Table");
			stmt.close();
		}
		 catch (ClassNotFoundException e) {
		   	MANAGER.Logwriter("KISA::Upload", "<ClassNotFoundException>"+e);
		}
		catch (SQLException e) {
		   	MANAGER.Logwriter("KISA::Upload", "<SQLException>"+e);
	    }
		catch (Exception e) {
			MANAGER.Logwriter("KISA::Upload", "<Exception>"+e);
		}
	}
	
	boolean is_Duplicate(String url) {
		try {
			Connection conn;
			PreparedStatement pstmt = null;
			Class.forName("com.mysql.jdbc.Driver");
			conn = DriverManager.getConnection("jdbc:mysql://"+ MAIN.DBADDR, MAIN.DBID,MAIN.DBPW);
			String sql = "select count(*) from notice where URL ='" + url + "';";
			pstmt = conn.prepareStatement(sql); 
			ResultSet rs = null;
			rs = pstmt.executeQuery();
			while(rs.next()) {
			    int i=1;
			    if(Integer.parseInt(rs.getString(i++)) == 0)//중복이 아니면
					return false;
			   }
			pstmt.close();
		}
	
	    catch (ClassNotFoundException e) {
	    	Logwriter("MANAGER::is_Duplicate", "<ClassNotFoundException>");
	        System.out.println(e);
	    }
		catch (SQLException e) {
			Logwriter("MANAGER::is_Duplicate", "<SQLException>");
	        System.out.println(e);
	    }
		catch (Exception e) {
			Logwriter("MANAGER::is_Duplicate", "<Exception>");
			System.out.println(e);
		}
		
		return true;
	}
	
	void Upload(HOMEPAGE page) {
		try {
			Class.forName("com.mysql.jdbc.Driver");
			Connection conn;
			conn = DriverManager.getConnection("jdbc:mysql://"+ MAIN.DBADDR, MAIN.DBID,MAIN.DBPW);
			PreparedStatement pstmt = null;
	        String sql = "insert into notice values(?,?,?,?,?,?);";
			Iterator<ITEM> seek = itemlist.iterator();
			while(seek.hasNext()) {
				 ITEM item = seek.next();
				 if(is_Duplicate(page.URL+item.url)) continue;
				 //System.out.println("Pass : " + item.title);
				 pstmt = conn.prepareStatement(sql);
			     pstmt.setInt(1, page.ismain);
			     pstmt.setString(2, page.category);
			     pstmt.setInt(3, item.num);
			     pstmt.setString(4, item.title);
			     pstmt.setString(5, item.uploader);
			     pstmt.setString(6, page.URL+item.url);
			     pstmt.executeUpdate();
			}	
			if (pstmt != null && !pstmt.isClosed())
                 pstmt.close();
		}
	    catch (ClassNotFoundException e) {
	    	Logwriter("MANAGER::Upload", "<ClassNotFoundException>");
	        System.out.println(e);
	    }
		catch(com.mysql.jdbc.exceptions.jdbc4.MySQLIntegrityConstraintViolationException e) {
		}
		catch (SQLException e) {
			Logwriter("MANAGER::Upload", "<SQLException>");
	        System.out.println(e);
        }
		catch (Exception e) {
			Logwriter("MANAGER::Upload", "<Exception>");
			System.out.println(e);
		}
	}
		MANAGER(String filename){
		try{
			Setdate();
			weather = new WEATHER();
			kisa = new KISA();
			int i = 0;
			int size=0; //홈페이지 개수

            File file = new File(filename);
            FileReader filereader = new FileReader(file);
            BufferedReader bufReader = new BufferedReader(filereader);
            String line = "";
            while((line = bufReader.readLine()) != null){
                size++;
            }              
            Logwriter("MANAGER", "Number of read : " + size);
            pagelist = new HOMEPAGE[size];
            filereader = new FileReader(file);
            bufReader = new BufferedReader(filereader);
            while((line = bufReader.readLine()) != null){
            	pagelist[i] = new HOMEPAGE(line);
            	Document doc = Jsoup.connect(line).get();
            	pagelist[i++].category =  doc.title().replace("서울과학기술대학교 ", "").replace("- ", "");
            }
            bufReader.close();
            filereader.close();            
        }catch (FileNotFoundException e) {
            Logwriter("MANAGER::Getnotice", "<FileNotFoundException>Check URL file name!");
            System.out.println(e);
        }catch(IOException e){
            Logwriter("MANAGER::Getnotice", "<IOException>");
            System.out.println(e);
        }
	}
	void Run(int waittime) throws InterruptedException {
		while(true) {
			weather.Getweather();
			weather.Upload();
			if(Isruntime()) {
				Setdate();
				Getnotice();
				kisa.Load();
				kisa.Upload();
				Logwriter("MANAGER::Run", "Daytime");
			}
			else {
				Logwriter("MANAGER::Run", "Nighttime");
			}
			Thread.sleep(waittime);
		}
	}
	void Setdate() {
		Date now = new Date();
		SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
		String newdate= sdf.format(now);
		if(newdate.compareTo(date) != 0) {
			truncate();
		}			
		date = newdate;
	}
	boolean Isruntime() {
		java.time.LocalTime now = java.time.LocalTime.now();
		int hour = now.getHour();
		return (hour >= 9 && hour < 22) ? true : false;
	}
	static String Gettime() {
		Date now = new Date();
		SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");
		return sdf.format(now);
	}
	static void Logwriter(String name, String msg) {
        System.out.println(Gettime() + " | [" + name + "] "+msg);
	}
}
