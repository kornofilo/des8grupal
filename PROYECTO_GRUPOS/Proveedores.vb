Public Class Proveedores
    Dim obj As New ConnectionDB
   
    Private Sub dataprovee_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataprovee.CellContentDoubleClick
        Registro_provee.ID.Text = dataprovee.CurrentRow.Cells(0).Value
        Registro_provee.txtruc.Text = dataprovee.CurrentRow.Cells(1).Value
        Registro_provee.txtdv.Text = dataprovee.CurrentRow.Cells(2).Value
        Registro_provee.txtnombre.Text = dataprovee.CurrentRow.Cells(3).Value
        Registro_provee.txttelefono.Text = dataprovee.CurrentRow.Cells(4).Value
        Registro_provee.txtfax.Text = dataprovee.CurrentRow.Cells(5).Value
        Registro_provee.txtdireccion.Text = dataprovee.CurrentRow.Cells(6).Value
        Registro_provee.txtemail.Text = dataprovee.CurrentRow.Cells(7).Value
        Registro_provee.cmtipoprovee.Text = dataprovee.CurrentRow.Cells(8).Value
    End Sub

    Public Sub mostrar()
        Try
            obj.ShowDataGrid("proveedores", dataprovee)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Proveedores_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        mostrar()

    End Sub

    Private Sub txtbuscar_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtbuscar.TextChanged
        obj.busquedaprovee(txtbuscar.Text, dataprovee)
    End Sub

    Private Sub dataprovee_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataprovee.CellContentClick

    End Sub

    Private Sub dataprovee_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataprovee.CellDoubleClick
        Registro_provee.txtcodigo.Text = dataprovee.CurrentRow.Cells(0).Value
        Registro_provee.txtruc.Text = dataprovee.CurrentRow.Cells(1).Value
        Registro_provee.txtdv.Text = dataprovee.CurrentRow.Cells(2).Value
        Registro_provee.txtnombre.Text = dataprovee.CurrentRow.Cells(3).Value
        Registro_provee.txttelefono.Text = dataprovee.CurrentRow.Cells(4).Value
        Registro_provee.txtfax.Text = dataprovee.CurrentRow.Cells(5).Value
        Registro_provee.txtdireccion.Text = dataprovee.CurrentRow.Cells(6).Value
        Registro_provee.txtemail.Text = dataprovee.CurrentRow.Cells(7).Value
        Registro_provee.cmtipoprovee.Text = dataprovee.CurrentRow.Cells(8).Value

        Me.Visible = False
        Registro_provee.Show()


    End Sub
End Class