Imports QLNT_BUS
Imports QLNT_DTO
Imports Utility
Imports QLNT_DAL
Public Class Frm_QuyDinhTS
    Private Sub Frm_QuyDinhTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ts = New ThamSo_DTO
        Dim result As Result
        Dim tsdal As ThamSo_DAL
        tsdal = New ThamSo_DAL()
        Dim tmp As Boolean
        tmp = tsdal.ReadTS(ts)
        If (tmp = False) Then
            MessageBox.Show("Lấy thông tin TS không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        txtTuoiMin.Text = ts.IntTuoiMin1
        txtTuoiMax.Text = ts.IntTuoiMax1
        txtKhoiMax.Text = ts.IntSokhoiMax1
        txtLopMax.Text = ts.IntSoLopMax1
        txtSiSoMax.Text = ts.IntSiSoMax1

        Dim qd As QuyDinh_DTO
        qd = New QuyDinh_DTO
        Dim qddal As QuyDinh_DAL
        qddal = New QuyDinh_DAL

        result = qddal.ReadQD(qd)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin QD không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        txtKhoiMax.ReadOnly = Not (qd.BoolSoKhoiToiDa1)
        txtLopMax.ReadOnly = Not (qd.BoolSoLopToiDa1)
        txtTuoiMin.ReadOnly = Not (qd.BoolTuoiToiThieu1)
        txtTuoiMax.ReadOnly = Not (qd.BoolTuoiToiDa1)
        txtSiSoMax.ReadOnly = Not (qd.BoolSiSoToiDa1)
    End Sub

    Private Sub btCapNhap_Click(sender As Object, e As EventArgs) Handles btCapNhap.Click
        Dim TS As ThamSo_DTO
        TS = New ThamSo_DTO


        '1. Mapping data from GUI control
        TS.IntTuoiMax1 = txtKhoiMax.Text
        TS.IntTuoiMin1 = txtTuoiMin.Text
        TS.IntSiSoMax1 = txtSiSoMax.Text
        TS.IntSokhoiMax1 = txtKhoiMax.Text
        TS.IntSoLopMax1 = txtLopMax.Text

        '2. Business .....




        '3. Insert to DB
        Dim tsdal As ThamSo_DAL
        tsdal = New ThamSo_DAL()
        Dim result As Result
        result = tsdal.update(TS)
        If (result.FlagResult = True) Then
            MessageBox.Show("Them tình trạng thanh cong.")
        Else
            MessageBox.Show("Them  that bai. Vui long kiem tra lai DB!!!")
        End If
    End Sub
End Class