Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim mybutton = New Button
        AddHandler mybutton.Click, AddressOf click_button
        Me.Controls.Add(mybutton)

    End Sub

    Sub click_button(myobject As Object, evento As EventArgs)

        MessageBox.Show("Hola")

    End Sub

End Class
