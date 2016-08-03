
Option Explicit On
Option Strict Off
Option Infer Off

Public Class frmMain



    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty
        TextBox3.Text = String.Empty
        TextBox1.BackColor = Color.White
        TextBox2.BackColor = Color.White
        TextBox3.BackColor = Color.White

    End Sub


    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If TextBox1.Text = "Rojo" OrElse TextBox1.Text = "rojo" OrElse TextBox1.Text = "ROJO" Then

            TextBox1.Text = "correct"
            TextBox1.BackColor = Color.Red
        Else
            TextBox1.Text = "Incorrect It is Rojo"


        End If
    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If TextBox2.Text = "Azul" OrElse TextBox2.Text = "azul" OrElse TextBox2.Text = "AZUL" Then

            TextBox2.Text = "correct"
            TextBox2.BackColor = Color.Blue
        Else
            TextBox2.Text = "Incorrect It is Azul"

        End If
    End Sub





    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If TextBox3.Text = "Verde" OrElse TextBox3.Text = "verde" OrElse TextBox3.Text = "VERDE" Then

            TextBox3.Text = "correct"
            TextBox3.BackColor = Color.Green
        Else
            TextBox3.Text = "Incorrect It is Verde"

        End If


    End Sub
End Class
