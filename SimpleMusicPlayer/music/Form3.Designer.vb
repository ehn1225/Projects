<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.InfluenceTheme1 = New music.InfluenceTheme()
        Me.HazelDev_Label1 = New music.HazelDev_Label()
        Me.TextBox1 = New music.HazelDev_TextBox()
        Me.ComboBox1 = New music.HazelDev_ComboBox()
        Me.HazelDev_Button1 = New music.HazelDev_Button()
        Me.InfluenceTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'InfluenceTheme1
        '
        Me.InfluenceTheme1.CloseButtonExitsApp = False
        Me.InfluenceTheme1.Controls.Add(Me.HazelDev_Label1)
        Me.InfluenceTheme1.Controls.Add(Me.TextBox1)
        Me.InfluenceTheme1.Controls.Add(Me.ComboBox1)
        Me.InfluenceTheme1.Controls.Add(Me.HazelDev_Button1)
        Me.InfluenceTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InfluenceTheme1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.InfluenceTheme1.Location = New System.Drawing.Point(0, 0)
        Me.InfluenceTheme1.MinimizeButton = False
        Me.InfluenceTheme1.Name = "InfluenceTheme1"
        Me.InfluenceTheme1.Size = New System.Drawing.Size(308, 84)
        Me.InfluenceTheme1.TabIndex = 0
        Me.InfluenceTheme1.Text = "Reservation Shutdown"
        '
        'HazelDev_Label1
        '
        Me.HazelDev_Label1.AutoSize = True
        Me.HazelDev_Label1.BackColor = System.Drawing.Color.Transparent
        Me.HazelDev_Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.HazelDev_Label1.ForeColor = System.Drawing.Color.White
        Me.HazelDev_Label1.Location = New System.Drawing.Point(218, 51)
        Me.HazelDev_Label1.Name = "HazelDev_Label1"
        Me.HazelDev_Label1.Size = New System.Drawing.Size(20, 17)
        Me.HazelDev_Label1.TabIndex = 4
        Me.HazelDev_Label1.Text = "분"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.DimGray
        Me.TextBox1.Location = New System.Drawing.Point(175, 41)
        Me.TextBox1.MaxLength = 4
        Me.TextBox1.Multiline = False
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = False
        Me.TextBox1.Size = New System.Drawing.Size(43, 27)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextBox1.UseSystemPasswordChar = False
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.ItemHeight = 21
        Me.ComboBox1.Items.AddRange(New Object() {"시스템 종료", "시스템 종료 취소"})
        Me.ComboBox1.Location = New System.Drawing.Point(12, 41)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(157, 27)
        Me.ComboBox1.TabIndex = 2
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
        Me.HazelDev_Button1.Location = New System.Drawing.Point(244, 41)
        Me.HazelDev_Button1.Name = "HazelDev_Button1"
        Me.HazelDev_Button1.Size = New System.Drawing.Size(49, 27)
        Me.HazelDev_Button1.TabIndex = 1
        Me.HazelDev_Button1.Text = "확인"
        Me.HazelDev_Button1.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 84)
        Me.Controls.Add(Me.InfluenceTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservation Shutdown"
        Me.InfluenceTheme1.ResumeLayout(False)
        Me.InfluenceTheme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents InfluenceTheme1 As music.InfluenceTheme
    Friend WithEvents HazelDev_Button1 As music.HazelDev_Button
    Friend WithEvents HazelDev_Label1 As music.HazelDev_Label
    Friend WithEvents TextBox1 As music.HazelDev_TextBox
    Friend WithEvents ComboBox1 As music.HazelDev_ComboBox
End Class
