Public Class Compras
    Dim obj As New ConnectionDB
    Dim funcion As New fcompras
    Dim compra As Double
    Dim total As Double
    Public NombreProveedor As String
    Public IDCompra As Integer

    Public NombreProducto As String
    Public PrecioProducto As Decimal


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obj.GetNumFactura(LabelNumFac)
    End Sub

    Public Sub Mostrar()
        Try
            obj.ShowDataGrid("compras", DataGridViewCompras)
        Catch ex As Exception
        End Try
    End Sub

    'Subprograma que al presionar la tecla ENTER. Llama a la función consulta del la clase fcompra.'
    Private Sub txtidprovee_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtidprovee.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Try
                funcion.Consulta()

            Catch ex As Exception

            End Try
        End If

    End Sub

    'Subprograma que al presionar la tecla ENTER. Llama a la función consultaProducto del la clase fcompra.'
    Private Sub txtidproduc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtidproduc.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Try
                funcion.ConsultaProducto()
                txtprecio.Text = PrecioProducto

                TxtNombreProducto.Text = NombreProducto

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btagregar_Click(sender As System.Object, e As System.EventArgs) Handles btagregar.Click
        DataGridViewCompras.Rows.Add(txtidproduc.Text, NombreProducto, NumericUpDownCantidadProductos.Value, FormatCurrency(PrecioProducto), FormatCurrency((NumericUpDownCantidadProductos.Value * PrecioProducto) * 0.07), FormatCurrency((NumericUpDownCantidadProductos.Value * PrecioProducto) * 1.07))

    End Sub


    Private Sub txtbuscar_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtbuscar.TextChanged
        funcion.busquedaprovee(txtbuscar.Text, DataGridViewCompras)
    End Sub

    Private Sub NumericUpDownCantidadProductos_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownCantidadProductos.ValueChanged
        TxtPrecioTotal.Text = FormatCurrency(PrecioProducto * NumericUpDownCantidadProductos.Value)
    End Sub

    Private Sub ButtonFinalizarCompra_Click(sender As Object, e As EventArgs) Handles ButtonFinalizarCompra.Click
        Try
            'Insertamos los datos generales de la compra.'
            Dim dts As New Datos_Compras
            Dim func As New fcompras

            dts.idproveedor = txtidprovee.Text
            dts.nombre = NombreProveedor
            dts.totalcompra = CalcularTotalCompra()
            If rbconta.Checked = True Then
                dts.tipocompra = "Contado"
            Else
                dts.tipocompra = "Crédito"
            End If

            'Insertamos los detalles de la compra.'
            Dim dtsCompraDetalle As New DatosCompraDetalle
            Dim funcCDetalle As New fcomprasDetalles
            For index As Integer = 0 To DataGridViewCompras.Rows.Count - 2
                dtsCompraDetalle.idcompra = IDCompra
                dtsCompraDetalle.idproveedor = DataGridViewCompras.Rows(index).Cells(0).Value.ToString
                dtsCompraDetalle.producto = DataGridViewCompras.Rows(index).Cells(1).Value.ToString
                dtsCompraDetalle.cantidad = DataGridViewCompras.Rows(index).Cells(2).Value.ToString
                dtsCompraDetalle.costounidad = DataGridViewCompras.Rows(index).Cells(3).Value
                dtsCompraDetalle.itbms = DataGridViewCompras.Rows(index).Cells(4).Value
                dtsCompraDetalle.totalcompra = DataGridViewCompras.Rows(index).Cells(5).Value
                funcCDetalle.insert_comp(dtsCompraDetalle)
            Next

            If func.insert_comp(dts) Then
                MessageBox.Show("Compra Registrado Correctamente", "Guardar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                obj.limpiarcampos(Me)
                obj.desconectado()
                obj.GetNumFactura(LabelNumFac)
                DataGridViewCompras.Rows.Clear()
                NumericUpDownCantidadProductos.Value = 1

            Else
                MessageBox.Show("Error al Registrar Compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridViewCompras_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewCompras.CellMouseUp
        If (e.Button = MouseButtons.Right) Then
            ContextMenuStripEliminar.Show(Cursor.Position)
        End If
    End Sub

    Private Sub ContextMenuStripEliminar_Click(sender As Object, e As EventArgs) Handles ContextMenuStripEliminar.Click
        DataGridViewCompras.Rows.Remove(DataGridViewCompras.CurrentRow)
    End Sub

    Private Function CalcularTotalCompra()
        Dim TotalCompra As Decimal
        For index As Integer = 0 To DataGridViewCompras.RowCount - 2
            TotalCompra += DataGridViewCompras.Rows(index).Cells(5).Value
        Next
        Return TotalCompra
    End Function
End Class