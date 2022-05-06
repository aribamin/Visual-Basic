Public Class frmPaymentCalculator

    Private Sub cmdPayments_Click(sender As Object, e As EventArgs) Handles cmdPayments.Click

        'defining variables
        Dim dblLoanAmount As Double
        Dim dblInterestRate As Double
        Dim intLoanLength As Integer
        Dim dblTermPayment As Double
        Dim dblTotalAmount As Double
        Dim dblInterestPaid As Double
        Dim intPaymentTime As Integer

        'getting loan amount from user
        dblLoanAmount = txtLoanAmount.Text
        'getting interest rate from user
        dblInterestRate = txtInterestRate.Text
        'getting loan length from user
        intLoanLength = cboLoanLength.Text

        'if interest rate is >= 1
        If dblInterestRate >= 1 Then
            'dividing interest rate by 100
            dblInterestRate = dblInterestRate / 100
        End If

        'selecting payment time
        Select Case Me.lstPaymentTime.SelectedItem
            'if daily is selected
            Case "Daily"
                'payment time equals 360
                intPaymentTime = 360
                'calculating for term payment daily
                dblTermPayment = Pmt(dblInterestRate / 360, intLoanLength * 360, (dblLoanAmount * -1))
                'displaying term payment for daily
                lblYearlyPayment.Text = "Your " & lstPaymentTime.SelectedItem & " payment is " & Format(dblTermPayment, "Currency")
                'if monthly is selected
            Case "Monthly"
                'payment time equals 12
                intPaymentTime = 12
                'calculating for term payment monthly
                dblTermPayment = Pmt(dblInterestRate / 12, intLoanLength * 12, (dblLoanAmount * -1))
                'displaying term payment for monthly
                lblYearlyPayment.Text = "Your " & lstPaymentTime.SelectedItem & " payment is " & Format(dblTermPayment, "Currency")
                'if yearly is selected
            Case "Yearly"
                'payment time equals 1
                intPaymentTime = 1
                'calculating for term payment yearly
                dblTermPayment = Pmt(dblInterestRate, intLoanLength, (dblLoanAmount * -1))
                'displaying term payment for yearly
                lblYearlyPayment.Text = "Your " & lstPaymentTime.SelectedItem & " payment is " & Format(dblTermPayment, "Currency")
                'if no term is selected
            Case ""
                'displaying message box telling user to select a term
                MsgBox("Please select a payment time")
                'end select case
        End Select

        'calculating total amount paid
        dblTotalAmount = dblTermPayment * intLoanLength * intPaymentTime
        'displaying total amount paid
        lblTotalAmount.Text = "Total amount paid is " & Format(dblTotalAmount, "Currency")
        'calculating total interest paid
        dblInterestPaid = dblTotalAmount - dblLoanAmount
        'displaying total interest paid
        lblInterestPaid.Text = "and total interest paid is " & Format(dblInterestPaid, "Currency")

    End Sub

    Private Sub cmdDone_Click(sender As Object, e As EventArgs) Handles cmdDone.Click

        'ending program
        End

    End Sub
End Class
