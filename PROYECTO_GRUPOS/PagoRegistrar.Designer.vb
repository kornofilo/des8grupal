<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PagoRegistrar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PagoRegistrar))
        Me.ButtonRegistrarPago = New System.Windows.Forms.Button()
        Me.GroupBoxDatosCompra = New System.Windows.Forms.GroupBox()
        Me.LabelSaldoActual = New System.Windows.Forms.Label()
        Me.LabelFormaDePago = New System.Windows.Forms.Label()
        Me.LabelCostoTotal = New System.Windows.Forms.Label()
        Me.LabelCostoUnitario = New System.Windows.Forms.Label()
        Me.LabelCantidadCompra = New System.Windows.Forms.Label()
        Me.LabelProductoCompra = New System.Windows.Forms.Label()
        Me.LabelProveedorCompra = New System.Windows.Forms.Label()
        Me.LabelFechaCompra = New System.Windows.Forms.Label()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.TextBoxNuevoPago = New System.Windows.Forms.TextBox()
        Me.TextBoxBuscarCompra = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBoxDatosCompra.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonRegistrarPago
        '
        Me.ButtonRegistrarPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRegistrarPago.Location = New System.Drawing.Point(555, 526)
        Me.ButtonRegistrarPago.Name = "ButtonRegistrarPago"
        Me.ButtonRegistrarPago.Size = New System.Drawing.Size(217, 40)
        Me.ButtonRegistrarPago.TabIndex = 19
        Me.ButtonRegistrarPago.Text = "Registrar Pago"
        Me.ButtonRegistrarPago.UseVisualStyleBackColor = True
        Me.ButtonRegistrarPago.Visible = False
        '
        'GroupBoxDatosCompra
        '
        Me.GroupBoxDatosCompra.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBoxDatosCompra.Controls.Add(Me.LabelSaldoActual)
        Me.GroupBoxDatosCompra.Controls.Add(Me.LabelFormaDePago)
        Me.GroupBoxDatosCompra.Controls.Add(Me.LabelCostoTotal)
        Me.GroupBoxDatosCompra.Controls.Add(Me.LabelCostoUnitario)
        Me.GroupBoxDatosCompra.Controls.Add(Me.LabelCantidadCompra)
        Me.GroupBoxDatosCompra.Controls.Add(Me.LabelProductoCompra)
        Me.GroupBoxDatosCompra.Controls.Add(Me.LabelProveedorCompra)
        Me.GroupBoxDatosCompra.Controls.Add(Me.LabelFechaCompra)
        Me.GroupBoxDatosCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxDatosCompra.Location = New System.Drawing.Point(45, 148)
        Me.GroupBoxDatosCompra.Name = "GroupBoxDatosCompra"
        Me.GroupBoxDatosCompra.Size = New System.Drawing.Size(847, 339)
        Me.GroupBoxDatosCompra.TabIndex = 16
        Me.GroupBoxDatosCompra.TabStop = False
        Me.GroupBoxDatosCompra.Text = "Datos de la Compra"
        Me.GroupBoxDatosCompra.Visible = False
        '
        'LabelSaldoActual
        '
        Me.LabelSaldoActual.AutoSize = True
        Me.LabelSaldoActual.Location = New System.Drawing.Point(319, 299)
        Me.LabelSaldoActual.Name = "LabelSaldoActual"
        Me.LabelSaldoActual.Size = New System.Drawing.Size(142, 25)
        Me.LabelSaldoActual.TabIndex = 8
        Me.LabelSaldoActual.Text = "Saldo Actual:"
        '
        'LabelFormaDePago
        '
        Me.LabelFormaDePago.AutoSize = True
        Me.LabelFormaDePago.Location = New System.Drawing.Point(481, 108)
        Me.LabelFormaDePago.Name = "LabelFormaDePago"
        Me.LabelFormaDePago.Size = New System.Drawing.Size(166, 25)
        Me.LabelFormaDePago.TabIndex = 7
        Me.LabelFormaDePago.Text = "Forma de Pago:"
        '
        'LabelCostoTotal
        '
        Me.LabelCostoTotal.AutoSize = True
        Me.LabelCostoTotal.Location = New System.Drawing.Point(319, 262)
        Me.LabelCostoTotal.Name = "LabelCostoTotal"
        Me.LabelCostoTotal.Size = New System.Drawing.Size(131, 25)
        Me.LabelCostoTotal.TabIndex = 6
        Me.LabelCostoTotal.Text = "Costo Total:"
        '
        'LabelCostoUnitario
        '
        Me.LabelCostoUnitario.AutoSize = True
        Me.LabelCostoUnitario.Location = New System.Drawing.Point(319, 225)
        Me.LabelCostoUnitario.Name = "LabelCostoUnitario"
        Me.LabelCostoUnitario.Size = New System.Drawing.Size(156, 25)
        Me.LabelCostoUnitario.TabIndex = 5
        Me.LabelCostoUnitario.Text = "Costo Unitario:"
        '
        'LabelCantidadCompra
        '
        Me.LabelCantidadCompra.AutoSize = True
        Me.LabelCantidadCompra.Location = New System.Drawing.Point(481, 158)
        Me.LabelCantidadCompra.Name = "LabelCantidadCompra"
        Me.LabelCantidadCompra.Size = New System.Drawing.Size(106, 25)
        Me.LabelCantidadCompra.TabIndex = 4
        Me.LabelCantidadCompra.Text = "Cantidad:"
        '
        'LabelProductoCompra
        '
        Me.LabelProductoCompra.AutoSize = True
        Me.LabelProductoCompra.Location = New System.Drawing.Point(6, 108)
        Me.LabelProductoCompra.Name = "LabelProductoCompra"
        Me.LabelProductoCompra.Size = New System.Drawing.Size(105, 25)
        Me.LabelProductoCompra.TabIndex = 3
        Me.LabelProductoCompra.Text = "Producto:"
        '
        'LabelProveedorCompra
        '
        Me.LabelProveedorCompra.AutoSize = True
        Me.LabelProveedorCompra.Location = New System.Drawing.Point(6, 53)
        Me.LabelProveedorCompra.Name = "LabelProveedorCompra"
        Me.LabelProveedorCompra.Size = New System.Drawing.Size(118, 25)
        Me.LabelProveedorCompra.TabIndex = 2
        Me.LabelProveedorCompra.Text = "Proveedor:"
        '
        'LabelFechaCompra
        '
        Me.LabelFechaCompra.AutoSize = True
        Me.LabelFechaCompra.Location = New System.Drawing.Point(481, 53)
        Me.LabelFechaCompra.Name = "LabelFechaCompra"
        Me.LabelFechaCompra.Size = New System.Drawing.Size(79, 25)
        Me.LabelFechaCompra.TabIndex = 1
        Me.LabelFechaCompra.Text = "Fecha:"
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBuscar.Location = New System.Drawing.Point(639, 105)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(106, 40)
        Me.ButtonBuscar.TabIndex = 15
        Me.ButtonBuscar.Text = "Buscar"
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        '
        'TextBoxNuevoPago
        '
        Me.TextBoxNuevoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNuevoPago.Location = New System.Drawing.Point(340, 529)
        Me.TextBoxNuevoPago.Name = "TextBoxNuevoPago"
        Me.TextBoxNuevoPago.Size = New System.Drawing.Size(198, 34)
        Me.TextBoxNuevoPago.TabIndex = 18
        Me.TextBoxNuevoPago.Visible = False
        '
        'TextBoxBuscarCompra
        '
        Me.TextBoxBuscarCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBuscarCompra.Location = New System.Drawing.Point(428, 108)
        Me.TextBoxBuscarCompra.Name = "TextBoxBuscarCompra"
        Me.TextBoxBuscarCompra.Size = New System.Drawing.Size(198, 34)
        Me.TextBoxBuscarCompra.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(164, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 29)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Número de Compra:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(145, 532)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 29)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Monto a Pagar:"
        Me.Label3.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PROYECTO_GRUPOS.My.Resources.Resources.Money_64a
        Me.PictureBox1.Location = New System.Drawing.Point(647, 18)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PROYECTO_GRUPOS.My.Resources.Resources.Money_64a
        Me.PictureBox2.Location = New System.Drawing.Point(210, 18)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 32
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Copperplate Gothic Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(303, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(311, 37)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Registrar Pago"
        '
        'PagoRegistrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 577)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonRegistrarPago)
        Me.Controls.Add(Me.GroupBoxDatosCompra)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Controls.Add(Me.TextBoxNuevoPago)
        Me.Controls.Add(Me.TextBoxBuscarCompra)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PagoRegistrar"
        Me.Text = "Registrar Pago"
        Me.GroupBoxDatosCompra.ResumeLayout(False)
        Me.GroupBoxDatosCompra.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonRegistrarPago As Button
    Friend WithEvents GroupBoxDatosCompra As GroupBox
    Friend WithEvents LabelSaldoActual As Label
    Friend WithEvents LabelFormaDePago As Label
    Friend WithEvents LabelCostoTotal As Label
    Friend WithEvents LabelCostoUnitario As Label
    Friend WithEvents LabelCantidadCompra As Label
    Friend WithEvents LabelProductoCompra As Label
    Friend WithEvents LabelProveedorCompra As Label
    Friend WithEvents LabelFechaCompra As Label
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents TextBoxNuevoPago As TextBox
    Friend WithEvents TextBoxBuscarCompra As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
End Class
