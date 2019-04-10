Imports QLNT_DTO
Imports QLNT_DAL
Imports Utility
Public Class GioiTinh_BUS
    Private gtDAL As GioiTinh_DAL
    Public Sub New()
        gtDAL = New GioiTinh_DAL()
    End Sub
    Public Sub New(connectionString As String)
        gtDAL = New GioiTinh_DAL(connectionString)
    End Sub
End Class
