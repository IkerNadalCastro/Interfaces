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
        Me.listBox1 = New System.Windows.Forms.ListBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.buttonAdd1 = New System.Windows.Forms.Button()
        Me.listBox2 = New System.Windows.Forms.ListBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.buttonAdd2 = New System.Windows.Forms.Button()
        Me.listBox3 = New System.Windows.Forms.ListBox()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.buttonAdd3 = New System.Windows.Forms.Button()
        Me.buttonDelete1 = New System.Windows.Forms.Button()
        Me.buttonDelete2 = New System.Windows.Forms.Button()
        Me.buttonDelete3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listBox1
        '
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.ItemHeight = 15
        Me.listBox1.Location = New System.Drawing.Point(86, 50)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(120, 94)
        Me.listBox1.TabIndex = 0
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(86, 163)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(120, 23)
        Me.textBox1.TabIndex = 1
        '
        'buttonAdd1
        '
        Me.buttonAdd1.Location = New System.Drawing.Point(86, 202)
        Me.buttonAdd1.Name = "buttonAdd1"
        Me.buttonAdd1.Size = New System.Drawing.Size(120, 23)
        Me.buttonAdd1.TabIndex = 2
        Me.buttonAdd1.Text = "Añadir"
        Me.buttonAdd1.UseVisualStyleBackColor = True
        '
        'listBox2
        '
        Me.listBox2.FormattingEnabled = True
        Me.listBox2.ItemHeight = 15
        Me.listBox2.Location = New System.Drawing.Point(242, 50)
        Me.listBox2.Name = "listBox2"
        Me.listBox2.Size = New System.Drawing.Size(120, 94)
        Me.listBox2.TabIndex = 0
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(242, 163)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(120, 23)
        Me.textBox2.TabIndex = 1
        '
        'buttonAdd2
        '
        Me.buttonAdd2.Location = New System.Drawing.Point(242, 202)
        Me.buttonAdd2.Name = "buttonAdd2"
        Me.buttonAdd2.Size = New System.Drawing.Size(120, 23)
        Me.buttonAdd2.TabIndex = 2
        Me.buttonAdd2.Text = "Añadir"
        Me.buttonAdd2.UseVisualStyleBackColor = True
        '
        'listBox3
        '
        Me.listBox3.FormattingEnabled = True
        Me.listBox3.ItemHeight = 15
        Me.listBox3.Location = New System.Drawing.Point(398, 50)
        Me.listBox3.Name = "listBox3"
        Me.listBox3.Size = New System.Drawing.Size(120, 94)
        Me.listBox3.TabIndex = 0
        '
        'textBox3
        '
        Me.textBox3.Location = New System.Drawing.Point(398, 163)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(120, 23)
        Me.textBox3.TabIndex = 1
        '
        'buttonAdd3
        '
        Me.buttonAdd3.Location = New System.Drawing.Point(398, 202)
        Me.buttonAdd3.Name = "buttonAdd3"
        Me.buttonAdd3.Size = New System.Drawing.Size(120, 23)
        Me.buttonAdd3.TabIndex = 2
        Me.buttonAdd3.Text = "Añadir"
        Me.buttonAdd3.UseVisualStyleBackColor = True
        '
        'buttonDelete1
        '
        Me.buttonDelete1.Location = New System.Drawing.Point(86, 231)
        Me.buttonDelete1.Name = "buttonDelete1"
        Me.buttonDelete1.Size = New System.Drawing.Size(120, 23)
        Me.buttonDelete1.TabIndex = 2
        Me.buttonDelete1.Text = "Quitar"
        Me.buttonDelete1.UseVisualStyleBackColor = True
        '
        'buttonDelete2
        '
        Me.buttonDelete2.Location = New System.Drawing.Point(242, 231)
        Me.buttonDelete2.Name = "buttonDelete2"
        Me.buttonDelete2.Size = New System.Drawing.Size(120, 23)
        Me.buttonDelete2.TabIndex = 2
        Me.buttonDelete2.Text = "Quitar"
        Me.buttonDelete2.UseVisualStyleBackColor = True
        '
        'buttonDelete3
        '
        Me.buttonDelete3.Location = New System.Drawing.Point(398, 231)
        Me.buttonDelete3.Name = "buttonDelete3"
        Me.buttonDelete3.Size = New System.Drawing.Size(120, 23)
        Me.buttonDelete3.TabIndex = 2
        Me.buttonDelete3.Text = "Quitar"
        Me.buttonDelete3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.buttonDelete3)
        Me.Controls.Add(Me.buttonAdd3)
        Me.Controls.Add(Me.buttonDelete2)
        Me.Controls.Add(Me.buttonDelete1)
        Me.Controls.Add(Me.buttonAdd2)
        Me.Controls.Add(Me.buttonAdd1)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.listBox3)
        Me.Controls.Add(Me.listBox2)
        Me.Controls.Add(Me.listBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents listBox1 As ListBox
    Friend WithEvents textBox1 As TextBox
    Friend WithEvents buttonAdd1 As Button
    Friend WithEvents listBox2 As ListBox
    Friend WithEvents textBox2 As TextBox
    Friend WithEvents buttonAdd2 As Button
    Friend WithEvents listBox3 As ListBox
    Friend WithEvents textBox3 As TextBox
    Friend WithEvents buttonAdd3 As Button
    Friend WithEvents buttonDelete1 As Button
    Friend WithEvents buttonDelete2 As Button
    Friend WithEvents buttonDelete3 As Button
End Class
