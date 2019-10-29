Public Class frmPayroll

    Private Sub btnGeneratePayroll_Click(sender As Object, e As EventArgs) Handles btnGeneratePayroll.Click
        Dim obj As New frmAddEmployeePayroll
        obj.ShowDialog()
    End Sub
End Class