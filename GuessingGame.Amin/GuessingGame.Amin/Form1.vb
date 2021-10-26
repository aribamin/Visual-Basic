Public Class frmGuessingGame
    'declaring global variables
    Private intSecretNum As Integer
    Private intNumTries As Integer

    Private Sub cmdCheckGusess_Click(sender As Object, e As EventArgs) Handles cmdCheckGusess.Click
        'declaring variables and constants

        Dim intGuess As Integer

        'adding one to the number of guesses
        intNumTries = intNumTries + 1


        'getting the user's guess
        intGuess = txtGuess.Text

        'check to see if guess is correct
        If intGuess = intSecretNum Then
            'telling the user they're right
            lblGuessCheckedMessage.Text = "You guessed it! It took you " & intNumTries & " tries"
            'checking to see if the number is low
        ElseIf intGuess < intSecretNum Then
            'tell the user they are too low
            lblGuessCheckedMessage.Text = "Too Low!"
        Else
            'tell the user they are too high
            lblGuessCheckedMessage.Text = "Too High!"
        End If
    End Sub

    Private Sub cmdEnd_Click(sender As Object, e As EventArgs) Handles cmdEnd.Click
        'ends program
        End

    End Sub

    Private Sub frmGuessingGame_Load(sender As Object, e As EventArgs) Handles Me.Load
        'make number random
        Randomize()

        'generate a random number
        intSecretNum = Int(10 * Rnd()) + 1

    End Sub

    Private Sub txtGuess_TextChanged(sender As Object, e As EventArgs) Handles txtGuess.TextChanged

    End Sub
End Class
