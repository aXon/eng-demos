Public Class EmailAddressValidator
    Private _EmailAddress As String

    Public Sub New(ByVal emailAddress As String)
        _EmailAddress = emailAddress
    End Sub

    Public Function IsValidEmailAddress() As Boolean
        Dim parts() As String = _EmailAddress.Split("@"c)

        If UBound(parts) <> 1 Then
            Return False
        End If

        Return IsPrefixValid(parts(0)) AndAlso IsPostfixValid(parts(1))
    End Function


    Private Function IsPrefixValid(ByVal prefix As String) As Boolean
        ' Checks the part of the email address before the @ sign.  For example: if the bit before 
        ' the at sign contains a space, then this function should return false.
        If prefix.Contains(" ") Then
            Return False
        End If

        Return True
    End Function

    Private Function IsPostfixValid(ByVal postfix As String) As Boolean
        ' Checks the part of the email address the @ sign.  For example, if the bit after 
        ' the at sign doesn't contain at least one dot  then this function should return false.
        postfix = postfix.TrimEnd

        If Not postfix.Contains(".") Then
            Return False
        End If

        If postfix.StartsWith(".") Then
            Return False
        End If

        If postfix.Contains(" ") Then
            Return False
        End If

        For Each letter As Char In postfix
            If Not (Char.IsLetterOrDigit(letter) Or letter = "."c) Then
                Return False
            End If
        Next

        Return True
    End Function

End Class
