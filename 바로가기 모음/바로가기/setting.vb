Public Class setting
    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        On Error Resume Next
        If GetSetting("바로가기", "바로가기", "Botton" & ComboBox1.SelectedItem, "") = "" Then
            TextBox1.Text = ""
            TextBox2.Text = ""
        Else
            TextBox1.Text = Split(Split(GetSetting("바로가기", "바로가기", "Botton" & ComboBox1.SelectedItem, ""), "<1>")(1), "<1>")(0)
            TextBox2.Text = Split(Split(GetSetting("바로가기", "바로가기", "Botton" & ComboBox1.SelectedItem, ""), "<2>")(1), "<2>")(0)
        End If
         End Sub
    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        On Error Resume Next
        TextBox1.Text = Split(Split(GetSetting("바로가기", "바로가기", "Botton" & ComboBox1.Text, ""), "<1>")(1), "<1>")(0)
        TextBox2.Text = Split(Split(GetSetting("바로가기", "바로가기", "Botton" & ComboBox1.Text, ""), "<2>")(1), "<2>")(0)
        If GetSetting("바로가기", "바로가기", "Botton" & ComboBox1.Text, "") = "" Then
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        On Error Resume Next
        OpenFileDialog1.FileName = "" '다이얼로그의 파일경로를 ""으로 변경합니다.
        OpenFileDialog1.ShowDialog() '다이얼로그를 보여줍니다.
        If Not OpenFileDialog1.FileName = "" Then '다이얼로그의 파일경로가 ""일경우
            TextBox1.Text = OpenFileDialog1.SafeFileName
            TextBox2.Text = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenFileDialog1.Title = "열기" '다이얼로그의 타이틀의 이름을 변경합니다.
        OpenFileDialog1.Filter = "exe파일|*.exe|모든파일|*.*" '다이얼로그에 필터를 적용합니다.
        OpenFileDialog1.RestoreDirectory = True '다이얼로그에 마지막으로 닫은 디렉터리가 저장됩니다.
    End Sub
    Private Sub HazelDev_Button1_Click(sender As Object, e As EventArgs) Handles HazelDev_Button1.Click
        If Not ComboBox1.Text = "" Or ComboBox1.SelectedItem = "" And TextBox1.Text = "" And TextBox2.Text = "" Then
            SaveSetting("바로가기", "바로가기", "Botton" & ComboBox1.Text, "<1>" & TextBox1.Text & "<1><2>" & TextBox2.Text & "<2>")
            MessageBox.Show("저장완료", "저장완료", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form1.Controls("HazelDev_Button" & ComboBox1.Text).Enabled = True
            Form1.Controls("HazelDev_Button" & ComboBox1.Text).Text = TextBox1.Text
        Else
            MessageBox.Show("입력이 올바르지않습니다.", "Err", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub HazelDev_Button3_Click(sender As Object, e As EventArgs) Handles HazelDev_Button3.Click
        On Error Resume Next
        DeleteSetting("바로가기", "바로가기", "Botton" & ComboBox1.Text)
        TextBox1.Text = ""
        TextBox2.Text = ""
        Form1.Controls("HazelDev_Button" & ComboBox1.Text).Text = "Botton" & ComboBox1.Text
        Form1.Controls("HazelDev_Button" & ComboBox1.Text).Enabled = False
    End Sub
End Class