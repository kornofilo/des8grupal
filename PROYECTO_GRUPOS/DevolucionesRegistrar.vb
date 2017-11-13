Public Class DevolucionesRegistrar
    Dim obj As New ConnectionDB
    Dim idCompraTB As Integer
    Public IDProveedor As Integer
    Public IDProducto As Integer
    Public CantidadProductos As Integer

    Public SaldoActual As Decimal
    Public CostoUnitario As Decimal


    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        If IsNumeric(TextBoxBuscarCompra.Text) = True Then
            obj.BuscarCompraRegistroDevolucion(TextBoxBuscarCompra.Text)
            idCompraTB = TextBoxBuscarCompra.Text
            obj.getCantidadesCompradas(idCompraTB, ComboBoxProductos.SelectedValue)
        Else
            MsgBox("Por favor, ingrese un código de compra válido.", 16)
        End If
    End Sub

    Private Sub ButtonRegistrarDevolución_Click(sender As Object, e As EventArgs) Handles ButtonRegistrarDevolución.Click
        If ((SaldoActual - (CostoUnitario * NumericUpDownCantDevoluciones.Value)) > 0) Then
            Try
                Dim dts As New Datos_Devoluciones
                Dim func As New fdevoluciones

                dts.IDProveedor = IDProveedor
                dts.IDProducto = IDProducto
                dts.CantidadProduct = NumericUpDownCantDevoluciones.Value
                dts.IDCompra = idCompraTB
                dts.CostoUnitario = CostoUnitario
                dts.MontoDev = CostoUnitario * NumericUpDownCantDevoluciones.Value
                dts.Saldo = SaldoActual - (CostoUnitario * NumericUpDownCantDevoluciones.Value)
                MsgBox(Val(CostoUnitario * NumericUpDownCantDevoluciones.Value))
                If func.insert_devolucion(dts) Then
                    MessageBox.Show("Devolución Registrada Correctamente", "Guardar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    obj.limpiarcampos(Me)
                    obj.BuscarCompraRegistroDevolucion(idCompraTB)
                Else
                    MessageBox.Show("Error al Registrar la Devolución", "Guardar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
                obj.BuscarCompraRegistroPago(idCompraTB)
            Catch ex As Exception
                MsgBox(ex.StackTrace)
            End Try
        Else
            MessageBox.Show("No se puede realizar la devolución ya que el monto a devolver es mayor que el saldo actual.", "Error de Devolución", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If


    End Sub



    Private Sub ComboBoxProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxProductos.SelectedIndexChanged
        obj.getCantidadesCompradas(idCompraTB, ComboBoxProductos.SelectedValue)
    End Sub

End Class