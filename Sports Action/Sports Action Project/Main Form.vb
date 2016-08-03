' Name:         Sports Action Project
' Purpose:      Displays the data from a dataset
'               Also displays the average of the home team's scores
' Programmer:   Wilman Gonzales 10/14/14

Option Explicit On
Option Strict On
Option Infer On
' using LINQ
'I was having a big problem trying to connect the access database. I solved by installing 2007 Office System Driver: Data Connectivity Components from micrososft
Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TblScoresTableAdapter.Fill(Me.SportsDataSet.tblScores)

    End Sub

    Private Sub btnAvgHome_Click(sender As Object, e As EventArgs) Handles btnAvgHome.Click

        Dim dblAvg As Double = Aggregate score In SportsDataSet.tblScores
                               Select score.HomeTeamScore Into Average()

        MessageBox.Show("Average home team score: " & dblAvg.ToString("N1"),
                        "Sports Action", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
