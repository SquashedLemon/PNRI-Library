Public Class BorrowForm
    Dim Entity_Borrower As Entity_Borrowers
    Dim Function_Catalog As Function_Catalog
    Dim Function_Borrowing As Function_Borrowing

    Sub New(Optional args As Boolean = True)

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

        Function_Borrowing = New Function_Borrowing()

        With Function_Borrowing
            .PopulateBorrowing(DgvBorrow)
        End With
    End Sub

    Private Sub TxtSearch_OnValueChanged(sender As Object, e As EventArgs) Handles TxtSearch.OnValueChanged
        Function_Borrowing = New Function_Borrowing()

        With Function_Borrowing
            .SearchBorrowing(DgvBorrow, TxtSearch.Text)
        End With
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        TxtFirstname.Text = ""
        TxtDivision.Text = ""
        TxtContact.Text = ""

        BtnAdd.Enabled = True
        BtnAdd.Cursor = Cursors.Hand

        BtnRemove.Enabled = False
        BtnRemove.Cursor = Cursors.No

        TxtSearch.Enabled = False
        TxtSearch.Cursor = Cursors.No

        DgvBorrow.Enabled = False
        DgvBorrow.Cursor = Cursors.No
    End Sub

    Private Sub DgvBorrow_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvBorrow.CellClick
        TxtAccession.Text = DgvBorrow.CurrentRow.Cells(1).Value.ToString()
        TxtCallNumber.Text = DgvBorrow.CurrentRow.Cells(2).Value.ToString()
        TxtTitle.Text = DgvBorrow.CurrentRow.Cells(3).Value.ToString()
        TxtAuthor.Text = DgvBorrow.CurrentRow.Cells(4).Value.ToString()
        TxtPublisher.Text = DgvBorrow.CurrentRow.Cells(5).Value.ToString()
        TxtCopyright.Text = DgvBorrow.CurrentRow.Cells(6).Value.ToString()
        TxtDate.Text = Date.Now.ToString()

        BtnBorrow.Enabled = True
        BtnBorrow.Cursor = Cursors.Hand
    End Sub

    Private Sub BtnBorrow_Click(sender As Object, e As EventArgs) Handles BtnBorrow.Click
        Entity_Borrower = New Entity_Borrowers()
        Function_Borrowing = New Function_Borrowing()

        With Function_Borrowing
            .SaveTransaction(Entity_Borrower.BorrowerIdValue, DgvBorrow.CurrentRow.Cells(0).Value.ToString())
            .ChangeStatus(DgvBorrow.CurrentRow.Cells(0).Value.ToString())
        End With

        ClearFields()
    End Sub

    Private Sub ClearFields()
        TxtFirstname.Text = ""
        TxtDivision.Text = ""
        TxtContact.Text = ""
        TxtAccession.Text = ""
        TxtCallNumber.Text = ""
        TxtAuthor.Text = ""
        TxtPublisher.Text = ""
        TxtCopyright.Text = ""
        TxtTitle.Text = ""
        TxtDate.Text = ""

        BtnAdd.Enabled = True
        BtnAdd.Cursor = Cursors.Hand

        BtnRemove.Enabled = False
        BtnRemove.Cursor = Cursors.No

        BtnBorrow.Enabled = False
        BtnBorrow.Cursor = Cursors.No

        DgvBorrow.Enabled = False
        DgvBorrow.Cursor = Cursors.No

        TxtSearch.Enabled = False
        TxtSearch.Cursor = Cursors.No
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Hide()
        BorrowersList.Show()
    End Sub
End Class