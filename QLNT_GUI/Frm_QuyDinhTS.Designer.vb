<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_QuyDinhTS
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
        Me.btCapNhap = New System.Windows.Forms.Button()
        Me.txtSiSoMax = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLopMax = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTuoiMax = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKhoiMax = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTuoiMin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btCapNhap
        '
        Me.btCapNhap.Location = New System.Drawing.Point(202, 340)
        Me.btCapNhap.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btCapNhap.Name = "btCapNhap"
        Me.btCapNhap.Size = New System.Drawing.Size(68, 36)
        Me.btCapNhap.TabIndex = 21
        Me.btCapNhap.Text = "Cập nhập"
        Me.btCapNhap.UseVisualStyleBackColor = True
        '
        'txtSiSoMax
        '
        Me.txtSiSoMax.Location = New System.Drawing.Point(215, 250)
        Me.txtSiSoMax.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSiSoMax.Name = "txtSiSoMax"
        Me.txtSiSoMax.Size = New System.Drawing.Size(76, 20)
        Me.txtSiSoMax.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(138, 253)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Sỉ số tối đa"
        '
        'txtLopMax
        '
        Me.txtLopMax.Location = New System.Drawing.Point(337, 189)
        Me.txtLopMax.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtLopMax.Name = "txtLopMax"
        Me.txtLopMax.Size = New System.Drawing.Size(76, 20)
        Me.txtLopMax.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(259, 192)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Số lớp tối đa"
        '
        'txtTuoiMax
        '
        Me.txtTuoiMax.Location = New System.Drawing.Point(337, 132)
        Me.txtTuoiMax.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTuoiMax.Name = "txtTuoiMax"
        Me.txtTuoiMax.Size = New System.Drawing.Size(76, 20)
        Me.txtTuoiMax.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(259, 134)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Tuổi tối đa"
        '
        'txtKhoiMax
        '
        Me.txtKhoiMax.Location = New System.Drawing.Point(132, 189)
        Me.txtKhoiMax.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtKhoiMax.Name = "txtKhoiMax"
        Me.txtKhoiMax.Size = New System.Drawing.Size(76, 20)
        Me.txtKhoiMax.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 192)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Số khối tối đa"
        '
        'txtTuoiMin
        '
        Me.txtTuoiMin.Location = New System.Drawing.Point(132, 132)
        Me.txtTuoiMin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTuoiMin.Name = "txtTuoiMin"
        Me.txtTuoiMin.Size = New System.Drawing.Size(76, 20)
        Me.txtTuoiMin.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 134)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Tuổi tối thiểu"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(143, 7)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 35)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "THAM SỐ"
        '
        'Frm_QuyDinhTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 401)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btCapNhap)
        Me.Controls.Add(Me.txtSiSoMax)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLopMax)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTuoiMax)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtKhoiMax)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTuoiMin)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Frm_QuyDinhTS"
        Me.Text = "Tham số"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btCapNhap As Button
    Friend WithEvents txtSiSoMax As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLopMax As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTuoiMax As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtKhoiMax As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTuoiMin As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
End Class
