Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmPrice 'khai báo
    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=PS01881.mssql.somee.com;packet size=4096;user id=raymondag95_SQLLogin_1;pwd=gm2ije9cvt;data source=PS01881.mssql.somee.com;persist security info=False;initial catalog=PS01881"
    Private Sub Loadsp()
        Dim KetNoi As New SqlConnection(connectstr)
        'Tạo đối tượng chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select * from Loai_SP", KetNoi)
        Try
            sqlAdapter.Fill(tb)
        Catch ex As Exception
        End Try
        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        DataGridView1.DataSource = tb
        KetNoi.Close()
    End Sub
    Private Sub Loadsp(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim KetNoi As New SqlConnection(connectstr)
        'Tạo đối tượng chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select * from Loai_SP", KetNoi)

        Try
            KetNoi.Open()
            'Đổ dữ liệu trên Table vào Datatable trên máy
            sqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        DataGridView1.DataSource = tb
        KetNoi.Close()

    End Sub

    'Hiện trên GridView
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        txtnhap1.Text = DataGridView1.Item(0, index).Value
        txtnhap2.Text = DataGridView1.Item(1, index).Value
    End Sub














    'nút thoát trang
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    'nút quay lại
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmAddShop.Show()
        Me.Hide()
    End Sub






    Private Sub dtpdate_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim query As String = String.Empty
        query &= "INSERT INTO Loai_SP ( Ma_SP,Ten_SP)"
        query &= "Values(@Ma_SP,@Ten_SP)"
        Using conn As New SqlConnection("workstation id=PS01881.mssql.somee.com;packet size=4096;user id=raymondag95_SQLLogin_1;pwd=gm2ije9cvt;data source=PS01881.mssql.somee.com;persist security info=False;initial catalog=PS01881")
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Ma_SP", txtnhap1.Text)
                    .Parameters.AddWithValue("@Ten_SP", txtnhap2.Text)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString(), "Error Message")
                End Try
            End Using
        End Using
    End Sub

    Private Sub lblhien1_Click(sender As Object, e As EventArgs) Handles lblhien1.Click

    End Sub
    'Xóa danh sách đã có
    Private Sub btnnhap3_Click(sender As Object, e As EventArgs) Handles btnnhap3.Click
        Dim KetNoi As New SqlConnection(connectstr)
        KetNoi.Open()
        Dim stradd As String = "Delete from  Loai_SP where Ma_SP = @Ma_SP"
        Dim com As New SqlCommand(stradd, KetNoi)
        Try
            com.Parameters.AddWithValue("@Ma_SP", txtnhap1.Text)
            com.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Yêu Cầu Của Bạn Không Thành Công Mời Bạn Thử Lại.")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        Loadsp()

    End Sub

    Private Sub btnnhap2_Click(sender As Object, e As EventArgs) Handles btnnhap2.Click
        Dim KetNoi As New SqlConnection(connectstr)
        KetNoi.Open()
        Dim stradd As String = "Update Loai_SP Set Ten_SP=@Ten_SP Where Ma_SP=@Ma_SP"
        Dim com As New SqlCommand(stradd, KetNoi)
        Try
            'them dữ liệu
            com.Parameters.AddWithValue("@Ma_SP", txtnhap1.Text)
            com.Parameters.AddWithValue("@Ten_SP", txtnhap2.Text)
            com.ExecuteNonQuery()
            KetNoi.Close()
        Catch ex As Exception
            MessageBox.Show("Kết Nối Thất Bại")

        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        Loadsp()
    End Sub
End Class