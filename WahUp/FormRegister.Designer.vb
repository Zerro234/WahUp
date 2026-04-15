<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegister
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.txtNoHp = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNoHp = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.lblTitel = New System.Windows.Forms.Label()
        Me.txtUlangPassword = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblUlangPassword = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.pbProfile = New System.Windows.Forms.PictureBox()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRegister.Location = New System.Drawing.Point(51, 316)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(291, 30)
        Me.btnRegister.TabIndex = 4
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'txtNoHp
        '
        Me.txtNoHp.Location = New System.Drawing.Point(42, 170)
        Me.txtNoHp.Name = "txtNoHp"
        Me.txtNoHp.Size = New System.Drawing.Size(310, 23)
        Me.txtNoHp.TabIndex = 1
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(42, 116)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(310, 23)
        Me.txtNama.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(233, 449)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Kirim Ulang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(87, 449)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Belum dapat kode OTP ? "
        '
        'lblNoHp
        '
        Me.lblNoHp.AutoSize = True
        Me.lblNoHp.Location = New System.Drawing.Point(42, 151)
        Me.lblNoHp.Name = "lblNoHp"
        Me.lblNoHp.Size = New System.Drawing.Size(95, 16)
        Me.lblNoHp.TabIndex = 14
        Me.lblNoHp.Text = "No. Handphone"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(42, 97)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(41, 16)
        Me.lblNama.TabIndex = 13
        Me.lblNama.Text = "Nama"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(27, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(338, 1)
        Me.Panel1.TabIndex = 12
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.Location = New System.Drawing.Point(39, 45)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(184, 16)
        Me.lblNote.TabIndex = 11
        Me.lblNote.Text = "Isi data anda dengan lengkap !"
        '
        'lblTitel
        '
        Me.lblTitel.AutoSize = True
        Me.lblTitel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitel.Location = New System.Drawing.Point(38, 22)
        Me.lblTitel.Name = "lblTitel"
        Me.lblTitel.Size = New System.Drawing.Size(78, 19)
        Me.lblTitel.TabIndex = 10
        Me.lblTitel.Text = "Register"
        '
        'txtUlangPassword
        '
        Me.txtUlangPassword.Location = New System.Drawing.Point(41, 277)
        Me.txtUlangPassword.Name = "txtUlangPassword"
        Me.txtUlangPassword.Size = New System.Drawing.Size(310, 23)
        Me.txtUlangPassword.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(41, 223)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(310, 23)
        Me.txtPassword.TabIndex = 2
        '
        'lblUlangPassword
        '
        Me.lblUlangPassword.AutoSize = True
        Me.lblUlangPassword.Location = New System.Drawing.Point(41, 258)
        Me.lblUlangPassword.Name = "lblUlangPassword"
        Me.lblUlangPassword.Size = New System.Drawing.Size(99, 16)
        Me.lblUlangPassword.TabIndex = 21
        Me.lblUlangPassword.Text = "Ulang Password"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(41, 204)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(63, 16)
        Me.lblPassword.TabIndex = 20
        Me.lblPassword.Text = "Password"
        '
        'pbProfile
        '
        Me.pbProfile.Image = Global.WahUp.My.Resources.Resources.profile
        Me.pbProfile.Location = New System.Drawing.Point(285, 13)
        Me.pbProfile.Name = "pbProfile"
        Me.pbProfile.Size = New System.Drawing.Size(60, 60)
        Me.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbProfile.TabIndex = 22
        Me.pbProfile.TabStop = False
        '
        'FormRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(393, 486)
        Me.Controls.Add(Me.pbProfile)
        Me.Controls.Add(Me.txtUlangPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblUlangPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.txtNoHp)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblNoHp)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblNote)
        Me.Controls.Add(Me.lblTitel)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRegister As Button
    Friend WithEvents txtNoHp As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblNoHp As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblNote As Label
    Friend WithEvents lblTitel As Label
    Friend WithEvents txtUlangPassword As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblUlangPassword As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents pbProfile As PictureBox
End Class
