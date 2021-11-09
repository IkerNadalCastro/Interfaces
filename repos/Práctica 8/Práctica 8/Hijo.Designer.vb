<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hijo
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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BorrarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarTextoDesdePortapapelesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(800, 450)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrarTodoToolStripMenuItem, Me.CopiarTextoDesdePortapapelesToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(246, 48)
        '
        'BorrarTodoToolStripMenuItem
        '
        Me.BorrarTodoToolStripMenuItem.Name = "BorrarTodoToolStripMenuItem"
        Me.BorrarTodoToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.BorrarTodoToolStripMenuItem.Text = "Borrar todo"
        '
        'CopiarTextoDesdePortapapelesToolStripMenuItem
        '
        Me.CopiarTextoDesdePortapapelesToolStripMenuItem.Name = "CopiarTextoDesdePortapapelesToolStripMenuItem"
        Me.CopiarTextoDesdePortapapelesToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.CopiarTextoDesdePortapapelesToolStripMenuItem.Text = "Copiar Texto desde Portapapeles"
        '
        'Hijo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "Hijo"
        Me.Text = "Hijo"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents BorrarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarTextoDesdePortapapelesToolStripMenuItem As ToolStripMenuItem
End Class
