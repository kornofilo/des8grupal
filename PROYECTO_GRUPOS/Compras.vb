Public Class Compras
    Dim CdbOBj As New ConnectionDB

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Verificamos el estado de la conexión con la base de datos.
        Dim estadoConexionDB As Boolean
        estadoConexionDB = DBConnection.connect("cuentasxpagar")

        If estadoConexionDB = True Then
            ToolStripStatusConnectionDB.Text = "Conectado a la Base de Datos."
            CdbOBj.selectNombreProveedor(ComboBoxProveedores)
        Else
            ToolStripStatusConnectionDB.Text = "Sin Conexión con la Base de Datos."
        End If


    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Close()
    End Sub
End Class