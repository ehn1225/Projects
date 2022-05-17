
abstract class User {
	int idnum;
	String name;
	String phonenum;
	int grade = 0; //학년(1,2,3,4 학년 / 대학원 · 비전임 교원 ·조교 ·직원 : 5 / 전임교원 : 6 )
	int lend = 0; //대출정보 1 2 3
	
	/*
	 * 휴학생 : 예약못함
	 * 학부생 : 대출 5권/기간 10일/예약 3권 
	 * 대학원생 & 비 전임: 대출 10권/기간 30일/예약 5권
	 * 전임교원 : 20권/ 90일/ 5권
	 */
	
	User(){
		boolean lengthTest = true;
		while(lengthTest) {
			idnum = Integer.parseInt(javax.swing.JOptionPane.showInputDialog("개인 ID 번호를 입력하세요 "));
			if(idnum > 999 || idnum < 1) {
				System.out.println("ID 번호의 범위는 1 ~ 999 사이입니다.");
			}
			else
				lengthTest = false;
			}
			
		lengthTest = true;
		while(lengthTest) {
			name = javax.swing.JOptionPane.showInputDialog("이름을 입력하세요 ");
			if(name.length()>10) {
				System.out.println("이름의 길이는 10byte 이하입니다..");
			}
			else
				lengthTest = false;
		}
		
		lengthTest = true;
		while(lengthTest) {
			phonenum = javax.swing.JOptionPane.showInputDialog("연락처를 입력하세요.(010-0000-0000)");
			if(phonenum.length() > 13) {
				System.out.println("연락처의 양식을 맞춰 다시 입력해주세요. (010-1234-1234)");
			}
			else
				lengthTest = false;
		}
	}
	
	User(byte [] data){
		String temp="";	
		char c;
		for(int i = 0; i <= 28; i++) {
			if((c = (char)data[i]) == '*' && i != 28)
				continue;
			switch(i) {
				case 3:
					idnum = Integer.parseInt(temp);
					temp = "";
					break;
				case 13:
					name = temp;
					temp = ""; 
					break;
				case 26:
					phonenum = temp;
					temp ="";
					break;
				case 27:
					grade = Integer.parseInt(temp);
					temp ="";
					break;
				case 28:	
					lend = Integer.parseInt(temp);
					temp ="";
					break;
			}
			temp += c;
		}
	}
	
	void printuser() {
		System.out.println("idnum : " + idnum);
		System.out.println("name : " + name);
		System.out.println("phonenum : " + phonenum);
		System.out.println("grade : " + grade);
		System.out.println("lend : " + lend);
		if(this instanceof Student) {
			Student stu = (Student)this;
			System.out.println("leave : " + stu.leave);
			System.out.println("User type : Student");
		}
		else
			System.out.println("User type : Faculty");
		System.out.println("");
	}
	
	byte [] tobyte() {
		byte [] record = new byte [50];
		
		for(int i = 0; i < 3;i++)
			if((idnum + "").length() > i)
				record[i] = (idnum + "").getBytes()[i];
			else
				record[i] = '*';
		
		for(int i = 3; i < 13;i++)
			if(name.length() > i-3)
				record[i] = name.getBytes()[i-3];
			else
				record[i] = '*';
		
		for(int i = 13; i < 26;i++)
			if(phonenum.length() > i-13)
				record[i] = phonenum.getBytes()[i-13];
			else
				record[i] = '*';
		
		record[26] = (grade + "").getBytes()[0];
		record[27] = (lend + "").getBytes()[0];
		
		for(int i = 28; i < 50; i++) 
			record[i] = '*';
		
		if(this instanceof Student) {
			Student stu = (Student)this;
			if(stu.leave) 
				record[28] = '1';
			else
				record[28] = '0';
		}
		
		return record;
	}

}
