Imports QLNT_DTO
Imports QLNT_DAL
Imports Utility
Public Class User_BUS
    Private userDAL As User_DAL
    Public Sub New()
        userDAL = New User_DAL()
    End Sub
    Public Function isValidName(user As User_DTO) As Boolean

        If (user.Username1.Length < 1) Then
            Return False
        End If
        If ((user.Username1.IndexOfAny("[~`!@#$%^&*()-+=|{}:;.,<>/?]".ToCharArray) <> -1) = True) Then
            Return False
        End If
        If (user.Username1.Contains(" ") = True) Then
            Return False
        End If
        Return True
    End Function
    Public Function isValidPass(user As User_DTO) As Boolean

        If (user.PassWord1.Length < 1) Then
            Return False
        End If
        If ((user.PassWord1.IndexOfAny("[~`!@#$%^&*()-+=|{}:;.,<>/?]".ToCharArray) <> -1) = True) Then
            Return False
        End If
        If (user.Username1.Contains(" ") = True) Then
            Return False
        End If



        Return True
    End Function
    Public Function getUser(p As String, u As String, User As User_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return userDAL.getUser(p, u, User)
    End Function
    Public Function createUser(NewUser As User_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return userDAL.CreateUser(NewUser)
    End Function
    Public Function selectALL(ByRef listUser As List(Of User_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return userDAL.selectALL(listUser)
    End Function
    Public Function checkUser(Username As String, User As User_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return userDAL.checkUser(Username, User)
    End Function

    Public Function deleteUser(User As User_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return userDAL.deleteUser(User)
    End Function
End Class
