
public class Faculty extends User {
	Faculty(){
		super();
		setgrade();
		
	}
	Faculty(byte [] data){
		super(data);		
	}
	void setgrade() {
		boolean lengthTest = true;
		while(lengthTest) {
			grade = Integer.parseInt(javax.swing.JOptionPane.showInputDialog("비전임 교원 ·조교 ·직원 : '5' / 전임교원 : '6'"));
			if(grade > 6 || grade < 5) {
				System.out.println("올바른 값을 입력하세요.");
			}
			else
				lengthTest = false;
			}
	}
}
