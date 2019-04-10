Imports System.Configuration
Imports System.Data.SqlClient
Imports QLNT_DTO
Imports Utility
Public Class Lop_DAL
    Private connectionString As String
    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function getNextID(ByRef nextID As Integer) As Result

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MALOP] "
        query &= "FROM [LOP] "
        query &= "ORDER BY [MALOP] DESC "

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
                            idOnDB = reader("malop")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của lớp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL(ByRef listLop As List(Of Lop_DTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [MaLop], [TenLop], [SiSoLop], [MaKhoi]"
        query &= " FROM [LOP]"


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
                        listLop.Clear()
                        While reader.Read()
                            listLop.Add(New Lop_DTO(reader("MaLop"), reader("TenLop"), reader("SiSoLop"), reader("MaKhoi")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy danh sách lớp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL_ByMaKhoiWhereNotFull(maKhoi As Integer, ByRef listLop As List(Of Lop_DTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [MaLop], [TenLop], [SiSoLop], [MaKhoi]"
        query &= " FROM [LOP], [THAMSO]"
        query &= " WHERE "
        query &= " [MaKhoi] = @makhoi AND [SiSoLop] < [THAMSO].[SiSoToiDa] "

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
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listLop.Clear()
                        While reader.Read()
                            listLop.Add(New Lop_DTO(reader("MaLop"), reader("TenLop"), reader("SiSoLop"), reader("MaKhoi")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả lớp theo mã khối không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL_ByMaKhoi(maKhoi As Integer, ByRef listLop As List(Of Lop_DTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [MaLop], [TenLop], [SiSoLop], [MaKhoi]"
        query &= " FROM [LOP], [THAMSO]"
        query &= " WHERE "
        query &= " [MaKhoi] = @makhoi"

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
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listLop.Clear()
                        While reader.Read()
                            listLop.Add(New Lop_DTO(reader("MaLop"), reader("TenLop"), reader("SiSoLop"), reader("MaKhoi")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả lớp theo mã khối không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_ByMaLop(maLop As String, Lop As Lop_DTO) As Result

        Dim query As String = String.Empty
        query &= " SELECT [MaLop], [TenLop], [SiSoLop], [MaKhoi]"
        query &= " FROM [LOP]"
        query &= " WHERE "
        query &= " [MaLop] = @maLop "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maLop", maLop)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then

                        While reader.Read()
                            Lop.StrMaLop1 = reader("MaLop")
                            Lop.StrMaKhoi1 = reader("MaKhoi")
                            Lop.StrTenLop1 = reader("TenLop")
                            Lop.IntSiSo1 = reader("SiSoLop")
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả lớp theo mã khối không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function updateLop(lop As Lop_DTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [LOP] SET"
        query &= " [TenLop] = @tenlop "
        query &= " ,[MaKhoi] = @makhoi "
        query &= " ,[SiSoLop] = @sisolop "
        query &= "WHERE "
        query &= " [MaLop] = @malop "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@malop", lop.StrMaLop1)
                    .Parameters.AddWithValue("@tenlop", lop.StrTenLop1)
                    .Parameters.AddWithValue("@makhoi", lop.StrMaKhoi1)
                    .Parameters.AddWithValue("@sisolop", lop.IntSiSo1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật lớp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function deleteLop(maLop As Integer) As Result
        Dim query As String = String.Empty
        query &= " DELETE FROM [LOP] "
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
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa lớp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectLopChuaDuocXep_ByMaKhoi(maKhoi As Integer, ByRef listLop As List(Of Lop_DTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [MaLop], [TenLop], [SiSoLop], [MaKhoi]"
        query &= " FROM [LOP]"
        query &= " WHERE "
        query &= " [MaKhoi] = @makhoi AND [SiSoLop] = '0' "

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
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listLop.Clear()
                        While reader.Read()
                            listLop.Add(New Lop_DTO(reader("MaLop"), reader("TenLop"), reader("SiSoLop"), reader("MaKhoi")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả lớp theo mã khối không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectLop_ByMaLop(maLop As String, Lop As Lop_DTO) As Result

        Dim query As String = String.Empty
        query &= " SELECT [MaLop], [TenLop], [SiSoLop], [MaKhoi]"
        query &= " FROM [LOP]"
        query &= " WHERE "
        query &= " [MaLop] = @maLop "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maLop", maLop)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then

                        While reader.Read()
                            Lop.StrMaLop1 = reader("MaLop")
                            Lop.StrMaKhoi1 = reader("MaKhoi")
                            Lop.StrTenLop1 = reader("TenLop")
                            Lop.IntSiSo1 = reader("SiSoLop")
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả lớp theo mã khối không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function updateSiSo(Lop As Lop_DTO) As Result

        Dim query As String = String.Empty
        query &= "Update [LOP] set"
        query &= " [SiSoLop]= @SiSo"
        query &= " Where [MaLop]=@maLop"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@SiSo", Lop.IntSiSo1)
                    .Parameters.AddWithValue("@maLop", Lop.StrMaLop1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteReader()


                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Update sỉ số lớp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(lop As Lop_DTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [LOP] ([MaLop], [TenLop], [SiSoLop], [MaKhoi])"
        query &= "VALUES (@malop,@tenlop,@sisolop,@makhoi)"

        Dim nextID = 0
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        lop.StrMaLop1 = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@malop", lop.StrMaLop1)
                    .Parameters.AddWithValue("@tenlop", lop.StrTenLop1)
                    .Parameters.AddWithValue("@sisolop", lop.IntSiSo1)
                    .Parameters.AddWithValue("@makhoi", lop.StrMaKhoi1)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm lớp: " + lop.StrTenLop1 + " không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

End Class
