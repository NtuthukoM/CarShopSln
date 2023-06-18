Public Class QuotesForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'load quotes:
        Dim qMan = New QuoteManager
        Dim quotes As New List(Of Quote)
        quotes = qMan.GetQuotes()
        dgQuotes.DataSource = quotes
    End Sub
End Class