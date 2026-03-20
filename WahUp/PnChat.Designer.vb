<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PnChat
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblChat = New System.Windows.Forms.Label()
        Me.pnMain = New System.Windows.Forms.Panel()
        Me.pns = New System.Windows.Forms.Panel()
        Me.pn1 = New System.Windows.Forms.Panel()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.pn2 = New System.Windows.Forms.Panel()
        Me.pb2 = New System.Windows.Forms.PictureBox()
        Me.pn3 = New System.Windows.Forms.Panel()
        Me.pn31 = New System.Windows.Forms.Panel()
        Me.pb31 = New System.Windows.Forms.PictureBox()
        Me.pn32 = New System.Windows.Forms.Panel()
        Me.pb32 = New System.Windows.Forms.PictureBox()
        Me.pnMain.SuspendLayout()
        Me.pns.SuspendLayout()
        Me.pn1.SuspendLayout()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pn2.SuspendLayout()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pn3.SuspendLayout()
        Me.pn31.SuspendLayout()
        CType(Me.pb31, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pn32.SuspendLayout()
        CType(Me.pb32, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblChat
        '
        Me.lblChat.AutoSize = True
        Me.lblChat.BackColor = System.Drawing.Color.Transparent
        Me.lblChat.Location = New System.Drawing.Point(13, 10)
        Me.lblChat.MaximumSize = New System.Drawing.Size(300, 1000)
        Me.lblChat.Name = "lblChat"
        Me.lblChat.Padding = New System.Windows.Forms.Padding(5)
        Me.lblChat.Size = New System.Drawing.Size(30, 26)
        Me.lblChat.TabIndex = 0
        Me.lblChat.Text = "..."
        '
        'pnMain
        '
        Me.pnMain.AutoSize = True
        Me.pnMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnMain.Controls.Add(Me.pns)
        Me.pnMain.Controls.Add(Me.lblChat)
        Me.pnMain.Location = New System.Drawing.Point(13, 13)
        Me.pnMain.Name = "pnMain"
        Me.pnMain.Padding = New System.Windows.Forms.Padding(10)
        Me.pnMain.Size = New System.Drawing.Size(58, 48)
        Me.pnMain.TabIndex = 1
        '
        'pns
        '
        Me.pns.Controls.Add(Me.pn1)
        Me.pns.Controls.Add(Me.pn2)
        Me.pns.Controls.Add(Me.pn3)
        Me.pns.Location = New System.Drawing.Point(25, 19)
        Me.pns.Name = "pns"
        Me.pns.Size = New System.Drawing.Size(10, 10)
        Me.pns.TabIndex = 0
        Me.pns.Visible = False
        '
        'pn1
        '
        Me.pn1.Controls.Add(Me.pb1)
        Me.pn1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pn1.Location = New System.Drawing.Point(0, 0)
        Me.pn1.Name = "pn1"
        Me.pn1.Size = New System.Drawing.Size(0, 10)
        Me.pn1.TabIndex = 2
        '
        'pb1
        '
        Me.pb1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pb1.Location = New System.Drawing.Point(0, 0)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(0, 10)
        Me.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb1.TabIndex = 0
        Me.pb1.TabStop = False
        '
        'pn2
        '
        Me.pn2.Controls.Add(Me.pb2)
        Me.pn2.Dock = System.Windows.Forms.DockStyle.Right
        Me.pn2.Location = New System.Drawing.Point(-202, 0)
        Me.pn2.Name = "pn2"
        Me.pn2.Size = New System.Drawing.Size(106, 10)
        Me.pn2.TabIndex = 0
        '
        'pb2
        '
        Me.pb2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pb2.Location = New System.Drawing.Point(0, 0)
        Me.pb2.Name = "pb2"
        Me.pb2.Size = New System.Drawing.Size(106, 10)
        Me.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb2.TabIndex = 1
        Me.pb2.TabStop = False
        '
        'pn3
        '
        Me.pn3.Controls.Add(Me.pn31)
        Me.pn3.Controls.Add(Me.pn32)
        Me.pn3.Dock = System.Windows.Forms.DockStyle.Right
        Me.pn3.Location = New System.Drawing.Point(-96, 0)
        Me.pn3.Name = "pn3"
        Me.pn3.Size = New System.Drawing.Size(106, 10)
        Me.pn3.TabIndex = 1
        '
        'pn31
        '
        Me.pn31.Controls.Add(Me.pb31)
        Me.pn31.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pn31.Location = New System.Drawing.Point(0, 0)
        Me.pn31.Name = "pn31"
        Me.pn31.Size = New System.Drawing.Size(106, 0)
        Me.pn31.TabIndex = 0
        '
        'pb31
        '
        Me.pb31.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pb31.Location = New System.Drawing.Point(0, 0)
        Me.pb31.Name = "pb31"
        Me.pb31.Size = New System.Drawing.Size(106, 0)
        Me.pb31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb31.TabIndex = 1
        Me.pb31.TabStop = False
        '
        'pn32
        '
        Me.pn32.Controls.Add(Me.pb32)
        Me.pn32.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pn32.Location = New System.Drawing.Point(0, -82)
        Me.pn32.Name = "pn32"
        Me.pn32.Size = New System.Drawing.Size(106, 92)
        Me.pn32.TabIndex = 1
        '
        'pb32
        '
        Me.pb32.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pb32.Location = New System.Drawing.Point(0, 0)
        Me.pb32.Name = "pb32"
        Me.pb32.Size = New System.Drawing.Size(106, 92)
        Me.pb32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb32.TabIndex = 1
        Me.pb32.TabStop = False
        '
        'PnChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.pnMain)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "PnChat"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(398, 74)
        Me.pnMain.ResumeLayout(False)
        Me.pnMain.PerformLayout()
        Me.pns.ResumeLayout(False)
        Me.pn1.ResumeLayout(False)
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pn2.ResumeLayout(False)
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pn3.ResumeLayout(False)
        Me.pn31.ResumeLayout(False)
        CType(Me.pb31, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pn32.ResumeLayout(False)
        CType(Me.pb32, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblChat As Label
    Friend WithEvents pnMain As Panel
    Friend WithEvents pns As Panel
    Friend WithEvents pn1 As Panel
    Friend WithEvents pb1 As PictureBox
    Friend WithEvents pn2 As Panel
    Friend WithEvents pb2 As PictureBox
    Friend WithEvents pn3 As Panel
    Friend WithEvents pn31 As Panel
    Friend WithEvents pb31 As PictureBox
    Friend WithEvents pn32 As Panel
    Friend WithEvents pb32 As PictureBox
End Class
