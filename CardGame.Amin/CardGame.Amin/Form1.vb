Public Class frmCardGame

    'defining public variables
    Dim intYouWin As Integer
    Dim intCompWin As Integer
    Dim intDraw As Integer

    Private Sub frmCardGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'randomizing numbers
        Randomize()

    End Sub

    Private Sub cmdPlay_Click(sender As Object, e As EventArgs) Handles cmdPlay.Click

        'defining variables
        Dim intYouOne As Integer
        Dim intYouTwo As Integer
        Dim intYouThree As Integer
        Dim intCompOne As Integer
        Dim intCompTwo As Integer
        Dim intCompThree As Integer
        Dim intHigh As Integer = 9
        Dim intLow As Integer = 1
        Dim intYouSum As Integer
        Dim intCompSum As Integer
        
        'getting random number for user card one
        intYouOne = RndInt(intHigh, intLow)
        'getting random number for user card two
        intYouTwo = RndInt(intHigh, intLow)
        'getting random number for user card three
        intYouThree = RndInt(intHigh, intLow)
        'getting random number for computer card one
        intCompOne = RndInt(intHigh, intLow)
        'getting random number for computer card two
        intCompTwo = RndInt(intHigh, intLow)
        'getting random number for computer card three
        intCompThree = RndInt(intHigh, intLow)

        'cases for value of user card one
        Select Case intYouOne
            'if case equals one
            Case Is = 1
                'display card one
                picYouOne.Image = My.Resources.Card1
                'if case equals two
            Case Is = 2
                'display card two
                picYouOne.Image = My.Resources.Card2
                'if case equals three
            Case Is = 3
                'display card three
                picYouOne.Image = My.Resources.Card3
                'if case equals four
            Case Is = 4
                'display card four
                picYouOne.Image = My.Resources.Card4
                'if case equals five
            Case Is = 5
                'display card five
                picYouOne.Image = My.Resources.Card5
                'if case equals six
            Case Is = 6
                'display card six
                picYouOne.Image = My.Resources.Card6
                'if case quals seven
            Case Is = 7
                'display card seven
                picYouOne.Image = My.Resources.Card7
                'if case equals eight
            Case Is = 8
                'display card eight
                picYouOne.Image = My.Resources.Card8
                'if case equals nine
            Case Is = 9
                'display card nine
                picYouOne.Image = My.Resources.Card9
                'if case equals 10
            Case Is = 10
                'display card 10
                picYouOne.Image = My.Resources.Card10
        End Select

        'cases for value of user card two
        Select Case intYouTwo
            'if case equals one
            Case Is = 1
                'display card one
                picYouTwo.Image = My.Resources.Card1
                'if case equals two
            Case Is = 2
                'display card two
                picYouTwo.Image = My.Resources.Card2
                'if case equals three
            Case Is = 3
                'display card three
                picYouTwo.Image = My.Resources.Card3
                'if case equals four
            Case Is = 4
                'display card four
                picYouTwo.Image = My.Resources.Card4
                'if case equals five
            Case Is = 5
                'display card five
                picYouTwo.Image = My.Resources.Card5
                'if case equals six
            Case Is = 6
                'display card six
                picYouTwo.Image = My.Resources.Card6
                'if case quals seven
            Case Is = 7
                'display card seven
                picYouTwo.Image = My.Resources.Card7
                'if case equals eight
            Case Is = 8
                'display card eight
                picYouTwo.Image = My.Resources.Card8
                'if case equals nine
            Case Is = 9
                'display card nine
                picYouTwo.Image = My.Resources.Card9
                'if case equals 10
            Case Is = 10
                'display card 10
                picYouTwo.Image = My.Resources.Card10
        End Select

        'cases for value of user card three
        Select Case intYouThree
            'if case equals one
            Case Is = 1
                'display card one
                picYouThree.Image = My.Resources.Card1
                'if case equals two
            Case Is = 2
                'display card two
                picYouThree.Image = My.Resources.Card2
                'if case equals three
            Case Is = 3
                'display card three
                picYouThree.Image = My.Resources.Card3
                'if case equals four
            Case Is = 4
                'display card four
                picYouThree.Image = My.Resources.Card4
                'if case equals five
            Case Is = 5
                'display card five
                picYouThree.Image = My.Resources.Card5
                'if case equals six
            Case Is = 6
                'display card six
                picYouThree.Image = My.Resources.Card6
                'if case quals seven
            Case Is = 7
                'display card seven
                picYouThree.Image = My.Resources.Card7
                'if case equals eight
            Case Is = 8
                'display card eight
                picYouThree.Image = My.Resources.Card8
                'if case equals nine
            Case Is = 9
                'display card nine
                picYouThree.Image = My.Resources.Card9
                'if case equals 10
            Case Is = 10
                'display card 10
                picYouThree.Image = My.Resources.Card10
        End Select

        'cases for value of computer card one
        Select Case intCompOne
            'if case equals one
            Case Is = 1
                'display card one
                picCompOne.Image = My.Resources.Card1
                'if case equals two
            Case Is = 2
                'display card two
                picCompOne.Image = My.Resources.Card2
                'if case equals three
            Case Is = 3
                'display card three
                picCompOne.Image = My.Resources.Card3
                'if case equals four
            Case Is = 4
                'display card four
                picCompOne.Image = My.Resources.Card4
                'if case equals five
            Case Is = 5
                'display card five
                picCompOne.Image = My.Resources.Card5
                'if case equals six
            Case Is = 6
                'display card six
                picCompOne.Image = My.Resources.Card6
                'if case quals seven
            Case Is = 7
                'display card seven
                picCompOne.Image = My.Resources.Card7
                'if case equals eight
            Case Is = 8
                'display card eight
                picCompOne.Image = My.Resources.Card8
                'if case equals nine
            Case Is = 9
                'display card nine
                picCompOne.Image = My.Resources.Card9
                'if case equals 10
            Case Is = 10
                'display card 10
                picCompOne.Image = My.Resources.Card10
        End Select

        'cases for value of computer card two
        Select Case intCompTwo
            'if case equals one
            Case Is = 1
                'display card one
                picCompTwo.Image = My.Resources.Card1
                'if case equals two
            Case Is = 2
                'display card two
                picCompTwo.Image = My.Resources.Card2
                'if case equals three
            Case Is = 3
                'display card three
                picCompTwo.Image = My.Resources.Card3
                'if case equals four
            Case Is = 4
                'display card four
                picCompTwo.Image = My.Resources.Card4
                'if case equals five
            Case Is = 5
                'display card five
                picCompTwo.Image = My.Resources.Card5
                'if case equals six
            Case Is = 6
                'display card six
                picCompTwo.Image = My.Resources.Card6
                'if case quals seven
            Case Is = 7
                'display card seven
                picCompTwo.Image = My.Resources.Card7
                'if case equals eight
            Case Is = 8
                'display card eight
                picCompTwo.Image = My.Resources.Card8
                'if case equals nine
            Case Is = 9
                'display card nine
                picCompTwo.Image = My.Resources.Card9
                'if case equals 10
            Case Is = 10
                'display card 10
                picCompTwo.Image = My.Resources.Card10
        End Select

        'cases for value of computer card three
        Select Case intCompThree
            'if case equals one
            Case Is = 1
                'display card one
                picCompThree.Image = My.Resources.Card1
                'if case equals two
            Case Is = 2
                'display card two
                picCompThree.Image = My.Resources.Card2
                'if case equals three
            Case Is = 3
                'display card three
                picCompThree.Image = My.Resources.Card3
                'if case equals four
            Case Is = 4
                'display card four
                picCompThree.Image = My.Resources.Card4
                'if case equals five
            Case Is = 5
                'display card five
                picCompThree.Image = My.Resources.Card5
                'if case equals six
            Case Is = 6
                'display card six
                picCompThree.Image = My.Resources.Card6
                'if case quals seven
            Case Is = 7
                'display card seven
                picCompThree.Image = My.Resources.Card7
                'if case equals eight
            Case Is = 8
                'display card eight
                picCompThree.Image = My.Resources.Card8
                'if case equals nine
            Case Is = 9
                'display card nine
                picCompThree.Image = My.Resources.Card9
                'if case equals 10
            Case Is = 10
                'display card 10
                picCompThree.Image = My.Resources.Card10
        End Select

        'adding up user cards
        intYouSum = intYouOne + intYouTwo + intYouThree
        'displaying user total
        lblYouSum.Text = intYouSum
        'adding up computer cards
        intCompSum = intCompOne + intCompTwo + intCompThree
        'displaying computer total
        lblCompSum.Text = intCompSum

        'if user sum > computer sum then
        If intYouSum > intCompSum Then
            'displaying message for user win
            lblWinner.Text = "You Win"
            'adding one to user win amount
            intYouWin = intYouWin + 1
            'if comp sum > user sum then
        ElseIf intCompSum > intYouSum Then
            'displaying message for computer win
            lblWinner.Text = "Computer Win"
            'adding one to computer win amount
            intCompWin = intCompWin + 1
            'if user sum = computer sum then
        ElseIf intYouSum = intCompSum Then
            'displaying message to draw
            lblWinner.Text = "Draw"
            'adding one to draws amount
            intDraw = intDraw + 1
        End If

        'displaying user win amount
        lblYouWin.Text = "You: " & intYouWin
        'displying computer win amount
        lblCompWin.Text = "Computer: " & intCompWin
        'displaying draws amount
        lblDraws.Text = "Draws: " & intDraw

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
End Class
