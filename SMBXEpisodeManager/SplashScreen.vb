Public NotInheritable Class SplashScreen

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).

    Public Function GenerateRandomNumber(ByVal min As Integer, ByVal max As Integer) As Integer
        Randomize()
        Dim random As New Random()
        Return random.Next(1, 5)
    End Function
    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If GenerateRandomNumber(1, 5) = 1 Then
            Me.BackgroundImage = My.Resources.background_1
        ElseIf 2 Then
            Me.BackgroundImage = My.Resources.background_2
        ElseIf 3 Then
            Me.BackgroundImage = My.Resources.background_3
        ElseIf 4 Then
            Me.BackgroundImage = My.Resources.background_4
        ElseIf 5 Then
            Me.BackgroundImage = My.Resources.background_5
        End If


    End Sub

   
End Class
