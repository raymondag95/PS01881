<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrice
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
        Me.grbNhaphang = New System.Windows.Forms.GroupBox()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnnhap3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblhien2 = New System.Windows.Forms.Label()
        Me.btnnhap2 = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.lblhien1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtnhap1 = New System.Windows.Forms.TextBox()
        Me.txtnhap2 = New System.Windows.Forms.TextBox()
        Me.grbNhaphang.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbNhaphang
        '
        Me.grbNhaphang.BackColor = System.Drawing.Color.PapayaWhip
        Me.grbNhaphang.Controls.Add(Me.txtnhap2)
        Me.grbNhaphang.Controls.Add(Me.txtnhap1)
        Me.grbNhaphang.Controls.Add(Me.btnThoat)
        Me.grbNhaphang.Controls.Add(Me.btnnhap3)
        Me.grbNhaphang.Controls.Add(Me.Button1)
        Me.grbNhaphang.Controls.Add(Me.lblhien2)
        Me.grbNhaphang.Controls.Add(Me.btnnhap2)
        Me.grbNhaphang.Controls.Add(Me.btnThem)
        Me.grbNhaphang.Controls.Add(Me.lblhien1)
        Me.grbNhaphang.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.grbNhaphang.Location = New System.Drawing.Point(1, 2)
        Me.grbNhaphang.Name = "grbNhaphang"
        Me.grbNhaphang.Size = New System.Drawing.Size(302, 159)
        Me.grbNhaphang.TabIndex = 8
        Me.grbNhaphang.TabStop = False
        Me.grbNhaphang.Text = "Add Infor ID"
        '
        'btnThoat
        '
        Me.btnThoat.Image = Global.longthps01881_ASS_BC.My.Resources.Resources._Exit
        Me.btnThoat.Location = New System.Drawing.Point(220, 110)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(41, 39)
        Me.btnThoat.TabIndex = 15
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnnhap3
        '
        Me.btnnhap3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnnhap3.Image = Global.longthps01881_ASS_BC.My.Resources.Resources.Delete1
        Me.btnnhap3.Location = New System.Drawing.Point(126, 110)
        Me.btnnhap3.Name = "btnnhap3"
        Me.btnnhap3.Size = New System.Drawing.Size(43, 40)
        Me.btnnhap3.TabIndex = 14
        Me.btnnhap3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.longthps01881_ASS_BC.My.Resources.Resources.Left
        Me.Button1.Location = New System.Drawing.Point(175, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 40)
        Me.Button1.TabIndex = 16
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblhien2
        '
        Me.lblhien2.AutoSize = True
        Me.lblhien2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblhien2.Location = New System.Drawing.Point(6, 62)
        Me.lblhien2.Name = "lblhien2"
        Me.lblhien2.Size = New System.Drawing.Size(91, 17)
        Me.lblhien2.TabIndex = 20
        Me.lblhien2.Text = "Name DVD: *"
        '
        'btnnhap2
        '
        Me.btnnhap2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnnhap2.Image = Global.longthps01881_ASS_BC.My.Resources.Resources.Edit
        Me.btnnhap2.Location = New System.Drawing.Point(81, 112)
        Me.btnnhap2.Name = "btnnhap2"
        Me.btnnhap2.Size = New System.Drawing.Size(39, 38)
        Me.btnnhap2.TabIndex = 13
        Me.btnnhap2.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Image = Global.longthps01881_ASS_BC.My.Resources.Resources.Add
        Me.btnThem.Location = New System.Drawing.Point(36, 112)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(39, 39)
        Me.btnThem.TabIndex = 14
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'lblhien1
        '
        Me.lblhien1.AutoSize = True
        Me.lblhien1.Location = New System.Drawing.Point(6, 31)
        Me.lblhien1.Name = "lblhien1"
        Me.lblhien1.Size = New System.Drawing.Size(83, 17)
        Me.lblhien1.TabIndex = 0
        Me.lblhien1.Text = "Catalog ID:*"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(1, 159)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(302, 162)
        Me.DataGridView1.TabIndex = 9
        '
        'txtnhap1
        '
        Me.txtnhap1.Location = New System.Drawing.Point(105, 28)
        Me.txtnhap1.Name = "txtnhap1"
        Me.txtnhap1.Size = New System.Drawing.Size(186, 25)
        Me.txtnhap1.TabIndex = 21
        '
        'txtnhap2
        '
        Me.txtnhap2.Location = New System.Drawing.Point(103, 59)
        Me.txtnhap2.Name = "txtnhap2"
        Me.txtnhap2.Size = New System.Drawing.Size(188, 25)
        Me.txtnhap2.TabIndex = 22
        '
        'frmPrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(304, 321)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.grbNhaphang)
        Me.Name = "frmPrice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add ID"
        Me.grbNhaphang.ResumeLayout(False)
        Me.grbNhaphang.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbNhaphang As System.Windows.Forms.GroupBox
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents lblhien1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblhien2 As System.Windows.Forms.Label
    Friend WithEvents btnnhap2 As System.Windows.Forms.Button
    Friend WithEvents btnnhap3 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtnhap2 As System.Windows.Forms.TextBox
    Friend WithEvents txtnhap1 As System.Windows.Forms.TextBox
End Class
