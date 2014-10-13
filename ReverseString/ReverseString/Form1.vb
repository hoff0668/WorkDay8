Option Strict On

Public Class Form1

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim st As String = txtInput.Text

        ' Please write your code here!

        Dim str As String = txtInput.Text
        Dim strReverse As String = " "

        For i As Integer = str.Length - 1 To 0 Step -1
            strReverse = strReverse & str.Chars(i)

        Next


        txtOutput.Text = strReverse
    End Sub
End Class
