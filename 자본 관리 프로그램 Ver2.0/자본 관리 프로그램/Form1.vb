Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load    '폼로딩
        On Error Resume Next
        If GetSetting("자본 관리 프로그램", "자본 관리 프로그램", "전체수입", "") = "" Then
            MsgBox("설정에서 한달 수입을 등록해주세요.")
            GroupBox1.Enabled = False
        End If
        Dim item1
        Dim line As Integer
        line = GetSetting("자본 관리 프로그램", "자본 관리 프로그램", "라인", "")
        For i = 1 To line
            item1 = Split(Split(GetSetting("자본 관리 프로그램", "자본 관리 프로그램", "기입목록", ""), "<" & i & ">")(1), "<" & i & ">")(0)
            ListView1.Items.Add(Split(Split(item1, "<line" & i & "-1>")(1), "<line" & i & "-2>")(0))
            ListView1.Items(i - 1).SubItems.Add(Split(Split(item1, "<line" & i & "-2>")(1), "<line" & i & "-3>")(0))
            ListView1.Items(i - 1).SubItems.Add(Split(Split(item1, "<line" & i & "-3>")(1), "<line" & i & "-4>")(0))
            ListView1.Items(i - 1).SubItems.Add(Split(Split(item1, "<line" & i & "-4>")(1), "<line" & i & "-5>")(0))
        Next
        ListView1.Items(line - 1).EnsureVisible()
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
        HazelDev_Label11.Text = "전체지출 : " & GetSetting("자본 관리 프로그램", "자본 관리 프로그램", "전체지출", "") & "원"
        HazelDev_ProgressBar1.Value = GetSetting("자본 관리 프로그램", "자본 관리 프로그램", "잔여퍼센트", "")
        HazelDev_Label10.Text = "전체잔액 : " & GetSetting("자본 관리 프로그램", "자본 관리 프로그램", "전체잔액", "") & "원"
        HazelDev_Label9.Text = "전체소득 : " & GetSetting("자본 관리 프로그램", "자본 관리 프로그램", "전체수입", "") & "원"
        HazelDev_Label7.Text = "현금잔액 : " & GetSetting("자본 관리 프로그램", "자본 관리 프로그램", "현금잔액", "") & "원"
        HazelDev_Label8.Text = "카드잔액 : " & GetSetting("자본 관리 프로그램", "자본 관리 프로그램", "카드잔액", "") & "원"
        HazelDev_Label14.Text = "저장날짜 : " & GetSetting("자본 관리 프로그램", "자본 관리 프로그램", "저장날짜", "")
        HazelDev_ProgressBar1.Value = GetSetting("자본 관리 프로그램", "자본 관리 프로그램", "퍼센트", "")
    End Sub
    Private Sub HazelDev_Button1_Click(sender As Object, e As EventArgs) Handles HazelDev_Button1.Click    '추가버튼
        On Error Resume Next
        Dim saveitem, item1, item2, item3, item4
        Dim iNum1, iNum2, inum3, inum4, inum5, inum6, c1, c2, h1, h2, h3, h4, t1, t2, t3, t4, t5, t6, t7, p1 As Integer
        Dim text1 As String
        Dim Index As Integer
        t1 = GetSetting("자본 관리 프로그램", "자본 관리 프로그램", "전체지출", "")
        t2 = GetSetting("자본 관리 프로그램", "자본 관리 프로그램", "현금총액", "")
        t3 = GetSetting("자본 관리 프로그램", "자본 관리 프로그램", "현금잔액", "")
        t4 = GetSetting("자본 관리 프로그램", "자본 관리 프로그램", "카드총액", "")
        t5 = GetSetting("자본 관리 프로그램", "자본 관리 프로그램", "카드잔액", "")
        t6 = GetSetting("자본 관리 프로그램", "자본 관리 프로그램", "전체잔액", "")
        t7 = GetSetting("자본 관리 프로그램", "자본 관리 프로그램", "전체수입", "")

        Index = ListView1.Items.Count
        If ComboBox1.SelectedItem = "" Or TextBox1.Text = "" Or TextBox4.Text = "" Then
            MessageBox.Show("날짜,금액,결재종류 를 입력해주세요.", "Error")
        Else
            item1 = TextBox1.Text                                                      'item1
            ListView1.Items.Add(item1)  '날짜입력
            item2 = ComboBox1.Text                                                     'item2
            Select Case ComboBox1.SelectedIndex
                Case 0                                                                 '현금선택
                    ListView1.Items(Index).SubItems.Add("지출-현금")
                    If TextBox3.Text = "" Then                                         '빈칸제거, 내용, item3
                        item3 = "-"
                    Else
                        item3 = TextBox3.Text
                    End If
                    ListView1.Items(Index).SubItems.Add(item3)
                    h1 = TextBox4.Text                                                 '사용금액 =item4(h1)
                    ListView1.Items(Index).SubItems.Add(h1)
                    h2 = t3 - h1                                                       '현금잔액
                    h3 = t6 - h1                                                       '전체잔액
                    h4 = t1 + h1                                                       '전체지출
                    SaveSetting("자본 관리 프로그램", "자본 관리 프로그램", "현금잔액", h2)

                Case 1                                                                 '카드선택
                    ListView1.Items(Index).SubItems.Add("지출-카드")
                    If TextBox3.Text = "" Then
                        item3 = "-"
                    Else
                        item3 = TextBox3.Text
                    End If
                    ListView1.Items(Index).SubItems.Add(item3)
                    h1 = TextBox4.Text
                    ListView1.Items(Index).SubItems.Add(h1)
                    c2 = t5 - h1                                                       '카드잔액
                    h3 = t6 - h1                                                       '전체잔액
                    h4 = t1 + h1                                                       '전체지출
                    SaveSetting("자본 관리 프로그램", "자본 관리 프로그램", "카드잔액", c2)

                Case 2 '현금→카드
                    ListView1.Items(Index).SubItems.Add("입금")
                    item4 = "입금 : " & TextBox4.Text & "원"
                    ListView1.Items(Index).SubItems.Add(item4)
                    ListView1.Items(Index).SubItems.Add("0")
                    h2 = TextBox4.Text
                    SaveSetting("자본 관리 프로그램", "자본 관리 프로그램", "현금잔액", (t3 - h2))
                    SaveSetting("자본 관리 프로그램", "자본 관리 프로그램", "현금총액", (t2 - h2))
                    SaveSetting("자본 관리 프로그램", "자본 관리 프로그램", "카드잔액", (t5 + h2))
                    SaveSetting("자본 관리 프로그램", "자본 관리 프로그램", "카드총액", (t4 + h2))
                    h3 = t6
                    h4 = t1
                Case 3 '카드→현금
                    ListView1.Items(Index).SubItems.Add("출금")
                    item4 = "출금 : " & TextBox3.Text & "원, " & "수수료 : " & TextBox4.Text & "원"
                    ListView1.Items(Index).SubItems.Add(item4)
                    h2 = TextBox3.Text '인출금액
                    h1 = TextBox4.Text '수수료
                    ListView1.Items(Index).SubItems.Add(h1)
                    SaveSetting("자본 관리 프로그램", "자본 관리 프로그램", "현금잔액", (t3 + h2))
                    SaveSetting("자본 관리 프로그램", "자본 관리 프로그램", "현금총액", (t2 + h2))
                    SaveSetting("자본 관리 프로그램", "자본 관리 프로그램", "카드잔액", (t5 - (h1 + h2)))
                    SaveSetting("자본 관리 프로그램", "자본 관리 프로그램", "카드총액", (t4 - (h1 + h2)))
                    h3 = t6 - h1
                    h4 = t1 + h1

                Case 4 '수입-현금
                    ListView1.Items(Index).SubItems.Add("수입-현금")
                    item4 = "수입(현금) : " & TextBox4.Text & "원 " & TextBox3.Text
                    ListView1.Items(Index).SubItems.Add(item4)
                    ListView1.Items(Index).SubItems.Add("0")
                    h2 = TextBox4.Text
                    SaveSetting("자본 관리 프로그램", "자본 관리 프로그램", "현금총액", (t2 + h2))
                    h3 = t6 + h2 '전체잔액
                    h4 = t1 '전체지출
                    SaveSetting("자본 관리 프로그램", "자본 관리 프로그램", "전체수입", (t7 + h2))
                    SaveSetting("자본 관리 프로그램", "자본 관리 프로그램", "현금잔액", (t3 + h2))

                Case 5 '수입-카드
                    ListView1.Items(Index).SubItems.Add("수입-카드")
                    item4 = "수입(카드) : " & TextBox4.Text & "원 " & TextBox3.Text
                    ListView1.Items(Index).SubItems.Add(item4)
                    ListView1.Items(Index).SubItems.Add("0")
                    h2 = TextBox4.Text
                    SaveSetting("자본 관리 프로그램", "자본 관리 프로그램", "카드총액", (t4 + h2))
                    h3 = t6 + h2 '전체잔액
                    h4 = t1 '전체지출
                    SaveSetting("자본 관리 프로그램", "자본 관리 프로그램", "전체수입", (t7 + h2))
                    SaveSetting("자본 관리 프로그램", "자본 관리 프로그램", "카드잔액", (t5 + h2))

            End Select

            For i = ListView1.Items.Count To ListView1.Items.Count
                If item4 = "" Then
                    saveitem = GetSetting("자본 관리 프로그램", "자본 관리 프로그램", "기입목록", "") & "<" & i & ">" & "<line" & i & "-1>" & item1 & "<line" & i & "-2>" & item2 & "<line" & i & "-3>" & item3 & "<line" & i & "-4>" & h1 & "<line" & i & "-5>" & "<" & i & ">"
                Else
                    saveitem = GetSetting("자본 관리 프로그램", "자본 관리 프로그램", "기입목록", "") & "<" & i & ">" & "<line" & i & "-1>" & item1 & "<line" & i & "-2>" & item2 & "<line" & i & "-3>" & item4 & "<line" & i & "-4>" & h1 & "<line" & i & "-5>" & "<" & i & ">"
                End If
                SaveSetting("자본 관리 프로그램", "자본 관리 프로그램", "기입목록", saveitem) '저장
            Next

            SaveSetting("자본 관리 프로그램", "자본 관리 프로그램", "라인", ListView1.Items.Count)
            SaveSetting("자본 관리 프로그램", "자본 관리 프로그램", "전체잔액", h3)
            SaveSetting("자본 관리 프로그램", "자본 관리 프로그램", "전체지출", h4)
            TextBox1.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            SaveSetting("자본 관리 프로그램", "자본 관리 프로그램", "퍼센트", h4 / t7 * 100)
            ListView1.Items(Index).EnsureVisible()
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
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 2 Then
            HazelDev_Label3.Enabled = False
            TextBox3.Enabled = False
            HazelDev_Label3.Text = "내용"
            HazelDev_Label4.Text = "입금금액"
        ElseIf ComboBox1.SelectedIndex = 3 Then
            HazelDev_Label3.Enabled = True
            TextBox3.Enabled = True
            HazelDev_Label3.Text = "인출금액"
            HazelDev_Label4.Text = "수수료"
        ElseIf ComboBox1.SelectedIndex = 4 Or ComboBox1.SelectedIndex = 5 Then
            HazelDev_Label3.Enabled = True
            TextBox3.Enabled = True
            HazelDev_Label3.Text = "내용"
            HazelDev_Label4.Text = "수입"
        Else
            HazelDev_Label3.Text = "내용"
            HazelDev_Label4.Text = "지출금액"
            HazelDev_Label3.Enabled = True
            TextBox3.Enabled = True
        End If
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class
