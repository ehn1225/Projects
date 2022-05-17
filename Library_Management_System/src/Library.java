import java.io.*;
public class Library{
	int bookcount;
	int usercount;
	java.util.Scanner scan;

	String user_fn = "user.bin";
	String book_fn;
	
	Book on_memory_book;
	User on_memory_user;

	Library(String fn){ 	
		this.book_fn = fn;
		count_check();
	}
	
	void user_menu() {
		boolean loop=true;
		scan = new java.util.Scanner(System.in);
		int menu_num;
		while(loop) {
			System.out.println("***********************");
			System.out.println("  1. 대출  ");
			System.out.println("  2. 반납  ");
			System.out.println("  3. 검색  ");
			System.out.println("  4. 종료  ");
			System.out.println("***********************");
			System.out.print("input menu number : ");
			menu_num=Integer.parseInt(scan.nextLine());		
			switch (menu_num) {
				case 1:
					borrowbook();
					break;
				case 2:
					returnbook();
					break;
				case 3:
					book_find();
					break;
				case 4 :
					loop=false;
					break;
				default:
					System.out.println("The menu number is Wrong!!!");	
					break;

			}	
		}
	}
	
	void admin_menu() {
		scan = new java.util.Scanner(System.in);
		boolean loop=true;
		int menu_num;
		while(loop) {
			System.out.println("***********************");
			System.out.println("  1. 도서관리  ");
			System.out.println("  2. 사용자관리  ");
			System.out.println("  3. 프로그종료  ");
			System.out.println("***********************");
			System.out.print("input menu number : ");
			menu_num=Integer.parseInt(scan.nextLine());		
			switch (menu_num) {
				case 1:
					book_set();
					break;
				case 2:
					user_set();
					break;
				case 3 :
					loop=false;
					System.out.println("프로그램 종료");
					break;
				default:
					System.out.println("The menu number is Wrong!!!");
					break;
			}
		}
	}

	void user_set() {
		int menu_num = 0;
		scan = new java.util.Scanner(System.in);
		boolean loop=true;
		while(loop) {
		System.out.println("***********************");
		System.out.println("  1. 사용자추가  ");
		System.out.println("  2. 사용자제거  ");
		System.out.println("  3. 사용자목록  ");
		System.out.println("  4. 종료  ");
		System.out.println("***********************");
		System.out.print("input menu number : ");
		menu_num=Integer.parseInt(scan.nextLine());
		
		switch (menu_num) {
			case 1:
				userregister();
				break;
			case 2:
				userremover();
				break;
			case 3:
				printAllUser();
				break;
			case 4 :
				loop=false;
				break;
			default:
				System.out.println("The menu number is Wrong!!!");
		}
		}
	}
	
	void book_set() {
		int menu_num = 0;
		scan = new java.util.Scanner(System.in);
		boolean loop=true;
		while(loop) {
		System.out.println("***********************");
		System.out.println("  1. 도서추가  ");
		System.out.println("  2. 도서제거  ");
		System.out.println("  3. 도서목록  ");
		System.out.println("  4. 종료  ");
		System.out.println("***********************");
		System.out.print("input menu number : ");
		menu_num=Integer.parseInt(scan.nextLine());
		
		switch (menu_num) {
			case 1:
				bookregister();
				break;
			case 2:
				bookremover();
				break;
			case 3:
				printAllBook();
				break;
			case 4 :
				loop=false;
				break;
			default:
				System.out.println("The menu number is Wrong!!!");
				break;
		}
		}
	}		
	
	void book_find() {
		boolean lengthTest = true;
		int book_pos = 0;
		while(lengthTest) {
			book_pos = searchBook(javax.swing.JOptionPane.showInputDialog("찾는 도서의 이름 또는 인덱스 번호를 입력하세요 "));
			if(book_pos == -1) {
				System.out.println("존재하지 않는 도서 입니다. 재입력 해주세요.");
			}
			else
				lengthTest = false;
		}
		getBook(book_pos);
		
		System.out.printf("    ----- 검색결과 -----   \n");
		System.out.printf("%5s %31s %6s %4s\n", "인덱스", "도서명", "대출여부", "대출자");
		System.out.printf("%4d %21s %6s %4d\n", on_memory_book.index, on_memory_book.name, on_memory_book.islend, on_memory_book.lender);
			
	}
	
