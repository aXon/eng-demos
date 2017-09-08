Public Class EmailValidatorForm

    Private Sub validateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles validateButton.Click
        Dim validator As New EmailAddressValidator(inputTextBox.Text)

        Dim result As Boolean = validator.IsValidEmailAddress

        validLabel.Visible = result
        invalidLabel.Visible = Not result
    End Sub
End Class
