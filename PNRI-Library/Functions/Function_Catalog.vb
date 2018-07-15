Imports MySql.Data.MySqlClient

Public Class Function_Catalog
    Inherits Class_Connection

    Public Function GenerateCatalogID() As String
        Dim id As Integer = 0

        Try
            OpenConnection()

            MyCommand = New MySqlCommand("SELECT COUNT(*) FROM tbl_catalog", MyConnection)
            MyReader = MyCommand.ExecuteReader()

            While MyReader.Read()
                id = Convert.ToInt32(MyReader(0)) + 1
            End While

            CloseConnection()
        Catch noID As InvalidCastException
            id = 1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return id.ToString()
    End Function

    Public Function GenerateAccessionNumber() As String
        Dim id As Integer = 0

        Try
            OpenConnection()

            MyCommand = New MySqlCommand("SELECT COUNT(*) FROM tbl_catalog", MyConnection)
            MyReader = MyCommand.ExecuteReader()

            While MyReader.Read()
                id = Convert.ToInt32(MyReader(0)) + 1
            End While

            CloseConnection()
        Catch noID As InvalidCastException
            id = 1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return id.ToString()
    End Function

    Public Function GenerateCallNumber() As String
        Dim id As Integer = 0

        Try
            OpenConnection()

            MyCommand = New MySqlCommand("SELECT COUNT(*) FROM tbl_catalog", MyConnection)
            MyReader = MyCommand.ExecuteReader()

            While MyReader.Read()
                id = Convert.ToInt32(MyReader(0)) + 1
            End While

            CloseConnection()
        Catch noID As InvalidCastException
            id = 1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return id.ToString()
    End Function

    Public Sub PopulateCatalog(DgvCatalog)
        Try
            OpenConnection()

            MyAdapter = New MySqlDataAdapter("SELECT c_id AS 'ID', c_access AS 'Accession Number', c_call AS 'Call Number', c_title AS 'Title', c_author AS 'Author', c_publisher AS 'Publisher', c_copyright AS 'Copyright', c_status AS 'Status' FROM tbl_catalog", MyConnection)
            MyDataSet = New DataSet()
            MyBindingSource = New BindingSource()

            MyAdapter.Fill(MyDataSet)

            MyBindingSource.DataSource = MyDataSet.Tables(0)
            DgvCatalog.DataSource = MyBindingSource

            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub SearchCatalog(DgvCatalog As DataGridView, Keyword As String)
        Try
            OpenConnection()

            MyAdapter = New MySqlDataAdapter("SELECT c_id AS 'ID', c_call AS 'Call Number', c_title AS 'Title', c_author AS 'Author', c_publisher AS 'Publisher', c_copyright AS 'Copyright', c_status AS 'Status', c_access AS 'Access' FROM tbl_catalog WHERE CONCAT(c_id, c_access, c_call, c_title, c_author, c_publisher, c_copyright) LIKE '%" & Keyword & "%'", MyConnection)

            MyDataSet = New DataSet()
            MyBindingSource = New BindingSource()

            MyAdapter.Fill(MyDataSet)

            MyBindingSource.DataSource = MyDataSet.Tables(0)
            DgvCatalog.DataSource = MyBindingSource

            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub InsertCatalog(Entity_Catalog As Entity_Catalog)
        Try
            OpenConnection()

            MyCommand = New MySqlCommand("INSERT INTO tbl_catalog() VALUES(@id, @status, @access, @call_number, @title, @author, @publisher, @copyright)", MyConnection)

            With MyCommand
                .Parameters.AddWithValue("@id", Entity_Catalog.CatalogIDValue)
                .Parameters.AddWithValue("@call_number", Entity_Catalog.CatalogCallNumberValue)
                .Parameters.AddWithValue("@title", Entity_Catalog.CatalogTitleValue)
                .Parameters.AddWithValue("@author", Entity_Catalog.CatalogAuthorValue)
                .Parameters.AddWithValue("@publisher", Entity_Catalog.CatalogPublisherValue)
                .Parameters.AddWithValue("@copyright", Entity_Catalog.CatalogCopyrightValue)
                .Parameters.AddWithValue("@status", Entity_Catalog.CatalogStatusValue)
                .Parameters.AddWithValue("@access", Entity_Catalog.CatalogAccessValue)
                .ExecuteNonQuery()
            End With

            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub UpdateCatalog(CatalogID As String, Entity_Catalog As Entity_Catalog)
        Try
            OpenConnection()

            MyCommand = New MySqlCommand("UPDATE tbl_catalog SET c_access=@access, c_call=@call_number, c_title=@title, c_author=@author, c_publisher=@publisher, c_copyright=@copyright WHERE u_id=@id", MyConnection)

            With MyCommand
                .Parameters.AddWithValue("@id", Entity_Catalog.CatalogIDValue)
                .Parameters.AddWithValue("@call_number", Entity_Catalog.CatalogCallNumberValue)
                .Parameters.AddWithValue("@title", Entity_Catalog.CatalogTitleValue)
                .Parameters.AddWithValue("@author", Entity_Catalog.CatalogAuthorValue)
                .Parameters.AddWithValue("@publisher", Entity_Catalog.CatalogPublisherValue)
                .Parameters.AddWithValue("@copyright", Entity_Catalog.CatalogCopyrightValue)
                .Parameters.AddWithValue("@access", Entity_Catalog.CatalogAccessValue)
                .ExecuteNonQuery()
            End With
            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class