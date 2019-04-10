Imports System.Configuration
Imports System.Data.SqlClient
Imports QLNT_DTO
Imports Utility
Public Class ChiTietLop_DAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function checkChiTietLop(MaTre As String, chitietLop As ChiTietLop_DTO) As Result

        Dim query As String = String.Empty
        query &= " SELECT [MaTre], [MaLop]"
        query &= " FROM [CHITIETLOP]"
        query &= "WHERE [MaTre]= @matre "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("matre", MaTre)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then

                        While reader.Read()
                            chitietLop.StrMaLop1 = reader("MaLop")
                            chitietLop.StrMaTre1 = reader("MaTre")

                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy chi tiết lớp theo mã trẻ không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(nh As ChiTietLop_DTO) As Result

        Dim query As String = String.Empty

        query &= "INSERT INTO [CHITIETLOP] ([MaTre], [MaLop])"

        query &= "VALUES (@matre,@malop)"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matre", nh.StrMaTre1)
                    .Parameters.AddWithValue("@malop", nh.StrMaLop1)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm học sinh vào lớp không thành công 1", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(nh As ChiTietLop_DTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [CHITIETLOP] SET"
        query &= " [MaLop] = @malop "
        query &= " WHERE "
        query &= " [MaTre] = @matre "
        'query &= " AND [mahocky] = @mahocky "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matre", nh.StrMaTre1)
                    .Parameters.AddWithValue("@malop", nh.StrMaLop1)
                    '.Parameters.AddWithValue("@mahocky", nh.MaHocKy)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật học sinh vào lớp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL(ByRef listChiTietLop As List(Of ChiTietLop_DTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [MaTre], [MaLop]"
        query &= " FROM [CHITIETLOP]"


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
                        listChiTietLop.Clear()
                        While reader.Read()
                            listChiTietLop.Add(New ChiTietLop_DTO(reader("MaLop"), reader("MaTre")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả lớp học sinh không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL_ByMaLop(maLop As String, ByRef listChiTietLop As List(Of ChiTietLop_DTO)) As Result

        Dim query As String = String.Empty
        'query &= " SELECT [mahocsinh], [malop], [mahocky]"
        query &= " SELECT [MaTre], [MaLop] "
        query &= " FROM [CHITIETLOP]"
        query &= " WHERE "
        query &= " [MaLop] = @malop "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@malop", maLop)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listChiTietLop.Clear()
                        While reader.Read()
                            listChiTietLop.Add(New ChiTietLop_DTO(reader("MaLop"), reader("MaTre")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả lớp học sinh không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function deleteLop(lhs As ChiTietLop_DTO) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [CHITIETLOP] "
        query &= " WHERE "
        query &= " [MaLop] = @malop "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@malop", lhs.StrMaLop1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa nguyên lớp trong chi tiết lớp không thành công ", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function deleteMaTre(lhs As ChiTietLop_DTO) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [CHITIETLOP] "
        query &= " WHERE "
        query &= " [MaTre] = @matre "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matre", lhs.StrMaTre1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa trẻ của lớp không thành công ", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function deleteMaTreMaLop(lhs As ChiTietLop_DTO) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [CHITIETLOP] "
        query &= " WHERE "
        query &= " [MaTre] = @matre "
        query &= " AND [MaLop] = @malop "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matre", lhs.StrMaTre1)
                    .Parameters.AddWithValue("@malop", lhs.StrMaLop1)
                    '.Parameters.AddWithValue("@mahocky", lhs.MaHocKy)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa học sinh của lớp không thành công 1", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function select_ByMaTre(maTre As String, ChiTietLop As ChiTietLop_DTO) As Result

        Dim query As String = String.Empty
        'query &= " SELECT [mahocsinh], [malop], [mahocky]"
        query &= " SELECT [MaTre], [MaLop] "
        query &= " FROM [CHITIETLOP]"
        query &= " WHERE "
        query &= " [MaTre] = @matre "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matre", maTre)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            ChiTietLop.StrMaLop1 = reader("MaLop")
                            ChiTietLop.StrMaTre1 = reader("MaTre")
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy mã lớp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
