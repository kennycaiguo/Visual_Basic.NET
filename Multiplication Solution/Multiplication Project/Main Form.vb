' Name:         Multiplication Project
' Purpose:      Display a multiplication table that shows
'               the multiplicand, multiplier, and product
' Programmer:   Wilman Gonzales on 9/21/14

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Dim timeTable As Integer
    Private Sub frmMain_Load(ByVal sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtNumber.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        If txtNumber.Text = "" Then
            MsgBox("Enter a number to be multiple", MsgBoxStyle.Information, "Display Table")
            txtNumber.Focus()
        Else
            For Me.timeTable = 1 To 12
                listBox.Items.Add(timeTable & "x" & txtNumber.Text & "=" & timeTable * CDbl(txtNumber.Text))

            Next

        End If
    End Sub

   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtNumber.Text = String.Empty
        listBox.Items.Clear()

    End Sub
End Class
