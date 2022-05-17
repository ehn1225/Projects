public class Library_main {
//대출자 숫자 6자리로 변경
//북에 반납일자 넣기
//데이터를 파일에 입출력할 때, 정해진 제한에 따라 입력해야 해서 tobyte()가 생김.
	public static void main(String[] args) {
		java.util.Scanner in_m=new java.util.Scanner(System.in);
		Library lib = new Library("book.bin");
		System.out.print("User --> 1, Admin --> 2 : ");
		int user_number=Integer.parseInt(in_m.nextLine());
		
		switch(user_number) {
			case 1 :
				lib.user_menu();
				break;
			case 2 :
				lib.admin_menu();
				break;
			default :
				System.out.println("시스템 종료. 잘못된 숫자 입력");
				break;
		}
		
		in_m.close();
	}

}
