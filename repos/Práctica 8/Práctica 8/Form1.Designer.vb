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
        Me.TSMItemPrincipal = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMItemCargar = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMItemCargarTexto = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMItemCargarImagen = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMItemCerrarVentana = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMItemCerrarVentanas = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSMItemCerrarAplicacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMItemVentanas = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMItemCascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMItemVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMItemHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSMItemAcercaDe = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSButtonOpenText = New System.Windows.Forms.ToolStripButton()
        Me.TSButtonOpenImage = New System.Windows.Forms.ToolStripButton()
        Me.TSButtonCloseWindows = New System.Windows.Forms.ToolStripButton()
        Me.TSButtonAcercaDe = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMItemPrincipal, Me.TSMItemVentanas, Me.TSMItemAcercaDe})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TSMItemPrincipal
        '
        Me.TSMItemPrincipal.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMItemCargar, Me.TSMItemCerrarVentana, Me.TSMItemCerrarVentanas, Me.ToolStripMenuItem1, Me.TSMItemCerrarAplicacion})
        Me.TSMItemPrincipal.Name = "TSMItemPrincipal"
        Me.TSMItemPrincipal.Size = New System.Drawing.Size(65, 20)
        Me.TSMItemPrincipal.Text = "Principal"
        '
        'TSMItemCargar
        '
        Me.TSMItemCargar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMItemCargarTexto, Me.TSMItemCargarImagen})
        Me.TSMItemCargar.Name = "TSMItemCargar"
        Me.TSMItemCargar.Size = New System.Drawing.Size(209, 22)
        Me.TSMItemCargar.Text = "Cargar Hijos"
        '
        'TSMItemCargarTexto
        '
        Me.TSMItemCargarTexto.Name = "TSMItemCargarTexto"
        Me.TSMItemCargarTexto.Size = New System.Drawing.Size(114, 22)
        Me.TSMItemCargarTexto.Text = "Texto"
        '
        'TSMItemCargarImagen
        '
        Me.TSMItemCargarImagen.Name = "TSMItemCargarImagen"
        Me.TSMItemCargarImagen.Size = New System.Drawing.Size(114, 22)
        Me.TSMItemCargarImagen.Text = "Imagen"
        '
        'TSMItemCerrarVentana
        '
        Me.TSMItemCerrarVentana.Name = "TSMItemCerrarVentana"
        Me.TSMItemCerrarVentana.Size = New System.Drawing.Size(209, 22)
        Me.TSMItemCerrarVentana.Text = "Cerrar Ventana Actual"
        '
        'TSMItemCerrarVentanas
        '
        Me.TSMItemCerrarVentanas.Name = "TSMItemCerrarVentanas"
        Me.TSMItemCerrarVentanas.Size = New System.Drawing.Size(209, 22)
        Me.TSMItemCerrarVentanas.Text = "Cerrar Todas Las Ventanas"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(206, 6)
        '
        'TSMItemCerrarAplicacion
        '
        Me.TSMItemCerrarAplicacion.Name = "TSMItemCerrarAplicacion"
        Me.TSMItemCerrarAplicacion.Size = New System.Drawing.Size(209, 22)
        Me.TSMItemCerrarAplicacion.Text = "Salir de la Aplicacion"
        '
        'TSMItemVentanas
        '
        Me.TSMItemVentanas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMItemCascade, Me.TSMItemVertical, Me.TSMItemHorizontal, Me.ToolStripMenuItem2})
        Me.TSMItemVentanas.Name = "TSMItemVentanas"
        Me.TSMItemVentanas.Size = New System.Drawing.Size(138, 20)
        Me.TSMItemVentanas.Text = "Ventanas hijos (Childs)"
        '
        'TSMItemCascade
        '
        Me.TSMItemCascade.Name = "TSMItemCascade"
        Me.TSMItemCascade.Size = New System.Drawing.Size(129, 22)
        Me.TSMItemCascade.Text = "Cascade"
        '
        'TSMItemVertical
        '
        Me.TSMItemVertical.Name = "TSMItemVertical"
        Me.TSMItemVertical.Size = New System.Drawing.Size(129, 22)
        Me.TSMItemVertical.Text = "Vertical"
        '
        'TSMItemHorizontal
        '
        Me.TSMItemHorizontal.Name = "TSMItemHorizontal"
        Me.TSMItemHorizontal.Size = New System.Drawing.Size(129, 22)
        Me.TSMItemHorizontal.Text = "Horizontal"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(126, 6)
        '
        'TSMItemAcercaDe
        '
        Me.TSMItemAcercaDe.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TSMItemAcercaDe.Name = "TSMItemAcercaDe"
        Me.TSMItemAcercaDe.Size = New System.Drawing.Size(24, 20)
        Me.TSMItemAcercaDe.Text = "?"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSButtonOpenText, Me.TSButtonOpenImage, Me.TSButtonCloseWindows, Me.TSButtonAcercaDe})
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
        'TSButtonAcercaDe
        '
        Me.TSButtonAcercaDe.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TSButtonAcercaDe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSButtonAcercaDe.Image = CType(resources.GetObject("TSButtonAcercaDe.Image"), System.Drawing.Image)
        Me.TSButtonAcercaDe.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSButtonAcercaDe.Name = "TSButtonAcercaDe"
        Me.TSButtonAcercaDe.Size = New System.Drawing.Size(36, 36)
        Me.TSButtonAcercaDe.Text = "Acerca de ..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Formulario MDI"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TSMItemPrincipal As ToolStripMenuItem
    Friend WithEvents TSMItemCargar As ToolStripMenuItem
    Friend WithEvents TSMItemCargarTexto As ToolStripMenuItem
    Friend WithEvents TSMItemCargarImagen As ToolStripMenuItem
    Friend WithEvents TSMItemCerrarVentana As ToolStripMenuItem
    Friend WithEvents TSMItemCerrarVentanas As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents TSMItemCerrarAplicacion As ToolStripMenuItem
    Friend WithEvents TSMItemVentanas As ToolStripMenuItem
    Friend WithEvents TSMItemCascade As ToolStripMenuItem
    Friend WithEvents TSMItemVertical As ToolStripMenuItem
    Friend WithEvents TSMItemHorizontal As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TSButtonOpenText As ToolStripButton
    Friend WithEvents TSButtonOpenImage As ToolStripButton
    Friend WithEvents TSButtonCloseWindows As ToolStripButton
    Friend WithEvents TSMItemAcercaDe As ToolStripMenuItem
    Friend WithEvents TSButtonAcercaDe As ToolStripButton
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
End Class
