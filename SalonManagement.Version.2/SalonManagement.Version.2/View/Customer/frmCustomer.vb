Public Class frmCustomer
    Private billing As New Billing

    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        billing.ViewCollection(gvView)
    End Sub

End Class