<%
	Dim cnn, rs
	Set cnn = Server.CreateObject("ADODB.Connection")
	s = "Provider=SQLOLEDB;Server=(local);Initial Catalog=Notice;User ID=notice;Password=1234;"
	cnn.open s
%>