Public Class RecordForm
    Dim Function_Borrowers As Function_Borrowers
    Dim Function_Records As Function_Records

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

        Function_Records = New Function_Records()
        Function_Borrowers = New Function_Borrowers()

        With Function_Borrowers
            .PopulateBorrowers(DgvBorrowers)
        End With

        With Function_Records
            .PopulateRecords(DgvTransaction)
        End With
    End Sub

    Private Sub TxtBorrowSearch_OnValueChanged(sender As Object, e As EventArgs) Handles TxtBorrowSearch.OnValueChanged
        Function_Borrowers = New Function_Borrowers()

        With Function_Borrowers
            .SearchBorrower(DgvBorrowers, TxtBorrowSearch.Text)
        End With
    End Sub

    Private Sub TxtTransactionSearch_OnValueChanged(sender As Object, e As EventArgs) Handles TxtTransactionSearch.OnValueChanged
        Function_Records = New Function_Records()

        With Function_Records
            .SearchRecords(DgvTransaction, TxtTransactionSearch.Text)
        End With
    End Sub

    Private Sub DtpFrom_onValueChanged(sender As Object, e As EventArgs) Handles DtpFrom.onValueChanged
        Function_Records = New Function_Records()

        With Function_Records
            .FilterByDate(DgvTransaction, DtpFrom.ToString("yyyy/MM/dd"), DtpTo.ToString("yyyy/MM/dd"))
        End With
    End Sub

    Private Sub DtpTo_onValueChanged(sender As Object, e As EventArgs) Handles DtpTo.onValueChanged
        Function_Records = New Function_Records()

        With Function_Records
            .FilterByDate(DgvTransaction, DtpFrom.ToString("yyyy/MM/dd"), DtpTo.ToString("yyyy/MM/dd"))
        End With
    End Sub
End Class