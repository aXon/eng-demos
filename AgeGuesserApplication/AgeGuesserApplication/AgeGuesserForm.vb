Public Class AgeGuesserForm
    Private tries As Integer


    Private Sub MakeAGuess()
        Dim rand As Random

        rand = New Random

        ' I could have written the previous two lines in one instead:
        '  Dim rand As New Random

        Dim thisGuess As Integer = rand.Next(13, 120) ' This assumes that the person is 13 or older, but younger than 120

        guessLabel.Text = CStr(thisGuess) & " years old"

        tries += 1
    End Sub


    Private Sub yesButton_Click(sender As System.Object, e As System.EventArgs) Handles yesButton.Click
        MessageBox.Show("Excellent!  I got it right in " & CStr(tries) & " guesses!")
    End Sub

    Private Sub noButton_Click(sender As Object, e As System.EventArgs) Handles noButton.Click
        MakeAGuess()
    End Sub

    Private Sub AgeGuesserForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        MakeAGuess()
    End Sub
End Class
