<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.HazelDev_Label2 = New 자본_관리_프로그램.HazelDev_Label()
        Me.HazelDev_Button3 = New 자본_관리_프로그램.HazelDev_Button()
        Me.HazelDev_Button4 = New 자본_관리_프로그램.HazelDev_Button()
        Me.HazelDev_Button1 = New 자본_관리_프로그램.HazelDev_Button()
        Me.HazelDev_Label1 = New 자본_관리_프로그램.HazelDev_Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.HazelDev_Label3 = New 자본_관리_프로그램.HazelDev_Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(106, 14)
        Me.TextBox1.MaxLength = 8
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 21)
        Me.TextBox1.TabIndex = 1
        '
        'HazelDev_Label2
        '
        Me.HazelDev_Label2.AutoSize = True
        Me.HazelDev_Label2.BackColor = System.Drawing.Color.Transparent
        Me.HazelDev_Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HazelDev_Label2.ForeColor = System.Drawing.Color.DimGray
        Me.HazelDev_Label2.Location = New System.Drawing.Point(284, 62)
        Me.HazelDev_Label2.Name = "HazelDev_Label2"
        Me.HazelDev_Label2.Size = New System.Drawing.Size(135, 16)
        Me.HazelDev_Label2.TabIndex = 4
        Me.HazelDev_Label2.Text = "Made by LeeYeChan"
        '
        'HazelDev_Button3
        '
        Me.HazelDev_Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.HazelDev_Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.HazelDev_Button3.FlatAppearance.BorderSize = 0
        Me.HazelDev_Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.HazelDev_Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.HazelDev_Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HazelDev_Button3.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.HazelDev_Button3.ForeColor = System.Drawing.Color.White
        Me.HazelDev_Button3.Location = New System.Drawing.Point(361, 14)
        Me.HazelDev_Button3.Name = "HazelDev_Button3"
        Me.HazelDev_Button3.Size = New System.Drawing.Size(58, 45)
        Me.HazelDev_Button3.TabIndex = 3
        Me.HazelDev_Button3.Text = "리셋"
        Me.HazelDev_Button3.UseVisualStyleBackColor = False
        '
        'HazelDev_Button4
        '
        Me.HazelDev_Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.HazelDev_Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.HazelDev_Button4.FlatAppearance.BorderSize = 0
        Me.HazelDev_Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.HazelDev_Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.HazelDev_Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HazelDev_Button4.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.HazelDev_Button4.ForeColor = System.Drawing.Color.White
        Me.HazelDev_Button4.Location = New System.Drawing.Point(292, 14)
        Me.HazelDev_Button4.Name = "HazelDev_Button4"
        Me.HazelDev_Button4.Size = New System.Drawing.Size(63, 45)
        Me.HazelDev_Button4.TabIndex = 3
        Me.HazelDev_Button4.Text = "제작자"
        Me.HazelDev_Button4.UseVisualStyleBackColor = False
        '
        'HazelDev_Button1
        '
        Me.HazelDev_Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.HazelDev_Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.HazelDev_Button1.FlatAppearance.BorderSize = 0
        Me.HazelDev_Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.HazelDev_Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.HazelDev_Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HazelDev_Button1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.HazelDev_Button1.ForeColor = System.Drawing.Color.White
        Me.HazelDev_Button1.Location = New System.Drawing.Point(232, 14)
        Me.HazelDev_Button1.Name = "HazelDev_Button1"
        Me.HazelDev_Button1.Size = New System.Drawing.Size(54, 45)
        Me.HazelDev_Button1.TabIndex = 2
        Me.HazelDev_Button1.Text = "적용"
        Me.HazelDev_Button1.UseVisualStyleBackColor = False
        '
        'HazelDev_Label1
        '
        Me.HazelDev_Label1.AutoSize = True
        Me.HazelDev_Label1.BackColor = System.Drawing.Color.Transparent
        Me.HazelDev_Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.HazelDev_Label1.ForeColor = System.Drawing.Color.DimGray
        Me.HazelDev_Label1.Location = New System.Drawing.Point(12, 14)
        Me.HazelDev_Label1.Name = "HazelDev_Label1"
        Me.HazelDev_Label1.Size = New System.Drawing.Size(88, 17)
        Me.HazelDev_Label1.TabIndex = 0
        Me.HazelDev_Label1.Text = "기본 고정 수입"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(106, 38)
        Me.TextBox2.MaxLength = 8
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(120, 21)
        Me.TextBox2.TabIndex = 6
        '
        'HazelDev_Label3
        '
        Me.HazelDev_Label3.AutoSize = True
        Me.HazelDev_Label3.BackColor = System.Drawing.Color.Transparent
        Me.HazelDev_Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.HazelDev_Label3.ForeColor = System.Drawing.Color.DimGray
        Me.HazelDev_Label3.Location = New System.Drawing.Point(40, 38)
        Me.HazelDev_Label3.Name = "HazelDev_Label3"
        Me.HazelDev_Label3.Size = New System.Drawing.Size(60, 17)
        Me.HazelDev_Label3.TabIndex = 5
        Me.HazelDev_Label3.Text = "추가 수입"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 85)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.HazelDev_Label3)
        Me.Controls.Add(Me.HazelDev_Label2)
        Me.Controls.Add(Me.HazelDev_Button3)
        Me.Controls.Add(Me.HazelDev_Button4)
        Me.Controls.Add(Me.HazelDev_Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.HazelDev_Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "설정"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HazelDev_Label1 As 자본_관리_프로그램.HazelDev_Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents HazelDev_Button1 As 자본_관리_프로그램.HazelDev_Button
    Friend WithEvents HazelDev_Button3 As 자본_관리_프로그램.HazelDev_Button
    Friend WithEvents HazelDev_Button4 As 자본_관리_프로그램.HazelDev_Button
    Friend WithEvents HazelDev_Label2 As 자본_관리_프로그램.HazelDev_Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents HazelDev_Label3 As 자본_관리_프로그램.HazelDev_Label
End Class
