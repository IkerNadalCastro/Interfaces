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
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.checkBox2 = New System.Windows.Forms.CheckBox()
        Me.checkBox3 = New System.Windows.Forms.CheckBox()
        Me.checkBox4 = New System.Windows.Forms.CheckBox()
        Me.boton1 = New System.Windows.Forms.Button()
        Me.etiqueta1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'checkBox1
        '
        Me.checkBox1.AutoSize = True
        Me.checkBox1.Location = New System.Drawing.Point(26, 22)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(74, 19)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Opción 1"
        Me.checkBox1.UseVisualStyleBackColor = True
        '
        'checkBox2
        '
        Me.checkBox2.AutoSize = True
        Me.checkBox2.Location = New System.Drawing.Point(26, 47)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(74, 19)
        Me.checkBox2.TabIndex = 0
        Me.checkBox2.Text = "Opción 2"
        Me.checkBox2.UseVisualStyleBackColor = True
        '
        'checkBox3
        '
        Me.checkBox3.AutoSize = True
        Me.checkBox3.Location = New System.Drawing.Point(26, 72)
        Me.checkBox3.Name = "checkBox3"
        Me.checkBox3.Size = New System.Drawing.Size(74, 19)
        Me.checkBox3.TabIndex = 0
        Me.checkBox3.Text = "Opción 3"
        Me.checkBox3.UseVisualStyleBackColor = True
        '
        'checkBox4
        '
        Me.checkBox4.AutoSize = True
        Me.checkBox4.Location = New System.Drawing.Point(26, 97)
        Me.checkBox4.Name = "checkBox4"
        Me.checkBox4.Size = New System.Drawing.Size(74, 19)
        Me.checkBox4.TabIndex = 0
        Me.checkBox4.Text = "Opción 4"
        Me.checkBox4.UseVisualStyleBackColor = True
        '
        'boton1
        '
        Me.boton1.Location = New System.Drawing.Point(206, 47)
        Me.boton1.Name = "boton1"
        Me.boton1.Size = New System.Drawing.Size(104, 44)
        Me.boton1.TabIndex = 1
        Me.boton1.Text = "Resumen"
        Me.boton1.UseVisualStyleBackColor = True
        '
        'etiqueta1
        '
        Me.etiqueta1.AutoSize = True
        Me.etiqueta1.Location = New System.Drawing.Point(401, 62)
        Me.etiqueta1.Name = "etiqueta1"
        Me.etiqueta1.Size = New System.Drawing.Size(41, 15)
        Me.etiqueta1.TabIndex = 2
        Me.etiqueta1.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.etiqueta1)
        Me.Controls.Add(Me.boton1)
        Me.Controls.Add(Me.checkBox4)
        Me.Controls.Add(Me.checkBox2)
        Me.Controls.Add(Me.checkBox3)
        Me.Controls.Add(Me.checkBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents checkBox1 As CheckBox
    Friend WithEvents checkBox2 As CheckBox
    Friend WithEvents checkBox3 As CheckBox
    Friend WithEvents checkBox4 As CheckBox
    Friend WithEvents boton1 As Button
    Friend WithEvents etiqueta1 As Label
End Class
