﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NamesForm
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
        Me.givenNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.familyNameTextBox = New System.Windows.Forms.TextBox()
        Me.middleNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.fullNameTextBox = New System.Windows.Forms.TextBox()
        Me.showWithoutMiddleButton = New System.Windows.Forms.Button()
        Me.showWithMiddleButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'givenNameTextBox
        '
        Me.givenNameTextBox.Location = New System.Drawing.Point(95, 10)
        Me.givenNameTextBox.Name = "givenNameTextBox"
        Me.givenNameTextBox.Size = New System.Drawing.Size(150, 20)
        Me.givenNameTextBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Given name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Family name:"
        '
        'familyNameTextBox
        '
        Me.familyNameTextBox.Location = New System.Drawing.Point(95, 62)
        Me.familyNameTextBox.Name = "familyNameTextBox"
        Me.familyNameTextBox.Size = New System.Drawing.Size(150, 20)
        Me.familyNameTextBox.TabIndex = 6
        '
        'middleNameTextBox
        '
        Me.middleNameTextBox.Location = New System.Drawing.Point(95, 36)
        Me.middleNameTextBox.Name = "middleNameTextBox"
        Me.middleNameTextBox.Size = New System.Drawing.Size(150, 20)
        Me.middleNameTextBox.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Middle name:"
        '
        'fullNameTextBox
        '
        Me.fullNameTextBox.Location = New System.Drawing.Point(95, 149)
        Me.fullNameTextBox.Name = "fullNameTextBox"
        Me.fullNameTextBox.ReadOnly = True
        Me.fullNameTextBox.Size = New System.Drawing.Size(150, 20)
        Me.fullNameTextBox.TabIndex = 11
        '
        'showWithoutMiddleButton
        '
        Me.showWithoutMiddleButton.Location = New System.Drawing.Point(15, 91)
        Me.showWithoutMiddleButton.Name = "showWithoutMiddleButton"
        Me.showWithoutMiddleButton.Size = New System.Drawing.Size(230, 23)
        Me.showWithoutMiddleButton.TabIndex = 12
        Me.showWithoutMiddleButton.Text = "Show full name (without middle name)"
        Me.showWithoutMiddleButton.UseVisualStyleBackColor = True
        '
        'showWithMiddleButton
        '
        Me.showWithMiddleButton.Location = New System.Drawing.Point(15, 120)
        Me.showWithMiddleButton.Name = "showWithMiddleButton"
        Me.showWithMiddleButton.Size = New System.Drawing.Size(230, 23)
        Me.showWithMiddleButton.TabIndex = 13
        Me.showWithMiddleButton.Text = "Show full name (with middle name)"
        Me.showWithMiddleButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Full name:"
        '
        'NamesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 186)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.showWithMiddleButton)
        Me.Controls.Add(Me.showWithoutMiddleButton)
        Me.Controls.Add(Me.fullNameTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.middleNameTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.familyNameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.givenNameTextBox)
        Me.Name = "NamesForm"
        Me.Text = "Names"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents givenNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents familyNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents middleNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents fullNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents showWithoutMiddleButton As System.Windows.Forms.Button
    Friend WithEvents showWithMiddleButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
