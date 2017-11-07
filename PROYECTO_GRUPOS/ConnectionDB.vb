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
                .ConnectionString = "Server=localhost; Database= cuentasxpagar; User id = root;  password=12345;"
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

    Public Sub ShowDataGrid(ByVal Tabla As String, ByVal DatagridContenedor As DataGridView, ByVal Filtro As Integer)

        Try
            Dim QuerySelect As String
            Dim MyDataAdapter As New MySqlDataAdapter
            Dim MyCommand As New MySqlCommand
            Dim MyBindingSource As New BindingSource
            Dim MyDataTable As New DataTable
            QuerySelect = "SELECT * FROM " & Tabla & " WHERE id_compra = " & Filtro
            MyCommand = New MySqlCommand(QuerySelect, connection_db)
            MyDataAdapter.SelectCommand = MyCommand
            MyDataAdapter.Fill(MyDataTable)
            MyBindingSource.DataSource = MyDataTable
            DatagridContenedor.DataSource = MyBindingSource
            MyDataAdapter.Update(MyDataTable)
            DatagridContenedor.Visible = True
            connection_db.Close()


        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            connection_db.Dispose()

        End Try
    End Sub

    Public Sub ShowDataGridDevoluciones(ByVal Tabla As String, ByVal DatagridContenedor As DataGridView, ByVal Filtro As Integer)

        Try
            Dim QuerySelect As String
            Dim MyDataAdapter As New MySqlDataAdapter
            Dim MyCommand As New MySqlCommand
            Dim MyBindingSource As New BindingSource
            Dim MyDataTable As New DataTable
            QuerySelect = "SELECT * FROM " & Tabla & " WHERE idCompra = " & Filtro
            MyCommand = New MySqlCommand(QuerySelect, connection_db)
            MyDataAdapter.SelectCommand = MyCommand
            MyDataAdapter.Fill(MyDataTable)
            MyBindingSource.DataSource = MyDataTable
            DatagridContenedor.DataSource = MyBindingSource
            MyDataAdapter.Update(MyDataTable)
            DatagridContenedor.Visible = True
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

    'Subpograma que recibe un número de compra, si la encuentra en la base de datos, muestra su información en pantalla. En caso contrario, mostrará un mensaje que notifica al cliente que no se encontró ninguna compra con ese código'
    Public Sub BuscarCompraRegistroPago(ByVal IdCompra As Integer)
        Try
            Dim adaptador As MySqlDataAdapter
            adaptador = New MySqlDataAdapter("SELECT compras.idCompra, compras.fecha, compras.idproveedor, compras.cantidad,compras.nombre, compras.producto, compras.costoUnitario, compras.totalCompra, compras.tipoCompra, saldos.saldoActual FROM compras INNER JOIN saldos ON compras.idCompra = saldos.idCompra AND compras.idCompra = " & IdCompra & ";", connection_db)
            MyDataTable = New DataTable
            adaptador.Fill(MyDataTable)
            'Si encontramos una compra con el código ingresado'
            If MyDataTable.Rows.Count > 0 Then
                'Hacemos visible el groupbox con los elementos que muestran los datos de la comora'
                PagoRegistrar.GroupBoxDatosCompra.Visible = True



                'Compras.txtprecio.Text = MyDataTable.Rows(0).Item("precio").ToString
                PagoRegistrar.LabelProveedorCompra.Text = "Proveedor: " & MyDataTable.Rows(0).Item("nombre").ToString
                PagoRegistrar.LabelFechaCompra.Text = "Fecha: " & MyDataTable.Rows(0).Item("fecha").ToString
                PagoRegistrar.LabelFormaDePago.Text = "Forma de Pago: " & MyDataTable.Rows(0).Item("tipoCompra").ToString
                PagoRegistrar.LabelProductoCompra.Text = "Producto: " & MyDataTable.Rows(0).Item("producto").ToString
                PagoRegistrar.LabelCantidadCompra.Text = "Cantidad: " & MyDataTable.Rows(0).Item("cantidad").ToString
                PagoRegistrar.LabelCostoUnitario.Text = "Costo Unitario: " & FormatCurrency(MyDataTable.Rows(0).Item("costoUnitario").ToString)
                PagoRegistrar.LabelCostoTotal.Text = "Costo Total: " & FormatCurrency(MyDataTable.Rows(0).Item("totalCompra").ToString)
                PagoRegistrar.LabelSaldoActual.Text = "Saldo Actual: " & FormatCurrency(MyDataTable.Rows(0).Item("saldoActual").ToString)
                PagoRegistrar.IDProveedor = MyDataTable.Rows(0).Item("idproveedor").ToString
                PagoRegistrar.SaldoActual = MyDataTable.Rows(0).Item("saldoActual").ToString


                'Si hay un saldo pendiente en la compra, habilitamos los controles de registro de pago.'
                If Val(MyDataTable.Rows(0).Item("saldoActual").ToString) > 0 Then
                    PagoRegistrar.Label3.Visible = True
                    PagoRegistrar.TextBoxNuevoPago.Visible = True
                    PagoRegistrar.ButtonRegistrarPago.Visible = True
                End If
            Else
                MsgBox("El número de la orden ingresada no se encuentra registrada.", 16)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection_db.Dispose()
        End Try

    End Sub

    Public Sub BuscarCompraPago(ByVal IdCompra As Integer)
        Try
            Dim adaptador As MySqlDataAdapter
            adaptador = New MySqlDataAdapter("SELECT compras.idCompra, compras.fecha, compras.idproveedor, compras.cantidad,compras.nombre, compras.producto, compras.costoUnitario, compras.totalCompra, compras.tipoCompra, saldos.saldoActual FROM compras INNER JOIN saldos ON compras.idCompra = saldos.idCompra AND compras.idCompra = " & IdCompra & ";", connection_db)
            MyDataTable = New DataTable
            adaptador.Fill(MyDataTable)
            'Si encontramos una compra con el código ingresado'
            If MyDataTable.Rows.Count > 0 Then
                'Hacemos visible el groupbox con los elementos que muestran los datos de la comora'
                PagoBuscar.GroupBoxDatosCompra.Visible = True



                'Compras.txtprecio.Text = MyDataTable.Rows(0).Item("precio").ToString
                PagoBuscar.LabelProveedorCompra.Text = "Proveedor: " & MyDataTable.Rows(0).Item("nombre").ToString
                PagoBuscar.LabelFechaCompra.Text = "Fecha: " & MyDataTable.Rows(0).Item("fecha").ToString
                PagoBuscar.LabelFormaDePago.Text = "Forma de Pago: " & MyDataTable.Rows(0).Item("tipoCompra").ToString
                PagoBuscar.LabelProductoCompra.Text = "Producto: " & MyDataTable.Rows(0).Item("producto").ToString
                PagoBuscar.LabelCantidadCompra.Text = "Cantidad: " & MyDataTable.Rows(0).Item("cantidad").ToString
                PagoBuscar.LabelCostoUnitario.Text = "Costo Unitario: " & FormatCurrency(MyDataTable.Rows(0).Item("costoUnitario").ToString)
                PagoBuscar.LabelCostoTotal.Text = "Costo Total: " & FormatCurrency(MyDataTable.Rows(0).Item("totalCompra").ToString)
                PagoBuscar.LabelSaldoActual.Text = "Saldo Actual: " & FormatCurrency(MyDataTable.Rows(0).Item("saldoActual").ToString)
            Else
                MsgBox("El número de la orden ingresada no se encuentra registrada.", 16)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection_db.Dispose()
        End Try

    End Sub

    Public Sub BuscarCompraRegistroDevolucion(ByVal IdCompra As Integer)
        Try
            Dim adaptador As MySqlDataAdapter
            adaptador = New MySqlDataAdapter("SELECT compras.idCompra, compras.fecha, compras.idproveedor, compras.cantidad,compras.nombre, compras.idProducto,compras.producto, compras.costoUnitario, compras.totalCompra, compras.tipoCompra, saldos.saldoActual FROM compras INNER JOIN saldos ON compras.idCompra = saldos.idCompra AND compras.idCompra = " & IdCompra & ";", connection_db)
            MyDataTable = New DataTable
            adaptador.Fill(MyDataTable)
            'Si encontramos una compra con el código ingresado'
            If MyDataTable.Rows.Count > 0 Then
                'Hacemos visible el groupbox con los elementos que muestran los datos de la comora'
                DevolucionesRegistrar.GroupBoxDatosCompra.Visible = True



                'Compras.txtprecio.Text = MyDataTable.Rows(0).Item("precio").ToString
                DevolucionesRegistrar.LabelProveedorCompra.Text = "Proveedor: " & MyDataTable.Rows(0).Item("nombre").ToString
                DevolucionesRegistrar.LabelFechaCompra.Text = "Fecha: " & MyDataTable.Rows(0).Item("fecha").ToString
                DevolucionesRegistrar.LabelFormaDePago.Text = "Forma de Pago: " & MyDataTable.Rows(0).Item("tipoCompra").ToString
                DevolucionesRegistrar.LabelProductoCompra.Text = "Producto: " & MyDataTable.Rows(0).Item("producto").ToString
                DevolucionesRegistrar.LabelCantidadCompra.Text = "Cantidad: " & MyDataTable.Rows(0).Item("cantidad").ToString
                DevolucionesRegistrar.LabelCostoUnitario.Text = "Costo Unitario: " & FormatCurrency(MyDataTable.Rows(0).Item("costoUnitario").ToString)
                DevolucionesRegistrar.LabelCostoTotal.Text = "Costo Total: " & FormatCurrency(MyDataTable.Rows(0).Item("totalCompra").ToString)
                DevolucionesRegistrar.LabelSaldoActual.Text = "Saldo Actual: " & FormatCurrency(MyDataTable.Rows(0).Item("saldoActual").ToString)

                DevolucionesRegistrar.IDProveedor = MyDataTable.Rows(0).Item("idproveedor").ToString
                DevolucionesRegistrar.SaldoActual = MyDataTable.Rows(0).Item("saldoActual").ToString
                DevolucionesRegistrar.IDProveedor = MyDataTable.Rows(0).Item("idproveedor").ToString
                DevolucionesRegistrar.IDProducto = MyDataTable.Rows(0).Item("idProducto").ToString
                DevolucionesRegistrar.CostoUnitario = MyDataTable.Rows(0).Item("costoUnitario").ToString

                DevolucionesRegistrar.CantidadProductos = MyDataTable.Rows(0).Item("cantidad").ToString


                'Si hay un saldo pendiente en la compra, habilitamos los controles de registro de pago.'
                If Val(MyDataTable.Rows(0).Item("saldoActual").ToString) > 0 Then
                    DevolucionesRegistrar.Label3.Visible = True
                    DevolucionesRegistrar.NumericUpDownCantDevoluciones.Visible = True
                    DevolucionesRegistrar.NumericUpDownCantDevoluciones.Maximum = MyDataTable.Rows(0).Item("cantidad").ToString
                    DevolucionesRegistrar.ButtonRegistrarDevolución.Visible = True

                End If
            Else
                MsgBox("El número de la orden ingresada no se encuentra registrada.", 16)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection_db.Dispose()
        End Try

    End Sub

    Public Sub BuscarCompraDevolucion(ByVal IdCompra As Integer)
        Try
            Dim adaptador As MySqlDataAdapter
            adaptador = New MySqlDataAdapter("SELECT compras.idCompra, compras.fecha, compras.idproveedor, compras.cantidad,compras.nombre, compras.producto, compras.costoUnitario, compras.totalCompra, compras.tipoCompra, saldos.saldoActual FROM compras INNER JOIN saldos ON compras.idCompra = saldos.idCompra AND compras.idCompra = " & IdCompra & ";", connection_db)
            MyDataTable = New DataTable
            adaptador.Fill(MyDataTable)
            'Si encontramos una compra con el código ingresado'
            If MyDataTable.Rows.Count > 0 Then
                'Hacemos visible el groupbox con los elementos que muestran los datos de la comora'
                DevolucionesBuscar.GroupBoxDatosCompra.Visible = True



                'Compras.txtprecio.Text = MyDataTable.Rows(0).Item("precio").ToString
                DevolucionesBuscar.LabelProveedorCompra.Text = "Proveedor: " & MyDataTable.Rows(0).Item("nombre").ToString
                DevolucionesBuscar.LabelFechaCompra.Text = "Fecha: " & MyDataTable.Rows(0).Item("fecha").ToString
                DevolucionesBuscar.LabelFormaDePago.Text = "Forma de Pago: " & MyDataTable.Rows(0).Item("tipoCompra").ToString
                DevolucionesBuscar.LabelProductoCompra.Text = "Producto: " & MyDataTable.Rows(0).Item("producto").ToString
                DevolucionesBuscar.LabelCantidadCompra.Text = "Cantidad: " & MyDataTable.Rows(0).Item("cantidad").ToString
                DevolucionesBuscar.LabelCostoUnitario.Text = "Costo Unitario: " & FormatCurrency(MyDataTable.Rows(0).Item("costoUnitario").ToString)
                DevolucionesBuscar.LabelCostoTotal.Text = "Costo Total: " & FormatCurrency(MyDataTable.Rows(0).Item("totalCompra").ToString)
                DevolucionesBuscar.LabelSaldoActual.Text = "Saldo Actual: " & FormatCurrency(MyDataTable.Rows(0).Item("saldoActual").ToString)
            Else
                MsgBox("El número de la orden ingresada no se encuentra registrada.", 16)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection_db.Dispose()
        End Try

    End Sub
End Class
