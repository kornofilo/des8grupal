Public Class PagoBuscar
    Dim obj As New ConnectionDB

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        If IsNumeric(TextBoxBuscarCompra.Text) = True Then
            obj.BuscarCompraPago(TextBoxBuscarCompra.Text)
            obj.ShowDataGrid("pagos", DataGridViewHistorialPagos, Val(TextBoxBuscarCompra.Text))
        Else
            MsgBox("Por favor, ingrese un código de compra válido.", 16)
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

End Class