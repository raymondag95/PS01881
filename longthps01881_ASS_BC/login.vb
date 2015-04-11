Imports System.Data.SqlClient

Public Class frmlogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnhien1.Click
        'Tạo Kết Nối Dữ Liệu với Datablase
        Dim dulieu As String = "workstation id=PS01881.mssql.somee.com;packet size=4096;user id=raymondag95_SQLLogin_1;pwd=gm2ije9cvt;data source=PS01881.mssql.somee.com;persist security info=False;initial catalog=PS01881"
        Dim KetNoi As SqlConnection = New SqlConnection(dulieu)
        'Tạo đối tượng chạy câu truy vấn
        Dim sqlAdapter As New SqlDataAdapter("select * from Quan_Tri where Tai_Khoan ='" & txtnhap1.Text & "' and Mat_Khau='" & txtnhap2.Text & "' ", KetNoi)
        Dim tb As New DataTable

        Try 'Mở Bảng Dữ Liệu Và Lọc Kết Quả Nếu Có Chương Trình Sẽ Đăng Nhập Vào Thành Công.
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Đăng Nhập Thành Công")
                frmquanli.Show() 'Khi Đăng Nhập Thành Công Form Quản Lí Được Mở Ra Cho Người Sử Dụng.
                Me.Hide()
            Else 'Ngược Lại Thông Báo Không Đăng Nhập Được.
                MessageBox.Show("Tài Khoản Hoặc Mật Khẩu Của Bạn Nhập Không Đúng.")
            End If

        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnhien2.Click
        End
    End Sub

    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class


        

