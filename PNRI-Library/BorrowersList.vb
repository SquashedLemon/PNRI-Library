Public Class BorrowersList
    Dim Function_Borrowers As Function_Borrowers
    Dim Entity_Borrower As Entity_Borrowers

    Private Sub BorrowersList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Function_Borrowers = New Function_Borrowers()

        With Function_Borrowers
            .PopulateBorrowers(DgvBorrowers)
        End With
    End Sub

    Private Sub TxtSearch_OnValueChanged(sender As Object, e As EventArgs) Handles TxtSearch.OnValueChanged
        Function_Borrowers = New Function_Borrowers()

        With Function_Borrowers
            .SearchBorrower(DgvBorrowers, TxtSearch.Text)
        End With
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim BorrowForm As New BorrowForm()
        Entity_Borrower = New Entity_Borrowers() With {
            .BorrowerIdValue = DgvBorrowers.CurrentRow.Cells(0).Value.ToString()
        }

        With BorrowForm
            .TxtFirstname.Text = DgvBorrowers.CurrentRow.Cells(1).Value.ToString() & " " & DgvBorrowers.CurrentRow.Cells(2).Value.ToString()
            .TxtDivision.Text = DgvBorrowers.CurrentRow.Cells(3).Value.ToString() & ", " & DgvBorrowers.CurrentRow.Cells(4).Value.ToString()
            .TxtContact.Text = DgvBorrowers.CurrentRow.Cells(6).Value.ToString()
            .TxtSearch.Enabled = True
            .TxtSearch.Cursor = Cursors.IBeam
            .DgvBorrow.Enabled = True
            .DgvBorrow.Cursor = Cursors.Hand
            .BtnAdd.Enabled = False
            .BtnAdd.Cursor = Cursors.No
            .BtnRemove.Enabled = True
            .BtnRemove.Cursor = Cursors.Hand
        End With
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Hide()
    End Sub
End Class