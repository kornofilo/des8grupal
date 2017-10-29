Imports MySql.Data.MySqlClient
Public Class ConnectionDB
    Public conn As New MySqlConnection("Server= localhost; User id = root; password=12345;")
    Public MyDataTable As New DataTable
    Public table As New DataSet
    Public sql As String = ""
    Public reader As MySqlDataReader
    Public connection_db As New MySqlConnection
    Dim cmd As New MySqlCommand
    Private MyBindingSource As New BindingSource


    'Función que intenta conectarse con la base de datos y devuelve un valor booleano según si tuvo éxito o no en el proceso

    Sub New()
        Try
            connection_db = New MySqlConnection With {
                .ConnectionString = "Server=localhost; Database= cuentasxpagar; User id = root;  password=;"
            }
            connection_db.Open()

        Catch ex As Exception
            MsgBox(ex.ToString, 16, "Connection Error")

        End Try
    End Sub
    'Subprograma que recibe el nombre de la tabla para que muestre sus registros en el datagridView declarado como segundo parámetro.
    Public Sub ShowDataGrid(ByVal Tabla As String, ByVal DatagridContenedor As DataGridView)

        Try
            Dim QuerySelect As String
            Dim MyDataAdapter As New MySqlDataAdapter
            Dim MyCommand As New MySqlCommand
            Dim MyBindingSource As New BindingSource
            Dim MyDataTable As New DataTable
            QuerySelect = "SELECT * FROM " & Tabla
            MyCommand = New MySqlCommand(QuerySelect, connection_db)
            MyDataAdapter.SelectCommand = MyCommand
            MyDataAdapter.Fill(MyDataTable)
            MyBindingSource.DataSource = MyDataTable
            DatagridContenedor.DataSource = MyBindingSource
            MyDataAdapter.Update(MyDataTable)
            connection_db.Close()


        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            connection_db.Dispose()

        End Try
    End Sub
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
End Class
