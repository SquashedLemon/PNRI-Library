Public Class Entity_Borrowers
    Private Shared BorrowerID As String
    Private Shared BorrowerFirstname As String
    Private Shared BorrowerLastname As String
    Private Shared BorrowerDivision As String
    Private Shared BorrowerSection As String
    Private Shared BorrowerUsername As String
    Private Shared BorrowerPassword As String
    Private Shared BorrowerContact As String
    Private Shared BorrowerAddress As String
    Private Shared BorrowerBarangay As String
    Private Shared BorrowerCity As String

    Public Property BorrowerIdValue() As String
        Get
            Return BorrowerID
        End Get
        Set(value As String)
            BorrowerID = value
        End Set
    End Property

    Public Property BorrowerFirstnameValue() As String
        Get
            Return BorrowerFirstname
        End Get
        Set(value As String)
            BorrowerFirstname = value
        End Set
    End Property

    Public Property BorrowerLastnameValue() As String
        Get
            Return BorrowerLastname
        End Get
        Set(value As String)
            BorrowerLastname = value
        End Set
    End Property

    Public Property BorrowerDivisionValue() As String
        Get
            Return BorrowerDivision
        End Get
        Set(value As String)
            BorrowerDivision = value
        End Set
    End Property

    Public Property BorrowerSectionValue() As String
        Get
            Return BorrowerSection
        End Get
        Set(value As String)
            BorrowerSection = value
        End Set
    End Property

    Public Property BorrowerUsernameValue() As String
        Get
            Return BorrowerUsername
        End Get
        Set(value As String)
            BorrowerUsername = value
        End Set
    End Property

    Public Property BorrowerPasswordValue() As String
        Get
            Return BorrowerPassword
        End Get
        Set(value As String)
            BorrowerPassword = value
        End Set
    End Property

    Public Property BorrowerAddressValue() As String
        Get
            Return BorrowerAddress
        End Get
        Set(value As String)
            BorrowerAddress = value
        End Set
    End Property

    Public Property BorrowerContactValue() As String
        Get
            Return BorrowerContact
        End Get
        Set(value As String)
            BorrowerContact = value
        End Set
    End Property

    Public Property BorrowerBarangayValue() As String
        Get
            Return BorrowerBarangay
        End Get
        Set(value As String)
            BorrowerBarangay = value
        End Set
    End Property

    Public Property BorrowerCityValue() As String
        Get
            Return BorrowerCity
        End Get
        Set(value As String)
            BorrowerCity = value
        End Set
    End Property
End Class
