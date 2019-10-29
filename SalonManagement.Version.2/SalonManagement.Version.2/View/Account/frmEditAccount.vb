Imports System.Windows.Forms

Public Class frmEditAccount
    Public account As Accounts

    Dim role As String = "clerk"
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IsTextBoxEmpty(txtName, txtPw, txtUserName) = True Or cboType.SelectedIndex = -1 Then
            MessageBox.Show("Name, User Name, Password and Position are required.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            account.FirstName = txtName.Text
            account.LastName = txtLastName.Text
            account.AccountRole = cboType.Text
            account.UserName = txtUserName.Text
            account.Password = txtPw.Text
            account.LoginStatus = 0
            If account.EditAccount() = True Then
                MessageBox.Show("Successfully Update.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Failed to update. Account already exist.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        AllowedOnly(LetterOnly, txtName)
        ToUpperOnly(CodeOnly, txtName)
    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged
        AllowedOnly(LetterOnly, txtLastName)
        ToUpperOnly(CodeOnly, txtLastName)
    End Sub

    Private Sub cboType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboType.SelectedIndexChanged
        Me.role = cboType.Text
    End Sub

    Private Sub frmEditAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With account
            txtName.Text = .FirstName
            txtLastName.Text = .LastName
            If .AccountRole = "Administrator" Then
                cboType.Enabled = False
            Else
                cboType.SelectedIndex = cboType.FindString(.AccountRole)
            End If
            txtUserName.Text = .UserName
            txtPw.Text = .Password
        End With
    End Sub

End Class