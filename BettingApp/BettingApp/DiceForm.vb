Public Class DiceForm
    Private die1 As New Die(1)
    Private die2 As New Die(2)
    Private die3 As New Die(3)


    Private Sub rollDiceButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rollDiceButton.Click
        die1NumericUpDown.Value = die1.Roll
        die2NumericUpDown.Value = die2.Roll
        die3NumericUpDown.Value = die3.Roll
    End Sub

    Private Sub calculateWinningsButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles calculateWinningsButton.Click
        Dim winnings As Integer

        If die1.Value = 6 AndAlso die2.Value = 6 AndAlso die3.Value = 6 Then ' All three dice are 6's
            winnings = 20
        ElseIf (die1.Value = die2.Value) AndAlso (die3.Value = die2.Value) Then ' All three dice are the same
            winnings = 10
        ElseIf (die1.Value = die2.Value) Or (die2.Value = die3.Value) Or (die1.Value = die3.Value) Then
            ' Any two of the three dice are the same
            winnings = 5
        Else
            winnings = 0
        End If

        If winnings > 0 Then
            MessageBox.Show("You have won $" & CStr(winnings))
        End If
    End Sub
End Class
