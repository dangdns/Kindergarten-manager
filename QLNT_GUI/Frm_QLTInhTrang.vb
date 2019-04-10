Imports QLNT_BUS
Imports QLNT_DTO
Imports Utility
Imports QLNT_DAL
Public Class Frm_QLTInhTrang
    Private Sub Frm_QLTInhTrang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listTinhTrang = New List(Of TinhTrang_DTO)
        Dim result As Result
        Dim ttdal As TinhTrang_DAL
        ttdal = New TinhTrang_DAL()
        result = ttdal.selectALL(listTinhTrang)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách tình trạng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If


        dgvTinhTrang.Columns.Clear()
        dgvTinhTrang.DataSource = Nothing

        dgvTinhTrang.AutoGenerateColumns = False
        dgvTinhTrang.AllowUserToAddRows = False
        dgvTinhTrang.DataSource = listTinhTrang


        Dim clMaTinhTrang = New DataGridViewTextBoxColumn()
        clMaTinhTrang.Name = "MaTinhTrang"
        clMaTinhTrang.HeaderText = "Mã Tình Trạng"
        clMaTinhTrang.DataPropertyName = "IntMaTinhTrang1"
        dgvTinhTrang.Columns.Add(clMaTinhTrang)

        Dim clTenTinhTrang = New DataGridViewTextBoxColumn()
        clTenTinhTrang.Name = "TenTinhTrang"
        clTenTinhTrang.HeaderText = "Tên Tình Trạng"
        clTenTinhTrang.DataPropertyName = "StrTenTinhTrang1"
        dgvTinhTrang.Columns.Add(clTenTinhTrang)
        'dgvListHS.ResumeLayout()
    End Sub

    Private Sub dgvTinhTrang_SelectionChanged(sender As Object, e As EventArgs) Handles dgvTinhTrang.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvTinhTrang.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListHS.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvTinhTrang.RowCount) Then
            Try
                Dim tt = CType(dgvTinhTrang.Rows(currentRowIndex).DataBoundItem, TinhTrang_DTO)
                txtID.Text = tt.IntMaTinhTrang1
                txrTinhTrang.Text = tt.StrTenTinhTrang1
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)



            End Try

        End If
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



        ''

        '3. Insert to DB
        Dim ttdal As TinhTrang_DAL
        ttdal = New TinhTrang_DAL()
        Dim result As Result
        result = ttdal.update(TT)
        If (result.FlagResult = True) Then
            MessageBox.Show("Cap nhap tình trạng thanh cong.")
        Else
            MessageBox.Show("Cap nhap that bai. Vui long kiem tra lai DB!!!")
        End If
    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        Dim TT As TinhTrang_DTO
        TT = New TinhTrang_DTO

        '1. Mapping data from GUI control
        TT.IntMaTinhTrang1 = txtID.Text

        '3. Delete from DB
        Dim ttdal As TinhTrang_DAL
        ttdal = New TinhTrang_DAL()
        Dim result As Result
        result = ttdal.delete(TT.IntMaTinhTrang1)
        If (result.FlagResult = True) Then
            MessageBox.Show("Xoa Tình trạng thanh cong.")
        Else
            MessageBox.Show("Xoa  that bai. Vui long kiem tra lai DB!!!")
        End If
    End Sub
End Class