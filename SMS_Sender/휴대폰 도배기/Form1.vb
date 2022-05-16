Public Class Form1
    Dim winhttp As New WinHttp.WinHttpRequest
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        winhttp.Open("POST", "https://www.yourstage.com/member/member_login.aspx?reurl=http%3a%2f%2fwww.yourstage.com%2fmypage%2fsms.aspx")
        winhttp.SetRequestHeader("Referer", "https://www.yourstage.com/member/member_login.aspx?reurl=http%3a%2f%2fwww.yourstage.com%2fmypage%2fsms.aspx")
        winhttp.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded")
        winhttp.Send("__VIEWSTATE=%2FwEPDwUKLTY0NDQ4ODA5MQ9kFgRmD2QWBmYPZBYCAgMPFgQeBGhyZWYFugFodHRwOi8vd3d3LnlvdXJzdGFnZS5jb20vbWVtYmVyL21lbWJlcl9sb2dpbi5hc3B4P3JldXJsPWh0dHAlM2ElMmYlMmZ3d3cueW91cnN0YWdlLmNvbSUyZm1lbWJlciUyZm1lbWJlcl9sb2dpbi5hc3B4JTNmcmV1cmwlM2RodHRwJTI1M2ElMjUyZiUyNTJmd3d3LnlvdXJzdGFnZS5jb20lMjUyZm15cGFnZSUyNTJmc21zLmFzcHgeCWlubmVyaHRtbAUJ66Gc6re47J24ZAIBD2QWAmYPFgIeC18hSXRlbUNvdW50AgUWCmYPZBYCZg8VBAVmaXJzdB8vaGVscC9ub3RpY2Vfdmlldy5hc3B4P251bT0xMDU0AAxTTlPrpqzribTslrxkAgEPZBYCZg8VBAAfL2V2ZW50L2V2ZW50X3Byb2dyZXNzX2xpc3QuYXNweAAU66y066OMIOqzteyXsCDstIjrjIBkAgIPZBYCZg8VBAAUL3JlcG9ydGVyL2FwcGx5LmFzcHgAEuyLnOuLiOyWtOumrO2PrO2EsGQCAw9kFgJmDxUEACYvY29tbXVuaXR5L2JvYXJkbGlzdC5hc3B4P3Nlcmllcz1mdW5ueQAW7J6s66%2B47J6I64qUIOydtOyVvOq4sGQCBA9kFgJmDxUEBSBsYXN0Ei9ldmVudC9hdHRlbmQuYXNweAAK7Lac7ISd67aAIGQCAg8WAh4HVmlzaWJsZWdkAgEPZBYCAgkPDxYCHg9Db21tYW5kQXJndW1lbnQFKGh0dHA6Ly93d3cueW91cnN0YWdlLmNvbS9teXBhZ2Uvc21zLmFzcHhkZBgBBR5fX0NvbnRyb2xzUmVxdWlyZVBvc3RCYWNrS2V5X18WAgURa2VlcF9sb2dpbl9zdGF0dXMFA3NzbP0aM0ihs8EbhAtQJ3T%2F1JQV43fBmTeg5yS%2F2EG8AnsD&email=" & Form2.TextBox1.Text & "&pw=" & Form2.TextBox2.Text & "&btnLogin=%EB%A1%9C%EA%B7%B8%EC%9D%B8")
        winhttp.Open("GET", "https://www.yourstage.com/mypage/sms.aspx")
        winhttp.Send()
        text7.Text = Split(Split(winhttp.ResponseText, "readonly=""readonly"" value=""")(1), """ /></li>")(0)
        Label8.Text = "잔여건수 : " & Split(Split(winhttp.ResponseText, "<li class=""cnt""><span id=""senOk"">")(1), "</span>")(0) & "건"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error Resume Next
        winhttp.Open("POST", "https://www.yourstage.com/member/member_login.aspx?reurl=http%3a%2f%2fwww.yourstage.com%2fmypage%2fsms.aspx")
        winhttp.SetRequestHeader("Referer", "https://www.yourstage.com/member/member_login.aspx?reurl=http%3a%2f%2fwww.yourstage.com%2fmypage%2fsms.aspx")
        winhttp.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded")
        winhttp.Send("__VIEWSTATE=%2FwEPDwUKLTY0NDQ4ODA5MQ9kFgRmD2QWBmYPZBYCAgMPFgQeBGhyZWYFugFodHRwOi8vd3d3LnlvdXJzdGFnZS5jb20vbWVtYmVyL21lbWJlcl9sb2dpbi5hc3B4P3JldXJsPWh0dHAlM2ElMmYlMmZ3d3cueW91cnN0YWdlLmNvbSUyZm1lbWJlciUyZm1lbWJlcl9sb2dpbi5hc3B4JTNmcmV1cmwlM2RodHRwJTI1M2ElMjUyZiUyNTJmd3d3LnlvdXJzdGFnZS5jb20lMjUyZm15cGFnZSUyNTJmc21zLmFzcHgeCWlubmVyaHRtbAUJ66Gc6re47J24ZAIBD2QWAmYPFgIeC18hSXRlbUNvdW50AgUWCmYPZBYCZg8VBAVmaXJzdB8vaGVscC9ub3RpY2Vfdmlldy5hc3B4P251bT0xMDU0AAxTTlPrpqzribTslrxkAgEPZBYCZg8VBAAfL2V2ZW50L2V2ZW50X3Byb2dyZXNzX2xpc3QuYXNweAAU66y066OMIOqzteyXsCDstIjrjIBkAgIPZBYCZg8VBAAUL3JlcG9ydGVyL2FwcGx5LmFzcHgAEuyLnOuLiOyWtOumrO2PrO2EsGQCAw9kFgJmDxUEACYvY29tbXVuaXR5L2JvYXJkbGlzdC5hc3B4P3Nlcmllcz1mdW5ueQAW7J6s66%2B47J6I64qUIOydtOyVvOq4sGQCBA9kFgJmDxUEBSBsYXN0Ei9ldmVudC9hdHRlbmQuYXNweAAK7Lac7ISd67aAIGQCAg8WAh4HVmlzaWJsZWdkAgEPZBYCAgkPDxYCHg9Db21tYW5kQXJndW1lbnQFKGh0dHA6Ly93d3cueW91cnN0YWdlLmNvbS9teXBhZ2Uvc21zLmFzcHhkZBgBBR5fX0NvbnRyb2xzUmVxdWlyZVBvc3RCYWNrS2V5X18WAgURa2VlcF9sb2dpbl9zdGF0dXMFA3NzbP0aM0ihs8EbhAtQJ3T%2F1JQV43fBmTeg5yS%2F2EG8AnsD&email=" & Form2.TextBox1.Text & "&pw=" & Form2.TextBox2.Text & "&btnLogin=%EB%A1%9C%EA%B7%B8%EC%9D%B8")
        System.Threading.Thread.Sleep(100)
        winhttp.Open("POST", "https://www.yourstage.com/mypage/sms.aspx")
        winhttp.SetRequestHeader("Referer", "https://www.yourstage.com/mypage/sms.aspx")
        winhttp.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded")
        winhttp.Send("__EVENTTARGET=btnRegist&__EVENTARGUMENT=&__VIEWSTATE=%2FwEPDwUJNjQxNDAxODU2D2QWCGYPZBYGZg9kFghmDxYEHglpbm5lcmh0bWwFCmVobjEyMjXri5geB1Zpc2libGVnZAIBDxYCHwFnFgYCAQ8WAh8ABR7rgpjsnZgg65Ox6riJIDog7J2867CYIDHroIjrsqhkAgMPFgIfAAU5PGEgaHJlZj0iaHR0cDovL3Nucy55b3Vyc3RhZ2UuY29tL2VobjEyMjUiPuuCmOydmCBTTlM8L2E%2BZAIFDxYCHwFoZAICDxYCHwFoZAIDDxYEHgRocmVmBRovbWVtYmVyL21lbWJlcl9sb2dvdXQuYXNweB8ABQzroZzqt7jslYTsm4NkAgEPZBYCZg8WAh4LXyFJdGVtQ291bnQCBRYKZg9kFgJmDxUEBWZpcnN0Hy9oZWxwL25vdGljZV92aWV3LmFzcHg%2FbnVtPTEwNTQADFNOU%2BumrOuJtOyWvGQCAQ9kFgJmDxUEAB8vZXZlbnQvZXZlbnRfcHJvZ3Jlc3NfbGlzdC5hc3B4ABTrrLTro4wg6rO17JewIOy0iOuMgGQCAg9kFgJmDxUEABQvcmVwb3J0ZXIvYXBwbHkuYXNweAAS7Iuc64uI7Ja066as7Y%2Bs7YSwZAIDD2QWAmYPFQQAJi9jb21tdW5pdHkvYm9hcmRsaXN0LmFzcHg%2Fc2VyaWVzPWZ1bm55ABbsnqzrr7jsnojripQg7J207JW86riwZAIED2QWAmYPFQQFIGxhc3QSL2V2ZW50L2F0dGVuZC5hc3B4AArstpzshJ3rtoAgZAICDxYCHwFnZAIBD2QWBAIBDxYCHwFnFggCCQ8PFgIeBFRleHQFATFkZAIKDw8WAh8EBQI5OWRkAgwPFgIfAWdkAg0PFgIfAAUU66ek64usIDEwMOqxtCDrrLTro4xkAgMPZBYCAgEPEGRkFgFmZAIDD2QWBGYPFgIfAwIHFg5mD2QWAmYPFQQJaW1wb3J0YW50BlNFQ1JFVAM2MDcy64K06rCAIOuwnOqyrO2VnCDsnKDslrTsiqTthYzsnbTsp4Ag66y47ZmU7J2067KkLi5kAgEPZBYCZg8VBAlpbXBvcnRhbnQFTUlOT1IEMjAwMifshLjsg4Hsl5DshJwg6rCA7J6lIOqwgOuCnO2VnCDrjIDthrXroLlkAgIPZBYCZg8VBAlpbXBvcnRhbnQFTUlOT1IEMTk3MiDrp4jsnYzsho3snZgg7L%2B17L%2B17ZWY64qUIOyGjOumrGQCAw9kFgJmDxUEAAVNSU5PUgQxOTkwM%2B2PieyImCDqs4TsgrDtlZjripDrnbwg7Iqk7Yq466CI7IqkIOuwm%2BuKlCDrtoTrk6R%2BfmQCBA9kFgJmDxUEAAVGVU5OWQQxMzQ0E%2B2VoOuouOuLiOydmCDsg4Hsi51kAgUPZBYCZg8VBAAFTUlOT1IEMjAxNi5bJ%2Bq3uOumrOqzoCDrgpjshJwn7JmAICfqt7jrn6zqs6Ag64KY7IScJ%2BydmC4uZAIGD2QWAmYPFQQABU1JTk9SBDE5NzkcW%2ByaseyLoOqxsOumrOuKlCDsnbQg7IS47JuUXWQCAQ8WAh8DAgcWDmYPZBYCZg8VBQlpbXBvcnRhbnQFUEhPVE8EMTY5OQAc66%2B466asIOuztOuKlCAn67SE66ee7J206r2DJ2QCAQ9kFgJmDxUFCWltcG9ydGFudAVNSU5PUgQxOTg0ACpbJ%2BuFueyKqCfqs7wgJ%2BuFueyKrOydgCdd7J2YIOuwlOuluCDtkZztmIRkAgIPZBYCZg8VBQlpbXBvcnRhbnQFTUlOT1IEMTk3OQAcW%2ByaseyLoOqxsOumrOuKlCDsnbQg7IS47JuUXWQCAw9kFgJmDxUFAAVQSE9UTwQxNzE0AA3rgpjsnZgg7JeE66eIZAIED2QWAmYPFQUABU1JTk9SBDE5OTAAM%2B2PieyImCDqs4TsgrDtlZjripDrnbwg7Iqk7Yq466CI7IqkIOuwm%2BuKlCDrtoTrk6R%2BfmQCBQ9kFgJmDxUFAAVNSU5PUgQyMDAyACfshLjsg4Hsl5DshJwg6rCA7J6lIOqwgOuCnO2VnCDrjIDthrXroLlkAgYPZBYCZg8VBQAFRlVOTlkEMTM2NAAQ64Kt7YyoIOyLnOumrOymiGQCBA9kFgRmDxYCHwMCBxYOZg9kFgJmDxUECWltcG9ydGFudAVNSU5PUgQxOTkwM%2B2PieyImCDqs4TsgrDtlZjripDrnbwg7Iqk7Yq466CI7IqkIOuwm%2BuKlCDrtoTrk6R%2BfmQCAQ9kFgJmDxUECWltcG9ydGFudAVNSU5PUgQxOTc5HFvsmrHsi6DqsbDrpqzripQg7J20IOyEuOyblF1kAgIPZBYCZg8VBAlpbXBvcnRhbnQFTUlOT1IEMjAxNi5bJ%2Bq3uOumrOqzoCDrgpjshJwn7JmAICfqt7jrn6zqs6Ag64KY7IScJ%2BydmC4uZAIDD2QWAmYPFQQABVBIT1RPBDE2OTkc66%2B466asIOuztOuKlCAn67SE66ee7J206r2DJ2QCBA9kFgJmDxUEAAVQSE9UTwQxNjY5Buq9g%2BuLtGQCBQ9kFgJmDxUEAAVQSE9UTwQxNjgwKe2SjeuFhO2ZlOqwgCDtlLzsl4jslrTsmpQt7ZmN66aJ7IiY66qp7JuQZAIGD2QWAmYPFQQABU1JTk9SBDE5ODQqWyfrhbnsiqgn6rO8ICfrhbnsiqzsnYAnXeydmCDrsJTrpbgg7ZGc7ZiEZAIBDxYCHwMCAxYGZg9kFgJmDxUFCWltcG9ydGFudAVwaG90bwQxNzE0CyNyZXBseTEzMDA0Meu2gOuqqOulvCDsg53qsIHtlZjripQg7J6Q7Iud7J2YIOuniOydjCEg7Zqo64WALi5kAgEPZBYCZg8VBQlpbXBvcnRhbnQFcGhvdG8EMTcxNAsjcmVwbHkxMjk3My3rlLDri5jsnYQg7LC4IOyemCDtgqTsmrDsi6Ag67aE65Ok7J6F64uI64ukLiBkAgIPZBYCZg8VBQlpbXBvcnRhbnQFcGhvdG8EMTcxNAsjcmVwbHkxMjk1NDLsmIgsIOyggOuPhCDrhIjrrLQg6riw7Yq57ZW07IScIOy5reywrOydhCDrp47slYQuLmRkTJW6j4D3vDt2ImJvHQsliGloULqO4z0BxH0GY5yDDYs%3D&context=" & text2.Text & "&receiver1=" & Text1.Text & "&receiver2=" & text3.Text & "&receiver3=" & text4.Text & "&receiver4=" & text5.Text & "&receiver5=" & text6.Text & "&callback=" & text7.Text)
        
        If InStr(winhttp.ResponseText, "SMS 발송이 1건 완료되었습니다.") Then
            MsgBox("문자 1건을 성공적으로 전송하였습니다!")
        End If
        If InStr(winhttp.ResponseText, "SMS 발송이 2건 완료되었습니다.") Then
            MsgBox("문자 2건을 성공적으로 전송하였습니다!")
        End If
        If InStr(winhttp.ResponseText, "SMS 발송이 3건 완료되었습니다.") Then
            MsgBox("문자 3건을 성공적으로 전송하였습니다!")
        End If
        If InStr(winhttp.ResponseText, "SMS 발송이 4건 완료되었습니다.") Then
            MsgBox("문자 4건을 성공적으로 전송하였습니다!")
        End If
        If InStr(winhttp.ResponseText, "SMS 발송이 5건 완료되었습니다.") Then
            MsgBox("문자 5건을 성공적으로 전송하였습니다!")
        End If
        Text1.Text = ""
        text2.Text = ""
        text3.Text = ""
        text4.Text = ""
        text5.Text = ""
        text6.Text = ""

        Label8.Text = "잔여건수 : " & Split(Split(winhttp.ResponseText, "<li class=""cnt""><span id=""senOk"">")(1), "</span>")(0) & "건"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("https://www.yourstage.com/")
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MsgBox("정말로 종료하시겠습니까?.", vbYesNo, "메세지 전송기 종료") = vbYes Then
            Form2.Close()
        Else
            e.Cancel = True
        End If
    End Sub
End Class
