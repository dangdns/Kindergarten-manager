Imports QLNT_BUS
Imports QLNT_DAL
Imports QLNT_DTO
Imports Utility
Public Class Frm_QLTre
    Private Sub Frm_QLTre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim result As Result
        Dim Tredal = New Tre_DAL


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


    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged

        If (txtID.Text.Length = 8) Then
            Dim treDTO = New Tre_DTO
            Dim result As Result
            Dim treDAL = New Tre_DAL
            result = treDAL.ReadTre(txtID.Text, treDTO)
            If (result.FlagResult = False Or treDTO.StrTenTre1 Is Nothing) Then
                'ko tim thay thi de trong
                txtHovaTen.Text = Nothing
                txtTenONha.Text = Nothing
                txtTenPhuHuynh.Text = Nothing
                txtDiaChi.Text = Nothing
                txtDienThoai.Text = Nothing
                cbGioiTinh.SelectedIndex = Nothing
                dtNgaySinh.Value = Today
                dtNgayNhapHoc.Value = Today
                MessageBox.Show("Lấy thông tin trẻ không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
            txtHovaTen.Text = treDTO.StrTenTre1
            txtTenONha.Text = treDTO.StrTenONha1
            txtTenPhuHuynh.Text = treDTO.StrTenPhuHuynh1
            txtDiaChi.Text = treDTO.StrDiaChi1
            txtDienThoai.Text = treDTO.StrDienThoai1
            cbGioiTinh.SelectedValue = treDTO.IntGioiTinh1
            dtNgaySinh.Value = treDTO.DtNgaySinh1
            dtNgayNhapHoc.Value = treDTO.DtNgayNhapHoc1
        End If

        If (txtID.Text.Length < 8 Or txtID.Text.Length > 8) Then

            txtHovaTen.Text = Nothing
            txtTenONha.Text = Nothing
            txtTenPhuHuynh.Text = Nothing
            txtDiaChi.Text = Nothing
            txtDienThoai.Text = Nothing
            cbGioiTinh.SelectedIndex = Nothing
            dtNgaySinh.Value = Today
            dtNgayNhapHoc.Value = Today

        End If


    End Sub

    Private Sub btSua_Click(sender As Object, e As EventArgs) Handles btSua.Click
        Dim TRE As Tre_DTO
        TRE = New Tre_DTO


        '1. Mapping data from GUI control
        TRE.StrID1 = txtID.Text
        TRE.StrTenTre1 = txtHovaTen.Text
        TRE.StrTenONha1 = txtTenONha.Text
        TRE.StrDiaChi1 = txtDiaChi.Text
        TRE.StrDienThoai1 = txtDienThoai.Text
        TRE.DtNgaySinh1 = dtNgaySinh.Value
        TRE.StrTenPhuHuynh1 = txtTenPhuHuynh.Text
        TRE.IntGioiTinh1 = cbGioiTinh.SelectedValue
        TRE.StrGhiChu1 = tbGhiChu.Text
        TRE.DtNgayNhapHoc1 = dtNgayNhapHoc.Value



        '2. Business .....

        Dim trebus As Tre_BUS
        trebus = New Tre_BUS



        If (trebus.isValidName(TRE) = False) Then
            MessageBox.Show("Ho Ten khong dung. vui long kiem tra lai")
            txtHovaTen.Focus()
            Return
        End If

        If (trebus.isValidYear(TRE) = False) Then
            MessageBox.Show("Ngay sinh khong dung. vui long kiem tra lai")
            dtNgaySinh.Focus()
            Return
        End If

        '3. Insert to DB
        Dim tredal As Tre_DAL
        tredal = New Tre_DAL()
        Dim result As Result
        result = tredal.update(TRE)
        If (result.FlagResult = True) Then
            MessageBox.Show("Them Tre thanh cong.")
        Else
            MessageBox.Show("Them  that bai. Vui long kiem tra lai DB!!!")
        End If
    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        Dim TRE As Tre_DTO
        TRE = New Tre_DTO


        '1. Mapping data from GUI control
        TRE.StrID1 = txtID.Text

        '3. Delete from DB
        Dim tredal As Tre_DAL
        tredal = New Tre_DAL()
        Dim result As Result
        result = tredal.delete(TRE.StrID1)
        If (result.FlagResult = True) Then
            MessageBox.Show("Xoa Tre thanh cong.")
        Else
            MessageBox.Show("Xoa  that bai. Vui long kiem tra lai DB!!!")
        End If
    End Sub

    Private Sub btThoat_Click(sender As Object, e As EventArgs) Handles btThoat.Click
        Me.Close()

    End Sub
End Class