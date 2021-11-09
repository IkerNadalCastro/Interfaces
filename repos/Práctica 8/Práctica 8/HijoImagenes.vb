Imports System.Collections.Specialized

Public Class HijoImagenes
    Private Sub BorrarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarTodoToolStripMenuItem.Click
        PictureBox1.Image = Nothing
    End Sub
    Private Sub AñadirImagenDesdePortapapelesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirImagenDesdePortapapelesToolStripMenuItem.Click
        PictureBox1.Image = Clipboard.GetImage
        'Dim Miload As New OpenFileDialog
        'Miload.ShowDialog()
        'PictureBox1.Image = Image.FromFile(Miload.FileName)
    End Sub
End Class