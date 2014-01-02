Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization
Imports Ionic.Zip
Imports UpdateVB
Imports Setting.IniFile

Public Class MainForm
    Public updater As New UpdateVB.UpdateVB
    Dim xml As New XDocument
    Dim settingsIni As New Setting.IniFile(Environment.CurrentDirectory + "\settings.ini")
    Dim generatedDownloadLink As String = "null"
    Dim generatedTechName As String = "null"


    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim firstRun As String
        firstRun = settingsIni.ReadValue("Settings", "isFirstRun")


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
        Dim req As System.Net.WebRequest = System.Net.HttpWebRequest.Create(node.@DownloadLink)
        req.Method = "HEAD"
    End Sub
    Private Sub InstalledWorlds_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstalledWorlds.SelectedIndexChanged
        deleteButton.Enabled = True
        Dim SelectWorld As String = CStr(InstalledWorlds.SelectedItem)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim oForm As New Settings
        oForm.ShowDialog()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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
    End Sub
    Private Sub deleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteButton.Click
        Dim SelectedWorld As String = CStr(InstalledWorlds.SelectedItem)
        My.Computer.FileSystem.DeleteDirectory(SelectedWorld, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
        ReloadWorldsDir()
    End Sub

    
    'User generated crap
    '
    '
    Public Sub ReloadWorldsDir()
        If My.Computer.FileSystem.DirectoryExists(settingsIni.ReadValue("Settings", "worldlocation")) Then
            InstalledWorlds.DataSource = Directory.GetDirectories(settingsIni.ReadValue("Settings", "worldlocation"))
        Else
            MsgBox("Directory not Found!", MsgBoxStyle.Critical)
        End If
    End Sub
    Public Sub RefreshAllItems()
        ReloadWorldsDir()
        xml = XDocument.Load("http://rohara.x10.mx/smbxpublisher/appfiles/worldIndex.xml")
        Dim games() As String = xml...<episode>.Select(Function(n) n.Value).ToArray
        AvailableEpisodes.DataSource = games
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

   
    
End Class
