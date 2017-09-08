<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmailValidatorForm
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
        Me.inputTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inputLengthLabel = New System.Windows.Forms.Label()
        Me.resultLengthLabel = New System.Windows.Forms.Label()
        Me.validateButton = New System.Windows.Forms.Button()
        Me.validLabel = New System.Windows.Forms.Label()
        Me.invalidLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'inputTextBox
        '
        Me.inputTextBox.Location = New System.Drawing.Point(145, 12)
        Me.inputTextBox.Name = "inputTextBox"
        Me.inputTextBox.Size = New System.Drawing.Size(262, 20)
        Me.inputTextBox.TabIndex = 0
        Me.inputTextBox.Text = "simon.chester@port.ac.uk  "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Email address to validate:"
        '
        'inputLengthLabel
        '
        Me.inputLengthLabel.AutoSize = True
        Me.inputLengthLabel.Location = New System.Drawing.Point(387, 15)
        Me.inputLengthLabel.Name = "inputLengthLabel"
        Me.inputLengthLabel.Size = New System.Drawing.Size(0, 13)
        Me.inputLengthLabel.TabIndex = 4
        '
        'resultLengthLabel
        '
        Me.resultLengthLabel.AutoSize = True
        Me.resultLengthLabel.Location = New System.Drawing.Point(387, 159)
        Me.resultLengthLabel.Name = "resultLengthLabel"
        Me.resultLengthLabel.Size = New System.Drawing.Size(0, 13)
        Me.resultLengthLabel.TabIndex = 4
        '
        'validateButton
        '
        Me.validateButton.Location = New System.Drawing.Point(145, 38)
        Me.validateButton.Name = "validateButton"
        Me.validateButton.Size = New System.Drawing.Size(262, 23)
        Me.validateButton.TabIndex = 5
        Me.validateButton.Text = "Validate"
        Me.validateButton.UseVisualStyleBackColor = True
        '
        'validLabel
        '
        Me.validLabel.BackColor = System.Drawing.Color.LawnGreen
        Me.validLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.validLabel.Location = New System.Drawing.Point(166, 74)
        Me.validLabel.Name = "validLabel"
        Me.validLabel.Size = New System.Drawing.Size(106, 51)
        Me.validLabel.TabIndex = 6
        Me.validLabel.Text = "Valid"
        Me.validLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.validLabel.Visible = False
        '
        'invalidLabel
        '
        Me.invalidLabel.BackColor = System.Drawing.Color.Red
        Me.invalidLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invalidLabel.Location = New System.Drawing.Point(278, 74)
        Me.invalidLabel.Name = "invalidLabel"
        Me.invalidLabel.Size = New System.Drawing.Size(106, 51)
        Me.invalidLabel.TabIndex = 7
        Me.invalidLabel.Text = "Invalid"
        Me.invalidLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.invalidLabel.Visible = False
        '
        'EmailValidatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 145)
        Me.Controls.Add(Me.invalidLabel)
        Me.Controls.Add(Me.validLabel)
        Me.Controls.Add(Me.validateButton)
        Me.Controls.Add(Me.resultLengthLabel)
        Me.Controls.Add(Me.inputLengthLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.inputTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EmailValidatorForm"
        Me.Text = "Email Validator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents inputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents inputLengthLabel As System.Windows.Forms.Label
    Friend WithEvents resultLengthLabel As System.Windows.Forms.Label
    Friend WithEvents validateButton As System.Windows.Forms.Button
    Friend WithEvents validLabel As System.Windows.Forms.Label
    Friend WithEvents invalidLabel As System.Windows.Forms.Label

End Class