	int searchBook(String query) {
		//이름이 중복될 경우 어떻게 처리할지 물어보자 
		count_check();
		try {
			int index = Integer.parseInt(query);
			//System.out.println("인덱스 검색");
			for(int i = 0; i < bookcount;i++) {
				getBook(i);
				if(on_memory_book.index == index)
					return i;
			}
		}
		catch (NumberFormatException e) {
			//System.out.println("도서명검색");
			for(int i = 0; i < bookcount;i++) {
				getBook(i);
				if(on_memory_book.name.compareTo(query) == 0)
					return i;
			}
		}
		return -1;	
	}
	
	int searchUser(int index) {
		count_check();
		//System.out.println("인덱스 검색");
		for(int i = 0; i < usercount;i++) {
			getUser(i);
			if(on_memory_user.idnum == index)
				return i;
		}
		return -1;	
	}
	
	void printAllBook() {
		count_check();
		System.out.printf("    ----- 도서목록 -----   \n");
		System.out.printf("%4s %4s %31s %6s %4s\n", "No.", "인덱스", "도서명", "대출여부", "대출자");
		for(int i =0, j = 1; i < bookcount; i++) {
			getBook(i);
			if(on_memory_book.index != 0)
				System.out.printf("%4d %4d %21s %6s %4d\n", j++, on_memory_book.index, on_memory_book.name, on_memory_book.islend, on_memory_book.lender);
		}
	}
	
	void getUser(int user_pos) {
		byte [] buf = new byte [50];
		try {
			RandomAccessFile f_in = new RandomAccessFile(user_fn, "r");
			f_in.seek(50*user_pos);
			f_in.read(buf);
			f_in.close();
			if(!(buf[0] == 0 && buf[1] == 0  && buf[2] == 0)) {
				if(buf[28] == '*')//Faculty
					on_memory_user = new Faculty(buf);
				else //Student
					on_memory_user = new Student(buf);
			}
		}
		catch(IOException e) {
			System.out.println(e.getMessage());
		}
	}
	
	void printAllUser() {
		count_check();
		String usertype;
		System.out.printf("    ----- 유저목록 -----   \n");
		System.out.printf("%4s %4s %11s %23s %11s %8s\n", " No", "ID", "성명", "연락처", "그룹", "대여권수");
		
		for(int i =0, j = 1; i < usercount; i++) {
			getUser(i);
			if(on_memory_user instanceof Student)
				usertype = "Student";
			else
				usertype = "Faculty";
			if(on_memory_user.idnum != 0)
				System.out.printf("%4d %4s %12s %15s %8s %7d \n", j++, on_memory_user.idnum, on_memory_user.name, on_memory_user.phonenum, usertype, on_memory_user.lend);
		}

	}
	
	void getBook(int book_pos) {
		byte [] buf = new byte [50];
		try {
			RandomAccessFile f_in = new RandomAccessFile(book_fn, "rw");
			f_in.seek(50*book_pos);
			f_in.read(buf);
			f_in.close();
			if(!(buf[0] == 0 && buf[1] == 0  && buf[2] == 0)) {
				on_memory_book = new Book(buf);
			}
		}
		catch(IOException e) {
			System.out.println(e.getMessage());
		}
	}
	
	void saveBook(int book_pos){
		try {
			RandomAccessFile out = new RandomAccessFile(book_fn, "rw");
			out.seek(50*book_pos);
			out.write(on_memory_book.toByte());
			out.close();
		}
		catch(IOException e) {
			System.out.println(e.getMessage());
			
		}
	}
	
	void saveUser(int User_pos){
		try {
			RandomAccessFile out = new RandomAccessFile(user_fn, "rw");
			out.seek(50*User_pos);
			out.write(on_memory_user.tobyte());
			out.close();
		}
		catch(IOException e) {
			System.out.println(e.getMessage());
			
		}
	}
	
	void bookregister(){
		Book tmp;
		while(true) {
			tmp = new Book();
			if(searchBook(tmp.index+"") == -1)
				break;
			else
				System.out.println("도서의 인덱스가 중복되었습니다. 재입력해주세요.");
		}
		
		int pos;
		try {
			if((pos=searchBook("000")) == -1) {
				FileOutputStream out = new FileOutputStream(book_fn,true);
				out.write(tmp.toByte());
				out.close();
			}
			else {
				RandomAccessFile out = new RandomAccessFile(book_fn,"rw");
				out.seek(50*pos);
				out.write(tmp.toByte());
				out.close();
			}
			System.out.println("도서가 등록되었습니다.");
				
		}
		catch(IOException e) {
			System.out.println(e.getMessage());
		}	
	}
	
