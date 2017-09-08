<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiceForm
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
        Me.die1NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.die2NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.die3NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rollDiceButton = New System.Windows.Forms.Button()
        Me.calculateWinningsButton = New System.Windows.Forms.Button()
        CType(Me.die1NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.die2NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.die3NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'die1NumericUpDown
        '
        Me.die1NumericUpDown.Location = New System.Drawing.Point(143, 12)
        Me.die1NumericUpDown.Name = "die1NumericUpDown"
        Me.die1NumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.die1NumericUpDown.TabIndex = 0
        '
        'die2NumericUpDown
        '
        Me.die2NumericUpDown.Location = New System.Drawing.Point(143, 38)
        Me.die2NumericUpDown.Name = "die2NumericUpDown"
        Me.die2NumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.die2NumericUpDown.TabIndex = 1
        '
        'die3NumericUpDown
        '
        Me.die3NumericUpDown.Location = New System.Drawing.Point(143, 65)
        Me.die3NumericUpDown.Name = "die3NumericUpDown"
        Me.die3NumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.die3NumericUpDown.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Die 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(98, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Die 2:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(98, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Die 3:"
        '
        'rollDiceButton
        '
        Me.rollDiceButton.Location = New System.Drawing.Point(12, 92)
        Me.rollDiceButton.Name = "rollDiceButton"
        Me.rollDiceButton.Size = New System.Drawing.Size(75, 23)
        Me.rollDiceButton.TabIndex = 6
        Me.rollDiceButton.Text = "Roll dice"
        Me.rollDiceButton.UseVisualStyleBackColor = True
        '
        'calculateWinningsButton
        '
        Me.calculateWinningsButton.Location = New System.Drawing.Point(12, 122)
        Me.calculateWinningsButton.Name = "calculateWinningsButton"
        Me.calculateWinningsButton.Size = New System.Drawing.Size(121, 23)
        Me.calculateWinningsButton.TabIndex = 7
        Me.calculateWinningsButton.Text = "Calculate Winnings"
        Me.calculateWinningsButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.calculateWinningsButton)
        Me.Controls.Add(Me.rollDiceButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.die3NumericUpDown)
        Me.Controls.Add(Me.die2NumericUpDown)
        Me.Controls.Add(Me.die1NumericUpDown)
        Me.Name = "Form1"
        Me.Text = "Betting"
        CType(Me.die1NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.die2NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.die3NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents die1NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents die2NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents die3NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rollDiceButton As System.Windows.Forms.Button
    Friend WithEvents calculateWinningsButton As System.Windows.Forms.Button

End Class
