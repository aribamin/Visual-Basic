Public Class frmMathTutor

    'defining vriables
    Dim intNumberOne As Integer
    Dim intNumberTwo As Integer
    Dim intOperator As Integer

    Private Sub frmMathTutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'randomizing numbers
        Randomize()

    End Sub

    Private Sub cmdNewProblem_Click(sender As Object, e As EventArgs) Handles cmdNewProblem.Click

        'changing to normal difficulty
        If radNormal.Checked = True Then
            'giving random number one range from 1 to 10
            intNumberOne = Int(10 * Rnd()) + 1
            'displaying random number one in the label
            lblNumberOne.Text = intNumberOne
            'giving random number two range from 1 to 10
            intNumberTwo = Int(10 * Rnd()) + 1
            'displaying random number two in the label
            lblNumberTwo.Text = intNumberTwo
        End If

        'changing to difficult difficulty
        If radDifficult.Checked = True Then
            'giving random number one range from 1 to 20
            intNumberOne = Int(20 * Rnd()) + 1
            'displaying ranom number one in the label
            lblNumberOne.Text = intNumberOne
            'giving random number two range from 1 to 20
            intNumberTwo = Int(20 * Rnd()) + 1
            'displaying random number two in the label
            lblNumberTwo.Text = intNumberTwo
        End If

        'giving operator range from 1 to 4
        intOperator = Int(4 * Rnd()) + 1

        'if operator is 1
        If intOperator = 1 Then
            'displaying plus sign 
            lblOperator.Text = "+"
        End If

        'if operator is 2
        If intOperator = 2 Then
            'displaying minus sign
            lblOperator.Text = "-"
        End If

        'if operator is 3
        If intOperator = 3 Then
            'displaying division sign
            lblOperator.Text = "/"
            'multiplying random number one by random number two
            intNumberOne = intNumberOne * intNumberTwo
            'displaying new random number one
            lblNumberOne.Text = intNumberOne
        End If

        'if operator is 4
        If intOperator = 4 Then
            'displaying multiplication sign
            lblOperator.Text = "x"
        End If

        'clearing text for user answer
        txtAnswer.Text = ""
        'clearing text for correct answer
        lblPrompt.Text = ""

    End Sub

    Private Sub cmdCheckAnswer_Click(sender As Object, e As EventArgs) Handles cmdCheckAnswer.Click

        'displaying variables
        Dim intUserAnswer As Integer
        Dim intCorrectAnswer As Integer

        'receiving user answer from textbox
        intUserAnswer = txtAnswer.Text

        'if operator is 1
        If intOperator = 1 Then
            'doing calculations for number one plus number two
            intCorrectAnswer = intNumberOne + intNumberTwo
        End If

        'if operator is 2
        If intOperator = 2 Then
            'doing calculations for number one minus number two
            intCorrectAnswer = intNumberOne - intNumberTwo
        End If

        'if operator is 3
        If intOperator = 3 Then
            'doing calculations for number one divided by number two
            intCorrectAnswer = intNumberOne / intNumberTwo
        End If

        'if operator is 4
        If intOperator = 4 Then
            'doing calculations for number one multiplied by number two
            intCorrectAnswer = intNumberOne * intNumberTwo
        End If

        'if user answer and correct answer are same
        If intUserAnswer = intCorrectAnswer Then
            'displaying message for correct answer
            lblPrompt.Text = "You are correct!!"
        Else
            'displaying message if user answer is not the same as correct answer
            lblPrompt.Text = "Sorry, the correct answer is " & intCorrectAnswer
        End If

    End Sub

    Private Sub cmdEnd_Click(sender As Object, e As EventArgs) Handles cmdEnd.Click

        'ending application
        End

    End Sub

    Private Sub radDifficult_CheckedChanged(sender As Object, e As EventArgs) Handles radDifficult.CheckedChanged

        'clearing text when difficulty diffucult
        lblOperator.Text = ""
        'clearing text for number one
        lblNumberOne.Text = ""
        'clearing text for number two
        lblNumberTwo.Text = ""
        'clearing text for correct answer
        lblPrompt.Text = ""
        'clearing text for user asnwer
        txtAnswer.Text = ""

    End Sub

    Private Sub radNormal_CheckedChanged(sender As Object, e As EventArgs) Handles radNormal.CheckedChanged

        'clearing text when difficult normal
        lblOperator.Text = ""
        'clearly text for number one
        lblNumberOne.Text = ""
        'clearly text for number two
        lblNumberTwo.Text = ""
        'clearing text for correct answer
        lblPrompt.Text = ""
        'clearing text for user answer
        txtAnswer.Text = ""

    End Sub
End Class
