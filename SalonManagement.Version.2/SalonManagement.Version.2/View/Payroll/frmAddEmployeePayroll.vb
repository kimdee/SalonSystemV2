Public Class frmAddEmployeePayroll
    Private employee As New Employee
    Private deduction As New Deduction

    Private Sub frmAddEmployeePayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        employee.SelectEmployee(gvViewEmployee)

    End Sub

    Sub recount()
        Dim i As Integer = 1
        Dim c As Decimal = 0
        For Each r As DataGridViewRow In gvViewDeduction.Rows
            r.Cells(1).Value = i
            i = i + 1
            c = c + r.Cells(3).Value
        Next
        txtTotalDeduction.Text = c
        'recolor()
        gvViewDeduction.ClearSelection()
    End Sub


    Private Sub btnAddDeduction_Click(sender As Object, e As EventArgs) Handles btnAddDeduction.Click
        Dim obj As New frmEmployeeDeduction
        If obj.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim index As Integer = 1
            For Each row As DataGridViewRow In obj.gvView.Rows
                If row.Cells(1).Value = True Then
                    With gvViewDeduction
                        .Rows.Add(row.Cells(0).Value.ToString,
                                       index.ToString,
                                       row.Cells(3).Value.ToString,
                                       row.Cells(4).Value.ToString,
                                       "Remove")
                    End With
                    index += 1
                    recount()
                End If
            Next
        End If
    End Sub

    Private Sub gvViewEmployee_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvViewEmployee.CellContentClick
        If e.ColumnIndex = 1 And gvViewEmployee.SelectedRows.Count > 0 Then
            If gvViewEmployee.SelectedRows(0).Cells(1).Value = False Then
                gvViewEmployee.SelectedRows(0).Cells(1).Value = True
                txtPosition.Text = gvViewEmployee.SelectedRows(0).Cells(5).Value.ToString
            Else
                gvViewEmployee.SelectedRows(0).Cells(1).Value = False
            End If
        End If
    End Sub
End Class