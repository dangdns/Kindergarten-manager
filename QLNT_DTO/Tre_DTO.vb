Public Class Tre_DTO
    Private strID As String
    Private strTenTre As String
    Private strTenONha As String
    Private strDiaChi As String
    Private strTenPhuHuynh As String
    Private strDienThoai As String
    Private dtNgaySinh As DateTime
    Private intGioiTinh As Integer
    Private strGhiChu As String
    Private dtNgayNhapHoc As DateTime

    Public Sub New()
    End Sub
    Public Sub New(msTre As String)
        Me.strID = msTre
    End Sub
    Public Sub New(id As String, ghichu As String, ngaynhaphoc As DateTime)
        Me.strID = id
        Me.strGhiChu = ghichu
        Me.dtNgayNhapHoc = ngaynhaphoc.Date
    End Sub

    Public Sub New(ID As String, TenTre As String, TenONha As String, DiaChi As String, TenPhuHuynh As String, DienThoai As String, NgaySinh As DateTime, GioiTinh As Integer, strGhiChu As String, dtNgayNhapHoc As DateTime)
        Me.strID = ID
        Me.strTenTre = TenTre
        Me.strTenONha = TenONha
        Me.strDiaChi = DiaChi
        Me.strTenPhuHuynh = TenPhuHuynh
        Me.strDienThoai = DienThoai
        Me.dtNgaySinh = NgaySinh.Date
        Me.intGioiTinh = GioiTinh
        Me.strGhiChu = strGhiChu
        Me.dtNgayNhapHoc = dtNgayNhapHoc.Date
    End Sub
    Public Property StrTenTre1 As String
        Get
            Return strTenTre
        End Get
        Set(value As String)
            strTenTre = value
        End Set
    End Property

    Public Property StrTenONha1 As String
        Get
            Return strTenONha
        End Get
        Set(value As String)
            strTenONha = value
        End Set
    End Property

    Public Property StrDiaChi1 As String
        Get
            Return strDiaChi
        End Get
        Set(value As String)
            strDiaChi = value
        End Set
    End Property

    Public Property StrTenPhuHuynh1 As String
        Get
            Return strTenPhuHuynh
        End Get
        Set(value As String)
            strTenPhuHuynh = value
        End Set
    End Property

    Public Property StrDienThoai1 As String
        Get
            Return strDienThoai
        End Get
        Set(value As String)
            strDienThoai = value
        End Set
    End Property

    Public Property DtNgaySinh1 As Date
        Get
            Return dtNgaySinh
        End Get
        Set(value As Date)
            dtNgaySinh = value.Date
        End Set
    End Property

    Public Property IntGioiTinh1 As Integer
        Get
            Return intGioiTinh
        End Get
        Set(value As Integer)
            intGioiTinh = value
        End Set
    End Property

    Public Property StrID1 As String
        Get
            Return strID
        End Get
        Set(value As String)
            strID = value
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

    Public Property DtNgayNhapHoc1 As Date
        Get
            Return dtNgayNhapHoc
        End Get
        Set(value As Date)
            dtNgayNhapHoc = value.Date
        End Set
    End Property
End Class
