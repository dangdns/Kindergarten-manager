Imports QLNT_BUS
Imports QLNT_DTO
Imports Utility
Imports QLNT_DAL
Public Class Frm_TimTre
    Private khoibus As Khoi_BUS
    Private thamsobus As ThamSo_BUS
    Private lopbus As Lop_BUS
    Private treBus As Tre_BUS
    Private chitietlopBus As ChiTietLop_BUS

    Private Sub Frm_NhapLop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        thamsobus = New ThamSo_BUS()
        lopbus = New Lop_BUS()
        khoibus = New Khoi_BUS()
        treBus = New Tre_BUS()
        chitietlopBus = New ChiTietLop_BUS()
        ' Load Khoi list
        Dim result As Result
        Dim myCurrencyManager As CurrencyManager
        Dim listKhoi = New List(Of Khoi_DTO)
        Dim khoidal As Khoi_DAL
        khoidal = New Khoi_DAL()
        cb_MaTre.Checked = True
        tb_DienThoai.ReadOnly = True
        tb_HovaTenTre.ReadOnly = True
        tb_TenONha.ReadOnly = True
        tb_TenPhuHuynh.ReadOnly = True


        tb_MaTre.ReadOnly = False

        cb_HocHanh.Checked = False
        Label7.Hide()
        Label8.Hide()
        cb_Khoi.Hide()
        cb_TenLop.Hide()

        cb_GioiTinh.Hide()
        result = khoidal.selectALL(listKhoi)
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

        'gioitinh


        Dim listGioiTinh = New List(Of GioiTinh_DTO)
        Dim gioitinhdal As GioiTinh_DAL
        gioitinhdal = New GioiTinh_DAL()
        result = gioitinhdal.selectALL(listGioiTinh)

        'result = kBus.selectAll(listKhoi)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách giới tính không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cb_GioiTinh.DataSource = New BindingSource(listGioiTinh, String.Empty)
        cb_GioiTinh.DisplayMember = "StrTenGioiTinh1"
        cb_GioiTinh.ValueMember = "StrMaGioiTinh1"
        myCurrencyManager = Me.BindingContext(cb_GioiTinh.DataSource)
        myCurrencyManager.Refresh()
        If (listLopByMaKhoi.Count > 0) Then
            cb_GioiTinh.SelectedIndex = 1
        End If

    End Sub
    Dim listLopByMaKhoi = New List(Of Lop_DTO)



    Private Sub cb_Khoi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Khoi.SelectedIndexChanged
        Dim khoi = CType(cb_Khoi.SelectedItem, Khoi_DTO)

        Dim result As Result
        result = lopbus.selectALL_ByMaKhoi(khoi.StrMaKhoi1, listLopByMaKhoi)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Lớp theo mã khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If



        cb_TenLop.DataSource = New BindingSource(listLopByMaKhoi, String.Empty)
        cb_TenLop.DisplayMember = "StrTenLop1"
        cb_TenLop.ValueMember = "StrMaLop1"

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(cb_TenLop.DataSource)
        myCurrencyManager.Refresh()
        If (listLopByMaKhoi.Count > 0) Then
            cb_TenLop.SelectedIndex = 0
        End If


    End Sub
    Dim treDTO As New Tre_DTO
    Dim KhoiDTO As New Khoi_DTO
    Dim LopDTO As New Lop_DTO
    Dim GioiTinhDTO As New GioiTinh_DTO
    Private Sub btn_Tim_Click(sender As Object, e As EventArgs) Handles btn_Tim.Click
        treDTO.StrTenTre1 = tb_HovaTenTre.Text.Trim
        treDTO.StrTenONha1 = tb_TenONha.Text.Trim
        treDTO.StrDienThoai1 = tb_DienThoai.Text.Trim
        treDTO.StrTenPhuHuynh1 = tb_TenPhuHuynh.Text.Trim
        treDTO.StrID1 = tb_MaTre.Text.Trim
        KhoiDTO = CType(cb_Khoi.SelectedItem, Khoi_DTO)
        LopDTO = CType(cb_TenLop.SelectedItem, Lop_DTO)
        GioiTinhDTO = CType(cb_GioiTinh.SelectedItem, GioiTinh_DTO)
        treDTO.IntGioiTinh1 = GioiTinhDTO.StrMaGioiTinh1

        Dim result As Result

        Dim lop = CType(cb_TenLop.SelectedItem, Lop_DTO)
        Dim listTreDTO As List(Of Tre_DTO)
        listTreDTO = New List(Of Tre_DTO)

        Dim listchiTietLop = New List(Of ChiTietLop_DTO)
        Dim listLopTheoMaKhoi = New List(Of Lop_DTO)
        If cb_MaTre.Checked = True Then
            If tb_MaTre.Text.Length <> 8 Then
                MessageBox.Show("Mã trẻ sai vui lòng nhập đầy đủ 8 kí tự.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else

                result = treBus.ReadTreTrongList(treDTO.StrID1, listTreDTO)
                If (result.FlagResult = False) Then
                    MessageBox.Show("Tìm trẻ không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                    Return
                Else
                    createDataGrid(DG_TIMTRE, listTreDTO)
                End If
                Return

            End If
        Else
            If cb_HocHanh.Checked = True Then
                result = treBus.TraCuu_Lop(lop.StrMaLop1, treDTO, listTreDTO)
                If (result.FlagResult = False) Then
                    MessageBox.Show("Tìm trẻ không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                    Return
                Else
                    createDataGrid(DG_TIMTRE, listTreDTO)
                End If
            Else
                result = treBus.TraCuu_KHONGLOP(treDTO, listTreDTO)
                If (result.FlagResult = False) Then
                    MessageBox.Show("Tìm trẻ không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                    Return
                Else
                    createDataGrid(DG_TIMTRE, listTreDTO)
                End If
            End If
        End If




    End Sub
    Private Function createDataGrid(dg As DataGridView, listTreDTO As List(Of Tre_DTO))
        dg.Columns.Clear()
        dg.DataSource = Nothing

        dg.AutoGenerateColumns = False
        dg.AllowUserToAddRows = False
        dg.DataSource = listTreDTO

        Dim clMaTre = New DataGridViewTextBoxColumn()
        clMaTre.Name = "MaTre"
        clMaTre.HeaderText = "Mã trẻ"
        clMaTre.DataPropertyName = "StrID1"
        dg.Columns.Add(clMaTre)

        Dim clHoTenTre = New DataGridViewTextBoxColumn()
        clHoTenTre.Name = "HoVaTenTre"
        clHoTenTre.HeaderText = "Họ và tên trẻ"
        clHoTenTre.DataPropertyName = "StrTenTre1"
        dg.Columns.Add(clHoTenTre)


        Dim clTenONha = New DataGridViewTextBoxColumn()
        clTenONha.Name = "TenONha"
        clTenONha.HeaderText = "Tên ở nhà"
        clTenONha.DataPropertyName = "StrTenONha1"
        dg.Columns.Add(clTenONha)

        Dim clHoTenPhuHuynh = New DataGridViewTextBoxColumn()
        clHoTenPhuHuynh.Name = "HoTenPhuHuynh"
        clHoTenPhuHuynh.HeaderText = "Họ tên phụ huynh"
        clHoTenPhuHuynh.DataPropertyName = "StrTenPhuHuynh1"
        dg.Columns.Add(clHoTenPhuHuynh)

        Dim clNgaySinh = New DataGridViewTextBoxColumn()
        clNgaySinh.Name = "NgaySinh"
        clNgaySinh.HeaderText = "Ngày sinh"
        clNgaySinh.DataPropertyName = "DtNgaySinh1"
        dg.Columns.Add(clNgaySinh)

        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "DiaChi"
        clDiaChi.HeaderText = "Địa chỉ"
        clDiaChi.DataPropertyName = "StrDiaChi1"
        dg.Columns.Add(clDiaChi)

        Dim clDienThoai = New DataGridViewTextBoxColumn()
        clDienThoai.Name = "DienThoai"
        clDienThoai.HeaderText = "Điện thoại"
        clDienThoai.DataPropertyName = "StrDienThoai1"
        dg.Columns.Add(clDienThoai)

        Dim clGioiTinh = New DataGridViewTextBoxColumn()
        clGioiTinh.Name = "GioiTinh"
        clGioiTinh.HeaderText = "Giói tính"
        clGioiTinh.DataPropertyName = "StrGioiTinh1"
        dg.Columns.Add(clGioiTinh)

    End Function







    Private Sub cb_HoVaTen_CheckedChanged(sender As Object, e As EventArgs)
        tb_HovaTenTre.Clear()
        If tb_HovaTenTre.ReadOnly = False Then
            tb_HovaTenTre.ReadOnly = True
        Else
            tb_HovaTenTre.ReadOnly = False
            cb_MaTre.Checked = False
        End If
    End Sub

    Private Sub cb_TenONha_CheckedChanged(sender As Object, e As EventArgs)
        tb_TenONha.Clear()
        If tb_TenONha.ReadOnly = False Then
            tb_TenONha.ReadOnly = True
        Else
            tb_TenONha.ReadOnly = False
            cb_MaTre.Checked = False
        End If
    End Sub

    Private Sub cb_TenPhuHuynh_CheckedChanged(sender As Object, e As EventArgs)
        tb_TenPhuHuynh.Clear()
        If tb_TenPhuHuynh.ReadOnly = False Then
            tb_TenPhuHuynh.ReadOnly = True
        Else
            tb_TenPhuHuynh.ReadOnly = False
            cb_MaTre.Checked = False
        End If
    End Sub
    Dim x = 0
    Dim y = 0


    Private Sub cb_MaTre_CheckedChanged(sender As Object, e As EventArgs) Handles cb_MaTre.CheckedChanged
        tb_MaTre.Clear()
        If tb_MaTre.ReadOnly = False Then
            tb_MaTre.ReadOnly = True
            tb_DienThoai.ReadOnly = False
            tb_HovaTenTre.ReadOnly = False
            tb_TenONha.ReadOnly = False
            tb_TenPhuHuynh.ReadOnly = False

            cb_HocHanh.Checked = False
            Label7.Hide()
            Label8.Hide()
            cb_Khoi.Hide()
            cb_TenLop.Hide()

            cb_GioiTinh.Show()

        Else
            tb_MaTre.ReadOnly = False
            cb_HocHanh.Checked = False


            tb_DienThoai.ReadOnly = True
            tb_HovaTenTre.ReadOnly = True
            tb_TenONha.ReadOnly = True
            tb_TenPhuHuynh.ReadOnly = True

            cb_HocHanh.Checked = False
            Label7.Hide()
            Label8.Hide()
            cb_Khoi.Hide()
            cb_TenLop.Hide()

            cb_GioiTinh.Hide()
        End If
    End Sub

    Private Sub cb_DienThoai_CheckedChanged(sender As Object, e As EventArgs)
        tb_DienThoai.Clear()
        If tb_DienThoai.ReadOnly = False Then
            tb_DienThoai.ReadOnly = True
        Else
            tb_DienThoai.ReadOnly = False
            cb_MaTre.Checked = False
        End If
    End Sub

    Private Sub CheckBoxGioiTinh_CheckedChanged(sender As Object, e As EventArgs)
        If y = 0 Then
            cb_GioiTinh.Show()
            y = 1
            cb_MaTre.Checked = False
        Else
            cb_GioiTinh.Hide()
            y = 0
        End If
    End Sub



    Private Sub cb_HocHanh_CheckedChanged(sender As Object, e As EventArgs) Handles cb_HocHanh.CheckedChanged
        If cb_HocHanh.Checked = True Then
            cb_MaTre.Checked = False
            Label7.Show()
            Label8.Show()
            cb_Khoi.Show()
            cb_TenLop.Show()


        Else
            Label7.Hide()
            Label8.Hide()
            cb_Khoi.Hide()
            cb_TenLop.Hide()

        End If
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class