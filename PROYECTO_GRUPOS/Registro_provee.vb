Public Class Registro_provee

    Private Sub btregi_Click(sender As System.Object, e As System.EventArgs) Handles btregi.Click
        Try

            Dim dts As New Datos_Provee
            Dim func As New ConnectionDB

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


            Else
                MessageBox.Show("Produccion Registrado Correctamente", "Guardar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class