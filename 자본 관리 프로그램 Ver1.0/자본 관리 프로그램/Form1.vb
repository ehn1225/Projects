Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load    '폼로딩
        On Error Resume Next
        If GetSetting("자본 관리 프로그램", "자본 관리 프로그램", "한달수입", "") = "" Then
            MsgBox("설정에서 한달 수입을 등록해주세요.")
            GroupBox1.Enabled = False
        End If
        Dim item1
        Dim line As Integer
        line = Split(Split(GetSetting("자본 관리 프로그램", "자본 관리 프로그램", "잔액등", ""), "<1>")(1), "<1>")(0)
        For i = 1 To line
            item1 = Split(Split(GetSetting("자본 관리 프로그램", "자본 관리 프로그램", "기입목록", ""), "<" & i & ">")(1), "<" & i & ">")(0)
            ListView1.Items.Add(Split(Split(item1, "<line" & i & "-1>")(1), "<line" & i & "-2>")(0))
            ListView1.Items(i - 1).SubItems.Add(Split(Split(item1, "<line" & i & "-2>")(1), "<line" & i & "-3>")(0))
            ListView1.Items(i - 1).SubItems.Add(Split(Split(item1, "<line" & i & "-3>")(1), "<line" & i & "-4>")(0))
            ListView1.Items(i - 1).SubItems.Add(Split(Split(item1, "<line" & i & "-4>")(1), "<line" & i & "-5>")(0))
        Next
        HazelDev_Label11.Text = "나의 전체 지출 : " & Split(Split(GetSetting("자본 관리 프로그램", "자본 관리 프로그램", "잔액등", ""), "<3>")(1), "<3>")(0) & "원"
        HazelDev_ProgressBar1.Value = Split(Split(GetSetting("자본 관리 프로그램", "자본 관리 프로그램", "잔액등", ""), "<4>")(1), "<4>")(0)
        HazelDev_Label10.Text = "나의 현재 잔액 : " & Split(Split(GetSetting("자본 관리 프로그램", "자본 관리 프로그램", "잔액등", ""), "<2>")(1), "<3>")(0) & "원"
        HazelDev_Label9.Text = "나의 한달 소득 : " & GetSetting("자본 관리 프로그램", "자본 관리 프로그램", "한달수입", "") & "원"
        Timer1.Start()
    End Sub
    Private Sub HazelDev_Button2_Click(sender As Object, e As EventArgs) Handles HazelDev_Button2.Click
        Form2.Show()
    End Sub
    Private Sub TextBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles TextBox1.MouseDown
        If TextBox1.Text = "" Then
            TextBox1.Text = LSet(Now, 10)
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        On Error Resume Next
        Dim per1, per2, inum1, inum2, inum3 As Integer
        per1 = GetSetting("자본 관리 프로그램", "자본 관리 프로그램", "한달수입", "")
        per2 = Split(Split(HazelDev_Label10.Text, "나의 현재 잔액 : ")(1), "원")(0)
        Dim set1, set2, set3, set4, set5
        set1 = ListView1.Items.Count
        set2 = Split(Split(HazelDev_Label10.Text, "나의 현재 잔액 : ")(1), "원")(0)
        set3 = Split(Split(HazelDev_Label11.Text, "나의 전체 지출 : ")(1), "원")(0)
        set4 = (per2 / per1) * 100
        set5 = "<1>" & set1 & "<1>" & "<2>" & set2 & "<2>" & "<3>" & set3 & "<3>" & "<4>" & set4 & "<4>"
        SaveSetting("자본 관리 프로그램", "자본 관리 프로그램", "잔액등", set5)
        inum1 = Split(Split(HazelDev_Label9.Text, "나의 한달 소득 : ")(1), "원")(0)
        inum2 = inum1 - set3
        HazelDev_Label10.Text = "나의 현재 잔액 : " & inum2 & "원"
        If set3 = 0 Then
            HazelDev_ProgressBar1.Value = 100
        Else
            HazelDev_ProgressBar1.Value = set4
        End If
    End Sub
    Private Sub HazelDev_Button1_Click(sender As Object, e As EventArgs) Handles HazelDev_Button1.Click    '추가버튼
        On Error Resume Next
        Dim saveitem, item1, item2, item3, item4
        Dim iNum1, iNum2, inum3, inum4, inum5, inum6 As Integer
        Dim Index As Integer
        Index = ListView1.Items.Count
        If ComboBox1.SelectedItem = "" Or TextBox1.Text = "" Or TextBox4.Text = "" Then
            MessageBox.Show("날짜,금액,결재종류 를 입력해주세요.", "ERROR")
        Else
            item1 = TextBox1.Text
            item2 = ComboBox1.Text
            ListView1.Items.Add(TextBox1.Text)
            Select Case ComboBox1.SelectedIndex
                Case 0
                    ListView1.Items(Index).SubItems.Add("현금")
                Case 1
                    ListView1.Items(Index).SubItems.Add("카드")
            End Select
            If TextBox3.Text = "" Then
                ListView1.Items(Index).SubItems.Add("-")
                item3 = "-"
            Else
                ListView1.Items(Index).SubItems.Add(TextBox3.Text)
                item3 = TextBox3.Text
            End If
            ''''''설정저장
            ListView1.Items(Index).SubItems.Add(TextBox4.Text)
            item4 = TextBox4.Text
            If ListView1.Items.Count = 1 Then
                iNum1 = GetSetting("자본 관리 프로그램", "자본 관리 프로그램", "한달수입", "")   '잔액
                iNum2 = TextBox4.Text
                inum3 = iNum1 - iNum2
                ListView1.Items(Index).SubItems.Add(inum3)
                HazelDev_Label10.Text = "나의 현재 잔액 : " & inum3 & "원"
                ListView1.Items(Index).SubItems.Add(TextBox4.Text)
                HazelDev_Label11.Text = "나의 전체 지출 : " & TextBox4.Text & "원"
            Else
                iNum1 = Split(Split(HazelDev_Label10.Text, "나의 현재 잔액 : ")(1), "원")(0)
                iNum2 = TextBox4.Text
                inum3 = iNum1 - iNum2
                HazelDev_Label10.Text = "나의 현재 잔액 : " & inum3 & "원"
                ListView1.Items(Index).SubItems.Add(inum3)
                inum4 = Split(Split(HazelDev_Label11.Text, "나의 전체 지출 : ")(1), "원")(0)
                inum5 = TextBox4.Text
                inum6 = inum4 + inum5
                ListView1.Items(Index).SubItems.Add(inum6)
                HazelDev_Label11.Text = "나의 전체 지출 : " & inum6 & "원"
            End If
            For i = ListView1.Items.Count To ListView1.Items.Count
                saveitem = GetSetting("자본 관리 프로그램", "자본 관리 프로그램", "기입목록", "") & "<" & i & ">" & "<line" & i & "-1>" & item1 & "<line" & i & "-2>" & item2 & "<line" & i & "-3>" & item3 & "<line" & i & "-4>" & item4 & "<line" & i & "-5>" & "<" & i & ">"
                SaveSetting("자본 관리 프로그램", "자본 관리 프로그램", "기입목록", saveitem) '저장
            Next
            TextBox1.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
        End If
    End Sub
    Private Sub TextBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox4.KeyDown
        If e.KeyCode = 13 Then
            HazelDev_Button1.PerformClick()
            TextBox1.Focus()
        End If
    End Sub
    Private Sub HazelDev_Button3_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = 13 Then
            HazelDev_Button1.PerformClick()
            TextBox1.Focus()
        End If
    End Sub
End Class
