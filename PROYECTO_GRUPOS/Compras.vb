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
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtidprovee_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtidprovee.KeyPress
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
           
            dts.idproveedor = txtidprovee.Text
            dts.nombre = lbn.Text
            dts.idproducto = txtidproduc.Text
            dts.producto = txtnomb.Text
            dts.cantidad = txtcant.Text
            dts.costounidad = txtprecio.Text
            If rbconta.Checked = True Then
                rbconta.Text = "Contado"
                dts.tipocompra = rbconta.Text
                compra = Val(txtcant.Text) * Val(txtprecio.Text)
                txtcompra.Text = compra
                dts.totalcompra = txtcompra.Text
            Else
                rbcredi.Checked = True
                rbcredi.Text = "Credito"
                dts.tipocompra = rbconta.Text
                compra = Val(txtcant.Text) * Val(txtprecio.Text)
                txtcompra.Text = compra
                dts.totalcompra = txtcompra.Text
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
End Class