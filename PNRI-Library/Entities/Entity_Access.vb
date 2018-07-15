Public Class Entity_Access
    Private Shared StaffAdd As Integer
    Private Shared StaffBorrow As Integer
    Private Shared StaffReturn As Integer
    Private Shared AdminAdd As Integer
    Private Shared AdminBorrow As Integer
    Private Shared AdminReturn As Integer
    Private Shared AdminAddStaff As Integer
    Private Shared AdminConfig As Integer
    Private Shared DefaultRecords As Integer
    Private Shared DefaultCatalog As Integer
    Private Shared DefaultView As Integer
    Private Shared DefaultAdminRecords As Integer
    Private Shared DefaultAdminCatalog As Integer
    Private Shared DefaultAdminView As Integer
    Private Shared DefaultDashboard As Integer

    Public Property StaffAddValue() As Boolean
        Get
            Return StaffAdd
        End Get
        Set(value As Boolean)
            StaffAdd = value
        End Set
    End Property

    Public Property StaffBorrowValue() As Boolean
        Get
            Return StaffBorrow
        End Get
        Set(value As Boolean)
            StaffBorrow = value
        End Set
    End Property

    Public Property StaffReturnValue() As Boolean
        Get
            Return StaffReturn
        End Get
        Set(value As Boolean)
            StaffReturn = value
        End Set
    End Property

    Public Property AdminAddValue() As Boolean
        Get
            Return AdminAdd
        End Get
        Set(value As Boolean)
            AdminAdd = value
        End Set
    End Property

    Public Property AdminBorrowValue() As Boolean
        Get
            Return AdminBorrow
        End Get
        Set(value As Boolean)
            AdminBorrow = value
        End Set
    End Property

    Public Property AdminReturnValue() As Boolean
        Get
            Return AdminReturn
        End Get
        Set(value As Boolean)
            AdminReturn = value
        End Set
    End Property

    Public Property AdminAddStaffValue() As Boolean
        Get
            Return AdminAddStaff
        End Get
        Set(value As Boolean)
            AdminAddStaff = value
        End Set
    End Property

    Public Property AdminConfigValue() As Boolean
        Get
            Return AdminConfig
        End Get
        Set(value As Boolean)
            AdminConfig = value
        End Set
    End Property

    Public Property DefaultRecordsValue() As Boolean
        Get
            Return DefaultRecords
        End Get
        Set(value As Boolean)
            DefaultRecords = value
        End Set
    End Property

    Public Property DefaultCatalogValue() As Boolean
        Get
            Return DefaultCatalog
        End Get
        Set(value As Boolean)
            DefaultCatalog = value
        End Set
    End Property

    Public Property DefaultViewValue() As Boolean
        Get
            Return DefaultView
        End Get
        Set(value As Boolean)
            DefaultView = value
        End Set
    End Property

    Public Property DefaultAdminRecordsValue() As Boolean
        Get
            Return DefaultAdminRecords
        End Get
        Set(value As Boolean)
            DefaultAdminRecords = value
        End Set
    End Property

    Public Property DefaultAdminCatalogValue() As Boolean
        Get
            Return DefaultAdminCatalog
        End Get
        Set(value As Boolean)
            DefaultAdminCatalog = value
        End Set
    End Property

    Public Property DefaultAdminViewValue() As Boolean
        Get
            Return DefaultAdminView
        End Get
        Set(value As Boolean)
            DefaultAdminView = value
        End Set
    End Property

    Public Property DefaultDashboardValue() As Boolean
        Get
            Return DefaultDashboard
        End Get
        Set(value As Boolean)
            DefaultDashboard = value
        End Set
    End Property
End Class
