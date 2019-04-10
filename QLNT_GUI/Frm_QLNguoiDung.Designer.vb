<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_QLNguoiDung
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
        Me.bt_Xoa = New System.Windows.Forms.Button()
        Me.bt_CapNhat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDanhSachNguoiDung = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_Pass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_User = New System.Windows.Forms.TextBox()
        Me.tb_Pass2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb_lvl = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgvDanhSachNguoiDung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bt_Xoa
        '
        Me.bt_Xoa.Location = New System.Drawing.Point(231, 413)
        Me.bt_Xoa.Name = "bt_Xoa"
        Me.bt_Xoa.Size = New System.Drawing.Size(85, 48)
        Me.bt_Xoa.TabIndex = 45
        Me.bt_Xoa.Text = "Xóa"
        Me.bt_Xoa.UseVisualStyleBackColor = True
        '
        'bt_CapNhat
        '
        Me.bt_CapNhat.Location = New System.Drawing.Point(79, 413)
        Me.bt_CapNhat.Name = "bt_CapNhat"
        Me.bt_CapNhat.Size = New System.Drawing.Size(85, 48)
        Me.bt_CapNhat.TabIndex = 44
        Me.bt_CapNhat.Text = "Cập Nhật"
        Me.bt_CapNhat.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Danh sach người dùng"
        '
        'dgvDanhSachNguoiDung
        '
        Me.dgvDanhSachNguoiDung.AllowUserToAddRows = False
        Me.dgvDanhSachNguoiDung.AllowUserToDeleteRows = False
        Me.dgvDanhSachNguoiDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachNguoiDung.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDanhSachNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachNguoiDung.Location = New System.Drawing.Point(10, 93)
        Me.dgvDanhSachNguoiDung.MultiSelect = False
        Me.dgvDanhSachNguoiDung.Name = "dgvDanhSachNguoiDung"
        Me.dgvDanhSachNguoiDung.ReadOnly = True
        Me.dgvDanhSachNguoiDung.RowHeadersVisible = False
        Me.dgvDanhSachNguoiDung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDanhSachNguoiDung.Size = New System.Drawing.Size(386, 150)
        Me.dgvDanhSachNguoiDung.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 306)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Mật khẩu mới:"
        '
        'tb_Pass
        '
        Me.tb_Pass.Location = New System.Drawing.Point(112, 302)
        Me.tb_Pass.Name = "tb_Pass"
        Me.tb_Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_Pass.Size = New System.Drawing.Size(222, 20)
        Me.tb_Pass.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 266)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Tên người dùng:"
        '
        'tb_User
        '
        Me.tb_User.Location = New System.Drawing.Point(112, 262)
        Me.tb_User.Name = "tb_User"
        Me.tb_User.Size = New System.Drawing.Size(222, 20)
        Me.tb_User.TabIndex = 43
        Me.tb_User.WordWrap = False
        '
        'tb_Pass2
        '
        Me.tb_Pass2.Location = New System.Drawing.Point(111, 342)
        Me.tb_Pass2.Name = "tb_Pass2"
        Me.tb_Pass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_Pass2.Size = New System.Drawing.Size(222, 20)
        Me.tb_Pass2.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 345)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Lập lại mật khẩu:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 390)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Cập độ quyền:"
        '
        'cb_lvl
        '
        Me.cb_lvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_lvl.FormattingEnabled = True
        Me.cb_lvl.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cb_lvl.Location = New System.Drawing.Point(112, 383)
        Me.cb_lvl.Name = "cb_lvl"
        Me.cb_lvl.Size = New System.Drawing.Size(111, 21)
        Me.cb_lvl.TabIndex = 49
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(82, 7)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(242, 35)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "QUẢN LÝ USER"
        '
        'Frm_QLNguoiDung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 468)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cb_lvl)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tb_Pass2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.bt_Xoa)
        Me.Controls.Add(Me.bt_CapNhat)
        Me.Controls.Add(Me.tb_User)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_Pass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvDanhSachNguoiDung)
        Me.Name = "Frm_QLNguoiDung"
        Me.Text = "Quản lý user"
        CType(Me.dgvDanhSachNguoiDung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bt_Xoa As Button
    Friend WithEvents bt_CapNhat As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDanhSachNguoiDung As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_Pass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_User As TextBox
    Friend WithEvents tb_Pass2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cb_lvl As ComboBox
    Friend WithEvents Label6 As Label
End Class
