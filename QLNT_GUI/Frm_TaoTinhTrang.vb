Imports QLNT_BUS
Imports QLNT_DAL
Imports QLNT_DTO
Imports Utility
Public Class Frm_TaoTinhTrang
    Private Sub Frm_TinhTrang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim result As Result
        Dim Ttdal = New TinhTrang_DAL
        Dim nextMshs As Integer
        result = Ttdal.buildID(nextMshs)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy tự động mã Tình trạng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtID.Text = nextMshs
    End Sub

    Private Sub btNhap_Click(sender As Object, e As EventArgs) Handles btNhap.Click
        Dim TT As TinhTrang_DTO
        TT = New TinhTrang_DTO


        '1. Mapping data from GUI control
        TT.IntMaTinhTrang1 = txtID.Text
        TT.StrTenTinhTrang1 = txrTinhTrang.Text




        '2. Business .....

        Dim ttbus As TinhTrang_BUS
        ttbus = New TinhTrang_BUS


        If (ttbus.isValidTenTInhTrang(TT) = True) Then
            MessageBox.Show("Tên tinh trạng không được chứa số và kí tự đặc biệt. Vui lòng kiểm tra lại!")
            txrTinhTrang.Focus()
            Return
        End If

        ''

        '3. Insert to DB
        Dim ttdal As TinhTrang_DAL
        ttdal = New TinhTrang_DAL()
        Dim result As Result
        result = ttdal.insert(TT)
        If (result.FlagResult = True) Then
            MessageBox.Show("Them tình trạng thanh cong.")
        Else
            MessageBox.Show("Them  that bai. Vui long kiem tra lai DB!!!")
        End If
    End Sub
End Class