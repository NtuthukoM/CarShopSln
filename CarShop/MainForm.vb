Public Class MainForm
    Private Sub NewClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewClientToolStripMenuItem.Click
        For Each form In Me.MdiChildren
            If form.GetType().Name.Equals(NewClientForm.GetType().Name) Then
                Return
            End If
        Next
        Dim client = New NewClientForm With {
            .MdiParent = Me
        }
        client.Show()
    End Sub

    Private Sub FinanceCalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinanceCalculatorToolStripMenuItem.Click
        For Each form In Me.MdiChildren
            If form.GetType().Name.Equals(FinanceCalculatorForm.GetType().Name) Then
                Return
            End If
        Next
        Dim calc As New FinanceCalculatorForm With {
            .MdiParent = Me
        }
        calc.Show()
    End Sub

    Private Sub DisplayPreviousQuotesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayPreviousQuotesToolStripMenuItem.Click
        For Each form In Me.MdiChildren
            If form.GetType().Name.Equals(QuotesForm.GetType().Name) Then
                Return
            End If
        Next
        Dim quote = New QuotesForm With {
            .MdiParent = Me
        }
        quote.Show()
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click

    End Sub
End Class
