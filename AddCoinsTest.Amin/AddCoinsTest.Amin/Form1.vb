Public Class frmAddCoins

    Private Sub cmdAddCoins_Click(sender As Object, e As EventArgs) Handles cmdAddCoins.Click

        'defining variables
        Dim dblQuartersValue As Double
        Dim dblDimesValue As Double
        Dim dblNickelsValue As Double
        Dim dblPenniesValue As Double
        Dim dblTotalValue As Double

        'if textbox is left empty
        If txtQuartersAmount.Text = "" Then
            'setting value to zero
            txtQuartersAmount.Text = 0
        End If
        'if textbox is left empty
        If txtDimesAmount.Text = "" Then
            'setting value to zero
            txtDimesAmount.Text = 0
        End If
        'if textbox is left empty
        If txtNickelsAmount.Text = "" Then
            'setting value to zero
            txtNickelsAmount.Text = 0
        End If
        'if textbox is left empty
        If txtPenniesAmount.Text = "" Then
            'setting value to zero
            txtPenniesAmount.Text = 0
        End If

        'calculating value of quarters
        dblQuartersValue = txtQuartersAmount.Text * 0.25
        'calculating value of dimes
        dblDimesValue = txtDimesAmount.Text * 0.1
        'calculating value of nickels
        dblNickelsValue = txtNickelsAmount.Text * 0.05
        'calculating value of pennies
        dblPenniesValue = txtPenniesAmount.Text * 0.01

        'calculating total value of all coins using TotalDollars function
        dblTotalValue = TotalDollars(dblQuartersValue, dblDimesValue, dblNickelsValue, dblPenniesValue)

        'displaying total value of all coins
        lblTotal.Text = "Total $" & dblTotalValue

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Pre: Receiving values of each coin type from user
    'Function: Adding up values of all coin types
    'Post: Returning total value of all coins types
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Function TotalDollars(ByVal dblQuarters As Double, dblDimes As Double, dblNickels As Double, dblPennies As Double) As Double

        'adding up values of all coint types
        TotalDollars = dblQuarters + dblDimes + dblNickels + dblPennies

    End Function
End Class
