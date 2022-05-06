<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSum
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
        Me.lblStartingNum = New System.Windows.Forms.Label()
        Me.lblEndingNum = New System.Windows.Forms.Label()
        Me.lblSum = New System.Windows.Forms.Label()
        Me.txtStartingNum = New System.Windows.Forms.TextBox()
        Me.txtEndingNum = New System.Windows.Forms.TextBox()
        Me.cmdCalculateSum = New System.Windows.Forms.Button()
        Me.cmdDone = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblStartingNum
        '
        Me.lblStartingNum.AutoSize = True
        Me.lblStartingNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartingNum.Location = New System.Drawing.Point(54, 39)
        Me.lblStartingNum.Name = "lblStartingNum"
        Me.lblStartingNum.Size = New System.Drawing.Size(163, 20)
        Me.lblStartingNum.TabIndex = 0
        Me.lblStartingNum.Text = "Enter starting number"
        '
        'lblEndingNum
        '
        Me.lblEndingNum.AutoSize = True
        Me.lblEndingNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndingNum.Location = New System.Drawing.Point(54, 96)
        Me.lblEndingNum.Name = "lblEndingNum"
        Me.lblEndingNum.Size = New System.Drawing.Size(158, 20)
        Me.lblEndingNum.TabIndex = 1
        Me.lblEndingNum.Text = "Enter ending number"
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSum.Location = New System.Drawing.Point(54, 190)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(0, 20)
        Me.lblSum.TabIndex = 2
        '
        'txtStartingNum
        '
        Me.txtStartingNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartingNum.Location = New System.Drawing.Point(240, 36)
        Me.txtStartingNum.Name = "txtStartingNum"
        Me.txtStartingNum.Size = New System.Drawing.Size(51, 26)
        Me.txtStartingNum.TabIndex = 3
        '
        'txtEndingNum
        '
        Me.txtEndingNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndingNum.Location = New System.Drawing.Point(240, 93)
        Me.txtEndingNum.Name = "txtEndingNum"
        Me.txtEndingNum.Size = New System.Drawing.Size(51, 26)
        Me.txtEndingNum.TabIndex = 4
        '
        'cmdCalculateSum
        '
        Me.cmdCalculateSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCalculateSum.Location = New System.Drawing.Point(58, 247)
        Me.cmdCalculateSum.Name = "cmdCalculateSum"
        Me.cmdCalculateSum.Size = New System.Drawing.Size(120, 28)
        Me.cmdCalculateSum.TabIndex = 5
        Me.cmdCalculateSum.Text = "Calculate Sum"
        Me.cmdCalculateSum.UseVisualStyleBackColor = True
        '
        'cmdDone
        '
        Me.cmdDone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDone.Location = New System.Drawing.Point(233, 247)
        Me.cmdDone.Name = "cmdDone"
        Me.cmdDone.Size = New System.Drawing.Size(58, 28)
        Me.cmdDone.TabIndex = 6
        Me.cmdDone.Text = "Done"
        Me.cmdDone.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter ending number"
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt.Location = New System.Drawing.Point(54, 154)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(0, 20)
        Me.lblPrompt.TabIndex = 7
        '
        'frmSum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 303)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.cmdDone)
        Me.Controls.Add(Me.cmdCalculateSum)
        Me.Controls.Add(Me.txtEndingNum)
        Me.Controls.Add(Me.txtStartingNum)
        Me.Controls.Add(Me.lblSum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblEndingNum)
        Me.Controls.Add(Me.lblStartingNum)
        Me.Name = "frmSum"
        Me.Text = "Sum"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStartingNum As System.Windows.Forms.Label
    Friend WithEvents lblEndingNum As System.Windows.Forms.Label
    Friend WithEvents lblSum As System.Windows.Forms.Label
    Friend WithEvents txtStartingNum As System.Windows.Forms.TextBox
    Friend WithEvents txtEndingNum As System.Windows.Forms.TextBox
    Friend WithEvents cmdCalculateSum As System.Windows.Forms.Button
    Friend WithEvents cmdDone As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPrompt As System.Windows.Forms.Label

End Class
