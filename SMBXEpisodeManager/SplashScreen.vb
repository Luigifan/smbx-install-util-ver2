Public NotInheritable Class SplashScreen

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).

    Public Function GenerateRandomNumber(ByVal min As Integer, ByVal max As Integer) As Integer
        Randomize()
        Dim random As New Random()
        Return random.Next(1, 10)
    End Function
    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If GenerateRandomNumber(1, 10) = 1 Then
            Me.BackgroundImage = My.Resources.background_1
        ElseIf 2 Then
            Me.BackgroundImage = My.Resources.background_2
        ElseIf 3 Then
            Me.BackgroundImage = My.Resources.background_3
        ElseIf 4 Then
            Me.BackgroundImage = My.Resources.background_4
        ElseIf 5 Then
            Me.BackgroundImage = My.Resources.background_5
        ElseIf 6 Then
            Me.BackgroundImage = My.Resources.background_6
        ElseIf 7 Then
            Me.BackgroundImage = My.Resources.background_7
        ElseIf 8 Then
            Me.BackgroundImage = My.Resources.background_8
        ElseIf 9 Then
            Me.BackgroundImage = My.Resources.background_9
        ElseIf 10 Then
            Me.BackgroundImage = My.Resources.background_10
        End If


    End Sub

   
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class
