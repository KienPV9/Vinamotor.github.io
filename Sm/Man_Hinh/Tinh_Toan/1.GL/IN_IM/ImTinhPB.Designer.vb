<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImTinhPB
    Inherits Cyber.From.FrmCalculator

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
        Me.CbbM_Nam = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbbM_Thang2 = New System.Windows.Forms.ComboBox()
        Me.CbbM_Thang1 = New System.Windows.Forms.ComboBox()
        Me.LabM_month2 = New System.Windows.Forms.Label()
        Me.LabM_month1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txtten_CC = New System.Windows.Forms.TextBox()
        Me.TxtMa_CC = New Cyber.SmLists.TxtLookup()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTen_NhCC1 = New System.Windows.Forms.TextBox()
        Me.TxtNh_CC1 = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_NhCC3 = New System.Windows.Forms.TextBox()
        Me.TxtNh_CC3 = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_NhCC2 = New System.Windows.Forms.TextBox()
        Me.TxtNh_CC2 = New Cyber.SmLists.TxtLookup()
        Me.ChkTao_but_Toan = New System.Windows.Forms.CheckBox()
        CType(Me.TxtMa_CC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_CC1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_CC3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_CC2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 185)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBoxLine.Size = New System.Drawing.Size(760, 10)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(493, 197)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtOK.TabIndex = 8
        Me.ButtOK.Tag = "&Ok"
        Me.ButtOK.Text = "&Chấp nhận"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(629, 197)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtExit.TabIndex = 9
        '
        'CbbM_Nam
        '
        Me.CbbM_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Nam.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Nam.FormattingEnabled = True
        Me.CbbM_Nam.Location = New System.Drawing.Point(613, 9)
        Me.CbbM_Nam.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbM_Nam.Name = "CbbM_Nam"
        Me.CbbM_Nam.Size = New System.Drawing.Size(145, 24)
        Me.CbbM_Nam.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(571, 12)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 17)
        Me.Label2.TabIndex = 505
        Me.Label2.Tag = "Year"
        Me.Label2.Text = "Năm"
        '
        'CbbM_Thang2
        '
        Me.CbbM_Thang2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Thang2.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Thang2.FormattingEnabled = True
        Me.CbbM_Thang2.Location = New System.Drawing.Point(361, 9)
        Me.CbbM_Thang2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbM_Thang2.Name = "CbbM_Thang2"
        Me.CbbM_Thang2.Size = New System.Drawing.Size(145, 24)
        Me.CbbM_Thang2.TabIndex = 1
        '
        'CbbM_Thang1
        '
        Me.CbbM_Thang1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Thang1.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Thang1.FormattingEnabled = True
        Me.CbbM_Thang1.Location = New System.Drawing.Point(112, 9)
        Me.CbbM_Thang1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbM_Thang1.Name = "CbbM_Thang1"
        Me.CbbM_Thang1.Size = New System.Drawing.Size(145, 24)
        Me.CbbM_Thang1.TabIndex = 0
        '
        'LabM_month2
        '
        Me.LabM_month2.AutoSize = True
        Me.LabM_month2.Location = New System.Drawing.Point(279, 12)
        Me.LabM_month2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_month2.Name = "LabM_month2"
        Me.LabM_month2.Size = New System.Drawing.Size(74, 17)
        Me.LabM_month2.TabIndex = 504
        Me.LabM_month2.Tag = "Month to"
        Me.LabM_month2.Text = "Đến tháng"
        '
        'LabM_month1
        '
        Me.LabM_month1.AutoSize = True
        Me.LabM_month1.Location = New System.Drawing.Point(0, 12)
        Me.LabM_month1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_month1.Name = "LabM_month1"
        Me.LabM_month1.Size = New System.Drawing.Size(65, 17)
        Me.LabM_month1.TabIndex = 503
        Me.LabM_month1.Tag = "Month from"
        Me.LabM_month1.Text = "Từ tháng"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(0, 44)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 18)
        Me.Label4.TabIndex = 502
        Me.Label4.Tag = "Tool"
        Me.Label4.Text = "Mã công cụ"
        '
        'Txtten_CC
        '
        Me.Txtten_CC.BackColor = System.Drawing.Color.White
        Me.Txtten_CC.Enabled = False
        Me.Txtten_CC.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_CC.Location = New System.Drawing.Point(264, 38)
        Me.Txtten_CC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtten_CC.Name = "Txtten_CC"
        Me.Txtten_CC.ReadOnly = True
        Me.Txtten_CC.Size = New System.Drawing.Size(495, 22)
        Me.Txtten_CC.TabIndex = 501
        Me.Txtten_CC.TabStop = False
        '
        'TxtMa_CC
        '
        Me.TxtMa_CC._ActilookupPopup = False
        Me.TxtMa_CC.CyberActilookupPopup = True
        Me.TxtMa_CC.Dv_ListDetail = Nothing
        Me.TxtMa_CC.Dv_Master = Nothing
        Me.TxtMa_CC.FilterClient = ""
        Me.TxtMa_CC.FilterSQL = ""
        Me.TxtMa_CC.Location = New System.Drawing.Point(112, 39)
        Me.TxtMa_CC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_CC.Name = "TxtMa_CC"
        Me.TxtMa_CC.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_CC.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_CC.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_CC.Size = New System.Drawing.Size(147, 22)
        Me.TxtMa_CC.TabIndex = 3
        Me.TxtMa_CC.Table_Name = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(1, 123)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 18)
        Me.Label8.TabIndex = 514
        Me.Label8.Tag = "Group 3"
        Me.Label8.Text = "Nhóm 3"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(1, 71)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 18)
        Me.Label6.TabIndex = 513
        Me.Label6.Tag = "Group 1"
        Me.Label6.Text = "Nhóm 1"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(1, 97)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 18)
        Me.Label5.TabIndex = 512
        Me.Label5.Tag = "Group 2"
        Me.Label5.Text = "Nhóm 2"
        '
        'TxtTen_NhCC1
        '
        Me.TxtTen_NhCC1.BackColor = System.Drawing.Color.White
        Me.TxtTen_NhCC1.Enabled = False
        Me.TxtTen_NhCC1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_NhCC1.Location = New System.Drawing.Point(264, 64)
        Me.TxtTen_NhCC1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_NhCC1.Name = "TxtTen_NhCC1"
        Me.TxtTen_NhCC1.ReadOnly = True
        Me.TxtTen_NhCC1.Size = New System.Drawing.Size(495, 22)
        Me.TxtTen_NhCC1.TabIndex = 511
        Me.TxtTen_NhCC1.TabStop = False
        '
        'TxtNh_CC1
        '
        Me.TxtNh_CC1._ActilookupPopup = False
        Me.TxtNh_CC1.CyberActilookupPopup = True
        Me.TxtNh_CC1.Dv_ListDetail = Nothing
        Me.TxtNh_CC1.Dv_Master = Nothing
        Me.TxtNh_CC1.FilterClient = ""
        Me.TxtNh_CC1.FilterSQL = ""
        Me.TxtNh_CC1.Location = New System.Drawing.Point(112, 65)
        Me.TxtNh_CC1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNh_CC1.Name = "TxtNh_CC1"
        Me.TxtNh_CC1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_CC1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_CC1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_CC1.Size = New System.Drawing.Size(147, 22)
        Me.TxtNh_CC1.TabIndex = 4
        Me.TxtNh_CC1.Table_Name = ""
        '
        'TxtTen_NhCC3
        '
        Me.TxtTen_NhCC3.BackColor = System.Drawing.Color.White
        Me.TxtTen_NhCC3.Enabled = False
        Me.TxtTen_NhCC3.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_NhCC3.Location = New System.Drawing.Point(264, 116)
        Me.TxtTen_NhCC3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_NhCC3.Name = "TxtTen_NhCC3"
        Me.TxtTen_NhCC3.ReadOnly = True
        Me.TxtTen_NhCC3.Size = New System.Drawing.Size(495, 22)
        Me.TxtTen_NhCC3.TabIndex = 510
        Me.TxtTen_NhCC3.TabStop = False
        '
        'TxtNh_CC3
        '
        Me.TxtNh_CC3._ActilookupPopup = False
        Me.TxtNh_CC3.CyberActilookupPopup = True
        Me.TxtNh_CC3.Dv_ListDetail = Nothing
        Me.TxtNh_CC3.Dv_Master = Nothing
        Me.TxtNh_CC3.FilterClient = ""
        Me.TxtNh_CC3.FilterSQL = ""
        Me.TxtNh_CC3.Location = New System.Drawing.Point(112, 117)
        Me.TxtNh_CC3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNh_CC3.Name = "TxtNh_CC3"
        Me.TxtNh_CC3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_CC3.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_CC3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_CC3.Size = New System.Drawing.Size(147, 22)
        Me.TxtNh_CC3.TabIndex = 6
        Me.TxtNh_CC3.Table_Name = ""
        '
        'TxtTen_NhCC2
        '
        Me.TxtTen_NhCC2.BackColor = System.Drawing.Color.White
        Me.TxtTen_NhCC2.Enabled = False
        Me.TxtTen_NhCC2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_NhCC2.Location = New System.Drawing.Point(264, 90)
        Me.TxtTen_NhCC2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_NhCC2.Name = "TxtTen_NhCC2"
        Me.TxtTen_NhCC2.ReadOnly = True
        Me.TxtTen_NhCC2.Size = New System.Drawing.Size(495, 22)
        Me.TxtTen_NhCC2.TabIndex = 509
        Me.TxtTen_NhCC2.TabStop = False
        '
        'TxtNh_CC2
        '
        Me.TxtNh_CC2._ActilookupPopup = False
        Me.TxtNh_CC2.CyberActilookupPopup = True
        Me.TxtNh_CC2.Dv_ListDetail = Nothing
        Me.TxtNh_CC2.Dv_Master = Nothing
        Me.TxtNh_CC2.FilterClient = ""
        Me.TxtNh_CC2.FilterSQL = ""
        Me.TxtNh_CC2.Location = New System.Drawing.Point(112, 91)
        Me.TxtNh_CC2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNh_CC2.Name = "TxtNh_CC2"
        Me.TxtNh_CC2.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_CC2.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_CC2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_CC2.Size = New System.Drawing.Size(147, 22)
        Me.TxtNh_CC2.TabIndex = 5
        Me.TxtNh_CC2.Table_Name = ""
        '
        'ChkTao_but_Toan
        '
        Me.ChkTao_but_Toan.AutoSize = True
        Me.ChkTao_but_Toan.Location = New System.Drawing.Point(112, 150)
        Me.ChkTao_but_Toan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkTao_but_Toan.Name = "ChkTao_but_Toan"
        Me.ChkTao_but_Toan.Size = New System.Drawing.Size(310, 21)
        Me.ChkTao_but_Toan.TabIndex = 7
        Me.ChkTao_but_Toan.Tag = "Create budget entries after allocating"
        Me.ChkTao_but_Toan.Text = "Tạo bút toán hạch toán sau khi tính phân bổ"
        Me.ChkTao_but_Toan.UseVisualStyleBackColor = True
        '
        'ImTinhPB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(765, 263)
        Me.Controls.Add(Me.ChkTao_but_Toan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTen_NhCC1)
        Me.Controls.Add(Me.TxtNh_CC1)
        Me.Controls.Add(Me.TxtTen_NhCC3)
        Me.Controls.Add(Me.TxtNh_CC3)
        Me.Controls.Add(Me.TxtTen_NhCC2)
        Me.Controls.Add(Me.TxtNh_CC2)
        Me.Controls.Add(Me.CbbM_Nam)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbbM_Thang2)
        Me.Controls.Add(Me.CbbM_Thang1)
        Me.Controls.Add(Me.LabM_month2)
        Me.Controls.Add(Me.LabM_month1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txtten_CC)
        Me.Controls.Add(Me.TxtMa_CC)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "ImTinhPB"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_CC, 0)
        Me.Controls.SetChildIndex(Me.Txtten_CC, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.LabM_month1, 0)
        Me.Controls.SetChildIndex(Me.LabM_month2, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Thang1, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Thang2, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Nam, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_CC2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_NhCC2, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_CC3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_NhCC3, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_CC1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_NhCC1, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.ChkTao_but_Toan, 0)
        CType(Me.TxtMa_CC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_CC1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_CC3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_CC2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbbM_Nam As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CbbM_Thang2 As System.Windows.Forms.ComboBox
    Friend WithEvents CbbM_Thang1 As System.Windows.Forms.ComboBox
    Friend WithEvents LabM_month2 As System.Windows.Forms.Label
    Friend WithEvents LabM_month1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txtten_CC As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_CC As Cyber.SmLists.TxtLookup
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_NhCC1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_CC1 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_NhCC3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_CC3 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_NhCC2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_CC2 As Cyber.SmLists.TxtLookup
    Friend WithEvents ChkTao_but_Toan As System.Windows.Forms.CheckBox

End Class
