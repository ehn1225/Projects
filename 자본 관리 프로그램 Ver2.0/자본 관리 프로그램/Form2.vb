Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = GetSetting("자본 관리 프로그램", "자본 관리 프로그램", "현금총액", "")
        TextBox2.Text = GetSetting("자본 관리 프로그램", "자본 관리 프로그램", "카드총액", "")
    End Sub

    Private Sub HazelDev_Button3_Click(sender As Object, e As EventArgs) Handles HazelDev_Button3.Click
        On Error Resume Next
        If MsgBox("정말로 초기화 하겠습니까?." & Chr(10) & "한번삭제후 복구가 불가능합니다.", vbYesNo, "자본관리프로그램 초기화") = vbYes Then
            DeleteSetting("자본 관리 프로그램", "자본 관리 프로그램", "기입목록")
            DeleteSetting("자본 관리 프로그램", "자본 관리 프로그램", "잔액등")
            DeleteSetting("자본 관리 프로그램", "자본 관리 프로그램", "전체수입")
            DeleteSetting("자본 관리 프로그램", "자본 관리 프로그램", "현금총액")
            DeleteSetting("자본 관리 프로그램", "자본 관리 프로그램", "카드총액")
            DeleteSetting("자본 관리 프로그램", "자본 관리 프로그램", "현금잔액")
            DeleteSetting("자본 관리 프로그램", "자본 관리 프로그램", "카드잔액")
            DeleteSetting("자본 관리 프로그램", "자본 관리 프로그램", "전체잔액")
            DeleteSetting("자본 관리 프로그램", "자본 관리 프로그램", "전체지출")
            DeleteSetting("자본 관리 프로그램", "자본 관리 프로그램", "라인")
            DeleteSetting("자본 관리 프로그램", "자본 관리 프로그램", "퍼센트")
            DeleteSetting("자본 관리 프로그램", "자본 관리 프로그램", "저장날짜")

            Form1.ListView1.Items.Clear()
            Form1.GroupBox1.Enabled = False
            Form1.HazelDev_Label11.Text = "전체지출"
            Form1.HazelDev_Label10.Text = "현재잔액"
            Form1.HazelDev_Label9.Text = "전체소득"
            Form1.HazelDev_Label7.Text = "현금잔액"
            Form1.HazelDev_Label8.Text = "카드잔액"
            Form1.HazelDev_Label14.Text = "저장날짜"

            TextBox1.Text = ""
            TextBox2.Text = ""
            Form1.Timer1.Stop()
            Form1.HazelDev_ProgressBar1.Value = 0
        End If
    End Sub

    Private Sub HazelDev_Button1_Click(sender As Object, e As EventArgs) Handles HazelDev_Button1.Click
        On Error Resume Next
        Dim inum1, inum2, inum3, inum4 As Integer
        If TextBox1.Text = "" Then
            MsgBox("한달 수입을 입력해주세요!")
        Else

            inum1 = TextBox1.Text                                                     '전체금액 저장
            inum2 = TextBox2.Text
            inum3 = inum1 + inum2
            SaveSetting("자본 관리 프로그램", "자본 관리 프로그램", "전체수입", inum3)
            SaveSetting("자본 관리 프로그램", "자본 관리 프로그램", "전체잔액", inum3)
            Form1.HazelDev_Label9.Text = "전체소득 : " & inum3 & "원"
            Form1.HazelDev_Label10.Text = "전체잔액 : " & inum3 & "원"

            SaveSetting("자본 관리 프로그램", "자본 관리 프로그램", "현금총액", TextBox1.Text) ' '현금저장
            SaveSetting("자본 관리 프로그램", "자본 관리 프로그램", "현금잔액", TextBox1.Text)

            SaveSetting("자본 관리 프로그램", "자본 관리 프로그램", "카드총액", TextBox2.Text) '카드저장
            SaveSetting("자본 관리 프로그램", "자본 관리 프로그램", "카드잔액", TextBox2.Text)
            Form1.GroupBox1.Enabled = True
            Form1.Timer1.Start()

            SaveSetting("자본 관리 프로그램", "자본 관리 프로그램", "전체지출", 0)
            Form1.HazelDev_Label11.Text = "전체지출 : 0원"
            SaveSetting("자본 관리 프로그램", "자본 관리 프로그램", "퍼센트", 0)
            SaveSetting("자본 관리 프로그램", "자본 관리 프로그램", "라인", 0)
            SaveSetting("자본 관리 프로그램", "자본 관리 프로그램", "저장날짜", LSet(Now, 10))
            Form1.HazelDev_Label14.Text = "저장날짜 : " & LSet(Now, 10)

            Me.Close()
        End If
    End Sub

    Private Sub HazelDev_Button4_Click(sender As Object, e As EventArgs) Handles HazelDev_Button4.Click
        MessageBox.Show("제작자 : LeeYeChan" & Chr(10) & "제작년일 : 2015-12-30" & Chr(10) & "E-mail : ehn1225@naver.com" & Chr(10) & "무단수정 및 무단배포를 금지합니다.", "제작자정보", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub HazelDev_Button1_KeyDown(sender As Object, e As KeyEventArgs) Handles HazelDev_Button1.KeyDown
        If e.KeyCode = 13 Then
            HazelDev_Button1.PerformClick()
        End If
    End Sub
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = 13 Then
            HazelDev_Button1.PerformClick()
        End If
    End Sub
    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = 13 Then
            HazelDev_Button1.PerformClick()
        End If
    End Sub
End Class