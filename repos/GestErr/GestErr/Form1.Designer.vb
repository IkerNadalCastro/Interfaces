<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Btn_Imagen = New System.Windows.Forms.Button()
        Me.OFDImagenes = New System.Windows.Forms.OpenFileDialog()
        Me.PBImagenes = New System.Windows.Forms.PictureBox()
        CType(Me.PBImagenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Imagen
        '
        Me.Btn_Imagen.Location = New System.Drawing.Point(408, 45)
        Me.Btn_Imagen.Name = "Btn_Imagen"
        Me.Btn_Imagen.Size = New System.Drawing.Size(114, 23)
        Me.Btn_Imagen.TabIndex = 0
        Me.Btn_Imagen.Text = "Cargar Imagen"
        Me.Btn_Imagen.UseVisualStyleBackColor = True
        '
        'OFDImagenes
        '
        Me.OFDImagenes.FileName = "OpenFileDialog1"
        '
        'PBImagenes
        '
        Me.PBImagenes.Location = New System.Drawing.Point(337, 74)
        Me.PBImagenes.Name = "PBImagenes"
        Me.PBImagenes.Size = New System.Drawing.Size(266, 202)
        Me.PBImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBImagenes.TabIndex = 1
        Me.PBImagenes.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PBImagenes)
        Me.Controls.Add(Me.Btn_Imagen)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PBImagenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_Imagen As Button
    Friend WithEvents OFDImagenes As OpenFileDialog
    Friend WithEvents PBImagenes As PictureBox
End Class
