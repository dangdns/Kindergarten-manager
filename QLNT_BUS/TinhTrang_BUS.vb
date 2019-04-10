Imports System.Windows.Forms
Imports QLNT_DAL
Imports QLNT_DTO
Imports Utility

Public Class TinhTrang_BUS
    Public Function isValidTenTInhTrang(ttt As TinhTrang_DTO) As Boolean

        If System.Text.RegularExpressions.Regex.IsMatch(ttt.StrTenTinhTrang1, "^[A-Za-z]-$") Then
            Return False
        End If
        If ttt.StrTenTinhTrang1.Length < 1 Then
            Return False
        End If
        Return True
    End Function
End Class
