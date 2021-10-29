Public Class Fuentes
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargaFuentes()

    End Sub

    Private Sub cargaFuentes()

        Dim miFuente As FontFamily
        For Each miFuente In FontFamily.Families

            comboBoxFuentes.Items.Add(miFuente.Name)

        Next

        comboBoxFuentes.Text = comboBoxFuentes.Items(0)

    End Sub

    Private Sub comboBoxFuentes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxFuentes.SelectedIndexChanged

        lblSaludo.Font = New Font(comboBoxFuentes.Text, trackBarSize.Value)


    End Sub

    Private Sub trackBarSize_Scroll(sender As Object, e As EventArgs) Handles trackBarSize.Scroll

        lblSaludo.Font = New Font(comboBoxFuentes.Text, trackBarSize.Value)

    End Sub
End Class
