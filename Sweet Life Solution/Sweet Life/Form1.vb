

'Name: Sweet Life Project
'Purpose: Calculate order
'Programmer: Wilmna Gonzales

Option Explicit On
Option Strict Off
Option Infer Off

Public Class Form1
    Dim t As String = 0.65
    Dim u As String = 0.65
    Dim v As String = 0.85
    Dim w As String = 1.0
    Dim x As String = 0
    Dim y As String = 1.8
    Dim z As String = 2.5
    Dim tax As String = 0.07
    Dim a As String
    Dim b As String
  


    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case True


            Case RadioButton1.Checked
                a = 0.65

            Case RadioButton2.Checked
                a = 0.65
            Case RadioButton3.Checked
                a = 0.85
            Case RadioButton4.Checked
                a = 1.0
        End Select

        Select Case True

            Case RadioButton5.Checked
                b = 0
            Case RadioButton6.Checked
                b = 1.8
            Case RadioButton7.Checked
                b = 2.5
        End Select



        TextBox1.Text = Val(a) + Val(b)
        TextBox2.Text = Val(TextBox1.Text) * Val(tax)



        TextBox3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
    End Sub


    
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
