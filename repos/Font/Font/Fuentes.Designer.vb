<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fuentes
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
        Me.lblSaludo = New System.Windows.Forms.Label()
        Me.comboBoxFuentes = New System.Windows.Forms.ComboBox()
        Me.trackBarSize = New System.Windows.Forms.TrackBar()
        CType(Me.trackBarSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSaludo
        '
        Me.lblSaludo.AutoSize = True
        Me.lblSaludo.Location = New System.Drawing.Point(373, 96)
        Me.lblSaludo.Name = "lblSaludo"
        Me.lblSaludo.Size = New System.Drawing.Size(32, 15)
        Me.lblSaludo.TabIndex = 0
        Me.lblSaludo.Text = "Hola"
        '
        'comboBoxFuentes
        '
        Me.comboBoxFuentes.FormattingEnabled = True
        Me.comboBoxFuentes.Location = New System.Drawing.Point(12, 96)
        Me.comboBoxFuentes.Name = "comboBoxFuentes"
        Me.comboBoxFuentes.Size = New System.Drawing.Size(302, 23)
        Me.comboBoxFuentes.TabIndex = 1
        '
        'trackBarSize
        '
        Me.trackBarSize.Location = New System.Drawing.Point(12, 125)
        Me.trackBarSize.Maximum = 50
        Me.trackBarSize.Minimum = 8
        Me.trackBarSize.Name = "trackBarSize"
        Me.trackBarSize.Size = New System.Drawing.Size(302, 45)
        Me.trackBarSize.TabIndex = 2
        Me.trackBarSize.Value = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.trackBarSize)
        Me.Controls.Add(Me.comboBoxFuentes)
        Me.Controls.Add(Me.lblSaludo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.trackBarSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSaludo As Label
    Friend WithEvents comboBoxFuentes As ComboBox
    Friend WithEvents trackBarSize As TrackBar
End Class
