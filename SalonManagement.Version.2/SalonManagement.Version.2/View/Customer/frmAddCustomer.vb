Public Class frmAddCustomer
    Public customer As Customer

    Public edit As Boolean = False
    Private Sub frmAddCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Focus()
        If edit Then
            With customer
                txtName.Text = .CustomerName
                If .CustomerSex = "Male" Then
                    rdbMale.Checked = True
                Else
                    rdbFemale.Checked = True
                End If
                txtCN.Text = .CustomerCN
                .AddCustomer()
            End With
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        With customer
            .CustomerName = txtName.Text
            .CustomerCN = txtCN.Text
            If rdbMale.Checked = True Then
                .CustomerSex = "Male"
            Else
                .CustomerSex = "Female"
            End If
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
        End With
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        AllowedOnly(LetterOnly, txtName)
        txtName.MaxLength = 15
    End Sub

    Private Sub txtCN_TextChanged(sender As Object, e As EventArgs) Handles txtCN.TextChanged
        PhoneFormat(txtCN)
        ContactNo(txtCN)
        AllowedOnly(NumberWDash, txtCN)
        txtCN.MaxLength = 13
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class