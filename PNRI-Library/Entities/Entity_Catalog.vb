Public Class Entity_Catalog
    Private Shared CatalogID As String
    Private Shared CatalogTitle As String
    Private Shared CatalogAuthor As String
    Private Shared CatalogPublisher As String
    Private Shared CatalogCopyright As String
    Private Shared CatalogCallNumber As String
    Private Shared CatalogStatus As String
    Private Shared CatalogAccess As String

    Public Property CatalogIDValue() As String
        Get
            Return CatalogID
        End Get
        Set(value As String)
            CatalogID = value
        End Set
    End Property

    Public Property CatalogTitleValue() As String
        Get
            Return CatalogTitle
        End Get
        Set(value As String)
            CatalogTitle = value
        End Set
    End Property

    Public Property CatalogAuthorValue() As String
        Get
            Return CatalogAuthor
        End Get
        Set(value As String)
            CatalogAuthor = value
        End Set
    End Property

    Public Property CatalogPublisherValue() As String
        Get
            Return CatalogPublisher
        End Get
        Set(value As String)
            CatalogPublisher = value
        End Set
    End Property

    Public Property CatalogCopyrightValue() As String
        Get
            Return CatalogCopyright
        End Get
        Set(value As String)
            CatalogCopyright = value
        End Set
    End Property

    Public Property CatalogCallNumberValue() As String
        Get
            Return CatalogCallNumber
        End Get
        Set(value As String)
            CatalogCallNumber = value
        End Set
    End Property

    Public Property CatalogStatusValue() As String
        Get
            Return CatalogStatus
        End Get
        Set(value As String)
            CatalogStatus = value
        End Set
    End Property

    Public Property CatalogAccessValue() As String
        Get
            Return CatalogAccess
        End Get
        Set(value As String)
            CatalogAccess = value
        End Set
    End Property
End Class
