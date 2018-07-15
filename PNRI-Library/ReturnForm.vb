Public Class ReturnForm
    Dim Function_Returning As Function_Returning
    Dim Entity_Borrowers As Entity_Borrowers
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

        Function_Returning = New Function_Returning()

        With Function_Returning
            .PopulateTransaction(DgvTransactions)
        End With
    End Sub

    Private Sub DgvTransactions_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTransactions.CellClick
        Function_Returning = New Function_Returning()
        Entity_Catalog = New Entity_Catalog() With {
            .CatalogIDValue = DgvTransactions.CurrentRow.Cells(0).Value.ToString()
        }
        Entity_Borrowers = New Entity_Borrowers() With {
            .BorrowerIdValue = DgvTransactions.CurrentRow.Cells(1).Value().ToString()
        }

        With Function_Returning
            .GetBorrowerInfo(Entity_Borrowers)
            .GetCatalogInfo(Entity_Catalog)
        End With

        TxtName.Text = Entity_Borrowers.BorrowerFirstnameValue & " " & Entity_Borrowers.BorrowerLastnameValue
        TxtDivSec.Text = Entity_Borrowers.BorrowerDivisionValue & ", " & Entity_Borrowers.BorrowerSectionValue
        TxtContact.Text = Entity_Borrowers.BorrowerContactValue

        TxtAccession.Text = Entity_Catalog.CatalogAccessValue
        TxtCallNumber.Text = Entity_Catalog.CatalogCallNumberValue
        TxtTitle.Text = Entity_Catalog.CatalogTitleValue
        TxtAuthor.Text = Entity_Catalog.CatalogAuthorValue
        TxtPublisher.Text = Entity_Catalog.CatalogPublisherValue
        TxtCopyright.Text = Entity_Catalog.CatalogCopyrightValue
        TxtCurrentDate.Text = Date.Now.ToString("D")
        TxtBorrowedDate.Text = DgvTransactions.CurrentRow.Cells(3).Value.ToString()
        TxtTransaction.Text = DgvTransactions.CurrentRow.Cells(0).Value.ToString()

        BtnReturn.Enabled = True
        BtnReturn.Cursor = Cursors.Hand
    End Sub

    Private Sub BtnReturn_Click(sender As Object, e As EventArgs) Handles BtnReturn.Click
        Function_Returning = New Function_Returning()

        With Function_Returning
            .ReturnTransaction(TxtTransaction.Text)
            .RevertAvailability(Entity_Catalog.CatalogIDValue)
        End With

        ClearFields()
    End Sub

    Public Sub ClearFields()
        TxtName.Text = ""
        TxtDivSec.Text = ""
        TxtContact.Text = ""
        TxtAccession.Text = ""
        TxtCallNumber.Text = ""
        TxtTitle.Text = ""
        TxtAuthor.Text = ""
        TxtPublisher.Text = ""
        TxtCopyright.Text = ""
        TxtCurrentDate.Text = ""
        TxtBorrowedDate.Text = ""
        TxtTransaction.Text = ""

        BtnReturn.Enabled = False
        BtnReturn.Cursor = Cursors.No
    End Sub
End Class