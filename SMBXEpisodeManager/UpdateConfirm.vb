Imports System.Net
Imports System.IO

Public Class UpdateConfirm

    Private Sub UpdateConfirm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim address2 As String = "http://rohara.x10.mx/smbxpublisher/appfiles/version_smbx_new.txt"
        'Dim address2 As String = Environment.CurrentDirectory + "\newestversion.txt"
        Dim client2 As WebClient = New WebClient()
        Dim newversion As StreamReader = New StreamReader(client2.OpenRead(address2))


        Dim address As String = "http://rohara.x10.mx/smbxpublisher/appfiles/changelog_smbx.rtf"
        'Dim address As String = Environment.CurrentDirectory + "\changelog.txt"
        Dim client As WebClient = New WebClient()
        Dim changelog As StreamReader = New StreamReader(client.OpenRead(address))

        RichTextBox1.Text = changelog.ReadToEnd
        CurrentVer.Text = "Your version: " + My.Application.Info.Version.ToString
        NewestVer.Text = "Newest Version: " + newversion.ReadToEnd
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim versionreader As String
        versionreader = My.Computer.FileSystem.ReadAllText(Environment.CurrentDirectory + "\version.txt")
        MsgBox("Will not update!")
        Me.Close()

        MainForm.isUpdated.Text = "New version: " + versionreader
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Process.Start(Environment.CurrentDirectory + "\Update.exe")
        Me.Close()
        MainForm.Close()
    End Sub
End Class