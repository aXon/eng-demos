Public Class CarCounterForm
    Private smallCarPark As New CarPark(10)

    Private Sub carInButton_Click(sender As System.Object, e As System.EventArgs) Handles carInButton.Click
        smallCarPark.AdmitCar()

        DisplayCarCount()
    End Sub

    Private Sub carOutButton_Click(sender As Object, e As System.EventArgs) Handles carOutButton.Click
        smallCarPark.AllowCarToLeave()

        DisplayCarCount()
    End Sub

    Private Sub DisplayCarCount()
        carCountNumericUpDown.Value = smallCarPark.CarCount

        carInButton.Enabled = smallCarPark.HasSpaces
        carOutButton.Enabled = Not (smallCarPark.IsEmpty)
    End Sub
End Class
