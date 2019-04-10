
Public Class GioiTinh_DTO
    Private strMaGioiTinh As Integer
    Private strTenGioiTinh As String
    Public Sub New(t1 As String, t2 As String)
        strMaGioiTinh = t1
        strTenGioiTinh = t2
    End Sub
    Public Sub New()

    End Sub

    Public Property StrMaGioiTinh1 As Integer
        Get
            Return strMaGioiTinh
        End Get
        Set(value As Integer)
            strMaGioiTinh = value
        End Set
    End Property

    Public Property StrTenGioiTinh1 As String
        Get
            Return strTenGioiTinh
        End Get
        Set(value As String)
            strTenGioiTinh = value
        End Set
    End Property
End Class
