<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HijoImagenes
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
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BorrarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirImagenDesdePortapapelesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 450)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrarTodoToolStripMenuItem, Me.AñadirImagenDesdePortapapelesToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(258, 48)
        '
        'BorrarTodoToolStripMenuItem
        '
        Me.BorrarTodoToolStripMenuItem.Name = "BorrarTodoToolStripMenuItem"
        Me.BorrarTodoToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.BorrarTodoToolStripMenuItem.Text = "Borrar todo"
        '
        'AñadirImagenDesdePortapapelesToolStripMenuItem
        '
        Me.AñadirImagenDesdePortapapelesToolStripMenuItem.Name = "AñadirImagenDesdePortapapelesToolStripMenuItem"
        Me.AñadirImagenDesdePortapapelesToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.AñadirImagenDesdePortapapelesToolStripMenuItem.Text = "Añadir Imagen desde Portapapeles"
        '
        'HijoImagenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "HijoImagenes"
        Me.Text = "HijoImagenes"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents BorrarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AñadirImagenDesdePortapapelesToolStripMenuItem As ToolStripMenuItem
End Class
