Public Class frmAddAccount
    Private col As New Accounts
    Dim role As String = "Clerk"

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        AllowedOnly(LetterOnly, txtName)
        SentenceCase(txtName)
    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged
        AllowedOnly(LetterOnly, txtLastName)
        SentenceCase(txtLastName)
    End Sub

    Private Sub cboPosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPosition.SelectedIndexChanged
        Me.role = cboPosition.Text
    End Sub

    Private Sub txtUserName_Leave(sender As Object, e As EventArgs) Handles txtUserName.Leave
        'If col.ValidateUserName(txtUserName.Text) = False Then
        '    MessageBox.Show("Your User Name is already exist.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    txtUserName.Focus()
        'End If
    End Sub


    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged
        AllowedOnly("ñabcdefghijklmnopqrstuvwxyzÑ1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ-_", txtUserName)
    End Sub

    Private Sub txtPw_TextChanged(sender As Object, e As EventArgs) Handles txtPw.TextChanged
        AllowedOnly("ñabcdefghijklmnopqrstuvwxyzÑ1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ-_", txtPw)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IsTextBoxEmpty(txtName, txtLastName, txtUserName, txtPw) = True Then
            MessageBox.Show("First Name, Last Name, username and password are required.", "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtUserName.TextLength < 6 Then
            MessageBox.Show("Username must be atleast 6 characters long.", "Message",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf col.IsAccountExist(txtUserName.Text) Then
            MessageBox.Show("Username already exist.", "Message",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtPw.TextLength < 6 Then
            MessageBox.Show("Password must be atleast 6 characters long.", "Message",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtPw.Text <> txtRetype.Text Then
            MessageBox.Show("Password did not match.", "Message",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf IsTextBoxEmpty(txtName, txtPw, txtUserName) = True Or cboPosition.SelectedIndex = -1 Then
            MessageBox.Show("Name, User Name, Password and Position are required.", "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf IsTextBoxEmpty(txtRetype) = True Or cboPosition.SelectedIndex = -1 Then
            MessageBox.Show("Please Retype Password.", "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            col.FirstName = txtName.Text.Trim
            col.LastName = txtLastName.Text.Trim
            col.AccountRole = cboPosition.Text.Trim
            col.UserName = txtUserName.Text.Trim
            col.Password = txtPw.Text.Trim
            col.LoginStatus = 0
            If col.AddAccount = True Then
                MessageBox.Show("Successfully Saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Failed to save. Account already exist.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
End Class