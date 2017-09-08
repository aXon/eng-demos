<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EllipseDrawingForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.drawingAreaPictureBox = New System.Windows.Forms.PictureBox()
        Me.xTrackBar = New System.Windows.Forms.TrackBar()
        Me.yTrackBar = New System.Windows.Forms.TrackBar()
        Me.drawRedEllipseButton = New System.Windows.Forms.Button()
        Me.drawGreenEllipseButton = New System.Windows.Forms.Button()
        Me.drawBlueEllipseButton = New System.Windows.Forms.Button()
        Me.yValueLabel = New System.Windows.Forms.Label()
        Me.xValueLabel = New System.Windows.Forms.Label()
        CType(Me.drawingAreaPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.yTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'drawingAreaPictureBox
        '
        Me.drawingAreaPictureBox.BackColor = System.Drawing.Color.White
        Me.drawingAreaPictureBox.Location = New System.Drawing.Point(105, 12)
        Me.drawingAreaPictureBox.Name = "drawingAreaPictureBox"
        Me.drawingAreaPictureBox.Size = New System.Drawing.Size(640, 440)
        Me.drawingAreaPictureBox.TabIndex = 0
        Me.drawingAreaPictureBox.TabStop = False
        '
        'xTrackBar
        '
        Me.xTrackBar.Location = New System.Drawing.Point(105, 458)
        Me.xTrackBar.Name = "xTrackBar"
        Me.xTrackBar.Size = New System.Drawing.Size(640, 45)
        Me.xTrackBar.TabIndex = 1
        '
        'yTrackBar
        '
        Me.yTrackBar.Location = New System.Drawing.Point(54, 12)
        Me.yTrackBar.Name = "yTrackBar"
        Me.yTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.yTrackBar.Size = New System.Drawing.Size(45, 440)
        Me.yTrackBar.TabIndex = 2
        Me.yTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'drawRedEllipseButton
        '
        Me.drawRedEllipseButton.BackColor = System.Drawing.Color.LightCoral
        Me.drawRedEllipseButton.Location = New System.Drawing.Point(751, 22)
        Me.drawRedEllipseButton.Name = "drawRedEllipseButton"
        Me.drawRedEllipseButton.Size = New System.Drawing.Size(149, 41)
        Me.drawRedEllipseButton.TabIndex = 3
        Me.drawRedEllipseButton.Text = "Draw Red Ellipse"
        Me.drawRedEllipseButton.UseVisualStyleBackColor = False
        '
        'drawGreenEllipseButton
        '
        Me.drawGreenEllipseButton.BackColor = System.Drawing.Color.LightGreen
        Me.drawGreenEllipseButton.Location = New System.Drawing.Point(751, 69)
        Me.drawGreenEllipseButton.Name = "drawGreenEllipseButton"
        Me.drawGreenEllipseButton.Size = New System.Drawing.Size(149, 41)
        Me.drawGreenEllipseButton.TabIndex = 4
        Me.drawGreenEllipseButton.Text = "Draw Green Ellipse"
        Me.drawGreenEllipseButton.UseVisualStyleBackColor = False
        '
        'drawBlueEllipseButton
        '
        Me.drawBlueEllipseButton.BackColor = System.Drawing.Color.LightSkyBlue
        Me.drawBlueEllipseButton.Location = New System.Drawing.Point(751, 116)
        Me.drawBlueEllipseButton.Name = "drawBlueEllipseButton"
        Me.drawBlueEllipseButton.Size = New System.Drawing.Size(149, 41)
        Me.drawBlueEllipseButton.TabIndex = 5
        Me.drawBlueEllipseButton.Text = "Draw Blue Ellipse"
        Me.drawBlueEllipseButton.UseVisualStyleBackColor = False
        '
        'yValueLabel
        '
        Me.yValueLabel.AutoSize = True
        Me.yValueLabel.Location = New System.Drawing.Point(12, 225)
        Me.yValueLabel.Name = "yValueLabel"
        Me.yValueLabel.Size = New System.Drawing.Size(39, 13)
        Me.yValueLabel.TabIndex = 6
        Me.yValueLabel.Text = "Label1"
        '
        'xValueLabel
        '
        Me.xValueLabel.AutoSize = True
        Me.xValueLabel.Location = New System.Drawing.Point(408, 490)
        Me.xValueLabel.Name = "xValueLabel"
        Me.xValueLabel.Size = New System.Drawing.Size(39, 13)
        Me.xValueLabel.TabIndex = 7
        Me.xValueLabel.Text = "Label2"
        '
        'EllipseDrawingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 524)
        Me.Controls.Add(Me.xValueLabel)
        Me.Controls.Add(Me.yValueLabel)
        Me.Controls.Add(Me.drawBlueEllipseButton)
        Me.Controls.Add(Me.drawGreenEllipseButton)
        Me.Controls.Add(Me.drawRedEllipseButton)
        Me.Controls.Add(Me.yTrackBar)
        Me.Controls.Add(Me.xTrackBar)
        Me.Controls.Add(Me.drawingAreaPictureBox)
        Me.Name = "EllipseDrawingForm"
        Me.Text = "Draw Ellipses"
        CType(Me.drawingAreaPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.yTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents drawingAreaPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents xTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents yTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents drawRedEllipseButton As System.Windows.Forms.Button
    Friend WithEvents drawGreenEllipseButton As System.Windows.Forms.Button
    Friend WithEvents drawBlueEllipseButton As System.Windows.Forms.Button
    Friend WithEvents yValueLabel As System.Windows.Forms.Label
    Friend WithEvents xValueLabel As System.Windows.Forms.Label

End Class
