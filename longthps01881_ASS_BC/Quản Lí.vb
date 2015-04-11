Public Class frmquanli

    Private Sub mnshethong_Click(sender As Object, e As EventArgs) Handles mnshethong.Click

    End Sub

    Private Sub lblTenpm_Click(sender As Object, e As EventArgs) Handles lblhien1.Click

    End Sub

    Private Sub frmquanli_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mnidangnhap_Click(sender As Object, e As EventArgs) Handles mnidangnhap.Click
        frmlogin.Show()
        Me.Hide()
    End Sub

    Private Sub mnithoat_Click(sender As Object, e As EventArgs) Handles mnithoat.Click
        End
    End Sub

    Private Sub ptb3_Click(sender As Object, e As EventArgs) Handles ptb3.Click
        frmthongtin.Show() ' Bảng Thông Tin Được Mở
    End Sub

    Private Sub mnigioithieu_Click(sender As Object, e As EventArgs) Handles mnigioithieu.Click
        frmthongtin.Show()
    End Sub

    Private Sub mnihuongdan_Click(sender As Object, e As EventArgs) Handles mnihuongdan.Click
        MessageBox.Show("Chưa Có Cập Nhật Mới!")
    End Sub

    Private Sub ptb1_Click(sender As Object, e As EventArgs) Handles ptb1.Click
        FrmAddShop.Show() 'Mở Cửa Sổ Của Bảng Quản Lí

    End Sub

    Private Sub ptb2_Click(sender As Object, e As EventArgs) Handles ptb2.Click
        frmview.Show() ' Bảng Khách Hàng Được Mở Lên

    End Sub

    Private Sub QuảnLíToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mniquanli.Click
        FrmAddShop.Show()
    End Sub

    Private Sub KháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnikhachhang.Click
        frmview.Show()
    End Sub

    Private Sub mnstrogiup_Click(sender As Object, e As EventArgs) Handles mnstrogiup.Click

    End Sub

    Private Sub lblhien2_Click(sender As Object, e As EventArgs) Handles lblhien2.Click

    End Sub
End Class