Public Class frmLoanCalculator

    Private Sub cmdCalculateLoan_Click(sender As Object, e As EventArgs) Handles cmdCalculateLoan.Click

        'defining variables
        Dim dblMaxMonthly As Double
        Dim dblAnnualInterest As Double
        Dim intLengthLoan As Integer
        Dim dblLoanAmount As Double
        Dim dblTotalPaid As Double
        Dim dblTotalInterest As Double

        'getting user max monthly payment
        dblMaxMonthly = txtMaxMonthly.Text
        'getting user annual interest rate
        dblAnnualInterest = txtAnnualInterest.Text
        'getting user length of loan (years)
        intLengthLoan = cboLengthLoan.Text

        'if interest rate is >= 1
        If dblAnnualInterest >= 1 Then
            'dividing the annual interest by 100
            dblAnnualInterest = dblAnnualInterest / 100
        End If

        'calculating for loan amount using PV function
        dblLoanAmount = PV(dblAnnualInterest / 12, intLengthLoan * 12, (dblMaxMonthly * -1))
        'calculating for total paid by multiplaying monthly by length * 12
        dblTotalPaid = dblMaxMonthly * intLengthLoan * 12
        'calulating interest by subtracting loan amnount from total
        dblTotalInterest = dblTotalPaid - dblLoanAmount

        'displaying text for max monthly payment and loan amount
        lblYourLoan.Text = "Your loan amount for monthly payments of " & FormatCurrency(dblMaxMonthly) & " is " & FormatCurrency(dblLoanAmount) & "."
        'displaying text for total amount paid and total interest
        lblTotalAmount.Text = "Total amount paid is " & FormatCurrency(dblTotalPaid) & " and the total interest is " & FormatCurrency(dblTotalInterest)

    End Sub

    Private Sub cmdDone_Click(sender As Object, e As EventArgs) Handles cmdDone.Click

        'ending program
        End

    End Sub
End Class
