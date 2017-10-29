<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro_provee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmtipoprovee = New System.Windows.Forms.ComboBox()
        Me.PROVEEDOR = New System.Windows.Forms.GroupBox()
        Me.ID = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtfax = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtdv = New System.Windows.Forms.TextBox()
        Me.txtruc = New System.Windows.Forms.TextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.btregi = New System.Windows.Forms.Button()
        Me.btsal = New System.Windows.Forms.Button()
        Me.btmodif = New System.Windows.Forms.Button()
        Me.PROVEEDOR.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(112, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CODIGO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "RUC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(279, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DV"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "NOMBRE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "TELEFONO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "FAX"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 284)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "DIRECCIÒN"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(41, 327)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "EMAIL"
        '
        'cmtipoprovee
        '
        Me.cmtipoprovee.FormattingEnabled = True
        Me.cmtipoprovee.Items.AddRange(New Object() {"MANTENIMIENTO", "LABORATORIO", "FARMACIA", "DIETETICA"})
        Me.cmtipoprovee.Location = New System.Drawing.Point(138, 369)
        Me.cmtipoprovee.Name = "cmtipoprovee"
        Me.cmtipoprovee.Size = New System.Drawing.Size(185, 21)
        Me.cmtipoprovee.TabIndex = 8
        Me.cmtipoprovee.Text = "TIPO PROVEEDOR"
        '
        'PROVEEDOR
        '
        Me.PROVEEDOR.Controls.Add(Me.ID)
        Me.PROVEEDOR.Controls.Add(Me.txtemail)
        Me.PROVEEDOR.Controls.Add(Me.txtdireccion)
        Me.PROVEEDOR.Controls.Add(Me.txtfax)
        Me.PROVEEDOR.Controls.Add(Me.txttelefono)
        Me.PROVEEDOR.Controls.Add(Me.txtnombre)
        Me.PROVEEDOR.Controls.Add(Me.txtdv)
        Me.PROVEEDOR.Controls.Add(Me.txtruc)
        Me.PROVEEDOR.Controls.Add(Me.txtcodigo)
        Me.PROVEEDOR.Controls.Add(Me.cmtipoprovee)
        Me.PROVEEDOR.Controls.Add(Me.Label8)
        Me.PROVEEDOR.Controls.Add(Me.Label7)
        Me.PROVEEDOR.Controls.Add(Me.Label6)
        Me.PROVEEDOR.Controls.Add(Me.Label5)
        Me.PROVEEDOR.Controls.Add(Me.Label4)
        Me.PROVEEDOR.Controls.Add(Me.Label3)
        Me.PROVEEDOR.Controls.Add(Me.Label2)
        Me.PROVEEDOR.Controls.Add(Me.Label1)
        Me.PROVEEDOR.Location = New System.Drawing.Point(37, 29)
        Me.PROVEEDOR.Name = "PROVEEDOR"
        Me.PROVEEDOR.Size = New System.Drawing.Size(501, 422)
        Me.PROVEEDOR.TabIndex = 9
        Me.PROVEEDOR.TabStop = False
        Me.PROVEEDOR.Text = "PROVEEDORES"
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Location = New System.Drawing.Point(444, 31)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(18, 13)
        Me.ID.TabIndex = 12
        Me.ID.Text = "ID"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(138, 320)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(185, 20)
        Me.txtemail.TabIndex = 16
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(138, 277)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(185, 20)
        Me.txtdireccion.TabIndex = 15
        '
        'txtfax
        '
        Me.txtfax.Location = New System.Drawing.Point(138, 235)
        Me.txtfax.Name = "txtfax"
        Me.txtfax.Size = New System.Drawing.Size(185, 20)
        Me.txtfax.TabIndex = 14
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(138, 186)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(185, 20)
        Me.txttelefono.TabIndex = 13
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(138, 137)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(185, 20)
        Me.txtnombre.TabIndex = 12
        '
        'txtdv
        '
        Me.txtdv.Location = New System.Drawing.Point(307, 85)
        Me.txtdv.Name = "txtdv"
        Me.txtdv.Size = New System.Drawing.Size(67, 20)
        Me.txtdv.TabIndex = 11
        '
        'txtruc
        '
        Me.txtruc.Location = New System.Drawing.Point(115, 85)
        Me.txtruc.Name = "txtruc"
        Me.txtruc.Size = New System.Drawing.Size(108, 20)
        Me.txtruc.TabIndex = 10
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(174, 31)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(149, 20)
        Me.txtcodigo.TabIndex = 9
        '
        'btregi
        '
        Me.btregi.Location = New System.Drawing.Point(48, 473)
        Me.btregi.Name = "btregi"
        Me.btregi.Size = New System.Drawing.Size(106, 39)
        Me.btregi.TabIndex = 10
        Me.btregi.Text = "&Registrar"
        Me.btregi.UseVisualStyleBackColor = True
        '
        'btsal
        '
        Me.btsal.Location = New System.Drawing.Point(432, 473)
        Me.btsal.Name = "btsal"
        Me.btsal.Size = New System.Drawing.Size(106, 39)
        Me.btsal.TabIndex = 11
        Me.btsal.Text = "&Salir"
        Me.btsal.UseVisualStyleBackColor = True
        '
        'btmodif
        '
        Me.btmodif.Location = New System.Drawing.Point(232, 473)
        Me.btmodif.Name = "btmodif"
        Me.btmodif.Size = New System.Drawing.Size(106, 39)
        Me.btmodif.TabIndex = 12
        Me.btmodif.Text = "&Modificar"
        Me.btmodif.UseVisualStyleBackColor = True
        '
        'Registro_provee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 536)
        Me.Controls.Add(Me.btmodif)
        Me.Controls.Add(Me.btsal)
        Me.Controls.Add(Me.btregi)
        Me.Controls.Add(Me.PROVEEDOR)
        Me.Name = "Registro_provee"
        Me.Text = "Form3"
        Me.PROVEEDOR.ResumeLayout(False)
        Me.PROVEEDOR.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PROVEEDOR As System.Windows.Forms.GroupBox
    Friend WithEvents btregi As System.Windows.Forms.Button
    Friend WithEvents btsal As System.Windows.Forms.Button
    Friend WithEvents ID As System.Windows.Forms.Label
    Friend WithEvents btmodif As System.Windows.Forms.Button
    Public WithEvents cmtipoprovee As System.Windows.Forms.ComboBox
    Public WithEvents txtemail As System.Windows.Forms.TextBox
    Public WithEvents txtdireccion As System.Windows.Forms.TextBox
    Public WithEvents txtfax As System.Windows.Forms.TextBox
    Public WithEvents txttelefono As System.Windows.Forms.TextBox
    Public WithEvents txtnombre As System.Windows.Forms.TextBox
    Public WithEvents txtdv As System.Windows.Forms.TextBox
    Public WithEvents txtruc As System.Windows.Forms.TextBox
    Public WithEvents txtcodigo As System.Windows.Forms.TextBox
End Class
