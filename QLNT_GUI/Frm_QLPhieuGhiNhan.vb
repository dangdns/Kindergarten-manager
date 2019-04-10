Imports QLNT_BUS
Imports QLNT_DTO
Imports Utility
Imports QLNT_DAL
Public Class Frm_QLPhieuGhiNhan
    Private kBus As Khoi_BUS
    Private ttBus As TinhTrang_BUS

    Private Sub loadListPGN(ID As String)
        Dim listPGN = New List(Of PhieuGhiNhan_DTO)
        Dim result As Result
        Dim pgndal As PhieuGhiNhan_DAL
        pgndal = New PhieuGhiNhan_DAL()
        result = pgndal.selectALL_ByID(ID, listPGN)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách học sinh theo loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListHS.SuspendLayout()
        dgvPGN.Columns.Clear()
        dgvPGN.DataSource = Nothing

        dgvPGN.AutoGenerateColumns = False
        dgvPGN.AllowUserToAddRows = False
        dgvPGN.DataSource = listPGN

        Dim clMaPhieu = New DataGridViewTextBoxColumn()
        clMaPhieu.Name = "MaPhieu"
        clMaPhieu.HeaderText = "Mã Phiếu"
        clMaPhieu.DataPropertyName = "StrMaPhieu1"
        dgvPGN.Columns.Add(clMaPhieu)

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "MaTre"
        clMa.HeaderText = "Mã Trẻ"
        clMa.DataPropertyName = "StrMaTre1"
        dgvPGN.Columns.Add(clMa)



        Dim clMaKhoi = New DataGridViewTextBoxColumn()
        clMaKhoi.Name = "MaKhoi"
        clMaKhoi.HeaderText = "Mã Khối"
        clMaKhoi.DataPropertyName = "CbKhoi1"
        dgvPGN.Columns.Add(clMaKhoi)

        Dim clMaTinhTrang = New DataGridViewTextBoxColumn()
        clMaTinhTrang.Name = "MaTinhTrang"
        clMaTinhTrang.HeaderText = "Mã Tình Trạng"
        clMaTinhTrang.DataPropertyName = "CbTinhTrang1"
        dgvPGN.Columns.Add(clMaTinhTrang)

        Dim clNgay = New DataGridViewTextBoxColumn()
        clNgay.Name = "NgayNhap"
        clNgay.HeaderText = "Ngày Nhập"
        clNgay.DataPropertyName = "DtNgay1"
        dgvPGN.Columns.Add(clNgay)

        Dim clGhiChu = New DataGridViewTextBoxColumn()
        clGhiChu.Name = "GhiChu"
        clGhiChu.HeaderText = "Ghi chú"
        clGhiChu.DataPropertyName = "strGhiChu1"
        dgvPGN.Columns.Add(clGhiChu)
        'dgvListHS.ResumeLayout()
    End Sub

    Private Sub Frm_QLPhieuGhiNhan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kBus = New Khoi_BUS()
        ' Load LoaiHocSinh list
        Dim listKhoi = New List(Of Khoi_DTO)
        Dim result As Result

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
        cbKhoi.DataSource = New BindingSource(listKhoi, String.Empty)
        cbKhoi.DisplayMember = "StrTenKhoi1"
        cbKhoi.ValueMember = "StrMaKhoi1"

        'binding tình trạng

        ttBus = New TinhTrang_BUS()
        ' Load LoaiHocSinh list
        Dim listTinhTrang = New List(Of TinhTrang_DTO)


        Dim tinhtrangdal As TinhTrang_DAL
        tinhtrangdal = New TinhTrang_DAL()
        result = tinhtrangdal.selectALL(listTinhTrang)

        'result = kBus.selectAll(listKhoi)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách tình trạng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbTinhTrang.DataSource = New BindingSource(listTinhTrang, String.Empty)
        cbTinhTrang.DisplayMember = "StrTenTinhTrang1"
        cbTinhTrang.ValueMember = "IntMaTinhTrang1"
    End Sub

    Private Sub dgvPGN_SELECTionChanged(sender As Object, e As EventArgs) Handles dgvPGN.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvPGN.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListHS.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvPGN.RowCount) Then
            Try
                Dim pgn = CType(dgvPGN.Rows(currentRowIndex).DataBoundItem, PhieuGhiNhan_DTO)
                cbID.Text = pgn.StrMaTre1
                'txtHoTen.Text = hs.HoTen
                cbTinhTrang.SelectedValue = pgn.CbTinhTrang1
                cbKhoi.SelectedValue = pgn.CbKhoi1
                dtNgay.Value = pgn.DtNgay1
                txtMaPhieu.Text = pgn.StrMaPhieu1
                txtGhiChu.Text = pgn.StrGhiChu1

            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)



            End Try

        End If
    End Sub



    Private Sub cbID_TextChanged(sender As Object, e As EventArgs) Handles cbID.TextChanged
        If (cbID.Text.Length = 8) Then
            Dim treDTO = New Tre_DTO
            Dim result As Result
            Dim treDAL = New Tre_DAL
            result = treDAL.ReadTre(cbID.Text, treDTO)
            If (result.FlagResult = False Or treDTO.StrTenTre1 Is Nothing) Then
                MessageBox.Show("Lấy thông tin trẻ không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
            txtHoTen.Text = treDTO.StrTenTre1


        End If
    End Sub

    Private Sub btSua_Click(sender As Object, e As EventArgs) Handles btSua.Click
        Dim PGN As PhieuGhiNhan_DTO
        PGN = New PhieuGhiNhan_DTO


        '1. Mapping data from GUI control
        PGN.StrMaPhieu1 = txtMaPhieu.Text
        PGN.StrMaTre1 = cbID.Text
        PGN.CbKhoi1 = cbKhoi.SelectedValue
        PGN.CbTinhTrang1 = cbTinhTrang.SelectedValue
        PGN.DtNgay1 = dtNgay.Value
        '2. Business .....

        Dim pgnbus As PhieuGhiNhan_BUS
        pgnbus = New PhieuGhiNhan_BUS



        ''

        '3. Insert to DB
        Dim pgndal As PhieuGhiNhan_DAL
        pgndal = New PhieuGhiNhan_DAL()
        Dim result As Result
        result = pgndal.update(PGN)
        If (result.FlagResult = True) Then
            MessageBox.Show("Cap nhap PGN thanh cong.")
        Else
            MessageBox.Show("Cap nhap that bai. Vui long kiem tra lai DB!!!")
        End If
    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        Dim PGN As PhieuGhiNhan_DTO
        PGN = New PhieuGhiNhan_DTO


        '1. Mapping data from GUI control
        PGN.StrMaPhieu1 = txtMaPhieu.Text

        '3. Delete from DB
        Dim pgndal As PhieuGhiNhan_DAL
        pgndal = New PhieuGhiNhan_DAL()
        Dim result As Result
        result = pgndal.delete(PGN.StrMaPhieu1)
        If (result.FlagResult = True) Then
            MessageBox.Show("Xoa Tre thanh cong.")
        Else
            MessageBox.Show("Xoa  that bai. Vui long kiem tra lai DB!!!")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim listID = New List(Of Tre_DTO)
        Dim result As Result


        Dim tredal As Tre_DAL
        tredal = New Tre_DAL()
        result = tredal.selectID(listID, TextBox1.Text)

        'result = kBus.selectAll(listKhoi)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách ID không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbID1.DataSource = New BindingSource(listID, String.Empty)
        cbID1.DisplayMember = "StrID1"
        cbID1.ValueMember = "StrID1"
        If (cbID1.SelectedValue IsNot Nothing) Then
            loadListPGN(cbID1.SelectedValue)
        End If

    End Sub


End Class