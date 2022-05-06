<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiceGame
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
        Me.txtRisk = New System.Windows.Forms.TextBox()
        Me.picDiceOne = New System.Windows.Forms.PictureBox()
        Me.picDiceTwo = New System.Windows.Forms.PictureBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.cmdRollDice = New System.Windows.Forms.Button()
        Me.cmdEnd = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        CType(Me.picDiceOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDiceTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt.Location = New System.Drawing.Point(25, 28)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(145, 20)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter points to risk:"
        '
        'txtRisk
        '
        Me.txtRisk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRisk.Location = New System.Drawing.Point(176, 25)
        Me.txtRisk.Name = "txtRisk"
        Me.txtRisk.Size = New System.Drawing.Size(84, 26)
        Me.txtRisk.TabIndex = 1
        '
        'picDiceOne
        '
        Me.picDiceOne.Image = Global.DiceGame.Amin.My.Resources.Resources.Dice1
        Me.picDiceOne.Location = New System.Drawing.Point(48, 95)
        Me.picDiceOne.Name = "picDiceOne"
        Me.picDiceOne.Size = New System.Drawing.Size(75, 71)
        Me.picDiceOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDiceOne.TabIndex = 2
        Me.picDiceOne.TabStop = False
        '
        'picDiceTwo
        '
        Me.picDiceTwo.Image = Global.DiceGame.Amin.My.Resources.Resources.Dice1
        Me.picDiceTwo.Location = New System.Drawing.Point(166, 95)
        Me.picDiceTwo.Name = "picDiceTwo"
        Me.picDiceTwo.Size = New System.Drawing.Size(75, 71)
        Me.picDiceTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDiceTwo.TabIndex = 3
        Me.picDiceTwo.TabStop = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(25, 205)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 20)
        Me.lblTotal.TabIndex = 4
        '
        'cmdRollDice
        '
        Me.cmdRollDice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRollDice.Location = New System.Drawing.Point(29, 253)
        Me.cmdRollDice.Name = "cmdRollDice"
        Me.cmdRollDice.Size = New System.Drawing.Size(94, 40)
        Me.cmdRollDice.TabIndex = 5
        Me.cmdRollDice.Text = "Roll Dice"
        Me.cmdRollDice.UseVisualStyleBackColor = True
        '
        'cmdEnd
        '
        Me.cmdEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEnd.Location = New System.Drawing.Point(166, 253)
        Me.cmdEnd.Name = "cmdEnd"
        Me.cmdEnd.Size = New System.Drawing.Size(94, 40)
        Me.cmdEnd.TabIndex = 6
        Me.cmdEnd.Text = "End"
        Me.cmdEnd.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(286, 83)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(94, 94)
        Me.lblAnswer.TabIndex = 7
        '
        'frmDiceGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 326)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.cmdEnd)
        Me.Controls.Add(Me.cmdRollDice)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.picDiceTwo)
        Me.Controls.Add(Me.picDiceOne)
        Me.Controls.Add(Me.txtRisk)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "frmDiceGame"
        Me.Text = "Dice Game"
        CType(Me.picDiceOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDiceTwo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents txtRisk As System.Windows.Forms.TextBox
    Friend WithEvents picDiceOne As System.Windows.Forms.PictureBox
    Friend WithEvents picDiceTwo As System.Windows.Forms.PictureBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents cmdRollDice As System.Windows.Forms.Button
    Friend WithEvents cmdEnd As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label

End Class
