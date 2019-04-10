<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_QLQuyDinh
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
        Me.btUpdate = New System.Windows.Forms.Button()
        Me.chbSiSoMax = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chbLopMax = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chbTuoiMax = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chbKhoiMax = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chbTuoiMin = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btUpdate
        '
        Me.btUpdate.Location = New System.Drawing.Point(215, 314)
        Me.btUpdate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btUpdate.Name = "btUpdate"
        Me.btUpdate.Size = New System.Drawing.Size(88, 37)
        Me.btUpdate.TabIndex = 21
        Me.btUpdate.Text = "Cập nhập"
        Me.btUpdate.UseVisualStyleBackColor = True
        '
        'chbSiSoMax
        '
        Me.chbSiSoMax.AutoSize = True
        Me.chbSiSoMax.Location = New System.Drawing.Point(305, 215)
        Me.chbSiSoMax.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chbSiSoMax.Name = "chbSiSoMax"
        Me.chbSiSoMax.Size = New System.Drawing.Size(15, 14)
        Me.chbSiSoMax.TabIndex = 20
        Me.chbSiSoMax.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(192, 219)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Sỉ số tối đa"
        '
        'chbLopMax
        '
        Me.chbLopMax.AutoSize = True
        Me.chbLopMax.Location = New System.Drawing.Point(410, 145)
        Me.chbLopMax.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chbLopMax.Name = "chbLopMax"
        Me.chbLopMax.Size = New System.Drawing.Size(15, 14)
        Me.chbLopMax.TabIndex = 18
        Me.chbLopMax.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(296, 149)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Số lớp tối đa"
        '
        'chbTuoiMax
        '
        Me.chbTuoiMax.AutoSize = True
        Me.chbTuoiMax.Location = New System.Drawing.Point(410, 97)
        Me.chbTuoiMax.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chbTuoiMax.Name = "chbTuoiMax"
        Me.chbTuoiMax.Size = New System.Drawing.Size(15, 14)
        Me.chbTuoiMax.TabIndex = 16
        Me.chbTuoiMax.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(296, 100)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Tuổi tối đa"
        '
        'chbKhoiMax
        '
        Me.chbKhoiMax.AutoSize = True
        Me.chbKhoiMax.Location = New System.Drawing.Point(184, 145)
        Me.chbKhoiMax.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chbKhoiMax.Name = "chbKhoiMax"
        Me.chbKhoiMax.Size = New System.Drawing.Size(15, 14)
        Me.chbKhoiMax.TabIndex = 14
        Me.chbKhoiMax.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 149)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Số khối tối đa"
        '
        'chbTuoiMin
        '
        Me.chbTuoiMin.AutoSize = True
        Me.chbTuoiMin.Location = New System.Drawing.Point(184, 97)
        Me.chbTuoiMin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chbTuoiMin.Name = "chbTuoiMin"
        Me.chbTuoiMin.Size = New System.Drawing.Size(15, 14)
        Me.chbTuoiMin.TabIndex = 12
        Me.chbTuoiMin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 100)
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
        Me.Label6.Location = New System.Drawing.Point(106, 7)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(314, 35)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "QUẢN LÝ QUY ĐỊNH"
        '
        'Frm_QLQuyDinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 396)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btUpdate)
        Me.Controls.Add(Me.chbSiSoMax)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chbLopMax)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chbTuoiMax)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chbKhoiMax)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chbTuoiMin)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Frm_QLQuyDinh"
        Me.Text = "Quản lý quy định"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btUpdate As Button
    Friend WithEvents chbSiSoMax As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chbLopMax As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chbTuoiMax As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chbKhoiMax As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chbTuoiMin As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
End Class
