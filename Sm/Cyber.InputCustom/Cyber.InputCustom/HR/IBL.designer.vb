﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IBL
    Inherits Cyber.From.Frmvoucher

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
        Me.CbbMa_GD = New System.Windows.Forms.ComboBox()
        Me.LabDia_Chi = New System.Windows.Forms.Label()
        Me.TxtDia_Chi = New System.Windows.Forms.TextBox()
        Me.LabNgay_LCt = New System.Windows.Forms.Label()
        Me.LabNgay_Ct = New System.Windows.Forms.Label()
        Me.txtDien_giai = New System.Windows.Forms.TextBox()
        Me.LabDien_Giai = New System.Windows.Forms.Label()
        Me.lblLoai_ct = New System.Windows.Forms.Label()
        Me.lblSo_ct = New System.Windows.Forms.Label()
        Me.txtSo_ct = New System.Windows.Forms.TextBox()
        Me.LabMa_kh = New System.Windows.Forms.Label()
        Me.LabMa_NT = New System.Windows.Forms.Label()
        Me.TxtTy_Gia = New ClsTextBox.txtTy_Gia()
        Me.TxtNgay_LCt = New ClsTextBox.txtDate()
        Me.TxtNgay_Ct = New ClsTextBox.txtDate()
        Me.TxtMa_NT = New System.Windows.Forms.TextBox()
        Me.Detail = New DevExpress.XtraGrid.GridControl()
        Me.DetailGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.LabTy_gia = New System.Windows.Forms.Label()
        Me.TxtTen_kh = New System.Windows.Forms.TextBox()
        Me.TxtMa_Kh = New Cyber.SmLists.TxtLookup()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.TxtT_Tien_NT = New ClsTextBox.txtTien_NT()
        Me.TxtT_Tien = New ClsTextBox.txtTien_NT()
        Me.LabT_TT_NT = New System.Windows.Forms.Label()
        Me.TxtMa_Dvcs = New System.Windows.Forms.TextBox()
        Me.TxtStt_Rec = New System.Windows.Forms.TextBox()
        Me.PopupMenuMasterGrid = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.LabT_So_Luong = New System.Windows.Forms.Label()
        Me.TxtT_SO_LUONG = New ClsTextBox.txtTien_NT()
        Me.TxtT_Tien2 = New ClsTextBox.txtTien_NT()
        Me.TxtT_Tien_NT2 = New ClsTextBox.txtTien_NT()
        Me.TxtT_Tien3 = New ClsTextBox.txtTien_NT()
        Me.TxtT_Tien_NT3 = New ClsTextBox.txtTien_NT()
        Me.TxtT_Ps = New ClsTextBox.txtTien_NT()
        Me.TxtT_Ps_NT = New ClsTextBox.txtTien_NT()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNgay_Kh1 = New ClsTextBox.txtDate()
        Me.TxtNgay_Kh2 = New ClsTextBox.txtDate()
        Me.CbbNam = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbbThang = New System.Windows.Forms.ComboBox()
        Me.LabM_month1 = New System.Windows.Forms.Label()
        Me.LabMa_TTCP_H = New System.Windows.Forms.Label()
        Me.CmbMa_TTCP_H = New System.Windows.Forms.ComboBox()
        CType(Me.PopupMenuMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Kh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdEdit
        '
        Me.CmdEdit.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdEdit.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdEdit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdEdit.Appearance.Options.UseBackColor = True
        Me.CmdEdit.Appearance.Options.UseFont = True
        Me.CmdEdit.Appearance.Options.UseForeColor = True
        Me.CmdEdit.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdEdit.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdEdit.Location = New System.Drawing.Point(239, 516)
        '
        'CmdSave
        '
        Me.CmdSave.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdSave.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdSave.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdSave.Appearance.Options.UseBackColor = True
        Me.CmdSave.Appearance.Options.UseFont = True
        Me.CmdSave.Appearance.Options.UseForeColor = True
        Me.CmdSave.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdSave.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdSave.Location = New System.Drawing.Point(-1, 516)
        Me.CmdSave.TabIndex = 10
        '
        'CmdView
        '
        Me.CmdView.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdView.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdView.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdView.Appearance.Options.UseBackColor = True
        Me.CmdView.Appearance.Options.UseFont = True
        Me.CmdView.Appearance.Options.UseForeColor = True
        Me.CmdView.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdView.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdView.Location = New System.Drawing.Point(478, 516)
        Me.CmdView.TabIndex = 16
        '
        'LabMa_Post
        '
        Me.LabMa_Post.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_Post.Location = New System.Drawing.Point(11, 498)
        '
        'CmdSms
        '
        Me.CmdSms.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdSms.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdSms.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdSms.Appearance.Options.UseBackColor = True
        Me.CmdSms.Appearance.Options.UseFont = True
        Me.CmdSms.Appearance.Options.UseForeColor = True
        Me.CmdSms.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdSms.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdSms.Location = New System.Drawing.Point(840, 516)
        Me.CmdSms.TabIndex = 21
        '
        'CmdImport
        '
        Me.CmdImport.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdImport.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdImport.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdImport.Appearance.Options.UseBackColor = True
        Me.CmdImport.Appearance.Options.UseFont = True
        Me.CmdImport.Appearance.Options.UseForeColor = True
        Me.CmdImport.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdImport.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdImport.Location = New System.Drawing.Point(884, 516)
        Me.CmdImport.TabIndex = 24
        '
        'CbbMa_Post
        '
        Me.CbbMa_Post.Location = New System.Drawing.Point(80, 493)
        Me.CbbMa_Post.TabIndex = 9
        '
        'CmdExit
        '
        Me.CmdExit.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdExit.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdExit.Appearance.Options.UseBackColor = True
        Me.CmdExit.Appearance.Options.UseFont = True
        Me.CmdExit.Appearance.Options.UseForeColor = True
        Me.CmdExit.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdExit.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdExit.Location = New System.Drawing.Point(637, 516)
        Me.CmdExit.TabIndex = 18
        '
        'CmdSearch
        '
        Me.CmdSearch.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdSearch.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdSearch.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdSearch.Appearance.Options.UseBackColor = True
        Me.CmdSearch.Appearance.Options.UseFont = True
        Me.CmdSearch.Appearance.Options.UseForeColor = True
        Me.CmdSearch.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdSearch.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdSearch.Location = New System.Drawing.Point(558, 516)
        Me.CmdSearch.TabIndex = 17
        '
        'CmdCopy
        '
        Me.CmdCopy.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdCopy.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdCopy.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdCopy.Appearance.Options.UseBackColor = True
        Me.CmdCopy.Appearance.Options.UseFont = True
        Me.CmdCopy.Appearance.Options.UseForeColor = True
        Me.CmdCopy.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdCopy.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdCopy.Location = New System.Drawing.Point(399, 516)
        Me.CmdCopy.TabIndex = 15
        '
        'CmdDelete
        '
        Me.CmdDelete.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdDelete.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdDelete.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdDelete.Appearance.Options.UseBackColor = True
        Me.CmdDelete.Appearance.Options.UseFont = True
        Me.CmdDelete.Appearance.Options.UseForeColor = True
        Me.CmdDelete.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdDelete.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdDelete.Location = New System.Drawing.Point(319, 516)
        Me.CmdDelete.TabIndex = 14
        '
        'CmdPrint
        '
        Me.CmdPrint.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdPrint.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdPrint.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdPrint.Appearance.Options.UseBackColor = True
        Me.CmdPrint.Appearance.Options.UseFont = True
        Me.CmdPrint.Appearance.Options.UseForeColor = True
        Me.CmdPrint.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdPrint.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdPrint.Location = New System.Drawing.Point(159, 516)
        Me.CmdPrint.TabIndex = 12
        '
        'CmdNew
        '
        Me.CmdNew.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdNew.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdNew.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdNew.Appearance.Options.UseBackColor = True
        Me.CmdNew.Appearance.Options.UseFont = True
        Me.CmdNew.Appearance.Options.UseForeColor = True
        Me.CmdNew.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdNew.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdNew.Location = New System.Drawing.Point(79, 516)
        Me.CmdNew.TabIndex = 11
        '
        'CmdCancel
        '
        Me.CmdCancel.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdCancel.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdCancel.Appearance.Options.UseBackColor = True
        Me.CmdCancel.Appearance.Options.UseFont = True
        Me.CmdCancel.Appearance.Options.UseForeColor = True
        Me.CmdCancel.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdCancel.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdCancel.Location = New System.Drawing.Point(239, 516)
        Me.CmdCancel.TabIndex = 13
        '
        'CmdPhan_Bo
        '
        Me.CmdPhan_Bo.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdPhan_Bo.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdPhan_Bo.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdPhan_Bo.Appearance.Options.UseBackColor = True
        Me.CmdPhan_Bo.Appearance.Options.UseFont = True
        Me.CmdPhan_Bo.Appearance.Options.UseForeColor = True
        Me.CmdPhan_Bo.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdPhan_Bo.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdPhan_Bo.Location = New System.Drawing.Point(779, 515)
        Me.CmdPhan_Bo.TabIndex = 20
        '
        'TxtUser_id
        '
        Me.TxtUser_id.Location = New System.Drawing.Point(721, 518)
        '
        'CbbMa_GD
        '
        Me.CbbMa_GD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_GD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa_GD.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_GD.FormattingEnabled = True
        Me.CbbMa_GD.Location = New System.Drawing.Point(258, 33)
        Me.CbbMa_GD.Name = "CbbMa_GD"
        Me.CbbMa_GD.Size = New System.Drawing.Size(159, 23)
        Me.CbbMa_GD.TabIndex = 2
        '
        'LabDia_Chi
        '
        Me.LabDia_Chi.BackColor = System.Drawing.Color.Transparent
        Me.LabDia_Chi.Enabled = False
        Me.LabDia_Chi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabDia_Chi.ForeColor = System.Drawing.Color.Navy
        Me.LabDia_Chi.Location = New System.Drawing.Point(430, 178)
        Me.LabDia_Chi.Margin = New System.Windows.Forms.Padding(0)
        Me.LabDia_Chi.Name = "LabDia_Chi"
        Me.LabDia_Chi.Size = New System.Drawing.Size(66, 14)
        Me.LabDia_Chi.TabIndex = 146
        Me.LabDia_Chi.Tag = "Address"
        Me.LabDia_Chi.Text = "Địa chỉ"
        Me.LabDia_Chi.Visible = False
        '
        'TxtDia_Chi
        '
        Me.TxtDia_Chi.BackColor = System.Drawing.Color.White
        Me.TxtDia_Chi.Enabled = False
        Me.TxtDia_Chi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtDia_Chi.ForeColor = System.Drawing.Color.Navy
        Me.TxtDia_Chi.Location = New System.Drawing.Point(499, 175)
        Me.TxtDia_Chi.Name = "TxtDia_Chi"
        Me.TxtDia_Chi.Size = New System.Drawing.Size(423, 20)
        Me.TxtDia_Chi.TabIndex = 6
        Me.TxtDia_Chi.TabStop = False
        Me.TxtDia_Chi.Visible = False
        '
        'LabNgay_LCt
        '
        Me.LabNgay_LCt.BackColor = System.Drawing.Color.Transparent
        Me.LabNgay_LCt.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabNgay_LCt.ForeColor = System.Drawing.Color.Navy
        Me.LabNgay_LCt.Location = New System.Drawing.Point(1, 42)
        Me.LabNgay_LCt.Name = "LabNgay_LCt"
        Me.LabNgay_LCt.Size = New System.Drawing.Size(78, 13)
        Me.LabNgay_LCt.TabIndex = 144
        Me.LabNgay_LCt.Tag = "Create date"
        Me.LabNgay_LCt.Text = "Ngày Lập"
        '
        'LabNgay_Ct
        '
        Me.LabNgay_Ct.BackColor = System.Drawing.Color.Transparent
        Me.LabNgay_Ct.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabNgay_Ct.ForeColor = System.Drawing.Color.Navy
        Me.LabNgay_Ct.Location = New System.Drawing.Point(1, 61)
        Me.LabNgay_Ct.Name = "LabNgay_Ct"
        Me.LabNgay_Ct.Size = New System.Drawing.Size(78, 13)
        Me.LabNgay_Ct.TabIndex = 143
        Me.LabNgay_Ct.Tag = "Voucher date"
        Me.LabNgay_Ct.Text = "Ngày c.từ"
        '
        'txtDien_giai
        '
        Me.txtDien_giai.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDien_giai.BackColor = System.Drawing.Color.White
        Me.txtDien_giai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtDien_giai.ForeColor = System.Drawing.Color.Navy
        Me.txtDien_giai.Location = New System.Drawing.Point(80, 90)
        Me.txtDien_giai.Name = "txtDien_giai"
        Me.txtDien_giai.Size = New System.Drawing.Size(529, 20)
        Me.txtDien_giai.TabIndex = 6
        '
        'LabDien_Giai
        '
        Me.LabDien_Giai.BackColor = System.Drawing.Color.Transparent
        Me.LabDien_Giai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabDien_Giai.ForeColor = System.Drawing.Color.Navy
        Me.LabDien_Giai.Location = New System.Drawing.Point(1, 93)
        Me.LabDien_Giai.Margin = New System.Windows.Forms.Padding(0)
        Me.LabDien_Giai.Name = "LabDien_Giai"
        Me.LabDien_Giai.Size = New System.Drawing.Size(64, 14)
        Me.LabDien_Giai.TabIndex = 139
        Me.LabDien_Giai.Tag = "Reason"
        Me.LabDien_Giai.Text = "Diễn giải"
        '
        'lblLoai_ct
        '
        Me.lblLoai_ct.BackColor = System.Drawing.Color.Transparent
        Me.lblLoai_ct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoai_ct.ForeColor = System.Drawing.Color.Navy
        Me.lblLoai_ct.Location = New System.Drawing.Point(181, 38)
        Me.lblLoai_ct.Margin = New System.Windows.Forms.Padding(0)
        Me.lblLoai_ct.Name = "lblLoai_ct"
        Me.lblLoai_ct.Size = New System.Drawing.Size(71, 15)
        Me.lblLoai_ct.TabIndex = 138
        Me.lblLoai_ct.Tag = "Vote style"
        Me.lblLoai_ct.Text = "Loại phiếu"
        '
        'lblSo_ct
        '
        Me.lblSo_ct.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_ct.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblSo_ct.ForeColor = System.Drawing.Color.Navy
        Me.lblSo_ct.Location = New System.Drawing.Point(181, 61)
        Me.lblSo_ct.Name = "lblSo_ct"
        Me.lblSo_ct.Size = New System.Drawing.Size(71, 13)
        Me.lblSo_ct.TabIndex = 135
        Me.lblSo_ct.Tag = "Voucher no."
        Me.lblSo_ct.Text = "Số C.Từ"
        '
        'txtSo_ct
        '
        Me.txtSo_ct.BackColor = System.Drawing.Color.White
        Me.txtSo_ct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSo_ct.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtSo_ct.ForeColor = System.Drawing.Color.Navy
        Me.txtSo_ct.Location = New System.Drawing.Point(258, 59)
        Me.txtSo_ct.Name = "txtSo_ct"
        Me.txtSo_ct.Size = New System.Drawing.Size(159, 21)
        Me.txtSo_ct.TabIndex = 3
        Me.txtSo_ct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabMa_kh
        '
        Me.LabMa_kh.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_kh.Enabled = False
        Me.LabMa_kh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabMa_kh.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_kh.Location = New System.Drawing.Point(430, 156)
        Me.LabMa_kh.Margin = New System.Windows.Forms.Padding(0)
        Me.LabMa_kh.Name = "LabMa_kh"
        Me.LabMa_kh.Size = New System.Drawing.Size(66, 14)
        Me.LabMa_kh.TabIndex = 133
        Me.LabMa_kh.Tag = "Cus code"
        Me.LabMa_kh.Text = "Đối tượng"
        Me.LabMa_kh.Visible = False
        '
        'LabMa_NT
        '
        Me.LabMa_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabMa_NT.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_NT.Enabled = False
        Me.LabMa_NT.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabMa_NT.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_NT.Location = New System.Drawing.Point(774, 42)
        Me.LabMa_NT.Name = "LabMa_NT"
        Me.LabMa_NT.Size = New System.Drawing.Size(55, 17)
        Me.LabMa_NT.TabIndex = 134
        Me.LabMa_NT.Tag = "E.Rate"
        Me.LabMa_NT.Text = "Ngoại tệ"
        Me.LabMa_NT.Visible = False
        '
        'TxtTy_Gia
        '
        Me.TxtTy_Gia.AllowNegative = True
        Me.TxtTy_Gia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTy_Gia.BackColor = System.Drawing.Color.White
        Me.TxtTy_Gia.Enabled = False
        Me.TxtTy_Gia.Flags = 7680
        Me.TxtTy_Gia.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTy_Gia.ForeColor = System.Drawing.Color.Navy
        Me.TxtTy_Gia.InputMask = "## ### ###.##"
        Me.TxtTy_Gia.Location = New System.Drawing.Point(835, 59)
        Me.TxtTy_Gia.MaxWholeDigits = 10
        Me.TxtTy_Gia.Name = "TxtTy_Gia"
        Me.TxtTy_Gia.RangeMax = 1.7976931348623157E+308R
        Me.TxtTy_Gia.RangeMin = -1.7976931348623157E+308R
        Me.TxtTy_Gia.Size = New System.Drawing.Size(88, 21)
        Me.TxtTy_Gia.TabIndex = 20
        Me.TxtTy_Gia.Text = "22 500.01"
        Me.TxtTy_Gia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTy_Gia.Visible = False
        '
        'TxtNgay_LCt
        '
        Me.TxtNgay_LCt.BackColor = System.Drawing.Color.White
        Me.TxtNgay_LCt.Flags = 65536
        Me.TxtNgay_LCt.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_LCt.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_LCt.isEmpty = True
        Me.TxtNgay_LCt.Location = New System.Drawing.Point(80, 37)
        Me.TxtNgay_LCt.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_LCt.MaxLength = 10
        Me.TxtNgay_LCt.Name = "TxtNgay_LCt"
        Me.TxtNgay_LCt.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_LCt.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_LCt.ReadOnly = True
        Me.TxtNgay_LCt.ShowDayBeforeMonth = False
        Me.TxtNgay_LCt.Size = New System.Drawing.Size(85, 21)
        Me.TxtNgay_LCt.TabIndex = 0
        Me.TxtNgay_LCt.Text = "18/09/2011"
        Me.TxtNgay_LCt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_LCt.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        '
        'TxtNgay_Ct
        '
        Me.TxtNgay_Ct.BackColor = System.Drawing.Color.White
        Me.TxtNgay_Ct.Flags = 65536
        Me.TxtNgay_Ct.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_Ct.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Ct.isEmpty = True
        Me.TxtNgay_Ct.Location = New System.Drawing.Point(80, 59)
        Me.TxtNgay_Ct.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Ct.MaxLength = 10
        Me.TxtNgay_Ct.Name = "TxtNgay_Ct"
        Me.TxtNgay_Ct.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_Ct.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Ct.ReadOnly = True
        Me.TxtNgay_Ct.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct.Size = New System.Drawing.Size(85, 21)
        Me.TxtNgay_Ct.TabIndex = 1
        Me.TxtNgay_Ct.Text = "18/09/2011"
        Me.TxtNgay_Ct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_Ct.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        '
        'TxtMa_NT
        '
        Me.TxtMa_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_NT.BackColor = System.Drawing.Color.White
        Me.TxtMa_NT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_NT.Enabled = False
        Me.TxtMa_NT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_NT.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_NT.Location = New System.Drawing.Point(835, 37)
        Me.TxtMa_NT.Name = "TxtMa_NT"
        Me.TxtMa_NT.Size = New System.Drawing.Size(88, 21)
        Me.TxtMa_NT.TabIndex = 19
        Me.TxtMa_NT.Visible = False
        '
        'Detail
        '
        Me.Detail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Detail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Detail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detail.Location = New System.Drawing.Point(1, 116)
        Me.Detail.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Detail.MainView = Me.DetailGRV
        Me.Detail.Name = "Detail"
        Me.Detail.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.Detail.Size = New System.Drawing.Size(926, 374)
        Me.Detail.TabIndex = 9
        Me.Detail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DetailGRV})
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
        'LabTy_gia
        '
        Me.LabTy_gia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabTy_gia.BackColor = System.Drawing.Color.Transparent
        Me.LabTy_gia.Enabled = False
        Me.LabTy_gia.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabTy_gia.ForeColor = System.Drawing.Color.Navy
        Me.LabTy_gia.Location = New System.Drawing.Point(774, 61)
        Me.LabTy_gia.Name = "LabTy_gia"
        Me.LabTy_gia.Size = New System.Drawing.Size(55, 17)
        Me.LabTy_gia.TabIndex = 153
        Me.LabTy_gia.Tag = "E.Rate"
        Me.LabTy_gia.Text = "Tỷ giá"
        Me.LabTy_gia.Visible = False
        '
        'TxtTen_kh
        '
        Me.TxtTen_kh.BackColor = System.Drawing.Color.White
        Me.TxtTen_kh.Enabled = False
        Me.TxtTen_kh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_kh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_kh.Location = New System.Drawing.Point(617, 153)
        Me.TxtTen_kh.Name = "TxtTen_kh"
        Me.TxtTen_kh.ReadOnly = True
        Me.TxtTen_kh.Size = New System.Drawing.Size(305, 20)
        Me.TxtTen_kh.TabIndex = 155
        Me.TxtTen_kh.TabStop = False
        Me.TxtTen_kh.Visible = False
        '
        'TxtMa_Kh
        '
        Me.TxtMa_Kh._ActilookupPopup = False
        Me.TxtMa_Kh.CyberActilookupPopup = True
        Me.TxtMa_Kh.Dv_ListDetail = Nothing
        Me.TxtMa_Kh.Dv_Master = Nothing
        Me.TxtMa_Kh.Enabled = False
        Me.TxtMa_Kh.FilterClient = ""
        Me.TxtMa_Kh.FilterSQL = ""
        Me.TxtMa_Kh.Location = New System.Drawing.Point(499, 153)
        Me.TxtMa_Kh.Name = "TxtMa_Kh"
        Me.TxtMa_Kh.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Kh.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kh.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Kh.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kh.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_Kh.TabIndex = 5
        Me.TxtMa_Kh.Table_Name = ""
        Me.TxtMa_Kh.TabStop = False
        Me.TxtMa_Kh.Visible = False
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(10, 82)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(912, 8)
        Me.GroupBoxLine.TabIndex = 156
        Me.GroupBoxLine.TabStop = False
        '
        'TxtT_Tien_NT
        '
        Me.TxtT_Tien_NT.AllowNegative = True
        Me.TxtT_Tien_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Tien_NT.BackColor = System.Drawing.Color.White
        Me.TxtT_Tien_NT.Enabled = False
        Me.TxtT_Tien_NT.Flags = 7680
        Me.TxtT_Tien_NT.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Tien_NT.InputMask = "### ### ### ### ###.#"
        Me.TxtT_Tien_NT.Location = New System.Drawing.Point(478, 493)
        Me.TxtT_Tien_NT.MaxWholeDigits = 16
        Me.TxtT_Tien_NT.Name = "TxtT_Tien_NT"
        Me.TxtT_Tien_NT.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Tien_NT.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Tien_NT.ReadOnly = True
        Me.TxtT_Tien_NT.Size = New System.Drawing.Size(119, 20)
        Me.TxtT_Tien_NT.TabIndex = 158
        Me.TxtT_Tien_NT.Text = "1.0"
        Me.TxtT_Tien_NT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_Tien_NT.Visible = False
        '
        'TxtT_Tien
        '
        Me.TxtT_Tien.AllowNegative = True
        Me.TxtT_Tien.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Tien.BackColor = System.Drawing.Color.White
        Me.TxtT_Tien.Enabled = False
        Me.TxtT_Tien.Flags = 7680
        Me.TxtT_Tien.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Tien.InputMask = "### ### ### ### ###.#"
        Me.TxtT_Tien.Location = New System.Drawing.Point(602, 493)
        Me.TxtT_Tien.MaxWholeDigits = 16
        Me.TxtT_Tien.Name = "TxtT_Tien"
        Me.TxtT_Tien.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Tien.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Tien.ReadOnly = True
        Me.TxtT_Tien.Size = New System.Drawing.Size(119, 20)
        Me.TxtT_Tien.TabIndex = 159
        Me.TxtT_Tien.Text = "1.0"
        Me.TxtT_Tien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_Tien.Visible = False
        '
        'LabT_TT_NT
        '
        Me.LabT_TT_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabT_TT_NT.AutoSize = True
        Me.LabT_TT_NT.BackColor = System.Drawing.Color.Transparent
        Me.LabT_TT_NT.Enabled = False
        Me.LabT_TT_NT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabT_TT_NT.ForeColor = System.Drawing.Color.Navy
        Me.LabT_TT_NT.Location = New System.Drawing.Point(397, 497)
        Me.LabT_TT_NT.Margin = New System.Windows.Forms.Padding(0)
        Me.LabT_TT_NT.Name = "LabT_TT_NT"
        Me.LabT_TT_NT.Size = New System.Drawing.Size(59, 13)
        Me.LabT_TT_NT.TabIndex = 160
        Me.LabT_TT_NT.Tag = "Total"
        Me.LabT_TT_NT.Text = "Tổng cộng"
        Me.LabT_TT_NT.Visible = False
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtMa_Dvcs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Dvcs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Dvcs.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(898, 521)
        Me.TxtMa_Dvcs.Name = "TxtMa_Dvcs"
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(21, 21)
        Me.TxtMa_Dvcs.TabIndex = 161
        Me.TxtMa_Dvcs.TabStop = False
        Me.TxtMa_Dvcs.Visible = False
        '
        'TxtStt_Rec
        '
        Me.TxtStt_Rec.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtStt_Rec.BackColor = System.Drawing.Color.White
        Me.TxtStt_Rec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtStt_Rec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStt_Rec.ForeColor = System.Drawing.Color.Navy
        Me.TxtStt_Rec.Location = New System.Drawing.Point(871, 521)
        Me.TxtStt_Rec.Name = "TxtStt_Rec"
        Me.TxtStt_Rec.Size = New System.Drawing.Size(21, 21)
        Me.TxtStt_Rec.TabIndex = 162
        Me.TxtStt_Rec.TabStop = False
        Me.TxtStt_Rec.Visible = False
        '
        'PopupMenuMasterGrid
        '
        Me.PopupMenuMasterGrid.Name = "PopupMenuMasterGrid"
        '
        'LabT_So_Luong
        '
        Me.LabT_So_Luong.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabT_So_Luong.BackColor = System.Drawing.Color.Transparent
        Me.LabT_So_Luong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabT_So_Luong.ForeColor = System.Drawing.Color.Navy
        Me.LabT_So_Luong.Location = New System.Drawing.Point(238, 497)
        Me.LabT_So_Luong.Margin = New System.Windows.Forms.Padding(0)
        Me.LabT_So_Luong.Name = "LabT_So_Luong"
        Me.LabT_So_Luong.Size = New System.Drawing.Size(78, 14)
        Me.LabT_So_Luong.TabIndex = 175
        Me.LabT_So_Luong.Tag = "Total"
        Me.LabT_So_Luong.Text = "Tổng số lượng"
        '
        'TxtT_SO_LUONG
        '
        Me.TxtT_SO_LUONG.AllowNegative = True
        Me.TxtT_SO_LUONG.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_SO_LUONG.BackColor = System.Drawing.Color.White
        Me.TxtT_SO_LUONG.Flags = 7680
        Me.TxtT_SO_LUONG.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_SO_LUONG.InputMask = "### ### ### ### ###.#"
        Me.TxtT_SO_LUONG.Location = New System.Drawing.Point(319, 493)
        Me.TxtT_SO_LUONG.MaxWholeDigits = 16
        Me.TxtT_SO_LUONG.Name = "TxtT_SO_LUONG"
        Me.TxtT_SO_LUONG.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_SO_LUONG.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_SO_LUONG.ReadOnly = True
        Me.TxtT_SO_LUONG.Size = New System.Drawing.Size(75, 20)
        Me.TxtT_SO_LUONG.TabIndex = 174
        Me.TxtT_SO_LUONG.Text = "0.0"
        Me.TxtT_SO_LUONG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtT_Tien2
        '
        Me.TxtT_Tien2.AllowNegative = True
        Me.TxtT_Tien2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Tien2.BackColor = System.Drawing.Color.White
        Me.TxtT_Tien2.Enabled = False
        Me.TxtT_Tien2.Flags = 7680
        Me.TxtT_Tien2.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Tien2.InputMask = "### ### ### ### ###.#"
        Me.TxtT_Tien2.Location = New System.Drawing.Point(602, 493)
        Me.TxtT_Tien2.MaxWholeDigits = 16
        Me.TxtT_Tien2.Name = "TxtT_Tien2"
        Me.TxtT_Tien2.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Tien2.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Tien2.ReadOnly = True
        Me.TxtT_Tien2.Size = New System.Drawing.Size(119, 20)
        Me.TxtT_Tien2.TabIndex = 252
        Me.TxtT_Tien2.Text = "1.0"
        Me.TxtT_Tien2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_Tien2.Visible = False
        '
        'TxtT_Tien_NT2
        '
        Me.TxtT_Tien_NT2.AllowNegative = True
        Me.TxtT_Tien_NT2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Tien_NT2.BackColor = System.Drawing.Color.White
        Me.TxtT_Tien_NT2.Enabled = False
        Me.TxtT_Tien_NT2.Flags = 7680
        Me.TxtT_Tien_NT2.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Tien_NT2.InputMask = "### ### ### ### ###.#"
        Me.TxtT_Tien_NT2.Location = New System.Drawing.Point(478, 493)
        Me.TxtT_Tien_NT2.MaxWholeDigits = 16
        Me.TxtT_Tien_NT2.Name = "TxtT_Tien_NT2"
        Me.TxtT_Tien_NT2.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Tien_NT2.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Tien_NT2.ReadOnly = True
        Me.TxtT_Tien_NT2.Size = New System.Drawing.Size(119, 20)
        Me.TxtT_Tien_NT2.TabIndex = 251
        Me.TxtT_Tien_NT2.Text = "1.0"
        Me.TxtT_Tien_NT2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_Tien_NT2.Visible = False
        '
        'TxtT_Tien3
        '
        Me.TxtT_Tien3.AllowNegative = True
        Me.TxtT_Tien3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Tien3.BackColor = System.Drawing.Color.White
        Me.TxtT_Tien3.Enabled = False
        Me.TxtT_Tien3.Flags = 7680
        Me.TxtT_Tien3.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Tien3.InputMask = "### ### ### ### ###.#"
        Me.TxtT_Tien3.Location = New System.Drawing.Point(602, 493)
        Me.TxtT_Tien3.MaxWholeDigits = 16
        Me.TxtT_Tien3.Name = "TxtT_Tien3"
        Me.TxtT_Tien3.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Tien3.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Tien3.ReadOnly = True
        Me.TxtT_Tien3.Size = New System.Drawing.Size(119, 20)
        Me.TxtT_Tien3.TabIndex = 254
        Me.TxtT_Tien3.Text = "1.0"
        Me.TxtT_Tien3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_Tien3.Visible = False
        '
        'TxtT_Tien_NT3
        '
        Me.TxtT_Tien_NT3.AllowNegative = True
        Me.TxtT_Tien_NT3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Tien_NT3.BackColor = System.Drawing.Color.White
        Me.TxtT_Tien_NT3.Enabled = False
        Me.TxtT_Tien_NT3.Flags = 7680
        Me.TxtT_Tien_NT3.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Tien_NT3.InputMask = "### ### ### ### ###.#"
        Me.TxtT_Tien_NT3.Location = New System.Drawing.Point(478, 493)
        Me.TxtT_Tien_NT3.MaxWholeDigits = 16
        Me.TxtT_Tien_NT3.Name = "TxtT_Tien_NT3"
        Me.TxtT_Tien_NT3.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Tien_NT3.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Tien_NT3.ReadOnly = True
        Me.TxtT_Tien_NT3.Size = New System.Drawing.Size(119, 20)
        Me.TxtT_Tien_NT3.TabIndex = 253
        Me.TxtT_Tien_NT3.Text = "1.0"
        Me.TxtT_Tien_NT3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_Tien_NT3.Visible = False
        '
        'TxtT_Ps
        '
        Me.TxtT_Ps.AllowNegative = True
        Me.TxtT_Ps.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Ps.BackColor = System.Drawing.Color.White
        Me.TxtT_Ps.Enabled = False
        Me.TxtT_Ps.Flags = 7680
        Me.TxtT_Ps.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Ps.InputMask = "### ### ### ### ###.#"
        Me.TxtT_Ps.Location = New System.Drawing.Point(602, 493)
        Me.TxtT_Ps.MaxWholeDigits = 16
        Me.TxtT_Ps.Name = "TxtT_Ps"
        Me.TxtT_Ps.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Ps.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Ps.ReadOnly = True
        Me.TxtT_Ps.Size = New System.Drawing.Size(119, 20)
        Me.TxtT_Ps.TabIndex = 256
        Me.TxtT_Ps.Text = "1.0"
        Me.TxtT_Ps.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_Ps.Visible = False
        '
        'TxtT_Ps_NT
        '
        Me.TxtT_Ps_NT.AllowNegative = True
        Me.TxtT_Ps_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Ps_NT.BackColor = System.Drawing.Color.White
        Me.TxtT_Ps_NT.Enabled = False
        Me.TxtT_Ps_NT.Flags = 7680
        Me.TxtT_Ps_NT.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Ps_NT.InputMask = "### ### ### ### ###.#"
        Me.TxtT_Ps_NT.Location = New System.Drawing.Point(478, 493)
        Me.TxtT_Ps_NT.MaxWholeDigits = 16
        Me.TxtT_Ps_NT.Name = "TxtT_Ps_NT"
        Me.TxtT_Ps_NT.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Ps_NT.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Ps_NT.ReadOnly = True
        Me.TxtT_Ps_NT.Size = New System.Drawing.Size(119, 20)
        Me.TxtT_Ps_NT.TabIndex = 255
        Me.TxtT_Ps_NT.Text = "1.0"
        Me.TxtT_Ps_NT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_Ps_NT.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(732, 442)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 143
        Me.Label1.Tag = "Voucher date"
        Me.Label1.Text = "Kế hoạch từ ngày"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(732, 465)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 143
        Me.Label2.Tag = "Voucher date"
        Me.Label2.Text = "Kế hoạch đến ngày"
        Me.Label2.Visible = False
        '
        'TxtNgay_Kh1
        '
        Me.TxtNgay_Kh1.BackColor = System.Drawing.Color.White
        Me.TxtNgay_Kh1.Flags = 65536
        Me.TxtNgay_Kh1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_Kh1.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Kh1.isEmpty = True
        Me.TxtNgay_Kh1.Location = New System.Drawing.Point(835, 439)
        Me.TxtNgay_Kh1.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Kh1.MaxLength = 10
        Me.TxtNgay_Kh1.Name = "TxtNgay_Kh1"
        Me.TxtNgay_Kh1.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_Kh1.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Kh1.ReadOnly = True
        Me.TxtNgay_Kh1.ShowDayBeforeMonth = False
        Me.TxtNgay_Kh1.Size = New System.Drawing.Size(85, 21)
        Me.TxtNgay_Kh1.TabIndex = 4
        Me.TxtNgay_Kh1.Text = "18/09/2011"
        Me.TxtNgay_Kh1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_Kh1.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        Me.TxtNgay_Kh1.Visible = False
        '
        'TxtNgay_Kh2
        '
        Me.TxtNgay_Kh2.BackColor = System.Drawing.Color.White
        Me.TxtNgay_Kh2.Flags = 65536
        Me.TxtNgay_Kh2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_Kh2.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Kh2.isEmpty = True
        Me.TxtNgay_Kh2.Location = New System.Drawing.Point(835, 461)
        Me.TxtNgay_Kh2.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Kh2.MaxLength = 10
        Me.TxtNgay_Kh2.Name = "TxtNgay_Kh2"
        Me.TxtNgay_Kh2.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_Kh2.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Kh2.ReadOnly = True
        Me.TxtNgay_Kh2.ShowDayBeforeMonth = False
        Me.TxtNgay_Kh2.Size = New System.Drawing.Size(85, 21)
        Me.TxtNgay_Kh2.TabIndex = 5
        Me.TxtNgay_Kh2.Text = "18/09/2011"
        Me.TxtNgay_Kh2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_Kh2.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        Me.TxtNgay_Kh2.Visible = False
        '
        'CbbNam
        '
        Me.CbbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbNam.ForeColor = System.Drawing.Color.Navy
        Me.CbbNam.FormattingEnabled = True
        Me.CbbNam.Location = New System.Drawing.Point(499, 61)
        Me.CbbNam.Name = "CbbNam"
        Me.CbbNam.Size = New System.Drawing.Size(110, 21)
        Me.CbbNam.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(427, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 513
        Me.Label3.Tag = "Year"
        Me.Label3.Text = "Năm"
        '
        'CbbThang
        '
        Me.CbbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbThang.ForeColor = System.Drawing.Color.Navy
        Me.CbbThang.FormattingEnabled = True
        Me.CbbThang.Location = New System.Drawing.Point(499, 37)
        Me.CbbThang.Name = "CbbThang"
        Me.CbbThang.Size = New System.Drawing.Size(110, 21)
        Me.CbbThang.TabIndex = 4
        '
        'LabM_month1
        '
        Me.LabM_month1.AutoSize = True
        Me.LabM_month1.Location = New System.Drawing.Point(427, 40)
        Me.LabM_month1.Name = "LabM_month1"
        Me.LabM_month1.Size = New System.Drawing.Size(38, 13)
        Me.LabM_month1.TabIndex = 512
        Me.LabM_month1.Tag = "Month"
        Me.LabM_month1.Text = "Tháng"
        '
        'LabMa_TTCP_H
        '
        Me.LabMa_TTCP_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabMa_TTCP_H.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_TTCP_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMa_TTCP_H.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_TTCP_H.Location = New System.Drawing.Point(637, 3)
        Me.LabMa_TTCP_H.Margin = New System.Windows.Forms.Padding(0)
        Me.LabMa_TTCP_H.Name = "LabMa_TTCP_H"
        Me.LabMa_TTCP_H.Size = New System.Drawing.Size(89, 20)
        Me.LabMa_TTCP_H.TabIndex = 2161
        Me.LabMa_TTCP_H.Tag = "Cost centrer"
        Me.LabMa_TTCP_H.Text = "TTCP"
        Me.LabMa_TTCP_H.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbMa_TTCP_H
        '
        Me.CmbMa_TTCP_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbMa_TTCP_H.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMa_TTCP_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMa_TTCP_H.ForeColor = System.Drawing.Color.Navy
        Me.CmbMa_TTCP_H.FormattingEnabled = True
        Me.CmbMa_TTCP_H.Location = New System.Drawing.Point(733, 0)
        Me.CmbMa_TTCP_H.Name = "CmbMa_TTCP_H"
        Me.CmbMa_TTCP_H.Size = New System.Drawing.Size(194, 23)
        Me.CmbMa_TTCP_H.TabIndex = 2160
        Me.CmbMa_TTCP_H.TabStop = False
        '
        'IBL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(931, 572)
        Me.Controls.Add(Me.LabMa_TTCP_H)
        Me.Controls.Add(Me.CmbMa_TTCP_H)
        Me.Controls.Add(Me.CbbNam)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CbbThang)
        Me.Controls.Add(Me.LabM_month1)
        Me.Controls.Add(Me.LabT_So_Luong)
        Me.Controls.Add(Me.TxtT_SO_LUONG)
        Me.Controls.Add(Me.LabT_TT_NT)
        Me.Controls.Add(Me.TxtT_Tien)
        Me.Controls.Add(Me.TxtT_Tien_NT)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabTy_gia)
        Me.Controls.Add(Me.Detail)
        Me.Controls.Add(Me.TxtMa_NT)
        Me.Controls.Add(Me.TxtTy_Gia)
        Me.Controls.Add(Me.TxtNgay_Kh1)
        Me.Controls.Add(Me.TxtNgay_LCt)
        Me.Controls.Add(Me.TxtNgay_Kh2)
        Me.Controls.Add(Me.TxtNgay_Ct)
        Me.Controls.Add(Me.CbbMa_GD)
        Me.Controls.Add(Me.LabNgay_LCt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabNgay_Ct)
        Me.Controls.Add(Me.txtDien_giai)
        Me.Controls.Add(Me.LabDien_Giai)
        Me.Controls.Add(Me.lblLoai_ct)
        Me.Controls.Add(Me.lblSo_ct)
        Me.Controls.Add(Me.txtSo_ct)
        Me.Controls.Add(Me.LabMa_NT)
        Me.Controls.Add(Me.TxtStt_Rec)
        Me.Controls.Add(Me.TxtMa_Dvcs)
        Me.Controls.Add(Me.TxtT_Ps)
        Me.Controls.Add(Me.TxtT_Ps_NT)
        Me.Controls.Add(Me.TxtT_Tien3)
        Me.Controls.Add(Me.TxtT_Tien_NT3)
        Me.Controls.Add(Me.TxtT_Tien2)
        Me.Controls.Add(Me.TxtT_Tien_NT2)
        Me.Controls.Add(Me.TxtTen_kh)
        Me.Controls.Add(Me.TxtMa_Kh)
        Me.Controls.Add(Me.LabDia_Chi)
        Me.Controls.Add(Me.LabMa_kh)
        Me.Controls.Add(Me.TxtDia_Chi)
        Me.KeyPreview = True
        Me.Name = "IBL"
        Me.Controls.SetChildIndex(Me.TxtDia_Chi, 0)
        Me.Controls.SetChildIndex(Me.LabMa_kh, 0)
        Me.Controls.SetChildIndex(Me.LabDia_Chi, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kh, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kh, 0)
        Me.Controls.SetChildIndex(Me.TxtUser_id, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Tien_NT2, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Tien2, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Tien_NT3, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Tien3, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Ps_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Ps, 0)
        Me.Controls.SetChildIndex(Me.CmdPhan_Bo, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.TxtStt_Rec, 0)
        Me.Controls.SetChildIndex(Me.CmdNew, 0)
        Me.Controls.SetChildIndex(Me.CmdSave, 0)
        Me.Controls.SetChildIndex(Me.CmdPrint, 0)
        Me.Controls.SetChildIndex(Me.CmdEdit, 0)
        Me.Controls.SetChildIndex(Me.CmdCancel, 0)
        Me.Controls.SetChildIndex(Me.CmdDelete, 0)
        Me.Controls.SetChildIndex(Me.CmdCopy, 0)
        Me.Controls.SetChildIndex(Me.CmdSearch, 0)
        Me.Controls.SetChildIndex(Me.CmdExit, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_Post, 0)
        Me.Controls.SetChildIndex(Me.CmdImport, 0)
        Me.Controls.SetChildIndex(Me.CmdSms, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Post, 0)
        Me.Controls.SetChildIndex(Me.CmdView, 0)
        Me.Controls.SetChildIndex(Me.LabMa_NT, 0)
        Me.Controls.SetChildIndex(Me.txtSo_ct, 0)
        Me.Controls.SetChildIndex(Me.lblSo_ct, 0)
        Me.Controls.SetChildIndex(Me.lblLoai_ct, 0)
        Me.Controls.SetChildIndex(Me.LabDien_Giai, 0)
        Me.Controls.SetChildIndex(Me.txtDien_giai, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_Ct, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_LCt, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_GD, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Kh2, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_LCt, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Kh1, 0)
        Me.Controls.SetChildIndex(Me.TxtTy_Gia, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_NT, 0)
        Me.Controls.SetChildIndex(Me.Detail, 0)
        Me.Controls.SetChildIndex(Me.LabTy_gia, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Tien_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Tien, 0)
        Me.Controls.SetChildIndex(Me.LabT_TT_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtT_SO_LUONG, 0)
        Me.Controls.SetChildIndex(Me.LabT_So_Luong, 0)
        Me.Controls.SetChildIndex(Me.LabM_month1, 0)
        Me.Controls.SetChildIndex(Me.CbbThang, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.CbbNam, 0)
        Me.Controls.SetChildIndex(Me.CmbMa_TTCP_H, 0)
        Me.Controls.SetChildIndex(Me.LabMa_TTCP_H, 0)
        CType(Me.PopupMenuMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Kh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbbMa_GD As System.Windows.Forms.ComboBox
    Friend WithEvents LabDia_Chi As System.Windows.Forms.Label
    Friend WithEvents TxtDia_Chi As System.Windows.Forms.TextBox
    Friend WithEvents LabNgay_LCt As System.Windows.Forms.Label
    Friend WithEvents LabNgay_Ct As System.Windows.Forms.Label
    Friend WithEvents txtDien_giai As System.Windows.Forms.TextBox
    Friend WithEvents LabDien_Giai As System.Windows.Forms.Label
    Friend WithEvents lblLoai_ct As System.Windows.Forms.Label
    Friend WithEvents lblSo_ct As System.Windows.Forms.Label
    Friend WithEvents txtSo_ct As System.Windows.Forms.TextBox
    Friend WithEvents LabMa_kh As System.Windows.Forms.Label
    Friend WithEvents LabMa_NT As System.Windows.Forms.Label
    Friend WithEvents TxtTy_Gia As ClsTextBox.txtTy_Gia
    Friend WithEvents TxtNgay_LCt As ClsTextBox.txtDate
    Friend WithEvents TxtNgay_Ct As ClsTextBox.txtDate
    Friend WithEvents TxtMa_NT As System.Windows.Forms.TextBox
    Friend WithEvents Detail As DevExpress.XtraGrid.GridControl
    Friend WithEvents DetailGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabTy_gia As System.Windows.Forms.Label
    Friend WithEvents TxtTen_kh As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents TxtMa_Kh As Cyber.SmLists.TxtLookup
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents TxtT_Tien_NT As ClsTextBox.txtTien_NT
    Friend WithEvents TxtT_Tien As ClsTextBox.txtTien_NT
    Friend WithEvents LabT_TT_NT As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Dvcs As System.Windows.Forms.TextBox
    Friend WithEvents TxtStt_Rec As System.Windows.Forms.TextBox
    Friend WithEvents PopupMenuMasterGrid As DevExpress.XtraBars.PopupMenu
    Friend WithEvents LabT_So_Luong As System.Windows.Forms.Label
    Friend WithEvents TxtT_SO_LUONG As ClsTextBox.txtTien_NT
    Friend WithEvents TxtT_Tien2 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtT_Tien_NT2 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtT_Tien3 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtT_Tien_NT3 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtT_Ps As ClsTextBox.txtTien_NT
    Friend WithEvents TxtT_Ps_NT As ClsTextBox.txtTien_NT
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_Kh1 As ClsTextBox.txtDate
    Friend WithEvents TxtNgay_Kh2 As ClsTextBox.txtDate
    Friend WithEvents CbbNam As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CbbThang As System.Windows.Forms.ComboBox
    Friend WithEvents LabM_month1 As System.Windows.Forms.Label
    Friend WithEvents LabMa_TTCP_H As Label
    Friend WithEvents CmbMa_TTCP_H As ComboBox
End Class
