Public Class Form2
    Dim winhttp As New WinHttp.WinHttpRequest
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not My.Settings.id = "" Or My.Settings.pw = "" Then
            TextBox1.Text = My.Settings.id
            TextBox2.Text = My.Settings.pw
        End If
    End Sub
    Private Sub InfluenceButton1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        winhttp.Open("POST", "https://www.yourstage.com/member/member_login.aspx?reurl=http%3a%2f%2fwww.yourstage.com%2fmypage%2fsms.aspx")
        winhttp.SetRequestHeader("Referer", "https://www.yourstage.com/member/member_login.aspx?reurl=http%3a%2f%2fwww.yourstage.com%2fmypage%2fsms.aspx")
        winhttp.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded")
        winhttp.Send("__VIEWSTATE=%2FwEPDwUKLTY0NDQ4ODA5MQ9kFgRmD2QWBmYPZBYCAgMPFgQeBGhyZWYFugFodHRwOi8vd3d3LnlvdXJzdGFnZS5jb20vbWVtYmVyL21lbWJlcl9sb2dpbi5hc3B4P3JldXJsPWh0dHAlM2ElMmYlMmZ3d3cueW91cnN0YWdlLmNvbSUyZm1lbWJlciUyZm1lbWJlcl9sb2dpbi5hc3B4JTNmcmV1cmwlM2RodHRwJTI1M2ElMjUyZiUyNTJmd3d3LnlvdXJzdGFnZS5jb20lMjUyZm15cGFnZSUyNTJmc21zLmFzcHgeCWlubmVyaHRtbAUJ66Gc6re47J24ZAIBD2QWAmYPFgIeC18hSXRlbUNvdW50AgUWCmYPZBYCZg8VBAVmaXJzdB8vaGVscC9ub3RpY2Vfdmlldy5hc3B4P251bT0xMDU0AAxTTlPrpqzribTslrxkAgEPZBYCZg8VBAAfL2V2ZW50L2V2ZW50X3Byb2dyZXNzX2xpc3QuYXNweAAU66y066OMIOqzteyXsCDstIjrjIBkAgIPZBYCZg8VBAAUL3JlcG9ydGVyL2FwcGx5LmFzcHgAEuyLnOuLiOyWtOumrO2PrO2EsGQCAw9kFgJmDxUEACYvY29tbXVuaXR5L2JvYXJkbGlzdC5hc3B4P3Nlcmllcz1mdW5ueQAW7J6s66%2B47J6I64qUIOydtOyVvOq4sGQCBA9kFgJmDxUEBSBsYXN0Ei9ldmVudC9hdHRlbmQuYXNweAAK7Lac7ISd67aAIGQCAg8WAh4HVmlzaWJsZWdkAgEPZBYCAgkPDxYCHg9Db21tYW5kQXJndW1lbnQFKGh0dHA6Ly93d3cueW91cnN0YWdlLmNvbS9teXBhZ2Uvc21zLmFzcHhkZBgBBR5fX0NvbnRyb2xzUmVxdWlyZVBvc3RCYWNrS2V5X18WAgURa2VlcF9sb2dpbl9zdGF0dXMFA3NzbP0aM0ihs8EbhAtQJ3T%2F1JQV43fBmTeg5yS%2F2EG8AnsD&email=" & TextBox1.Text & "&pw=" & TextBox2.Text & "&btnLogin=%EB%A1%9C%EA%B7%B8%EC%9D%B8")
        If InStr(winhttp.ResponseText, "등록된 아이디가 없습니다.") Or InStr(winhttp.ResponseText, "비밀번호가 맞지 않습니다.") Then
            MsgBox("존재하지않는 ID or PW입니다.")
        Else
            Form1.Show()
        End If
        If CheckBox1.Checked = True Then
            My.Settings.id = TextBox1.Text
            My.Settings.pw = TextBox2.Text
        End If
    End Sub

    Private Sub InfluenceButton2_Click(sender As Object, e As EventArgs) Handles InfluenceButton2.Click
        Process.Start("https://www.yourstage.com/member/member_register.aspx")
    End Sub
End Class