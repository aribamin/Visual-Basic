<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculator2
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
        Me.lblFirstNumber = New System.Windows.Forms.Label()
        Me.txtFirstNumber = New System.Windows.Forms.TextBox()
        Me.lblSecondNumber = New System.Windows.Forms.Label()
        Me.txtSecondNumber = New System.Windows.Forms.TextBox()
        Me.radAdd = New System.Windows.Forms.RadioButton()
        Me.radSubtract = New System.Windows.Forms.RadioButton()
        Me.radMultiply = New System.Windows.Forms.RadioButton()
        Me.radDivide = New System.Windows.Forms.RadioButton()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.cmdEnd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFirstNumber
        '
        Me.lblFirstNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstNumber.Location = New System.Drawing.Point(24, 58)
        Me.lblFirstNumber.Name = "lblFirstNumber"
        Me.lblFirstNumber.Size = New System.Drawing.Size(105, 21)
        Me.lblFirstNumber.TabIndex = 0
        Me.lblFirstNumber.Text = "First Number:"
        '
        'txtFirstNumber
        '
        Me.txtFirstNumber.Location = New System.Drawing.Point(131, 59)
        Me.txtFirstNumber.Name = "txtFirstNumber"
        Me.txtFirstNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstNumber.TabIndex = 1
        '
        'lblSecondNumber
        '
        Me.lblSecondNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecondNumber.Location = New System.Drawing.Point(268, 57)
        Me.lblSecondNumber.Name = "lblSecondNumber"
        Me.lblSecondNumber.Size = New System.Drawing.Size(128, 21)
        Me.lblSecondNumber.TabIndex = 2
        Me.lblSecondNumber.Text = "Second Number:"
        '
        'txtSecondNumber
        '
        Me.txtSecondNumber.Location = New System.Drawing.Point(402, 60)
        Me.txtSecondNumber.Name = "txtSecondNumber"
        Me.txtSecondNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtSecondNumber.TabIndex = 3
        '
        'radAdd
        '
        Me.radAdd.AutoSize = True
        Me.radAdd.Location = New System.Drawing.Point(28, 146)
        Me.radAdd.Name = "radAdd"
        Me.radAdd.Size = New System.Drawing.Size(59, 17)
        Me.radAdd.TabIndex = 4
        Me.radAdd.TabStop = True
        Me.radAdd.Text = "(+) Add"
        Me.radAdd.UseVisualStyleBackColor = True
        '
        'radSubtract
        '
        Me.radSubtract.AutoSize = True
        Me.radSubtract.Location = New System.Drawing.Point(131, 146)
        Me.radSubtract.Name = "radSubtract"
        Me.radSubtract.Size = New System.Drawing.Size(77, 17)
        Me.radSubtract.TabIndex = 5
        Me.radSubtract.TabStop = True
        Me.radSubtract.Text = "(-) Subtract"
        Me.radSubtract.UseVisualStyleBackColor = True
        '
        'radMultiply
        '
        Me.radMultiply.AutoSize = True
        Me.radMultiply.Location = New System.Drawing.Point(272, 146)
        Me.radMultiply.Name = "radMultiply"
        Me.radMultiply.Size = New System.Drawing.Size(74, 17)
        Me.radMultiply.TabIndex = 6
        Me.radMultiply.TabStop = True
        Me.radMultiply.Text = "(x) Multiply"
        Me.radMultiply.UseVisualStyleBackColor = True
        '
        'radDivide
        '
        Me.radDivide.AutoSize = True
        Me.radDivide.Location = New System.Drawing.Point(402, 146)
        Me.radDivide.Name = "radDivide"
        Me.radDivide.Size = New System.Drawing.Size(69, 17)
        Me.radDivide.TabIndex = 7
        Me.radDivide.TabStop = True
        Me.radDivide.Text = "(/) Divide"
        Me.radDivide.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(28, 224)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(206, 40)
        Me.lblAnswer.TabIndex = 8
        '
        'cmdEnd
        '
        Me.cmdEnd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdEnd.Location = New System.Drawing.Point(427, 241)
        Me.cmdEnd.Name = "cmdEnd"
        Me.cmdEnd.Size = New System.Drawing.Size(75, 23)
        Me.cmdEnd.TabIndex = 9
        Me.cmdEnd.Text = "End"
        Me.cmdEnd.UseVisualStyleBackColor = True
        '
        'frmCalculator2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 314)
        Me.Controls.Add(Me.cmdEnd)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.radDivide)
        Me.Controls.Add(Me.radMultiply)
        Me.Controls.Add(Me.radSubtract)
        Me.Controls.Add(Me.radAdd)
        Me.Controls.Add(Me.txtSecondNumber)
        Me.Controls.Add(Me.lblSecondNumber)
        Me.Controls.Add(Me.txtFirstNumber)
        Me.Controls.Add(Me.lblFirstNumber)
        Me.Name = "frmCalculator2"
        Me.Text = "Calculator 2.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFirstNumber As System.Windows.Forms.Label
    Friend WithEvents txtFirstNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblSecondNumber As System.Windows.Forms.Label
    Friend WithEvents txtSecondNumber As System.Windows.Forms.TextBox
    Friend WithEvents radAdd As System.Windows.Forms.RadioButton
    Friend WithEvents radSubtract As System.Windows.Forms.RadioButton
    Friend WithEvents radMultiply As System.Windows.Forms.RadioButton
    Friend WithEvents radDivide As System.Windows.Forms.RadioButton
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents cmdEnd As System.Windows.Forms.Button

End Class
