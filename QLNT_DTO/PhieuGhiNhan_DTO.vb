Public Class PhieuGhiNhan_DTO
    Private strMaPhieu As String
    Private strMaTre As String
    Private cbKhoi As String
    Private cbTinhTrang As Integer
    Private dtNgay As DateTime
    Private strGhiChu As String


    Public Sub New(t1 As String, t2 As String, t3 As String, t4 As Integer, t5 As DateTime, t6 As String)
        strMaPhieu = t1
        strMaTre = t2
        cbKhoi = t3
        CbTinhTrang1 = t4
        dtNgay = t5
        strGhiChu = t6


    End Sub
    Public Sub New(maphieu As String)
        Me.strMaPhieu = maphieu
    End Sub
    Public Sub New()


    End Sub


    Public Property CbKhoi1 As String
        Get
            Return cbKhoi
        End Get
        Set(value As String)
            cbKhoi = value
        End Set
    End Property



    Public Property DtNgay1 As Date
        Get
            Return dtNgay
        End Get
        Set(value As Date)
            dtNgay = value
        End Set
    End Property

    Public Property StrMaTre1 As String
        Get
            Return strMaTre
        End Get
        Set(value As String)
            strMaTre = value
        End Set
    End Property

    Public Property StrMaPhieu1 As String
        Get
            Return strMaPhieu
        End Get
        Set(value As String)
            strMaPhieu = value
        End Set
    End Property

    Public Property CbTinhTrang1 As Integer
        Get
            Return cbTinhTrang
        End Get
        Set(value As Integer)
            cbTinhTrang = value
        End Set
    End Property

    Public Property StrGhiChu1 As String
        Get
            Return strGhiChu
        End Get
        Set(value As String)
            strGhiChu = value
        End Set
    End Property
End Class
