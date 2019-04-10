Imports System.Configuration
Imports System.Data.SqlClient
Imports QLNT_DTO
Imports Utility
Public Class User_DAL
    Private connectionString As String
    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function deleteUser(user As User_DTO) As Result

        Dim query As String = String.Empty
        query &= "DELETE "
        query &= " FROM  [User]  "
        query &= "WHERE Username=@user AND Password = @pass "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@User", user.Username1)
                    .Parameters.AddWithValue("@Pass", user.PassWord1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteReader()


                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa tài khoản " + user.Username1 + " không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function checkUser(Username As String, User As User_DTO) As Result

        Dim query As String = String.Empty
        query &= " SELECT [Username], [Password], [Level]"
        query &= " FROM [User]"
        query &= " WHERE [Username]= @user"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@user", Username)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            User.Username1 = reader("Username")
                            User.PassWord1 = reader("Password")
                            User.Lvl1 = reader("Level")
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy thông tin người dùng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL(ByRef listUser As List(Of User_DTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [Username], [Password], [Level]"
        query &= " FROM [User]"


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
                        listUser.Clear()
                        While reader.Read()
                            listUser.Add(New User_DTO(reader("Username"), reader("PassWord"), reader("Level")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy danh người dùng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function createUser(NewUser As User_DTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT"
        query &= " INTO  [User] ([Username], [Password], [Level]) "
        query &= "VALUES(@User,@Pass,@lvl) "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@User", NewUser.Username1)
                    .Parameters.AddWithValue("@Pass", NewUser.PassWord1)
                    .Parameters.AddWithValue("@lvl", NewUser.Lvl1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteReader()


                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm người dùng " + NewUser.Username1 + " không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function getUser(p As String, u As String, user As User_DTO) As Result

        Dim query As String = String.Empty
        query &= "SELECT [Username],[Password],[Level] "
        query &= "FROM [User] "
        query &= "WHERE [Username] = @Username "
        query &= "AND [Password]= @PassWord"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Username", u)
                    .Parameters.AddWithValue("@PassWord", p)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then

                        While reader.Read()

                            user.Username1 = reader("Username")
                            user.PassWord1 = reader("PassWord")

                            user.Lvl1 = reader("Level")
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
