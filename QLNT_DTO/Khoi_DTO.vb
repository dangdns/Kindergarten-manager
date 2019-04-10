Public Class Khoi_DTO
    Private strMaKhoi As String
    Private strTenKhoi As String
    Private intSoLop As Integer

    Public Sub New()
        strMaKhoi = String.Empty
        strTenKhoi = String.Empty
        intSoLop = 0
    End Sub
    Public Sub New(ml As String, tl As String, sl As Integer)
        strMaKhoi = ml
        strTenKhoi = tl
        intSoLop = sl
    End Sub


    Public Property StrMaKhoi1 As String
        Get
            Return strMaKhoi
        End Get
        Set(value As String)
            strMaKhoi = value
        End Set
    End Property

    Public Property StrTenKhoi1 As String
        Get
            Return strTenKhoi
        End Get
        Set(value As String)
            strTenKhoi = value
        End Set
    End Property

    Public Property IntSoLop1 As Integer
        Get
            Return intSoLop
        End Get
        Set(value As Integer)
            intSoLop = value
        End Set
    End Property
End Class
