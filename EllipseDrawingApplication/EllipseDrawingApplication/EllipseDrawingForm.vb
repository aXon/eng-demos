Public Class EllipseDrawingForm

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        SetupTrackBars()
    End Sub

    Private Sub SetupTrackBars()
        ' Set the maximum values of the TrackBars based on the width and height of the PictureBox we're going to draw in
        xTrackBar.Maximum = drawingAreaPictureBox.Width
        yTrackBar.Maximum = drawingAreaPictureBox.Height
    End Sub

    Private Sub RedrawCurrentEllipse()
        Dim yValue As Integer

        yValue = drawingAreaPictureBox.Height - yTrackBar.Value

        ' Update the labels for both TrackBars
        xValueLabel.Text = CStr(xTrackBar.Value)
        yValueLabel.Text = CStr(yValue)

        ' Draw the current ellipse in the drawing area
        Dim drawingArea As Graphics = drawingAreaPictureBox.CreateGraphics()

        drawingArea.Clear(drawingAreaPictureBox.BackColor)

        drawingArea.DrawEllipse(Pens.Black, 0, 0, xTrackBar.Value, yValue)
    End Sub

    Private Sub xTrackBar_Scroll(sender As Object, e As System.EventArgs) Handles xTrackBar.Scroll
        RedrawCurrentEllipse()
    End Sub

    Private Sub yTrackBar_Scroll(sender As Object, e As System.EventArgs) Handles yTrackBar.Scroll
        RedrawCurrentEllipse()
    End Sub
End Class
