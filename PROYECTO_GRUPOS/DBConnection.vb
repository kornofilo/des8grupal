Imports MySql.Data.MySqlClient

Module DBConnection
    Public conn As New MySqlConnection("Server= localhost; User id = root; password=12345;")

    Public table As New DataSet
    Public sql As String = ""
    Public connection_db As New MySqlConnection




    'Función que intenta conectarse con la base de datos y devuelve un valor booleano según si tuvo éxito o no en el proceso
    Public Function connect(ByVal db As String)
        Try
            connection_db = New MySqlConnection With {
                .ConnectionString = "Server=localhost; Database= " + db + "; User id = root;  password=;"
            }
            connection_db.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString, 16, "Connection Error")
            Return False
        End Try
    End Function

    'Subprograma que recibe el nombre de la tabla para que muestre sus registros en el datagridView declarado como segundo parámetro.
    Public Sub ShowDataGrid(ByVal Tabla As String, ByVal DatagridContenedor As DataGridView)
        Dim estadoConexionDB As Boolean

        estadoConexionDB = connect("cuentasxpagar")
        If estadoConexionDB = True Then
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




        Else

        End If
    End Sub

End Module