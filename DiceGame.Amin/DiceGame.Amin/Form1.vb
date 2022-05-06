Public Class frmDiceGame

    'defining public variables
    Private intPoints As Integer

    Private Sub frmDiceGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'randomizing numbers
        Randomize()
        'starting amount of points
        intPoints = 1000
        'displaying total points
        lblTotal.Text = "Total points = " & intPoints

    End Sub

    Private Sub cmdRollDice_Click(sender As Object, e As EventArgs) Handles cmdRollDice.Click

        'defining variables
        Dim intRisk As Integer
        Dim intRandomOne As Integer
        Dim intRandomTwo As Integer
        Dim intHigh As Integer = 5
        Dim intLow As Integer = 1
        Dim intSum As Integer

        'getting user risk amount
        intRisk = txtRisk.Text
        
        'if risk is <= points then
        If intRisk <= intPoints Then

            'generating random number one within range
            intRandomOne = RndInt(intHigh, intLow)

            'generating random number two within range
            intRandomTwo = RndInt(intHigh, intLow)
          
            'displaying image for random number one
            Select Case intRandomOne
                'if number = 1
                Case Is = 1
                    'display dice 1
                    picDiceOne.Image = My.Resources.Dice1
                    'if number = 2
                Case Is = 2
                    'display dice 2
                    picDiceOne.Image = My.Resources.Dice2
                    'if number = 3
                Case Is = 3
                    'display dice 3
                    picDiceOne.Image = My.Resources.Dice3
                    'if number = 4
                Case Is = 4
                    'display dice 4
                    picDiceOne.Image = My.Resources.Dice4
                    'if dice = 5
                Case Is = 5
                    'display dice 5
                    picDiceOne.Image = My.Resources.Dice5
                    'if dice = 6
                Case Is = 6
                    'display dice 6
                    picDiceOne.Image = My.Resources.Dice6
            End Select

            'displaying image for random number two
            Select Case intRandomTwo
                'if number = 1
                Case Is = 1
                    'display dice 1
                    picDiceTwo.Image = My.Resources.Dice1
                    'if number = 2
                Case Is = 2
                    'display dice 2
                    picDiceTwo.Image = My.Resources.Dice2
                    'if number = 3
                Case Is = 3
                    'display dice 3
                    picDiceTwo.Image = My.Resources.Dice3
                    'if number = 4
                Case Is = 4
                    'display dice 4
                    picDiceTwo.Image = My.Resources.Dice4
                    'if dice = 5
                Case Is = 5
                    'display dice 5
                    picDiceTwo.Image = My.Resources.Dice5
                    'if dice = 6
                Case Is = 6
                    'display dice 6
                    picDiceTwo.Image = My.Resources.Dice6
            End Select

            'getting sum of two dice rolls
            intSum = intRandomOne + intRandomTwo

            'if sum is an odd number then
            If intSum = 3 Or intSum = 5 Or intSum = 7 Or intSum = 9 Or intSum = 11 Then
                'adding risk amount times two
                intPoints = intPoints + (intRisk * 2)
                'displaying win text
                lblAnswer.Text = "You win. The number was " & intSum
                'if sum is an even number then
            Else
                'subtracting risk amount
                intPoints = intPoints - intRisk
                'displaying lose text
                lblAnswer.Text = "You lose. The number was " & intSum
            End If
            'if risk is > points then
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

    Private Sub cmdEnd_Click(sender As Object, e As EventArgs) Handles cmdEnd.Click

        'ending program
        End

    End Sub
End Class
