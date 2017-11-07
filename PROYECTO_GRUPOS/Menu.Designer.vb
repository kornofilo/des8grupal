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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PROVEEDORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PAGOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarPagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarPagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DEVOLUCIONESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaDevoluciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarDevoluciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PROVEEDORToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.PAGOSToolStripMenuItem, Me.DEVOLUCIONESToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(976, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PROVEEDORToolStripMenuItem
        '
        Me.PROVEEDORToolStripMenuItem.Name = "PROVEEDORToolStripMenuItem"
        Me.PROVEEDORToolStripMenuItem.Size = New System.Drawing.Size(105, 24)
        Me.PROVEEDORToolStripMenuItem.Text = "PROVEEDOR"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.ComprasToolStripMenuItem.Text = "COMPRAS"
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
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(857, 103)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cuentas por Pagar"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 205)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Menu"
        Me.Text = "Menú Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
End Class
