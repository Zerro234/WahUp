Imports System.IO
''Imports System.Drawing.Drawing2D

Public Class FormMain
    Private Sub btnSend1_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Me.Send(True)
    End Sub

    Private Sub btnSend2_Click(sender As Object, e As EventArgs) Handles btnSand2.Click
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
            pn.Focus()

            Me.Clear()

            txtChat.Text = ""
            txtChat.Focus()

        End If
    End Sub

    Private Filenames As String() = {}

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Me.CloseAll()
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
        Me.CloseAll()
    End Sub

    Private Sub CloseAll()
        pnFooter1.Visible = False
        pnFooter4.Visible = False
        pnFooter3.Visible = False
    End Sub

    Private Sub btnClear1_Click(sender As Object, e As EventArgs) Handles btnClear1.Click
        Me.Clear()
    End Sub

    Private Sub btnStikers_Click(sender As Object, e As EventArgs) Handles btnStikers.Click
        Me.CloseAll()
        Me.ClearStiker()
    End Sub

    Private Sub LoadStiker()

        Dim folderPath As String = Application.StartupPath & "\Stickers"
        Dim dirInfo As New DirectoryInfo(folderPath)

        If dirInfo.Exists Then
            pnStiker.Controls.Clear()

            Dim files As FileInfo() = dirInfo.GetFiles()

            For Each file As FileInfo In files
                If file.Extension.ToLower() = ".png" Or file.Extension.ToLower() = ".jpg" Or file.Extension.ToLower() = ".jpeg" Then
                    Dim pb As New PictureBox()
                    pb.Dock = DockStyle.Left
                    pb.Size = New Size(50, 50)
                    pb.BorderStyle = BorderStyle.FixedSingle
                    pb.SizeMode = PictureBoxSizeMode.Zoom
                    pb.Image = Image.FromFile(file.FullName)
                    pb.Tag = file.FullName
                    AddHandler pb.Click, AddressOf Stiker_Click

                    pnStiker.Controls.Add(pb)
                    pb.BringToFront()
                End If
            Next
        Else
            MessageBox.Show("Folder stiker tidak ditemukan di: " & folderPath, "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Stiker_Click(sender As Object, e As EventArgs)

        'Deteksi stiker mana yang diklik
        Dim pbClic As PictureBox = CType(sender, PictureBox)
        Dim filenameStiker As String = pbClic.Tag.ToString()

        Dim pn As New PnChat()
        pn.Filename = filenameStiker
        pn.IsLeft = True
        pn.Dock = DockStyle.Top
        pnChats.Controls.Add(pn)
        pn.BringToFront()
        pnFooter3.Visible = False
        pn.Focus()

    End Sub

    Private Sub ClearStiker()
        pnFooter3.Visible = Not pnFooter3.Visible

        ' Memastikan stiker hanya diload sekali saat panel kosong
        If pnStiker.Visible = True AndAlso pnStiker.Controls.Count = 0 Then
            LoadStiker()
        End If
    End Sub

    Private Sub btnClear3_Click(sender As Object, e As EventArgs) Handles btnClear3.Click
        Me.ClearStiker()
    End Sub



    '----------------------------------- GIF -------------------------------------------------------------------------------------

    Private Sub LoadGif()
        Dim folderPath As String = Application.StartupPath & "\Gif"
        Dim dirInfo As New DirectoryInfo(folderPath)

        If dirInfo.Exists Then
            pnGif.Controls.Clear()

            Dim files As FileInfo() = dirInfo.GetFiles()

            For Each file As FileInfo In files
                If file.Extension.ToLower() = ".gif" Then
                    Dim pb As New PictureBox()
                    pb.Dock = DockStyle.Left
                    pb.Size = New Size(50, 50)
                    pb.BorderStyle = BorderStyle.FixedSingle
                    pb.SizeMode = PictureBoxSizeMode.Zoom
                    pb.Image = Image.FromFile(file.FullName)
                    pb.Tag = file.FullName
                    AddHandler pb.Click, AddressOf Gif_Click

                    pnGif.Controls.Add(pb)
                    pb.BringToFront()
                End If
            Next
        Else
            MessageBox.Show("Folder stiker tidak ditemukan di: " & folderPath, "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Gif_Click(sender As Object, e As EventArgs)

        'Deteksi stiker mana yang diklik
        Dim pbClic As PictureBox = CType(sender, PictureBox)
        Dim filenameGif As String = pbClic.Tag.ToString()

        Dim pn As New PnChat()
        pn.Filename = filenameGif
        pn.IsLeft = True
        pn.Dock = DockStyle.Top
        pnChats.Controls.Add(pn)
        pn.BringToFront()
        pnFooter4.Visible = False
        pn.Focus()

    End Sub
    Private Sub btnClear4_Click(sender As Object, e As EventArgs) Handles btnClear4.Click
        pnFooter4.Visible = False
    End Sub

    Private Sub btnGif_Click(sender As Object, e As EventArgs) Handles btnGif.Click
        Me.CloseAll()
        pnFooter4.Visible = True
        LoadGif()
    End Sub

    Private Sub ResetNotifikasiKontak()
        ' Memanggil properti Jumlah pada User Control
        ' Ini otomatis menjalankan logika sembunyikan PictureBox & tengahkan Label
        PnContact1.Jumlah = 0

        ' Opsional: Refresh untuk memastikan UI langsung update
        PnContact1.Refresh()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load, PnContact2.Click
        ' Panggil fungsi untuk mendaftarkan klik ke PnContact1 dan SEMUA anaknya
        DaftarkanKlik(PnContact1)
    End Sub

    ' Fungsi Rekursif: Akan mencari semua kontrol sampai ke akar-akarnya
    Private Sub DaftarkanKlik(parent As Control)
        ' Berikan event klik ke kontrol ini sendiri
        AddHandler parent.Click, AddressOf ResetNotifikasiKontak

        ' Cari semua anak di dalamnya (Recursive)
        For Each child As Control In parent.Controls
            DaftarkanKlik(child)
        Next
    End Sub



    ''Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ''Dim path As New GraphicsPath()
    ''   path.AddEllipse(0, 0, pbProfil.Width, pbProfil.Height)
    ''    pbProfil.Region = New Region(path)
    '' End Sub

    ' Private Sub Click_contact()
    ' Me.Jumlah = 0
    'End Sub


End Class