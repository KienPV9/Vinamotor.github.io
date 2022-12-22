<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPhanQuyen
    Inherits Cyber.From.FrmCalculator

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPhanQuyen))
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Detail2 = New DevExpress.XtraGrid.GridControl()
        Me.DetailGRV2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.detail1 = New DevExpress.XtraGrid.GridControl()
        Me.DetailGRV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TxtNgay_Ct2 = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNgay_Ct1 = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Detail3 = New DevExpress.XtraGrid.GridControl()
        Me.DetailGRV3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Detail4 = New DevExpress.XtraGrid.GridControl()
        Me.DetailGRV4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CmdSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.PopupMenuMasterGrid = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtComment = New System.Windows.Forms.TextBox()
        Me.TxtUser = New Cyber.SmLists.TxtLookup()
        Me.TxtGroup_Old = New Cyber.SmLists.TxtLookup()
        Me.txtTen_Group_Old = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGroup_New = New System.Windows.Forms.TextBox()
        Me.TxtTen_Group_New = New System.Windows.Forms.TextBox()
        Me.CmdCopy = New DevExpress.XtraEditors.SimpleButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.Detail2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailGRV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.detail1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailGRV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.Detail3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailGRV3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.Detail4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailGRV4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtGroup_Old.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 497)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1186, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(976, 393)
        Me.ButtOK.TabIndex = 9
        Me.ButtOK.Visible = False
        '
        'ButtExit
        '
        Me.ButtExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtExit.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseFont = True
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(795, 55)
        Me.ButtExit.Size = New System.Drawing.Size(137, 39)
        Me.ButtExit.TabIndex = 9
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'GridView2
        '
        Me.GridView2.Name = "GridView2"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Detail2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1184, 375)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Chỉnh sửa phiếu"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Detail2
        '
        Me.Detail2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Detail2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Detail2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detail2.Location = New System.Drawing.Point(3, 3)
        Me.Detail2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Detail2.MainView = Me.DetailGRV2
        Me.Detail2.Name = "Detail2"
        Me.Detail2.Size = New System.Drawing.Size(1178, 369)
        Me.Detail2.TabIndex = 10
        Me.Detail2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DetailGRV2, Me.GridView3})
        '
        'DetailGRV2
        '
        Me.DetailGRV2.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Black
        Me.DetailGRV2.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.DetailGRV2.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DetailGRV2.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Black
        Me.DetailGRV2.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DetailGRV2.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.DetailGRV2.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.DetailGRV2.Appearance.SelectedRow.Options.UseBackColor = True
        Me.DetailGRV2.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.DetailGRV2.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.DetailGRV2.Appearance.ViewCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Hide
        Me.DetailGRV2.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.DetailGRV2.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailGRV2.AppearancePrint.EvenRow.Options.UseFont = True
        Me.DetailGRV2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.DetailGRV2.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.DetailGRV2.GridControl = Me.Detail2
        Me.DetailGRV2.GroupRowHeight = 30
        Me.DetailGRV2.Name = "DetailGRV2"
        Me.DetailGRV2.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.DetailGRV2.OptionsLayout.Columns.AddNewColumns = False
        Me.DetailGRV2.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.DetailGRV2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.DetailGRV2.OptionsView.ColumnAutoWidth = False
        Me.DetailGRV2.OptionsView.ShowGroupPanel = False
        Me.DetailGRV2.OptionsView.ShowViewCaption = True
        Me.DetailGRV2.RowHeight = 21
        Me.DetailGRV2.ViewCaption = " "
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.Detail2
        Me.GridView3.Name = "GridView3"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.detail1)
        Me.TabPage1.Controls.Add(Me.TxtNgay_Ct2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.TxtNgay_Ct1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1184, 375)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Truy cập menu"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'detail1
        '
        Me.detail1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.detail1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.detail1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detail1.Location = New System.Drawing.Point(3, 3)
        Me.detail1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.detail1.MainView = Me.DetailGRV1
        Me.detail1.Name = "detail1"
        Me.detail1.Size = New System.Drawing.Size(1178, 369)
        Me.detail1.TabIndex = 0
        Me.detail1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DetailGRV1, Me.GridView4})
        '
        'DetailGRV1
        '
        Me.DetailGRV1.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Black
        Me.DetailGRV1.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.DetailGRV1.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DetailGRV1.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Black
        Me.DetailGRV1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DetailGRV1.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.DetailGRV1.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.DetailGRV1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.DetailGRV1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.DetailGRV1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.DetailGRV1.Appearance.ViewCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Hide
        Me.DetailGRV1.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.DetailGRV1.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailGRV1.AppearancePrint.EvenRow.Options.UseFont = True
        Me.DetailGRV1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.DetailGRV1.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.DetailGRV1.GridControl = Me.detail1
        Me.DetailGRV1.GroupRowHeight = 30
        Me.DetailGRV1.Name = "DetailGRV1"
        Me.DetailGRV1.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.DetailGRV1.OptionsLayout.Columns.AddNewColumns = False
        Me.DetailGRV1.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.DetailGRV1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.DetailGRV1.OptionsView.ColumnAutoWidth = False
        Me.DetailGRV1.OptionsView.ShowGroupPanel = False
        Me.DetailGRV1.OptionsView.ShowViewCaption = True
        Me.DetailGRV1.RowHeight = 21
        Me.DetailGRV1.ViewCaption = " "
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.detail1
        Me.GridView4.Name = "GridView4"
        '
        'TxtNgay_Ct2
        '
        Me.TxtNgay_Ct2.Flags = 0
        Me.TxtNgay_Ct2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_Ct2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNgay_Ct2.IsAllowResize = False
        Me.TxtNgay_Ct2.Location = New System.Drawing.Point(284, 49)
        Me.TxtNgay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_Ct2.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_Ct2.MaxLength = 10
        Me.TxtNgay_Ct2.Name = "TxtNgay_Ct2"
        Me.TxtNgay_Ct2.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_Ct2.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Ct2.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct2.Size = New System.Drawing.Size(124, 21)
        Me.TxtNgay_Ct2.TabIndex = 3
        Me.TxtNgay_Ct2.Value = "09/08/2022 15:59"
        Me.TxtNgay_Ct2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Thời gian từ"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(234, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "đến"
        Me.Label2.Visible = False
        '
        'TxtNgay_Ct1
        '
        Me.TxtNgay_Ct1.Flags = 0
        Me.TxtNgay_Ct1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_Ct1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNgay_Ct1.IsAllowResize = False
        Me.TxtNgay_Ct1.Location = New System.Drawing.Point(74, 49)
        Me.TxtNgay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_Ct1.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_Ct1.MaxLength = 10
        Me.TxtNgay_Ct1.Name = "TxtNgay_Ct1"
        Me.TxtNgay_Ct1.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_Ct1.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Ct1.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct1.Size = New System.Drawing.Size(124, 21)
        Me.TxtNgay_Ct1.TabIndex = 1
        Me.TxtNgay_Ct1.Value = "09/08/2022 15:59"
        Me.TxtNgay_Ct1.Visible = False
        '
        'TabControl3
        '
        Me.TabControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl3.Controls.Add(Me.TabPage1)
        Me.TabControl3.Controls.Add(Me.TabPage2)
        Me.TabControl3.Controls.Add(Me.TabPage3)
        Me.TabControl3.Controls.Add(Me.TabPage4)
        Me.TabControl3.Location = New System.Drawing.Point(-1, 103)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(1192, 401)
        Me.TabControl3.TabIndex = 10
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Detail3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1184, 375)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Chỉnh sửa danh mục"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Detail3
        '
        Me.Detail3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Detail3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Detail3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detail3.Location = New System.Drawing.Point(0, 0)
        Me.Detail3.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Detail3.MainView = Me.DetailGRV3
        Me.Detail3.Name = "Detail3"
        Me.Detail3.Size = New System.Drawing.Size(1184, 375)
        Me.Detail3.TabIndex = 11
        Me.Detail3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DetailGRV3, Me.GridView8})
        '
        'DetailGRV3
        '
        Me.DetailGRV3.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Black
        Me.DetailGRV3.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.DetailGRV3.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DetailGRV3.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Black
        Me.DetailGRV3.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DetailGRV3.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.DetailGRV3.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.DetailGRV3.Appearance.SelectedRow.Options.UseBackColor = True
        Me.DetailGRV3.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.DetailGRV3.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.DetailGRV3.Appearance.ViewCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Hide
        Me.DetailGRV3.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.DetailGRV3.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailGRV3.AppearancePrint.EvenRow.Options.UseFont = True
        Me.DetailGRV3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.DetailGRV3.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.DetailGRV3.GridControl = Me.Detail3
        Me.DetailGRV3.GroupRowHeight = 30
        Me.DetailGRV3.Name = "DetailGRV3"
        Me.DetailGRV3.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.DetailGRV3.OptionsLayout.Columns.AddNewColumns = False
        Me.DetailGRV3.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.DetailGRV3.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.DetailGRV3.OptionsView.ColumnAutoWidth = False
        Me.DetailGRV3.OptionsView.ShowGroupPanel = False
        Me.DetailGRV3.OptionsView.ShowViewCaption = True
        Me.DetailGRV3.RowHeight = 21
        Me.DetailGRV3.ViewCaption = " "
        '
        'GridView8
        '
        Me.GridView8.GridControl = Me.Detail3
        Me.GridView8.Name = "GridView8"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Detail4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1184, 375)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Danh sách nhóm quyền"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Detail4
        '
        Me.Detail4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Detail4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Detail4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detail4.Location = New System.Drawing.Point(0, 0)
        Me.Detail4.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Detail4.MainView = Me.DetailGRV4
        Me.Detail4.Name = "Detail4"
        Me.Detail4.Size = New System.Drawing.Size(1184, 375)
        Me.Detail4.TabIndex = 11
        Me.Detail4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DetailGRV4, Me.GridView6})
        '
        'DetailGRV4
        '
        Me.DetailGRV4.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Black
        Me.DetailGRV4.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.DetailGRV4.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DetailGRV4.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Black
        Me.DetailGRV4.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DetailGRV4.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.DetailGRV4.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.DetailGRV4.Appearance.SelectedRow.Options.UseBackColor = True
        Me.DetailGRV4.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.DetailGRV4.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.DetailGRV4.Appearance.ViewCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Hide
        Me.DetailGRV4.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.DetailGRV4.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailGRV4.AppearancePrint.EvenRow.Options.UseFont = True
        Me.DetailGRV4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.DetailGRV4.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.DetailGRV4.GridControl = Me.Detail4
        Me.DetailGRV4.GroupRowHeight = 30
        Me.DetailGRV4.Name = "DetailGRV4"
        Me.DetailGRV4.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.DetailGRV4.OptionsLayout.Columns.AddNewColumns = False
        Me.DetailGRV4.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.DetailGRV4.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.DetailGRV4.OptionsView.ColumnAutoWidth = False
        Me.DetailGRV4.OptionsView.ShowGroupPanel = False
        Me.DetailGRV4.OptionsView.ShowViewCaption = True
        Me.DetailGRV4.RowHeight = 21
        Me.DetailGRV4.ViewCaption = " "
        '
        'GridView6
        '
        Me.GridView6.GridControl = Me.Detail4
        Me.GridView6.Name = "GridView6"
        '
        'CmdSearch
        '
        Me.CmdSearch.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSearch.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdSearch.Appearance.Options.UseFont = True
        Me.CmdSearch.Appearance.Options.UseForeColor = True
        Me.CmdSearch.Image = CType(resources.GetObject("CmdSearch.Image"), System.Drawing.Image)
        Me.CmdSearch.Location = New System.Drawing.Point(501, 56)
        Me.CmdSearch.Name = "CmdSearch"
        Me.CmdSearch.Size = New System.Drawing.Size(124, 40)
        Me.CmdSearch.TabIndex = 8
        Me.CmdSearch.Text = "Tra cứu"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(1190, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 529)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1190, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 529)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1190, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 529)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(432, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Tài khoản"
        '
        'TxtComment
        '
        Me.TxtComment.BackColor = System.Drawing.Color.White
        Me.TxtComment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtComment.ForeColor = System.Drawing.Color.Navy
        Me.TxtComment.Location = New System.Drawing.Point(628, 29)
        Me.TxtComment.Name = "TxtComment"
        Me.TxtComment.ReadOnly = True
        Me.TxtComment.Size = New System.Drawing.Size(304, 20)
        Me.TxtComment.TabIndex = 6
        Me.TxtComment.TabStop = False
        '
        'TxtUser
        '
        Me.TxtUser._ActilookupPopup = False
        Me.TxtUser.CyberActilookupPopup = True
        Me.TxtUser.Dv_ListDetail = Nothing
        Me.TxtUser.Dv_Master = Nothing
        Me.TxtUser.FilterClient = ""
        Me.TxtUser.FilterSQL = ""
        Me.TxtUser.Location = New System.Drawing.Point(501, 29)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtUser.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtUser.Properties.Appearance.Options.UseFont = True
        Me.TxtUser.Properties.Appearance.Options.UseForeColor = True
        Me.TxtUser.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtUser.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtUser.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtUser.Size = New System.Drawing.Size(124, 20)
        Me.TxtUser.TabIndex = 5
        Me.TxtUser.Table_Name = ""
        '
        'TxtGroup_Old
        '
        Me.TxtGroup_Old._ActilookupPopup = False
        Me.TxtGroup_Old.CyberActilookupPopup = True
        Me.TxtGroup_Old.Dv_ListDetail = Nothing
        Me.TxtGroup_Old.Dv_Master = Nothing
        Me.TxtGroup_Old.FilterClient = ""
        Me.TxtGroup_Old.FilterSQL = ""
        Me.TxtGroup_Old.Location = New System.Drawing.Point(77, 27)
        Me.TxtGroup_Old.Name = "TxtGroup_Old"
        Me.TxtGroup_Old.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtGroup_Old.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtGroup_Old.Properties.Appearance.Options.UseFont = True
        Me.TxtGroup_Old.Properties.Appearance.Options.UseForeColor = True
        Me.TxtGroup_Old.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtGroup_Old.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtGroup_Old.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtGroup_Old.Size = New System.Drawing.Size(124, 20)
        Me.TxtGroup_Old.TabIndex = 0
        Me.TxtGroup_Old.Table_Name = ""
        '
        'txtTen_Group_Old
        '
        Me.txtTen_Group_Old.BackColor = System.Drawing.Color.White
        Me.txtTen_Group_Old.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtTen_Group_Old.ForeColor = System.Drawing.Color.Navy
        Me.txtTen_Group_Old.Location = New System.Drawing.Point(204, 27)
        Me.txtTen_Group_Old.Name = "txtTen_Group_Old"
        Me.txtTen_Group_Old.ReadOnly = True
        Me.txtTen_Group_Old.Size = New System.Drawing.Size(207, 20)
        Me.txtTen_Group_Old.TabIndex = 1
        Me.txtTen_Group_Old.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Nhóm cũ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Nhóm mới"
        '
        'txtGroup_New
        '
        Me.txtGroup_New.Location = New System.Drawing.Point(77, 51)
        Me.txtGroup_New.Name = "txtGroup_New"
        Me.txtGroup_New.Size = New System.Drawing.Size(124, 20)
        Me.txtGroup_New.TabIndex = 2
        '
        'TxtTen_Group_New
        '
        Me.TxtTen_Group_New.Location = New System.Drawing.Point(204, 51)
        Me.TxtTen_Group_New.Name = "TxtTen_Group_New"
        Me.TxtTen_Group_New.Size = New System.Drawing.Size(207, 20)
        Me.TxtTen_Group_New.TabIndex = 3
        '
        'CmdCopy
        '
        Me.CmdCopy.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCopy.Appearance.ForeColor = System.Drawing.Color.Red
        Me.CmdCopy.Appearance.Options.UseFont = True
        Me.CmdCopy.Appearance.Options.UseForeColor = True
        Me.CmdCopy.Image = CType(resources.GetObject("CmdCopy.Image"), System.Drawing.Image)
        Me.CmdCopy.Location = New System.Drawing.Point(632, 56)
        Me.CmdCopy.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdCopy.Name = "CmdCopy"
        Me.CmdCopy.Size = New System.Drawing.Size(156, 39)
        Me.CmdCopy.TabIndex = 2205
        Me.CmdCopy.Text = "&Copy phân quyền"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(578, 6)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(229, 15)
        Me.Label6.TabIndex = 2206
        Me.Label6.Tag = "Date to"
        Me.Label6.Text = "Tra cứu quyền theo User nhân viên"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(55, 6)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(385, 15)
        Me.Label5.TabIndex = 2207
        Me.Label5.Tag = "Date to"
        Me.Label5.Text = "Tra cứu phân quyền theo nhóm / Copy quyền cho nhóm mới"
        '
        'FrmPhanQuyen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1190, 529)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CmdCopy)
        Me.Controls.Add(Me.TxtTen_Group_New)
        Me.Controls.Add(Me.txtGroup_New)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtGroup_Old)
        Me.Controls.Add(Me.txtTen_Group_Old)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtUser)
        Me.Controls.Add(Me.TxtComment)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CmdSearch)
        Me.Controls.Add(Me.TabControl3)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "FrmPhanQuyen"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.TabControl3, 0)
        Me.Controls.SetChildIndex(Me.CmdSearch, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.TxtComment, 0)
        Me.Controls.SetChildIndex(Me.TxtUser, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.txtTen_Group_Old, 0)
        Me.Controls.SetChildIndex(Me.TxtGroup_Old, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.txtGroup_New, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Group_New, 0)
        Me.Controls.SetChildIndex(Me.CmdCopy, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Detail2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailGRV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.detail1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailGRV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.Detail3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailGRV3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.Detail4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailGRV4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtGroup_Old.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabPage2 As Windows.Forms.TabPage
    Friend WithEvents Detail2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents DetailGRV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabPage1 As Windows.Forms.TabPage
    Friend WithEvents detail1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents DetailGRV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabControl3 As Windows.Forms.TabControl
    Friend WithEvents CmdSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PopupMenuMasterGrid As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents TabPage3 As Windows.Forms.TabPage
    Friend WithEvents TabPage4 As Windows.Forms.TabPage
    Friend WithEvents Detail3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents DetailGRV3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Detail4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents DetailGRV4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents TxtComment As Windows.Forms.TextBox
    Friend WithEvents TxtUser As SmLists.TxtLookup
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents TxtNgay_Ct2 As ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents TxtNgay_Ct1 As ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents TxtGroup_Old As SmLists.TxtLookup
    Friend WithEvents txtTen_Group_Old As Windows.Forms.TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents TxtTen_Group_New As Windows.Forms.TextBox
    Friend WithEvents txtGroup_New As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents CmdCopy As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
End Class
