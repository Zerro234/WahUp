<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.pnChats = New System.Windows.Forms.Panel()
        Me.pnLine1 = New System.Windows.Forms.Panel()
        Me.pnFooter2 = New System.Windows.Forms.Panel()
        Me.txtChat = New System.Windows.Forms.TextBox()
        Me.pnPbGif = New System.Windows.Forms.Panel()
        Me.btnGif = New System.Windows.Forms.PictureBox()
        Me.pnPbStiker = New System.Windows.Forms.Panel()
        Me.btnStikers = New System.Windows.Forms.PictureBox()
        Me.pnPbPicture = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.PictureBox()
        Me.pnPbSend1 = New System.Windows.Forms.Panel()
        Me.btnSend = New System.Windows.Forms.PictureBox()
        Me.pnPbSend2 = New System.Windows.Forms.Panel()
        Me.btnSand2 = New System.Windows.Forms.PictureBox()
        Me.pnFooter1 = New System.Windows.Forms.Panel()
        Me.pnImages = New System.Windows.Forms.Panel()
        Me.btnClear1 = New System.Windows.Forms.PictureBox()
        Me.pnFooter3 = New System.Windows.Forms.Panel()
        Me.pnStiker = New System.Windows.Forms.Panel()
        Me.btnClear3 = New System.Windows.Forms.PictureBox()
        Me.pnFooter4 = New System.Windows.Forms.Panel()
        Me.pnGif = New System.Windows.Forms.Panel()
        Me.btnClear4 = New System.Windows.Forms.PictureBox()
        Me.pnLine5 = New System.Windows.Forms.Panel()
        Me.pnLeft = New System.Windows.Forms.Panel()
        Me.pnContacts = New System.Windows.Forms.Panel()
        Me.pnLine4 = New System.Windows.Forms.Panel()
        Me.pnHeader1 = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnLine2 = New System.Windows.Forms.Panel()
        Me.pnMain = New System.Windows.Forms.Panel()
        Me.pnLine3 = New System.Windows.Forms.Panel()
        Me.pnHeader2 = New System.Windows.Forms.Panel()
        Me.PnContact2 = New WahUp.PnContact()
        Me.PnContact1 = New WahUp.PnContact()
        Me.pnFooter2.SuspendLayout()
        Me.pnPbGif.SuspendLayout()
        CType(Me.btnGif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnPbStiker.SuspendLayout()
        CType(Me.btnStikers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnPbPicture.SuspendLayout()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnPbSend1.SuspendLayout()
        CType(Me.btnSend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnPbSend2.SuspendLayout()
        CType(Me.btnSand2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnFooter1.SuspendLayout()
        CType(Me.btnClear1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnFooter3.SuspendLayout()
        CType(Me.btnClear3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnFooter4.SuspendLayout()
        CType(Me.btnClear4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnLeft.SuspendLayout()
        Me.pnContacts.SuspendLayout()
        Me.pnHeader1.SuspendLayout()
        Me.pnMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnChats
        '
        Me.pnChats.AutoScroll = True
        Me.pnChats.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnChats.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnChats.Location = New System.Drawing.Point(0, 71)
        Me.pnChats.Name = "pnChats"
        Me.pnChats.Size = New System.Drawing.Size(726, 444)
        Me.pnChats.TabIndex = 0
        '
        'pnLine1
        '
        Me.pnLine1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnLine1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnLine1.Location = New System.Drawing.Point(0, 515)
        Me.pnLine1.Name = "pnLine1"
        Me.pnLine1.Size = New System.Drawing.Size(726, 1)
        Me.pnLine1.TabIndex = 1
        '
        'pnFooter2
        '
        Me.pnFooter2.Controls.Add(Me.txtChat)
        Me.pnFooter2.Controls.Add(Me.pnPbGif)
        Me.pnFooter2.Controls.Add(Me.pnPbStiker)
        Me.pnFooter2.Controls.Add(Me.pnPbPicture)
        Me.pnFooter2.Controls.Add(Me.pnPbSend1)
        Me.pnFooter2.Controls.Add(Me.pnPbSend2)
        Me.pnFooter2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnFooter2.Location = New System.Drawing.Point(0, 576)
        Me.pnFooter2.Name = "pnFooter2"
        Me.pnFooter2.Padding = New System.Windows.Forms.Padding(5)
        Me.pnFooter2.Size = New System.Drawing.Size(726, 60)
        Me.pnFooter2.TabIndex = 2
        '
        'txtChat
        '
        Me.txtChat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtChat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtChat.Location = New System.Drawing.Point(5, 5)
        Me.txtChat.Multiline = True
        Me.txtChat.Name = "txtChat"
        Me.txtChat.Size = New System.Drawing.Size(551, 50)
        Me.txtChat.TabIndex = 0
        '
        'pnPbGif
        '
        Me.pnPbGif.Controls.Add(Me.btnGif)
        Me.pnPbGif.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnPbGif.Location = New System.Drawing.Point(556, 5)
        Me.pnPbGif.Name = "pnPbGif"
        Me.pnPbGif.Padding = New System.Windows.Forms.Padding(5)
        Me.pnPbGif.Size = New System.Drawing.Size(33, 50)
        Me.pnPbGif.TabIndex = 8
        '
        'btnGif
        '
        Me.btnGif.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnGif.Image = Global.WahUp.My.Resources.Resources.gif
        Me.btnGif.Location = New System.Drawing.Point(5, 5)
        Me.btnGif.Name = "btnGif"
        Me.btnGif.Padding = New System.Windows.Forms.Padding(2)
        Me.btnGif.Size = New System.Drawing.Size(23, 40)
        Me.btnGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnGif.TabIndex = 5
        Me.btnGif.TabStop = False
        '
        'pnPbStiker
        '
        Me.pnPbStiker.Controls.Add(Me.btnStikers)
        Me.pnPbStiker.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnPbStiker.Location = New System.Drawing.Point(589, 5)
        Me.pnPbStiker.Name = "pnPbStiker"
        Me.pnPbStiker.Padding = New System.Windows.Forms.Padding(5)
        Me.pnPbStiker.Size = New System.Drawing.Size(33, 50)
        Me.pnPbStiker.TabIndex = 9
        '
        'btnStikers
        '
        Me.btnStikers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnStikers.Image = Global.WahUp.My.Resources.Resources.sticker
        Me.btnStikers.Location = New System.Drawing.Point(5, 5)
        Me.btnStikers.Name = "btnStikers"
        Me.btnStikers.Size = New System.Drawing.Size(23, 40)
        Me.btnStikers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnStikers.TabIndex = 4
        Me.btnStikers.TabStop = False
        '
        'pnPbPicture
        '
        Me.pnPbPicture.Controls.Add(Me.btnSearch)
        Me.pnPbPicture.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnPbPicture.Location = New System.Drawing.Point(622, 5)
        Me.pnPbPicture.Name = "pnPbPicture"
        Me.pnPbPicture.Padding = New System.Windows.Forms.Padding(5)
        Me.pnPbPicture.Size = New System.Drawing.Size(33, 50)
        Me.pnPbPicture.TabIndex = 10
        '
        'btnSearch
        '
        Me.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSearch.Image = Global.WahUp.My.Resources.Resources.gallery
        Me.btnSearch.Location = New System.Drawing.Point(5, 5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(23, 40)
        Me.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.TabStop = False
        '
        'pnPbSend1
        '
        Me.pnPbSend1.Controls.Add(Me.btnSend)
        Me.pnPbSend1.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnPbSend1.Location = New System.Drawing.Point(655, 5)
        Me.pnPbSend1.Name = "pnPbSend1"
        Me.pnPbSend1.Padding = New System.Windows.Forms.Padding(5)
        Me.pnPbSend1.Size = New System.Drawing.Size(33, 50)
        Me.pnPbSend1.TabIndex = 11
        '
        'btnSend
        '
        Me.btnSend.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSend.Image = Global.WahUp.My.Resources.Resources.send
        Me.btnSend.Location = New System.Drawing.Point(5, 5)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(23, 40)
        Me.btnSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSend.TabIndex = 6
        Me.btnSend.TabStop = False
        '
        'pnPbSend2
        '
        Me.pnPbSend2.Controls.Add(Me.btnSand2)
        Me.pnPbSend2.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnPbSend2.Location = New System.Drawing.Point(688, 5)
        Me.pnPbSend2.Name = "pnPbSend2"
        Me.pnPbSend2.Padding = New System.Windows.Forms.Padding(5)
        Me.pnPbSend2.Size = New System.Drawing.Size(33, 50)
        Me.pnPbSend2.TabIndex = 12
        '
        'btnSand2
        '
        Me.btnSand2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSand2.Image = Global.WahUp.My.Resources.Resources.send
        Me.btnSand2.Location = New System.Drawing.Point(5, 5)
        Me.btnSand2.Name = "btnSand2"
        Me.btnSand2.Size = New System.Drawing.Size(23, 40)
        Me.btnSand2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSand2.TabIndex = 7
        Me.btnSand2.TabStop = False
        '
        'pnFooter1
        '
        Me.pnFooter1.BackColor = System.Drawing.Color.Transparent
        Me.pnFooter1.Controls.Add(Me.pnImages)
        Me.pnFooter1.Controls.Add(Me.btnClear1)
        Me.pnFooter1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnFooter1.Location = New System.Drawing.Point(0, 516)
        Me.pnFooter1.Name = "pnFooter1"
        Me.pnFooter1.Size = New System.Drawing.Size(726, 60)
        Me.pnFooter1.TabIndex = 3
        Me.pnFooter1.Visible = False
        '
        'pnImages
        '
        Me.pnImages.AutoScroll = True
        Me.pnImages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnImages.Location = New System.Drawing.Point(0, 0)
        Me.pnImages.Name = "pnImages"
        Me.pnImages.Size = New System.Drawing.Size(707, 60)
        Me.pnImages.TabIndex = 1
        '
        'btnClear1
        '
        Me.btnClear1.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClear1.Image = Global.WahUp.My.Resources.Resources.clear
        Me.btnClear1.Location = New System.Drawing.Point(707, 0)
        Me.btnClear1.Name = "btnClear1"
        Me.btnClear1.Size = New System.Drawing.Size(19, 60)
        Me.btnClear1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClear1.TabIndex = 0
        Me.btnClear1.TabStop = False
        '
        'pnFooter3
        '
        Me.pnFooter3.AutoScroll = True
        Me.pnFooter3.Controls.Add(Me.pnStiker)
        Me.pnFooter3.Controls.Add(Me.btnClear3)
        Me.pnFooter3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnFooter3.Location = New System.Drawing.Point(0, 636)
        Me.pnFooter3.Name = "pnFooter3"
        Me.pnFooter3.Size = New System.Drawing.Size(726, 60)
        Me.pnFooter3.TabIndex = 4
        Me.pnFooter3.Visible = False
        '
        'pnStiker
        '
        Me.pnStiker.AutoScroll = True
        Me.pnStiker.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnStiker.Location = New System.Drawing.Point(0, 0)
        Me.pnStiker.Name = "pnStiker"
        Me.pnStiker.Size = New System.Drawing.Size(707, 60)
        Me.pnStiker.TabIndex = 3
        '
        'btnClear3
        '
        Me.btnClear3.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClear3.Image = Global.WahUp.My.Resources.Resources.clear
        Me.btnClear3.Location = New System.Drawing.Point(707, 0)
        Me.btnClear3.Name = "btnClear3"
        Me.btnClear3.Size = New System.Drawing.Size(19, 60)
        Me.btnClear3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClear3.TabIndex = 2
        Me.btnClear3.TabStop = False
        '
        'pnFooter4
        '
        Me.pnFooter4.BackColor = System.Drawing.Color.Transparent
        Me.pnFooter4.Controls.Add(Me.pnGif)
        Me.pnFooter4.Controls.Add(Me.btnClear4)
        Me.pnFooter4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnFooter4.Location = New System.Drawing.Point(0, 696)
        Me.pnFooter4.Name = "pnFooter4"
        Me.pnFooter4.Size = New System.Drawing.Size(726, 60)
        Me.pnFooter4.TabIndex = 5
        Me.pnFooter4.Visible = False
        '
        'pnGif
        '
        Me.pnGif.AutoScroll = True
        Me.pnGif.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnGif.Location = New System.Drawing.Point(0, 0)
        Me.pnGif.Name = "pnGif"
        Me.pnGif.Size = New System.Drawing.Size(707, 60)
        Me.pnGif.TabIndex = 1
        '
        'btnClear4
        '
        Me.btnClear4.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClear4.Image = Global.WahUp.My.Resources.Resources.clear
        Me.btnClear4.Location = New System.Drawing.Point(707, 0)
        Me.btnClear4.Name = "btnClear4"
        Me.btnClear4.Size = New System.Drawing.Size(19, 60)
        Me.btnClear4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClear4.TabIndex = 0
        Me.btnClear4.TabStop = False
        '
        'pnLine5
        '
        Me.pnLine5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnLine5.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnLine5.Location = New System.Drawing.Point(5, 5)
        Me.pnLine5.Name = "pnLine5"
        Me.pnLine5.Size = New System.Drawing.Size(1041, 1)
        Me.pnLine5.TabIndex = 6
        '
        'pnLeft
        '
        Me.pnLeft.Controls.Add(Me.pnContacts)
        Me.pnLeft.Controls.Add(Me.pnLine4)
        Me.pnLeft.Controls.Add(Me.pnHeader1)
        Me.pnLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnLeft.Location = New System.Drawing.Point(5, 6)
        Me.pnLeft.Name = "pnLeft"
        Me.pnLeft.Size = New System.Drawing.Size(314, 756)
        Me.pnLeft.TabIndex = 7
        '
        'pnContacts
        '
        Me.pnContacts.AutoScroll = True
        Me.pnContacts.Controls.Add(Me.PnContact2)
        Me.pnContacts.Controls.Add(Me.PnContact1)
        Me.pnContacts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnContacts.Location = New System.Drawing.Point(0, 72)
        Me.pnContacts.Name = "pnContacts"
        Me.pnContacts.Size = New System.Drawing.Size(314, 684)
        Me.pnContacts.TabIndex = 2
        '
        'pnLine4
        '
        Me.pnLine4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnLine4.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnLine4.Location = New System.Drawing.Point(0, 71)
        Me.pnLine4.Name = "pnLine4"
        Me.pnLine4.Size = New System.Drawing.Size(314, 1)
        Me.pnLine4.TabIndex = 1
        '
        'pnHeader1
        '
        Me.pnHeader1.Controls.Add(Me.lblTitle)
        Me.pnHeader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnHeader1.Location = New System.Drawing.Point(0, 0)
        Me.pnHeader1.Name = "pnHeader1"
        Me.pnHeader1.Size = New System.Drawing.Size(314, 71)
        Me.pnHeader1.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(4, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(66, 27)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Chats"
        '
        'pnLine2
        '
        Me.pnLine2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnLine2.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnLine2.Location = New System.Drawing.Point(319, 6)
        Me.pnLine2.Name = "pnLine2"
        Me.pnLine2.Size = New System.Drawing.Size(1, 756)
        Me.pnLine2.TabIndex = 8
        '
        'pnMain
        '
        Me.pnMain.Controls.Add(Me.pnChats)
        Me.pnMain.Controls.Add(Me.pnLine3)
        Me.pnMain.Controls.Add(Me.pnHeader2)
        Me.pnMain.Controls.Add(Me.pnLine1)
        Me.pnMain.Controls.Add(Me.pnFooter1)
        Me.pnMain.Controls.Add(Me.pnFooter2)
        Me.pnMain.Controls.Add(Me.pnFooter3)
        Me.pnMain.Controls.Add(Me.pnFooter4)
        Me.pnMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnMain.Location = New System.Drawing.Point(320, 6)
        Me.pnMain.Name = "pnMain"
        Me.pnMain.Size = New System.Drawing.Size(726, 756)
        Me.pnMain.TabIndex = 9
        '
        'pnLine3
        '
        Me.pnLine3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnLine3.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnLine3.ForeColor = System.Drawing.SystemColors.Control
        Me.pnLine3.Location = New System.Drawing.Point(0, 70)
        Me.pnLine3.Name = "pnLine3"
        Me.pnLine3.Size = New System.Drawing.Size(726, 1)
        Me.pnLine3.TabIndex = 7
        '
        'pnHeader2
        '
        Me.pnHeader2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnHeader2.Location = New System.Drawing.Point(0, 0)
        Me.pnHeader2.Name = "pnHeader2"
        Me.pnHeader2.Padding = New System.Windows.Forms.Padding(10)
        Me.pnHeader2.Size = New System.Drawing.Size(726, 70)
        Me.pnHeader2.TabIndex = 6
        '
        'PnContact2
        '
        Me.PnContact2.Chat = "P Valo"
        Me.PnContact2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnContact2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnContact2.Jumlah = 10
        Me.PnContact2.Location = New System.Drawing.Point(0, 60)
        Me.PnContact2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PnContact2.Nama = "Fuled"
        Me.PnContact2.Name = "PnContact2"
        Me.PnContact2.Padding = New System.Windows.Forms.Padding(5)
        Me.PnContact2.Profile = CType(resources.GetObject("PnContact2.Profile"), System.Drawing.Image)
        Me.PnContact2.Size = New System.Drawing.Size(314, 60)
        Me.PnContact2.TabIndex = 1
        Me.PnContact2.Tanggal = New Date(2026, 4, 6, 0, 32, 1, 731)
        '
        'PnContact1
        '
        Me.PnContact1.Chat = "Halloo..."
        Me.PnContact1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnContact1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnContact1.ForeColor = System.Drawing.Color.White
        Me.PnContact1.Jumlah = 10
        Me.PnContact1.Location = New System.Drawing.Point(0, 0)
        Me.PnContact1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PnContact1.Nama = "Fransiskus Juniarto"
        Me.PnContact1.Name = "PnContact1"
        Me.PnContact1.Padding = New System.Windows.Forms.Padding(5)
        Me.PnContact1.Profile = CType(resources.GetObject("PnContact1.Profile"), System.Drawing.Image)
        Me.PnContact1.Size = New System.Drawing.Size(314, 60)
        Me.PnContact1.TabIndex = 0
        Me.PnContact1.Tanggal = New Date(2026, 4, 5, 23, 52, 53, 197)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1051, 767)
        Me.Controls.Add(Me.pnMain)
        Me.Controls.Add(Me.pnLine2)
        Me.Controls.Add(Me.pnLeft)
        Me.Controls.Add(Me.pnLine5)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnFooter2.ResumeLayout(False)
        Me.pnFooter2.PerformLayout()
        Me.pnPbGif.ResumeLayout(False)
        CType(Me.btnGif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnPbStiker.ResumeLayout(False)
        CType(Me.btnStikers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnPbPicture.ResumeLayout(False)
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnPbSend1.ResumeLayout(False)
        CType(Me.btnSend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnPbSend2.ResumeLayout(False)
        CType(Me.btnSand2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnFooter1.ResumeLayout(False)
        CType(Me.btnClear1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnFooter3.ResumeLayout(False)
        CType(Me.btnClear3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnFooter4.ResumeLayout(False)
        CType(Me.btnClear4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnLeft.ResumeLayout(False)
        Me.pnContacts.ResumeLayout(False)
        Me.pnHeader1.ResumeLayout(False)
        Me.pnHeader1.PerformLayout()
        Me.pnMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnChats As Panel
    Friend WithEvents pnLine1 As Panel
    Friend WithEvents pnFooter2 As Panel
    Friend WithEvents txtChat As TextBox
    Friend WithEvents pnFooter1 As Panel
    Friend WithEvents btnClear1 As PictureBox
    Friend WithEvents pnImages As Panel
    Friend WithEvents pnFooter3 As Panel
    Friend WithEvents pnStiker As Panel
    Friend WithEvents btnClear3 As PictureBox
    Friend WithEvents pnFooter4 As Panel
    Friend WithEvents pnGif As Panel
    Friend WithEvents btnClear4 As PictureBox
    Friend WithEvents pnLine5 As Panel
    Friend WithEvents pnLeft As Panel
    Friend WithEvents pnLine2 As Panel
    Friend WithEvents pnMain As Panel
    Friend WithEvents pnLine3 As Panel
    Friend WithEvents pnHeader2 As Panel
    Friend WithEvents pnHeader1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnSearch As PictureBox
    Friend WithEvents btnSand2 As PictureBox
    Friend WithEvents btnSend As PictureBox
    Friend WithEvents btnStikers As PictureBox
    Friend WithEvents pnPbSend1 As Panel
    Friend WithEvents pnPbPicture As Panel
    Friend WithEvents pnPbStiker As Panel
    Friend WithEvents pnPbGif As Panel
    Friend WithEvents btnGif As PictureBox
    Friend WithEvents pnPbSend2 As Panel
    Friend WithEvents pnLine4 As Panel
    Friend WithEvents pnContacts As Panel
    Friend WithEvents PnContact1 As PnContact
    Friend WithEvents PnContact2 As PnContact
End Class
