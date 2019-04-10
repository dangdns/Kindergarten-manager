Imports QLNT_DTO
Imports QLNT_DAL
Imports Utility
Public Class Khoi_BUS
    Private kDAL As Khoi_DAL
    Public Sub New()
        kDAL = New Khoi_DAL()
    End Sub
    Public Sub New(connectionString As String)
        kDAL = New Khoi_DAL(connectionString)
    End Sub
    Public Function isValidNameKhoi(K As Khoi_DTO) As Boolean

        If (K.StrTenKhoi1 < 1) Then
            Return False
        End If
        If ((K.StrTenKhoi1.IndexOfAny("[~`!@#$%^&*()-+=|{}:;.,<>/?]".ToCharArray) <> -1) = True) Then
            Return False
        End If



        Return True
    End Function

    Public Function selectKhoiByMaKhoi(MaKhoi As String, Khoi As Khoi_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return kDAL.selectKhoiByMaKhoi(MaKhoi, Khoi)
    End Function
    Public Function selectKhoiByKhoi(Khoi As Khoi_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return kDAL.selectKhoiByKhoi(Khoi)
    End Function
    Public Function deleteKhoi(maKhoi As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return kDAL.deleteKhoi(maKhoi)
    End Function

    Public Function updateSoLopTrongKhoi(kh As Khoi_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return kDAL.updateSoLopTrongKhoi(kh)
    End Function
    Public Function selectAll(ByRef listKhoi As List(Of Khoi_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return kDAL.selectALL(listKhoi)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return kDAL.getNextID(nextID)
    End Function
    Public Function insertKhoi(kh As Khoi_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return kDAL.insertKhoi(kh)
    End Function
    Public Function updateTenKhoi(kh As Khoi_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return kDAL.updateTenKhoi(kh)
    End Function
End Class
