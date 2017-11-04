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
        Me.rbconta = New System.Windows.Forms.RadioButton()
        Me.rbcredi = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.txtcompra = New System.Windows.Forms.TextBox()
        Me.DataGridViewCompras = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusConnectionDB = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btmodificar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btagregar = New System.Windows.Forms.Button()
        Me.lbn = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxProveedores = New System.Windows.Forms.ComboBox()
        Me.ComboBoxProductos = New System.Windows.Forms.ComboBox()
        Me.NumericUpDownCantidad = New System.Windows.Forms.NumericUpDown()
        CType(Me.DataGridViewCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(769, 129)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PRODUCTO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(769, 242)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(239, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PRECIO UNITARIO"
        '
        'rbconta
        '
        Me.rbconta.AutoSize = True
        Me.rbconta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbconta.Location = New System.Drawing.Point(247, 200)
        Me.rbconta.Margin = New System.Windows.Forms.Padding(4)
        Me.rbconta.Name = "rbconta"
        Me.rbconta.Size = New System.Drawing.Size(135, 29)
        Me.rbconta.TabIndex = 5
        Me.rbconta.TabStop = True
        Me.rbconta.Text = "CONTADO"
        Me.rbconta.UseVisualStyleBackColor = True
        '
        'rbcredi
        '
        Me.rbcredi.AutoSize = True
        Me.rbcredi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbcredi.Location = New System.Drawing.Point(247, 232)
        Me.rbcredi.Margin = New System.Windows.Forms.Padding(4)
        Me.rbcredi.Name = "rbcredi"
        Me.rbcredi.Size = New System.Drawing.Size(122, 29)
        Me.rbcredi.TabIndex = 6
        Me.rbcredi.TabStop = True
        Me.rbcredi.Text = "CRÉDITO"
        Me.rbcredi.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(769, 298)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 29)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "TOTAL"
        '
        'txtprecio
        '
        Me.txtprecio.Enabled = False
        Me.txtprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecio.Location = New System.Drawing.Point(1013, 242)
        Me.txtprecio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(165, 34)
        Me.txtprecio.TabIndex = 12
        '
        'txtcompra
        '
        Me.txtcompra.Enabled = False
        Me.txtcompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcompra.Location = New System.Drawing.Point(1013, 295)
        Me.txtcompra.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcompra.Name = "txtcompra"
        Me.txtcompra.Size = New System.Drawing.Size(165, 34)
        Me.txtcompra.TabIndex = 15
        '
        'DataGridViewCompras
        '
        Me.DataGridViewCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCompras.Location = New System.Drawing.Point(23, 423)
        Me.DataGridViewCompras.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewCompras.Name = "DataGridViewCompras"
        Me.DataGridViewCompras.Size = New System.Drawing.Size(1347, 290)
        Me.DataGridViewCompras.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 199)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(195, 29)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "TIPO DE PAGO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Copperplate Gothic Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(693, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(184, 37)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Compras"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(1229, 382)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(139, 34)
        Me.TextBox5.TabIndex = 19
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusConnectionDB})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 717)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 13, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1395, 33)
        Me.StatusStrip1.TabIndex = 24
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusConnectionDB
        '
        Me.ToolStripStatusConnectionDB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusConnectionDB.Image = Global.PROYECTO_GRUPOS.My.Resources.Resources._Stop
        Me.ToolStripStatusConnectionDB.Name = "ToolStripStatusConnectionDB"
        Me.ToolStripStatusConnectionDB.Size = New System.Drawing.Size(288, 28)
        Me.ToolStripStatusConnectionDB.Text = "ToolStripStatusConnectionDB"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.PROYECTO_GRUPOS.My.Resources.Resources.Shopping
        Me.PictureBox3.Location = New System.Drawing.Point(888, 12)
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
        Me.PictureBox2.Location = New System.Drawing.Point(615, 12)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.PROYECTO_GRUPOS.My.Resources.Resources.Delete
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(391, 359)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(159, 48)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "    Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btmodificar
        '
        Me.btmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmodificar.Image = Global.PROYECTO_GRUPOS.My.Resources.Resources.Edit
        Me.btmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btmodificar.Location = New System.Drawing.Point(213, 359)
        Me.btmodificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btmodificar.Name = "btmodificar"
        Me.btmodificar.Size = New System.Drawing.Size(160, 48)
        Me.btmodificar.TabIndex = 26
        Me.btmodificar.Text = "     Modificar"
        Me.btmodificar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PROYECTO_GRUPOS.My.Resources.Resources.Search
        Me.PictureBox1.Location = New System.Drawing.Point(1165, 372)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'btagregar
        '
        Me.btagregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btagregar.Image = Global.PROYECTO_GRUPOS.My.Resources.Resources.Add
        Me.btagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btagregar.Location = New System.Drawing.Point(37, 359)
        Me.btagregar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btagregar.Name = "btagregar"
        Me.btagregar.Size = New System.Drawing.Size(155, 48)
        Me.btagregar.TabIndex = 21
        Me.btagregar.Text = "    Agregar"
        Me.btagregar.UseVisualStyleBackColor = True
        '
        'lbn
        '
        Me.lbn.AutoSize = True
        Me.lbn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbn.Location = New System.Drawing.Point(961, 383)
        Me.lbn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbn.Name = "lbn"
        Me.lbn.Size = New System.Drawing.Size(197, 31)
        Me.lbn.TabIndex = 30
        Me.lbn.Text = "PROVEEDOR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(769, 199)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 29)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "CANTIDAD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 129)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PROVEEDOR"
        '
        'ComboBoxProveedores
        '
        Me.ComboBoxProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxProveedores.FormattingEnabled = True
        Me.ComboBoxProveedores.Location = New System.Drawing.Point(247, 121)
        Me.ComboBoxProveedores.Name = "ComboBoxProveedores"
        Me.ComboBoxProveedores.Size = New System.Drawing.Size(368, 37)
        Me.ComboBoxProveedores.TabIndex = 33
        '
        'ComboBoxProductos
        '
        Me.ComboBoxProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxProductos.FormattingEnabled = True
        Me.ComboBoxProductos.Location = New System.Drawing.Point(1015, 129)
        Me.ComboBoxProductos.Name = "ComboBoxProductos"
        Me.ComboBoxProductos.Size = New System.Drawing.Size(368, 37)
        Me.ComboBoxProductos.TabIndex = 34
        '
        'NumericUpDownCantidad
        '
        Me.NumericUpDownCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownCantidad.Location = New System.Drawing.Point(1015, 195)
        Me.NumericUpDownCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownCantidad.Name = "NumericUpDownCantidad"
        Me.NumericUpDownCantidad.Size = New System.Drawing.Size(120, 34)
        Me.NumericUpDownCantidad.TabIndex = 35
        Me.NumericUpDownCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(1395, 750)
        Me.Controls.Add(Me.NumericUpDownCantidad)
        Me.Controls.Add(Me.ComboBoxProductos)
        Me.Controls.Add(Me.ComboBoxProveedores)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbn)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btmodificar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btagregar)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DataGridViewCompras)
        Me.Controls.Add(Me.txtcompra)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.rbcredi)
        Me.Controls.Add(Me.rbconta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Compras"
        Me.Text = "Compras"
        CType(Me.DataGridViewCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rbconta As System.Windows.Forms.RadioButton
    Friend WithEvents rbcredi As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents txtcompra As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewCompras As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents btagregar As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusConnectionDB As ToolStripStatusLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btmodificar As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lbn As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxProveedores As ComboBox
    Friend WithEvents ComboBoxProductos As ComboBox
    Friend WithEvents NumericUpDownCantidad As NumericUpDown
End Class
