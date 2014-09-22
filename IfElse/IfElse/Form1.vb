Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim num1, num2, largerNum As Double

        ' Modify the program such that it does not crash 
        ' if the user types incorrect input

        Dim st1 As String = txtFirstNum.Text
        Dim st2 As String = txtSecondNum.Text

        'Checkpoint to see where user input it' return allows you to jump to the end and skip over the rest of the code
        If Not (IsNumeric(st1) And IsNumeric(st2)) Then
            MessageBox.Show("Please type the numbers")
            Return
        End If

        'clean area, a good place to start over'
        num1 = CDbl(st1)
        num2 = CDbl(st2)

        'chekcpoint 2 to see if the user input is correct'
        If Not (num1 >= 0 And num2 >= 0) Then
            MessageBox.Show("Please type non-negative numbers")
            Return
        End If



        Dim result As String

        If num1 > num2 Then
            result = "The larger number is " & num1
        ElseIf num2 > num1 Then
            result = "The larger number is " & num2
        Else
            result = "They are equal"
        End If

        txtResult.Text = result
        Else
        MessageBox.Show("Please type the numbers")

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
