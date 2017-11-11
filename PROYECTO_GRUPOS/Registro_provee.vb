Public Class Registro_provee
    Dim obj As New ConnectionDB


    Private Sub btregi_Click(sender As System.Object, e As System.EventArgs) Handles btregi.Click
        Try

            Dim dts As New Datos_Provee
            Dim func As New fproveedor

            dts.RUC = txtruc.Text
            dts.DV = txtdv.Text
            dts.nombre = txtnombre.Text
            dts.telefono = txttelefono.Text
            dts.fax = txtfax.Text
            dts.direccion = txtdireccion.Text
            dts.email = txtemail.Text
            dts.tipoproveedor = cmtipoprovee.Text

            If func.insertar(dts) Then
                MessageBox.Show("Produccion Registrado Correctamente", "Guardar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Proveedores.Show()
                obj.limpiarcampos(Me)

            Else
                MessageBox.Show("Produccion   Registrado", "Guardar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub btmodif_Click(sender As System.Object, e As System.EventArgs) Handles btmodif.Click
        Try
            Dim dts As New Datos_Provee
            Dim func As New fproveedor
            dts.codigo = txtcodigo.Text
            dts.RUC = txtruc.Text
            dts.DV = txtdv.Text
            dts.nombre = txtnombre.Text
            dts.telefono = txttelefono.Text
            dts.fax = txtfax.Text
            dts.direccion = txtdireccion.Text
            dts.email = txtemail.Text
            dts.tipoproveedor = cmtipoprovee.Text

            If func.modificar_provee(dts) Then
                MessageBox.Show("Produccion Modificado Correctamente", "Guardar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Proveedores.Show()



            Else
                MessageBox.Show("Produccion no fue Modificado Correctamente", "Guardar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If
            mostrar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub mostrar()
        Try
            obj.ShowDataGrid("proveedores", Proveedores.dataprovee)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Registro_provee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btsal_Click(sender As Object, e As EventArgs) Handles btsal.Click
        Proveedores.Show()
    End Sub
End Class