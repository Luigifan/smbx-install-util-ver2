Imports System.Net
Imports System.IO
Imports IWshRuntimeLibrary
Imports System.Runtime.InteropServices

Public Class Form1
    Public installDir As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\SMBX Episode Manager"
    Public desktopDir As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

    Public smbxDownload As String = "http://rohara.x10.mx/smbxpublisher/appfiles/SMBX.zip"
    Public episodeManagerExe As String = "http://rohara.x10.mx/smbxpublisher/appfiles/SMBXEpisodeManager_Latest.exe"
    Public UpdateVbDll As String = "http://rohara.x10.mx/smbxpublisher/appfiles/UpdateVB.dll"
    Public settingDll As String = "http://rohara.x10.mx/smbxpublisher/appfiles/Setting.dll"
    Public ionicZipDll As String = "http://rohara.x10.mx/smbxpublisher/appfiles/Ionic.Zip.dll"


    <DllImport("user32.dll", EntryPoint:="FlashWindow")> _
    Public Shared Function FlashWindow(ByVal hwnd As Integer, ByVal bInvert As Integer) As Integer
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MsgBox("Are you sure you wish to cancel the installer?", MsgBoxStyle.YesNo, "Cancel?") = MsgBoxResult.Yes Then
            End
        ElseIf MsgBoxResult.No Then
            'cancels
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '470
        Button1.Hide()
        Button2.Hide()
        smbx.Enabled = False
        episodeManager.Enabled = False
        Do Until Me.Height = 400
            Me.Height += 2
        Loop
        If smbx.Checked = True Then
            InstallBoth()
        Else
            installJustEpisodeManager()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Network.DownloadFile("https://dl.dropboxusercontent.com/u/62304851/Interop.Shell32.dll", Environment.CurrentDirectory + "Interop.Shell32.dll")
        My.Computer.Network.DownloadFile("https://dl.dropboxusercontent.com/u/62304851/Interop.IWshRuntimeLibrary.dll", Environment.CurrentDirectory + "Interop.IWshRuntimeLibrary.dll")
        Label3.Text = "Will be installed to: " + installDir
    End Sub
    '
    '
    '

    Public Sub installJustEpisodeManager()
        TextBox1.AppendText("Checking for an internet connection..." + vbNewLine)
        If CheckForInternetConnection() = True Then
            TextBox1.AppendText("Checking if directory exists..." + vbNewLine)
            If My.Computer.FileSystem.FileExists(installDir) Then
                'proceed normally
                TextBox1.AppendText("Exists" + vbNewLine)
            Else
                TextBox1.AppendText("Doesn't exist! Generating: " + installDir + vbNewLine)
                My.Computer.FileSystem.CreateDirectory(installDir)
            End If
            TextBox1.AppendText("Downloading " + episodeManagerExe + "to " + installDir + "\SMBXEpisodeManager.exe" + vbNewLine)
            My.Computer.Network.DownloadFile(episodeManagerExe, installDir + "\SMBXEpisodeManager.exe", vbNull, vbNull, True, vbNull, True, FileIO.UICancelOption.DoNothing)
            '
            TextBox1.AppendText("Downloading " + UpdateVbDll + "to " + installDir + "\UpdateVB.dll" + vbNewLine)
            My.Computer.Network.DownloadFile(UpdateVbDll, installDir + "\UpdateVB.dll", vbNull, vbNull, True, vbNull, True, FileIO.UICancelOption.DoNothing)
            '
            TextBox1.AppendText("Downloading " + settingDll + "to " + installDir + "\Setting.dll" + vbNewLine)
            My.Computer.Network.DownloadFile(settingDll, installDir + "\Setting.dll", vbNull, vbNull, True, vbNull, True, FileIO.UICancelOption.DoNothing)
            '
            TextBox1.AppendText("Downloading " + ionicZipDll + "to " + installDir + "\Ionic.Zip.dll" + vbNewLine)
            My.Computer.Network.DownloadFile(ionicZipDll, installDir + "\Ionic.Zip.dll", vbNull, vbNull, True, vbNull, True, FileIO.UICancelOption.DoNothing)
            '
            TextBox1.AppendText("Generating desktop shortcut..." + vbNewLine)
            CreateShortCut()
            TextBox1.AppendText("Desktop Shortcut Created!" + vbNewLine)
            TextBox1.AppendText("Generating Default INI File..." + vbNewLine)

            With Timer1
                .Interval = 300
                .Enabled = True
                .Start()
            End With
            My.Computer.FileSystem.DeleteFile(Environment.CurrentDirectory + "Interop.Shell32.dll")
            My.Computer.FileSystem.DeleteFile(Environment.CurrentDirectory + "Interop.IWshRuntimeLibrary.dll")
            MsgBox("Setup complete!" + vbNewLine + "Installed to: " + installDir)
            End
        Else
            MsgBox("Setup could not connect to our servers! Blame Pixel!" + vbNewLine + "Please re-run setup with a valid connection")
            End
        End If
    End Sub

    Public Sub InstallBoth()
        TextBox1.AppendText("Checking for an internet connection..." + vbNewLine)
        If CheckForInternetConnection() = True Then
            TextBox1.AppendText("Checking if directory exists..." + vbNewLine)
            If My.Computer.FileSystem.FileExists(installDir) Then
                'proceed normally
                TextBox1.AppendText("Exists" + vbNewLine)
            Else
                TextBox1.AppendText("Doesn't exist! Generating: " + installDir + vbNewLine)
                My.Computer.FileSystem.CreateDirectory(installDir)
            End If
            TextBox1.AppendText("Downloading " + episodeManagerExe + "to " + installDir + "\SMBXEpisodeManager.exe" + vbNewLine)
            My.Computer.Network.DownloadFile(episodeManagerExe, installDir + "\SMBXEpisodeManager.exe", vbNull, vbNull, True, vbNull, True, FileIO.UICancelOption.DoNothing)
            '
            TextBox1.AppendText("Downloading " + UpdateVbDll + "to " + installDir + "\UpdateVB.dll" + vbNewLine)
            My.Computer.Network.DownloadFile(UpdateVbDll, installDir + "\UpdateVB.dll", vbNull, vbNull, True, vbNull, True, FileIO.UICancelOption.DoNothing)
            '
            TextBox1.AppendText("Downloading " + settingDll + "to " + installDir + "\Setting.dll" + vbNewLine)
            My.Computer.Network.DownloadFile(settingDll, installDir + "\Setting.dll", vbNull, vbNull, True, vbNull, True, FileIO.UICancelOption.DoNothing)
            '
            TextBox1.AppendText("Downloading " + ionicZipDll + "to " + installDir + "\Ionic.Zip.dll" + vbNewLine)
            My.Computer.Network.DownloadFile(ionicZipDll, installDir + "\Ionic.Zip.dll", vbNull, vbNull, True, vbNull, True, FileIO.UICancelOption.DoNothing)
            '
            TextBox1.AppendText("Downloading " + smbxDownload + "to " + installDir + "\smbx.zip" + vbNewLine)
            'My.Computer.Network.DownloadFile(smbxDownload, installDir + "\smbx.zip", vbNull, vbNull, True, vbNull, True, FileIO.UICancelOption.DoNothing)
            '
            TextBox1.AppendText("Extracting..." + vbNewLine)
            Dim vbUnzip As New vbUnzip()
            extractProgressBar.Visible = True
            vbUnzip.UnZip()
            '
            TextBox1.AppendText("Done extracting!" + vbNewLine)
            '
            TextBox1.AppendText("Generating desktop shortcut..." + vbNewLine)
            CreateShortCut()
            TextBox1.AppendText("Desktop Shortcut Created!" + vbNewLine)
            TextBox1.AppendText("Generating Default INI File..." + vbNewLine)

            With Timer1
                .Interval = 300
                .Enabled = True
                .Start()
            End With
            MsgBox("Setup complete!" + vbNewLine + "Installed to: " + installDir)
            End
        Else
            MsgBox("Setup could not connect to our servers! Blame Pixel!" + vbNewLine + "Please re-run setup with a valid connection")
            End
        End If
    End Sub

    Public Shared Function CheckForInternetConnection() As Boolean
        Try
            Using client = New WebClient()
                Using stream = client.OpenRead("http://rohara.x10.mx/")
                    Return True
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

    Public Sub CreateShortCut()

        Try
            Dim wshShell As New WshShell
            Dim shortcut As IWshRuntimeLibrary.IWshShortcut = DirectCast(wshShell.CreateShortcut(desktopDir + "SMBX Episode Manager.lnk"), IWshRuntimeLibrary.IWshShortcut)
            With shortcut
                .TargetPath = installDir + "\SMBXEpisodeManager.exe"
                .WindowStyle = 1I
                .Description = "Episode Manager"
                .WorkingDirectory = installDir
                .IconLocation = installDir + "\SMBXEpisodeManager.exe" & ", 0"
                .Arguments = String.Empty
                .Save()


            End With
        Catch ex As System.Exception
            MsgBox("Error! Failed to create shortcut at " + desktopDir + vbNewLine + ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        FlashWindow(Me.Handle, 1)
    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        FlashWindow(Me.Handle, 1)
    End Sub
End Class
