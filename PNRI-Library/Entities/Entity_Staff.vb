Public Class Entity_Staff
    Private Shared StaffId As String
    Private Shared StaffFirstname As String
    Private Shared StaffLastname As String
    Private Shared StaffUsername As String
    Private Shared StaffPassword As String
    Private Shared StaffType As String

    Public Property StaffIdValue() As String
        Get
            Return StaffId
        End Get
        Set(value As String)
            StaffId = value
        End Set
    End Property

    Public Property StaffFirstnamValue() As String
        Get
            Return StaffFirstname
        End Get
        Set(value As String)
            StaffFirstname = value
        End Set
    End Property

    Public Property StaffLastnameValue() As String
        Get
            Return StaffLastname
        End Get
        Set(value As String)
            StaffLastname = value
        End Set
    End Property

    Public Property StaffUsernameValue() As String
        Get
            Return StaffUsername
        End Get
        Set(value As String)
            StaffUsername = value
        End Set
    End Property

    Public Property StaffPasswordValue() As String
        Get
            Return StaffPassword
        End Get
        Set(value As String)
            StaffPassword = value
        End Set
    End Property

    Public Property StaffTypeValue() As String
        Get
            Return StaffType
        End Get
        Set(value As String)
            StaffType = value
        End Set
    End Property
End Class
