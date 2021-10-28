Public Class Form1
    Private Sub buttonAdd_Click(sender As Object, e As EventArgs) Handles buttonAdd1.Click, buttonAdd2.Click, buttonAdd3.Click

        Dim miBoton As Button = sender
        Dim miTexto As TextBox = miBoton.Tag
        Dim miLista As ListBox = miTexto.Tag

        If (miTexto.Text.Trim = "") Or Not (miLista.Items.IndexOf(miTexto.Text) = -1) Then

            Exit Sub

        End If

        miLista.Items.Add(miTexto.Text)
        miTexto.Text = ""
        miTexto.Focus()

    End Sub
    Private Sub buttonDelete_Click(sender As Object, e As EventArgs) Handles buttonDelete1.Click, buttonDelete2.Click, buttonDelete3.Click

        Dim miBoton As Button = sender
        Dim miLista As ListBox = miBoton.Tag
        miLista.Items.Remove(miLista.SelectedItem)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        relacionaListas()

    End Sub

    Private Sub relacionaListas()

        buttonAdd1.Tag = textBox1
        textBox1.Tag = listBox1
        listBox1.Tag = buttonAdd1
        buttonDelete1.Tag = listBox1

        buttonAdd2.Tag = textBox2
        textBox2.Tag = listBox2
        listBox2.Tag = buttonAdd2
        buttonDelete2.Tag = listBox2

        buttonAdd3.Tag = textBox3
        textBox3.Tag = listBox3
        listBox3.Tag = buttonAdd3
        buttonDelete3.Tag = listBox3

    End Sub

    Private Sub textBox1_TextChanged(sender As Object, e As KeyPressEventArgs) Handles textBox1.KeyPress, textBox2.KeyPress, textBox3.KeyPress

        Dim miTexto As TextBox = sender
        Dim miBoton As Button = miTexto.Tag.Tag

        If e.KeyChar = Chr(13) Then

            e.Handled = True
            buttonAdd_Click(miBoton, New EventArgs)

        End If

    End Sub
End Class
