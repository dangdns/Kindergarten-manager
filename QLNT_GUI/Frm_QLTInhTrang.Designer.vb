<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_QLTInhTrang
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
        Me.dgvTinhTrang = New System.Windows.Forms.DataGridView()
        Me.btNhap = New System.Windows.Forms.Button()
        Me.txrTinhTrang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btXoa = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvTinhTrang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTinhTrang
        '
        Me.dgvTinhTrang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTinhTrang.Location = New System.Drawing.Point(23, 80)
        Me.dgvTinhTrang.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvTinhTrang.MultiSelect = False
        Me.dgvTinhTrang.Name = "dgvTinhTrang"
        Me.dgvTinhTrang.ReadOnly = True
        Me.dgvTinhTrang.RowTemplate.Height = 24
        Me.dgvTinhTrang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTinhTrang.Size = New System.Drawing.Size(230, 203)
        Me.dgvTinhTrang.TabIndex = 0
        '
        'btNhap
        '
        Me.btNhap.Location = New System.Drawing.Point(23, 418)
        Me.btNhap.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btNhap.Name = "btNhap"
        Me.btNhap.Size = New System.Drawing.Size(56, 28)
        Me.btNhap.TabIndex = 9
        Me.btNhap.Text = "Nhập"
        Me.btNhap.UseVisualStyleBackColor = True
        '
        'txrTinhTrang
        '
        Me.txrTinhTrang.Location = New System.Drawing.Point(113, 356)
        Me.txrTinhTrang.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txrTinhTrang.Name = "txrTinhTrang"
        Me.txrTinhTrang.Size = New System.Drawing.Size(76, 20)
        Me.txrTinhTrang.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 356)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Tên tình trạng"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(113, 308)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(76, 20)
        Me.txtID.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 308)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Mã tình trạng"
        '
        'btXoa
        '
        Me.btXoa.Location = New System.Drawing.Point(196, 418)
        Me.btXoa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btXoa.Name = "btXoa"
        Me.btXoa.Size = New System.Drawing.Size(56, 28)
        Me.btXoa.TabIndex = 10
        Me.btXoa.Text = "Xóa"
        Me.btXoa.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 15)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(260, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "QUẢN LÝ TÌNH TRẠNG"
        '
        'Frm_QLTInhTrang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 457)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btXoa)
        Me.Controls.Add(Me.btNhap)
        Me.Controls.Add(Me.txrTinhTrang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvTinhTrang)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Frm_QLTInhTrang"
        Me.Text = "Quản lý tình trạng"
        CType(Me.dgvTinhTrang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvTinhTrang As DataGridView
    Friend WithEvents btNhap As Button
    Friend WithEvents txrTinhTrang As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btXoa As Button
    Friend WithEvents Label3 As Label
End Class
