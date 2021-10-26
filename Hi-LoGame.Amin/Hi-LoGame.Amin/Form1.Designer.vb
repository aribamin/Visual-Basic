<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHiLoGame
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
        Me.cmdHigh = New System.Windows.Forms.Button()
        Me.cmdLow = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.cmdDone = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt.Location = New System.Drawing.Point(30, 26)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(145, 20)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter points to risk:"
        '
        'txtRisk
        '
        Me.txtRisk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRisk.Location = New System.Drawing.Point(188, 23)
        Me.txtRisk.Name = "txtRisk"
        Me.txtRisk.Size = New System.Drawing.Size(100, 26)
        Me.txtRisk.TabIndex = 1
        '
        'cmdHigh
        '
        Me.cmdHigh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHigh.Location = New System.Drawing.Point(78, 74)
        Me.cmdHigh.Name = "cmdHigh"
        Me.cmdHigh.Size = New System.Drawing.Size(92, 35)
        Me.cmdHigh.TabIndex = 2
        Me.cmdHigh.Text = "High"
        Me.cmdHigh.UseVisualStyleBackColor = True
        '
        'cmdLow
        '
        Me.cmdLow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLow.Location = New System.Drawing.Point(188, 74)
        Me.cmdLow.Name = "cmdLow"
        Me.cmdLow.Size = New System.Drawing.Size(92, 35)
        Me.cmdLow.TabIndex = 3
        Me.cmdLow.Text = "Low"
        Me.cmdLow.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(30, 137)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 20)
        Me.lblAnswer.TabIndex = 4
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(30, 176)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 20)
        Me.lblTotal.TabIndex = 5
        '
        'cmdDone
        '
        Me.cmdDone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDone.Location = New System.Drawing.Point(291, 197)
        Me.cmdDone.Name = "cmdDone"
        Me.cmdDone.Size = New System.Drawing.Size(92, 35)
        Me.cmdDone.TabIndex = 6
        Me.cmdDone.Text = "Done"
        Me.cmdDone.UseVisualStyleBackColor = True
        '
        'frmHiLoGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 244)
        Me.Controls.Add(Me.cmdDone)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.cmdLow)
        Me.Controls.Add(Me.cmdHigh)
        Me.Controls.Add(Me.txtRisk)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "frmHiLoGame"
        Me.Text = "Hi-Lo Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents txtRisk As System.Windows.Forms.TextBox
    Friend WithEvents cmdHigh As System.Windows.Forms.Button
    Friend WithEvents cmdLow As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents cmdDone As System.Windows.Forms.Button

End Class
