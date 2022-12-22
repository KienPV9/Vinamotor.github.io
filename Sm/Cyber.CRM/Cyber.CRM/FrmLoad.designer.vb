<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLoad
    Inherits Cyber.From.FrmList

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNgay_CT2 = New System.Windows.Forms.DateTimePicker()
        Me.TxtNgay_CT1 = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtLay_DL = New System.Windows.Forms.Button()
        Me.ButtKet_Noi = New System.Windows.Forms.Button()
        Me.TxtPort = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtIP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbbMayCC = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(685, 383)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(583, 383)
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(344, 380)
        Me.TxtMa_Dvcs.TabIndex = 9
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 394)
        Me.ChkActi.Visible = False
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 374)
        Me.GroupBoxLine.Size = New System.Drawing.Size(788, 9)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(404, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Đến ngày"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(404, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Từ ngày"
        '
        'TxtNgay_CT2
        '
        Me.TxtNgay_CT2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TxtNgay_CT2.Location = New System.Drawing.Point(477, 91)
        Me.TxtNgay_CT2.Name = "TxtNgay_CT2"
        Me.TxtNgay_CT2.Size = New System.Drawing.Size(104, 21)
        Me.TxtNgay_CT2.TabIndex = 24
        '
        'TxtNgay_CT1
        '
        Me.TxtNgay_CT1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TxtNgay_CT1.Location = New System.Drawing.Point(477, 69)
        Me.TxtNgay_CT1.Name = "TxtNgay_CT1"
        Me.TxtNgay_CT1.Size = New System.Drawing.Size(104, 21)
        Me.TxtNgay_CT1.TabIndex = 23
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(14, 118)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(766, 250)
        Me.DataGridView1.TabIndex = 22
        '
        'ButtLay_DL
        '
        Me.ButtLay_DL.Location = New System.Drawing.Point(617, 72)
        Me.ButtLay_DL.Name = "ButtLay_DL"
        Me.ButtLay_DL.Size = New System.Drawing.Size(94, 32)
        Me.ButtLay_DL.TabIndex = 21
        Me.ButtLay_DL.Text = "&Lấy dữ liệu"
        Me.ButtLay_DL.UseVisualStyleBackColor = True
        '
        'ButtKet_Noi
        '
        Me.ButtKet_Noi.Location = New System.Drawing.Point(233, 72)
        Me.ButtKet_Noi.Name = "ButtKet_Noi"
        Me.ButtKet_Noi.Size = New System.Drawing.Size(92, 32)
        Me.ButtKet_Noi.TabIndex = 20
        Me.ButtKet_Noi.Text = "&Kết nối"
        Me.ButtKet_Noi.UseVisualStyleBackColor = True
        '
        'TxtPort
        '
        Me.TxtPort.Location = New System.Drawing.Point(64, 91)
        Me.TxtPort.Name = "TxtPort"
        Me.TxtPort.Size = New System.Drawing.Size(149, 21)
        Me.TxtPort.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Port"
        '
        'TxtIP
        '
        Me.TxtIP.Location = New System.Drawing.Point(64, 69)
        Me.TxtIP.Name = "TxtIP"
        Me.TxtIP.Size = New System.Drawing.Size(149, 21)
        Me.TxtIP.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "IP"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(301, 386)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Mở cùng windows"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 19)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Phần mềm lấy dữ liệu từ máy chấm công"
        '
        'CbbMayCC
        '
        Me.CbbMayCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMayCC.FormattingEnabled = True
        Me.CbbMayCC.Location = New System.Drawing.Point(64, 42)
        Me.CbbMayCC.Name = "CbbMayCC"
        Me.CbbMayCC.Size = New System.Drawing.Size(149, 21)
        Me.CbbMayCC.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Máy"
        '
        'FrmLoad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(792, 417)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbbMayCC)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtNgay_CT2)
        Me.Controls.Add(Me.TxtNgay_CT1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtLay_DL)
        Me.Controls.Add(Me.ButtKet_Noi)
        Me.Controls.Add(Me.TxtPort)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtIP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.Name = "FrmLoad"
        Me.Text = "Lấy dữ liệu chấm công"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtIP, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtPort, 0)
        Me.Controls.SetChildIndex(Me.ButtKet_Noi, 0)
        Me.Controls.SetChildIndex(Me.ButtLay_DL, 0)
        Me.Controls.SetChildIndex(Me.DataGridView1, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_CT1, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_CT2, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.CbbMayCC, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_CT2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtNgay_CT1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ButtLay_DL As System.Windows.Forms.Button
    Friend WithEvents ButtKet_Noi As System.Windows.Forms.Button
    Friend WithEvents TxtPort As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtIP As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CbbMayCC As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
