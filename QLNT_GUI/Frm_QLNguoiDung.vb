Imports QLNT_DTO
Imports QLNT_BUS
Imports QLNT_DAL
Imports Utility
Public Class Frm_QLNguoiDung
    Dim UserDTO As User_DTO
    Dim UserBUS As User_BUS
    Dim result As Result
    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles bt_CapNhat.Click
        If ((tb_User.Text.Trim = "") And (tb_Pass.Text.Trim = "")) Or cb_lvl.Text = "" Then
            MessageBox.Show("Vui lòng nhập thông tin muốn cập nhật.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            UserDTO = New User_DTO
            UserBUS = New User_BUS
            Dim currentRowIndex As Integer = dgvDanhSachNguoiDung.CurrentCellAddress.Y 'current row selected

            If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachNguoiDung.RowCount) Then
                Try
                    Dim userr = CType(dgvDanhSachNguoiDung.Rows(currentRowIndex).DataBoundItem, User_DTO)

                    If (tb_Pass.Text <> tb_Pass2.Text) Then
                        MessageBox.Show("Mật khẩu không khớp với nhau. Vui lòng nhập lại mật khẩu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        tb_Pass.Clear()
                        tb_Pass2.Clear()
                        tb_Pass.Focus()


                    Else
                        result = UserBUS.deleteUser(userr)
                        If (result.FlagResult = False) Then
                            MessageBox.Show("Xóa người dùng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            System.Console.WriteLine(result.SystemMessage)
                            Return
                        End If
                        UserDTO.Lvl1 = cb_lvl.Text
                        UserDTO.PassWord1 = tb_Pass.Text.Trim
                        UserDTO.Username1 = tb_User.Text.Trim
                        result = UserBUS.createUser(UserDTO)
                        If (result.FlagResult = False) Then
                            MessageBox.Show("Cập nhật người không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            System.Console.WriteLine(result.SystemMessage)
                            Return
                        Else
                            MessageBox.Show("Cập nhật người dùng thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            System.Console.WriteLine(result.SystemMessage)

                        End If
                        'If (userr.Username1 <> tb_User.Text) Then
                        '    result = UserBUS.checkUser(tb_User.Text, UserDTO)
                        '    If (UserDTO.Username1 = tb_User.Text) Then
                        '        MessageBox.Show("Trung tên vui lòng đổi .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        '        System.Console.WriteLine(result.SystemMessage)
                        '        Return
                        '    End If
                        '    result = UserBUS.updateNameOfUser(tb_User.Text, userr)
                        '    If (result.FlagResult = False) Then
                        '        MessageBox.Show("Cập nhật tên cho người dùng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        '        System.Console.WriteLine(result.SystemMessage)
                        '        Return
                        '    End If
                        'End If
                        'If userr.PassWord1 <> tb_Pass.Text Then
                        '    'result = UserBUS.updatePassOfUser(tb_Pass.Text, userr)
                        '    'If (result.FlagResult = False) Then
                        '    '    MessageBox.Show("Cập nhật mật khẩu cho người dùng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        '    '    System.Console.WriteLine(result.SystemMessage)
                        '    '    Return

                        '    'End If
                        '    result = UserBUS.updatePassOfUser(tb_Pass.Text, userr)
                        '    If (result.FlagResult = False) Then
                        '        MessageBox.Show("Cập nhật mật khẩu cho người dùng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        '        System.Console.WriteLine(result.SystemMessage)
                        '        Return

                        '    End If
                        'End If
                        'If userr.Lvl1 <> Convert.ToInt16(cb_lvl.Text) Then
                        '    result = UserBUS.updateLevelOfUser(Convert.ToInt16(cb_lvl.Text), userr)
                        '    If (result.FlagResult = False) Then
                        '        MessageBox.Show("Cập nhật quyền cho người dùng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        '        System.Console.WriteLine(result.SystemMessage)
                        '        Return

                        '    End If
                        'End If


                        loadlistUser()
                    End If

                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                End Try


            End If



        End If

    End Sub
    Private Sub Frm_QLNguoiDung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserBUS = New User_BUS()

        'Load list Khối
        loadlistUser()
    End Sub

    Private Sub loadlistUser()
        ' Load LoaiHocSinh list
        Dim listUser = New List(Of User_DTO)
        Dim result As Result
        result = UserBUS.selectALL(listUser)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách người dùng thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvDanhSachNguoiDung.Columns.Clear()
        dgvDanhSachNguoiDung.DataSource = Nothing

        dgvDanhSachNguoiDung.AutoGenerateColumns = False
        dgvDanhSachNguoiDung.AllowUserToAddRows = False
        dgvDanhSachNguoiDung.DataSource = listUser

        Dim clUser = New DataGridViewTextBoxColumn()
        clUser.Name = "Username"
        clUser.HeaderText = "Tên người dùng"
        clUser.DataPropertyName = "Username1"
        dgvDanhSachNguoiDung.Columns.Add(clUser)

        Dim clPass = New DataGridViewTextBoxColumn()
        clPass.Name = "Password"
        clPass.HeaderText = "Mật khẩu"
        clPass.DataPropertyName = "PassWord1"
        dgvDanhSachNguoiDung.Columns.Add(clPass)

        Dim clLevel = New DataGridViewTextBoxColumn()
        clLevel.Name = "Level"
        clLevel.HeaderText = "Cấp quyền"
        clLevel.DataPropertyName = "Lvl1"
        dgvDanhSachNguoiDung.Columns.Add(clLevel)


        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvDanhSachNguoiDung.DataSource)
        myCurrencyManager.Refresh()
    End Sub
    Private Sub dgvDanhSachNguoiDung_SELECTionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachNguoiDung.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachNguoiDung.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvDanhSachNamHoc.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachNguoiDung.RowCount) Then
            Try
                Dim userr = CType(dgvDanhSachNguoiDung.Rows(currentRowIndex).DataBoundItem, User_DTO)
                tb_User.Text = userr.Username1
                cb_lvl.Text = userr.Lvl1
                tb_Pass.Text = userr.PassWord1

                tb_Pass2.Text = userr.PassWord1
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub bt_Xoa_Click(sender As Object, e As EventArgs) Handles bt_Xoa.Click
        Dim currentRowIndex As Integer = dgvDanhSachNguoiDung.CurrentCellAddress.Y 'current row selected

        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachNguoiDung.RowCount) Then
            Try
                Dim userr = CType(dgvDanhSachNguoiDung.Rows(currentRowIndex).DataBoundItem, User_DTO)
                result = UserBUS.deleteUser(userr)
                If (result.FlagResult = False) Then
                    MessageBox.Show("Xóa người dùng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                    Return
                End If
                loadlistUser()
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If

    End Sub
End Class