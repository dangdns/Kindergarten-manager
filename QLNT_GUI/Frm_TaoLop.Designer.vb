<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_TaoLop
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_Khoi = New System.Windows.Forms.ComboBox()
        Me.tb_MaLop = New System.Windows.Forms.TextBox()
        Me.tb_TenLop = New System.Windows.Forms.TextBox()
        Me.btn_NhapVaDong = New System.Windows.Forms.Button()
        Me.btn_Nhap = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbFrmName
        '
        Me.lbFrmName.AutoSize = True
        Me.lbFrmName.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFrmName.Location = New System.Drawing.Point(81, 26)
        Me.lbFrmName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbFrmName.Name = "lbFrmName"
        Me.lbFrmName.Size = New System.Drawing.Size(71, 17)
        Me.lbFrmName.TabIndex = 37
        Me.lbFrmName.Text = "TẠO LỚP"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Khối:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Mã lớp:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Tên lớp:"
        '
        'cb_Khoi
        '
        Me.cb_Khoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Khoi.FormattingEnabled = True
        Me.cb_Khoi.Location = New System.Drawing.Point(84, 65)
        Me.cb_Khoi.Name = "cb_Khoi"
        Me.cb_Khoi.Size = New System.Drawing.Size(121, 21)
        Me.cb_Khoi.TabIndex = 42
        '
        'tb_MaLop
        '
        Me.tb_MaLop.Location = New System.Drawing.Point(84, 102)
        Me.tb_MaLop.Name = "tb_MaLop"
        Me.tb_MaLop.ReadOnly = True
        Me.tb_MaLop.Size = New System.Drawing.Size(121, 20)
        Me.tb_MaLop.TabIndex = 43
        '
        'tb_TenLop
        '
        Me.tb_TenLop.Location = New System.Drawing.Point(84, 139)
        Me.tb_TenLop.MaxLength = 10
        Me.tb_TenLop.Name = "tb_TenLop"
        Me.tb_TenLop.Size = New System.Drawing.Size(121, 20)
        Me.tb_TenLop.TabIndex = 44
        '
        'btn_NhapVaDong
        '
        Me.btn_NhapVaDong.Location = New System.Drawing.Point(128, 176)
        Me.btn_NhapVaDong.Name = "btn_NhapVaDong"
        Me.btn_NhapVaDong.Size = New System.Drawing.Size(110, 36)
        Me.btn_NhapVaDong.TabIndex = 46
        Me.btn_NhapVaDong.Text = "Nhập và Đóng"
        Me.btn_NhapVaDong.UseVisualStyleBackColor = True
        '
        'btn_Nhap
        '
        Me.btn_Nhap.Location = New System.Drawing.Point(12, 176)
        Me.btn_Nhap.Name = "btn_Nhap"
        Me.btn_Nhap.Size = New System.Drawing.Size(110, 36)
        Me.btn_Nhap.TabIndex = 47
        Me.btn_Nhap.Text = "Nhập"
        Me.btn_Nhap.UseVisualStyleBackColor = True
        '
        'Frm_TaoLop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(252, 245)
        Me.Controls.Add(Me.btn_Nhap)
        Me.Controls.Add(Me.btn_NhapVaDong)
        Me.Controls.Add(Me.tb_TenLop)
        Me.Controls.Add(Me.tb_MaLop)
        Me.Controls.Add(Me.cb_Khoi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbFrmName)
        Me.Name = "Frm_TaoLop"
        Me.Text = "Lớp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbFrmName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cb_Khoi As ComboBox
    Friend WithEvents tb_MaLop As TextBox
    Friend WithEvents tb_TenLop As TextBox
    Friend WithEvents btn_NhapVaDong As Button
    Friend WithEvents btn_Nhap As Button
End Class
