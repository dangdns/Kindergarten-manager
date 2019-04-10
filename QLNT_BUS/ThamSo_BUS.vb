Imports QLNT_DTO
Imports QLNT_DAL
Imports Utility
Public Class ThamSo_BUS
    Private TSDAL As ThamSo_DAL
    Public Sub New()
        TSDAL = New ThamSo_DAL()
    End Sub
    Public Sub New(connectionString As String)
        TSDAL = New ThamSo_DAL(connectionString)
    End Sub

    Public Function selectAll(listThamSo As ThamSo_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return TSDAL.selectALL(listThamSo)
    End Function
End Class
