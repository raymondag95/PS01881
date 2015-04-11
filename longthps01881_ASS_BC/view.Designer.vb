<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmview
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
        Me.grbSanpham = New System.Windows.Forms.GroupBox()
        Me.lbldictype = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbldiscs = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblcata = New System.Windows.Forms.Label()
        Me.lblHinhsp = New System.Windows.Forms.Label()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.lblSoluongcon = New System.Windows.Forms.Label()
        Me.lblsalePrice = New System.Windows.Forms.Label()
        Me.lblGiaban = New System.Windows.Forms.Label()
        Me.lblproduc = New System.Windows.Forms.Label()
        Me.lblHangsx = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblcataID = New System.Windows.Forms.Label()
        Me.lblNameDV = New System.Windows.Forms.Label()
        Me.ptbHinh = New System.Windows.Forms.PictureBox()
        Me.lblsothutu = New System.Windows.Forms.Label()
        Me.btnxuongcuoi = New System.Windows.Forms.Button()
        Me.btnquaylaidau = New System.Windows.Forms.Button()
        Me.btntoi = New System.Windows.Forms.Button()
        Me.btnlui = New System.Windows.Forms.Button()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.grbDanhsach = New System.Windows.Forms.GroupBox()
        Me.lsvdanhsach = New System.Windows.Forms.ListView()
        Me.lsvcolCatalog = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lsvcolName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lsvcolProduction = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lsvcolSale = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lsvcolDiscs = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lsvcolHinhanh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lsvcolDicsType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lsvcolstatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnmuahang = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ptb1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grbSanpham.SuspendLayout()
        CType(Me.ptbHinh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDanhsach.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbSanpham
        '
        Me.grbSanpham.BackColor = System.Drawing.Color.PapayaWhip
        Me.grbSanpham.Controls.Add(Me.lbldictype)
        Me.grbSanpham.Controls.Add(Me.Label5)
        Me.grbSanpham.Controls.Add(Me.lbldiscs)
        Me.grbSanpham.Controls.Add(Me.Label3)
        Me.grbSanpham.Controls.Add(Me.lblcata)
        Me.grbSanpham.Controls.Add(Me.lblHinhsp)
        Me.grbSanpham.Controls.Add(Me.lblstatus)
        Me.grbSanpham.Controls.Add(Me.lblSoluongcon)
        Me.grbSanpham.Controls.Add(Me.lblsalePrice)
        Me.grbSanpham.Controls.Add(Me.lblGiaban)
        Me.grbSanpham.Controls.Add(Me.lblproduc)
        Me.grbSanpham.Controls.Add(Me.lblHangsx)
        Me.grbSanpham.Controls.Add(Me.lblname)
        Me.grbSanpham.Controls.Add(Me.lblcataID)
        Me.grbSanpham.Controls.Add(Me.lblNameDV)
        Me.grbSanpham.Controls.Add(Me.ptbHinh)
        Me.grbSanpham.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.grbSanpham.Location = New System.Drawing.Point(12, 11)
        Me.grbSanpham.Name = "grbSanpham"
        Me.grbSanpham.Size = New System.Drawing.Size(301, 434)
        Me.grbSanpham.TabIndex = 5
        Me.grbSanpham.TabStop = False
        Me.grbSanpham.Text = "View Infor"
        '
        'lbldictype
        '
        Me.lbldictype.BackColor = System.Drawing.Color.GhostWhite
        Me.lbldictype.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldictype.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbldictype.Location = New System.Drawing.Point(111, 226)
        Me.lbldictype.Name = "lbldictype"
        Me.lbldictype.Size = New System.Drawing.Size(178, 25)
        Me.lbldictype.TabIndex = 25
        Me.lbldictype.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 17)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Discs type:"
        '
        'lbldiscs
        '
        Me.lbldiscs.BackColor = System.Drawing.Color.GhostWhite
        Me.lbldiscs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldiscs.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbldiscs.Location = New System.Drawing.Point(111, 158)
        Me.lbldiscs.Name = "lbldiscs"
        Me.lbldiscs.Size = New System.Drawing.Size(178, 25)
        Me.lbldiscs.TabIndex = 23
        Me.lbldiscs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 17)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Discs:"
        '
        'lblcata
        '
        Me.lblcata.BackColor = System.Drawing.Color.GhostWhite
        Me.lblcata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcata.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblcata.Location = New System.Drawing.Point(111, 24)
        Me.lblcata.Name = "lblcata"
        Me.lblcata.Size = New System.Drawing.Size(178, 25)
        Me.lblcata.TabIndex = 21
        Me.lblcata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHinhsp
        '
        Me.lblHinhsp.AutoSize = True
        Me.lblHinhsp.Location = New System.Drawing.Point(16, 264)
        Me.lblHinhsp.Name = "lblHinhsp"
        Me.lblHinhsp.Size = New System.Drawing.Size(50, 17)
        Me.lblHinhsp.TabIndex = 12
        Me.lblHinhsp.Text = "Image:"
        '
        'lblstatus
        '
        Me.lblstatus.BackColor = System.Drawing.Color.GhostWhite
        Me.lblstatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblstatus.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblstatus.Location = New System.Drawing.Point(111, 193)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(178, 25)
        Me.lblstatus.TabIndex = 11
        Me.lblstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSoluongcon
        '
        Me.lblSoluongcon.AutoSize = True
        Me.lblSoluongcon.Location = New System.Drawing.Point(16, 197)
        Me.lblSoluongcon.Name = "lblSoluongcon"
        Me.lblSoluongcon.Size = New System.Drawing.Size(54, 17)
        Me.lblSoluongcon.TabIndex = 10
        Me.lblSoluongcon.Text = "Status: "
        '
        'lblsalePrice
        '
        Me.lblsalePrice.BackColor = System.Drawing.Color.GhostWhite
        Me.lblsalePrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblsalePrice.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblsalePrice.Location = New System.Drawing.Point(111, 124)
        Me.lblsalePrice.Name = "lblsalePrice"
        Me.lblsalePrice.Size = New System.Drawing.Size(178, 25)
        Me.lblsalePrice.TabIndex = 9
        Me.lblsalePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGiaban
        '
        Me.lblGiaban.AutoSize = True
        Me.lblGiaban.Location = New System.Drawing.Point(16, 128)
        Me.lblGiaban.Name = "lblGiaban"
        Me.lblGiaban.Size = New System.Drawing.Size(71, 17)
        Me.lblGiaban.TabIndex = 8
        Me.lblGiaban.Text = "Sale Price:"
        '
        'lblproduc
        '
        Me.lblproduc.BackColor = System.Drawing.Color.GhostWhite
        Me.lblproduc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblproduc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblproduc.Location = New System.Drawing.Point(111, 91)
        Me.lblproduc.Name = "lblproduc"
        Me.lblproduc.Size = New System.Drawing.Size(178, 25)
        Me.lblproduc.TabIndex = 7
        Me.lblproduc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHangsx
        '
        Me.lblHangsx.AutoSize = True
        Me.lblHangsx.Location = New System.Drawing.Point(16, 95)
        Me.lblHangsx.Name = "lblHangsx"
        Me.lblHangsx.Size = New System.Drawing.Size(80, 17)
        Me.lblHangsx.TabIndex = 6
        Me.lblHangsx.Text = "Production:"
        '
        'lblname
        '
        Me.lblname.BackColor = System.Drawing.Color.GhostWhite
        Me.lblname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblname.Location = New System.Drawing.Point(111, 58)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(178, 25)
        Me.lblname.TabIndex = 5
        Me.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblcataID
        '
        Me.lblcataID.AutoSize = True
        Me.lblcataID.Location = New System.Drawing.Point(16, 28)
        Me.lblcataID.Name = "lblcataID"
        Me.lblcataID.Size = New System.Drawing.Size(77, 17)
        Me.lblcataID.TabIndex = 4
        Me.lblcataID.Text = "Catalog ID:"
        '
        'lblNameDV
        '
        Me.lblNameDV.AutoSize = True
        Me.lblNameDV.Location = New System.Drawing.Point(16, 62)
        Me.lblNameDV.Name = "lblNameDV"
        Me.lblNameDV.Size = New System.Drawing.Size(81, 17)
        Me.lblNameDV.TabIndex = 1
        Me.lblNameDV.Text = "Name DVD:"
        '
        'ptbHinh
        '
        Me.ptbHinh.BackColor = System.Drawing.Color.GhostWhite
        Me.ptbHinh.Location = New System.Drawing.Point(19, 284)
        Me.ptbHinh.Name = "ptbHinh"
        Me.ptbHinh.Size = New System.Drawing.Size(270, 144)
        Me.ptbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbHinh.TabIndex = 3
        Me.ptbHinh.TabStop = False
        '
        'lblsothutu
        '
        Me.lblsothutu.BackColor = System.Drawing.Color.GhostWhite
        Me.lblsothutu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblsothutu.Location = New System.Drawing.Point(407, 233)
        Me.lblsothutu.Name = "lblsothutu"
        Me.lblsothutu.Size = New System.Drawing.Size(40, 25)
        Me.lblsothutu.TabIndex = 20
        Me.lblsothutu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnxuongcuoi
        '
        Me.btnxuongcuoi.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnxuongcuoi.Location = New System.Drawing.Point(491, 233)
        Me.btnxuongcuoi.Name = "btnxuongcuoi"
        Me.btnxuongcuoi.Size = New System.Drawing.Size(35, 27)
        Me.btnxuongcuoi.TabIndex = 19
        Me.btnxuongcuoi.Text = ">|"
        Me.btnxuongcuoi.UseVisualStyleBackColor = True
        '
        'btnquaylaidau
        '
        Me.btnquaylaidau.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnquaylaidau.Location = New System.Drawing.Point(325, 231)
        Me.btnquaylaidau.Name = "btnquaylaidau"
        Me.btnquaylaidau.Size = New System.Drawing.Size(35, 27)
        Me.btnquaylaidau.TabIndex = 18
        Me.btnquaylaidau.Text = "|<"
        Me.btnquaylaidau.UseVisualStyleBackColor = True
        '
        'btntoi
        '
        Me.btntoi.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btntoi.Location = New System.Drawing.Point(453, 233)
        Me.btntoi.Name = "btntoi"
        Me.btntoi.Size = New System.Drawing.Size(35, 27)
        Me.btntoi.TabIndex = 16
        Me.btntoi.Text = ">"
        Me.btntoi.UseVisualStyleBackColor = True
        '
        'btnlui
        '
        Me.btnlui.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnlui.Location = New System.Drawing.Point(366, 231)
        Me.btnlui.Name = "btnlui"
        Me.btnlui.Size = New System.Drawing.Size(35, 27)
        Me.btnlui.TabIndex = 15
        Me.btnlui.Text = "<"
        Me.btnlui.UseVisualStyleBackColor = True
        '
        'btnDong
        '
        Me.btnDong.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnDong.Image = Global.longthps01881_ASS_BC.My.Resources.Resources._Exit
        Me.btnDong.Location = New System.Drawing.Point(752, 231)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(68, 36)
        Me.btnDong.TabIndex = 13
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'grbDanhsach
        '
        Me.grbDanhsach.BackColor = System.Drawing.Color.PapayaWhip
        Me.grbDanhsach.Controls.Add(Me.lsvdanhsach)
        Me.grbDanhsach.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.grbDanhsach.Location = New System.Drawing.Point(319, 12)
        Me.grbDanhsach.Name = "grbDanhsach"
        Me.grbDanhsach.Size = New System.Drawing.Size(507, 209)
        Me.grbDanhsach.TabIndex = 6
        Me.grbDanhsach.TabStop = False
        Me.grbDanhsach.Text = "List infor"
        '
        'lsvdanhsach
        '
        Me.lsvdanhsach.BackColor = System.Drawing.Color.White
        Me.lsvdanhsach.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lsvcolCatalog, Me.lsvcolName, Me.lsvcolProduction, Me.lsvcolSale, Me.lsvcolDiscs, Me.lsvcolHinhanh, Me.lsvcolDicsType, Me.lsvcolstatus})
        Me.lsvdanhsach.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lsvdanhsach.ForeColor = System.Drawing.Color.Black
        Me.lsvdanhsach.FullRowSelect = True
        Me.lsvdanhsach.GridLines = True
        Me.lsvdanhsach.Location = New System.Drawing.Point(6, 17)
        Me.lsvdanhsach.MultiSelect = False
        Me.lsvdanhsach.Name = "lsvdanhsach"
        Me.lsvdanhsach.Size = New System.Drawing.Size(495, 186)
        Me.lsvdanhsach.TabIndex = 10
        Me.lsvdanhsach.UseCompatibleStateImageBehavior = False
        Me.lsvdanhsach.View = System.Windows.Forms.View.Details
        '
        'lsvcolCatalog
        '
        Me.lsvcolCatalog.Text = "Catalog ID"
        Me.lsvcolCatalog.Width = 78
        '
        'lsvcolName
        '
        Me.lsvcolName.Text = "Name DVD"
        Me.lsvcolName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lsvcolName.Width = 133
        '
        'lsvcolProduction
        '
        Me.lsvcolProduction.Text = "Production"
        Me.lsvcolProduction.Width = 82
        '
        'lsvcolSale
        '
        Me.lsvcolSale.Text = "Sale Price"
        Me.lsvcolSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lsvcolSale.Width = 85
        '
        'lsvcolDiscs
        '
        Me.lsvcolDiscs.Text = "Discs"
        Me.lsvcolDiscs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lsvcolDiscs.Width = 88
        '
        'lsvcolHinhanh
        '
        Me.lsvcolHinhanh.Text = "Hình ảnh"
        '
        'lsvcolDicsType
        '
        Me.lsvcolDicsType.Text = "Dics Type"
        Me.lsvcolDicsType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lsvcolDicsType.Width = 112
        '
        'lsvcolstatus
        '
        Me.lsvcolstatus.Text = "Status"
        '
        'btnmuahang
        '
        Me.btnmuahang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnmuahang.Image = Global.longthps01881_ASS_BC.My.Resources.Resources.Add_to_basket
        Me.btnmuahang.Location = New System.Drawing.Point(676, 231)
        Me.btnmuahang.Name = "btnmuahang"
        Me.btnmuahang.Size = New System.Drawing.Size(70, 36)
        Me.btnmuahang.TabIndex = 14
        Me.btnmuahang.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(755, 379)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "We Accept:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(322, 379)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Hợp Tác Và Phân Phối Băng Đĩa Gốc"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.longthps01881_ASS_BC.My.Resources.Resources.asia
        Me.PictureBox3.Location = New System.Drawing.Point(485, 397)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(74, 48)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 20
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.longthps01881_ASS_BC.My.Resources.Resources.thuy_nga_logo_1
        Me.PictureBox2.Location = New System.Drawing.Point(405, 397)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(74, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'ptb1
        '
        Me.ptb1.Image = Global.longthps01881_ASS_BC.My.Resources.Resources.vslogo
        Me.ptb1.Location = New System.Drawing.Point(325, 397)
        Me.ptb1.Name = "ptb1"
        Me.ptb1.Size = New System.Drawing.Size(74, 48)
        Me.ptb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb1.TabIndex = 17
        Me.ptb1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.longthps01881_ASS_BC.My.Resources.Resources.icon_creditcard
        Me.PictureBox1.Location = New System.Drawing.Point(752, 397)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 48)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'frmview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(838, 457)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btnquaylaidau)
        Me.Controls.Add(Me.lblsothutu)
        Me.Controls.Add(Me.btnlui)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnxuongcuoi)
        Me.Controls.Add(Me.btntoi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ptb1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnmuahang)
        Me.Controls.Add(Me.grbDanhsach)
        Me.Controls.Add(Me.grbSanpham)
        Me.Controls.Add(Me.btnDong)
        Me.Name = "frmview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Xem Sản Phẩm"
        Me.grbSanpham.ResumeLayout(False)
        Me.grbSanpham.PerformLayout()
        CType(Me.ptbHinh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDanhsach.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grbSanpham As System.Windows.Forms.GroupBox
    Friend WithEvents lblcata As System.Windows.Forms.Label
    Friend WithEvents lblsothutu As System.Windows.Forms.Label
    Friend WithEvents btnxuongcuoi As System.Windows.Forms.Button
    Friend WithEvents btnquaylaidau As System.Windows.Forms.Button
    Friend WithEvents btntoi As System.Windows.Forms.Button
    Friend WithEvents btnlui As System.Windows.Forms.Button
    Friend WithEvents btnDong As System.Windows.Forms.Button
    Friend WithEvents lblHinhsp As System.Windows.Forms.Label
    Friend WithEvents lblstatus As System.Windows.Forms.Label
    Friend WithEvents lblSoluongcon As System.Windows.Forms.Label
    Friend WithEvents lblsalePrice As System.Windows.Forms.Label
    Friend WithEvents lblGiaban As System.Windows.Forms.Label
    Friend WithEvents lblproduc As System.Windows.Forms.Label
    Friend WithEvents lblHangsx As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents lblcataID As System.Windows.Forms.Label
    Friend WithEvents lblNameDV As System.Windows.Forms.Label
    Friend WithEvents ptbHinh As System.Windows.Forms.PictureBox
    Friend WithEvents grbDanhsach As System.Windows.Forms.GroupBox
    Friend WithEvents lsvdanhsach As System.Windows.Forms.ListView
    Friend WithEvents lsvcolCatalog As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvcolName As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvcolSale As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvcolDiscs As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvcolDicsType As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnmuahang As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ptb1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents lsvcolHinhanh As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbldiscs As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lsvcolProduction As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbldictype As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lsvcolstatus As System.Windows.Forms.ColumnHeader
End Class
