Public Class MainForm
    Private Sub NewClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewClientToolStripMenuItem.Click

        Dim client = New NewClientForm
        client.MdiParent = Me
        client.Show()
    End Sub

    Private Sub FinanceCalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinanceCalculatorToolStripMenuItem.Click
        Dim quote = New QuotesForm
        quote.MdiParent = Me
        quote.Show()
    End Sub
End Class
