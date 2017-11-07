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
        Else
            MsgBox("Por favor, ingrese un código de compra válido.", 16)
        End If
    End Sub

    Private Sub ButtonRegistrarDevolución_Click(sender As Object, e As EventArgs) Handles ButtonRegistrarDevolución.Click
        Try
            Dim dts As New Datos_Devoluciones
            Dim func As New fdevoluciones

            dts.IDProveedor = IDProveedor
            dts.IDProducto = IDProducto
            dts.CantidadProduct = NumericUpDownCantDevoluciones.Value
            dts.IDCompra = idCompraTB
            dts.CostoUnitario = CostoUnitario
            dts.MontoDev = CostoUnitario * NumericUpDownCantDevoluciones.Value
            dts.Saldo = SaldoActual - CostoUnitario * NumericUpDownCantDevoluciones.Value
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
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class