import java.util.Date;
import java.io.*;
import java.text.SimpleDateFormat;
public class testbed {

	public static void main(String[] args) throws Exception {
	/*	User on_memory_user;
		Student fac = new Student();
		fac.printuser();
		Faculty fac1 = new Faculty();
		fac1.printuser();
		
		byte [] arr = new byte [50];
		arr = fac.tobyte();
		for(byte a : arr) 
			System.out.print((char)a);
		System.out.println("");
		FileOutputStream out = new FileOutputStream("user.bin");
		out.write(arr);
		out.close();

		arr = fac1.tobyte();
		for(byte a : arr) 
			System.out.print((char)a);

		
		out = new FileOutputStream("user.bin",true);
		out.write(arr);
		out.close();*/
		/*
		byte [] buf = new byte [50];
		try {
			RandomAccessFile f_in = new RandomAccessFile("user.bin", "r");
			f_in.read(buf);
			f_in.close();
			if(buf[28] == '*')//Faculty
				on_memory_user = new Faculty(buf);
			else //Student
				on_memory_user = new Student(buf);
			on_memory_user.printuser();

		}
		catch(IOException e) {
			System.out.println(e.getMessage());
		};
		
		
		*/
		
		Library lib = new Library("book.bin");
		lib.getBook(0);
		lib.on_memory_book.waiter[0] = 12;
		lib.on_memory_book.waiter[1] = 5;
		lib.on_memory_book.waiter[2] = 254;
		lib.on_memory_book.printbook();
		lib.on_memory_book.toByte();
	}

}
