<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCoins
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
        Me.lblQuarters = New System.Windows.Forms.Label()
        Me.lblDimes = New System.Windows.Forms.Label()
        Me.lblNickels = New System.Windows.Forms.Label()
        Me.lblPennies = New System.Windows.Forms.Label()
        Me.cmdAddCoins = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtQuartersAmount = New System.Windows.Forms.TextBox()
        Me.txtDimesAmount = New System.Windows.Forms.TextBox()
        Me.txtNickelsAmount = New System.Windows.Forms.TextBox()
        Me.txtPenniesAmount = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblQuarters
        '
        Me.lblQuarters.AutoSize = True
        Me.lblQuarters.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuarters.Location = New System.Drawing.Point(60, 59)
        Me.lblQuarters.Name = "lblQuarters"
        Me.lblQuarters.Size = New System.Drawing.Size(75, 20)
        Me.lblQuarters.TabIndex = 0
        Me.lblQuarters.Text = "Quarters:"
        '
        'lblDimes
        '
        Me.lblDimes.AutoSize = True
        Me.lblDimes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDimes.Location = New System.Drawing.Point(60, 117)
        Me.lblDimes.Name = "lblDimes"
        Me.lblDimes.Size = New System.Drawing.Size(58, 20)
        Me.lblDimes.TabIndex = 1
        Me.lblDimes.Text = "Dimes:"
        '
        'lblNickels
        '
        Me.lblNickels.AutoSize = True
        Me.lblNickels.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNickels.Location = New System.Drawing.Point(60, 180)
        Me.lblNickels.Name = "lblNickels"
        Me.lblNickels.Size = New System.Drawing.Size(63, 20)
        Me.lblNickels.TabIndex = 2
        Me.lblNickels.Text = "Nickels:"
        '
        'lblPennies
        '
        Me.lblPennies.AutoSize = True
        Me.lblPennies.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPennies.Location = New System.Drawing.Point(60, 244)
        Me.lblPennies.Name = "lblPennies"
        Me.lblPennies.Size = New System.Drawing.Size(70, 20)
        Me.lblPennies.TabIndex = 3
        Me.lblPennies.Text = "Pennies:"
        '
        'cmdAddCoins
        '
        Me.cmdAddCoins.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddCoins.Location = New System.Drawing.Point(345, 79)
        Me.cmdAddCoins.Name = "cmdAddCoins"
        Me.cmdAddCoins.Size = New System.Drawing.Size(92, 37)
        Me.cmdAddCoins.TabIndex = 4
        Me.cmdAddCoins.Text = "Add Coins"
        Me.cmdAddCoins.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(341, 213)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(57, 20)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "Total $"
        '
        'txtQuartersAmount
        '
        Me.txtQuartersAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuartersAmount.Location = New System.Drawing.Point(174, 56)
        Me.txtQuartersAmount.Name = "txtQuartersAmount"
        Me.txtQuartersAmount.Size = New System.Drawing.Size(100, 26)
        Me.txtQuartersAmount.TabIndex = 6
        '
        'txtDimesAmount
        '
        Me.txtDimesAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDimesAmount.Location = New System.Drawing.Point(174, 114)
        Me.txtDimesAmount.Name = "txtDimesAmount"
        Me.txtDimesAmount.Size = New System.Drawing.Size(100, 26)
        Me.txtDimesAmount.TabIndex = 7
        '
        'txtNickelsAmount
        '
        Me.txtNickelsAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNickelsAmount.Location = New System.Drawing.Point(174, 177)
        Me.txtNickelsAmount.Name = "txtNickelsAmount"
        Me.txtNickelsAmount.Size = New System.Drawing.Size(100, 26)
        Me.txtNickelsAmount.TabIndex = 8
        '
        'txtPenniesAmount
        '
        Me.txtPenniesAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPenniesAmount.Location = New System.Drawing.Point(174, 241)
        Me.txtPenniesAmount.Name = "txtPenniesAmount"
        Me.txtPenniesAmount.Size = New System.Drawing.Size(100, 26)
        Me.txtPenniesAmount.TabIndex = 9
        '
        'frmAddCoins
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 327)
        Me.Controls.Add(Me.txtPenniesAmount)
        Me.Controls.Add(Me.txtNickelsAmount)
        Me.Controls.Add(Me.txtDimesAmount)
        Me.Controls.Add(Me.txtQuartersAmount)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.cmdAddCoins)
        Me.Controls.Add(Me.lblPennies)
        Me.Controls.Add(Me.lblNickels)
        Me.Controls.Add(Me.lblDimes)
        Me.Controls.Add(Me.lblQuarters)
        Me.Name = "frmAddCoins"
        Me.Text = "Add Coins"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblQuarters As System.Windows.Forms.Label
    Friend WithEvents lblDimes As System.Windows.Forms.Label
    Friend WithEvents lblNickels As System.Windows.Forms.Label
    Friend WithEvents lblPennies As System.Windows.Forms.Label
    Friend WithEvents cmdAddCoins As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtQuartersAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtDimesAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtNickelsAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtPenniesAmount As System.Windows.Forms.TextBox

End Class
