<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompraBuscar
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewCompras = New System.Windows.Forms.DataGridView()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.TextBoxBuscarCompra = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBoxDatosCompra = New System.Windows.Forms.GroupBox()
        Me.LabelSaldoActual = New System.Windows.Forms.Label()
        Me.LabelFormaDePago = New System.Windows.Forms.Label()
        Me.LabelCostoTotal = New System.Windows.Forms.Label()
        Me.LabelProveedorCompra = New System.Windows.Forms.Label()
        Me.LabelFechaCompra = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxDatosCompra.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewCompras
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewCompras.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewCompras.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCompras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewCompras.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewCompras.Location = New System.Drawing.Point(55, 460)
        Me.DataGridViewCompras.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewCompras.Name = "DataGridViewCompras"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCompras.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewCompras.Size = New System.Drawing.Size(910, 290)
        Me.DataGridViewCompras.TabIndex = 17
        Me.DataGridViewCompras.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.PROYECTO_GRUPOS.My.Resources.Resources.Shopping
        Me.PictureBox3.Location = New System.Drawing.Point(737, 15)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 32
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PROYECTO_GRUPOS.My.Resources.Resources.Shopping
        Me.PictureBox2.Location = New System.Drawing.Point(286, 15)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Copperplate Gothic Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(356, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(375, 44)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Buscar Compra"
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBuscar.Location = New System.Drawing.Point(713, 97)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(106, 40)
        Me.ButtonBuscar.TabIndex = 42
        Me.ButtonBuscar.Text = "Buscar"
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        '
        'TextBoxBuscarCompra
        '
        Me.TextBoxBuscarCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBuscarCompra.Location = New System.Drawing.Point(502, 100)
        Me.TextBoxBuscarCompra.Name = "TextBoxBuscarCompra"
        Me.TextBoxBuscarCompra.Size = New System.Drawing.Size(198, 34)
        Me.TextBoxBuscarCompra.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(238, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 29)
        Me.Label2.TabIndex = 40
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
        Me.GroupBoxDatosCompra.Location = New System.Drawing.Point(93, 153)
        Me.GroupBoxDatosCompra.Name = "GroupBoxDatosCompra"
        Me.GroupBoxDatosCompra.Size = New System.Drawing.Size(847, 226)
        Me.GroupBoxDatosCompra.TabIndex = 43
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(358, 408)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(312, 36)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Artículos Comprados"
        '
        'CompraBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 774)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBoxDatosCompra)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Controls.Add(Me.TextBoxBuscarCompra)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DataGridViewCompras)
        Me.Name = "CompraBuscar"
        Me.Text = "CompraBuscar"
        CType(Me.DataGridViewCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxDatosCompra.ResumeLayout(False)
        Me.GroupBoxDatosCompra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewCompras As DataGridView
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents TextBoxBuscarCompra As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBoxDatosCompra As GroupBox
    Friend WithEvents LabelSaldoActual As Label
    Friend WithEvents LabelFormaDePago As Label
    Friend WithEvents LabelCostoTotal As Label
    Friend WithEvents LabelProveedorCompra As Label
    Friend WithEvents LabelFechaCompra As Label
    Friend WithEvents Label3 As Label
End Class
