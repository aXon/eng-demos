Public Class Die
    Private _value As Integer
    Private rnd As Random

    Public Sub New(ByVal dieNumber As Integer)
        rnd = New Random(dieNumber)
    End Sub

    Public ReadOnly Property Value As Integer
        Get
            Return _value
        End Get
    End Property

    Public Function Roll() As Integer
        _value = rnd.Next(1, 7)

        Return _value
    End Function
End Class
