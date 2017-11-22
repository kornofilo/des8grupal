Imports MySql.Data.MySqlClient
Public Class fcomprasDetalles
    Inherits ConnectionDB
    Dim cmd As New MySqlCommand

    Public Function insert_comp(ByVal dts As DatosCompraDetalle) As Boolean
        Try

            cmd = New MySqlCommand("INSERT_COMPDETALLE")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = connection_db

            cmd.Parameters.AddWithValue("@_idcompra", dts.idcompra)
            cmd.Parameters.AddWithValue("@_idprovee", dts.idproveedor)
            cmd.Parameters.AddWithValue("@_idproduc", dts.idproducto)
            cmd.Parameters.AddWithValue("@_produc", dts.producto)
            cmd.Parameters.AddWithValue("@_cant", dts.cantidad)
            cmd.Parameters.AddWithValue("@_costounidad", dts.costounidad)
            cmd.Parameters.AddWithValue("@_itbms", dts.itbms)
            cmd.Parameters.AddWithValue("@_totalcompr", dts.totalcompra)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception

            MsgBox(ex.Message)
            Return False
        End Try

    End Function
End Class
