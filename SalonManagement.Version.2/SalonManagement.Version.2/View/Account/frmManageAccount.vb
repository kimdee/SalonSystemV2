﻿Public Class frmManageAccount
    Private account As New Accounts
    Private Sub frmManageAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        account.ViewAccounts(gvView, lblResult)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim obj As New frmAddAccount
        If obj.ShowDialog() = DialogResult.OK Then
            account.ViewAccounts(gvView, lblResult)
        Else
            account.ViewAccounts(gvView, lblResult)
        End If
    End Sub

    Private Sub gvView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvView.CellContentClick
        If e.ColumnIndex = 6 Then
            account.SetAccountDetails(gvView.SelectedRows(0).Cells(0).Value)
            If MessageBox.Show("Are you sure you want to delete the account of  " + account.UserName, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If account.DeleteAccount() = True Then
                    account.ViewAccounts(gvView, lblResult)
                Else
                    MessageBox.Show("Failed to delete. Please try again.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        ElseIf e.ColumnIndex = 5 Then
            account.SetAccountDetails(gvView.SelectedRows(0).Cells(0).Value)
            Dim obj As New frmEditAccount
            obj.account = Me.account
            If obj.ShowDialog = DialogResult.OK Then
                account.ViewAccounts(gvView, lblResult)
            End If
        End If
    End Sub

End Class