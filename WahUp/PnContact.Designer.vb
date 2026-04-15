<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PnContact
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.pnName = New System.Windows.Forms.Panel()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblChat = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.pbJumlah = New System.Windows.Forms.PictureBox()
        Me.lblJumlah = New System.Windows.Forms.Label()
        Me.pbProfile = New System.Windows.Forms.PictureBox()
        Me.pnName.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pbJumlah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pbJumlah.SuspendLayout()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnName
        '
        Me.pnName.Controls.Add(Me.lblNama)
        Me.pnName.Controls.Add(Me.lblChat)
        Me.pnName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnName.Location = New System.Drawing.Point(55, 5)
        Me.pnName.Name = "pnName"
        Me.pnName.Size = New System.Drawing.Size(181, 50)
        Me.pnName.TabIndex = 1
        '
        'lblNama
        '
        Me.lblNama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNama.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.ForeColor = System.Drawing.Color.Black
        Me.lblNama.Location = New System.Drawing.Point(0, 0)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(181, 25)
        Me.lblNama.TabIndex = 0
        Me.lblNama.Text = "Fransiskus Juniarto"
        Me.lblNama.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblChat
        '
        Me.lblChat.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblChat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblChat.Location = New System.Drawing.Point(0, 25)
        Me.lblChat.Name = "lblChat"
        Me.lblChat.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.lblChat.Size = New System.Drawing.Size(181, 25)
        Me.lblChat.TabIndex = 1
        Me.lblChat.Text = "Halloo..."
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.pbJumlah)
        Me.Panel2.Controls.Add(Me.lblTanggal)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(236, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(90, 50)
        Me.Panel2.TabIndex = 2
        '
        'lblTanggal
        '
        Me.lblTanggal.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTanggal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTanggal.Location = New System.Drawing.Point(0, 0)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(90, 25)
        Me.lblTanggal.TabIndex = 0
        Me.lblTanggal.Text = "15:45"
        Me.lblTanggal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'pbJumlah
        '
        Me.pbJumlah.Controls.Add(Me.lblJumlah)
        Me.pbJumlah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbJumlah.Image = Global.WahUp.My.Resources.Resources.circle
        Me.pbJumlah.Location = New System.Drawing.Point(0, 25)
        Me.pbJumlah.Name = "pbJumlah"
        Me.pbJumlah.Size = New System.Drawing.Size(90, 25)
        Me.pbJumlah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbJumlah.TabIndex = 1
        Me.pbJumlah.TabStop = False
        Me.pbJumlah.Visible = False
        '
        'lblJumlah
        '
        Me.lblJumlah.BackColor = System.Drawing.Color.Transparent
        Me.lblJumlah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblJumlah.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlah.ForeColor = System.Drawing.Color.White
        Me.lblJumlah.Location = New System.Drawing.Point(0, 0)
        Me.lblJumlah.Name = "lblJumlah"
        Me.lblJumlah.Size = New System.Drawing.Size(90, 25)
        Me.lblJumlah.TabIndex = 3
        Me.lblJumlah.Text = "0"
        Me.lblJumlah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbProfile
        '
        Me.pbProfile.Dock = System.Windows.Forms.DockStyle.Left
        Me.pbProfile.Image = Global.WahUp.My.Resources.Resources.profile
        Me.pbProfile.Location = New System.Drawing.Point(5, 5)
        Me.pbProfile.Name = "pbProfile"
        Me.pbProfile.Size = New System.Drawing.Size(50, 50)
        Me.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbProfile.TabIndex = 0
        Me.pbProfile.TabStop = False
        '
        'PnContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnName)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pbProfile)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "PnContact"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(331, 60)
        Me.pnName.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.pbJumlah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pbJumlah.ResumeLayout(False)
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbProfile As PictureBox
    Friend WithEvents pnName As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblNama As Label
    Friend WithEvents lblChat As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblJumlah As Label
    Friend WithEvents pbJumlah As PictureBox
End Class
