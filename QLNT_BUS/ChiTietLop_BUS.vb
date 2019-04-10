Imports QLNT_DAL
Imports QLNT_DTO
Imports Utility
Public Class ChiTietLop_BUS


    Private ChiTietLopDAL As ChiTietLop_DAL
    Public Sub New()
        ChiTietLopDAL = New ChiTietLop_DAL()
    End Sub
        Public Sub New(connectionString As String)
        ChiTietLopDAL = New ChiTietLop_DAL(connectionString)
    End Sub
    Public Function checkChiTietLop(MaTre As String, chitietLop As ChiTietLop_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ChiTietLopDAL.checkChiTietLop(MaTre, chitietLop)
    End Function

    Public Function insert(lhs As ChiTietLop_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ChiTietLopDAL.insert(lhs)
    End Function
    Public Function update(lhs As ChiTietLop_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ChiTietLopDAL.update(lhs)
    End Function
    Public Function deleteMaTreMaLop(lhs As ChiTietLop_DTO) As Result
        '1. verify data here!!

        '2. insert to DB

        Return ChiTietLopDAL.deleteMaTreMaLop(lhs)
    End Function
    Public Function deleteMaTre(lhs As ChiTietLop_DTO) As Result
        '1. verify data here!!

        '2. insert to DB

        Return ChiTietLopDAL.deleteMaTre(lhs)
    End Function

    Public Function deleteLop(lhs As ChiTietLop_DTO) As Result
        '1. verify data here!!

        '2. insert to DB

        Return ChiTietLopDAL.deleteLop(lhs)
    End Function
    Public Function selectAll(ByRef listLopHocSinh As List(Of ChiTietLop_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ChiTietLopDAL.selectALL(listLopHocSinh)
    End Function
    Public Function selectALL_ByMaLop(iMaLop As Integer, ByRef listLopHocSinh As List(Of ChiTietLop_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ChiTietLopDAL.selectALL_ByMaLop(iMaLop, listLopHocSinh)
    End Function
    'Public Function selectALL_ByMaLopAndMaHocKy(iMaLop As Integer, iMaHocKy As Integer, ByRef listLopHocSinh As List(Of LopHocSinhDTO)) As Result
    '    '1. verify data here!!

    '    '2. insert to DB
    '    Return lopHocSinhDAL.selectALL_ByMaLopAndMaHocKy(iMaLop, iMaHocKy, listLopHocSinh)
    'End Function
End Class
