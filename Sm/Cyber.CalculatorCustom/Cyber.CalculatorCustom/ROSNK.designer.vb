﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ROSNK
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ROSNK))
        Me.LabLenh_RO = New System.Windows.Forms.Label()
        Me.TxtSo_Ro = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txtngay_HD = New ClsTextBox.txtDate1()
        Me.CmdUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtSo_Hd = New System.Windows.Forms.TextBox()
        Me.LabT_TT_NT = New System.Windows.Forms.Label()
        Me.TxtT_TT = New ClsTextBox.txtTien_NT()
        Me.PopupMenuMasterGrid = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.PopupMenuChoGRV = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.CmDanh_Sach = New System.Windows.Forms.Button()
        Me.Detail1 = New DevExpress.XtraGrid.GridControl()
        Me.DetailGRV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DetailGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Detail = New DevExpress.XtraGrid.GridControl()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Chkis_Hd = New System.Windows.Forms.CheckBox()
        Me.Txtngay_ct2 = New ClsTextBox.txtDate1()
        Me.Txtngay_ct1 = New ClsTextBox.txtDate1()
        Me.TxtMa_KH = New Cyber.SmLists.TxtLookup()
        Me.lblMa_kh = New System.Windows.Forms.Label()
        Me.TxtTen_KH = New System.Windows.Forms.TextBox()
        Me.CmdOK = New DevExpress.XtraEditors.SimpleButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtSo_NK = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer_Data = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuChoGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detail1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailGRV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.TxtMa_KH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 498)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1483, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(1283, 502)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtOK.TabIndex = 10
        Me.ButtOK.Tag = "&OK"
        Me.ButtOK.Text = "&Chấp nhận"
        Me.ButtOK.Visible = False
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(1385, 502)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtExit.TabIndex = 11
        Me.ButtExit.Visible = False
        '
        'LabLenh_RO
        '
        Me.LabLenh_RO.AutoSize = True
        Me.LabLenh_RO.BackColor = System.Drawing.Color.Transparent
        Me.LabLenh_RO.Font = New System.Drawing.Font("Tahoma", 10.25!, System.Drawing.FontStyle.Bold)
        Me.LabLenh_RO.ForeColor = System.Drawing.Color.Navy
        Me.LabLenh_RO.Location = New System.Drawing.Point(8, 32)
        Me.LabLenh_RO.Name = "LabLenh_RO"
        Me.LabLenh_RO.Size = New System.Drawing.Size(102, 17)
        Me.LabLenh_RO.TabIndex = 1804
        Me.LabLenh_RO.Tag = "R/O"
        Me.LabLenh_RO.Text = "Nhà cung cấp"
        '
        'TxtSo_Ro
        '
        Me.TxtSo_Ro.BackColor = System.Drawing.Color.White
        Me.TxtSo_Ro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_Ro.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.TxtSo_Ro.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Ro.Location = New System.Drawing.Point(108, 28)
        Me.TxtSo_Ro.Name = "TxtSo_Ro"
        Me.TxtSo_Ro.Size = New System.Drawing.Size(411, 26)
        Me.TxtSo_Ro.TabIndex = 2
        Me.TxtSo_Ro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Txtngay_HD)
        Me.GroupBox1.Controls.Add(Me.CmdUpdate)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TxtSo_Hd)
        Me.GroupBox1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox1.Location = New System.Drawing.Point(556, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(385, 150)
        Me.GroupBox1.TabIndex = 1807
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = "RO info"
        '
        'Txtngay_HD
        '
        Me.Txtngay_HD.Flags = 0
        Me.Txtngay_HD.ForeColor = System.Drawing.Color.Navy
        Me.Txtngay_HD.IsAllowResize = False
        Me.Txtngay_HD.isEmpty = True
        Me.Txtngay_HD.Location = New System.Drawing.Point(139, 79)
        Me.Txtngay_HD.Margin = New System.Windows.Forms.Padding(0)
        Me.Txtngay_HD.MaskDate = "dd/MM/yyyy"
        Me.Txtngay_HD.MaxLength = 10
        Me.Txtngay_HD.Name = "Txtngay_HD"
        Me.Txtngay_HD.RangeMax = New Date(CType(0, Long))
        Me.Txtngay_HD.RangeMin = New Date(CType(0, Long))
        Me.Txtngay_HD.ShowDayBeforeMonth = False
        Me.Txtngay_HD.Size = New System.Drawing.Size(156, 20)
        Me.Txtngay_HD.TabIndex = 2206
        Me.Txtngay_HD.Text = "__/__/____"
        Me.Txtngay_HD.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'CmdUpdate
        '
        Me.CmdUpdate.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!, System.Drawing.FontStyle.Bold)
        Me.CmdUpdate.Appearance.ForeColor = System.Drawing.Color.Red
        Me.CmdUpdate.Appearance.Options.UseFont = True
        Me.CmdUpdate.Appearance.Options.UseForeColor = True
        Me.CmdUpdate.Image = CType(resources.GetObject("CmdUpdate.Image"), System.Drawing.Image)
        Me.CmdUpdate.Location = New System.Drawing.Point(139, 105)
        Me.CmdUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdUpdate.Name = "CmdUpdate"
        Me.CmdUpdate.Size = New System.Drawing.Size(156, 36)
        Me.CmdUpdate.TabIndex = 2204
        Me.CmdUpdate.Text = "&Cập Nhật"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(53, 84)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 2205
        Me.Label5.Tag = "Date to"
        Me.Label5.Text = "Ngày Hóa Đơn"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(149, 16)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 15)
        Me.Label4.TabIndex = 2204
        Me.Label4.Tag = "Date to"
        Me.Label4.Text = "Thông tin cập nhật"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(53, 60)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 1779
        Me.Label10.Tag = "Address"
        Me.Label10.Text = "Số Hóa Đơn"
        '
        'TxtSo_Hd
        '
        Me.TxtSo_Hd.BackColor = System.Drawing.Color.White
        Me.TxtSo_Hd.ForeColor = System.Drawing.Color.Blue
        Me.TxtSo_Hd.Location = New System.Drawing.Point(139, 56)
        Me.TxtSo_Hd.Name = "TxtSo_Hd"
        Me.TxtSo_Hd.Size = New System.Drawing.Size(156, 20)
        Me.TxtSo_Hd.TabIndex = 5
        '
        'LabT_TT_NT
        '
        Me.LabT_TT_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabT_TT_NT.BackColor = System.Drawing.Color.Transparent
        Me.LabT_TT_NT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabT_TT_NT.ForeColor = System.Drawing.Color.Navy
        Me.LabT_TT_NT.Location = New System.Drawing.Point(1290, 508)
        Me.LabT_TT_NT.Margin = New System.Windows.Forms.Padding(0)
        Me.LabT_TT_NT.Name = "LabT_TT_NT"
        Me.LabT_TT_NT.Size = New System.Drawing.Size(68, 17)
        Me.LabT_TT_NT.TabIndex = 1811
        Me.LabT_TT_NT.Tag = "Total All"
        Me.LabT_TT_NT.Text = "Tổng cộng"
        '
        'TxtT_TT
        '
        Me.TxtT_TT.AllowNegative = True
        Me.TxtT_TT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtT_TT.BackColor = System.Drawing.Color.White
        Me.TxtT_TT.Flags = 7680
        Me.TxtT_TT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtT_TT.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_TT.InputMask = "### ### ### ### ###.#"
        Me.TxtT_TT.Location = New System.Drawing.Point(1363, 506)
        Me.TxtT_TT.MaxWholeDigits = 16
        Me.TxtT_TT.Name = "TxtT_TT"
        Me.TxtT_TT.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_TT.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_TT.ReadOnly = True
        Me.TxtT_TT.Size = New System.Drawing.Size(119, 20)
        Me.TxtT_TT.TabIndex = 1810
        Me.TxtT_TT.TabStop = False
        Me.TxtT_TT.Text = "1.0"
        Me.TxtT_TT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.barDockControlTop.Size = New System.Drawing.Size(1252, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 556)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1252, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 556)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1252, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 556)
        '
        'PopupMenuChoGRV
        '
        Me.PopupMenuChoGRV.Manager = Me.BarManager1
        Me.PopupMenuChoGRV.Name = "PopupMenuChoGRV"
        '
        'CmDanh_Sach
        '
        Me.CmDanh_Sach.Location = New System.Drawing.Point(87, 29)
        Me.CmDanh_Sach.Name = "CmDanh_Sach"
        Me.CmDanh_Sach.Size = New System.Drawing.Size(183, 47)
        Me.CmDanh_Sach.TabIndex = 3
        Me.CmDanh_Sach.Tag = "List RO has not exported out of stock"
        Me.CmDanh_Sach.Text = "Danh sách nhà cung cấp"
        Me.CmDanh_Sach.UseVisualStyleBackColor = True
        Me.CmDanh_Sach.Visible = False
        '
        'Detail1
        '
        Me.Detail1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Detail1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Detail1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detail1.Location = New System.Drawing.Point(3, 1)
        Me.Detail1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Detail1.MainView = Me.DetailGRV1
        Me.Detail1.Name = "Detail1"
        Me.Detail1.Size = New System.Drawing.Size(289, 474)
        Me.Detail1.TabIndex = 7125
        Me.Detail1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DetailGRV1})
        '
        'DetailGRV1
        '
        Me.DetailGRV1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DetailGRV1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DetailGRV1.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.DetailGRV1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.DetailGRV1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.DetailGRV1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DetailGRV1.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.DetailGRV1.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.DetailGRV1.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailGRV1.AppearancePrint.EvenRow.Options.UseFont = True
        Me.DetailGRV1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.DetailGRV1.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.DetailGRV1.GridControl = Me.Detail1
        Me.DetailGRV1.GroupRowHeight = 30
        Me.DetailGRV1.Name = "DetailGRV1"
        Me.DetailGRV1.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.DetailGRV1.OptionsLayout.Columns.AddNewColumns = False
        Me.DetailGRV1.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.DetailGRV1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.DetailGRV1.OptionsView.ColumnAutoWidth = False
        Me.DetailGRV1.OptionsView.ShowGroupPanel = False
        Me.DetailGRV1.RowHeight = 21
        '
        'DetailGRV
        '
        Me.DetailGRV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DetailGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DetailGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.DetailGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.DetailGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.DetailGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DetailGRV.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.DetailGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.DetailGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.DetailGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.DetailGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.DetailGRV.GridControl = Me.Detail
        Me.DetailGRV.GroupRowHeight = 30
        Me.DetailGRV.Name = "DetailGRV"
        Me.DetailGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.DetailGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.DetailGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.DetailGRV.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.DetailGRV.OptionsView.ColumnAutoWidth = False
        Me.DetailGRV.OptionsView.ShowGroupPanel = False
        Me.DetailGRV.RowHeight = 21
        '
        'Detail
        '
        Me.Detail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Detail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Detail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detail.Location = New System.Drawing.Point(3, 159)
        Me.Detail.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Detail.MainView = Me.DetailGRV
        Me.Detail.Name = "Detail"
        Me.Detail.Size = New System.Drawing.Size(938, 316)
        Me.Detail.TabIndex = 1817
        Me.Detail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DetailGRV})
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(9, 9)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Chkis_Hd)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Txtngay_ct2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Txtngay_ct1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtMa_KH)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblMa_kh)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtTen_KH)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CmdOK)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtSo_NK)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Detail)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtSo_Ro)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabLenh_RO)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Detail1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CmDanh_Sach)
        Me.SplitContainer1.Size = New System.Drawing.Size(1243, 497)
        Me.SplitContainer1.SplitterDistance = 944
        Me.SplitContainer1.TabIndex = 7130
        '
        'Chkis_Hd
        '
        Me.Chkis_Hd.AutoSize = True
        Me.Chkis_Hd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chkis_Hd.ForeColor = System.Drawing.Color.Red
        Me.Chkis_Hd.Location = New System.Drawing.Point(239, 108)
        Me.Chkis_Hd.Name = "Chkis_Hd"
        Me.Chkis_Hd.Size = New System.Drawing.Size(146, 17)
        Me.Chkis_Hd.TabIndex = 2209
        Me.Chkis_Hd.Tag = "Group 1 "
        Me.Chkis_Hd.Text = "Có thông tin hóa đơn"
        Me.Chkis_Hd.UseVisualStyleBackColor = True
        '
        'Txtngay_ct2
        '
        Me.Txtngay_ct2.Flags = 0
        Me.Txtngay_ct2.ForeColor = System.Drawing.Color.Navy
        Me.Txtngay_ct2.IsAllowResize = False
        Me.Txtngay_ct2.isEmpty = True
        Me.Txtngay_ct2.Location = New System.Drawing.Point(393, 56)
        Me.Txtngay_ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.Txtngay_ct2.MaskDate = "dd/MM/yyyy"
        Me.Txtngay_ct2.MaxLength = 10
        Me.Txtngay_ct2.Name = "Txtngay_ct2"
        Me.Txtngay_ct2.RangeMax = New Date(CType(0, Long))
        Me.Txtngay_ct2.RangeMin = New Date(CType(0, Long))
        Me.Txtngay_ct2.ShowDayBeforeMonth = False
        Me.Txtngay_ct2.Size = New System.Drawing.Size(126, 20)
        Me.Txtngay_ct2.TabIndex = 2208
        Me.Txtngay_ct2.Text = "__/__/____"
        Me.Txtngay_ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Txtngay_ct1
        '
        Me.Txtngay_ct1.Flags = 0
        Me.Txtngay_ct1.ForeColor = System.Drawing.Color.Navy
        Me.Txtngay_ct1.IsAllowResize = False
        Me.Txtngay_ct1.isEmpty = True
        Me.Txtngay_ct1.Location = New System.Drawing.Point(108, 56)
        Me.Txtngay_ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.Txtngay_ct1.MaskDate = "dd/MM/yyyy"
        Me.Txtngay_ct1.MaxLength = 10
        Me.Txtngay_ct1.Name = "Txtngay_ct1"
        Me.Txtngay_ct1.RangeMax = New Date(CType(0, Long))
        Me.Txtngay_ct1.RangeMin = New Date(CType(0, Long))
        Me.Txtngay_ct1.ShowDayBeforeMonth = False
        Me.Txtngay_ct1.Size = New System.Drawing.Size(126, 20)
        Me.Txtngay_ct1.TabIndex = 2207
        Me.Txtngay_ct1.Text = "__/__/____"
        Me.Txtngay_ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtMa_KH
        '
        Me.TxtMa_KH._ActilookupPopup = False
        Me.TxtMa_KH.CyberActilookupPopup = True
        Me.TxtMa_KH.Dv_ListDetail = Nothing
        Me.TxtMa_KH.Dv_Master = Nothing
        Me.TxtMa_KH.FilterClient = ""
        Me.TxtMa_KH.FilterSQL = ""
        Me.TxtMa_KH.Location = New System.Drawing.Point(108, 79)
        Me.TxtMa_KH.Name = "TxtMa_KH"
        Me.TxtMa_KH.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_KH.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_KH.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_KH.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_KH.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TxtMa_KH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_KH.Size = New System.Drawing.Size(125, 22)
        Me.TxtMa_KH.TabIndex = 2201
        Me.TxtMa_KH.Table_Name = ""
        '
        'lblMa_kh
        '
        Me.lblMa_kh.AutoSize = True
        Me.lblMa_kh.ForeColor = System.Drawing.Color.Navy
        Me.lblMa_kh.Location = New System.Drawing.Point(8, 86)
        Me.lblMa_kh.Margin = New System.Windows.Forms.Padding(0)
        Me.lblMa_kh.Name = "lblMa_kh"
        Me.lblMa_kh.Size = New System.Drawing.Size(75, 13)
        Me.lblMa_kh.TabIndex = 2203
        Me.lblMa_kh.Tag = "Customer"
        Me.lblMa_kh.Text = "Nhà cung cấp"
        '
        'TxtTen_KH
        '
        Me.TxtTen_KH.BackColor = System.Drawing.Color.White
        Me.TxtTen_KH.Enabled = False
        Me.TxtTen_KH.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_KH.Location = New System.Drawing.Point(239, 80)
        Me.TxtTen_KH.Name = "TxtTen_KH"
        Me.TxtTen_KH.ReadOnly = True
        Me.TxtTen_KH.Size = New System.Drawing.Size(280, 20)
        Me.TxtTen_KH.TabIndex = 2202
        Me.TxtTen_KH.Tag = ""
        '
        'CmdOK
        '
        Me.CmdOK.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!, System.Drawing.FontStyle.Bold)
        Me.CmdOK.Appearance.ForeColor = System.Drawing.Color.Red
        Me.CmdOK.Appearance.Options.UseFont = True
        Me.CmdOK.Appearance.Options.UseForeColor = True
        Me.CmdOK.Image = CType(resources.GetObject("CmdOK.Image"), System.Drawing.Image)
        Me.CmdOK.Location = New System.Drawing.Point(389, 115)
        Me.CmdOK.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdOK.Name = "CmdOK"
        Me.CmdOK.Size = New System.Drawing.Size(130, 36)
        Me.CmdOK.TabIndex = 2200
        Me.CmdOK.Text = "&Tìm Kiếm"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(236, 8)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 15)
        Me.Label6.TabIndex = 1839
        Me.Label6.Tag = "Date to"
        Me.Label6.Text = "Thông tin tìm kiếm"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(8, 108)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 1838
        Me.Label3.Tag = "Receiver"
        Me.Label3.Text = "Số phiếu nhập kho"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(326, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1821
        Me.Label2.Tag = "Date to"
        Me.Label2.Text = "Đến ngày"
        '
        'TxtSo_NK
        '
        Me.TxtSo_NK.BackColor = System.Drawing.Color.White
        Me.TxtSo_NK.ForeColor = System.Drawing.Color.Blue
        Me.TxtSo_NK.Location = New System.Drawing.Point(108, 105)
        Me.TxtSo_NK.Name = "TxtSo_NK"
        Me.TxtSo_NK.Size = New System.Drawing.Size(126, 20)
        Me.TxtSo_NK.TabIndex = 1837
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(8, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1820
        Me.Label1.Tag = "Date from"
        Me.Label1.Text = "Từ ngày"
        '
        'ROSNK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1252, 556)
        Me.Controls.Add(Me.LabT_TT_NT)
        Me.Controls.Add(Me.TxtT_TT)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ROSNK"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.Controls.SetChildIndex(Me.TxtT_TT, 0)
        Me.Controls.SetChildIndex(Me.LabT_TT_NT, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuChoGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detail1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailGRV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.TxtMa_KH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabLenh_RO As System.Windows.Forms.Label
    Friend WithEvents TxtSo_Ro As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtSo_Hd As System.Windows.Forms.TextBox
    Friend WithEvents LabT_TT_NT As System.Windows.Forms.Label
    Friend WithEvents TxtT_TT As ClsTextBox.txtTien_NT
    Friend WithEvents PopupMenuMasterGrid As DevExpress.XtraBars.PopupMenu
    Friend WithEvents PopupMenuChoGRV As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents CmDanh_Sach As System.Windows.Forms.Button
    Friend WithEvents Detail1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents DetailGRV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Detail As DevExpress.XtraGrid.GridControl
    Friend WithEvents DetailGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Timer_Data As System.Windows.Forms.Timer
    Friend WithEvents TxtMa_KH As SmLists.TxtLookup
    Friend WithEvents lblMa_kh As Windows.Forms.Label
    Friend WithEvents TxtTen_KH As Windows.Forms.TextBox
    Friend WithEvents CmdOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents TxtSo_NK As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents CmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Txtngay_HD As ClsTextBox.txtDate1
    Friend WithEvents Txtngay_ct2 As ClsTextBox.txtDate1
    Friend WithEvents Txtngay_ct1 As ClsTextBox.txtDate1
    Friend WithEvents Chkis_Hd As Windows.Forms.CheckBox
End Class
