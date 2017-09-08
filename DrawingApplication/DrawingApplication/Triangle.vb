Public Class Triangle
    Inherits Shape

    Protected _Width As Integer
    Protected _Height As Integer

    Public Property Height As Integer
        Get
            Return _Height
        End Get
        Set(ByVal value As Integer)
            _Height = value
        End Set
    End Property

    Public Property Width As Integer
        Get
            Return _Width
        End Get
        Set(ByVal value As Integer)
            _Width = value
        End Set
    End Property

    Public Sub New(ByVal height As Integer, ByVal width As Integer, ByVal colour As Color)
        MyBase.New(colour, 0, 0)

        _Height = height
        _Width = width
    End Sub

    Public Overrides Sub Display(ByVal drawingArea As System.Drawing.Graphics)
        Dim pen As New Pen(_Colour)

        Dim topPointX As Integer = _Width \ 2

        drawingArea.DrawLine(pen, (_Left + topPointX), _Top, (_Left + _Width), (_Top + Height))
        drawingArea.DrawLine(pen, (_Left + _Width), (_Top + Height), _Left, (_Top + Height))
        drawingArea.DrawLine(pen, _Left, (_Top + Height), (_Left + topPointX), _Top)
    End Sub
End Class
