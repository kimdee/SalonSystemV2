Public Class frmAddService
    Private service As New Service
    Dim edit As Boolean

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtName.Text = "" Then
            MessageBox.Show("Name And Description required.", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf IsTextBoxEmpty(txtDescription) = True Then
            MessageBox.Show("Name And Description are required.", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            With Service
                .ServiceName = txtName.Text.Trim
                .ServiceDescription = txtDescription.Text.Trim
                .ServicePrice = nudPrice.Value

                If Service.AddService = True Then
                    MessageBox.Show("Successfully Saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Failed to save. Service already exist.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End With
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        AllowedOnly(AlphaChar, txtName)
        ToUpperOnly(AlphaChar, txtName)
    End Sub

    Private Sub txtDescription_TextChanged(sender As Object, e As EventArgs) Handles txtDescription.TextChanged
        AllowedOnly(AlphaChar, txtDescription)
        ToUpperOnly(AlphaChar, txtDescription)
    End Sub

End Class