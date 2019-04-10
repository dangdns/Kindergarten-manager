Imports QLNT_BUS
Imports QLNT_DTO
Imports Utility
Imports QLNT_DAL
Public Class Frm_XepLop
    Private khoibus As Khoi_BUS
    Private thamsobus As ThamSo_BUS
    Private lopbus As Lop_BUS
    Private treBus As Tre_BUS
    Private chitietlopBus As ChiTietLop_BUS
    Private listTreChuaCoLop As List(Of Tre_DTO)

    Private listTre As List(Of Tre_DTO)
    Private listTre_Added As List(Of Tre_DTO)

    Private Sub Frm_NhapLop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listTreChuaCoLop = New List(Of Tre_DTO)
        listTre = New List(Of Tre_DTO)
        listTre_Added = New List(Of Tre_DTO)
        thamsobus = New ThamSo_BUS()
        lopbus = New Lop_BUS()
        khoibus = New Khoi_BUS()
        treBus = New Tre_BUS()
        chitietlopBus = New ChiTietLop_BUS()
        Dim result As Result
        Dim resultThamSo As Boolean
        khoibus = New Khoi_BUS()
        ' Load si số
        Dim listThamSo = New List(Of ThamSo_DTO)
        Dim ThamSoDTO = New ThamSo_DTO()
        Dim ThamSoDAL = New ThamSo_DAL()
        resultThamSo = ThamSoDAL.ReadTS(ThamSoDTO)
        If (resultThamSo = False) Then
            MessageBox.Show("Lấy danh sách tham số không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        For index As Integer = 1 To ThamSoDTO.IntSiSoMax1
            cb_SiSo.Items.Add(index)
        Next
        ' Load Khoi list
        Dim myCurrencyManager As CurrencyManager
        Dim listKhoi = New List(Of Khoi_DTO)
        Dim khoidal As Khoi_DAL
        khoidal = New Khoi_DAL()

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

        result = treBus.SelectListTreMaChuaDuocXepLop(listTreChuaCoLop)
        If (resultThamSo = False) Then
            MessageBox.Show("Lấy danh sách trẻ chưa có lớp không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        buildGridFROM()
    End Sub
    Private Sub cb_SiSo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_SiSo.SelectedIndexChanged

        DG_XepLop.Rows.Clear()
        For index As Integer = 1 To cb_SiSo.SelectedItem

            DG_XepLop.Rows.Add()
            DG_XepLop.Rows(index - 1).Cells(0).Value = index
        Next
        For Each item As Tre_DTO In listTreChuanBiXep
            listTreChuaCoLop.Add(item)
        Next
        buildGridFROM()
    End Sub
    Private Sub buildGridFROM()
        dgvListHS_FROM.Columns.Clear()
        dgvListHS_FROM.DataSource = Nothing

        dgvListHS_FROM.AutoGenerateColumns = False
        dgvListHS_FROM.AllowUserToAddRows = False
        dgvListHS_FROM.DataSource = listTreChuaCoLop

        Dim clMaTre = New DataGridViewTextBoxColumn()
        clMaTre.Name = "MaTre"
        clMaTre.HeaderText = "Mã trẻ"
        clMaTre.DataPropertyName = "StrID1"
        dgvListHS_FROM.Columns.Add(clMaTre)

        Dim clHoTenTre = New DataGridViewTextBoxColumn()
        clHoTenTre.Name = "HoVaTenTre"
        clHoTenTre.HeaderText = "Họ và tên trẻ"
        clHoTenTre.DataPropertyName = "StrTenTre1"
        dgvListHS_FROM.Columns.Add(clHoTenTre)


        Dim clNgaySinh = New DataGridViewTextBoxColumn()
        clNgaySinh.Name = "NgaySinh"
        clNgaySinh.HeaderText = "Ngày sinh"
        clNgaySinh.DataPropertyName = "DtNgaySinh1"
        dgvListHS_FROM.Columns.Add(clNgaySinh)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvListHS_FROM.DataSource)
        myCurrencyManager.Refresh()
    End Sub
    Dim listTreChuanBiXep As New List(Of Tre_DTO)
    Private Sub DG_NhapMaTre(sender As Object, e As DataGridViewCellEventArgs) Handles DG_XepLop.CellEndEdit
        Dim row As Integer
        Dim col As Integer

        col = DG_XepLop.CurrentCell.ColumnIndex
        row = DG_XepLop.CurrentCell.RowIndex
        Dim treDTO1 As Tre_DTO
        treDTO1 = New Tre_DTO
        If DG_XepLop.Rows(row).Cells(DG_MaTre.Index).Value = Nothing Then
            treDTO1.StrID1 = ""
        Else

            treDTO1.StrID1 = DG_XepLop.Rows(row).Cells(DG_MaTre.Index).Value
        End If
        If treBus.isIDLessThan8Char(treDTO1) = True Then
            If treBus.isValidName(treDTO1) = True Then


                Dim MaTre As String
                MaTre = DG_XepLop.CurrentCell.Value.ToString


                If col = 1 Then
                    Dim treDTO = New Tre_DTO
                    Dim result As Result
                    Dim chitietDTO = New ChiTietLop_DTO
                    Dim chiTietBUS = New ChiTietLop_BUS
                    Dim treDAL = New Tre_DAL

                    result = treDAL.ReadTre(MaTre, treDTO)
                    If (result.FlagResult = False) Then
                        MessageBox.Show("Lấy mã trẻ không thành công. Vui lòng kiểm tra lại mã trẻ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        System.Console.WriteLine(result.SystemMessage)
                        Return
                    End If
                    result = chitietlopBus.checkChiTietLop(DG_XepLop.Rows(row).Cells(DG_MaTre.Index).Value, chitietDTO)
                    If (result.FlagResult = False) Then
                        MessageBox.Show("Kiểm tra trẻ trong danh sách chi tiết lớp không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        System.Console.WriteLine(result.SystemMessage)
                        Return
                    End If
                    If chitietDTO.StrMaTre1 = DG_XepLop.Rows(row).Cells(DG_MaTre.Index).Value Then
                        MessageBox.Show("Trẻ đã nằm trong lớp khác. Vui lòng nhập trẻ khác!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        DG_XepLop.Rows(row).Cells(DG_MaTre.Index).Value = ""
                        Return
                    End If
                    Dim x As Integer
                    x = 0
                    For Each tre As Tre_DTO In listTreChuaCoLop

                        If treDTO.StrID1 = tre.StrID1 Then
                            listTreChuaCoLop.RemoveAt(x)
                            listTreChuanBiXep.Add(tre)
                            buildGridFROM()
                            GoTo end_of_for
                        End If
                        x = x + 1
                    Next
end_of_for:


                    DG_XepLop.Rows(row).Cells(DG_TenTre.Index).Value = treDTO.StrTenTre1
                    If (treDTO.IntGioiTinh1 = 1) Then

                        DG_XepLop.Rows(row).Cells(DG_GioiTInh.Index).Value = "Nam"
                    Else

                        DG_XepLop.Rows(row).Cells(DG_GioiTInh.Index).Value = "Nữ"
                    End If
                    'SapXepColumnWidth()
                    'AdjustHeightOfGridBasedOnRows(DG_XepLop)
                End If
            Else
                MessageBox.Show("Họ tên không đúng. Vui lòng kiểm tra lại!")
                Return
            End If
        Else
            MessageBox.Show("Vui lòng nhập đầy đủ 8 kí tự cho mã trẻ.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
    End Sub
    Dim dateTimePicker As New DateTimePicker

    Dim mem As New Integer
    Private Sub DG_DateTimePicker(sender As Object, e As DataGridViewCellEventArgs) Handles DG_XepLop.CellClick
        Dim row As Integer

        Dim col As Integer

        col = DG_XepLop.CurrentCell.ColumnIndex
        row = DG_XepLop.CurrentCell.RowIndex

        If (col = DG_NgayNhapHoc.Index) Then
            DG_XepLop.Controls.Add(dateTimePicker)
            Dim rec As Rectangle = DG_XepLop.GetCellDisplayRectangle(col, row, True)
            dateTimePicker.Size = New Size(rec.Width, rec.Height)
            dateTimePicker.Location = New Point(rec.X, rec.Y)

            ' dateTimePicker.Value = DG_XepLop.CurrentCell.Value
            '// Now make it visible  
            dateTimePicker.Visible = True

            AddHandler dateTimePicker.ValueChanged, AddressOf dateTimePicker_ValueChanged
        End If

        'SapXepColumnWidth()
        'AdjustHeightOfGridBasedOnRows(DG_XepLop)


    End Sub
    Private Sub dateTimePicker_ValueChanged(sender As Object, e As System.EventArgs)
        DG_XepLop.CurrentCell.Value = dateTimePicker.Value.Date
    End Sub
    Private Sub DG_XepLop_CellLeave(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_XepLop.CellLeave
        dateTimePicker.Visible = False
    End Sub

    Private Sub DeleteRow(sender As Object, e As DataGridViewRowEventArgs) Handles DG_XepLop.UserDeletedRow

        If IDOfDeltedRow <> "" Then
            Dim result As Result
            Dim tre As Tre_DTO
            tre = New Tre_DTO
            result = treBus.ReadTre(IDOfDeltedRow.ToString, tre)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy trẻ không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
            For Each item As Tre_DTO In listTreChuanBiXep
                If item.StrID1 = tre.StrID1 Then

                    listTreChuanBiXep.Remove(item)
                End If
            Next
            listTreChuaCoLop.Add(tre)
            buildGridFROM()
        End If

        Dim DG2 As New DataGridView


        Dim DG2Rows = New List(Of DataGridViewRow)

        For Each DG_XepLopRow As DataGridViewRow In DG_XepLop.Rows

            If (Not DG_XepLopRow.IsNewRow) Then

                Dim DG2Row = CType(DG_XepLopRow.Clone(), DataGridViewRow)

                For Each cell As DataGridViewCell In DG_XepLopRow.Cells
                    DG2Row.Cells(cell.ColumnIndex).Value = cell.Value
                Next

                DG2Rows.Add(DG2Row)

            End If

        Next

        DG2.Columns.Clear()

        For Each column As DataGridViewColumn In DG_XepLop.Columns
            DG2.Columns.Add(CType(column.Clone(), DataGridViewColumn))
        Next

        DG2.Rows.AddRange(DG2Rows.ToArray())
        cb_SiSo.SelectedIndex = cb_SiSo.SelectedIndex - 1


        Dim DG_XepLopRows = New List(Of DataGridViewRow)

        For Each DG2Row As DataGridViewRow In DG2.Rows

            If (Not DG2Row.IsNewRow) Then

                Dim DG_XepLopRow = CType(DG2Row.Clone(), DataGridViewRow)

                For Each cell As DataGridViewCell In DG2Row.Cells
                    DG_XepLopRow.Cells(cell.ColumnIndex).Value = cell.Value
                Next

                DG_XepLopRows.Add(DG_XepLopRow)

            End If

        Next

        DG_XepLop.Columns.Clear()

        For Each column As DataGridViewColumn In DG2.Columns
            DG_XepLop.Columns.Add(CType(column.Clone(), DataGridViewColumn))
        Next


        DG_XepLop.Rows.AddRange(DG_XepLopRows.ToArray())

        For index As Integer = 1 To cb_SiSo.SelectedItem

            DG_XepLop.Rows(index - 1).Cells(0).Value = index
        Next
    End Sub


    Dim listLopByMaKhoi = New List(Of Lop_DTO)



    Private Sub cbKhoi_SELECTedIndexChanged(sender As Object, e As EventArgs) Handles cb_Khoi.SelectedIndexChanged


        Dim khoi = CType(cb_Khoi.SelectedItem, Khoi_DTO)

        Dim result As Result
        result = lopbus.selectLopChuaDuocXep_ByMaKhoi(khoi.StrMaKhoi1, listLopByMaKhoi)
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

    Private Sub bt_XepLop_Click(sender As Object, e As EventArgs) Handles bt_XepLop.Click


        Dim lop = CType(cb_TenLop.SelectedItem, Lop_DTO)

        Dim listTre = New List(Of Tre_DTO)

        Dim listChiTietLop = New List(Of ChiTietLop_DTO)
        For index As Integer = 0 To cb_SiSo.Text - 1
            If (DG_XepLop.Rows(index).Cells(DG_MaTre.Index).Value = "") Then
                MessageBox.Show("Vui lòng nhập đầy đủ trẻ để xếp lớp", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Next
        For index As Integer = 0 To cb_SiSo.Text - 1

            Dim chitietlopDTO As ChiTietLop_DTO
            chitietlopDTO = New ChiTietLop_DTO
            Dim tre = CType(DG_XepLop.Rows(index).DataBoundItem, Tre_DTO)
            tre = New Tre_DTO
            tre.StrID1 = DG_XepLop.Rows(index).Cells(DG_MaTre.Index).Value
            If (DG_XepLop.Rows(index).Cells(DG_NgayNhapHoc.Index).Value = Nothing) Then
                tre.DtNgayNhapHoc1 = "1/1/1965"
            Else
                tre.DtNgayNhapHoc1 = DG_XepLop.Rows(index).Cells(DG_NgayNhapHoc.Index).Value

            End If
            If (DG_XepLop.Rows(index).Cells(DG_GhiChu.Index).Value = Nothing) Then
                tre.StrGhiChu1 = ""
            Else
                tre.StrGhiChu1 = DG_XepLop.Rows(index).Cells(DG_GhiChu.Index).Value

            End If
            listChiTietLop.Add(chitietlopDTO)
            listTre.Add(tre)
        Next

        Dim result As Result
        Dim lop1 = New ChiTietLop_DTO(lop.StrMaLop1)

        result = chitietlopBus.deleteLop(lop1)
        If (result.FlagResult = False) Then
            MessageBox.Show("Xoá nguyên lớp cũ không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        For index As Integer = 0 To cb_SiSo.Text - 1
            Dim lop_hs = New ChiTietLop_DTO(lop.StrMaLop1, listTre(index).StrID1)
            Dim tre = New Tre_DTO(listTre(index).StrID1, listTre(index).StrGhiChu1, listTre(index).DtNgayNhapHoc1.Date)
            Dim lopDTO = New Lop_DTO(lop.StrMaLop1, cb_SiSo.SelectedItem)



            result = chitietlopBus.deleteMaTre(lop_hs)
            If (result.FlagResult = False) Then
                MessageBox.Show("Xoá trẻ khỏi lóp cũ không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
            result = lopbus.updateSiSO(lopDTO)

            If (result.FlagResult = False) Then
                MessageBox.Show("Update sí số lớp không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
            result = treBus.updateGhiChuAndNgayNhapHoc(tre)
            If (result.FlagResult = False) Then
                MessageBox.Show("Update trẻ không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
            result = chitietlopBus.insert(lop_hs)
            If (result.FlagResult = False) Then
                MessageBox.Show("Thêm chi tiế tlớp không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If

        Next
        MessageBox.Show("Tạo lớp xong", "Done", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.Close()
        'For Each tre As Tre_DTO In listTre


        '    Dim lop_hs = New ChiTietLop_DTO(lop.StrMaLop1, tre.StrID1, chitietlopDTO.StrGhiChu1, chitietlopDTO.DtNgayNhapHoc2)

        'Next
    End Sub

    Private Sub bt_Thoat_Click(sender As Object, e As EventArgs) Handles bt_Thoat.Click
        Me.Close()
    End Sub

    Private Sub cb_TenLop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_TenLop.SelectedIndexChanged
        DG_XepLop.Rows.Clear()
        For index As Integer = 1 To cb_SiSo.SelectedItem

            DG_XepLop.Rows.Add()
            DG_XepLop.Rows(index - 1).Cells(0).Value = index
        Next
    End Sub
    Private IndexOfDeletingRow As Integer
    Private IDOfDeltedRow
    Private Sub DeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles DG_XepLop.UserDeletingRow
        IndexOfDeletingRow = e.Row.Index
        IDOfDeltedRow = DG_XepLop.Rows(IndexOfDeletingRow).Cells(1).Value
    End Sub
End Class