	void bookremover(){
		int index = searchBook(javax.swing.JOptionPane.showInputDialog("삭제할 도서명(인덱스)입력 "));
		if(index != -1) {
			try {
				byte [] deletebyte = new byte[50];
				for(int i = 0; i < 3;i++)
					deletebyte[i] = (byte)'0';
				for(int i = 3; i < 50;i++)
					deletebyte[i] = '*';
				RandomAccessFile out = new RandomAccessFile(book_fn,"rw");
				out.seek(50*index);
				out.write(deletebyte);
				out.close();
			}
			catch(IOException e) {
				System.out.println(e.getMessage());
			}
			System.out.println("삭제 성공!");
		}
		else {
			System.out.println("입력 결과에 해당하는 도서가 없습니다.");
		}
	}

	void count_check(){
		try {
			RandomAccessFile f_in = new RandomAccessFile(book_fn, "rw");
			bookcount =  (int)(f_in.length() / 50);
			f_in.close();
			f_in = new RandomAccessFile(user_fn, "r");
			usercount =  (int)(f_in.length() / 50);
			f_in.close();
			if(bookcount == 0)
				System.out.println("도서의 수가 0권 입니다!!! 도서를 등록해 주세요!");
			else if(usercount == 0)
				System.out.println("사용자의 수가 0명 입니다!!! 서용자를 등록해 주세요!");

		}
		catch(IOException e) {
			System.out.println(e.getMessage());
		}
	}

	
	void userregister(){
		int index = Integer.parseInt(javax.swing.JOptionPane.showInputDialog("등록할 사용자 유형 입력 (학생 : '1', 교직원 : '2')"));
		User usr;
		if(index == 1)
			while(true) {
				usr = new Student();
				if(searchUser(usr.idnum) == -1)
					break;
				else
					System.out.println("사용자의 ID번호가 중복되었습니다. 재입력해주세요.");
			}
		else if((index == 2))
			while(true) {
				usr = new Faculty();
				if(searchUser(usr.idnum) == -1)
					break;
				else
					System.out.println("사용자의 ID번호가 중복되었습니다. 재입력해주세요.");
			}		
		else {
			System.out.println("잘못된 값 입력. 메인으로 돌아갑니다.");
			return;
		}
		
		int pos;
		try {
			if((pos=searchUser(000)) == -1) {
				FileOutputStream out = new FileOutputStream(user_fn,true);
				out.write(usr.tobyte());
				out.close();
			}
			else {
				RandomAccessFile out = new RandomAccessFile(user_fn,"rw");
				out.seek(50*pos);
				out.write(usr.tobyte());
				out.close();
			}
			System.out.println("사용자가 등록되었습니다.");
				
		}
		catch(IOException e) {
			System.out.println(e.getMessage());
		}	
	}
	
	void userremover(){
		int idnum = searchUser(Integer.parseInt(javax.swing.JOptionPane.showInputDialog("삭제할 유저 ID번호 입력 ")));
		if(idnum != -1) {
			try {
				byte [] deletebyte = new byte[50];
				for(int i = 0; i < 3;i++)
					deletebyte[i] = (byte)'0';
				for(int i = 3; i < 50;i++)
					deletebyte[i] = '*';
				RandomAccessFile out = new RandomAccessFile(user_fn,"rw");
				out.seek(50*idnum);
				out.write(deletebyte);
				out.close();
			}
			catch(IOException e) {
				System.out.println(e.getMessage());
			}
			System.out.println("삭제 성공!");
		}
		else {
			System.out.println("해당하는 ID번호가 없습니다.");
		}
	}
	
	
	
	
	void borrowbook(){
		boolean lengthTest = true;
		int book_pos = 0, user_pos = 0;
		while(lengthTest) {
			book_pos = searchBook(javax.swing.JOptionPane.showInputDialog("대여할 도서의 이름 또는 인덱스 번호를 입력하세요 "));
			if(book_pos == -1) {
				System.out.println("존재하지 않는 도서 입니다. 재입력 해주세요.");
			}
			else
				lengthTest = false;
		}
		
		lengthTest = true;
		while(lengthTest) {
			user_pos = searchUser(Integer.parseInt(javax.swing.JOptionPane.showInputDialog("User ID를 입력해 주세요")));
			if(user_pos == -1) {
				System.out.println("존재하지 않는 ID 입니다. 재입력 해주세요.");
			}
			else
				lengthTest = false;
		}
		
		if((user_pos != -1) && (book_pos != -1)) {
			getBook(book_pos);
			getUser(user_pos);
			if(check_per(false, on_memory_user.idnum)) {
				on_memory_book.lendBook(on_memory_user.idnum);
				on_memory_user.lend++;
				saveBook(book_pos);
				saveUser(user_pos);
				System.out.printf("대출되었습니다. 도서명 : %s , 대출자 : %s\n", on_memory_book.name,on_memory_user.name);
			}
			else {
				if(check_per(true, 0)) {
					String qus = javax.swing.JOptionPane.showInputDialog("해당 도서는 예약이 가능합니다. 예약하시겠습니까?(대출 : 'yes')");
					if(qus.compareTo("yes") == 0)
						reserve_book(book_pos);
				}
				
			}
		}
		else
			System.out.printf("SYSTEM 오류 발생!!!");
		
	}
	
