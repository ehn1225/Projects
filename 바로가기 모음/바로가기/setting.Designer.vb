<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(setting))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.HazelDev_Button3 = New 바로가기.HazelDev_Button()
        Me.HazelDev_Button1 = New 바로가기.HazelDev_Button()
        Me.HazelDev_Label3 = New 바로가기.HazelDev_Label()
        Me.HazelDev_Label2 = New 바로가기.HazelDev_Label()
        Me.HazelDev_Label1 = New 바로가기.HazelDev_Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25"})
        Me.ComboBox1.Location = New System.Drawing.Point(118, 7)
        Me.ComboBox1.MaxDropDownItems = 5
        Me.ComboBox1.MaxLength = 2
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(87, 20)
        Me.ComboBox1.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(78, 33)
        Me.TextBox1.MaxLength = 10
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(127, 21)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(77, 59)
        Me.TextBox2.MaxLength = 500
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(261, 21)
        Me.TextBox2.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.바로가기.My.Resources.Resources.Icon_8
        Me.PictureBox1.Location = New System.Drawing.Point(339, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 21)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'HazelDev_Button3
        '
        Me.HazelDev_Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.HazelDev_Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.HazelDev_Button3.FlatAppearance.BorderSize = 0
        Me.HazelDev_Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.HazelDev_Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.HazelDev_Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HazelDev_Button3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HazelDev_Button3.ForeColor = System.Drawing.Color.White
        Me.HazelDev_Button3.Location = New System.Drawing.Point(303, 7)
        Me.HazelDev_Button3.Name = "HazelDev_Button3"
        Me.HazelDev_Button3.Size = New System.Drawing.Size(61, 46)
        Me.HazelDev_Button3.TabIndex = 5
        Me.HazelDev_Button3.Text = "삭제"
        Me.HazelDev_Button3.UseVisualStyleBackColor = False
        '
        'HazelDev_Button1
        '
        Me.HazelDev_Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.HazelDev_Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.HazelDev_Button1.FlatAppearance.BorderSize = 0
        Me.HazelDev_Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.HazelDev_Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.HazelDev_Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HazelDev_Button1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HazelDev_Button1.ForeColor = System.Drawing.Color.White
        Me.HazelDev_Button1.Location = New System.Drawing.Point(211, 7)
        Me.HazelDev_Button1.Name = "HazelDev_Button1"
        Me.HazelDev_Button1.Size = New System.Drawing.Size(86, 46)
        Me.HazelDev_Button1.TabIndex = 4
        Me.HazelDev_Button1.Text = "추가/수정"
        Me.HazelDev_Button1.UseVisualStyleBackColor = False
        '
        'HazelDev_Label3
        '
        Me.HazelDev_Label3.AutoSize = True
        Me.HazelDev_Label3.BackColor = System.Drawing.Color.Transparent
        Me.HazelDev_Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.HazelDev_Label3.ForeColor = System.Drawing.Color.DimGray
        Me.HazelDev_Label3.Location = New System.Drawing.Point(12, 61)
        Me.HazelDev_Label3.Name = "HazelDev_Label3"
        Me.HazelDev_Label3.Size = New System.Drawing.Size(60, 17)
        Me.HazelDev_Label3.TabIndex = 1
        Me.HazelDev_Label3.Text = "연결 경로"
        '
        'HazelDev_Label2
        '
        Me.HazelDev_Label2.AutoSize = True
        Me.HazelDev_Label2.BackColor = System.Drawing.Color.Transparent
        Me.HazelDev_Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.HazelDev_Label2.ForeColor = System.Drawing.Color.DimGray
        Me.HazelDev_Label2.Location = New System.Drawing.Point(12, 9)
        Me.HazelDev_Label2.Name = "HazelDev_Label2"
        Me.HazelDev_Label2.Size = New System.Drawing.Size(100, 17)
        Me.HazelDev_Label2.TabIndex = 1
        Me.HazelDev_Label2.Text = "수정할 버튼 번호"
        '
        'HazelDev_Label1
        '
        Me.HazelDev_Label1.AutoSize = True
        Me.HazelDev_Label1.BackColor = System.Drawing.Color.Transparent
        Me.HazelDev_Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.HazelDev_Label1.ForeColor = System.Drawing.Color.DimGray
        Me.HazelDev_Label1.Location = New System.Drawing.Point(12, 36)
        Me.HazelDev_Label1.Name = "HazelDev_Label1"
        Me.HazelDev_Label1.Size = New System.Drawing.Size(56, 17)
        Me.HazelDev_Label1.TabIndex = 1
        Me.HazelDev_Label1.Text = "버튼이름"
        '
        'setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 89)
        Me.Controls.Add(Me.HazelDev_Button3)
        Me.Controls.Add(Me.HazelDev_Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.HazelDev_Label3)
        Me.Controls.Add(Me.HazelDev_Label2)
        Me.Controls.Add(Me.HazelDev_Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "setting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "바로가기 - 설정"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HazelDev_Label1 As 바로가기.HazelDev_Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents HazelDev_Label2 As 바로가기.HazelDev_Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents HazelDev_Label3 As 바로가기.HazelDev_Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents HazelDev_Button1 As 바로가기.HazelDev_Button
    Friend WithEvents HazelDev_Button3 As 바로가기.HazelDev_Button
End Class
