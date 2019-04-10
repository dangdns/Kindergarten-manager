Public Class TinhTrang_DTO
    Private intMaTinhTrang As Integer
    Private strTenTinhTrang As String

    Public Sub New(t1 As Integer, t2 As String)
        intMaTinhTrang = t1
        strTenTinhTrang = t2
    End Sub
    Public Sub New(t1 As Integer)
        intMaTinhTrang = t1

    End Sub
    Public Sub New()


    End Sub

    Public Property IntMaTinhTrang1 As Integer
        Get
            Return intMaTinhTrang
        End Get
        Set(value As Integer)
            intMaTinhTrang = value
        End Set
    End Property

    Public Property StrTenTinhTrang1 As String
        Get
            Return strTenTinhTrang
        End Get
        Set(value As String)
            strTenTinhTrang = value
        End Set
    End Property
End Class
