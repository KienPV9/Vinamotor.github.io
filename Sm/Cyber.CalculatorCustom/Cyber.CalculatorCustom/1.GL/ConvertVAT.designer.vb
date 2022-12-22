<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConvertVAT
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
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.Master1 = New DevExpress.XtraGrid.GridControl()
        Me.Master1GRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.btnLoadData = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNgay_Ct1 = New ClsTextBox.txtDate1()
        Me.TxtNgay_Ct2 = New ClsTextBox.txtDate1()
        Me.TxtTk = New Cyber.SmLists.TxtLookup()
        Me.Txtten_Tk = New System.Windows.Forms.TextBox()
        Me.LabM_Tk = New System.Windows.Forms.Label()
        Me.TxtTk_Du = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Tk_Du = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChkCo = New System.Windows.Forms.CheckBox()
        Me.ChkNo = New System.Windows.Forms.CheckBox()
        Me.LabMa_Sp = New System.Windows.Forms.Label()
        Me.TxtTen_Sp = New System.Windows.Forms.TextBox()
        Me.TxtMa_Sp = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_kh_N = New System.Windows.Forms.TextBox()
        Me.TxtMa_Kh_N = New Cyber.SmLists.TxtLookup()
        Me.LabMa_kh_N = New System.Windows.Forms.Label()
        Me.TxtMa_CT = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Ct = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_kh_C = New System.Windows.Forms.TextBox()
        Me.TxtMa_Kh_C = New Cyber.SmLists.TxtLookup()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTen_Dvcs = New System.Windows.Forms.TextBox()
        Me.TxtMa_Dvcs = New Cyber.SmLists.TxtLookup()
        Me.CmdDelete = New System.Windows.Forms.Button()
        Me.CmdOk = New System.Windows.Forms.Button()
        Me.CmdRemoveAll = New System.Windows.Forms.Button()
        Me.CmdSelectAll = New System.Windows.Forms.Button()
        Me.CbbM_Thang = New System.Windows.Forms.ComboBox()
        Me.LabM_month1 = New System.Windows.Forms.Label()
        Me.CbbM_Nam = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.Master1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Master1GRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTk_Du.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Sp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Kh_N.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_CT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Kh_C.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Dvcs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 546)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1024, 8)
        Me.GroupBoxLine.TabIndex = 17
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(804, 556)
        Me.ButtOK.Size = New System.Drawing.Size(120, 30)
        Me.ButtOK.TabIndex = 19
        Me.ButtOK.Tag = "&OK"
        Me.ButtOK.Text = "&Chấp nhận"
        Me.ButtOK.Visible = False
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(926, 556)
        Me.ButtExit.TabIndex = 20
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(12, 9)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(46, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 507
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        Me.LabM_Ngay_Ct1.Visible = False
        '
        'Master1
        '
        Me.Master1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Master1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master1.Location = New System.Drawing.Point(0, 115)
        Me.Master1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master1.MainView = Me.Master1GRV
        Me.Master1.Name = "Master1"
        Me.Master1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.Master1.Size = New System.Drawing.Size(1025, 434)
        Me.Master1.TabIndex = 18
        Me.Master1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Master1GRV})
        '
        'Master1GRV
        '
        Me.Master1GRV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Master1GRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.Master1GRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.Master1GRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.Master1GRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.Master1GRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Master1GRV.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Master1GRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.Master1GRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master1GRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.Master1GRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.Master1GRV.CustomizationFormBounds = New System.Drawing.Rectangle(814, 465, 210, 172)
        Me.Master1GRV.GridControl = Me.Master1
        Me.Master1GRV.GroupRowHeight = 30
        Me.Master1GRV.Name = "Master1GRV"
        Me.Master1GRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.Master1GRV.OptionsLayout.Columns.AddNewColumns = False
        Me.Master1GRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.Master1GRV.OptionsView.ColumnAutoWidth = False
        Me.Master1GRV.OptionsView.ShowGroupPanel = False
        Me.Master1GRV.RowHeight = 21
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'btnLoadData
        '
        Me.btnLoadData.Location = New System.Drawing.Point(537, 68)
        Me.btnLoadData.Name = "btnLoadData"
        Me.btnLoadData.Size = New System.Drawing.Size(113, 31)
        Me.btnLoadData.TabIndex = 10
        Me.btnLoadData.Text = "Lấy dữ liệu"
        Me.btnLoadData.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 507
        Me.Label1.Tag = "Date from"
        Me.Label1.Text = "Đến ngày"
        Me.Label1.Visible = False
        '
        'TxtNgay_Ct1
        '
        Me.TxtNgay_Ct1.Flags = 0
        Me.TxtNgay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Ct1.IsAllowResize = False
        Me.TxtNgay_Ct1.isEmpty = True
        Me.TxtNgay_Ct1.Location = New System.Drawing.Point(81, 9)
        Me.TxtNgay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Ct1.MaxLength = 10
        Me.TxtNgay_Ct1.Name = "TxtNgay_Ct1"
        Me.TxtNgay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtNgay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtNgay_Ct1.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct1.Size = New System.Drawing.Size(110, 20)
        Me.TxtNgay_Ct1.TabIndex = 0
        Me.TxtNgay_Ct1.Text = "__/__/____"
        Me.TxtNgay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Ct1.Visible = False
        '
        'TxtNgay_Ct2
        '
        Me.TxtNgay_Ct2.Flags = 0
        Me.TxtNgay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Ct2.IsAllowResize = False
        Me.TxtNgay_Ct2.isEmpty = True
        Me.TxtNgay_Ct2.Location = New System.Drawing.Point(81, 31)
        Me.TxtNgay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Ct2.MaxLength = 10
        Me.TxtNgay_Ct2.Name = "TxtNgay_Ct2"
        Me.TxtNgay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtNgay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtNgay_Ct2.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct2.Size = New System.Drawing.Size(110, 20)
        Me.TxtNgay_Ct2.TabIndex = 1
        Me.TxtNgay_Ct2.Text = "__/__/____"
        Me.TxtNgay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Ct2.Visible = False
        '
        'TxtTk
        '
        Me.TxtTk._ActilookupPopup = False
        Me.TxtTk.CyberActilookupPopup = True
        Me.TxtTk.Dv_ListDetail = Nothing
        Me.TxtTk.Dv_Master = Nothing
        Me.TxtTk.FilterClient = ""
        Me.TxtTk.FilterSQL = ""
        Me.TxtTk.Location = New System.Drawing.Point(81, 52)
        Me.TxtTk.Name = "TxtTk"
        Me.TxtTk.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTk.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTk.Properties.Appearance.Options.UseFont = True
        Me.TxtTk.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTk.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTk.Size = New System.Drawing.Size(110, 20)
        Me.TxtTk.TabIndex = 2
        Me.TxtTk.Table_Name = ""
        Me.TxtTk.Visible = False
        '
        'Txtten_Tk
        '
        Me.Txtten_Tk.BackColor = System.Drawing.SystemColors.Control
        Me.Txtten_Tk.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtten_Tk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Txtten_Tk.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_Tk.Location = New System.Drawing.Point(30, 59)
        Me.Txtten_Tk.Name = "Txtten_Tk"
        Me.Txtten_Tk.ReadOnly = True
        Me.Txtten_Tk.Size = New System.Drawing.Size(260, 13)
        Me.Txtten_Tk.TabIndex = 520
        Me.Txtten_Tk.TabStop = False
        Me.Txtten_Tk.Visible = False
        '
        'LabM_Tk
        '
        Me.LabM_Tk.Location = New System.Drawing.Point(12, 55)
        Me.LabM_Tk.Name = "LabM_Tk"
        Me.LabM_Tk.Size = New System.Drawing.Size(82, 13)
        Me.LabM_Tk.TabIndex = 519
        Me.LabM_Tk.Tag = "Account"
        Me.LabM_Tk.Text = "Tài khoản"
        Me.LabM_Tk.Visible = False
        '
        'TxtTk_Du
        '
        Me.TxtTk_Du._ActilookupPopup = False
        Me.TxtTk_Du.CyberActilookupPopup = True
        Me.TxtTk_Du.Dv_ListDetail = Nothing
        Me.TxtTk_Du.Dv_Master = Nothing
        Me.TxtTk_Du.FilterClient = ""
        Me.TxtTk_Du.FilterSQL = ""
        Me.TxtTk_Du.Location = New System.Drawing.Point(81, 74)
        Me.TxtTk_Du.Name = "TxtTk_Du"
        Me.TxtTk_Du.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTk_Du.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTk_Du.Properties.Appearance.Options.UseFont = True
        Me.TxtTk_Du.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTk_Du.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTk_Du.Size = New System.Drawing.Size(110, 20)
        Me.TxtTk_Du.TabIndex = 3
        Me.TxtTk_Du.Table_Name = ""
        Me.TxtTk_Du.Visible = False
        '
        'TxtTen_Tk_Du
        '
        Me.TxtTen_Tk_Du.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Tk_Du.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Tk_Du.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Tk_Du.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Tk_Du.Location = New System.Drawing.Point(30, 77)
        Me.TxtTen_Tk_Du.Name = "TxtTen_Tk_Du"
        Me.TxtTen_Tk_Du.ReadOnly = True
        Me.TxtTen_Tk_Du.Size = New System.Drawing.Size(260, 13)
        Me.TxtTen_Tk_Du.TabIndex = 523
        Me.TxtTen_Tk_Du.TabStop = False
        Me.TxtTen_Tk_Du.Visible = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 522
        Me.Label2.Tag = "Account"
        Me.Label2.Text = "TK đối ứng"
        Me.Label2.Visible = False
        '
        'ChkCo
        '
        Me.ChkCo.AutoSize = True
        Me.ChkCo.Location = New System.Drawing.Point(315, 12)
        Me.ChkCo.Name = "ChkCo"
        Me.ChkCo.Size = New System.Drawing.Size(89, 17)
        Me.ChkCo.TabIndex = 5
        Me.ChkCo.Tag = "Acc credit"
        Me.ChkCo.Text = "Tài khoản có"
        Me.ChkCo.UseVisualStyleBackColor = True
        Me.ChkCo.Visible = False
        '
        'ChkNo
        '
        Me.ChkNo.AutoSize = True
        Me.ChkNo.Location = New System.Drawing.Point(201, 12)
        Me.ChkNo.Name = "ChkNo"
        Me.ChkNo.Size = New System.Drawing.Size(89, 17)
        Me.ChkNo.TabIndex = 4
        Me.ChkNo.Tag = "Acc debit"
        Me.ChkNo.Text = "Tài khoản nợ"
        Me.ChkNo.UseVisualStyleBackColor = True
        Me.ChkNo.Visible = False
        '
        'LabMa_Sp
        '
        Me.LabMa_Sp.Location = New System.Drawing.Point(703, 90)
        Me.LabMa_Sp.Name = "LabMa_Sp"
        Me.LabMa_Sp.Size = New System.Drawing.Size(82, 13)
        Me.LabMa_Sp.TabIndex = 543
        Me.LabMa_Sp.Tag = "Product"
        Me.LabMa_Sp.Text = "Mã sản phẩm"
        Me.LabMa_Sp.Visible = False
        '
        'TxtTen_Sp
        '
        Me.TxtTen_Sp.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Sp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Sp.Enabled = False
        Me.TxtTen_Sp.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Sp.Location = New System.Drawing.Point(656, 74)
        Me.TxtTen_Sp.Name = "TxtTen_Sp"
        Me.TxtTen_Sp.ReadOnly = True
        Me.TxtTen_Sp.Size = New System.Drawing.Size(272, 13)
        Me.TxtTen_Sp.TabIndex = 542
        Me.TxtTen_Sp.TabStop = False
        Me.TxtTen_Sp.Visible = False
        '
        'TxtMa_Sp
        '
        Me.TxtMa_Sp._ActilookupPopup = False
        Me.TxtMa_Sp.CyberActilookupPopup = True
        Me.TxtMa_Sp.Dv_ListDetail = Nothing
        Me.TxtMa_Sp.Dv_Master = Nothing
        Me.TxtMa_Sp.FilterClient = ""
        Me.TxtMa_Sp.FilterSQL = ""
        Me.TxtMa_Sp.Location = New System.Drawing.Point(723, 65)
        Me.TxtMa_Sp.Name = "TxtMa_Sp"
        Me.TxtMa_Sp.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Sp.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Sp.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Sp.Size = New System.Drawing.Size(113, 20)
        Me.TxtMa_Sp.TabIndex = 9
        Me.TxtMa_Sp.Table_Name = ""
        Me.TxtMa_Sp.Visible = False
        '
        'TxtTen_kh_N
        '
        Me.TxtTen_kh_N.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_kh_N.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_kh_N.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_kh_N.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_kh_N.Location = New System.Drawing.Point(656, 31)
        Me.TxtTen_kh_N.Name = "TxtTen_kh_N"
        Me.TxtTen_kh_N.ReadOnly = True
        Me.TxtTen_kh_N.Size = New System.Drawing.Size(272, 13)
        Me.TxtTen_kh_N.TabIndex = 535
        Me.TxtTen_kh_N.TabStop = False
        Me.TxtTen_kh_N.Visible = False
        '
        'TxtMa_Kh_N
        '
        Me.TxtMa_Kh_N._ActilookupPopup = False
        Me.TxtMa_Kh_N.CyberActilookupPopup = True
        Me.TxtMa_Kh_N.Dv_ListDetail = Nothing
        Me.TxtMa_Kh_N.Dv_Master = Nothing
        Me.TxtMa_Kh_N.FilterClient = ""
        Me.TxtMa_Kh_N.FilterSQL = ""
        Me.TxtMa_Kh_N.Location = New System.Drawing.Point(732, 24)
        Me.TxtMa_Kh_N.Name = "TxtMa_Kh_N"
        Me.TxtMa_Kh_N.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Kh_N.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kh_N.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Kh_N.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kh_N.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kh_N.Size = New System.Drawing.Size(112, 20)
        Me.TxtMa_Kh_N.TabIndex = 7
        Me.TxtMa_Kh_N.Table_Name = ""
        Me.TxtMa_Kh_N.Visible = False
        '
        'LabMa_kh_N
        '
        Me.LabMa_kh_N.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_kh_N.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabMa_kh_N.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_kh_N.Location = New System.Drawing.Point(827, 67)
        Me.LabMa_kh_N.Margin = New System.Windows.Forms.Padding(0)
        Me.LabMa_kh_N.Name = "LabMa_kh_N"
        Me.LabMa_kh_N.Size = New System.Drawing.Size(82, 14)
        Me.LabMa_kh_N.TabIndex = 534
        Me.LabMa_kh_N.Tag = "Cus code"
        Me.LabMa_kh_N.Text = "Đối tượng nợ"
        Me.LabMa_kh_N.Visible = False
        '
        'TxtMa_CT
        '
        Me.TxtMa_CT._ActilookupPopup = False
        Me.TxtMa_CT.CyberActilookupPopup = True
        Me.TxtMa_CT.Dv_ListDetail = Nothing
        Me.TxtMa_CT.Dv_Master = Nothing
        Me.TxtMa_CT.FilterClient = ""
        Me.TxtMa_CT.FilterSQL = ""
        Me.TxtMa_CT.Location = New System.Drawing.Point(538, 2)
        Me.TxtMa_CT.Name = "TxtMa_CT"
        Me.TxtMa_CT.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_CT.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_CT.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_CT.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_CT.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_CT.Size = New System.Drawing.Size(112, 20)
        Me.TxtMa_CT.TabIndex = 6
        Me.TxtMa_CT.Table_Name = ""
        '
        'TxtTen_Ct
        '
        Me.TxtTen_Ct.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Ct.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Ct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Ct.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Ct.Location = New System.Drawing.Point(656, 9)
        Me.TxtTen_Ct.Name = "TxtTen_Ct"
        Me.TxtTen_Ct.ReadOnly = True
        Me.TxtTen_Ct.Size = New System.Drawing.Size(272, 13)
        Me.TxtTen_Ct.TabIndex = 533
        Me.TxtTen_Ct.TabStop = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(454, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 532
        Me.Label3.Tag = "Account"
        Me.Label3.Text = "Loại chứng từ"
        '
        'TxtTen_kh_C
        '
        Me.TxtTen_kh_C.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_kh_C.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_kh_C.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_kh_C.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_kh_C.Location = New System.Drawing.Point(656, 51)
        Me.TxtTen_kh_C.Name = "TxtTen_kh_C"
        Me.TxtTen_kh_C.ReadOnly = True
        Me.TxtTen_kh_C.Size = New System.Drawing.Size(272, 13)
        Me.TxtTen_kh_C.TabIndex = 546
        Me.TxtTen_kh_C.TabStop = False
        Me.TxtTen_kh_C.Visible = False
        '
        'TxtMa_Kh_C
        '
        Me.TxtMa_Kh_C._ActilookupPopup = False
        Me.TxtMa_Kh_C.CyberActilookupPopup = True
        Me.TxtMa_Kh_C.Dv_ListDetail = Nothing
        Me.TxtMa_Kh_C.Dv_Master = Nothing
        Me.TxtMa_Kh_C.FilterClient = ""
        Me.TxtMa_Kh_C.FilterSQL = ""
        Me.TxtMa_Kh_C.Location = New System.Drawing.Point(760, 48)
        Me.TxtMa_Kh_C.Name = "TxtMa_Kh_C"
        Me.TxtMa_Kh_C.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Kh_C.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kh_C.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Kh_C.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kh_C.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kh_C.Size = New System.Drawing.Size(112, 20)
        Me.TxtMa_Kh_C.TabIndex = 8
        Me.TxtMa_Kh_C.Table_Name = ""
        Me.TxtMa_Kh_C.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(729, 47)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 14)
        Me.Label5.TabIndex = 545
        Me.Label5.Tag = "Cus code"
        Me.Label5.Text = "Đối tượng có"
        Me.Label5.Visible = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 549
        Me.Label4.Tag = "Product"
        Me.Label4.Text = "Mã công ty"
        Me.Label4.Visible = False
        '
        'TxtTen_Dvcs
        '
        Me.TxtTen_Dvcs.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Dvcs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Dvcs.Enabled = False
        Me.TxtTen_Dvcs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Dvcs.Location = New System.Drawing.Point(30, 90)
        Me.TxtTen_Dvcs.Name = "TxtTen_Dvcs"
        Me.TxtTen_Dvcs.ReadOnly = True
        Me.TxtTen_Dvcs.Size = New System.Drawing.Size(260, 13)
        Me.TxtTen_Dvcs.TabIndex = 548
        Me.TxtTen_Dvcs.TabStop = False
        Me.TxtTen_Dvcs.Visible = False
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs._ActilookupPopup = False
        Me.TxtMa_Dvcs.CyberActilookupPopup = True
        Me.TxtMa_Dvcs.Dv_ListDetail = Nothing
        Me.TxtMa_Dvcs.Dv_Master = Nothing
        Me.TxtMa_Dvcs.FilterClient = ""
        Me.TxtMa_Dvcs.FilterSQL = ""
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(81, 96)
        Me.TxtMa_Dvcs.Name = "TxtMa_Dvcs"
        Me.TxtMa_Dvcs.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Dvcs.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Dvcs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(110, 20)
        Me.TxtMa_Dvcs.TabIndex = 5
        Me.TxtMa_Dvcs.Table_Name = ""
        Me.TxtMa_Dvcs.Visible = False
        '
        'CmdDelete
        '
        Me.CmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdDelete.Location = New System.Drawing.Point(670, 556)
        Me.CmdDelete.Name = "CmdDelete"
        Me.CmdDelete.Size = New System.Drawing.Size(127, 31)
        Me.CmdDelete.TabIndex = 553
        Me.CmdDelete.Tag = "&Create Closing"
        Me.CmdDelete.Text = "&Xóa số liệu đã copy"
        Me.CmdDelete.UseVisualStyleBackColor = True
        '
        'CmdOk
        '
        Me.CmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdOk.BackColor = System.Drawing.Color.Red
        Me.CmdOk.ForeColor = System.Drawing.Color.Navy
        Me.CmdOk.Location = New System.Drawing.Point(578, 556)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(90, 31)
        Me.CmdOk.TabIndex = 552
        Me.CmdOk.Tag = "&Create Closing"
        Me.CmdOk.Text = "&Copy số liệu"
        Me.CmdOk.UseVisualStyleBackColor = False
        '
        'CmdRemoveAll
        '
        Me.CmdRemoveAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdRemoveAll.Location = New System.Drawing.Point(478, 556)
        Me.CmdRemoveAll.Name = "CmdRemoveAll"
        Me.CmdRemoveAll.Size = New System.Drawing.Size(98, 31)
        Me.CmdRemoveAll.TabIndex = 551
        Me.CmdRemoveAll.Tag = "&Remove All"
        Me.CmdRemoveAll.Text = "&Bỏ chọn tất cả"
        Me.CmdRemoveAll.UseVisualStyleBackColor = True
        '
        'CmdSelectAll
        '
        Me.CmdSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdSelectAll.Location = New System.Drawing.Point(387, 556)
        Me.CmdSelectAll.Name = "CmdSelectAll"
        Me.CmdSelectAll.Size = New System.Drawing.Size(90, 31)
        Me.CmdSelectAll.TabIndex = 550
        Me.CmdSelectAll.Tag = "&SELECT ALL"
        Me.CmdSelectAll.Text = "&Chọn tất cả"
        Me.CmdSelectAll.UseVisualStyleBackColor = True
        '
        'CbbM_Thang
        '
        Me.CbbM_Thang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Thang.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Thang.FormattingEnabled = True
        Me.CbbM_Thang.Location = New System.Drawing.Point(283, 6)
        Me.CbbM_Thang.Name = "CbbM_Thang"
        Me.CbbM_Thang.Size = New System.Drawing.Size(106, 21)
        Me.CbbM_Thang.TabIndex = 554
        '
        'LabM_month1
        '
        Me.LabM_month1.AutoSize = True
        Me.LabM_month1.Location = New System.Drawing.Point(198, 13)
        Me.LabM_month1.Name = "LabM_month1"
        Me.LabM_month1.Size = New System.Drawing.Size(38, 13)
        Me.LabM_month1.TabIndex = 555
        Me.LabM_month1.Tag = "Month from"
        Me.LabM_month1.Text = "Tháng"
        '
        'CbbM_Nam
        '
        Me.CbbM_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Nam.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Nam.FormattingEnabled = True
        Me.CbbM_Nam.Location = New System.Drawing.Point(283, 32)
        Me.CbbM_Nam.Name = "CbbM_Nam"
        Me.CbbM_Nam.Size = New System.Drawing.Size(106, 21)
        Me.CbbM_Nam.TabIndex = 556
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(198, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 557
        Me.Label6.Tag = "Year"
        Me.Label6.Text = "Năm"
        '
        'ConvertVAT
        '
        Me.AcceptButton = Me.btnLoadData
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1028, 610)
        Me.Controls.Add(Me.CbbM_Nam)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabM_month1)
        Me.Controls.Add(Me.CbbM_Thang)
        Me.Controls.Add(Me.CmdDelete)
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.CmdRemoveAll)
        Me.Controls.Add(Me.CmdSelectAll)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTen_Dvcs)
        Me.Controls.Add(Me.TxtMa_Dvcs)
        Me.Controls.Add(Me.TxtTen_kh_C)
        Me.Controls.Add(Me.TxtMa_Kh_C)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabMa_Sp)
        Me.Controls.Add(Me.TxtTen_Sp)
        Me.Controls.Add(Me.TxtMa_Sp)
        Me.Controls.Add(Me.TxtTen_kh_N)
        Me.Controls.Add(Me.TxtMa_Kh_N)
        Me.Controls.Add(Me.LabMa_kh_N)
        Me.Controls.Add(Me.TxtMa_CT)
        Me.Controls.Add(Me.TxtTen_Ct)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ChkCo)
        Me.Controls.Add(Me.ChkNo)
        Me.Controls.Add(Me.TxtTk_Du)
        Me.Controls.Add(Me.TxtTen_Tk_Du)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTk)
        Me.Controls.Add(Me.Txtten_Tk)
        Me.Controls.Add(Me.LabM_Tk)
        Me.Controls.Add(Me.TxtNgay_Ct2)
        Me.Controls.Add(Me.TxtNgay_Ct1)
        Me.Controls.Add(Me.btnLoadData)
        Me.Controls.Add(Me.Master1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Name = "ConvertVAT"
        Me.Text = " "
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Master1, 0)
        Me.Controls.SetChildIndex(Me.btnLoadData, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Tk, 0)
        Me.Controls.SetChildIndex(Me.Txtten_Tk, 0)
        Me.Controls.SetChildIndex(Me.TxtTk, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Tk_Du, 0)
        Me.Controls.SetChildIndex(Me.TxtTk_Du, 0)
        Me.Controls.SetChildIndex(Me.ChkNo, 0)
        Me.Controls.SetChildIndex(Me.ChkCo, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Ct, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_CT, 0)
        Me.Controls.SetChildIndex(Me.LabMa_kh_N, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kh_N, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kh_N, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Sp, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Sp, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Sp, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kh_C, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kh_C, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.CmdSelectAll, 0)
        Me.Controls.SetChildIndex(Me.CmdRemoveAll, 0)
        Me.Controls.SetChildIndex(Me.CmdOk, 0)
        Me.Controls.SetChildIndex(Me.CmdDelete, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Thang, 0)
        Me.Controls.SetChildIndex(Me.LabM_month1, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Nam, 0)
        CType(Me.Master1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Master1GRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTk_Du.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Sp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Kh_N.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_CT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Kh_C.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Dvcs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents Master1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents Master1GRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnLoadData As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtNgay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents TxtTk As Cyber.SmLists.TxtLookup
    Friend WithEvents Txtten_Tk As System.Windows.Forms.TextBox
    Friend WithEvents LabM_Tk As System.Windows.Forms.Label
    Friend WithEvents TxtTk_Du As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Tk_Du As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ChkCo As System.Windows.Forms.CheckBox
    Friend WithEvents ChkNo As System.Windows.Forms.CheckBox
    Friend WithEvents LabMa_Sp As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Sp As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Sp As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_kh_N As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Kh_N As Cyber.SmLists.TxtLookup
    Friend WithEvents LabMa_kh_N As System.Windows.Forms.Label
    Friend WithEvents TxtMa_CT As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Ct As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_kh_C As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Kh_C As Cyber.SmLists.TxtLookup
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Dvcs As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Dvcs As Cyber.SmLists.TxtLookup
    Friend WithEvents CmdDelete As System.Windows.Forms.Button
    Friend WithEvents CmdOk As System.Windows.Forms.Button
    Friend WithEvents CmdRemoveAll As System.Windows.Forms.Button
    Friend WithEvents CmdSelectAll As System.Windows.Forms.Button
    Friend WithEvents CbbM_Thang As Windows.Forms.ComboBox
    Friend WithEvents LabM_month1 As Windows.Forms.Label
    Friend WithEvents CbbM_Nam As Windows.Forms.ComboBox
    Friend WithEvents Label6 As Windows.Forms.Label
End Class
