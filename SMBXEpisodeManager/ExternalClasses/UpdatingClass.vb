Imports System.IO
Imports System.Net

Public Class UpdatingClass
    Public Shared Function CheckforInternetConnection() As Boolean
        If My.Computer.Network.IsAvailable = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function CheckVersion(ByVal url As String, ByVal curver As String) As Boolean
        Dim NewestVersion As String
        Dim client2 As WebClient = New WebClient()
        Dim curDir As String = Environment.CurrentDirectory


        My.Computer.Network.DownloadFile(url, curDir + "\version.txt", vbNull, vbNull, False, 10000, True)
        Try
            Using reader As StreamReader = New StreamReader(curDir + "\version.txt")
                NewestVersion = reader.ReadLine
            End Using
            If NewestVersion = curver Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured when trying to update!" + vbNewLine + vbNewLine + ex.Message, "Simple VB Updater")
        End Try




    End Function
End Class
