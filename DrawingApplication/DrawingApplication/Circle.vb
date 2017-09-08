Public Class Circle
    Inherits Shape

    Protected _Diameter As Integer

    Public Property Diameter As Integer
        Get
            Return _Diameter
        End Get
        Set(ByVal value As Integer)
            _Diameter = value
        End Set
    End Property

    Public Sub New(ByVal colour As Color, ByVal diameter As Integer)
        MyBase.New(colour, 0, 0)

        _Diameter = diameter
    End Sub

    Public Overrides Sub Display(ByVal drawingArea As Graphics)
        Dim pen As New Pen(_Colour)

        drawingArea.DrawEllipse(pen, _Left, _Top, _Diameter, _Diameter)
    End Sub
End Class
