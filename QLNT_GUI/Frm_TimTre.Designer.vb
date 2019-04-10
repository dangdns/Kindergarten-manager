<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_TimTre
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
        Me.cb_Khoi = New System.Windows.Forms.ComboBox()
        Me.cb_TenLop = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_HocHanh = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cb_MaTre = New System.Windows.Forms.CheckBox()
        Me.cb_GioiTinh = New System.Windows.Forms.ComboBox()
        Me.tb_DienThoai = New System.Windows.Forms.TextBox()
        Me.tb_MaTre = New System.Windows.Forms.TextBox()
        Me.tb_TenPhuHuynh = New System.Windows.Forms.TextBox()
        Me.tb_TenONha = New System.Windows.Forms.TextBox()
        Me.tb_HovaTenTre = New System.Windows.Forms.TextBox()
        Me.btn_Tim = New System.Windows.Forms.Button()
        Me.btn_Thoat = New System.Windows.Forms.Button()
        Me.DG_TIMTRE = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DG_TIMTRE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(343, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "TÌM TRẺ"
        '
        'cb_Khoi
        '
        Me.cb_Khoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Khoi.FormattingEnabled = True
        Me.cb_Khoi.Location = New System.Drawing.Point(73, 31)
        Me.cb_Khoi.Name = "cb_Khoi"
        Me.cb_Khoi.Size = New System.Drawing.Size(121, 21)
        Me.cb_Khoi.TabIndex = 4
        '
        'cb_TenLop
        '
        Me.cb_TenLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_TenLop.FormattingEnabled = True
        Me.cb_TenLop.Location = New System.Drawing.Point(73, 73)
        Me.cb_TenLop.Name = "cb_TenLop"
        Me.cb_TenLop.Size = New System.Drawing.Size(121, 21)
        Me.cb_TenLop.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cb_HocHanh)
        Me.GroupBox1.Controls.Add(Me.cb_TenLop)
        Me.GroupBox1.Controls.Add(Me.cb_Khoi)
        Me.GroupBox1.Location = New System.Drawing.Point(573, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'cb_HocHanh
        '
        Me.cb_HocHanh.AutoSize = True
        Me.cb_HocHanh.Location = New System.Drawing.Point(6, 0)
        Me.cb_HocHanh.Name = "cb_HocHanh"
        Me.cb_HocHanh.Size = New System.Drawing.Size(73, 17)
        Me.cb_HocHanh.TabIndex = 9
        Me.cb_HocHanh.Text = "Học hành"
        Me.cb_HocHanh.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cb_MaTre)
        Me.GroupBox2.Controls.Add(Me.cb_GioiTinh)
        Me.GroupBox2.Controls.Add(Me.tb_DienThoai)
        Me.GroupBox2.Controls.Add(Me.tb_MaTre)
        Me.GroupBox2.Controls.Add(Me.tb_TenPhuHuynh)
        Me.GroupBox2.Controls.Add(Me.tb_TenONha)
        Me.GroupBox2.Controls.Add(Me.tb_HovaTenTre)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(543, 178)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông tin cá nhân"
        '
        'cb_MaTre
        '
        Me.cb_MaTre.AutoSize = True
        Me.cb_MaTre.Location = New System.Drawing.Point(316, 23)
        Me.cb_MaTre.Name = "cb_MaTre"
        Me.cb_MaTre.Size = New System.Drawing.Size(59, 17)
        Me.cb_MaTre.TabIndex = 22
        Me.cb_MaTre.Text = "Mã trẻ:"
        Me.cb_MaTre.UseVisualStyleBackColor = True
        '
        'cb_GioiTinh
        '
        Me.cb_GioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_GioiTinh.FormattingEnabled = True
        Me.cb_GioiTinh.Location = New System.Drawing.Point(381, 54)
        Me.cb_GioiTinh.Name = "cb_GioiTinh"
        Me.cb_GioiTinh.Size = New System.Drawing.Size(156, 21)
        Me.cb_GioiTinh.TabIndex = 9
        '
        'tb_DienThoai
        '
        Me.tb_DienThoai.Location = New System.Drawing.Point(381, 93)
        Me.tb_DienThoai.MaxLength = 12
        Me.tb_DienThoai.Name = "tb_DienThoai"
        Me.tb_DienThoai.Size = New System.Drawing.Size(156, 20)
        Me.tb_DienThoai.TabIndex = 13
        '
        'tb_MaTre
        '
        Me.tb_MaTre.Location = New System.Drawing.Point(381, 20)
        Me.tb_MaTre.MaxLength = 8
        Me.tb_MaTre.Name = "tb_MaTre"
        Me.tb_MaTre.Size = New System.Drawing.Size(156, 20)
        Me.tb_MaTre.TabIndex = 12
        '
        'tb_TenPhuHuynh
        '
        Me.tb_TenPhuHuynh.Location = New System.Drawing.Point(130, 57)
        Me.tb_TenPhuHuynh.MaxLength = 50
        Me.tb_TenPhuHuynh.Name = "tb_TenPhuHuynh"
        Me.tb_TenPhuHuynh.Size = New System.Drawing.Size(146, 20)
        Me.tb_TenPhuHuynh.TabIndex = 11
        '
        'tb_TenONha
        '
        Me.tb_TenONha.Location = New System.Drawing.Point(130, 96)
        Me.tb_TenONha.MaxLength = 20
        Me.tb_TenONha.Name = "tb_TenONha"
        Me.tb_TenONha.Size = New System.Drawing.Size(146, 20)
        Me.tb_TenONha.TabIndex = 10
        '
        'tb_HovaTenTre
        '
        Me.tb_HovaTenTre.Location = New System.Drawing.Point(130, 17)
        Me.tb_HovaTenTre.Name = "tb_HovaTenTre"
        Me.tb_HovaTenTre.Size = New System.Drawing.Size(146, 20)
        Me.tb_HovaTenTre.TabIndex = 9
        '
        'btn_Tim
        '
        Me.btn_Tim.Location = New System.Drawing.Point(590, 158)
        Me.btn_Tim.Name = "btn_Tim"
        Me.btn_Tim.Size = New System.Drawing.Size(90, 68)
        Me.btn_Tim.TabIndex = 9
        Me.btn_Tim.Text = "Tìm kiếm"
        Me.btn_Tim.UseVisualStyleBackColor = True
        '
        'btn_Thoat
        '
        Me.btn_Thoat.Location = New System.Drawing.Point(686, 158)
        Me.btn_Thoat.Name = "btn_Thoat"
        Me.btn_Thoat.Size = New System.Drawing.Size(87, 68)
        Me.btn_Thoat.TabIndex = 10
        Me.btn_Thoat.Text = "Thoát"
        Me.btn_Thoat.UseVisualStyleBackColor = True
        '
        'DG_TIMTRE
        '
        Me.DG_TIMTRE.AllowUserToAddRows = False
        Me.DG_TIMTRE.AllowUserToDeleteRows = False
        Me.DG_TIMTRE.BackgroundColor = System.Drawing.Color.Gray
        Me.DG_TIMTRE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_TIMTRE.GridColor = System.Drawing.Color.White
        Me.DG_TIMTRE.Location = New System.Drawing.Point(12, 232)
        Me.DG_TIMTRE.Name = "DG_TIMTRE"
        Me.DG_TIMTRE.ReadOnly = True
        Me.DG_TIMTRE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_TIMTRE.Size = New System.Drawing.Size(783, 142)
        Me.DG_TIMTRE.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Họ tên trẻ:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Tên phụ huynh:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Tên ở nhà:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(322, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Giới tính:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(313, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Điện thoại:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Khối:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Lớp:"
        '
        'Frm_TimTre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 450)
        Me.Controls.Add(Me.DG_TIMTRE)
        Me.Controls.Add(Me.btn_Thoat)
        Me.Controls.Add(Me.btn_Tim)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_TimTre"
        Me.Text = "Frm_TimTre"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DG_TIMTRE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cb_Khoi As ComboBox
    Friend WithEvents cb_TenLop As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tb_MaTre As TextBox
    Friend WithEvents tb_HovaTenTre As TextBox
    Friend WithEvents btn_Tim As Button
    Friend WithEvents btn_Thoat As Button
    Friend WithEvents cb_GioiTinh As ComboBox
    Friend WithEvents DG_TIMTRE As DataGridView
    Friend WithEvents cb_MaTre As CheckBox
    Friend WithEvents cb_HocHanh As CheckBox
    Friend WithEvents tb_DienThoai As TextBox
    Friend WithEvents tb_TenPhuHuynh As TextBox
    Friend WithEvents tb_TenONha As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
End Class
