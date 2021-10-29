Public Class Form1

    Friend WithEvents miExplorador As WebBrowser

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        miExplorador = New WebBrowser
        miExplorador.Dock = DockStyle.Fill
        Me.Controls.Add(miExplorador)
        miExplorador.Navigate("\Users\DAM2Alu11\Desktop")

    End Sub
End Class
