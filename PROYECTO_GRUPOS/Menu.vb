
Public Class Menu

    Private Sub REToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Compras.Show()


    End Sub

    Private Sub RegistrarPagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarPagoToolStripMenuItem.Click
        PagoRegistrar.Show()

    End Sub

    Private Sub ConsultarPagosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarPagosToolStripMenuItem.Click
        PagoBuscar.Show()
    End Sub

    Private Sub NuevaDevoluciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaDevoluciónToolStripMenuItem.Click
        DevolucionesRegistrar.Show()

    End Sub

    Private Sub ConsultarDevoluciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarDevoluciónToolStripMenuItem.Click
        DevolucionesBuscar.Show()
    End Sub

    Private Sub NuevoProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoProveedorToolStripMenuItem.Click
        Registro_provee.Show()

    End Sub

    Private Sub GestiónDeProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónDeProveedoresToolStripMenuItem.Click
        Proveedores.Show()
    End Sub

    Private Sub NuevaCompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaCompraToolStripMenuItem.Click
        Compras.Show()
    End Sub


End Class
