Public Class PnChat
    Private Filename_ As String = ""
    Public Property Filename As String
        Set(value As String)
            Filename_ = value

            Filenames = {}

            If (Filename_.Trim() <> "") Then
                Filenames = {Filename_}
                Me.Chat = ""
                Me.RPosition()
            End If

        End Set
        Get
            Return Filename_
        End Get
    End Property

    Private Filenames_ As String() = {}
    Public Property Filenames As String()
        Set(value As String())
            Filenames_ = value

            Dim count As Integer
            count = Filenames_.Length

            pn1.Visible = False
            pn2.Visible = False
            pn3.Visible = False
            pns.Visible = False
            pns.Size = New Size(0, 0)
            lblChat.Location = New Point(10, 10)
            pnMain.Size = New Size(0, 0)


            If (count > 0) Then
                pns.Visible = True
                pns.Size = New Size(320, 170)
                lblChat.Location = New Point(10, pns.Height + 10 + 5)

                If (count = 1) Then
                    pn1.Visible = True

                    pb1.Image = Image.FromFile(Filenames_(0))
                ElseIf (count = 2) Then
                    pn1.Visible = True
                    pn2.Visible = True

                    pn2.Size = New Size(pns.Width / 2, 0)

                    pb1.Image = Image.FromFile(Filenames_(0))
                    pb2.Image = Image.FromFile(Filenames_(1))


                ElseIf (count = 3) Then
                    pn2.Visible = True
                    pn3.Visible = True

                    pn2.Size = New Size(pns.Width / 2, 0)
                    pn3.Size = New Size(pns.Width / 2, 0)

                    pb2.Image = Image.FromFile(Filenames_(0))
                    pb31.Image = Image.FromFile(Filenames_(1))
                    pb32.Image = Image.FromFile(Filenames_(2))
                End If
            End If
        End Set
        Get
            Return Filenames_
        End Get
    End Property



    Private Chat_ As String = "..."
    Public Property Chat As String
        Set(value As String)
            Chat_ = value
            lblChat.Text = Chat_

            Me.RPosition()
        End Set
        Get
            Return Chat_
        End Get
    End Property

    Private IsLeft_ As Boolean = True
    Public Property IsLeft As Boolean
        Set(value As Boolean)
            IsLeft_ = value
            Me.RPosition()
        End Set
        Get
            Return IsLeft_
        End Get
    End Property

    Private Sub RPosition()
        If (IsLeft = True) Then
            pnMain.BackColor = Color.FromArgb(255, 192, 192)
            pnMain.Location = New Point(10, 10)
        Else
            pnMain.BackColor = Color.FromArgb(92, 255, 192)
            pnMain.Location = New Point(Me.Width - pnMain.Width - 10, 10)
        End If

        pnMain.BorderStyle = BorderStyle.FixedSingle
        If (Filename.Trim() <> "") Then
            pnMain.BorderStyle = BorderStyle.None
            pnMain.BackColor = Color.Transparent
        End If

        pnMain.Size = New Size(0, 0)
    End Sub

    Private Sub lblChat_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged, lblChat.SizeChanged
        Me.RPosition()
    End Sub
End Class
