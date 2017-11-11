Public Class Compras
    Dim obj As New ConnectionDB
    Dim funcion As New fcompras
    Dim compra As Double
    Dim total As Double
    Public NombreProveedor As Integer
    Public NombreProducto As String
    Public PrecioProducto As Decimal


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        Try

            Dim dts As New Datos_Compras
            Dim func As New fcompras

            dts.idproveedor = txtidprovee.Text
            dts.nombre = ""
            dts.idproducto = txtidproduc.Text
            dts.producto = "Nombre"
            dts.cantidad = ""
            dts.costounidad = txtprecio.Text
            If rbconta.Checked = True Then
                rbconta.Text = "Contado"
                dts.tipocompra = rbconta.Text
                compra = Val(NumericUpDownCantidadProductos.Value) * Val(txtprecio.Text)
                dts.totalcompra = compra
            Else
                rbcredi.Checked = True
                rbcredi.Text = "Credito"
                dts.tipocompra = rbcredi.Text
                compra = Val(NumericUpDownCantidadProductos.Value) * Val(txtprecio.Text)
                dts.totalcompra = compra
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


    Private Sub txtbuscar_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtbuscar.TextChanged
        funcion.busquedaprovee(txtbuscar.Text, DataGridViewCompras)
    End Sub

    Private Sub DataGridViewCompras_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewCompras.CellContentClick

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub NumericUpDownCantidadProductos_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownCantidadProductos.ValueChanged
        TxtPrecioTotal.Text = FormatCurrency(PrecioProducto * NumericUpDownCantidadProductos.Value)
    End Sub
End Class