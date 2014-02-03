
Public Class UpdatingSmbx
    Dim settingsIni As New Setting.IniFile(Environment.CurrentDirectory + "\settings.ini")
    Dim smbxDir As String = settingsIni.ReadValue("Settings", "smbxpath")
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://supermariobrosx.org/forums/viewtopic.php?f=57&t=962")

    End Sub

    Private Sub UpdatingSmbx_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label6.Text = smbxDir

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        If My.Computer.FileSystem.DirectoryExists(smbxDir) Then
            Process.Start(smbxDir)
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class