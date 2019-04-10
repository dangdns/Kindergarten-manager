Imports System.Configuration
Imports System.Data.SqlClient
Imports QLNT_DTO
Imports Utility
Public Class Tre_DAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function buildID(ByRef nextID As String) As Result 'ex: 18222229

        nextID = String.Empty
        Dim y = DateTime.Now.Year
        Dim x = y.ToString().Substring(2)
        nextID = x + "000000"

        Dim query As String = String.Empty
        query &= "Select TOP 1 [MaTre] "
        query &= "From [TRE] "
        query &= "Order By [MaTre] DESC "

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
                            msOnDB = reader("MaTre")
                        End While
                    End If
                    If (msOnDB <> Nothing And msOnDB.Length >= 8) Then
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
                    Return New Result(False, "Lấy tự động Mã số Học sinh kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(tre As Tre_DTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [TRE] ([MaTre], [HoTenTre], [TenONha], [HoTenPhuHuynh], [DiaChi], [NgaySinh], [DienThoai], [MaGioiTinh], [GhiChu], [NgayNhapHoc])"
        query &= "VALUES (@matre,@hotentre,@tenonha,@hotenphuhuynh,@diachi,@ngaysinh,@dienthoai,@magioitinh,@ghichu,@ngaynhaphoc)"

        'get MSHS
        Dim nextID = "1"
        buildID(nextID)
        tre.StrID1 = nextID
        'Dim MaGT As Integer
        ' MaGT = Convert.ToInt32(tre.StrGioiTinh1)

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matre", tre.StrID1)
                    .Parameters.AddWithValue("@hotentre", tre.StrTenTre1)
                    .Parameters.AddWithValue("@tenonha", tre.StrTenONha1)
                    .Parameters.AddWithValue("@hotenphuhuynh", tre.StrTenPhuHuynh1)
                    .Parameters.AddWithValue("@diachi", tre.StrDiaChi1)
                    .Parameters.AddWithValue("@ngaysinh", tre.DtNgaySinh1)
                    .Parameters.AddWithValue("@dienthoai", tre.StrDienThoai1)
                    .Parameters.AddWithValue("@magioitinh", tre.IntGioiTinh1)
                    .Parameters.AddWithValue("@ghichu", String.Empty)
                    .Parameters.AddWithValue("@ngaynhaphoc", "06/09/1969")
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm Trẻ không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function FindFullTre(maLop As String, tre As Tre_DTO, listtre As List(Of Tre_DTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [TRE].[MaTre], [HoTenTre], [TenONha], [HoTenPhuHuynh], [NgaySinh], [DiaChi], [DienThoai], [MaGioiTinh], [GhiChu], [NgayNhapHoc] "
        query &= "FROM [TRE],[CHITIETLOP],[LOP] "
        query &= "WHERE [HoTenTre] = @hotentre AND [NgaySinh]=@ngaysinh AND  [MaGioiTinh]=@magioitinh AND [LOP].[MaLop]=@maLop  AND [LOP].[MaLop]=[CHITIETLOP].[MaLop] AND [TRE].[MaTre]=[CHITIETLOP].[MaTre] "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@malop", maLop)
                    .Parameters.AddWithValue("@ngaysinh", tre.DtNgaySinh1)
                    .Parameters.AddWithValue("@magioitinh", tre.IntGioiTinh1)
                    .Parameters.AddWithValue("@hotentre", tre.StrTenTre1)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listtre.Clear()
                        While reader.Read()
                            listtre.Add(New Tre_DTO(reader("MaTre"), reader("HoTenTre"), reader("TenONha"), reader("DiaChi"), reader("HoTenPhuHuynh"), reader("DienThoai"), reader("NgaySinh"), reader("MaGioiTinh"), reader("GhiChu"), reader("NgayNhapHoc")))
                        End While
                    End If
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy học sinh không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function ReadTre(maTre As String, tre As Tre_DTO) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaTre], [HoTenTre], [TenONha], [HoTenPhuHuynh], [NgaySinh], [DiaChi], [DienThoai], [MaGioiTinh], [GhiChu], [NgayNhapHoc] "
        query &= "FROM [TRE] "
        query &= "WHERE [MaTre] = @matre "

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
                            tre.StrID1 = reader("MaTre")
                            tre.StrTenTre1 = reader("HoTenTre")
                            tre.StrTenONha1 = reader("TenONha")
                            tre.StrTenPhuHuynh1 = reader("HoTenPhuHuynh")
                            tre.StrDiaChi1 = reader("DiaChi")
                            tre.DtNgaySinh1 = reader("NgaySinh")
                            tre.StrDienThoai1 = reader("DienThoai")
                            tre.IntGioiTinh1 = reader("MaGioiTinh")
                            tre.StrGhiChu1 = reader("GhiChu")
                            tre.DtNgayNhapHoc1 = reader("NgayNhapHoc")

                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy học sinh không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function ReadTreTheoHTvaNsvaGT(tre As Tre_DTO, listtre As List(Of Tre_DTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaTre], [HoTenTre], [TenONha], [HoTenPhuHuynh], [NgaySinh], [DiaChi], [DienThoai], [MaGioiTinh], [GhiChu], [NgayNhapHoc] "
        query &= "FROM [TRE] "
        query &= "WHERE [HoTenTre] = @hotentre AND [NgaySinh]=@ngaysinh and [MaGioiTinh]=@magioitinh"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@hotentre", tre.StrTenTre1)
                    .Parameters.AddWithValue("@ngaysinh", tre.DtNgaySinh1)
                    .Parameters.AddWithValue("@magioitinh", tre.IntGioiTinh1)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listtre.Clear()
                        While reader.Read()
                            listtre.Add(New Tre_DTO(reader("MaTre"), reader("HoTenTre"), reader("TenONha"), reader("DiaChi"), reader("HoTenPhuHuynh"), reader("DienThoai"), reader("NgaySinh"), reader("MaGioiTinh"), reader("GhiChu"), reader("NgayNhapHoc")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy học sinh theo họ tên, giới tính và ngày sinh không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function TraCuu_LOP(malop As String, tre As Tre_DTO, listtre As List(Of Tre_DTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [TRE].[MaTre], [HoTenTre], [TenONha], [HoTenPhuHuynh], [NgaySinh], [DiaChi], [DienThoai], [MaGioiTinh], [GhiChu], [NgayNhapHoc]"
        query &= " FROM [TRE],[CHITIETLOP],[LOP]"
        query &= " WHERE [TRE].[MaTre]=[CHITIETLOP].[MaTre] "
        query &= " AND [CHITIETLOP].[MaLop]=[LOP].[MaLop] "
        query &= " AND [TRE].[HoTenTre] like '%' + @hotentre + '%' "
        query &= " AND [TenONha] like '%' + @tenonha + '%' "
        query &= " AND [HoTenPhuHuynh] like '%' + @hotenPH + '%' "
        query &= " AND [DienThoai] like '%' + @dienthoai + '%' "
        query &= " AND [MaGioiTinh]= @magioitinh  "
        query &= " AND [LOP].[MaLop] = @malop "




        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@hotentre", tre.StrTenTre1)
                    .Parameters.AddWithValue("@tenonha", tre.StrTenONha1)
                    .Parameters.AddWithValue("@hotenPH", tre.StrTenPhuHuynh1)
                    .Parameters.AddWithValue("@dienthoai", tre.StrDienThoai1)
                    .Parameters.AddWithValue("@magioitinh", tre.IntGioiTinh1)
                    .Parameters.AddWithValue("@malop", malop)

                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listtre.Clear()
                        While reader.Read()
                            listtre.Add(New Tre_DTO(reader("MaTre"), reader("HoTenTre"), reader("TenONha"), reader("DiaChi"), reader("HoTenPhuHuynh"), reader("DienThoai"), reader("NgaySinh"), reader("MaGioiTinh"), reader("GhiChu"), reader("NgayNhapHoc")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Tra Cuu không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function TraCuu_KHONGLOP(tre As Tre_DTO, listtre As List(Of Tre_DTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [TRE].[MaTre], [HoTenTre], [TenONha], [HoTenPhuHuynh], [NgaySinh], [DiaChi], [DienThoai], [MaGioiTinh], [GhiChu], [NgayNhapHoc]"
        query &= " FROM [TRE]"
        query &= " WHERE [TRE].[HoTenTre] like '%' + @hotentre + '%' "
        query &= " AND [TenONha] like '%' + @tenonha + '%' "
        query &= " AND [HoTenPhuHuynh] like '%' + @hotenPH + '%' "
        query &= " AND [DienThoai] like '%' + @dienthoai + '%' "
        query &= " AND [MaGioiTinh]= @magioitinh  "




        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@hotentre", tre.StrTenTre1)
                    .Parameters.AddWithValue("@tenonha", tre.StrTenONha1)
                    .Parameters.AddWithValue("@hotenPH", tre.StrTenPhuHuynh1)
                    .Parameters.AddWithValue("@dienthoai", tre.StrDienThoai1)
                    .Parameters.AddWithValue("@magioitinh", tre.IntGioiTinh1)

                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listtre.Clear()
                        If reader.HasRows = True Then

                            While reader.Read()
                                listtre.Add(New Tre_DTO(reader("MaTre"), reader("HoTenTre"), reader("TenONha"), reader("DiaChi"), reader("HoTenPhuHuynh"), reader("DienThoai"), reader("NgaySinh"), reader("MaGioiTinh"), reader("GhiChu"), reader("NgayNhapHoc")))
                            End While
                        End If
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Tra Cuu không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function ReadTreTheoNSvaGT(tre As Tre_DTO, listtre As List(Of Tre_DTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaTre], [HoTenTre], [TenONha], [HoTenPhuHuynh], [NgaySinh], [DiaChi], [DienThoai], [MaGioiTinh], [GhiChu], [NgayNhapHoc] "
        query &= "FROM [TRE] "
        query &= "WHERE [NgaySinh]=@ngaysinh and [MaGioiTinh]=@magioitinh"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ngaysinh", tre.DtNgaySinh1)
                    .Parameters.AddWithValue("@magioitinh", tre.IntGioiTinh1)
                End With
                Try
                     conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listtre.Clear()
                        While reader.Read()
                            listtre.Add(New Tre_DTO(reader("MaTre"), reader("HoTenTre"), reader("TenONha"), reader("DiaChi"), reader("HoTenPhuHuynh"), reader("DienThoai"), reader("NgaySinh"), reader("MaGioiTinh"), reader("GhiChu"), reader("NgayNhapHoc")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy học sinh theo giới tính và ngày sinh không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function ReadTreTheoHTvaGT(tre As Tre_DTO, listtre As List(Of Tre_DTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaTre], [HoTenTre], [TenONha], [HoTenPhuHuynh], [NgaySinh], [DiaChi], [DienThoai], [MaGioiTinh], [GhiChu], [NgayNhapHoc] "
        query &= "FROM [TRE] "
        query &= "WHERE [HoTenTre] = @hotentre and [MaGioiTinh]=@magioitinh"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@hotentre", tre.StrTenTre1)
                    .Parameters.AddWithValue("@magioitinh", tre.IntGioiTinh1)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listtre.Clear()
                        While reader.Read()
                            listtre.Add(New Tre_DTO(reader("MaTre"), reader("HoTenTre"), reader("TenONha"), reader("DiaChi"), reader("HoTenPhuHuynh"), reader("DienThoai"), reader("NgaySinh"), reader("MaGioiTinh"), reader("GhiChu"), reader("NgayNhapHoc")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy học sinh theo họ tên và giới tính không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function ReadTreTheoHTvaNS(tre As Tre_DTO, listtre As List(Of Tre_DTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaTre], [HoTenTre], [TenONha], [HoTenPhuHuynh], [NgaySinh], [DiaChi], [DienThoai], [MaGioiTinh], [GhiChu], [NgayNhapHoc] "
        query &= "FROM [TRE] "
        query &= "WHERE [HoTenTre] = @hotentre AND [NgaySinh]=@ngaysinh"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@hotentre", tre.StrTenTre1)
                    .Parameters.AddWithValue("@ngaysinh", tre.DtNgaySinh1)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listtre.Clear()
                        While reader.Read()
                            listtre.Add(New Tre_DTO(reader("MaTre"), reader("HoTenTre"), reader("TenONha"), reader("DiaChi"), reader("HoTenPhuHuynh"), reader("DienThoai"), reader("NgaySinh"), reader("MaGioiTinh"), reader("GhiChu"), reader("NgayNhapHoc")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy học sinh theo họ tên và ngày sinh không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function ReadTreTrongList(maTre As String, listTre As List(Of Tre_DTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaTre], [HoTenTre], [TenONha], [HoTenPhuHuynh], [NgaySinh], [DiaChi], [DienThoai], [MaGioiTinh],[GhiChu],[NgayNhapHoc] "
        query &= "FROM [TRE] "
        query &= "WHERE [MaTre] = @matre "

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
                        listTre.Clear()
                        While reader.Read()
                            listTre.Add(New Tre_DTO(reader("MaTre"), reader("HoTenTre"), reader("TenONha"), reader("DiaChi"), reader("HoTenPhuHuynh"), reader("DienThoai"), reader("NgaySinh"), reader("MaGioiTinh"), reader("GhiChu"), reader("NgayNhapHoc")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy học sinh không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function updateGhiChuAndNgayNhapHoc(tre As Tre_DTO) As Result

        Dim query As String = String.Empty
        query &= "Update [TRE] set"
        query &= " [GhiChu]= @ghichu, [NgayNhapHoc]=@ngaynhaphoc "
        query &= " Where [MaTre]=@maTre"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maTre", tre.StrID1)
                    .Parameters.AddWithValue("@ghichu", tre.StrGhiChu1)
                    .Parameters.AddWithValue("@ngaynhaphoc", tre.DtNgayNhapHoc1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteReader()


                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Update ghi chu và ngày nhập học không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function SelectListTreMaChuaDuocXepLop(listTre As List(Of Tre_DTO)) As Result

        Dim query As String = String.Empty
        query &= " Select [TRE].[MaTre], [HoTenTre], [TenONha], [HoTenPhuHuynh], [NgaySinh], [DiaChi], [DienThoai], [MaGioiTinh],[GhiChu],[NgayNhapHoc] "
        query &= "From [TRE]"
        query &= "Left Join [CHITIETLOP] ON [CHITIETLOP].[MaTre] = [TRE].[MaTre]"
        query &= "WHERE [CHITIETLOP].[MaTre] Is NULL"


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
                        listTre.Clear()
                        While reader.Read()
                            listTre.Add(New Tre_DTO(reader("MaTre"), reader("HoTenTre"), reader("TenONha"), reader("DiaChi"), reader("HoTenPhuHuynh"), reader("DienThoai"), reader("NgaySinh"), reader("MaGioiTinh"), reader("GhiChu"), reader("NgayNhapHoc")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy danh sách học sinh chưa có lớp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(maTre As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [TRE] "
        query &= " WHERE "
        query &= " [MaTre] = @maTre "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maTre", maTre)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa trẻ không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function
    Public Function selectID(ByRef listID As List(Of Tre_DTO), hotentre As String) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaTre]"
        query &= "FROM [TRE]"
        query &= "WHERE [HoTenTre] = @hotentre "


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@hotentre", hotentre)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listID.Clear()
                        While reader.Read()
                            listID.Add(New Tre_DTO(reader("MaTre")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy ds mã trẻ không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_ByMaLop(iMaLop As Integer, ByRef listTre As List(Of Tre_DTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [TRE].[MaTre], [HoTenTre], [TenONha], [HoTenPhuHuynh], [NgaySinh], [DiaChi], [DienThoai], [MaGioiTinh],[GhiChu],[NgayNhapHoc] "
        query &= " FROM [TRE] "
        query &= "     ,[CHITIETLOP] "
        query &= " WHERE "
        query &= "     [TRE].[MaTre] = [CHITIETLOP].[MaTre]"
        query &= "     AND [ChiTietLop].[MaLop] = @malop"



        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@malop", iMaLop)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listTre.Clear()
                        While reader.Read()
                            listTre.Add(New Tre_DTO(reader("MaTre"), reader("HoTenTre"), reader("TenONha"), reader("DiaChi"), reader("HoTenPhuHuynh"), reader("DienThoai"), reader("NgaySinh"), reader("MaGioiTinh"), reader("GhiChu"), reader("NgayNhapHoc")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Học sinh theo Lớp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(tre As Tre_DTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [TRE] SET"
        query &= " [HoTenTre] = @hotentre "
        query &= " ,[TenONha] = @tenonha "
        query &= " ,[HoTenPhuHuynh] = @hotenphuhuynh "
        query &= " ,[NgaySinh] = @ngaysinh "
        query &= " ,[DiaChi] = @diachi "

        query &= " ,[DienThoai] = @dienthoai "
        query &= " ,[MaGioiTinh] = @magioitinh "
        query &= " ,[GhiChu] = @ghichu "
        query &= " ,[NgayNhapHoc] = @ngaynhaphoc "
        query &= " WHERE "
        query &= " [MaTre] = @matre "


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query

                    .Parameters.AddWithValue("@hotentre", tre.StrTenTre1)
                    .Parameters.AddWithValue("@tenonha", tre.StrTenONha1)
                    .Parameters.AddWithValue("@hotenphuhuynh", tre.StrTenPhuHuynh1)
                    .Parameters.AddWithValue("@diachi", tre.StrDiaChi1)
                    .Parameters.AddWithValue("@ngaysinh", tre.DtNgaySinh1)
                    .Parameters.AddWithValue("@dienthoai", tre.StrDienThoai1)
                    .Parameters.AddWithValue("@magioitinh", tre.IntGioiTinh1)
                    .Parameters.AddWithValue("@ghichu", tre.StrGhiChu1)
                    .Parameters.AddWithValue("@ngaynhaphoc", tre.DtNgayNhapHoc1)
                    .Parameters.AddWithValue("@matre", tre.StrID1)
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

    ''
    Public Function SelectALL(listTre As List(Of Tre_DTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaTre], [HoTenTre], [TenONha], [HoTenPhuHuynh], [NgaySinh], [DiaChi], [DienThoai], [MaGioiTinh],[GhiChu],[NgayNhapHoc] "
        query &= "FROM [TRE] "

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
                        listTre.Clear()
                        While reader.Read()
                            listTre.Add(New Tre_DTO(reader("MaTre"), reader("HoTenTre"), reader("TenONha"), reader("DiaChi"), reader("HoTenPhuHuynh"), reader("DienThoai"), reader("NgaySinh"), reader("MaGioiTinh"), reader("GhiChu"), reader("NgayNhapHoc")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy học sinh không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

End Class
