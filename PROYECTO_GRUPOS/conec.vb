Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.IO
Public Class conec
    Dim con As New MySqlConnection("Server=localhost; User id= root; password=;")
    Dim datatable As New DataTable
    Dim tabla As New DataSet
    Dim comando As New MySqlCommand
    Dim sql As String
    Dim reader As MySqlDataReader
    Dim dadapter As MySqlDataAdapter
    Dim conexion_bd As New MySqlConnection

    Public Sub conectar(ByVal bd As String)
        Try
            conexion_bd = New MySqlConnection("Server= localhost; Database=" + bd + "; user id= root;")
            conexion_bd.Open()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

End Class
