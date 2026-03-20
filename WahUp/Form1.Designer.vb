<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.pnChats = New System.Windows.Forms.Panel()
        Me.pnLine1 = New System.Windows.Forms.Panel()
        Me.pnFooter2 = New System.Windows.Forms.Panel()
        Me.txtChat = New System.Windows.Forms.TextBox()
        Me.btnStikers = New System.Windows.Forms.PictureBox()
        Me.btnSearch = New System.Windows.Forms.PictureBox()
        Me.btnSend1 = New System.Windows.Forms.Button()
        Me.btnSend2 = New System.Windows.Forms.Button()
        Me.pnFooter1 = New System.Windows.Forms.Panel()
        Me.pnImages = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnFooter2.SuspendLayout()
        CType(Me.btnStikers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnFooter1.SuspendLayout()
        CType(Me.btnClear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnChats
        '
        Me.pnChats.AutoScroll = True
        Me.pnChats.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnChats.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnChats.Location = New System.Drawing.Point(5, 5)
        Me.pnChats.Name = "pnChats"
        Me.pnChats.Size = New System.Drawing.Size(558, 682)
        Me.pnChats.TabIndex = 0
        '
        'pnLine1
        '
        Me.pnLine1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnLine1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnLine1.Location = New System.Drawing.Point(5, 687)
        Me.pnLine1.Name = "pnLine1"
        Me.pnLine1.Size = New System.Drawing.Size(558, 1)
        Me.pnLine1.TabIndex = 1
        '
        'pnFooter2
        '
        Me.pnFooter2.Controls.Add(Me.txtChat)
        Me.pnFooter2.Controls.Add(Me.btnStikers)
        Me.pnFooter2.Controls.Add(Me.btnSearch)
        Me.pnFooter2.Controls.Add(Me.btnSend1)
        Me.pnFooter2.Controls.Add(Me.btnSend2)
        Me.pnFooter2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnFooter2.Location = New System.Drawing.Point(5, 748)
        Me.pnFooter2.Name = "pnFooter2"
        Me.pnFooter2.Padding = New System.Windows.Forms.Padding(5)
        Me.pnFooter2.Size = New System.Drawing.Size(558, 100)
        Me.pnFooter2.TabIndex = 2
        '
        'txtChat
        '
        Me.txtChat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtChat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtChat.Location = New System.Drawing.Point(5, 5)
        Me.txtChat.Multiline = True
        Me.txtChat.Name = "txtChat"
        Me.txtChat.Size = New System.Drawing.Size(372, 90)
        Me.txtChat.TabIndex = 0
        '
        'btnStikers
        '
        Me.btnStikers.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnStikers.Image = Global.WahUp.My.Resources.Resources.sticker
        Me.btnStikers.Location = New System.Drawing.Point(377, 5)
        Me.btnStikers.Name = "btnStikers"
        Me.btnStikers.Size = New System.Drawing.Size(40, 90)
        Me.btnStikers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnStikers.TabIndex = 4
        Me.btnStikers.TabStop = False
        '
        'btnSearch
        '
        Me.btnSearch.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSearch.Image = Global.WahUp.My.Resources.Resources.image_gallery
        Me.btnSearch.Location = New System.Drawing.Point(417, 5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(40, 90)
        Me.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.TabStop = False
        '
        'btnSend1
        '
        Me.btnSend1.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSend1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSend1.Location = New System.Drawing.Point(457, 5)
        Me.btnSend1.Name = "btnSend1"
        Me.btnSend1.Size = New System.Drawing.Size(47, 90)
        Me.btnSend1.TabIndex = 2
        Me.btnSend1.Text = "Send (1)"
        Me.btnSend1.UseVisualStyleBackColor = True
        '
        'btnSend2
        '
        Me.btnSend2.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSend2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSend2.Location = New System.Drawing.Point(504, 5)
        Me.btnSend2.Name = "btnSend2"
        Me.btnSend2.Size = New System.Drawing.Size(49, 90)
        Me.btnSend2.TabIndex = 1
        Me.btnSend2.Text = "Send (2)"
        Me.btnSend2.UseVisualStyleBackColor = True
        '
        'pnFooter1
        '
        Me.pnFooter1.BackColor = System.Drawing.Color.Transparent
        Me.pnFooter1.Controls.Add(Me.pnImages)
        Me.pnFooter1.Controls.Add(Me.btnClear)
        Me.pnFooter1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnFooter1.Location = New System.Drawing.Point(5, 688)
        Me.pnFooter1.Name = "pnFooter1"
        Me.pnFooter1.Size = New System.Drawing.Size(558, 60)
        Me.pnFooter1.TabIndex = 3
        Me.pnFooter1.Visible = False
        '
        'pnImages
        '
        Me.pnImages.AutoScroll = True
        Me.pnImages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnImages.Location = New System.Drawing.Point(0, 0)
        Me.pnImages.Name = "pnImages"
        Me.pnImages.Size = New System.Drawing.Size(539, 60)
        Me.pnImages.TabIndex = 1
        '
        'btnClear
        '
        Me.btnClear.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClear.Image = Global.WahUp.My.Resources.Resources.clear
        Me.btnClear.Location = New System.Drawing.Point(539, 0)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(19, 60)
        Me.btnClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClear.TabIndex = 0
        Me.btnClear.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(5, 848)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(558, 59)
        Me.Panel1.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(568, 912)
        Me.Controls.Add(Me.pnChats)
        Me.Controls.Add(Me.pnLine1)
        Me.Controls.Add(Me.pnFooter1)
        Me.Controls.Add(Me.pnFooter2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnFooter2.ResumeLayout(False)
        Me.pnFooter2.PerformLayout()
        CType(Me.btnStikers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnFooter1.ResumeLayout(False)
        CType(Me.btnClear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnChats As Panel
    Friend WithEvents pnLine1 As Panel
    Friend WithEvents pnFooter2 As Panel
    Friend WithEvents btnSend1 As Button
    Friend WithEvents btnSend2 As Button
    Friend WithEvents txtChat As TextBox
    Friend WithEvents pnFooter1 As Panel
    Friend WithEvents btnSearch As PictureBox
    Friend WithEvents btnClear As PictureBox
    Friend WithEvents pnImages As Panel
    Friend WithEvents btnStikers As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
