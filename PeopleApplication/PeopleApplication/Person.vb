Public Class Person
    Private _Age As Integer
    Private _FamilyName As String
    Private _GivenName As String
    Private _MiddleName As String

    Public ReadOnly Property Age As Integer
        Get
            Return _Age
        End Get
    End Property

    Public Property FamilyName As String
        Get
            Return _FamilyName
        End Get
        Set(ByVal value As String)
            _FamilyName = value
        End Set
    End Property


    Public Property GivenName As String
        Get
            Return _GivenName
        End Get
        Set(ByVal value As String)
            _GivenName = value
        End Set
    End Property


    Public Property MiddleName As String
        Get
            Return _MiddleName
        End Get
        Set(ByVal value As String)
            _MiddleName = value
        End Set
    End Property

    Public Sub New()
        AssignRandomAge()
    End Sub

    Public Sub New(ByVal givenName As String, ByVal middleName As String, ByVal familyName As String)
        _GivenName = givenName
        _FamilyName = familyName
        _MiddleName = middleName

        AssignRandomAge()
    End Sub

    Public Sub New(ByVal givenName As String, ByVal familyName As String)
        Me.New(givenName, "", familyName)
    End Sub

    Private Sub AssignRandomAge()
        Dim rnd As New Random
        _Age = rnd.Next(1, 120)
    End Sub

    Public Function GetAge() As String
        If _Age = 0 Then
            Return "(Age unknown)"
        Else
            Return "(Age: " & CStr(_Age) & ")"
        End If
    End Function

    Public Function GetFullName(ByVal includeMiddleName As Boolean) As String
        Dim fullName As String = GivenName

        If includeMiddleName AndAlso (Not (_MiddleName = "")) Then
            fullName &= " " & _MiddleName
        End If

        fullName &= " " & _FamilyName

        Return fullName
    End Function

    Public Function GetFullNameAndAge(ByVal includeMiddleName As Boolean) As String
        Return GetFullName(includeMiddleName) & " " & GetAge()
    End Function


End Class
