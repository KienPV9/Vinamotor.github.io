<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PXF
    Inherits Cyber.From.Frmvoucher

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
        Me.CbbMa_GD = New System.Windows.Forms.ComboBox()
        Me.LabDia_Chi = New System.Windows.Forms.Label()
        Me.TxtDia_Chi = New System.Windows.Forms.TextBox()
        Me.TxtMa_Quyen = New System.Windows.Forms.TextBox()
        Me.LabMa_Quyen = New System.Windows.Forms.Label()
        Me.LabNgay_LCt = New System.Windows.Forms.Label()
        Me.LabNgay_Ct = New System.Windows.Forms.Label()
        Me.txtDien_giai = New System.Windows.Forms.TextBox()
        Me.LabDien_Giai = New System.Windows.Forms.Label()
        Me.lblLoai_ct = New System.Windows.Forms.Label()
        Me.txtOng_ba = New System.Windows.Forms.TextBox()
        Me.LabOng_ba = New System.Windows.Forms.Label()
        Me.lblSo_ct = New System.Windows.Forms.Label()
        Me.TxtSo_Ct = New System.Windows.Forms.TextBox()
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
        Me.TxtT_TT_NT = New ClsTextBox.txtTien_NT()
        Me.TxtT_TT = New ClsTextBox.txtTien_NT()
        Me.LabT_TT_NT = New System.Windows.Forms.Label()
        Me.TxtMa_Dvcs = New System.Windows.Forms.TextBox()
        Me.TxtStt_Rec = New System.Windows.Forms.TextBox()
        Me.PopupMenuMasterGrid = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.LabLenh_RO = New System.Windows.Forms.Label()
        Me.TxtLenh_RO = New System.Windows.Forms.TextBox()
        Me.LabLenh_PO = New System.Windows.Forms.Label()
        Me.TxtLenh_PO = New System.Windows.Forms.TextBox()
        Me.LabLenh_SO = New System.Windows.Forms.Label()
        Me.TxtLenh_SO = New System.Windows.Forms.TextBox()
        Me.LabT_So_Luong = New System.Windows.Forms.Label()
        Me.TxtT_SO_LUONG = New ClsTextBox.txtTien_NT()
        Me.TxtTen_KhVAT = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDia_ChiVAT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtMa_So_Thue = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTen_BP_H = New System.Windows.Forms.TextBox()
        Me.TxtMa_Bp_H = New Cyber.SmLists.TxtLookup()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTen_HS_H = New System.Windows.Forms.TextBox()
        Me.txtMa_HS_H = New Cyber.SmLists.TxtLookup()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTen_NX = New System.Windows.Forms.TextBox()
        Me.txtMa_NX = New Cyber.SmLists.TxtLookup()
        Me.LabMa_Nx = New System.Windows.Forms.Label()
        Me.TxtTen_vtthue = New System.Windows.Forms.TextBox()
        Me.LabTen_vtthue = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtSo_Seri = New System.Windows.Forms.TextBox()
        Me.LabT_Thue_NT = New System.Windows.Forms.Label()
        Me.TxtT_Thue = New ClsTextBox.txtTien_NT()
        Me.TxtT_thue_NT = New ClsTextBox.txtTien_NT()
        Me.TxtT_Tien = New ClsTextBox.txtTien_NT()
        Me.TxtT_Tien_NT = New ClsTextBox.txtTien_NT()
        Me.TxtTk_Thue_Co = New Cyber.SmLists.TxtLookup()
        Me.LabTk_Thue_No = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtThue_Suat = New ClsTextBox.txtTien_NT()
        Me.TxtMa_Thue = New System.Windows.Forms.TextBox()
        Me.LabTk_Thue_Co = New System.Windows.Forms.Label()
        Me.ChkSua_Thue = New System.Windows.Forms.CheckBox()
        Me.ChkSua_TkThue = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtHan_TT = New ClsTextBox.txtTien_NT()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtTk_Thue_No = New Cyber.SmLists.TxtLookup()
        Me.TxtLenh_Vt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LabMau_BC = New System.Windows.Forms.Label()
        Me.TxtMau_BC = New System.Windows.Forms.TextBox()
        Me.ChkE_Thue = New System.Windows.Forms.CheckBox()
        Me.ChkE_Tien = New System.Windows.Forms.CheckBox()
        Me.ChkNonVAT = New System.Windows.Forms.CheckBox()
        Me.CbbMa_TTCP_H = New System.Windows.Forms.ComboBox()
        Me.LabMa_TTCP_H = New System.Windows.Forms.Label()
        CType(Me.PopupMenuMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Kh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Bp_H.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMa_HS_H.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMa_NX.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTk_Thue_Co.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTk_Thue_No.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CmdEdit.Location = New System.Drawing.Point(239, 533)
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
        Me.CmdSave.Location = New System.Drawing.Point(-1, 533)
        Me.CmdSave.TabIndex = 16
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
        Me.CmdView.Location = New System.Drawing.Point(478, 533)
        Me.CmdView.TabIndex = 22
        '
        'LabMa_Post
        '
        Me.LabMa_Post.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_Post.Location = New System.Drawing.Point(11, 515)
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
        Me.CmdSms.Location = New System.Drawing.Point(910, 533)
        Me.CmdSms.TabIndex = 23
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
        Me.CmdImport.Location = New System.Drawing.Point(954, 533)
        Me.CmdImport.TabIndex = 24
        '
        'CbbMa_Post
        '
        Me.CbbMa_Post.Location = New System.Drawing.Point(80, 510)
        Me.CbbMa_Post.TabIndex = 15
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
        Me.CmdExit.Location = New System.Drawing.Point(637, 533)
        Me.CmdExit.TabIndex = 24
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
        Me.CmdSearch.Location = New System.Drawing.Point(558, 533)
        Me.CmdSearch.TabIndex = 23
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
        Me.CmdCopy.Location = New System.Drawing.Point(399, 533)
        Me.CmdCopy.TabIndex = 21
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
        Me.CmdDelete.Location = New System.Drawing.Point(319, 533)
        Me.CmdDelete.TabIndex = 20
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
        Me.CmdPrint.Location = New System.Drawing.Point(159, 533)
        Me.CmdPrint.TabIndex = 18
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
        Me.CmdNew.Location = New System.Drawing.Point(79, 533)
        Me.CmdNew.TabIndex = 17
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
        Me.CmdCancel.Location = New System.Drawing.Point(239, 533)
        Me.CmdCancel.TabIndex = 19
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
        Me.CmdPhan_Bo.Location = New System.Drawing.Point(849, 532)
        '
        'CbbMa_GD
        '
        Me.CbbMa_GD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_GD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa_GD.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_GD.FormattingEnabled = True
        Me.CbbMa_GD.Location = New System.Drawing.Point(242, 33)
        Me.CbbMa_GD.Name = "CbbMa_GD"
        Me.CbbMa_GD.Size = New System.Drawing.Size(136, 23)
        Me.CbbMa_GD.TabIndex = 21
        '
        'LabDia_Chi
        '
        Me.LabDia_Chi.BackColor = System.Drawing.Color.Transparent
        Me.LabDia_Chi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabDia_Chi.ForeColor = System.Drawing.Color.Navy
        Me.LabDia_Chi.Location = New System.Drawing.Point(1, 115)
        Me.LabDia_Chi.Margin = New System.Windows.Forms.Padding(0)
        Me.LabDia_Chi.Name = "LabDia_Chi"
        Me.LabDia_Chi.Size = New System.Drawing.Size(78, 14)
        Me.LabDia_Chi.TabIndex = 146
        Me.LabDia_Chi.Tag = "Address"
        Me.LabDia_Chi.Text = "Địa chỉ"
        '
        'TxtDia_Chi
        '
        Me.TxtDia_Chi.BackColor = System.Drawing.Color.White
        Me.TxtDia_Chi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtDia_Chi.ForeColor = System.Drawing.Color.Navy
        Me.TxtDia_Chi.Location = New System.Drawing.Point(80, 112)
        Me.TxtDia_Chi.Name = "TxtDia_Chi"
        Me.TxtDia_Chi.Size = New System.Drawing.Size(478, 20)
        Me.TxtDia_Chi.TabIndex = 4
        '
        'TxtMa_Quyen
        '
        Me.TxtMa_Quyen.BackColor = System.Drawing.Color.White
        Me.TxtMa_Quyen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Quyen.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtMa_Quyen.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Quyen.Location = New System.Drawing.Point(716, 62)
        Me.TxtMa_Quyen.Name = "TxtMa_Quyen"
        Me.TxtMa_Quyen.Size = New System.Drawing.Size(21, 21)
        Me.TxtMa_Quyen.TabIndex = 22
        Me.TxtMa_Quyen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtMa_Quyen.Visible = False
        '
        'LabMa_Quyen
        '
        Me.LabMa_Quyen.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_Quyen.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabMa_Quyen.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_Quyen.Location = New System.Drawing.Point(596, 34)
        Me.LabMa_Quyen.Name = "LabMa_Quyen"
        Me.LabMa_Quyen.Size = New System.Drawing.Size(55, 13)
        Me.LabMa_Quyen.TabIndex = 145
        Me.LabMa_Quyen.Tag = "Book no."
        Me.LabMa_Quyen.Text = "Quyển số"
        Me.LabMa_Quyen.Visible = False
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
        Me.txtDien_giai.Location = New System.Drawing.Point(630, 133)
        Me.txtDien_giai.Name = "txtDien_giai"
        Me.txtDien_giai.Size = New System.Drawing.Size(366, 20)
        Me.txtDien_giai.TabIndex = 9
        '
        'LabDien_Giai
        '
        Me.LabDien_Giai.BackColor = System.Drawing.Color.Transparent
        Me.LabDien_Giai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabDien_Giai.ForeColor = System.Drawing.Color.Navy
        Me.LabDien_Giai.Location = New System.Drawing.Point(558, 137)
        Me.LabDien_Giai.Margin = New System.Windows.Forms.Padding(0)
        Me.LabDien_Giai.Name = "LabDien_Giai"
        Me.LabDien_Giai.Size = New System.Drawing.Size(69, 14)
        Me.LabDien_Giai.TabIndex = 139
        Me.LabDien_Giai.Tag = "Note"
        Me.LabDien_Giai.Text = "Diễn giải"
        '
        'lblLoai_ct
        '
        Me.lblLoai_ct.BackColor = System.Drawing.Color.Transparent
        Me.lblLoai_ct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoai_ct.ForeColor = System.Drawing.Color.Navy
        Me.lblLoai_ct.Location = New System.Drawing.Point(170, 38)
        Me.lblLoai_ct.Margin = New System.Windows.Forms.Padding(0)
        Me.lblLoai_ct.Name = "lblLoai_ct"
        Me.lblLoai_ct.Size = New System.Drawing.Size(71, 15)
        Me.lblLoai_ct.TabIndex = 138
        Me.lblLoai_ct.Tag = "Vote style"
        Me.lblLoai_ct.Text = "Loại phiếu"
        '
        'txtOng_ba
        '
        Me.txtOng_ba.BackColor = System.Drawing.Color.White
        Me.txtOng_ba.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtOng_ba.ForeColor = System.Drawing.Color.Navy
        Me.txtOng_ba.Location = New System.Drawing.Point(80, 133)
        Me.txtOng_ba.Name = "txtOng_ba"
        Me.txtOng_ba.Size = New System.Drawing.Size(181, 20)
        Me.txtOng_ba.TabIndex = 5
        '
        'LabOng_ba
        '
        Me.LabOng_ba.BackColor = System.Drawing.Color.Transparent
        Me.LabOng_ba.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabOng_ba.ForeColor = System.Drawing.Color.Navy
        Me.LabOng_ba.Location = New System.Drawing.Point(1, 137)
        Me.LabOng_ba.Margin = New System.Windows.Forms.Padding(0)
        Me.LabOng_ba.Name = "LabOng_ba"
        Me.LabOng_ba.Size = New System.Drawing.Size(78, 14)
        Me.LabOng_ba.TabIndex = 136
        Me.LabOng_ba.Tag = "Receiver"
        Me.LabOng_ba.Text = "Người mua"
        '
        'lblSo_ct
        '
        Me.lblSo_ct.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_ct.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblSo_ct.ForeColor = System.Drawing.Color.Navy
        Me.lblSo_ct.Location = New System.Drawing.Point(170, 61)
        Me.lblSo_ct.Name = "lblSo_ct"
        Me.lblSo_ct.Size = New System.Drawing.Size(71, 13)
        Me.lblSo_ct.TabIndex = 135
        Me.lblSo_ct.Tag = "Voucher no."
        Me.lblSo_ct.Text = "Số phiếu"
        '
        'TxtSo_Ct
        '
        Me.TxtSo_Ct.BackColor = System.Drawing.Color.White
        Me.TxtSo_Ct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_Ct.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtSo_Ct.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Ct.Location = New System.Drawing.Point(242, 59)
        Me.TxtSo_Ct.Name = "TxtSo_Ct"
        Me.TxtSo_Ct.Size = New System.Drawing.Size(136, 21)
        Me.TxtSo_Ct.TabIndex = 2
        Me.TxtSo_Ct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabMa_kh
        '
        Me.LabMa_kh.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_kh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabMa_kh.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_kh.Location = New System.Drawing.Point(1, 93)
        Me.LabMa_kh.Margin = New System.Windows.Forms.Padding(0)
        Me.LabMa_kh.Name = "LabMa_kh"
        Me.LabMa_kh.Size = New System.Drawing.Size(78, 14)
        Me.LabMa_kh.TabIndex = 133
        Me.LabMa_kh.Tag = "Cus code"
        Me.LabMa_kh.Text = "Đối tượng (KH)"
        '
        'LabMa_NT
        '
        Me.LabMa_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabMa_NT.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_NT.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabMa_NT.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_NT.Location = New System.Drawing.Point(844, 42)
        Me.LabMa_NT.Name = "LabMa_NT"
        Me.LabMa_NT.Size = New System.Drawing.Size(55, 17)
        Me.LabMa_NT.TabIndex = 134
        Me.LabMa_NT.Tag = "E.Rate"
        Me.LabMa_NT.Text = "Ngoại tệ"
        '
        'TxtTy_Gia
        '
        Me.TxtTy_Gia.AllowNegative = True
        Me.TxtTy_Gia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTy_Gia.BackColor = System.Drawing.Color.White
        Me.TxtTy_Gia.Flags = 7680
        Me.TxtTy_Gia.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTy_Gia.ForeColor = System.Drawing.Color.Navy
        Me.TxtTy_Gia.InputMask = "## ### ###.##"
        Me.TxtTy_Gia.Location = New System.Drawing.Point(908, 59)
        Me.TxtTy_Gia.MaxWholeDigits = 10
        Me.TxtTy_Gia.Name = "TxtTy_Gia"
        Me.TxtTy_Gia.RangeMax = 1.7976931348623157E+308R
        Me.TxtTy_Gia.RangeMin = -1.7976931348623157E+308R
        Me.TxtTy_Gia.ReadOnly = True
        Me.TxtTy_Gia.Size = New System.Drawing.Size(88, 21)
        Me.TxtTy_Gia.TabIndex = 20
        Me.TxtTy_Gia.Text = "22 500.01"
        Me.TxtTy_Gia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.TxtMa_NT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_NT.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_NT.Location = New System.Drawing.Point(908, 37)
        Me.TxtMa_NT.Name = "TxtMa_NT"
        Me.TxtMa_NT.Size = New System.Drawing.Size(88, 21)
        Me.TxtMa_NT.TabIndex = 19
        Me.TxtMa_NT.TabStop = False
        '
        'Detail
        '
        Me.Detail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Detail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Detail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detail.Location = New System.Drawing.Point(1, 200)
        Me.Detail.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Detail.MainView = Me.DetailGRV
        Me.Detail.Name = "Detail"
        Me.Detail.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.Detail.Size = New System.Drawing.Size(996, 242)
        Me.Detail.TabIndex = 14
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
        Me.LabTy_gia.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabTy_gia.ForeColor = System.Drawing.Color.Navy
        Me.LabTy_gia.Location = New System.Drawing.Point(844, 61)
        Me.LabTy_gia.Name = "LabTy_gia"
        Me.LabTy_gia.Size = New System.Drawing.Size(55, 17)
        Me.LabTy_gia.TabIndex = 153
        Me.LabTy_gia.Tag = "E.Rate"
        Me.LabTy_gia.Text = "Tỷ giá"
        '
        'TxtTen_kh
        '
        Me.TxtTen_kh.BackColor = System.Drawing.Color.White
        Me.TxtTen_kh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_kh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_kh.Location = New System.Drawing.Point(198, 90)
        Me.TxtTen_kh.Name = "TxtTen_kh"
        Me.TxtTen_kh.ReadOnly = True
        Me.TxtTen_kh.Size = New System.Drawing.Size(360, 20)
        Me.TxtTen_kh.TabIndex = 155
        Me.TxtTen_kh.TabStop = False
        '
        'TxtMa_Kh
        '
        Me.TxtMa_Kh._ActilookupPopup = False
        Me.TxtMa_Kh.CyberActilookupPopup = True
        Me.TxtMa_Kh.Dv_ListDetail = Nothing
        Me.TxtMa_Kh.Dv_Master = Nothing
        Me.TxtMa_Kh.FilterClient = ""
        Me.TxtMa_Kh.FilterSQL = ""
        Me.TxtMa_Kh.Location = New System.Drawing.Point(80, 90)
        Me.TxtMa_Kh.Name = "TxtMa_Kh"
        Me.TxtMa_Kh.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Kh.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kh.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Kh.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kh.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_Kh.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_Kh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kh.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_Kh.TabIndex = 3
        Me.TxtMa_Kh.Table_Name = ""
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(10, 82)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(982, 8)
        Me.GroupBoxLine.TabIndex = 156
        Me.GroupBoxLine.TabStop = False
        '
        'TxtT_TT_NT
        '
        Me.TxtT_TT_NT.AllowNegative = True
        Me.TxtT_TT_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_TT_NT.BackColor = System.Drawing.Color.White
        Me.TxtT_TT_NT.Flags = 7680
        Me.TxtT_TT_NT.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_TT_NT.InputMask = "### ### ### ### ###.#"
        Me.TxtT_TT_NT.Location = New System.Drawing.Point(474, 510)
        Me.TxtT_TT_NT.MaxWholeDigits = 16
        Me.TxtT_TT_NT.Name = "TxtT_TT_NT"
        Me.TxtT_TT_NT.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_TT_NT.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_TT_NT.ReadOnly = True
        Me.TxtT_TT_NT.Size = New System.Drawing.Size(119, 20)
        Me.TxtT_TT_NT.TabIndex = 158
        Me.TxtT_TT_NT.TabStop = False
        Me.TxtT_TT_NT.Text = "1.0"
        Me.TxtT_TT_NT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtT_TT
        '
        Me.TxtT_TT.AllowNegative = True
        Me.TxtT_TT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_TT.BackColor = System.Drawing.Color.White
        Me.TxtT_TT.Flags = 7680
        Me.TxtT_TT.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_TT.InputMask = "### ### ### ### ###.#"
        Me.TxtT_TT.Location = New System.Drawing.Point(595, 510)
        Me.TxtT_TT.MaxWholeDigits = 16
        Me.TxtT_TT.Name = "TxtT_TT"
        Me.TxtT_TT.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_TT.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_TT.ReadOnly = True
        Me.TxtT_TT.Size = New System.Drawing.Size(119, 20)
        Me.TxtT_TT.TabIndex = 159
        Me.TxtT_TT.TabStop = False
        Me.TxtT_TT.Text = "1.0"
        Me.TxtT_TT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabT_TT_NT
        '
        Me.LabT_TT_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabT_TT_NT.BackColor = System.Drawing.Color.Transparent
        Me.LabT_TT_NT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabT_TT_NT.ForeColor = System.Drawing.Color.Navy
        Me.LabT_TT_NT.Location = New System.Drawing.Point(382, 514)
        Me.LabT_TT_NT.Margin = New System.Windows.Forms.Padding(0)
        Me.LabT_TT_NT.Name = "LabT_TT_NT"
        Me.LabT_TT_NT.Size = New System.Drawing.Size(88, 14)
        Me.LabT_TT_NT.TabIndex = 160
        Me.LabT_TT_NT.Tag = "Total"
        Me.LabT_TT_NT.Text = "Tổng cộng"
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtMa_Dvcs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Dvcs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Dvcs.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(968, 538)
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
        Me.TxtStt_Rec.Location = New System.Drawing.Point(941, 538)
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
        'LabLenh_RO
        '
        Me.LabLenh_RO.BackColor = System.Drawing.Color.Transparent
        Me.LabLenh_RO.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabLenh_RO.ForeColor = System.Drawing.Color.Navy
        Me.LabLenh_RO.Location = New System.Drawing.Point(600, 48)
        Me.LabLenh_RO.Name = "LabLenh_RO"
        Me.LabLenh_RO.Size = New System.Drawing.Size(71, 13)
        Me.LabLenh_RO.TabIndex = 169
        Me.LabLenh_RO.Tag = "R/O"
        Me.LabLenh_RO.Text = "Số R/O"
        Me.LabLenh_RO.Visible = False
        '
        'TxtLenh_RO
        '
        Me.TxtLenh_RO.BackColor = System.Drawing.Color.White
        Me.TxtLenh_RO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLenh_RO.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtLenh_RO.ForeColor = System.Drawing.Color.Navy
        Me.TxtLenh_RO.Location = New System.Drawing.Point(655, 62)
        Me.TxtLenh_RO.Name = "TxtLenh_RO"
        Me.TxtLenh_RO.Size = New System.Drawing.Size(21, 21)
        Me.TxtLenh_RO.TabIndex = 168
        Me.TxtLenh_RO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLenh_RO.Visible = False
        '
        'LabLenh_PO
        '
        Me.LabLenh_PO.BackColor = System.Drawing.Color.Transparent
        Me.LabLenh_PO.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabLenh_PO.ForeColor = System.Drawing.Color.Navy
        Me.LabLenh_PO.Location = New System.Drawing.Point(668, 46)
        Me.LabLenh_PO.Name = "LabLenh_PO"
        Me.LabLenh_PO.Size = New System.Drawing.Size(60, 13)
        Me.LabLenh_PO.TabIndex = 171
        Me.LabLenh_PO.Tag = "P/O"
        Me.LabLenh_PO.Text = "Số P/O"
        Me.LabLenh_PO.Visible = False
        '
        'TxtLenh_PO
        '
        Me.TxtLenh_PO.BackColor = System.Drawing.Color.White
        Me.TxtLenh_PO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLenh_PO.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtLenh_PO.ForeColor = System.Drawing.Color.Navy
        Me.TxtLenh_PO.Location = New System.Drawing.Point(593, 62)
        Me.TxtLenh_PO.Name = "TxtLenh_PO"
        Me.TxtLenh_PO.Size = New System.Drawing.Size(21, 21)
        Me.TxtLenh_PO.TabIndex = 170
        Me.TxtLenh_PO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLenh_PO.Visible = False
        '
        'LabLenh_SO
        '
        Me.LabLenh_SO.BackColor = System.Drawing.Color.Transparent
        Me.LabLenh_SO.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabLenh_SO.ForeColor = System.Drawing.Color.Navy
        Me.LabLenh_SO.Location = New System.Drawing.Point(666, 34)
        Me.LabLenh_SO.Name = "LabLenh_SO"
        Me.LabLenh_SO.Size = New System.Drawing.Size(60, 13)
        Me.LabLenh_SO.TabIndex = 173
        Me.LabLenh_SO.Tag = "S/O"
        Me.LabLenh_SO.Text = "Số S/O"
        Me.LabLenh_SO.Visible = False
        '
        'TxtLenh_SO
        '
        Me.TxtLenh_SO.BackColor = System.Drawing.Color.White
        Me.TxtLenh_SO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLenh_SO.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtLenh_SO.ForeColor = System.Drawing.Color.Navy
        Me.TxtLenh_SO.Location = New System.Drawing.Point(686, 62)
        Me.TxtLenh_SO.Name = "TxtLenh_SO"
        Me.TxtLenh_SO.Size = New System.Drawing.Size(21, 21)
        Me.TxtLenh_SO.TabIndex = 172
        Me.TxtLenh_SO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLenh_SO.Visible = False
        '
        'LabT_So_Luong
        '
        Me.LabT_So_Luong.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabT_So_Luong.BackColor = System.Drawing.Color.Transparent
        Me.LabT_So_Luong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabT_So_Luong.ForeColor = System.Drawing.Color.Navy
        Me.LabT_So_Luong.Location = New System.Drawing.Point(382, 447)
        Me.LabT_So_Luong.Margin = New System.Windows.Forms.Padding(0)
        Me.LabT_So_Luong.Name = "LabT_So_Luong"
        Me.LabT_So_Luong.Size = New System.Drawing.Size(82, 13)
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
        Me.TxtT_SO_LUONG.Location = New System.Drawing.Point(474, 446)
        Me.TxtT_SO_LUONG.MaxWholeDigits = 16
        Me.TxtT_SO_LUONG.Name = "TxtT_SO_LUONG"
        Me.TxtT_SO_LUONG.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_SO_LUONG.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_SO_LUONG.ReadOnly = True
        Me.TxtT_SO_LUONG.Size = New System.Drawing.Size(119, 20)
        Me.TxtT_SO_LUONG.TabIndex = 174
        Me.TxtT_SO_LUONG.TabStop = False
        Me.TxtT_SO_LUONG.Text = "0.0"
        Me.TxtT_SO_LUONG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTen_KhVAT
        '
        Me.TxtTen_KhVAT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTen_KhVAT.BackColor = System.Drawing.Color.White
        Me.TxtTen_KhVAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_KhVAT.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_KhVAT.Location = New System.Drawing.Point(630, 90)
        Me.TxtTen_KhVAT.Name = "TxtTen_KhVAT"
        Me.TxtTen_KhVAT.Size = New System.Drawing.Size(366, 20)
        Me.TxtTen_KhVAT.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(558, 115)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 14)
        Me.Label1.TabIndex = 178
        Me.Label1.Tag = "Address VAT"
        Me.Label1.Text = "Địa chỉ VAT"
        '
        'TxtDia_ChiVAT
        '
        Me.TxtDia_ChiVAT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDia_ChiVAT.BackColor = System.Drawing.Color.White
        Me.TxtDia_ChiVAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtDia_ChiVAT.ForeColor = System.Drawing.Color.Navy
        Me.TxtDia_ChiVAT.Location = New System.Drawing.Point(630, 112)
        Me.TxtDia_ChiVAT.Name = "TxtDia_ChiVAT"
        Me.TxtDia_ChiVAT.Size = New System.Drawing.Size(366, 20)
        Me.TxtDia_ChiVAT.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(558, 93)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 14)
        Me.Label2.TabIndex = 177
        Me.Label2.Tag = "Name VAT"
        Me.Label2.Text = "Tên VAT"
        '
        'TxtMa_So_Thue
        '
        Me.TxtMa_So_Thue.BackColor = System.Drawing.Color.White
        Me.TxtMa_So_Thue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_So_Thue.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_So_Thue.Location = New System.Drawing.Point(336, 133)
        Me.TxtMa_So_Thue.Name = "TxtMa_So_Thue"
        Me.TxtMa_So_Thue.Size = New System.Drawing.Size(222, 20)
        Me.TxtMa_So_Thue.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(262, 137)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 14)
        Me.Label3.TabIndex = 181
        Me.Label3.Tag = "Receiver"
        Me.Label3.Text = "Mã số thuế"
        '
        'txtTen_BP_H
        '
        Me.txtTen_BP_H.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTen_BP_H.BackColor = System.Drawing.Color.White
        Me.txtTen_BP_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtTen_BP_H.ForeColor = System.Drawing.Color.Navy
        Me.txtTen_BP_H.Location = New System.Drawing.Point(747, 155)
        Me.txtTen_BP_H.Name = "txtTen_BP_H"
        Me.txtTen_BP_H.ReadOnly = True
        Me.txtTen_BP_H.Size = New System.Drawing.Size(249, 20)
        Me.txtTen_BP_H.TabIndex = 184
        Me.txtTen_BP_H.TabStop = False
        '
        'TxtMa_Bp_H
        '
        Me.TxtMa_Bp_H._ActilookupPopup = False
        Me.TxtMa_Bp_H.CyberActilookupPopup = True
        Me.TxtMa_Bp_H.Dv_ListDetail = Nothing
        Me.TxtMa_Bp_H.Dv_Master = Nothing
        Me.TxtMa_Bp_H.FilterClient = ""
        Me.TxtMa_Bp_H.FilterSQL = ""
        Me.TxtMa_Bp_H.Location = New System.Drawing.Point(630, 155)
        Me.TxtMa_Bp_H.Name = "TxtMa_Bp_H"
        Me.TxtMa_Bp_H.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Bp_H.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Bp_H.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Bp_H.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Bp_H.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_Bp_H.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_Bp_H.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Bp_H.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_Bp_H.TabIndex = 12
        Me.TxtMa_Bp_H.Table_Name = ""
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(558, 160)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 14)
        Me.Label4.TabIndex = 183
        Me.Label4.Tag = "Cus code"
        Me.Label4.Text = "Bộ phận"
        '
        'txtTen_HS_H
        '
        Me.txtTen_HS_H.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTen_HS_H.BackColor = System.Drawing.Color.White
        Me.txtTen_HS_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtTen_HS_H.ForeColor = System.Drawing.Color.Navy
        Me.txtTen_HS_H.Location = New System.Drawing.Point(747, 176)
        Me.txtTen_HS_H.Name = "txtTen_HS_H"
        Me.txtTen_HS_H.ReadOnly = True
        Me.txtTen_HS_H.Size = New System.Drawing.Size(249, 20)
        Me.txtTen_HS_H.TabIndex = 187
        Me.txtTen_HS_H.TabStop = False
        '
        'txtMa_HS_H
        '
        Me.txtMa_HS_H._ActilookupPopup = False
        Me.txtMa_HS_H.CyberActilookupPopup = True
        Me.txtMa_HS_H.Dv_ListDetail = Nothing
        Me.txtMa_HS_H.Dv_Master = Nothing
        Me.txtMa_HS_H.FilterClient = ""
        Me.txtMa_HS_H.FilterSQL = ""
        Me.txtMa_HS_H.Location = New System.Drawing.Point(630, 176)
        Me.txtMa_HS_H.Name = "txtMa_HS_H"
        Me.txtMa_HS_H.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtMa_HS_H.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtMa_HS_H.Properties.Appearance.Options.UseFont = True
        Me.txtMa_HS_H.Properties.Appearance.Options.UseForeColor = True
        Me.txtMa_HS_H.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtMa_HS_H.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtMa_HS_H.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.txtMa_HS_H.Size = New System.Drawing.Size(116, 20)
        Me.txtMa_HS_H.TabIndex = 13
        Me.txtMa_HS_H.Table_Name = ""
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(558, 183)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 14)
        Me.Label5.TabIndex = 186
        Me.Label5.Tag = "Cus code"
        Me.Label5.Text = "Nhân viên"
        '
        'txtTen_NX
        '
        Me.txtTen_NX.BackColor = System.Drawing.Color.White
        Me.txtTen_NX.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtTen_NX.ForeColor = System.Drawing.Color.Navy
        Me.txtTen_NX.Location = New System.Drawing.Point(198, 155)
        Me.txtTen_NX.Name = "txtTen_NX"
        Me.txtTen_NX.ReadOnly = True
        Me.txtTen_NX.Size = New System.Drawing.Size(360, 20)
        Me.txtTen_NX.TabIndex = 190
        Me.txtTen_NX.TabStop = False
        '
        'txtMa_NX
        '
        Me.txtMa_NX._ActilookupPopup = False
        Me.txtMa_NX.CyberActilookupPopup = True
        Me.txtMa_NX.Dv_ListDetail = Nothing
        Me.txtMa_NX.Dv_Master = Nothing
        Me.txtMa_NX.FilterClient = ""
        Me.txtMa_NX.FilterSQL = ""
        Me.txtMa_NX.Location = New System.Drawing.Point(80, 155)
        Me.txtMa_NX.Name = "txtMa_NX"
        Me.txtMa_NX.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtMa_NX.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtMa_NX.Properties.Appearance.Options.UseFont = True
        Me.txtMa_NX.Properties.Appearance.Options.UseForeColor = True
        Me.txtMa_NX.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtMa_NX.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtMa_NX.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.txtMa_NX.Size = New System.Drawing.Size(116, 20)
        Me.txtMa_NX.TabIndex = 10
        Me.txtMa_NX.Table_Name = ""
        '
        'LabMa_Nx
        '
        Me.LabMa_Nx.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_Nx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabMa_Nx.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_Nx.Location = New System.Drawing.Point(1, 161)
        Me.LabMa_Nx.Margin = New System.Windows.Forms.Padding(0)
        Me.LabMa_Nx.Name = "LabMa_Nx"
        Me.LabMa_Nx.Size = New System.Drawing.Size(78, 14)
        Me.LabMa_Nx.TabIndex = 189
        Me.LabMa_Nx.Tag = "Acc credit"
        Me.LabMa_Nx.Text = "Tk Nợ"
        '
        'TxtTen_vtthue
        '
        Me.TxtTen_vtthue.BackColor = System.Drawing.Color.White
        Me.TxtTen_vtthue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_vtthue.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_vtthue.Location = New System.Drawing.Point(80, 176)
        Me.TxtTen_vtthue.Name = "TxtTen_vtthue"
        Me.TxtTen_vtthue.Size = New System.Drawing.Size(478, 20)
        Me.TxtTen_vtthue.TabIndex = 11
        '
        'LabTen_vtthue
        '
        Me.LabTen_vtthue.BackColor = System.Drawing.Color.Transparent
        Me.LabTen_vtthue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabTen_vtthue.ForeColor = System.Drawing.Color.Navy
        Me.LabTen_vtthue.Location = New System.Drawing.Point(1, 183)
        Me.LabTen_vtthue.Margin = New System.Windows.Forms.Padding(0)
        Me.LabTen_vtthue.Name = "LabTen_vtthue"
        Me.LabTen_vtthue.Size = New System.Drawing.Size(76, 14)
        Me.LabTen_vtthue.TabIndex = 192
        Me.LabTen_vtthue.Tag = "Googs"
        Me.LabTen_vtthue.Text = "Nhóm hàng"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(381, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 196
        Me.Label9.Tag = "Seri"
        Me.Label9.Text = "Số Seri"
        '
        'TxtSo_Seri
        '
        Me.TxtSo_Seri.BackColor = System.Drawing.Color.White
        Me.TxtSo_Seri.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_Seri.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtSo_Seri.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Seri.Location = New System.Drawing.Point(450, 59)
        Me.TxtSo_Seri.Name = "TxtSo_Seri"
        Me.TxtSo_Seri.Size = New System.Drawing.Size(108, 21)
        Me.TxtSo_Seri.TabIndex = 195
        Me.TxtSo_Seri.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabT_Thue_NT
        '
        Me.LabT_Thue_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabT_Thue_NT.BackColor = System.Drawing.Color.Transparent
        Me.LabT_Thue_NT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabT_Thue_NT.ForeColor = System.Drawing.Color.Navy
        Me.LabT_Thue_NT.Location = New System.Drawing.Point(382, 490)
        Me.LabT_Thue_NT.Margin = New System.Windows.Forms.Padding(0)
        Me.LabT_Thue_NT.Name = "LabT_Thue_NT"
        Me.LabT_Thue_NT.Size = New System.Drawing.Size(88, 13)
        Me.LabT_Thue_NT.TabIndex = 201
        Me.LabT_Thue_NT.Tag = "Total tax"
        Me.LabT_Thue_NT.Text = "Tiền thuế"
        '
        'TxtT_Thue
        '
        Me.TxtT_Thue.AllowNegative = True
        Me.TxtT_Thue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Thue.BackColor = System.Drawing.Color.White
        Me.TxtT_Thue.Flags = 7680
        Me.TxtT_Thue.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Thue.InputMask = "### ### ### ### ###.#"
        Me.TxtT_Thue.Location = New System.Drawing.Point(595, 489)
        Me.TxtT_Thue.MaxWholeDigits = 16
        Me.TxtT_Thue.Name = "TxtT_Thue"
        Me.TxtT_Thue.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Thue.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Thue.ReadOnly = True
        Me.TxtT_Thue.Size = New System.Drawing.Size(119, 20)
        Me.TxtT_Thue.TabIndex = 200
        Me.TxtT_Thue.TabStop = False
        Me.TxtT_Thue.Text = "1.0"
        Me.TxtT_Thue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtT_thue_NT
        '
        Me.TxtT_thue_NT.AllowNegative = True
        Me.TxtT_thue_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_thue_NT.BackColor = System.Drawing.Color.White
        Me.TxtT_thue_NT.Flags = 7680
        Me.TxtT_thue_NT.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_thue_NT.InputMask = "### ### ### ### ###.#"
        Me.TxtT_thue_NT.Location = New System.Drawing.Point(474, 489)
        Me.TxtT_thue_NT.MaxWholeDigits = 16
        Me.TxtT_thue_NT.Name = "TxtT_thue_NT"
        Me.TxtT_thue_NT.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_thue_NT.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_thue_NT.ReadOnly = True
        Me.TxtT_thue_NT.Size = New System.Drawing.Size(119, 20)
        Me.TxtT_thue_NT.TabIndex = 199
        Me.TxtT_thue_NT.TabStop = False
        Me.TxtT_thue_NT.Text = "1.0"
        Me.TxtT_thue_NT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtT_Tien
        '
        Me.TxtT_Tien.AllowNegative = True
        Me.TxtT_Tien.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Tien.BackColor = System.Drawing.Color.White
        Me.TxtT_Tien.Flags = 7680
        Me.TxtT_Tien.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Tien.InputMask = "### ### ### ### ###.#"
        Me.TxtT_Tien.Location = New System.Drawing.Point(595, 468)
        Me.TxtT_Tien.MaxWholeDigits = 16
        Me.TxtT_Tien.Name = "TxtT_Tien"
        Me.TxtT_Tien.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Tien.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Tien.ReadOnly = True
        Me.TxtT_Tien.Size = New System.Drawing.Size(119, 20)
        Me.TxtT_Tien.TabIndex = 198
        Me.TxtT_Tien.TabStop = False
        Me.TxtT_Tien.Text = "1.0"
        Me.TxtT_Tien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtT_Tien_NT
        '
        Me.TxtT_Tien_NT.AllowNegative = True
        Me.TxtT_Tien_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Tien_NT.BackColor = System.Drawing.Color.White
        Me.TxtT_Tien_NT.Flags = 7680
        Me.TxtT_Tien_NT.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Tien_NT.InputMask = "### ### ### ### ###.#"
        Me.TxtT_Tien_NT.Location = New System.Drawing.Point(474, 468)
        Me.TxtT_Tien_NT.MaxWholeDigits = 16
        Me.TxtT_Tien_NT.Name = "TxtT_Tien_NT"
        Me.TxtT_Tien_NT.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Tien_NT.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Tien_NT.ReadOnly = True
        Me.TxtT_Tien_NT.Size = New System.Drawing.Size(119, 20)
        Me.TxtT_Tien_NT.TabIndex = 197
        Me.TxtT_Tien_NT.TabStop = False
        Me.TxtT_Tien_NT.Text = "1.0"
        Me.TxtT_Tien_NT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTk_Thue_Co
        '
        Me.TxtTk_Thue_Co._ActilookupPopup = False
        Me.TxtTk_Thue_Co.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtTk_Thue_Co.CyberActilookupPopup = True
        Me.TxtTk_Thue_Co.Dv_ListDetail = Nothing
        Me.TxtTk_Thue_Co.Dv_Master = Nothing
        Me.TxtTk_Thue_Co.FilterClient = ""
        Me.TxtTk_Thue_Co.FilterSQL = ""
        Me.TxtTk_Thue_Co.Location = New System.Drawing.Point(121, 488)
        Me.TxtTk_Thue_Co.Name = "TxtTk_Thue_Co"
        Me.TxtTk_Thue_Co.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTk_Thue_Co.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTk_Thue_Co.Properties.Appearance.Options.UseFont = True
        Me.TxtTk_Thue_Co.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTk_Thue_Co.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtTk_Thue_Co.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtTk_Thue_Co.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTk_Thue_Co.Size = New System.Drawing.Size(116, 20)
        Me.TxtTk_Thue_Co.TabIndex = 209
        Me.TxtTk_Thue_Co.Table_Name = ""
        Me.TxtTk_Thue_Co.TabStop = False
        '
        'LabTk_Thue_No
        '
        Me.LabTk_Thue_No.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabTk_Thue_No.BackColor = System.Drawing.Color.Transparent
        Me.LabTk_Thue_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabTk_Thue_No.ForeColor = System.Drawing.Color.Navy
        Me.LabTk_Thue_No.Location = New System.Drawing.Point(35, 469)
        Me.LabTk_Thue_No.Margin = New System.Windows.Forms.Padding(0)
        Me.LabTk_Thue_No.Name = "LabTk_Thue_No"
        Me.LabTk_Thue_No.Size = New System.Drawing.Size(82, 13)
        Me.LabTk_Thue_No.TabIndex = 210
        Me.LabTk_Thue_No.Tag = "Acc Credit Tax"
        Me.LabTk_Thue_No.Text = "TK thuế nợ"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(35, 448)
        Me.Label13.Margin = New System.Windows.Forms.Padding(0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 13)
        Me.Label13.TabIndex = 212
        Me.Label13.Tag = "Tax Acc"
        Me.Label13.Text = "Thuế suất"
        '
        'TxtThue_Suat
        '
        Me.TxtThue_Suat.AllowNegative = True
        Me.TxtThue_Suat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtThue_Suat.BackColor = System.Drawing.Color.White
        Me.TxtThue_Suat.Flags = 7680
        Me.TxtThue_Suat.ForeColor = System.Drawing.Color.Navy
        Me.TxtThue_Suat.InputMask = "###"
        Me.TxtThue_Suat.Location = New System.Drawing.Point(175, 446)
        Me.TxtThue_Suat.MaxWholeDigits = 10
        Me.TxtThue_Suat.Name = "TxtThue_Suat"
        Me.TxtThue_Suat.RangeMax = 1.7976931348623157E+308R
        Me.TxtThue_Suat.RangeMin = -1.7976931348623157E+308R
        Me.TxtThue_Suat.ReadOnly = True
        Me.TxtThue_Suat.Size = New System.Drawing.Size(42, 20)
        Me.TxtThue_Suat.TabIndex = 213
        Me.TxtThue_Suat.TabStop = False
        Me.TxtThue_Suat.Text = "0"
        Me.TxtThue_Suat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtMa_Thue
        '
        Me.TxtMa_Thue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Thue.BackColor = System.Drawing.Color.White
        Me.TxtMa_Thue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Thue.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Thue.Location = New System.Drawing.Point(121, 446)
        Me.TxtMa_Thue.Name = "TxtMa_Thue"
        Me.TxtMa_Thue.Size = New System.Drawing.Size(52, 20)
        Me.TxtMa_Thue.TabIndex = 214
        Me.TxtMa_Thue.Text = "10"
        '
        'LabTk_Thue_Co
        '
        Me.LabTk_Thue_Co.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabTk_Thue_Co.BackColor = System.Drawing.Color.Transparent
        Me.LabTk_Thue_Co.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabTk_Thue_Co.ForeColor = System.Drawing.Color.Navy
        Me.LabTk_Thue_Co.Location = New System.Drawing.Point(35, 490)
        Me.LabTk_Thue_Co.Margin = New System.Windows.Forms.Padding(0)
        Me.LabTk_Thue_Co.Name = "LabTk_Thue_Co"
        Me.LabTk_Thue_Co.Size = New System.Drawing.Size(82, 13)
        Me.LabTk_Thue_Co.TabIndex = 216
        Me.LabTk_Thue_Co.Tag = "Acc debit Tax"
        Me.LabTk_Thue_Co.Text = "TK thuế có"
        '
        'ChkSua_Thue
        '
        Me.ChkSua_Thue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkSua_Thue.AutoSize = True
        Me.ChkSua_Thue.Location = New System.Drawing.Point(788, 489)
        Me.ChkSua_Thue.Name = "ChkSua_Thue"
        Me.ChkSua_Thue.Size = New System.Drawing.Size(89, 17)
        Me.ChkSua_Thue.TabIndex = 217
        Me.ChkSua_Thue.TabStop = False
        Me.ChkSua_Thue.Tag = "Edit tax"
        Me.ChkSua_Thue.Text = "Sửa tiền thuế"
        Me.ChkSua_Thue.UseVisualStyleBackColor = True
        '
        'ChkSua_TkThue
        '
        Me.ChkSua_TkThue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkSua_TkThue.AutoSize = True
        Me.ChkSua_TkThue.Location = New System.Drawing.Point(788, 466)
        Me.ChkSua_TkThue.Name = "ChkSua_TkThue"
        Me.ChkSua_TkThue.Size = New System.Drawing.Size(100, 17)
        Me.ChkSua_TkThue.TabIndex = 218
        Me.ChkSua_TkThue.TabStop = False
        Me.ChkSua_TkThue.Tag = "Maturity tax"
        Me.ChkSua_TkThue.Text = "Hạch toán thuế"
        Me.ChkSua_TkThue.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(911, 466)
        Me.Label15.Margin = New System.Windows.Forms.Padding(0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 14)
        Me.Label15.TabIndex = 221
        Me.Label15.Tag = "Total"
        Me.Label15.Text = "Hạn thanh toán"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtHan_TT
        '
        Me.TxtHan_TT.AllowNegative = True
        Me.TxtHan_TT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtHan_TT.BackColor = System.Drawing.Color.White
        Me.TxtHan_TT.Flags = 7680
        Me.TxtHan_TT.ForeColor = System.Drawing.Color.Navy
        Me.TxtHan_TT.InputMask = "### ###"
        Me.TxtHan_TT.Location = New System.Drawing.Point(914, 485)
        Me.TxtHan_TT.MaxWholeDigits = 5
        Me.TxtHan_TT.Name = "TxtHan_TT"
        Me.TxtHan_TT.RangeMax = 1.7976931348623157E+308R
        Me.TxtHan_TT.RangeMin = -1.7976931348623157E+308R
        Me.TxtHan_TT.ReadOnly = True
        Me.TxtHan_TT.Size = New System.Drawing.Size(38, 20)
        Me.TxtHan_TT.TabIndex = 220
        Me.TxtHan_TT.Text = "0"
        Me.TxtHan_TT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(955, 486)
        Me.Label16.Margin = New System.Windows.Forms.Padding(0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 17)
        Me.Label16.TabIndex = 222
        Me.Label16.Tag = "Day"
        Me.Label16.Text = "Ngày"
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(220, 448)
        Me.Label17.Margin = New System.Windows.Forms.Padding(0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(13, 13)
        Me.Label17.TabIndex = 223
        Me.Label17.Tag = "%"
        Me.Label17.Text = "%"
        '
        'TxtTk_Thue_No
        '
        Me.TxtTk_Thue_No._ActilookupPopup = False
        Me.TxtTk_Thue_No.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtTk_Thue_No.CyberActilookupPopup = True
        Me.TxtTk_Thue_No.Dv_ListDetail = Nothing
        Me.TxtTk_Thue_No.Dv_Master = Nothing
        Me.TxtTk_Thue_No.FilterClient = ""
        Me.TxtTk_Thue_No.FilterSQL = ""
        Me.TxtTk_Thue_No.Location = New System.Drawing.Point(121, 467)
        Me.TxtTk_Thue_No.Name = "TxtTk_Thue_No"
        Me.TxtTk_Thue_No.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTk_Thue_No.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTk_Thue_No.Properties.Appearance.Options.UseFont = True
        Me.TxtTk_Thue_No.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTk_Thue_No.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtTk_Thue_No.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtTk_Thue_No.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTk_Thue_No.Size = New System.Drawing.Size(116, 20)
        Me.TxtTk_Thue_No.TabIndex = 225
        Me.TxtTk_Thue_No.Table_Name = ""
        Me.TxtTk_Thue_No.TabStop = False
        '
        'TxtLenh_Vt
        '
        Me.TxtLenh_Vt.BackColor = System.Drawing.Color.White
        Me.TxtLenh_Vt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLenh_Vt.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtLenh_Vt.ForeColor = System.Drawing.Color.Navy
        Me.TxtLenh_Vt.Location = New System.Drawing.Point(623, 62)
        Me.TxtLenh_Vt.Name = "TxtLenh_Vt"
        Me.TxtLenh_Vt.Size = New System.Drawing.Size(21, 21)
        Me.TxtLenh_Vt.TabIndex = 243
        Me.TxtLenh_Vt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLenh_Vt.Visible = False
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(382, 468)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 13)
        Me.Label10.TabIndex = 205
        Me.Label10.Tag = "Pay cash"
        Me.Label10.Text = "Tổng hàng"
        '
        'LabMau_BC
        '
        Me.LabMau_BC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabMau_BC.BackColor = System.Drawing.Color.Transparent
        Me.LabMau_BC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabMau_BC.ForeColor = System.Drawing.Color.Navy
        Me.LabMau_BC.Location = New System.Drawing.Point(282, 448)
        Me.LabMau_BC.Margin = New System.Windows.Forms.Padding(0)
        Me.LabMau_BC.Name = "LabMau_BC"
        Me.LabMau_BC.Size = New System.Drawing.Size(61, 13)
        Me.LabMau_BC.TabIndex = 297
        Me.LabMau_BC.Tag = "VAT Form"
        Me.LabMau_BC.Text = "Mẫu VAT"
        '
        'TxtMau_BC
        '
        Me.TxtMau_BC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtMau_BC.BackColor = System.Drawing.Color.White
        Me.TxtMau_BC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMau_BC.ForeColor = System.Drawing.Color.Navy
        Me.TxtMau_BC.Location = New System.Drawing.Point(243, 446)
        Me.TxtMau_BC.Name = "TxtMau_BC"
        Me.TxtMau_BC.Size = New System.Drawing.Size(30, 20)
        Me.TxtMau_BC.TabIndex = 296
        Me.TxtMau_BC.TabStop = False
        Me.TxtMau_BC.Text = "1"
        '
        'ChkE_Thue
        '
        Me.ChkE_Thue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkE_Thue.AutoSize = True
        Me.ChkE_Thue.Location = New System.Drawing.Point(715, 491)
        Me.ChkE_Thue.Name = "ChkE_Thue"
        Me.ChkE_Thue.Size = New System.Drawing.Size(15, 14)
        Me.ChkE_Thue.TabIndex = 298
        Me.ChkE_Thue.TabStop = False
        Me.ChkE_Thue.Tag = ""
        Me.ChkE_Thue.UseVisualStyleBackColor = True
        '
        'ChkE_Tien
        '
        Me.ChkE_Tien.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkE_Tien.AutoSize = True
        Me.ChkE_Tien.Location = New System.Drawing.Point(715, 471)
        Me.ChkE_Tien.Name = "ChkE_Tien"
        Me.ChkE_Tien.Size = New System.Drawing.Size(15, 14)
        Me.ChkE_Tien.TabIndex = 299
        Me.ChkE_Tien.TabStop = False
        Me.ChkE_Tien.Tag = ""
        Me.ChkE_Tien.UseVisualStyleBackColor = True
        '
        'ChkNonVAT
        '
        Me.ChkNonVAT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNonVAT.AutoSize = True
        Me.ChkNonVAT.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkNonVAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkNonVAT.ForeColor = System.Drawing.Color.Navy
        Me.ChkNonVAT.Location = New System.Drawing.Point(933, 514)
        Me.ChkNonVAT.Name = "ChkNonVAT"
        Me.ChkNonVAT.Size = New System.Drawing.Size(62, 17)
        Me.ChkNonVAT.TabIndex = 2128
        Me.ChkNonVAT.TabStop = False
        Me.ChkNonVAT.Tag = "Non VAT"
        Me.ChkNonVAT.Text = "NonVat"
        Me.ChkNonVAT.UseVisualStyleBackColor = True
        '
        'CbbMa_TTCP_H
        '
        Me.CbbMa_TTCP_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbbMa_TTCP_H.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_TTCP_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa_TTCP_H.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_TTCP_H.FormattingEnabled = True
        Me.CbbMa_TTCP_H.Location = New System.Drawing.Point(802, 2)
        Me.CbbMa_TTCP_H.Name = "CbbMa_TTCP_H"
        Me.CbbMa_TTCP_H.Size = New System.Drawing.Size(194, 23)
        Me.CbbMa_TTCP_H.TabIndex = 2159
        Me.CbbMa_TTCP_H.TabStop = False
        '
        'LabMa_TTCP_H
        '
        Me.LabMa_TTCP_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabMa_TTCP_H.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_TTCP_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMa_TTCP_H.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_TTCP_H.Location = New System.Drawing.Point(693, 3)
        Me.LabMa_TTCP_H.Margin = New System.Windows.Forms.Padding(0)
        Me.LabMa_TTCP_H.Name = "LabMa_TTCP_H"
        Me.LabMa_TTCP_H.Size = New System.Drawing.Size(106, 19)
        Me.LabMa_TTCP_H.TabIndex = 2162
        Me.LabMa_TTCP_H.Tag = "Cost centrer"
        Me.LabMa_TTCP_H.Text = "TTCP"
        Me.LabMa_TTCP_H.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PXF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1001, 589)
        Me.Controls.Add(Me.LabMa_TTCP_H)
        Me.Controls.Add(Me.CbbMa_TTCP_H)
        Me.Controls.Add(Me.ChkNonVAT)
        Me.Controls.Add(Me.ChkE_Tien)
        Me.Controls.Add(Me.ChkE_Thue)
        Me.Controls.Add(Me.LabMau_BC)
        Me.Controls.Add(Me.TxtMau_BC)
        Me.Controls.Add(Me.TxtLenh_Vt)
        Me.Controls.Add(Me.TxtTk_Thue_No)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TxtHan_TT)
        Me.Controls.Add(Me.ChkSua_TkThue)
        Me.Controls.Add(Me.ChkSua_Thue)
        Me.Controls.Add(Me.LabTk_Thue_Co)
        Me.Controls.Add(Me.TxtMa_Thue)
        Me.Controls.Add(Me.TxtThue_Suat)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtTk_Thue_Co)
        Me.Controls.Add(Me.LabTk_Thue_No)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LabT_Thue_NT)
        Me.Controls.Add(Me.TxtT_Thue)
        Me.Controls.Add(Me.TxtT_thue_NT)
        Me.Controls.Add(Me.TxtT_Tien)
        Me.Controls.Add(Me.TxtT_Tien_NT)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtSo_Seri)
        Me.Controls.Add(Me.TxtTen_vtthue)
        Me.Controls.Add(Me.LabTen_vtthue)
        Me.Controls.Add(Me.txtTen_NX)
        Me.Controls.Add(Me.txtMa_NX)
        Me.Controls.Add(Me.LabMa_Nx)
        Me.Controls.Add(Me.txtTen_HS_H)
        Me.Controls.Add(Me.txtMa_HS_H)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTen_BP_H)
        Me.Controls.Add(Me.TxtMa_Bp_H)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtMa_So_Thue)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTen_KhVAT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtDia_ChiVAT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabT_So_Luong)
        Me.Controls.Add(Me.TxtT_SO_LUONG)
        Me.Controls.Add(Me.LabLenh_SO)
        Me.Controls.Add(Me.TxtLenh_SO)
        Me.Controls.Add(Me.LabLenh_PO)
        Me.Controls.Add(Me.TxtLenh_PO)
        Me.Controls.Add(Me.LabLenh_RO)
        Me.Controls.Add(Me.TxtLenh_RO)
        Me.Controls.Add(Me.LabT_TT_NT)
        Me.Controls.Add(Me.TxtT_TT)
        Me.Controls.Add(Me.TxtT_TT_NT)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.TxtTen_kh)
        Me.Controls.Add(Me.TxtMa_Kh)
        Me.Controls.Add(Me.LabTy_gia)
        Me.Controls.Add(Me.Detail)
        Me.Controls.Add(Me.TxtMa_NT)
        Me.Controls.Add(Me.TxtTy_Gia)
        Me.Controls.Add(Me.TxtNgay_LCt)
        Me.Controls.Add(Me.TxtNgay_Ct)
        Me.Controls.Add(Me.CbbMa_GD)
        Me.Controls.Add(Me.LabDia_Chi)
        Me.Controls.Add(Me.TxtDia_Chi)
        Me.Controls.Add(Me.TxtMa_Quyen)
        Me.Controls.Add(Me.LabMa_Quyen)
        Me.Controls.Add(Me.LabNgay_LCt)
        Me.Controls.Add(Me.LabNgay_Ct)
        Me.Controls.Add(Me.txtDien_giai)
        Me.Controls.Add(Me.LabDien_Giai)
        Me.Controls.Add(Me.lblLoai_ct)
        Me.Controls.Add(Me.txtOng_ba)
        Me.Controls.Add(Me.LabOng_ba)
        Me.Controls.Add(Me.lblSo_ct)
        Me.Controls.Add(Me.TxtSo_Ct)
        Me.Controls.Add(Me.LabMa_kh)
        Me.Controls.Add(Me.LabMa_NT)
        Me.Controls.Add(Me.TxtStt_Rec)
        Me.Controls.Add(Me.TxtMa_Dvcs)
        Me.KeyPreview = True
        Me.Name = "PXF"
        Me.Controls.SetChildIndex(Me.TxtUser_id, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.TxtStt_Rec, 0)
        Me.Controls.SetChildIndex(Me.LabMa_NT, 0)
        Me.Controls.SetChildIndex(Me.LabMa_kh, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Ct, 0)
        Me.Controls.SetChildIndex(Me.lblSo_ct, 0)
        Me.Controls.SetChildIndex(Me.LabOng_ba, 0)
        Me.Controls.SetChildIndex(Me.txtOng_ba, 0)
        Me.Controls.SetChildIndex(Me.lblLoai_ct, 0)
        Me.Controls.SetChildIndex(Me.LabDien_Giai, 0)
        Me.Controls.SetChildIndex(Me.txtDien_giai, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_Ct, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_LCt, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Quyen, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Quyen, 0)
        Me.Controls.SetChildIndex(Me.TxtDia_Chi, 0)
        Me.Controls.SetChildIndex(Me.LabDia_Chi, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_GD, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_LCt, 0)
        Me.Controls.SetChildIndex(Me.TxtTy_Gia, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_NT, 0)
        Me.Controls.SetChildIndex(Me.Detail, 0)
        Me.Controls.SetChildIndex(Me.LabTy_gia, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kh, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kh, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtT_TT_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtT_TT, 0)
        Me.Controls.SetChildIndex(Me.LabT_TT_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtLenh_RO, 0)
        Me.Controls.SetChildIndex(Me.LabLenh_RO, 0)
        Me.Controls.SetChildIndex(Me.TxtLenh_PO, 0)
        Me.Controls.SetChildIndex(Me.LabLenh_PO, 0)
        Me.Controls.SetChildIndex(Me.TxtLenh_SO, 0)
        Me.Controls.SetChildIndex(Me.LabLenh_SO, 0)
        Me.Controls.SetChildIndex(Me.TxtT_SO_LUONG, 0)
        Me.Controls.SetChildIndex(Me.LabT_So_Luong, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtDia_ChiVAT, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_KhVAT, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_So_Thue, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Bp_H, 0)
        Me.Controls.SetChildIndex(Me.txtTen_BP_H, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.txtMa_HS_H, 0)
        Me.Controls.SetChildIndex(Me.txtTen_HS_H, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Nx, 0)
        Me.Controls.SetChildIndex(Me.txtMa_NX, 0)
        Me.Controls.SetChildIndex(Me.txtTen_NX, 0)
        Me.Controls.SetChildIndex(Me.LabTen_vtthue, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_vtthue, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Seri, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Tien_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Tien, 0)
        Me.Controls.SetChildIndex(Me.TxtT_thue_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Thue, 0)
        Me.Controls.SetChildIndex(Me.LabT_Thue_NT, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.LabTk_Thue_No, 0)
        Me.Controls.SetChildIndex(Me.TxtTk_Thue_Co, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.TxtThue_Suat, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Thue, 0)
        Me.Controls.SetChildIndex(Me.LabTk_Thue_Co, 0)
        Me.Controls.SetChildIndex(Me.ChkSua_Thue, 0)
        Me.Controls.SetChildIndex(Me.ChkSua_TkThue, 0)
        Me.Controls.SetChildIndex(Me.TxtHan_TT, 0)
        Me.Controls.SetChildIndex(Me.Label15, 0)
        Me.Controls.SetChildIndex(Me.Label16, 0)
        Me.Controls.SetChildIndex(Me.Label17, 0)
        Me.Controls.SetChildIndex(Me.TxtTk_Thue_No, 0)
        Me.Controls.SetChildIndex(Me.TxtLenh_Vt, 0)
        Me.Controls.SetChildIndex(Me.CmdPhan_Bo, 0)
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
        Me.Controls.SetChildIndex(Me.TxtMau_BC, 0)
        Me.Controls.SetChildIndex(Me.LabMau_BC, 0)
        Me.Controls.SetChildIndex(Me.ChkE_Thue, 0)
        Me.Controls.SetChildIndex(Me.ChkE_Tien, 0)
        Me.Controls.SetChildIndex(Me.ChkNonVAT, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_TTCP_H, 0)
        Me.Controls.SetChildIndex(Me.LabMa_TTCP_H, 0)
        CType(Me.PopupMenuMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Kh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Bp_H.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMa_HS_H.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMa_NX.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTk_Thue_Co.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTk_Thue_No.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbbMa_GD As System.Windows.Forms.ComboBox
    Friend WithEvents LabDia_Chi As System.Windows.Forms.Label
    Friend WithEvents TxtDia_Chi As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Quyen As System.Windows.Forms.TextBox
    Friend WithEvents LabMa_Quyen As System.Windows.Forms.Label
    Friend WithEvents LabNgay_LCt As System.Windows.Forms.Label
    Friend WithEvents LabNgay_Ct As System.Windows.Forms.Label
    Friend WithEvents txtDien_giai As System.Windows.Forms.TextBox
    Friend WithEvents LabDien_Giai As System.Windows.Forms.Label
    Friend WithEvents lblLoai_ct As System.Windows.Forms.Label
    Friend WithEvents txtOng_ba As System.Windows.Forms.TextBox
    Friend WithEvents LabOng_ba As System.Windows.Forms.Label
    Friend WithEvents lblSo_ct As System.Windows.Forms.Label
    Friend WithEvents TxtSo_Ct As System.Windows.Forms.TextBox
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
    Friend WithEvents TxtT_TT_NT As ClsTextBox.txtTien_NT
    Friend WithEvents TxtT_TT As ClsTextBox.txtTien_NT
    Friend WithEvents LabT_TT_NT As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Dvcs As System.Windows.Forms.TextBox
    Friend WithEvents TxtStt_Rec As System.Windows.Forms.TextBox
    Friend WithEvents PopupMenuMasterGrid As DevExpress.XtraBars.PopupMenu
    Friend WithEvents LabLenh_RO As System.Windows.Forms.Label
    Friend WithEvents TxtLenh_RO As System.Windows.Forms.TextBox
    Friend WithEvents LabLenh_PO As System.Windows.Forms.Label
    Friend WithEvents TxtLenh_PO As System.Windows.Forms.TextBox
    Friend WithEvents LabLenh_SO As System.Windows.Forms.Label
    Friend WithEvents TxtLenh_SO As System.Windows.Forms.TextBox
    Friend WithEvents LabT_So_Luong As System.Windows.Forms.Label
    Friend WithEvents TxtT_SO_LUONG As ClsTextBox.txtTien_NT
    Friend WithEvents TxtTen_KhVAT As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtDia_ChiVAT As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_So_Thue As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTen_BP_H As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Bp_H As Cyber.SmLists.TxtLookup
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTen_HS_H As System.Windows.Forms.TextBox
    Friend WithEvents txtMa_HS_H As Cyber.SmLists.TxtLookup
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTen_NX As System.Windows.Forms.TextBox
    Friend WithEvents txtMa_NX As Cyber.SmLists.TxtLookup
    Friend WithEvents LabMa_Nx As System.Windows.Forms.Label
    Friend WithEvents TxtTen_vtthue As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_vtthue As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtSo_Seri As System.Windows.Forms.TextBox
    Friend WithEvents LabT_Thue_NT As System.Windows.Forms.Label
    Friend WithEvents TxtT_Thue As ClsTextBox.txtTien_NT
    Friend WithEvents TxtT_thue_NT As ClsTextBox.txtTien_NT
    Friend WithEvents TxtT_Tien As ClsTextBox.txtTien_NT
    Friend WithEvents TxtT_Tien_NT As ClsTextBox.txtTien_NT
    Friend WithEvents TxtTk_Thue_Co As Cyber.SmLists.TxtLookup
    Friend WithEvents LabTk_Thue_No As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtThue_Suat As ClsTextBox.txtTien_NT
    Friend WithEvents TxtMa_Thue As System.Windows.Forms.TextBox
    Friend WithEvents LabTk_Thue_Co As System.Windows.Forms.Label
    Friend WithEvents ChkSua_Thue As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSua_TkThue As System.Windows.Forms.CheckBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtHan_TT As ClsTextBox.txtTien_NT
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtTk_Thue_No As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtLenh_Vt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LabMau_BC As System.Windows.Forms.Label
    Friend WithEvents TxtMau_BC As System.Windows.Forms.TextBox
    Friend WithEvents ChkE_Thue As System.Windows.Forms.CheckBox
    Friend WithEvents ChkE_Tien As System.Windows.Forms.CheckBox
    Friend WithEvents ChkNonVAT As System.Windows.Forms.CheckBox
    Friend WithEvents CbbMa_TTCP_H As System.Windows.Forms.ComboBox
    Friend WithEvents LabMa_TTCP_H As System.Windows.Forms.Label

End Class
