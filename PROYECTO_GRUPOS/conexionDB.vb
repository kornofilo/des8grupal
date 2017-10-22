Imports MySql.Data.MySqlClient

Module Connection
    Public conn As New MySqlConnection("Server= localhost; User id = root; password=12345;")
    Public datatable As New DataTable
    Public table As New DataSet
    Public sql As String = ""
    Public reader As MySqlDataReader
    Public dAdapter As MySqlDataAdapter
    Public connection_db As New MySqlConnection
    Public user As String


    'Function who start the connection with the DB and handle the possible errors.'
    Public Function connect(ByVal db As String)
        Try
            connection_db = New MySqlConnection("Server=localhost; Database= " + db + "; User id = root;  password=12345;")
            connection_db.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString, 16, "Connection Error")
            Return False
        End Try
    End Function

End Module
