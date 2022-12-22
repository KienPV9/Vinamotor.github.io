<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLocTT
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtT_Tien = New ClsTextBox.txtTien_NT()
        Me.TxtSo_Lenh_HT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTk = New Cyber.SmLists.TxtLookup()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNgay_Ct2 = New ClsTextBox.txtDate()
        Me.TxtNgay_Ct1 = New ClsTextBox.txtDate()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lblMa_kh = New System.Windows.Forms.Label()
        Me.CmdLoc_TT = New System.Windows.Forms.Button()
        Me.TxtTen_tk = New System.Windows.Forms.TextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DetailRo_Master = New DevExpress.XtraGrid.GridControl()
        Me.DetailGRVRo_Master = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.DetailRo_DetailCv = New DevExpress.XtraGrid.GridControl()
        Me.DetailGRVRo_DetailCv = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        CType(Me.TxtTk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DetailRo_Master, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailGRVRo_Master, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailRo_DetailCv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailGRVRo_DetailCv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 516)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1070, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(972, 525)
        Me.ButtOK.TabIndex = 4
        Me.ButtOK.Text = "&Chấp nhận"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(972, 558)
        Me.ButtExit.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(188, 539)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 399
        Me.Label3.Tag = "Total "
        Me.Label3.Text = "Tổng cộng"
        '
        'TxtT_Tien
        '
        Me.TxtT_Tien.AllowNegative = True
        Me.TxtT_Tien.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Tien.BackColor = System.Drawing.Color.White
        Me.TxtT_Tien.Flags = 7680
        Me.TxtT_Tien.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtT_Tien.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Tien.InputMask = "### ### ### ### ### ###"
        Me.TxtT_Tien.Location = New System.Drawing.Point(257, 535)
        Me.TxtT_Tien.MaxWholeDigits = 17
        Me.TxtT_Tien.Name = "TxtT_Tien"
        Me.TxtT_Tien.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Tien.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Tien.ReadOnly = True
        Me.TxtT_Tien.Size = New System.Drawing.Size(123, 20)
        Me.TxtT_Tien.TabIndex = 395
        Me.TxtT_Tien.TabStop = False
        Me.TxtT_Tien.Text = "0"
        Me.TxtT_Tien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtSo_Lenh_HT
        '
        Me.TxtSo_Lenh_HT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtSo_Lenh_HT.BackColor = System.Drawing.Color.White
        Me.TxtSo_Lenh_HT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_Lenh_HT.Enabled = False
        Me.TxtSo_Lenh_HT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSo_Lenh_HT.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Lenh_HT.Location = New System.Drawing.Point(53, 535)
        Me.TxtSo_Lenh_HT.Name = "TxtSo_Lenh_HT"
        Me.TxtSo_Lenh_HT.ReadOnly = True
        Me.TxtSo_Lenh_HT.Size = New System.Drawing.Size(125, 20)
        Me.TxtSo_Lenh_HT.TabIndex = 400
        Me.TxtSo_Lenh_HT.TabStop = False
        Me.TxtSo_Lenh_HT.Tag = ""
        Me.TxtSo_Lenh_HT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(4, 539)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 393
        Me.Label4.Tag = "Order no"
        Me.Label4.Text = "Số lệnh"
        '
        'TxtTk
        '
        Me.TxtTk._ActilookupPopup = False
        Me.TxtTk.CyberActilookupPopup = True
        Me.TxtTk.Dv_ListDetail = Nothing
        Me.TxtTk.Dv_Master = Nothing
        Me.TxtTk.FilterClient = ""
        Me.TxtTk.FilterSQL = ""
        Me.TxtTk.Location = New System.Drawing.Point(73, 5)
        Me.TxtTk.Name = "TxtTk"
        Me.TxtTk.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTk.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTk.Properties.Appearance.Options.UseFont = True
        Me.TxtTk.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTk.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TxtTk.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTk.Size = New System.Drawing.Size(119, 22)
        Me.TxtTk.TabIndex = 0
        Me.TxtTk.Table_Name = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(689, 10)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 382
        Me.Label2.Tag = "Date to"
        Me.Label2.Text = "Đến ngày"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(479, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 381
        Me.Label1.Tag = "Date from"
        Me.Label1.Text = "Từ ngày"
        '
        'TxtNgay_Ct2
        '
        Me.TxtNgay_Ct2.BackColor = System.Drawing.Color.White
        Me.TxtNgay_Ct2.Flags = 65536
        Me.TxtNgay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Ct2.isEmpty = True
        Me.TxtNgay_Ct2.Location = New System.Drawing.Point(752, 6)
        Me.TxtNgay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Ct2.MaxLength = 10
        Me.TxtNgay_Ct2.Name = "TxtNgay_Ct2"
        Me.TxtNgay_Ct2.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_Ct2.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Ct2.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct2.Size = New System.Drawing.Size(127, 20)
        Me.TxtNgay_Ct2.TabIndex = 2
        Me.TxtNgay_Ct2.Text = "18/09/2011"
        Me.TxtNgay_Ct2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_Ct2.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        '
        'TxtNgay_Ct1
        '
        Me.TxtNgay_Ct1.BackColor = System.Drawing.Color.White
        Me.TxtNgay_Ct1.Flags = 65536
        Me.TxtNgay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Ct1.isEmpty = True
        Me.TxtNgay_Ct1.Location = New System.Drawing.Point(548, 6)
        Me.TxtNgay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Ct1.MaxLength = 10
        Me.TxtNgay_Ct1.Name = "TxtNgay_Ct1"
        Me.TxtNgay_Ct1.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_Ct1.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Ct1.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct1.Size = New System.Drawing.Size(119, 20)
        Me.TxtNgay_Ct1.TabIndex = 1
        Me.TxtNgay_Ct1.Text = "18/09/2011"
        Me.TxtNgay_Ct1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_Ct1.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        '
        'GridView6
        '
        Me.GridView6.Name = "GridView6"
        '
        'GridView5
        '
        Me.GridView5.Name = "GridView5"
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'GridView2
        '
        Me.GridView2.Name = "GridView2"
        '
        'GridView3
        '
        Me.GridView3.Name = "GridView3"
        '
        'GridView4
        '
        Me.GridView4.Name = "GridView4"
        '
        'lblMa_kh
        '
        Me.lblMa_kh.AutoSize = True
        Me.lblMa_kh.ForeColor = System.Drawing.Color.Navy
        Me.lblMa_kh.Location = New System.Drawing.Point(5, 10)
        Me.lblMa_kh.Margin = New System.Windows.Forms.Padding(0)
        Me.lblMa_kh.Name = "lblMa_kh"
        Me.lblMa_kh.Size = New System.Drawing.Size(55, 13)
        Me.lblMa_kh.TabIndex = 380
        Me.lblMa_kh.Tag = "Account"
        Me.lblMa_kh.Text = "Tài khoản"
        '
        'CmdLoc_TT
        '
        Me.CmdLoc_TT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdLoc_TT.ForeColor = System.Drawing.Color.Navy
        Me.CmdLoc_TT.Location = New System.Drawing.Point(930, 1)
        Me.CmdLoc_TT.Name = "CmdLoc_TT"
        Me.CmdLoc_TT.Size = New System.Drawing.Size(140, 29)
        Me.CmdLoc_TT.TabIndex = 3
        Me.CmdLoc_TT.TabStop = False
        Me.CmdLoc_TT.Tag = "&Find"
        Me.CmdLoc_TT.Text = "&Lọc Phiếu"
        Me.CmdLoc_TT.UseVisualStyleBackColor = True
        '
        'TxtTen_tk
        '
        Me.TxtTen_tk.BackColor = System.Drawing.Color.White
        Me.TxtTen_tk.Enabled = False
        Me.TxtTen_tk.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_tk.Location = New System.Drawing.Point(194, 6)
        Me.TxtTen_tk.Name = "TxtTen_tk"
        Me.TxtTen_tk.ReadOnly = True
        Me.TxtTen_tk.Size = New System.Drawing.Size(282, 20)
        Me.TxtTen_tk.TabIndex = 377
        Me.TxtTen_tk.Tag = ""
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 36)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DetailRo_Master)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DetailRo_DetailCv)
        Me.SplitContainer1.Size = New System.Drawing.Size(1070, 484)
        Me.SplitContainer1.SplitterDistance = 225
        Me.SplitContainer1.TabIndex = 402
        '
        'DetailRo_Master
        '
        Me.DetailRo_Master.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.DetailRo_Master.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DetailRo_Master.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailRo_Master.Location = New System.Drawing.Point(0, 0)
        Me.DetailRo_Master.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.DetailRo_Master.MainView = Me.DetailGRVRo_Master
        Me.DetailRo_Master.Name = "DetailRo_Master"
        Me.DetailRo_Master.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.DetailRo_Master.Size = New System.Drawing.Size(1070, 225)
        Me.DetailRo_Master.TabIndex = 277
        Me.DetailRo_Master.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DetailGRVRo_Master})
        '
        'DetailGRVRo_Master
        '
        Me.DetailGRVRo_Master.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DetailGRVRo_Master.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DetailGRVRo_Master.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.DetailGRVRo_Master.Appearance.SelectedRow.Options.UseBackColor = True
        Me.DetailGRVRo_Master.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.DetailGRVRo_Master.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DetailGRVRo_Master.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.DetailGRVRo_Master.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.DetailGRVRo_Master.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailGRVRo_Master.AppearancePrint.EvenRow.Options.UseFont = True
        Me.DetailGRVRo_Master.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.DetailGRVRo_Master.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.DetailGRVRo_Master.GridControl = Me.DetailRo_Master
        Me.DetailGRVRo_Master.GroupRowHeight = 30
        Me.DetailGRVRo_Master.Name = "DetailGRVRo_Master"
        Me.DetailGRVRo_Master.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.DetailGRVRo_Master.OptionsLayout.Columns.AddNewColumns = False
        Me.DetailGRVRo_Master.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.DetailGRVRo_Master.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.DetailGRVRo_Master.OptionsView.ColumnAutoWidth = False
        Me.DetailGRVRo_Master.OptionsView.ShowGroupPanel = False
        Me.DetailGRVRo_Master.RowHeight = 21
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
        'DetailRo_DetailCv
        '
        Me.DetailRo_DetailCv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.DetailRo_DetailCv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DetailRo_DetailCv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailRo_DetailCv.Location = New System.Drawing.Point(0, 0)
        Me.DetailRo_DetailCv.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.DetailRo_DetailCv.MainView = Me.DetailGRVRo_DetailCv
        Me.DetailRo_DetailCv.Name = "DetailRo_DetailCv"
        Me.DetailRo_DetailCv.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit4})
        Me.DetailRo_DetailCv.Size = New System.Drawing.Size(1070, 255)
        Me.DetailRo_DetailCv.TabIndex = 279
        Me.DetailRo_DetailCv.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DetailGRVRo_DetailCv})
        '
        'DetailGRVRo_DetailCv
        '
        Me.DetailGRVRo_DetailCv.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DetailGRVRo_DetailCv.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DetailGRVRo_DetailCv.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.DetailGRVRo_DetailCv.Appearance.SelectedRow.Options.UseBackColor = True
        Me.DetailGRVRo_DetailCv.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.DetailGRVRo_DetailCv.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DetailGRVRo_DetailCv.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.DetailGRVRo_DetailCv.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.DetailGRVRo_DetailCv.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailGRVRo_DetailCv.AppearancePrint.EvenRow.Options.UseFont = True
        Me.DetailGRVRo_DetailCv.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.DetailGRVRo_DetailCv.GridControl = Me.DetailRo_DetailCv
        Me.DetailGRVRo_DetailCv.GroupRowHeight = 30
        Me.DetailGRVRo_DetailCv.Name = "DetailGRVRo_DetailCv"
        Me.DetailGRVRo_DetailCv.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.DetailGRVRo_DetailCv.OptionsLayout.Columns.AddNewColumns = False
        Me.DetailGRVRo_DetailCv.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.DetailGRVRo_DetailCv.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.DetailGRVRo_DetailCv.OptionsView.ColumnAutoWidth = False
        Me.DetailGRVRo_DetailCv.OptionsView.ShowGroupPanel = False
        Me.DetailGRVRo_DetailCv.RowHeight = 21
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'FrmLocTT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1074, 612)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtT_Tien)
        Me.Controls.Add(Me.TxtSo_Lenh_HT)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNgay_Ct2)
        Me.Controls.Add(Me.TxtNgay_Ct1)
        Me.Controls.Add(Me.lblMa_kh)
        Me.Controls.Add(Me.CmdLoc_TT)
        Me.Controls.Add(Me.TxtTen_tk)
        Me.Name = "FrmLocTT"
        Me.Text = "Lọc phiếu thu dịch vụ"
        Me.Controls.SetChildIndex(Me.TxtTen_tk, 0)
        Me.Controls.SetChildIndex(Me.CmdLoc_TT, 0)
        Me.Controls.SetChildIndex(Me.lblMa_kh, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtTk, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Lenh_HT, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Tien, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        CType(Me.TxtTk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DetailRo_Master, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailGRVRo_Master, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailRo_DetailCv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailGRVRo_DetailCv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtT_Tien As ClsTextBox.txtTien_NT
    Friend WithEvents TxtSo_Lenh_HT As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtTk As Cyber.SmLists.TxtLookup
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_Ct2 As ClsTextBox.txtDate
    Friend WithEvents TxtNgay_Ct1 As ClsTextBox.txtDate
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblMa_kh As System.Windows.Forms.Label
    Friend WithEvents CmdLoc_TT As System.Windows.Forms.Button
    Friend WithEvents TxtTen_tk As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DetailRo_Master As DevExpress.XtraGrid.GridControl
    Friend WithEvents DetailGRVRo_Master As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents DetailRo_DetailCv As DevExpress.XtraGrid.GridControl
    Friend WithEvents DetailGRVRo_DetailCv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

End Class
