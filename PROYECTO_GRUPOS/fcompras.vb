Imports MySql.Data.MySqlClient
Public Class fcompras
    Inherits ConnectionDB

    Public Sub Consulta()

        Try
            Dim sql As String = "SELECT nombre FROM proveedores where idproveedor = ?ident"
            Dim cmd As New MySqlCommand(sql, connection_db)
            cmd.Parameters.AddWithValue("?ident", Compras.txtidprovee.Text)

            Dim DataAdapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            DataAdapter.Fill(dt)

            If dt.Rows.Count > 0 Then

                Dim row As DataRow = dt.Rows(0)
                Compras.lbn.Text = CStr(row("Nombre"))

            End If
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            connection_db.Dispose()

        End Try
    End Sub
End Class
