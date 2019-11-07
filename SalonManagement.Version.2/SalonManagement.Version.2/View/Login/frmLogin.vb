Imports System.Windows.Forms
Imports MaterialSkin

Public Class frmLogin
    Private account As New Accounts
    Dim i As Integer = 0

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnableButton()

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub
    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If i = 0 Then
            frmMain.flag = 0
            frmMain.Close()
        End If
    End Sub

    Sub EnableButton()
        If txtUsername.Text.Count = 0 Or txtPassword.Text.Count = 0 Then
            btnLogin.Enabled = False
        Else
            btnLogin.Enabled = True
        End If
    End Sub

    ''----LOGING IN----
    Private Sub login()
        account.EditAccount()
        frmMain.UserID = account.AccountID
        frmMain.fullName = account.FirstName + " " + account.LastName
        frmMain.userType = account.AccountRole
        i = 1
        If account.AccountRole = "Administrator" Then
            frmMain.lnklblAppointment.Enabled = True
            frmMain.lnklblServices.Enabled = True
            frmMain.lnkLblEmployee.Enabled = True
            frmMain.lnklblPosition.Enabled = True
            frmMain.lnklblDeduction.Enabled = True
            frmMain.lnklblAttendance.Enabled = True
            frmMain.lnklblPayroll.Enabled = True
            frmMain.lnklblCollection.Enabled = True
            frmMain.lnklblCustomer.Enabled = True
            frmMain.lnklblAccounts.Enabled = True
            frmMain.lnklblLogout.Enabled = True

        ElseIf account.AccountRole = "Clerk" Then
            frmMain.lnklblAppointment.Enabled = True
            frmMain.lnklblServices.Enabled = False
            frmMain.lnkLblEmployee.Enabled = False
            frmMain.lnklblPosition.Enabled = False
            frmMain.lnklblDeduction.Enabled = False
            frmMain.lnklblAttendance.Enabled = True
            frmMain.lnklblPayroll.Enabled = False
            frmMain.lnklblCollection.Enabled = True
            frmMain.lnklblCustomer.Enabled = True
            frmMain.lnklblAccounts.Enabled = False
            frmMain.lnklblLogout.Enabled = True

        ElseIf account.AccountRole = "Cashier" Then
            For Each btn As Button In frmMain.panelMain.Controls
                btn.Enabled = False
            Next

            For Each pb As PictureBox In frmMain.panelMain.Controls
                pb.Enabled = False
            Next
            'frmMain.btnBilling.Enabled = True
        End If
        frmMain.Show()
        frmMain.timeMain.Start()

        Me.DialogResult = DialogResult.OK
        Me.Close()
        frmMain.flag = 1
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If IsTextBoxEmpty(txtUsername, txtPassword) = True Then
            MessageBox.Show("Please enter Username and Password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If account.IsLogin(txtUsername.Text, txtPassword.Text) = True Then
                account.SetAccountDetails(account.AccountID)
                If account.AccountRole = "Administrator" Then
                    account.LoginStatus = 0
                    login()
                ElseIf account.LoginStatus = 1 Then
                    MessageBox.Show("Your account is already login from another device.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    account.LoginStatus = 1
                    login()
                End If
            Else
                MessageBox.Show("Please enter a valid username and password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            If IsTextBoxEmpty(txtUsername, txtPassword) = True Then
                MessageBox.Show("Please enter Username and Password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If account.IsLogin(txtUsername.Text, txtPassword.Text) = True Then
                    account.SetAccountDetails(account.AccountID)
                    If account.AccountRole = "Administrator" Then
                        account.LoginStatus = 0
                        login()
                    ElseIf account.LoginStatus = 1 Then
                        MessageBox.Show("Your account is already login from another device.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        account.LoginStatus = 1
                        login()
                    End If
                Else
                    MessageBox.Show("Please enter a valid username and password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            If IsTextBoxEmpty(txtUsername, txtPassword) = True Then
                MessageBox.Show("Please enter Username and Password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If account.IsLogin(txtUsername.Text, txtPassword.Text) = True Then
                    account.SetAccountDetails(account.AccountID)
                    If account.AccountRole = "Administrator" Then
                        account.LoginStatus = 0
                        login()
                    ElseIf account.LoginStatus = 1 Then
                        MessageBox.Show("Your account is already login from another device.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        account.LoginStatus = 1
                        login()
                    End If
                Else
                    MessageBox.Show("Please enter a valid username and password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        AllowedOnly(ForUserPass, txtUsername)
        EnableButton()
        txtUsername.MaxLength = 20
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        AllowedOnly(ForUserPass, txtPassword)
        EnableButton()
        txtPassword.MaxLength = 20
    End Sub

    Private Sub txtUsername_GotFocus(sender As Object, e As EventArgs) Handles txtUsername.GotFocus
        If txtUsername.Text = "Username" Then
            txtUsername.Text = ""
            txtUsername.ForeColor = Color.White
        End If
    End Sub

    Private Sub txtUsername_LostFocus(sender As Object, e As EventArgs) Handles txtUsername.LostFocus
        If txtUsername.Text = "" Then
            txtUsername.ForeColor = Color.Gray
            txtUsername.Text = "Username"
        End If
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        If txtPassword.Text = "Password" Then
            txtPassword.Text = ""
            txtPassword.ForeColor = Color.White
            txtPassword.PasswordChar = "●"
        End If
    End Sub

    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        If txtPassword.Text = "" Then
            txtPassword.ForeColor = Color.Gray
            txtPassword.Text = "Password"
            txtPassword.PasswordChar = ""
        End If
    End Sub

    ''----ConnectionForm----
    'Sub switchForm(ByVal panel As UserControl)
    '    panelRight.Controls.Clear()
    '    panelRight.Controls.Add(panel)
    '    panel.Dock = DockStyle.Fill
    '    panel.Show()
    'End Sub

    Private Sub linkAttendance_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkAttendance.LinkClicked
        Dim obj As New frmAttendanceTimein
        obj.ShowDialog()
    End Sub

    Private Sub panelContainer_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim obj As New frmConnection
        obj.ShowDialog()
    End Sub

End Class