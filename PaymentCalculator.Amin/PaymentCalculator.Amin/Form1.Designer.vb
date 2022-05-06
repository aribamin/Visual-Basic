<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaymentCalculator
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
        Me.lblLoanAmount = New System.Windows.Forms.Label()
        Me.lblInterestRate = New System.Windows.Forms.Label()
        Me.lblLoanLength = New System.Windows.Forms.Label()
        Me.lblPaymentTime = New System.Windows.Forms.Label()
        Me.cmdPayments = New System.Windows.Forms.Button()
        Me.cmdDone = New System.Windows.Forms.Button()
        Me.txtLoanAmount = New System.Windows.Forms.TextBox()
        Me.txtInterestRate = New System.Windows.Forms.TextBox()
        Me.cboLoanLength = New System.Windows.Forms.ComboBox()
        Me.lstPaymentTime = New System.Windows.Forms.ListBox()
        Me.lblYearlyPayment = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.lblInterestPaid = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt.Location = New System.Drawing.Point(35, 23)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(173, 20)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter Loan Information"
        '
        'lblLoanAmount
        '
        Me.lblLoanAmount.AutoSize = True
        Me.lblLoanAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoanAmount.Location = New System.Drawing.Point(35, 71)
        Me.lblLoanAmount.Name = "lblLoanAmount"
        Me.lblLoanAmount.Size = New System.Drawing.Size(140, 20)
        Me.lblLoanAmount.TabIndex = 1
        Me.lblLoanAmount.Text = "Amount of Loan $:"
        '
        'lblInterestRate
        '
        Me.lblInterestRate.AutoSize = True
        Me.lblInterestRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterestRate.Location = New System.Drawing.Point(35, 118)
        Me.lblInterestRate.Name = "lblInterestRate"
        Me.lblInterestRate.Size = New System.Drawing.Size(179, 20)
        Me.lblInterestRate.TabIndex = 2
        Me.lblInterestRate.Text = "Annual Interest Rate %:"
        '
        'lblLoanLength
        '
        Me.lblLoanLength.AutoSize = True
        Me.lblLoanLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoanLength.Location = New System.Drawing.Point(35, 172)
        Me.lblLoanLength.Name = "lblLoanLength"
        Me.lblLoanLength.Size = New System.Drawing.Size(173, 20)
        Me.lblLoanLength.TabIndex = 3
        Me.lblLoanLength.Text = "Length of Loan (Years)"
        '
        'lblPaymentTime
        '
        Me.lblPaymentTime.AutoSize = True
        Me.lblPaymentTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentTime.Location = New System.Drawing.Point(35, 222)
        Me.lblPaymentTime.Name = "lblPaymentTime"
        Me.lblPaymentTime.Size = New System.Drawing.Size(150, 20)
        Me.lblPaymentTime.TabIndex = 4
        Me.lblPaymentTime.Text = "Payments are made"
        '
        'cmdPayments
        '
        Me.cmdPayments.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPayments.Location = New System.Drawing.Point(39, 283)
        Me.cmdPayments.Name = "cmdPayments"
        Me.cmdPayments.Size = New System.Drawing.Size(97, 37)
        Me.cmdPayments.TabIndex = 5
        Me.cmdPayments.Text = "Payments"
        Me.cmdPayments.UseVisualStyleBackColor = True
        '
        'cmdDone
        '
        Me.cmdDone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDone.Location = New System.Drawing.Point(152, 283)
        Me.cmdDone.Name = "cmdDone"
        Me.cmdDone.Size = New System.Drawing.Size(73, 37)
        Me.cmdDone.TabIndex = 6
        Me.cmdDone.Text = "Done"
        Me.cmdDone.UseVisualStyleBackColor = True
        '
        'txtLoanAmount
        '
        Me.txtLoanAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanAmount.Location = New System.Drawing.Point(257, 68)
        Me.txtLoanAmount.Name = "txtLoanAmount"
        Me.txtLoanAmount.Size = New System.Drawing.Size(100, 26)
        Me.txtLoanAmount.TabIndex = 7
        '
        'txtInterestRate
        '
        Me.txtInterestRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInterestRate.Location = New System.Drawing.Point(257, 115)
        Me.txtInterestRate.Name = "txtInterestRate"
        Me.txtInterestRate.Size = New System.Drawing.Size(100, 26)
        Me.txtInterestRate.TabIndex = 8
        '
        'cboLoanLength
        '
        Me.cboLoanLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLoanLength.FormattingEnabled = True
        Me.cboLoanLength.Items.AddRange(New Object() {"5", "10", "15", "20", "25", "30"})
        Me.cboLoanLength.Location = New System.Drawing.Point(257, 169)
        Me.cboLoanLength.Name = "cboLoanLength"
        Me.cboLoanLength.Size = New System.Drawing.Size(100, 28)
        Me.cboLoanLength.TabIndex = 10
        '
        'lstPaymentTime
        '
        Me.lstPaymentTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPaymentTime.FormattingEnabled = True
        Me.lstPaymentTime.ItemHeight = 20
        Me.lstPaymentTime.Items.AddRange(New Object() {"Daily", "Monthly", "Yearly"})
        Me.lstPaymentTime.Location = New System.Drawing.Point(257, 222)
        Me.lstPaymentTime.Name = "lstPaymentTime"
        Me.lstPaymentTime.Size = New System.Drawing.Size(121, 64)
        Me.lstPaymentTime.TabIndex = 11
        '
        'lblYearlyPayment
        '
        Me.lblYearlyPayment.AutoSize = True
        Me.lblYearlyPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearlyPayment.Location = New System.Drawing.Point(35, 347)
        Me.lblYearlyPayment.Name = "lblYearlyPayment"
        Me.lblYearlyPayment.Size = New System.Drawing.Size(0, 20)
        Me.lblYearlyPayment.TabIndex = 12
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.Location = New System.Drawing.Point(35, 376)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(0, 20)
        Me.lblTotalAmount.TabIndex = 13
        '
        'lblInterestPaid
        '
        Me.lblInterestPaid.AutoSize = True
        Me.lblInterestPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterestPaid.Location = New System.Drawing.Point(35, 405)
        Me.lblInterestPaid.Name = "lblInterestPaid"
        Me.lblInterestPaid.Size = New System.Drawing.Size(0, 20)
        Me.lblInterestPaid.TabIndex = 14
        '
        'frmPaymentCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 447)
        Me.Controls.Add(Me.lblInterestPaid)
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.lblYearlyPayment)
        Me.Controls.Add(Me.lstPaymentTime)
        Me.Controls.Add(Me.cboLoanLength)
        Me.Controls.Add(Me.txtInterestRate)
        Me.Controls.Add(Me.txtLoanAmount)
        Me.Controls.Add(Me.cmdDone)
        Me.Controls.Add(Me.cmdPayments)
        Me.Controls.Add(Me.lblPaymentTime)
        Me.Controls.Add(Me.lblLoanLength)
        Me.Controls.Add(Me.lblInterestRate)
        Me.Controls.Add(Me.lblLoanAmount)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "frmPaymentCalculator"
        Me.Text = "Payment Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents lblLoanAmount As System.Windows.Forms.Label
    Friend WithEvents lblInterestRate As System.Windows.Forms.Label
    Friend WithEvents lblLoanLength As System.Windows.Forms.Label
    Friend WithEvents lblPaymentTime As System.Windows.Forms.Label
    Friend WithEvents cmdPayments As System.Windows.Forms.Button
    Friend WithEvents cmdDone As System.Windows.Forms.Button
    Friend WithEvents txtLoanAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtInterestRate As System.Windows.Forms.TextBox
    Friend WithEvents cboLoanLength As System.Windows.Forms.ComboBox
    Friend WithEvents lstPaymentTime As System.Windows.Forms.ListBox
    Friend WithEvents lblYearlyPayment As System.Windows.Forms.Label
    Friend WithEvents lblTotalAmount As System.Windows.Forms.Label
    Friend WithEvents lblInterestPaid As System.Windows.Forms.Label

End Class
