﻿Public Class frmPosition
    Private position As New Position
    Dim edit As Boolean

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtName.Text = "" Then
            MessageBox.Show("Name required.", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtStandardPay.Text = "" Then
            MessageBox.Show("Name required.", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf IsTextBoxEmpty(txtName, txtStandardPay) = True Then
            MessageBox.Show("Name and Basic Pay are required.", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            With position

                .PositionName = txtName.Text
                .PositionStandardPay = txtStandardPay.Text
                .PositionOvertime = txtOT.Text
                .PositionBasicPay = txtBasicPays.Text

                If position.AddPosition = True Then
                    MessageBox.Show("Successfully Saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    position.ViewPosition(gvView, lblResult)
                Else
                    MessageBox.Show("Failed to save.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End With
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmAddPosition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        position.ViewPosition(gvView, lblResult)
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        AllowedOnly(AlphaChar, txtName)
        txtName.MaxLength = 15
    End Sub

    Private Sub txtStandardPay_TextChanged(sender As Object, e As EventArgs) Handles txtStandardPay.TextChanged
        AllowedOnly(NumberWDot, txtStandardPay)
        txtStandardPay.MaxLength = 15
        CheckforDoubleDot(txtStandardPay)

        If txtStandardPay.Text = "" Then
            txtBasicPays.Text = "0"
        Else
            txtBasicPays.Text = txtStandardPay.Text * 15
        End If
    End Sub

    Private Sub txtOT_TextChanged(sender As Object, e As EventArgs) Handles txtOT.TextChanged
        AllowedOnly(NumberWDot, txtOT)
        txtOT.MaxLength = 15
        CheckforDoubleDot(txtOT)
    End Sub

    Private Sub txtBasicPays_TextChanged(sender As Object, e As EventArgs) Handles txtBasicPays.TextChanged
        AllowedOnly(NumberWDot, txtBasicPays)
        CheckforDoubleDot(txtBasicPays)
    End Sub

End Class