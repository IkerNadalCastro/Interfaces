Public Class Principal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSaludo.Click

        'lblSaludo.Text = sender.tag'

        'If rbtDia.Checked Then

        'lblSaludo.Text = "Buenos " & rbtDia.Text

        'End If

        'If rbtTarde.Checked Then

        'lblSaludo.Text = "Buenas " & rbtTarde.Text

        ' End If

        'If rbtNoche.Checked Then

        'lblSaludo.Text = "Buenas " & rbtNoche.Text

        ' End If 

        For Each Radio As RadioButton In panelOpcionesRadio.Controls

            If Radio.Checked Then

                lblSaludo.Text = Radio.Tag & " " & Radio.Text

            End If

        Next

        For Each Radio As RadioButton In panelOpcionesRadio2.Controls

            If Radio.Checked Then

                lblSaludo.Text &= " " & Radio.Text


            End If

        Next

        Me.Text = lblSaludo.Text



    End Sub


End Class
