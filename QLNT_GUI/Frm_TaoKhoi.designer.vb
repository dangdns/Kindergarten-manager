<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_TaoKhoi
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
        Me.btnNhapVanDong = New System.Windows.Forms.Button()
        Me.btnNhap = New System.Windows.Forms.Button()
        Me.tb_TenKhoi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_MaKhoi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbFrmName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnNhapVanDong
        '
        Me.btnNhapVanDong.Location = New System.Drawing.Point(95, 144)
        Me.btnNhapVanDong.Name = "btnNhapVanDong"
        Me.btnNhapVanDong.Size = New System.Drawing.Size(75, 23)
        Me.btnNhapVanDong.TabIndex = 23
        Me.btnNhapVanDong.Text = "Nhập và Đóng"
        Me.btnNhapVanDong.UseVisualStyleBackColor = True
        '
        'btnNhap
        '
        Me.btnNhap.Location = New System.Drawing.Point(14, 144)
        Me.btnNhap.Name = "btnNhap"
        Me.btnNhap.Size = New System.Drawing.Size(75, 23)
        Me.btnNhap.TabIndex = 22
        Me.btnNhap.Text = "Nhập"
        Me.btnNhap.UseVisualStyleBackColor = True
        '
        'tb_TenKhoi
        '
        Me.tb_TenKhoi.Location = New System.Drawing.Point(75, 95)
        Me.tb_TenKhoi.Name = "tb_TenKhoi"
        Me.tb_TenKhoi.Size = New System.Drawing.Size(95, 20)
        Me.tb_TenKhoi.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Tên Khối:"
        '
        'tb_MaKhoi
        '
        Me.tb_MaKhoi.Location = New System.Drawing.Point(75, 55)
        Me.tb_MaKhoi.Name = "tb_MaKhoi"
        Me.tb_MaKhoi.ReadOnly = True
        Me.tb_MaKhoi.Size = New System.Drawing.Size(95, 20)
        Me.tb_MaKhoi.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Mã Khối:"
        '
        'lbFrmName
        '
        Me.lbFrmName.AutoSize = True
        Me.lbFrmName.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFrmName.Location = New System.Drawing.Point(53, 21)
        Me.lbFrmName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbFrmName.Name = "lbFrmName"
        Me.lbFrmName.Size = New System.Drawing.Size(81, 17)
        Me.lbFrmName.TabIndex = 38
        Me.lbFrmName.Text = "TẠO KHỐI"
        '
        'Frm_TaoKhoi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(195, 188)
        Me.Controls.Add(Me.lbFrmName)
        Me.Controls.Add(Me.btnNhapVanDong)
        Me.Controls.Add(Me.btnNhap)
        Me.Controls.Add(Me.tb_TenKhoi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_MaKhoi)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Frm_TaoKhoi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Khối"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNhapVanDong As Button
    Friend WithEvents btnNhap As Button
    Friend WithEvents tb_TenKhoi As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_MaKhoi As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbFrmName As Label
End Class
