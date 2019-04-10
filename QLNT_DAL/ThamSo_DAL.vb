Imports QLNT_DTO
Imports System.Data.SqlClient
Imports System.Configuration
Imports Utility
Public Class ThamSo_DAL
    Private connectionString As String

    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function ReadTS(ts As ThamSo_DTO) As Boolean

        Dim query As String = String.Empty
        query &= "SELECT [TuoiToiThieu], [TuoiToiDa], [SiSoToiDa], [SoKhoiToiDa], [SoLopToiDa]"
        query &= "FROM [THAMSO]"


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
                    If reader.HasRows = True Then
                        While reader.Read()
                            ts.IntTuoiMin1 = reader("TuoiToiThieu")
                            ts.IntTuoiMax1 = reader("TuoiToiDa")
                            ts.IntSiSoMax1 = reader("SiSoToiDa")
                            ts.IntSokhoiMax1 = reader("SoKhoiToiDa")
                            ts.IntSoLopMax1 = reader("SoLopToiDa")

                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return False
                End Try
            End Using
        End Using
        Return True ' thanh cong
    End Function
    Public Function selectALL(listThamSo As ThamSo_DTO) As Result

        Dim query As String = String.Empty
        query &= " SELECT [TuoiToiThieu], [TuoiToiDa], [SiSoToiDa], [SoKhoiToiDa],[SoLopToiDa]"
        query &= " FROM [THAMSO]"


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
                    If reader.HasRows = True Then

                        While reader.Read()
                            listThamSo.IntSiSoMax1 = reader("SiSoToiDa")
                            listThamSo.IntSokhoiMax1 = reader("SoKhoiToiDa")
                            listThamSo.IntTuoiMax1 = reader("TuoiToiDa")
                            listThamSo.IntTuoiMin1 = reader("TuoiToiThieu")
                            listThamSo.IntSoLopMax1 = reader("SoLopToiDa")
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy danh sách tham số không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(ts As ThamSo_DTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [THAMSO] SET"
        query &= " [TuoiToiThieu] = @tuoimin "
        query &= " ,[TuoiToiDa] = @tuoimax "
        query &= " ,[SiSoToiDa] = @sisomax "
        query &= " ,[SoKhoiToiDa] = @sokhoimax "
        query &= " ,[SoLopToiDa] = @solopmax "



        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query

                    .Parameters.AddWithValue("@tuoimin", ts.IntTuoiMin1)
                    .Parameters.AddWithValue("@tuoimax", ts.IntTuoiMax1)
                    .Parameters.AddWithValue("@sisomax", ts.IntSiSoMax1)
                    .Parameters.AddWithValue("@sokhoimax", ts.IntSoKhoiMax1)
                    .Parameters.AddWithValue("@solopmax", ts.IntSoLopMax1)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhập Trẻ không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

End Class
