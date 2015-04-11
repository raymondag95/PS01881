Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class FrmAddShop

    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=PS01881.mssql.somee.com;packet size=4096;user id=raymondag95_SQLLogin_1;pwd=gm2ije9cvt;data source=PS01881.mssql.somee.com;persist security info=False;initial catalog=PS01881"
    Private Sub Loadsp()
        Dim KetNoi As New SqlConnection(connectstr)
        'Tạo đối tượng chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select * from San_Pham", KetNoi)
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
        Dim sqlAdapter As New SqlDataAdapter("select * from San_Pham", KetNoi)

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
        txtnhap3.Text = DataGridView1.Item(2, index).Value
        txtnhap4.Text = DataGridView1.Item(3, index).Value
        txtnhap5.Text = DataGridView1.Item(4, index).Value
        txtnhap6.Text = DataGridView1.Item(5, index).Value
        txtnhap7.Text = DataGridView1.Item(6, index).Value
        txtnhap8.Text = DataGridView1.Item(7, index).Value
    End Sub
    'Thêm mới vào mục danh sách
    Private Sub btnnhap1_Click(sender As Object, e As EventArgs) Handles btnnhap1.Click
        Dim query As String = String.Empty
        query &= "INSERT INTO San_Pham ( Ma_SP,Ten_SP,Noi_SX,Don_Gia,So_Luong,Ma_Loai,ChiTiet_SP,Loai_SP_Ma_SP)"
        query &= "Values(@Ma_SP,@Ten_SP,@Noi_SX,@Don_Gia,@So_Luong,@Ma_Loai,@ChiTiet_SP,@Loai_SP_Ma_SP)"
        Using conn As New SqlConnection("workstation id=PS01881.mssql.somee.com;packet size=4096;user id=raymondag95_SQLLogin_1;pwd=gm2ije9cvt;data source=PS01881.mssql.somee.com;persist security info=False;initial catalog=PS01881")
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Ma_SP", txtnhap1.Text)
                    .Parameters.AddWithValue("@Ten_SP", txtnhap2.Text)
                    .Parameters.AddWithValue("@Noi_SX", txtnhap3.Text)
                    .Parameters.AddWithValue("@Don_Gia", txtnhap4.Text)
                    .Parameters.AddWithValue("@So_Luong", txtnhap5.Text)
                    .Parameters.AddWithValue("@Ma_Loai", txtnhap6.Text)
                    .Parameters.AddWithValue("@ChiTiet_SP", txtnhap7.Text)
                    .Parameters.AddWithValue("@Loai_SP_Ma_SP", txtnhap8.Text)

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

   
    Private Sub btnnhap4_Click(sender As Object, e As EventArgs) Handles btnnhap4.Click
        Me.Close()
    End Sub
    'Xóa danh sách đã có
    Private Sub btnnhap3_Click(sender As Object, e As EventArgs) Handles btnnhap3.Click
        Dim KetNoi As New SqlConnection(connectstr)
        KetNoi.Open()
        Dim stradd As String = "Delete from  San_Pham where Ma_SP = @Ma_SP"
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
    'sửa thông tin đã nhập
    Private Sub btnnhap2_Click(sender As Object, e As EventArgs) Handles btnnhap2.Click
        Dim KetNoi As New SqlConnection(connectstr)
        KetNoi.Open()
        Dim stradd As String = "Update San_Pham Set Ten_SP=@Ten_SP,Noi_SX=@Noi_SX,Don_Gia=@Don_Gia,So_Luong=@So_Luong,Ma_Loai=@Ma_Loai,ChiTiet_SP=@ChiTiet_SP,Loai_SP_Ma_SP=@Loai_SP_Ma_SP Where Ma_SP=@Ma_SP"
        Dim com As New SqlCommand(stradd, KetNoi)
        Try
            'them dữ liệu
            com.Parameters.AddWithValue("@Ma_SP", txtnhap1.Text)
            com.Parameters.AddWithValue("@Ten_SP", txtnhap2.Text)
            com.Parameters.AddWithValue("@Noi_SX", txtnhap3.Text)
            com.Parameters.AddWithValue("@Don_Gia", txtnhap4.Text)
            com.Parameters.AddWithValue("@So_Luong", txtnhap5.Text)
            com.Parameters.AddWithValue("@Ma_Loai", txtnhap6.Text)
            com.Parameters.AddWithValue("@ChiTiet_SP", txtnhap7.Text)
            com.Parameters.AddWithValue("@Loai_SP_Ma_SP", txtnhap8.Text)
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

    Private Sub btnchuyen_Click(sender As Object, e As EventArgs) Handles btnchuyen.Click
        frmPrice.Show()
    End Sub
End Class