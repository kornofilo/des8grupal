Public Class Compras

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim estadoConexionDB As Boolean

        estadoConexionDB = conexionDB.connect("cuentasxpagar")
        If estadoConexionDB = True Then
            ToolStripStatusConnectionDB.Text = "Conectado a la Base de Datos."
            ToolStripStatusConnectionDB.Image = My.Resources.Play
            conexionDB.showDataGridCompras()

        Else
            ToolStripStatusConnectionDB.Text = "Sin Conexión con la Base de Datos."

        End If

    End Sub





    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub txtffiscal_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtffiscal.Validating

    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class