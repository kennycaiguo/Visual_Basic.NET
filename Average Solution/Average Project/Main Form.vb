Public Class Form1
    'Developer Wilman

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox4.Text = Str((Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text)) / 3)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox4.Text = "" Then
            MsgBox("Please enter some text")
        Else
            PrintPreviewDialog1.ShowDialog()

        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font1 As New Font("arial", 16, FontStyle.Regular)
        e.Graphics.DrawString(TextBox4.Text, font1, Brushes.Black, 100, 100)



    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

        'this is the page'
    End Sub
End Class
