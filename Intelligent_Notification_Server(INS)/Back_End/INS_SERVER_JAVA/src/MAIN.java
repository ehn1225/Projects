
public class MAIN {
	static final String DBADDR = "localhost/NOTICE"; // Ex)"192.168.0.122:3306/NOTICE" : 원격 & "localhost/NOTICE" : 내부
	static final String DBID = "notice";
	static final String DBPW = "1234";
	
	public static void main(String[] args) {
		try {
			MANAGER manager = new MANAGER("URL.txt");
			System.out.println("Set Interver : " + args[0] + " min");
			manager.Run(Integer.parseInt(args[0])*60000);
		}
		catch(java.lang.ArrayIndexOutOfBoundsException e) {
			MANAGER.Logwriter("main", "<ArrayIndexOutOfBoundsException>" + "매개변수로 작동 주기를 넣어주세요.(단위 : 분)"+ e);
		}
		catch(Exception e) {
			MANAGER.Logwriter("main", "<Exception>" + e);
		}
	}

}
