Public Class DashboardForm
    Dim Function_Dashboard As Function_Dashboard

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

        Function_Dashboard = New Function_Dashboard()

        With Function_Dashboard
            LblTransactions.Text = .CountTransactions().ToString()
            LblBorrowers.Text = .CountBorrowers().ToString()
            LblMaterials.Text = .CountMaterials().ToString()
            .LoadTransactionChart(ChartTransactions, Date.Now.Year)
        End With
    End Sub

    Private Sub DdYear_onItemSelected(sender As Object, e As EventArgs) Handles DdYear.onItemSelected
        Function_Dashboard = New Function_Dashboard()

        With Function_Dashboard
            .LoadTransactionChart(ChartTransactions, DdYear.selectedValue)
        End With
    End Sub
End Class