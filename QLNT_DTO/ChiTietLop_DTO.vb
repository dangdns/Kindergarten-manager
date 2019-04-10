
Public Class ChiTietLop_DTO
    Private strMaLop As String
    Private strMaTre As String
    Public Sub New()
        strMaLop = String.Empty
        strMaTre = String.Empty
    End Sub
    Public Sub New(strMaLop As String, strMaTre As String)
        Me.strMaLop = strMaLop
        Me.strMaTre = strMaTre
    End Sub
    Public Sub New(strMaLop As String)
        Me.strMaLop = strMaLop
        Me.strMaTre = String.Empty
    End Sub
    Public Property StrMaLop1 As String
        Get
            Return strMaLop
        End Get
        Set(value As String)
            strMaLop = value
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


End Class
