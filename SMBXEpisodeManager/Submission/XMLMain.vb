Imports System.IO
Imports System.Text
Imports System.Xml.Serialization

Public Class XMLMain
    Dim destFile As String = Environment.CurrentDirectory() + "\submission.sub"
    

    Private Sub CreateExampleData()
        'Hi guys! This is where the data is submitted!
        Using sr As StreamWriter = New StreamWriter(destFile)
            sr.WriteLine("<episodesList>")
            sr.WriteLine("<episode " + "IconLoc=""" + TextBox7.Text + """ TechName=""" + TextBox5.Text + """ Description=""" + TextBox3.Text + """ Author=""" + TextBox2.Text + """ DownloadLink=""" + """" + " ZipName=""" + TextBox4.Text + """>" + TextBox1.Text + "</episode>")
            sr.WriteLine("</episodesList>")
        End Using



    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load


        TextBox6.Text = destFile
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CreateExampleData()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        CreateExampleData()
        MsgBox("XML Saved to " + destFile, MsgBoxStyle.Information)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Process.Start(Environment.CurrentDirectory)
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'MsgBox("Due to limitations of Visual Basic and XML, please place your strings INSIDE the quotations marks for you episode to be submitted." & vbNewLine & "Episode names are not required to be in quotation marks" & vbNewLine & "Thank you!", MsgBoxStyle.Critical)
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim oForm As New Help
        oForm.Show()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text IsNot Nothing Then
            AuthorTextBox.Text = TextBox2.Text
        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        episodename.Text = TextBox1.Text
        DescriptionTextBox.Text = TextBox3.Text
        AuthorTextBox.Text = TextBox2.Text
        IconImage.ImageLocation = TextBox7.Text

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        MsgBox("It is generally a good thing to keep this the same as the episode name, unless it contains what isn't allowed in a Windows file name")
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Console.WriteLine(("<episode " + "IconLoc=""" + TextBox7.Text + """ TechName=""" + TextBox5.Text + """ Description=""" + TextBox3.Text + """ Author=""" + TextBox2.Text + """ DownloadLink=""" + """" + " ZipName=""" + TextBox4.Text + """>" + TextBox1.Text + "</episode>"))

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text IsNot Nothing Then
            episodename.Text = TextBox1.Text
            TextBox5.Text = TextBox1.Text
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text IsNot Nothing Then
            DescriptionTextBox.Text = TextBox3.Text
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        IconImage.BackgroundImage = Nothing

        IconImage.ImageLocation = TextBox7.Text

    End Sub

End Class
