<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_BaoCao
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
        Me.dgvBaoCao = New System.Windows.Forms.DataGridView()
        Me.dtNgay = New System.Windows.Forms.DateTimePicker()
        Me.lb_ChonKhoi = New System.Windows.Forms.Label()
        Me.cb_Khoi = New System.Windows.Forms.ComboBox()
        Me.lb_ChonNgay = New System.Windows.Forms.Label()
        Me.checkB_Ngay = New System.Windows.Forms.CheckBox()
        Me.checkB_Khoi = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bt_BaoCao = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaBaoCao = New System.Windows.Forms.TextBox()
        CType(Me.dgvBaoCao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBaoCao
        '
        Me.dgvBaoCao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBaoCao.Location = New System.Drawing.Point(30, 209)
        Me.dgvBaoCao.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvBaoCao.MultiSelect = False
        Me.dgvBaoCao.Name = "dgvBaoCao"
        Me.dgvBaoCao.ReadOnly = True
        Me.dgvBaoCao.RowHeadersVisible = False
        Me.dgvBaoCao.RowTemplate.Height = 24
        Me.dgvBaoCao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBaoCao.Size = New System.Drawing.Size(521, 222)
        Me.dgvBaoCao.TabIndex = 3
        '
        'dtNgay
        '
        Me.dtNgay.Location = New System.Drawing.Point(378, 123)
        Me.dtNgay.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtNgay.Name = "dtNgay"
        Me.dtNgay.Size = New System.Drawing.Size(151, 20)
        Me.dtNgay.TabIndex = 2
        '
        'lb_ChonKhoi
        '
        Me.lb_ChonKhoi.AutoSize = True
        Me.lb_ChonKhoi.Location = New System.Drawing.Point(314, 163)
        Me.lb_ChonKhoi.Name = "lb_ChonKhoi"
        Me.lb_ChonKhoi.Size = New System.Drawing.Size(58, 13)
        Me.lb_ChonKhoi.TabIndex = 4
        Me.lb_ChonKhoi.Text = "Chọn khối:"
        '
        'cb_Khoi
        '
        Me.cb_Khoi.FormattingEnabled = True
        Me.cb_Khoi.Location = New System.Drawing.Point(378, 160)
        Me.cb_Khoi.Name = "cb_Khoi"
        Me.cb_Khoi.Size = New System.Drawing.Size(151, 21)
        Me.cb_Khoi.TabIndex = 5
        '
        'lb_ChonNgay
        '
        Me.lb_ChonNgay.AutoSize = True
        Me.lb_ChonNgay.Location = New System.Drawing.Point(311, 128)
        Me.lb_ChonNgay.Name = "lb_ChonNgay"
        Me.lb_ChonNgay.Size = New System.Drawing.Size(61, 13)
        Me.lb_ChonNgay.TabIndex = 6
        Me.lb_ChonNgay.Text = "Chọn ngày:"
        '
        'checkB_Ngay
        '
        Me.checkB_Ngay.AutoSize = True
        Me.checkB_Ngay.Location = New System.Drawing.Point(88, 132)
        Me.checkB_Ngay.Name = "checkB_Ngay"
        Me.checkB_Ngay.Size = New System.Drawing.Size(51, 17)
        Me.checkB_Ngay.TabIndex = 7
        Me.checkB_Ngay.Text = "Ngày"
        Me.checkB_Ngay.UseVisualStyleBackColor = True
        '
        'checkB_Khoi
        '
        Me.checkB_Khoi.AutoSize = True
        Me.checkB_Khoi.Location = New System.Drawing.Point(88, 164)
        Me.checkB_Khoi.Name = "checkB_Khoi"
        Me.checkB_Khoi.Size = New System.Drawing.Size(47, 17)
        Me.checkB_Khoi.TabIndex = 8
        Me.checkB_Khoi.Text = "Khối"
        Me.checkB_Khoi.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Báo cáo theo:"
        '
        'bt_BaoCao
        '
        Me.bt_BaoCao.Location = New System.Drawing.Point(236, 450)
        Me.bt_BaoCao.Name = "bt_BaoCao"
        Me.bt_BaoCao.Size = New System.Drawing.Size(99, 44)
        Me.bt_BaoCao.TabIndex = 10
        Me.bt_BaoCao.Text = "Xuất báo cáo"
        Me.bt_BaoCao.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(207, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 35)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "BÁO CÁO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 61)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Mã báo cáo"
        '
        'txtMaBaoCao
        '
        Me.txtMaBaoCao.Location = New System.Drawing.Point(103, 58)
        Me.txtMaBaoCao.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtMaBaoCao.Name = "txtMaBaoCao"
        Me.txtMaBaoCao.ReadOnly = True
        Me.txtMaBaoCao.Size = New System.Drawing.Size(76, 20)
        Me.txtMaBaoCao.TabIndex = 13
        '
        'Frm_BaoCao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 498)
        Me.Controls.Add(Me.txtMaBaoCao)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt_BaoCao)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.checkB_Khoi)
        Me.Controls.Add(Me.checkB_Ngay)
        Me.Controls.Add(Me.lb_ChonNgay)
        Me.Controls.Add(Me.cb_Khoi)
        Me.Controls.Add(Me.lb_ChonKhoi)
        Me.Controls.Add(Me.dgvBaoCao)
        Me.Controls.Add(Me.dtNgay)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Frm_BaoCao"
        Me.Text = "Báo cáo"
        CType(Me.dgvBaoCao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvBaoCao As DataGridView
    Friend WithEvents dtNgay As DateTimePicker
    Friend WithEvents lb_ChonKhoi As Label
    Friend WithEvents cb_Khoi As ComboBox
    Friend WithEvents lb_ChonNgay As Label
    Friend WithEvents checkB_Ngay As CheckBox
    Friend WithEvents checkB_Khoi As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents bt_BaoCao As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaBaoCao As TextBox
End Class
