
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
End Class
