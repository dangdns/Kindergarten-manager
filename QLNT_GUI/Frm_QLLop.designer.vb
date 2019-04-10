<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_QLLop
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
        Me.txtMaLop = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTenLop = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.dgvListLop = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbKhoiFilter = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvListLop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMaLop
        '
        Me.txtMaLop.Location = New System.Drawing.Point(127, 366)
        Me.txtMaLop.Name = "txtMaLop"
        Me.txtMaLop.ReadOnly = True
        Me.txtMaLop.Size = New System.Drawing.Size(162, 20)
        Me.txtMaLop.TabIndex = 54
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 373)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Mã Lớp:"
        '
        'txtTenLop
        '
        Me.txtTenLop.Location = New System.Drawing.Point(127, 413)
        Me.txtTenLop.Name = "txtTenLop"
        Me.txtTenLop.Size = New System.Drawing.Size(222, 20)
        Me.txtTenLop.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 420)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Tên Lớp:"
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(250, 457)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(99, 23)
        Me.btnXoa.TabIndex = 50
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(127, 457)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(75, 23)
        Me.btnCapNhat.TabIndex = 49
        Me.btnCapNhat.Text = "Cập nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'dgvListLop
        '
        Me.dgvListLop.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvListLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListLop.Location = New System.Drawing.Point(43, 128)
        Me.dgvListLop.MultiSelect = False
        Me.dgvListLop.Name = "dgvListLop"
        Me.dgvListLop.ReadOnly = True
        Me.dgvListLop.RowHeadersVisible = False
        Me.dgvListLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListLop.Size = New System.Drawing.Size(370, 221)
        Me.dgvListLop.TabIndex = 48
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(90, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Khối:"
        '
        'cbKhoiFilter
        '
        Me.cbKhoiFilter.FormattingEnabled = True
        Me.cbKhoiFilter.Location = New System.Drawing.Point(127, 83)
        Me.cbKhoiFilter.Name = "cbKhoiFilter"
        Me.cbKhoiFilter.Size = New System.Drawing.Size(176, 21)
        Me.cbKhoiFilter.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(141, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 35)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "QUẢN LÝ LỚP"
        '
        'Frm_QLLop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 502)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMaLop)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTenLop)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.dgvListLop)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbKhoiFilter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Frm_QLLop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý lớp"
        CType(Me.dgvListLop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMaLop As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTenLop As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents dgvListLop As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents cbKhoiFilter As ComboBox
    Friend WithEvents Label1 As Label
End Class
