Public Class Form1
    Private Sub ImagenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImagenToolStripMenuItem.Click
        Dim MiFormImagen As New Form_Imagen
        Dim miImagen As Image = Nothing
        MiFormImagen.MdiParent = Me
        AbrirFichero.ShowDialog()
        miImagen = Image.FromFile(AbrirFichero.FileName)
        MiFormImagen.PictureBox1.Image = miImagen
        MiFormImagen.Show()
    End Sub

    'el siguiente metodo es una practica de clase

    Private Sub TextoRTFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextoRTFToolStripMenuItem.Click
        Dim MiFormRTF As New Form_RTF
        AbrirFichero.ShowDialog()
        MiFormRTF.RichTextBox1.LoadFile(AbrirFichero.FileName)
        MiFormRTF.MdiParent = Me
        MiFormRTF.Show()
    End Sub

End Class
