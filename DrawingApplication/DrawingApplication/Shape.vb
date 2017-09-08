Public MustInherit Class Shape
    Protected _Colour As Color
    Protected _Left As Integer
    Protected _Top As Integer

    Public Sub New(ByVal colour As Color, ByVal left As Integer, ByVal top As Integer)
        _Colour = colour
        _Left = left
        _Top = top
    End Sub

    Public Property Colour As Color
        Get
            Return _Colour
        End Get
        Set(ByVal value As Color)
            _Colour = value
        End Set
    End Property

    Public Property Left As Integer
        Get
            Return _Left
        End Get
        Set(ByVal value As Integer)
            _Left = value
        End Set
    End Property

    Public Property Top As Integer
        Get
            Return _Top
        End Get
        Set(ByVal value As Integer)
            _Top = value
        End Set
    End Property

    Public MustOverride Sub Display(ByVal drawingArea As Graphics)
End Class
