Imports MySql.Data.MySqlClient

Public Class fpagos
    Inherits ConnectionDB
    Dim cmd As New MySqlCommand



    Public Function insert_pago(ByVal dts As Datos_Pagos) As Boolean
        Try
            cmd = New MySqlCommand("INSERT_PAGO")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = connection_db
            cmd.Parameters.AddWithValue("@_id_Pago", dts.IDPago)
            cmd.Parameters.AddWithValue("@_idproveedor", dts.IDProveedor)
            cmd.Parameters.AddWithValue("@_monto", dts.Monto)
            cmd.Parameters.AddWithValue("@_fecha", dts.Fecha)
            cmd.Parameters.AddWithValue("@_id_compra", dts.IDCompra)
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
