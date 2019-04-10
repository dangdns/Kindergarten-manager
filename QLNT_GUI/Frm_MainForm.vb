Public Class Frm_MainForm
    Private Sub Frm_MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim dangnhap As New Frm_DangNhap
        dangnhap.MdiParent = Me
        dangnhap.Show()
        MenuStrip1.Hide()
        NguoiDungStripMenuItem.Enabled = False
        UserToolStripMenuItem.Enabled = False
        DangXuatToolStripMenuItem1.Enabled = False
        UserTaoNgươiDungToolStripMenuItem.Enabled = False
        UserQuanLyNgươiDungToolStripMenuItem1.Enabled = False


        NhapToolStripMenuItem.Enabled = False
        NhapTreToolStripMenuItem.Enabled = False
        NhapKhoiToolStripMenuItem1.Enabled = False
        NhapPhieuGhiNhanToolStripMenuItem.Enabled = False
        NhapLopToolStripMenuItem1.Enabled = False

        QuanLyToolStripMenuItem.Enabled = False
        QuanLyKhoiToolStripMenuItem.Enabled = False
        QuanLyLopToolStripMenuItem.Enabled = False
        QuanLyPhieuGhiNhanToolStripMenuItem.Enabled = False
        QuanLyQuyĐinhToolStripMenuItem.Enabled = False
        QuanLyTreToolStripMenuItem1.Enabled = False

        XepToolStripMenuItem.Enabled = False
        XepLopToolStripMenuItem2.Enabled = False
        XepChuyenLopToolStripMenuItem.Enabled = False

        TimKiemToolStripMenuItem.Enabled = False

        BaoCaoToolStripMenuItem.Enabled = False
        BaoCaoNgayToolStripMenuItem.Enabled = False

        QuyDinhToolStripMenuItem.Enabled = False
        QuyDinhQuanLyTinhTrangToolStripMenuItem.Enabled = False
        QuyDInhThamSOToolStripMenuItem.Enabled = False
        QuyDInhThemTinhTrangToolStripMenuItem.Enabled = False

    End Sub
    Private Sub TrẻToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhapTreToolStripMenuItem.Click
        Dim frm As Frm_TaoTreTre = New Frm_TaoTreTre()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PhiếuGhiNhậnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhapPhieuGhiNhanToolStripMenuItem.Click
        Dim frm As Frm_TaoPhieuGhiNhan = New Frm_TaoPhieuGhiNhan()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub TrẻToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles QuanLyTreToolStripMenuItem1.Click
        Dim frm As Frm_QLTre = New Frm_QLTre()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub LơpToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NhapLopToolStripMenuItem1.Click
        Dim frm As Frm_TaoLop = New Frm_TaoLop()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub LơpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuanLyLopToolStripMenuItem.Click
        Dim frm As Frm_QLLop = New Frm_QLLop()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub LơpToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles XepLopToolStripMenuItem2.Click
        Dim frm As Frm_XepLop = New Frm_XepLop()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub TreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TreToolStripMenuItem.Click
        Dim frm As Frm_TimTre = New Frm_TimTre()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ĐăngXuâtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NguoiDungStripMenuItem.Click

    End Sub

    Private Sub ChuyênLơpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XepChuyenLopToolStripMenuItem.Click
        Dim frm As Frm_ChuyenLop = New Frm_ChuyenLop()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PhiêuGhiNhânToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuanLyPhieuGhiNhanToolStripMenuItem.Click
        Dim frm As Frm_QLPhieuGhiNhan = New Frm_QLPhieuGhiNhan()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BaoCaoNgayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BaoCaoNgayToolStripMenuItem.Click
        Dim frm As Frm_BaoCao = New Frm_BaoCao()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ThamSôToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuyDInhThamSOToolStripMenuItem.Click
        Dim frm As Frm_QuyDinhTS = New Frm_QuyDinhTS()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ThêmTinhTrangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuyDInhThemTinhTrangToolStripMenuItem.Click
        Dim frm As Frm_TaoTinhTrang = New Frm_TaoTinhTrang()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuanLyTinhTrangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuyDinhQuanLyTinhTrangToolStripMenuItem.Click
        Dim frm As Frm_QLTInhTrang = New Frm_QLTInhTrang()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuyĐịnhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuanLyQuyĐinhToolStripMenuItem.Click
        Dim frm As Frm_QLQuyDinh = New Frm_QLQuyDinh()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ĐăngXuâtToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DangXuatToolStripMenuItem1.Click
        Dim dangnhap As New Frm_DangNhap
        dangnhap.MdiParent = Me
        dangnhap.Show()
        MenuStrip1.Hide()
        NhapTreToolStripMenuItem.Enabled = False
        NhapPhieuGhiNhanToolStripMenuItem.Enabled = False
        QuanLyTreToolStripMenuItem1.Enabled = False
        QuanLyLopToolStripMenuItem.Enabled = False
        NhapLopToolStripMenuItem1.Enabled = False
        XepLopToolStripMenuItem2.Enabled = False
        TreToolStripMenuItem.Enabled = False
    End Sub

    Private Sub TaoNgươiDungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserTaoNgươiDungToolStripMenuItem.Click
        Dim frm As Frm_TaoNguoiDung = New Frm_TaoNguoiDung()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuanLyNgươiDungToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UserQuanLyNgươiDungToolStripMenuItem1.Click
        Dim frm As Frm_QLNguoiDung = New Frm_QLNguoiDung()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub KhôiToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NhapKhoiToolStripMenuItem1.Click
        Dim frm As Frm_TaoKhoi = New Frm_TaoKhoi()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub KhôiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuanLyKhoiToolStripMenuItem.Click
        Dim frm As Frm_QLKhoi = New Frm_QLKhoi()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLýToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuanLyToolStripMenuItem.Click

    End Sub
End Class
