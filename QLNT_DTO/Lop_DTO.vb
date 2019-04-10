Public Class Lop_DTO
    Private strMaLop As String
    Private strTenLop As String
    Private intSiSo As Integer
    Private strMaKhoi As String
    Public Sub New(MaLop As String, ss As Integer)
        Me.strMaLop = MaLop
        Me.strTenLop = String.Empty
        Me.strMaKhoi = String.Empty
        Me.intSiSo = ss
    End Sub
    Public Sub New()
        strMaLop = String.Empty
        strTenLop = String.Empty
        strMaKhoi = String.Empty
        intSiSo = 0
    End Sub
    Public Sub New(maLop As String, tenLop As String, siSO As Integer, maKhoi As String)
        Me.strMaLop = maLop
        strTenLop = tenLop
        intSiSo = siSO
        strMaKhoi = maKhoi
    End Sub

    Public Property StrMaLop1 As String
        Get
            Return strMaLop
        End Get
        Set(value As String)
            strMaLop = value
        End Set
    End Property

    Public Property StrTenLop1 As String
        Get
            Return strTenLop
        End Get
        Set(value As String)
            strTenLop = value
        End Set
    End Property

    Public Property IntSiSo1 As Integer
        Get
            Return intSiSo
        End Get
        Set(value As Integer)
            intSiSo = value
        End Set
    End Property

    Public Property StrMaKhoi1 As String
        Get
            Return strMaKhoi
        End Get
        Set(value As String)
            strMaKhoi = value
        End Set
    End Property
End Class
