Public Class Form1

    Friend WithEvents mireloj As Timer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        mireloj = New Timer
        mireloj.Interval = 1000
        mireloj.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles mireloj.Tick

        Label1.Text = Now().ToLongTimeString

    End Sub
End Class
