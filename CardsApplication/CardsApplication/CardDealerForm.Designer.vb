<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CardDealerForm
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
        Me.components = New System.ComponentModel.Container()
        Me.playingSurfacePictureBox = New System.Windows.Forms.PictureBox()
        Me.dealButton = New System.Windows.Forms.Button()
        Me.cardCountTrackBar = New System.Windows.Forms.TrackBar()
        Me.showNextCardTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.playingSurfacePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cardCountTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'playingSurfacePictureBox
        '
        Me.playingSurfacePictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.playingSurfacePictureBox.BackColor = System.Drawing.Color.DarkGreen
        Me.playingSurfacePictureBox.Location = New System.Drawing.Point(12, 12)
        Me.playingSurfacePictureBox.Name = "playingSurfacePictureBox"
        Me.playingSurfacePictureBox.Size = New System.Drawing.Size(660, 390)
        Me.playingSurfacePictureBox.TabIndex = 0
        Me.playingSurfacePictureBox.TabStop = False
        '
        'dealButton
        '
        Me.dealButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dealButton.Location = New System.Drawing.Point(527, 472)
        Me.dealButton.Name = "dealButton"
        Me.dealButton.Size = New System.Drawing.Size(145, 42)
        Me.dealButton.TabIndex = 1
        Me.dealButton.Text = "Deal"
        Me.dealButton.UseVisualStyleBackColor = True
        '
        'cardCountTrackBar
        '
        Me.cardCountTrackBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cardCountTrackBar.Location = New System.Drawing.Point(12, 408)
        Me.cardCountTrackBar.Name = "cardCountTrackBar"
        Me.cardCountTrackBar.Size = New System.Drawing.Size(660, 45)
        Me.cardCountTrackBar.TabIndex = 2
        Me.cardCountTrackBar.Value = 7
        '
        'showNextCardTimer
        '
        Me.showNextCardTimer.Interval = 500
        '
        'CardDealerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 526)
        Me.Controls.Add(Me.cardCountTrackBar)
        Me.Controls.Add(Me.dealButton)
        Me.Controls.Add(Me.playingSurfacePictureBox)
        Me.Name = "CardDealerForm"
        Me.Text = "Cards"
        CType(Me.playingSurfacePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cardCountTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents playingSurfacePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents dealButton As System.Windows.Forms.Button
    Friend WithEvents cardCountTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents showNextCardTimer As System.Windows.Forms.Timer

End Class
