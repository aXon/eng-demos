Option Strict On

Public Class CalculatorForm
    Private firstNumber As String
    Private operation As String

    Private Sub Clear()
        equalsButton.Enabled = False
        minusButton.Enabled = True
        plusButton.Enabled = True

        displayTextBox.Clear()
        firstNumber = ""
        operation = ""
    End Sub

    Private Sub NumberButtonPressed(sender As Object, e As EventArgs) Handles num0Button.Click, num1Button.Click, num2Button.Click, num3Button.Click, _
                                                num4Button.Click, num5Button.Click, num6Button.Click, num7Button.Click, _
                                                num8Button.Click, num9Button.Click
        If operation = "result" Then
            Clear()
        End If

        Dim clickedButton As Button = DirectCast(sender, Button)

        Dim singleDigit As String = clickedButton.Text.Substring(1, 1)

        displayTextBox.AppendText(singleDigit)

        If operation = String.Empty Then
            firstNumber &= singleDigit
        End If
    End Sub

    Private Sub OperatorButtonPressed()
        displayTextBox.Clear()

        equalsButton.Enabled = True
        minusButton.Enabled = False
        plusButton.Enabled = False
    End Sub

    Private Sub plusButton_Click(sender As Object, e As EventArgs) Handles plusButton.Click
        operation = "add"

        OperatorButtonPressed()
    End Sub

    Private Sub minusButton_Click(sender As Object, e As EventArgs) Handles minusButton.Click
        operation = "subtract"

        OperatorButtonPressed()
    End Sub

    Private Sub equalsButton_Click(sender As Object, e As EventArgs) Handles equalsButton.Click
        Dim firstPart As Integer = CInt(firstNumber)
        Dim secondPart As Integer = CInt(displayTextBox.Text)
        Dim result As Integer

        If operation = "add" Then
            result = firstPart + secondPart
        ElseIf operation = "subtract" Then
            result = firstPart - secondPart
        End If

        operation = "result"

        displayTextBox.Text = CStr(result)
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        Clear()
    End Sub
End Class
