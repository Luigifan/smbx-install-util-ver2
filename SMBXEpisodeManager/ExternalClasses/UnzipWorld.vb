Imports Ionic.Zip
Imports Setting.IniFile

Public Class UnzipWorld

    Public Sub unzipWorldK(ByVal techName As String, ByVal downloadLink As String, ByVal zipToUnzip As String, ByVal worldsDir As String)
        If My.Computer.FileSystem.DirectoryExists(techName) Then
            'continue normally
        Else
            My.Computer.FileSystem.CreateDirectory(techName)
        End If
        Using zip1 As ZipFile = ZipFile.Read(zipToUnzip)
            Dim entry As ZipEntry
            For Each entry In zip1
                entry.Extract(worldsDir + techName, ExtractExistingFileAction.OverwriteSilently)
            Next
        End Using
    End Sub



End Class
