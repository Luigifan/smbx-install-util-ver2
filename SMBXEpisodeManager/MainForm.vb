﻿Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization
Imports Ionic.Zip
Imports Setting.IniFile
Imports System.Net
Imports System.Reflection
Imports System.Drawing.Text

Public Class MainForm
    Dim NewUpdate As New UpdatingClass
    Dim CheckSMBXVer As New SMBXVersionManaging


    Dim xml As New XDocument

    Dim settingsIni As New Setting.IniFile(Environment.CurrentDirectory + "\settings.ini")
    Dim generatedDownloadLink As String = "null"
    Dim generatedTechName As String = "null"
    Dim pixelsServers As Boolean = False
    Dim customFont As PrivateFontCollection = New PrivateFontCollection

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            ' Turn on WS_EX_COMPOSITED
            Return cp
        End Get
    End Property
    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetDoubleBuffered(Me)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)

        Control.CheckForIllegalCrossThreadCalls = False
        Dim firstRun As String
        firstRun = settingsIni.ReadValue("Settings", "isFirstRun")
        If CheckForInternetConnection() = False Then
            MsgBox("No internet connection! Closing..")
            End
        End If
        If My.Computer.FileSystem.FileExists(Environment.CurrentDirectory + "\Update.exe") Then
            Try
                My.Computer.FileSystem.DeleteFile(Environment.CurrentDirectory + "\Update.exe")

            Catch ex As Exception
                MsgBox("A problem occured! This is not a major issue however, " + vbNewLine + ex.Message())
            End Try
        End If

        If My.Computer.FileSystem.FileExists(Environment.CurrentDirectory + "\changelog.rtf") Then
            Try

                My.Computer.FileSystem.DeleteFile(Environment.CurrentDirectory + "\changelog.rtf")
            Catch ex As Exception
                MsgBox("A problem occured! This is not a major issue however, " + vbNewLine + ex.Message())
            End Try
        End If




        If My.Computer.FileSystem.FileExists(Environment.CurrentDirectory + "\settings.ini") Then
            If firstRun = "True" Then
                MsgBox("Hi! I see this is your first run!" & vbNewLine & "Please go to Settings and configure your SMBX directories")
                settingsIni.WriteValue("Settings", "isFirstRun", "False")
                'Label6.Text = My.Application.Info.Version.ToString
            Else
                'Label6.Text = My.Application.Info.Version.ToString
            End If
        Else
            Dim sw As New System.IO.StreamWriter(Environment.CurrentDirectory + "\settings.ini")
            sw.WriteLine("[Settings]")
            sw.WriteLine("isFirstRun=True")
            sw.WriteLine("smbxpath=C:\SMBX")
            sw.WriteLine("worldlocation=C:\SMBX\worlds")
            sw.WriteLine("executableloc=C:\SMBX\smbx.exe")
            sw.WriteLine("dlServers=pixels")
            sw.WriteLine("Theme=smb")
            sw.Close()
            If firstRun = "True" Then
                MsgBox("Hi! I see this is your first run!" & vbNewLine & "Please go to Settings and configure your SMBX directories")
                settingsIni.WriteValue("Settings", "isFirstRun", "False")
                'Label6.Text = My.Application.Info.Version.ToString
            Else
                'Continue Normally
            End If
        End If
        Dim smbxexe As String = settingsIni.ReadValue("Settings", "executableloc")


        If My.Computer.FileSystem.FileExists(smbxexe) Then
            CheckSMBXVer.CheckSMBXVersion()
            SmbxUpdates()
            RefreshAllItems()
            CheckForUpdates()
        Else
            RefreshAllItems()
            CheckForUpdates()
        End If
        CheckTheme()
    End Sub
    Private Sub AvailableEpisodes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvailableEpisodes.SelectedIndexChanged
        Button1.Enabled = True
        Dim node As XElement = xml...<episode>.First(Function(n) n.Value = AvailableEpisodes.Text)
        DescriptionTextBox.Text = node.@Description
        AuthorTextBox.Text = node.@Author
        generatedDownloadLink = node.@DownloadLink
        generatedTechName = node.@TechName
        If node.@IconLoc = "null" Then
            IconImage.ImageLocation = "http://mrmiketheripper.x10.mx/epmanager/noicon.gif"
        Else
            IconImage.ImageLocation = node.@IconLoc
        End If
        IconImage.Visible = True
        Dim ZipName As String = node.@ZipName
        If node.@DownloadLink = "null" Then
        Else
            Dim req As System.Net.WebRequest = System.Net.HttpWebRequest.Create(node.@DownloadLink)
            req.Method = "HEAD"
        End If

    End Sub
    Private Sub InstalledWorlds_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstalledWorlds.SelectedIndexChanged
        deleteButton.Enabled = True
        Dim SelectWorld As String = CStr(InstalledWorlds.SelectedItem.ToString)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If generatedDownloadLink = "null" Then
            MsgBox("You can't download a seperator!")
        Else
            MsgBox("Episode will be downloaded and saved to " + settingsIni.ReadValue("Settings", "worldlocation"))

            My.Computer.Network.DownloadFile(generatedDownloadLink, settingsIni.ReadValue("Settings", "worldlocation") + "\downloaded.zip", "", "", True, 30, True, FileIO.UICancelOption.DoNothing)

            Button1.Enabled = False
            RefreshIndex.Enabled = False
            RefreshWorlds.Enabled = False
            deleteButton.Enabled = False
            launchSMBXButton.Enabled = False
            feedbackButton.Enabled = False
            settingsToolStrip.Enabled = False
            ToolStripProgressBar1.Visible = True
            isExtract.Visible = True
            BackgroundWorker1.RunWorkerAsync()






        End If

    End Sub
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim UnzipWorld As New UnzipWorld
        Dim node As XElement = xml...<episode>.First(Function(n) n.Value = AvailableEpisodes.Text)
        Dim TechName As String = node.@TechName
        Dim worldsDir As String = settingsIni.ReadValue("Settings", "worldlocation") + "\"
        Dim ZiptoUnzip As String = settingsIni.ReadValue("Settings", "worldlocation") + "\downloaded.zip"
        Try
            UnzipWorld.unzipWorldK(TechName, generatedDownloadLink, ZiptoUnzip, worldsDir)
            UnzipProgress.Dispose()
        Catch ex As Exception
            Console.WriteLine("Error! Message: " + ex.Message())
        End Try
    End Sub
    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Dim doneWorking As Boolean = True

        MsgBox("Finished! Enjoy!")

        Button1.Enabled = True
        RefreshIndex.Enabled = True
        RefreshWorlds.Enabled = True
        deleteButton.Enabled = True
        launchSMBXButton.Enabled = True
        feedbackButton.Enabled = True
        settingsToolStrip.Enabled = True
        ToolStripProgressBar1.Visible = False
        isExtract.Visible = False

        ReloadWorldsDir()


    End Sub
    Private Sub deleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteButton.Click
        Dim SelectedWorld As String = CStr(InstalledWorlds.SelectedItem.ToString)
        Dim smbxDir As String = settingsIni.ReadValue("settings", "worldlocation")
        'Debugging
        'MsgBox("Going to delete " + vbNewLine + smbxDir + "\" + SelectedWorld)
        My.Computer.FileSystem.DeleteDirectory(smbxDir + "\" + SelectedWorld, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
        ReloadWorldsDir()
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles launchSMBXButton.Click
        Dim smbxexe As String = settingsIni.ReadValue("Settings", "executableloc")
        If My.Computer.FileSystem.FileExists(smbxexe) = True Then
            Process.Start(smbxexe)
        Else
            MsgBox("Unable to find " + smbxexe + " be sure to check your settings!", MsgBoxStyle.Critical)
        End If


    End Sub
    Private Sub RefreshIndex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshIndex.Click
        If pixelsServers = True Then
            xml = XDocument.Load("https://dl.dropboxusercontent.com/u/62304851/worldIndex.xml")
        ElseIf pixelsServers = False Then
            xml = XDocument.Load("https://dl.dropboxusercontent.com/u/62304851/worldIndex.xml")
        End If
        Dim index As String = settingsIni.ReadValue("Settings", "dlServers")
        If index = "mike" Then
            xml = XDocument.Load("https://dl.dropboxusercontent.com/u/62304851/worldIndex.xml")
        Else
            Try
                xml = XDocument.Load(index)
            Catch ex As Exception
                MsgBox("There was in error in reading the custom XML!" + vbNewLine + ex.Message)
            End Try
        End If
        Dim games() As String = xml...<episode>.Select(Function(n) n.Value).ToArray
        AvailableEpisodes.DataSource = games
        AvailableEpisodes.SelectedIndex = AvailableEpisodes.SelectedIndex + 1
    End Sub
    Private Sub RefreshWorlds_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshWorlds.Click
        If My.Computer.FileSystem.DirectoryExists(settingsIni.ReadValue("Settings", "worldlocation")) Then
            Dim di As New DirectoryInfo(settingsIni.ReadValue("Settings", "worldlocation"))
            Dim subdi As DirectoryInfo() = di.GetDirectories()
            InstalledWorlds.DataSource = subdi.ToList

        Else
            MsgBox("Directory not Found!", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles feedbackButton.Click
        Dim oForm As New Feedback
        oForm.ShowDialog()
    End Sub
    Private Sub settingsToolStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles settingsToolStrip.Click
        Dim oForm As New Settings
        oForm.ShowDialog()
    End Sub






    'User generated crap
    '
    '
    Public Shared Sub SetDoubleBuffered(ByVal c As System.Windows.Forms.Control)
        'Taxes: Remote Desktop Connection and painting
        'http://blogs.msdn.com/oldnewthing/archive/2006/01/03/508694.aspx
        If System.Windows.Forms.SystemInformation.TerminalServerSession Then
            Return
        End If

        Dim aProp As System.Reflection.PropertyInfo = GetType(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Instance)

        aProp.SetValue(c, True, Nothing)
    End Sub
    Public Sub CompileSMBXVersions()
        'ListView1.BeginUpdate()
        'Dim li As ListViewItem
        'li = ListView1.Items.Add("SMBX 1.0.0")
        'li.SubItems.Add("")
    End Sub
    Public Sub CheckTheme()
        Try
            If settingsIni.ReadValue("Settings", "Theme") = "smb" Then
                'BackgrondSecondary
                episodeTab.BackgroundImage = My.Resources.Background_Main_Full
                smbxVersionsTab.BackgroundImage = My.Resources.Backgrond_Secondary
                curSMBXLabel.ForeColor = Color.White
                Label100.ForeColor = Color.White
                Label121.ForeColor = Color.White
                Label1301.ForeColor = Color.White
                Label59.ForeColor = Color.White
                'Adds the customFont and downloads if necessary
                customFont.AddFontFile(returnFont())
                'Change font theme
                AvailableLabel.Font = New Font(customFont.Families(0), 8)
                InstalledLabel.Font = New Font(customFont.Families(0), 8)
                DescriptionLabel.Font = New Font(customFont.Families(0), 5)
                DescriptionLabel.Location = New Point(6, 401)
                AuthorLabel.Font = New Font(customFont.Families(0), 5)
                AuthorLabel.Location = New Point(22, 464)

            ElseIf settingsIni.ReadValue("Settings", "Theme") = "windows" Then
                episodeTab.BackgroundImage = Nothing
                smbxVersionsTab.BackgroundImage = Nothing
                curSMBXLabel.ForeColor = Color.Black
                Label100.ForeColor = Color.Black
                Label121.ForeColor = Color.Black
                Label1301.ForeColor = Color.Black
                Label59.ForeColor = Color.Black
                'Author: 41, 13
                'Desc: 22, 401
                AvailableLabel.Font = Control.DefaultFont
                InstalledLabel.Font = Control.DefaultFont
                DescriptionLabel.Font = Control.DefaultFont
                AuthorLabel.Font = Control.DefaultFont
                AuthorLabel.Location = New Point(44, 464)
                DescriptionLabel.Font = Control.DefaultFont
                DescriptionLabel.Location = New Point(22, 401)


            ElseIf settingsIni.ReadValue("Settings", "Theme") = vbNull Then
                settingsIni.WriteValue("Settings", "Theme", "smb")
                CheckTheme()
            End If
        Catch ex As Exception
            Console.WriteLine("ERROR: " + ex.Message)

        End Try
    End Sub

    Public Sub ReloadWorldsDir()
        If My.Computer.FileSystem.DirectoryExists(settingsIni.ReadValue("Settings", "worldlocation")) Then
            Dim di As New DirectoryInfo(settingsIni.ReadValue("Settings", "worldlocation"))
            Dim subdi As DirectoryInfo() = di.GetDirectories()
            InstalledWorlds.DataSource = subdi.ToList

        Else
            MsgBox("Directory not Found!", MsgBoxStyle.Critical)
        End If
    End Sub
    Public Sub RefreshAllItems()
        Dim smbxexe As String = settingsIni.ReadValue("Settings", "executableloc")
        'Dim smbxver As String = GetFileVersionInfo(smbxexe).ToString

        If pixelsServers = True Then
            xml = XDocument.Load("https://dl.dropboxusercontent.com/u/62304851/worldIndex.xml")
        ElseIf pixelsServers = False Then
            xml = XDocument.Load("https://dl.dropboxusercontent.com/u/62304851/worldIndex.xml")
        End If
        Try
            Dim games() As String = xml...<episode>.Select(Function(n) n.Value).ToArray
            AvailableEpisodes.DataSource = games
            ReloadWorldsDir()
        Catch ex As Exception
            Console.WriteLine("CRITICAL STARTUP ERROR: " + ex.Message)

        End Try

        AvailableEpisodes.SelectedIndex = AvailableEpisodes.SelectedIndex + 1






        'repoUpdated.Text = "Repo Updated"

    End Sub
    Private Function GetFileVersionInfo(ByVal filename As String) As Version
        Return Version.Parse(FileVersionInfo.GetVersionInfo(filename).FileVersion)
    End Function
    Public Sub SmbxUpdates()
        Dim smbxexe As String = settingsIni.ReadValue("Settings", "executableloc")
        Dim smbxver As String = GetFileVersionInfo(smbxexe).ToString

        If smbxver = "1.2.2" Then
            curSMBXLabel.Text = "Current Installed SMBX Version: Beta 59"
        Else
            curSMBXLabel.Text = "Current Installed SMBX Version: " + smbxver
        End If





        'If My.Computer.FileSystem.FileExists(smbxexe) Then
        ' If smbxver = "1.3" Then
        ' Dim oForm As New UpdatingSmbx
        ' oForm.ShowDialog()
        ' ToolStripLabel1.Visible = True
        ' End If
        ' ElseIf smbxver = "1.3.0.1" Then
        'proceed normally

        ' End If
    End Sub
    Public Sub CheckForUpdates()
        Dim curver As String = My.Application.Info.Version.ToString
        If UpdatingClass.CheckforInternetConnection = True Then
            If UpdatingClass.CheckVersion("http://mrmiketheripper.x10.mx/epmanager/version.txt", curver) = True Then
                My.Computer.Network.DownloadFile("http://mrmiketheripper.x10.mx/epmanager/SMBXUpdater_Latest.exe", Environment.CurrentDirectory + "\Update.exe", "", "", False, "1000", True)
                Dim oForm As New UpdateConfirm
                oForm.Owner = Me
                oForm.ShowDialog()
            Else
                isUpdated.Text = "Up to date: " + curver
            End If
        ElseIf UpdatingClass.CheckforInternetConnection = False Then
            MsgBox("Cannot update! No internet connection!")
        End If




        '
        ' Old Update method; for reference only, uses UpdateVB.dll
        'updater.checkinternet()
        'updater.checkversion("http://rohara.x10.mx/smbxpublisher/appfiles/version_smbx_new.txt", curver)
        'updater.checkversion(Environment.CurrentDirectory + "\newestversion.txt", curver)
        'If updater.updateavailable = True Then
        'My.Computer.Network.DownloadFile("http://rohara.x10.mx/smbxpublisher/appfiles/SMBXUpdater_Latest.exe", Environment.CurrentDirectory + "\Update.exe", "", "", False, "1000", True)
        'Dim oForm As New UpdateConfirm
        'oForm.Owner = Me
        'oForm.ShowDialog()
        'Else
        'isUpdated.Text = "Up to date: " + curver
        'End If

    End Sub

    Public Shared Function CheckForInternetConnection() As Boolean
        Try
            Using client = New WebClient()
                Using stream = client.OpenRead("http://google.com")
                    Return True
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function
    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click
        Dim oForm As New UpdatingSmbx
        oForm.ShowDialog()
    End Sub

    Private Sub smbx1301button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles smbx1301button.Click
        CheckSMBXVer.InstallAnSMBX("1.3.0.1")

    End Sub

    Private Sub smbx121button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles smbx121button.Click
        CheckSMBXVer.InstallAnSMBX("1.2.0.1")
    End Sub

    Private Sub smbx59button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles smbx59button.Click
        CheckSMBXVer.InstallAnSMBX("59")
    End Sub

    Private Sub smbx1button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles smbx1button.Click
        CheckSMBXVer.InstallAnSMBX("1.0.0.0")
    End Sub

    Private Sub LaunchMainGameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaunchMainGameToolStripMenuItem.Click, launchSMBXSplit.ButtonClick
        Dim smbxexe As String = settingsIni.ReadValue("Settings", "executableloc")
        Process.Start(smbxexe)
    End Sub

    Private Sub LaunchEditorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaunchEditorToolStripMenuItem.Click
        Dim smbxloc As String = settingsIni.ReadValue("Settings", "smbxpath")
        Dim smbxeditor As String = "\smbx1editor.exe"

        Process.Start(smbxloc + smbxeditor)
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim oForm As New XMLMain
        oForm.ShowDialog()

    End Sub

    Private Sub curSMBXLabel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles curSMBXLabel.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim assemblyRes As String() = [Assembly].GetExecutingAssembly().GetManifestResourceNames
        For Each asdf As String In assemblyRes
            MsgBox(asdf)
        Next
    End Sub

    Public Function returnFont()
        If File.Exists(Environment.CurrentDirectory + "\font.ttf".ToString()) = True Then
            Return Environment.CurrentDirectory + "\font.ttf
        Else
            My.Computer.Network.DownloadFile("https://dl.dropboxusercontent.com/u/62304851/emulogic.ttf", Environment.CurrentDirectory + "\font.ttf", vbNull, vbNull, False, 100000000, True)
            Return Environment.CurrentDirectory + "\font.ttf"
        End If

    End Function
End Class
