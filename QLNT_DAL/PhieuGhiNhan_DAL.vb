Imports System.Configuration
Imports System.Data.SqlClient
Imports QLNT_DTO
Imports Utility
Public Class PhieuGhiNhan_DAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function insert(pgn As PhieuGhiNhan_DTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [PHIEUGHINHAN] ([MaPhieu], [MaTre], [MaKhoi], [MaTinhTrang], [NgayNhap], [GhiChu])"
        query &= "VALUES (@maphieu,@matre,@khoi,@matinhtrang,@ngay,@ghichu)"



        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maphieu", pgn.StrMaPhieu1)
                    .Parameters.AddWithValue("@matre", pgn.StrMaTre1)
                    .Parameters.AddWithValue("@khoi", pgn.CbKhoi1)
                    .Parameters.AddWithValue("@matinhtrang", pgn.CbTinhTrang1)
                    .Parameters.AddWithValue("@ngay", pgn.DtNgay1)
                    .Parameters.AddWithValue("@ghichu", pgn.StrGhiChu1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm phiếu ghi nhận không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_ByKhoi(MaKhoi As String, ByRef listPGN As List(Of PhieuGhiNhan_DTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaPhieu], [MaTre], [MaKhoi], [MaTinhTrang] ,[NgayNhap], [GhiChu]"
        query &= "FROM [PHIEUGHINHAN] "
        query &= "WHERE [MaKhoi] = @makhoi "

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
                        listPGN.Clear()
                        While reader.Read()
                            listPGN.Add(New PhieuGhiNhan_DTO(reader("MaPhieu"), reader("MaTre"), reader("MaKhoi"), reader("MaTinhTrang"), reader("NgayNhap"), reader("GhiChu")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả phiếu ghi nhận theo khối không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_ByKhoiAndDate(NgayLap As DateTime, MaKhoi As String, ByRef listPGN As List(Of PhieuGhiNhan_DTO)) As Result
        Dim query As String = String.Empty
        query &= "SELECT [MaPhieu], [MaTre], [MaKhoi], [MaTinhTrang] ,[NgayNhap], [GhiChu]"
        query &= "FROM [PHIEUGHINHAN] "
        query &= "WHERE [MaKhoi] = @makhoi AND [NgayNhap] = @NgayNhap "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@makhoi", MaKhoi)
                    .Parameters.AddWithValue("@NgayNhap", NgayLap)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listPGN.Clear()
                        While reader.Read()
                            listPGN.Add(New PhieuGhiNhan_DTO(reader("MaPhieu"), reader("MaTre"), reader("MaKhoi"), reader("MaTinhTrang"), reader("NgayNhap"), reader("GhiChu")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả phiếu ghi nhận theo khối và ngày lập không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function selectALL_ByDate(NgayLap As DateTime, ByRef listPGN As List(Of PhieuGhiNhan_DTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaPhieu], [MaTre], [MaKhoi], [MaTinhTrang] ,[NgayNhap], [GhiChu] "
        query &= "FROM [PHIEUGHINHAN] "
        query &= "WHERE [NgayNhap] = @NgayNhap "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@NgayNhap", NgayLap)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listPGN.Clear()
                        While reader.Read()
                            listPGN.Add(New PhieuGhiNhan_DTO(reader("MaPhieu"), reader("MaTre"), reader("MaKhoi"), reader("MaTinhTrang"), reader("NgayNhap"), reader("GhiChu")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Học sinh theo Loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_ByID(matre As String, ByRef listPGN As List(Of PhieuGhiNhan_DTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaPhieu], [MaTre], [MaKhoi], [MaTinhTrang] ,[NgayNhap], [GhiChu]"
        query &= "FROM [PHIEUGHINHAN] "
        query &= "WHERE [MaTre] = @matre "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matre", matre)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listPGN.Clear()
                        While reader.Read()
                            listPGN.Add(New PhieuGhiNhan_DTO(reader("MaPhieu"), reader("MaTre"), reader("MaKhoi"), reader("MaTinhTrang"), reader("NgayNhap"), reader("GhiChu")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Học sinh theo Loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(pgn As PhieuGhiNhan_DTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [PHIEUGHINHAN] SET"
        query &= " [MaTre] = @matre "
        query &= " ,[MaKhoi] = @makhoi "
        query &= " ,[MaTinhTrang] = @matinhtrang "
        query &= " ,[NgayNhap] = @ngaynhap "
        query &= " WHERE "
        query &= " [MaPhieu] = @maphieu "
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maphieu", "abc")
                    .Parameters.AddWithValue("@matre", pgn.StrMaTre1)
                    .Parameters.AddWithValue("@makhoi", pgn.CbKhoi1)
                    .Parameters.AddWithValue("@matinhtrang", pgn.CbTinhTrang1)
                    .Parameters.AddWithValue("@ngaynhap", pgn.DtNgay1)

                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhập PGN không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(maPGN As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [PHIEUGHINHAN] "
        query &= " WHERE "
        query &= " [MaPhieu] = @maphieu "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maphieu", maPGN)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa PGN không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function

    Public Function buildID(ByRef nextID As String) As Result 'ex: 18222229

        nextID = String.Empty
        Dim y = DateTime.Now.Year
        Dim x = y.ToString().Substring(2)
        nextID = x + "00000000"

        Dim query As String = String.Empty
        query &= "Select TOP 1 [MaPhieu] "
        query &= "From [PHIEUGHINHAN] "
        query &= "Order By [MaPhieu] DESC "

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
                    Dim msOnDB As String
                    msOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            msOnDB = reader("MaPhieu")
                        End While
                    End If
                    If (msOnDB <> Nothing And msOnDB.Length >= 10) Then
                        Dim currentYear = DateTime.Now.Year.ToString().Substring(2)
                        Dim iCurrentYear = Integer.Parse(currentYear)
                        Dim currentYearOnDB = msOnDB.Substring(0, 2)
                        Dim icurrentYearOnDB = Integer.Parse(currentYearOnDB)
                        Dim year = iCurrentYear
                        If (year < icurrentYearOnDB) Then
                            year = icurrentYearOnDB
                        End If
                        nextID = year.ToString()
                        Dim v = msOnDB.Substring(2)
                        Dim convertDecimal = Convert.ToDecimal(v)
                        convertDecimal = convertDecimal + 1
                        Dim tmp = convertDecimal.ToString()
                        tmp = tmp.PadLeft(msOnDB.Length - 2, "0")
                        nextID = nextID + tmp

                        System.Console.WriteLine(nextID)
                    End If

                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã PGN kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    ''
    Public Function delete_byMaTre(maTre As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [PHIEUGHINHAN] "
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
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa PGN không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function
End Class