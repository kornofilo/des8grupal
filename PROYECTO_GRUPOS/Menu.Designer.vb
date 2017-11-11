<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PROVEEDORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónDeProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PAGOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarPagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarPagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DEVOLUCIONESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaDevoluciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarDevoluciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PROVEEDORToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.PAGOSToolStripMenuItem, Me.DEVOLUCIONESToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(832, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PROVEEDORToolStripMenuItem
        '
        Me.PROVEEDORToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoProveedorToolStripMenuItem, Me.GestiónDeProveedoresToolStripMenuItem})
        Me.PROVEEDORToolStripMenuItem.Name = "PROVEEDORToolStripMenuItem"
        Me.PROVEEDORToolStripMenuItem.Size = New System.Drawing.Size(105, 24)
        Me.PROVEEDORToolStripMenuItem.Text = "PROVEEDOR"
        '
        'NuevoProveedorToolStripMenuItem
        '
        Me.NuevoProveedorToolStripMenuItem.Name = "NuevoProveedorToolStripMenuItem"
        Me.NuevoProveedorToolStripMenuItem.Size = New System.Drawing.Size(241, 26)
        Me.NuevoProveedorToolStripMenuItem.Text = "Nuevo Proveedor"
        '
        'GestiónDeProveedoresToolStripMenuItem
        '
        Me.GestiónDeProveedoresToolStripMenuItem.Name = "GestiónDeProveedoresToolStripMenuItem"
        Me.GestiónDeProveedoresToolStripMenuItem.Size = New System.Drawing.Size(241, 26)
        Me.GestiónDeProveedoresToolStripMenuItem.Text = "Gestión de Proveedores"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaCompraToolStripMenuItem, Me.ConsultarFacturaToolStripMenuItem})
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.ComprasToolStripMenuItem.Text = "COMPRAS"
        '
        'NuevaCompraToolStripMenuItem
        '
        Me.NuevaCompraToolStripMenuItem.Name = "NuevaCompraToolStripMenuItem"
        Me.NuevaCompraToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.NuevaCompraToolStripMenuItem.Text = "Nueva Compra"
        '
        'ConsultarFacturaToolStripMenuItem
        '
        Me.ConsultarFacturaToolStripMenuItem.Name = "ConsultarFacturaToolStripMenuItem"
        Me.ConsultarFacturaToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.ConsultarFacturaToolStripMenuItem.Text = "Consultar Factura"
        '
        'PAGOSToolStripMenuItem
        '
        Me.PAGOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarPagoToolStripMenuItem, Me.ConsultarPagosToolStripMenuItem})
        Me.PAGOSToolStripMenuItem.Name = "PAGOSToolStripMenuItem"
        Me.PAGOSToolStripMenuItem.Size = New System.Drawing.Size(67, 24)
        Me.PAGOSToolStripMenuItem.Text = "PAGOS"
        '
        'RegistrarPagoToolStripMenuItem
        '
        Me.RegistrarPagoToolStripMenuItem.Name = "RegistrarPagoToolStripMenuItem"
        Me.RegistrarPagoToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.RegistrarPagoToolStripMenuItem.Text = "Nuevo Pago"
        '
        'ConsultarPagosToolStripMenuItem
        '
        Me.ConsultarPagosToolStripMenuItem.Name = "ConsultarPagosToolStripMenuItem"
        Me.ConsultarPagosToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.ConsultarPagosToolStripMenuItem.Text = "Consultar Pagos"
        '
        'DEVOLUCIONESToolStripMenuItem
        '
        Me.DEVOLUCIONESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaDevoluciónToolStripMenuItem, Me.ConsultarDevoluciónToolStripMenuItem})
        Me.DEVOLUCIONESToolStripMenuItem.Name = "DEVOLUCIONESToolStripMenuItem"
        Me.DEVOLUCIONESToolStripMenuItem.Size = New System.Drawing.Size(128, 24)
        Me.DEVOLUCIONESToolStripMenuItem.Text = "DEVOLUCIONES"
        '
        'NuevaDevoluciónToolStripMenuItem
        '
        Me.NuevaDevoluciónToolStripMenuItem.Name = "NuevaDevoluciónToolStripMenuItem"
        Me.NuevaDevoluciónToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.NuevaDevoluciónToolStripMenuItem.Text = "Nueva Devolución"
        '
        'ConsultarDevoluciónToolStripMenuItem
        '
        Me.ConsultarDevoluciónToolStripMenuItem.Name = "ConsultarDevoluciónToolStripMenuItem"
        Me.ConsultarDevoluciónToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.ConsultarDevoluciónToolStripMenuItem.Text = "Consultar Devolución"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(785, 91)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cuentas por Pagar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PROYECTO_GRUPOS.My.Resources.Resources.paying
        Me.PictureBox1.Location = New System.Drawing.Point(269, 134)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(267, 203)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(832, 378)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Menu"
        Me.Text = "Menú Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PROVEEDORToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PAGOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarPagoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarPagosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DEVOLUCIONESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevaDevoluciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarDevoluciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents NuevoProveedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestiónDeProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevaCompraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarFacturaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
