Public Class frmSum

    Private Sub cmdCalculateSum_Click(sender As Object, e As EventArgs) Handles cmdCalculateSum.Click

        'defining variables
        Dim intStartingNum As Integer
        Dim intEndingNum As Integer
        Dim intSum As Integer
        Dim intLoop As Integer

        'receiving user numbers
        intStartingNum = txtStartingNum.Text
        intEndingNum = txtEndingNum.Text

        'if starting num is less than ending num then
        If intStartingNum < intEndingNum Then
            'loop starting num to ending sum
            For intLoop = intStartingNum To intEndingNum
                'sum equals sum plus loop
                intSum = intSum + intLoop
                'displaying sum
                lblPrompt.Text = "The sum of the numbers"
                lblSum.Text = "between " & intStartingNum & " and " & intEndingNum & " is " & intSum
            Next
            'if starting num is greater than ending num then
        ElseIf intEndingNum < intStartingNum Then
            'loop ending num to starting num
            For intLoop = intEndingNum To intStartingNum
                'sum equals sum plus loop
                intSum = intSum + intLoop
                'displaying sum
                lblPrompt.Text = "The sum of the numbers"
                lblSum.Text = "between " & intEndingNum & " and " & intStartingNum & " is " & intSum
            Next
        End If

    End Sub

    Private Sub cmdDone_Click(sender As Object, e As EventArgs) Handles cmdDone.Click

        'ending program
        End

    End Sub
End Class
