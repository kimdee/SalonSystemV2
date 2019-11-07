Public Class frmAppointment
    Private appointment As New Appointment
    Private customer As New Customer
    Private service As New Service

    Private Sub btnAddAppointment_Click(sender As Object, e As EventArgs) Handles btnAddAppointment.Click
        Dim obj As New frmAddAppointment
        If obj.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            appointment.ViewAppointment(gvView)
        Else
            appointment.ViewAppointment(gvView)
        End If
    End Sub

    Private Sub frmAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        appointment.ViewAppointment(gvView)
    End Sub

    Private Sub gvViewWalkIn_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvView.CellContentClick
        If e.ColumnIndex = 9 Then
            appointment.SetAppointmentDetails(gvView.SelectedRows(0).Cells(0).Value)
            If MessageBox.Show("Are you sure you want to delete customer " + customer.CustomerName, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If appointment.DeleteAppointment() = True Then
                    appointment.ViewAppointment(gvView)
                Else
                    MessageBox.Show("Failed to delete. Please try again.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
            'Dim obj As New frmEditAppointment
            'obj.appointment = Me.appointment
            'obj.customer = Me.customer
            'obj.service = Me.service
            'If obj.ShowDialog = DialogResult.OK Then
            '    appointment.ViewAppointment(gvView)
            'End If
        End If
    End Sub

End Class