<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class COPYDL
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(COPYDL))
        Me.ButtDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.PopupMenuMasterGrid = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.CbbLoai_Chuyen = New System.Windows.Forms.ComboBox()
        Me.LabM_Tk = New System.Windows.Forms.Label()
        Me.LabM_Ngay_Ct2 = New System.Windows.Forms.Label()
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.TxtM_Ngay_Ct2 = New ClsTextBox.txtDate1()
        Me.TxtM_Ngay_Ct1 = New ClsTextBox.txtDate1()
        Me.BttLay_Dl = New DevExpress.XtraEditors.SimpleButton()
        Me.CmdRemoveAll = New DevExpress.XtraEditors.SimpleButton()
        Me.CmdSelectAll = New DevExpress.XtraEditors.SimpleButton()
        Me.Master = New DevExpress.XtraGrid.GridControl()
        Me.MasterGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.ChkAll = New System.Windows.Forms.CheckBox()
        Me.TxtTk = New Cyber.SmLists.TxtLookup()
        Me.Txtten_Tk = New System.Windows.Forms.TextBox()
        Me.labTk = New System.Windows.Forms.Label()
        Me.TxtTK1 = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Tk1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmdDelete = New System.Windows.Forms.Button()
        Me.TxtMa_Kh = New Cyber.SmLists.TxtLookup()
        Me.Txtten_Kh = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtSo_HD1 = New System.Windows.Forms.TextBox()
        Me.TxtSo_HD2 = New System.Windows.Forms.TextBox()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Master, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTK1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Kh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 473)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1013, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Image = CType(resources.GetObject("ButtOK.Image"), System.Drawing.Image)
        Me.ButtOK.Location = New System.Drawing.Point(794, 482)
        Me.ButtOK.Size = New System.Drawing.Size(115, 30)
        Me.ButtOK.Text = "&Tạo bút toán"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(915, 483)
        '
        'ButtDelete
        '
        Me.ButtDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtDelete.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtDelete.Appearance.Options.UseForeColor = True
        Me.ButtDelete.Image = CType(resources.GetObject("ButtDelete.Image"), System.Drawing.Image)
        Me.ButtDelete.Location = New System.Drawing.Point(246, 483)
        Me.ButtDelete.Name = "ButtDelete"
        Me.ButtDelete.Size = New System.Drawing.Size(110, 30)
        Me.ButtDelete.TabIndex = 507
        Me.ButtDelete.Tag = "Delete"
        Me.ButtDelete.Text = "&Xóa bút toán"
        Me.ButtDelete.Visible = False
        '
        'PopupMenuMasterGrid
        '
        Me.PopupMenuMasterGrid.Manager = Me.BarManager1
        Me.PopupMenuMasterGrid.Name = "PopupMenuMasterGrid"
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.MaxItemId = 0
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1017, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 537)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1017, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 537)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1017, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 537)
        '
        'CbbLoai_Chuyen
        '
        Me.CbbLoai_Chuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbLoai_Chuyen.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.CbbLoai_Chuyen.FormattingEnabled = True
        Me.CbbLoai_Chuyen.Location = New System.Drawing.Point(91, 1)
        Me.CbbLoai_Chuyen.Name = "CbbLoai_Chuyen"
        Me.CbbLoai_Chuyen.Size = New System.Drawing.Size(700, 21)
        Me.CbbLoai_Chuyen.TabIndex = 512
        '
        'LabM_Tk
        '
        Me.LabM_Tk.AutoSize = True
        Me.LabM_Tk.Location = New System.Drawing.Point(7, 4)
        Me.LabM_Tk.Name = "LabM_Tk"
        Me.LabM_Tk.Size = New System.Drawing.Size(65, 13)
        Me.LabM_Tk.TabIndex = 513
        Me.LabM_Tk.Tag = "Account"
        Me.LabM_Tk.Text = "Loại chuyển"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(214, 28)
        Me.LabM_Ngay_Ct2.Name = "LabM_Ngay_Ct2"
        Me.LabM_Ngay_Ct2.Size = New System.Drawing.Size(53, 13)
        Me.LabM_Ngay_Ct2.TabIndex = 521
        Me.LabM_Ngay_Ct2.Tag = "Date to"
        Me.LabM_Ngay_Ct2.Text = "Đến ngày"
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(5, 28)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(46, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 519
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.isEmpty = True
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(300, 25)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(114, 20)
        Me.TxtM_Ngay_Ct2.TabIndex = 515
        Me.TxtM_Ngay_Ct2.Text = "__/__/____"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(91, 25)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(114, 20)
        Me.TxtM_Ngay_Ct1.TabIndex = 514
        Me.TxtM_Ngay_Ct1.Text = "__/__/____"
        Me.TxtM_Ngay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'BttLay_Dl
        '
        Me.BttLay_Dl.Image = CType(resources.GetObject("BttLay_Dl.Image"), System.Drawing.Image)
        Me.BttLay_Dl.Location = New System.Drawing.Point(797, 1)
        Me.BttLay_Dl.Name = "BttLay_Dl"
        Me.BttLay_Dl.Size = New System.Drawing.Size(115, 30)
        Me.BttLay_Dl.TabIndex = 529
        Me.BttLay_Dl.Text = "Lấy dữ liệu"
        '
        'CmdRemoveAll
        '
        Me.CmdRemoveAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdRemoveAll.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdRemoveAll.Appearance.Options.UseForeColor = True
        Me.CmdRemoveAll.Image = CType(resources.GetObject("CmdRemoveAll.Image"), System.Drawing.Image)
        Me.CmdRemoveAll.Location = New System.Drawing.Point(125, 482)
        Me.CmdRemoveAll.Name = "CmdRemoveAll"
        Me.CmdRemoveAll.Size = New System.Drawing.Size(115, 30)
        Me.CmdRemoveAll.TabIndex = 535
        Me.CmdRemoveAll.Text = "&Không chọn"
        '
        'CmdSelectAll
        '
        Me.CmdSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdSelectAll.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdSelectAll.Appearance.Options.UseForeColor = True
        Me.CmdSelectAll.Image = CType(resources.GetObject("CmdSelectAll.Image"), System.Drawing.Image)
        Me.CmdSelectAll.Location = New System.Drawing.Point(7, 482)
        Me.CmdSelectAll.Name = "CmdSelectAll"
        Me.CmdSelectAll.Size = New System.Drawing.Size(115, 30)
        Me.CmdSelectAll.TabIndex = 534
        Me.CmdSelectAll.Text = "&Chọn"
        '
        'Master
        '
        Me.Master.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Master.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master.Location = New System.Drawing.Point(0, 141)
        Me.Master.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master.MainView = Me.MasterGRV
        Me.Master.Name = "Master"
        Me.Master.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.Master.Size = New System.Drawing.Size(1017, 322)
        Me.Master.TabIndex = 540
        Me.Master.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.MasterGRV})
        '
        'MasterGRV
        '
        Me.MasterGRV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MasterGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.MasterGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.MasterGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.MasterGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.MasterGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MasterGRV.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.MasterGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.MasterGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.MasterGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.MasterGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.MasterGRV.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.MasterGRV.GridControl = Me.Master
        Me.MasterGRV.GroupRowHeight = 30
        Me.MasterGRV.Name = "MasterGRV"
        Me.MasterGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.MasterGRV.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.[False]
        Me.MasterGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.MasterGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.MasterGRV.OptionsSelection.MultiSelect = True
        Me.MasterGRV.OptionsView.ColumnAutoWidth = False
        Me.MasterGRV.OptionsView.ShowAutoFilterRow = True
        Me.MasterGRV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.MasterGRV.OptionsView.ShowGroupPanel = False
        Me.MasterGRV.RowHeight = 21
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
        'ChkAll
        '
        Me.ChkAll.AutoSize = True
        Me.ChkAll.ForeColor = System.Drawing.Color.Red
        Me.ChkAll.Location = New System.Drawing.Point(585, 29)
        Me.ChkAll.Name = "ChkAll"
        Me.ChkAll.Size = New System.Drawing.Size(206, 17)
        Me.ChkAll.TabIndex = 545
        Me.ChkAll.Text = "Tất cả phiếu(Bao gồm phiếu đã Copy)"
        Me.ChkAll.UseVisualStyleBackColor = True
        '
        'TxtTk
        '
        Me.TxtTk._ActilookupPopup = False
        Me.TxtTk.CyberActilookupPopup = True
        Me.TxtTk.Dv_ListDetail = Nothing
        Me.TxtTk.Dv_Master = Nothing
        Me.TxtTk.FilterClient = ""
        Me.TxtTk.FilterSQL = ""
        Me.TxtTk.Location = New System.Drawing.Point(91, 48)
        Me.TxtTk.Name = "TxtTk"
        Me.TxtTk.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTk.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTk.Properties.Appearance.Options.UseFont = True
        Me.TxtTk.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTk.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTk.Size = New System.Drawing.Size(116, 20)
        Me.TxtTk.TabIndex = 551
        Me.TxtTk.Table_Name = ""
        '
        'Txtten_Tk
        '
        Me.Txtten_Tk.BackColor = System.Drawing.Color.White
        Me.Txtten_Tk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Txtten_Tk.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_Tk.Location = New System.Drawing.Point(209, 48)
        Me.Txtten_Tk.Name = "Txtten_Tk"
        Me.Txtten_Tk.ReadOnly = True
        Me.Txtten_Tk.Size = New System.Drawing.Size(319, 20)
        Me.Txtten_Tk.TabIndex = 553
        Me.Txtten_Tk.TabStop = False
        '
        'labTk
        '
        Me.labTk.BackColor = System.Drawing.Color.Transparent
        Me.labTk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.labTk.ForeColor = System.Drawing.Color.Navy
        Me.labTk.Location = New System.Drawing.Point(7, 51)
        Me.labTk.Margin = New System.Windows.Forms.Padding(0)
        Me.labTk.Name = "labTk"
        Me.labTk.Size = New System.Drawing.Size(78, 14)
        Me.labTk.TabIndex = 552
        Me.labTk.Tag = "Debit acc"
        Me.labTk.Text = "TK Nợ"
        '
        'TxtTK1
        '
        Me.TxtTK1._ActilookupPopup = False
        Me.TxtTK1.CyberActilookupPopup = True
        Me.TxtTK1.Dv_ListDetail = Nothing
        Me.TxtTK1.Dv_Master = Nothing
        Me.TxtTK1.FilterClient = ""
        Me.TxtTK1.FilterSQL = ""
        Me.TxtTK1.Location = New System.Drawing.Point(91, 70)
        Me.TxtTK1.Name = "TxtTK1"
        Me.TxtTK1.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTK1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTK1.Properties.Appearance.Options.UseFont = True
        Me.TxtTK1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTK1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTK1.Size = New System.Drawing.Size(116, 20)
        Me.TxtTK1.TabIndex = 558
        Me.TxtTK1.Table_Name = ""
        '
        'TxtTen_Tk1
        '
        Me.TxtTen_Tk1.BackColor = System.Drawing.Color.White
        Me.TxtTen_Tk1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Tk1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Tk1.Location = New System.Drawing.Point(209, 70)
        Me.TxtTen_Tk1.Name = "TxtTen_Tk1"
        Me.TxtTen_Tk1.ReadOnly = True
        Me.TxtTen_Tk1.Size = New System.Drawing.Size(319, 20)
        Me.TxtTen_Tk1.TabIndex = 560
        Me.TxtTen_Tk1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(6, 73)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 14)
        Me.Label1.TabIndex = 559
        Me.Label1.Tag = "Debit acc"
        Me.Label1.Text = "TK Có"
        '
        'CmdDelete
        '
        Me.CmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdDelete.Location = New System.Drawing.Point(662, 482)
        Me.CmdDelete.Name = "CmdDelete"
        Me.CmdDelete.Size = New System.Drawing.Size(127, 31)
        Me.CmdDelete.TabIndex = 565
        Me.CmdDelete.Tag = "&Create Closing"
        Me.CmdDelete.Text = "&Xóa số liệu đã copy"
        Me.CmdDelete.UseVisualStyleBackColor = True
        '
        'TxtMa_Kh
        '
        Me.TxtMa_Kh._ActilookupPopup = False
        Me.TxtMa_Kh.CyberActilookupPopup = True
        Me.TxtMa_Kh.Dv_ListDetail = Nothing
        Me.TxtMa_Kh.Dv_Master = Nothing
        Me.TxtMa_Kh.FilterClient = ""
        Me.TxtMa_Kh.FilterSQL = ""
        Me.TxtMa_Kh.Location = New System.Drawing.Point(91, 92)
        Me.TxtMa_Kh.Name = "TxtMa_Kh"
        Me.TxtMa_Kh.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Kh.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kh.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Kh.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kh.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_Kh.TabIndex = 570
        Me.TxtMa_Kh.Table_Name = ""
        '
        'Txtten_Kh
        '
        Me.Txtten_Kh.BackColor = System.Drawing.Color.White
        Me.Txtten_Kh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Txtten_Kh.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_Kh.Location = New System.Drawing.Point(209, 92)
        Me.Txtten_Kh.Name = "Txtten_Kh"
        Me.Txtten_Kh.ReadOnly = True
        Me.Txtten_Kh.Size = New System.Drawing.Size(319, 20)
        Me.Txtten_Kh.TabIndex = 572
        Me.Txtten_Kh.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(6, 95)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 14)
        Me.Label2.TabIndex = 571
        Me.Label2.Tag = "Debit acc"
        Me.Label2.Text = "Mã khách"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(5, 117)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 14)
        Me.Label3.TabIndex = 578
        Me.Label3.Tag = "Debit acc"
        Me.Label3.Text = "Từ số HĐ"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(327, 116)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 14)
        Me.Label4.TabIndex = 580
        Me.Label4.Tag = "Debit acc"
        Me.Label4.Text = "Đến số HĐ"
        '
        'TxtSo_HD1
        '
        Me.TxtSo_HD1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_HD1.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_HD1.Location = New System.Drawing.Point(91, 114)
        Me.TxtSo_HD1.Name = "TxtSo_HD1"
        Me.TxtSo_HD1.Size = New System.Drawing.Size(116, 20)
        Me.TxtSo_HD1.TabIndex = 581
        '
        'TxtSo_HD2
        '
        Me.TxtSo_HD2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_HD2.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_HD2.Location = New System.Drawing.Point(408, 114)
        Me.TxtSo_HD2.Name = "TxtSo_HD2"
        Me.TxtSo_HD2.Size = New System.Drawing.Size(120, 20)
        Me.TxtSo_HD2.TabIndex = 582
        '
        'COPYDL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1017, 537)
        Me.Controls.Add(Me.TxtSo_HD2)
        Me.Controls.Add(Me.TxtSo_HD1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtMa_Kh)
        Me.Controls.Add(Me.Txtten_Kh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmdDelete)
        Me.Controls.Add(Me.TxtTK1)
        Me.Controls.Add(Me.TxtTen_Tk1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTk)
        Me.Controls.Add(Me.Txtten_Tk)
        Me.Controls.Add(Me.labTk)
        Me.Controls.Add(Me.ChkAll)
        Me.Controls.Add(Me.Master)
        Me.Controls.Add(Me.CmdRemoveAll)
        Me.Controls.Add(Me.CmdSelectAll)
        Me.Controls.Add(Me.BttLay_Dl)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Controls.Add(Me.CbbLoai_Chuyen)
        Me.Controls.Add(Me.LabM_Tk)
        Me.Controls.Add(Me.ButtDelete)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "COPYDL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.ButtDelete, 0)
        Me.Controls.SetChildIndex(Me.LabM_Tk, 0)
        Me.Controls.SetChildIndex(Me.CbbLoai_Chuyen, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.BttLay_Dl, 0)
        Me.Controls.SetChildIndex(Me.CmdSelectAll, 0)
        Me.Controls.SetChildIndex(Me.CmdRemoveAll, 0)
        Me.Controls.SetChildIndex(Me.Master, 0)
        Me.Controls.SetChildIndex(Me.ChkAll, 0)
        Me.Controls.SetChildIndex(Me.labTk, 0)
        Me.Controls.SetChildIndex(Me.Txtten_Tk, 0)
        Me.Controls.SetChildIndex(Me.TxtTk, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Tk1, 0)
        Me.Controls.SetChildIndex(Me.TxtTK1, 0)
        Me.Controls.SetChildIndex(Me.CmdDelete, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Txtten_Kh, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kh, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_HD1, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_HD2, 0)
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Master, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTK1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Kh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PopupMenuMasterGrid As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents CbbLoai_Chuyen As System.Windows.Forms.ComboBox
    Friend WithEvents LabM_Tk As System.Windows.Forms.Label
    Friend WithEvents BttLay_Dl As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CmdRemoveAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CmdSelectAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Master As DevExpress.XtraGrid.GridControl
    Friend WithEvents MasterGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ChkAll As System.Windows.Forms.CheckBox
    Friend WithEvents TxtTk As Cyber.SmLists.TxtLookup
    Friend WithEvents Txtten_Tk As System.Windows.Forms.TextBox
    Friend WithEvents labTk As System.Windows.Forms.Label
    Friend WithEvents TxtTK1 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Tk1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmdDelete As System.Windows.Forms.Button
    Friend WithEvents TxtMa_Kh As Cyber.SmLists.TxtLookup
    Friend WithEvents Txtten_Kh As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtSo_HD2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtSo_HD1 As System.Windows.Forms.TextBox

End Class
