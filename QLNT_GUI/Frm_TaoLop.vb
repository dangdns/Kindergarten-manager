Imports QLNT_DTO
Imports QLNT_BUS
Imports QLNT_DAL
Imports Utility
Public Class Frm_TaoLop
    Private lopBus As Lop_BUS
    Private khoiBus As Khoi_BUS
    Private result As Result
    Private thamSo As ThamSo_BUS
    Private listLop As List(Of Lop_DTO)
    Private Sub frmThemLop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lopBus = New Lop_BUS()
        thamSo = New ThamSo_BUS()
        khoiBus = New Khoi_BUS()
        listLop = New List(Of Lop_DTO)
        Dim myCurrencyManager As CurrencyManager
        ' Load Khoi list
        Dim listKhoi = New List(Of Khoi_DTO)
        result = khoiBus.selectAll(listKhoi)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cb_Khoi.DataSource = New BindingSource(listKhoi, String.Empty)
        cb_Khoi.DisplayMember = "StrTenKhoi1"
        cb_Khoi.ValueMember = "StrMaKhoi1"
        myCurrencyManager = Me.BindingContext(cb_Khoi.DataSource)
        myCurrencyManager.Refresh()
        If (listKhoi.Count > 0) Then
            cb_Khoi.SelectedIndex = 0
        End If
        'set Mã LOP auto
        Dim lopDAL = New Lop_DAL
        Dim nextID = 0
        result = lopDAL.getNextID(nextID)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy mã Lớp không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        tb_MaLop.Text = nextID
    End Sub

    Private Sub btn_Nhap_Click(sender As Object, e As EventArgs) Handles btn_Nhap.Click
        Dim lopDTO As Lop_DTO
        lopDTO = New Lop_DTO()
        Dim thamSoDTO As ThamSo_DTO
        thamSoDTO = New ThamSo_DTO

        'Update so lop trong bang khoi
        Dim khoi = CType(cb_Khoi.SelectedItem, Khoi_DTO)


        '1. Mapping data from GUI control
        lopDTO.StrMaLop1 = Convert.ToInt32(tb_MaLop.Text)
        lopDTO.StrTenLop1 = tb_TenLop.Text
        lopDTO.StrMaKhoi1 = khoi.StrMaKhoi1

        '2. Business .....
        If (lopBus.isValidName(lopDTO) = False) Then
            MessageBox.Show("Tên Lớp không được chứa kí tự đặc biệt. Vui lòng kiểm tra lại!")
            tb_TenLop.Focus()
            Return
        End If


        'Check so lop toi da
        result = lopBus.selectALL(listLop)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách lớp không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        result = thamSo.selectAll(thamSoDTO)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy tham số không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        If (listLop.Count = thamSoDTO.IntSokhoiMax1) Then
            MessageBox.Show("Đã đạt tối đa số lớp trong một khối. Vui lòng thay đổi quy định hay xóa bớt lớp để tạo thêm lớp.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        '3. Insert to DB
        'Lấy số lớp trong khối
        result = khoiBUS.selectKhoiByKhoi(khoi)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy khối theo mã khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        'Tang 1 don vi
        khoi.IntSoLop1 = khoi.IntSoLop1 + 1
        'Update So lop lai
        result = khoiBUS.updateSoLopTrongKhoi(khoi)
        If (result.FlagResult = False) Then
            MessageBox.Show("Update số lớp trong khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        'Tao lop
        result = lopBus.insert(lopDTO)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Lớp thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set Mã HK auto
            Dim nextID = 0
            result = lopBus.getNextID(nextID)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy mã Lớp không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Me.Close()
                Return
            End If
            tb_MaLop.Text = nextID
            tb_TenLop.Text = String.Empty

        Else
            MessageBox.Show("Thêm Lớp không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btn_NhapVaDong_Click(sender As Object, e As EventArgs) Handles btn_NhapVaDong.Click
        Dim lopDTO As Lop_DTO
        lopDTO = New Lop_DTO()
        Dim thamSoDTO As ThamSo_DTO
        thamSoDTO = New ThamSo_DTO


        Dim khoiBUS As Khoi_BUS
        khoiBUS = New Khoi_BUS()
        Dim result As Result

        Dim khoi = CType(cb_Khoi.SelectedItem, Khoi_DTO)
        result = khoiBUS.selectKhoiByKhoi(khoi)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy khối theo mã khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        khoi.IntSoLop1 = khoi.IntSoLop1 + 1
        result = khoiBUS.updateSoLopTrongKhoi(khoi)
        If (result.FlagResult = False) Then
            MessageBox.Show("Update số lớp trong khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If

        '1. Mapping data from GUI control
        lopDTO.StrMaLop1 = Convert.ToInt32(tb_MaLop.Text)
        lopDTO.StrTenLop1 = tb_TenLop.Text
        lopDTO.StrMaKhoi1 = khoi.StrMaKhoi1

        '2. Business .....
        If (lopBus.isValidName(lopDTO) = False) Then
            MessageBox.Show("Tên Lớp không đúng")
            tb_TenLop.Focus()
            Return
        End If

        'Check so lop toi da
        result = lopBus.selectALL(listLop)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách lớp không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        result = thamSo.selectAll(thamSoDTO)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy tham số không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        If (listLop.Count = thamSoDTO.IntSokhoiMax1) Then
            MessageBox.Show("Đã đạt tối đa số lớp trong một khối. Vui lòng thay đổi quy định hay xóa bớt lớp để tạo thêm lớp.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        '3. Insert to DB
        'Lấy số lớp trong khối
        result = khoiBUS.selectKhoiByKhoi(khoi)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy khối theo mã khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        'Tang 1 don vi
        khoi.IntSoLop1 = khoi.IntSoLop1 + 1
        'Update So lop lai
        result = khoiBUS.updateSoLopTrongKhoi(khoi)
        If (result.FlagResult = False) Then
            MessageBox.Show("Update số lớp trong khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        'Tao lop
        result = lopBus.insert(lopDTO)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Lớp thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Else
            MessageBox.Show("Thêm Lớp không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
End Class