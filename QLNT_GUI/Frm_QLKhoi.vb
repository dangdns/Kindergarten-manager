Imports QLNT_BUS
Imports QLNT_DTO
Imports Utility

Public Class Frm_QLKhoi
    Private khoiBus As Khoi_BUS
    Private Sub frmQLKhoi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        khoiBus = New Khoi_BUS()

        'Load list Khối
        loadlistKhoi()
    End Sub
    Private Sub loadlistKhoi()
        ' Load LoaiHocSinh list
        Dim listKhoi = New List(Of Khoi_DTO)
        Dim result As Result
        result = khoiBus.selectAll(listKhoi)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvDanhSachKhoi.Columns.Clear()
        dgvDanhSachKhoi.DataSource = Nothing

        dgvDanhSachKhoi.AutoGenerateColumns = False
        dgvDanhSachKhoi.AllowUserToAddRows = False
        dgvDanhSachKhoi.DataSource = listKhoi

        Dim clMaKhoi = New DataGridViewTextBoxColumn()
        clMaKhoi.Name = "MaKhoi"
        clMaKhoi.HeaderText = "Mã Khối"
        clMaKhoi.DataPropertyName = "StrMaKhoi1"
        dgvDanhSachKhoi.Columns.Add(clMaKhoi)

        Dim clTenKhoi = New DataGridViewTextBoxColumn()
        clTenKhoi.Name = "TenKhoi"
        clTenKhoi.HeaderText = "Tên Khối"
        clTenKhoi.DataPropertyName = "StrTenKhoi1"
        dgvDanhSachKhoi.Columns.Add(clTenKhoi)

        Dim clSoLop = New DataGridViewTextBoxColumn()
        clSoLop.Name = "SoLop"
        clSoLop.HeaderText = "Số lớp"
        clSoLop.DataPropertyName = "IntSoLop1"
        dgvDanhSachKhoi.Columns.Add(clSoLop)


        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvDanhSachKhoi.DataSource)
        myCurrencyManager.Refresh()
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachKhoi.CurrentCellAddress.Y 'current row selected

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachKhoi.RowCount) Then
            Try
                Dim khoi As Khoi_DTO
                khoi = New Khoi_DTO()

                '1. Mapping data from GUI control
                khoi.StrMaKhoi1 = Convert.ToInt32(txtMaKhoi.Text)
                khoi.StrTenKhoi1 = txtTenKhoi.Text

                '2. Business .....
                'If (khoiBus.isValidName(khoi) = False) Then
                '    MessageBox.Show("Tên Khối không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '    txtTenKhoi.Focus()
                '    Return
                'End If

                '3. Insert to DB

                Dim result As Result
                result = khoiBus.updateTenKhoi(khoi)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiHocSinh list
                    loadlistKhoi()
                    ' Hightlight the row has been updated on table
                    dgvDanhSachKhoi.Rows(currentRowIndex).Selected = True
                    Try
                        khoi = CType(dgvDanhSachKhoi.Rows(currentRowIndex).DataBoundItem, Khoi_DTO)
                        txtMaKhoi.Text = khoi.StrMaKhoi1
                        txtTenKhoi.Text = khoi.StrTenKhoi1
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật Khối thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật Khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachKhoi.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachKhoi.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa Khối " + txtTenKhoi.Text + " có mã: " + txtMaKhoi.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        'Check nếu tồn tại lớp nào dướik hối đó không
                        Dim result As Result
                        Dim khoiDTO As Khoi_DTO
                        khoiDTO = New Khoi_DTO
                        result = khoiBus.selectKhoiByMaKhoi(txtMaKhoi.Text, khoiDTO)
                        If (khoiDTO.IntSoLop1 = 0) Then


                            '1. Delete from DB
                            result = khoiBus.deleteKhoi(Convert.ToInt32(txtMaKhoi.Text))
                            If (result.FlagResult = True) Then

                                ' Re-Load LoaiHocSinh list
                                loadlistKhoi()

                                ' Hightlight the next row on table
                                If (currentRowIndex >= dgvDanhSachKhoi.Rows.Count) Then
                                    currentRowIndex = currentRowIndex - 1
                                End If
                                If (currentRowIndex >= 0) Then
                                    dgvDanhSachKhoi.Rows(currentRowIndex).Selected = True
                                    Try
                                        Dim khoi = CType(dgvDanhSachKhoi.Rows(currentRowIndex).DataBoundItem, Khoi_DTO)
                                        txtMaKhoi.Text = khoi.StrMaKhoi1
                                        txtTenKhoi.Text = khoi.StrTenKhoi1
                                    Catch ex As Exception
                                        Console.WriteLine(ex.StackTrace)
                                    End Try
                                End If
                                MessageBox.Show("Xóa Khối thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MessageBox.Show("Xóa Khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                System.Console.WriteLine(result.SystemMessage)
                            End If
                        Else
                            MessageBox.Show("Vui lòng xóa tất cả lớp của khối " + txtTenKhoi.Text + " để hoàn thành thao tác xóa khối.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return

                        End If
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                Case MsgBoxResult.No
                    Return
            End Select

        End If
    End Sub

    Private Sub dgvDanhSachNamHoc_SELECTionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachKhoi.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachKhoi.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvDanhSachNamHoc.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachKhoi.RowCount) Then
            Try
                Dim khoi = CType(dgvDanhSachKhoi.Rows(currentRowIndex).DataBoundItem, Khoi_DTO)
                txtMaKhoi.Text = khoi.StrMaKhoi1
                txtTenKhoi.Text = khoi.StrTenKhoi1
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub
End Class