<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarHijosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImagenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarVentanaActualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarTodasLasVentanasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirDeLaAplicacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentanasHijosChildsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSButtonOpenText = New System.Windows.Forms.ToolStripButton()
        Me.TSButtonOpenImage = New System.Windows.Forms.ToolStripButton()
        Me.TSButtonCloseWindows = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrincipalToolStripMenuItem, Me.VentanasHijosChildsToolStripMenuItem, Me.ToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PrincipalToolStripMenuItem
        '
        Me.PrincipalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarHijosToolStripMenuItem, Me.CerrarVentanaActualToolStripMenuItem, Me.CerrarTodasLasVentanasToolStripMenuItem, Me.ToolStripMenuItem1, Me.SalirDeLaAplicacionToolStripMenuItem})
        Me.PrincipalToolStripMenuItem.Name = "PrincipalToolStripMenuItem"
        Me.PrincipalToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.PrincipalToolStripMenuItem.Text = "Principal"
        '
        'CargarHijosToolStripMenuItem
        '
        Me.CargarHijosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextoToolStripMenuItem, Me.ImagenToolStripMenuItem})
        Me.CargarHijosToolStripMenuItem.Name = "CargarHijosToolStripMenuItem"
        Me.CargarHijosToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.CargarHijosToolStripMenuItem.Text = "Cargar Hijos"
        '
        'TextoToolStripMenuItem
        '
        Me.TextoToolStripMenuItem.Name = "TextoToolStripMenuItem"
        Me.TextoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TextoToolStripMenuItem.Text = "Texto"
        '
        'ImagenToolStripMenuItem
        '
        Me.ImagenToolStripMenuItem.Name = "ImagenToolStripMenuItem"
        Me.ImagenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ImagenToolStripMenuItem.Text = "Imagen"
        '
        'CerrarVentanaActualToolStripMenuItem
        '
        Me.CerrarVentanaActualToolStripMenuItem.Name = "CerrarVentanaActualToolStripMenuItem"
        Me.CerrarVentanaActualToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.CerrarVentanaActualToolStripMenuItem.Text = "Cerrar Ventana Actual"
        '
        'CerrarTodasLasVentanasToolStripMenuItem
        '
        Me.CerrarTodasLasVentanasToolStripMenuItem.Name = "CerrarTodasLasVentanasToolStripMenuItem"
        Me.CerrarTodasLasVentanasToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.CerrarTodasLasVentanasToolStripMenuItem.Text = "Cerrar Todas Las Ventanas"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(206, 6)
        '
        'SalirDeLaAplicacionToolStripMenuItem
        '
        Me.SalirDeLaAplicacionToolStripMenuItem.Name = "SalirDeLaAplicacionToolStripMenuItem"
        Me.SalirDeLaAplicacionToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.SalirDeLaAplicacionToolStripMenuItem.Text = "Salir de la Aplicacion"
        '
        'VentanasHijosChildsToolStripMenuItem
        '
        Me.VentanasHijosChildsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadeToolStripMenuItem, Me.VerticalToolStripMenuItem, Me.HorizontalToolStripMenuItem})
        Me.VentanasHijosChildsToolStripMenuItem.Name = "VentanasHijosChildsToolStripMenuItem"
        Me.VentanasHijosChildsToolStripMenuItem.Size = New System.Drawing.Size(138, 20)
        Me.VentanasHijosChildsToolStripMenuItem.Text = "Ventanas hijos (Childs)"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CascadeToolStripMenuItem.Text = "Cascade"
        '
        'VerticalToolStripMenuItem
        '
        Me.VerticalToolStripMenuItem.Name = "VerticalToolStripMenuItem"
        Me.VerticalToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VerticalToolStripMenuItem.Text = "Vertical"
        '
        'HorizontalToolStripMenuItem
        '
        Me.HorizontalToolStripMenuItem.Name = "HorizontalToolStripMenuItem"
        Me.HorizontalToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HorizontalToolStripMenuItem.Text = "Horizontal"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(24, 20)
        Me.ToolStripMenuItem2.Text = "?"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSButtonOpenText, Me.TSButtonOpenImage, Me.TSButtonCloseWindows, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 39)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TSButtonOpenText
        '
        Me.TSButtonOpenText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSButtonOpenText.Image = CType(resources.GetObject("TSButtonOpenText.Image"), System.Drawing.Image)
        Me.TSButtonOpenText.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSButtonOpenText.Name = "TSButtonOpenText"
        Me.TSButtonOpenText.Size = New System.Drawing.Size(36, 36)
        Me.TSButtonOpenText.Text = "Abrir Texto"
        '
        'TSButtonOpenImage
        '
        Me.TSButtonOpenImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSButtonOpenImage.Image = CType(resources.GetObject("TSButtonOpenImage.Image"), System.Drawing.Image)
        Me.TSButtonOpenImage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSButtonOpenImage.Name = "TSButtonOpenImage"
        Me.TSButtonOpenImage.Size = New System.Drawing.Size(36, 36)
        Me.TSButtonOpenImage.Text = "Abrir Imagen"
        '
        'TSButtonCloseWindows
        '
        Me.TSButtonCloseWindows.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSButtonCloseWindows.Image = CType(resources.GetObject("TSButtonCloseWindows.Image"), System.Drawing.Image)
        Me.TSButtonCloseWindows.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSButtonCloseWindows.Name = "TSButtonCloseWindows"
        Me.TSButtonCloseWindows.Size = New System.Drawing.Size(36, 36)
        Me.TSButtonCloseWindows.Text = "Cerrar Ventanas"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton1.Text = "Acerca de ..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PrincipalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargarHijosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImagenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarVentanaActualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarTodasLasVentanasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents SalirDeLaAplicacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentanasHijosChildsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerticalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TSButtonOpenText As ToolStripButton
    Friend WithEvents TSButtonOpenImage As ToolStripButton
    Friend WithEvents TSButtonCloseWindows As ToolStripButton
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
