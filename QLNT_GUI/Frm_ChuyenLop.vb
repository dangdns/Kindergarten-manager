Imports QLNT_BUS
Imports QLNT_DTO
Imports Utility

Public Class Frm_ChuyenLop

    Private khoiBus As Khoi_BUS
    Private lopBus As Lop_BUS
    Private treBus As Tre_BUS
    Private chitietlopBus As ChiTietLop_BUS
    Private thamsoBus As ThamSo_BUS
    Private listTre As List(Of Tre_DTO)
    Private listTre_Deleted As List(Of Tre_DTO)
    Private listTre_Addded As List(Of Tre_DTO)
    Private listLopFROM As List(Of Lop_DTO)
    Private listLopTO As List(Of Lop_DTO)

    Private Sub Frm_ChuyenLop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listLopFROM = New List(Of Lop_DTO)
        khoiBus = New Khoi_BUS()
        lopBus = New Lop_BUS()
        treBus = New Tre_BUS()
        thamsoBus = New ThamSo_BUS()
        chitietlopBus = New ChiTietLop_BUS()

        listTre = New List(Of Tre_DTO)
        listTre_Deleted = New List(Of Tre_DTO)
        listTre_Addded = New List(Of Tre_DTO)

        ' Load Khoi list vào 2 cb
        Dim listKhoi = New List(Of Khoi_DTO)
        Dim result = khoiBus.selectAll(listKhoi)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbKhoi.DataSource = New BindingSource(listKhoi, String.Empty)
        cbKhoi.DisplayMember = "StrTenKhoi1"
        cbKhoi.ValueMember = "StrMaKhoi1"
        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(cbKhoi.DataSource)
        myCurrencyManager.Refresh()
        If (listKhoi.Count > 0) Then
            cbKhoi.SelectedIndex = 0
        End If

        cbKhoi2.DataSource = New BindingSource(listKhoi, String.Empty)

        cbKhoi2.DisplayMember = "StrTenKhoi1"
        cbKhoi2.ValueMember = "StrMaKhoi1"
        myCurrencyManager = Me.BindingContext(cbKhoi2.DataSource)
        myCurrencyManager.Refresh()
        If (listKhoi.Count > 0) Then
            cbKhoi2.SelectedIndex = 0
        End If
    End Sub

    Private Sub cbKhoi1_SELECTedIndexChanged(sender As Object, e As EventArgs) Handles cbKhoi.SelectedIndexChanged
        dgvListHS_FROM.DataSource = Nothing
        '  dgvListHS_To.DataSource = Nothing

        Try
            Dim khoi = CType(cbKhoi.SelectedItem, Khoi_DTO)
            Dim result = lopBus.selectALL_ByMaKhoi(khoi.StrMaKhoi1, listLopFROM)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh sách Lớp không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Me.Close()
                Return
            End If

            ' Load Lop list
            cbLop_FROM.DataSource = New BindingSource(listLopFROM, String.Empty)
            cbLop_FROM.DisplayMember = "StrTenLop1"
            cbLop_FROM.ValueMember = "StrMaLop1"
            Dim myCurrencyManager As CurrencyManager = Me.BindingContext(cbLop_FROM.DataSource)
            myCurrencyManager.Refresh()
            If (listLopFROM.Count > 0) Then
                cbLop_FROM.SelectedIndex = 0
            End If
            If cbKhoi.Text = cbKhoi2.Text Then
                Dim listLopTo = buildListLopTo(listLopFROM)
                cbLop_To.DataSource = New BindingSource(listLopTo, String.Empty)
                cbLop_To.DisplayMember = "StrTenLop1"
                cbLop_To.ValueMember = "StrMaLop1"
                Dim myCurrencyManager1 As CurrencyManager = Me.BindingContext(cbLop_To.DataSource)
                myCurrencyManager1.Refresh()
                If (listLopTo.Count > 0) Then
                    cbLop_To.SelectedIndex = 0
                End If
            End If

        Catch ex As Exception
            System.Console.WriteLine(ex.StackTrace)
            Return
        End Try
    End Sub
    Private Sub cbKhoi2_SELECTedIndexChanged(sender As Object, e As EventArgs) Handles cbKhoi2.SelectedIndexChanged
        '  dgvListHS_FROM.DataSource = Nothing
        dgvListHS_To.DataSource = Nothing
        listLopTO = New List(Of Lop_DTO)
        Try
            Dim khoi2 = CType(cbKhoi2.SelectedItem, Khoi_DTO)
            Dim result = lopBus.selectALL_ByMaKhoiWhereNotFull(khoi2.StrMaKhoi1, listLopTO)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh sách Lớp không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Me.Close()
                Return
            End If

            ' Load Lop list
            If cbKhoi.Text = cbKhoi2.Text Then
                Dim listLopTo = buildListLopTo(listLopFROM)
                cbLop_To.DataSource = New BindingSource(listLopTo, String.Empty)
                cbLop_To.DisplayMember = "StrTenLop1"
                cbLop_To.ValueMember = "StrMaLop1"
                Dim myCurrencyManager1 As CurrencyManager = Me.BindingContext(cbLop_To.DataSource)
                myCurrencyManager1.Refresh()
                If (listLopTo.Count > 0) Then
                    cbLop_To.SelectedIndex = 0
                End If
            Else
                cbLop_To.DataSource = New BindingSource(listLopTo, String.Empty)
                cbLop_To.DisplayMember = "StrTenLop1"
                cbLop_To.ValueMember = "StrMaLop1"
                Dim myCurrencyManager1 As CurrencyManager = Me.BindingContext(cbLop_To.DataSource)
                myCurrencyManager1.Refresh()
                If (listLopTo.Count > 0) Then
                    cbLop_To.SelectedIndex = 0
                End If

            End If

        Catch ex As Exception
            System.Console.WriteLine(ex.StackTrace)
            Return
        End Try
    End Sub

    Private Sub btnChuyenHS_Click(sender As Object, e As EventArgs) Handles btnChuyenHS.Click
        Try
            Dim lopFROM = CType(cbLop_FROM.SelectedItem, Lop_DTO)
            Dim lopTo = CType(cbLop_To.SelectedItem, Lop_DTO)
            Dim thamsoDTO = New ThamSo_DTO
            Dim result As Result
            Dim listchitietlopDTO As List(Of ChiTietLop_DTO)
            listchitietlopDTO = New List(Of ChiTietLop_DTO)
            'Kiem tra si số lớp chuyển qua
            result = thamsoBus.selectAll(thamsoDTO)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy tham số không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If

            result = chitietlopBus.selectALL_ByMaLop(lopTo.StrMaLop1, listchitietlopDTO)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh sách lớp không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If

            If (thamsoDTO.IntSiSoMax1 <= listchitietlopDTO.Count) Then
                MessageBox.Show("Sỉ số đã vượt mức tối đa cho phép cho một lớp. Vui lòng kiểm tra lại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
            For Each treDTO As Tre_DTO In listTre_Deleted
                Dim chitietlop_tre_deleted = New ChiTietLop_DTO(lopFROM.StrMaLop1, treDTO.StrID1)
                Dim chitietlop_tre_added = New ChiTietLop_DTO(lopTo.StrMaLop1, treDTO.StrID1)
                lopFROM.IntSiSo1 = lopFROM.IntSiSo1 - 1
                lopTo.IntSiSo1 = lopTo.IntSiSo1 + 1
                Result = chitietlopBus.deleteMaTreMaLop(chitietlop_tre_deleted)
                If (result.FlagResult = False) Then
                    MessageBox.Show("Xoá trẻ khỏi lóp cũ không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                    Return
                End If
                result = lopBus.updateSiSO(lopFROM)
                If (result.FlagResult = False) Then
                    MessageBox.Show("Update sỉ số lóp cũ không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                    Return
                End If

                result = chitietlopBus.insert(chitietlop_tre_added)
                If (result.FlagResult = False) Then
                    MessageBox.Show("Thêm trẻ vô lóp mới không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                    Return
                End If
                result = lopBus.updateSiSO(lopTo)
                If (result.FlagResult = False) Then
                    MessageBox.Show("Update sỉ số lóp mới không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                    Return
                End If
            Next
            loadListTreFROM(lopFROM.StrMaLop1)
            MessageBox.Show("Chuyển Lớp cho học sinh thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgvListHS_FROM.Refresh()
            dgvListHS_To.Refresh()
            Me.Close()
        Catch ex As Exception
            System.Console.WriteLine(ex.StackTrace)
            Return

        End Try
    End Sub



    Private Function buildListLopTo(listLopFROM As List(Of Lop_DTO)) As List(Of Lop_DTO)
        Dim listLopTo = New List(Of Lop_DTO)
        If (listLopFROM.Count < 1) Then
            Return listLopTo
        End If
        For n = 0 To listLopFROM.Count - 1
            If (n <> cbLop_FROM.SelectedIndex) Then
                listLopTo.Add(listLopFROM(n))
            End If
        Next n
        Return listLopTo
    End Function


    Private Sub cbLop_FROM_SELECTedIndexChanged(sender As Object, e As EventArgs) Handles cbLop_FROM.SelectedIndexChanged
        Try

            Dim lopFROM = CType(cbLop_FROM.SelectedItem, Lop_DTO)
            loadListTreFROM(lopFROM.StrMaLop1)
            If cbKhoi.Text = cbKhoi2.Text Then
                Dim listLopTo = buildListLopTo(listLopFROM)
                cbLop_To.DataSource = New BindingSource(listLopTo, String.Empty)
                cbLop_To.DisplayMember = "StrTenLop1"
                cbLop_To.ValueMember = "StrMaLop1"
                Dim myCurrencyManager1 As CurrencyManager = Me.BindingContext(cbLop_To.DataSource)
                myCurrencyManager1.Refresh()
                If (listLopTo.Count > 0) Then
                    cbLop_To.SelectedIndex = 0
                End If
            End If

            buildGridFROM()
            buildGridTo()
        Catch ex As Exception
            System.Console.WriteLine(ex.StackTrace)
            Return
        End Try
    End Sub
    Private Sub loadListTreFROM(maLop As Integer)
        listTre.Clear()
        Dim result As Result
        result = treBus.selectALL_ByMaLop(maLop, listTre)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách trẻ theo mã lớp không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        listTre_Addded.Clear()
        listTre_Deleted.Clear()
    End Sub

    Private Sub buildGridFROM()
        dgvListHS_FROM.Columns.Clear()
        dgvListHS_FROM.DataSource = Nothing

        dgvListHS_FROM.AutoGenerateColumns = False
        dgvListHS_FROM.AllowUserToAddRows = False
        dgvListHS_FROM.DataSource = listTre

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

    Private Sub buildGridTo()

        dgvListHS_To.Columns.Clear()
        dgvListHS_To.DataSource = Nothing

        dgvListHS_To.AutoGenerateColumns = False
        dgvListHS_To.AllowUserToAddRows = False
        dgvListHS_To.DataSource = listTre_Addded

        Dim clMaTre = New DataGridViewTextBoxColumn()
        clMaTre.Name = "MaTre"
        clMaTre.HeaderText = "Mã tre"
        clMaTre.DataPropertyName = "StrID1"
        dgvListHS_To.Columns.Add(clMaTre)
        clMaTre.ReadOnly = True

        Dim clHoTenTre = New DataGridViewTextBoxColumn()
        clHoTenTre.Name = "HoVaTenTre"
        clHoTenTre.HeaderText = "Họ và tên trẻ"
        clHoTenTre.DataPropertyName = "StrTenTre1"
        dgvListHS_To.Columns.Add(clHoTenTre)




        Dim clNgaySinh = New DataGridViewTextBoxColumn()
        clNgaySinh.Name = "NgaySinh"
        clNgaySinh.HeaderText = "Ngày Sinh"
        clNgaySinh.DataPropertyName = "DtNgaySinh1"
        dgvListHS_To.Columns.Add(clNgaySinh)
        clNgaySinh.ReadOnly = False

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvListHS_FROM.DataSource)
        myCurrencyManager.Refresh()
    End Sub



    Private Sub btnFROMTo_Click(sender As Object, e As EventArgs) Handles btnFROMTo.Click

        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListHS_FROM.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListHS.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListHS_FROM.RowCount) Then
            Try
                Dim tre = CType(dgvListHS_FROM.Rows(currentRowIndex).DataBoundItem, Tre_DTO)

                listTre.Remove(tre)
                listTre_Deleted.Add(tre)
                listTre_Addded.Add(tre)

                buildGridFROM()
                buildGridTo()

            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub btnToFROM_Click(sender As Object, e As EventArgs) Handles btnToFROM.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListHS_To.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListHS.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListHS_To.RowCount) Then
            Try
                Dim tre = CType(dgvListHS_To.Rows(currentRowIndex).DataBoundItem, Tre_DTO)

                listTre_Addded.Remove(tre)
                listTre_Deleted.Remove(tre)
                listTre.Add(tre)

                buildGridFROM()
                buildGridTo()

            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub dgvListHS_FROM_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvListHS_FROM.DataError
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListHS_FROM.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListHS.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListHS_FROM.RowCount) Then
            Try
                Dim hs = CType(dgvListHS_FROM.Rows(currentRowIndex).DataBoundItem, Tre_DTO)

                MessageBox.Show("Test DataError:" + dgvListHS_FROM.CurrentCell.Value, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dgvListHS_FROM.CancelEdit()
                'storeValue = hs.NgaySinh
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub
End Class