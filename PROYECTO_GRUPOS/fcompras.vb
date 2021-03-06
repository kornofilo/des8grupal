﻿Imports MySql.Data.MySqlClient
Public Class fcompras
    Inherits ConnectionDB
    Dim cmd As New MySqlCommand

    Public Sub Consulta()

        Try
            Dim sql As String = "SELECT nombre FROM proveedores where codigo = ?ident"
            Dim cmd As New MySqlCommand(sql, connection_db)
            cmd.Parameters.AddWithValue("?ident", Compras.txtidprovee.Text)

            Dim DataAdapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            DataAdapter.Fill(dt)

            If dt.Rows.Count > 0 Then

                Dim row As DataRow = dt.Rows(0)
                Compras.NombreProveedor = CStr(row("nombre"))
            Else
                MsgBox("El código de proveedor ingresado no se encuentra registrado en la base de datos. Por favor, intente con otro código.", 48, "No se encontró proveedor")
            End If

        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            connection_db.Dispose()

        End Try
    End Sub

    Public Sub ConsultaProducto()

        Try
            Dim sql As String = "SELECT id_articulo,nombre_art,precio FROM articulos where id_articulo = ?ident"
            Dim cmd As New MySqlCommand(sql, connection_db)
            cmd.Parameters.AddWithValue("?ident", Compras.txtidproduc.Text)

            Dim DataAdapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            DataAdapter.Fill(dt)

            If dt.Rows.Count > 0 Then

                Dim row As DataRow = dt.Rows(0)
                Compras.NombreProducto = CStr(row("nombre_art"))
                Compras.PrecioProducto = CStr(row("precio"))
            Else
                MsgBox("El código del artículo ingresado no se encuentra registrado en la base de datos. Por favor, intente con otro código.", 48, "No se encontró artículo")
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
            cmd.Parameters.AddWithValue("@_totalcompra", dts.totalcompra)
            cmd.Parameters.AddWithValue("@_tipocompra", dts.tipocompra)
            cmd.Parameters.AddWithValue("@_cxp", dts.cxp)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As MySqlException

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
