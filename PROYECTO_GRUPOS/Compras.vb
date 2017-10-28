Public Class Compras

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim estadoConexionDB As Boolean

        estadoConexionDB = DBConnection.connect("cuentasxpagar")
        If estadoConexionDB = True Then
            ToolStripStatusConnectionDB.Text = "Conectado a la Base de Datos."
            ToolStripStatusConnectionDB.Image = My.Resources.Play
            DBConnection.ShowDataGrid("compras", DataGridView1)
            DataGridView1.Columns(0).HeaderText = "ID"
            DataGridView1.Columns(1).HeaderText = "PROVEEDOR"
            DataGridView1.Columns(2).HeaderText = "FECHA"
            DataGridView1.Columns(3).HeaderText = "ID DE PRODUCTO"
            DataGridView1.Columns(4).HeaderText = "CANTIDAD ADQUIRIDA"
            DataGridView1.Columns(5).HeaderText = "% DE DESCUENTO"
            DataGridView1.Columns(6).HeaderText = "MONTO DE DESCUENTO"
            DataGridView1.Columns(7).HeaderText = "MONTO DE ITBMS"
            DataGridView1.Columns(8).HeaderText = "SUBTOTAL"
            DataGridView1.Columns(9).HeaderText = "TOTAL DE LA COMPRA"









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