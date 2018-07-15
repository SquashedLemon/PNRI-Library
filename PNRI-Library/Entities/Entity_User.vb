Public Class Entity_User
    Private Shared UserID As String
    Private Shared Username As String
    Private Shared Password As String
    Private Shared Firstname As String
    Private Shared Lastname As String
    Private Shared Type As String

    Public Property IDValue() As String
        Get
            Return UserID
        End Get
        Set(ByVal value As String)
            UserID = value
        End Set
    End Property

    Public Property UsernameValue() As String
        Get
            Return Username
        End Get
        Set(ByVal value As String)
            Username = value
        End Set
    End Property

    Public Property PasswordValue() As String
        Get
            Return Password
        End Get
        Set(ByVal value As String)
            Password = value
        End Set
    End Property

    Public Property FirstnameValue() As String
        Get
            Return Firstname
        End Get
        Set(ByVal value As String)
            Firstname = value
        End Set
    End Property

    Public Property LastnameValue() As String
        Get
            Return Lastname
        End Get
        Set(ByVal value As String)
            Lastname = value
        End Set
    End Property

    Public Property TypeValue() As String
        Get
            Return Type
        End Get
        Set(ByVal value As String)
            Type = value
        End Set
    End Property
End Class
