Public Class Form
    Dim winhttp As New WinHttp.WinHttpRequest
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MessageBox.Show("제작자 : 이예찬" & Chr(13) & "E-mail : ehn1225@naver.com" & Chr(13) & "제작년일 : 2015년 8월 14일", "제작자정보")
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Process.Start("https://www.doortodoor.co.kr/parcel/pa_004.jsp")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        winhttp.Open("POST", "http://www.yourstage.com/member/member_login.aspx?reurl=http%3a%2f%2fwww.yourstage.com%2fmypage%2fsms.aspx")
        winhttp.SetRequestHeader("Referer", "http://www.yourstage.com/member/member_login.aspx?reurl=http%3a%2f%2fwww.yourstage.com%2fmypage%2fsms.aspx")
        winhttp.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded")
        winhttp.Send("__VIEWSTATE=%2FwEPDwUKLTY0NDQ4ODA5MQ9kFgRmD2QWBmYPZBYCAgIPFgQeBGhyZWYFugFodHRwOi8vd3d3LnlvdXJzdGFnZS5jb20vbWVtYmVyL21lbWJlcl9sb2dpbi5hc3B4P3JldXJsPWh0dHAlM2ElMmYlMmZ3d3cueW91cnN0YWdlLmNvbSUyZm1lbWJlciUyZm1lbWJlcl9sb2dpbi5hc3B4JTNmcmV1cmwlM2RodHRwJTI1M2ElMjUyZiUyNTJmd3d3LnlvdXJzdGFnZS5jb20lMjUyZm15cGFnZSUyNTJmc21zLmFzcHgeCWlubmVyaHRtbAUJ66Gc6re47J24ZAIBD2QWAmYPFgIeC18hSXRlbUNvdW50Ag4WHGYPZBYCZg8VBAAmL2NvbW11bml0eS9ib2FyZGxpc3QuYXNweD9zZXJpZXM9ZnVubnkAFuyerOuvuOyeiOuKlCDsnbTslbzquLBkAgEPZBYCZg8VBAAQL215cGFnZS9zbXMuYXNweAAM66y066OM66y47J6QZAICD2QWAmYPFQQAQmh0dHBzOi8vd3d3LnlvdXJzdGFnZS5jb20vZW5jb3Jlc2Nob29sL2NsYXNzX2RldGFpbC5hc3B4P3RocmVhZD05NAAc7ZWc66y46rWQ7Jyh7KeA64%2BE7IKsIOqwleyijGQCAw9kFgJmDxUEAB5odHRwOi8vY2x1Yi55b3Vyc3RhZ2UuY29tL2RvYm8ADOyduOq4sO2BtOufvWQCBA9kFgJmDxUEABUvbXlwYWdlL21ha2VfYmxvZy5hc3AAEuu4lOuhnOq3uOunjOuTpOq4sGQCBQ9kFgJmDxUEADZodHRwczovL3d3dy55b3Vyc3RhZ2UuY29tL2VuY29yZXNjaG9vbC9jbGFzc19saXN0LmFzcHgADOqwleyijOyLoOyyrWQCBg9kFgJmDxUEADdodHRwOi8vd3d3LnlvdXJzdGFnZS5jb20vaGVscC9ub3RpY2Vfdmlldy5hc3B4P251bT0xMTAwABDrqZTrpbTsiqQg7JiI67CpZAIHD2QWAmYPFQQAHy9ldmVudC9ldmVudF9wcm9ncmVzc19saXN0LmFzcHgAETbsm5Qg66y066OM6rO17JewZAIID2QWAmYPFQQAQGh0dHBzOi8vd3d3LnlvdXJzdGFnZS5jb20vY29tbXVuaXR5L2JvYXJkbGlzdC5hc3B4P3Nlcmllcz1zZWNyZXQADOqzoOuvvOyDgeuLtGQCCQ9kFgJmDxUEACkvZW5jb3Jlc2Nob29sL2NsYXNzX2RldGFpbC5hc3B4P3RocmVhZD04OQAS7IOB7IOd7JWE7Lm0642w66%2B4ZAIKD2QWAmYPFQQADi9saWZlL2pvYi5hc3B4AA%2FsnbzsnpDrpqzssL7quLBkAgsPZBYCZg8VBABCaHR0cHM6Ly93d3cueW91cnN0YWdlLmNvbS9lbmNvcmVzY2hvb2wvY2xhc3NfZGV0YWlsLmFzcHg%2FdGhyZWFkPTk2ABnsiqTrp4jtirjtj7Ag66y066OM6rCV7KKMZAIMD2QWAmYPFQQAEi9ldmVudC9hdHRlbmQuYXNweAAK7Lac7ISd67aAIGQCDQ9kFgJmDxUEASAfL2hlbHAvbm90aWNlX3ZpZXcuYXNweD9udW09MTA3MgAM66qo67CU7J287Ju5ZAICDxYCHgdWaXNpYmxlZ2QCAQ9kFgICCQ8PFgIeD0NvbW1hbmRBcmd1bWVudAUoaHR0cDovL3d3dy55b3Vyc3RhZ2UuY29tL215cGFnZS9zbXMuYXNweGRkGAEFHl9fQ29udHJvbHNSZXF1aXJlUG9zdEJhY2tLZXlfXxYCBRFrZWVwX2xvZ2luX3N0YXR1cwUDc3Ns1LepHMfhfXOMDzkiGGnd9JTGvaWVgCcEL8J8tv05n%2BA%3D&__VIEWSTATEGENERATOR=5795B9CA&email=" & TextBox2.Text & "&pw=" & TextBox3.Text & "&btnLogin=%EB%A1%9C%EA%B7%B8%EC%9D%B8")
        If InStr(winhttp.ResponseText, "등록된 아이디가 없습니다.") Or InStr(winhttp.ResponseText, "비밀번호가 맞지 않습니다.") Then
            MsgBox("존재하지않는 ID or PW입니다.")
            Label4.Text = "로그인 : 실패"
        Else
            GroupBox2.Enabled = True
            GroupBox3.Enabled = True
            GroupBox4.Enabled = True
            Label4.Text = "로그인 : 성공"
            winhttp.Open("POST", "http://www.yourstage.com/member/member_login.aspx?reurl=http%3a%2f%2fwww.yourstage.com%2fmypage%2fsms.aspx")
            winhttp.SetRequestHeader("Referer", "http://www.yourstage.com/member/member_login.aspx?reurl=http%3a%2f%2fwww.yourstage.com%2fmypage%2fsms.aspx")
            winhttp.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded")
            winhttp.Send("__VIEWSTATE=%2FwEPDwUKLTY0NDQ4ODA5MQ9kFgRmD2QWBmYPZBYCAgIPFgQeBGhyZWYFugFodHRwOi8vd3d3LnlvdXJzdGFnZS5jb20vbWVtYmVyL21lbWJlcl9sb2dpbi5hc3B4P3JldXJsPWh0dHAlM2ElMmYlMmZ3d3cueW91cnN0YWdlLmNvbSUyZm1lbWJlciUyZm1lbWJlcl9sb2dpbi5hc3B4JTNmcmV1cmwlM2RodHRwJTI1M2ElMjUyZiUyNTJmd3d3LnlvdXJzdGFnZS5jb20lMjUyZm15cGFnZSUyNTJmc21zLmFzcHgeCWlubmVyaHRtbAUJ66Gc6re47J24ZAIBD2QWAmYPFgIeC18hSXRlbUNvdW50Ag4WHGYPZBYCZg8VBAAmL2NvbW11bml0eS9ib2FyZGxpc3QuYXNweD9zZXJpZXM9ZnVubnkAFuyerOuvuOyeiOuKlCDsnbTslbzquLBkAgEPZBYCZg8VBAAQL215cGFnZS9zbXMuYXNweAAM66y066OM66y47J6QZAICD2QWAmYPFQQAQmh0dHBzOi8vd3d3LnlvdXJzdGFnZS5jb20vZW5jb3Jlc2Nob29sL2NsYXNzX2RldGFpbC5hc3B4P3RocmVhZD05NAAc7ZWc66y46rWQ7Jyh7KeA64%2BE7IKsIOqwleyijGQCAw9kFgJmDxUEAB5odHRwOi8vY2x1Yi55b3Vyc3RhZ2UuY29tL2RvYm8ADOyduOq4sO2BtOufvWQCBA9kFgJmDxUEABUvbXlwYWdlL21ha2VfYmxvZy5hc3AAEuu4lOuhnOq3uOunjOuTpOq4sGQCBQ9kFgJmDxUEADZodHRwczovL3d3dy55b3Vyc3RhZ2UuY29tL2VuY29yZXNjaG9vbC9jbGFzc19saXN0LmFzcHgADOqwleyijOyLoOyyrWQCBg9kFgJmDxUEADdodHRwOi8vd3d3LnlvdXJzdGFnZS5jb20vaGVscC9ub3RpY2Vfdmlldy5hc3B4P251bT0xMTAwABDrqZTrpbTsiqQg7JiI67CpZAIHD2QWAmYPFQQAHy9ldmVudC9ldmVudF9wcm9ncmVzc19saXN0LmFzcHgAETbsm5Qg66y066OM6rO17JewZAIID2QWAmYPFQQAQGh0dHBzOi8vd3d3LnlvdXJzdGFnZS5jb20vY29tbXVuaXR5L2JvYXJkbGlzdC5hc3B4P3Nlcmllcz1zZWNyZXQADOqzoOuvvOyDgeuLtGQCCQ9kFgJmDxUEACkvZW5jb3Jlc2Nob29sL2NsYXNzX2RldGFpbC5hc3B4P3RocmVhZD04OQAS7IOB7IOd7JWE7Lm0642w66%2B4ZAIKD2QWAmYPFQQADi9saWZlL2pvYi5hc3B4AA%2FsnbzsnpDrpqzssL7quLBkAgsPZBYCZg8VBABCaHR0cHM6Ly93d3cueW91cnN0YWdlLmNvbS9lbmNvcmVzY2hvb2wvY2xhc3NfZGV0YWlsLmFzcHg%2FdGhyZWFkPTk2ABnsiqTrp4jtirjtj7Ag66y066OM6rCV7KKMZAIMD2QWAmYPFQQAEi9ldmVudC9hdHRlbmQuYXNweAAK7Lac7ISd67aAIGQCDQ9kFgJmDxUEASAfL2hlbHAvbm90aWNlX3ZpZXcuYXNweD9udW09MTA3MgAM66qo67CU7J287Ju5ZAICDxYCHgdWaXNpYmxlZ2QCAQ9kFgICCQ8PFgIeD0NvbW1hbmRBcmd1bWVudAUoaHR0cDovL3d3dy55b3Vyc3RhZ2UuY29tL215cGFnZS9zbXMuYXNweGRkGAEFHl9fQ29udHJvbHNSZXF1aXJlUG9zdEJhY2tLZXlfXxYCBRFrZWVwX2xvZ2luX3N0YXR1cwUDc3Ns1LepHMfhfXOMDzkiGGnd9JTGvaWVgCcEL8J8tv05n%2BA%3D&__VIEWSTATEGENERATOR=5795B9CA&email=" & TextBox2.Text & "&pw=" & TextBox3.Text & "&btnLogin=%EB%A1%9C%EA%B7%B8%EC%9D%B8")
            winhttp.Open("GET", "https://www.yourstage.com/mypage/sms.aspx")
            winhttp.Send()
            Label7.Text = Split(Split(winhttp.ResponseText, "readonly=""readonly"" value=""")(1), """ /></li>")(0)
            Label10.Text = "잔여건수 : " & Split(Split(winhttp.ResponseText, "<li class=""cnt""><span id=""senOk"">")(1), "</span>")(0) & "건"
            TextBox4.Focus()
        End If
    End Sub
    Private Sub TextBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyDown
        If e.KeyCode = 13 Then
            Button3.PerformClick()
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Text1.Text = "" Or ComboBox2.SelectedItem = "" Then
            MsgBox("송장번호입력과 택배사 선택을 확인해주세요")
        ElseIf TextBox4.Text = "" And TextBox5.Text = "" Then
            MsgBox("수신할 전화번호를 입력해 주세요.")
        ElseIf RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False Then
            MsgBox("내용을 선택해 주세요")
        ElseIf ComboBox1.SelectedItem = "" Then
            MsgBox("재갱신 시간을 선택해주세요.")
        Else
            Dim intever1 As Integer = ComboBox1.SelectedIndex
            Select Case intever1
                Case 0
                    Timer1.Interval = 5000
                Case 1
                    Timer1.Interval = 10000
                Case 2
                    Timer1.Interval = 30000
                Case 3
                    Timer1.Interval = 60000
                Case 4
                    Timer1.Interval = 300000
                Case 5
                    Timer1.Interval = 600000
                Case 6
                    Timer1.Interval = 1800000
                Case 7
                    Timer1.Interval = 3600000
            End Select
            If Timer1.Enabled = False Then
                Timer1.Start()
                Timer1.Enabled = True
                Label8.Text = "실시간알림 작동여부 : 작동"
                Text1.Enabled = False
                Button1.Enabled = False
                GroupBox1.Enabled = False
                GroupBox2.Enabled = False
                GroupBox3.Enabled = False
                Button2.Enabled = False
            Else
                Timer1.Stop()
                Timer1.Enabled = False
                Label8.Text = "실시간알림 작동여부 : 중지"
                Text1.Enabled = True
                Button1.Enabled = True
                Button2.Enabled = True
                GroupBox1.Enabled = True
                GroupBox2.Enabled = True
                GroupBox3.Enabled = True
            End If
        End If

    End Sub
    Private Sub Text1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Text1.KeyDown
        If e.KeyCode = 13 Then
            Button1.PerformClick()
        End If
    End Sub
    Sub checkboxClick(cCount As Integer, cBoxName As String)
        Dim i As Integer
        Dim cBox As CheckBox
        For i = 1 To cCount
            cBox = Me.Controls(cBoxName & i)
            cBox.Checked = True
            cBox.Visible = True
        Next
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error Resume Next '에러가 나오면 무시합니다.
        Dim fac As Integer = ComboBox2.SelectedIndex
        Dim list4index As Integer = List4.Items.Count
        Dim hjtext As String
        Dim source, source1
        Dim nb1, nb2, nb3, ccount1 As Integer
        nb1 = Len(Text1.Text)
        If Len(Text1.Text) < 10 Or Len(Text1.Text) > 12 Then
            MsgBox("송장번호는 10자 혹은 12자 입니다" & Chr(10) & "입력한글자수 : " & nb1)
            Text1.Focus()
        ElseIf ComboBox2.SelectedItem = "" Then
            MsgBox("택배회사를 선택하여 주세요.")
        Else
            Select Case fac
                Case 0  'cj대한통운
                    winhttp.Open("POST", "https://www.doortodoor.co.kr/parcel/doortodoor.do")
                    winhttp.SetRequestHeader("Referer", "https://www.doortodoor.co.kr/parcel/pa_004.jsp")
                    winhttp.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded")
                    winhttp.Send("fsp_action=PARC_ACT_002&fsp_cmd=retrieveInvNoACT&invc_no=" & Text1.Text)
                    source = Split(Split(winhttp.ResponseText, "<th scope=""col"" class=""last"">담당 점소</th>")(1), "<td class=""last last_b"">")(0)
                    source = Replace(Replace(Replace(source, vbCr, ""), vbLf, ""), vbTab, vbNullString)
                    ccount1 = UBound(Split(source, "<td class="""">"))
                    For i = 1 To ccount1  '리스트박스에 담기
                        source1 = Split(Split(source, "<td class="""">")(i), "</td>")(0)
                        If InStr(source1, "<br />") Then
                            List4.Items.Add(Replace(source1, "<br />", ""))
                        Else
                            List4.Items.Add(source1)
                        End If
                        If i = ccount1 Then   'last 처리
                            For z = 1 To 3
                                source1 = Split(Split(source, "<td class=""last_b"">")(z), "</td>")(0)
                                If InStr(source1, "<br />") Then
                                    List4.Items.Add(Replace(Split(Split(source, "<td class=""last_b"">")(z), "</td>")(0), "<br />", ""))
                                Else
                                    List4.Items.Add(source1)
                                End If
                            Next
                        End If
                    Next
                    For z = 0 To List4.Items.Count
                        ListView1.Items.Add(List4.Items(z * 3))
                        ListView1.Items(z).SubItems.Add(List4.Items(4 * z - z + 1))
                        ListView1.Items(z).SubItems.Add(List4.Items(z * 2 + 2 + z))
                    Next
                   
                Case 1    '한진
                    winhttp.Open("POST", "http://www.hanjin.co.kr/Delivery_html/inquiry/result_waybill.jsp?wbl_num=" & Text1.Text)
                    winhttp.SetRequestHeader("Referer", "http://www.hanjin.co.kr/Delivery_html/inquiry/personal_inquiry.jsp")
                    winhttp.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded")
                    winhttp.Send("wbl_num=" & Text1.Text)
                    source = Split(Split(winhttp.ResponseText, "<caption>배송진행 상황</caption>")(1), "<ul class=""board_tip"">")(0)
                    If InStr(winhttp.ResponseText, "배송완료</strong> 되었습니다.") Then
                        ccount1 = UBound(Split(source, "<div align=""left"">")) - 1
                    Else
                        ccount1 = UBound(Split(source, "<div align=""left"">")) - 0
                    End If
                    For i = 1 To ccount1 * 4   '리스트박스에 담기
                        source1 = Replace(Replace(Split(Split(source, "<td>")(i), "</td>")(0), vbTab, ""), " ", "")
                        If InStr(source1, "<divalign=""left"">") Then
                            List4.Items.Add(Replace(Replace(Replace(Replace(source1, "<divalign=""left"">", ""), "<strong>", " "), "</strong>", ""), "</div>", " "))
                        Else
                            List4.Items.Add(source1)
                        End If
                        If i = ccount1 * 4 Then   'last 처리, 배송완료만
                            For z = 1 To 2
                                List4.Items.Add(Split(Split(source, "<td rowspan=""2"" class=""bb""><b>")(z), "</b></td>")(0))
                                If z = 2 Then
                                    For h = 1 To 2
                                        source1 = Replace(Replace(Split(Split(source, "<td>")(h + i), "</td>")(0), vbTab, ""), " ", "")
                                        If InStr(source1, "<divalign=""left"">") Then
                                            List4.Items.Add(Replace(Replace(Replace(Replace(source1, "<divalign=""left"">", ""), "<strong>", " "), "</strong>", ""), "</div>", " "))
                                        Else
                                            List4.Items.Add(source1)
                                        End If
                                    Next
                                End If
                            Next
                        End If
                    Next

                    For z = 0 To List4.Items.Count
                        ListView1.Items.Add(List4.Items(z * 4))
                        ListView1.Items(z).SubItems.Add(List4.Items(4 * z + 1))
                        ListView1.Items(z).SubItems.Add(List4.Items(z * 4 + 3))
                    Next
            End Select
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        On Error Resume Next
        ListView1.Items.Clear()
        List4.Items.Clear()

        Dim source, message1, source1
        Dim ccount1 As Integer
        Dim nb1, nb2, nb3 As Integer
        nb1 = Len(Text1.Text)
        If Len(Text1.Text) < 10 Or Len(Text1.Text) > 12 Then
            MsgBox("송장번호는 10자 혹은 12자 입니다" & Chr(10) & "입력한글자수 : " & nb1)
            Text1.Focus()
        ElseIf ComboBox2.SelectedItem = "" Then
            MsgBox("택배회사를 선택하여 주세요.")
        Else
            Dim fac As Integer = ComboBox2.SelectedIndex
            Select Case fac
                Case 0  'cj대한통운
                    winhttp.Open("POST", "https://www.doortodoor.co.kr/parcel/doortodoor.do")
                    winhttp.SetRequestHeader("Referer", "https://www.doortodoor.co.kr/parcel/pa_004.jsp")
                    winhttp.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded")
                    winhttp.Send("fsp_action=PARC_ACT_002&fsp_cmd=retrieveInvNoACT&invc_no=" & Text1.Text)
                    source = Split(Split(winhttp.ResponseText, "<th scope=""col"" class=""last"">담당 점소</th>")(1), "<td class=""last last_b"">")(0)
                    source = Replace(Replace(Replace(source, vbCr, ""), vbLf, ""), vbTab, vbNullString)
                    ccount1 = UBound(Split(source, "<td class="""">"))
                    For i = 1 To ccount1  '리스트박스에 담기
                        source1 = Split(Split(source, "<td class="""">")(i), "</td>")(0)
                        If InStr(source1, "<br />") Then
                            List4.Items.Add(Replace(source1, "<br />", ""))
                        Else
                            List4.Items.Add(source1)
                        End If
                        If i = ccount1 Then   'last 처리
                            For z = 1 To 3
                                source1 = Split(Split(source, "<td class=""last_b"">")(z), "</td>")(0)
                                If InStr(source1, "<br />") Then
                                    List4.Items.Add(Replace(Split(Split(source, "<td class=""last_b"">")(z), "</td>")(0), "<br />", ""))
                                Else
                                    List4.Items.Add(source1)
                                End If
                            Next
                        End If
                    Next

                    For z = 0 To List4.Items.Count
                        ListView1.Items.Add(List4.Items(z * 3))
                        ListView1.Items(z).SubItems.Add(List4.Items(4 * z - z + 1))
                        ListView1.Items(z).SubItems.Add(List4.Items(z * 2 + 2 + z))
                    Next       'cj대한통운
                    Dim intever2 As Integer = List4.Items.Count
                    If RadioButton1.Checked = True Then
                        message1 = "<" & List4.Items(intever2 - 3) & ">"
                    ElseIf RadioButton2.Checked = True Then
                        message1 = "<" & List4.Items(intever2 - 3) & ">(" & List4.Items(intever2 - 2) & ")"
                    ElseIf RadioButton3.Checked = True Then
                        message1 = "<" & List4.Items(intever2 - 3) & ">(" & List4.Items(intever2 - 2) & ")" & List4.Items(intever2 - 1)
                    End If
                    For i As Integer = 0 To smsBox1.Text
                        ListView1.Items(i).SubItems.Add("완료")
                    Next

                    If TextBoxcount.Text < intever2 Then
                        winhttp.Open("POST", "https://www.yourstage.com/member/member_login.aspx?reurl=http%3a%2f%2fwww.yourstage.com%2fmypage%2fsms.aspx")
                        winhttp.SetRequestHeader("Referer", "https://www.yourstage.com/member/member_login.aspx?reurl=http%3a%2f%2fwww.yourstage.com%2fmypage%2fsms.aspx")
                        winhttp.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded")
                        winhttp.Send("__VIEWSTATE=%2FwEPDwUKLTY0NDQ4ODA5MQ9kFgRmD2QWBmYPZBYCAgIPFgQeBGhyZWYFugFodHRwOi8vd3d3LnlvdXJzdGFnZS5jb20vbWVtYmVyL21lbWJlcl9sb2dpbi5hc3B4P3JldXJsPWh0dHAlM2ElMmYlMmZ3d3cueW91cnN0YWdlLmNvbSUyZm1lbWJlciUyZm1lbWJlcl9sb2dpbi5hc3B4JTNmcmV1cmwlM2RodHRwJTI1M2ElMjUyZiUyNTJmd3d3LnlvdXJzdGFnZS5jb20lMjUyZm15cGFnZSUyNTJmc21zLmFzcHgeCWlubmVyaHRtbAUJ66Gc6re47J24ZAIBD2QWAmYPFgIeC18hSXRlbUNvdW50Ag4WHGYPZBYCZg8VBAAmL2NvbW11bml0eS9ib2FyZGxpc3QuYXNweD9zZXJpZXM9ZnVubnkAFuyerOuvuOyeiOuKlCDsnbTslbzquLBkAgEPZBYCZg8VBAAQL215cGFnZS9zbXMuYXNweAAM66y066OM66y47J6QZAICD2QWAmYPFQQAQmh0dHBzOi8vd3d3LnlvdXJzdGFnZS5jb20vZW5jb3Jlc2Nob29sL2NsYXNzX2RldGFpbC5hc3B4P3RocmVhZD05NAAc7ZWc66y46rWQ7Jyh7KeA64%2BE7IKsIOqwleyijGQCAw9kFgJmDxUEAB5odHRwOi8vY2x1Yi55b3Vyc3RhZ2UuY29tL2RvYm8ADOyduOq4sO2BtOufvWQCBA9kFgJmDxUEABUvbXlwYWdlL21ha2VfYmxvZy5hc3AAEuu4lOuhnOq3uOunjOuTpOq4sGQCBQ9kFgJmDxUEADZodHRwczovL3d3dy55b3Vyc3RhZ2UuY29tL2VuY29yZXNjaG9vbC9jbGFzc19saXN0LmFzcHgADOqwleyijOyLoOyyrWQCBg9kFgJmDxUEADdodHRwOi8vd3d3LnlvdXJzdGFnZS5jb20vaGVscC9ub3RpY2Vfdmlldy5hc3B4P251bT0xMTAwABDrqZTrpbTsiqQg7JiI67CpZAIHD2QWAmYPFQQAHy9ldmVudC9ldmVudF9wcm9ncmVzc19saXN0LmFzcHgAETbsm5Qg66y066OM6rO17JewZAIID2QWAmYPFQQAQGh0dHBzOi8vd3d3LnlvdXJzdGFnZS5jb20vY29tbXVuaXR5L2JvYXJkbGlzdC5hc3B4P3Nlcmllcz1zZWNyZXQADOqzoOuvvOyDgeuLtGQCCQ9kFgJmDxUEACkvZW5jb3Jlc2Nob29sL2NsYXNzX2RldGFpbC5hc3B4P3RocmVhZD04OQAS7IOB7IOd7JWE7Lm0642w66%2B4ZAIKD2QWAmYPFQQADi9saWZlL2pvYi5hc3B4AA%2FsnbzsnpDrpqzssL7quLBkAgsPZBYCZg8VBABCaHR0cHM6Ly93d3cueW91cnN0YWdlLmNvbS9lbmNvcmVzY2hvb2wvY2xhc3NfZGV0YWlsLmFzcHg%2FdGhyZWFkPTk2ABnsiqTrp4jtirjtj7Ag66y066OM6rCV7KKMZAIMD2QWAmYPFQQAEi9ldmVudC9hdHRlbmQuYXNweAAK7Lac7ISd67aAIGQCDQ9kFgJmDxUEASAfL2hlbHAvbm90aWNlX3ZpZXcuYXNweD9udW09MTA3MgAM66qo67CU7J287Ju5ZAICDxYCHgdWaXNpYmxlZ2QCAQ9kFgICCQ8PFgIeD0NvbW1hbmRBcmd1bWVudAUoaHR0cDovL3d3dy55b3Vyc3RhZ2UuY29tL215cGFnZS9zbXMuYXNweGRkGAEFHl9fQ29udHJvbHNSZXF1aXJlUG9zdEJhY2tLZXlfXxYCBRFrZWVwX2xvZ2luX3N0YXR1cwUDc3Ns1LepHMfhfXOMDzkiGGnd9JTGvaWVgCcEL8J8tv05n%2BA%3D&__VIEWSTATEGENERATOR=5795B9CA&email=" & TextBox2.Text & "&pw=" & TextBox3.Text & "&btnLogin=%EB%A1%9C%EA%B7%B8%EC%9D%B8")
                        System.Threading.Thread.Sleep(100)
                        winhttp.Open("POST", "https://www.yourstage.com/mypage/sms.aspx")
                        winhttp.SetRequestHeader("Referer", "https://www.yourstage.com/mypage/sms.aspx")
                        winhttp.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded")
                        winhttp.Send("__EVENTTARGET=btnRegist&__EVENTARGUMENT=&__VIEWSTATE=%2FwEPDwUJNjQxNDAxODU2D2QWCGYPZBYGZg9kFghmDxYEHglpbm5lcmh0bWwFOTxiPmVobjEyMjU8L2I%2B64uYIDxzcGFuIHN0eWxlPSdmb250LXNpemU6N3B4Oyc%2B4pa8PC9zcGFuPh4HVmlzaWJsZWdkAgEPFgIfAWdkAgIPFgYeBGhyZWYFGi9tZW1iZXIvbWVtYmVyX2xvZ291dC5hc3B4HwAFDOuhnOq3uOyVhOybgx8BaGQCAw8WAh8BaGQCAQ9kFgJmDxYCHgtfIUl0ZW1Db3VudAIOFhxmD2QWAmYPFQQAHy9oZWxwL25vdGljZV92aWV3LmFzcHg%2FbnVtPTEwNzIADOuqqOuwlOydvOybuWQCAQ9kFgJmDxUEACYvY29tbXVuaXR5L2JvYXJkbGlzdC5hc3B4P3Nlcmllcz1mdW5ueQAW7J6s66%2B47J6I64qUIOydtOyVvOq4sGQCAg9kFgJmDxUEADZodHRwczovL3d3dy55b3Vyc3RhZ2UuY29tL2VuY29yZXNjaG9vbC9jbGFzc19saXN0LmFzcHgADOqwleyijOyLoOyyrWQCAw9kFgJmDxUEADdodHRwOi8vd3d3LnlvdXJzdGFnZS5jb20vaGVscC9ub3RpY2Vfdmlldy5hc3B4P251bT0xMTAwABDrqZTrpbTsiqQg7JiI67CpZAIED2QWAmYPFQQAFS9teXBhZ2UvbWFrZV9ibG9nLmFzcAAS67iU66Gc6re466eM65Ok6riwZAIFD2QWAmYPFQQAQmh0dHBzOi8vd3d3LnlvdXJzdGFnZS5jb20vZW5jb3Jlc2Nob29sL2NsYXNzX2RldGFpbC5hc3B4P3RocmVhZD05NgAZ7Iqk66eI7Yq47Y%2BwIOustOujjOqwleyijGQCBg9kFgJmDxUEABAvbXlwYWdlL3Ntcy5hc3B4AAzrrLTro4zrrLjsnpBkAgcPZBYCZg8VBAAeaHR0cDovL2NsdWIueW91cnN0YWdlLmNvbS9kb2JvAAzsnbjquLDtgbTrn71kAggPZBYCZg8VBABCaHR0cHM6Ly93d3cueW91cnN0YWdlLmNvbS9lbmNvcmVzY2hvb2wvY2xhc3NfZGV0YWlsLmFzcHg%2FdGhyZWFkPTk0ABztlZzrrLjqtZDsnKHsp4Drj4Tsgqwg6rCV7KKMZAIJD2QWAmYPFQQADi9saWZlL2pvYi5hc3B4AA%2FsnbzsnpDrpqzssL7quLBkAgoPZBYCZg8VBAApL2VuY29yZXNjaG9vbC9jbGFzc19kZXRhaWwuYXNweD90aHJlYWQ9ODkAEuyDgeyDneyVhOy5tOuNsOuvuGQCCw9kFgJmDxUEAEBodHRwczovL3d3dy55b3Vyc3RhZ2UuY29tL2NvbW11bml0eS9ib2FyZGxpc3QuYXNweD9zZXJpZXM9c2VjcmV0AAzqs6Drr7zsg4Hri7RkAgwPZBYCZg8VBAAfL2V2ZW50L2V2ZW50X3Byb2dyZXNzX2xpc3QuYXNweAARNuyblCDrrLTro4zqs7Xsl7BkAg0PZBYCZg8VBAEgEi9ldmVudC9hdHRlbmQuYXNweAAK7Lac7ISd67aAIGQCAg8WAh8BZ2QCAQ9kFgQCAQ8WAh8BZxYIAgkPDxYCHgRUZXh0BQEyZGQCCg8PFgIfBAUCNDhkZAIMDxYCHwFnZAINDxYCHwAFE%2BunpOuLrCA1MOqxtCDrrLTro4xkAgMPZBYCAgEPEGRkFgFmZAIDD2QWBGYPFgIfAwIHFg5mD2QWAmYPFQQJaW1wb3J0YW50BVBIT1RPBDM5MDMiNuyblOydmCA86rWs66as7ZWc6rCV7Iuc66%2B86rO17JuQPmQCAQ9kFgJmDxUECWltcG9ydGFudAVGVU5OWQQyMjcxHeykkeq1reynkSDsgqzsnqXsnZgg7Iic67Cc66ClZAICD2QWAmYPFQQJaW1wb3J0YW50BU1JTk9SBDM0MjQt7KCV7KO87JiBIO2ajOyepeuLmOydtCDrgqjquLQgMTbqsIDsp4Ag66qF7Ja4ZAIDD2QWAmYPFQQABVBIT1RPBDM5MDkg67aE6r2D7J20IO2UvOq4sCDsi5zsnpHtlojslrTsmpRkAgQPZBYCZg8VBAAFTUlOT1IEMzM5MgrruYgg66eI7J2MZAIFD2QWAmYPFQQABU1JTk9SBDM0MDMj7JeJ642p7J20LCDqtoHrkaXsnbQsIOuwqeuRpeydtC4uLj9kAgYPZBYCZg8VBAAFTUlOT1IEMzM0Mh3quLDtmozrpbwg67O8IOyImCDsnojripQg64iIIGQCAQ8WAh8DAgcWDmYPZBYCZg8VBQlpbXBvcnRhbnQFUEhPVE8EMzkwMwAiNuyblOydmCA86rWs66as7ZWc6rCV7Iuc66%2B86rO17JuQPmQCAQ9kFgJmDxUFCWltcG9ydGFudAVNSU5PUgQzNDAzACPsl4nrjansnbQsIOq2geuRpeydtCwg67Cp65Gl7J20Li4uP2QCAg9kFgJmDxUFCWltcG9ydGFudAVGVU5OWQQyMjcxAB3spJHqta3sp5Eg7IKs7J6l7J2YIOyInOuwnOugpWQCAw9kFgJmDxUFAAVGVU5OWQQyMjgxADI17J24IOqwgOyhseydtCAyNey4teyYpeyDgeyXkOyEnCDrlqjslrTsoYzripTrjbAuLmQCBA9kFgJmDxUFAAVQSE9UTwQzOTA5ACDrtoTqvYPsnbQg7ZS86riwIOyLnOyeke2WiOyWtOyalGQCBQ9kFgJmDxUFAAVNSU5PUgQzNDE5ABXsnpDquLAg67CU67O0IOyVhOuFgD9kAgYPZBYCZg8VBQAFTUlOT1IEMzM5NAAT7J6l7Z2s67mI7J2YIOy1nO2bhGQCBA9kFgRmDxYCHwMCBxYOZg9kFgJmDxUECWltcG9ydGFudAVNSU5PUgQzNDAzI%2ByXieuNqeydtCwg6raB65Gl7J20LCDrsKnrkaXsnbQuLi4%2FZAIBD2QWAmYPFQQJaW1wb3J0YW50BVBIT1RPBDM5MDMiNuyblOydmCA86rWs66as7ZWc6rCV7Iuc66%2B86rO17JuQPmQCAg9kFgJmDxUECWltcG9ydGFudAVQSE9UTwQzOTA5IOu2hOq9g%2BydtCDtlLzquLAg7Iuc7J6R7ZaI7Ja07JqUZAIDD2QWAmYPFQQABVBIT1RPBDM5MjYY7ZKN642V7LKc7J2YIDbsm5Qg7ZKN6rK9ZAIED2QWAmYPFQQABUZVTk5ZBDIyNzEd7KSR6rWt7KeRIOyCrOyepeydmCDsiJzrsJzroKVkAgUPZBYCZg8VBAAFTUlOT1IEMzQxORXsnpDquLAg67CU67O0IOyVhOuFgD9kAgYPZBYCZg8VBAAFRlVOTlkEMjI1NR7snoXsnYAg7JmcIO2VmOuCmOu%2FkOydvOq5jOyalD9kAgEPFgIfA2ZkZO4fpNxzWWeI3Gvz5%2BfN9UPBXij6OVICDKMF4qINnDGA&__VIEWSTATEGENERATOR=E13F7BF8&context=" & message1 & "&receiver1=" & TextBox4.Text & "&receiver2=" & TextBox5.Text & "&receiver3=&receiver4=&receiver5=&callback=" & Label7.Text)
                        winhttp.Open("GET", "https://www.yourstage.com/mypage/sms.aspx")
                        Label10.Text = "잔여건수 : " & Split(Split(winhttp.ResponseText, "<li class=""cnt""><span id=""senOk"">")(1), "</span>")(0) & "건"
                        For i As Integer = 0 To intever2 / 3
                            ListView1.Items(i).SubItems.Add("완료")
                            smsBox1.Text = i
                        Next
                        TextBoxcount.Text = intever2
                        Call checkboxClick(intever2 / 3, "CheckBox")
                        If TextBoxcount.Text = 15 Or InStr(winhttp.ResponseText, "고객님의 상품이 배달완료 되었습니다.") Then
                            Timer1.Stop()
                            Timer1.Enabled = False
                            Label8.Text = "실시간알림 작동여부 : 중지"
                            Text1.Enabled = True
                            Button1.Enabled = True
                            Button2.Enabled = True
                            GroupBox1.Enabled = True
                            GroupBox2.Enabled = True
                            GroupBox3.Enabled = True
                        End If
                    End If
                Case 1    '한진
                    winhttp.Open("POST", "http://www.hanjin.co.kr/Delivery_html/inquiry/result_waybill.jsp?wbl_num=" & Text1.Text)
                    winhttp.SetRequestHeader("Referer", "http://www.hanjin.co.kr/Delivery_html/inquiry/personal_inquiry.jsp")
                    winhttp.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded")
                    winhttp.Send("wbl_num=" & Text1.Text)
                    source = Split(Split(winhttp.ResponseText, "<caption>배송진행 상황</caption>")(1), "<ul class=""board_tip"">")(0)
                    If InStr(winhttp.ResponseText, "배송완료</strong> 되었습니다.") Then
                        ccount1 = UBound(Split(source, "<div align=""left"">")) - 1
                    Else
                        ccount1 = UBound(Split(source, "<div align=""left"">"))
                    End If
                    For i = 1 To ccount1 * 4   '리스트박스에 담기
                        source1 = Replace(Replace(Split(Split(source, "<td>")(i), "</td>")(0), vbTab, ""), " ", "")
                        If InStr(source1, "<divalign=""left"">") Then
                            List4.Items.Add(Replace(Replace(Replace(Replace(source1, "<divalign=""left"">", ""), "<strong>", ""), "</strong>", " "), "</div>", " "))
                        Else
                            List4.Items.Add(source1)
                        End If
                        If i = ccount1 * 4 Then   'last 처리, 배송완료만
                            For z = 1 To 2
                                List4.Items.Add(Split(Split(source, "<td rowspan=""2"" class=""bb""><b>")(z), "</b></td>")(0))
                                If z = 2 Then
                                    For h = 1 To 2
                                        source1 = Replace(Replace(Split(Split(source, "<td>")(h + i), "</td>")(0), vbTab, ""), " ", "")
                                        If InStr(source1, "<divalign=""left"">") Then
                                            List4.Items.Add(Replace(Replace(Replace(Replace(source1, "<divalign=""left"">", ""), "<strong>", ""), "</strong>", " "), "</div>", " "))
                                        Else
                                            List4.Items.Add(source1)
                                        End If
                                    Next
                                End If
                            Next
                        End If
                    Next
                    For z = 0 To List4.Items.Count
                        ListView1.Items.Add(List4.Items(z * 4))
                        ListView1.Items(z).SubItems.Add(List4.Items(4 * z + 1))
                        ListView1.Items(z).SubItems.Add(List4.Items(z * 4 + 3))
                    Next
                   Dim intever2 As Integer = List4.Items.Count
                    If RadioButton1.Checked = True Then
                        message1 = "<" & List4.Items(intever2 - 4) & ">"
                    ElseIf RadioButton2.Checked = True Then
                        message1 = "<" & List4.Items(intever2 - 4) & ">(" & List4.Items(intever2 - 3) & ")"
                    ElseIf RadioButton3.Checked = True Then
                        message1 = "<" & List4.Items(intever2 - 4) & ">(" & List4.Items(intever2 - 2) & ")" & List4.Items(intever2)
                    End If
                    For i As Integer = 0 To smsBox1.Text
                        ListView1.Items(i).SubItems.Add("완료")
                    Next
                    If TextBoxcount.Text < intever2 Then
                        winhttp.Open("POST", "https://www.yourstage.com/member/member_login.aspx?reurl=http%3a%2f%2fwww.yourstage.com%2fmypage%2fsms.aspx")
                        winhttp.SetRequestHeader("Referer", "https://www.yourstage.com/member/member_login.aspx?reurl=http%3a%2f%2fwww.yourstage.com%2fmypage%2fsms.aspx")
                        winhttp.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded")
                        winhttp.Send("__VIEWSTATE=%2FwEPDwUKLTY0NDQ4ODA5MQ9kFgRmD2QWBmYPZBYCAgIPFgQeBGhyZWYFugFodHRwOi8vd3d3LnlvdXJzdGFnZS5jb20vbWVtYmVyL21lbWJlcl9sb2dpbi5hc3B4P3JldXJsPWh0dHAlM2ElMmYlMmZ3d3cueW91cnN0YWdlLmNvbSUyZm1lbWJlciUyZm1lbWJlcl9sb2dpbi5hc3B4JTNmcmV1cmwlM2RodHRwJTI1M2ElMjUyZiUyNTJmd3d3LnlvdXJzdGFnZS5jb20lMjUyZm15cGFnZSUyNTJmc21zLmFzcHgeCWlubmVyaHRtbAUJ66Gc6re47J24ZAIBD2QWAmYPFgIeC18hSXRlbUNvdW50Ag4WHGYPZBYCZg8VBAAmL2NvbW11bml0eS9ib2FyZGxpc3QuYXNweD9zZXJpZXM9ZnVubnkAFuyerOuvuOyeiOuKlCDsnbTslbzquLBkAgEPZBYCZg8VBAAQL215cGFnZS9zbXMuYXNweAAM66y066OM66y47J6QZAICD2QWAmYPFQQAQmh0dHBzOi8vd3d3LnlvdXJzdGFnZS5jb20vZW5jb3Jlc2Nob29sL2NsYXNzX2RldGFpbC5hc3B4P3RocmVhZD05NAAc7ZWc66y46rWQ7Jyh7KeA64%2BE7IKsIOqwleyijGQCAw9kFgJmDxUEAB5odHRwOi8vY2x1Yi55b3Vyc3RhZ2UuY29tL2RvYm8ADOyduOq4sO2BtOufvWQCBA9kFgJmDxUEABUvbXlwYWdlL21ha2VfYmxvZy5hc3AAEuu4lOuhnOq3uOunjOuTpOq4sGQCBQ9kFgJmDxUEADZodHRwczovL3d3dy55b3Vyc3RhZ2UuY29tL2VuY29yZXNjaG9vbC9jbGFzc19saXN0LmFzcHgADOqwleyijOyLoOyyrWQCBg9kFgJmDxUEADdodHRwOi8vd3d3LnlvdXJzdGFnZS5jb20vaGVscC9ub3RpY2Vfdmlldy5hc3B4P251bT0xMTAwABDrqZTrpbTsiqQg7JiI67CpZAIHD2QWAmYPFQQAHy9ldmVudC9ldmVudF9wcm9ncmVzc19saXN0LmFzcHgAETbsm5Qg66y066OM6rO17JewZAIID2QWAmYPFQQAQGh0dHBzOi8vd3d3LnlvdXJzdGFnZS5jb20vY29tbXVuaXR5L2JvYXJkbGlzdC5hc3B4P3Nlcmllcz1zZWNyZXQADOqzoOuvvOyDgeuLtGQCCQ9kFgJmDxUEACkvZW5jb3Jlc2Nob29sL2NsYXNzX2RldGFpbC5hc3B4P3RocmVhZD04OQAS7IOB7IOd7JWE7Lm0642w66%2B4ZAIKD2QWAmYPFQQADi9saWZlL2pvYi5hc3B4AA%2FsnbzsnpDrpqzssL7quLBkAgsPZBYCZg8VBABCaHR0cHM6Ly93d3cueW91cnN0YWdlLmNvbS9lbmNvcmVzY2hvb2wvY2xhc3NfZGV0YWlsLmFzcHg%2FdGhyZWFkPTk2ABnsiqTrp4jtirjtj7Ag66y066OM6rCV7KKMZAIMD2QWAmYPFQQAEi9ldmVudC9hdHRlbmQuYXNweAAK7Lac7ISd67aAIGQCDQ9kFgJmDxUEASAfL2hlbHAvbm90aWNlX3ZpZXcuYXNweD9udW09MTA3MgAM66qo67CU7J287Ju5ZAICDxYCHgdWaXNpYmxlZ2QCAQ9kFgICCQ8PFgIeD0NvbW1hbmRBcmd1bWVudAUoaHR0cDovL3d3dy55b3Vyc3RhZ2UuY29tL215cGFnZS9zbXMuYXNweGRkGAEFHl9fQ29udHJvbHNSZXF1aXJlUG9zdEJhY2tLZXlfXxYCBRFrZWVwX2xvZ2luX3N0YXR1cwUDc3Ns1LepHMfhfXOMDzkiGGnd9JTGvaWVgCcEL8J8tv05n%2BA%3D&__VIEWSTATEGENERATOR=5795B9CA&email=" & TextBox2.Text & "&pw=" & TextBox3.Text & "&btnLogin=%EB%A1%9C%EA%B7%B8%EC%9D%B8")
                        System.Threading.Thread.Sleep(100)
                        winhttp.Open("POST", "https://www.yourstage.com/mypage/sms.aspx")
                        winhttp.SetRequestHeader("Referer", "https://www.yourstage.com/mypage/sms.aspx")
                        winhttp.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded")
                        winhttp.Send("__EVENTTARGET=btnRegist&__EVENTARGUMENT=&__VIEWSTATE=%2FwEPDwUJNjQxNDAxODU2D2QWCGYPZBYGZg9kFghmDxYEHglpbm5lcmh0bWwFOTxiPmVobjEyMjU8L2I%2B64uYIDxzcGFuIHN0eWxlPSdmb250LXNpemU6N3B4Oyc%2B4pa8PC9zcGFuPh4HVmlzaWJsZWdkAgEPFgIfAWdkAgIPFgYeBGhyZWYFGi9tZW1iZXIvbWVtYmVyX2xvZ291dC5hc3B4HwAFDOuhnOq3uOyVhOybgx8BaGQCAw8WAh8BaGQCAQ9kFgJmDxYCHgtfIUl0ZW1Db3VudAIOFhxmD2QWAmYPFQQAHy9oZWxwL25vdGljZV92aWV3LmFzcHg%2FbnVtPTEwNzIADOuqqOuwlOydvOybuWQCAQ9kFgJmDxUEACYvY29tbXVuaXR5L2JvYXJkbGlzdC5hc3B4P3Nlcmllcz1mdW5ueQAW7J6s66%2B47J6I64qUIOydtOyVvOq4sGQCAg9kFgJmDxUEADZodHRwczovL3d3dy55b3Vyc3RhZ2UuY29tL2VuY29yZXNjaG9vbC9jbGFzc19saXN0LmFzcHgADOqwleyijOyLoOyyrWQCAw9kFgJmDxUEADdodHRwOi8vd3d3LnlvdXJzdGFnZS5jb20vaGVscC9ub3RpY2Vfdmlldy5hc3B4P251bT0xMTAwABDrqZTrpbTsiqQg7JiI67CpZAIED2QWAmYPFQQAFS9teXBhZ2UvbWFrZV9ibG9nLmFzcAAS67iU66Gc6re466eM65Ok6riwZAIFD2QWAmYPFQQAQmh0dHBzOi8vd3d3LnlvdXJzdGFnZS5jb20vZW5jb3Jlc2Nob29sL2NsYXNzX2RldGFpbC5hc3B4P3RocmVhZD05NgAZ7Iqk66eI7Yq47Y%2BwIOustOujjOqwleyijGQCBg9kFgJmDxUEABAvbXlwYWdlL3Ntcy5hc3B4AAzrrLTro4zrrLjsnpBkAgcPZBYCZg8VBAAeaHR0cDovL2NsdWIueW91cnN0YWdlLmNvbS9kb2JvAAzsnbjquLDtgbTrn71kAggPZBYCZg8VBABCaHR0cHM6Ly93d3cueW91cnN0YWdlLmNvbS9lbmNvcmVzY2hvb2wvY2xhc3NfZGV0YWlsLmFzcHg%2FdGhyZWFkPTk0ABztlZzrrLjqtZDsnKHsp4Drj4Tsgqwg6rCV7KKMZAIJD2QWAmYPFQQADi9saWZlL2pvYi5hc3B4AA%2FsnbzsnpDrpqzssL7quLBkAgoPZBYCZg8VBAApL2VuY29yZXNjaG9vbC9jbGFzc19kZXRhaWwuYXNweD90aHJlYWQ9ODkAEuyDgeyDneyVhOy5tOuNsOuvuGQCCw9kFgJmDxUEAEBodHRwczovL3d3dy55b3Vyc3RhZ2UuY29tL2NvbW11bml0eS9ib2FyZGxpc3QuYXNweD9zZXJpZXM9c2VjcmV0AAzqs6Drr7zsg4Hri7RkAgwPZBYCZg8VBAAfL2V2ZW50L2V2ZW50X3Byb2dyZXNzX2xpc3QuYXNweAARNuyblCDrrLTro4zqs7Xsl7BkAg0PZBYCZg8VBAEgEi9ldmVudC9hdHRlbmQuYXNweAAK7Lac7ISd67aAIGQCAg8WAh8BZ2QCAQ9kFgQCAQ8WAh8BZxYIAgkPDxYCHgRUZXh0BQEyZGQCCg8PFgIfBAUCNDhkZAIMDxYCHwFnZAINDxYCHwAFE%2BunpOuLrCA1MOqxtCDrrLTro4xkAgMPZBYCAgEPEGRkFgFmZAIDD2QWBGYPFgIfAwIHFg5mD2QWAmYPFQQJaW1wb3J0YW50BVBIT1RPBDM5MDMiNuyblOydmCA86rWs66as7ZWc6rCV7Iuc66%2B86rO17JuQPmQCAQ9kFgJmDxUECWltcG9ydGFudAVGVU5OWQQyMjcxHeykkeq1reynkSDsgqzsnqXsnZgg7Iic67Cc66ClZAICD2QWAmYPFQQJaW1wb3J0YW50BU1JTk9SBDM0MjQt7KCV7KO87JiBIO2ajOyepeuLmOydtCDrgqjquLQgMTbqsIDsp4Ag66qF7Ja4ZAIDD2QWAmYPFQQABVBIT1RPBDM5MDkg67aE6r2D7J20IO2UvOq4sCDsi5zsnpHtlojslrTsmpRkAgQPZBYCZg8VBAAFTUlOT1IEMzM5MgrruYgg66eI7J2MZAIFD2QWAmYPFQQABU1JTk9SBDM0MDMj7JeJ642p7J20LCDqtoHrkaXsnbQsIOuwqeuRpeydtC4uLj9kAgYPZBYCZg8VBAAFTUlOT1IEMzM0Mh3quLDtmozrpbwg67O8IOyImCDsnojripQg64iIIGQCAQ8WAh8DAgcWDmYPZBYCZg8VBQlpbXBvcnRhbnQFUEhPVE8EMzkwMwAiNuyblOydmCA86rWs66as7ZWc6rCV7Iuc66%2B86rO17JuQPmQCAQ9kFgJmDxUFCWltcG9ydGFudAVNSU5PUgQzNDAzACPsl4nrjansnbQsIOq2geuRpeydtCwg67Cp65Gl7J20Li4uP2QCAg9kFgJmDxUFCWltcG9ydGFudAVGVU5OWQQyMjcxAB3spJHqta3sp5Eg7IKs7J6l7J2YIOyInOuwnOugpWQCAw9kFgJmDxUFAAVGVU5OWQQyMjgxADI17J24IOqwgOyhseydtCAyNey4teyYpeyDgeyXkOyEnCDrlqjslrTsoYzripTrjbAuLmQCBA9kFgJmDxUFAAVQSE9UTwQzOTA5ACDrtoTqvYPsnbQg7ZS86riwIOyLnOyeke2WiOyWtOyalGQCBQ9kFgJmDxUFAAVNSU5PUgQzNDE5ABXsnpDquLAg67CU67O0IOyVhOuFgD9kAgYPZBYCZg8VBQAFTUlOT1IEMzM5NAAT7J6l7Z2s67mI7J2YIOy1nO2bhGQCBA9kFgRmDxYCHwMCBxYOZg9kFgJmDxUECWltcG9ydGFudAVNSU5PUgQzNDAzI%2ByXieuNqeydtCwg6raB65Gl7J20LCDrsKnrkaXsnbQuLi4%2FZAIBD2QWAmYPFQQJaW1wb3J0YW50BVBIT1RPBDM5MDMiNuyblOydmCA86rWs66as7ZWc6rCV7Iuc66%2B86rO17JuQPmQCAg9kFgJmDxUECWltcG9ydGFudAVQSE9UTwQzOTA5IOu2hOq9g%2BydtCDtlLzquLAg7Iuc7J6R7ZaI7Ja07JqUZAIDD2QWAmYPFQQABVBIT1RPBDM5MjYY7ZKN642V7LKc7J2YIDbsm5Qg7ZKN6rK9ZAIED2QWAmYPFQQABUZVTk5ZBDIyNzEd7KSR6rWt7KeRIOyCrOyepeydmCDsiJzrsJzroKVkAgUPZBYCZg8VBAAFTUlOT1IEMzQxORXsnpDquLAg67CU67O0IOyVhOuFgD9kAgYPZBYCZg8VBAAFRlVOTlkEMjI1NR7snoXsnYAg7JmcIO2VmOuCmOu%2FkOydvOq5jOyalD9kAgEPFgIfA2ZkZO4fpNxzWWeI3Gvz5%2BfN9UPBXij6OVICDKMF4qINnDGA&__VIEWSTATEGENERATOR=E13F7BF8&context=" & message1 & "&receiver1=" & TextBox4.Text & "&receiver2=" & TextBox5.Text & "&receiver3=&receiver4=&receiver5=&callback=" & Label7.Text)
                        winhttp.Open("GET", "https://www.yourstage.com/mypage/sms.aspx")
                        Label10.Text = "잔여건수 : " & Split(Split(winhttp.ResponseText, "<li class=""cnt""><span id=""senOk"">")(1), "</span>")(0) & "건"
                        For i As Integer = 0 To intever2 / 4
                            ListView1.Items(i).SubItems.Add("완료")
                            smsBox1.Text = i
                        Next
                        TextBoxcount.Text = intever2
                        Call checkboxClick(intever2, "CheckBox")
                        If TextBoxcount.Text = 5 Then
                            Timer1.Stop()
                            Timer1.Enabled = False
                            Label8.Text = "실시간알림 작동여부 : 중지"
                            Text1.Enabled = True
                            Button1.Enabled = True
                            GroupBox1.Enabled = True
                            GroupBox2.Enabled = True
                            GroupBox3.Enabled = True
                        End If
                    End If
            End Select
        End If

    End Sub

End Class