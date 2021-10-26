Public Class frmHiLoGame

    'defining variables
    Private intPoints As Integer
    Private intRisk As Integer
    Private intRandom As Integer
    Private intHigh As Integer = 12
    Private intLow As Integer = 1

    Private Sub frmHiLoGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'randomizing numbers
        Randomize()
        'starting amount of points
        intPoints = 1000
        'displaying total points
        lblTotal.Text = "Total points = " & intPoints

    End Sub

    Private Sub cmdHigh_Click(sender As Object, e As EventArgs) Handles cmdHigh.Click

        'getting user risk amount
        intRisk = txtRisk.Text
        'generating random number withing range
        intRandom = RndInt(intHigh, intLow)

        'if risk is <= points then
        If intRisk <= intPoints Then
            'if random number is high then
            If intRandom >= 8 And intRandom <= 13 Then
                'adding risk amount times two
                intPoints = intPoints + (intRisk * 2)
                'displaying win text
                lblAnswer.Text = "You win. The number was " & intRandom
                'if random number is not high then
            Else
                'subtracting risk amount
                intPoints = intPoints - intRisk
                'displaying lose text
                lblAnswer.Text = "You lose. The number was " & intRandom
            End If
        Else
            'displaying message box for risk > points
            MsgBox("Insufficient amount")
        End If

        'if points <= 0 then
        If intPoints <= 0 Then
            'display total points
            lblTotal.Text = "Total points = " & intPoints
            'display message for game over
            MsgBox("Game over")
            'ending program
            End
        End If

        'displaying total points
        lblTotal.Text = "Total points = " & intPoints

    End Sub

    Private Sub cmdLow_Click(sender As Object, e As EventArgs) Handles cmdLow.Click

        'getting user risk amount
        intRisk = txtRisk.Text
        'generating random number within range
        intRandom = RndInt(intHigh, intLow)

        'if risk is <= points then
        If intRisk <= intPoints Then
            'if random number is low then
            If intRandom >= 1 And intRandom <= 6 Then
                'adding risk amount times two
                intPoints = intPoints + (intRisk * 2)
                'displaying win text
                lblAnswer.Text = "You win. The number was " & intRandom
                'if random number is not low then
            Else
                'subtracting risk amount
                intPoints = intPoints - intRisk
                'displaying lose text
                lblAnswer.Text = "You lose. The number was " & intRandom
            End If
        Else
            'displaying message box for risk > points
            MsgBox("Insufficient amount")
        End If

        'if points <= 0 then
        If intPoints <= 0 Then
            'display total points
            lblTotal.Text = "Total points = " & intPoints
            'display message for game over
            MsgBox("Game over")
            'ending program
            End
        End If

        'displaying total
        lblTotal.Text = "Total points = " & intPoints

    End Sub

    '********************************************************
    ' Pre: range of intLowNum to intHighNum
    '
    ' Returns random integer in the range intLowNum to intHighNum
    '
    ' Post: random integer in range returned
    '********************************************************
    Function RndInt(ByVal intHighNum As Integer, ByVal intLowNum As Integer) As Integer

        'generating random number within parameters
        RndInt = (Rnd() * intHighNum) + intLowNum

    End Function

    Private Sub cmdDone_Click(sender As Object, e As EventArgs) Handles cmdDone.Click

        'ending program
        End

    End Sub
End Class
