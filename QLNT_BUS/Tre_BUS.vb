Imports System.Windows.Forms
Imports QLNT_DAL
Imports QLNT_DTO
Imports Utility

Public Class Tre_BUS
    Private treDAL As Tre_DAL
    Public Sub New()
        treDAL = New Tre_DAL()
    End Sub
    'BUS FOR DOBIRTH
    Public Function isValidYear(tre As Tre_DTO) As Boolean
        Dim TS As ThamSo_DTO
        TS = New ThamSo_DTO
        Dim tsdal As ThamSo_DAL
        tsdal = New ThamSo_DAL
        Dim kq As Boolean
        kq = tsdal.ReadTS(TS)

        Dim zeroTime As DateTime
        zeroTime = New DateTime(1, 1, 1)
        Dim Datepast As TimeSpan
        Datepast = DateTime.Today - tre.DtNgaySinh1
        Dim Tuoi As Integer
        Tuoi = (zeroTime + Datepast).Year - 1
        If (Tuoi < TS.IntTuoiMin1 Or Tuoi > TS.IntTuoiMax1) Then
            Return False
        End If
        Return True
    End Function
    'BUS for nhap ID
    Public Function isIDLessThan8Char(tre As Tre_DTO) As Boolean
        If tre.StrID1.Length <> 8 Then
            Return False
        End If
        Return True

    End Function
    'BUS for TenONha
    Public Function isValidTenONha(tre As Tre_DTO) As Boolean

        If System.Text.RegularExpressions.Regex.IsMatch(tre.StrTenONha1, "^[A-Za-z]+$") Then
            Return False
        End If
        If tre.StrTenONha1.Length < 1 Then
            Return False
        End If
        Return True
    End Function
    'BUs for dia chi cho dung "," và "/"

    Public Function isValidDiaChi(tre As Tre_DTO) As Boolean
        If ((tre.StrDiaChi1.IndexOfAny("[~`!@#$%^&*()-+=|{}:;.<>?]".ToCharArray) <> -1) = True) Then

            Return False
        End If
        Return True
    End Function

    'BUS for DienThoai

    Public Function isValidPhoneNumber(tre As Tre_DTO) As Boolean
        If Text.RegularExpressions.Regex.IsMatch(tre.StrDienThoai1, "^[0-9 ]+$") Then

            Return True

        End If
        Return False
    End Function
    'BUS for ngay nhap hoc
    Public Function isValidNgayNhapHoc(tre As Tre_DTO) As Boolean
        Dim treDTO As Tre_DTO
        treDTO = New Tre_DTO

        If treDTO.DtNgayNhapHoc1.Year < treDTO.DtNgaySinh1.Year Then
            Return False
        End If

        Return True
    End Function
    'Bus for kick khoi truong
    Public Function IsKickOutOfSchool(tre As Tre_DTO) As Boolean
        Dim TS As ThamSo_DTO
        TS = New ThamSo_DTO
        Dim tsdal As ThamSo_DAL
        tsdal = New ThamSo_DAL
        Dim kq As Boolean
        kq = tsdal.ReadTS(TS)

        Dim zeroTime As DateTime
        zeroTime = New DateTime(1, 1, 1)
        Dim Datepast As TimeSpan
        Datepast = DateTime.Today - tre.DtNgaySinh1
        Dim Tuoi As Integer
        Tuoi = (zeroTime + Datepast).Year - 1
        If (Tuoi < 10) Then
            Return False
        End If
        Return True
    End Function
    ' Bus for ten
    Public Function isValidName(tre As Tre_DTO) As Boolean

        If (tre.StrTenTre1.Length < 1) Then
            Return False
        End If
        If ((tre.StrTenTre1.IndexOfAny("[~`!@#$%^&*()-+=|{}:;.,<>/?]".ToCharArray) <> -1) = True) Then
            Return False
        End If



        Return True
    End Function
    Public Function ReadTre(MATre As String, Tre As Tre_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return treDAL.ReadTre(MATre, Tre)
    End Function
    Public Function FindFullTre(maLop As String, tre As Tre_DTO, listtre As List(Of Tre_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return treDAL.FindFullTre(maLop, tre, listtre)
    End Function
    Public Function ReadTreTheoHTvaNsvaGT(tre As Tre_DTO, listtre As List(Of Tre_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return treDAL.ReadTreTheoHTvaNsvaGT(tre, listtre)
    End Function
    Public Function ReadTreTheoHTvaNS(tre As Tre_DTO, listtre As List(Of Tre_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return treDAL.ReadTreTheoHTvaNS(tre, listtre)
    End Function


    Public Function ReadTreTheoHTvaGT(tre As Tre_DTO, listtre As List(Of Tre_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return treDAL.ReadTreTheoHTvaGT(tre, listtre)
    End Function
    Public Function ReadTreTheoNSvaGT(tre As Tre_DTO, listtre As List(Of Tre_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return treDAL.ReadTreTheoNSvaGT(tre, listtre)
    End Function
    Public Function TraCuu_Lop(malop As String, tre As Tre_DTO, listtre As List(Of Tre_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return treDAL.TraCuu_LOP(malop, tre, listtre)
    End Function
    Public Function TraCuu_KHONGLOP(tre As Tre_DTO, listtre As List(Of Tre_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return treDAL.TraCuu_KHONGLOP(tre, listtre)
    End Function

    Public Function ReadTreTrongList(MATre As String, listTre As List(Of Tre_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return treDAL.ReadTreTrongList(MATre, listTre)
    End Function
    Public Function delete(maLoai As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return treDAL.delete(maLoai)
    End Function
    Public Function SelectListTreMaChuaDuocXepLop(listTre As List(Of Tre_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return treDAL.SelectListTreMaChuaDuocXepLop(listTre)
    End Function
    Public Function selectALL_ByMaLop(maLop As Integer, listTre As List(Of Tre_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return treDAL.selectALL_ByMaLop(maLop, listTre)
    End Function
    Public Function updateGhiChuAndNgayNhapHoc(tre As Tre_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return treDAL.updateGhiChuAndNgayNhapHoc(tre)
    End Function
End Class
