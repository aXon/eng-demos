<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DrawingForm
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
        Me.xValueLabel = New System.Windows.Forms.Label()
        Me.yValueLabel = New System.Windows.Forms.Label()
        Me.yTrackBar = New System.Windows.Forms.TrackBar()
        Me.xTrackBar = New System.Windows.Forms.TrackBar()
        Me.drawingAreaPictureBox = New System.Windows.Forms.PictureBox()
        Me.drawBlueEllipseButton = New System.Windows.Forms.Button()
        Me.drawGreenEllipseButton = New System.Windows.Forms.Button()
        Me.drawRedEllipseButton = New System.Windows.Forms.Button()
        Me.drawYellowCircleButton = New System.Windows.Forms.Button()
        Me.drawPurpleTriangle = New System.Windows.Forms.Button()
        CType(Me.yTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drawingAreaPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'xValueLabel
        '
        Me.xValueLabel.AutoSize = True
        Me.xValueLabel.Location = New System.Drawing.Point(415, 490)
        Me.xValueLabel.Name = "xValueLabel"
        Me.xValueLabel.Size = New System.Drawing.Size(13, 13)
        Me.xValueLabel.TabIndex = 12
        Me.xValueLabel.Text = "0"
        '
        'yValueLabel
        '
        Me.yValueLabel.AutoSize = True
        Me.yValueLabel.Location = New System.Drawing.Point(19, 225)
        Me.yValueLabel.Name = "yValueLabel"
        Me.yValueLabel.Size = New System.Drawing.Size(13, 13)
        Me.yValueLabel.TabIndex = 11
        Me.yValueLabel.Text = "0"
        '
        'yTrackBar
        '
        Me.yTrackBar.Location = New System.Drawing.Point(61, 12)
        Me.yTrackBar.Name = "yTrackBar"
        Me.yTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.yTrackBar.Size = New System.Drawing.Size(45, 440)
        Me.yTrackBar.TabIndex = 10
        Me.yTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'xTrackBar
        '
        Me.xTrackBar.Location = New System.Drawing.Point(112, 458)
        Me.xTrackBar.Name = "xTrackBar"
        Me.xTrackBar.Size = New System.Drawing.Size(640, 45)
        Me.xTrackBar.TabIndex = 9
        '
        'drawingAreaPictureBox
        '
        Me.drawingAreaPictureBox.BackColor = System.Drawing.Color.White
        Me.drawingAreaPictureBox.Location = New System.Drawing.Point(112, 12)
        Me.drawingAreaPictureBox.Name = "drawingAreaPictureBox"
        Me.drawingAreaPictureBox.Size = New System.Drawing.Size(640, 440)
        Me.drawingAreaPictureBox.TabIndex = 8
        Me.drawingAreaPictureBox.TabStop = False
        '
        'drawBlueEllipseButton
        '
        Me.drawBlueEllipseButton.BackColor = System.Drawing.Color.LightSkyBlue
        Me.drawBlueEllipseButton.Location = New System.Drawing.Point(775, 106)
        Me.drawBlueEllipseButton.Name = "drawBlueEllipseButton"
        Me.drawBlueEllipseButton.Size = New System.Drawing.Size(149, 41)
        Me.drawBlueEllipseButton.TabIndex = 15
        Me.drawBlueEllipseButton.Text = "Draw Blue Ellipse"
        Me.drawBlueEllipseButton.UseVisualStyleBackColor = False
        '
        'drawGreenEllipseButton
        '
        Me.drawGreenEllipseButton.BackColor = System.Drawing.Color.LightGreen
        Me.drawGreenEllipseButton.Location = New System.Drawing.Point(775, 59)
        Me.drawGreenEllipseButton.Name = "drawGreenEllipseButton"
        Me.drawGreenEllipseButton.Size = New System.Drawing.Size(149, 41)
        Me.drawGreenEllipseButton.TabIndex = 14
        Me.drawGreenEllipseButton.Text = "Draw Green Ellipse"
        Me.drawGreenEllipseButton.UseVisualStyleBackColor = False
        '
        'drawRedEllipseButton
        '
        Me.drawRedEllipseButton.BackColor = System.Drawing.Color.LightCoral
        Me.drawRedEllipseButton.Location = New System.Drawing.Point(775, 12)
        Me.drawRedEllipseButton.Name = "drawRedEllipseButton"
        Me.drawRedEllipseButton.Size = New System.Drawing.Size(149, 41)
        Me.drawRedEllipseButton.TabIndex = 13
        Me.drawRedEllipseButton.Text = "Draw Red Ellipse"
        Me.drawRedEllipseButton.UseVisualStyleBackColor = False
        '
        'drawYellowCircleButton
        '
        Me.drawYellowCircleButton.BackColor = System.Drawing.Color.Yellow
        Me.drawYellowCircleButton.Location = New System.Drawing.Point(775, 153)
        Me.drawYellowCircleButton.Name = "drawYellowCircleButton"
        Me.drawYellowCircleButton.Size = New System.Drawing.Size(149, 41)
        Me.drawYellowCircleButton.TabIndex = 16
        Me.drawYellowCircleButton.Text = "Draw Yellow Circle"
        Me.drawYellowCircleButton.UseVisualStyleBackColor = False
        '
        'drawPurpleTriangle
        '
        Me.drawPurpleTriangle.BackColor = System.Drawing.Color.Purple
        Me.drawPurpleTriangle.Location = New System.Drawing.Point(775, 200)
        Me.drawPurpleTriangle.Name = "drawPurpleTriangle"
        Me.drawPurpleTriangle.Size = New System.Drawing.Size(149, 41)
        Me.drawPurpleTriangle.TabIndex = 17
        Me.drawPurpleTriangle.Text = "Draw Purple Triangle"
        Me.drawPurpleTriangle.UseVisualStyleBackColor = False
        '
        'DrawingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 514)
        Me.Controls.Add(Me.drawPurpleTriangle)
        Me.Controls.Add(Me.drawYellowCircleButton)
        Me.Controls.Add(Me.drawBlueEllipseButton)
        Me.Controls.Add(Me.drawGreenEllipseButton)
        Me.Controls.Add(Me.drawRedEllipseButton)
        Me.Controls.Add(Me.xValueLabel)
        Me.Controls.Add(Me.yValueLabel)
        Me.Controls.Add(Me.yTrackBar)
        Me.Controls.Add(Me.xTrackBar)
        Me.Controls.Add(Me.drawingAreaPictureBox)
        Me.Name = "DrawingForm"
        Me.Text = "Form1"
        CType(Me.yTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.drawingAreaPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents xValueLabel As System.Windows.Forms.Label
    Friend WithEvents yValueLabel As System.Windows.Forms.Label
    Friend WithEvents yTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents xTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents drawingAreaPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents drawBlueEllipseButton As System.Windows.Forms.Button
    Friend WithEvents drawGreenEllipseButton As System.Windows.Forms.Button
    Friend WithEvents drawRedEllipseButton As System.Windows.Forms.Button
    Friend WithEvents drawYellowCircleButton As System.Windows.Forms.Button
    Friend WithEvents drawPurpleTriangle As System.Windows.Forms.Button

End Class
