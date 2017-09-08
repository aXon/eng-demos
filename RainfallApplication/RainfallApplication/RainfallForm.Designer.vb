<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RainfallForm
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
        Me.doItButton = New System.Windows.Forms.Button()
        Me.outputTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'doItButton
        '
        Me.doItButton.Location = New System.Drawing.Point(27, 22)
        Me.doItButton.Name = "doItButton"
        Me.doItButton.Size = New System.Drawing.Size(75, 23)
        Me.doItButton.TabIndex = 0
        Me.doItButton.Text = "Do it!"
        Me.doItButton.UseVisualStyleBackColor = True
        '
        'outputTextBox
        '
        Me.outputTextBox.Location = New System.Drawing.Point(27, 63)
        Me.outputTextBox.Multiline = True
        Me.outputTextBox.Name = "outputTextBox"
        Me.outputTextBox.Size = New System.Drawing.Size(245, 187)
        Me.outputTextBox.TabIndex = 1
        '
        'RainfallForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 380)
        Me.Controls.Add(Me.outputTextBox)
        Me.Controls.Add(Me.doItButton)
        Me.Name = "RainfallForm"
        Me.Text = "UK Rainfall"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents doItButton As System.Windows.Forms.Button
    Friend WithEvents outputTextBox As System.Windows.Forms.TextBox

End Class
