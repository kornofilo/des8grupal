﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DevolucionesRegistrar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.TextBoxBuscarCompra = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBoxDatosCompra = New System.Windows.Forms.GroupBox()
        Me.LabelSaldoActual = New System.Windows.Forms.Label()
        Me.LabelFormaDePago = New System.Windows.Forms.Label()
        Me.LabelCostoTotal = New System.Windows.Forms.Label()
        Me.LabelProveedorCompra = New System.Windows.Forms.Label()
        Me.LabelFechaCompra = New System.Windows.Forms.Label()
        Me.ButtonRegistrarDevolución = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumericUpDownCantDevoluciones = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxProductos = New System.Windows.Forms.ComboBox()
        Me.GroupBoxDatosCompra.SuspendLayout()
        CType(Me.NumericUpDownCantDevoluciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBuscar.Location = New System.Drawing.Point(704, 112)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(106, 40)
        Me.ButtonBuscar.TabIndex = 16
        Me.ButtonBuscar.Text = "Buscar"
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        '
        'TextBoxBuscarCompra
        '
        Me.TextBoxBuscarCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBuscarCompra.Location = New System.Drawing.Point(492, 115)
        Me.TextBoxBuscarCompra.Name = "TextBoxBuscarCompra"
        Me.TextBoxBuscarCompra.Size = New System.Drawing.Size(198, 34)
        Me.TextBoxBuscarCompra.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(229, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 29)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Número de Compra:"
        '
        'GroupBoxDatosCompra
        '
        Me.GroupBoxDatosCompra.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBoxDatosCompra.Controls.Add(Me.LabelSaldoActual)
        Me.GroupBoxDatosCompra.Controls.Add(Me.LabelFormaDePago)
        Me.GroupBoxDatosCompra.Controls.Add(Me.LabelCostoTotal)
        Me.GroupBoxDatosCompra.Controls.Add(Me.LabelProveedorCompra)
        Me.GroupBoxDatosCompra.Controls.Add(Me.LabelFechaCompra)
        Me.GroupBoxDatosCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxDatosCompra.Location = New System.Drawing.Point(107, 158)
        Me.GroupBoxDatosCompra.Name = "GroupBoxDatosCompra"
        Me.GroupBoxDatosCompra.Size = New System.Drawing.Size(847, 226)
        Me.GroupBoxDatosCompra.TabIndex = 17
        Me.GroupBoxDatosCompra.TabStop = False
        Me.GroupBoxDatosCompra.Text = "Datos de la Compra"
        Me.GroupBoxDatosCompra.Visible = False
        '
        'LabelSaldoActual
        '
        Me.LabelSaldoActual.AutoSize = True
        Me.LabelSaldoActual.Location = New System.Drawing.Point(310, 175)
        Me.LabelSaldoActual.Name = "LabelSaldoActual"
        Me.LabelSaldoActual.Size = New System.Drawing.Size(142, 25)
        Me.LabelSaldoActual.TabIndex = 8
        Me.LabelSaldoActual.Text = "Saldo Actual:"
        '
        'LabelFormaDePago
        '
        Me.LabelFormaDePago.AutoSize = True
        Me.LabelFormaDePago.Location = New System.Drawing.Point(474, 44)
        Me.LabelFormaDePago.Name = "LabelFormaDePago"
        Me.LabelFormaDePago.Size = New System.Drawing.Size(166, 25)
        Me.LabelFormaDePago.TabIndex = 7
        Me.LabelFormaDePago.Text = "Forma de Pago:"
        '
        'LabelCostoTotal
        '
        Me.LabelCostoTotal.AutoSize = True
        Me.LabelCostoTotal.Location = New System.Drawing.Point(310, 138)
        Me.LabelCostoTotal.Name = "LabelCostoTotal"
        Me.LabelCostoTotal.Size = New System.Drawing.Size(131, 25)
        Me.LabelCostoTotal.TabIndex = 6
        Me.LabelCostoTotal.Text = "Costo Total:"
        '
        'LabelProveedorCompra
        '
        Me.LabelProveedorCompra.AutoSize = True
        Me.LabelProveedorCompra.Location = New System.Drawing.Point(103, 44)
        Me.LabelProveedorCompra.Name = "LabelProveedorCompra"
        Me.LabelProveedorCompra.Size = New System.Drawing.Size(118, 25)
        Me.LabelProveedorCompra.TabIndex = 2
        Me.LabelProveedorCompra.Text = "Proveedor:"
        '
        'LabelFechaCompra
        '
        Me.LabelFechaCompra.AutoSize = True
        Me.LabelFechaCompra.Location = New System.Drawing.Point(523, 0)
        Me.LabelFechaCompra.Name = "LabelFechaCompra"
        Me.LabelFechaCompra.Size = New System.Drawing.Size(79, 25)
        Me.LabelFechaCompra.TabIndex = 1
        Me.LabelFechaCompra.Text = "Fecha:"
        '
        'ButtonRegistrarDevolución
        '
        Me.ButtonRegistrarDevolución.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRegistrarDevolución.Location = New System.Drawing.Point(657, 472)
        Me.ButtonRegistrarDevolución.Name = "ButtonRegistrarDevolución"
        Me.ButtonRegistrarDevolución.Size = New System.Drawing.Size(271, 40)
        Me.ButtonRegistrarDevolución.TabIndex = 20
        Me.ButtonRegistrarDevolución.Text = "Registrar Devolución"
        Me.ButtonRegistrarDevolución.UseVisualStyleBackColor = True
        Me.ButtonRegistrarDevolución.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(210, 478)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(262, 29)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Unidades a Devolver:"
        Me.Label3.Visible = False
        '
        'NumericUpDownCantDevoluciones
        '
        Me.NumericUpDownCantDevoluciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownCantDevoluciones.Location = New System.Drawing.Point(490, 476)
        Me.NumericUpDownCantDevoluciones.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownCantDevoluciones.Name = "NumericUpDownCantDevoluciones"
        Me.NumericUpDownCantDevoluciones.Size = New System.Drawing.Size(120, 34)
        Me.NumericUpDownCantDevoluciones.TabIndex = 21
        Me.NumericUpDownCantDevoluciones.ThousandsSeparator = True
        Me.NumericUpDownCantDevoluciones.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownCantDevoluciones.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(302, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(433, 37)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Registrar Devolución"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PROYECTO_GRUPOS.My.Resources.Resources.Box
        Me.PictureBox1.Location = New System.Drawing.Point(760, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PROYECTO_GRUPOS.My.Resources.Resources.Box
        Me.PictureBox2.Location = New System.Drawing.Point(215, 10)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 32
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(210, 420)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 29)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Producto:"
        Me.Label5.Visible = False
        '
        'ComboBoxProductos
        '
        Me.ComboBoxProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxProductos.FormattingEnabled = True
        Me.ComboBoxProductos.Location = New System.Drawing.Point(490, 412)
        Me.ComboBoxProductos.Name = "ComboBoxProductos"
        Me.ComboBoxProductos.Size = New System.Drawing.Size(409, 37)
        Me.ComboBoxProductos.TabIndex = 35
        Me.ComboBoxProductos.Visible = False
        '
        'DevolucionesRegistrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1061, 521)
        Me.Controls.Add(Me.ComboBoxProductos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBoxDatosCompra)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDownCantDevoluciones)
        Me.Controls.Add(Me.ButtonRegistrarDevolución)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Controls.Add(Me.TextBoxBuscarCompra)
        Me.Controls.Add(Me.Label2)
        Me.Name = "DevolucionesRegistrar"
        Me.Text = "Nueva Devolución"
        Me.GroupBoxDatosCompra.ResumeLayout(False)
        Me.GroupBoxDatosCompra.PerformLayout()
        CType(Me.NumericUpDownCantDevoluciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents TextBoxBuscarCompra As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBoxDatosCompra As GroupBox
    Friend WithEvents LabelSaldoActual As Label
    Friend WithEvents LabelFormaDePago As Label
    Friend WithEvents LabelCostoTotal As Label
    Friend WithEvents LabelProveedorCompra As Label
    Friend WithEvents LabelFechaCompra As Label
    Friend WithEvents ButtonRegistrarDevolución As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents NumericUpDownCantDevoluciones As NumericUpDown
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxProductos As ComboBox
End Class
