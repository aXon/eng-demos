<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarCounterForm
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
        Me.carInButton = New System.Windows.Forms.Button()
        Me.carOutButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.carCountNumericUpDown = New System.Windows.Forms.NumericUpDown()
        CType(Me.carCountNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'carInButton
        '
        Me.carInButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.carInButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.carInButton.Location = New System.Drawing.Point(12, 12)
        Me.carInButton.Name = "carInButton"
        Me.carInButton.Size = New System.Drawing.Size(97, 62)
        Me.carInButton.TabIndex = 0
        Me.carInButton.Text = "Car In"
        Me.carInButton.UseVisualStyleBackColor = False
        '
        'carOutButton
        '
        Me.carOutButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.carOutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.carOutButton.Location = New System.Drawing.Point(115, 12)
        Me.carOutButton.Name = "carOutButton"
        Me.carOutButton.Size = New System.Drawing.Size(97, 62)
        Me.carOutButton.TabIndex = 1
        Me.carOutButton.Text = "Car Out"
        Me.carOutButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cars currently in Car Park:"
        '
        'carCountNumericUpDown
        '
        Me.carCountNumericUpDown.Location = New System.Drawing.Point(147, 86)
        Me.carCountNumericUpDown.Name = "carCountNumericUpDown"
        Me.carCountNumericUpDown.ReadOnly = True
        Me.carCountNumericUpDown.Size = New System.Drawing.Size(65, 20)
        Me.carCountNumericUpDown.TabIndex = 3
        '
        'CarCounterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(223, 126)
        Me.Controls.Add(Me.carCountNumericUpDown)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.carOutButton)
        Me.Controls.Add(Me.carInButton)
        Me.Name = "CarCounterForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Car Park Counter"
        CType(Me.carCountNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents carInButton As System.Windows.Forms.Button
    Friend WithEvents carOutButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents carCountNumericUpDown As System.Windows.Forms.NumericUpDown

End Class
