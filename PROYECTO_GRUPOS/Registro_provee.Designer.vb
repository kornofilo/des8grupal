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
        Me.btmodif = New System.Windows.Forms.Button()
        Me.btregi = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btsal = New System.Windows.Forms.Button()
        Me.PROVEEDOR.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(204, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CODIGO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "RUC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(272, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DV"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "NOMBRE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "TELEFONO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "FAX"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 313)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "DIRECCIÒN"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(44, 356)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "EMAIL"
        '
        'cmtipoprovee
        '
        Me.cmtipoprovee.FormattingEnabled = True
        Me.cmtipoprovee.Items.AddRange(New Object() {"MANTENIMIENTO", "LABORATORIO", "FARMACIA", "DIETETICA", "TECNOLOGIA"})
        Me.cmtipoprovee.Location = New System.Drawing.Point(141, 387)
        Me.cmtipoprovee.Name = "cmtipoprovee"
        Me.cmtipoprovee.Size = New System.Drawing.Size(185, 21)
        Me.cmtipoprovee.TabIndex = 8
        Me.cmtipoprovee.Text = "TIPO PROVEEDOR"
        '
        'PROVEEDOR
        '
        Me.PROVEEDOR.Controls.Add(Me.PictureBox1)
        Me.PROVEEDOR.Controls.Add(Me.btsal)
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
        Me.txtemail.Location = New System.Drawing.Point(141, 349)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(185, 20)
        Me.txtemail.TabIndex = 16
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(141, 306)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(185, 20)
        Me.txtdireccion.TabIndex = 15
        '
        'txtfax
        '
        Me.txtfax.Location = New System.Drawing.Point(141, 264)
        Me.txtfax.Name = "txtfax"
        Me.txtfax.Size = New System.Drawing.Size(185, 20)
        Me.txtfax.TabIndex = 14
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(141, 215)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(185, 20)
        Me.txttelefono.TabIndex = 13
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(141, 166)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(185, 20)
        Me.txtnombre.TabIndex = 12
        '
        'txtdv
        '
        Me.txtdv.Location = New System.Drawing.Point(300, 127)
        Me.txtdv.Name = "txtdv"
        Me.txtdv.Size = New System.Drawing.Size(67, 20)
        Me.txtdv.TabIndex = 11
        '
        'txtruc
        '
        Me.txtruc.Location = New System.Drawing.Point(108, 127)
        Me.txtruc.Name = "txtruc"
        Me.txtruc.Size = New System.Drawing.Size(108, 20)
        Me.txtruc.TabIndex = 10
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(275, 64)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(59, 20)
        Me.txtcodigo.TabIndex = 9
        '
        'btmodif
        '
        Me.btmodif.Image = Global.PROYECTO_GRUPOS.My.Resources.Resources.Edit
        Me.btmodif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btmodif.Location = New System.Drawing.Point(322, 465)
        Me.btmodif.Name = "btmodif"
        Me.btmodif.Size = New System.Drawing.Size(112, 55)
        Me.btmodif.TabIndex = 12
        Me.btmodif.Text = "&Modificar"
        Me.btmodif.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btmodif.UseVisualStyleBackColor = True
        '
        'btregi
        '
        Me.btregi.Image = Global.PROYECTO_GRUPOS.My.Resources.Resources.Add
        Me.btregi.Location = New System.Drawing.Point(100, 465)
        Me.btregi.Name = "btregi"
        Me.btregi.Size = New System.Drawing.Size(118, 55)
        Me.btregi.TabIndex = 10
        Me.btregi.Text = "&Registrar"
        Me.btregi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btregi.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PROYECTO_GRUPOS.My.Resources.Resources.proveedores
        Me.PictureBox1.Location = New System.Drawing.Point(28, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(137, 112)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'btsal
        '
        Me.btsal.Image = Global.PROYECTO_GRUPOS.My.Resources.Resources.Box
        Me.btsal.Location = New System.Drawing.Point(389, 356)
        Me.btsal.Name = "btsal"
        Me.btsal.Size = New System.Drawing.Size(106, 55)
        Me.btsal.TabIndex = 11
        Me.btsal.Text = "&Monstrar"
        Me.btsal.UseVisualStyleBackColor = True
        '
        'Registro_provee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 536)
        Me.Controls.Add(Me.btmodif)
        Me.Controls.Add(Me.btregi)
        Me.Controls.Add(Me.PROVEEDOR)
        Me.Name = "Registro_provee"
        Me.Text = "Form3"
        Me.PROVEEDOR.ResumeLayout(False)
        Me.PROVEEDOR.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
