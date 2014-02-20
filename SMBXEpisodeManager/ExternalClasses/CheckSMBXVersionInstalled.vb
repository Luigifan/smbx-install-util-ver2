Imports Setting.IniFile

Public Class SMBXVersionManaging
    Dim settingsIni As New Setting.IniFile(Environment.CurrentDirectory + "\settings.ini")
    Public Sub CheckSMBXVersion()
        Dim smbxexe As String = settingsIni.ReadValue("Settings", "executableloc")


        If My.Computer.FileSystem.FileExists(smbxexe) Then
            Dim smbxver As String = GetFileVersionInfo(smbxexe).ToString

            If smbxver = "1.3.0.1" Then
                MainForm.launchSMBXSplit.Visible = False
                MainForm.launchSMBXButton.Visible = True

                MainForm.smbx1301button.Enabled = False
                MainForm.smbx59button.Enabled = True
                MainForm.smbx121button.Enabled = True
                MainForm.smbx1button.Enabled = True

                MainForm.smbx1301button.Text = "Installed"
                MainForm.smbx59button.Text = "Install"
                MainForm.smbx121button.Text = "Install"
                MainForm.smbx1button.Text = "Install"
            ElseIf smbxver = "1.2.1" Then
                MainForm.launchSMBXSplit.Visible = False
                MainForm.launchSMBXButton.Visible = True

                MainForm.smbx1301button.Enabled = True
                MainForm.smbx59button.Enabled = True
                MainForm.smbx121button.Enabled = False
                MainForm.smbx1button.Enabled = True

                MainForm.smbx1301button.Text = "Install"
                MainForm.smbx59button.Text = "Install"
                MainForm.smbx121button.Text = "Installed"
                MainForm.smbx1button.Text = "Install"
            ElseIf smbxver = "1.2.2" Then
                'Remember, 1.2.0.2 was the codename for beta 59
                MainForm.launchSMBXSplit.Visible = False
                MainForm.launchSMBXButton.Visible = True

                MainForm.smbx1301button.Enabled = True
                MainForm.smbx59button.Enabled = False
                MainForm.smbx121button.Enabled = True
                MainForm.smbx1button.Enabled = True

                MainForm.smbx1301button.Text = "Install"
                MainForm.smbx59button.Text = "Installed"
                MainForm.smbx121button.Text = "Install"
                MainForm.smbx1button.Text = "Install"
            ElseIf smbxver = "1.0" Then
                MainForm.launchSMBXSplit.Visible = True
                MainForm.launchSMBXButton.Visible = False


                MainForm.smbx1301button.Enabled = True
                MainForm.smbx59button.Enabled = True
                MainForm.smbx121button.Enabled = True
                MainForm.smbx1button.Enabled = False

                MainForm.smbx1301button.Text = "Install"
                MainForm.smbx59button.Text = "Install"
                MainForm.smbx121button.Text = "Install"
                MainForm.smbx1button.Text = "Installed"
            End If
            MainForm.launchSMBXButton.ToolTipText = "Launch SMBX " + smbxver
        Else
            Console.WriteLine("No SMBX Versions in index are installed")
            Throw New Exception("No SMBX Versions in index are installed")

        End If
    End Sub

    Public Sub InstallAnSMBX(ByVal ver As String)
        Dim smbxexe As String = settingsIni.ReadValue("Settings", "executableloc")
        Dim smbxpath As String = settingsIni.ReadValue("Settings", "smbxpath")
        Dim smbx131 As String = "https://dl.dropboxusercontent.com/u/62304851/smbx131.exe"
        Dim smbx121 As String = "https://dl.dropboxusercontent.com/u/62304851/smbx121.exe"
        Dim smbx59 As String = "https://dl.dropboxusercontent.com/u/62304851/smbx59.exe"
        Dim smbx1main As String = "https://dl.dropboxusercontent.com/u/62304851/smbx1maingame.exe"
        Dim smbx1edit As String = "https://dl.dropboxusercontent.com/u/62304851/smbx1editor.exe"


        Try
            Try
                My.Computer.FileSystem.DeleteFile(smbxpath + "\smbx_backup.exe")
            Catch ex As Exception
                Console.WriteLine("No backup to remove")
            End Try
            My.Computer.FileSystem.CopyFile(smbxexe, smbxpath + "\smbx_backup.exe")
        Catch ex As Exception
            MsgBox("An error occurred!" + vbNewLine + vbNewLine + "Details: " + ex.Message)

        End Try

        If ver = "1.3.0.1" Then
            My.Computer.Network.DownloadFile(smbx131, smbxexe, vbNull, vbNull, True, 10000, True, FileIO.UICancelOption.DoNothing)
        ElseIf ver = "1.2.0.1" Then
            My.Computer.Network.DownloadFile(smbx121, smbxexe, vbNull, vbNull, True, 10000, True, FileIO.UICancelOption.DoNothing)
        ElseIf ver = "59" Then
            My.Computer.Network.DownloadFile(smbx59, smbxexe, vbNull, vbNull, True, 10000, True, FileIO.UICancelOption.DoNothing)
        ElseIf ver = "1.0.0.0" Then
            My.Computer.Network.DownloadFile(smbx1main, smbxexe, vbNull, vbNull, True, 10000, True, FileIO.UICancelOption.DoNothing)
            My.Computer.Network.DownloadFile(smbx1edit, smbxpath + "\smbx1editor.exe", vbNull, vbNull, True, 10000, True, FileIO.UICancelOption.DoNothing)
        End If

        MsgBox("Successfully installed SMBX " + ver)

        MainForm.RefreshAllItems()

        CheckSMBXVersion()
    End Sub

    Private Function GetFileVersionInfo(ByVal filename As String) As Version
        Return Version.Parse(FileVersionInfo.GetVersionInfo(filename).FileVersion)
    End Function
End Class
