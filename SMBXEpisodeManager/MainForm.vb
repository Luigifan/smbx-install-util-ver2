Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization
Imports Ionic.Zip
Imports UpdateVB
Imports Setting.IniFile
Imports System.Net

Public Class MainForm
    Public updater As New UpdateVB.UpdateVB
    Dim xml As New XDocument
    Dim settingsIni As New Setting.IniFile(Environment.CurrentDirectory + "\settings.ini")
    Dim generatedDownloadLink As String = "null"
    Dim generatedTechName As String = "null"
    Dim pixelsServers As Boolean = True


    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim firstRun As String
        firstRun = settingsIni.ReadValue("Settings", "isFirstRun")
        If CheckForInternetConnection() = False Then
            MsgBox("No internet connection! Closing..")
            End
        End If
        Try
            My.Computer.FileSystem.DeleteFile(Environment.CurrentDirectory + "\Update.exe")
            My.Computer.FileSystem.DeleteFile(Environment.CurrentDirectory + "\changelog.rtf")
        Catch ex As Exception
            MsgBox("A problem occured! This is not a major issue however, " + vbNewLine + ex.Message())

        End Try

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
            sw.Close()
            If firstRun = "True" Then
                MsgBox("Hi! I see this is your first run!" & vbNewLine & "Please go to Settings and configure your SMBX directories")
                settingsIni.WriteValue("Settings", "isFirstRun", "False")
                'Label6.Text = My.Application.Info.Version.ToString
            Else
                'Continue Normally
            End If
        End If
        RefreshAllItems()
        CheckForUpdates()
    End Sub
    Private Sub AvailableEpisodes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvailableEpisodes.SelectedIndexChanged
        Button1.Enabled = True
        Dim node As XElement = xml...<episode>.First(Function(n) n.Value = AvailableEpisodes.Text)
        DescriptionTextBox.Text = node.@Description
        AuthorTextBox.Text = node.@Author
        generatedDownloadLink = node.@DownloadLink
        generatedTechName = node.@TechName
        If node.@IconLoc = "null" Then
            IconImage.ImageLocation = "http://rohara.x10.mx/smbxpublisher/appfiles/NOICON.gif"
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
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim oForm As New Settings
        oForm.ShowDialog()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If generatedDownloadLink = "null" Then
            MsgBox("You can't download a seperator!")
        Else

            MsgBox("Episode will be downloaded and saved to " + settingsIni.ReadValue("Settings", "worldlocation"))
            Dim EpisodeFolderName As String = xml...<episode>.ToString
            Dim node As XElement = xml...<episode>.First(Function(n) n.Value = AvailableEpisodes.Text)
            Dim ZipName As String = node.@ZipName
            Dim TechName As String = node.@TechName
            'MsgBox("The following episode will be download: " + ListBox1.SelectedItem() + vbNewLine + "It will be saved to " + My.Settings.worldlocation + vbNewLine + "Proceed?", MsgBoxStyle.YesNo)

            Dim DownloadedFile As String = settingsIni.ReadValue("Settings", "worldlocation") + "\" + ZipName

            'My.Computer.Network.DownloadFile(TextBox3.Text, My.Settings.worldlocation + "\" + ZipName, String.Empty, String.Empty, True, String.Empty, True)
            My.Computer.Network.DownloadFile(generatedDownloadLink, settingsIni.ReadValue("Settings", "worldlocation") + "\downloaded.zip", "", "", True, 30, True, FileIO.UICancelOption.DoNothing)
            Dim ZiptoUnzip As String = settingsIni.ReadValue("Settings", "worldlocation") + "\downloaded.zip"
            If My.Computer.FileSystem.DirectoryExists(EpisodeFolderName) Then
                Dim TargetDir As String = EpisodeFolderName
                Using zip1 As ZipFile = ZipFile.Read(ZiptoUnzip)
                    Dim entry As ZipEntry
                    For Each entry In zip1
                        entry.Extract(EpisodeFolderName, ExtractExistingFileAction.OverwriteSilently)
                    Next
                End Using
                ReloadWorldsDir()
            Else
                My.Computer.FileSystem.CreateDirectory(settingsIni.ReadValue("Settings", "worldlocation") + "\" + TechName)
                Dim TargetDir As String = settingsIni.ReadValue("Settings", "worldlocation") + "\" + TechName
                Using zip1 As ZipFile = ZipFile.Read(ZiptoUnzip)
                    Dim entry As ZipEntry
                    'DEBUG MESSAGES
                    MsgBox("Extracting to " + TargetDir)
                    For Each entry In zip1

                        entry.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently)
                    Next
                    ReloadWorldsDir()
                End Using

            End If
            MsgBox("Episode completed extracting! Enjoy!")
        End If
    End Sub
    Private Sub deleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteButton.Click
        Dim SelectedWorld As String = CStr(InstalledWorlds.SelectedItem.ToString)
        Dim smbxDir As String = settingsIni.ReadValue("settings", "worldlocation")
        'Debugging
        MsgBox("Going to delete " + vbNewLine + smbxDir + "\" + SelectedWorld)
        My.Computer.FileSystem.DeleteDirectory(smbxDir + "\" + SelectedWorld, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
        ReloadWorldsDir()
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim smbxexe As String = settingsIni.ReadValue("Settings", "executableloc")
        If My.Computer.FileSystem.FileExists(smbxexe) = True Then
            Process.Start(smbxexe)
        Else
            MsgBox("Unable to find " + smbxexe + " be sure to check your settings!", MsgBoxStyle.Critical)
        End If


    End Sub
    Private Sub RefreshIndex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshIndex.Click
        If pixelsServers = True Then
            xml = XDocument.Load("http://rohara.x10.mx/smbxpublisher/appfiles/worldIndex.xml")
        ElseIf pixelsServers = False Then
            xml = XDocument.Load("https://dl.dropboxusercontent.com/u/62304851/worldIndex.xml")
        End If

        Dim games() As String = xml...<episode>.Select(Function(n) n.Value).ToArray
        AvailableEpisodes.DataSource = games
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
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim oForm As New Feedback
        oForm.ShowDialog()
    End Sub

    'User generated crap
    '
    '
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
        If pixelsServers = True Then
            xml = XDocument.Load("http://rohara.x10.mx/smbxpublisher/appfiles/worldIndex.xml")
        ElseIf pixelsServers = False Then
            xml = XDocument.Load("https://dl.dropboxusercontent.com/u/62304851/worldIndex.xml")
        End If

        Dim games() As String = xml...<episode>.Select(Function(n) n.Value).ToArray
        AvailableEpisodes.DataSource = games
        ReloadWorldsDir()
        'repoUpdated.Text = "Repo Updated"
    End Sub
    Public Sub CheckForUpdates()
        Dim curver As String = My.Application.Info.Version.ToString

        updater.checkinternet()
        updater.checkversion("http://rohara.x10.mx/smbxpublisher/appfiles/version_smbx_new.txt", curver)
        'updater.checkversion(Environment.CurrentDirectory + "\newestversion.txt", curver)
        If updater.updateavailable = True Then
            My.Computer.Network.DownloadFile("http://rohara.x10.mx/smbxpublisher/appfiles/SMBXUpdater_Latest.exe", Environment.CurrentDirectory + "\Update.exe", "", "", False, "1000", True)
            Dim oForm As New UpdateConfirm
            oForm.Owner = Me
            oForm.ShowDialog()
        Else
            isUpdated.Text = "Up to date: " + curver
        End If

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





    
End Class
