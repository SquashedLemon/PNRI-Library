Public Class Entity_Login
    Private Shared AddMaterial As Boolean
    Private Shared AddStaff As Boolean
    Private Shared BorrowMaterial As Boolean
    Private Shared Catalog As Boolean
    Private Shared Dashboard As Boolean
    Private Shared Records As Boolean
    Private Shared ReturnMaterial As Boolean
    Private Shared View As Boolean

    Public Property AddMaterialValue() As Boolean
        Get
            Return AddMaterial
        End Get
        Set(value As Boolean)
            AddMaterial = value
        End Set
    End Property

    Public Property AddStaffValue() As Boolean
        Get
            Return AddStaff
        End Get
        Set(value As Boolean)
            AddStaff = value
        End Set
    End Property

    Public Property BorrowMaterialValue() As Boolean
        Get
            Return BorrowMaterial
        End Get
        Set(value As Boolean)
            BorrowMaterial = value
        End Set
    End Property

    Public Property CatalogValue() As Boolean
        Get
            Return Catalog
        End Get
        Set(value As Boolean)
            Catalog = value
        End Set
    End Property

    Public Property DashboardValue() As Boolean
        Get
            Return Dashboard
        End Get
        Set(value As Boolean)
            Dashboard = value
        End Set
    End Property

    Public Property RecordsValue() As Boolean
        Get
            Return Records
        End Get
        Set(value As Boolean)
            Records = value
        End Set
    End Property

    Public Property ReturnMaterialValue() As Boolean
        Get
            Return ReturnMaterial
        End Get
        Set(value As Boolean)
            ReturnMaterial = value
        End Set
    End Property

    Public Property ViewValue() As Boolean
        Get
            Return View
        End Get
        Set(value As Boolean)
            View = value
        End Set
    End Property
End Class
