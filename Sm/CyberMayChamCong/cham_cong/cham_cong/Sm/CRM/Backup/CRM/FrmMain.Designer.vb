<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

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
        Me.CmdConnect = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtIP = New System.Windows.Forms.TextBox
        Me.TxtPort = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmdLoadDmHs = New System.Windows.Forms.Button
        Me.CmdLoadData = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.TxtTen_Hs = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtMa_Hs = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.CmdSave = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdConnect
        '
        Me.CmdConnect.Location = New System.Drawing.Point(613, 7)
        Me.CmdConnect.Name = "CmdConnect"
        Me.CmdConnect.Size = New System.Drawing.Size(112, 23)
        Me.CmdConnect.TabIndex = 0
        Me.CmdConnect.Text = "Kết nối "
        Me.CmdConnect.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ip"
        '
        'TxtIP
        '
        Me.TxtIP.Location = New System.Drawing.Point(113, 8)
        Me.TxtIP.Name = "TxtIP"
        Me.TxtIP.Size = New System.Drawing.Size(298, 20)
        Me.TxtIP.TabIndex = 2
        Me.TxtIP.Text = "10.0.0.25"
        '
        'TxtPort
        '
        Me.TxtPort.Location = New System.Drawing.Point(449, 8)
        Me.TxtPort.Name = "TxtPort"
        Me.TxtPort.Size = New System.Drawing.Size(147, 20)
        Me.TxtPort.TabIndex = 4
        Me.TxtPort.Text = "4370"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(417, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Port"
        '
        'CmdLoadDmHs
        '
        Me.CmdLoadDmHs.Location = New System.Drawing.Point(32, 86)
        Me.CmdLoadDmHs.Name = "CmdLoadDmHs"
        Me.CmdLoadDmHs.Size = New System.Drawing.Size(105, 59)
        Me.CmdLoadDmHs.TabIndex = 5
        Me.CmdLoadDmHs.Text = "Lấy danh sách nhân viên"
        Me.CmdLoadDmHs.UseVisualStyleBackColor = True
        '
        'CmdLoadData
        '
        Me.CmdLoadData.Location = New System.Drawing.Point(143, 86)
        Me.CmdLoadData.Name = "CmdLoadData"
        Me.CmdLoadData.Size = New System.Drawing.Size(105, 59)
        Me.CmdLoadData.TabIndex = 6
        Me.CmdLoadData.Text = "Lấy dữ liệu chấm công"
        Me.CmdLoadData.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(33, 151)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(692, 267)
        Me.DataGridView1.TabIndex = 7
        '
        'TxtTen_Hs
        '
        Me.TxtTen_Hs.Location = New System.Drawing.Point(113, 60)
        Me.TxtTen_Hs.Name = "TxtTen_Hs"
        Me.TxtTen_Hs.Size = New System.Drawing.Size(298, 20)
        Me.TxtTen_Hs.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Tên nhân viên"
        '
        'TxtMa_Hs
        '
        Me.TxtMa_Hs.Location = New System.Drawing.Point(113, 34)
        Me.TxtMa_Hs.Name = "TxtMa_Hs"
        Me.TxtMa_Hs.Size = New System.Drawing.Size(298, 20)
        Me.TxtMa_Hs.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Mã nhân viên"
        '
        'CmdSave
        '
        Me.CmdSave.Location = New System.Drawing.Point(449, 34)
        Me.CmdSave.Name = "CmdSave"
        Me.CmdSave.Size = New System.Drawing.Size(147, 46)
        Me.CmdSave.TabIndex = 12
        Me.CmdSave.Text = "Cập nhập nhân viên"
        Me.CmdSave.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(737, 430)
        Me.Controls.Add(Me.CmdSave)
        Me.Controls.Add(Me.TxtTen_Hs)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtMa_Hs)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CmdLoadData)
        Me.Controls.Add(Me.CmdLoadDmHs)
        Me.Controls.Add(Me.TxtPort)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtIP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmdConnect)
        Me.ForeColor = System.Drawing.Color.Navy
        Me.Name = "FrmMain"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmdConnect As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtIP As System.Windows.Forms.TextBox
    Friend WithEvents TxtPort As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmdLoadDmHs As System.Windows.Forms.Button
    Friend WithEvents CmdLoadData As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TxtTen_Hs As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Hs As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CmdSave As System.Windows.Forms.Button

End Class
