<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_TaoPhieuGhiNhan
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
        Me.tbHovaTen = New System.Windows.Forms.TextBox()
        Me.lbHovaTen = New System.Windows.Forms.Label()
        Me.lbKhoiLop = New System.Windows.Forms.Label()
        Me.cbKhoiLop = New System.Windows.Forms.ComboBox()
        Me.cbTinhTrang = New System.Windows.Forms.ComboBox()
        Me.lbTinhTrang = New System.Windows.Forms.Label()
        Me.lbNgay = New System.Windows.Forms.Label()
        Me.dtNgay = New System.Windows.Forms.DateTimePicker()
        Me.cbMaTre = New System.Windows.Forms.ComboBox()
        Me.lbMaTre = New System.Windows.Forms.Label()
        Me.btNhập = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGhiChu = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'tbHovaTen
        '
        Me.tbHovaTen.Location = New System.Drawing.Point(105, 126)
        Me.tbHovaTen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbHovaTen.Name = "tbHovaTen"
        Me.tbHovaTen.Size = New System.Drawing.Size(140, 20)
        Me.tbHovaTen.TabIndex = 0
        '
        'lbHovaTen
        '
        Me.lbHovaTen.AutoSize = True
        Me.lbHovaTen.Location = New System.Drawing.Point(38, 130)
        Me.lbHovaTen.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbHovaTen.Name = "lbHovaTen"
        Me.lbHovaTen.Size = New System.Drawing.Size(57, 13)
        Me.lbHovaTen.TabIndex = 1
        Me.lbHovaTen.Text = "Họ và tên:"
        '
        'lbKhoiLop
        '
        Me.lbKhoiLop.AutoSize = True
        Me.lbKhoiLop.Location = New System.Drawing.Point(38, 169)
        Me.lbKhoiLop.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbKhoiLop.Name = "lbKhoiLop"
        Me.lbKhoiLop.Size = New System.Drawing.Size(48, 13)
        Me.lbKhoiLop.TabIndex = 3
        Me.lbKhoiLop.Text = "Khối lớp:"
        '
        'cbKhoiLop
        '
        Me.cbKhoiLop.FormattingEnabled = True
        Me.cbKhoiLop.Location = New System.Drawing.Point(105, 163)
        Me.cbKhoiLop.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbKhoiLop.Name = "cbKhoiLop"
        Me.cbKhoiLop.Size = New System.Drawing.Size(152, 21)
        Me.cbKhoiLop.TabIndex = 4
        '
        'cbTinhTrang
        '
        Me.cbTinhTrang.FormattingEnabled = True
        Me.cbTinhTrang.Location = New System.Drawing.Point(105, 206)
        Me.cbTinhTrang.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbTinhTrang.Name = "cbTinhTrang"
        Me.cbTinhTrang.Size = New System.Drawing.Size(73, 21)
        Me.cbTinhTrang.TabIndex = 6
        '
        'lbTinhTrang
        '
        Me.lbTinhTrang.AutoSize = True
        Me.lbTinhTrang.Location = New System.Drawing.Point(38, 211)
        Me.lbTinhTrang.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTinhTrang.Name = "lbTinhTrang"
        Me.lbTinhTrang.Size = New System.Drawing.Size(58, 13)
        Me.lbTinhTrang.TabIndex = 5
        Me.lbTinhTrang.Text = "Tình trạng:"
        '
        'lbNgay
        '
        Me.lbNgay.AutoSize = True
        Me.lbNgay.Location = New System.Drawing.Point(38, 251)
        Me.lbNgay.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbNgay.Name = "lbNgay"
        Me.lbNgay.Size = New System.Drawing.Size(62, 13)
        Me.lbNgay.TabIndex = 7
        Me.lbNgay.Text = "Ngày nhập:"
        '
        'dtNgay
        '
        Me.dtNgay.Location = New System.Drawing.Point(105, 247)
        Me.dtNgay.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtNgay.Name = "dtNgay"
        Me.dtNgay.Size = New System.Drawing.Size(169, 20)
        Me.dtNgay.TabIndex = 8
        '
        'cbMaTre
        '
        Me.cbMaTre.FormattingEnabled = True
        Me.cbMaTre.Location = New System.Drawing.Point(406, 124)
        Me.cbMaTre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbMaTre.Name = "cbMaTre"
        Me.cbMaTre.Size = New System.Drawing.Size(73, 21)
        Me.cbMaTre.TabIndex = 10
        '
        'lbMaTre
        '
        Me.lbMaTre.AutoSize = True
        Me.lbMaTre.Location = New System.Drawing.Point(340, 130)
        Me.lbMaTre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbMaTre.Name = "lbMaTre"
        Me.lbMaTre.Size = New System.Drawing.Size(40, 13)
        Me.lbMaTre.TabIndex = 9
        Me.lbMaTre.Text = "Mã trẻ:"
        '
        'btNhập
        '
        Me.btNhập.Location = New System.Drawing.Point(222, 301)
        Me.btNhập.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btNhập.Name = "btNhập"
        Me.btNhập.Size = New System.Drawing.Size(59, 31)
        Me.btNhập.TabIndex = 11
        Me.btNhập.Text = "Nhập"
        Me.btNhập.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 89)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Mã phiếu:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(105, 85)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(140, 20)
        Me.txtID.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(126, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(273, 35)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "PHIẾU GHI NHẬN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(330, 210)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Ghi chú:"
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Location = New System.Drawing.Point(397, 206)
        Me.txtGhiChu.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(108, 20)
        Me.txtGhiChu.TabIndex = 15
        '
        'Frm_TaoPhieuGhiNhan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 353)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtGhiChu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btNhập)
        Me.Controls.Add(Me.cbMaTre)
        Me.Controls.Add(Me.lbMaTre)
        Me.Controls.Add(Me.dtNgay)
        Me.Controls.Add(Me.lbNgay)
        Me.Controls.Add(Me.cbTinhTrang)
        Me.Controls.Add(Me.lbTinhTrang)
        Me.Controls.Add(Me.cbKhoiLop)
        Me.Controls.Add(Me.lbKhoiLop)
        Me.Controls.Add(Me.lbHovaTen)
        Me.Controls.Add(Me.tbHovaTen)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Frm_TaoPhieuGhiNhan"
        Me.Text = "Phiếu ghi nhận"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbHovaTen As TextBox
    Friend WithEvents lbHovaTen As Label
    Friend WithEvents lbKhoiLop As Label
    Friend WithEvents cbKhoiLop As ComboBox
    Friend WithEvents cbTinhTrang As ComboBox
    Friend WithEvents lbTinhTrang As Label
    Friend WithEvents lbNgay As Label
    Friend WithEvents dtNgay As DateTimePicker
    Friend WithEvents cbMaTre As ComboBox
    Friend WithEvents lbMaTre As Label
    Friend WithEvents btNhập As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGhiChu As TextBox
End Class
