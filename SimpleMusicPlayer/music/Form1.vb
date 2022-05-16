Option Explicit On
Imports TagLib
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Web
Public Class Form1
    Private Media As TagLib.File
    Public Function GetLyricsFromStyleRoot(ByVal FileName As String) As String
        On Error Resume Next
        Dim Data As Byte()
        Using Media As TagLib.File = TagLib.File.Create(플레이어.URL)
            Using FileStream As New IO.FileStream(FileName, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.ReadWrite)
                Dim BinaryReader As New IO.BinaryReader(FileStream)
                FileStream.Seek(Media.InvariantStartPosition, IO.SeekOrigin.Begin)
                Data = BinaryReader.ReadBytes(163800)
                FileStream.Close()
            End Using
        End Using
        Dim WebClient As New Net.WebClient
        WebClient.Encoding = System.Text.Encoding.UTF8
        Return WebClient.DownloadString("http://aspx.styleroot.com/VertexLRC/Default.aspx?get=true&md5=" & GetMD5Hash(Data).ToLower())
    End Function
    Private Function GetMD5Hash(Source As Byte()) As String
        On Error Resume Next
        Dim MD5 As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim Data As Byte() = Source
        Data = MD5.ComputeHash(Data)
        Dim Result As String = String.Empty
        Dim Bytes As Byte = 0
        For Each BytesLoop As Byte In Data
            Bytes = BytesLoop
            Result += Bytes.ToString("x2")
        Next
        Return Result
    End Function
    Private Sub pause_MouseMove(sender As Object, e As MouseEventArgs) Handles pause.MouseMove
        pause.Image = music.My.Resources.Resources.image1_1_
    End Sub
    Private Sub play_MouseMove(sender As Object, e As MouseEventArgs) Handles play.MouseMove
        play.Image = music.My.Resources.Resources.play2_1_
    End Sub
    Private Sub play_MouseLeave(sender As Object, e As EventArgs) Handles play.MouseLeave
        play.Image = music.My.Resources.Resources._1423429966_play_64
    End Sub
    Private Sub pause_MouseLeave(sender As Object, e As EventArgs) Handles pause.MouseLeave
        pause.Image = music.My.Resources.Resources._1423429994_pause_64
    End Sub
    Private Sub leftbt1_MouseMove(sender As Object, e As MouseEventArgs) Handles leftbt1.MouseMove
        leftbt1.Image = music.My.Resources.Resources.left1_1_
    End Sub
    Private Sub leftbt1_MouseLeave(sender As Object, e As EventArgs) Handles leftbt1.MouseLeave
        leftbt1.Image = music.My.Resources.Resources._1423417376_arrow_left_01_64
    End Sub
    Private Sub rightbt1_MouseLeave(sender As Object, e As EventArgs) Handles rightbt1.MouseLeave
        rightbt1.Image = music.My.Resources.Resources._1423426689_arrow_right_01_641
    End Sub
    Private Sub rightbt1_MouseMove(sender As Object, e As MouseEventArgs) Handles rightbt1.MouseMove
        rightbt1.Image = music.My.Resources.Resources.right3_1_
    End Sub
    Private Sub delete_MouseMove(sender As Object, e As MouseEventArgs) Handles delete.MouseMove
        delete.Image = My.Resources.Resources.tr4_1_
    End Sub
    Private Sub delete_MouseLeave(sender As Object, e As EventArgs) Handles delete.MouseLeave
        delete.Image = music.My.Resources.Resources._1423423291_trash
    End Sub
    Private Sub playlist_MouseMove(sender As Object, e As MouseEventArgs) Handles playlist.MouseMove
        playlist.Image = music.My.Resources.Resources.image2_1_1
    End Sub
    Private Sub playlist_MouseLeave(sender As Object, e As EventArgs) Handles playlist.MouseLeave
        playlist.Image = music.My.Resources.Resources._1423423311_View_Details1
    End Sub
    Private Sub openfile_MouseMove(sender As Object, e As MouseEventArgs) Handles openfile.MouseMove
        openfile.Image = music.My.Resources.Resources.image1
    End Sub
    Private Sub openfile_MouseLeave(sender As Object, e As EventArgs) Handles openfile.MouseLeave
        openfile.Image = music.My.Resources.Resources._1423423073_add_file1
    End Sub
    Private Sub openfolder_MouseMove(sender As Object, e As MouseEventArgs) Handles openfolder.MouseMove
        openfolder.Image = music.My.Resources.Resources.folder_1_1
    End Sub
    Private Sub openfolder_MouseLeave(sender As Object, e As EventArgs) Handles openfolder.MouseLeave
        openfolder.Image = music.My.Resources.Resources._1423423158_add_folder1
    End Sub
    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles mute.MouseLeave
        mute.Image = music.My.Resources.Resources._1423570357_mute_1_
    End Sub
    Private Sub mute_MouseMove(sender As Object, e As MouseEventArgs) Handles mute.MouseMove
        mute.Image = music.My.Resources.Resources.휜_사운드3_1_
    End Sub
    Private Sub playtime_MouseDown(sender As Object, e As MouseEventArgs) Handles playtime.MouseDown
        플레이어.Ctlcontrols.currentPosition = playtime.Value
    End Sub
    Private Sub form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        다이얼.Title = "열기" '다이얼로그의 타이틀의 이름을 변경합니다.
        다이얼.Filter = "MP3파일|*.mp3|WAV파일|*.wav|WMA파일|*.wma|OGG파일|*.ogg|모든파일|*.*" '다이얼로그에 필터를 적용합니다.
        '(ex: MP3|*.mp3 를 입력하면 MP3가 출력되고 mp3 확장명만 표시됨, *은 전체)
        다이얼.RestoreDirectory = True '다이얼로그에 마지막으로 닫은 디렉터리가 저장됩니다.
        My.Settings.name1 = 0
    End Sub
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        On Error Resume Next
        If MsgBox("Simple Music Player 를 종료하시겠습니까?." & Chr(10) & "음악이 재생중이였다면 종료됩니다.", vbYesNo, "Simple Music Player 종료") = vbYes Then

        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub openfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles openfile.Click
        On Error Resume Next
        다이얼.FileName = "" '다이얼로그의 파일경로를 ""으로 변경합니다.
        다이얼.ShowDialog() '다이얼로그를 보여줍니다.
        If 다이얼.FileName = "" Then '다이얼로그의 파일경로가 ""일경우
            MsgBox("파일이 선택되지않았습니다.", 16 + 0, "") '메세지박스를 출력
        Else '아닐경우
            musicnamelist.Items.Add(다이얼.SafeFileName)
            ListBox2.Items.Add(다이얼.FileName)
            Timer1.Start()
            lyric.Start()
            If 플레이어.URL = "" Then
                플레이어.URL = 다이얼.FileName
                Media = TagLib.File.Create(다이얼.FileName)
            End If
        End If
        Dim name, url
        For i = 0 To musicnamelist.Items.Count
            name = name & "<" & i & ">" & musicnamelist.Items(i) & "<" & i & ">"
            SaveSetting("Simplemusic", "playlist", folder1.SelectedItem & "name", name) ' 파일이름 저장
            url = url & "<" & i & ">" & ListBox2.Items(i) & "<" & i & ">"
            SaveSetting("Simplemusic", "playlist", folder1.SelectedItem & "url", url) ' 파일경로 저장
            SaveSetting("Simplemusic", "playlist", folder1.SelectedItem & "count", musicnamelist.Items.Count)
        Next
    End Sub
    Private Sub refreshbt_Click(sender As Object, e As EventArgs) Handles refreshbt.Click
        On Error Resume Next
        If refreshtimer.Enabled = True Then
            refreshbt.Image = music.My.Resources.Resources._1423728728_sync_01_24_1_1
            refreshbt.Visible = False
            onefresh.Visible = True
            My.Settings.refresh = 1
        Else
            refreshtimer.Start()
            refreshbt.Image = music.My.Resources.Resources.image56_1_1
            refreshbt.Visible = True
        End If
    End Sub
    Private Sub refreshtimer_Tick(sender As Object, e As EventArgs) Handles refreshtimer.Tick
        On Error Resume Next
        Select Case My.Settings.refresh
            Case 0
                If 플레이어.playState = WMPLib.WMPPlayState.wmppsStopped Then
                    If My.Settings.name1 = musicnamelist.Items.Count Then
                        My.Settings.name1 = 0
                        플레이어.URL = ListBox2.Items(My.Settings.name1)
                        Media = TagLib.File.Create(ListBox2.Items(My.Settings.name1))
                        TextBox1.Text = GetLyricsFromStyleRoot(플레이어.URL)
                    Else
                        My.Settings.name1 = My.Settings.name1 + 1
                        플레이어.URL = ListBox2.Items(My.Settings.name1)
                        Media = TagLib.File.Create(ListBox2.Items(My.Settings.name1))
                        TextBox1.Text = GetLyricsFromStyleRoot(플레이어.URL)
                    End If
                End If
            Case 1
                If 플레이어.playState = WMPLib.WMPPlayState.wmppsStopped Then
                    플레이어.Ctlcontrols.play()
                End If
        End Select
    End Sub
    Private Sub onefresh_Click(sender As Object, e As EventArgs) Handles onefresh.Click
        My.Settings.refresh = 0
        refreshbt.Visible = True
        onefresh.Visible = False
        refreshtimer.Stop()
    End Sub
    Private Sub 플레이어끝시간_DoubleClick(sender As Object, e As EventArgs) Handles 플레이어끝시간.DoubleClick
        MessageBox.Show("제작자 : LYC" & Chr(10) & "E-mail : ehn1225@naver.com" & Chr(10) & "제작년월 : 20150329" & Chr(10) & "Lyrics Powered By. StyleRoot.", "제작자정보")
    End Sub
    Private Sub volume_Click(sender As Object, e As EventArgs) Handles volume.Click
        mute.Visible = True
        volume.Visible = False
        My.Settings.volume = 음량조절.Value
        음량조절.Value = 0
    End Sub
    Private Sub mute_Click(sender As Object, e As EventArgs) Handles mute.Click
        mute.Visible = False
        volume.Visible = True
        음량조절.Value = My.Settings.volume
    End Sub
    Private Sub 음량조절_MouseMove(sender As Object, e As MouseEventArgs) Handles 음량조절.MouseMove
        플레이어.settings.volume = 음량조절.Value '의 음량을 음량조절의 Value 로 설정
        mute.Visible = False
        volume.Visible = True
        If 음량조절.Value = 0 Then
            volume.Image = music.My.Resources.Resources._1423570357_mute
        ElseIf 음량조절.Value < 30 Then
            volume.Image = music.My.Resources.Resources._1423570255_volume_down
        ElseIf 음량조절.Value < 70 Then
            volume.Image = music.My.Resources.Resources.vol2b1
        ElseIf 음량조절.Value >= 70 Then
            volume.Image = music.My.Resources.Resources._1423570277_volume_up_1_1
        End If
    End Sub
    Private Sub volume_MouseMove(sender As Object, e As MouseEventArgs) Handles volume.MouseMove
        If 음량조절.Value = 0 Then
            volume.Image = music.My.Resources.Resources.휜_사운드3
        ElseIf 음량조절.Value < 30 Then
            volume.Image = music.My.Resources.Resources.휜_사운드1
        ElseIf 음량조절.Value < 70 Then
            volume.Image = music.My.Resources.Resources.vol2
        ElseIf 음량조절.Value >= 70 Then
            volume.Image = music.My.Resources.Resources.휜_사운드2_1_
        End If
    End Sub
    Private Sub volume_MouseLeave(sender As Object, e As EventArgs) Handles volume.MouseLeave
        If 음량조절.Value = 0 Then
            volume.Image = music.My.Resources.Resources._1423570357_mute
        ElseIf 음량조절.Value < 30 Then
            volume.Image = music.My.Resources.Resources._1423570255_volume_down
        ElseIf 음량조절.Value < 70 Then
            volume.Image = music.My.Resources.Resources.vol2b1
        ElseIf 음량조절.Value >= 70 Then
            volume.Image = music.My.Resources.Resources._1423570277_volume_up_1_1
        End If
    End Sub
    Private Sub pause_Click(sender As Object, e As EventArgs) Handles pause.Click
        Timer1.Stop()
        lyric.Stop()
        플레이어.Ctlcontrols.pause()
        play.Visible = True
        pause.Visible = False
    End Sub
    Private Sub openfolder_Click(sender As Object, e As EventArgs) Handles openfolder.Click
        On Error Resume Next
        Dim url, name
        If 폴더다이얼.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim Extensions As String() = {".mp3", ".wav", ".wma", ".ogg"}
            Dim DirFileGet As String() = IO.Directory.GetFiles(폴더다이얼.SelectedPath, "*.*", IO.SearchOption.TopDirectoryOnly).Where(Function(F) Extensions.Contains(System.IO.Path.GetExtension(F).ToLower())).ToArray()
            Timer1.Start()
            lyric.Start()
            TextBox1.Text = GetLyricsFromStyleRoot(플레이어.URL)
            For Each Dra In DirFileGet
                ListBox2.Items.Add(Dra)
                musicnamelist.Items.Add(System.IO.Path.GetFileName(Dra))
            Next
            If DirFileGet.Count = 0 Then
                MessageBox.Show("해당 폴더에 사용 가능한 미디어가 없습니다." & Chr(10) & "미디어 파일이 존재하는 폴더를 선택하십시오.", "미디어 없음")
            End If
        End If
        If 플레이어.URL = "" Then
            플레이어.URL = ListBox2.Items(0)
        End If
        For i = 0 To musicnamelist.Items.Count
            name = name & "<" & i & ">" & musicnamelist.Items(i) & "<" & i & ">"
            SaveSetting("Simplemusic", "playlist", folder1.SelectedItem & "name", name) ' 파일이름 저장
            url = url & "<" & i & ">" & ListBox2.Items(i) & "<" & i & ">"
            SaveSetting("Simplemusic", "playlist", folder1.SelectedItem & "url", url) ' 파일경로 저장
            SaveSetting("Simplemusic", "playlist", folder1.SelectedItem & "count", musicnamelist.Items.Count)
        Next
    End Sub
    Private Sub playlist_Click(sender As Object, e As EventArgs) Handles playlist.Click
        On Error Resume Next
        If musicnamelist.Visible = False Then
            musicnamelist.Visible = True
            folder1.Visible = True
            ComboBox1.Visible = True
            delete.Visible = True
            volume.Visible = False
            mute.Visible = False
            Label1.Visible = False
            save.Visible = True
            addplaylist.Visible = True
            Textsearch.Visible = True
            Toggle1.Visible = False
            refreshbt.Visible = False
            If My.Settings.namecount = 0 Then
                Dim line, name
                line = GetSetting("Simplemusic", "setting", "list4 count", "")
                name = GetSetting("Simplemusic", "setting", "list4 item", "")
                For i As Integer = 0 To line
                    folder1.Items.Add(Split(Split(name, "<" & i & ">")(1), "<" & i & ">")(0))
                Next
                My.Settings.namecount = 1
            End If
        Else
            musicnamelist.Visible = False
            delete.Visible = False
            searchmusic.Visible = False
            addplaylist.Visible = False
            volume.Visible = True
            save.Visible = False
            ComboBox1.Visible = False
            folder1.Visible = False
            Label1.Visible = True
            Textsearch.Visible = False
            Toggle1.Visible = True
            mute.Visible = True
            refreshbt.Visible = True
            TextBox1.Text = GetLyricsFromStyleRoot(플레이어.URL)
        End If
    End Sub
    Private Sub rightbt1_Click(sender As Object, e As EventArgs) Handles rightbt1.Click
        On Error Resume Next
        Timer1.Start()
        lyric.Start()
        If My.Settings.name1 = musicnamelist.Items.Count - 1 Then
            My.Settings.name1 = 0
            플레이어.URL = ListBox2.Items(My.Settings.name1)
            Media = TagLib.File.Create(ListBox2.Items(My.Settings.name1))
        Else
            My.Settings.name1 = My.Settings.name1 + 1
            플레이어.URL = ListBox2.Items(My.Settings.name1)
            Media = TagLib.File.Create(ListBox2.Items(My.Settings.name1))
            Form2.sync.Text = ""
        End If
        TextBox1.Text = GetLyricsFromStyleRoot(플레이어.URL)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        On Error Resume Next
        플레이어재생시간.Text = 플레이어.Ctlcontrols.currentPositionString
        플레이어끝시간.Text = 플레이어.currentMedia.durationString
        playtime.Value = 플레이어.Ctlcontrols.currentPosition
        If 플레이어.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            play.Visible = False
            pause.Visible = True
        Else
            play.Visible = True
            pause.Visible = False
        End If

        Dim text1, text2 As String
        Dim iNum1, iNum2 As Integer       '변수의 정수형 선언
        Dim sResult2 As Double
        text1 = Int(Mid(플레이어끝시간.Text, 1, 2)) '분단위
        text1 = text1 * 60 '분을 초로전환
        text2 = Int(Mid(플레이어끝시간.Text, 4, 5))  '초단위
        iNum1 = text1    '텍스트 박스의 내용을 변수에 옮긴다
        iNum2 = text2
        sResult2 = iNum1 + iNum2   '두 변수를 더한다, 플레이어끝시간 초 로만들기 끝
        playtime.MaxValue = sResult2
        플레이어.settings.volume = 음량조절.Value '의 음량을 음량조절의 Value 로 설정
        Media = TagLib.File.Create(플레이어.URL)
        Dim musicname1
        If Not Media.Tag.Title = "" Then
            musicname.Text = Media.Tag.Title
        Else
            musicname.Text = Split(Split(플레이어.URL, "\")(UBound(Split(플레이어.URL, "\"))), ".mp3")(0)
        End If
        If Not Media.Tag.FirstArtist = "" Then
            artistname.Text = Media.Tag.FirstArtist
        Else
            artistname.Text = "정보없음"
        End If
        Dim file As TagLib.File = TagLib.File.Create(플레이어.URL)  '음반 파일경로
        If file.Tag.Pictures.Length >= 1 Then  '유무확인
            Dim bin As Byte() = DirectCast(file.Tag.Pictures(0).Data.Data, Byte())
            albumart.Image = System.Drawing.Image.FromStream(New MemoryStream(bin)).GetThumbnailImage(128, 128, Nothing, System.IntPtr.Zero)  '숫자 =픽셀
        Else
            albumart.Image = music.My.Resources.Resources._1423420162_folder_cd
        End If
    End Sub
    Private Sub play_Click(sender As Object, e As EventArgs) Handles play.Click
        If 플레이어.URL = "" Then
            MsgBox("재생할 곡을 선택하세요.")
            play.Visible = True
            pause.Visible = False
        Else
            플레이어.Ctlcontrols.play()
            Timer1.Start()
            lyric.Start()
            play.Visible = False
            pause.Visible = True
        End If
    End Sub
    Private Sub leftbt1_Click(sender As Object, e As EventArgs) Handles leftbt1.Click
        On Error Resume Next
        If My.Settings.name1 = 0 Then
            My.Settings.name1 = ListBox2.Items.Count - 1
            플레이어.URL = ListBox2.Items(My.Settings.name1)
        Else
            플레이어.URL = ListBox2.Items(My.Settings.name1)
            My.Settings.name1 = My.Settings.name1 - 1
        End If
        Form2.sync.Text = ""
        TextBox1.Text = GetLyricsFromStyleRoot(플레이어.URL)
    End Sub
    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        On Error Resume Next
        Dim Index As Integer = ComboBox1.SelectedIndex
        Select Case Index
            Case 0
                플레이어.URL = ListBox2.Items(musicnamelist.SelectedIndex + 1)
                ListBox2.Items.RemoveAt(musicnamelist.SelectedIndex)
                musicnamelist.Items.RemoveAt(musicnamelist.SelectedIndex)
                TextBox1.Text = GetLyricsFromStyleRoot(플레이어.URL)
                Dim name, url
                For i = 0 To musicnamelist.Items.Count
                    name = name & "<" & i & ">" & musicnamelist.Items(i) & "<" & i & ">"
                    SaveSetting("Simplemusic", "playlist", folder1.SelectedItem & "name", name) ' 파일이름 저장
                    url = url & "<" & i & ">" & ListBox2.Items(i) & "<" & i & ">"
                    SaveSetting("Simplemusic", "playlist", folder1.SelectedItem & "url", url) ' 파일경로 저장
                    SaveSetting("Simplemusic", "playlist", folder1.SelectedItem & "count", musicnamelist.Items.Count)
                Next
            Case 1
                Dim list1
                DeleteSetting("Simplemusic", "playlist", folder1.SelectedItem & "name")
                DeleteSetting("Simplemusic", "playlist", folder1.SelectedItem & "url")
                DeleteSetting("Simplemusic", "playlist", folder1.SelectedItem & "count")
                folder1.Items.RemoveAt(folder1.SelectedIndex)
                ListBox2.Items.Clear()
                DeleteSetting("Simplemusic", "setting", "list4 item")
                DeleteSetting("Simplemusic", "setting", "list4 Count")
                For i = 0 To folder1.Items.Count   '폴더이름 저장
                    list1 = list1 & "<" & i & ">" & folder1.Items(i) & "<" & i & ">"
                    SaveSetting("Simplemusic", "setting", "list4 item", list1)
                    SaveSetting("Simplemusic", "setting", "list4 Count", folder1.Items.Count)
                Next
            Case 2
                DeleteSetting("Simplemusic", "playlist", folder1.SelectedItem & "name")
                DeleteSetting("Simplemusic", "playlist", folder1.SelectedItem & "url")
                DeleteSetting("Simplemusic", "playlist", folder1.SelectedItem & "count")
                musicnamelist.Items.Clear()
            Case 3
                albumart.Image = music.My.Resources.Resources._1423420162_folder_cd
                Timer1.Stop()
                lyric.Stop()
                Form2.sync.Text = ""
                ListBox2.Items.Clear()
                플레이어.URL = ""
                musicname.Text = "리스트에 음악이 없습니다."
                artistname.Text = ""
                TextBox1.Text = ""
                
                For i = 0 To folder1.Items.Count
                    DeleteSetting("Simplemusic", "playlist", folder1.Items(i) & "name")
                    DeleteSetting("Simplemusic", "playlist", folder1.Items(i) & "url")
                    DeleteSetting("Simplemusic", "playlist", folder1.Items(i) & "count")
                Next
                DeleteSetting("Simplemusic", "setting", "list4 item")
                DeleteSetting("Simplemusic", "setting", "list4 Count")
                folder1.Items.Clear()
                musicnamelist.Items.Clear()
        End Select
        DeleteSetting("Simplemusic", "playlist", "name")
        DeleteSetting("Simplemusic", "playlist", "url")
        DeleteSetting("Simplemusic", "playlist", "count")
    End Sub
    Private Sub lyric_Tick(sender As Object, e As EventArgs) Handles lyric.Tick
        On Error Resume Next
        Dim second, Lyric, Lyric1, Lyric3, milisecond
        Dim Lyric2 As Integer
        Lyric = TextBox1.Text
        If Not Lyric = "GET - NO RESULT" Or Lyric = "GET - QUERY ERROR" Then
            second = "[" & 플레이어.Ctlcontrols.currentPositionString & "." & LSet(Split(Split(플레이어.Ctlcontrols.currentPosition, ".")(1), "")(0), 1)
            Lyric2 = UBound(Split(Lyric, second))
            Select Case Lyric2
                Case 1
                    listbox3.Items.Clear()
                    Lyric1 = Split(Split(Lyric, second)(1), "[")(0)
                    listbox3.Items.Add(Split(Split(Lyric1, "]")(1), "")(0))
                    Form2.sync.Text = listbox3.Items(0)
                Case 2
                    listbox3.Items.Clear()
                    For i = 1 To 2
                        Lyric1 = Split(Split(Lyric, second)(i), "[")(0)
                        listbox3.Items.Add(Split(Split(Lyric1, "]")(1), "")(0))
                        Form2.sync.Text = listbox3.Items(0) & vbNewLine & listbox3.Items(1)
                    Next
                Case 3
                    listbox3.Items.Clear()
                    For i = 1 To 3
                        Lyric1 = Split(Split(Lyric, second)(i), "[")(0)
                        listbox3.Items.Add(Split(Split(Lyric1, "]")(1), "")(0))
                        Form2.sync.Text = listbox3.Items(0) & vbNewLine & listbox3.Items(1) & vbNewLine & listbox3.Items(2)
                    Next
            End Select
        Else
            Form2.sync.Text = "가사가 등록되지 않았습니다!"
        End If
    End Sub
    Private Sub Toggle1_CheckedChanged(sender As Object) Handles Toggle1.CheckedChanged
        If Not My.Settings.lyon = 1 Then
            lyric.Start()
            Form2.Show()
            TextBox1.Text = GetLyricsFromStyleRoot(플레이어.URL)
            My.Settings.lyon = 1
        Else
            lyric.Stop()
            Form2.Close()
            My.Settings.lyon = 0
        End If
    End Sub
    Private Sub addplaylist_MouseMove(sender As Object, e As MouseEventArgs) Handles addplaylist.MouseMove
        addplaylist.Image = music.My.Resources.Resources.image11
    End Sub
    Private Sub addplaylist_MouseLeave(sender As Object, e As EventArgs) Handles addplaylist.MouseLeave
        addplaylist.Image = music.My.Resources.Resources._1427517194_add_list
    End Sub

    Private Sub InfluenceTextBox1_TextChanged(sender As Object, e As EventArgs) Handles Textsearch.TextChanged
        On Error Resume Next
        searchmusic.Items.Clear()
        searchmusic.Visible = True
        For i As Integer = 0 To musicnamelist.Items.Count - 1
            If InStr(musicnamelist.Items(i).ToString, Textsearch.Text) Then
                searchmusic.Items.Add(musicnamelist.Items(i))
            End If
        Next
    End Sub
    Private Sub ListBox5_DoubleClick(sender As Object, e As EventArgs) Handles searchmusic.DoubleClick
        On Error Resume Next
        If Not searchmusic.SelectedItem Is Nothing Then
            musicnamelist.SelectedItem = searchmusic.SelectedItem
            플레이어.URL = ListBox2.Items(musicnamelist.SelectedIndex)
            My.Settings.name1 = musicnamelist.SelectedIndex
            Form2.sync.Text = ""
            TextBox1.Text = GetLyricsFromStyleRoot(플레이어.URL)
            searchmusic.Visible = False
        End If
    End Sub
    Private Sub ListBox1_MouseEnter(sender As Object, e As EventArgs) Handles musicnamelist.MouseEnter
        searchmusic.Visible = False
    End Sub
    Private Sub Textsearch_MouseMove(sender As Object, e As MouseEventArgs) Handles Textsearch.MouseMove
        searchmusic.Visible = True
    End Sub
    Private Sub ListBox4_MouseEnter(sender As Object, e As EventArgs) Handles folder1.MouseEnter
        searchmusic.Visible = False
    End Sub
    Private Sub addplaylist_Click(sender As Object, e As EventArgs) Handles addplaylist.Click
        On Error Resume Next
        Dim list1, list2, url, url2
        If Textsearch.Text = "" Then
            MsgBox("재생목록 이름을 입력하여 주세요.", MsgBoxStyle.Exclamation, "오류")
        Else
            folder1.Items.Add(Textsearch.Text)
            For i = 0 To folder1.Items.Count   '폴더이름 저장
                list1 = list1 & "<" & i & ">" & folder1.Items(i) & "<" & i & ">"
                SaveSetting("Simplemusic", "setting", "list4 item", list1)
                SaveSetting("Simplemusic", "setting", "list4 Count", folder1.Items.Count)
            Next
        End If
        Textsearch.Text = ""
    End Sub

    Private Sub ListBox4_DoubleClick(sender As Object, e As EventArgs) Handles folder1.DoubleClick
        On Error Resume Next
        musicnamelist.Items.Clear()
        ListBox2.Items.Clear()
        Dim name, url
        Dim line As Integer
        
        line = GetSetting("Simplemusic", "playlist", folder1.SelectedItem & "count", "")
        For i = 0 To line
            name = GetSetting("Simplemusic", "playlist", folder1.SelectedItem & "name", "")
            musicnamelist.Items.Add(Split(Split(name, "<" & i & ">")(1), "<" & i & ">")(0))
            url = GetSetting("Simplemusic", "playlist", folder1.SelectedItem & "url", "")
            ListBox2.Items.Add(Split(Split(url, "<" & i & ">")(1), "<" & i & ">")(0))
        Next
    End Sub
    Private Sub musicnamelist_DoubleClick(sender As Object, e As EventArgs) Handles musicnamelist.DoubleClick
        On Error Resume Next
        Timer1.Start()
        lyric.Start()
        플레이어.URL = ListBox2.Items(musicnamelist.SelectedIndex)
        My.Settings.name1 = musicnamelist.SelectedIndex
        Form2.sync.Text = ""
        TextBox1.Text = GetLyricsFromStyleRoot(플레이어.URL)
    End Sub
    Private Sub PictureBox1_MouseLeave_1(sender As Object, e As EventArgs) Handles save.MouseLeave
        save.Image = music.My.Resources.Resources._1427541173_save()
    End Sub
    Private Sub save_MouseMove(sender As Object, e As MouseEventArgs) Handles save.MouseMove
        save.Image = music.My.Resources.Resources.image1_1_3
    End Sub
    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        On Error Resume Next
            Dim name, url
            For i = 0 To musicnamelist.Items.Count
                name = name & "<" & i & ">" & musicnamelist.Items(i) & "<" & i & ">"
                SaveSetting("Simplemusic", "playlist", folder1.SelectedItem & "name", name) ' 파일이름 저장
                url = url & "<" & i & ">" & ListBox2.Items(i) & "<" & i & ">"
                SaveSetting("Simplemusic", "playlist", folder1.SelectedItem & "url", url) ' 파일경로 저장
                SaveSetting("Simplemusic", "playlist", folder1.SelectedItem & "count", musicnamelist.Items.Count)
            Next
    End Sub
    Private Sub time_MouseMove(sender As Object, e As MouseEventArgs) Handles time.MouseMove
        time.Image = music.My.Resources.Resources.image1_1_4
    End Sub
    Private Sub time_MouseLeave(sender As Object, e As EventArgs) Handles time.MouseLeave
        time.Image = music.My.Resources.Resources._1427648552_timer
    End Sub
    Private Sub time_Click(sender As Object, e As EventArgs) Handles time.Click
        Form3.Show()
    End Sub
End Class