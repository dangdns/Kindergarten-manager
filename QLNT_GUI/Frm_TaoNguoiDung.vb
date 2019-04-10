Imports QLNT_DTO
Imports QLNT_BUS
Imports QLNT_DAL
Imports Utility
Public Class Frm_TaoNguoiDung
    Dim UserDTO As User_DTO
    Dim UserBUS As User_BUS
    Dim result
    Private Sub bt_Tao_Click(sender As Object, e As EventArgs) Handles bt_Tao.Click
        If (tb_User.Text.Trim = "") Or (tb_Pass.Text.Trim = "") Or cb_lvl.Text.ToString = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            UserDTO = New User_DTO
            UserBUS = New User_BUS




            result = UserBUS.checkUser(tb_User.Text, UserDTO)
                If (result.FlagResult = False) Then
                    MessageBox.Show("Không kiểm tra được có trùng tên người dùng hay không.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                    Return
                End If
                If (UserDTO.Username1 = tb_User.Text) Then
                    MessageBox.Show("Trung tên người dùng. Vui lòng đổi tên người dùng.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                    Return
                Else
                    If (tb_Pass.Text <> tb_Pass2.Text) Then
                        MessageBox.Show("Mật khẩu không khớp với nhau. Vui lòng nhập lại mật khẩu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        tb_Pass.Clear()
                        tb_Pass2.Clear()
                        tb_Pass.Focus()


                    Else
                    '1 Mapping data
                    UserDTO.PassWord1 = tb_Pass.Text
                        UserDTO.Username1 = tb_User.Text
                    UserDTO.Lvl1 = cb_lvl.Text
                    '2 bus
                    If UserBUS.isValidPass(UserDTO) = False Then
                        MessageBox.Show("Mật khẩu không được chứa kí tự đặc biệt hoặc khoảng trống.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        tb_Pass.Clear()
                        tb_Pass2.Clear()
                        tb_Pass.Focus()

                        Return
                    End If
                    If UserBUS.isValidName(UserDTO) = False Then
                        MessageBox.Show("Mật khẩu không được chứa kí tự đặc biệt hoặc khoảng trống.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        tb_Pass.Clear()
                        tb_Pass2.Clear()
                        tb_User.Clear()
                        tb_User.Focus()
                        Return
                    End If
                    result = UserBUS.createUser(UserDTO)
                        If (result.FlagResult = False) Then
                            MessageBox.Show("Tạo người dùng mới không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            System.Console.WriteLine(result.SystemMessage)
                            Return
                        Else
                            MessageBox.Show("Tạo người dùng mới thành công.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                            Me.Close()
                        End If
                    End If


                End If


            End If

    End Sub
    Private Sub bt_Dong_Click(sender As Object, e As EventArgs) Handles bt_DONg.Click
        Me.Close()
    End Sub

End Class