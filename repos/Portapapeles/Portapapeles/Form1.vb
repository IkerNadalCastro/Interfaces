Public Class Form1
    Private Sub pictureBoxImage_DoubleClick(sender As Object, e As EventArgs) Handles pictureBoxImage.DoubleClick

        Dim miPictureBox As PictureBox = sender

        miPictureBox.Image = Clipboard.GetImage()

    End Sub

    Private Sub RichTextBox1_DoubleClick(sender As Object, e As EventArgs) Handles RichTextBox1.DoubleClick

        Dim miTexto As RichTextBox = sender

        miTexto.Paste()

    End Sub
End Class
