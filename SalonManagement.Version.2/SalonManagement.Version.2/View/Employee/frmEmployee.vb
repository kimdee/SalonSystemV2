Public Class frmEmployee
    Private employee As New Employee

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        Dim obj As New frmAddEmployee
        If obj.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            employee.ViewEmployee(gvView, lblResult)
        Else
            employee.ViewEmployee(gvView, lblResult)
        End If
    End Sub

    Private Sub frmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        employee.ViewEmployee(gvView, lblResult)
    End Sub
End Class