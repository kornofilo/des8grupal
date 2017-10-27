Imports MySql.Data.MySqlClient

Module conexionDB
    Public conn As New MySqlConnection("Server= localhost; User id = root; password=12345;")
    Public MyDataTable As New DataTable
    Public table As New DataSet
    Public sql As String = ""
    Public reader As MySqlDataReader
    Public connection_db As New MySqlConnection
    Private MyBindingSource As New BindingSource



    'Función que intenta conectarse con la base de datos y devuelve un valor booleano según si tuvo éxito o no en el proceso
    Public Function connect(ByVal db As String)
        Try
            connection_db = New MySqlConnection With {
                .ConnectionString = "Server=localhost; Database= " + db + "; User id = root;  password=12345;"
            }
            connection_db.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString, 16, "Connection Error")
            Return False
        End Try
    End Function

    Public Sub showDataGridCompras()
        Dim estadoConexionDB As Boolean

        estadoConexionDB = connect("cuentasxpagar")
        If estadoConexionDB = True Then
            Try
                Dim QuerySelect As String
                Dim MyDataAdapter As New MySqlDataAdapter
                Dim MyCommand As New MySqlCommand
                QuerySelect = "SELECT * FROM cuentasxpagar.compras"
                MyCommand = New MySqlCommand(QuerySelect, connection_db)
                MyDataAdapter.SelectCommand = MyCommand
                MyDataAdapter.Fill(MyDataTable)
                MyBindingSource.DataSource = MyDataTable
                Compras.DataGridView1.DataSource = MyBindingSource
                MyDataAdapter.Update(MyDataTable)
                connection_db.Close()


            Catch ex As MySqlException
                MsgBox(ex)
            Finally
                connection_db.Dispose()

            End Try




        Else

        End If
    End Sub

End Module