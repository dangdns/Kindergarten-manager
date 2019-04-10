Imports QLNT_DTO
Imports System.Data.SqlClient
Imports System.Configuration
Imports Utility
Public Class QuyDinh_DAL
    Private connectionString As String

    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function ReadQD(qd As QuyDinh_DTO) As Result

        Dim query As String = String.Empty
        query &= "SELECT [TuoiToiThieu], [TuoiToiDa], [SiSoToiDa], [SoKhoiToiDa], [SoLopToiDa]"
        query &= "FROM [QLQUYDINH]"


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
                            qd.BoolTuoiToiThieu1 = reader("TuoiToiThieu")
                            qd.BoolTuoiToiDa1 = reader("TuoiToiDa")
                            qd.BoolSiSoToiDa1 = reader("SiSoToiDa")
                            qd.BoolSoKhoiToiDa1 = reader("SoKhoiToiDa")
                            qd.BoolSoLopToiDa1 = reader("SoLopToiDa")
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lay QD không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(qd As QuyDinh_DTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [QLQUYDINH] SET"
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

                    .Parameters.AddWithValue("@tuoimin", qd.BoolTuoiToiThieu1)
                    .Parameters.AddWithValue("@tuoimax", qd.BoolTuoiToiDa1)
                    .Parameters.AddWithValue("@sisomax", qd.BoolSiSoToiDa1)
                    .Parameters.AddWithValue("@sokhoimax", qd.BoolSoKhoiToiDa1)
                    .Parameters.AddWithValue("@solopmax", qd.BoolSoLopToiDa1)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhập QD không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
