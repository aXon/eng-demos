<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculatorForm
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
        Me.displayTextBox = New System.Windows.Forms.TextBox()
        Me.num1Button = New System.Windows.Forms.Button()
        Me.num2Button = New System.Windows.Forms.Button()
        Me.num3Button = New System.Windows.Forms.Button()
        Me.num4Button = New System.Windows.Forms.Button()
        Me.num5Button = New System.Windows.Forms.Button()
        Me.num6Button = New System.Windows.Forms.Button()
        Me.num7Button = New System.Windows.Forms.Button()
        Me.num8Button = New System.Windows.Forms.Button()
        Me.num9Button = New System.Windows.Forms.Button()
        Me.num0Button = New System.Windows.Forms.Button()
        Me.plusButton = New System.Windows.Forms.Button()
        Me.minusButton = New System.Windows.Forms.Button()
        Me.equalsButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'displayTextBox
        '
        Me.displayTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.displayTextBox.BackColor = System.Drawing.Color.White
        Me.displayTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displayTextBox.Location = New System.Drawing.Point(13, 13)
        Me.displayTextBox.Name = "displayTextBox"
        Me.displayTextBox.ReadOnly = True
        Me.displayTextBox.Size = New System.Drawing.Size(212, 31)
        Me.displayTextBox.TabIndex = 0
        Me.displayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'num1Button
        '
        Me.num1Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num1Button.Location = New System.Drawing.Point(13, 67)
        Me.num1Button.Name = "num1Button"
        Me.num1Button.Size = New System.Drawing.Size(46, 41)
        Me.num1Button.TabIndex = 1
        Me.num1Button.Text = "&1"
        Me.num1Button.UseVisualStyleBackColor = True
        '
        'num2Button
        '
        Me.num2Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num2Button.Location = New System.Drawing.Point(65, 67)
        Me.num2Button.Name = "num2Button"
        Me.num2Button.Size = New System.Drawing.Size(46, 41)
        Me.num2Button.TabIndex = 2
        Me.num2Button.Text = "&2"
        Me.num2Button.UseVisualStyleBackColor = True
        '
        'num3Button
        '
        Me.num3Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num3Button.Location = New System.Drawing.Point(117, 67)
        Me.num3Button.Name = "num3Button"
        Me.num3Button.Size = New System.Drawing.Size(46, 41)
        Me.num3Button.TabIndex = 3
        Me.num3Button.Text = "&3"
        Me.num3Button.UseVisualStyleBackColor = True
        '
        'num4Button
        '
        Me.num4Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num4Button.Location = New System.Drawing.Point(13, 114)
        Me.num4Button.Name = "num4Button"
        Me.num4Button.Size = New System.Drawing.Size(46, 41)
        Me.num4Button.TabIndex = 3
        Me.num4Button.Text = "&4"
        Me.num4Button.UseVisualStyleBackColor = True
        '
        'num5Button
        '
        Me.num5Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num5Button.Location = New System.Drawing.Point(65, 114)
        Me.num5Button.Name = "num5Button"
        Me.num5Button.Size = New System.Drawing.Size(46, 41)
        Me.num5Button.TabIndex = 3
        Me.num5Button.Text = "&5"
        Me.num5Button.UseVisualStyleBackColor = True
        '
        'num6Button
        '
        Me.num6Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num6Button.Location = New System.Drawing.Point(117, 114)
        Me.num6Button.Name = "num6Button"
        Me.num6Button.Size = New System.Drawing.Size(46, 41)
        Me.num6Button.TabIndex = 3
        Me.num6Button.Text = "&6"
        Me.num6Button.UseVisualStyleBackColor = True
        '
        'num7Button
        '
        Me.num7Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num7Button.Location = New System.Drawing.Point(13, 161)
        Me.num7Button.Name = "num7Button"
        Me.num7Button.Size = New System.Drawing.Size(46, 41)
        Me.num7Button.TabIndex = 3
        Me.num7Button.Text = "&7"
        Me.num7Button.UseVisualStyleBackColor = True
        '
        'num8Button
        '
        Me.num8Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num8Button.Location = New System.Drawing.Point(65, 161)
        Me.num8Button.Name = "num8Button"
        Me.num8Button.Size = New System.Drawing.Size(46, 41)
        Me.num8Button.TabIndex = 3
        Me.num8Button.Text = "&8"
        Me.num8Button.UseVisualStyleBackColor = True
        '
        'num9Button
        '
        Me.num9Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num9Button.Location = New System.Drawing.Point(117, 161)
        Me.num9Button.Name = "num9Button"
        Me.num9Button.Size = New System.Drawing.Size(46, 41)
        Me.num9Button.TabIndex = 3
        Me.num9Button.Text = "&9"
        Me.num9Button.UseVisualStyleBackColor = True
        '
        'num0Button
        '
        Me.num0Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num0Button.Location = New System.Drawing.Point(13, 208)
        Me.num0Button.Name = "num0Button"
        Me.num0Button.Size = New System.Drawing.Size(46, 41)
        Me.num0Button.TabIndex = 3
        Me.num0Button.Text = "&0"
        Me.num0Button.UseVisualStyleBackColor = True
        '
        'plusButton
        '
        Me.plusButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plusButton.Location = New System.Drawing.Point(178, 114)
        Me.plusButton.Name = "plusButton"
        Me.plusButton.Size = New System.Drawing.Size(46, 41)
        Me.plusButton.TabIndex = 3
        Me.plusButton.Text = "&+"
        Me.plusButton.UseVisualStyleBackColor = True
        '
        'minusButton
        '
        Me.minusButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minusButton.Location = New System.Drawing.Point(178, 161)
        Me.minusButton.Name = "minusButton"
        Me.minusButton.Size = New System.Drawing.Size(46, 41)
        Me.minusButton.TabIndex = 3
        Me.minusButton.Text = "&-"
        Me.minusButton.UseVisualStyleBackColor = True
        '
        'equalsButton
        '
        Me.equalsButton.Enabled = False
        Me.equalsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.equalsButton.Location = New System.Drawing.Point(117, 208)
        Me.equalsButton.Name = "equalsButton"
        Me.equalsButton.Size = New System.Drawing.Size(107, 41)
        Me.equalsButton.TabIndex = 3
        Me.equalsButton.Text = "&="
        Me.equalsButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(178, 67)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(46, 41)
        Me.clearButton.TabIndex = 3
        Me.clearButton.Text = "&C"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'CalculatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(237, 268)
        Me.Controls.Add(Me.num0Button)
        Me.Controls.Add(Me.num9Button)
        Me.Controls.Add(Me.num8Button)
        Me.Controls.Add(Me.num7Button)
        Me.Controls.Add(Me.num6Button)
        Me.Controls.Add(Me.num5Button)
        Me.Controls.Add(Me.num4Button)
        Me.Controls.Add(Me.equalsButton)
        Me.Controls.Add(Me.minusButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.plusButton)
        Me.Controls.Add(Me.num3Button)
        Me.Controls.Add(Me.num2Button)
        Me.Controls.Add(Me.num1Button)
        Me.Controls.Add(Me.displayTextBox)
        Me.Name = "CalculatorForm"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents displayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents num1Button As System.Windows.Forms.Button
    Friend WithEvents num2Button As System.Windows.Forms.Button
    Friend WithEvents num3Button As System.Windows.Forms.Button
    Friend WithEvents num4Button As System.Windows.Forms.Button
    Friend WithEvents num5Button As System.Windows.Forms.Button
    Friend WithEvents num6Button As System.Windows.Forms.Button
    Friend WithEvents num7Button As System.Windows.Forms.Button
    Friend WithEvents num8Button As System.Windows.Forms.Button
    Friend WithEvents num9Button As System.Windows.Forms.Button
    Friend WithEvents num0Button As System.Windows.Forms.Button
    Friend WithEvents plusButton As System.Windows.Forms.Button
    Friend WithEvents minusButton As System.Windows.Forms.Button
    Friend WithEvents equalsButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button

End Class
