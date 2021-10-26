<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuessingGame
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
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.lblGuess = New System.Windows.Forms.Label()
        Me.txtGuess = New System.Windows.Forms.TextBox()
        Me.lblGuessCheckedMessage = New System.Windows.Forms.Label()
        Me.cmdCheckGusess = New System.Windows.Forms.Button()
        Me.cmdEnd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt.Location = New System.Drawing.Point(26, 34)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(318, 25)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Guess a number between 1 - 10"
        '
        'lblGuess
        '
        Me.lblGuess.AutoSize = True
        Me.lblGuess.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuess.Location = New System.Drawing.Point(60, 97)
        Me.lblGuess.Name = "lblGuess"
        Me.lblGuess.Size = New System.Drawing.Size(109, 25)
        Me.lblGuess.TabIndex = 1
        Me.lblGuess.Text = "My Guess"
        '
        'txtGuess
        '
        Me.txtGuess.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuess.Location = New System.Drawing.Point(191, 94)
        Me.txtGuess.Name = "txtGuess"
        Me.txtGuess.Size = New System.Drawing.Size(100, 31)
        Me.txtGuess.TabIndex = 2
        '
        'lblGuessCheckedMessage
        '
        Me.lblGuessCheckedMessage.AutoSize = True
        Me.lblGuessCheckedMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuessCheckedMessage.Location = New System.Drawing.Point(21, 160)
        Me.lblGuessCheckedMessage.Name = "lblGuessCheckedMessage"
        Me.lblGuessCheckedMessage.Size = New System.Drawing.Size(0, 25)
        Me.lblGuessCheckedMessage.TabIndex = 3
        '
        'cmdCheckGusess
        '
        Me.cmdCheckGusess.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCheckGusess.Location = New System.Drawing.Point(230, 211)
        Me.cmdCheckGusess.Name = "cmdCheckGusess"
        Me.cmdCheckGusess.Size = New System.Drawing.Size(114, 31)
        Me.cmdCheckGusess.TabIndex = 4
        Me.cmdCheckGusess.Text = "Check Guess"
        Me.cmdCheckGusess.UseVisualStyleBackColor = True
        '
        'cmdEnd
        '
        Me.cmdEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEnd.Location = New System.Drawing.Point(230, 248)
        Me.cmdEnd.Name = "cmdEnd"
        Me.cmdEnd.Size = New System.Drawing.Size(114, 31)
        Me.cmdEnd.TabIndex = 5
        Me.cmdEnd.Text = "End"
        Me.cmdEnd.UseVisualStyleBackColor = True
        '
        'frmGuessingGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 287)
        Me.Controls.Add(Me.cmdEnd)
        Me.Controls.Add(Me.cmdCheckGusess)
        Me.Controls.Add(Me.lblGuessCheckedMessage)
        Me.Controls.Add(Me.txtGuess)
        Me.Controls.Add(Me.lblGuess)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "frmGuessingGame"
        Me.Text = "Guessing Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents lblGuess As System.Windows.Forms.Label
    Friend WithEvents txtGuess As System.Windows.Forms.TextBox
    Friend WithEvents lblGuessCheckedMessage As System.Windows.Forms.Label
    Friend WithEvents cmdCheckGusess As System.Windows.Forms.Button
    Friend WithEvents cmdEnd As System.Windows.Forms.Button

End Class
