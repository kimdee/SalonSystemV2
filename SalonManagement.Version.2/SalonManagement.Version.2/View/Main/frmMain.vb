Imports MySql.Data.MySqlClient
Imports System.ComponentModel.Design
Imports System.Windows.Forms.Form

Public Class frmMain
    Public Shared flag As Integer = 0
    Public Shared UserID As Integer = 0
    Public Shared fullName As String = "User Admin"
    Public Shared userType As String = "Administrator"
    Public Shared dtServer As Date = DateTime.Now

    Private account As New Accounts
    Private customer As New Customer
    Private employee As New Employee

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timeMain.Start()
        Me.Hide()
        Dim obj As New frmLogin
        If obj.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Me.Show()
        End If
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If flag = 1 Then
            If MessageBox.Show("Are you sure you want to exit from the system?", "Message", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then
                e.Cancel = True
            Else
                account.SetAccountDetails(UserID)
                account.LoginStatus = 0
                account.EditAccount()
            End If
        End If
    End Sub

    Private Sub timeMain_Tick(sender As Object, e As EventArgs) Handles timeMain.Tick
        Dim sql As String = "SELECT now();"
        Try
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                dtServer = cmd.ExecuteScalar
                lnklblUsername.Text = fullName
                'lbluserType.Text = userType
                lblTime.Text = TimeOfDay.ToString("h:mm:ss tt")
                lblDate.Text = dtServer.ToString("MMMM d, yyyy")
                'lblDate.Text = MonthName(dtServer.Month) + " " + dtServer.Day.ToString() + ", " + dtServer.Year.ToString()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnNewCustomer.Click
        Dim obj As New frmAddCustomer
        obj.customer = Me.customer

        If btnNewCustomer.Text = "Edit Customer" Then
            obj.edit = True
        End If

        If obj.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            ''Insert CustomerTable
            With customer
                txtName.Text = .CustomerName
                txtCN.Text = .CustomerCN
                If .CustomerSex = "Male" Then
                    rdbMale.Checked = True
                ElseIf .CustomerSex = "Female" Then
                    rdbFemale.Checked = True
                End If
                .AddCustomer()
            End With
            btnNewCustomer.Text = "Edit Customer"
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearInput(Me)
        btnNewCustomer.Text = "New Customer"
    End Sub

    Private Sub lnklblAppointment_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblAppointment.LinkClicked
        Dim obj As New frmAppointment
        obj.ShowDialog()
    End Sub

    Private Sub lnklblServices_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblServices.LinkClicked
        Dim obj As New frmServices
        obj.ShowDialog()
    End Sub

    Private Sub lnkLblEmployee_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkLblEmployee.LinkClicked
        Dim obj As New frmEmployee
        obj.ShowDialog()
    End Sub

    Private Sub lnklblPosition_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblPosition.LinkClicked
        Dim obj As New frmPosition
        obj.ShowDialog()
    End Sub

    Private Sub lnklblDeduction_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblDeduction.LinkClicked
        Dim obj As New frmDeduction
        obj.ShowDialog()
    End Sub

    Private Sub lnklblAttendance_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblAttendance.LinkClicked
        Dim obj As New frmAttendance
        obj.ShowDialog()
    End Sub

    Private Sub lnklblPayroll_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblPayroll.LinkClicked
        Dim obj As New frmPayroll
        obj.ShowDialog()
    End Sub

    Private Sub lnklblCollection_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblCollection.LinkClicked
        Dim obj As New frmCollection
        obj.ShowDialog()
    End Sub

    Private Sub lnklblCustomer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblCustomer.LinkClicked
        Dim obj As New frmCustomer
        obj.ShowDialog()
    End Sub

    Private Sub lnklblAccounts_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblAccounts.LinkClicked
        Dim obj As New frmManageAccount
        obj.ShowDialog()
    End Sub

    Private Sub lnklblLogout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblLogout.LinkClicked
        Me.Hide()
        Dim obj As New frmLogin
        obj.ShowDialog()
    End Sub

End Class