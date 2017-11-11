<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Compras
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtidproduc = New System.Windows.Forms.TextBox()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.DataGridViewCompras = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btagregar = New System.Windows.Forms.Button()
        Me.rbcredi = New System.Windows.Forms.RadioButton()
        Me.rbconta = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtidprovee = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDownCantidadProductos = New System.Windows.Forms.NumericUpDown()
        Me.TxtNombreProducto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPrecioTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownCantidadProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 184)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(310, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CÓDIGO DE PRODUCTO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(607, 178)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(239, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PRECIO UNITARIO"
        '
        'txtidproduc
        '
        Me.txtidproduc.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidproduc.Location = New System.Drawing.Point(381, 179)
        Me.txtidproduc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidproduc.Name = "txtidproduc"
        Me.txtidproduc.Size = New System.Drawing.Size(181, 34)
        Me.txtidproduc.TabIndex = 2
        '
        'txtprecio
        '
        Me.txtprecio.Enabled = False
        Me.txtprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecio.Location = New System.Drawing.Point(953, 175)
        Me.txtprecio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(144, 34)
        Me.txtprecio.TabIndex = 5
        '
        'DataGridViewCompras
        '
        Me.DataGridViewCompras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical
        Me.DataGridViewCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCompras.Location = New System.Drawing.Point(23, 423)
        Me.DataGridViewCompras.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewCompras.Name = "DataGridViewCompras"
        Me.DataGridViewCompras.Size = New System.Drawing.Size(1347, 290)
        Me.DataGridViewCompras.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Copperplate Gothic Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(568, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(350, 44)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Nueva Compra"
        '
        'txtbuscar
        '
        Me.txtbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscar.Location = New System.Drawing.Point(1146, 373)
        Me.txtbuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(201, 34)
        Me.txtbuscar.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(607, 126)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 29)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "CANTIDAD"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Crimson
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.PROYECTO_GRUPOS.My.Resources.Resources.Checkmark2
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(332, 349)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(287, 58)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "        Finalizar Compra"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.PROYECTO_GRUPOS.My.Resources.Resources.Shopping
        Me.PictureBox3.Location = New System.Drawing.Point(924, 11)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 29
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PROYECTO_GRUPOS.My.Resources.Resources.Shopping
        Me.PictureBox2.Location = New System.Drawing.Point(498, 11)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PROYECTO_GRUPOS.My.Resources.Resources.Search
        Me.PictureBox1.Location = New System.Drawing.Point(1091, 369)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'btagregar
        '
        Me.btagregar.BackColor = System.Drawing.Color.YellowGreen
        Me.btagregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btagregar.Image = Global.PROYECTO_GRUPOS.My.Resources.Resources.Add
        Me.btagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btagregar.Location = New System.Drawing.Point(37, 349)
        Me.btagregar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btagregar.Name = "btagregar"
        Me.btagregar.Size = New System.Drawing.Size(259, 58)
        Me.btagregar.TabIndex = 9
        Me.btagregar.Text = "     Agregar Producto"
        Me.btagregar.UseVisualStyleBackColor = False
        '
        'rbcredi
        '
        Me.rbcredi.AutoSize = True
        Me.rbcredi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbcredi.Location = New System.Drawing.Point(1180, 201)
        Me.rbcredi.Margin = New System.Windows.Forms.Padding(4)
        Me.rbcredi.Name = "rbcredi"
        Me.rbcredi.Size = New System.Drawing.Size(122, 29)
        Me.rbcredi.TabIndex = 8
        Me.rbcredi.TabStop = True
        Me.rbcredi.Text = "CRÉDITO"
        Me.rbcredi.UseVisualStyleBackColor = True
        '
        'rbconta
        '
        Me.rbconta.AutoSize = True
        Me.rbconta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbconta.Location = New System.Drawing.Point(1180, 164)
        Me.rbconta.Margin = New System.Windows.Forms.Padding(4)
        Me.rbconta.Name = "rbconta"
        Me.rbconta.Size = New System.Drawing.Size(135, 29)
        Me.rbconta.TabIndex = 7
        Me.rbconta.TabStop = True
        Me.rbconta.Text = "CONTADO"
        Me.rbconta.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1152, 131)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(195, 29)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "TIPO DE PAGO"
        '
        'txtidprovee
        '
        Me.txtidprovee.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidprovee.Location = New System.Drawing.Point(381, 123)
        Me.txtidprovee.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidprovee.Name = "txtidprovee"
        Me.txtidprovee.Size = New System.Drawing.Size(181, 34)
        Me.txtidprovee.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 123)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(325, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CÓDIGO DE PROVEEDOR"
        '
        'NumericUpDownCantidadProductos
        '
        Me.NumericUpDownCantidadProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownCantidadProductos.Location = New System.Drawing.Point(953, 129)
        Me.NumericUpDownCantidadProductos.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownCantidadProductos.Name = "NumericUpDownCantidadProductos"
        Me.NumericUpDownCantidadProductos.Size = New System.Drawing.Size(144, 34)
        Me.NumericUpDownCantidadProductos.TabIndex = 4
        Me.NumericUpDownCantidadProductos.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'TxtNombreProducto
        '
        Me.TxtNombreProducto.Enabled = False
        Me.TxtNombreProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreProducto.Location = New System.Drawing.Point(381, 233)
        Me.TxtNombreProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNombreProducto.Name = "TxtNombreProducto"
        Me.TxtNombreProducto.Size = New System.Drawing.Size(181, 34)
        Me.TxtNombreProducto.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 236)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(334, 29)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "NOMBRE DEL PRODUCTO"
        '
        'TxtPrecioTotal
        '
        Me.TxtPrecioTotal.Enabled = False
        Me.TxtPrecioTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecioTotal.Location = New System.Drawing.Point(953, 231)
        Me.TxtPrecioTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPrecioTotal.Name = "TxtPrecioTotal"
        Me.TxtPrecioTotal.Size = New System.Drawing.Size(144, 34)
        Me.TxtPrecioTotal.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(607, 234)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(201, 29)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "PRECIO TOTAL"
        '
        'Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1388, 733)
        Me.Controls.Add(Me.TxtPrecioTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtNombreProducto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NumericUpDownCantidadProductos)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btagregar)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DataGridViewCompras)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.txtidproduc)
        Me.Controls.Add(Me.txtidprovee)
        Me.Controls.Add(Me.rbcredi)
        Me.Controls.Add(Me.rbconta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Compras"
        Me.Text = "Nueva Compra"
        CType(Me.DataGridViewCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownCantidadProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtidproduc As System.Windows.Forms.TextBox
    Friend WithEvents txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewCompras As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents btagregar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As Button
    Friend WithEvents rbcredi As RadioButton
    Friend WithEvents rbconta As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents txtidprovee As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NumericUpDownCantidadProductos As NumericUpDown
    Friend WithEvents TxtNombreProducto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtPrecioTotal As TextBox
    Friend WithEvents Label6 As Label
End Class
