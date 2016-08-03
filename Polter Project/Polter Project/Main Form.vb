' Name:         Polter Project
' Purpose:      Displays the records contained in a dataset
'               Also allows the user to display specific records
' Programmer:   Wilman Gonzales 10/26/2014

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProductsDataSet.tblProducts' table. You can move, or remove it, as needed.
        Me.TblProductsTableAdapter.Fill(Me.ProductsDataSet.tblProducts)
        TblProductsBindingSource.Sort = "ItemNum"
    End Sub






    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub



    Private Sub txtNumber_Enter(sender As Object, e As EventArgs) Handles txtNumber.Enter
        txtNumber.SelectAll()
    End Sub




    Private Sub txtPrice_Enter(sender As Object, e As EventArgs) Handles txtPrice.Enter
        txtPrice.SelectAll()
    End Sub




    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        ' this allows the text box to accept numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub





    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        ' this selects all of the fields and records
        TblProductsTableAdapter.Fill(ProductsDataSet.tblProducts)
    End Sub





    Private Sub btnNumber_Click(sender As Object, e As EventArgs) Handles btnNumber.Click
        ' this selects the record for a specific item number
        If txtNumber.Text.Trim <> String.Empty Then
            TblProductsTableAdapter.FillByItemNum(ProductsDataSet.tblProducts, txtNumber.Text.Trim)
        Else
            MessageBox.Show("Please enter the item number.", "Polter Industries",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub




    Private Sub btnPrice_Click(sender As Object, e As EventArgs) Handles btnPrice.Click
        ' this selects the records whose prices are at least the value entered
        Dim intPrice As Integer
        If txtPrice.Text <> String.Empty Then
            Integer.TryParse(txtPrice.Text, intPrice)
            TblProductsTableAdapter.FillByPrice(ProductsDataSet.tblProducts, intPrice)
        Else
            MessageBox.Show("Please enter the price.", "Polter Industries",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub



End Class
