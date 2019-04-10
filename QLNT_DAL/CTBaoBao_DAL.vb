Imports System.Configuration
Imports System.Data.SqlClient
Imports QLNT_DTO
Imports Utility
Public Class CTBaoBao_DAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function insert(ctbc As CTBaoCao_DTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [CHITIETBAOCAO] ([MaChiTietBaoCao], [MaPhieu], [MaBaoCao])"
        query &= "VALUES (@mactbaocao,@mapgn,@mabaocao)"



        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@mactbaocao", ctbc.MaCTBaoCao1)
                    .Parameters.AddWithValue("@mapgn", ctbc.MaPhieuGhiNhan1)
                    .Parameters.AddWithValue("@mabaocao", ctbc.MaBaoCao1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xuat bao cao không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function buildID(ByRef nextID As Integer) As Result 'ex: 18222229


        nextID = 0

        Dim query As String = String.Empty
        query &= "Select TOP 1 [MaChiTietBaoCao] "
        query &= "From [CHITIETBAOCAO] "
        query &= "Order By [MaChiTietBaoCao] DESC "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    Dim msOnDB As Integer

                    If reader.HasRows = True Then
                        While reader.Read()
                            msOnDB = reader("MaChiTietBaoCao")
                        End While
                    End If
                    If (msOnDB <> Nothing) Then


                        nextID = msOnDB + 1
                        System.Console.WriteLine(nextID)
                    End If

                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã Ct báo cáo kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
