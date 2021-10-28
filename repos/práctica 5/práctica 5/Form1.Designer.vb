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
        Me.listBoxLeft = New System.Windows.Forms.ListBox()
        Me.textBoxLeft = New System.Windows.Forms.TextBox()
        Me.buttonDeleteLeft = New System.Windows.Forms.Button()
        Me.listBoxMiddle = New System.Windows.Forms.ListBox()
        Me.textBoxMiddle = New System.Windows.Forms.TextBox()
        Me.buttonDeleteMiddle = New System.Windows.Forms.Button()
        Me.buttonSwap1_2 = New System.Windows.Forms.Button()
        Me.buttonSwap2_1 = New System.Windows.Forms.Button()
        Me.buttonSwap2_3 = New System.Windows.Forms.Button()
        Me.buttonSwap3_2 = New System.Windows.Forms.Button()
        Me.listBoxRight = New System.Windows.Forms.ListBox()
        Me.textBoxRight = New System.Windows.Forms.TextBox()
        Me.buttonDeleteRight = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listBoxLeft
        '
        Me.listBoxLeft.AllowDrop = True
        Me.listBoxLeft.FormattingEnabled = True
        Me.listBoxLeft.ItemHeight = 15
        Me.listBoxLeft.Items.AddRange(New Object() {"Ford", "Mazda", "Seat", "Audi", "Mercedes"})
        Me.listBoxLeft.Location = New System.Drawing.Point(74, 85)
        Me.listBoxLeft.Name = "listBoxLeft"
        Me.listBoxLeft.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.listBoxLeft.Size = New System.Drawing.Size(120, 214)
        Me.listBoxLeft.TabIndex = 0
        '
        'textBoxLeft
        '
        Me.textBoxLeft.Location = New System.Drawing.Point(74, 305)
        Me.textBoxLeft.Name = "textBoxLeft"
        Me.textBoxLeft.Size = New System.Drawing.Size(120, 23)
        Me.textBoxLeft.TabIndex = 2
        '
        'buttonDeleteLeft
        '
        Me.buttonDeleteLeft.Location = New System.Drawing.Point(74, 56)
        Me.buttonDeleteLeft.Name = "buttonDeleteLeft"
        Me.buttonDeleteLeft.Size = New System.Drawing.Size(120, 23)
        Me.buttonDeleteLeft.TabIndex = 3
        Me.buttonDeleteLeft.Text = "Borrar esta lista"
        Me.buttonDeleteLeft.UseVisualStyleBackColor = True
        '
        'listBoxMiddle
        '
        Me.listBoxMiddle.AllowDrop = True
        Me.listBoxMiddle.FormattingEnabled = True
        Me.listBoxMiddle.ItemHeight = 15
        Me.listBoxMiddle.Location = New System.Drawing.Point(326, 85)
        Me.listBoxMiddle.Name = "listBoxMiddle"
        Me.listBoxMiddle.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.listBoxMiddle.Size = New System.Drawing.Size(120, 214)
        Me.listBoxMiddle.TabIndex = 0
        '
        'textBoxMiddle
        '
        Me.textBoxMiddle.Location = New System.Drawing.Point(326, 305)
        Me.textBoxMiddle.Name = "textBoxMiddle"
        Me.textBoxMiddle.Size = New System.Drawing.Size(120, 23)
        Me.textBoxMiddle.TabIndex = 2
        '
        'buttonDeleteMiddle
        '
        Me.buttonDeleteMiddle.Location = New System.Drawing.Point(326, 56)
        Me.buttonDeleteMiddle.Name = "buttonDeleteMiddle"
        Me.buttonDeleteMiddle.Size = New System.Drawing.Size(120, 23)
        Me.buttonDeleteMiddle.TabIndex = 3
        Me.buttonDeleteMiddle.Text = "Borrar esta lista"
        Me.buttonDeleteMiddle.UseVisualStyleBackColor = True
        '
        'buttonSwap1_2
        '
        Me.buttonSwap1_2.Location = New System.Drawing.Point(200, 120)
        Me.buttonSwap1_2.Name = "buttonSwap1_2"
        Me.buttonSwap1_2.Size = New System.Drawing.Size(120, 23)
        Me.buttonSwap1_2.TabIndex = 3
        Me.buttonSwap1_2.Text = "--> Envia -->"
        Me.buttonSwap1_2.UseVisualStyleBackColor = True
        '
        'buttonSwap2_1
        '
        Me.buttonSwap2_1.Location = New System.Drawing.Point(200, 201)
        Me.buttonSwap2_1.Name = "buttonSwap2_1"
        Me.buttonSwap2_1.Size = New System.Drawing.Size(120, 23)
        Me.buttonSwap2_1.TabIndex = 3
        Me.buttonSwap2_1.Text = "<-- Envia <--"
        Me.buttonSwap2_1.UseVisualStyleBackColor = True
        '
        'buttonSwap2_3
        '
        Me.buttonSwap2_3.Location = New System.Drawing.Point(452, 120)
        Me.buttonSwap2_3.Name = "buttonSwap2_3"
        Me.buttonSwap2_3.Size = New System.Drawing.Size(120, 23)
        Me.buttonSwap2_3.TabIndex = 3
        Me.buttonSwap2_3.Text = "--> Envia -->"
        Me.buttonSwap2_3.UseVisualStyleBackColor = True
        '
        'buttonSwap3_2
        '
        Me.buttonSwap3_2.Location = New System.Drawing.Point(452, 201)
        Me.buttonSwap3_2.Name = "buttonSwap3_2"
        Me.buttonSwap3_2.Size = New System.Drawing.Size(120, 23)
        Me.buttonSwap3_2.TabIndex = 3
        Me.buttonSwap3_2.Text = "<-- Envia <--"
        Me.buttonSwap3_2.UseVisualStyleBackColor = True
        '
        'listBoxRight
        '
        Me.listBoxRight.AllowDrop = True
        Me.listBoxRight.FormattingEnabled = True
        Me.listBoxRight.ItemHeight = 15
        Me.listBoxRight.Location = New System.Drawing.Point(578, 85)
        Me.listBoxRight.Name = "listBoxRight"
        Me.listBoxRight.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.listBoxRight.Size = New System.Drawing.Size(120, 214)
        Me.listBoxRight.TabIndex = 0
        '
        'textBoxRight
        '
        Me.textBoxRight.Location = New System.Drawing.Point(578, 305)
        Me.textBoxRight.Name = "textBoxRight"
        Me.textBoxRight.Size = New System.Drawing.Size(120, 23)
        Me.textBoxRight.TabIndex = 2
        '
        'buttonDeleteRight
        '
        Me.buttonDeleteRight.Location = New System.Drawing.Point(578, 56)
        Me.buttonDeleteRight.Name = "buttonDeleteRight"
        Me.buttonDeleteRight.Size = New System.Drawing.Size(120, 23)
        Me.buttonDeleteRight.TabIndex = 3
        Me.buttonDeleteRight.Text = "Borrar esta lista"
        Me.buttonDeleteRight.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.buttonDeleteRight)
        Me.Controls.Add(Me.buttonDeleteMiddle)
        Me.Controls.Add(Me.buttonSwap3_2)
        Me.Controls.Add(Me.buttonSwap2_1)
        Me.Controls.Add(Me.buttonSwap2_3)
        Me.Controls.Add(Me.buttonSwap1_2)
        Me.Controls.Add(Me.buttonDeleteLeft)
        Me.Controls.Add(Me.textBoxRight)
        Me.Controls.Add(Me.textBoxMiddle)
        Me.Controls.Add(Me.textBoxLeft)
        Me.Controls.Add(Me.listBoxRight)
        Me.Controls.Add(Me.listBoxMiddle)
        Me.Controls.Add(Me.listBoxLeft)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents listBoxLeft As ListBox
    Friend WithEvents textBoxLeft As TextBox
    Friend WithEvents buttonDeleteLeft As Button
    Friend WithEvents listBoxMiddle As ListBox
    Friend WithEvents textBoxMiddle As TextBox
    Friend WithEvents buttonDeleteMiddle As Button
    Friend WithEvents buttonSwap1_2 As Button
    Friend WithEvents buttonSwap2_1 As Button
    Friend WithEvents buttonSwap2_3 As Button
    Friend WithEvents buttonSwap3_2 As Button
    Friend WithEvents listBoxRight As ListBox
    Friend WithEvents textBoxRight As TextBox
    Friend WithEvents buttonDeleteRight As Button
End Class
