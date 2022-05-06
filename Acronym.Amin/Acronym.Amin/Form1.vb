Public Class frmAcronym

    Private Sub cmdCreateAcronym_Click(sender As Object, e As EventArgs) Handles cmdCreateAcronym.Click

        'defining variables
        Dim strNumberOfWords As String
        Dim intLoop As Integer
        Dim strTempWord As String
        Dim strFirstCharacter As String
        Dim strAcronym As String


        'receiving number of words
        strNumberOfWords = InputBox("Please enter number of words", "Enter number of words", )

        'looping for nummber of words
        For intLoop = 1 To strNumberOfWords

            'receiving words from user
            strTempWord = InputBox("Please enter a word", "Enter a word", )

            'taking first character of word
            strFirstCharacter = Microsoft.VisualBasic.Left(strTempWord, 1)

            'making first character capital
            strFirstCharacter = UCase(strFirstCharacter)

            'adding first characters together
            strAcronym = strAcronym + strFirstCharacter
        Next

        'displaying first characters (strAcronym)
        lblAcronym.Text = "The acronym is " & strAcronym

    End Sub

    Private Sub cmdDone_Click(sender As Object, e As EventArgs) Handles cmdDone.Click

        'ending program
        End

    End Sub
End Class
