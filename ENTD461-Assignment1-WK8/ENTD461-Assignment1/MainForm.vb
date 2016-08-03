'Wilman Gonzales
'week 8

Public Class MainForm


    Private Sub NewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem1.Click
        Dim calcForm As New CalcForm()
        calcForm.MdiParent = Me
        calcForm.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub
End Class