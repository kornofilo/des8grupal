Public Class DevolucionesBuscar
    Dim obj As New ConnectionDB

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        If IsNumeric(TextBoxBuscarCompra.Text) = True Then
            obj.BuscarCompraDevolucion(TextBoxBuscarCompra.Text)
            obj.ShowDataGridDevoluciones("devoluciones", DataGridViewHistorialPagos, Val(TextBoxBuscarCompra.Text))
        Else
            MsgBox("Por favor, ingrese un código de compra válido.", 16)
        End If
    End Sub
End Class