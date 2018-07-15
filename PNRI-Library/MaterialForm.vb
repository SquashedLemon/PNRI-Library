Public Class MaterialForm
    Dim Function_Catalog As Function_Catalog
    Dim Entity_Catalog As Entity_Catalog

    Sub New(args As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If args Then
            TopLevel = False
            Visible = True
        Else
            TopLevel = False
            Visible = False
        End If

        Function_Catalog = New Function_Catalog()

        With Function_Catalog
            TxtAccession.Text = .GenerateAccessionNumber()
            TxtCallNumber.Text = .GenerateCallNumber()
            TxtCatalogID.Text = .GenerateCatalogID()
            .PopulateCatalog(DgvCatalog)
        End With
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ClearTextFields()

        Function_Catalog = New Function_Catalog()

        With Function_Catalog
            TxtAccession.Text = .GenerateAccessionNumber()
            TxtCallNumber.Text = .GenerateCallNumber()
        End With
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If String.IsNullOrWhiteSpace(TxtTitle.Text) And String.IsNullOrWhiteSpace(TxtAuthor.Text) And String.IsNullOrWhiteSpace(TxtPublisher.Text) And String.IsNullOrWhiteSpace(TxtCopyright.Text) Then
            MessageBox.Show("Fill out all the fields before proceeding.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Entity_Catalog = New Entity_Catalog() With {
            .CatalogAccessValue = TxtCallNumber.Text,
            .CatalogCallNumberValue = TxtCallNumber.Text,
            .CatalogTitleValue = TxtTitle.Text,
            .CatalogAuthorValue = TxtAuthor.Text,
            .CatalogPublisherValue = TxtPublisher.Text,
            .CatalogCopyrightValue = TxtCopyright.Text,
            .CatalogStatusValue = "Available"
        }

            Function_Catalog = New Function_Catalog()

            With Function_Catalog
                .InsertCatalog(Entity_Catalog)

                ClearTextFields()

                TxtAccession.Text = .GenerateAccessionNumber()
                TxtCallNumber.Text = .GenerateCallNumber()
                TxtCatalogID.Text = .GenerateCatalogID()
                .PopulateCatalog(DgvCatalog)
            End With
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Entity_Catalog = New Entity_Catalog()
        Function_Catalog = New Function_Catalog()

        With Function_Catalog
            .UpdateCatalog(Entity_Catalog.CatalogIDValue, Entity_Catalog)
            .PopulateCatalog(DgvCatalog)
            TxtAccession.Text = .GenerateAccessionNumber()
            TxtCallNumber.Text = .GenerateCallNumber()
            TxtCatalogID.Text = .GenerateCatalogID()
        End With
    End Sub

    Private Sub DgvCatalog_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCatalog.CellClick
        BtnUpdate.Enabled = True
        BtnUpdate.Cursor = Cursors.Hand

        BtnAdd.Enabled = False
        BtnAdd.Cursor = Cursors.No

        TxtCatalogID.Text = DgvCatalog.CurrentRow.Cells(0).Value.ToString()
        TxtAccession.Text = DgvCatalog.CurrentRow.Cells(1).Value.ToString()
        TxtCallNumber.Text = DgvCatalog.CurrentRow.Cells(2).Value.ToString()
        TxtTitle.Text = DgvCatalog.CurrentRow.Cells(3).Value.ToString()
        TxtAuthor.Text = DgvCatalog.CurrentRow.Cells(4).Value.ToString()
        TxtPublisher.Text = DgvCatalog.CurrentRow.Cells(5).Value.ToString()
        TxtCopyright.Text = DgvCatalog.CurrentRow.Cells(6).Value.ToString()

        Entity_Catalog = New Entity_Catalog() With {
            .CatalogIDValue = TxtCatalogID.Text,
            .CatalogAccessValue = TxtAccession.Text,
            .CatalogCallNumberValue = TxtCallNumber.Text,
            .CatalogTitleValue = TxtTitle.Text,
            .CatalogAuthorValue = TxtAuthor.Text,
            .CatalogPublisherValue = TxtPublisher.Text,
            .CatalogCopyrightValue = TxtCopyright.Text,
            .CatalogStatusValue = DgvCatalog.CurrentRow.Cells(7).Value.ToString()
        }
    End Sub

    Private Sub ClearTextFields()
        TxtAuthor.Text = ""
        TxtTitle.Text = ""
        TxtCopyright.Text = ""
        TxtPublisher.Text = ""
    End Sub

    Private Sub TxtSearch_OnValueChanged(sender As Object, e As EventArgs) Handles TxtSearch.OnValueChanged
        Function_Catalog = New Function_Catalog()

        With Function_Catalog
            .SearchCatalog(DgvCatalog, TxtSearch.Text)
        End With
    End Sub
End Class