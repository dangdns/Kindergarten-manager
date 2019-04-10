Imports QLNT_BUS
Imports QLNT_DTO
Imports Utility

Public Class Frm_TaoKhoi
    Private khoiBus As Khoi_BUS

    Private thamSoBUS As ThamSo_BUS
    Private result As Result
    Private listKhoi As List(Of Khoi_DTO)
    Private Sub Frm_NhapKhoi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        result = New Result
        listKhoi = New List(Of Khoi_DTO)
        thamSoBUS = New ThamSo_BUS
    End Sub
    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click
        Dim khoi As Khoi_DTO
        khoi = New Khoi_DTO()
        Dim thamsoDTO As ThamSo_DTO
        thamsoDTO = New ThamSo_DTO()
        '1. Mapping data from GUI control
        khoi.StrMaKhoi1 = Convert.ToInt32(tb_MaKhoi.Text)
        khoi.StrTenKhoi1 = tb_TenKhoi.Text

        '2. Business .....
        If (khoiBus.isValidNameKhoi(khoi) = False) Then
            MessageBox.Show("Tên Khối không được chứa kí tự đặc biệt. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tb_TenKhoi.Clear()
            tb_TenKhoi.Focus()

            Return
        End If
        'Check so khoi toi da
        result = khoiBus.selectAll(listKhoi)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        result = thamSoBUS.selectAll(thamsoDTO)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy tham số không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        If (listKhoi.Count = thamsoDTO.IntSokhoiMax1) Then
            MessageBox.Show("Đã đạt tối đa số khối. Vui lòng thay đổi quy định hay xóa bớt số khối để tạo thêm khối.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        '3. Insert to DB

        result = khoiBus.insertKhoi(khoi)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Khối thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tb_TenKhoi.Text = String.Empty

            ' Get Next ID
            Dim nextID As Integer
            result = khoiBus.getNextID(nextID)
            If (result.FlagResult = True) Then
                tb_MaKhoi.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của Khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

        Else
            MessageBox.Show("Thêm Khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnNhapVanDong_Click(sender As Object, e As EventArgs) Handles btnNhapVanDong.Click
        Dim khoi As Khoi_DTO
        khoi = New Khoi_DTO()
        Dim thamsoDTO As ThamSo_DTO
        thamsoDTO = New ThamSo_DTO()


        '1. Mapping data from GUI control
        khoi.StrMaKhoi1 = Convert.ToInt32(tb_MaKhoi.Text)
        khoi.StrTenKhoi1 = tb_TenKhoi.Text

        '2. Business .....
        If (khoiBus.isValidNameKhoi(khoi) = False) Then
            MessageBox.Show("Tên Khối không được chứa kí tự đặc biệt. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tb_TenKhoi.Clear()
            tb_TenKhoi.Focus()

            Return
        End If
        'Check so khoi toi da
        result = khoiBus.selectAll(listKhoi)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        result = thamSoBUS.selectAll(thamsoDTO)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy tham số không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        If (listKhoi.Count = thamsoDTO.IntSokhoiMax1) Then
            MessageBox.Show("Đã đạt tối đa số khối. Vui lòng thay đổi quy định hay xóa bớt số khối để tạo thêm khối.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        '3. Insert to DB
        result = khoiBus.insertKhoi(khoi)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Khối thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tb_TenKhoi.Text = String.Empty
            Me.Close()
        Else
            MessageBox.Show("Thêm Khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub Frm_TaoKhoi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        khoiBus = New Khoi_BUS()

        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = khoiBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            tb_MaKhoi.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của Khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If


    End Sub
End Class