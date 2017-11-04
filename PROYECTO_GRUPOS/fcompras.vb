Imports MySql.Data.MySqlClient
Public Class fcompras
    Inherits ConnectionDB
    Dim cmd As New MySqlCommand

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
    Public Function insert_comp(ByVal dts As Datos_Compras) As Boolean
        Try

            cmd = New MySqlCommand("INSERT_COMP")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = connection_db

            cmd.Parameters.AddWithValue("@_idcompra", dts.idcompra)
            cmd.Parameters.AddWithValue("@_idprovee", dts.idproveedor)
            cmd.Parameters.AddWithValue("@_nombre", dts.nombre)
            cmd.Parameters.AddWithValue("@_fecha", dts.fecha)
            cmd.Parameters.AddWithValue("@_idproduc", dts.idproducto)
            cmd.Parameters.AddWithValue("@_produc", dts.producto)
            cmd.Parameters.AddWithValue("@_cant", dts.cantidad)
            cmd.Parameters.AddWithValue("@_costouni", dts.costounidad)
            cmd.Parameters.AddWithValue("@_totalcompr", dts.totalcompra)
            cmd.Parameters.AddWithValue("@_tipocompr", dts.tipocompra)
            cmd.Parameters.AddWithValue("@_cxp", dts.cxp)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception

            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try

    End Function

    Sub busquedaprovee(ByVal no As String, ByVal DataGridViewCompras As DataGridView)
        Try
            Dim adaptador As MySqlDataAdapter
            adaptador = New MySqlDataAdapter("Select * from compras where nombre like '" & "%" + no + "%" & "'", connection_db)
            MyDataTable = New DataTable
            adaptador.Fill(MyDataTable)
            DataGridViewCompras.DataSource = MyDataTable
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
