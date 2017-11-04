﻿Imports MySql.Data.MySqlClient
Public Class ConnectionDB
    Public conn As New MySqlConnection("Server= localhost; User id = root; password=;")
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
    Public Function desconectado()
        Try
            If connection_db.State = ConnectionState.Open Then
                connection_db.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
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

    Public Sub limpiarcampos(ByVal form As Form)
        Dim text As Object
        Dim combo As Object
        Dim radiob As Object

        For Each text In form.Controls
            If TypeOf text Is TextBox Then
                Dim txttemp As TextBox = CType(text, TextBox)
                txttemp.Text = ""
            ElseIf TypeOf combo Is ComboBox Then
                Dim cmbtemp As ComboBox = CType(combo, ComboBox)
                cmbtemp.Text = ""
            ElseIf TypeOf radiob Is RadioButton Then
                Dim rdbtemp As RadioButton = CType(radiob, RadioButton)
                rdbtemp.Checked = False
            End If

        Next


    End Sub

    'Subprograma que obtiene los nombres de los proveedores registrados en el sistema y alimenta un combo box los nombres obtenidos.'
    Sub GetNombreProveedores(ByVal CBox As ComboBox)
        Try
            Dim adaptador As MySqlDataAdapter
            adaptador = New MySqlDataAdapter("Select codigo, nombre from proveedores", connection_db)
            MyDataTable = New DataTable
            adaptador.Fill(MyDataTable)
            If MyDataTable.Rows.Count > 0 Then
                CBox.DisplayMember = "nombre"
                CBox.ValueMember = "codigo"
                CBox.DataSource = MyDataTable

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection_db.Dispose()
        End Try

    End Sub

    'Subprograma que obtiene los nombres de los proveedores registrados en el sistema y alimenta un combo box los nombres obtenidos.'
    Sub GetNombreProductos(ByVal CBox As ComboBox)
        Try
            Dim adaptador As MySqlDataAdapter
            adaptador = New MySqlDataAdapter("Select id_articulo, nombre_art from articulos order by nombre_art ASC", connection_db)
            MyDataTable = New DataTable
            adaptador.Fill(MyDataTable)
            If MyDataTable.Rows.Count > 0 Then
                CBox.DisplayMember = "nombre_art"
                CBox.ValueMember = "id_articulo"
                CBox.DataSource = MyDataTable

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection_db.Dispose()
        End Try

    End Sub

    'Subprograma que obtiene los nombres de los proveedores registrados en el sistema y alimenta un combo box los nombres obtenidos.'
    Sub GetPrecio(ByVal IdProducto As String)
        Try
            Dim adaptador As MySqlDataAdapter
            adaptador = New MySqlDataAdapter("Select precio from articulos where id_articulo = " & IdProducto, connection_db)
            MyDataTable = New DataTable
            adaptador.Fill(MyDataTable)
            If MyDataTable.Rows.Count > 0 Then
                Compras.txtprecio.Text = MyDataTable.Rows(0).Item("precio").ToString

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection_db.Dispose()
        End Try

    End Sub

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
