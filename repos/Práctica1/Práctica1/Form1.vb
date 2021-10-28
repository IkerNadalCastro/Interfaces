Public Class Form1
    Private Sub botonPulsado_Click(sender As Object, e As EventArgs) Handles botonPulsado.MouseClick

        If botonPulsado.Text = "Pulsa" Then

            botonPulsado.Text = "Ya Pulsado"

        Else

            MessageBox.Show("Este botón ya ha sido pulsado")

        End If

    End Sub

    Private Sub etiqueta1_Click(sender As Object, e As EventArgs) Handles etiqueta1.DoubleClick

        etiqueta1.Text = etiqueta1.Text + "P"

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As EventArgs) Handles botonRadio1.Click,
            botonRadio2.Click, botonRadio3.Click, botonRadio4.Click

        Dim miRadio As RadioButton = sender

        MessageBox.Show(miRadio.Text & " Seleccionado ", "Aviso ", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles botonContador.Click

        Dim miBoton As Button = sender
        Static contador As Integer = 0
        contador = contador + 1
        miBoton.Text = contador

        'botonContador.Text = botonContador.Text + 1

    End Sub

    Private Sub botonConcatenar_Click(sender As Object, e As EventArgs) Handles botonConcatenar.Click

        Me.Text = cajaTexto1.Text + cajaTexto2.Text

    End Sub
End Class
