
Public Class Menu

    Private Sub REToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Compras.Show()


    End Sub

    Private Sub PROVEEDORToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PROVEEDORToolStripMenuItem.Click

    End Sub

    Private Sub ComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem.Click
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
End Class
