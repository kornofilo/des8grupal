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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbconta = New System.Windows.Forms.RadioButton()
        Me.rbcredi = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtidprovee = New System.Windows.Forms.TextBox()
        Me.txtidproduc = New System.Windows.Forms.TextBox()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.txtnomb = New System.Windows.Forms.TextBox()
        Me.txtcompra = New System.Windows.Forms.TextBox()
        Me.DataGridViewCompras = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbn = New System.Windows.Forms.Label()
        Me.txtcant = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btmodificar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStripStatusConnectionDB = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btagregar = New System.Windows.Forms.Button()
        CType(Me.DataGridViewCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 129)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID PROVEEDOR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 187)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ID PRODUCTO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(607, 178)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PRECIO"
        '
        'rbconta
        '
        Me.rbconta.AutoSize = True
        Me.rbconta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbconta.Location = New System.Drawing.Point(1183, 161)
        Me.rbconta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.rbcredi.Location = New System.Drawing.Point(1183, 193)
        Me.rbcredi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbcredi.Name = "rbcredi"
        Me.rbcredi.Size = New System.Drawing.Size(122, 29)
        Me.rbcredi.TabIndex = 6
        Me.rbcredi.TabStop = True
        Me.rbcredi.Text = "CRÉDITO"
        Me.rbcredi.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 241)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 29)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "NOMBRE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(607, 241)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(256, 29)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "TOTAL DE COMPRA"
        '
        'txtidprovee
        '
        Me.txtidprovee.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidprovee.Location = New System.Drawing.Point(352, 126)
        Me.txtidprovee.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtidprovee.Name = "txtidprovee"
        Me.txtidprovee.Size = New System.Drawing.Size(116, 34)
        Me.txtidprovee.TabIndex = 10
        '
        'txtidproduc
        '
        Me.txtidproduc.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidproduc.Location = New System.Drawing.Point(352, 182)
        Me.txtidproduc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtidproduc.Name = "txtidproduc"
        Me.txtidproduc.Size = New System.Drawing.Size(116, 34)
        Me.txtidproduc.TabIndex = 11
        '
        'txtprecio
        '
        Me.txtprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecio.Location = New System.Drawing.Point(953, 183)
        Me.txtprecio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(116, 34)
        Me.txtprecio.TabIndex = 12
        '
        'txtnomb
        '
        Me.txtnomb.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnomb.Location = New System.Drawing.Point(352, 236)
        Me.txtnomb.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtnomb.Name = "txtnomb"
        Me.txtnomb.Size = New System.Drawing.Size(116, 34)
        Me.txtnomb.TabIndex = 14
        '
        'txtcompra
        '
        Me.txtcompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcompra.Location = New System.Drawing.Point(953, 236)
        Me.txtcompra.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtcompra.Name = "txtcompra"
        Me.txtcompra.Size = New System.Drawing.Size(116, 34)
        Me.txtcompra.TabIndex = 15
        '
        'DataGridViewCompras
        '
        Me.DataGridViewCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCompras.Location = New System.Drawing.Point(23, 423)
        Me.DataGridViewCompras.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridViewCompras.Name = "DataGridViewCompras"
        Me.DataGridViewCompras.Size = New System.Drawing.Size(1347, 290)
        Me.DataGridViewCompras.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1160, 126)
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
        'txtbuscar
        '
        Me.txtbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscar.Location = New System.Drawing.Point(1145, 382)
        Me.txtbuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(201, 34)
        Me.txtbuscar.TabIndex = 19
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusConnectionDB})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 717)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 13, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1364, 33)
        Me.StatusStrip1.TabIndex = 24
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbn
        '
        Me.lbn.AutoSize = True
        Me.lbn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbn.Location = New System.Drawing.Point(768, 367)
        Me.lbn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbn.Name = "lbn"
        Me.lbn.Size = New System.Drawing.Size(197, 31)
        Me.lbn.TabIndex = 30
        Me.lbn.Text = "PROVEEDOR"
        '
        'txtcant
        '
        Me.txtcant.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcant.Location = New System.Drawing.Point(953, 142)
        Me.txtcant.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtcant.Name = "txtcant"
        Me.txtcant.Size = New System.Drawing.Size(116, 34)
        Me.txtcant.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(607, 137)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 29)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "CANTIDAD"
        '
        'PictureBox3
        '
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
        Me.PictureBox1.Location = New System.Drawing.Point(1091, 369)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'ToolStripStatusConnectionDB
        '
        Me.ToolStripStatusConnectionDB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusConnectionDB.Name = "ToolStripStatusConnectionDB"
        Me.ToolStripStatusConnectionDB.Size = New System.Drawing.Size(288, 28)
        Me.ToolStripStatusConnectionDB.Text = "ToolStripStatusConnectionDB"
        '
        'btagregar
        '
        Me.btagregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btagregar.Location = New System.Drawing.Point(37, 359)
        Me.btagregar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btagregar.Name = "btagregar"
        Me.btagregar.Size = New System.Drawing.Size(155, 48)
        Me.btagregar.TabIndex = 21
        Me.btagregar.Text = "    Agregar"
        Me.btagregar.UseVisualStyleBackColor = True
        '
        'Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(1364, 750)
        Me.Controls.Add(Me.txtcant)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbn)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btmodificar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btagregar)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DataGridViewCompras)
        Me.Controls.Add(Me.txtcompra)
        Me.Controls.Add(Me.txtnomb)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.txtidproduc)
        Me.Controls.Add(Me.txtidprovee)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.rbcredi)
        Me.Controls.Add(Me.rbconta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Compras"
        Me.Text = "Compras"
        CType(Me.DataGridViewCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rbconta As System.Windows.Forms.RadioButton
    Friend WithEvents rbcredi As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtidprovee As System.Windows.Forms.TextBox
    Friend WithEvents txtidproduc As System.Windows.Forms.TextBox
    Friend WithEvents txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents txtnomb As System.Windows.Forms.TextBox
    Friend WithEvents txtcompra As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewCompras As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents btagregar As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusConnectionDB As ToolStripStatusLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btmodificar As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lbn As System.Windows.Forms.Label
    Friend WithEvents txtcant As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
