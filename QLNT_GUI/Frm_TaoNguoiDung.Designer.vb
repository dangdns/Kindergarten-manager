<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_TaoNguoiDung
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
        Me.lbFrmName = New System.Windows.Forms.Label()
        Me.tb_Pass = New System.Windows.Forms.TextBox()
        Me.tb_User = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_Pass2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt_Tao = New System.Windows.Forms.Button()
        Me.bt_DONg = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_lvl = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lbFrmName
        '
        Me.lbFrmName.AutoSize = True
        Me.lbFrmName.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFrmName.Location = New System.Drawing.Point(73, 43)
        Me.lbFrmName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbFrmName.Name = "lbFrmName"
        Me.lbFrmName.Size = New System.Drawing.Size(138, 17)
        Me.lbFrmName.TabIndex = 38
        Me.lbFrmName.Text = "TẠO NGƯỜI DÙNG"
        '
        'tb_Pass
        '
        Me.tb_Pass.Location = New System.Drawing.Point(114, 130)
        Me.tb_Pass.MaxLength = 10
        Me.tb_Pass.Name = "tb_Pass"
        Me.tb_Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_Pass.Size = New System.Drawing.Size(121, 20)
        Me.tb_Pass.TabIndex = 48
        '
        'tb_User
        '
        Me.tb_User.Location = New System.Drawing.Point(114, 96)
        Me.tb_User.Name = "tb_User"
        Me.tb_User.Size = New System.Drawing.Size(121, 20)
        Me.tb_User.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Mật khẩu:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Tên người dùng:"
        '
        'tb_Pass2
        '
        Me.tb_Pass2.Location = New System.Drawing.Point(114, 164)
        Me.tb_Pass2.MaxLength = 10
        Me.tb_Pass2.Name = "tb_Pass2"
        Me.tb_Pass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_Pass2.Size = New System.Drawing.Size(121, 20)
        Me.tb_Pass2.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Lập lại mật khẩu:"
        '
        'bt_Tao
        '
        Me.bt_Tao.Location = New System.Drawing.Point(35, 239)
        Me.bt_Tao.Name = "bt_Tao"
        Me.bt_Tao.Size = New System.Drawing.Size(82, 43)
        Me.bt_Tao.TabIndex = 51
        Me.bt_Tao.Text = "Tạo"
        Me.bt_Tao.UseVisualStyleBackColor = True
        '
        'bt_DONg
        '
        Me.bt_DONg.Location = New System.Drawing.Point(169, 239)
        Me.bt_DONg.Name = "bt_DONg"
        Me.bt_DONg.Size = New System.Drawing.Size(82, 43)
        Me.bt_DONg.TabIndex = 52
        Me.bt_DONg.Text = "Đóng"
        Me.bt_DONg.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Cấp độ quyền:"
        '
        'cb_lvl
        '
        Me.cb_lvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_lvl.FormattingEnabled = True
        Me.cb_lvl.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cb_lvl.Location = New System.Drawing.Point(115, 198)
        Me.cb_lvl.Name = "cb_lvl"
        Me.cb_lvl.Size = New System.Drawing.Size(121, 21)
        Me.cb_lvl.TabIndex = 54
        '
        'Frm_TaoNguoiDung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 307)
        Me.Controls.Add(Me.cb_lvl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.bt_DONg)
        Me.Controls.Add(Me.bt_Tao)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_Pass2)
        Me.Controls.Add(Me.tb_Pass)
        Me.Controls.Add(Me.tb_User)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbFrmName)
        Me.Name = "Frm_TaoNguoiDung"
        Me.Text = "Người dùng"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbFrmName As Label
    Friend WithEvents tb_Pass As TextBox
    Friend WithEvents tb_User As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_Pass2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents bt_Tao As Button
    Friend WithEvents bt_DONg As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cb_lvl As ComboBox
End Class
