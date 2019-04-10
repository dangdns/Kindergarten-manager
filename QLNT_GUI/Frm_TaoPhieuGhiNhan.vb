Imports QLNT_BUS
Imports QLNT_DTO
Imports Utility
Imports QLNT_DAL
Public Class Frm_TaoPhieuGhiNhan
    Private kBus As Khoi_BUS
    Private ttBus As TinhTrang_BUS
    Private Sub Frm_PhieuGhiNhan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        cbKhoiLop.DataSource = New BindingSource(listKhoi, String.Empty)
        cbKhoiLop.DisplayMember = "StrTenKhoi1"
        cbKhoiLop.ValueMember = "StrMaKhoi1"

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

        Dim Pgndal = New PhieuGhiNhan_DAL
        Dim nextMshs = "1"
        result = Pgndal.buildID(nextMshs)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã Học sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtID.Text = nextMshs
    End Sub

    Private Sub btNhập_Click(sender As Object, e As EventArgs) Handles btNhập.Click



        Dim PGN As PhieuGhiNhan_DTO
        PGN = New PhieuGhiNhan_DTO


        '1. Mapping data from GUI control
        PGN.StrMaTre1 = cbMaTre.Text
        PGN.StrMaPhieu1 = txtID.Text
        PGN.CbTinhTrang1 = cbTinhTrang.SelectedValue
        PGN.DtNgay1 = dtNgay.Value.Date
        PGN.CbKhoi1 = cbKhoiLop.SelectedValue
        PGN.StrGhiChu1 = txtGhiChu.Text

        ''s
        '2. Business .....


        Dim pgnbus As PhieuGhiNhan_BUS
        pgnbus = New PhieuGhiNhan_BUS



        If (pgnbus.isValidyear(PGN) = False) Then
            MessageBox.Show("Ho Ten khong dung. vui long kiem tra lai")
            dtNgay.Focus()
            Return
        End If
        ''e

        '3. Insert to DB
        Dim pgndal As PhieuGhiNhan_DAL
        pgndal = New PhieuGhiNhan_DAL()
        Dim result As Result
        result = pgndal.insert(PGN)
        If (result.FlagResult = True) Then
            MessageBox.Show("Them Tre thanh cong.")
        Else
            MessageBox.Show("Them  that bai. Vui long kiem tra lai DB!!!")
        End If
    End Sub

    Private Sub tbHovaTen_TextChanged(sender As Object, e As EventArgs) Handles tbHovaTen.TextChanged

        Dim listID = New List(Of Tre_DTO)
            Dim result As Result


            Dim tredal As Tre_DAL
            tredal = New Tre_DAL()
            result = tredal.selectID(listID, tbHovaTen.Text)

            'result = kBus.selectAll(listKhoi)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh sách ID không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Me.Close()
                Return
            End If
            cbMaTre.DataSource = New BindingSource(listID, String.Empty)
            cbMaTre.DisplayMember = "StrID1"
            cbMaTre.ValueMember = "StrID1"


    End Sub
    ''s
    Private Sub cbMaTre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMaTre.SelectedIndexChanged
        Dim CTLop = New ChiTietLop_DTO
        Dim result As Result
        Dim ctlopdal As ChiTietLop_DAL
        ctlopdal = New ChiTietLop_DAL
        result = ctlopdal.select_ByMaTre(cbMaTre.Text, CTLop)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy mã lớp không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If

        Dim Lop = New Lop_DTO
        Dim lopdal As Lop_DAL
        lopdal = New Lop_DAL
        result = lopdal.selectALL_ByMaLop(CTLop.StrMaLop1, Lop)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy mã khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If

        cbKhoiLop.SelectedValue = Lop.StrMaKhoi1
        If (cbKhoiLop.SelectedValue Is Nothing) Then
            MessageBox.Show("Trẻ chưa dc xếp lớp.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If



    End Sub
    ''e
End Class