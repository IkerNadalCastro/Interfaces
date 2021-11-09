Public Class Form1
    'Opciones del apartado "principal" del MenuStrip
    Private Sub TSMItemCargarTexto_Click(sender As Object, e As EventArgs) Handles TSMItemCargarTexto.Click
        Dim mihijo As New Hijo
        mihijo.MdiParent = Me
        mihijo.Show()
    End Sub

    Private Sub TSMItemCargarImagen_Click(sender As Object, e As EventArgs) Handles TSMItemCargarImagen.Click
        Dim mihijoImagen As New HijoImagenes
        mihijoImagen.MdiParent = Me
        mihijoImagen.Show()
    End Sub

    Private Sub TSMItemCerrarVentana_Click(sender As Object, e As EventArgs) Handles TSMItemCerrarVentana.Click
        If MdiChildren.Length = 0 Then Exit Sub
        ActiveMdiChild.Close()
    End Sub

    Private Sub TSMItemCerrarVentanas_Click(sender As Object, e As EventArgs) Handles TSMItemCerrarVentanas.Click
        For numero As Integer = MdiChildren.Length To 0
            If MdiChildren.Length = 0 Then Exit Sub
            ActiveMdiChild.Close()
        Next
    End Sub

    Private Sub TSMItemCerrarAplicacion_Click(sender As Object, e As EventArgs) Handles TSMItemCerrarAplicacion.Click
        Me.Close()
    End Sub
End Class
