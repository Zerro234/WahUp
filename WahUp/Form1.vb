Public Class Form1
    Private Sub btnSend1_Click(sender As Object, e As EventArgs) Handles btnSend1.Click
        Me.Send(True)
    End Sub

    Private Sub btnSend2_Click(sender As Object, e As EventArgs) Handles btnSend2.Click
        Me.Send(False)
    End Sub

    Private Sub Send(Isleft As Boolean)

        If (txtChat.Text.Trim() = "" And pnImages.Controls.Count = 0) Then
            Return
        Else
            Dim pn As PnChat
            pn = New PnChat()
            pn.Chat = txtChat.Text
            pn.IsLeft = Isleft
            pn.Filenames = Filenames
            pn.Dock = DockStyle.Top
            pnChats.Controls.Add(pn)
            pn.BringToFront()

            Me.Clear()

            txtChat.Text = ""
            txtChat.Focus()
        End If

    End Sub

    Private Filenames As String() = {}

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim frm As OpenFileDialog
        frm = New OpenFileDialog()
        frm.Multiselect = True


        If (frm.ShowDialog() = DialogResult.OK) Then
            pnFooter1.Visible = True
            Dim i As Integer
            For i = 0 To frm.FileNames.Length - 1
                Dim filename As String
                filename = frm.FileNames(i)

                Filenames = frm.FileNames

                Dim pb As PictureBox
                pb = New PictureBox()
                pb.Dock = DockStyle.Left
                pb.Size = New Size(50, 50)
                pb.BorderStyle = BorderStyle.FixedSingle
                pb.SizeMode = PictureBoxSizeMode.Zoom
                pb.Image = Image.FromFile(filename)
                pb.BringToFront()
                pnImages.Controls.Add(pb)
            Next
        End If
    End Sub

    Private Sub Clear()
        Filenames = {}
        pnImages.Controls.Clear()
        pnFooter1.Visible = False
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.Clear()
    End Sub

    Private Sub btnStikers_Click(sender As Object, e As EventArgs) Handles btnStikers.Click

    End Sub
End Class
