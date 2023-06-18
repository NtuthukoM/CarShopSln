Public Class Quote
    Private _ClientNumber As String
    Public Property ClientNumber() As String
        Get
            Return _ClientNumber
        End Get
        Set(ByVal value As String)
            _ClientNumber = value
        End Set
    End Property

    Private _PurchasePrice As String
    Public Property PurchasePrice() As String
        Get
            Return _PurchasePrice
        End Get
        Set(ByVal value As String)
            _PurchasePrice = value
        End Set
    End Property
    Private _Deposit As String
    Public Property Deposit() As String
        Get
            Return _Deposit
        End Get
        Set(ByVal value As String)
            _Deposit = value
        End Set
    End Property

    Private _PaymentTerm As String
    Public Property PaymentTerm() As String
        Get
            Return _PaymentTerm
        End Get
        Set(ByVal value As String)
            _PaymentTerm = value
        End Set
    End Property

    Private _BalloonPaymentPerc As String
    Public Property BalloonPaymentPerc() As String
        Get
            Return _BalloonPaymentPerc
        End Get
        Set(ByVal value As String)
            _BalloonPaymentPerc = value
        End Set
    End Property
    Private _InterestRatePerc As String
    Public Property InterestRatePerc() As String
        Get
            Return _InterestRatePerc
        End Get
        Set(ByVal value As String)
            _InterestRatePerc = value
        End Set
    End Property
    Private _RepaymentValue As String
    Public Property RepaymentValue() As String
        Get
            Return _RepaymentValue
        End Get
        Set(ByVal value As String)
            _RepaymentValue = value
        End Set
    End Property
    Private _MonthlyPayment As String
    Public Property MonthlyPayment() As String
        Get
            Return _MonthlyPayment
        End Get
        Set(ByVal value As String)
            _MonthlyPayment = value
        End Set
    End Property
    Private _BalloonPayment As String
    Public Property BalloonPayment() As String
        Get
            Return _BalloonPayment
        End Get
        Set(ByVal value As String)
            _BalloonPayment = value
        End Set
    End Property
    Private _InterestRate As String
    Public Property InterestAmount() As String
        Get
            Return _InterestRate
        End Get
        Set(ByVal value As String)
            _InterestRate = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return String.Format("{0},{1},{2},{3},{4},{5},{6},{7}",
                             ClientNumber, PurchasePrice, Deposit, PaymentTerm, BalloonPaymentPerc, InterestRatePerc, MonthlyPayment, BalloonPayment)
    End Function
End Class
