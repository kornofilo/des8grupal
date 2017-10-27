Public Class Proveedores

    Private Sub Proveedores_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim estadoConexionDB As Boolean

        estadoConexionDB = DBConnection.connect("cuentasxpagar")
        
        DBConnection.ShowDataGrid("proveedores", dataprovee)
    End Sub
End Class