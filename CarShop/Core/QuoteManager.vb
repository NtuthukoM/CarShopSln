Imports System.IO

Public Class QuoteManager

    Private _QuoteFile As String = "quote.txt"
    Public Sub SaveQuote(quote As Quote)
        Dim fileWriter As StreamWriter
        fileWriter = New StreamWriter(_QuoteFile, True)
        fileWriter.WriteLine(quote.ToString())
        fileWriter.Close()
    End Sub

    Public Sub Calculate(quote As Quote)
        Dim purchasePrice = CType(quote.PurchasePrice, Decimal)
        Dim deposit = CType(quote.Deposit, Decimal)
        Dim balloon = (purchasePrice * CType(quote.BalloonPaymentPerc, Decimal)) / 100
        Dim financeAmt = purchasePrice - deposit - balloon
        Dim interestPayment = financeAmt * (CType(quote.InterestRatePerc, Decimal) / 100)
        Dim monthlyPayment = (financeAmt + interestPayment) / CType(quote.PaymentTerm, Int32)
        'Set values:
        quote.BalloonPayment = Math.Round(balloon, 2).ToString
        quote.RepaymentValue = Math.Round(financeAmt, 2).ToString
        quote.InterestAmount = Math.Round(interestPayment, 2).ToString
        quote.MonthlyPayment = Math.Round(monthlyPayment, 2).ToString

    End Sub



    Public Function CheckForNumeric(contactNumber As String) As Boolean
        Dim validator = New NumberValidator
        Return validator.CheckForNumeric(contactNumber)
    End Function

    Public Function GetQuotes() As List(Of Quote)
        Dim quotes As New List(Of Quote)
        If (File.Exists(_QuoteFile)) Then
            Dim fileReader As StreamReader
            fileReader = New StreamReader(_QuoteFile)
            Dim line As String = ""
            Do While fileReader.Peek() <> -1 ' Loop until the end of the file is reached
                line = fileReader.ReadLine()
                Dim quoteArr = line.Split(",")
                Dim quote = New Quote
                quote.ClientNumber = quoteArr(0)
                quote.PurchasePrice = quoteArr(1)
                quote.Deposit = quoteArr(2)
                quote.PaymentTerm = quoteArr(3)
                quote.BalloonPaymentPerc = quoteArr(4)
                quote.InterestRatePerc = quoteArr(5)
                quote.MonthlyPayment = quoteArr(6)
                quote.BalloonPayment = quoteArr(7)
                quotes.Add(quote)
            Loop
            fileReader.Close()
        End If
        Return quotes
    End Function
End Class
