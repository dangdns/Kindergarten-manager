<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_QLTre
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lbMaTre = New System.Windows.Forms.Label()
        Me.lbFrmName = New System.Windows.Forms.Label()
        Me.cbGioiTinh = New System.Windows.Forms.ComboBox()
        Me.lbGioiTinh = New System.Windows.Forms.Label()
        Me.btThoat = New System.Windows.Forms.Button()
        Me.btSua = New System.Windows.Forms.Button()
        Me.dtNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.lbNgaySinh = New System.Windows.Forms.Label()
        Me.lbDienThoai = New System.Windows.Forms.Label()
        Me.txtDienThoai = New System.Windows.Forms.TextBox()
        Me.lbPhuHuynh = New System.Windows.Forms.Label()
        Me.txtTenPhuHuynh = New System.Windows.Forms.TextBox()
        Me.lbDiaChi = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.lbTenONha = New System.Windows.Forms.Label()
        Me.txtTenONha = New System.Windows.Forms.TextBox()
        Me.lbTenTre = New System.Windows.Forms.Label()
        Me.txtHovaTen = New System.Windows.Forms.TextBox()
        Me.btXoa = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbGhiChu = New System.Windows.Forms.TextBox()
        Me.dtNgayNhapHoc = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.SystemColors.Window
        Me.txtID.Location = New System.Drawing.Point(119, 89)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(76, 20)
        Me.txtID.TabIndex = 37
        '
        'lbMaTre
        '
        Me.lbMaTre.AutoSize = True
        Me.lbMaTre.Location = New System.Drawing.Point(35, 93)
        Me.lbMaTre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbMaTre.Name = "lbMaTre"
        Me.lbMaTre.Size = New System.Drawing.Size(40, 13)
        Me.lbMaTre.TabIndex = 36
        Me.lbMaTre.Text = "Mã trẻ:"
        '
        'lbFrmName
        '
        Me.lbFrmName.AutoSize = True
        Me.lbFrmName.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFrmName.Location = New System.Drawing.Point(168, 7)
        Me.lbFrmName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbFrmName.Name = "lbFrmName"
        Me.lbFrmName.Size = New System.Drawing.Size(222, 35)
        Me.lbFrmName.TabIndex = 35
        Me.lbFrmName.Text = "QUẢN LÝ TRẺ"
        '
        'cbGioiTinh
        '
        Me.cbGioiTinh.FormattingEnabled = True
        Me.cbGioiTinh.Items.AddRange(New Object() {"1", "2"})
        Me.cbGioiTinh.Location = New System.Drawing.Point(120, 180)
        Me.cbGioiTinh.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbGioiTinh.Name = "cbGioiTinh"
        Me.cbGioiTinh.Size = New System.Drawing.Size(92, 21)
        Me.cbGioiTinh.TabIndex = 34
        '
        'lbGioiTinh
        '
        Me.lbGioiTinh.AutoSize = True
        Me.lbGioiTinh.Location = New System.Drawing.Point(34, 180)
        Me.lbGioiTinh.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbGioiTinh.Name = "lbGioiTinh"
        Me.lbGioiTinh.Size = New System.Drawing.Size(54, 13)
        Me.lbGioiTinh.TabIndex = 33
        Me.lbGioiTinh.Text = "Giới Tính:"
        '
        'btThoat
        '
        Me.btThoat.Location = New System.Drawing.Point(411, 384)
        Me.btThoat.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btThoat.Name = "btThoat"
        Me.btThoat.Size = New System.Drawing.Size(56, 31)
        Me.btThoat.TabIndex = 32
        Me.btThoat.Text = "Thoát"
        Me.btThoat.UseVisualStyleBackColor = True
        '
        'btSua
        '
        Me.btSua.Location = New System.Drawing.Point(106, 384)
        Me.btSua.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btSua.Name = "btSua"
        Me.btSua.Size = New System.Drawing.Size(56, 31)
        Me.btSua.TabIndex = 31
        Me.btSua.Text = "Lưu"
        Me.btSua.UseVisualStyleBackColor = True
        '
        'dtNgaySinh
        '
        Me.dtNgaySinh.Location = New System.Drawing.Point(120, 243)
        Me.dtNgaySinh.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtNgaySinh.Name = "dtNgaySinh"
        Me.dtNgaySinh.Size = New System.Drawing.Size(151, 20)
        Me.dtNgaySinh.TabIndex = 30
        '
        'lbNgaySinh
        '
        Me.lbNgaySinh.AutoSize = True
        Me.lbNgaySinh.Location = New System.Drawing.Point(34, 245)
        Me.lbNgaySinh.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbNgaySinh.Name = "lbNgaySinh"
        Me.lbNgaySinh.Size = New System.Drawing.Size(59, 13)
        Me.lbNgaySinh.TabIndex = 29
        Me.lbNgaySinh.Text = "Ngày Sinh:"
        '
        'lbDienThoai
        '
        Me.lbDienThoai.AutoSize = True
        Me.lbDienThoai.Location = New System.Drawing.Point(34, 313)
        Me.lbDienThoai.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbDienThoai.Name = "lbDienThoai"
        Me.lbDienThoai.Size = New System.Drawing.Size(58, 13)
        Me.lbDienThoai.TabIndex = 28
        Me.lbDienThoai.Text = "Điện thoại:"
        '
        'txtDienThoai
        '
        Me.txtDienThoai.Location = New System.Drawing.Point(120, 313)
        Me.txtDienThoai.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDienThoai.Name = "txtDienThoai"
        Me.txtDienThoai.Size = New System.Drawing.Size(122, 20)
        Me.txtDienThoai.TabIndex = 27
        '
        'lbPhuHuynh
        '
        Me.lbPhuHuynh.AutoSize = True
        Me.lbPhuHuynh.Location = New System.Drawing.Point(34, 275)
        Me.lbPhuHuynh.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbPhuHuynh.Name = "lbPhuHuynh"
        Me.lbPhuHuynh.Size = New System.Drawing.Size(82, 13)
        Me.lbPhuHuynh.TabIndex = 26
        Me.lbPhuHuynh.Text = "Tên phụ huynh:"
        '
        'txtTenPhuHuynh
        '
        Me.txtTenPhuHuynh.Location = New System.Drawing.Point(120, 275)
        Me.txtTenPhuHuynh.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTenPhuHuynh.Name = "txtTenPhuHuynh"
        Me.txtTenPhuHuynh.Size = New System.Drawing.Size(142, 20)
        Me.txtTenPhuHuynh.TabIndex = 25
        '
        'lbDiaChi
        '
        Me.lbDiaChi.AutoSize = True
        Me.lbDiaChi.Location = New System.Drawing.Point(34, 214)
        Me.lbDiaChi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbDiaChi.Name = "lbDiaChi"
        Me.lbDiaChi.Size = New System.Drawing.Size(44, 13)
        Me.lbDiaChi.TabIndex = 24
        Me.lbDiaChi.Text = "Địa Chỉ:"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(120, 212)
        Me.txtDiaChi.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(142, 20)
        Me.txtDiaChi.TabIndex = 23
        '
        'lbTenONha
        '
        Me.lbTenONha.AutoSize = True
        Me.lbTenONha.Location = New System.Drawing.Point(34, 149)
        Me.lbTenONha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTenONha.Name = "lbTenONha"
        Me.lbTenONha.Size = New System.Drawing.Size(59, 13)
        Me.lbTenONha.TabIndex = 22
        Me.lbTenONha.Text = "Tên ở nhà:"
        '
        'txtTenONha
        '
        Me.txtTenONha.Location = New System.Drawing.Point(120, 149)
        Me.txtTenONha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTenONha.Name = "txtTenONha"
        Me.txtTenONha.Size = New System.Drawing.Size(142, 20)
        Me.txtTenONha.TabIndex = 21
        '
        'lbTenTre
        '
        Me.lbTenTre.AutoSize = True
        Me.lbTenTre.Location = New System.Drawing.Point(34, 119)
        Me.lbTenTre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTenTre.Name = "lbTenTre"
        Me.lbTenTre.Size = New System.Drawing.Size(72, 13)
        Me.lbTenTre.TabIndex = 20
        Me.lbTenTre.Text = "Họ và tên trẻ:"
        '
        'txtHovaTen
        '
        Me.txtHovaTen.Location = New System.Drawing.Point(120, 119)
        Me.txtHovaTen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtHovaTen.Name = "txtHovaTen"
        Me.txtHovaTen.Size = New System.Drawing.Size(142, 20)
        Me.txtHovaTen.TabIndex = 19
        '
        'btXoa
        '
        Me.btXoa.Location = New System.Drawing.Point(262, 384)
        Me.btXoa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btXoa.Name = "btXoa"
        Me.btXoa.Size = New System.Drawing.Size(56, 31)
        Me.btXoa.TabIndex = 38
        Me.btXoa.Text = "Xóa"
        Me.btXoa.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(273, 275)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Ghi chú:"
        '
        'tbGhiChu
        '
        Me.tbGhiChu.Location = New System.Drawing.Point(359, 275)
        Me.tbGhiChu.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbGhiChu.Name = "tbGhiChu"
        Me.tbGhiChu.Size = New System.Drawing.Size(142, 20)
        Me.tbGhiChu.TabIndex = 39
        '
        'dtNgayNhapHoc
        '
        Me.dtNgayNhapHoc.Location = New System.Drawing.Point(359, 311)
        Me.dtNgayNhapHoc.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtNgayNhapHoc.Name = "dtNgayNhapHoc"
        Me.dtNgayNhapHoc.Size = New System.Drawing.Size(151, 20)
        Me.dtNgayNhapHoc.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(273, 313)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Ngày nhập học:"
        '
        'Frm_QLTre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 439)
        Me.Controls.Add(Me.dtNgayNhapHoc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbGhiChu)
        Me.Controls.Add(Me.btXoa)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lbMaTre)
        Me.Controls.Add(Me.lbFrmName)
        Me.Controls.Add(Me.cbGioiTinh)
        Me.Controls.Add(Me.lbGioiTinh)
        Me.Controls.Add(Me.btThoat)
        Me.Controls.Add(Me.btSua)
        Me.Controls.Add(Me.dtNgaySinh)
        Me.Controls.Add(Me.lbNgaySinh)
        Me.Controls.Add(Me.lbDienThoai)
        Me.Controls.Add(Me.txtDienThoai)
        Me.Controls.Add(Me.lbPhuHuynh)
        Me.Controls.Add(Me.txtTenPhuHuynh)
        Me.Controls.Add(Me.lbDiaChi)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.lbTenONha)
        Me.Controls.Add(Me.txtTenONha)
        Me.Controls.Add(Me.lbTenTre)
        Me.Controls.Add(Me.txtHovaTen)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Frm_QLTre"
        Me.Text = "Quản lý trẻ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents lbMaTre As Label
    Friend WithEvents lbFrmName As Label
    Friend WithEvents cbGioiTinh As ComboBox
    Friend WithEvents lbGioiTinh As Label
    Friend WithEvents btThoat As Button
    Friend WithEvents btSua As Button
    Friend WithEvents dtNgaySinh As DateTimePicker
    Friend WithEvents lbNgaySinh As Label
    Friend WithEvents lbDienThoai As Label
    Friend WithEvents txtDienThoai As TextBox
    Friend WithEvents lbPhuHuynh As Label
    Friend WithEvents txtTenPhuHuynh As TextBox
    Friend WithEvents lbDiaChi As Label
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents lbTenONha As Label
    Friend WithEvents txtTenONha As TextBox
    Friend WithEvents lbTenTre As Label
    Friend WithEvents txtHovaTen As TextBox
    Friend WithEvents btXoa As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tbGhiChu As TextBox
    Friend WithEvents dtNgayNhapHoc As DateTimePicker
    Friend WithEvents Label2 As Label
End Class
