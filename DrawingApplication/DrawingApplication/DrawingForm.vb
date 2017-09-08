Public Class DrawingForm
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        SetupTrackBars()

        UpdateTrackBarLabels()
    End Sub

    Private Sub SetupTrackBars()
        ' Set the maximum values of the TrackBars based on the width and height of the PictureBox we're going to draw in
        xTrackBar.Maximum = drawingAreaPictureBox.Width
        xTrackBar.TickFrequency = drawingAreaPictureBox.Width \ 10
        yTrackBar.Maximum = drawingAreaPictureBox.Height
        yTrackBar.TickFrequency = drawingAreaPictureBox.Height \ 10
    End Sub

    Private Sub UpdateTrackBarLabels()
        Dim yValue As Integer

        yValue = drawingAreaPictureBox.Height - yTrackBar.Value

        ' Update the labels for both TrackBars
        xValueLabel.Text = CStr(xTrackBar.Value)
        yValueLabel.Text = CStr(yValue)
    End Sub

    Private Sub yTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yTrackBar.Scroll
        UpdateTrackBarLabels()
    End Sub

    Private Sub xTrackBar_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles xTrackBar.Scroll
        UpdateTrackBarLabels()
    End Sub

    Private Sub drawRedEllipseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles drawRedEllipseButton.Click
        Dim drawingArea As Graphics = drawingAreaPictureBox.CreateGraphics()

        drawingArea.Clear(drawingAreaPictureBox.BackColor)

        Dim ellipse As New Ellipse(CInt(yValueLabel.Text), CInt(xValueLabel.Text), Color.Red)

        ellipse.Display(drawingArea)
    End Sub

    Private Sub drawGreenEllipseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles drawGreenEllipseButton.Click
        Dim drawingArea As Graphics = drawingAreaPictureBox.CreateGraphics()

        drawingArea.Clear(drawingAreaPictureBox.BackColor)

        Dim ellipse As New Ellipse(CInt(yValueLabel.Text), CInt(xValueLabel.Text), Color.Green)

        ellipse.Display(drawingArea)
    End Sub

    Private Sub drawBlueEllipseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles drawBlueEllipseButton.Click
        Dim drawingArea As Graphics = drawingAreaPictureBox.CreateGraphics()

        drawingArea.Clear(drawingAreaPictureBox.BackColor)

        Dim ellipse As New Ellipse(CInt(yValueLabel.Text), CInt(xValueLabel.Text), Color.Blue)

        ellipse.Display(drawingArea)
    End Sub

    Private Sub drawYellowCircleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles drawYellowCircleButton.Click
        Dim drawingArea As Graphics = drawingAreaPictureBox.CreateGraphics()

        drawingArea.Clear(drawingAreaPictureBox.BackColor)

        Dim circle As New Circle(Color.Yellow, CInt(yValueLabel.Text))

        circle.Display(drawingArea)
    End Sub

    Private Sub drawPurpleTriangle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles drawPurpleTriangle.Click
        Dim drawingArea As Graphics = drawingAreaPictureBox.CreateGraphics()

        drawingArea.Clear(drawingAreaPictureBox.BackColor)

        Dim triangle As New Triangle(CInt(xValueLabel.Text), CInt(yValueLabel.Text), Color.Purple)

        triangle.Display(drawingArea)
    End Sub
End Class
