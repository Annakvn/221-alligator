'Project name:          Alligator Project
'Project purpose:       Display total annual allowance
'Created/revised by:    Anna Kovneva by February 16,2017

Option Explicit On
Option Infer Off
Option Strict On

Public Class MainForm
    Private Sub printPreviewButton_Click(sender As Object, e As EventArgs) Handles printPreviewButton.Click
        PrintForm1.Print()

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        'calculate and display the total annnual allowance

        Const MonthlyAllowance As Integer = 200
        Dim people As Integer
        Dim annualAllow As Integer

        'store user input in a variable
        Integer.TryParse(peopleTextBox.Text, people)

        'calculate the total annual allowance
        annualAllow = people * MonthlyAllowance * 12

        'display total annual allowance 
        totalLabel.Text = annualAllow.ToString("C0")
    End Sub
End Class
