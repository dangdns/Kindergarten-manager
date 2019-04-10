Imports QLNT_DTO
Imports QLNT_BUS
Imports QLNT_DAL
Imports Utility
Public Class Frm_DangNhap

    Dim userBUS As New User_BUS
    Dim user As New User_DTO
    Private Sub btn_Thoat_Click(sender As Object, e As EventArgs) Handles btn_Thoat.Click
        Me.Close()
    End Sub

    Private Sub btn_DangNhap_Click(sender As Object, e As EventArgs) Handles btn_DangNhap.Click
        Dim result As Result
        result = New Result
        'Kiểm tra tên đăng nhập và mật khẩu không được để trống
        If tb_User.Text.Trim = "" Or tb_Pass.Text.Trim = "" Then
            MessageBox.Show("Ten đăng nhập, mật khẩu không được để trống !")
        Else
            'Lấy dữ liệu từ bảng NGUOIDUNG
            result = userBUS.getUser(tb_Pass.Text.Trim, tb_User.Text.Trim, user)
            'kiểm tra tên đăng nhập và mật khẩu
            If (user.PassWord1 = tb_Pass.Text.Trim) And (user.Username1 = tb_User.Text.Trim) Then
                MessageBox.Show("Đăng nhập thành công !")
                Close()

                'Phan cap cho nguoi dung cap 3
                If (user.Lvl1 = "3") Then
                    Frm_MainForm.MenuStrip1.Show()

                    Frm_MainForm.NguoiDungStripMenuItem.Enabled = True
                    Frm_MainForm.UserToolStripMenuItem.Enabled = True
                    Frm_MainForm.DangXuatToolStripMenuItem1.Enabled = True
                    Frm_MainForm.UserTaoNgươiDungToolStripMenuItem.Enabled = True
                    Frm_MainForm.UserQuanLyNgươiDungToolStripMenuItem1.Enabled = True


                    Frm_MainForm.NhapToolStripMenuItem.Enabled = False
                    Frm_MainForm.NhapTreToolStripMenuItem.Enabled = False
                    Frm_MainForm.NhapKhoiToolStripMenuItem1.Enabled = False
                    Frm_MainForm.NhapPhieuGhiNhanToolStripMenuItem.Enabled = False
                    Frm_MainForm.NhapLopToolStripMenuItem1.Enabled = False

                    Frm_MainForm.QuanLyToolStripMenuItem.Enabled = False
                    Frm_MainForm.QuanLyKhoiToolStripMenuItem.Enabled = False
                    Frm_MainForm.QuanLyLopToolStripMenuItem.Enabled = False
                    Frm_MainForm.QuanLyPhieuGhiNhanToolStripMenuItem.Enabled = False
                    Frm_MainForm.QuanLyQuyĐinhToolStripMenuItem.Enabled = False
                    Frm_MainForm.QuanLyTreToolStripMenuItem1.Enabled = False

                    Frm_MainForm.XepToolStripMenuItem.Enabled = False
                    Frm_MainForm.XepLopToolStripMenuItem2.Enabled = False
                    Frm_MainForm.XepChuyenLopToolStripMenuItem.Enabled = False

                    Frm_MainForm.TimKiemToolStripMenuItem.Enabled = False

                    Frm_MainForm.BaoCaoToolStripMenuItem.Enabled = False
                    Frm_MainForm.BaoCaoNgayToolStripMenuItem.Enabled = False

                    Frm_MainForm.QuyDinhToolStripMenuItem.Enabled = False
                    Frm_MainForm.QuyDinhQuanLyTinhTrangToolStripMenuItem.Enabled = False
                    Frm_MainForm.QuyDInhThamSOToolStripMenuItem.Enabled = False
                    Frm_MainForm.QuyDInhThemTinhTrangToolStripMenuItem.Enabled = False

                    ''FOR DEBUG
                    'Frm_MainForm.NguoiDungStripMenuItem.Enabled = True
                    'Frm_MainForm.UserToolStripMenuItem.Enabled = True
                    'Frm_MainForm.DangXuatToolStripMenuItem1.Enabled = True
                    'Frm_MainForm.UserTaoNgươiDungToolStripMenuItem.Enabled = True
                    'Frm_MainForm.UserQuanLyNgươiDungToolStripMenuItem1.Enabled = True


                    'Frm_MainForm.NhapToolStripMenuItem.Enabled = True
                    'Frm_MainForm.NhapTreToolStripMenuItem.Enabled = True
                    'Frm_MainForm.NhapKhoiToolStripMenuItem1.Enabled = True
                    'Frm_MainForm.NhapPhieuGhiNhanToolStripMenuItem.Enabled = True
                    'Frm_MainForm.NhapLopToolStripMenuItem1.Enabled = True

                    'Frm_MainForm.QuanLyToolStripMenuItem.Enabled = True
                    'Frm_MainForm.QuanLyKhoiToolStripMenuItem.Enabled = True
                    'Frm_MainForm.QuanLyLopToolStripMenuItem.Enabled = True
                    'Frm_MainForm.QuanLyPhieuGhiNhanToolStripMenuItem.Enabled = True
                    'Frm_MainForm.QuanLyQuyĐinhToolStripMenuItem.Enabled = True
                    'Frm_MainForm.QuanLyTreToolStripMenuItem1.Enabled = True

                    'Frm_MainForm.XepToolStripMenuItem.Enabled = True
                    'Frm_MainForm.XepLopToolStripMenuItem2.Enabled = True
                    'Frm_MainForm.XepChuyenLopToolStripMenuItem.Enabled = True

                    'Frm_MainForm.TimKiemToolStripMenuItem.Enabled = True

                    'Frm_MainForm.BaoCaoToolStripMenuItem.Enabled = True
                    'Frm_MainForm.BaoCaoNgayToolStripMenuItem.Enabled = True

                    'Frm_MainForm.QuyDinhToolStripMenuItem.Enabled = True
                    'Frm_MainForm.QuyDinhQuanLyTinhTrangToolStripMenuItem.Enabled = True
                    'Frm_MainForm.QuyDInhThamSOToolStripMenuItem.Enabled = True
                    'Frm_MainForm.QuyDInhThemTinhTrangToolStripMenuItem.Enabled = True


                Else
                    'Phan cap cho nguoi dung cap 2
                    If (user.Lvl1 = "2") Then

                        Frm_MainForm.MenuStrip1.Show()

                        Frm_MainForm.NguoiDungStripMenuItem.Enabled = True
                        Frm_MainForm.UserToolStripMenuItem.Enabled = False
                        Frm_MainForm.DangXuatToolStripMenuItem1.Enabled = True
                        Frm_MainForm.UserTaoNgươiDungToolStripMenuItem.Enabled = False
                        Frm_MainForm.UserQuanLyNgươiDungToolStripMenuItem1.Enabled = False


                        Frm_MainForm.NhapToolStripMenuItem.Enabled = False
                        Frm_MainForm.NhapTreToolStripMenuItem.Enabled = False
                        Frm_MainForm.NhapKhoiToolStripMenuItem1.Enabled = False
                        Frm_MainForm.NhapPhieuGhiNhanToolStripMenuItem.Enabled = False
                        Frm_MainForm.NhapLopToolStripMenuItem1.Enabled = False

                        Frm_MainForm.QuanLyToolStripMenuItem.Enabled = True
                        Frm_MainForm.QuanLyKhoiToolStripMenuItem.Enabled = False
                        Frm_MainForm.QuanLyLopToolStripMenuItem.Enabled = False
                        Frm_MainForm.QuanLyPhieuGhiNhanToolStripMenuItem.Enabled = False
                        Frm_MainForm.QuanLyQuyĐinhToolStripMenuItem.Enabled = True
                        Frm_MainForm.QuanLyTreToolStripMenuItem1.Enabled = False

                        Frm_MainForm.XepToolStripMenuItem.Enabled = False
                        Frm_MainForm.XepLopToolStripMenuItem2.Enabled = False
                        Frm_MainForm.XepChuyenLopToolStripMenuItem.Enabled = False

                        Frm_MainForm.TimKiemToolStripMenuItem.Enabled = True
                        Frm_MainForm.TreToolStripMenuItem.Enabled = True

                        Frm_MainForm.BaoCaoToolStripMenuItem.Enabled = False
                        Frm_MainForm.BaoCaoNgayToolStripMenuItem.Enabled = False

                        Frm_MainForm.QuyDinhToolStripMenuItem.Enabled = True
                        Frm_MainForm.QuyDinhQuanLyTinhTrangToolStripMenuItem.Enabled = True
                        Frm_MainForm.QuyDInhThamSOToolStripMenuItem.Enabled = True
                        Frm_MainForm.QuyDInhThemTinhTrangToolStripMenuItem.Enabled = True


                    Else

                        'Phan cap cho nguoi dung cap 1
                        If (user.Lvl1 = "1") Then
                            Frm_MainForm.MenuStrip1.Show()
                            Frm_MainForm.NguoiDungStripMenuItem.Enabled = True
                            Frm_MainForm.UserToolStripMenuItem.Enabled = False
                            Frm_MainForm.DangXuatToolStripMenuItem1.Enabled = True
                            Frm_MainForm.UserTaoNgươiDungToolStripMenuItem.Enabled = False
                            Frm_MainForm.UserQuanLyNgươiDungToolStripMenuItem1.Enabled = False


                            Frm_MainForm.NhapToolStripMenuItem.Enabled = True
                            Frm_MainForm.NhapTreToolStripMenuItem.Enabled = True
                            Frm_MainForm.NhapKhoiToolStripMenuItem1.Enabled = True
                            Frm_MainForm.NhapPhieuGhiNhanToolStripMenuItem.Enabled = True
                            Frm_MainForm.NhapLopToolStripMenuItem1.Enabled = True

                            Frm_MainForm.QuanLyToolStripMenuItem.Enabled = True
                            Frm_MainForm.QuanLyKhoiToolStripMenuItem.Enabled = True
                            Frm_MainForm.QuanLyLopToolStripMenuItem.Enabled = True
                            Frm_MainForm.QuanLyPhieuGhiNhanToolStripMenuItem.Enabled = True
                            Frm_MainForm.QuanLyQuyĐinhToolStripMenuItem.Enabled = False
                            Frm_MainForm.QuanLyTreToolStripMenuItem1.Enabled = True

                            Frm_MainForm.XepToolStripMenuItem.Enabled = True
                            Frm_MainForm.XepLopToolStripMenuItem2.Enabled = True
                            Frm_MainForm.XepChuyenLopToolStripMenuItem.Enabled = True

                            Frm_MainForm.TimKiemToolStripMenuItem.Enabled = True
                            Frm_MainForm.TreToolStripMenuItem.Enabled = True

                            Frm_MainForm.BaoCaoToolStripMenuItem.Enabled = True
                            Frm_MainForm.BaoCaoNgayToolStripMenuItem.Enabled = True

                            Frm_MainForm.QuyDinhToolStripMenuItem.Enabled = False
                            Frm_MainForm.QuyDinhQuanLyTinhTrangToolStripMenuItem.Enabled = False
                            Frm_MainForm.QuyDInhThamSOToolStripMenuItem.Enabled = False
                            Frm_MainForm.QuyDInhThemTinhTrangToolStripMenuItem.Enabled = False

                        End If



                    End If
                End If

            Else
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng !")
                tb_Pass.Text = ""
                tb_User.Text = ""
            End If

        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub bt_TimTre_Click(sender As Object, e As EventArgs) Handles bt_TimTre.Click
        Dim frm As Frm_TimTre = New Frm_TimTre()
        frm.Show()
    End Sub
End Class