	void returnbook(){
		boolean lengthTest = true;
		int book_pos = 0, user_pos = 0;;
		while(lengthTest) {
			book_pos = searchBook(javax.swing.JOptionPane.showInputDialog("반납할 도서의 이름 또는 인덱스 번호를 입력하세요 "));
			if(book_pos == -1) {
				System.out.println("존재하지 않는 도서 입니다. 재입력 해주세요.");
			}
			else
				lengthTest = false;
		}
		if(on_memory_book.islend) {
			getBook(book_pos);
			user_pos = searchUser(on_memory_book.lender);
			getUser(user_pos);
			on_memory_user.lend--;;
			on_memory_book.returnBook();
			saveBook(book_pos);
			saveUser(user_pos);
			System.out.printf("도서명 '%s'가 반납되었습니다.\n",on_memory_book.name);
		}
		else
			System.out.println("해당 도서는 대출되지 않았습니다!");
		
		
	}
	
	void reserve_book(int book_pos) {
		on_memory_book.reservate_book(on_memory_user.idnum);
		saveBook(book_pos);
	}
	
	boolean check_per(boolean wait, int id) {
		int [] lend_max = {0,5,5,5,5,9,9};
		//10권 이상은 lend에 2바이트로 해야함!
		//예약기록을 봐야겠는데...
		//int [] wait_max = {0,3,3,3,3,5,5};
		if(wait) {
			//예약 처리 - 휴학 X, 책의 최대 예약 가능수 3초과 X, 계정별 예약 가능 최대수
			if(on_memory_user instanceof Student) {
				Student stu = (Student)on_memory_user;
				if(stu.leave) { //휴학중이면 예약불가
					return false;
				}
			}
			
			//if(on_memory_user.lend >= wait_max[on_memory_user.grade]) {
				//System.out.printf("예약할 수 있는 최대 권수를 초과하였습니다. (현재 예약권수 : %d, 최대 예약권수 : %d)\n",on_memory_user.lend, wait_max[on_memory_user.grade]);		
			//}
			
			if(on_memory_book.waiter[0] != 0 && on_memory_book.waiter[1] != 0 && on_memory_book.waiter[2] != 0) {//예약 만석
				return false;
			}
			return true;
		}
		else {
			//대출 처리 - 이미 대출됬을�?false, 개정당 최대 대여수
			if(on_memory_user.lend >= lend_max[on_memory_user.grade]) { //이미 최대 대여갯수를 넘었을 경우 대출안됨
				System.out.printf("대출할 수 있는 최대 권수를 초과하였습니다. (현재 대여권수 : %d, 최대 대여권수 : %d)\n",on_memory_user.lend, lend_max[on_memory_user.grade]);
				return false;
				}
			if(on_memory_book.iswait && on_memory_book.waiter[0] != id) { //예약이 되어있는 도서입니다.
				System.out.println("해당 도서는 예약되어있어, 대출할 수 없습니다.");
				return false;		
			}
			if(on_memory_book.islend) { //이미 대여중일 경우 대출안됨
				System.out.println("해당 도서는 현재 대여중 입니다.");
				return false;		
			}
			
			return true;
		}
	}
	
	
}
