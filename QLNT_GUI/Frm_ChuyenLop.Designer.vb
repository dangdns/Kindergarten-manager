<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_ChuyenLop
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
        Me.btnToFROM = New System.Windows.Forms.Button()
        Me.btnFROMTo = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbLop_To = New System.Windows.Forms.ComboBox()
        Me.dgvListHS_To = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbLop_FROM = New System.Windows.Forms.ComboBox()
        Me.dgvListHS_FROM = New System.Windows.Forms.DataGridView()
        Me.btnChuyenHS = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbKhoi = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbKhoi2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgvListHS_To, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListHS_FROM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnToFROM
        '
        Me.btnToFROM.Location = New System.Drawing.Point(373, 289)
        Me.btnToFROM.Name = "btnToFROM"
        Me.btnToFROM.Size = New System.Drawing.Size(52, 23)
        Me.btnToFROM.TabIndex = 91
        Me.btnToFROM.Text = "<"
        Me.btnToFROM.UseVisualStyleBackColor = True
        '
        'btnFROMTo
        '
        Me.btnFROMTo.Location = New System.Drawing.Point(373, 199)
        Me.btnFROMTo.Name = "btnFROMTo"
        Me.btnFROMTo.Size = New System.Drawing.Size(52, 23)
        Me.btnFROMTo.TabIndex = 90
        Me.btnFROMTo.Text = ">"
        Me.btnFROMTo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(434, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Sang Lớp:"
        '
        'cbLop_To
        '
        Me.cbLop_To.FormattingEnabled = True
        Me.cbLop_To.Location = New System.Drawing.Point(492, 95)
        Me.cbLop_To.Name = "cbLop_To"
        Me.cbLop_To.Size = New System.Drawing.Size(153, 21)
        Me.cbLop_To.TabIndex = 88
        '
        'dgvListHS_To
        '
        Me.dgvListHS_To.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvListHS_To.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListHS_To.Location = New System.Drawing.Point(431, 122)
        Me.dgvListHS_To.MultiSelect = False
        Me.dgvListHS_To.Name = "dgvListHS_To"
        Me.dgvListHS_To.ReadOnly = True
        Me.dgvListHS_To.RowHeadersVisible = False
        Me.dgvListHS_To.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListHS_To.Size = New System.Drawing.Size(357, 325)
        Me.dgvListHS_To.TabIndex = 87
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Từ Lớp:"
        '
        'cbLop_FROM
        '
        Me.cbLop_FROM.FormattingEnabled = True
        Me.cbLop_FROM.Location = New System.Drawing.Point(71, 95)
        Me.cbLop_FROM.Name = "cbLop_FROM"
        Me.cbLop_FROM.Size = New System.Drawing.Size(153, 21)
        Me.cbLop_FROM.TabIndex = 85
        '
        'dgvListHS_FROM
        '
        Me.dgvListHS_FROM.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvListHS_FROM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListHS_FROM.Location = New System.Drawing.Point(10, 122)
        Me.dgvListHS_FROM.MultiSelect = False
        Me.dgvListHS_FROM.Name = "dgvListHS_FROM"
        Me.dgvListHS_FROM.RowHeadersVisible = False
        Me.dgvListHS_FROM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListHS_FROM.Size = New System.Drawing.Size(357, 325)
        Me.dgvListHS_FROM.TabIndex = 84
        '
        'btnChuyenHS
        '
        Me.btnChuyenHS.Location = New System.Drawing.Point(337, 479)
        Me.btnChuyenHS.Name = "btnChuyenHS"
        Me.btnChuyenHS.Size = New System.Drawing.Size(125, 23)
        Me.btnChuyenHS.TabIndex = 83
        Me.btnChuyenHS.Text = "Chuyển Học Sinh"
        Me.btnChuyenHS.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Khối:"
        '
        'cbKhoi
        '
        Me.cbKhoi.FormattingEnabled = True
        Me.cbKhoi.Location = New System.Drawing.Point(71, 68)
        Me.cbKhoi.Name = "cbKhoi"
        Me.cbKhoi.Size = New System.Drawing.Size(153, 21)
        Me.cbKhoi.TabIndex = 77
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(447, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "Khối:"
        '
        'cbKhoi2
        '
        Me.cbKhoi2.FormattingEnabled = True
        Me.cbKhoi2.Location = New System.Drawing.Point(492, 68)
        Me.cbKhoi2.Name = "cbKhoi2"
        Me.cbKhoi2.Size = New System.Drawing.Size(153, 21)
        Me.cbKhoi2.TabIndex = 92
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(296, 7)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(216, 35)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "CHUYỂN LỚP"
        '
        'Frm_ChuyenLop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 535)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbKhoi2)
        Me.Controls.Add(Me.btnToFROM)
        Me.Controls.Add(Me.btnFROMTo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbLop_To)
        Me.Controls.Add(Me.dgvListHS_To)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbLop_FROM)
        Me.Controls.Add(Me.dgvListHS_FROM)
        Me.Controls.Add(Me.btnChuyenHS)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbKhoi)
        Me.Name = "Frm_ChuyenLop"
        Me.Text = "Chuyển lớp"
        CType(Me.dgvListHS_To, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListHS_FROM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnToFROM As Button
    Friend WithEvents btnFROMTo As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cbLop_To As ComboBox
    Friend WithEvents dgvListHS_To As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents cbLop_FROM As ComboBox
    Friend WithEvents dgvListHS_FROM As DataGridView
    Friend WithEvents btnChuyenHS As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cbKhoi As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbKhoi2 As ComboBox
    Friend WithEvents Label5 As Label
End Class
