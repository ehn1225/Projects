
public class ITEM {
	int num = 0;
	String title = "";
	String uploader = "";
	String url = "";
	ITEM(String num, String title, String uploader, String url){
		this.num =  num.length()==0 ? 0 : Integer.parseInt(num);
		this.title = title.length()==0 ? "로딩실패:직접방문하기" : title;
		this.uploader = uploader;
		this.url = url;
	}
}
