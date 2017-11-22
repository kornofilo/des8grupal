Public Class CompraBuscar
    Dim obj As New ConnectionDB

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        If IsNumeric(TextBoxBuscarCompra.Text) = True Then
            obj.BuscarCompra(TextBoxBuscarCompra.Text)
            obj.ShowDataGridBuscarCompra(DataGridViewCompras, Val(TextBoxBuscarCompra.Text))
        Else
            MsgBox("Por favor, ingrese un código de compra válido.", 16)
        End If
    End Sub
End Class