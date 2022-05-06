<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoanCalculator
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
        Me.lblMaxMonthly = New System.Windows.Forms.Label()
        Me.lblAnnualInterest = New System.Windows.Forms.Label()
        Me.lblLengthLoan = New System.Windows.Forms.Label()
        Me.cmdCalculateLoan = New System.Windows.Forms.Button()
        Me.lblYourLoan = New System.Windows.Forms.Label()
        Me.cmdDone = New System.Windows.Forms.Button()
        Me.txtMaxMonthly = New System.Windows.Forms.TextBox()
        Me.txtAnnualInterest = New System.Windows.Forms.TextBox()
        Me.cboLengthLoan = New System.Windows.Forms.ComboBox()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(46, 20)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(165, 20)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter loan information"
        '
        'lblMaxMonthly
        '
        Me.lblMaxMonthly.AutoSize = True
        Me.lblMaxMonthly.Location = New System.Drawing.Point(73, 76)
        Me.lblMaxMonthly.Name = "lblMaxMonthly"
        Me.lblMaxMonthly.Size = New System.Drawing.Size(205, 20)
        Me.lblMaxMonthly.TabIndex = 1
        Me.lblMaxMonthly.Text = "Maximum Monthly Payment:"
        '
        'lblAnnualInterest
        '
        Me.lblAnnualInterest.AutoSize = True
        Me.lblAnnualInterest.Location = New System.Drawing.Point(73, 136)
        Me.lblAnnualInterest.Name = "lblAnnualInterest"
        Me.lblAnnualInterest.Size = New System.Drawing.Size(157, 20)
        Me.lblAnnualInterest.TabIndex = 2
        Me.lblAnnualInterest.Text = "Annual Interest Rate"
        '
        'lblLengthLoan
        '
        Me.lblLengthLoan.AutoSize = True
        Me.lblLengthLoan.Location = New System.Drawing.Point(73, 194)
        Me.lblLengthLoan.Name = "lblLengthLoan"
        Me.lblLengthLoan.Size = New System.Drawing.Size(169, 20)
        Me.lblLengthLoan.TabIndex = 3
        Me.lblLengthLoan.Text = "Length of Loan (years)"
        '
        'cmdCalculateLoan
        '
        Me.cmdCalculateLoan.Location = New System.Drawing.Point(50, 256)
        Me.cmdCalculateLoan.Name = "cmdCalculateLoan"
        Me.cmdCalculateLoan.Size = New System.Drawing.Size(192, 39)
        Me.cmdCalculateLoan.TabIndex = 4
        Me.cmdCalculateLoan.Text = "Calculate Loan"
        Me.cmdCalculateLoan.UseVisualStyleBackColor = True
        '
        'lblYourLoan
        '
        Me.lblYourLoan.AutoSize = True
        Me.lblYourLoan.Location = New System.Drawing.Point(46, 330)
        Me.lblYourLoan.Name = "lblYourLoan"
        Me.lblYourLoan.Size = New System.Drawing.Size(0, 20)
        Me.lblYourLoan.TabIndex = 5
        '
        'cmdDone
        '
        Me.cmdDone.Location = New System.Drawing.Point(585, 11)
        Me.cmdDone.Name = "cmdDone"
        Me.cmdDone.Size = New System.Drawing.Size(104, 39)
        Me.cmdDone.TabIndex = 6
        Me.cmdDone.Text = "Done"
        Me.cmdDone.UseVisualStyleBackColor = True
        '
        'txtMaxMonthly
        '
        Me.txtMaxMonthly.Location = New System.Drawing.Point(346, 73)
        Me.txtMaxMonthly.Name = "txtMaxMonthly"
        Me.txtMaxMonthly.Size = New System.Drawing.Size(100, 26)
        Me.txtMaxMonthly.TabIndex = 7
        '
        'txtAnnualInterest
        '
        Me.txtAnnualInterest.Location = New System.Drawing.Point(346, 133)
        Me.txtAnnualInterest.Name = "txtAnnualInterest"
        Me.txtAnnualInterest.Size = New System.Drawing.Size(100, 26)
        Me.txtAnnualInterest.TabIndex = 8
        '
        'cboLengthLoan
        '
        Me.cboLengthLoan.FormattingEnabled = True
        Me.cboLengthLoan.Items.AddRange(New Object() {"5", "10", "15", "20", "25", "30"})
        Me.cboLengthLoan.Location = New System.Drawing.Point(346, 191)
        Me.cboLengthLoan.Name = "cboLengthLoan"
        Me.cboLengthLoan.Size = New System.Drawing.Size(100, 28)
        Me.cboLengthLoan.TabIndex = 9
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Location = New System.Drawing.Point(46, 379)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(0, 20)
        Me.lblTotalAmount.TabIndex = 10
        '
        'frmLoanCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 419)
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.cboLengthLoan)
        Me.Controls.Add(Me.txtAnnualInterest)
        Me.Controls.Add(Me.txtMaxMonthly)
        Me.Controls.Add(Me.cmdDone)
        Me.Controls.Add(Me.lblYourLoan)
        Me.Controls.Add(Me.cmdCalculateLoan)
        Me.Controls.Add(Me.lblLengthLoan)
        Me.Controls.Add(Me.lblAnnualInterest)
        Me.Controls.Add(Me.lblMaxMonthly)
        Me.Controls.Add(Me.lblPrompt)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmLoanCalculator"
        Me.Text = "Loan Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents lblMaxMonthly As System.Windows.Forms.Label
    Friend WithEvents lblAnnualInterest As System.Windows.Forms.Label
    Friend WithEvents lblLengthLoan As System.Windows.Forms.Label
    Friend WithEvents cmdCalculateLoan As System.Windows.Forms.Button
    Friend WithEvents lblYourLoan As System.Windows.Forms.Label
    Friend WithEvents cmdDone As System.Windows.Forms.Button
    Friend WithEvents txtMaxMonthly As System.Windows.Forms.TextBox
    Friend WithEvents txtAnnualInterest As System.Windows.Forms.TextBox
    Friend WithEvents cboLengthLoan As System.Windows.Forms.ComboBox
    Friend WithEvents lblTotalAmount As System.Windows.Forms.Label

End Class
