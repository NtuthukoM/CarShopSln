Public Class MainForm
    Private Sub NewClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewClientToolStripMenuItem.Click
        Dim client = New NewClientForm With {
            .MdiParent = Me
        }
        client.Show()
    End Sub

    Private Sub FinanceCalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinanceCalculatorToolStripMenuItem.Click
        Dim calc As New FinanceCalculatorForm With {
            .MdiParent = Me
        }
        calc.Show()
    End Sub

    Private Sub DisplayPreviousQuotesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayPreviousQuotesToolStripMenuItem.Click
        Dim quote = New QuotesForm With {
            .MdiParent = Me
        }
        quote.Show()
    End Sub
End Class
