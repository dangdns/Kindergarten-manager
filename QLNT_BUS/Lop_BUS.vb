Imports QLNT_DTO
Imports QLNT_DAL
Imports Utility
Public Class Lop_BUS
    Private lopDAL As Lop_DAL
    Public Sub New()
        lopDAL = New Lop_DAL()
    End Sub
    Public Sub New(connectionString As String)
        lopDAL = New Lop_DAL(connectionString)
    End Sub
    Public Function updateLop(Lop As Lop_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lopDAL.updateLop(Lop)
    End Function
    Public Function isValidName(lop As Lop_DTO) As Boolean

        If (lop.StrTenLop1.Length < 1) Then
            Return False
        End If
        If ((lop.StrTenLop1.IndexOfAny("[~`!@#$%^&*()-+=|{}:;.,<>/?]".ToCharArray) <> -1) = True) Then
            Return False
        End If
        Return True

    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return lopDAL.getNextID(nextID)
    End Function
    Public Function insert(lop As Lop_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lopDAL.insert(lop)
    End Function

    Public Function updateSiSO(Lop As Lop_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lopDAL.updateSiSo(Lop)
    End Function
    Public Function selectLop_ByMaLop(maLop As String, Lop As Lop_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lopDAL.selectLop_ByMaLop(maLop, Lop)
    End Function
    Public Function deleteLop(maLop As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lopDAL.deleteLop(maLop)

    End Function
    Public Function selectLopChuaDuocXep_ByMaKhoi(maKhoi As Integer, ByRef listLop As List(Of Lop_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lopDAL.selectLopChuaDuocXep_ByMaKhoi(maKhoi, listLop)
    End Function
    Public Function selectALL_ByMaKhoiWhereNotFull(maKhoi As Integer, ByRef listLop As List(Of Lop_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lopDAL.selectALL_ByMaKhoiWhereNotFull(maKhoi, listLop)
    End Function
    Public Function selectALL_ByMaKhoi(maKhoi As Integer, ByRef listLop As List(Of Lop_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lopDAL.selectALL_ByMaKhoi(maKhoi, listLop)
    End Function
    Public Function selectALL_ByMaLop(maLop As String, Lop As Lop_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lopDAL.selectALL_ByMaLop(maLop, Lop)
    End Function

    Public Function selectALL(ByRef listLop As List(Of Lop_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lopDAL.selectALL(listLop)
    End Function
End Class
