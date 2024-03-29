﻿Imports MySql.Data.MySqlClient

Public Class frmAddPayments
    Public appointment As Appointment
    Public customer As Customer

    Private billing As New Billing

    Public Shared dtServer As Date = DateTime.Now

    Private Sub frmPayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With appointment
            txtTotal.Text = .AppointmentTotalAmount
        End With

        With customer
            txtFName.Text = .CustomerName
            If .CustomerSex = "Male" Then
                rdbMale.Checked = True
            Else
                rdbFemale.Checked = True
            End If
        End With

        TimerPayment.Start()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Try
            With billing
                For Each r As DataGridViewRow In gvView.Rows
                    .AppointmentID = appointment.AppointmentID
                    .CustomerID = customer.CustomerID
                    .EmployeeID = r.Cells(0).Value.ToString
                    .BillingDate = tsstDate.ToString
                    .BillingAmount = txtTotal.Text
                    .BillingStatus = "Paid"
                    .AppointmentType = appointment.AppointmentType

                    If .Addbill() = True Then
                        Dim ok As New OKMessage
                        ok = New OKMessage
                        ok.lblMsg.Text = "Paid"
                        ok.ShowDialog()
                        Me.Close()
                    End If
                Next
            End With

            With appointment
                .AppointmentStatus = "Paid"
            End With

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        Dim obj As New frmEmployeeServe
        If obj.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim index As Integer = 1
            For Each row As DataGridViewRow In obj.gvView.Rows
                If row.Cells(1).Value = True Then
                    With gvView
                        .Rows.Add(row.Cells(0).Value.ToString,
                                  index.ToString,
                                  row.Cells(3).Value.ToString,
                                  row.Cells(4).Value.ToString,
                                  row.Cells(5).Value.ToString,
                                  "Remove")
                    End With
                    index += 1
                End If
            Next
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimerPayment.Tick
        Dim sql As String = "SELECT now();"
        Try
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                dtServer = cmd.ExecuteScalar

                tsstDate.Text = dtServer.ToShortDateString
                tsstTime.Text = dtServer.ToString("hh:mm:ss tt")

                'lblDate.Text = MonthName(dtServer.Month) + " " + dtServer.Day.ToString() + ", " + dtServer.Year.ToString()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtxRecieve_TextChanged(sender As Object, e As EventArgs) Handles txtxRecieve.TextChanged
        txtChange.Text = txtTotal.Text - txtxRecieve.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class