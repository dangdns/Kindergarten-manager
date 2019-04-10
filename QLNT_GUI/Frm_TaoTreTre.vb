Imports QLNT_BUS
Imports QLNT_DAL
Imports QLNT_DTO
Imports Utility

Public Class Frm_TaoTreTre
    Private Sub btNhap_Click(sender As Object, e As EventArgs) Handles btNhap.Click
        Dim TRE As Tre_DTO
        TRE = New Tre_DTO


        '1. Mapping data from GUI control
        TRE.StrTenTre1 = txtHovaTen.Text
        TRE.StrTenONha1 = txtTenONha.Text
        TRE.StrDiaChi1 = txtDiaChi.Text
        TRE.StrDienThoai1 = txtDienThoai.Text
        TRE.DtNgaySinh1 = dtNgaySinh.Value
        TRE.StrTenPhuHuynh1 = txtTenPhuHuynh.Text
        TRE.IntGioiTinh1 = cbGioiTinh.SelectedValue
        'TRE.StrGhiChu1 = tbGhiChu.Text
        'TRE.DtNgayNhapHoc1 = dtNgayNhapHoc.Value



        '2. Business .....

        Dim trebus As Tre_BUS
        trebus = New Tre_BUS



        If (trebus.isValidName(TRE) = False) Then
            MessageBox.Show("Họ tên không đúng. Vui lòng kiểm tra lại!")
            txtHovaTen.Focus()
            Return
        End If
        If (trebus.isValidDiaChi(TRE) = False) Then
            MessageBox.Show("Đỉa chỉ không được chứa kí tự đặc biệt trừ ',' và '/'. Vui lòng kiểm tra lại!")
            txtDiaChi.Focus()
            Return
        End If

        If (trebus.isValidNgayNhapHoc(TRE) = False) Then
            MessageBox.Show("Ngày nhập học không thẻ sớm hơn ngày sinh. Vui lòng kiểm tra lại!")
            txtDiaChi.Focus()
            Return
        End If
        If (trebus.isValidPhoneNumber(TRE) = False) Then
            MessageBox.Show("Số điện thoại không được chứa khoảng cách và kí tự đặc biệt. Vui lòng kiểm tra lại!")
            txtDiaChi.Focus()
            Return
        End If
        If (trebus.isValidTenONha(TRE) = False) Then
            MessageBox.Show("Tên ở nhà không được chứa kí tự đặc biệt. Vui lòng kiểm tra lại!")
            txtDiaChi.Focus()
            Return
        End If

        If (trebus.isValidYear(TRE) = False) Then
            MessageBox.Show("Trẻ phải từ 3 - 5 tuổi mới được nhập học. Vui lòng kiểm tra lại!")
            dtNgaySinh.Focus()
            Return
        End If
        'Đuổi cổ ra khỏi trường

        Dim listTRE = New List(Of Tre_DTO)
        Dim listtredal As Tre_DAL
        listtredal = New Tre_DAL()

        listtredal.SelectALL(listTRE)
        For Each item As Tre_DTO In listTRE
            If (trebus.IsKickOutOfSchool(item) = True) Then
                Dim pgn As PhieuGhiNhan_DAL
                pgn = New PhieuGhiNhan_DAL()
                pgn.delete_byMaTre(item.StrID1)
                listtredal.delete(item.StrID1)
                Return
            End If
        Next

        '3. Insert to DB
        Dim tredal As Tre_DAL
        tredal = New Tre_DAL()
        Dim result As Result
        result = tredal.insert(TRE)
        If (result.FlagResult = True) Then
            MessageBox.Show("Them Tre thanh cong.")
        Else
            MessageBox.Show("Them  that bai. Vui long kiem tra lai DB!!!")
        End If
    End Sub

    Private Sub Frm_NhapTre_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim result As Result
        Dim Tredal = New Tre_DAL
        Dim nextMshs = "1"
        result = Tredal.buildID(nextMshs)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã Học sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtID.Text = nextMshs




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
        cbGioiTinh.DataSource = New BindingSource(listGioiTinh, String.Empty)
        cbGioiTinh.DisplayMember = "StrTenGioiTinh1"
        cbGioiTinh.ValueMember = "StrMaGioiTinh1"
    End Sub

    Private Sub btThoat_Click(sender As Object, e As EventArgs) Handles btThoat.Click
        Me.Close()

    End Sub
End Class