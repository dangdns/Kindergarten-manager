Imports System.Configuration
Imports System.Data.SqlClient
Imports QLNT_DTO
Imports Utility
Public Class TinhTrang_DAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function selectALL(ByRef listTinhTrang As List(Of TinhTrang_DTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [MaTinhTrang], [TenTinhTrang]"
        query &= " FROM [TINHTRANG]"


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
                        listTinhTrang.Clear()
                        While reader.Read()
                            listTinhTrang.Add(New TinhTrang_DTO(reader("MaTinhTrang"), reader("TenTinhTrang")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy ds tình trạng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectByID(ID As Integer, tt As TinhTrang_DTO) As Result

        Dim query As String = String.Empty
        query &= " SELECT [MaTinhTrang], [TenTinhTrang]"
        query &= " FROM [TINHTRANG]"
        query &= "WHERE [MaTinhTrang] = @matinhtrang "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matinhtrang", ID)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            tt.IntMaTinhTrang1 = reader("MaTinhTrang")
                            tt.StrTenTinhTrang1 = reader("TenTinhTrang")

                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy ds tình trạng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function buildID(ByRef nextID As Integer) As Result 'ex: 18222229


        nextID = 0

        Dim query As String = String.Empty
        query &= "Select TOP 1 [MaTinhTrang] "
        query &= "From [TINHTRANG] "
        query &= "Order By [MaTinhTrang] DESC "

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
                            msOnDB = reader("MaTinhTrang")
                        End While
                    End If
                    If (msOnDB <> Nothing) Then


                        nextID = msOnDB + 1
                        System.Console.WriteLine(nextID)
                    End If

                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã tình trạng kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(tt As TinhTrang_DTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [TINHTRANG] ([MaTinhTrang], [TenTinhTrang])"
        query &= "VALUES (@matinhtrang,@tentinhtrang)"

        'get MSHS
        Dim nextID = 0
        buildID(nextID)
        tt.IntMaTinhTrang1 = nextID
        'Dim MaGT As Integer
        'MaGT = Convert.ToInt32(tre.StrGioiTinh1)

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matinhtrang", tt.IntMaTinhTrang1)
                    .Parameters.AddWithValue("@tentinhtrang", tt.StrTenTinhTrang1)

                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm Tình trạng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(tt As TinhTrang_DTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [TINHTRANG] SET"
        query &= " [TenTinhTrang] = @tentinhtrang "

        query &= " WHERE "
        query &= " [MaTinhTrang] = @matinhtrang "


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query

                    .Parameters.AddWithValue("@matinhtrang", tt.IntMaTinhTrang1)
                    .Parameters.AddWithValue("@tentinhtrang", tt.StrTenTinhTrang1)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhập Tình trạng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(maTT As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [TINHTRANG] "
        query &= " WHERE "
        query &= " [MaTinhTrang] = @matinhtrang "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matinhtrang", maTT)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa tình trạng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function
End Class
