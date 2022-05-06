<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcronym
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
        Me.lblAcronym = New System.Windows.Forms.Label()
        Me.cmdCreateAcronym = New System.Windows.Forms.Button()
        Me.cmdDone = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAcronym
        '
        Me.lblAcronym.AutoSize = True
        Me.lblAcronym.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcronym.Location = New System.Drawing.Point(35, 38)
        Me.lblAcronym.Name = "lblAcronym"
        Me.lblAcronym.Size = New System.Drawing.Size(115, 20)
        Me.lblAcronym.TabIndex = 0
        Me.lblAcronym.Text = "The acronym is"
        '
        'cmdCreateAcronym
        '
        Me.cmdCreateAcronym.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCreateAcronym.Location = New System.Drawing.Point(241, 141)
        Me.cmdCreateAcronym.Name = "cmdCreateAcronym"
        Me.cmdCreateAcronym.Size = New System.Drawing.Size(132, 28)
        Me.cmdCreateAcronym.TabIndex = 1
        Me.cmdCreateAcronym.Text = "Create Acronym"
        Me.cmdCreateAcronym.UseVisualStyleBackColor = True
        '
        'cmdDone
        '
        Me.cmdDone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDone.Location = New System.Drawing.Point(241, 175)
        Me.cmdDone.Name = "cmdDone"
        Me.cmdDone.Size = New System.Drawing.Size(132, 28)
        Me.cmdDone.TabIndex = 2
        Me.cmdDone.Text = "Done"
        Me.cmdDone.UseVisualStyleBackColor = True
        '
        'frmAcronym
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 216)
        Me.Controls.Add(Me.cmdDone)
        Me.Controls.Add(Me.cmdCreateAcronym)
        Me.Controls.Add(Me.lblAcronym)
        Me.DoubleBuffered = True
        Me.Name = "frmAcronym"
        Me.Text = "Acronym"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lblAcronym As System.Windows.Forms.Label
    Friend WithEvents cmdCreateAcronym As System.Windows.Forms.Button
    Friend WithEvents cmdDone As System.Windows.Forms.Button

End Class
