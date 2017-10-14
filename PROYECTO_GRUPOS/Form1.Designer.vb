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
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REToolStripMenuItem, Me.PROVEEDORToolStripMenuItem, Me.ARTICULOToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(767, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'REToolStripMenuItem
        '
        Me.REToolStripMenuItem.Name = "REToolStripMenuItem"
        Me.REToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.REToolStripMenuItem.Text = "RECEPCION"
        '
        'PROVEEDORToolStripMenuItem
        '
        Me.PROVEEDORToolStripMenuItem.Name = "PROVEEDORToolStripMenuItem"
        Me.PROVEEDORToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.PROVEEDORToolStripMenuItem.Text = "PROVEEDOR"
        '
        'ARTICULOToolStripMenuItem
        '
        Me.ARTICULOToolStripMenuItem.Name = "ARTICULOToolStripMenuItem"
        Me.ARTICULOToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.ARTICULOToolStripMenuItem.Text = "ARTICULO"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 479)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents REToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PROVEEDORToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ARTICULOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
