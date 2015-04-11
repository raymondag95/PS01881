<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmquanli
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
        Me.mnscongcu = New System.Windows.Forms.MenuStrip()
        Me.mnshethong = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnidangnhap = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnithoat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnschucnang = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniquanli = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnikhachhang = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnstrogiup = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnihuongdan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnigioithieu = New System.Windows.Forms.ToolStripMenuItem()
        Me.stsnoidung = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblhien1 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblhien2 = New System.Windows.Forms.Label()
        Me.ptb3 = New System.Windows.Forms.PictureBox()
        Me.ptb2 = New System.Windows.Forms.PictureBox()
        Me.ptb1 = New System.Windows.Forms.PictureBox()
        Me.mnscongcu.SuspendLayout()
        Me.stsnoidung.SuspendLayout()
        CType(Me.ptb3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnscongcu
        '
        Me.mnscongcu.AutoSize = False
        Me.mnscongcu.BackColor = System.Drawing.Color.LightSkyBlue
        Me.mnscongcu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnshethong, Me.mnschucnang, Me.mnstrogiup})
        Me.mnscongcu.Location = New System.Drawing.Point(0, 0)
        Me.mnscongcu.Name = "mnscongcu"
        Me.mnscongcu.Size = New System.Drawing.Size(579, 30)
        Me.mnscongcu.TabIndex = 2
        Me.mnscongcu.Text = "MenuStrip1"
        '
        'mnshethong
        '
        Me.mnshethong.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnidangnhap, Me.mnithoat})
        Me.mnshethong.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.mnshethong.Name = "mnshethong"
        Me.mnshethong.Size = New System.Drawing.Size(73, 26)
        Me.mnshethong.Text = "Hệ Thống"
        '
        'mnidangnhap
        '
        Me.mnidangnhap.Image = Global.longthps01881_ASS_BC.My.Resources.Resources.User
        Me.mnidangnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnidangnhap.Name = "mnidangnhap"
        Me.mnidangnhap.Size = New System.Drawing.Size(132, 22)
        Me.mnidangnhap.Text = "Đăng Xuất"
        '
        'mnithoat
        '
        Me.mnithoat.Image = Global.longthps01881_ASS_BC.My.Resources.Resources.Log_out
        Me.mnithoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnithoat.Name = "mnithoat"
        Me.mnithoat.Size = New System.Drawing.Size(132, 22)
        Me.mnithoat.Text = "Thoát"
        '
        'mnschucnang
        '
        Me.mnschucnang.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniquanli, Me.mnikhachhang})
        Me.mnschucnang.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.mnschucnang.Name = "mnschucnang"
        Me.mnschucnang.Size = New System.Drawing.Size(79, 26)
        Me.mnschucnang.Text = "Chức Năng"
        '
        'mniquanli
        '
        Me.mniquanli.Image = Global.longthps01881_ASS_BC.My.Resources.Resources.Clien_list
        Me.mniquanli.Name = "mniquanli"
        Me.mniquanli.Size = New System.Drawing.Size(140, 22)
        Me.mniquanli.Text = "Quản Lí"
        '
        'mnikhachhang
        '
        Me.mnikhachhang.Image = Global.longthps01881_ASS_BC.My.Resources.Resources.Users
        Me.mnikhachhang.Name = "mnikhachhang"
        Me.mnikhachhang.Size = New System.Drawing.Size(140, 22)
        Me.mnikhachhang.Text = "Khách Hàng"
        '
        'mnstrogiup
        '
        Me.mnstrogiup.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnihuongdan, Me.mnigioithieu})
        Me.mnstrogiup.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.mnstrogiup.Name = "mnstrogiup"
        Me.mnstrogiup.Size = New System.Drawing.Size(68, 26)
        Me.mnstrogiup.Text = "Trợ Giúp"
        '
        'mnihuongdan
        '
        Me.mnihuongdan.Image = Global.longthps01881_ASS_BC.My.Resources.Resources.Add_to_basket
        Me.mnihuongdan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnihuongdan.Name = "mnihuongdan"
        Me.mnihuongdan.Size = New System.Drawing.Size(131, 22)
        Me.mnihuongdan.Text = "Update"
        '
        'mnigioithieu
        '
        Me.mnigioithieu.Image = Global.longthps01881_ASS_BC.My.Resources.Resources.Properties
        Me.mnigioithieu.Name = "mnigioithieu"
        Me.mnigioithieu.Size = New System.Drawing.Size(131, 22)
        Me.mnigioithieu.Text = "Giới Thiệu"
        '
        'stsnoidung
        '
        Me.stsnoidung.BackColor = System.Drawing.Color.LightSkyBlue
        Me.stsnoidung.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.stsnoidung.Location = New System.Drawing.Point(0, 324)
        Me.stsnoidung.Name = "stsnoidung"
        Me.stsnoidung.Size = New System.Drawing.Size(579, 22)
        Me.stsnoidung.TabIndex = 7
        Me.stsnoidung.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ToolStripStatusLabel1.Image = Global.longthps01881_ASS_BC.My.Resources.Resources.Database
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(379, 17)
        Me.ToolStripStatusLabel1.Text = "Copyright © 2014 LongTran-PS01881 Corp. All Rights Reserved"
        '
        'lblhien1
        '
        Me.lblhien1.AutoSize = True
        Me.lblhien1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhien1.ForeColor = System.Drawing.Color.Firebrick
        Me.lblhien1.Location = New System.Drawing.Point(117, 59)
        Me.lblhien1.Name = "lblhien1"
        Me.lblhien1.Size = New System.Drawing.Size(337, 21)
        Me.lblhien1.TabIndex = 13
        Me.lblhien1.Text = "CHƯƠNG TRÌNH QUẢN LÍ VÀ TÌM KIẾM ĐĨA"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbl1.Location = New System.Drawing.Point(57, 248)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(53, 13)
        Me.lbl1.TabIndex = 14
        Me.lbl1.Text = "Quản Lí"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(256, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Khách Hàng"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(462, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Thông Tin"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblhien2
        '
        Me.lblhien2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblhien2.Location = New System.Drawing.Point(438, 30)
        Me.lblhien2.Name = "lblhien2"
        Me.lblhien2.Size = New System.Drawing.Size(141, 20)
        Me.lblhien2.TabIndex = 17
        Me.lblhien2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ptb3
        '
        Me.ptb3.Image = Global.longthps01881_ASS_BC.My.Resources.Resources.about_logo_lock_
        Me.ptb3.Location = New System.Drawing.Point(419, 106)
        Me.ptb3.Name = "ptb3"
        Me.ptb3.Size = New System.Drawing.Size(148, 139)
        Me.ptb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb3.TabIndex = 12
        Me.ptb3.TabStop = False
        '
        'ptb2
        '
        Me.ptb2.Image = Global.longthps01881_ASS_BC.My.Resources.Resources.research_star
        Me.ptb2.Location = New System.Drawing.Point(218, 106)
        Me.ptb2.Name = "ptb2"
        Me.ptb2.Size = New System.Drawing.Size(148, 139)
        Me.ptb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb2.TabIndex = 11
        Me.ptb2.TabStop = False
        '
        'ptb1
        '
        Me.ptb1.Image = Global.longthps01881_ASS_BC.My.Resources.Resources.user_student_assistant
        Me.ptb1.Location = New System.Drawing.Point(12, 106)
        Me.ptb1.Name = "ptb1"
        Me.ptb1.Size = New System.Drawing.Size(148, 139)
        Me.ptb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb1.TabIndex = 10
        Me.ptb1.TabStop = False
        '
        'frmquanli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(579, 346)
        Me.Controls.Add(Me.lblhien2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.lblhien1)
        Me.Controls.Add(Me.ptb3)
        Me.Controls.Add(Me.ptb2)
        Me.Controls.Add(Me.ptb1)
        Me.Controls.Add(Me.stsnoidung)
        Me.Controls.Add(Me.mnscongcu)
        Me.Name = "frmquanli"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lí"
        Me.mnscongcu.ResumeLayout(False)
        Me.mnscongcu.PerformLayout()
        Me.stsnoidung.ResumeLayout(False)
        Me.stsnoidung.PerformLayout()
        CType(Me.ptb3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnscongcu As System.Windows.Forms.MenuStrip
    Friend WithEvents mnshethong As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnidangnhap As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnithoat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnschucnang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnstrogiup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnihuongdan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnigioithieu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents stsnoidung As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ptb1 As System.Windows.Forms.PictureBox
    Friend WithEvents ptb2 As System.Windows.Forms.PictureBox
    Friend WithEvents ptb3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblhien1 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblhien2 As System.Windows.Forms.Label
    Friend WithEvents mniquanli As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnikhachhang As System.Windows.Forms.ToolStripMenuItem
End Class
