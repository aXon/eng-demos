Public Class NamesForm
    Private _Someone As New Person()

    Private Sub familyNameTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles familyNameTextBox.TextChanged
        _Someone.FamilyName = familyNameTextBox.Text
    End Sub

    Private Sub givenNameTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles givenNameTextBox.TextChanged
        _Someone.GivenName = givenNameTextBox.Text
    End Sub

    Private Sub middleNameTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles middleNameTextBox.TextChanged
        _Someone.MiddleName = middleNameTextBox.Text
    End Sub


    Private Sub showWithoutMiddleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showWithoutMiddleButton.Click
        fullNameTextBox.Text = _Someone.GetFullNameAndAge(False)
    End Sub

    Private Sub showWithMiddleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showWithMiddleButton.Click
        fullNameTextBox.Text = _Someone.GetFullNameAndAge(True)
    End Sub
   
End Class
