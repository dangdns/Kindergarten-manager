Imports QLNT_BUS
Imports QLNT_DTO
Imports Utility
Imports QLNT_DAL
Public Class Frm_QLQuyDinh
    Private Sub Frm_QLQuyDinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim qd As QuyDinh_DTO
        qd = New QuyDinh_DTO
        Dim qddal As QuyDinh_DAL
        qddal = New QuyDinh_DAL
        Dim result As Result
        result = qddal.ReadQD(qd)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin QD không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        chbTuoiMin.CheckState = -qd.BoolTuoiToiThieu1
        chbTuoiMax.CheckState = -qd.BoolTuoiToiDa1
        chbSiSoMax.CheckState = -qd.BoolSiSoToiDa1
        chbKhoiMax.CheckState = -qd.BoolSoKhoiToiDa1
        chbLopMax.CheckState = -qd.BoolSoLopToiDa1



    End Sub

    Private Sub btUpdate_Click(sender As Object, e As EventArgs) Handles btUpdate.Click
        Dim QD As QuyDinh_DTO

        QD = New QuyDinh_DTO


        '1. Mapping data from GUI control
        QD.BoolTuoiToiThieu1 = chbTuoiMin.CheckState
        QD.BoolTuoiToiDa1 = chbTuoiMax.CheckState
        QD.BoolSoLopToiDa1 = chbLopMax.CheckState
        QD.BoolSoKhoiToiDa1 = chbKhoiMax.CheckState
        QD.BoolSiSoToiDa1 = chbSiSoMax.CheckState

        '2. Business .....





        ''

        '3. Insert to DB
        Dim qddal As QuyDinh_DAL
        qddal = New QuyDinh_DAL()
        Dim result As Result
        result = qddal.update(QD)
        If (result.FlagResult = True) Then
            MessageBox.Show("Cap nhap quy định thanh cong.")
        Else
            MessageBox.Show("Cap nhap that bai. Vui long kiem tra lai DB!!!")
        End If
        Me.Close()

    End Sub
End Class