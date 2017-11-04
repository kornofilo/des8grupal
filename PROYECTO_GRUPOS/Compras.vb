Public Class Compras
    Dim obj As New ConnectionDB
    Dim funcion As New fcompras
    Dim compra As Double


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Public Sub mostrar()
        Try
            obj.ShowDataGrid("compras", DataGridViewCompras)

            'Alimentamos el combo box de proveedores con los que están registrados en la base de datos'
            obj.GetNombreProveedores(ComboBoxProveedores)

            'Alimentamos el combo box de productos con los que están registrados en la base de datos'
            obj.GetNombreProductos(ComboBoxProductos)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtidprovee_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            Try
                funcion.Consulta()
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub btagregar_Click(sender As System.Object, e As System.EventArgs) Handles btagregar.Click
        Try
            Dim dts As New Datos_Compras
            Dim func As New fcompras

            dts.idproveedor = ComboBoxProveedores.SelectedValue.ToString
            dts.nombre = ComboBoxProveedores.Text
            dts.idproducto = ComboBoxProductos.SelectedValue.ToString
            dts.producto = ComboBoxProductos.Text
            dts.cantidad = NumericUpDownCantidad.Text
            dts.costounidad = txtprecio.Text
            dts.totalcompra = txtcompra.Text
            If rbconta.Checked = True Then
                dts.tipocompra = rbconta.Text
            Else
                rbcredi.Checked = True
                dts.tipocompra = rbcredi.Text
            End If




            If func.insert_comp(dts) Then
                MessageBox.Show("Compra Registrado Correctamente", "Guardar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                obj.limpiarcampos(Me)

            Else
                MessageBox.Show("Compra Registrado Correctamente", "Guardar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

            'Refrescamos el Datagridview con la compra registrada'
            mostrar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


<<<<<<< HEAD

    Private Sub ComboBoxProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxProductos.SelectedIndexChanged
        obj.GetPrecio(ComboBoxProductos.SelectedValue.ToString)
        txtcompra.Text = FormatCurrency(Val(txtprecio.Text) * NumericUpDownCantidad.Value)
    End Sub

    Private Sub NumericUpDownCantidad_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownCantidad.ValueChanged
        txtcompra.Text = FormatCurrency(Val(txtprecio.Text) * NumericUpDownCantidad.Value)
=======
    Private Sub txtbuscar_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtbuscar.TextChanged
        funcion.busquedaprovee(txtbuscar.Text, DataGridViewCompras)
    End Sub

    Private Sub DataGridViewCompras_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewCompras.CellContentClick

>>>>>>> master
    End Sub
End Class