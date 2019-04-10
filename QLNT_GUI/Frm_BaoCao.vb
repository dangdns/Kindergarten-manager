Imports QLNT_BUS
Imports QLNT_DTO
Imports Utility
Imports QLNT_DAL
Public Class Frm_BaoCao
    Private kBus As Khoi_BUS
    Private PGNBUS As PhieuGhiNhan_BUS
    Dim result As Result
    Private Sub Frm_BaoCao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lb_ChonKhoi.Hide()
        cb_Khoi.Hide()
        lb_ChonNgay.Hide()
        dtNgay.Hide()
        PGNBUS = New PhieuGhiNhan_BUS
        'Load list khối
        Dim listKhoiDTO = New List(Of Khoi_DTO)
        kBus = New Khoi_BUS
        result = kBus.selectAll(listKhoiDTO)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cb_Khoi.DataSource = New BindingSource(listKhoiDTO, String.Empty)
        cb_Khoi.DisplayMember = "StrTenKhoi1"
        cb_Khoi.ValueMember = "StrMaKhoi1"
        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(cb_Khoi.DataSource)
        myCurrencyManager.Refresh()
        If (listKhoiDTO.Count > 0) Then
            cb_Khoi.SelectedIndex = 0
        End If

        Dim bcdal = New BaoCao_DAL
        Dim nextMshs As Integer
        result = bcdal.buildID(nextMshs)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy tự động mã Tình trạng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaBaoCao.Text = nextMshs
    End Sub
    Private Sub dtNgay_ValueChanged(sender As Object, e As EventArgs) Handles dtNgay.ValueChanged

    End Sub

    Private Sub loadListPGNByDate(NgayNhap As Date)
        Dim listPGN = New List(Of PhieuGhiNhan_DTO)

        Dim pgndal As PhieuGhiNhan_DAL
        pgndal = New PhieuGhiNhan_DAL()
        result = pgndal.selectALL_ByDate(NgayNhap, listPGN)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh phiếu ghi nhận theo ngày không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        convert(listPGN)


        'dgvListHS.SuspendLayout()
        dgvBaoCao.Columns.Clear()
        dgvBaoCao.DataSource = Nothing

        dgvBaoCao.AutoGenerateColumns = False
        dgvBaoCao.AllowUserToAddRows = False
        dgvBaoCao.DataSource = listPGN




        Dim clMaPhieu = New DataGridViewTextBoxColumn()
        clMaPhieu.Name = "MaPhieu"
        clMaPhieu.HeaderText = "Mã Phiếu"
        clMaPhieu.DataPropertyName = "StrMaPhieu1"
        dgvBaoCao.Columns.Add(clMaPhieu)

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "Tre"
        clMa.HeaderText = "Tên Trẻ"
        clMa.DataPropertyName = "StrMaTre1"
        dgvBaoCao.Columns.Add(clMa)


        kBus = New Khoi_BUS()
        ' Load LoaiHocSinh list
        Dim listKhoi = New List(Of Khoi_DTO)


        Dim khoidal As Khoi_DAL
        khoidal = New Khoi_DAL()
        result = khoidal.selectALL(listKhoi)

        'result = kBus.selectAll(listKhoi)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If


        Dim clMaKhoi = New DataGridViewTextBoxColumn()
        clMaKhoi.Name = "Khoi"
        clMaKhoi.HeaderText = "Tên Khối"
        clMaKhoi.DataPropertyName = "CbKhoi1"
        dgvBaoCao.Columns.Add(clMaKhoi)

        Dim clMaTinhTrang = New DataGridViewTextBoxColumn()
        clMaTinhTrang.Name = "MaTinhTrang"
        clMaTinhTrang.HeaderText = "Mã Tình Trạng"
        clMaTinhTrang.DataPropertyName = "CbTinhTrang1"
        dgvBaoCao.Columns.Add(clMaTinhTrang)

        Dim clNgayNhap = New DataGridViewTextBoxColumn()
        clNgayNhap.Name = "NgayNhap"
        clNgayNhap.HeaderText = "Ngày nhập"
        clNgayNhap.DataPropertyName = "dtNgay1"
        dgvBaoCao.Columns.Add(clNgayNhap)
        'dgvListHS.ResumeLayout()
    End Sub


    Private Sub checkb_Ngay_CheckedChanged(sender As Object, e As EventArgs) Handles checkB_Ngay.CheckedChanged
        If checkB_Ngay.Checked = True Then
            lb_ChonNgay.Show()
            dtNgay.Show()
        Else

            lb_ChonNgay.Hide()
            dtNgay.Hide()
        End If

    End Sub

    Private Sub checkB_Khoi_CheckedChanged(sender As Object, e As EventArgs) Handles checkB_Khoi.CheckedChanged
        If checkB_Khoi.Checked = True Then
            lb_ChonKhoi.Show()
            cb_Khoi.Show()
        Else
            lb_ChonKhoi.Hide()
            cb_Khoi.Hide()
        End If
    End Sub
    Private Sub loadListPGNByKhoi(Khoi As Khoi_DTO)
        Dim listPGN = New List(Of PhieuGhiNhan_DTO)

        Dim pgndal As PhieuGhiNhan_DAL
        pgndal = New PhieuGhiNhan_DAL()
        result = pgndal.selectALL_ByKhoi(Khoi.StrMaKhoi1, listPGN)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách phiếu ghi nhận theo khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        convert(listPGN)
        'dgvListHS.SuspendLayout()
        dgvBaoCao.Columns.Clear()
        dgvBaoCao.DataSource = Nothing

        dgvBaoCao.AutoGenerateColumns = False
        dgvBaoCao.AllowUserToAddRows = False
        dgvBaoCao.DataSource = listPGN




        Dim clMaPhieu = New DataGridViewTextBoxColumn()
        clMaPhieu.Name = "MaPhieu"
        clMaPhieu.HeaderText = "Mã Phiếu"
        clMaPhieu.DataPropertyName = "StrMaPhieu1"
        dgvBaoCao.Columns.Add(clMaPhieu)

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "Tre"
        clMa.HeaderText = "Tên Trẻ"
        clMa.DataPropertyName = "StrMaTre1"
        dgvBaoCao.Columns.Add(clMa)


        kBus = New Khoi_BUS()
        ' Load LoaiHocSinh list
        Dim listKhoi = New List(Of Khoi_DTO)


        Dim khoidal As Khoi_DAL
        khoidal = New Khoi_DAL()
        result = khoidal.selectALL(listKhoi)

        'result = kBus.selectAll(listKhoi)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If


        Dim clMaKhoi = New DataGridViewTextBoxColumn()
        clMaKhoi.Name = "Khoi"
        clMaKhoi.HeaderText = "Tên Khối"
        clMaKhoi.DataPropertyName = "CbKhoi1"
        dgvBaoCao.Columns.Add(clMaKhoi)

        Dim clMaTinhTrang = New DataGridViewTextBoxColumn()
        clMaTinhTrang.Name = "MaTinhTrang"
        clMaTinhTrang.HeaderText = "Mã Tình Trạng"
        clMaTinhTrang.DataPropertyName = "CbTinhTrang1"
        dgvBaoCao.Columns.Add(clMaTinhTrang)

        Dim clNgayNhap = New DataGridViewTextBoxColumn()
        clNgayNhap.Name = "NgayNhap"
        clNgayNhap.HeaderText = "Ngày nhập"
        clNgayNhap.DataPropertyName = "dtNgay1"
        dgvBaoCao.Columns.Add(clNgayNhap)
        'dgvListHS.ResumeLayout()
    End Sub
    Private Sub loadListPGNByKhoiAndDaTe(NgayNhap As Date, Khoi As Khoi_DTO)
        Dim listPGN = New List(Of PhieuGhiNhan_DTO)

        Dim pgndal As PhieuGhiNhan_DAL
        pgndal = New PhieuGhiNhan_DAL()
        result = PGNBUS.selectALL_ByKhoiAndDate(NgayNhap, Khoi.StrMaKhoi1, listPGN)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách phiếu ghi nhận theo ngày và khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        convert(listPGN)
        'dgvListHS.SuspendLayout()
        dgvBaoCao.Columns.Clear()
        dgvBaoCao.DataSource = Nothing

        dgvBaoCao.AutoGenerateColumns = False
        dgvBaoCao.AllowUserToAddRows = False
        dgvBaoCao.DataSource = listPGN




        Dim clMaPhieu = New DataGridViewTextBoxColumn()
        clMaPhieu.Name = "MaPhieu"
        clMaPhieu.HeaderText = "Mã Phiếu"
        clMaPhieu.DataPropertyName = "StrMaPhieu1"
        dgvBaoCao.Columns.Add(clMaPhieu)

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "Tre"
        clMa.HeaderText = "Tên Trẻ"
        clMa.DataPropertyName = "StrMaTre1"
        dgvBaoCao.Columns.Add(clMa)


        kBus = New Khoi_BUS()
        ' Load LoaiHocSinh list
        Dim listKhoi = New List(Of Khoi_DTO)


        Dim khoidal As Khoi_DAL
        khoidal = New Khoi_DAL()
        result = khoidal.selectALL(listKhoi)

        'result = kBus.selectAll(listKhoi)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If


        Dim clMaKhoi = New DataGridViewTextBoxColumn()
        clMaKhoi.Name = "Khoi"
        clMaKhoi.HeaderText = "Tên Khối"
        clMaKhoi.DataPropertyName = "CbKhoi1"
        dgvBaoCao.Columns.Add(clMaKhoi)

        Dim clMaTinhTrang = New DataGridViewTextBoxColumn()
        clMaTinhTrang.Name = "MaTinhTrang"
        clMaTinhTrang.HeaderText = "Mã Tình Trạng"
        clMaTinhTrang.DataPropertyName = "CbTinhTrang1"
        dgvBaoCao.Columns.Add(clMaTinhTrang)

        Dim clNgayNhap = New DataGridViewTextBoxColumn()
        clNgayNhap.Name = "NgayNhap"
        clNgayNhap.HeaderText = "Ngày nhập"
        clNgayNhap.DataPropertyName = "dtNgay1"
        dgvBaoCao.Columns.Add(clNgayNhap)


        'dgvListHS.ResumeLayout()
    End Sub

    Private Sub bt_BaoCao_Click(sender As Object, e As EventArgs) Handles bt_BaoCao.Click
        Dim khoiDTO = CType(cb_Khoi.SelectedItem, Khoi_DTO)
        If checkB_Khoi.Checked = True And checkB_Ngay.Checked = True Then
            loadListPGNByKhoiAndDaTe(dtNgay.Value.Date, khoiDTO)

            Dim BC As BaoCao_DTO
            BC = New BaoCao_DTO


            '1. Mapping data from GUI control
            BC.MaKhoi1 = cb_Khoi.SelectedValue
            BC.NgayBaoCao1 = dtNgay.Value.Date
            BC.SoLuong1 = dgvBaoCao.RowCount
            BC.MaBaoCao1 = txtMaBaoCao.Text




            '2. Business .....





            '3. Insert to DB
            Dim bcdal As BaoCao_DAL
            bcdal = New BaoCao_DAL()
            Dim result As Result
            result = bcdal.insert(BC)
            If (result.FlagResult = True) Then
                MessageBox.Show("Lưu báo cáo thanh cong.")
            Else
                MessageBox.Show("Them  that bai. Vui long kiem tra lai DB!!!")
            End If

            Return
        End If
        If checkB_Ngay.Checked = True Then

            loadListPGNByDate(dtNgay.Value.Date)

            Dim BC As BaoCao_DTO
            BC = New BaoCao_DTO


            '1. Mapping data from GUI control
            BC.MaKhoi1 = " "
            BC.NgayBaoCao1 = dtNgay.Value.Date
            BC.SoLuong1 = dgvBaoCao.RowCount
            BC.MaBaoCao1 = txtMaBaoCao.Text




            '2. Business .....





            '3. Insert to DB
            Dim bcdal As BaoCao_DAL
            bcdal = New BaoCao_DAL()
            Dim result As Result
            result = bcdal.insert(BC)
            If (result.FlagResult = True) Then
                MessageBox.Show("Lưu báo cáo thanh cong.")
            Else
                MessageBox.Show("Them  that bai. Vui long kiem tra lai DB!!!")
            End If

            Return
        End If
        If checkB_Khoi.Checked = True Then

            loadListPGNByKhoi(khoiDTO)

            Dim BC As BaoCao_DTO
            BC = New BaoCao_DTO


            '1. Mapping data from GUI control
            BC.MaKhoi1 = cb_Khoi.SelectedValue
            BC.SoLuong1 = dgvBaoCao.RowCount
            BC.MaBaoCao1 = txtMaBaoCao.Text




            '2. Business .....





            '3. Insert to DB
            Dim bcdal As BaoCao_DAL
            bcdal = New BaoCao_DAL()
            Dim result As Result
            result = bcdal.insert(BC)
            If (result.FlagResult = True) Then
                MessageBox.Show("Lưu báo cáo thanh cong.")
            Else
                MessageBox.Show("Them  that bai. Vui long kiem tra lai DB!!!")
            End If


            Return
        End If

    End Sub

    Private Sub convert(listPGN As List(Of PhieuGhiNhan_DTO))
        Dim result As Result

        For Each item As PhieuGhiNhan_DTO In listPGN
            Dim tre As Tre_DTO
            tre = New Tre_DTO()
            Dim tredal As Tre_DAL
            tredal = New Tre_DAL()
            result = tredal.ReadTre(item.StrMaTre1, tre)
            item.StrMaTre1 = tre.StrTenTre1

            Dim khoi As Khoi_DTO
            khoi = New Khoi_DTO()
            Dim khoidal As Khoi_DAL
            khoidal = New Khoi_DAL()
            result = khoidal.selectKhoibyMaKhoi(item.CbKhoi1, khoi)
            item.CbKhoi1 = khoi.StrTenKhoi1

            'Dim tt As TinhTrang_DTO
            'tt = New TinhTrang_DTO()
            'Dim ttdal As TinhTrang_DAL
            'ttdal = New TinhTrang_DAL()
            'result = ttdal.selectByID(item.CbTinhTrang1, tt)
            'item.CbTinhTrang1 = tt.StrTenTinhTrang1

            Dim CTBC As CTBaoCao_DTO
            CTBC = New CTBaoCao_DTO


            '1. Mapping data from GUI control
            CTBC.MaPhieuGhiNhan1 = item.StrMaPhieu1
            CTBC.MaBaoCao1 = txtMaBaoCao.Text


            Dim ctbcdal = New CTBaoBao_DAL
            Dim nextMshs As Integer
            result = ctbcdal.buildID(nextMshs)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy tự động mã Tình trạng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Me.Close()
                Return
            End If

            CTBC.MaCTBaoCao1 = nextMshs

            '2. Business .....





            '3. Insert to DB
            Dim bcdal As CTBaoBao_DAL
            bcdal = New CTBaoBao_DAL()

            result = bcdal.insert(CTBC)
            If (result.FlagResult = True) Then
                MessageBox.Show("Lưu CT báo cáo thanh cong.")
            Else
                MessageBox.Show("Them  that bai. Vui long kiem tra lai DB!!!")
            End If





        Next

    End Sub
End Class