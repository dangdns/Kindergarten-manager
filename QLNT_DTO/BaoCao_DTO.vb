Public Class BaoCao_DTO
    Private MaBaoCao As Integer
    Private NgayBaoCao As DateTime
    Private SoLuong As Integer
    Private MaKhoi As String


    Public Property MaBaoCao1 As Integer
        Get
            Return MaBaoCao
        End Get
        Set(value As Integer)
            MaBaoCao = value
        End Set
    End Property

    Public Property NgayBaoCao1 As Date
        Get
            Return NgayBaoCao
        End Get
        Set(value As Date)
            NgayBaoCao = value
        End Set
    End Property

    Public Property SoLuong1 As Integer
        Get
            Return SoLuong
        End Get
        Set(value As Integer)
            SoLuong = value
        End Set
    End Property

    Public Property MaKhoi1 As String
        Get
            Return MaKhoi
        End Get
        Set(value As String)
            MaKhoi = value
        End Set
    End Property
End Class
