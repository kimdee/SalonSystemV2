﻿Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class frmAddEmployee

    Private employee As New Employee
    Private deduction As New Deduction
    Private position As New Position
    Private msg As String = ""

    Private add As Boolean = False
    Private edit As Boolean = False

    Private deleteExprtise As New ArrayList

    Dim gender As String = "Male"
    Private Sub frmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisableInput(Me)
    End Sub

    ''---------Inputs Enable---------
    Private Sub EnableInput(root As Control)
        For Each ctrl As Control In root.Controls
            EnableInput(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Enabled = True
            End If
            If TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).Enabled = True
            End If
            If TypeOf ctrl Is RadioButton Then
                CType(ctrl, RadioButton).Enabled = True
            End If
            If TypeOf ctrl Is DateTimePicker Then
                CType(ctrl, DateTimePicker).Enabled = True
            End If
            If TypeOf ctrl Is CheckBox Then
                CType(ctrl, CheckBox).Enabled = True
            End If
        Next ctrl
        txtLName.Focus()
        txtAge.Enabled = False
    End Sub
    Private Sub DisableInput(root As Control)
        For Each ctrl As Control In root.Controls
            DisableInput(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Enabled = False
            End If
            If TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).Enabled = False
            End If
            If TypeOf ctrl Is RadioButton Then
                CType(ctrl, RadioButton).Enabled = False
            End If
            If TypeOf ctrl Is DateTimePicker Then
                CType(ctrl, DateTimePicker).Enabled = False
            End If
            If TypeOf ctrl Is CheckBox Then
                CType(ctrl, CheckBox).Enabled = False
            End If
        Next ctrl
    End Sub
    Private Sub ClearInput(root As Control)
        For Each ctrl As Control In root.Controls
            ClearInput(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
            If TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).Text = String.Empty
            End If
        Next ctrl
    End Sub
    Private Sub AllowedOnly(s As String, tb As TextBox)
        Try
            Dim theText As String = tb.Text
            Dim Letter As String
            Dim SelectionIndex As Integer = tb.SelectionStart
            Dim Change As Integer
            For x As Integer = 0 To tb.Text.Length - 1
                Letter = tb.Text.Substring(x, 1)
                If s.Contains(Letter) = False Then
                    theText = theText.Replace(Letter, String.Empty)
                    Change = 1
                End If
            Next
            tb.Text = theText
            tb.Select(SelectionIndex - Change, 0)
        Catch ex As Exception
        End Try
    End Sub

    ''---------Buttons Enable/Color---------
    Private Sub ResetButton()
        btnSearch.Enabled = True
        btnSearch.BackColor = Color.WhiteSmoke
        btnNew.Enabled = True
        btnNew.BackColor = Color.WhiteSmoke
        btnEdit.Enabled = False
        btnEdit.BackColor = Color.DarkSlateGray
        btnDelete.Enabled = False
        btnDelete.BackColor = Color.DarkSlateGray
        btnSave.Enabled = False
        btnSave.BackColor = Color.DarkSlateGray
        btnCancel.Enabled = False
        btnCancel.BackColor = Color.DarkSlateGray
        btnClose.Enabled = True
        btnClose.BackColor = Color.WhiteSmoke
        btnUpload.Enabled = False
    End Sub
    Private Sub OnActionButton()
        btnSearch.Enabled = False
        btnSearch.BackColor = Color.WhiteSmoke
        btnNew.Enabled = False
        btnNew.BackColor = Color.WhiteSmoke
        btnEdit.Enabled = False
        btnEdit.BackColor = Color.DarkSlateGray
        btnDelete.Enabled = False
        btnDelete.BackColor = Color.DarkSlateGray
        btnSave.Enabled = True
        btnSave.BackColor = Color.DarkSlateGray
        btnCancel.Enabled = True
        btnCancel.BackColor = Color.DarkSlateGray
        btnClose.Enabled = False
        btnClose.BackColor = Color.WhiteSmoke
        btnUpload.Enabled = True
    End Sub

    ''---------Uploading Picture---------
    Public Function ConvertToBytes(img As PictureBox) As Byte()
        Try
            Dim msPic As New IO.MemoryStream
            img.BackgroundImage.Save(msPic, System.Drawing.Imaging.ImageFormat.Bmp)
            Dim Mybyte() As Byte = msPic.GetBuffer
            msPic.Close()
            Return Mybyte
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Private Function ResizeImage(ByVal PhotoFile As Image) As Image
        Return New Bitmap(PhotoFile, New Size(PictureImage.Width, PictureImage.Height))
    End Function
    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Try
            Dim ofd As New OpenFileDialog
            ofd.Title = "Choose a photo"
            ofd.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            ofd.Filter = "Picture Files(*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            ofd.FilterIndex = 2
            ofd.RestoreDirectory = False

            If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                If ofd.CheckFileExists = False Or ofd.CheckPathExists = False Then
                    MessageBox.Show("The File Does Not Exist.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = DialogResult.OK
                    Me.Close()

                Else
                    Dim PhotoFile As New IO.FileInfo(ofd.FileName)
                    If PhotoFile.Length <= 3500000 Then
                        Dim EmployeePhoto As New Bitmap(ofd.FileName)
                        PictureImage.BackgroundImageLayout = ImageLayout.Stretch
                        PictureImage.BackgroundImage = ResizeImage(EmployeePhoto)
                    Else
                        MessageBox.Show("File Size Too Large", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    ''---------Validation---------
    Private Function ValidateRequired() As Boolean
        If IsTextBoxEmpty(txtLName, txtFName, txtCN, txtPasscode) = True Or PictureImage.BackgroundImage Is PictureNoImage.BackgroundImage = True Then
            msg = "Picture And Fields with asterisk symbol are required."
            Return False
        Else
            msg = ""
            Return True
        End If
    End Function
    Private Function ValidateAge() As Boolean
        If employee.GetCurrentAge(dtpDob.Value.Date, frmMain.dtServer.Date) < 18 Then
            msg = "You are less than 18 years old"
            Return True
        Else
            msg = ""
            Return False
        End If
    End Function
    Private Function PasscodeLimit() As Boolean
        If txtPasscode.MaxLength <= 8 Then
            msg = "Passcode must be 8 characters or more"
            Return True
        Else
            msg = ""
            Return False
        End If
    End Function

    ''---------DoAdd/Edit---------
    Private Sub doAdd()
        Try
            If ValidateRequired() = True Then
                'If ValidateAge() = True Then
                'If PasscodeLimit() = True Then
                With employee
                    .EmployeeFN = txtFName.Text.Trim
                    .EmployeeLN = txtLName.Text.Trim
                    .EmployeeMN = txtMName.Text.Trim

                    .EmployeeBirthDate = dtpDob.Value.Date
                    .EmployeeGender = gender

                    .EmployeeCN = txtCN.Text.Trim
                    .EmployeePosition = cboPosition.Text.Trim
                    .EmployeePasscode = txtPasscode.Text.Trim

                    .EmployeePicture = .ConvertImageTo64(PictureImage.BackgroundImage)
                    .EmployeeStatus = 0

                    If .AddEmployee() = True Then
                        Dim ok As New OKMessage
                        ok = New OKMessage
                        ok.lblMsg.Text = "Succesfully Save New Employee."
                        ok.ShowDialog()
                        OnDone()
                    Else
                        Dim err As ErrorMessage
                        err = New ErrorMessage
                        err.lblMsg.Text = "Failed To Save Employee."
                        err.ShowDialog()
                    End If
                End With
            End If
            'End If
            'End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub doEdit()
        If ValidateRequired() = True Then
            If ValidateAge() = False Then
                If PasscodeLimit() = True Then
                    With employee
                        .EmployeeFN = txtFName.Text.Trim
                        .EmployeeLN = txtLName.Text.Trim
                        .EmployeeMN = txtMName.Text.Trim

                        .EmployeeBirthDate = dtpDob.Value.Date
                        .EmployeeGender = gender

                        .EmployeeCN = txtCN.Text.Trim
                        .EmployeePosition = cboPosition.Text.Trim
                        .EmployeePasscode = txtPasscode.Text.Trim

                        .EmployeePicture = .ConvertImageTo64(PictureImage.BackgroundImage)
                        .EmployeeStatus = 0

                        If .EditEmployee() = True Then
                            Dim ok As New OKMessage
                            ok = New OKMessage
                            ok.lblMsg.Text = "Employee has been update."
                            ok.ShowDialog()
                            OnDone()
                        Else
                            Dim err As ErrorMessage
                            err = New ErrorMessage
                            err.lblMsg.Text = "Failed to update Employee."
                            err.ShowDialog()
                        End If
                    End With
                End If
            End If
        End If
    End Sub
    Private Sub OnDone()
        ResetButton()
        DisableInput(Me)
        add = False
        edit = False
        ClearInput(Me)
        PictureImage.BackgroundImage = PictureNoImage.BackgroundImage
    End Sub

    ''---------Changes---------
    Private Sub rdbMale_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMale.CheckedChanged
        If rdbMale.Checked = True Then
            gender = "Male"
        End If
    End Sub

    Private Sub rdbFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rdbFemale.CheckedChanged
        If rdbFemale.Checked = True Then
            gender = "Female"
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ClearInput(Me)
        EnableInput(Me)

        txtStandardPay.Enabled = False
        txtBasicPays.Enabled = False
        txtOT.Enabled = False

        OnActionButton()

        position.LoadPositionToCBO(cboPosition)

        add = True
        edit = True
        deleteExprtise.Clear()
        PictureImage.BackgroundImage = PictureNoImage.BackgroundImage
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If add = True Then
            doAdd()
        ElseIf edit = True Then
            doEdit()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        EnableInput(Me)
        OnActionButton()
        add = False
        edit = True
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If frmMain.userType = 0 Then
            MessageBox.Show("You cannot delete a record.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("Are you sure you want to delete the selected Employee?", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
            If employee.EmployeeID <> 0 Then
                If Me.DialogResult = DialogResult.Yes Then
                    employee.DeleteEmployee()
                    ClearInput(Me)
                    DisableInput(Me)
                    ResetButton()
                    add = False
                    edit = False
                    deleteExprtise.Clear()
                    PictureImage.BackgroundImage = PictureNoImage.BackgroundImage
                End If
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        OnDone()
        ClearInput(Me)
        rdbMale.Checked = True
        dtpDob.ResetText()
        PictureImage.BackgroundImage = PictureNoImage.BackgroundImage
    End Sub

    Private Sub txtLName_TextChanged(sender As Object, e As EventArgs) Handles txtLName.TextChanged
        AllowedOnly(LetterOnly, txtLName)
        txtLName.MaxLength = 20
    End Sub

    Private Sub txtFName_TextChanged(sender As Object, e As EventArgs) Handles txtFName.TextChanged
        AllowedOnly(LetterOnly, txtFName)
        txtFName.MaxLength = 20
    End Sub

    Private Sub txtMName_TextChanged(sender As Object, e As EventArgs) Handles txtMName.TextChanged
        AllowedOnly(LetterWDot, txtMName)
        txtMName.MaxLength = 20
    End Sub

    Private Sub txtCN_TextChanged(sender As Object, e As EventArgs) Handles txtCN.TextChanged
        ContactNo(txtCN)
        PhoneFormat(txtCN)
        txtCN.MaxLength = 13
        AllowedOnly(NumberWDash, txtCN)
    End Sub

    Private Sub txtPasscode_TextChanged(sender As Object, e As EventArgs) Handles txtPasscode.TextChanged
        AllowedOnly(ForUserPass, txtPasscode)
        txtPasscode.MaxLength = 30
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim obj As New frmSearchEmployee
        obj.ShowDialog()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dtpDob_ValueChanged(sender As Object, e As EventArgs) Handles dtpDob.ValueChanged
        txtAge.Text = employee.GetCurrentAge(dtpDob.Value, frmMain.dtServer)
    End Sub

    Private Sub cboPosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPosition.SelectedIndexChanged
        With position
            .LoadPositionCboTextBox(cboPosition, txtStandardPay, txtOT, txtBasicPays)
        End With
    End Sub

End Class