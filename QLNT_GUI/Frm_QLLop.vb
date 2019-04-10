Imports QLNT_BUS
Imports QLNT_DTO
Imports Utility

Public Class Frm_QLLop
    Private lopBus As Lop_BUS
    Private khoiBus As Khoi_BUS

    Private Sub cbKhoiFilter_SELECTedIndexChanged(sender As Object, e As EventArgs) Handles cbKhoiFilter.SelectedIndexChanged

        Dim khoi = CType(cbKhoiFilter.SelectedItem, Khoi_DTO)
        loadListLop(khoi.StrMaKhoi1)
    End Sub
    Private Sub loadListLop(maKhoi As Integer)
        Dim listLop = New List(Of Lop_DTO)
        Dim result As Result
        result = lopBus.selectALL_ByMaKhoi(maKhoi, listLop)

        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Lớp theo Khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListLop.SuspendLayout()
        dgvListLop.Columns.Clear()
        dgvListLop.DataSource = Nothing

        dgvListLop.AutoGenerateColumns = False
        dgvListLop.AllowUserToAddRows = False
        dgvListLop.DataSource = listLop

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "MaLop"
        clMa.HeaderText = "Mã Lớp"
        clMa.DataPropertyName = "StrMaLop1"
        dgvListLop.Columns.Add(clMa)

        Dim clTenHocKy = New DataGridViewTextBoxColumn()
        clTenHocKy.Name = "TenLop"
        clTenHocKy.HeaderText = "Tên Lớp"
        clTenHocKy.DataPropertyName = "StrTenLop1"
        dgvListLop.Columns.Add(clTenHocKy)

        Dim clSiSo = New DataGridViewTextBoxColumn()
        clSiSo.Name = "SiSo"
        clSiSo.HeaderText = "Sỉ số lớp"
        clSiSo.DataPropertyName = "IntSiSo1"
        dgvListLop.Columns.Add(clSiSo)

        Dim clMaKhoi = New DataGridViewTextBoxColumn()
        clMaKhoi.Name = "MaKhoi"
        clMaKhoi.HeaderText = "Mã khối"
        clMaKhoi.DataPropertyName = "StrMaKhoi1"
        dgvListLop.Columns.Add(clMaKhoi)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvListLop.DataSource)
        myCurrencyManager.Refresh()
    End Sub
    Private Sub Frm_QLLop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lopBus = New Lop_BUS()
        khoiBus = New Khoi_BUS()

        ' Load Khoi list
        Dim listKhoi = New List(Of Khoi_DTO)
        Dim result = khoiBus.selectAll(listKhoi)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbKhoiFilter.DataSource = New BindingSource(listKhoi, String.Empty)
        cbKhoiFilter.DisplayMember = "StrTenKhoi1"
        cbKhoiFilter.ValueMember = "StrMaKhoi1"
        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(cbKhoiFilter.DataSource)
        myCurrencyManager.Refresh()
        If (listKhoi.Count > 0) Then
            cbKhoiFilter.SelectedIndex = 0
        End If
        Dim khoi = CType(cbKhoiFilter.SelectedItem, Khoi_DTO)
        loadListLop(khoi.StrMaKhoi1)
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListLop.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListLop.RowCount) Then
            Try
                '1. Map data from GUI
                Dim lop = CType(dgvListLop.Rows(currentRowIndex).DataBoundItem, Lop_DTO)
                lop.StrTenLop1 = txtTenLop.Text
                '2. Business .....
                If (lopBus.isValidName(lop) = False) Then
                    MessageBox.Show("Tên Lớp không đúng.")
                    txtTenLop.Focus()
                    Return
                End If
                '3. Insert to DB
                Dim result As Result
                result = lopBus.updateLop(lop)
                If (result.FlagResult = True) Then
                    ' Re-Load khoi list
                    Dim khoi = CType(cbKhoiFilter.SelectedItem, Khoi_DTO)
                    loadListLop(khoi.StrMaKhoi1)
                    ' Hightlight the row has been updated on table
                    dgvListLop.Rows(currentRowIndex).Selected = True

                    MessageBox.Show("Cập nhật Lớp thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật Lớp không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListLop.CurrentCellAddress.Y 'current row selected

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListLop.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa Lớp " + txtTenLop.Text + " có mã số: " + txtMaLop.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        'Check nếu tồn tại lớp nào dướik hối đó không
                        Dim result As Result
                        Dim chitietDTO As ChiTietLop_DTO
                        chitietDTO = New ChiTietLop_DTO
                        Dim chitietlopBUS As ChiTietLop_BUS
                        chitietlopBUS = New ChiTietLop_BUS
                        Dim lopDTO As Lop_DTO
                        lopDTO = New Lop_DTO
                        Dim listTre As List(Of ChiTietLop_DTO)
                        listTre = New List(Of ChiTietLop_DTO)

                        result = lopBus.selectLop_ByMaLop(txtMaLop.Text, lopDTO)
                        If (lopDTO.IntSiSo1 <> 0) Then
                            Select Case MsgBox("Việc xóa nguyên lớp sẽ dẫn đén việc xóa tất cả các học sinh trong lớp đó. Bạn có chắc muốn xóa nguyên lớp khi vẫn còn học sinh trong lớp đó không?", MsgBoxStyle.YesNo, "Information")
                                Case MsgBoxResult.Yes
                                    Dim lop = CType(dgvListLop.Rows(currentRowIndex).DataBoundItem, Lop_DTO)
                                    chitietDTO.StrMaLop1 = lop.StrMaLop1
                                    result = chitietlopBUS.selectALL_ByMaLop(lop.StrMaLop1, listTre)
                                    If (result.FlagResult = False) Then
                                        MessageBox.Show("Lấy khối theo mã khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        System.Console.WriteLine(result.SystemMessage)
                                        Me.Close()
                                        Return
                                    End If
                                    result = chitietlopBUS.deleteLop(chitietDTO)
                                    If (result.FlagResult = False) Then
                                        MessageBox.Show("Xóa nguyên lớp trong chi tiết lớp không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        System.Console.WriteLine(result.SystemMessage)
                                        Me.Close()
                                        Return
                                    End If

                                    Dim khoiBUS As Khoi_BUS
                                    khoiBUS = New Khoi_BUS()

                                    Dim khoi1 = CType(cbKhoiFilter.SelectedItem, Khoi_DTO)
                                    result = khoiBUS.selectKhoiByKhoi(khoi1)
                                    If (result.FlagResult = False) Then
                                        MessageBox.Show("Lấy khối theo mã khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        System.Console.WriteLine(result.SystemMessage)
                                        Me.Close()
                                        Return
                                    End If
                                    khoi1.IntSoLop1 = khoi1.IntSoLop1 - 1
                                    result = khoiBUS.updateSoLopTrongKhoi(khoi1)
                                    If (result.FlagResult = False) Then
                                        MessageBox.Show("Update số lớp trong khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        System.Console.WriteLine(result.SystemMessage)
                                        Me.Close()
                                        Return
                                    End If
                                    '1. Delete from DB
                                    result = lopBus.deleteLop(lop.StrMaLop1)
                                    If (result.FlagResult = True) Then

                                        ' Re-Load Loaikhoi list
                                        Dim khoi = CType(cbKhoiFilter.SelectedItem, Khoi_DTO)
                                        loadListLop(khoi.StrMaKhoi1)

                                        ' Hightlight the next row on table
                                        If (currentRowIndex >= dgvListLop.Rows.Count) Then
                                            currentRowIndex = currentRowIndex - 1
                                        End If
                                        If (currentRowIndex >= 0) Then
                                            dgvListLop.Rows(currentRowIndex).Selected = True
                                        End If

                                        MessageBox.Show("Xóa Lớp thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Else
                                        MessageBox.Show("Xóa Lớp không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        System.Console.WriteLine(result.SystemMessage)
                                    End If
                                Case MsgBoxResult.No
                                    Return
                            End Select
                        Else


                            Dim lop = CType(dgvListLop.Rows(currentRowIndex).DataBoundItem, Lop_DTO)

                            Dim khoiBUS As Khoi_BUS
                            khoiBUS = New Khoi_BUS()

                            Dim khoi1 = CType(cbKhoiFilter.SelectedItem, Khoi_DTO)
                            result = khoiBUS.selectKhoiByKhoi(khoi1)
                            If (result.FlagResult = False) Then
                                MessageBox.Show("Lấy khối theo mã khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                System.Console.WriteLine(result.SystemMessage)
                                Me.Close()
                                Return
                            End If
                            khoi1.IntSoLop1 = khoi1.IntSoLop1 - 1
                            result = khoiBUS.updateSoLopTrongKhoi(khoi1)
                            If (result.FlagResult = False) Then
                                MessageBox.Show("Update số lớp trong khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                System.Console.WriteLine(result.SystemMessage)
                                Me.Close()
                                Return
                            End If
                            '1. Delete from DB
                            result = lopBus.deleteLop(lop.StrMaLop1)
                            If (result.FlagResult = True) Then

                                ' Re-Load Loaikhoi list
                                Dim khoi = CType(cbKhoiFilter.SelectedItem, Khoi_DTO)
                                loadListLop(khoi.StrMaKhoi1)

                                ' Hightlight the next row on table
                                If (currentRowIndex >= dgvListLop.Rows.Count) Then
                                    currentRowIndex = currentRowIndex - 1
                                End If
                                If (currentRowIndex >= 0) Then
                                    dgvListLop.Rows(currentRowIndex).Selected = True
                                End If

                                MessageBox.Show("Xóa Lớp thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MessageBox.Show("Xóa Lớp không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                System.Console.WriteLine(result.SystemMessage)
                            End If
                        End If



                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try

                Case MsgBoxResult.No

            End Select



        End If
    End Sub

    Private Sub dgvListLop_SELECTionChanged(sender As Object, e As EventArgs) Handles dgvListLop.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListLop.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListLop.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListLop.RowCount) Then
            Try
                Dim lop = CType(dgvListLop.Rows(currentRowIndex).DataBoundItem, Lop_DTO)
                txtMaLop.Text = lop.StrMaLop1
                txtTenLop.Text = lop.StrTenLop1

            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub



End Class