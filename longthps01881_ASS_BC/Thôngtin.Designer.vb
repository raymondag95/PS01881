<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmthongtin
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
        Me.pnlTopabout = New System.Windows.Forms.Panel()
        Me.lbltên = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDesign = New System.Windows.Forms.Label()
        Me.lblBanquyen = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pnlTopabout.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTopabout
        '
        Me.pnlTopabout.BackColor = System.Drawing.Color.GhostWhite
        Me.pnlTopabout.Controls.Add(Me.lbltên)
        Me.pnlTopabout.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopabout.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopabout.Name = "pnlTopabout"
        Me.pnlTopabout.Size = New System.Drawing.Size(371, 100)
        Me.pnlTopabout.TabIndex = 9
        '
        'lbltên
        '
        Me.lbltên.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbltên.ForeColor = System.Drawing.Color.Black
        Me.lbltên.Location = New System.Drawing.Point(47, 39)
        Me.lbltên.Name = "lbltên"
        Me.lbltên.Size = New System.Drawing.Size(273, 33)
        Me.lbltên.TabIndex = 0
        Me.lbltên.Text = "PHẦN MỀM QUẢN LÍ ĐĨA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lbltên.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(108, 128)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(155, 17)
        Me.lblVersion.TabIndex = 11
        Me.lblVersion.Text = "Phiên bản: ANONYMOUS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Ms: PS01881 - Lớp: PT9301"
        '
        'lblDesign
        '
        Me.lblDesign.AutoSize = True
        Me.lblDesign.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesign.Location = New System.Drawing.Point(95, 181)
        Me.lblDesign.Name = "lblDesign"
        Me.lblDesign.Size = New System.Drawing.Size(182, 17)
        Me.lblDesign.TabIndex = 14
        Me.lblDesign.Text = "Người Làm: Trần Hoàng Long"
        '
        'lblBanquyen
        '
        Me.lblBanquyen.AutoSize = True
        Me.lblBanquyen.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBanquyen.Location = New System.Drawing.Point(95, 155)
        Me.lblBanquyen.Name = "lblBanquyen"
        Me.lblBanquyen.Size = New System.Drawing.Size(180, 17)
        Me.lblBanquyen.TabIndex = 15
        Me.lblBanquyen.Text = "Bản quyền thuộc về LongTran"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.longthps01881_ASS_BC.My.Resources.Resources.Anonymous
        Me.PictureBox2.Location = New System.Drawing.Point(0, 295)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(371, 139)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'frmthongtin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 434)
        Me.Controls.Add(Me.lblBanquyen)
        Me.Controls.Add(Me.lblDesign)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.pnlTopabout)
        Me.Name = "frmthongtin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        Me.pnlTopabout.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlTopabout As System.Windows.Forms.Panel
    Friend WithEvents lbltên As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDesign As System.Windows.Forms.Label
    Friend WithEvents lblBanquyen As System.Windows.Forms.Label
End Class
