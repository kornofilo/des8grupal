<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PagoBuscar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PagoBuscar))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridViewHistorialPagos = New System.Windows.Forms.DataGridView()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.TextBoxBuscarCompra = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBoxDatosCompra = New System.Windows.Forms.GroupBox()
        Me.LabelSaldoActual = New System.Windows.Forms.Label()
        Me.LabelFormaDePago = New System.Windows.Forms.Label()
        Me.LabelCostoTotal = New System.Windows.Forms.Label()
        Me.LabelProveedorCompra = New System.Windows.Forms.Label()
        Me.LabelFechaCompra = New System.Windows.Forms.Label()
        CType(Me.DataGridViewHistorialPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxDatosCompra.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(394, 474)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(228, 29)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Historial de Pagos"
        '
        'DataGridViewHistorialPagos
        '
        Me.DataGridViewHistorialPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewHistorialPagos.Location = New System.Drawing.Point(84, 522)
        Me.DataGridViewHistorialPagos.Name = "DataGridViewHistorialPagos"
        Me.DataGridViewHistorialPagos.RowTemplate.Height = 24
        Me.DataGridViewHistorialPagos.Size = New System.Drawing.Size(847, 212)
        Me.DataGridViewHistorialPagos.TabIndex = 21
        Me.DataGridViewHistorialPagos.Visible = False
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBuscar.Location = New System.Drawing.Point(660, 110)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(106, 40)
        Me.ButtonBuscar.TabIndex = 19
        Me.ButtonBuscar.Text = "Buscar"
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        '
        'TextBoxBuscarCompra
        '
        Me.TextBoxBuscarCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBuscarCompra.Location = New System.Drawing.Point(449, 113)
        Me.TextBoxBuscarCompra.Name = "TextBoxBuscarCompra"
        Me.TextBoxBuscarCompra.Size = New System.Drawing.Size(198, 34)
        Me.TextBoxBuscarCompra.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(185, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 29)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Número de Compra:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(322, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 37)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Consultar Pago"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PROYECTO_GRUPOS.My.Resources.Resources.Money_64a
        Me.PictureBox2.Location = New System.Drawing.Point(235, 19)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PROYECTO_GRUPOS.My.Resources.Resources.Money_64a
        Me.PictureBox1.Location = New System.Drawing.Point(672, 19)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
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
        Me.GroupBoxDatosCompra.Location = New System.Drawing.Point(84, 207)
        Me.GroupBoxDatosCompra.Name = "GroupBoxDatosCompra"
        Me.GroupBoxDatosCompra.Size = New System.Drawing.Size(847, 226)
        Me.GroupBoxDatosCompra.TabIndex = 31
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
        'PagoBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 774)
        Me.Controls.Add(Me.GroupBoxDatosCompra)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridViewHistorialPagos)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Controls.Add(Me.TextBoxBuscarCompra)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PagoBuscar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Consultar Pago"
        CType(Me.DataGridViewHistorialPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxDatosCompra.ResumeLayout(False)
        Me.GroupBoxDatosCompra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridViewHistorialPagos As DataGridView
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents TextBoxBuscarCompra As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBoxDatosCompra As GroupBox
    Friend WithEvents LabelSaldoActual As Label
    Friend WithEvents LabelFormaDePago As Label
    Friend WithEvents LabelCostoTotal As Label
    Friend WithEvents LabelProveedorCompra As Label
    Friend WithEvents LabelFechaCompra As Label
End Class
