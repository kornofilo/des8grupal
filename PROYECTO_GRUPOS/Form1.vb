Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connLog As Boolean
        connLog = connect("cuentasxpagar")
        If connLog = True Then
            ToolStripStatusLabelConnStatus.Text = "Conectado a la Base de Datos."
        Else
            ToolStripStatusLabelConnStatus.Text = "Sin conexión con la Base de Datos."
            MsgBox("Error al conectar con la Base de Datos", 16, "Error de Conexión con la Base de Datos")

        End If

    End Sub

    Private Sub REToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles REToolStripMenuItem.Click
        Form2.Show()


    End Sub

    Private Sub PROVEEDORToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PROVEEDORToolStripMenuItem.Click

    End Sub

    Private Sub ComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem.Click
        Form2.Show()

    End Sub

End Class
