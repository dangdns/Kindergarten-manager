<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_TaoTreTre
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtHovaTen = New System.Windows.Forms.TextBox()
        Me.lbTenTre = New System.Windows.Forms.Label()
        Me.lbTenONha = New System.Windows.Forms.Label()
        Me.txtTenONha = New System.Windows.Forms.TextBox()
        Me.lbDiaChi = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.lbPhuHuynh = New System.Windows.Forms.Label()
        Me.txtTenPhuHuynh = New System.Windows.Forms.TextBox()
        Me.lbDienThoai = New System.Windows.Forms.Label()
        Me.txtDienThoai = New System.Windows.Forms.TextBox()
        Me.lbNgaySinh = New System.Windows.Forms.Label()
        Me.dtNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.btNhap = New System.Windows.Forms.Button()
        Me.btThoat = New System.Windows.Forms.Button()
        Me.lbGioiTinh = New System.Windows.Forms.Label()
        Me.cbGioiTinh = New System.Windows.Forms.ComboBox()
        Me.lbFrmName = New System.Windows.Forms.Label()
        Me.lbMaTre = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtHovaTen
        '
        Me.txtHovaTen.Location = New System.Drawing.Point(111, 72)
        Me.txtHovaTen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtHovaTen.Name = "txtHovaTen"
        Me.txtHovaTen.Size = New System.Drawing.Size(142, 20)
        Me.txtHovaTen.TabIndex = 0
        '
        'lbTenTre
        '
        Me.lbTenTre.AutoSize = True
        Me.lbTenTre.Location = New System.Drawing.Point(25, 72)
        Me.lbTenTre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTenTre.Name = "lbTenTre"
        Me.lbTenTre.Size = New System.Drawing.Size(72, 13)
        Me.lbTenTre.TabIndex = 1
        Me.lbTenTre.Text = "Họ và tên trẻ:"
        '
        'lbTenONha
        '
        Me.lbTenONha.AutoSize = True
        Me.lbTenONha.Location = New System.Drawing.Point(25, 102)
        Me.lbTenONha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTenONha.Name = "lbTenONha"
        Me.lbTenONha.Size = New System.Drawing.Size(59, 13)
        Me.lbTenONha.TabIndex = 3
        Me.lbTenONha.Text = "Tên ở nhà:"
        '
        'txtTenONha
        '
        Me.txtTenONha.Location = New System.Drawing.Point(111, 102)
        Me.txtTenONha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTenONha.Name = "txtTenONha"
        Me.txtTenONha.Size = New System.Drawing.Size(142, 20)
        Me.txtTenONha.TabIndex = 2
        '
        'lbDiaChi
        '
        Me.lbDiaChi.AutoSize = True
        Me.lbDiaChi.Location = New System.Drawing.Point(25, 167)
        Me.lbDiaChi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbDiaChi.Name = "lbDiaChi"
        Me.lbDiaChi.Size = New System.Drawing.Size(44, 13)
        Me.lbDiaChi.TabIndex = 5
        Me.lbDiaChi.Text = "Địa Chỉ:"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(111, 166)
        Me.txtDiaChi.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(142, 20)
        Me.txtDiaChi.TabIndex = 4
        '
        'lbPhuHuynh
        '
        Me.lbPhuHuynh.AutoSize = True
        Me.lbPhuHuynh.Location = New System.Drawing.Point(25, 229)
        Me.lbPhuHuynh.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbPhuHuynh.Name = "lbPhuHuynh"
        Me.lbPhuHuynh.Size = New System.Drawing.Size(82, 13)
        Me.lbPhuHuynh.TabIndex = 7
        Me.lbPhuHuynh.Text = "Tên phụ huynh:"
        '
        'txtTenPhuHuynh
        '
        Me.txtTenPhuHuynh.Location = New System.Drawing.Point(111, 229)
        Me.txtTenPhuHuynh.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTenPhuHuynh.Name = "txtTenPhuHuynh"
        Me.txtTenPhuHuynh.Size = New System.Drawing.Size(142, 20)
        Me.txtTenPhuHuynh.TabIndex = 6
        '
        'lbDienThoai
        '
        Me.lbDienThoai.AutoSize = True
        Me.lbDienThoai.Location = New System.Drawing.Point(25, 266)
        Me.lbDienThoai.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbDienThoai.Name = "lbDienThoai"
        Me.lbDienThoai.Size = New System.Drawing.Size(58, 13)
        Me.lbDienThoai.TabIndex = 9
        Me.lbDienThoai.Text = "Điện thoại:"
        '
        'txtDienThoai
        '
        Me.txtDienThoai.Location = New System.Drawing.Point(111, 266)
        Me.txtDienThoai.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDienThoai.Name = "txtDienThoai"
        Me.txtDienThoai.Size = New System.Drawing.Size(107, 20)
        Me.txtDienThoai.TabIndex = 8
        '
        'lbNgaySinh
        '
        Me.lbNgaySinh.AutoSize = True
        Me.lbNgaySinh.Location = New System.Drawing.Point(25, 198)
        Me.lbNgaySinh.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbNgaySinh.Name = "lbNgaySinh"
        Me.lbNgaySinh.Size = New System.Drawing.Size(59, 13)
        Me.lbNgaySinh.TabIndex = 10
        Me.lbNgaySinh.Text = "Ngày Sinh:"
        '
        'dtNgaySinh
        '
        Me.dtNgaySinh.Location = New System.Drawing.Point(111, 197)
        Me.dtNgaySinh.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtNgaySinh.Name = "dtNgaySinh"
        Me.dtNgaySinh.Size = New System.Drawing.Size(151, 20)
        Me.dtNgaySinh.TabIndex = 11
        '
        'btNhap
        '
        Me.btNhap.Location = New System.Drawing.Point(125, 295)
        Me.btNhap.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btNhap.Name = "btNhap"
        Me.btNhap.Size = New System.Drawing.Size(56, 31)
        Me.btNhap.TabIndex = 12
        Me.btNhap.Text = "Nhập"
        Me.btNhap.UseVisualStyleBackColor = True
        '
        'btThoat
        '
        Me.btThoat.Location = New System.Drawing.Point(283, 295)
        Me.btThoat.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btThoat.Name = "btThoat"
        Me.btThoat.Size = New System.Drawing.Size(56, 31)
        Me.btThoat.TabIndex = 13
        Me.btThoat.Text = "Thoát"
        Me.btThoat.UseVisualStyleBackColor = True
        '
        'lbGioiTinh
        '
        Me.lbGioiTinh.AutoSize = True
        Me.lbGioiTinh.Location = New System.Drawing.Point(25, 134)
        Me.lbGioiTinh.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbGioiTinh.Name = "lbGioiTinh"
        Me.lbGioiTinh.Size = New System.Drawing.Size(54, 13)
        Me.lbGioiTinh.TabIndex = 14
        Me.lbGioiTinh.Text = "Giới Tính:"
        '
        'cbGioiTinh
        '
        Me.cbGioiTinh.FormattingEnabled = True
        Me.cbGioiTinh.Items.AddRange(New Object() {"1", "2"})
        Me.cbGioiTinh.Location = New System.Drawing.Point(111, 134)
        Me.cbGioiTinh.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbGioiTinh.Name = "cbGioiTinh"
        Me.cbGioiTinh.Size = New System.Drawing.Size(92, 21)
        Me.cbGioiTinh.TabIndex = 15
        '
        'lbFrmName
        '
        Me.lbFrmName.AutoSize = True
        Me.lbFrmName.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFrmName.Location = New System.Drawing.Point(170, 15)
        Me.lbFrmName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbFrmName.Name = "lbFrmName"
        Me.lbFrmName.Size = New System.Drawing.Size(121, 17)
        Me.lbFrmName.TabIndex = 16
        Me.lbFrmName.Text = "TIẾP NHẬN TRẺ"
        '
        'lbMaTre
        '
        Me.lbMaTre.AutoSize = True
        Me.lbMaTre.Location = New System.Drawing.Point(301, 72)
        Me.lbMaTre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbMaTre.Name = "lbMaTre"
        Me.lbMaTre.Size = New System.Drawing.Size(40, 13)
        Me.lbMaTre.TabIndex = 17
        Me.lbMaTre.Text = "Mã trẻ:"
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.SystemColors.Control
        Me.txtID.Location = New System.Drawing.Point(355, 68)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(76, 20)
        Me.txtID.TabIndex = 18
        '
        'Frm_TaoTreTre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 342)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lbMaTre)
        Me.Controls.Add(Me.lbFrmName)
        Me.Controls.Add(Me.cbGioiTinh)
        Me.Controls.Add(Me.lbGioiTinh)
        Me.Controls.Add(Me.btThoat)
        Me.Controls.Add(Me.btNhap)
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
        Me.Name = "Frm_TaoTreTre"
        Me.Text = "Tiếp nhận trẻ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtHovaTen As TextBox
    Friend WithEvents lbTenTre As Label
    Friend WithEvents lbTenONha As Label
    Friend WithEvents txtTenONha As TextBox
    Friend WithEvents lbDiaChi As Label
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents lbPhuHuynh As Label
    Friend WithEvents txtTenPhuHuynh As TextBox
    Friend WithEvents lbDienThoai As Label
    Friend WithEvents txtDienThoai As TextBox
    Friend WithEvents lbNgaySinh As Label
    Friend WithEvents dtNgaySinh As DateTimePicker
    Friend WithEvents btNhap As Button
    Friend WithEvents btThoat As Button
    Friend WithEvents lbGioiTinh As Label
    Friend WithEvents cbGioiTinh As ComboBox
    Friend WithEvents lbFrmName As Label
    Friend WithEvents lbMaTre As Label
    Friend WithEvents txtID As TextBox
End Class
