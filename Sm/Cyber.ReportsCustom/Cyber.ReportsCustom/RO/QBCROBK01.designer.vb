<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QBCROBK01
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
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.Labma_kh = New System.Windows.Forms.Label()
        Me.txtten_kh = New System.Windows.Forms.TextBox()
        Me.Txtma_kh = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Nh_Vt3 = New System.Windows.Forms.TextBox()
        Me.TxtTen_Nh_Vt2 = New System.Windows.Forms.TextBox()
        Me.TxtTen_Nh_Vt1 = New System.Windows.Forms.TextBox()
        Me.CbbMa_GD = New System.Windows.Forms.ComboBox()
        Me.LabMa_GD = New System.Windows.Forms.Label()
        Me.LabMa_Bp = New System.Windows.Forms.Label()
        Me.TxtTen_Bp = New System.Windows.Forms.TextBox()
        Me.TxtMa_Bp = New Cyber.SmLists.TxtLookup()
        Me.LabMa_Hs = New System.Windows.Forms.Label()
        Me.TxtTen_Hs = New System.Windows.Forms.TextBox()
        Me.TxtMa_Hs = New Cyber.SmLists.TxtLookup()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbbMa_post2 = New System.Windows.Forms.ComboBox()
        Me.CbbMa_Post1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabM_Ngay_Ct2 = New System.Windows.Forms.Label()
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.TxtM_Ngay_Ct2 = New ClsTextBox.txtDate1()
        Me.TxtM_Ngay_Ct1 = New ClsTextBox.txtDate1()
        Me.CbbGroupByTH = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSo_RO = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtMa_xe = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtMa_Kx = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_kx = New System.Windows.Forms.TextBox()
        Me.LabMa_kho = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbbMa_TT = New System.Windows.Forms.ComboBox()
        CType(Me.Txtma_kh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Bp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Kx.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(754, 275)
        Me.ButtExit.TabIndex = 31
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(97, 236)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(508, 21)
        Me.CBBMa_Dvcs.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 239)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(650, 275)
        Me.ButtOK.TabIndex = 30
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(610, 242)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(691, 240)
        Me.ChkVND.TabIndex = 28
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(762, 240)
        Me.ChkNT.TabIndex = 29
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 258)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(851, 9)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'Labma_kh
        '
        Me.Labma_kh.Location = New System.Drawing.Point(5, 167)
        Me.Labma_kh.Name = "Labma_kh"
        Me.Labma_kh.Size = New System.Drawing.Size(66, 13)
        Me.Labma_kh.TabIndex = 206
        Me.Labma_kh.Tag = "Customer code"
        Me.Labma_kh.Text = "Mã  khách "
        '
        'txtten_kh
        '
        Me.txtten_kh.BackColor = System.Drawing.SystemColors.Control
        Me.txtten_kh.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtten_kh.Enabled = False
        Me.txtten_kh.ForeColor = System.Drawing.Color.Navy
        Me.txtten_kh.Location = New System.Drawing.Point(213, 166)
        Me.txtten_kh.Name = "txtten_kh"
        Me.txtten_kh.ReadOnly = True
        Me.txtten_kh.Size = New System.Drawing.Size(408, 14)
        Me.txtten_kh.TabIndex = 205
        Me.txtten_kh.TabStop = False
        '
        'Txtma_kh
        '
        Me.Txtma_kh._ActilookupPopup = False
        Me.Txtma_kh.CyberActilookupPopup = True
        Me.Txtma_kh.Dv_ListDetail = Nothing
        Me.Txtma_kh.Dv_Master = Nothing
        Me.Txtma_kh.FilterClient = ""
        Me.Txtma_kh.FilterSQL = ""
        Me.Txtma_kh.Location = New System.Drawing.Point(97, 163)
        Me.Txtma_kh.Name = "Txtma_kh"
        Me.Txtma_kh.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Txtma_kh.Properties.Appearance.Options.UseForeColor = True
        Me.Txtma_kh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.Txtma_kh.Size = New System.Drawing.Size(110, 20)
        Me.Txtma_kh.TabIndex = 2
        Me.Txtma_kh.Table_Name = ""
        '
        'TxtTen_Nh_Vt3
        '
        Me.TxtTen_Nh_Vt3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtTen_Nh_Vt3.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh_Vt3.Enabled = False
        Me.TxtTen_Nh_Vt3.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh_Vt3.Location = New System.Drawing.Point(193, 307)
        Me.TxtTen_Nh_Vt3.Name = "TxtTen_Nh_Vt3"
        Me.TxtTen_Nh_Vt3.ReadOnly = True
        Me.TxtTen_Nh_Vt3.Size = New System.Drawing.Size(177, 21)
        Me.TxtTen_Nh_Vt3.TabIndex = 352
        Me.TxtTen_Nh_Vt3.TabStop = False
        Me.TxtTen_Nh_Vt3.Visible = False
        '
        'TxtTen_Nh_Vt2
        '
        Me.TxtTen_Nh_Vt2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtTen_Nh_Vt2.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh_Vt2.Enabled = False
        Me.TxtTen_Nh_Vt2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh_Vt2.Location = New System.Drawing.Point(193, 285)
        Me.TxtTen_Nh_Vt2.Name = "TxtTen_Nh_Vt2"
        Me.TxtTen_Nh_Vt2.ReadOnly = True
        Me.TxtTen_Nh_Vt2.Size = New System.Drawing.Size(177, 21)
        Me.TxtTen_Nh_Vt2.TabIndex = 351
        Me.TxtTen_Nh_Vt2.TabStop = False
        Me.TxtTen_Nh_Vt2.Visible = False
        '
        'TxtTen_Nh_Vt1
        '
        Me.TxtTen_Nh_Vt1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtTen_Nh_Vt1.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh_Vt1.Enabled = False
        Me.TxtTen_Nh_Vt1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh_Vt1.Location = New System.Drawing.Point(193, 263)
        Me.TxtTen_Nh_Vt1.Name = "TxtTen_Nh_Vt1"
        Me.TxtTen_Nh_Vt1.ReadOnly = True
        Me.TxtTen_Nh_Vt1.Size = New System.Drawing.Size(177, 21)
        Me.TxtTen_Nh_Vt1.TabIndex = 350
        Me.TxtTen_Nh_Vt1.TabStop = False
        Me.TxtTen_Nh_Vt1.Visible = False
        '
        'CbbMa_GD
        '
        Me.CbbMa_GD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_GD.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_GD.FormattingEnabled = True
        Me.CbbMa_GD.Location = New System.Drawing.Point(417, 187)
        Me.CbbMa_GD.Name = "CbbMa_GD"
        Me.CbbMa_GD.Size = New System.Drawing.Size(188, 21)
        Me.CbbMa_GD.TabIndex = 8
        '
        'LabMa_GD
        '
        Me.LabMa_GD.AutoSize = True
        Me.LabMa_GD.Location = New System.Drawing.Point(340, 191)
        Me.LabMa_GD.Name = "LabMa_GD"
        Me.LabMa_GD.Size = New System.Drawing.Size(49, 13)
        Me.LabMa_GD.TabIndex = 380
        Me.LabMa_GD.Tag = "Loại lệnh"
        Me.LabMa_GD.Text = "Loại lệnh"
        '
        'LabMa_Bp
        '
        Me.LabMa_Bp.AutoSize = True
        Me.LabMa_Bp.Location = New System.Drawing.Point(5, 144)
        Me.LabMa_Bp.Name = "LabMa_Bp"
        Me.LabMa_Bp.Size = New System.Drawing.Size(46, 13)
        Me.LabMa_Bp.TabIndex = 412
        Me.LabMa_Bp.Tag = "Parts department"
        Me.LabMa_Bp.Text = "Bộ phận"
        '
        'TxtTen_Bp
        '
        Me.TxtTen_Bp.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Bp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Bp.Enabled = False
        Me.TxtTen_Bp.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Bp.Location = New System.Drawing.Point(213, 143)
        Me.TxtTen_Bp.Name = "TxtTen_Bp"
        Me.TxtTen_Bp.ReadOnly = True
        Me.TxtTen_Bp.Size = New System.Drawing.Size(408, 14)
        Me.TxtTen_Bp.TabIndex = 411
        Me.TxtTen_Bp.TabStop = False
        '
        'TxtMa_Bp
        '
        Me.TxtMa_Bp._ActilookupPopup = False
        Me.TxtMa_Bp.CyberActilookupPopup = True
        Me.TxtMa_Bp.Dv_ListDetail = Nothing
        Me.TxtMa_Bp.Dv_Master = Nothing
        Me.TxtMa_Bp.FilterClient = ""
        Me.TxtMa_Bp.FilterSQL = ""
        Me.TxtMa_Bp.Location = New System.Drawing.Point(97, 140)
        Me.TxtMa_Bp.Name = "TxtMa_Bp"
        Me.TxtMa_Bp.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Bp.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Bp.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Bp.Size = New System.Drawing.Size(110, 20)
        Me.TxtMa_Bp.TabIndex = 18
        Me.TxtMa_Bp.Table_Name = ""
        '
        'LabMa_Hs
        '
        Me.LabMa_Hs.AutoSize = True
        Me.LabMa_Hs.Location = New System.Drawing.Point(5, 122)
        Me.LabMa_Hs.Name = "LabMa_Hs"
        Me.LabMa_Hs.Size = New System.Drawing.Size(78, 13)
        Me.LabMa_Hs.TabIndex = 408
        Me.LabMa_Hs.Tag = "Staff"
        Me.LabMa_Hs.Text = "Cố vấn dịch vụ"
        '
        'TxtTen_Hs
        '
        Me.TxtTen_Hs.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Hs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Hs.Enabled = False
        Me.TxtTen_Hs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Hs.Location = New System.Drawing.Point(213, 121)
        Me.TxtTen_Hs.Name = "TxtTen_Hs"
        Me.TxtTen_Hs.ReadOnly = True
        Me.TxtTen_Hs.Size = New System.Drawing.Size(408, 14)
        Me.TxtTen_Hs.TabIndex = 407
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
        Me.TxtMa_Hs.Location = New System.Drawing.Point(97, 118)
        Me.TxtMa_Hs.Name = "TxtMa_Hs"
        Me.TxtMa_Hs.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Hs.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Hs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Hs.Size = New System.Drawing.Size(110, 20)
        Me.TxtMa_Hs.TabIndex = 17
        Me.TxtMa_Hs.Table_Name = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(340, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 435
        Me.Label3.Tag = "Loại giao dịch"
        Me.Label3.Text = "Đến"
        '
        'CbbMa_post2
        '
        Me.CbbMa_post2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_post2.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_post2.FormattingEnabled = True
        Me.CbbMa_post2.Location = New System.Drawing.Point(417, 210)
        Me.CbbMa_post2.Name = "CbbMa_post2"
        Me.CbbMa_post2.Size = New System.Drawing.Size(188, 21)
        Me.CbbMa_post2.TabIndex = 26
        '
        'CbbMa_Post1
        '
        Me.CbbMa_Post1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_Post1.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_Post1.FormattingEnabled = True
        Me.CbbMa_Post1.Location = New System.Drawing.Point(97, 210)
        Me.CbbMa_Post1.Name = "CbbMa_Post1"
        Me.CbbMa_Post1.Size = New System.Drawing.Size(225, 21)
        Me.CbbMa_Post1.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(5, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 17)
        Me.Label7.TabIndex = 434
        Me.Label7.Tag = "Type"
        Me.Label7.Text = "Mức xử lý từ"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(340, 32)
        Me.LabM_Ngay_Ct2.Name = "LabM_Ngay_Ct2"
        Me.LabM_Ngay_Ct2.Size = New System.Drawing.Size(54, 13)
        Me.LabM_Ngay_Ct2.TabIndex = 439
        Me.LabM_Ngay_Ct2.Tag = "Date to"
        Me.LabM_Ngay_Ct2.Text = "Đến ngày"
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(5, 32)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(47, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 438
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(417, 27)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(102, 21)
        Me.TxtM_Ngay_Ct2.TabIndex = 1
        Me.TxtM_Ngay_Ct2.Text = "01/01/1900"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(97, 27)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(110, 21)
        Me.TxtM_Ngay_Ct1.TabIndex = 0
        Me.TxtM_Ngay_Ct1.Text = "01/01/1900"
        Me.TxtM_Ngay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'CbbGroupByTH
        '
        Me.CbbGroupByTH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbGroupByTH.ForeColor = System.Drawing.Color.Navy
        Me.CbbGroupByTH.FormattingEnabled = True
        Me.CbbGroupByTH.Location = New System.Drawing.Point(97, 3)
        Me.CbbGroupByTH.Name = "CbbGroupByTH"
        Me.CbbGroupByTH.Size = New System.Drawing.Size(508, 21)
        Me.CbbGroupByTH.TabIndex = 440
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 443
        Me.Label9.Tag = "Sum by"
        Me.Label9.Text = "Tổng hợp theo"
        '
        'txtSo_RO
        '
        Me.txtSo_RO.BackColor = System.Drawing.Color.White
        Me.txtSo_RO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSo_RO.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtSo_RO.ForeColor = System.Drawing.Color.Navy
        Me.txtSo_RO.Location = New System.Drawing.Point(97, 50)
        Me.txtSo_RO.Name = "txtSo_RO"
        Me.txtSo_RO.Size = New System.Drawing.Size(110, 21)
        Me.txtSo_RO.TabIndex = 444
        Me.txtSo_RO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 445
        Me.Label10.Tag = "Account"
        Me.Label10.Text = "Số lệnh"
        '
        'txtMa_xe
        '
        Me.txtMa_xe.BackColor = System.Drawing.Color.White
        Me.txtMa_xe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMa_xe.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtMa_xe.ForeColor = System.Drawing.Color.Navy
        Me.txtMa_xe.Location = New System.Drawing.Point(97, 73)
        Me.txtMa_xe.Name = "txtMa_xe"
        Me.txtMa_xe.Size = New System.Drawing.Size(110, 21)
        Me.txtMa_xe.TabIndex = 447
        Me.txtMa_xe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 448
        Me.Label11.Tag = "Account"
        Me.Label11.Text = "Biển số"
        '
        'TxtMa_Kx
        '
        Me.TxtMa_Kx._ActilookupPopup = False
        Me.TxtMa_Kx.CyberActilookupPopup = True
        Me.TxtMa_Kx.Dv_ListDetail = Nothing
        Me.TxtMa_Kx.Dv_Master = Nothing
        Me.TxtMa_Kx.FilterClient = ""
        Me.TxtMa_Kx.FilterSQL = ""
        Me.TxtMa_Kx.Location = New System.Drawing.Point(97, 96)
        Me.TxtMa_Kx.Name = "TxtMa_Kx"
        Me.TxtMa_Kx.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kx.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kx.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kx.Size = New System.Drawing.Size(110, 20)
        Me.TxtMa_Kx.TabIndex = 3
        Me.TxtMa_Kx.Table_Name = ""
        '
        'TxtTen_kx
        '
        Me.TxtTen_kx.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_kx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_kx.Enabled = False
        Me.TxtTen_kx.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_kx.Location = New System.Drawing.Point(213, 99)
        Me.TxtTen_kx.Name = "TxtTen_kx"
        Me.TxtTen_kx.ReadOnly = True
        Me.TxtTen_kx.Size = New System.Drawing.Size(408, 14)
        Me.TxtTen_kx.TabIndex = 354
        Me.TxtTen_kx.TabStop = False
        '
        'LabMa_kho
        '
        Me.LabMa_kho.Location = New System.Drawing.Point(5, 100)
        Me.LabMa_kho.Name = "LabMa_kho"
        Me.LabMa_kho.Size = New System.Drawing.Size(66, 13)
        Me.LabMa_kho.TabIndex = 355
        Me.LabMa_kho.Tag = "Warehouse code"
        Me.LabMa_kho.Text = "Kiểu xe"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 450
        Me.Label2.Tag = "Loại lệnh"
        Me.Label2.Text = "Lệnh"
        '
        'CbbMa_TT
        '
        Me.CbbMa_TT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_TT.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_TT.FormattingEnabled = True
        Me.CbbMa_TT.Location = New System.Drawing.Point(97, 187)
        Me.CbbMa_TT.Name = "CbbMa_TT"
        Me.CbbMa_TT.Size = New System.Drawing.Size(225, 21)
        Me.CbbMa_TT.TabIndex = 449
        '
        'QBCROBK01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(858, 328)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbbMa_TT)
        Me.Controls.Add(Me.txtMa_xe)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtSo_RO)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CbbGroupByTH)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CbbMa_post2)
        Me.Controls.Add(Me.CbbMa_Post1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LabMa_Bp)
        Me.Controls.Add(Me.TxtTen_Bp)
        Me.Controls.Add(Me.TxtMa_Bp)
        Me.Controls.Add(Me.LabMa_Hs)
        Me.Controls.Add(Me.TxtTen_Hs)
        Me.Controls.Add(Me.TxtMa_Hs)
        Me.Controls.Add(Me.LabMa_GD)
        Me.Controls.Add(Me.CbbMa_GD)
        Me.Controls.Add(Me.LabMa_kho)
        Me.Controls.Add(Me.TxtTen_kx)
        Me.Controls.Add(Me.TxtMa_Kx)
        Me.Controls.Add(Me.TxtTen_Nh_Vt3)
        Me.Controls.Add(Me.TxtTen_Nh_Vt2)
        Me.Controls.Add(Me.TxtTen_Nh_Vt1)
        Me.Controls.Add(Me.Labma_kh)
        Me.Controls.Add(Me.txtten_kh)
        Me.Controls.Add(Me.Txtma_kh)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Name = "QBCROBK01"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Txtma_kh, 0)
        Me.Controls.SetChildIndex(Me.txtten_kh, 0)
        Me.Controls.SetChildIndex(Me.Labma_kh, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh_Vt1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh_Vt2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh_Vt3, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kx, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kx, 0)
        Me.Controls.SetChildIndex(Me.LabMa_kho, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_GD, 0)
        Me.Controls.SetChildIndex(Me.LabMa_GD, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Hs, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hs, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Hs, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Bp, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Bp, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Bp, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_Post1, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_post2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.CbbGroupByTH, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.txtSo_RO, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.txtMa_xe, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_TT, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        CType(Me.Txtma_kh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Bp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Kx.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents Labma_kh As System.Windows.Forms.Label
    Friend WithEvents txtten_kh As System.Windows.Forms.TextBox
    Friend WithEvents Txtma_kh As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Nh_Vt3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_Nh_Vt2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_Nh_Vt1 As System.Windows.Forms.TextBox
    Friend WithEvents CbbMa_GD As System.Windows.Forms.ComboBox
    Friend WithEvents LabMa_GD As System.Windows.Forms.Label
    Friend WithEvents LabMa_Bp As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Bp As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Bp As Cyber.SmLists.TxtLookup
    Friend WithEvents LabMa_Hs As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Hs As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Hs As Cyber.SmLists.TxtLookup
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CbbMa_post2 As System.Windows.Forms.ComboBox
    Friend WithEvents CbbMa_Post1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents CbbGroupByTH As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSo_RO As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtMa_xe As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Kx As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_kx As System.Windows.Forms.TextBox
    Friend WithEvents LabMa_kho As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CbbMa_TT As System.Windows.Forms.ComboBox

End Class
