﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newplaylist
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
        Me.SuspendLayout()
        '
        'InfluenceTheme1
        '
        Me.InfluenceTheme1.CloseButtonExitsApp = False
        Me.InfluenceTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InfluenceTheme1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.InfluenceTheme1.Location = New System.Drawing.Point(0, 0)
        Me.InfluenceTheme1.MinimizeButton = False
        Me.InfluenceTheme1.Name = "InfluenceTheme1"
        Me.InfluenceTheme1.Size = New System.Drawing.Size(474, 155)
        Me.InfluenceTheme1.TabIndex = 0
        Me.InfluenceTheme1.Text = "InfluenceTheme1"
        '
        'newplaylist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 155)
        Me.Controls.Add(Me.InfluenceTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "newplaylist"
        Me.Text = "newplaylist"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents InfluenceTheme1 As music.InfluenceTheme
End Class
