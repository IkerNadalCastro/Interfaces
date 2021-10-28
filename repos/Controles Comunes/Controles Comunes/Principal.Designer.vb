<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnSaludo = New System.Windows.Forms.Button()
        Me.lblSaludo = New System.Windows.Forms.Label()
        Me.rbtDia = New System.Windows.Forms.RadioButton()
        Me.rbtTarde = New System.Windows.Forms.RadioButton()
        Me.rbtNoche = New System.Windows.Forms.RadioButton()
        Me.panelOpcionesRadio = New System.Windows.Forms.Panel()
        Me.panelOpcionesRadio2 = New System.Windows.Forms.Panel()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.panelOpcionesRadio.SuspendLayout()
        Me.panelOpcionesRadio2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSaludo
        '
        Me.btnSaludo.AutoSize = True
        Me.btnSaludo.Location = New System.Drawing.Point(361, 119)
        Me.btnSaludo.Name = "btnSaludo"
        Me.btnSaludo.Size = New System.Drawing.Size(91, 25)
        Me.btnSaludo.TabIndex = 0
        Me.btnSaludo.Tag = "Saludo"
        Me.btnSaludo.Text = "Saludo"
        Me.btnSaludo.UseVisualStyleBackColor = True
        '
        'lblSaludo
        '
        Me.lblSaludo.AutoSize = True
        Me.lblSaludo.Location = New System.Drawing.Point(389, 253)
        Me.lblSaludo.Name = "lblSaludo"
        Me.lblSaludo.Size = New System.Drawing.Size(43, 15)
        Me.lblSaludo.TabIndex = 1
        Me.lblSaludo.Text = "Saludo"
        '
        'rbtDia
        '
        Me.rbtDia.AutoSize = True
        Me.rbtDia.Location = New System.Drawing.Point(58, 51)
        Me.rbtDia.Name = "rbtDia"
        Me.rbtDia.Size = New System.Drawing.Size(47, 19)
        Me.rbtDia.TabIndex = 3
        Me.rbtDia.TabStop = True
        Me.rbtDia.Tag = "Buenos"
        Me.rbtDia.Text = "Dias"
        Me.rbtDia.UseVisualStyleBackColor = True
        '
        'rbtTarde
        '
        Me.rbtTarde.AutoSize = True
        Me.rbtTarde.Location = New System.Drawing.Point(58, 180)
        Me.rbtTarde.Name = "rbtTarde"
        Me.rbtTarde.Size = New System.Drawing.Size(58, 19)
        Me.rbtTarde.TabIndex = 4
        Me.rbtTarde.TabStop = True
        Me.rbtTarde.Tag = "Buenas"
        Me.rbtTarde.Text = "Tardes"
        Me.rbtTarde.UseVisualStyleBackColor = True
        '
        'rbtNoche
        '
        Me.rbtNoche.AutoSize = True
        Me.rbtNoche.Location = New System.Drawing.Point(58, 302)
        Me.rbtNoche.Name = "rbtNoche"
        Me.rbtNoche.Size = New System.Drawing.Size(65, 19)
        Me.rbtNoche.TabIndex = 5
        Me.rbtNoche.TabStop = True
        Me.rbtNoche.Tag = "Buenas"
        Me.rbtNoche.Text = "Noches"
        Me.rbtNoche.UseVisualStyleBackColor = True
        '
        'panelOpcionesRadio
        '
        Me.panelOpcionesRadio.Controls.Add(Me.rbtTarde)
        Me.panelOpcionesRadio.Controls.Add(Me.rbtNoche)
        Me.panelOpcionesRadio.Controls.Add(Me.rbtDia)
        Me.panelOpcionesRadio.Location = New System.Drawing.Point(25, 12)
        Me.panelOpcionesRadio.Name = "panelOpcionesRadio"
        Me.panelOpcionesRadio.Size = New System.Drawing.Size(200, 426)
        Me.panelOpcionesRadio.TabIndex = 6
        '
        'panelOpcionesRadio2
        '
        Me.panelOpcionesRadio2.Controls.Add(Me.RadioButton1)
        Me.panelOpcionesRadio2.Controls.Add(Me.RadioButton2)
        Me.panelOpcionesRadio2.Controls.Add(Me.RadioButton3)
        Me.panelOpcionesRadio2.Location = New System.Drawing.Point(574, 12)
        Me.panelOpcionesRadio2.Name = "panelOpcionesRadio2"
        Me.panelOpcionesRadio2.Size = New System.Drawing.Size(200, 426)
        Me.panelOpcionesRadio2.TabIndex = 7
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(61, 180)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(46, 19)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Tag = "Buenas"
        Me.RadioButton1.Text = "Luis"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(58, 302)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(62, 19)
        Me.RadioButton2.TabIndex = 5
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Tag = "Buenas"
        Me.RadioButton2.Text = "Andres"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(58, 51)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(49, 19)
        Me.RadioButton3.TabIndex = 3
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Tag = "Buenos"
        Me.RadioButton3.Text = "Juan"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.panelOpcionesRadio2)
        Me.Controls.Add(Me.panelOpcionesRadio)
        Me.Controls.Add(Me.lblSaludo)
        Me.Controls.Add(Me.btnSaludo)
        Me.Name = "Principal"
        Me.Text = "Form1"
        Me.panelOpcionesRadio.ResumeLayout(False)
        Me.panelOpcionesRadio.PerformLayout()
        Me.panelOpcionesRadio2.ResumeLayout(False)
        Me.panelOpcionesRadio2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSaludo As Button
    Friend WithEvents lblSaludo As Label
    Friend WithEvents rbtDia As RadioButton
    Friend WithEvents rbtTarde As RadioButton
    Friend WithEvents rbtNoche As RadioButton
    Friend WithEvents panelOpcionesRadio As Panel
    Friend WithEvents panelOpcionesRadio2 As Panel
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
End Class
