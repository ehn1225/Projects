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
        Dim ColorPack1 As gTrackBar.ColorPack = New gTrackBar.ColorPack()
        Dim ColorPack2 As gTrackBar.ColorPack = New gTrackBar.ColorPack()
        Dim ColorPack3 As gTrackBar.ColorPack = New gTrackBar.ColorPack()
        Dim ColorLinearGradient1 As gTrackBar.ColorLinearGradient = New gTrackBar.ColorLinearGradient()
        Dim ColorLinearGradient2 As gTrackBar.ColorLinearGradient = New gTrackBar.ColorLinearGradient()
        Dim ColorPack4 As gTrackBar.ColorPack = New gTrackBar.ColorPack()
        Dim ColorPack5 As gTrackBar.ColorPack = New gTrackBar.ColorPack()
        Dim ColorPack6 As gTrackBar.ColorPack = New gTrackBar.ColorPack()
        Dim ColorLinearGradient3 As gTrackBar.ColorLinearGradient = New gTrackBar.ColorLinearGradient()
        Dim ColorLinearGradient4 As gTrackBar.ColorLinearGradient = New gTrackBar.ColorLinearGradient()
        Me.다이얼 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.refreshtimer = New System.Windows.Forms.Timer(Me.components)
        Me.폴더다이얼 = New System.Windows.Forms.FolderBrowserDialog()
        Me.lyric = New System.Windows.Forms.Timer(Me.components)
        Me.InfluenceTheme1 = New music.InfluenceTheme()
        Me.time = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.save = New System.Windows.Forms.PictureBox()
        Me.searchmusic = New System.Windows.Forms.ListBox()
        Me.Textsearch = New music.InfluenceTextBox()
        Me.addplaylist = New System.Windows.Forms.PictureBox()
        Me.folder1 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New music.HazelDev_Label()
        Me.Toggle1 = New music.HazelDev_Toggle()
        Me.listbox3 = New System.Windows.Forms.ListBox()
        Me.refreshbt = New System.Windows.Forms.PictureBox()
        Me.musicnamelist = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.playtime = New gTrackBar.gTrackBar()
        Me.음량조절 = New gTrackBar.gTrackBar()
        Me.volume = New System.Windows.Forms.PictureBox()
        Me.mute = New System.Windows.Forms.PictureBox()
        Me.openfolder = New System.Windows.Forms.PictureBox()
        Me.musicname = New System.Windows.Forms.Label()
        Me.플레이어끝시간 = New System.Windows.Forms.Label()
        Me.플레이어재생시간 = New System.Windows.Forms.Label()
        Me.플레이어 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.play = New System.Windows.Forms.PictureBox()
        Me.pause = New System.Windows.Forms.PictureBox()
        Me.rightbt1 = New System.Windows.Forms.PictureBox()
        Me.playlist = New System.Windows.Forms.PictureBox()
        Me.albumart = New System.Windows.Forms.PictureBox()
        Me.delete = New System.Windows.Forms.PictureBox()
        Me.leftbt1 = New System.Windows.Forms.PictureBox()
        Me.openfile = New System.Windows.Forms.PictureBox()
        Me.onefresh = New System.Windows.Forms.PictureBox()
        Me.artistname = New System.Windows.Forms.Label()
        Me.InfluenceTheme1.SuspendLayout()
        CType(Me.time, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addplaylist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.refreshbt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.volume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.openfolder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.플레이어, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.play, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pause, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rightbt1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.playlist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.albumart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.delete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leftbt1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.openfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.onefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '다이얼
        '
        Me.다이얼.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'refreshtimer
        '
        Me.refreshtimer.Interval = 300
        '
        'lyric
        '
        Me.lyric.Interval = 10
        '
        'InfluenceTheme1
        '
        Me.InfluenceTheme1.CloseButtonExitsApp = False
        Me.InfluenceTheme1.Controls.Add(Me.time)
        Me.InfluenceTheme1.Controls.Add(Me.ComboBox1)
        Me.InfluenceTheme1.Controls.Add(Me.save)
        Me.InfluenceTheme1.Controls.Add(Me.searchmusic)
        Me.InfluenceTheme1.Controls.Add(Me.Textsearch)
        Me.InfluenceTheme1.Controls.Add(Me.addplaylist)
        Me.InfluenceTheme1.Controls.Add(Me.folder1)
        Me.InfluenceTheme1.Controls.Add(Me.TextBox1)
        Me.InfluenceTheme1.Controls.Add(Me.Label1)
        Me.InfluenceTheme1.Controls.Add(Me.Toggle1)
        Me.InfluenceTheme1.Controls.Add(Me.listbox3)
        Me.InfluenceTheme1.Controls.Add(Me.refreshbt)
        Me.InfluenceTheme1.Controls.Add(Me.musicnamelist)
        Me.InfluenceTheme1.Controls.Add(Me.ListBox2)
        Me.InfluenceTheme1.Controls.Add(Me.playtime)
        Me.InfluenceTheme1.Controls.Add(Me.음량조절)
        Me.InfluenceTheme1.Controls.Add(Me.volume)
        Me.InfluenceTheme1.Controls.Add(Me.mute)
        Me.InfluenceTheme1.Controls.Add(Me.openfolder)
        Me.InfluenceTheme1.Controls.Add(Me.musicname)
        Me.InfluenceTheme1.Controls.Add(Me.플레이어끝시간)
        Me.InfluenceTheme1.Controls.Add(Me.플레이어재생시간)
        Me.InfluenceTheme1.Controls.Add(Me.플레이어)
        Me.InfluenceTheme1.Controls.Add(Me.play)
        Me.InfluenceTheme1.Controls.Add(Me.pause)
        Me.InfluenceTheme1.Controls.Add(Me.rightbt1)
        Me.InfluenceTheme1.Controls.Add(Me.playlist)
        Me.InfluenceTheme1.Controls.Add(Me.albumart)
        Me.InfluenceTheme1.Controls.Add(Me.delete)
        Me.InfluenceTheme1.Controls.Add(Me.leftbt1)
        Me.InfluenceTheme1.Controls.Add(Me.openfile)
        Me.InfluenceTheme1.Controls.Add(Me.onefresh)
        Me.InfluenceTheme1.Controls.Add(Me.artistname)
        Me.InfluenceTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InfluenceTheme1.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.InfluenceTheme1.Location = New System.Drawing.Point(0, 0)
        Me.InfluenceTheme1.MinimizeButton = True
        Me.InfluenceTheme1.Name = "InfluenceTheme1"
        Me.InfluenceTheme1.Size = New System.Drawing.Size(627, 358)
        Me.InfluenceTheme1.TabIndex = 0
        Me.InfluenceTheme1.Text = "Simple Music Player"
        '
        'time
        '
        Me.time.BackColor = System.Drawing.Color.Transparent
        Me.time.Image = Global.music.My.Resources.Resources._1427648552_timer
        Me.time.Location = New System.Drawing.Point(591, 320)
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(26, 26)
        Me.time.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.time.TabIndex = 209
        Me.time.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"한곡삭제", "폴더삭제", "전곡삭제", "전체삭제"})
        Me.ComboBox1.Location = New System.Drawing.Point(201, 33)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(79, 26)
        Me.ComboBox1.TabIndex = 207
        Me.ComboBox1.Visible = False
        '
        'save
        '
        Me.save.BackColor = System.Drawing.Color.Transparent
        Me.save.Image = Global.music.My.Resources.Resources._1427541173_save
        Me.save.Location = New System.Drawing.Point(137, 33)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(26, 26)
        Me.save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.save.TabIndex = 201
        Me.save.TabStop = False
        Me.save.Visible = False
        '
        'searchmusic
        '
        Me.searchmusic.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.searchmusic.ForeColor = System.Drawing.Color.White
        Me.searchmusic.FormattingEnabled = True
        Me.searchmusic.ItemHeight = 14
        Me.searchmusic.Location = New System.Drawing.Point(407, 65)
        Me.searchmusic.Name = "searchmusic"
        Me.searchmusic.Size = New System.Drawing.Size(217, 88)
        Me.searchmusic.TabIndex = 199
        Me.searchmusic.Visible = False
        '
        'Textsearch
        '
        Me.Textsearch.BackColor = System.Drawing.Color.Transparent
        Me.Textsearch.ForeColor = System.Drawing.Color.White
        Me.Textsearch.Location = New System.Drawing.Point(407, 35)
        Me.Textsearch.MaxLength = 32767
        Me.Textsearch.Name = "Textsearch"
        Me.Textsearch.Size = New System.Drawing.Size(217, 26)
        Me.Textsearch.TabIndex = 196
        Me.Textsearch.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.Textsearch.UseSystemPasswordChar = False
        Me.Textsearch.Visible = False
        '
        'addplaylist
        '
        Me.addplaylist.BackColor = System.Drawing.Color.Transparent
        Me.addplaylist.Image = Global.music.My.Resources.Resources._1427517194_add_list
        Me.addplaylist.Location = New System.Drawing.Point(105, 33)
        Me.addplaylist.Name = "addplaylist"
        Me.addplaylist.Size = New System.Drawing.Size(26, 26)
        Me.addplaylist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.addplaylist.TabIndex = 194
        Me.addplaylist.TabStop = False
        Me.addplaylist.Visible = False
        '
        'folder1
        '
        Me.folder1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.folder1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.folder1.ForeColor = System.Drawing.Color.White
        Me.folder1.FormattingEnabled = True
        Me.folder1.ItemHeight = 16
        Me.folder1.Location = New System.Drawing.Point(3, 63)
        Me.folder1.Name = "folder1"
        Me.folder1.Size = New System.Drawing.Size(135, 292)
        Me.folder1.TabIndex = 192
        Me.folder1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(599, 264)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(18, 25)
        Me.TextBox1.TabIndex = 188
        Me.TextBox1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(462, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 18)
        Me.Label1.TabIndex = 184
        Me.Label1.Text = "실시간가사"
        '
        'Toggle1
        '
        Me.Toggle1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Toggle1.DrawBorders = False
        Me.Toggle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Toggle1.Location = New System.Drawing.Point(535, 43)
        Me.Toggle1.Name = "Toggle1"
        Me.Toggle1.Size = New System.Drawing.Size(76, 27)
        Me.Toggle1.TabIndex = 182
        Me.Toggle1.Text = "HazelDev_Toggle1"
        Me.Toggle1.Toggled = False
        '
        'listbox3
        '
        Me.listbox3.FormattingEnabled = True
        Me.listbox3.ItemHeight = 14
        Me.listbox3.Location = New System.Drawing.Point(555, 271)
        Me.listbox3.Name = "listbox3"
        Me.listbox3.Size = New System.Drawing.Size(36, 18)
        Me.listbox3.TabIndex = 174
        Me.listbox3.Visible = False
        '
        'refreshbt
        '
        Me.refreshbt.BackColor = System.Drawing.Color.Transparent
        Me.refreshbt.Image = CType(resources.GetObject("refreshbt.Image"), System.Drawing.Image)
        Me.refreshbt.Location = New System.Drawing.Point(561, 322)
        Me.refreshbt.Name = "refreshbt"
        Me.refreshbt.Size = New System.Drawing.Size(24, 24)
        Me.refreshbt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.refreshbt.TabIndex = 152
        Me.refreshbt.TabStop = False
        '
        'musicnamelist
        '
        Me.musicnamelist.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.musicnamelist.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.musicnamelist.ForeColor = System.Drawing.Color.White
        Me.musicnamelist.FormattingEnabled = True
        Me.musicnamelist.ItemHeight = 16
        Me.musicnamelist.Location = New System.Drawing.Point(137, 63)
        Me.musicnamelist.Name = "musicnamelist"
        Me.musicnamelist.Size = New System.Drawing.Size(487, 292)
        Me.musicnamelist.TabIndex = 9
        Me.musicnamelist.Visible = False
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 14
        Me.ListBox2.Location = New System.Drawing.Point(9, 161)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(26, 4)
        Me.ListBox2.TabIndex = 11
        Me.ListBox2.Visible = False
        '
        'playtime
        '
        Me.playtime.ArrowColorHover = System.Drawing.Color.AliceBlue
        Me.playtime.BackColor = System.Drawing.Color.Transparent
        Me.playtime.BrushDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.playtime.ChangeLarge = 1
        ColorPack1.Border = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        ColorPack1.Face = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        ColorPack1.Highlight = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.playtime.ColorDown = ColorPack1
        ColorPack2.Border = System.Drawing.Color.White
        ColorPack2.Face = System.Drawing.Color.White
        ColorPack2.Highlight = System.Drawing.Color.White
        Me.playtime.ColorHover = ColorPack2
        ColorPack3.Border = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        ColorPack3.Face = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        ColorPack3.Highlight = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.playtime.ColorUp = ColorPack3
        Me.playtime.FloatValue = False
        Me.playtime.JumpToMouse = True
        Me.playtime.Label = Nothing
        Me.playtime.Location = New System.Drawing.Point(109, 243)
        Me.playtime.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.playtime.MaxValue = 100
        Me.playtime.Name = "playtime"
        Me.playtime.ShowFocus = False
        Me.playtime.Size = New System.Drawing.Size(426, 24)
        Me.playtime.SliderCapEnd = System.Drawing.Drawing2D.LineCap.RoundAnchor
        Me.playtime.SliderCapStart = System.Drawing.Drawing2D.LineCap.RoundAnchor
        ColorLinearGradient1.ColorA = System.Drawing.Color.DimGray
        ColorLinearGradient1.ColorB = System.Drawing.Color.DimGray
        Me.playtime.SliderColorHigh = ColorLinearGradient1
        ColorLinearGradient2.ColorA = System.Drawing.Color.White
        ColorLinearGradient2.ColorB = System.Drawing.Color.White
        Me.playtime.SliderColorLow = ColorLinearGradient2
        Me.playtime.SliderShape = gTrackBar.gTrackBar.eShape.Rectangle
        Me.playtime.SliderSize = New System.Drawing.Size(7, 20)
        Me.playtime.SliderWidthHigh = 1.0!
        Me.playtime.SliderWidthLow = 1.0!
        Me.playtime.TabIndex = 148
        Me.playtime.TickInterval = 20
        Me.playtime.TickOffset = 2
        Me.playtime.TickThickness = 1.0!
        Me.playtime.TickWidth = 7
        Me.playtime.UpDownAutoWidth = False
        Me.playtime.UpDownShow = False
        Me.playtime.Value = 0
        Me.playtime.ValueAdjusted = 0.0!
        Me.playtime.ValueBoxBackColor = System.Drawing.Color.Transparent
        Me.playtime.ValueBoxBorder = System.Drawing.Color.White
        Me.playtime.ValueBoxFont = New System.Drawing.Font("Arial", 9.0!)
        Me.playtime.ValueBoxFontColor = System.Drawing.Color.White
        Me.playtime.ValueDivisor = gTrackBar.gTrackBar.eValueDivisor.e1
        Me.playtime.ValueStrFormat = Nothing
        '
        '음량조절
        '
        Me.음량조절.ArrowColorHover = System.Drawing.Color.AliceBlue
        Me.음량조절.BackColor = System.Drawing.Color.Transparent
        Me.음량조절.BrushDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        ColorPack4.Border = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        ColorPack4.Face = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        ColorPack4.Highlight = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.음량조절.ColorDown = ColorPack4
        ColorPack5.Border = System.Drawing.Color.White
        ColorPack5.Face = System.Drawing.Color.White
        ColorPack5.Highlight = System.Drawing.Color.White
        Me.음량조절.ColorHover = ColorPack5
        ColorPack6.Border = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        ColorPack6.Face = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        ColorPack6.Highlight = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.음량조절.ColorUp = ColorPack6
        Me.음량조절.FloatValue = False
        Me.음량조절.JumpToMouse = True
        Me.음량조절.Label = Nothing
        Me.음량조절.Location = New System.Drawing.Point(582, 108)
        Me.음량조절.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.음량조절.MaxValue = 100
        Me.음량조절.Name = "음량조절"
        Me.음량조절.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.음량조절.ShowFocus = False
        Me.음량조절.Size = New System.Drawing.Size(34, 128)
        ColorLinearGradient3.ColorA = System.Drawing.Color.White
        ColorLinearGradient3.ColorB = System.Drawing.Color.White
        Me.음량조절.SliderColorHigh = ColorLinearGradient3
        ColorLinearGradient4.ColorA = System.Drawing.Color.DimGray
        ColorLinearGradient4.ColorB = System.Drawing.Color.DimGray
        Me.음량조절.SliderColorLow = ColorLinearGradient4
        Me.음량조절.SliderShape = gTrackBar.gTrackBar.eShape.Rectangle
        Me.음량조절.SliderSize = New System.Drawing.Size(16, 7)
        Me.음량조절.SliderWidthHigh = 1.0!
        Me.음량조절.SliderWidthLow = 1.0!
        Me.음량조절.TabIndex = 144
        Me.음량조절.TickInterval = 20
        Me.음량조절.TickOffset = 2
        Me.음량조절.TickThickness = 1.0!
        Me.음량조절.TickType = gTrackBar.gTrackBar.eTickType.Both
        Me.음량조절.TickWidth = 7
        Me.음량조절.UpDownAutoWidth = False
        Me.음량조절.UpDownShow = False
        Me.음량조절.Value = 80
        Me.음량조절.ValueAdjusted = 80.0!
        Me.음량조절.ValueBox = gTrackBar.gTrackBar.eValueBox.Right
        Me.음량조절.ValueBoxBackColor = System.Drawing.Color.Transparent
        Me.음량조절.ValueBoxBorder = System.Drawing.Color.White
        Me.음량조절.ValueBoxFont = New System.Drawing.Font("Arial", 9.0!)
        Me.음량조절.ValueBoxFontColor = System.Drawing.Color.White
        Me.음량조절.ValueDivisor = gTrackBar.gTrackBar.eValueDivisor.e1
        Me.음량조절.ValueStrFormat = Nothing
        '
        'volume
        '
        Me.volume.BackColor = System.Drawing.Color.Transparent
        Me.volume.Image = CType(resources.GetObject("volume.Image"), System.Drawing.Image)
        Me.volume.Location = New System.Drawing.Point(585, 80)
        Me.volume.Name = "volume"
        Me.volume.Size = New System.Drawing.Size(26, 26)
        Me.volume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.volume.TabIndex = 141
        Me.volume.TabStop = False
        '
        'mute
        '
        Me.mute.BackColor = System.Drawing.Color.Transparent
        Me.mute.Image = CType(resources.GetObject("mute.Image"), System.Drawing.Image)
        Me.mute.Location = New System.Drawing.Point(585, 80)
        Me.mute.Name = "mute"
        Me.mute.Size = New System.Drawing.Size(26, 26)
        Me.mute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.mute.TabIndex = 139
        Me.mute.TabStop = False
        '
        'openfolder
        '
        Me.openfolder.BackColor = System.Drawing.Color.Transparent
        Me.openfolder.Image = CType(resources.GetObject("openfolder.Image"), System.Drawing.Image)
        Me.openfolder.Location = New System.Drawing.Point(73, 33)
        Me.openfolder.Name = "openfolder"
        Me.openfolder.Size = New System.Drawing.Size(26, 26)
        Me.openfolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.openfolder.TabIndex = 33
        Me.openfolder.TabStop = False
        '
        'musicname
        '
        Me.musicname.AutoSize = True
        Me.musicname.BackColor = System.Drawing.Color.Transparent
        Me.musicname.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.musicname.Font = New System.Drawing.Font("Verdana", 13.0!)
        Me.musicname.ForeColor = System.Drawing.Color.White
        Me.musicname.Location = New System.Drawing.Point(168, 84)
        Me.musicname.Name = "musicname"
        Me.musicname.Size = New System.Drawing.Size(61, 22)
        Me.musicname.TabIndex = 24
        Me.musicname.Text = "NAME"
        '
        '플레이어끝시간
        '
        Me.플레이어끝시간.AutoSize = True
        Me.플레이어끝시간.BackColor = System.Drawing.Color.Transparent
        Me.플레이어끝시간.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.플레이어끝시간.Location = New System.Drawing.Point(507, 227)
        Me.플레이어끝시간.Name = "플레이어끝시간"
        Me.플레이어끝시간.Size = New System.Drawing.Size(0, 14)
        Me.플레이어끝시간.TabIndex = 22
        '
        '플레이어재생시간
        '
        Me.플레이어재생시간.AutoSize = True
        Me.플레이어재생시간.BackColor = System.Drawing.Color.Transparent
        Me.플레이어재생시간.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.플레이어재생시간.Location = New System.Drawing.Point(99, 227)
        Me.플레이어재생시간.Name = "플레이어재생시간"
        Me.플레이어재생시간.Size = New System.Drawing.Size(0, 14)
        Me.플레이어재생시간.TabIndex = 21
        '
        '플레이어
        '
        Me.플레이어.Enabled = True
        Me.플레이어.Location = New System.Drawing.Point(12, 173)
        Me.플레이어.Name = "플레이어"
        Me.플레이어.OcxState = CType(resources.GetObject("플레이어.OcxState"), System.Windows.Forms.AxHost.State)
        Me.플레이어.Size = New System.Drawing.Size(26, 26)
        Me.플레이어.TabIndex = 13
        Me.플레이어.Visible = False
        '
        'play
        '
        Me.play.BackColor = System.Drawing.Color.Transparent
        Me.play.Image = CType(resources.GetObject("play.Image"), System.Drawing.Image)
        Me.play.Location = New System.Drawing.Point(296, 276)
        Me.play.Name = "play"
        Me.play.Size = New System.Drawing.Size(48, 64)
        Me.play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.play.TabIndex = 9
        Me.play.TabStop = False
        '
        'pause
        '
        Me.pause.BackColor = System.Drawing.Color.Transparent
        Me.pause.Image = CType(resources.GetObject("pause.Image"), System.Drawing.Image)
        Me.pause.Location = New System.Drawing.Point(296, 276)
        Me.pause.Name = "pause"
        Me.pause.Size = New System.Drawing.Size(48, 64)
        Me.pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pause.TabIndex = 11
        Me.pause.TabStop = False
        '
        'rightbt1
        '
        Me.rightbt1.BackColor = System.Drawing.Color.Transparent
        Me.rightbt1.Image = CType(resources.GetObject("rightbt1.Image"), System.Drawing.Image)
        Me.rightbt1.Location = New System.Drawing.Point(420, 276)
        Me.rightbt1.Name = "rightbt1"
        Me.rightbt1.Size = New System.Drawing.Size(64, 64)
        Me.rightbt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.rightbt1.TabIndex = 8
        Me.rightbt1.TabStop = False
        '
        'playlist
        '
        Me.playlist.BackColor = System.Drawing.Color.Transparent
        Me.playlist.Image = CType(resources.GetObject("playlist.Image"), System.Drawing.Image)
        Me.playlist.Location = New System.Drawing.Point(9, 33)
        Me.playlist.Name = "playlist"
        Me.playlist.Size = New System.Drawing.Size(26, 26)
        Me.playlist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.playlist.TabIndex = 5
        Me.playlist.TabStop = False
        '
        'albumart
        '
        Me.albumart.BackColor = System.Drawing.Color.Transparent
        Me.albumart.Image = Global.music.My.Resources.Resources._1423420162_folder_cd
        Me.albumart.Location = New System.Drawing.Point(35, 84)
        Me.albumart.Name = "albumart"
        Me.albumart.Size = New System.Drawing.Size(128, 128)
        Me.albumart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.albumart.TabIndex = 4
        Me.albumart.TabStop = False
        '
        'delete
        '
        Me.delete.BackColor = System.Drawing.Color.Transparent
        Me.delete.Image = CType(resources.GetObject("delete.Image"), System.Drawing.Image)
        Me.delete.Location = New System.Drawing.Point(169, 33)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(26, 26)
        Me.delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.delete.TabIndex = 3
        Me.delete.TabStop = False
        Me.delete.Visible = False
        '
        'leftbt1
        '
        Me.leftbt1.BackColor = System.Drawing.Color.Transparent
        Me.leftbt1.Image = CType(resources.GetObject("leftbt1.Image"), System.Drawing.Image)
        Me.leftbt1.Location = New System.Drawing.Point(156, 276)
        Me.leftbt1.Name = "leftbt1"
        Me.leftbt1.Size = New System.Drawing.Size(64, 64)
        Me.leftbt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.leftbt1.TabIndex = 2
        Me.leftbt1.TabStop = False
        '
        'openfile
        '
        Me.openfile.BackColor = System.Drawing.Color.Transparent
        Me.openfile.Image = CType(resources.GetObject("openfile.Image"), System.Drawing.Image)
        Me.openfile.Location = New System.Drawing.Point(41, 33)
        Me.openfile.Name = "openfile"
        Me.openfile.Size = New System.Drawing.Size(26, 26)
        Me.openfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.openfile.TabIndex = 1
        Me.openfile.TabStop = False
        '
        'onefresh
        '
        Me.onefresh.BackColor = System.Drawing.Color.Transparent
        Me.onefresh.Image = CType(resources.GetObject("onefresh.Image"), System.Drawing.Image)
        Me.onefresh.Location = New System.Drawing.Point(591, 322)
        Me.onefresh.Name = "onefresh"
        Me.onefresh.Size = New System.Drawing.Size(24, 24)
        Me.onefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.onefresh.TabIndex = 155
        Me.onefresh.TabStop = False
        Me.onefresh.Visible = False
        '
        'artistname
        '
        Me.artistname.AutoSize = True
        Me.artistname.BackColor = System.Drawing.Color.Transparent
        Me.artistname.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.artistname.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.artistname.ForeColor = System.Drawing.Color.White
        Me.artistname.Location = New System.Drawing.Point(169, 108)
        Me.artistname.MaximumSize = New System.Drawing.Size(348, 0)
        Me.artistname.Name = "artistname"
        Me.artistname.Size = New System.Drawing.Size(65, 14)
        Me.artistname.TabIndex = 157
        Me.artistname.Text = "subname"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 358)
        Me.Controls.Add(Me.InfluenceTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simple Music Player"
        Me.InfluenceTheme1.ResumeLayout(False)
        Me.InfluenceTheme1.PerformLayout()
        CType(Me.time, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addplaylist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.refreshbt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.volume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.openfolder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.플레이어, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.play, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pause, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rightbt1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.playlist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.albumart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.delete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leftbt1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.openfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.onefresh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents 다이얼 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents openfile As System.Windows.Forms.PictureBox
    Friend WithEvents leftbt1 As System.Windows.Forms.PictureBox
    Friend WithEvents delete As System.Windows.Forms.PictureBox
    Friend WithEvents albumart As System.Windows.Forms.PictureBox
    Friend WithEvents playlist As System.Windows.Forms.PictureBox
    Friend WithEvents rightbt1 As System.Windows.Forms.PictureBox
    Friend WithEvents pause As System.Windows.Forms.PictureBox
    Friend WithEvents play As System.Windows.Forms.PictureBox
    Friend WithEvents 플레이어 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents 플레이어재생시간 As System.Windows.Forms.Label
    Friend WithEvents 플레이어끝시간 As System.Windows.Forms.Label
    Friend WithEvents musicname As System.Windows.Forms.Label
    Friend WithEvents InfluenceTheme1 As music.InfluenceTheme
    Friend WithEvents refreshtimer As System.Windows.Forms.Timer
    Friend WithEvents openfolder As System.Windows.Forms.PictureBox
    Friend WithEvents volume As System.Windows.Forms.PictureBox
    Friend WithEvents mute As System.Windows.Forms.PictureBox
    Friend WithEvents 음량조절 As gTrackBar.gTrackBar
    Friend WithEvents playtime As gTrackBar.gTrackBar
    Friend WithEvents 폴더다이얼 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents musicnamelist As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents refreshbt As System.Windows.Forms.PictureBox
    Friend WithEvents onefresh As System.Windows.Forms.PictureBox
    Friend WithEvents artistname As System.Windows.Forms.Label
    Friend WithEvents lyric As System.Windows.Forms.Timer
    Friend WithEvents listbox3 As System.Windows.Forms.ListBox
    Friend WithEvents Toggle1 As music.HazelDev_Toggle
    Friend WithEvents Label1 As music.HazelDev_Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents folder1 As System.Windows.Forms.ListBox
    Friend WithEvents addplaylist As System.Windows.Forms.PictureBox
    Friend WithEvents Textsearch As music.InfluenceTextBox
    Friend WithEvents searchmusic As System.Windows.Forms.ListBox
    Friend WithEvents save As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents time As System.Windows.Forms.PictureBox

End Class
