Public Class Form1

    Dim milistaorigen As ListBox
    Dim milistadestino As ListBox

    Private Sub textBoxLeft_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBoxLeft.KeyPress

        Dim MiTexto As TextBox = sender
        Dim MiListBox As ListBox = MiTexto.Tag

        If Asc(e.KeyChar) = Keys.Enter Then

            e.Handled = True

            If ((MiListBox.Items.Contains(MiTexto.Text.Trim)) Or (MiTexto.Text.Trim = "")) Then

                MiTexto.Text = ""
                Exit Sub

            End If

            MiListBox.Items.Add(MiTexto.Text.Trim)
            MiTexto.Text = ""
            MiTexto.Focus()

        End If

    End Sub

    Private Sub textBoxMiddle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBoxMiddle.KeyPress

        Dim MiTexto As TextBox = sender
        Dim MiListBox As ListBox = MiTexto.Tag

        If Asc(e.KeyChar) = Keys.Enter Then

            e.Handled = True

            If ((MiListBox.Items.Contains(MiTexto.Text.Trim)) Or (MiTexto.Text.Trim = "")) Then

                MiTexto.Text = ""
                Exit Sub

            End If

            MiListBox.Items.Add(MiTexto.Text.Trim)
            MiTexto.Text = ""
            MiTexto.Focus()

        End If

    End Sub

    Private Sub textBoxRight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBoxRight.KeyPress

        Dim MiTexto As TextBox = sender
        Dim MiListBox As ListBox = MiTexto.Tag

        If Asc(e.KeyChar) = Keys.Enter Then

            e.Handled = True

            If ((MiListBox.Items.Contains(MiTexto.Text.Trim)) Or (MiTexto.Text.Trim = "")) Then

                MiTexto.Text = ""
                Exit Sub

            End If

            MiListBox.Items.Add(MiTexto.Text.Trim)
            MiTexto.Text = ""
            MiTexto.Focus()

        End If

    End Sub

    Private Sub buttonDeleteLeft_Click(sender As Object, e As EventArgs) Handles buttonDeleteLeft.Click

        Dim mibutton As Button = sender
        Dim milistbox As ListBox = mibutton.Tag

        milistbox.Items.Clear()

    End Sub

    Private Sub buttonDeleteMiddle_Click(sender As Object, e As EventArgs) Handles buttonDeleteMiddle.Click

        Dim mibutton As Button = sender
        Dim milistbox As ListBox = mibutton.Tag

        milistbox.Items.Clear()

    End Sub

    Private Sub buttonDeleteRight_Click(sender As Object, e As EventArgs) Handles buttonDeleteRight.Click

        Dim mibutton As Button = sender
        Dim milistbox As ListBox = mibutton.Tag

        milistbox.Items.Clear()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        initialize()


    End Sub

    Private Sub initialize()

        textBoxLeft.Tag = listBoxLeft
        buttonDeleteLeft.Tag = listBoxLeft

        textBoxMiddle.Tag = listBoxMiddle
        buttonDeleteMiddle.Tag = listBoxMiddle

        textBoxRight.Tag = listBoxRight
        buttonDeleteRight.Tag = listBoxRight

    End Sub

    Private Sub swapListItems()

        Do While milistaorigen.SelectedItems.Count

            milistadestino.Items.Add(milistaorigen.SelectedItems(0))
            milistaorigen.Items.Remove(milistaorigen.SelectedItems(0))

        Loop

    End Sub

    Private Sub listBox_DoubleClick(sender As Object, e As EventArgs) Handles listBoxLeft.DoubleClick, listBoxMiddle.DoubleClick, listBoxRight.DoubleClick

        Dim milista As ListBox = sender

        If milista.SelectedItems.Count = 0 Then

            Exit Sub

        End If

        Select Case milista.Name

            Case "listBoxLeft"

                milistaorigen = listBoxLeft
                milistadestino = listBoxMiddle


            Case "listBoxMiddle"

                milistaorigen = listBoxMiddle
                milistadestino = listBoxRight

            Case "listBoxRight"

                milistaorigen = listBoxRight
                milistadestino = listBoxLeft


        End Select

        swapListItems()

    End Sub

    Private Sub buttonSwap_Click(sender As Object, e As EventArgs) Handles buttonSwap1_2.Click, buttonSwap2_1.Click, buttonSwap3_2.Click, buttonSwap2_3.Click

        Dim miboton As Button = sender
        Select Case miboton.Name

            Case "buttonSwap1_2"

                milistaorigen = listBoxLeft
                milistadestino = listBoxMiddle


            Case "buttonSwap2_1"

                milistaorigen = listBoxMiddle
                milistadestino = listBoxLeft

            Case "buttonSwap2_3"

                milistaorigen = listBoxMiddle
                milistadestino = listBoxRight

            Case "buttonSwap3_2"

                milistaorigen = listBoxRight
                milistadestino = listBoxMiddle

        End Select

        swapListItems()

    End Sub

    Private Sub Listas_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles listBoxLeft.MouseDown, listBoxMiddle.MouseDown, listBoxRight.MouseDown

        milistaorigen = sender
        Select Case milistaorigen.Name

            Case listBoxLeft.Name

                milistadestino = listBoxMiddle


            Case listBoxMiddle.Name

                milistadestino = listBoxRight


            Case listBoxRight.Name

                milistadestino = listBoxLeft


        End Select

        If e.Clicks = 2 Then

            swapListItems()
            Exit Sub

        End If

        milistaorigen.DoDragDrop(milistaorigen.Text, DragDropEffects.Move)

    End Sub

    Private Sub Listas_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles listBoxMiddle.DragOver, listBoxLeft.DragOver, listBoxRight.DragOver

        e.Effect = DragDropEffects.Move

    End Sub

    Private Sub Listas_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles listBoxMiddle.DragDrop, listBoxLeft.DragDrop, listBoxRight.DragDrop

        milistadestino = sender
        swapListItems()

    End Sub

End Class
