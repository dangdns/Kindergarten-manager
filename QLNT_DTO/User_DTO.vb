Public Class User_DTO
    Private Username As String
    Private PassWord As String
    Private lvl As Integer
    Public Sub New()

    End Sub
    Public Sub New(U As String, P As String, lvl As Integer)
        Me.Username = U
        Me.PassWord = P
        Me.Lvl1 = lvl
    End Sub
    Public Property Username1 As String
        Get
            Return Username
        End Get
        Set(value As String)
            Username = value
        End Set
    End Property

    Public Property PassWord1 As String
        Get
            Return PassWord
        End Get
        Set(value As String)
            PassWord = value
        End Set
    End Property

    Public Property Lvl1 As Integer
        Get
            Return lvl
        End Get
        Set(value As Integer)
            lvl = value
        End Set
    End Property
End Class
