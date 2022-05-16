Public Class Form3
    Private Sub HazelDev_Button1_Click(sender As Object, e As EventArgs) Handles HazelDev_Button1.Click
        Dim Index As Integer = ComboBox1.SelectedIndex
        Select Case Index
            Case 0
                If TextBox1.Text = "" Then
                    MsgBox("종료할 분을 입력해주세요")
                Else
                    Shell("C:\Windows\System32\cmd.exe /k" & "shutdown -s -t " & TextBox1.Text * 60, vbHide)
                End If
            Case 1
                Shell("C:\Windows\System32\cmd.exe /k" & "shutdown/a", vbHide)
        End Select
    End Sub
End Class