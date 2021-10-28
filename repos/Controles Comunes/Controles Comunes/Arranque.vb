Module Arranque

    Sub main()

        Dim op As Integer = 0
        Dim MiPrincipal As New Principal
        op = MessageBox.Show("Sigues? Sí o No", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If op = vbNo Then Stop
        MiPrincipal = New Principal
        MiPrincipal.ShowDialog()

    End Sub

End Module
