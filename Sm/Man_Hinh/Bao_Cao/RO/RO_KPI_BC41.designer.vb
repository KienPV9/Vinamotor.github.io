<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RO_KPI_BC41
    Inherits Cyber.From.FilterReport

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
        Me.TxtM_Ngay_Ct1 = New ClsTextBox.txtDate1()
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtM_Ngay_Ct2 = New ClsTextBox.txtDate1()
        Me.TxtSo_RO = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CbbMa_GD = New System.Windows.Forms.ComboBox()
        Me.LabSo_Ct1 = New System.Windows.Forms.Label()
        Me.LabMa_Hs = New System.Windows.Forms.Label()
        Me.TxtTen_Hs = New System.Windows.Forms.TextBox()
        Me.TxtMa_Hs = New Cyber.SmLists.TxtLookup()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTen_kh = New System.Windows.Forms.TextBox()
        Me.Txtma_kh = New Cyber.SmLists.TxtLookup()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh5 = New System.Windows.Forms.TextBox()
        Me.TxtNh_KH5 = New Cyber.SmLists.TxtLookup()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh4 = New System.Windows.Forms.TextBox()
        Me.TxtNh_KH4 = New Cyber.SmLists.TxtLookup()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh3 = New System.Windows.Forms.TextBox()
        Me.TxtNh_KH3 = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Nh2 = New System.Windows.Forms.TextBox()
        Me.TxtNh_KH2 = New Cyber.SmLists.TxtLookup()
        Me.LabMa_Nh1 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh1 = New System.Windows.Forms.TextBox()
        Me.TxtNh_KH1 = New Cyber.SmLists.TxtLookup()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTen_TK = New System.Windows.Forms.TextBox()
        Me.TxtTk = New Cyber.SmLists.TxtLookup()
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txtma_kh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_KH5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_KH4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_KH3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_KH2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_KH1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(1068, 383)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 25
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(127, 332)
        Me.CBBMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(1065, 25)
        Me.CBBMa_Dvcs.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 336)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(929, 383)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 24
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(13, 307)
        Me.LabLoai_NT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(127, 303)
        Me.ChkVND.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkVND.TabIndex = 21
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(280, 303)
        Me.ChkNT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkNT.TabIndex = 22
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(125, 4)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(153, 24)
        Me.TxtM_Ngay_Ct1.TabIndex = 0
        Me.TxtM_Ngay_Ct1.Text = "__/__/____"
        Me.TxtM_Ngay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(7, 8)
        Me.LabM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(60, 17)
        Me.LabM_Ngay_Ct1.TabIndex = 13
        Me.LabM_Ngay_Ct1.Tag = "From Date "
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(5, 361)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1197, 12)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 38)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Tag = "Date to"
        Me.Label2.Text = "Đến ngày"
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.isEmpty = True
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(125, 34)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(153, 24)
        Me.TxtM_Ngay_Ct2.TabIndex = 1
        Me.TxtM_Ngay_Ct2.Text = "__/__/____"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtSo_RO
        '
        Me.TxtSo_RO.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_RO.Location = New System.Drawing.Point(371, 4)
        Me.TxtSo_RO.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtSo_RO.Name = "TxtSo_RO"
        Me.TxtSo_RO.Size = New System.Drawing.Size(153, 24)
        Me.TxtSo_RO.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(555, 13)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 17)
        Me.Label5.TabIndex = 528
        Me.Label5.Tag = "Type"
        Me.Label5.Text = "Loại lệnh"
        '
        'CbbMa_GD
        '
        Me.CbbMa_GD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_GD.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_GD.FormattingEnabled = True
        Me.CbbMa_GD.Location = New System.Drawing.Point(669, 8)
        Me.CbbMa_GD.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbMa_GD.Name = "CbbMa_GD"
        Me.CbbMa_GD.Size = New System.Drawing.Size(215, 25)
        Me.CbbMa_GD.TabIndex = 4
        '
        'LabSo_Ct1
        '
        Me.LabSo_Ct1.Location = New System.Drawing.Point(287, 8)
        Me.LabSo_Ct1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabSo_Ct1.Name = "LabSo_Ct1"
        Me.LabSo_Ct1.Size = New System.Drawing.Size(83, 20)
        Me.LabSo_Ct1.TabIndex = 527
        Me.LabSo_Ct1.Tag = "No RO"
        Me.LabSo_Ct1.Text = "Số lệnh"
        '
        'LabMa_Hs
        '
        Me.LabMa_Hs.AutoSize = True
        Me.LabMa_Hs.Location = New System.Drawing.Point(7, 102)
        Me.LabMa_Hs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_Hs.Name = "LabMa_Hs"
        Me.LabMa_Hs.Size = New System.Drawing.Size(101, 17)
        Me.LabMa_Hs.TabIndex = 533
        Me.LabMa_Hs.Tag = "Staff"
        Me.LabMa_Hs.Text = "Cố vấn dịch vụ"
        '
        'TxtTen_Hs
        '
        Me.TxtTen_Hs.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Hs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Hs.Enabled = False
        Me.TxtTen_Hs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Hs.Location = New System.Drawing.Point(297, 102)
        Me.TxtTen_Hs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Hs.Name = "TxtTen_Hs"
        Me.TxtTen_Hs.ReadOnly = True
        Me.TxtTen_Hs.Size = New System.Drawing.Size(576, 17)
        Me.TxtTen_Hs.TabIndex = 532
        Me.TxtTen_Hs.TabStop = False
        '
        'TxtMa_Hs
        '
        Me.TxtMa_Hs._ActilookupPopup = False
        Me.TxtMa_Hs.CyberActilookupPopup = True
        Me.TxtMa_Hs.Dv_ListDetail = Nothing
        Me.TxtMa_Hs.Dv_Master = Nothing
        Me.TxtMa_Hs.FilterClient = ""
        Me.TxtMa_Hs.FilterSQL = ""
        Me.TxtMa_Hs.Location = New System.Drawing.Point(125, 98)
        Me.TxtMa_Hs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Hs.Name = "TxtMa_Hs"
        Me.TxtMa_Hs.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Hs.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Hs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Hs.Size = New System.Drawing.Size(155, 22)
        Me.TxtMa_Hs.TabIndex = 8
        Me.TxtMa_Hs.Table_Name = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 131)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 17)
        Me.Label6.TabIndex = 536
        Me.Label6.Tag = "Customer"
        Me.Label6.Text = "Mã khách hàng"
        '
        'TxtTen_kh
        '
        Me.TxtTen_kh.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_kh.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_kh.Enabled = False
        Me.TxtTen_kh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_kh.Location = New System.Drawing.Point(297, 131)
        Me.TxtTen_kh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_kh.Name = "TxtTen_kh"
        Me.TxtTen_kh.ReadOnly = True
        Me.TxtTen_kh.Size = New System.Drawing.Size(576, 17)
        Me.TxtTen_kh.TabIndex = 535
        Me.TxtTen_kh.TabStop = False
        '
        'Txtma_kh
        '
        Me.Txtma_kh._ActilookupPopup = False
        Me.Txtma_kh.CyberActilookupPopup = True
        Me.Txtma_kh.Dv_ListDetail = Nothing
        Me.Txtma_kh.Dv_Master = Nothing
        Me.Txtma_kh.FilterClient = ""
        Me.Txtma_kh.FilterSQL = ""
        Me.Txtma_kh.Location = New System.Drawing.Point(125, 127)
        Me.Txtma_kh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtma_kh.Name = "Txtma_kh"
        Me.Txtma_kh.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Txtma_kh.Properties.Appearance.Options.UseForeColor = True
        Me.Txtma_kh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.Txtma_kh.Size = New System.Drawing.Size(155, 22)
        Me.Txtma_kh.TabIndex = 9
        Me.Txtma_kh.Table_Name = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(7, 277)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 24)
        Me.Label8.TabIndex = 556
        Me.Label8.Tag = "Group 5"
        Me.Label8.Text = "Nhóm 5"
        '
        'TxtTen_Nh5
        '
        Me.TxtTen_Nh5.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh5.Enabled = False
        Me.TxtTen_Nh5.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh5.Location = New System.Drawing.Point(297, 279)
        Me.TxtTen_Nh5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Nh5.Name = "TxtTen_Nh5"
        Me.TxtTen_Nh5.ReadOnly = True
        Me.TxtTen_Nh5.Size = New System.Drawing.Size(576, 17)
        Me.TxtTen_Nh5.TabIndex = 555
        Me.TxtTen_Nh5.TabStop = False
        '
        'TxtNh_KH5
        '
        Me.TxtNh_KH5._ActilookupPopup = False
        Me.TxtNh_KH5.CyberActilookupPopup = True
        Me.TxtNh_KH5.Dv_ListDetail = Nothing
        Me.TxtNh_KH5.Dv_Master = Nothing
        Me.TxtNh_KH5.FilterClient = ""
        Me.TxtNh_KH5.FilterSQL = ""
        Me.TxtNh_KH5.Location = New System.Drawing.Point(125, 271)
        Me.TxtNh_KH5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNh_KH5.Name = "TxtNh_KH5"
        Me.TxtNh_KH5.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_KH5.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_KH5.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_KH5.Size = New System.Drawing.Size(155, 22)
        Me.TxtNh_KH5.TabIndex = 14
        Me.TxtNh_KH5.Table_Name = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(7, 248)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 22)
        Me.Label9.TabIndex = 554
        Me.Label9.Tag = "Group 4"
        Me.Label9.Text = "Nhóm 4"
        '
        'TxtTen_Nh4
        '
        Me.TxtTen_Nh4.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh4.Enabled = False
        Me.TxtTen_Nh4.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh4.Location = New System.Drawing.Point(297, 250)
        Me.TxtTen_Nh4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Nh4.Name = "TxtTen_Nh4"
        Me.TxtTen_Nh4.ReadOnly = True
        Me.TxtTen_Nh4.Size = New System.Drawing.Size(576, 17)
        Me.TxtTen_Nh4.TabIndex = 553
        Me.TxtTen_Nh4.TabStop = False
        '
        'TxtNh_KH4
        '
        Me.TxtNh_KH4._ActilookupPopup = False
        Me.TxtNh_KH4.CyberActilookupPopup = True
        Me.TxtNh_KH4.Dv_ListDetail = Nothing
        Me.TxtNh_KH4.Dv_Master = Nothing
        Me.TxtNh_KH4.FilterClient = ""
        Me.TxtNh_KH4.FilterSQL = ""
        Me.TxtNh_KH4.Location = New System.Drawing.Point(125, 242)
        Me.TxtNh_KH4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNh_KH4.Name = "TxtNh_KH4"
        Me.TxtNh_KH4.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_KH4.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_KH4.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_KH4.Size = New System.Drawing.Size(155, 22)
        Me.TxtNh_KH4.TabIndex = 13
        Me.TxtNh_KH4.Table_Name = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(7, 218)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 22)
        Me.Label10.TabIndex = 552
        Me.Label10.Tag = "Group 3"
        Me.Label10.Text = "Nhóm 3"
        '
        'TxtTen_Nh3
        '
        Me.TxtTen_Nh3.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh3.Enabled = False
        Me.TxtTen_Nh3.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh3.Location = New System.Drawing.Point(297, 221)
        Me.TxtTen_Nh3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Nh3.Name = "TxtTen_Nh3"
        Me.TxtTen_Nh3.ReadOnly = True
        Me.TxtTen_Nh3.Size = New System.Drawing.Size(576, 17)
        Me.TxtTen_Nh3.TabIndex = 551
        Me.TxtTen_Nh3.TabStop = False
        '
        'TxtNh_KH3
        '
        Me.TxtNh_KH3._ActilookupPopup = False
        Me.TxtNh_KH3.CyberActilookupPopup = True
        Me.TxtNh_KH3.Dv_ListDetail = Nothing
        Me.TxtNh_KH3.Dv_Master = Nothing
        Me.TxtNh_KH3.FilterClient = ""
        Me.TxtNh_KH3.FilterSQL = ""
        Me.TxtNh_KH3.Location = New System.Drawing.Point(125, 213)
        Me.TxtNh_KH3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNh_KH3.Name = "TxtNh_KH3"
        Me.TxtNh_KH3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_KH3.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_KH3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_KH3.Size = New System.Drawing.Size(155, 22)
        Me.TxtNh_KH3.TabIndex = 12
        Me.TxtNh_KH3.Table_Name = ""
        '
        'TxtTen_Nh2
        '
        Me.TxtTen_Nh2.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh2.Enabled = False
        Me.TxtTen_Nh2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh2.Location = New System.Drawing.Point(297, 192)
        Me.TxtTen_Nh2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Nh2.Name = "TxtTen_Nh2"
        Me.TxtTen_Nh2.ReadOnly = True
        Me.TxtTen_Nh2.Size = New System.Drawing.Size(576, 17)
        Me.TxtTen_Nh2.TabIndex = 550
        Me.TxtTen_Nh2.TabStop = False
        '
        'TxtNh_KH2
        '
        Me.TxtNh_KH2._ActilookupPopup = False
        Me.TxtNh_KH2.CyberActilookupPopup = True
        Me.TxtNh_KH2.Dv_ListDetail = Nothing
        Me.TxtNh_KH2.Dv_Master = Nothing
        Me.TxtNh_KH2.FilterClient = ""
        Me.TxtNh_KH2.FilterSQL = ""
        Me.TxtNh_KH2.Location = New System.Drawing.Point(125, 184)
        Me.TxtNh_KH2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNh_KH2.Name = "TxtNh_KH2"
        Me.TxtNh_KH2.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_KH2.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_KH2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_KH2.Size = New System.Drawing.Size(155, 22)
        Me.TxtNh_KH2.TabIndex = 11
        Me.TxtNh_KH2.Table_Name = ""
        '
        'LabMa_Nh1
        '
        Me.LabMa_Nh1.Location = New System.Drawing.Point(7, 160)
        Me.LabMa_Nh1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_Nh1.Name = "LabMa_Nh1"
        Me.LabMa_Nh1.Size = New System.Drawing.Size(105, 22)
        Me.LabMa_Nh1.TabIndex = 549
        Me.LabMa_Nh1.Tag = "Group 1"
        Me.LabMa_Nh1.Text = "Nhóm 1"
        '
        'TxtTen_Nh1
        '
        Me.TxtTen_Nh1.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh1.Enabled = False
        Me.TxtTen_Nh1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh1.Location = New System.Drawing.Point(297, 163)
        Me.TxtTen_Nh1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Nh1.Name = "TxtTen_Nh1"
        Me.TxtTen_Nh1.ReadOnly = True
        Me.TxtTen_Nh1.Size = New System.Drawing.Size(576, 17)
        Me.TxtTen_Nh1.TabIndex = 548
        Me.TxtTen_Nh1.TabStop = False
        '
        'TxtNh_KH1
        '
        Me.TxtNh_KH1._ActilookupPopup = False
        Me.TxtNh_KH1.CyberActilookupPopup = True
        Me.TxtNh_KH1.Dv_ListDetail = Nothing
        Me.TxtNh_KH1.Dv_Master = Nothing
        Me.TxtNh_KH1.FilterClient = ""
        Me.TxtNh_KH1.FilterSQL = ""
        Me.TxtNh_KH1.Location = New System.Drawing.Point(125, 156)
        Me.TxtNh_KH1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNh_KH1.Name = "TxtNh_KH1"
        Me.TxtNh_KH1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_KH1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_KH1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_KH1.Size = New System.Drawing.Size(155, 22)
        Me.TxtNh_KH1.TabIndex = 10
        Me.TxtNh_KH1.Table_Name = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(7, 188)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 22)
        Me.Label11.TabIndex = 557
        Me.Label11.Tag = "Group 2"
        Me.Label11.Text = "Nhóm 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 72)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 17)
        Me.Label4.TabIndex = 624
        Me.Label4.Tag = "Account"
        Me.Label4.Text = "TK công nợ"
        '
        'TxtTen_TK
        '
        Me.TxtTen_TK.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_TK.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_TK.Enabled = False
        Me.TxtTen_TK.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_TK.Location = New System.Drawing.Point(297, 72)
        Me.TxtTen_TK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_TK.Name = "TxtTen_TK"
        Me.TxtTen_TK.ReadOnly = True
        Me.TxtTen_TK.Size = New System.Drawing.Size(576, 17)
        Me.TxtTen_TK.TabIndex = 623
        Me.TxtTen_TK.TabStop = False
        '
        'TxtTk
        '
        Me.TxtTk._ActilookupPopup = False
        Me.TxtTk.CyberActilookupPopup = True
        Me.TxtTk.Dv_ListDetail = Nothing
        Me.TxtTk.Dv_Master = Nothing
        Me.TxtTk.FilterClient = ""
        Me.TxtTk.FilterSQL = ""
        Me.TxtTk.Location = New System.Drawing.Point(125, 68)
        Me.TxtTk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTk.Name = "TxtTk"
        Me.TxtTk.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTk.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTk.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTk.Size = New System.Drawing.Size(155, 22)
        Me.TxtTk.TabIndex = 622
        Me.TxtTk.Table_Name = ""
        '
        'RO_KPI_BC41
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(1207, 452)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTen_TK)
        Me.Controls.Add(Me.TxtTk)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtTen_Nh5)
        Me.Controls.Add(Me.TxtNh_KH5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtTen_Nh4)
        Me.Controls.Add(Me.TxtNh_KH4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtTen_Nh3)
        Me.Controls.Add(Me.TxtNh_KH3)
        Me.Controls.Add(Me.TxtTen_Nh2)
        Me.Controls.Add(Me.TxtNh_KH2)
        Me.Controls.Add(Me.LabMa_Nh1)
        Me.Controls.Add(Me.TxtTen_Nh1)
        Me.Controls.Add(Me.TxtNh_KH1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtTen_kh)
        Me.Controls.Add(Me.Txtma_kh)
        Me.Controls.Add(Me.LabMa_Hs)
        Me.Controls.Add(Me.TxtTen_Hs)
        Me.Controls.Add(Me.TxtMa_Hs)
        Me.Controls.Add(Me.TxtSo_RO)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CbbMa_GD)
        Me.Controls.Add(Me.LabSo_Ct1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "RO_KPI_BC41"
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.LabSo_Ct1, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_GD, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_RO, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Hs, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hs, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Hs, 0)
        Me.Controls.SetChildIndex(Me.Txtma_kh, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kh, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_KH1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh1, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Nh1, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_KH2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh2, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_KH3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh3, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_KH4, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh4, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_KH5, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh5, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtTk, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_TK, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txtma_kh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_KH5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_KH4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_KH3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_KH2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_KH1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents TxtSo_RO As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CbbMa_GD As System.Windows.Forms.ComboBox
    Friend WithEvents LabSo_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabMa_Hs As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Hs As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Hs As Cyber.SmLists.TxtLookup
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_kh As System.Windows.Forms.TextBox
    Friend WithEvents Txtma_kh As Cyber.SmLists.TxtLookup
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh5 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_KH5 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh4 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_KH4 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_KH3 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Nh2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_KH2 As Cyber.SmLists.TxtLookup
    Friend WithEvents LabMa_Nh1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_KH1 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_TK As System.Windows.Forms.TextBox
    Friend WithEvents TxtTk As Cyber.SmLists.TxtLookup

End Class
