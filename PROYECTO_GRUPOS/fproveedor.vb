Imports MySql.Data.MySqlClient

Public Class fproveedor
    Inherits ConnectionDB
    Dim cmd As New MySqlCommand

    Public Function insertar(ByVal dts As Datos_Provee) As Boolean
        Try

            cmd = New MySqlCommand("INSERT_PROVEE")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = connection_db

            cmd.Parameters.AddWithValue("@_codigo", dts.codigo)
            cmd.Parameters.AddWithValue("@_ruc", dts.RUC)
            cmd.Parameters.AddWithValue("@_dv", dts.DV)
            cmd.Parameters.AddWithValue("@_nombre", dts.nombre)
            cmd.Parameters.AddWithValue("@_telefono", dts.telefono)
            cmd.Parameters.AddWithValue("@_fax", dts.fax)
            cmd.Parameters.AddWithValue("@_direccion", dts.direccion)
            cmd.Parameters.AddWithValue("@_email", dts.email)
            cmd.Parameters.AddWithValue("@_tipoproveedor", dts.tipoproveedor)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception

            MsgBox(ex.Message)
            Return False
        Finally

        End Try

    End Function
    Public Function modificar_provee(ByVal dts As Datos_Provee) As Boolean
        Try

            cmd = New MySqlCommand("UPDAT_PROVEE")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = connection_db

            cmd.Parameters.AddWithValue("@_codigo", dts.codigo)
            cmd.Parameters.AddWithValue("@_ruc", dts.RUC)
            cmd.Parameters.AddWithValue("@_dv", dts.DV)
            cmd.Parameters.AddWithValue("@_nombre", dts.nombre)
            cmd.Parameters.AddWithValue("@_telefono", dts.telefono)
            cmd.Parameters.AddWithValue("@_fax", dts.fax)
            cmd.Parameters.AddWithValue("@_direccion", dts.direccion)
            cmd.Parameters.AddWithValue("@_email", dts.email)
            cmd.Parameters.AddWithValue("@_tipoproveedor", dts.tipoproveedor)

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

    Sub busquedaprovee(ByVal no As String, ByVal dataprovee As DataGridView)
        Try
            Dim adaptador As MySqlDataAdapter
            adaptador = New MySqlDataAdapter("Select * from proveedores where nombre like '" & "%" + no + "%" & "'", connection_db)
            MyDataTable = New DataTable
            adaptador.Fill(MyDataTable)
            dataprovee.DataSource = MyDataTable
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
