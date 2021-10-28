Public Class Form1
    Private Sub checkBox1_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox1.CheckedChanged, checkBox2.CheckedChanged, checkBox3.CheckedChanged, checkBox4.CheckedChanged, boton1.MouseClick

        Dim miCheck As CheckBox = sender
        Dim texto As String

        If miCheck.Checked Then

            texto = "activado"

            etiqueta1.Text = miCheck.Text


        Else

            texto = "desactivado"

        End If



        'MessageBox.Show("El Checkbox " & miCheck.Text & " está " & texto, " Estado ")

    End Sub

    Private Sub boton1_Click(sender As Object, e As EventArgs) Handles boton1.Click

        Dim miChechBox As CheckBox
        Dim texto As String = " "

        For Each miChechBox.Text In pane

    End Sub
End Class
