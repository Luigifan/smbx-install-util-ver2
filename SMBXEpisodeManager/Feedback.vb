﻿Public Class Feedback

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub WebBrowser1_LocationChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebBrowser1.LocationChanged
        If WebBrowser1.Url = New Uri("http://smbxepisodes.tk/index.html") Then
            Me.Close()
        End If
    End Sub

    Private Sub WebBrowser1_Navigating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles WebBrowser1.Navigating
        If WebBrowser1.Url = New Uri("http://smbxepisodes.tk/index.html") Then
            Me.Close()
        End If
    End Sub
End Class