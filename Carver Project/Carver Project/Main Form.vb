' Name:         Carver Project
' Purpose:      Displays a grade based on the number of points the user enters
' Programmer:   Wilman Gonzales 10/04/2014

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtPoints_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPoints.Enter

        txtPoints.SelectAll()
    End Sub

    Private Sub txtPoints_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPoints.KeyPress
        ' accepts only numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtPoints_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPoints.TextChanged
        lblGrade.Text = String.Empty
    End Sub

    Private Sub btnDisplay_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        ' Display the letter grade associated with a students total points earned.

        Dim intGrade As Integer
        Dim searchForPoints As Integer
        Dim intPoints() As Integer = {450, 400, 350, 300, 0}
        Dim strGrades() As String = {"A", "B", "C", "D", "F"}
        searchForPoints = Integer.Parse(Me.txtPoints.Text)

        ' Search the array for the grades

        For intGrade = 0 To 4

            If searchForPoints < intPoints(intGrade) Then
                lblGrade.Text = strGrades(intGrade + 1)

            ElseIf searchForPoints = intPoints(intGrade) Or searchForPoints < intPoints(intGrade) Then
                lblGrade.Text = strGrades(intGrade)

            ElseIf searchForPoints > 450 Then
                searchForPoints = intPoints(intGrade)
                lblGrade.Text = strGrades(intGrade)
            End If
        Next

    End Sub
End Class
