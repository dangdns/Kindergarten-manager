<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_DangNhap
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_User = New System.Windows.Forms.TextBox()
        Me.tb_Pass = New System.Windows.Forms.TextBox()
        Me.btn_DangNhap = New System.Windows.Forms.Button()
        Me.btn_Thoat = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bt_TimTre = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        '
        'tb_User
        '
        Me.tb_User.Location = New System.Drawing.Point(118, 66)
        Me.tb_User.MaxLength = 20
        Me.tb_User.Name = "tb_User"
        Me.tb_User.Size = New System.Drawing.Size(100, 20)
        Me.tb_User.TabIndex = 2
        '
        'tb_Pass
        '
        Me.tb_Pass.Location = New System.Drawing.Point(118, 109)
        Me.tb_Pass.MaxLength = 30
        Me.tb_Pass.Name = "tb_Pass"
        Me.tb_Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_Pass.Size = New System.Drawing.Size(100, 20)
        Me.tb_Pass.TabIndex = 3
        '
        'btn_DangNhap
        '
        Me.btn_DangNhap.Location = New System.Drawing.Point(48, 165)
        Me.btn_DangNhap.Name = "btn_DangNhap"
        Me.btn_DangNhap.Size = New System.Drawing.Size(87, 42)
        Me.btn_DangNhap.TabIndex = 4
        Me.btn_DangNhap.Text = "Đăng nhập"
        Me.btn_DangNhap.UseVisualStyleBackColor = True
        '
        'btn_Thoat
        '
        Me.btn_Thoat.Location = New System.Drawing.Point(141, 165)
        Me.btn_Thoat.Name = "btn_Thoat"
        Me.btn_Thoat.Size = New System.Drawing.Size(87, 42)
        Me.btn_Thoat.TabIndex = 5
        Me.btn_Thoat.Text = "Thoát"
        Me.btn_Thoat.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(260, 31)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "QUẢN LÝ NHÀ TRẺ"
        '
        'bt_TimTre
        '
        Me.bt_TimTre.Location = New System.Drawing.Point(234, 165)
        Me.bt_TimTre.Name = "bt_TimTre"
        Me.bt_TimTre.Size = New System.Drawing.Size(87, 42)
        Me.bt_TimTre.TabIndex = 8
        Me.bt_TimTre.Text = "Tìm kiếm trẻ"
        Me.bt_TimTre.UseVisualStyleBackColor = True
        '
        'Frm_DangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 255)
        Me.Controls.Add(Me.bt_TimTre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_Thoat)
        Me.Controls.Add(Me.btn_DangNhap)
        Me.Controls.Add(Me.tb_Pass)
        Me.Controls.Add(Me.tb_User)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_DangNhap"
        Me.Text = "Đăng nhập"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_User As TextBox
    Friend WithEvents tb_Pass As TextBox
    Friend WithEvents btn_DangNhap As Button
    Friend WithEvents btn_Thoat As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents bt_TimTre As Button
End Class
