Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        Dim miListBox As ListBox = sender

        If miListBox.SelectedIndex = -1 Then

            Exit Sub

        End If

        etiqueta1.Text = ""

        For Each texto As String In miListBox.SelectedItems

            etiqueta1.Text &= texto
            etiqueta1.Text &= Chr(13) + Chr(10)

        Next

    End Sub
End Class
