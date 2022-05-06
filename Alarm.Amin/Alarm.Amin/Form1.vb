Public Class frmAlarm

    'Defining variables
    Dim strPasswordGuess As String
    Dim intPassLength As Integer
    Dim strBlurred As String

    Private Sub cmd1_Click(sender As Object, e As EventArgs) Handles cmd7.Click

        'Defining variables
        Dim strSeven As String = 7

        'adding pasword digits
        strPasswordGuess = strPasswordGuess + strSeven
        'getting length of guess
        intPassLength = Len(strPasswordGuess)
        'replacing with asteriks
        strBlurred = StrDup(intPassLength, "*")
        'displaying asteriks
        lblPassword.Text = strBlurred

    End Sub

    Private Sub cmd8_Click(sender As Object, e As EventArgs) Handles cmd8.Click

        'Defining variables
        Dim strEight As String = 8

        'adding pasword digits
        strPasswordGuess = strPasswordGuess + strEight
        'getting length of guess
        intPassLength = Len(strPasswordGuess)
        'replacing with asteriks
        strBlurred = StrDup(intPassLength, "*")
        'displaying asteriks
        lblPassword.Text = strBlurred

    End Sub

    Private Sub cmd9_Click(sender As Object, e As EventArgs) Handles cmd9.Click

        'Defining variables
        Dim strNine As String = 9

        'adding pasword digits
        strPasswordGuess = strPasswordGuess + strNine
        'getting length of guess
        intPassLength = Len(strPasswordGuess)
        'replacing with asteriks
        strBlurred = StrDup(intPassLength, "*")
        'displaying asteriks
        lblPassword.Text = strBlurred

    End Sub

    Private Sub cmd4_Click(sender As Object, e As EventArgs) Handles cmd4.Click

        'Defining variables
        Dim strFour As String = 4

        'adding pasword digits
        strPasswordGuess = strPasswordGuess + strFour
        'getting length of guess
        intPassLength = Len(strPasswordGuess)
        'replacing with asteriks
        strBlurred = StrDup(intPassLength, "*")
        'displaying asteriks
        lblPassword.Text = strBlurred

    End Sub

    Private Sub cmd5_Click(sender As Object, e As EventArgs) Handles cmd5.Click

        'Defining variables
        Dim strFive As String = 5

        'adding pasword digits
        strPasswordGuess = strPasswordGuess + strFive
        'getting length of guess
        intPassLength = Len(strPasswordGuess)
        'replacing with asteriks
        strBlurred = StrDup(intPassLength, "*")
        'displaying asteriks
        lblPassword.Text = strBlurred

    End Sub

    Private Sub cmd6_Click(sender As Object, e As EventArgs) Handles cmd6.Click

        'Defining variables
        Dim strSix As String = 6

        'adding pasword digits
        strPasswordGuess = strPasswordGuess + strSix
        'getting length of guess
        intPassLength = Len(strPasswordGuess)
        'replacing with asteriks
        strBlurred = StrDup(intPassLength, "*")
        'displaying asteriks
        lblPassword.Text = strBlurred

    End Sub

    Private Sub cmd1_Click_1(sender As Object, e As EventArgs) Handles cmd1.Click

        'Defining variables
        Dim strOne As String = 1

        'adding pasword digits
        strPasswordGuess = strPasswordGuess + strOne
        'getting length of guess
        intPassLength = Len(strPasswordGuess)
        'replacing with asteriks
        strBlurred = StrDup(intPassLength, "*")
        'displaying asteriks
        lblPassword.Text = strBlurred

    End Sub

    Private Sub cmd2_Click(sender As Object, e As EventArgs) Handles cmd2.Click

        'Defining variables
        Dim strTwo As String = 2

        'adding pasword digits
        strPasswordGuess = strPasswordGuess + strTwo
        'getting length of guess
        intPassLength = Len(strPasswordGuess)
        'replacing with asteriks
        strBlurred = StrDup(intPassLength, "*")
        'displaying asteriks
        lblPassword.Text = strBlurred

    End Sub

    Private Sub cmd3_Click(sender As Object, e As EventArgs) Handles cmd3.Click

        'Defining variables
        Dim strThree As String = 3

        'adding pasword digits
        strPasswordGuess = strPasswordGuess + strThree
        'getting length of guess
        intPassLength = Len(strPasswordGuess)
        'replacing with asteriks
        strBlurred = StrDup(intPassLength, "*")
        'displaying asteriks
        lblPassword.Text = strBlurred

    End Sub

    Private Sub cmd0_Click(sender As Object, e As EventArgs) Handles cmd0.Click

        'Defining variables
        Dim strZero As String = 0

        'adding pasword digits
        strPasswordGuess = strPasswordGuess + strZero
        'getting length of guess
        intPassLength = Len(strPasswordGuess)
        'replacing with asteriks
        strBlurred = StrDup(intPassLength, "*")
        'displaying asteriks
        lblPassword.Text = strBlurred

    End Sub

    '**********************************************************************************
    ' Returns True if strPassword = 62489
    '
    ' post: True returned if strPassword =62489
    ' otherwise False returned
    '**********************************************************************************
    Function CheckPass(ByVal strPassword As String) As Boolean

        'if password equals 62489
        If strPassword = "62489" Then
            'function equals true
            CheckPass = True
        Else
            'function equals flase
            CheckPass = False
        End If

    End Function

    '********************************************************
    ' Returns a message box corresponding to strPasswordGuess
    '
    ' post: a message box returned
    '********************************************************
    Private Sub cmdEnter_Click(sender As Object, e As EventArgs) Handles cmdEnter.Click

        'if check pass equals 62489
        If CheckPass(strPasswordGuess) Then
            'displaying correct
            MsgBox("You are correct")
            'clearing labels
            lblPassword.Text = ""
            strPasswordGuess = ""
        Else
            'displaying wrong
            MsgBox("You are wrong")
            'clearing lables
            lblPassword.Text = ""
            strPasswordGuess = ""
        End If

    End Sub
End Class
