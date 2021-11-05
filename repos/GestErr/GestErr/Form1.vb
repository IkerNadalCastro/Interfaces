Public Class Form1
    Private Sub Btn_Imagen_Click(sender As Object, e As EventArgs) Handles Btn_Imagen.Click
        On Error GoTo GestionErr

        With OFDImagenes
            .InitialDirectory = My.Application.Info.DirectoryPath
            .Filter = "Todos los archivos(*.*)|*.*|Imagenes(*.BMP, *.JPG)|*.bmp; *.jpg"
            .ShowDialog()

        End With
        PBImagenes.Image = Image.FromFile(OFDImagenes.FileName)
        'Try
        'PBImagenes.Image = Image.FromFile(OFDImagenes.FileName)
        'Catch ex As Exception
        'MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

        Exit Sub
GestionErr:
        MessageBox.Show("Error en la lectura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Class
