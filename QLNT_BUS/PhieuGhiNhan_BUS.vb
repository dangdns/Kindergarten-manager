Imports QLNT_DAL
Imports QLNT_DTO
Imports Utility

Public Class PhieuGhiNhan_BUS

    Private pgnDAL As PhieuGhiNhan_DAL
    Public Sub New()

        pgnDAL = New PhieuGhiNhan_DAL()
    End Sub
    Public Function isValidyear(pgn As PhieuGhiNhan_DTO) As Boolean
        Dim tre As Tre_DTO
        tre = New Tre_DTO
        Dim tredal As Tre_DAL
        tredal = New Tre_DAL
        Dim result As Result
        result = tredal.ReadTre(pgn.StrMaTre1, tre)




        If (tre.DtNgayNhapHoc1 > pgn.DtNgay1) Then
            Return False
        End If

        Return True
    End Function

    Public Function selectALL_ByKhoi(MaKhoi As String, ByRef listPGN As List(Of PhieuGhiNhan_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return pgnDAL.selectALL_ByKhoi(MaKhoi, listPGN)
    End Function
    Public Function selectALL_ByKhoiAndDate(NgayNhap As DateTime, MaKhoi As String, ByRef listPGN As List(Of PhieuGhiNhan_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return pgnDAL.selectALL_ByKhoiAndDate(NgayNhap, MaKhoi, listPGN)
    End Function
End Class
