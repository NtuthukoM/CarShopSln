Public Class FinanceCalculatorForm

    Private _QuoteManager As QuoteManager
    Private _Quote As Quote
    Private _ClientID As String = "MKH00001"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(clientID As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._ClientID = clientID
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ValidateInput() = True) Then
            _Quote.BalloonPaymentPerc = lblBalloon.Text
            _Quote.InterestRatePerc = lblInterestRate.Text
            _Quote.PaymentTerm = cbPaymentTerm.Text
            _Quote.PurchasePrice = txtPurchasePrice.Text
            _Quote.Deposit = txtDeposit.Text
            _QuoteManager.Calculate(_Quote)
            'Update UI:
            lblRepayment.Text = "R" + _Quote.MonthlyPayment
            lblAmountToFinance.Text = "R" + _Quote.RepaymentValue
            lblInterestAmt.Text = "R" + _Quote.InterestAmount
            lblBalloonAmount.ForeColor = Color.Red
            lblBalloonAmount.Text = String.Format("At the end of the payment term, you will still owe R{0} plus interset.", _Quote.BalloonPayment)
            btnWriteFile.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnWriteFile.Click
        _QuoteManager.SaveQuote(_Quote)
        btnWriteFile.Enabled = False
        MessageBox.Show("Quote saved.")
    End Sub

    Private Sub FinanceCalculatorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _QuoteManager = New QuoteManager
        _Quote = New Quote
        cbPaymentTerm.SelectedIndex = 0
        ResetCalculatedValues()
        lblClientID.Text = _ClientID
    End Sub

    Private Sub tbBalloon_Scroll(sender As Object, e As EventArgs) Handles tbBalloon.Scroll
        lblBalloon.Text = tbBalloon.Value.ToString
    End Sub

    Private Sub tbInterestRate_Scroll(sender As Object, e As EventArgs) Handles tbInterestRate.Scroll
        lblInterestRate.Text = tbInterestRate.Value.ToString
    End Sub

    Private Function ValidateInput() As Boolean
        ResetCalculatedValues()

        If _QuoteManager.CheckForNumeric(txtPurchasePrice.Text) = False Then
            lblPurchasePrice.ForeColor = Color.Red
            Return False
        End If
        If _QuoteManager.CheckForNumeric(txtDeposit.Text) = False Then
            lblDeposit.ForeColor = Color.Red
            Return False
        End If
        Return True
    End Function

    Private Sub ResetCalculatedValues()
        lblBalloonAmount.Text = ""
        lblAmountToFinance.Text = ""
        lblInterestAmt.Text = ""
        lblRepayment.Text = ""
        lblPurchasePrice.ForeColor = Color.Black
        lblDeposit.ForeColor = Color.Black
    End Sub

    Private Sub lblRepayment_Click(sender As Object, e As EventArgs) Handles lblRepayment.Click

    End Sub
End Class