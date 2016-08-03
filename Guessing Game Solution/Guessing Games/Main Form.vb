

' Name:         Guessing Game
' Purpose:      Guess the Number
' Programmer:   Wilman Gonzales on 9/21/14
Public Class Form1
    Dim guesses As Integer
    Dim CG As Integer
    Dim prng As New Random


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = Button3
        Button3.Enabled = False

    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        'THIS IS A NEW GAME
        CG = prng.Next(1, 26)
        guesses = 0
        TextBox1.Text = ("")
        TextBox1.Select()
        Button3.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim R As DialogResult
        R = MessageBox.Show("Are you sure you want to quit?", "Game Quit", MessageBoxButtons.YesNo)
        If R = Windows.Forms.DialogResult.No Then
            Button1.PerformClick()
        ElseIf R = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Guess
        Dim UG As Integer
        If Integer.TryParse(TextBox1.Text, UG) Then
            guesses = guesses + 1
            If UG = CG Then
                MessageBox.Show("You are correct, You guessed the Number!")
                Button3.Enabled = False
                'To start the game
            ElseIf guesses = 5 Then
                MessageBox.Show("That was the Fifth chance, it was your last Guess")
                Button3.Enabled = False
                'end current game here
            ElseIf UG < CG Then
                MessageBox.Show("Guess Higher")
            ElseIf UG > CG Then
                MessageBox.Show("Guess Lower")
            End If
            TextBox1.SelectAll()
        Else
            MessageBox.Show("Please enter a number and try again")
        End If
    End Sub



End Class
