
public class Student extends User{
	boolean leave; //휴학여부
	
	Student(){
		super();
		setgrade();
		setleave();
	}
	
	Student(byte [] data){
		super(data);
		if((char)data[28] == '1') 
			leave = true;			
		else
			leave = false;
	}
		
	void setgrade() {
		boolean lengthTest = true;
		while(lengthTest) {
			grade = Integer.parseInt(javax.swing.JOptionPane.showInputDialog("학년을 입력하세요(대학원생 : '5')"));
			if(grade > 5 || grade < 1) {
				System.out.println("학년의 범위는 1 ~ 5 사이입니다.");
			}
			else
				lengthTest = false;
			}
	}
	
	void setleave() {
		boolean lengthTest = true;
		while(lengthTest) {
			int a = Integer.parseInt(javax.swing.JOptionPane.showInputDialog("휴학여부(0 : 재학생 , 1 : 휴학생)"));
			if(a != 0 && a != 1) {
				System.out.println("재학생이면 '0', 휴학생이면 '1'을 입력하세요.");
			}
			else {
				lengthTest = false;
				if(a == 1) 
					leave = true;
				else
					leave = false;
			}
		}		
	}


}
