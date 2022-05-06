Public Class frmHangman

    Private Sub cmdPlay_Click(sender As Object, e As EventArgs) Handles cmdPlay.Click

        'defining variables
        Dim intRandomNumber As Integer
        Dim strRandomWord As String
        Dim intRandomWordLength As Integer
        Dim strSecretWord As String
        Dim strSecretWordGuess As String
        Dim intNumberOfGuesses As Integer
        Dim intLetterPos As Integer
        Dim intLoop As Integer

        'generating random numbers from one to ten
        intRandomNumber = Int(Rnd() * 10) + 3

        'generating ten random words
        If intRandomNumber = 3 Then
            strRandomWord = "sum"
            lblRandomWord.Text = strRandomWord
        ElseIf intRandomNumber = 4 Then
            strRandomWord = "area"
            lblRandomWord.Text = strRandomWord
        ElseIf intRandomNumber = 5 Then
            strRandomWord = "error"
            lblRandomWord.Text = strRandomWord
        ElseIf intRandomNumber = 6 Then
            strRandomWord = "single"
            lblRandomWord.Text = strRandomWord
        ElseIf intRandomNumber = 7 Then
            strRandomWord = "network"
            lblRandomWord.Text = strRandomWord
        ElseIf intRandomNumber = 8 Then
            strRandomWord = "cylinder"
            lblRandomWord.Text = strRandomWord
        ElseIf intRandomNumber = 9 Then
            strRandomWord = "reduction"
            lblRandomWord.Text = strRandomWord
        ElseIf intRandomNumber = 10 Then
            strRandomWord = "artificial"
            lblRandomWord.Text = strRandomWord
        ElseIf intRandomNumber = 11 Then
            strRandomWord = "calculation"
            lblRandomWord.Text = strRandomWord
        ElseIf intRandomNumber = 12 Then
            strRandomWord = "continuation"
            lblRandomWord.Text = strRandomWord
        End If

        'getting length of random word
        intRandomWordLength = Len(strRandomWord)
        'getting random word in asterisks
        strSecretWord = StrDup(intRandomWordLength, "*")
        'displaying random word in asterisks
        lblRandomWord.Text = strSecretWord

        'looping until user enters "!" into input box
        Do Until strSecretWordGuess = "!"
            'receiving letter guessed from user
            strSecretWordGuess = InputBox("Guess a letter, type (!) to guess a word", "Hangman")
            'calculating number of letter guesses
            intNumberOfGuesses = intNumberOfGuesses + 1
            'looping for number of characters in random word
            For intLoop = 1 To intRandomWordLength
                'checking position of letter guessed in random word
                intLetterPos = InStr(intLoop, strRandomWord, strSecretWordGuess)
                'if letter position is not zero then
                If intLetterPos <> 0 Then
                    'replacing letter guessed in secret word
                    Mid(strSecretWord, intLetterPos, 1) = strSecretWordGuess
                End If
                'displaying updated secret word
                lblRandomWord.Text = strSecretWord
            Next
        Loop

        'if user enters "!" into input box then
        If strSecretWordGuess = "!" Then
            'receiving word guessed from user
            strSecretWordGuess = InputBox("Guess a word, (you only have ONE attempt)", "Hangman")
            'removing one guess for when "!" is entered
            intNumberOfGuesses = intNumberOfGuesses - 1
            'if word guessed is equal to random word then
            If strSecretWordGuess = strRandomWord Then
                'displaying random word to user
                lblRandomWord.Text = strRandomWord
                'displaying amount of attempts to user
                MsgBox("It took you " & intNumberOfGuesses & " attempts to guess the word")
            Else
                'telling to user to try again after loss
                MsgBox("You have lost the game, press play to try again")
            End If
        End If

    End Sub

    Private Sub frmHangman_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'randomizing numbers
        Randomize()

    End Sub

    Private Sub cmdDone_Click(sender As Object, e As EventArgs) Handles cmdDone.Click

        'ending application
        End

    End Sub
End Class


