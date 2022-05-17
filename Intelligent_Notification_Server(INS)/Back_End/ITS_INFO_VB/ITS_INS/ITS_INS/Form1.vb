Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Form1
    Dim Winhttp As New WinHttp.WinHttpRequest
    Private Sub Get_notice(Url As String, Original_Url As String)
        Dim counttotal, url_Num As Integer
        Dim uploadDate, temp, temp1 As String
        Dim is_Main As Boolean
        Dim TODAY As DateTime = DateTime.Parse(DateTimePicker1.Text)
        Try
            Winhttp.Open("GET", Url)
            Winhttp.Send()
            Winhttp.WaitForResponse()
            counttotal = UBound(Split(Winhttp.ResponseText, "<tr class=""body_tr"">")) '전체
            is_Main = UBound(Split(Url, "www.seoultech.ac.kr/service/info/")) '학교메인홈페이지인지 검사
            If Not counttotal = 0 Then '학교홈페이지에 있는 게시판을 파싱합니다.
                For i = 1 To counttotal
                    Dim Listview_index As Integer = ListView1.Items.Count
                    temp = Split(Split(Winhttp.ResponseText, "<tr class=""body_tr"">")(i), "</tr>")(0) 'temp에 공지사항을 받아옴.
                    If (is_Main) Then
                        uploadDate = Split(Split(temp, "<td style=""text-align: center;"">")(3), "</td>")(0)
                    Else
                        uploadDate = Split(Split(temp, "<td class=""body_col_regdate"" align=""center"">")(1), "</td>")(0)
                    End If
                    If (uploadDate = TODAY) Then ' not notice
                        If (UBound(Split(temp, "<img alt=""notice"""))) Then
                            If Not (Url = Original_Url) Then
                                Continue For
                            End If
                            ListView1.Items.Add(Replace(Replace(Split(Split(Winhttp.ResponseText, "<title>")(1), "</title>")(0), "서울과학기술대학교 ", ""), "- ", ""))
                            ListView1.Items(Listview_index).SubItems.Add("")
                        Else
                            ListView1.Items.Add(Replace(Replace(Split(Split(Winhttp.ResponseText, "<title>")(1), "</title>")(0), "서울과학기술대학교 ", ""), "- ", ""))
                            If (is_Main) Then
                                ListView1.Items(Listview_index).SubItems.Add(Split(Split(temp, "<td style=""text-align: center;"">")(1), "</td>")(0))
                            Else
                                ListView1.Items(Listview_index).SubItems.Add(Replace(Replace(Split(Split(temp, "<td class=""body_col_number"">")(1), "</td>")(0), vbTab, ""), vbCrLf, ""))
                            End If
                        End If
                        temp1 = Split(Split(temp, "<td class=""tit"" >")(1), "</td>")(0)
                        If (is_Main) Then
                            ListView1.Items(Listview_index).SubItems.Add(Replace(Replace(Regex.Replace(temp1, "\<[^\>]+\>", ""), vbTab, ""), vbCrLf, "")) '제목
                            ListView1.Items(Listview_index).SubItems.Add(Split(Split(temp, "<td style=""text-align: center;"">")(4), "</td>")(0)) '게시자
                        Else
                            ListView1.Items(Listview_index).SubItems.Add(Replace(Replace(Split(Split(temp, ">")(5 + UBound(Split(temp, "ico_notice_ko.gif"))), "<")(0), vbTab, ""), vbCrLf, ""))
                            ListView1.Items(Listview_index).SubItems.Add(Split(Split(temp, "<td class=""body_col_user"" align=""center"">")(2), "</td>")(0))
                        End If

                        ListView1.Items(Listview_index).SubItems.Add(Original_Url)
                        ListView1.Items(Listview_index).SubItems.Add(Original_Url & Split(Split(temp, "<a href='")(1), "'>")(0))
                        If i = counttotal And Url = Original_Url Then
                            If is_Main Then
                                If (Url = "http://www.seoultech.ac.kr/service/info/notice/") Then
                                    url_Num = 4691
                                ElseIf (Url = "http://www.seoultech.ac.kr/service/info/matters/") Then
                                    url_Num = 6112
                                ElseIf (Url = "http://www.seoultech.ac.kr/service/info/janghak/") Then
                                    url_Num = 5233
                                ElseIf (Url = "http://www.seoultech.ac.kr/service/info/graduate/") Then
                                    url_Num = 56589
                                End If
                            Else
                                url_Num = Split(Split(ListView1.Items(ListView1.Items.Count - 1).SubItems(5).Text, "&bnum=")(1), "&bidx")(0) '해당 홈페이지의 게시판 고유번호를 파싱합니다.
                            End If
                            Original_Url = Url
                            Url = Original_Url & "?bidx=" & url_Num & "&bnum=" & url_Num & "&allboard=" & Split(Split(ListView1.Items(ListView1.Items.Count - 1).SubItems(5).Text, "allboard=")(1), "&nowpage")(0) & "&page=2&size=5&searchtype=1&searchtext="
                            Get_notice(Url, Original_Url)
                        End If
                    End If
                Next
            End If

        Catch ex As System.Runtime.InteropServices.COMException
            log_writer("[Get_notice]" & "URL이 손상되어 페이지를 읽을 수 없거나 인터넷이 연결되지 않았습니다.")
            timer_stop()
            Return
        End Try
    End Sub

    Private Sub Get_all_notice() '리스트뷰의 내용을 추가합니다.(리스트뷰의 번호, 로딩할 페이지의 주소, 해당 게시판의 1페이지 주소)
        Dim Url As String
        Dim LineIndex As Integer
        ListView1.Items.Clear()
        Try
            Dim Lines() As String = IO.File.ReadAllLines("URL.txt") 'read URL.txt(for : 0 to Lines.Length - 1
            For LineIndex = 0 To Lines.Length - 1
                Application.DoEvents()
                ToolStripProgressBar1.Value = (100 / Lines.Length) * (LineIndex)
                ToolStripStatusLabel3.Text = ToolStripProgressBar1.Value & "%"
                Url = Lines(LineIndex)
                Get_notice(Url, Url)
            Next
            ToolStripProgressBar1.Value = 100
            ToolStripStatusLabel2.Text = Now.ToString
        Catch ex As System.IO.FileNotFoundException
            ToolStripStatusLabel3.Text = ToolStripProgressBar1.Value & "%"
            log_writer("[Get_all_notice]" & "URL목록을 읽을 수 없습니다. 파일이 존재하는지 확인해주세요.")
            timer_stop()
        End Try
        ToolStripStatusLabel3.Text = ToolStripProgressBar1.Value & "%"
        UploadSQL()

    End Sub

    Private Sub UploadSQL() '리스트뷰1에 있는 모든 내용을 업로드합니다.
        Dim i As Integer
        Dim query As String = "INSERT INTO notice (no, category, num, title, uploader, URL) VALUES (@no, @category, @num, @title, @uploader, @URL)"

        'Using conn As New OdbcConnection("Server=192.168.0.122:3306;" & "Database=NOTICE;Uid=test;Pwd=1234;")
        Using conn As New SqlConnection("Server=192.168.0.122:3306;Database=NOTICE;User Id=test;Password=1234;")

            conn.Open()

            Using comm As New SqlCommand()
                Try
                    comm.Connection = conn
                    comm.CommandType = CommandType.Text
                    comm.CommandText = "TRUNCATE TABLE notice"
                    comm.ExecuteNonQuery()
                Catch ex As SqlException
                    log_writer("[UploadSQL]" & ex.Message.ToString() & " : 테이블 초기화 실패")
                    timer_stop()
                End Try
            End Using
            For i = 0 To ListView1.Items.Count - 1
                Using comm As New SqlCommand()
                    Try
                        With comm
                            .Connection = conn
                            .CommandType = CommandType.Text
                            .CommandText = query
                            .Parameters.AddWithValue("@no", i + 1)
                            .Parameters.AddWithValue("@category", ListView1.Items(i).SubItems(0).Text)
                            .Parameters.AddWithValue("@num", ListView1.Items(i).SubItems(1).Text)
                            .Parameters.AddWithValue("@title", ListView1.Items(i).SubItems(2).Text)
                            .Parameters.AddWithValue("@uploader", ListView1.Items(i).SubItems(3).Text)
                            .Parameters.AddWithValue("@URL", ListView1.Items(i).SubItems(5).Text)
                        End With
                        comm.ExecuteNonQuery()
                    Catch ex As SqlException
                        log_writer("[UploadSQL]" & ex.Message.ToString() & " : " & ListView1.Items(i).SubItems(5).Text)
                        timer_stop()
                    Catch ex As ArgumentOutOfRangeException
                        log_writer("[UploadSQL]" & ex.Message.ToString() & " : " & ListView1.Items(i).SubItems(5).Text)
                        timer_stop()
                    End Try
                End Using
            Next
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Get_all_notice()
        ToolStripStatusLabel1.Text = "MANUAL : 공지사항 : " & ListView1.Items.Count & "개"
        log_writer("[Get_all_notice]" & "MANUAL : 공지사항 : " & ListView1.Items.Count & "개")
    End Sub

    Private Sub Get_weather()
        Dim temp, img, ultraviolet, dust, microdust, cast_txt, dustlv, microdustlv, ozone, ozonelv As String
        Dim temperature, min, max As Integer
        Dim hanriver As Double

        Try
            Winhttp.Open("GET", "https://search.naver.com/search.naver?sm=top_hty&fbm=1&ie=utf8&query=%EA%B3%B5%EB%A6%89+%EB%82%A0%EC%94%A8")
            Winhttp.Send()
            Winhttp.WaitForResponse()
            temp = Split(Split(Winhttp.ResponseText, "<div class=""sc cs_weather _weather"">")(1), "<div class=""table_info bytime _todayWeatherByTime""> ")(0) 'temp에 공지사항을 받아옴.
            temperature = Split(Split(temp, "<span class=""todaytemp"">")(1), "</span>")(0)
            img = Split(Split(temp, "<div class=""main_info""> <span class=""")(1), """></span>")(0)
            cast_txt = Split(Split(temp, "<p class=""cast_txt"">")(1), "</p>")(0)
            min = Split(Split(temp, "<span class=""min""><span class=""num"">")(1), "</span>")(0)
            max = Split(Split(temp, "<span class=""max""><span class=""num"">")(1), "</span>")(0)
            ultraviolet = Replace(Split(Split(temp, "<span class=""num"">")(4), "<span class=""ico"">")(0), "</span>", " ")
            If ultraviolet.Length > 20 Then '시간당 강수량
                ultraviolet = Replace(Split(Split(temp, "<span class=""num"">")(4), "</em>")(0), "</span>", " ")
            End If
            dust = Replace(Split(Split(temp, "<span class=""num"">")(5), "<span class=""ico"">")(0), "</span>", " ")
            dustlv = Split(Split(temp, "<dd class=""")(1), """")(0)
            microdust = Replace(Split(Split(temp, "<span class=""num"">")(6), "<span class=""ico"">")(0), "</span>", " ")
            microdustlv = Split(Split(temp, "<dd class=""")(2), """")(0)
            ozone = Replace(Split(Split(temp, "<span class=""num"">")(7), "<span class=""ico"">")(0), "</span>", " ")
            ozonelv = Split(Split(temp, "<dd class=""")(3), """")(0)
            Winhttp.Open("GET", "http://hangang.dkserver.wo.tc/")
            Winhttp.Send()
            Winhttp.WaitForResponse()
            hanriver = Split(Split(Winhttp.ResponseText, ":""")(2), """,")(0)
            MsgBox(temperature & Chr(13) & img & Chr(13) & cast_txt & Chr(13) & min & Chr(13) & max & Chr(13) & ultraviolet & Chr(13) & dust & Chr(13) & dustlv & Chr(13) & microdust & Chr(13) & microdustlv & Chr(13) & ozone & Chr(13) & ozonelv & Chr(13) & hanriver)
            Dim query As String = "INSERT INTO weather (temperature, img, min, max, cast_txt, ultraviolet, dust, dustlv, microdust, microdustlv, ozone, ozonelv, hanriver, updatetime) VALUES (@temperature, @img, @min, @max, @cast_txt, @ultraviolet, @dust, @dustlv, @microdust, @microdustlv, @ozone, @ozonelv, @hanriver, @updatetime)"
            Using conn As New SqlConnection("Server=localhost;Database=Notice;User Id=notice;Password=notice1225;")
                conn.Open()
                Using comm As New SqlCommand()
                    Try
                        comm.Connection = conn
                        comm.CommandType = CommandType.Text
                        comm.CommandText = "TRUNCATE TABLE weather"
                        comm.ExecuteNonQuery()
                    Catch ex As SqlException
                        log_writer("[Get_weather]" & ex.Message.ToString() & " : 테이블 초기화 실패")
                        timer_stop()
                    End Try
                End Using
                Using comm As New SqlCommand()
                    Try
                        With comm
                            .Connection = conn
                            .CommandType = CommandType.Text
                            .CommandText = query
                            .Parameters.AddWithValue("@temperature", temperature)
                            .Parameters.AddWithValue("@img", img)
                            .Parameters.AddWithValue("@min", min)
                            .Parameters.AddWithValue("@max", max)
                            .Parameters.AddWithValue("@cast_txt", cast_txt)
                            .Parameters.AddWithValue("@ultraviolet", ultraviolet)
                            .Parameters.AddWithValue("@dust", dust)
                            .Parameters.AddWithValue("@dustlv", dustlv)
                            .Parameters.AddWithValue("@microdust", microdust)
                            .Parameters.AddWithValue("@microdustlv", microdustlv)
                            .Parameters.AddWithValue("@ozone", ozone)
                            .Parameters.AddWithValue("@ozonelv", ozonelv)
                            .Parameters.AddWithValue("@hanriver", hanriver)
                            .Parameters.AddWithValue("@updatetime", ToolStripStatusLabel2.Text)
                        End With
                        comm.ExecuteNonQuery()
                    Catch ex As SqlException
                        log_writer("[Get_weather]" & ex.Message.ToString())
                        timer_stop()
                    Catch ex As ArgumentOutOfRangeException
                        log_writer("[Get_weather]" & ex.Message.ToString())
                        timer_stop()
                    End Try
                End Using
            End Using

        Catch ex As System.Runtime.InteropServices.COMException
            log_writer("[Get_weather]" & "URL이 손상되어 페이지를 읽을 수 없거나 인터넷이 연결되지 않았습니다.")
            timer_stop()
            Return
        Catch ex As System.IndexOutOfRangeException
            log_writer("[Get_weather]" & ex.ToString())
            timer_stop()
            Return
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Get_weather()
        ToolStripStatusLabel1.Text = "MANUAL : 날씨"
        log_writer("[Get_weather]" & ToolStripStatusLabel1.Text)
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        MsgBox(ListView1.Items(ListView1.FocusedItem.Index).SubItems(5).Text)
    End Sub

    Private Sub Button3_Click_2(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If timer_interval.Text > 0 And timer_interval.Text <= 999 Then
                DateTimePicker1.Value = Now.Date
                Timer1.Start()
                Timer1.Interval = timer_interval.Text * 60000
                ToolStripStatusLabel4.Text = "Run : Running"
                log_writer("[Timer]" & "타이머 작동 시작")
                timer_interval.Enabled = False
                GroupBox2.Enabled = False
                Button5.Enabled = True
                Button3.Enabled = False
            Else
                MsgBox("숫자 입력 범위 이탈")
            End If
        Catch ex As System.InvalidCastException
            MsgBox("잘못된 문자 입력")
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        timer_stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If Now.Hour > 8 And Now.Hour < 21 Then
            Get_all_notice()
            ToolStripStatusLabel1.Text = "AUTO : 주간모드"
        Else
            ToolStripStatusLabel1.Text = "AUTO : 야간모드"
            If Not (DateTimePicker1.Text = Now.Date) Then
                DateTimePicker1.Value = Now.Date
                ListView2.Items.Clear()
            End If
        End If
        Get_weather()
        log_writer("[Timer]" & ToolStripStatusLabel1.Text)
    End Sub

    Private Sub log_writer(message As String)
        ListView2.Items.Add(Now.ToString)
        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(message)
        ListView2.Items(ListView2.Items.Count - 1).EnsureVisible()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel2.Text = Now.ToString
        DateTimePicker1.Value = Now.Date
    End Sub

    Private Sub timer_stop()
        Timer1.Stop()
        ToolStripStatusLabel4.Text = "Run : Terminated"
        log_writer("[Timer]" & "타이머 작동 종료")
        GroupBox2.Enabled = True
        timer_interval.Enabled = True
        Button3.Enabled = True
        Button5.Enabled = False
    End Sub
End Class

