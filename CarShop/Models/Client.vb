Public Class Client
    Private _ClientNumber As String
    Public Property ClientNumber() As String
        Get
            Return _ClientNumber
        End Get
        Set(ByVal value As String)
            _ClientNumber = value
        End Set
    End Property
    Private _Name As String
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property
    Private _Surname As String
    Public Property Surname() As String
        Get
            Return _Surname
        End Get
        Set(ByVal value As String)
            _Surname = value
        End Set
    End Property

    Private _SaIdNumber As String
    Public Property SaIdNumber() As String
        Get
            Return _SaIdNumber
        End Get
        Set(ByVal value As String)
            _SaIdNumber = value
        End Set
    End Property

    Private _PassportNumber As String
    Public Property PassportNumber() As String
        Get
            Return _PassportNumber
        End Get
        Set(ByVal value As String)
            _PassportNumber = value
        End Set
    End Property
    Private _DateOfBirth As String
    Public Property DateOfBirth() As String
        Get
            Return _DateOfBirth
        End Get
        Set(ByVal value As String)
            _DateOfBirth = value
        End Set
    End Property

    Private _Email As String
    Public Property Email() As String
        Get
            Return _Email
        End Get
        Set(ByVal value As String)
            _Email = value
        End Set
    End Property

    Private _ContactNumber As String
    Public Property ContactNumber() As String
        Get
            Return _ContactNumber
        End Get
        Set(ByVal value As String)
            _ContactNumber = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return String.Format("{0},{1},{2},{3},{4},{5},{6},{7}",
            ClientNumber, Name, Surname, SaIdNumber, PassportNumber, DateOfBirth, Email, ContactNumber)
    End Function
End Class
