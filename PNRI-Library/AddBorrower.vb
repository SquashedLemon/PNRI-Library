Imports System.Text.RegularExpressions

Public Class AddBorrower
    Dim Entity_Borrowers As Entity_Borrowers
    Dim Function_Borrowers As Function_Borrowers

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

        Function_Borrowers = New Function_Borrowers()

        With Function_Borrowers
            TxtBorrowerID.Text = .GenerateBorrowerID()
            .PopulateBorrowers(DgvBorrowers)
        End With
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If MessageBox.Show("Do you want to save this data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If TxtEmail.Text.Length > 0 Then
                If Regex.IsMatch(TxtEmail.Text, "^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$") Then
                    MessageBox.Show("Invalid Email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                Entity_Borrowers = New Entity_Borrowers() With {
                    .BorrowerIdValue = TxtBorrowerID.Text,
                    .BorrowerFirstnameValue = TxtFirstname.Text,
                    .BorrowerLastnameValue = TxtLastname.Text,
                    .BorrowerDivisionValue = CmbDivision.selectedValue,
                    .BorrowerSectionValue = CmbSection.selectedValue,
                    .BorrowerAddressValue = TxtAddress.Text,
                    .BorrowerBarangayValue = TxtBarangay.Text,
                    .BorrowerCityValue = TxtCity.Text,
                    .BorrowerContactValue = TxtContact.Text
                }

                With Function_Borrowers
                    .InsertBorrower(Entity_Borrowers)
                    TxtBorrowerID.Text = .GenerateBorrowerID()
                    .PopulateBorrowers(DgvBorrowers)
                End With
            End If
        End If
    End Sub

    Private Sub DgvBorrowers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvBorrowers.CellClick
        TxtBorrowerID.Text = DgvBorrowers.CurrentRow.Cells(0).Value.ToString()
        TxtFirstname.Text = DgvBorrowers.CurrentRow.Cells(1).Value.ToString()
        TxtLastname.Text = DgvBorrowers.CurrentRow.Cells(2).Value.ToString()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If MessageBox.Show("Do you want to update this data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If TxtEmail.Text.Length > 0 Then
                If Regex.IsMatch(TxtEmail.Text, "^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$") Then
                    MessageBox.Show("Invalid Email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                Entity_Borrowers = New Entity_Borrowers() With {
                    .BorrowerIdValue = TxtBorrowerID.Text,
                    .BorrowerFirstnameValue = TxtFirstname.Text,
                    .BorrowerLastnameValue = TxtLastname.Text,
                    .BorrowerDivisionValue = CmbDivision.selectedValue,
                    .BorrowerSectionValue = CmbSection.selectedValue,
                    .BorrowerContactValue = TxtContact.Text,
                    .BorrowerAddressValue = TxtAddress.Text,
                    .BorrowerBarangayValue = TxtBarangay.Text,
                    .BorrowerCityValue = TxtCity.Text
                }
                Function_Borrowers = New Function_Borrowers()

                With Function_Borrowers
                    .UpdateBorrower(DgvBorrowers.CurrentRow.Cells(0).Value.ToString(), Entity_Borrowers)
                    TxtBorrowerID.Text = .GenerateBorrowerID()
                    .PopulateBorrowers(DgvBorrowers)
                End With
            End If
        End If

    End Sub

    Private Sub TxtContact_OnValueChanged(sender As Object, e As EventArgs) Handles TxtContact.OnValueChanged
        If Regex.IsMatch(TxtContact.Text, "[^0-9]") Then
            MessageBox.Show("Contact field only accepts numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtContact.Text = TxtContact.Text.Remove(TxtContact.Text.Length - 1)
        ElseIf TxtContact.Text.Length > 11 Then
            MessageBox.Show("This field only accepts 11 characters.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtContact.Text = TxtContact.Text.Remove(TxtContact.Text.Length - 1)
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        If MessageBox.Show("All fields will be cleared. Do still want to continue?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Function_Borrowers = New Function_Borrowers()

            TxtBorrowerID.Text = Function_Borrowers.GenerateBorrowerID()
            TxtFirstname.Text = String.Empty
            TxtLastname.Text = String.Empty
            TxtEmail.Text = String.Empty
            TxtBarangay.Text = String.Empty
            TxtCity.Text = String.Empty
            TxtAddress.Text = String.Empty
            TxtContact.Text = String.Empty
            CmbDivision.selectedIndex = 0
            CmbSection.selectedIndex = 0
        End If
    End Sub

    Private Sub TxtFirstname_OnValueChanged(sender As Object, e As EventArgs) Handles TxtFirstname.OnValueChanged
        If TxtFirstname.Text.Length > 0 Then
            If Regex.IsMatch(TxtFirstname.Text, "^[A-Za-z ,]+$") = False Then
                MessageBox.Show("This field only accepts letters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtFirstname.Text = TxtFirstname.Text.Remove(TxtFirstname.Text.Length - 1)
            End If
        End If
    End Sub

    Private Sub TxtLastname_OnValueChanged(sender As Object, e As EventArgs) Handles TxtLastname.OnValueChanged
        If TxtLastname.Text.Length > 0 Then
            If Regex.IsMatch(TxtLastname.Text, "^[A-Za-z ,]+$") = False Then
                MessageBox.Show("This field only accepts letters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtLastname.Text = TxtLastname.Text.Remove(TxtLastname.Text.Length - 1)
            End If
        End If
    End Sub

    Private Sub TxtEmail_OnValueChanged(sender As Object, e As EventArgs) Handles TxtEmail.OnValueChanged

    End Sub
End Class