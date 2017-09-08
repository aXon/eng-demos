Public Class Ellipse
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

    Public Sub New(ByVal colour As Color, ByVal left As Integer, ByVal top As Integer)
        MyBase.New(colour, left, top)
    End Sub

    Public Sub New(ByVal height As Integer, ByVal width As Integer, ByVal colour As Color)
        MyBase.New(colour, 0, 0)

        _Height = height
        _Width = width
    End Sub


    Public Overrides Sub Display(ByVal drawingArea As Graphics)
        Dim pen As New Pen(_Colour)

        drawingArea.DrawEllipse(pen, _Left, _Top, _Width, _Height)
    End Sub
End Class
