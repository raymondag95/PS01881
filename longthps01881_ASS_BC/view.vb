Imports System.IO

Public Class frmview

    Dim strdocfile As String         'khai báo biến đọc file
    Dim arrmangluu As String()       'khai báo mảng để lưu dữ liệu đọc file
    Dim lstmoiluu As ListViewItem = New ListViewItem 'khai báo danh sách mới lưu

    Public Shared dssp As New List(Of sanpham)
    Sub danhsach(ByVal i As Integer)
        Dim strsanpham As sanpham = dssp(i)
        lblcata.Text = strsanpham.strcata
        lblname.Text = strsanpham.strname
        lblproduc.Text = strsanpham.strproduc
        lblsalePrice.Text = strsanpham.varprice
        lbldiscs.Text = strsanpham.vardics
        lblstatus.Text = strsanpham.strstatus
        lbldictype.Text = strsanpham.strdictype
        ptbHinh.ImageLocation = strsanpham.pictures

    End Sub

    Public Structure sanpham
        Dim strcata As String
        Dim strname As String
        Dim strproduc As String
        Dim varprice As Decimal
        Dim vardics As Integer
        Dim strstatus As String
        Dim strdictype As String
        Dim strdvt As String
        Dim pictures As String
    End Structure

    'sự kiện đọc dữ liệu từ file themsanpham.txt vào listview khi load form frmView
    Private Sub frmView_Load(ByVal sender As System.Object, _
                             ByVal e As System.EventArgs) Handles MyBase.Load
        lsvdanhsach.Items.Clear()      'xóa list cũ
        If File.Exists("giavatinhtrangdia.txt") = True Then 'kiểm tra sự tồn tại của file, nếu có mới thực hiện

            'khai báo biến streamwriter nhận giá trị từ file themsanpham.txt
            Dim dulieu As StreamReader = New StreamReader("giavatinhtrangdia.txt", True) 'mở file 
            'lấy dữ liệu từ file lên listview
            Do While dulieu.EndOfStream = False 'lặp lại khi chưa đọc hết file
                strdocfile = dulieu.ReadLine()         'đọc từng dòng trong file
                'strdocfilenhap = dulieunhap.ReadLine()
                arrmangluu = strdocfile.Split(",")     'ghi vào mảng
                'arrmangluunhap = strdocfilenhap.Split(",")

                lstmoiluu = New ListViewItem(arrmangluu(0))     'thêm mới dữ liệu
                lstmoiluu.SubItems.Add(arrmangluu(7))           'thêm từng  vào từng cột trong dòng1
                lstmoiluu.SubItems.Add(arrmangluu(8))
                lstmoiluu.SubItems.Add(arrmangluu(3))
                lstmoiluu.SubItems.Add(arrmangluu(1))
                lstmoiluu.SubItems.Add(arrmangluu(11))
                lstmoiluu.SubItems.Add(arrmangluu(10))
                lstmoiluu.SubItems.Add(arrmangluu(2))
                lsvdanhsach.Items.Add(lstmoiluu)        'thêm dòng mới vào listview
            Loop
            dulieu.Close()    'đóng file
            lsvcolHinhanh.Width = 0

        Else 'nếu file chưa tồn tại thì tạo file mới để lưu dữ liệu
            Using strsave As New StreamWriter("giavatinhtrangdia.txt", True)
            End Using
        End If
        If lsvdanhsach.Items.Count > 0 Then 'kiểm tra list và vô hiệu hóa các button khi load form
            lsvdanhsach.Items(0).Selected = True
            lblsothutu.Text = 1
        Else
            lblsothutu.Text = 0
            btnlui.Enabled = False
            btntoi.Enabled = False
            btnxuongcuoi.Enabled = False
            btnquaylaidau.Enabled = False

        End If

        'thiết lập kiểu hiển thị màu cho list
        For Co As Integer = 0 To lsvdanhsach.Items.Count - 1 Step 2
            lsvdanhsach.Items(Co).BackColor = Color.Cyan
        Next

    End Sub

    'sự kiện khi click vào 1 dòng trong listview lấy dữ liệu trong từng cột lên textbox tương ứng
    Private Sub lstDanhsachsp_SelectedIndexChanged(ByVal sender As Object, _
                                                   ByVal e As System.EventArgs) Handles lsvdanhsach.SelectedIndexChanged
        Dim lstrow As ListViewItem = New ListViewItem      'khai báo biến lưu dòng dữ liệu trong listview
        For Each lstrow In lsvdanhsach.SelectedItems     '
            lblcata.Text = lstrow.SubItems(0).Text
            lblname.Text = lstrow.SubItems(1).Text
            lblproduc.Text = lstrow.SubItems(2).Text
            lblsalePrice.Text = String.Format("{0:n}", lstrow.SubItems(3).Text)
            lbldiscs.Text = lstrow.SubItems(4).Text
            lblstatus.Text = lstrow.SubItems(7).Text
            lbldictype.Text = lstrow.SubItems(6).Text
            ptbHinh.ImageLocation = lstrow.SubItems(5).Text
        Next
        If lsvdanhsach.Items(0).Selected = True Then  'nếu đang chọn dòng đầu tiên trong list thì
            btntoi.Enabled = False      'vô hiệu hóa button first
            btnlui.Enabled = False        'vô hiệu hóa button lùi
        ElseIf lsvdanhsach.Items.Count = 0 Then 'còn nếu list ko có sp thì 
            btnlui.Enabled = False                 'vô hiệu hóa cả 4 button
            btntoi.Enabled = False
            btnxuongcuoi.Enabled = False
            btntoi.Enabled = False
        Else        'ngược lại enable button first và button lùi
            btntoi.Enabled = True
            btnlui.Enabled = True
        End If
        If lsvdanhsach.Items(lsvdanhsach.Items.Count - 1).Selected = True _
           Then 'nếu đang chọn dòng cuối trong list thì
            btnxuongcuoi.Enabled = False    'vô hiệu hóa button last
            btntoi.Enabled = False    'vô hiệu hóa button tiến
        Else              'ngược lại enable button last và button next
            btnxuongcuoi.Enabled = True
            btntoi.Enabled = True
        End If

        'lấy số thứ tự dòng đang chọn hiển thị lên label
        For so As Integer = 0 To lsvdanhsach.Items.Count - 1
            If lsvdanhsach.Items(so).Selected = True Then
                lblsothutu.Text = so + 1
            End If
        Next

    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnmuahang.Click
        MessageBox.Show("Phiên Bản Chưa Được Hỗ Trợ")
    End Sub

    Private Sub btntoi_Click(sender As Object, e As EventArgs) Handles btntoi.Click
        Dim varstt As Integer
        If lsvdanhsach.Items.Count > 0 Then
            For varstt = 0 To lsvdanhsach.Items.Count - 1
                If lsvdanhsach.Items(varstt).Selected = True Then
                    If varstt <> lsvdanhsach.Items.Count - 1 Then
                        lsvdanhsach.Items(varstt + 1).Selected = True
                    End If
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub btnxuongcuoi_Click(sender As Object, e As EventArgs) Handles btnxuongcuoi.Click
        If lsvdanhsach.Items.Count > 0 Then
            lsvdanhsach.Items(lsvdanhsach.Items.Count - 1).Selected = True
            lblsothutu.Text = lsvdanhsach.Items.Count
        Else
            lblsothutu.Text = 0
        End If
    End Sub

    Private Sub btnlui_Click(sender As Object, e As EventArgs) Handles btnlui.Click
        Dim varstt As Integer
        If lsvdanhsach.Items.Count > 0 Then  'kiểm tra list ko trống thì mới thực hiện
            For varstt = 0 To lsvdanhsach.Items.Count - 1
                If lsvdanhsach.Items(varstt).Selected = True Then
                    If varstt <> 0 Then
                        lsvdanhsach.Items(varstt - 1).Selected = True
                    End If
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub btnquaylaidau_Click(sender As Object, e As EventArgs) Handles btnquaylaidau.Click
        If lsvdanhsach.Items.Count > 0 Then ' nếu listview có tòn tại dữ liệu thì mới thực hiện
            lsvdanhsach.Items(lsvdanhsach.Items.Count - lsvdanhsach.Items.Count).Selected = True
            lblsothutu.Text = 1
        Else        'nếu listview trống thì label số trang = 0
            lblsothutu.Text = 0

        End If
    End Sub
End Class