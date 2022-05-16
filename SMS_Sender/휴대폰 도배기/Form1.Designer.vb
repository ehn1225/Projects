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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.InfluenceTheme1 = New 휴대폰_도배기.InfluenceTheme()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.text2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.text7 = New 휴대폰_도배기.InfluenceTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.text6 = New 휴대폰_도배기.InfluenceTextBox()
        Me.text5 = New 휴대폰_도배기.InfluenceTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.text4 = New 휴대폰_도배기.InfluenceTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.text3 = New 휴대폰_도배기.InfluenceTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Text1 = New 휴대폰_도배기.InfluenceTextBox()
        Me.InfluenceTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'InfluenceTheme1
        '
        Me.InfluenceTheme1.CloseButtonExitsApp = False
        Me.InfluenceTheme1.Controls.Add(Me.Label9)
        Me.InfluenceTheme1.Controls.Add(Me.Button2)
        Me.InfluenceTheme1.Controls.Add(Me.Label8)
        Me.InfluenceTheme1.Controls.Add(Me.text2)
        Me.InfluenceTheme1.Controls.Add(Me.Label6)
        Me.InfluenceTheme1.Controls.Add(Me.Label5)
        Me.InfluenceTheme1.Controls.Add(Me.text7)
        Me.InfluenceTheme1.Controls.Add(Me.Label7)
        Me.InfluenceTheme1.Controls.Add(Me.Label4)
        Me.InfluenceTheme1.Controls.Add(Me.text6)
        Me.InfluenceTheme1.Controls.Add(Me.text5)
        Me.InfluenceTheme1.Controls.Add(Me.Label3)
        Me.InfluenceTheme1.Controls.Add(Me.text4)
        Me.InfluenceTheme1.Controls.Add(Me.Label2)
        Me.InfluenceTheme1.Controls.Add(Me.text3)
        Me.InfluenceTheme1.Controls.Add(Me.Button1)
        Me.InfluenceTheme1.Controls.Add(Me.Label1)
        Me.InfluenceTheme1.Controls.Add(Me.Text1)
        Me.InfluenceTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InfluenceTheme1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.InfluenceTheme1.Location = New System.Drawing.Point(0, 0)
        Me.InfluenceTheme1.MinimizeButton = False
        Me.InfluenceTheme1.Name = "InfluenceTheme1"
        Me.InfluenceTheme1.Size = New System.Drawing.Size(446, 246)
        Me.InfluenceTheme1.TabIndex = 0
        Me.InfluenceTheme1.Text = "Send message"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(354, 225)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 12)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Made by Lyc"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Orange
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(370, 71)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 49)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "웹사이트 접속"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Snow
        Me.Label8.Location = New System.Drawing.Point(195, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 18)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "잔여건수 : "
        '
        'text2
        '
        Me.text2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text2.Location = New System.Drawing.Point(198, 71)
        Me.text2.Multiline = True
        Me.text2.Name = "text2"
        Me.text2.Size = New System.Drawing.Size(166, 149)
        Me.text2.TabIndex = 18
        Me.text2.Text = "보낼 내용을 입력해주세요."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(14, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 12)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "보내는사람 외 ""-"" 은 생략"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Snow
        Me.Label5.Location = New System.Drawing.Point(10, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 18)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "보내는사람"
        '
        'text7
        '
        Me.text7.BackColor = System.Drawing.Color.Transparent
        Me.text7.ForeColor = System.Drawing.Color.White
        Me.text7.Location = New System.Drawing.Point(89, 40)
        Me.text7.MaxLength = 32767
        Me.text7.Name = "text7"
        Me.text7.Size = New System.Drawing.Size(97, 25)
        Me.text7.TabIndex = 15
        Me.text7.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.text7.UseSystemPasswordChar = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Snow
        Me.Label7.Location = New System.Drawing.Point(13, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 18)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "받는사람5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Snow
        Me.Label4.Location = New System.Drawing.Point(13, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 18)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "받는사람4"
        '
        'text6
        '
        Me.text6.BackColor = System.Drawing.Color.Transparent
        Me.text6.ForeColor = System.Drawing.Color.White
        Me.text6.Location = New System.Drawing.Point(89, 195)
        Me.text6.MaxLength = 32767
        Me.text6.Name = "text6"
        Me.text6.Size = New System.Drawing.Size(97, 25)
        Me.text6.TabIndex = 13
        Me.text6.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.text6.UseSystemPasswordChar = False
        '
        'text5
        '
        Me.text5.BackColor = System.Drawing.Color.Transparent
        Me.text5.ForeColor = System.Drawing.Color.White
        Me.text5.Location = New System.Drawing.Point(89, 164)
        Me.text5.MaxLength = 32767
        Me.text5.Name = "text5"
        Me.text5.Size = New System.Drawing.Size(97, 25)
        Me.text5.TabIndex = 13
        Me.text5.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.text5.UseSystemPasswordChar = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Snow
        Me.Label3.Location = New System.Drawing.Point(13, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 18)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "받는사람3"
        '
        'text4
        '
        Me.text4.BackColor = System.Drawing.Color.Transparent
        Me.text4.ForeColor = System.Drawing.Color.White
        Me.text4.Location = New System.Drawing.Point(89, 133)
        Me.text4.MaxLength = 32767
        Me.text4.Name = "text4"
        Me.text4.Size = New System.Drawing.Size(97, 25)
        Me.text4.TabIndex = 11
        Me.text4.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.text4.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Snow
        Me.Label2.Location = New System.Drawing.Point(13, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "받는사람2"
        '
        'text3
        '
        Me.text3.BackColor = System.Drawing.Color.Transparent
        Me.text3.ForeColor = System.Drawing.Color.White
        Me.text3.Location = New System.Drawing.Point(89, 102)
        Me.text3.MaxLength = 32767
        Me.text3.Name = "text3"
        Me.text3.Size = New System.Drawing.Size(97, 25)
        Me.text3.TabIndex = 9
        Me.text3.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.text3.UseSystemPasswordChar = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Orange
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button1.Location = New System.Drawing.Point(370, 126)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 94)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "전송"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(13, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "받는사람1"
        '
        'Text1
        '
        Me.Text1.BackColor = System.Drawing.Color.Transparent
        Me.Text1.ForeColor = System.Drawing.Color.White
        Me.Text1.Location = New System.Drawing.Point(89, 71)
        Me.Text1.MaxLength = 32767
        Me.Text1.Name = "Text1"
        Me.Text1.Size = New System.Drawing.Size(97, 25)
        Me.Text1.TabIndex = 1
        Me.Text1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.Text1.UseSystemPasswordChar = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 246)
        Me.Controls.Add(Me.InfluenceTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Send message"
        Me.InfluenceTheme1.ResumeLayout(False)
        Me.InfluenceTheme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents InfluenceTheme1 As 휴대폰_도배기.InfluenceTheme
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Text1 As 휴대폰_도배기.InfluenceTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents text4 As 휴대폰_도배기.InfluenceTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents text3 As 휴대폰_도배기.InfluenceTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents text5 As 휴대폰_도배기.InfluenceTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents text7 As 휴대폰_도배기.InfluenceTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents text6 As 휴대폰_도배기.InfluenceTextBox
    Friend WithEvents text2 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
