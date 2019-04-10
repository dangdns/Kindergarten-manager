Public Class CTBaoCao_DTO
    Private MaCTBaoCao As Integer
    Private MaPhieuGhiNhan As String
    Private MaBaoCao As Integer

    Public Property MaCTBaoCao1 As Integer
        Get
            Return MaCTBaoCao
        End Get
        Set(value As Integer)
            MaCTBaoCao = value
        End Set
    End Property

    Public Property MaPhieuGhiNhan1 As String
        Get
            Return MaPhieuGhiNhan
        End Get
        Set(value As String)
            MaPhieuGhiNhan = value
        End Set
    End Property

    Public Property MaBaoCao1 As Integer
        Get
            Return MaBaoCao
        End Get
        Set(value As Integer)
            MaBaoCao = value
        End Set
    End Property
End Class
