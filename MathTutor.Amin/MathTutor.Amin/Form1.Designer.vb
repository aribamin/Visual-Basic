<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMathTutor
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
        Me.cmdNewProblem = New System.Windows.Forms.Button()
        Me.cmdCheckAnswer = New System.Windows.Forms.Button()
        Me.cmdEnd = New System.Windows.Forms.Button()
        Me.lblNumberOne = New System.Windows.Forms.Label()
        Me.lblOperator = New System.Windows.Forms.Label()
        Me.lblNumberTwo = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.radNormal = New System.Windows.Forms.RadioButton()
        Me.radDifficult = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'cmdNewProblem
        '
        Me.cmdNewProblem.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdNewProblem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdNewProblem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNewProblem.Location = New System.Drawing.Point(472, 25)
        Me.cmdNewProblem.Name = "cmdNewProblem"
        Me.cmdNewProblem.Size = New System.Drawing.Size(120, 42)
        Me.cmdNewProblem.TabIndex = 0
        Me.cmdNewProblem.Text = "New Problem"
        Me.cmdNewProblem.UseVisualStyleBackColor = False
        '
        'cmdCheckAnswer
        '
        Me.cmdCheckAnswer.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdCheckAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCheckAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCheckAnswer.Location = New System.Drawing.Point(472, 116)
        Me.cmdCheckAnswer.Name = "cmdCheckAnswer"
        Me.cmdCheckAnswer.Size = New System.Drawing.Size(120, 42)
        Me.cmdCheckAnswer.TabIndex = 1
        Me.cmdCheckAnswer.Text = "Check Answer"
        Me.cmdCheckAnswer.UseVisualStyleBackColor = False
        '
        'cmdEnd
        '
        Me.cmdEnd.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdEnd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEnd.Location = New System.Drawing.Point(472, 211)
        Me.cmdEnd.Name = "cmdEnd"
        Me.cmdEnd.Size = New System.Drawing.Size(120, 42)
        Me.cmdEnd.TabIndex = 2
        Me.cmdEnd.Text = "End"
        Me.cmdEnd.UseVisualStyleBackColor = False
        '
        'lblNumberOne
        '
        Me.lblNumberOne.AutoSize = True
        Me.lblNumberOne.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNumberOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumberOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOne.Location = New System.Drawing.Point(37, 49)
        Me.lblNumberOne.Name = "lblNumberOne"
        Me.lblNumberOne.Size = New System.Drawing.Size(2, 33)
        Me.lblNumberOne.TabIndex = 3
        '
        'lblOperator
        '
        Me.lblOperator.AutoSize = True
        Me.lblOperator.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblOperator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOperator.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperator.Location = New System.Drawing.Point(165, 49)
        Me.lblOperator.Name = "lblOperator"
        Me.lblOperator.Size = New System.Drawing.Size(2, 33)
        Me.lblOperator.TabIndex = 4
        '
        'lblNumberTwo
        '
        Me.lblNumberTwo.AutoSize = True
        Me.lblNumberTwo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNumberTwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumberTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberTwo.Location = New System.Drawing.Point(289, 49)
        Me.lblNumberTwo.Name = "lblNumberTwo"
        Me.lblNumberTwo.Size = New System.Drawing.Size(2, 33)
        Me.lblNumberTwo.TabIndex = 5
        '
        'txtAnswer
        '
        Me.txtAnswer.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.Location = New System.Drawing.Point(394, 46)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(52, 38)
        Me.txtAnswer.TabIndex = 6
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPrompt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt.Location = New System.Drawing.Point(37, 142)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(2, 33)
        Me.lblPrompt.TabIndex = 7
        '
        'radNormal
        '
        Me.radNormal.AutoSize = True
        Me.radNormal.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radNormal.Checked = True
        Me.radNormal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.radNormal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radNormal.Location = New System.Drawing.Point(264, 229)
        Me.radNormal.Name = "radNormal"
        Me.radNormal.Size = New System.Drawing.Size(76, 24)
        Me.radNormal.TabIndex = 8
        Me.radNormal.TabStop = True
        Me.radNormal.Text = "Normal"
        Me.radNormal.UseVisualStyleBackColor = False
        '
        'radDifficult
        '
        Me.radDifficult.AutoSize = True
        Me.radDifficult.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radDifficult.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.radDifficult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDifficult.Location = New System.Drawing.Point(366, 229)
        Me.radDifficult.Name = "radDifficult"
        Me.radDifficult.Size = New System.Drawing.Size(79, 24)
        Me.radDifficult.TabIndex = 9
        Me.radDifficult.TabStop = True
        Me.radDifficult.Text = "Difficult"
        Me.radDifficult.UseVisualStyleBackColor = False
        '
        'frmMathTutor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(617, 274)
        Me.Controls.Add(Me.radDifficult)
        Me.Controls.Add(Me.radNormal)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.lblNumberTwo)
        Me.Controls.Add(Me.lblOperator)
        Me.Controls.Add(Me.lblNumberOne)
        Me.Controls.Add(Me.cmdEnd)
        Me.Controls.Add(Me.cmdCheckAnswer)
        Me.Controls.Add(Me.cmdNewProblem)
        Me.Name = "frmMathTutor"
        Me.Text = "Math Tutor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdNewProblem As System.Windows.Forms.Button
    Friend WithEvents cmdCheckAnswer As System.Windows.Forms.Button
    Friend WithEvents cmdEnd As System.Windows.Forms.Button
    Friend WithEvents lblNumberOne As System.Windows.Forms.Label
    Friend WithEvents lblOperator As System.Windows.Forms.Label
    Friend WithEvents lblNumberTwo As System.Windows.Forms.Label
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents radNormal As System.Windows.Forms.RadioButton
    Friend WithEvents radDifficult As System.Windows.Forms.RadioButton

End Class
