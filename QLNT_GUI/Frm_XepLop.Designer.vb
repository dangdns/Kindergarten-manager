<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_XepLop
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb_Khoi = New System.Windows.Forms.ComboBox()
        Me.cb_SiSo = New System.Windows.Forms.ComboBox()
        Me.DG_XepLop = New System.Windows.Forms.DataGridView()
        Me.DG_STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DG_MaTre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DG_TenTre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DG_GioiTInh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DG_GhiChu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DG_NgayNhapHoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb_MaLop = New System.Windows.Forms.TextBox()
        Me.bt_XepLop = New System.Windows.Forms.Button()
        Me.bt_Thoat = New System.Windows.Forms.Button()
        Me.cb_TenLop = New System.Windows.Forms.ComboBox()
        Me.dgvListHS_FROM = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DG_XepLop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListHS_FROM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(241, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "XẾP LỚP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tên lớp:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Mã lớp:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Khối:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Sỉ số:"
        '
        'cb_Khoi
        '
        Me.cb_Khoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Khoi.FormattingEnabled = True
        Me.cb_Khoi.Location = New System.Drawing.Point(65, 88)
        Me.cb_Khoi.Name = "cb_Khoi"
        Me.cb_Khoi.Size = New System.Drawing.Size(121, 21)
        Me.cb_Khoi.TabIndex = 7
        '
        'cb_SiSo
        '
        Me.cb_SiSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_SiSo.FormattingEnabled = True
        Me.cb_SiSo.Location = New System.Drawing.Point(65, 159)
        Me.cb_SiSo.Name = "cb_SiSo"
        Me.cb_SiSo.Size = New System.Drawing.Size(121, 21)
        Me.cb_SiSo.TabIndex = 8
        '
        'DG_XepLop
        '
        Me.DG_XepLop.AllowUserToAddRows = False
        Me.DG_XepLop.AllowUserToOrderColumns = True
        Me.DG_XepLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_XepLop.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DG_STT, Me.DG_MaTre, Me.DG_TenTre, Me.DG_GioiTInh, Me.DG_GhiChu, Me.DG_NgayNhapHoc})
        Me.DG_XepLop.Location = New System.Drawing.Point(12, 238)
        Me.DG_XepLop.Name = "DG_XepLop"
        Me.DG_XepLop.Size = New System.Drawing.Size(644, 150)
        Me.DG_XepLop.TabIndex = 9
        '
        'DG_STT
        '
        Me.DG_STT.HeaderText = "STT"
        Me.DG_STT.Name = "DG_STT"
        Me.DG_STT.ReadOnly = True
        '
        'DG_MaTre
        '
        Me.DG_MaTre.HeaderText = "Mã trẻ"
        Me.DG_MaTre.MaxInputLength = 8
        Me.DG_MaTre.Name = "DG_MaTre"
        '
        'DG_TenTre
        '
        Me.DG_TenTre.HeaderText = "Tên trẻ"
        Me.DG_TenTre.Name = "DG_TenTre"
        Me.DG_TenTre.ReadOnly = True
        '
        'DG_GioiTInh
        '
        Me.DG_GioiTInh.HeaderText = "Giới tính"
        Me.DG_GioiTInh.Name = "DG_GioiTInh"
        Me.DG_GioiTInh.ReadOnly = True
        '
        'DG_GhiChu
        '
        Me.DG_GhiChu.HeaderText = "Ghi chú"
        Me.DG_GhiChu.MaxInputLength = 100
        Me.DG_GhiChu.Name = "DG_GhiChu"
        '
        'DG_NgayNhapHoc
        '
        Me.DG_NgayNhapHoc.HeaderText = "Ngày nhập học"
        Me.DG_NgayNhapHoc.Name = "DG_NgayNhapHoc"
        '
        'tb_MaLop
        '
        Me.tb_MaLop.Location = New System.Drawing.Point(65, 198)
        Me.tb_MaLop.Name = "tb_MaLop"
        Me.tb_MaLop.ReadOnly = True
        Me.tb_MaLop.Size = New System.Drawing.Size(121, 20)
        Me.tb_MaLop.TabIndex = 28
        '
        'bt_XepLop
        '
        Me.bt_XepLop.Location = New System.Drawing.Point(173, 405)
        Me.bt_XepLop.Name = "bt_XepLop"
        Me.bt_XepLop.Size = New System.Drawing.Size(92, 51)
        Me.bt_XepLop.TabIndex = 29
        Me.bt_XepLop.Text = "Xếp lớp"
        Me.bt_XepLop.UseVisualStyleBackColor = True
        '
        'bt_Thoat
        '
        Me.bt_Thoat.Location = New System.Drawing.Point(351, 405)
        Me.bt_Thoat.Name = "bt_Thoat"
        Me.bt_Thoat.Size = New System.Drawing.Size(91, 51)
        Me.bt_Thoat.TabIndex = 30
        Me.bt_Thoat.Text = "Thoát"
        Me.bt_Thoat.UseVisualStyleBackColor = True
        '
        'cb_TenLop
        '
        Me.cb_TenLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_TenLop.FormattingEnabled = True
        Me.cb_TenLop.Location = New System.Drawing.Point(65, 123)
        Me.cb_TenLop.Name = "cb_TenLop"
        Me.cb_TenLop.Size = New System.Drawing.Size(121, 21)
        Me.cb_TenLop.TabIndex = 31
        '
        'dgvListHS_FROM
        '
        Me.dgvListHS_FROM.AllowUserToAddRows = False
        Me.dgvListHS_FROM.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvListHS_FROM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListHS_FROM.Location = New System.Drawing.Point(202, 74)
        Me.dgvListHS_FROM.MultiSelect = False
        Me.dgvListHS_FROM.Name = "dgvListHS_FROM"
        Me.dgvListHS_FROM.ReadOnly = True
        Me.dgvListHS_FROM.RowHeadersVisible = False
        Me.dgvListHS_FROM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListHS_FROM.Size = New System.Drawing.Size(306, 158)
        Me.dgvListHS_FROM.TabIndex = 85
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(199, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 13)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Danh sách trẻ chưa có lớp:"
        '
        'Frm_XepLop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 485)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvListHS_FROM)
        Me.Controls.Add(Me.cb_TenLop)
        Me.Controls.Add(Me.bt_Thoat)
        Me.Controls.Add(Me.bt_XepLop)
        Me.Controls.Add(Me.tb_MaLop)
        Me.Controls.Add(Me.DG_XepLop)
        Me.Controls.Add(Me.cb_SiSo)
        Me.Controls.Add(Me.cb_Khoi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_XepLop"
        Me.Text = "Xếp lớp"
        CType(Me.DG_XepLop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListHS_FROM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cb_Khoi As ComboBox
    Friend WithEvents cb_SiSo As ComboBox
    Friend WithEvents DG_XepLop As DataGridView
    Friend WithEvents tb_MaLop As TextBox
    Friend WithEvents bt_XepLop As Button
    Friend WithEvents bt_Thoat As Button
    Friend WithEvents cb_TenLop As ComboBox
    Friend WithEvents DG_STT As DataGridViewTextBoxColumn
    Friend WithEvents DG_MaTre As DataGridViewTextBoxColumn
    Friend WithEvents DG_TenTre As DataGridViewTextBoxColumn
    Friend WithEvents DG_GioiTInh As DataGridViewTextBoxColumn
    Friend WithEvents DG_GhiChu As DataGridViewTextBoxColumn
    Friend WithEvents DG_NgayNhapHoc As DataGridViewTextBoxColumn
    Friend WithEvents dgvListHS_FROM As DataGridView
    Friend WithEvents Label6 As Label
End Class
