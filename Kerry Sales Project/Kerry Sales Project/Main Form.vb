' Name:         Kerry Sales Project
' Purpose:      Displays a salesperson's bonus
' Programmer:   Wilman Gonzales 10/09/14

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub txtSales_Enter(sender As Object, e As EventArgs) Handles txtSales.Enter
        txtSales.SelectAll()
    End Sub
    Private Sub txtSales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSales.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtSales_TextChanged(sender As Object, e As EventArgs) Handles txtSales.TextChanged
        lblBonus.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculates and displays the bonus

        Dim dblSales As Double
        Dim dblBonus As Double

        Double.TryParse(txtSales.Text, dblSales)

        ' if the sales are over $2500 it will instantiate a PremiumBonus object 
        
        If dblSales > 2500 Then
            Dim salesBonus As New PremiumBonus(txtId.Text, dblSales)
            dblBonus = salesBonus.GetBonus
        Else
            Dim salesBonus As New Bonus(txtId.Text, dblSales)
            dblBonus = salesBonus.GetBonus
        End If

        ' this will display the bonus
        lblBonus.Text = dblBonus.ToString("C2")
    End Sub
End Class
