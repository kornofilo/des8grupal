Imports MySql.Data.MySqlClient

Public Class fdevoluciones
    Inherits ConnectionDB
    Dim cmd As New MySqlCommand



    Public Function insert_devolucion(ByVal dts As Datos_Devoluciones) As Boolean
        Try
            cmd = New MySqlCommand("INSERT_DEV")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = connection_db
            cmd.Parameters.AddWithValue("@_idProveedor", dts.IDProveedor)
            cmd.Parameters.AddWithValue("@_idProducto", dts.IDProducto)
            cmd.Parameters.AddWithValue("@_cantidadProduct", dts.CantidadProduct)
            cmd.Parameters.AddWithValue("@_id_compra", dts.IDCompra)
            cmd.Parameters.AddWithValue("@_costoUnitario", dts.CostoUnitario)
            cmd.Parameters.AddWithValue("@_montoDev", dts.MontoDev)
            cmd.Parameters.AddWithValue("@_saldo", dts.Saldo)
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
End Class
