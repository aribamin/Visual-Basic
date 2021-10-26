<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlotMachine
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
        Me.lblRandomNum1 = New System.Windows.Forms.Label()
        Me.lblRandomNum2 = New System.Windows.Forms.Label()
        Me.lblRandomNum3 = New System.Windows.Forms.Label()
        Me.radPull = New System.Windows.Forms.Button()
        Me.radDone = New System.Windows.Forms.Button()
        Me.lblTokensLeft = New System.Windows.Forms.Label()
        Me.lblTokens = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblRandomNum1
        '
        Me.lblRandomNum1.AutoSize = True
        Me.lblRandomNum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRandomNum1.Location = New System.Drawing.Point(67, 80)
        Me.lblRandomNum1.Name = "lblRandomNum1"
        Me.lblRandomNum1.Size = New System.Drawing.Size(0, 73)
        Me.lblRandomNum1.TabIndex = 0
        '
        'lblRandomNum2
        '
        Me.lblRandomNum2.AutoSize = True
        Me.lblRandomNum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRandomNum2.Location = New System.Drawing.Point(238, 80)
        Me.lblRandomNum2.Name = "lblRandomNum2"
        Me.lblRandomNum2.Size = New System.Drawing.Size(0, 73)
        Me.lblRandomNum2.TabIndex = 1
        '
        'lblRandomNum3
        '
        Me.lblRandomNum3.AutoSize = True
        Me.lblRandomNum3.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRandomNum3.Location = New System.Drawing.Point(408, 80)
        Me.lblRandomNum3.Name = "lblRandomNum3"
        Me.lblRandomNum3.Size = New System.Drawing.Size(0, 73)
        Me.lblRandomNum3.TabIndex = 2
        '
        'radPull
        '
        Me.radPull.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.radPull.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPull.Location = New System.Drawing.Point(106, 304)
        Me.radPull.Name = "radPull"
        Me.radPull.Size = New System.Drawing.Size(101, 26)
        Me.radPull.TabIndex = 3
        Me.radPull.Text = "Pull"
        Me.radPull.UseVisualStyleBackColor = True
        '
        'radDone
        '
        Me.radDone.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.radDone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDone.Location = New System.Drawing.Point(338, 304)
        Me.radDone.Name = "radDone"
        Me.radDone.Size = New System.Drawing.Size(101, 26)
        Me.radDone.TabIndex = 4
        Me.radDone.Text = "Done"
        Me.radDone.UseVisualStyleBackColor = True
        '
        'lblTokensLeft
        '
        Me.lblTokensLeft.AutoSize = True
        Me.lblTokensLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTokensLeft.Location = New System.Drawing.Point(65, 216)
        Me.lblTokensLeft.Name = "lblTokensLeft"
        Me.lblTokensLeft.Size = New System.Drawing.Size(342, 37)
        Me.lblTokensLeft.TabIndex = 5
        Me.lblTokensLeft.Text = "Tokens You Have Left:"
        '
        'lblTokens
        '
        Me.lblTokens.AutoSize = True
        Me.lblTokens.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTokens.Location = New System.Drawing.Point(413, 216)
        Me.lblTokens.Name = "lblTokens"
        Me.lblTokens.Size = New System.Drawing.Size(69, 37)
        Me.lblTokens.TabIndex = 6
        Me.lblTokens.Text = "100"
        '
        'frmSlotMachine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 358)
        Me.Controls.Add(Me.lblTokens)
        Me.Controls.Add(Me.lblTokensLeft)
        Me.Controls.Add(Me.radDone)
        Me.Controls.Add(Me.radPull)
        Me.Controls.Add(Me.lblRandomNum3)
        Me.Controls.Add(Me.lblRandomNum2)
        Me.Controls.Add(Me.lblRandomNum1)
        Me.Name = "frmSlotMachine"
        Me.Text = "Slot Machine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRandomNum1 As System.Windows.Forms.Label
    Friend WithEvents lblRandomNum2 As System.Windows.Forms.Label
    Friend WithEvents lblRandomNum3 As System.Windows.Forms.Label
    Friend WithEvents radPull As System.Windows.Forms.Button
    Friend WithEvents radDone As System.Windows.Forms.Button
    Friend WithEvents lblTokensLeft As System.Windows.Forms.Label
    Friend WithEvents lblTokens As System.Windows.Forms.Label

End Class
