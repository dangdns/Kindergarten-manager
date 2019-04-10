Imports System.Configuration
Imports System.Data.SqlClient
Imports QLNT_DTO
Imports Utility
Public Class Khoi_DAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function updateTenKhoi(nh As Khoi_DTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [KHOI] SET"
        query &= " [TenKhoi] = @tenkhoi "
        query &= "WHERE "
        query &= " [MaKhoi] = @makhoi "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@makhoi", nh.StrMaKhoi1)
                    .Parameters.AddWithValue("@tenkhoi", nh.StrTenKhoi1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật khối không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaKhoi] "
        query &= "FROM [KHOI] "
        query &= "ORDER BY [MaKhoi] DESC "

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
                    Dim idOnDB As Integer
                    idOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("Makhoi")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của Loại khối không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function updateSoLopTrongKhoi(nh As Khoi_DTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [KHOI] SET"
        query &= " [SoLop] = @solop "
        query &= "WHERE "
        query &= " [MaKhoi] = @makhoi "


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@makhoi", nh.StrMaKhoi1)
                    .Parameters.AddWithValue("@solop", nh.IntSoLop1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật khối không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function deleteKhoi(maKhoi As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [KHOI] "
        query &= " WHERE "
        query &= " [MaKhoi] = @makhoi "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@makhoi", maKhoi)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa khối không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectKhoiByKhoi(Khoi As Khoi_DTO) As Result

        Dim query As String = String.Empty
        query &= " SELECT [MaKhoi], [TenKhoi], [SoLop]"
        query &= " FROM [KHOI]"
        query &= " WHERE [MaKhoi]= @makhoi"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@makhoi", Khoi.StrMaKhoi1)
                End With

                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then

                        While reader.Read()
                            Khoi.StrMaKhoi1 = reader("MaKhoi")
                            Khoi.StrTenKhoi1 = reader("TenKhoi")
                            Khoi.IntSoLop1 = reader("SoLop")
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy khối theo mã khối không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectKhoibyMaKhoi(MaKhoi As String, Khoi As Khoi_DTO) As Result

        Dim query As String = String.Empty
        query &= " SELECT [MaKhoi], [TenKhoi], [SoLop]"
        query &= " FROM [KHOI]"
        query &= " WHERE [MaKhoi]= @makhoi"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@makhoi", MaKhoi)
                End With

                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then

                        While reader.Read()
                            Khoi.StrMaKhoi1 = reader("MaKhoi")
                            Khoi.StrTenKhoi1 = reader("TenKhoi")
                            Khoi.IntSoLop1 = reader("SoLop")
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy khối theo mã khối không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(ByRef listKhoi As List(Of Khoi_DTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [MaKhoi], [TenKhoi], [SoLop]"
        query &= " FROM [KHOI]"


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
                        listKhoi.Clear()
                        While reader.Read()
                            listKhoi.Add(New Khoi_DTO(reader("MaKhoi"), reader("TenKhoi"), reader("SoLop")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy danh sách khoi không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insertKhoi(khoi As Khoi_DTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [LOP] ([MaKhoi], [TenKhoi], [SoLop])"
        query &= "VALUES (@makhoi,@tenkhoi,@solop)"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@makhoi", khoi.StrMaKhoi1)
                    .Parameters.AddWithValue("@tenkhoi", khoi.StrTenKhoi1)
                    .Parameters.AddWithValue("@solop", khoi.IntSoLop1)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm khối: " + khoi.StrTenKhoi1 + " không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function ReadMaKhoiFromTenKhoi(tenKhoi As String, Khoi As Khoi_DTO) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaKhoi], [TenKhoi], [SoLop] "
        query &= "FROM [KHOI] "
        query &= "WHERE [TenKhoi] = @tenkhoi "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@tenkhoi", tenKhoi)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then

                        While reader.Read()
                            Khoi.IntSoLop1 = reader("SoLop")
                            Khoi.StrMaKhoi1 = reader("MaKhoi")
                            Khoi.StrTenKhoi1 = reader("TenKhoi")
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy mã khối từ tên khối không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


End Class
