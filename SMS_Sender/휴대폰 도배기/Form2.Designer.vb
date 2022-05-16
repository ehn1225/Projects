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
        Me.InfluenceTheme1 = New 휴대폰_도배기.InfluenceTheme()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.InfluenceButton2 = New 휴대폰_도배기.InfluenceButton()
        Me.Button1 = New 휴대폰_도배기.InfluenceButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New 휴대폰_도배기.InfluenceTextBox()
        Me.TextBox1 = New 휴대폰_도배기.InfluenceTextBox()
        Me.InfluenceTheme1.SuspendLayout
        Me.SuspendLayout
        '
        'InfluenceTheme1
        '
        Me.InfluenceTheme1.CloseButtonExitsApp = false
        Me.InfluenceTheme1.Controls.Add(Me.CheckBox1)
        Me.InfluenceTheme1.Controls.Add(Me.InfluenceButton2)
        Me.InfluenceTheme1.Controls.Add(Me.Button1)
        Me.InfluenceTheme1.Controls.Add(Me.Label2)
        Me.InfluenceTheme1.Controls.Add(Me.Label1)
        Me.InfluenceTheme1.Controls.Add(Me.TextBox2)
        Me.InfluenceTheme1.Controls.Add(Me.TextBox1)
        Me.InfluenceTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InfluenceTheme1.Font = New System.Drawing.Font("Verdana", 8!)
        Me.InfluenceTheme1.Location = New System.Drawing.Point(0, 0)
        Me.InfluenceTheme1.MinimizeButton = false
        Me.InfluenceTheme1.Name = "InfluenceTheme1"
        Me.InfluenceTheme1.Size = New System.Drawing.Size(304, 124)
        Me.InfluenceTheme1.TabIndex = 0
        Me.InfluenceTheme1.Text = "Login"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = true
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(42, 99)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(92, 17)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "ID, PW 저장"
        Me.CheckBox1.UseVisualStyleBackColor = false
        '
        'InfluenceButton2
        '
        Me.InfluenceButton2.BackColor = System.Drawing.Color.Transparent
        Me.InfluenceButton2.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.InfluenceButton2.Location = New System.Drawing.Point(229, 37)
        Me.InfluenceButton2.Name = "InfluenceButton2"
        Me.InfluenceButton2.Size = New System.Drawing.Size(62, 57)
        Me.InfluenceButton2.TabIndex = 6
        Me.InfluenceButton2.Text = "회원가입"
        Me.InfluenceButton2.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Button1.Location = New System.Drawing.Point(183, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 56)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "접속"
        Me.Button1.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(11, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "PW"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 11)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Transparent
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(42, 68)
        Me.TextBox2.MaxLength = 32767
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(135, 24)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextBox2.UseSystemPasswordChar = true
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Transparent
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(42, 37)
        Me.TextBox1.MaxLength = 32767
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(135, 24)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextBox1.UseSystemPasswordChar = false
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 12!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 124)
        Me.Controls.Add(Me.InfluenceTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Login"
        Me.InfluenceTheme1.ResumeLayout(false)
        Me.InfluenceTheme1.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents InfluenceTheme1 As 휴대폰_도배기.InfluenceTheme
    Friend WithEvents Button1 As 휴대폰_도배기.InfluenceButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As 휴대폰_도배기.InfluenceTextBox
    Friend WithEvents TextBox1 As 휴대폰_도배기.InfluenceTextBox
    Friend WithEvents InfluenceButton2 As 휴대폰_도배기.InfluenceButton
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
