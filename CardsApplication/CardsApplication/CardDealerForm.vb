Option Strict On

Public Class CardDealerForm
    Private cardsDealtSoFar As Integer
    Private drawingArea As Graphics

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ShowNumberOfCardsToDeal()
    End Sub

    Private Sub dealButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dealButton.Click
        drawingArea = playingSurfacePictureBox.CreateGraphics

        drawingArea.Clear(playingSurfacePictureBox.BackColor)

        cardsDealtSoFar = 0

        showNextCardTimer.Start()
    End Sub

    Private Sub showNextCardTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles showNextCardTimer.Tick
        ChooseAndDisplayCard(cardsDealtSoFar)

        cardsDealtSoFar += 1

        If cardsDealtSoFar >= cardCountTrackBar.Value Then
            showNextCardTimer.Stop()
        End If
    End Sub

    Private Sub cardCountTrackBar_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles cardCountTrackBar.Scroll
        ShowNumberOfCardsToDeal()
    End Sub


    Private Sub ChooseAndDisplayCard(ByVal offset As Integer)
        Dim randomGenerator As New Random
        Dim cardNumber As Integer = randomGenerator.Next(0, 52)
        Dim cardSuit As Integer = cardNumber \ 13
        Dim cardValue As Integer = (cardNumber Mod 13) + 1

        Dim filePath As String = GetCardFileName(cardSuit, cardValue)

        Dim cardImage As Image = Image.FromFile(filePath)

        Dim xPosition As Integer

        xPosition = (offset * 50) + 10

        drawingArea.DrawImage(cardImage, xPosition, 10, 250, 363)
    End Sub

    Private Function GetCardFileName(ByVal cardSuit As Integer, ByVal cardValue As Integer) As String
        Dim suitName As String = GetSuitName(cardSuit)
        Dim value As String = GetValueName(cardValue)

        Dim fileName As String

        fileName = value & "_of_" & suitName & ".png"

        fileName = IO.Path.Combine("PNG-cards-1.3", fileName)

        Return fileName
    End Function

    Private Function GetValueName(ByVal cardValue As Integer) As String
        Select Case cardValue
            Case 1
                Return "Ace"

            Case 2 To 10
                Return CStr(cardValue)

            Case 11
                Return "Jack"

            Case 12
                Return "Queen"

            Case 13
                Return "King"

            Case Else
                Return "(Unknown value)"
        End Select
    End Function

    Private Function GetSuitName(ByVal cardSuit As Integer) As String
        Dim suitName As String

        Select Case cardSuit
            Case 0
                suitName = "Clubs"

            Case 1
                suitName = "Diamonds"

            Case 2
                suitName = "Hearts"

            Case 3
                suitName = "Spades"

            Case Else
                ' This shouldn't happen but to stop Visual Basic from showing a warning, we set suitName to a value here
                suitName = "(Unknown suit)"
        End Select

        Return suitName
    End Function

    Private Sub ShowNumberOfCardsToDeal()
        Dim buttonText As String

        Dim cardsToDeal As Integer = cardCountTrackBar.Value

        dealButton.Enabled = True

        If cardsToDeal > 1 Then
            buttonText = "Deal " & CStr(cardsToDeal) & " cards"
        ElseIf cardsToDeal = 1 Then
            buttonText = "Deal a card"
        Else ' cardsToDeal must be zero
            buttonText = "No cards to deal"

            dealButton.Enabled = False
        End If

        dealButton.Text = buttonText
    End Sub
End Class
