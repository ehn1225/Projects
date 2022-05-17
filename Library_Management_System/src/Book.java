import java.util.Date;
import java.text.SimpleDateFormat;

public class Book {
	int index;
	String name = "";
	boolean islend = false;
	int lender;//학번
	boolean iswait = false;
	int [] waiter = new int [3];
	String timestamp = "2019-00-00"; // "2019-05-26"
	
	Book() {
		//새로운 도서 등록
		boolean lengthTest = true;
		while(lengthTest) {
			name = javax.swing.JOptionPane.showInputDialog("도서명 입력 ");
			if(name.length() > 20) 
				System.out.println("도서명은 20바이트를 초과할 수 없습니다.");
			else
				lengthTest = false;
			}
			
		lengthTest = true;
		while(lengthTest) {
			index = Integer.parseInt(javax.swing.JOptionPane.showInputDialog("도서의 인덱스 번호를 입력하세요 "));
			if(index > 999 || index < 1) {
				System.out.println("인덱스 번호의 범위는 1 ~ 999 사이입니다.");
			}
			else
				lengthTest = false;
		}
		System.out.printf("도서가 정상적으로 생성되었습니다.(인덱스 : %d, 도서명 : %s)\n", index,name);
	}
	Book(byte [] data) {
		//도서를 읽어옵니다.
		String temp="";	
		char c;
		for(int i = 0; i < 50; i++) {
			if((c = (char)data[i]) == '*' && i != 47 )
				continue;
			switch(i) {
			case 3:
				index = Integer.parseInt(temp);
				temp = "";
				break;
			case 23:
				name = temp;
				if(c == 'y') {
					islend = true;
					temp ="";
					for(int j = 24; j < 27; j++) {
						if((char)data[j] != '*')
							temp+=(char)data[j];
					}
					lender = Integer.parseInt(temp);
				}
				temp ="";
				i = 26;
				continue;
			case 27:
				temp ="";
				if(c == 'y') 
					iswait = true;
				continue;
			case 31:
				waiter[0] = Integer.parseInt(temp);
				temp = "";
				break;
			case 34:
				waiter[1] = Integer.parseInt(temp);
				temp = "";
				break;
			case 37	:
				waiter[2] = Integer.parseInt(temp);
				temp = "";
				break;
			case 47	:
				timestamp = temp;
				break;
			
			}
			temp += c;
		}
	}
	void lendBook(int lender) {	
		settoday();
		islend = true;
		this.lender = lender;
		if(lender == waiter[0]) {
			for(int i = 0; i < 2; i++)
				waiter[i] = waiter[i+1];
			waiter[2] = 0;
			if(waiter[0] == 0 && waiter[1] == 0 && waiter[2] == 0)
				iswait = false;
		}
	}
	
	void returnBook() {
		islend = false;
		lender = 0;
		settoday();
		if(iswait) {
			System.out.printf("%d님, %s 도서가 반납되었습니다. 대출해가세요.\n", waiter[0], name);
		}
	}
	
	void reservate_book(int id) {
		iswait = true;
		for(int i =0; i < 3; i++){
			if(waiter[i] == 0) {
				waiter[i] = id;
				break;
			}
		}	
	}
	
	byte[] toByte() {
		byte [] record = new byte [50];

		for(int i = 0; i < 3;i++)
			if((index + "").length() > i)
				record[i] = (index + "").getBytes()[i];
			else
				record[i] = '*';
		
		for(int i = 3; i < 23;i++)
			if(name.length() > i-3)
				record[i] = name.getBytes()[i-3];
			else
				record[i] = '*';
		
		if(islend) {
			record[23] = 'y';
			int len = (lender + "").length();
			for(int i = 24; i < 27-len; i++)
				record[i] = '0';
			for(int i = 27-len; i < 27; i++)
				record[i] = (lender + "").getBytes()[i-(27-len)];
		}
		else {
			record[23] = 'n';
			for(int i = 24; i < 27;i++)
				record[i] = '0';
		}
		if(iswait) {
			record[27] = 'y';
			for(int j = 0; j < 3; j++) {
				int len = (waiter[j] + "").length();
				if(waiter[j] == 0) {
					for(int i =0; i < 3;i++)
						record[3*(j+1)+25+i] = '0';
					continue;
				}
				for(int i = 0; i < 3-len; i++)
					record[3*(j+1)+25+i] = '0';
				for(int i = 3-len; i < 3; i++)
					record[3*(j+1)+25+i] = (waiter[j] + "").getBytes()[i-(3-len)];
			}
		}
		else {
			record[27] = 'n';
			for(int i = 28; i < 37;i++)
				record[i] = '0';
		}
		
		for(int i = 37; i < 47; i++) 
			record[i] = timestamp.getBytes()[i-37];
		
		for(int i = 47; i < 50; i++) 
			record[i] = '*';
		//System.out.println(new String(record));
		return record;
	}
	void printbook(){
		System.out.println("index : " + index);
		System.out.println("name : " + name);
		System.out.println("islend : " + islend);
		System.out.println("lender : " + lender);
		System.out.println("iswait : " + iswait);

		for(int i =0; i < 3; i++)
			System.out.printf("waiter[%d] : " + waiter[i] + "\n", i);
		System.out.println("timestamp : " + timestamp);

	}

	void settoday() {
		Date date = new Date();
		SimpleDateFormat formatType = new SimpleDateFormat("yyyy-MM-dd");
		timestamp = formatType.format(date);
	}

}
