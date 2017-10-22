<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.REToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PROVEEDORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ARTICULOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabelConnStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REToolStripMenuItem, Me.PROVEEDORToolStripMenuItem, Me.ARTICULOToolStripMenuItem, Me.ComprasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1023, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'REToolStripMenuItem
        '
        Me.REToolStripMenuItem.Name = "REToolStripMenuItem"
        Me.REToolStripMenuItem.Size = New System.Drawing.Size(98, 24)
        Me.REToolStripMenuItem.Text = "RECEPCION"
        '
        'PROVEEDORToolStripMenuItem
        '
        Me.PROVEEDORToolStripMenuItem.Name = "PROVEEDORToolStripMenuItem"
        Me.PROVEEDORToolStripMenuItem.Size = New System.Drawing.Size(105, 24)
        Me.PROVEEDORToolStripMenuItem.Text = "PROVEEDOR"
        '
        'ARTICULOToolStripMenuItem
        '
        Me.ARTICULOToolStripMenuItem.Name = "ARTICULOToolStripMenuItem"
        Me.ARTICULOToolStripMenuItem.Size = New System.Drawing.Size(87, 24)
        Me.ARTICULOToolStripMenuItem.Text = "ARTICULO"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.ComprasToolStripMenuItem.Text = "COMPRAS"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 28)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1023, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabelConnStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 565)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1023, 25)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabelConnStatus
        '
        Me.ToolStripStatusLabelConnStatus.Name = "ToolStripStatusLabelConnStatus"
        Me.ToolStripStatusLabelConnStatus.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabelConnStatus.Text = "ToolStripStatusLabel1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 590)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Cuentas por Pagar"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents REToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PROVEEDORToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ARTICULOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabelConnStatus As ToolStripStatusLabel
End Class
