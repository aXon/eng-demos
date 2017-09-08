Public Class CarPark
    Private _CurrentCarCount As Integer
    Private _Capacity As Integer

    Public ReadOnly Property CarCount As Integer
        Get
            Return _CurrentCarCount
        End Get
    End Property


    Public Sub New(ByVal capacity As Integer)
        _Capacity = capacity
    End Sub

    Public Function HasSpaces() As Boolean
        Return Not IsFull()
    End Function

    Public Function IsEmpty() As Boolean
        Return (_CurrentCarCount = 0)
    End Function

    Public Function IsFull() As Boolean
        If _CurrentCarCount >= _Capacity Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub AdmitCar()
        If _CurrentCarCount < _Capacity Then
            _CurrentCarCount = _CurrentCarCount + 1
        Else
            MessageBox.Show("The car park is full!")
        End If
    End Sub

    Public Sub AllowCarToLeave()
        If _CurrentCarCount > 0 Then
            _CurrentCarCount -= 1
        Else
            MessageBox.Show("You can't decrease the car count because the car park is already empty")
        End If
    End Sub

End Class
