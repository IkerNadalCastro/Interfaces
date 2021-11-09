Public Class Hijo
    Private Sub BorrarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarTodoToolStripMenuItem.Click
        RichTextBox1.Text = Nothing
    End Sub
    Private Sub CopiarTextoDesdePortapapelesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarTextoDesdePortapapelesToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub
End Class