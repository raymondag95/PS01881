<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogin
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
        Dim grbLogin As System.Windows.Forms.GroupBox
        Me.txtnhap1 = New System.Windows.Forms.TextBox()
        Me.btnhien2 = New System.Windows.Forms.Button()
        Me.lbltaikhoan = New System.Windows.Forms.Label()
        Me.btnhien1 = New System.Windows.Forms.Button()
        Me.txtnhap2 = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ptbhinh1 = New System.Windows.Forms.PictureBox()
        grbLogin = New System.Windows.Forms.GroupBox()
        grbLogin.SuspendLayout()
        CType(Me.ptbhinh1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbLogin
        '
        grbLogin.BackColor = System.Drawing.Color.DimGray
        grbLogin.Controls.Add(Me.txtnhap1)
        grbLogin.Controls.Add(Me.btnhien2)
        grbLogin.Controls.Add(Me.lbltaikhoan)
        grbLogin.Controls.Add(Me.btnhien1)
        grbLogin.Controls.Add(Me.txtnhap2)
        grbLogin.Controls.Add(Me.lblPassword)
        grbLogin.Controls.Add(Me.lblLogin)
        grbLogin.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        grbLogin.ForeColor = System.Drawing.Color.White
        grbLogin.Location = New System.Drawing.Point(44, 126)
        grbLogin.Name = "grbLogin"
        grbLogin.Size = New System.Drawing.Size(341, 162)
        grbLogin.TabIndex = 2
        grbLogin.TabStop = False
        grbLogin.Text = "Đăng nhập"
        '
        'txtnhap1
        '
        Me.txtnhap1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtnhap1.ForeColor = System.Drawing.Color.Black
        Me.txtnhap1.Location = New System.Drawing.Point(121, 49)
        Me.txtnhap1.MaxLength = 20
        Me.txtnhap1.Name = "txtnhap1"
        Me.txtnhap1.Size = New System.Drawing.Size(198, 25)
        Me.txtnhap1.TabIndex = 1
        '
        'btnhien2
        '
        Me.btnhien2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnhien2.ForeColor = System.Drawing.Color.Black
        Me.btnhien2.Image = Global.longthps01881_ASS_BC.My.Resources.Resources.Delete
        Me.btnhien2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhien2.Location = New System.Drawing.Point(229, 116)
        Me.btnhien2.Name = "btnhien2"
        Me.btnhien2.Size = New System.Drawing.Size(100, 40)
        Me.btnhien2.TabIndex = 4
        Me.btnhien2.Text = "     Thoát"
        Me.btnhien2.UseVisualStyleBackColor = True
        '
        'lbltaikhoan
        '
        Me.lbltaikhoan.BackColor = System.Drawing.Color.Transparent
        Me.lbltaikhoan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbltaikhoan.ForeColor = System.Drawing.Color.Yellow
        Me.lbltaikhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbltaikhoan.Location = New System.Drawing.Point(132, 23)
        Me.lbltaikhoan.Name = "lbltaikhoan"
        Me.lbltaikhoan.Size = New System.Drawing.Size(187, 23)
        Me.lbltaikhoan.TabIndex = 5
        Me.lbltaikhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbltaikhoan.Visible = False
        '
        'btnhien1
        '
        Me.btnhien1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnhien1.ForeColor = System.Drawing.Color.Black
        Me.btnhien1.Image = Global.longthps01881_ASS_BC.My.Resources.Resources.Open_lock
        Me.btnhien1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhien1.Location = New System.Drawing.Point(121, 116)
        Me.btnhien1.Name = "btnhien1"
        Me.btnhien1.Size = New System.Drawing.Size(102, 40)
        Me.btnhien1.TabIndex = 3
        Me.btnhien1.Text = "         Đăng nhập"
        Me.btnhien1.UseVisualStyleBackColor = True
        '
        'txtnhap2
        '
        Me.txtnhap2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtnhap2.ForeColor = System.Drawing.Color.Black
        Me.txtnhap2.Location = New System.Drawing.Point(121, 81)
        Me.txtnhap2.MaxLength = 20
        Me.txtnhap2.Name = "txtnhap2"
        Me.txtnhap2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnhap2.Size = New System.Drawing.Size(198, 25)
        Me.txtnhap2.TabIndex = 2
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Black
        Me.lblPassword.Location = New System.Drawing.Point(18, 84)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(70, 17)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Mật khẩu:"
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.Black
        Me.lblLogin.Location = New System.Drawing.Point(18, 52)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(97, 17)
        Me.lblLogin.TabIndex = 0
        Me.lblLogin.Text = "Tên tài khoản:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 291)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(405, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Để tìm kiếm thông tin đĩa khách hàng đăng nhập bằng tài khoản user"
        '
        'ptbhinh1
        '
        Me.ptbhinh1.Image = Global.longthps01881_ASS_BC.My.Resources.Resources.anonymous_by_zaysancho_d3aqimh
        Me.ptbhinh1.Location = New System.Drawing.Point(165, 12)
        Me.ptbhinh1.Name = "ptbhinh1"
        Me.ptbhinh1.Size = New System.Drawing.Size(99, 91)
        Me.ptbhinh1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbhinh1.TabIndex = 10
        Me.ptbhinh1.TabStop = False
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(428, 312)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ptbhinh1)
        Me.Controls.Add(grbLogin)
        Me.Name = "frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login_PS01881"
        grbLogin.ResumeLayout(False)
        grbLogin.PerformLayout()
        CType(Me.ptbhinh1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnhap1 As System.Windows.Forms.TextBox
    Friend WithEvents btnhien2 As System.Windows.Forms.Button
    Friend WithEvents lbltaikhoan As System.Windows.Forms.Label
    Friend WithEvents btnhien1 As System.Windows.Forms.Button
    Friend WithEvents txtnhap2 As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents ptbhinh1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
