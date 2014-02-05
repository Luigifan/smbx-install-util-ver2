Public Class UnzipProgress

    Private Sub UnzipProgress_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim main As New MainForm
        While MainForm.BackgroundWorker1.IsBusy
            Me.Refresh()
        End While
        Me.Close()
    End Sub
End Class