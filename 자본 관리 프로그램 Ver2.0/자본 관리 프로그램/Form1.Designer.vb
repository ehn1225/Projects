<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.HazelDev_Label14 = New 자본_관리_프로그램.HazelDev_Label()
        Me.HazelDev_Label7 = New 자본_관리_프로그램.HazelDev_Label()
        Me.HazelDev_Label8 = New 자본_관리_프로그램.HazelDev_Label()
        Me.HazelDev_Button2 = New 자본_관리_프로그램.HazelDev_Button()
        Me.HazelDev_Label9 = New 자본_관리_프로그램.HazelDev_Label()
        Me.HazelDev_ProgressBar1 = New 자본_관리_프로그램.HazelDev_ProgressBar()
        Me.HazelDev_Label10 = New 자본_관리_프로그램.HazelDev_Label()
        Me.HazelDev_Label13 = New 자본_관리_프로그램.HazelDev_Label()
        Me.HazelDev_Label11 = New 자본_관리_프로그램.HazelDev_Label()
        Me.HazelDev_Label12 = New 자본_관리_프로그램.HazelDev_Label()
        Me.HazelDev_Label2 = New 자본_관리_프로그램.HazelDev_Label()
        Me.HazelDev_Button1 = New 자본_관리_프로그램.HazelDev_Button()
        Me.HazelDev_Label1 = New 자본_관리_프로그램.HazelDev_Label()
        Me.HazelDev_Label4 = New 자본_관리_프로그램.HazelDev_Label()
        Me.HazelDev_Label3 = New 자본_관리_프로그램.HazelDev_Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader5, Me.ColumnHeader3})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListView1.LabelWrap = False
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(559, 353)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "날짜(Date)"
        Me.ColumnHeader1.Width = 76
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "카드/현금"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 73
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "내용"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 328
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "비용(￦)"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 65
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(75, 13)
        Me.TextBox1.MaxLength = 10
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(124, 21)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(75, 66)
        Me.TextBox3.MaxLength = 24
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(124, 21)
        Me.TextBox3.TabIndex = 3
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(75, 92)
        Me.TextBox4.MaxLength = 7
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(124, 21)
        Me.TextBox4.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.HazelDev_Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.HazelDev_Button1)
        Me.GroupBox1.Controls.Add(Me.HazelDev_Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.HazelDev_Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.HazelDev_Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 359)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(210, 160)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "기록 추가"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"지출-현금", "지출-카드", "입금", "출금", "수입-현금", "수입-카드"})
        Me.ComboBox1.Location = New System.Drawing.Point(75, 39)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(124, 20)
        Me.ComboBox1.TabIndex = 2
        Me.ComboBox1.Text = "지출-현금"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.HazelDev_Label14)
        Me.GroupBox3.Controls.Add(Me.HazelDev_Label7)
        Me.GroupBox3.Controls.Add(Me.HazelDev_Label8)
        Me.GroupBox3.Controls.Add(Me.HazelDev_Button2)
        Me.GroupBox3.Controls.Add(Me.HazelDev_Label9)
        Me.GroupBox3.Controls.Add(Me.HazelDev_ProgressBar1)
        Me.GroupBox3.Controls.Add(Me.HazelDev_Label10)
        Me.GroupBox3.Controls.Add(Me.HazelDev_Label13)
        Me.GroupBox3.Controls.Add(Me.HazelDev_Label11)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Location = New System.Drawing.Point(221, 359)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(334, 160)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total"
        '
        'HazelDev_Label14
        '
        Me.HazelDev_Label14.AutoSize = True
        Me.HazelDev_Label14.BackColor = System.Drawing.Color.Transparent
        Me.HazelDev_Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.HazelDev_Label14.ForeColor = System.Drawing.SystemColors.Desktop
        Me.HazelDev_Label14.Location = New System.Drawing.Point(164, 50)
        Me.HazelDev_Label14.Name = "HazelDev_Label14"
        Me.HazelDev_Label14.Size = New System.Drawing.Size(56, 17)
        Me.HazelDev_Label14.TabIndex = 16
        Me.HazelDev_Label14.Text = "저장날짜"
        '
        'HazelDev_Label7
        '
        Me.HazelDev_Label7.AutoSize = True
        Me.HazelDev_Label7.BackColor = System.Drawing.Color.Transparent
        Me.HazelDev_Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.HazelDev_Label7.ForeColor = System.Drawing.Color.Black
        Me.HazelDev_Label7.Location = New System.Drawing.Point(164, 17)
        Me.HazelDev_Label7.Name = "HazelDev_Label7"
        Me.HazelDev_Label7.Size = New System.Drawing.Size(56, 17)
        Me.HazelDev_Label7.TabIndex = 15
        Me.HazelDev_Label7.Text = "현금잔액"
        '
        'HazelDev_Label8
        '
        Me.HazelDev_Label8.AutoSize = True
        Me.HazelDev_Label8.BackColor = System.Drawing.Color.Transparent
        Me.HazelDev_Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.HazelDev_Label8.ForeColor = System.Drawing.SystemColors.Desktop
        Me.HazelDev_Label8.Location = New System.Drawing.Point(164, 34)
        Me.HazelDev_Label8.Name = "HazelDev_Label8"
        Me.HazelDev_Label8.Size = New System.Drawing.Size(56, 17)
        Me.HazelDev_Label8.TabIndex = 14
        Me.HazelDev_Label8.Text = "카드잔액"
        '
        'HazelDev_Button2
        '
        Me.HazelDev_Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.HazelDev_Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.HazelDev_Button2.FlatAppearance.BorderSize = 0
        Me.HazelDev_Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.HazelDev_Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.HazelDev_Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HazelDev_Button2.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.HazelDev_Button2.ForeColor = System.Drawing.Color.White
        Me.HazelDev_Button2.Location = New System.Drawing.Point(6, 119)
        Me.HazelDev_Button2.Name = "HazelDev_Button2"
        Me.HazelDev_Button2.Size = New System.Drawing.Size(320, 38)
        Me.HazelDev_Button2.TabIndex = 11
        Me.HazelDev_Button2.Text = "설정"
        Me.HazelDev_Button2.UseVisualStyleBackColor = False
        '
        'HazelDev_Label9
        '
        Me.HazelDev_Label9.AutoSize = True
        Me.HazelDev_Label9.BackColor = System.Drawing.Color.Transparent
        Me.HazelDev_Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.HazelDev_Label9.ForeColor = System.Drawing.SystemColors.Desktop
        Me.HazelDev_Label9.Location = New System.Drawing.Point(6, 17)
        Me.HazelDev_Label9.Name = "HazelDev_Label9"
        Me.HazelDev_Label9.Size = New System.Drawing.Size(56, 17)
        Me.HazelDev_Label9.TabIndex = 7
        Me.HazelDev_Label9.Text = "전체소득"
        '
        'HazelDev_ProgressBar1
        '
        Me.HazelDev_ProgressBar1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.HazelDev_ProgressBar1.Location = New System.Drawing.Point(6, 95)
        Me.HazelDev_ProgressBar1.Maximum = 100
        Me.HazelDev_ProgressBar1.Name = "HazelDev_ProgressBar1"
        Me.HazelDev_ProgressBar1.Size = New System.Drawing.Size(320, 18)
        Me.HazelDev_ProgressBar1.TabIndex = 9
        Me.HazelDev_ProgressBar1.TransparencyKey = System.Drawing.Color.Empty
        Me.HazelDev_ProgressBar1.Value = 1
        Me.HazelDev_ProgressBar1.ValueAlignment = 자본_관리_프로그램.HazelDev_ProgressBar.Alignment.Right
        '
        'HazelDev_Label10
        '
        Me.HazelDev_Label10.AutoSize = True
        Me.HazelDev_Label10.BackColor = System.Drawing.Color.Transparent
        Me.HazelDev_Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.HazelDev_Label10.ForeColor = System.Drawing.SystemColors.Desktop
        Me.HazelDev_Label10.Location = New System.Drawing.Point(6, 51)
        Me.HazelDev_Label10.Name = "HazelDev_Label10"
        Me.HazelDev_Label10.Size = New System.Drawing.Size(56, 17)
        Me.HazelDev_Label10.TabIndex = 7
        Me.HazelDev_Label10.Text = "전체잔액"
        '
        'HazelDev_Label13
        '
        Me.HazelDev_Label13.AutoSize = True
        Me.HazelDev_Label13.BackColor = System.Drawing.Color.Transparent
        Me.HazelDev_Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.HazelDev_Label13.ForeColor = System.Drawing.SystemColors.Desktop
        Me.HazelDev_Label13.Location = New System.Drawing.Point(6, 75)
        Me.HazelDev_Label13.Name = "HazelDev_Label13"
        Me.HazelDev_Label13.Size = New System.Drawing.Size(66, 17)
        Me.HazelDev_Label13.TabIndex = 7
        Me.HazelDev_Label13.Text = "사용량(%)"
        '
        'HazelDev_Label11
        '
        Me.HazelDev_Label11.AutoSize = True
        Me.HazelDev_Label11.BackColor = System.Drawing.Color.Transparent
        Me.HazelDev_Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.HazelDev_Label11.ForeColor = System.Drawing.Color.Black
        Me.HazelDev_Label11.Location = New System.Drawing.Point(6, 34)
        Me.HazelDev_Label11.Name = "HazelDev_Label11"
        Me.HazelDev_Label11.Size = New System.Drawing.Size(56, 17)
        Me.HazelDev_Label11.TabIndex = 7
        Me.HazelDev_Label11.Text = "전체지출"
        '
        'HazelDev_Label12
        '
        Me.HazelDev_Label12.AutoSize = True
        Me.HazelDev_Label12.BackColor = System.Drawing.Color.Transparent
        Me.HazelDev_Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.HazelDev_Label12.ForeColor = System.Drawing.Color.DimGray
        Me.HazelDev_Label12.Location = New System.Drawing.Point(500, 420)
        Me.HazelDev_Label12.Name = "HazelDev_Label12"
        Me.HazelDev_Label12.Size = New System.Drawing.Size(0, 17)
        Me.HazelDev_Label12.TabIndex = 7
        '
        'HazelDev_Label2
        '
        Me.HazelDev_Label2.AutoSize = True
        Me.HazelDev_Label2.BackColor = System.Drawing.Color.Transparent
        Me.HazelDev_Label2.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.HazelDev_Label2.ForeColor = System.Drawing.Color.Black
        Me.HazelDev_Label2.Location = New System.Drawing.Point(9, 42)
        Me.HazelDev_Label2.Name = "HazelDev_Label2"
        Me.HazelDev_Label2.Size = New System.Drawing.Size(65, 17)
        Me.HazelDev_Label2.TabIndex = 3
        Me.HazelDev_Label2.Text = "카드/현금"
        '
        'HazelDev_Button1
        '
        Me.HazelDev_Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.HazelDev_Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.HazelDev_Button1.FlatAppearance.BorderSize = 0
        Me.HazelDev_Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.HazelDev_Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.HazelDev_Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HazelDev_Button1.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.HazelDev_Button1.ForeColor = System.Drawing.Color.White
        Me.HazelDev_Button1.Location = New System.Drawing.Point(6, 119)
        Me.HazelDev_Button1.Name = "HazelDev_Button1"
        Me.HazelDev_Button1.Size = New System.Drawing.Size(197, 38)
        Me.HazelDev_Button1.TabIndex = 5
        Me.HazelDev_Button1.Text = "추가"
        Me.HazelDev_Button1.UseVisualStyleBackColor = False
        '
        'HazelDev_Label1
        '
        Me.HazelDev_Label1.AutoSize = True
        Me.HazelDev_Label1.BackColor = System.Drawing.Color.Transparent
        Me.HazelDev_Label1.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.HazelDev_Label1.ForeColor = System.Drawing.Color.Black
        Me.HazelDev_Label1.Location = New System.Drawing.Point(9, 17)
        Me.HazelDev_Label1.Name = "HazelDev_Label1"
        Me.HazelDev_Label1.Size = New System.Drawing.Size(34, 17)
        Me.HazelDev_Label1.TabIndex = 3
        Me.HazelDev_Label1.Text = "날짜"
        Me.HazelDev_Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'HazelDev_Label4
        '
        Me.HazelDev_Label4.AutoSize = True
        Me.HazelDev_Label4.BackColor = System.Drawing.Color.Transparent
        Me.HazelDev_Label4.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.HazelDev_Label4.ForeColor = System.Drawing.Color.Black
        Me.HazelDev_Label4.Location = New System.Drawing.Point(9, 96)
        Me.HazelDev_Label4.Name = "HazelDev_Label4"
        Me.HazelDev_Label4.Size = New System.Drawing.Size(60, 17)
        Me.HazelDev_Label4.TabIndex = 3
        Me.HazelDev_Label4.Text = "지출금액"
        '
        'HazelDev_Label3
        '
        Me.HazelDev_Label3.AutoSize = True
        Me.HazelDev_Label3.BackColor = System.Drawing.Color.Transparent
        Me.HazelDev_Label3.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.HazelDev_Label3.ForeColor = System.Drawing.Color.Black
        Me.HazelDev_Label3.Location = New System.Drawing.Point(9, 69)
        Me.HazelDev_Label3.Name = "HazelDev_Label3"
        Me.HazelDev_Label3.Size = New System.Drawing.Size(34, 17)
        Me.HazelDev_Label3.TabIndex = 3
        Me.HazelDev_Label3.Text = "내용"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 523)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.HazelDev_Label12)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "자본 관리 프로그램"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents HazelDev_Button1 As 자본_관리_프로그램.HazelDev_Button
    Friend WithEvents HazelDev_Label1 As 자본_관리_프로그램.HazelDev_Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents HazelDev_Label2 As 자본_관리_프로그램.HazelDev_Label
    Friend WithEvents HazelDev_Label3 As 자본_관리_프로그램.HazelDev_Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents HazelDev_Label4 As 자본_관리_프로그램.HazelDev_Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents HazelDev_Label9 As 자본_관리_프로그램.HazelDev_Label
    Friend WithEvents HazelDev_Button2 As 자본_관리_프로그램.HazelDev_Button
    Friend WithEvents HazelDev_Label10 As 자본_관리_프로그램.HazelDev_Label
    Friend WithEvents HazelDev_Label11 As 자본_관리_프로그램.HazelDev_Label
    Friend WithEvents HazelDev_Label12 As 자본_관리_프로그램.HazelDev_Label
    Friend WithEvents HazelDev_Label13 As 자본_관리_프로그램.HazelDev_Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents HazelDev_ProgressBar1 As 자본_관리_프로그램.HazelDev_ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents HazelDev_Label7 As 자본_관리_프로그램.HazelDev_Label
    Friend WithEvents HazelDev_Label8 As 자본_관리_프로그램.HazelDev_Label
    Friend WithEvents HazelDev_Label14 As 자본_관리_프로그램.HazelDev_Label

End Class
