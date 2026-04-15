Public Class PnContact
    Private Profile_ As Image = Global.WahUp.My.Resources.Resources.profile
    Public Property Profile As Image
        Set(value As Image)
            Profile_ = value
            pbProfile.Image = Profile_
        End Set
        Get
            Return Profile_
        End Get
    End Property

    Private Nama_ As String = "Fransiskus Juniarto"
    Public Property Nama As String
        Set(value As String)
            Nama_ = value
            lblNama.Text = Nama_
        End Set
        Get
            Return Nama_
        End Get
    End Property

    Private Chat_ As String = "Halloo..."
    Public Property Chat As String
        Set(value As String)
            Chat_ = value
            lblChat.Text = Chat_
        End Set
        Get
            Return Chat_
        End Get
    End Property

    Private Tanggal_ As DateTime = DateTime.Now


    Public Property Tanggal As DateTime
        Set(value As DateTime)
            Tanggal_ = value
            lblTanggal.Text = Tanggal_.ToString("HH:mm")
        End Set
        Get
            Return Tanggal_
        End Get
    End Property

    Private Jumlah_ As Integer = 10
    Public Property Jumlah As Integer
        Set(value As Integer)
            Jumlah_ = value
            lblJumlah.Text = Jumlah_.ToString

            If Jumlah_ = 0 Then
                pbJumlah.Visible = False
            Else
                pbJumlah.Visible = True
            End If
        End Set
        Get
            Return Jumlah_
        End Get
    End Property
End Class
