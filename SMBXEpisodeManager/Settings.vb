Imports Setting.IniFile

Public Class Settings
    Dim settingsIni As New Setting.IniFile(Environment.CurrentDirectory + "\settings.ini")
    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        smbxDir.Text = settingsIni.ReadValue("Settings", "smbxpath")
        worldsDir.Text = settingsIni.ReadValue("Settings", "worldlocation")
        execDir.Text = settingsIni.ReadValue("Settings", "executableloc")
    End Sub

    Public Sub SaveSettings()
        MsgBox("Settings saved!")

        settingsIni.WriteValue("Settings", "smbxpath", smbxDir.Text)
        settingsIni.WriteValue("Settings", "worldlocation", worldsDir.Text)
        settingsIni.WriteValue("Settings", "executableloc", execDir.Text)
        MainForm.ReloadWorldsDir()
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
End Class