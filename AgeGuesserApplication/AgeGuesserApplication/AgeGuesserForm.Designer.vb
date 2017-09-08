<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgeGuesserForm
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
        Me.yesButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.guessLabel = New System.Windows.Forms.Label()
        Me.noButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'yesButton
        '
        Me.yesButton.Location = New System.Drawing.Point(16, 93)
        Me.yesButton.Name = "yesButton"
        Me.yesButton.Size = New System.Drawing.Size(122, 41)
        Me.yesButton.TabIndex = 0
        Me.yesButton.Text = "&Yes, that's right!"
        Me.yesButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "The computer guesses that you are:"
        '
        'guessLabel
        '
        Me.guessLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guessLabel.Location = New System.Drawing.Point(16, 43)
        Me.guessLabel.Name = "guessLabel"
        Me.guessLabel.Size = New System.Drawing.Size(259, 23)
        Me.guessLabel.TabIndex = 2
        Me.guessLabel.Text = "???"
        Me.guessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'noButton
        '
        Me.noButton.Location = New System.Drawing.Point(144, 93)
        Me.noButton.Name = "noButton"
        Me.noButton.Size = New System.Drawing.Size(131, 41)
        Me.noButton.TabIndex = 3
        Me.noButton.Text = "&No.  Try again."
        Me.noButton.UseVisualStyleBackColor = True
        '
        'AgeGuesserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 151)
        Me.Controls.Add(Me.noButton)
        Me.Controls.Add(Me.guessLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.yesButton)
        Me.MaximizeBox = False
        Me.Name = "AgeGuesserForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Age Guesser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents yesButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents guessLabel As System.Windows.Forms.Label
    Friend WithEvents noButton As System.Windows.Forms.Button

End Class
