Imports Setting.IniFile

Public Class Settings
    Dim settingsIni As New Setting.IniFile(Environment.CurrentDirectory + "\settings.ini")
    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        smbxDir.Text = settingsIni.ReadValue("Settings", "smbxpath")
        worldsDir.Text = settingsIni.ReadValue("Settings", "worldlocation")
        execDir.Text = settingsIni.ReadValue("Settings", "executableloc")
        If settingsIni.ReadValue("Settings", "dlServers") = "pixels" Then
            RadioButton1.Checked = True
            'RadioButton2.Checked = False
        ElseIf settingsIni.ReadValue("Settings", "dlServer") = "mike" Then
            'RadioButton1.Checked = False
            RadioButton2.Checked = True
        End If

        If settingsIni.ReadValue("Settings", "Theme") = "smb" Then
            smbRadio.Checked = True
        ElseIf settingsIni.ReadValue("Settings", "Theme") = "windows" Then
            wfRadio.Checked = True

        End If

        If My.Computer.FileSystem.FileExists(execDir.Text) Then
            ver.Text = "SMBX " + GetFileVersionInfo(execDir.Text).ToString

            ver.ForeColor = Color.Green
        Else
            ver.Text = "SMBX not found!"
            ver.ForeColor = System.Drawing.Color.Red
        End If
    End Sub

    Public Sub SaveSettings()
        MsgBox("Settings saved!")

        settingsIni.WriteValue("Settings", "smbxpath", smbxDir.Text)
        settingsIni.WriteValue("Settings", "worldlocation", worldsDir.Text)
        settingsIni.WriteValue("Settings", "executableloc", execDir.Text)
        If RadioButton1.Checked = True Then
            settingsIni.WriteValue("Settings", "dlServers", "pixels")
        ElseIf RadioButton2.Checked = True Then
            settingsIni.WriteValue("Settings", "dlServers", "mike")
            MsgBox("Warning! Mike's servers still use Pixels' to download as of right now." + vbNewLine + "And sometimes it can be out of date. Proceed with caution")
        End If

        If smbRadio.Checked = True Then
            settingsIni.WriteValue("Settings", "Theme", "smb")
        ElseIf wfRadio.Checked = True Then
            settingsIni.WriteValue("Settings", "Theme", "windows")
        End If
        MainForm.RefreshAllItems()
        MainForm.ReloadWorldsDir()
        MainForm.CheckTheme()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim FolderBrowserDialog1 As New FolderBrowserDialog
        Dim smbxexedir As String = ""
        FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer
        If (FolderBrowserDialog1.ShowDialog = DialogResult.OK) Then
            smbxexedir = FolderBrowserDialog1.SelectedPath
        End If

        smbxDir.Text = smbxexedir
        worldsDir.Text = smbxexedir + "\worlds"
        execDir.Text = smbxexedir + "\smbx.exe"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SaveSettings()
    End Sub

    Private Function GetFileVersionInfo(ByVal filename As String) As Version
        Return Version.Parse(FileVersionInfo.GetVersionInfo(filename).FileVersion)
    End Function
End Class