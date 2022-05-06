Public Class frmCalculator2

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub radAdd_CheckedChanged(sender As Object, e As EventArgs) Handles radAdd.CheckedChanged
        'declaring variables
        Dim intFirstNumber As Integer
        Dim intSecondNumber As Integer
        Dim intAnswer As Integer

        'get first number from user
        intFirstNumber = txtFirstNumber.Text
        'get second number from user
        intSecondNumber = txtSecondNumber.Text
        'calculates answer for addition
        intAnswer = intFirstNumber + intSecondNumber
        'shows answer for addition
        lblAnswer.Text = intAnswer
    End Sub

    Private Sub lblAnswer_Click(sender As Object, e As EventArgs) Handles lblAnswer.Click

    End Sub

    Private Sub radSubtract_CheckedChanged(sender As Object, e As EventArgs) Handles radSubtract.CheckedChanged
        'declaring variables
        Dim intFirstNumber As Integer
        Dim intSecondNumber As Integer
        Dim intAnswer As Integer

        'get first number from user
        intFirstNumber = txtFirstNumber.Text
        'get second number from user
        intSecondNumber = txtSecondNumber.Text
        'calculates answer for subtraction
        intAnswer = intFirstNumber - intSecondNumber
        'shows answer for subtraction
        lblAnswer.Text = intAnswer
    End Sub

    Private Sub radMultiply_CheckedChanged(sender As Object, e As EventArgs) Handles radMultiply.CheckedChanged
        'declaring variables
        Dim intFirstNumber As Integer
        Dim intSecondNumber As Integer
        Dim intAnswer As Integer

        'get first number from user
        intFirstNumber = txtFirstNumber.Text
        'get second number from user
        intSecondNumber = txtSecondNumber.Text
        'calculates answer for multiplication
        intAnswer = intFirstNumber * intSecondNumber
        'shows answer for multiplication
        lblAnswer.Text = intAnswer
    End Sub

    Private Sub radDivide_CheckedChanged(sender As Object, e As EventArgs) Handles radDivide.CheckedChanged
        'declaring variables
        Dim dblFirstNumber As Double
        Dim dblSecondNumber As Double
        Dim dblAnswer As Double

        'get first number from user
        dblFirstNumber = txtFirstNumber.Text
        'get second number from user
        dblSecondNumber = txtSecondNumber.Text
        'calculates answer for division
        dblAnswer = dblFirstNumber / dblSecondNumber
        'shows answer for division
        lblAnswer.Text = dblAnswer
    End Sub

    Private Sub cmdEnd_Click(sender As Object, e As EventArgs) Handles cmdEnd.Click
        'ends program
        End
    End Sub
End Class
