
'Name:Wilman Gonzales
'Assignment 1 week 2
'03/15/2015


Imports System.IO

Public Class Calculator

    Dim Num1 As Decimal
    Dim Num2 As Decimal
    Dim Num3 As Decimal
    Dim blnSave As Boolean 'this is an indicator if save button was pressed

    Private Sub ButtonAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click
        Num1 = TextBoxNum1.Text
        Num2 = TextBoxNum2.Text
        Num3 = Num1 + Num2
        TextBoxNum3.Text = Num3
    End Sub

    Private Sub ButtonSubtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSubtract.Click
        Num1 = TextBoxNum1.Text
        Num2 = TextBoxNum2.Text
        Num3 = Num1 - Num2
        TextBoxNum3.Text = Num3
    End Sub

    Private Sub ButtonMultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMultiply.Click
        Num1 = TextBoxNum1.Text
        Num2 = TextBoxNum2.Text
        Num3 = Num1 * Num2
        TextBoxNum3.Text = Num3
    End Sub

    Private Sub ButtonDivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDivide.Click
        Num1 = TextBoxNum1.Text
        Num2 = TextBoxNum2.Text
        Try
            Num3 = Num1 / Num2
            ' zero is not allowed for divisions
        Catch ex As DivideByZeroException When Num2 = 0
            MessageBox.Show("Cannot divide by 0, Please try again")
            TextBoxNum2.Focus()
        End Try
        TextBoxNum3.Text = Num3

    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clear everything when clear button is pressed 
        ListBox1.Items.Clear()
        TextBoxNum1.Text = ""
        TextBoxNum2.Text = ""
        TextBoxNum3.Text = ""

        My.Computer.FileSystem.WriteAllText("test.txt", "", False)
    End Sub

    'Saves the numbers that the user writes
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("test.txt", True)
        file.Write(TextBoxNum1.Text)
        file.Write(TextBoxNum2.Text)
        file.Write("=")
        file.Write(TextBoxNum3.Text)
        file.WriteLine()
        file.Close()
    End Sub
    ' thisplay number1, number2 and the result in the listbox
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim lines() As String = IO.File.ReadAllLines("test.txt")
        ListBox1.Items.AddRange(lines)
    End Sub
End Class
