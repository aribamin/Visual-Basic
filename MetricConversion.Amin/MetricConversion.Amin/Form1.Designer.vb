<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMetricConversion
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
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.cmdDone = New System.Windows.Forms.Button()
        Me.lblPromptTwo = New System.Windows.Forms.Label()
        Me.cmdInchesToCm = New System.Windows.Forms.Button()
        Me.cmdFeetToCm = New System.Windows.Forms.Button()
        Me.cmdYardsToMeters = New System.Windows.Forms.Button()
        Me.cmdMilesToKm = New System.Windows.Forms.Button()
        Me.cmdKmToMiles = New System.Windows.Forms.Button()
        Me.cmdMetersToYards = New System.Windows.Forms.Button()
        Me.cmdCmToFeet = New System.Windows.Forms.Button()
        Me.cmdCmToInches = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNumber
        '
        Me.txtNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber.Location = New System.Drawing.Point(159, 39)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(100, 26)
        Me.txtNumber.TabIndex = 0
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt.Location = New System.Drawing.Point(21, 42)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(123, 20)
        Me.lblPrompt.TabIndex = 1
        Me.lblPrompt.Text = "Enter a number:"
        '
        'cmdDone
        '
        Me.cmdDone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDone.Location = New System.Drawing.Point(372, 39)
        Me.cmdDone.Name = "cmdDone"
        Me.cmdDone.Size = New System.Drawing.Size(89, 26)
        Me.cmdDone.TabIndex = 2
        Me.cmdDone.Text = "Done"
        Me.cmdDone.UseVisualStyleBackColor = True
        '
        'lblPromptTwo
        '
        Me.lblPromptTwo.AutoSize = True
        Me.lblPromptTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromptTwo.Location = New System.Drawing.Point(21, 96)
        Me.lblPromptTwo.Name = "lblPromptTwo"
        Me.lblPromptTwo.Size = New System.Drawing.Size(68, 20)
        Me.lblPromptTwo.TabIndex = 3
        Me.lblPromptTwo.Text = "Convert:"
        '
        'cmdInchesToCm
        '
        Me.cmdInchesToCm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInchesToCm.Location = New System.Drawing.Point(25, 131)
        Me.cmdInchesToCm.Name = "cmdInchesToCm"
        Me.cmdInchesToCm.Size = New System.Drawing.Size(203, 26)
        Me.cmdInchesToCm.TabIndex = 4
        Me.cmdInchesToCm.Text = "Inches to Centimeters"
        Me.cmdInchesToCm.UseVisualStyleBackColor = True
        '
        'cmdFeetToCm
        '
        Me.cmdFeetToCm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFeetToCm.Location = New System.Drawing.Point(25, 166)
        Me.cmdFeetToCm.Name = "cmdFeetToCm"
        Me.cmdFeetToCm.Size = New System.Drawing.Size(203, 26)
        Me.cmdFeetToCm.TabIndex = 5
        Me.cmdFeetToCm.Text = "Feet to Centimeters"
        Me.cmdFeetToCm.UseVisualStyleBackColor = True
        '
        'cmdYardsToMeters
        '
        Me.cmdYardsToMeters.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdYardsToMeters.Location = New System.Drawing.Point(25, 201)
        Me.cmdYardsToMeters.Name = "cmdYardsToMeters"
        Me.cmdYardsToMeters.Size = New System.Drawing.Size(203, 26)
        Me.cmdYardsToMeters.TabIndex = 6
        Me.cmdYardsToMeters.Text = "Yards to Meters"
        Me.cmdYardsToMeters.UseVisualStyleBackColor = True
        '
        'cmdMilesToKm
        '
        Me.cmdMilesToKm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMilesToKm.Location = New System.Drawing.Point(25, 236)
        Me.cmdMilesToKm.Name = "cmdMilesToKm"
        Me.cmdMilesToKm.Size = New System.Drawing.Size(203, 26)
        Me.cmdMilesToKm.TabIndex = 7
        Me.cmdMilesToKm.Text = "Miles to Kilometers"
        Me.cmdMilesToKm.UseVisualStyleBackColor = True
        '
        'cmdKmToMiles
        '
        Me.cmdKmToMiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdKmToMiles.Location = New System.Drawing.Point(258, 236)
        Me.cmdKmToMiles.Name = "cmdKmToMiles"
        Me.cmdKmToMiles.Size = New System.Drawing.Size(203, 26)
        Me.cmdKmToMiles.TabIndex = 8
        Me.cmdKmToMiles.Text = "Kilometers to Miles"
        Me.cmdKmToMiles.UseVisualStyleBackColor = True
        '
        'cmdMetersToYards
        '
        Me.cmdMetersToYards.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMetersToYards.Location = New System.Drawing.Point(258, 201)
        Me.cmdMetersToYards.Name = "cmdMetersToYards"
        Me.cmdMetersToYards.Size = New System.Drawing.Size(203, 26)
        Me.cmdMetersToYards.TabIndex = 9
        Me.cmdMetersToYards.Text = "Meters to Yards"
        Me.cmdMetersToYards.UseVisualStyleBackColor = True
        '
        'cmdCmToFeet
        '
        Me.cmdCmToFeet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCmToFeet.Location = New System.Drawing.Point(258, 166)
        Me.cmdCmToFeet.Name = "cmdCmToFeet"
        Me.cmdCmToFeet.Size = New System.Drawing.Size(203, 26)
        Me.cmdCmToFeet.TabIndex = 10
        Me.cmdCmToFeet.Text = "Centimeters to Feet"
        Me.cmdCmToFeet.UseVisualStyleBackColor = True
        '
        'cmdCmToInches
        '
        Me.cmdCmToInches.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCmToInches.Location = New System.Drawing.Point(258, 131)
        Me.cmdCmToInches.Name = "cmdCmToInches"
        Me.cmdCmToInches.Size = New System.Drawing.Size(203, 26)
        Me.cmdCmToInches.TabIndex = 11
        Me.cmdCmToInches.Text = "Centimeters to Inches"
        Me.cmdCmToInches.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(114, 290)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(250, 20)
        Me.lblAnswer.TabIndex = 12
        Me.lblAnswer.Text = "10 inches equals 25.4 centimeters"
        '
        'frmMetricConversion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 341)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.cmdCmToInches)
        Me.Controls.Add(Me.cmdCmToFeet)
        Me.Controls.Add(Me.cmdMetersToYards)
        Me.Controls.Add(Me.cmdKmToMiles)
        Me.Controls.Add(Me.cmdMilesToKm)
        Me.Controls.Add(Me.cmdYardsToMeters)
        Me.Controls.Add(Me.cmdFeetToCm)
        Me.Controls.Add(Me.cmdInchesToCm)
        Me.Controls.Add(Me.lblPromptTwo)
        Me.Controls.Add(Me.cmdDone)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.txtNumber)
        Me.Name = "frmMetricConversion"
        Me.Text = "Metric Conversion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents cmdDone As System.Windows.Forms.Button
    Friend WithEvents lblPromptTwo As System.Windows.Forms.Label
    Friend WithEvents cmdInchesToCm As System.Windows.Forms.Button
    Friend WithEvents cmdFeetToCm As System.Windows.Forms.Button
    Friend WithEvents cmdYardsToMeters As System.Windows.Forms.Button
    Friend WithEvents cmdMilesToKm As System.Windows.Forms.Button
    Friend WithEvents cmdKmToMiles As System.Windows.Forms.Button
    Friend WithEvents cmdMetersToYards As System.Windows.Forms.Button
    Friend WithEvents cmdCmToFeet As System.Windows.Forms.Button
    Friend WithEvents cmdCmToInches As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label

End Class
