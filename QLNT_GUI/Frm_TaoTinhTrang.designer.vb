<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_TaoTinhTrang
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
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txrTinhTrang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btNhap = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 102)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã tình trạng"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(130, 102)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(76, 20)
        Me.txtID.TabIndex = 1
        '
        'txrTinhTrang
        '
        Me.txrTinhTrang.Location = New System.Drawing.Point(130, 150)
        Me.txrTinhTrang.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txrTinhTrang.Name = "txrTinhTrang"
        Me.txrTinhTrang.Size = New System.Drawing.Size(76, 20)
        Me.txrTinhTrang.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 150)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tên tình trạng"
        '
        'btNhap
        '
        Me.btNhap.Location = New System.Drawing.Point(102, 212)
        Me.btNhap.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btNhap.Name = "btNhap"
        Me.btNhap.Size = New System.Drawing.Size(62, 28)
        Me.btNhap.TabIndex = 4
        Me.btNhap.Text = "Nhập"
        Me.btNhap.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 7)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(226, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "THÊM TÌNH TRẠNG"
        '
        'Frm_TaoTinhTrang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 265)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btNhap)
        Me.Controls.Add(Me.txrTinhTrang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Frm_TaoTinhTrang"
        Me.Text = "Tình trạng"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txrTinhTrang As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btNhap As Button
    Friend WithEvents Label3 As Label
End Class
