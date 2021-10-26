Public Class frmSlotMachine

    'defining variables and constants
    Private intTokens As Integer = 1

    Private Sub frmSlotMachine_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'making numbers random
        Randomize()

    End Sub

    Private Sub radPull_Click(sender As Object, e As EventArgs) Handles radPull.Click

        'defining variables and constants
        Dim intRandomNum1 As Integer
        Dim intRandomNum2 As Integer
        Dim intRandomNum3 As Integer

        'getting random number for number 1
        intRandomNum1 = Int(3 * Rnd()) + 1
        'getting random number for number 2
        intRandomNum2 = Int(3 * Rnd()) + 1
        'getting random number for number 3
        intRandomNum3 = Int(3 * Rnd()) + 1

        'displaying random number for number 1
        lblRandomNum1.Text = intRandomNum1
        'displaying random number for number 2
        lblRandomNum2.Text = intRandomNum2
        'displaying random number for number 3
        lblRandomNum3.Text = intRandomNum3

        'removing 1 token for every pull
        intTokens = intTokens - 1
        'displaying amount of tokens remaining
        lblTokens.Text = intTokens

        'if all random numbers equal 1 then
        If intRandomNum1 = 1 And intRandomNum2 = 1 And intRandomNum3 = 1 Then
            'displaying message for 4 tokens won
            MsgBox("You have won 4 tokens")
            'adding tokens won to current tokens
            intTokens = intTokens + 4
        End If

        'if all random numbers equal 2 then
        If intRandomNum1 = 2 And intRandomNum2 = 2 And intRandomNum3 = 2 Then
            'displaying message for 8 tokens won
            MsgBox("You have won 8 tokens")
            'adding tokens won to current tokens
            intTokens = intTokens + 8
        End If

        'if all random numbers equal 3 then
        If intRandomNum1 = 3 And intRandomNum2 = 3 And intRandomNum3 = 3 Then
            'displaying message for 12 tokens won
            MsgBox("You have won 12 tokens")
            'adding tokens won to current tokens
            intTokens = intTokens + 12
        End If

        'displaying tokens remaining
        lblTokens.Text = intTokens

        'if tokens remaining equals 0 then
        If intTokens = 0 Then
            'displaying message for no more tokens left
            MsgBox("You have no more tokens left")
            'ending application
            End
        End If

    End Sub

    Private Sub radDone_Click(sender As Object, e As EventArgs) Handles radDone.Click

        'ending application
        End

    End Sub
End Class
