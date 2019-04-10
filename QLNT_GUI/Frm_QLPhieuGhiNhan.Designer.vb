<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_QLPhieuGhiNhan
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
        Me.dgvPGN = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbKhoi = New System.Windows.Forms.ComboBox()
        Me.cbTinhTrang = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtNgay = New System.Windows.Forms.DateTimePicker()
        Me.cbID = New System.Windows.Forms.ComboBox()
        Me.btSua = New System.Windows.Forms.Button()
        Me.btXoa = New System.Windows.Forms.Button()
        Me.txtMaPhieu = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbID1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtGhiChu = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.dgvPGN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPGN
        '
        Me.dgvPGN.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvPGN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPGN.Location = New System.Drawing.Point(31, 113)
        Me.dgvPGN.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvPGN.MultiSelect = False
        Me.dgvPGN.Name = "dgvPGN"
        Me.dgvPGN.ReadOnly = True
        Me.dgvPGN.RowHeadersVisible = False
        Me.dgvPGN.RowTemplate.Height = 24
        Me.dgvPGN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPGN.Size = New System.Drawing.Size(521, 222)
        Me.dgvPGN.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 367)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Họ tên"
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(115, 362)
        Me.txtHoTen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.ReadOnly = True
        Me.txtHoTen.Size = New System.Drawing.Size(131, 20)
        Me.txtHoTen.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(321, 367)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mã trẻ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 411)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Khối"
        '
        'cbKhoi
        '
        Me.cbKhoi.FormattingEnabled = True
        Me.cbKhoi.Location = New System.Drawing.Point(115, 404)
        Me.cbKhoi.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbKhoi.Name = "cbKhoi"
        Me.cbKhoi.Size = New System.Drawing.Size(131, 21)
        Me.cbKhoi.TabIndex = 7
        '
        'cbTinhTrang
        '
        Me.cbTinhTrang.FormattingEnabled = True
        Me.cbTinhTrang.Location = New System.Drawing.Point(115, 448)
        Me.cbTinhTrang.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbTinhTrang.Name = "cbTinhTrang"
        Me.cbTinhTrang.Size = New System.Drawing.Size(131, 21)
        Me.cbTinhTrang.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 455)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Tình trạng"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 502)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Ngày"
        '
        'dtNgay
        '
        Me.dtNgay.Location = New System.Drawing.Point(115, 500)
        Me.dtNgay.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtNgay.Name = "dtNgay"
        Me.dtNgay.Size = New System.Drawing.Size(190, 20)
        Me.dtNgay.TabIndex = 11
        '
        'cbID
        '
        Me.cbID.FormattingEnabled = True
        Me.cbID.Location = New System.Drawing.Point(395, 362)
        Me.cbID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbID.Name = "cbID"
        Me.cbID.Size = New System.Drawing.Size(131, 21)
        Me.cbID.TabIndex = 12
        '
        'btSua
        '
        Me.btSua.Location = New System.Drawing.Point(188, 552)
        Me.btSua.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btSua.Name = "btSua"
        Me.btSua.Size = New System.Drawing.Size(56, 39)
        Me.btSua.TabIndex = 13
        Me.btSua.Text = "Sửa"
        Me.btSua.UseVisualStyleBackColor = True
        '
        'btXoa
        '
        Me.btXoa.Location = New System.Drawing.Point(344, 552)
        Me.btXoa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btXoa.Name = "btXoa"
        Me.btXoa.Size = New System.Drawing.Size(59, 39)
        Me.btXoa.TabIndex = 14
        Me.btXoa.Text = "Xóa"
        Me.btXoa.UseVisualStyleBackColor = True
        '
        'txtMaPhieu
        '
        Me.txtMaPhieu.Location = New System.Drawing.Point(395, 404)
        Me.txtMaPhieu.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtMaPhieu.Name = "txtMaPhieu"
        Me.txtMaPhieu.ReadOnly = True
        Me.txtMaPhieu.Size = New System.Drawing.Size(131, 20)
        Me.txtMaPhieu.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(321, 410)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Mã phiếu"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(115, 70)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(131, 20)
        Me.TextBox1.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(45, 76)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Họ tên"
        '
        'cbID1
        '
        Me.cbID1.FormattingEnabled = True
        Me.cbID1.Location = New System.Drawing.Point(395, 70)
        Me.cbID1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbID1.Name = "cbID1"
        Me.cbID1.Size = New System.Drawing.Size(131, 21)
        Me.cbID1.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(321, 76)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Mã trẻ"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(98, 7)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(419, 35)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "QUẢN LÝ PHIẾU GHI NHẬN"
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Location = New System.Drawing.Point(395, 448)
        Me.txtGhiChu.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(131, 20)
        Me.txtGhiChu.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(321, 450)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Ghi chú"
        '
        'Frm_QLPhieuGhiNhan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 599)
        Me.Controls.Add(Me.txtGhiChu)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbID1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtMaPhieu)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btXoa)
        Me.Controls.Add(Me.btSua)
        Me.Controls.Add(Me.cbID)
        Me.Controls.Add(Me.dtNgay)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbTinhTrang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbKhoi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtHoTen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvPGN)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Frm_QLPhieuGhiNhan"
        Me.Text = "Quản lý phiếu ghi nhận"
        CType(Me.dgvPGN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvPGN As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbKhoi As ComboBox
    Friend WithEvents cbTinhTrang As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtNgay As DateTimePicker
    Friend WithEvents cbID As ComboBox
    Friend WithEvents btSua As Button
    Friend WithEvents btXoa As Button
    Friend WithEvents txtMaPhieu As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbID1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtGhiChu As TextBox
    Friend WithEvents Label10 As Label
End Class
