<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PXJ
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
        Me.LabDien_Giai = New System.Windows.Forms.Label()
        Me.lblLoai_ct = New System.Windows.Forms.Label()
        Me.txtOng_ba = New System.Windows.Forms.TextBox()
        Me.LabOng_ba = New System.Windows.Forms.Label()
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
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.TxtT_Tien_NT = New ClsTextBox.txtTien_NT()
        Me.TxtT_Tien = New ClsTextBox.txtTien_NT()
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
        Me.LabMa_kho = New System.Windows.Forms.Label()
        Me.LabMa_khoN = New System.Windows.Forms.Label()
        Me.TxtLenh_Vt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTen_KH = New System.Windows.Forms.TextBox()
        Me.TxtMa_KH = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Kho = New System.Windows.Forms.TextBox()
        Me.TxtMa_Kho = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_KhoN = New System.Windows.Forms.TextBox()
        Me.TxtMa_KhoN = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Bp_H = New System.Windows.Forms.TextBox()
        Me.TxtMa_BP_H = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_HS_H = New System.Windows.Forms.TextBox()
        Me.TxtMa_HS_H = New Cyber.SmLists.TxtLookup()
        Me.TxtDien_Giai = New System.Windows.Forms.TextBox()
        Me.ChkNonVAT = New System.Windows.Forms.CheckBox()
        Me.CbbMa_TTCP_H = New System.Windows.Forms.ComboBox()
        Me.LabMa_TTCP_H = New System.Windows.Forms.Label()
        CType(Me.PopupMenuMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_KH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Kho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_KhoN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_BP_H.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_HS_H.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CmdEdit.Location = New System.Drawing.Point(239, 497)
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
        Me.CmdSave.Location = New System.Drawing.Point(-1, 497)
        Me.CmdSave.TabIndex = 20
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
        Me.CmdView.Location = New System.Drawing.Point(478, 497)
        Me.CmdView.TabIndex = 26
        '
        'LabMa_Post
        '
        Me.LabMa_Post.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_Post.Location = New System.Drawing.Point(11, 479)
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
        Me.CmdSms.Location = New System.Drawing.Point(872, 497)
        Me.CmdSms.TabIndex = 31
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
        Me.CmdImport.Location = New System.Drawing.Point(916, 497)
        Me.CmdImport.TabIndex = 33
        '
        'CbbMa_Post
        '
        Me.CbbMa_Post.Location = New System.Drawing.Point(80, 474)
        Me.CbbMa_Post.TabIndex = 19
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
        Me.CmdExit.Location = New System.Drawing.Point(637, 497)
        Me.CmdExit.TabIndex = 28
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
        Me.CmdSearch.Location = New System.Drawing.Point(558, 497)
        Me.CmdSearch.TabIndex = 27
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
        Me.CmdCopy.Location = New System.Drawing.Point(399, 497)
        Me.CmdCopy.TabIndex = 25
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
        Me.CmdDelete.Location = New System.Drawing.Point(319, 497)
        Me.CmdDelete.TabIndex = 24
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
        Me.CmdPrint.Location = New System.Drawing.Point(159, 497)
        Me.CmdPrint.TabIndex = 22
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
        Me.CmdNew.Location = New System.Drawing.Point(79, 497)
        Me.CmdNew.TabIndex = 21
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
        Me.CmdCancel.Location = New System.Drawing.Point(239, 497)
        Me.CmdCancel.TabIndex = 23
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
        Me.CmdPhan_Bo.Location = New System.Drawing.Point(811, 496)
        Me.CmdPhan_Bo.TabIndex = 30
        '
        'TxtUser_id
        '
        Me.TxtUser_id.Location = New System.Drawing.Point(753, 499)
        '
        'CbbMa_GD
        '
        Me.CbbMa_GD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_GD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa_GD.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_GD.FormattingEnabled = True
        Me.CbbMa_GD.Location = New System.Drawing.Point(243, 33)
        Me.CbbMa_GD.Name = "CbbMa_GD"
        Me.CbbMa_GD.Size = New System.Drawing.Size(157, 23)
        Me.CbbMa_GD.TabIndex = 2
        '
        'LabDia_Chi
        '
        Me.LabDia_Chi.BackColor = System.Drawing.Color.Transparent
        Me.LabDia_Chi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabDia_Chi.ForeColor = System.Drawing.Color.Navy
        Me.LabDia_Chi.Location = New System.Drawing.Point(1, 123)
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
        Me.TxtDia_Chi.Location = New System.Drawing.Point(80, 120)
        Me.TxtDia_Chi.Name = "TxtDia_Chi"
        Me.TxtDia_Chi.Size = New System.Drawing.Size(437, 20)
        Me.TxtDia_Chi.TabIndex = 11
        '
        'TxtMa_Quyen
        '
        Me.TxtMa_Quyen.BackColor = System.Drawing.Color.White
        Me.TxtMa_Quyen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Quyen.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtMa_Quyen.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Quyen.Location = New System.Drawing.Point(478, 35)
        Me.TxtMa_Quyen.Name = "TxtMa_Quyen"
        Me.TxtMa_Quyen.Size = New System.Drawing.Size(108, 21)
        Me.TxtMa_Quyen.TabIndex = 4
        Me.TxtMa_Quyen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtMa_Quyen.Visible = False
        '
        'LabMa_Quyen
        '
        Me.LabMa_Quyen.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_Quyen.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabMa_Quyen.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_Quyen.Location = New System.Drawing.Point(404, 39)
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
        'LabDien_Giai
        '
        Me.LabDien_Giai.BackColor = System.Drawing.Color.Transparent
        Me.LabDien_Giai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabDien_Giai.ForeColor = System.Drawing.Color.Navy
        Me.LabDien_Giai.Location = New System.Drawing.Point(522, 123)
        Me.LabDien_Giai.Margin = New System.Windows.Forms.Padding(0)
        Me.LabDien_Giai.Name = "LabDien_Giai"
        Me.LabDien_Giai.Size = New System.Drawing.Size(64, 14)
        Me.LabDien_Giai.TabIndex = 139
        Me.LabDien_Giai.Tag = "Reason"
        Me.LabDien_Giai.Text = "Lý do"
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
        Me.txtOng_ba.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOng_ba.BackColor = System.Drawing.Color.White
        Me.txtOng_ba.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtOng_ba.ForeColor = System.Drawing.Color.Navy
        Me.txtOng_ba.Location = New System.Drawing.Point(586, 97)
        Me.txtOng_ba.Name = "txtOng_ba"
        Me.txtOng_ba.Size = New System.Drawing.Size(369, 20)
        Me.txtOng_ba.TabIndex = 14
        '
        'LabOng_ba
        '
        Me.LabOng_ba.BackColor = System.Drawing.Color.Transparent
        Me.LabOng_ba.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabOng_ba.ForeColor = System.Drawing.Color.Navy
        Me.LabOng_ba.Location = New System.Drawing.Point(520, 100)
        Me.LabOng_ba.Margin = New System.Windows.Forms.Padding(0)
        Me.LabOng_ba.Name = "LabOng_ba"
        Me.LabOng_ba.Size = New System.Drawing.Size(65, 14)
        Me.LabOng_ba.TabIndex = 136
        Me.LabOng_ba.Tag = "Receiver"
        Me.LabOng_ba.Text = "Người nhận"
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
        'txtSo_ct
        '
        Me.txtSo_ct.BackColor = System.Drawing.Color.White
        Me.txtSo_ct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSo_ct.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtSo_ct.ForeColor = System.Drawing.Color.Navy
        Me.txtSo_ct.Location = New System.Drawing.Point(243, 59)
        Me.txtSo_ct.Name = "txtSo_ct"
        Me.txtSo_ct.Size = New System.Drawing.Size(157, 21)
        Me.txtSo_ct.TabIndex = 3
        Me.txtSo_ct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabMa_kh
        '
        Me.LabMa_kh.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_kh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabMa_kh.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_kh.Location = New System.Drawing.Point(1, 100)
        Me.LabMa_kh.Margin = New System.Windows.Forms.Padding(0)
        Me.LabMa_kh.Name = "LabMa_kh"
        Me.LabMa_kh.Size = New System.Drawing.Size(78, 14)
        Me.LabMa_kh.TabIndex = 133
        Me.LabMa_kh.Tag = "Cus code"
        Me.LabMa_kh.Text = "Đối tượng"
        '
        'LabMa_NT
        '
        Me.LabMa_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabMa_NT.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_NT.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabMa_NT.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_NT.Location = New System.Drawing.Point(806, 42)
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
        Me.TxtTy_Gia.Location = New System.Drawing.Point(867, 59)
        Me.TxtTy_Gia.MaxWholeDigits = 10
        Me.TxtTy_Gia.Name = "TxtTy_Gia"
        Me.TxtTy_Gia.RangeMax = 1.7976931348623157E+308R
        Me.TxtTy_Gia.RangeMin = -1.7976931348623157E+308R
        Me.TxtTy_Gia.ReadOnly = True
        Me.TxtTy_Gia.Size = New System.Drawing.Size(88, 21)
        Me.TxtTy_Gia.TabIndex = 9
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
        Me.TxtMa_NT.Location = New System.Drawing.Point(867, 37)
        Me.TxtMa_NT.Name = "TxtMa_NT"
        Me.TxtMa_NT.Size = New System.Drawing.Size(88, 21)
        Me.TxtMa_NT.TabIndex = 8
        Me.TxtMa_NT.TabStop = False
        '
        'Detail
        '
        Me.Detail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Detail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Detail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detail.Location = New System.Drawing.Point(1, 195)
        Me.Detail.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Detail.MainView = Me.DetailGRV
        Me.Detail.Name = "Detail"
        Me.Detail.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.Detail.Size = New System.Drawing.Size(958, 276)
        Me.Detail.TabIndex = 18
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
        Me.LabTy_gia.Location = New System.Drawing.Point(806, 61)
        Me.LabTy_gia.Name = "LabTy_gia"
        Me.LabTy_gia.Size = New System.Drawing.Size(55, 17)
        Me.LabTy_gia.TabIndex = 153
        Me.LabTy_gia.Tag = "E.Rate"
        Me.LabTy_gia.Text = "Tỷ giá"
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(10, 82)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(944, 8)
        Me.GroupBoxLine.TabIndex = 156
        Me.GroupBoxLine.TabStop = False
        '
        'TxtT_Tien_NT
        '
        Me.TxtT_Tien_NT.AllowNegative = True
        Me.TxtT_Tien_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Tien_NT.BackColor = System.Drawing.Color.White
        Me.TxtT_Tien_NT.Flags = 7680
        Me.TxtT_Tien_NT.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Tien_NT.InputMask = "### ### ### ### ###.#"
        Me.TxtT_Tien_NT.Location = New System.Drawing.Point(478, 474)
        Me.TxtT_Tien_NT.MaxWholeDigits = 16
        Me.TxtT_Tien_NT.Name = "TxtT_Tien_NT"
        Me.TxtT_Tien_NT.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Tien_NT.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Tien_NT.ReadOnly = True
        Me.TxtT_Tien_NT.Size = New System.Drawing.Size(119, 20)
        Me.TxtT_Tien_NT.TabIndex = 158
        Me.TxtT_Tien_NT.Text = "1.0"
        Me.TxtT_Tien_NT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtT_Tien
        '
        Me.TxtT_Tien.AllowNegative = True
        Me.TxtT_Tien.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Tien.BackColor = System.Drawing.Color.White
        Me.TxtT_Tien.Flags = 7680
        Me.TxtT_Tien.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Tien.InputMask = "### ### ### ### ###.#"
        Me.TxtT_Tien.Location = New System.Drawing.Point(599, 474)
        Me.TxtT_Tien.MaxWholeDigits = 16
        Me.TxtT_Tien.Name = "TxtT_Tien"
        Me.TxtT_Tien.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Tien.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Tien.ReadOnly = True
        Me.TxtT_Tien.Size = New System.Drawing.Size(119, 20)
        Me.TxtT_Tien.TabIndex = 159
        Me.TxtT_Tien.Text = "1.0"
        Me.TxtT_Tien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabT_TT_NT
        '
        Me.LabT_TT_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabT_TT_NT.BackColor = System.Drawing.Color.Transparent
        Me.LabT_TT_NT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabT_TT_NT.ForeColor = System.Drawing.Color.Navy
        Me.LabT_TT_NT.Location = New System.Drawing.Point(397, 478)
        Me.LabT_TT_NT.Margin = New System.Windows.Forms.Padding(0)
        Me.LabT_TT_NT.Name = "LabT_TT_NT"
        Me.LabT_TT_NT.Size = New System.Drawing.Size(78, 14)
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
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(930, 502)
        Me.TxtMa_Dvcs.Name = "TxtMa_Dvcs"
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(21, 21)
        Me.TxtMa_Dvcs.TabIndex = 34
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
        Me.TxtStt_Rec.Location = New System.Drawing.Point(903, 502)
        Me.TxtStt_Rec.Name = "TxtStt_Rec"
        Me.TxtStt_Rec.Size = New System.Drawing.Size(21, 21)
        Me.TxtStt_Rec.TabIndex = 32
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
        Me.LabLenh_RO.Location = New System.Drawing.Point(404, 61)
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
        Me.TxtLenh_RO.Location = New System.Drawing.Point(478, 59)
        Me.TxtLenh_RO.Name = "TxtLenh_RO"
        Me.TxtLenh_RO.Size = New System.Drawing.Size(108, 21)
        Me.TxtLenh_RO.TabIndex = 5
        Me.TxtLenh_RO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLenh_RO.Visible = False
        '
        'LabLenh_PO
        '
        Me.LabLenh_PO.BackColor = System.Drawing.Color.Transparent
        Me.LabLenh_PO.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabLenh_PO.ForeColor = System.Drawing.Color.Navy
        Me.LabLenh_PO.Location = New System.Drawing.Point(593, 38)
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
        Me.TxtLenh_PO.Location = New System.Drawing.Point(658, 35)
        Me.TxtLenh_PO.Name = "TxtLenh_PO"
        Me.TxtLenh_PO.Size = New System.Drawing.Size(108, 21)
        Me.TxtLenh_PO.TabIndex = 6
        Me.TxtLenh_PO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLenh_PO.Visible = False
        '
        'LabLenh_SO
        '
        Me.LabLenh_SO.BackColor = System.Drawing.Color.Transparent
        Me.LabLenh_SO.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabLenh_SO.ForeColor = System.Drawing.Color.Navy
        Me.LabLenh_SO.Location = New System.Drawing.Point(593, 61)
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
        Me.TxtLenh_SO.Location = New System.Drawing.Point(658, 58)
        Me.TxtLenh_SO.Name = "TxtLenh_SO"
        Me.TxtLenh_SO.Size = New System.Drawing.Size(108, 21)
        Me.TxtLenh_SO.TabIndex = 7
        Me.TxtLenh_SO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLenh_SO.Visible = False
        '
        'LabT_So_Luong
        '
        Me.LabT_So_Luong.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabT_So_Luong.BackColor = System.Drawing.Color.Transparent
        Me.LabT_So_Luong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabT_So_Luong.ForeColor = System.Drawing.Color.Navy
        Me.LabT_So_Luong.Location = New System.Drawing.Point(238, 478)
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
        Me.TxtT_SO_LUONG.Location = New System.Drawing.Point(319, 474)
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
        'LabMa_kho
        '
        Me.LabMa_kho.AutoSize = True
        Me.LabMa_kho.Location = New System.Drawing.Point(1, 146)
        Me.LabMa_kho.Name = "LabMa_kho"
        Me.LabMa_kho.Size = New System.Drawing.Size(49, 13)
        Me.LabMa_kho.TabIndex = 178
        Me.LabMa_kho.Tag = "Export"
        Me.LabMa_kho.Text = "Kho xuất"
        '
        'LabMa_khoN
        '
        Me.LabMa_khoN.AutoSize = True
        Me.LabMa_khoN.Location = New System.Drawing.Point(1, 169)
        Me.LabMa_khoN.Name = "LabMa_khoN"
        Me.LabMa_khoN.Size = New System.Drawing.Size(53, 13)
        Me.LabMa_khoN.TabIndex = 181
        Me.LabMa_khoN.Tag = "Import"
        Me.LabMa_khoN.Text = "Kho nhập"
        '
        'TxtLenh_Vt
        '
        Me.TxtLenh_Vt.BackColor = System.Drawing.Color.White
        Me.TxtLenh_Vt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLenh_Vt.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtLenh_Vt.ForeColor = System.Drawing.Color.Navy
        Me.TxtLenh_Vt.Location = New System.Drawing.Point(680, 53)
        Me.TxtLenh_Vt.Name = "TxtLenh_Vt"
        Me.TxtLenh_Vt.Size = New System.Drawing.Size(35, 21)
        Me.TxtLenh_Vt.TabIndex = 250
        Me.TxtLenh_Vt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLenh_Vt.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(523, 168)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 14)
        Me.Label5.TabIndex = 260
        Me.Label5.Tag = "Cus code"
        Me.Label5.Text = "Nhân viên"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(523, 145)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 14)
        Me.Label4.TabIndex = 259
        Me.Label4.Tag = "Cus code"
        Me.Label4.Text = "Bộ phận"
        '
        'TxtTen_KH
        '
        Me.TxtTen_KH.BackColor = System.Drawing.Color.White
        Me.TxtTen_KH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_KH.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_KH.Location = New System.Drawing.Point(198, 97)
        Me.TxtTen_KH.Name = "TxtTen_KH"
        Me.TxtTen_KH.ReadOnly = True
        Me.TxtTen_KH.Size = New System.Drawing.Size(319, 20)
        Me.TxtTen_KH.TabIndex = 274
        Me.TxtTen_KH.TabStop = False
        '
        'TxtMa_KH
        '
        Me.TxtMa_KH._ActilookupPopup = False
        Me.TxtMa_KH.CyberActilookupPopup = True
        Me.TxtMa_KH.Dv_ListDetail = Nothing
        Me.TxtMa_KH.Dv_Master = Nothing
        Me.TxtMa_KH.FilterClient = ""
        Me.TxtMa_KH.FilterSQL = ""
        Me.TxtMa_KH.Location = New System.Drawing.Point(80, 97)
        Me.TxtMa_KH.Name = "TxtMa_KH"
        Me.TxtMa_KH.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_KH.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_KH.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_KH.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_KH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_KH.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_KH.TabIndex = 10
        Me.TxtMa_KH.Table_Name = ""
        '
        'TxtTen_Kho
        '
        Me.TxtTen_Kho.BackColor = System.Drawing.Color.White
        Me.TxtTen_Kho.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Kho.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Kho.Location = New System.Drawing.Point(198, 142)
        Me.TxtTen_Kho.Name = "TxtTen_Kho"
        Me.TxtTen_Kho.ReadOnly = True
        Me.TxtTen_Kho.Size = New System.Drawing.Size(319, 20)
        Me.TxtTen_Kho.TabIndex = 276
        Me.TxtTen_Kho.TabStop = False
        '
        'TxtMa_Kho
        '
        Me.TxtMa_Kho._ActilookupPopup = False
        Me.TxtMa_Kho.CyberActilookupPopup = True
        Me.TxtMa_Kho.Dv_ListDetail = Nothing
        Me.TxtMa_Kho.Dv_Master = Nothing
        Me.TxtMa_Kho.FilterClient = ""
        Me.TxtMa_Kho.FilterSQL = ""
        Me.TxtMa_Kho.Location = New System.Drawing.Point(80, 142)
        Me.TxtMa_Kho.Name = "TxtMa_Kho"
        Me.TxtMa_Kho.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Kho.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kho.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Kho.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kho.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kho.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_Kho.TabIndex = 12
        Me.TxtMa_Kho.Table_Name = ""
        '
        'TxtTen_KhoN
        '
        Me.TxtTen_KhoN.BackColor = System.Drawing.Color.White
        Me.TxtTen_KhoN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_KhoN.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_KhoN.Location = New System.Drawing.Point(198, 165)
        Me.TxtTen_KhoN.Name = "TxtTen_KhoN"
        Me.TxtTen_KhoN.ReadOnly = True
        Me.TxtTen_KhoN.Size = New System.Drawing.Size(319, 20)
        Me.TxtTen_KhoN.TabIndex = 278
        Me.TxtTen_KhoN.TabStop = False
        '
        'TxtMa_KhoN
        '
        Me.TxtMa_KhoN._ActilookupPopup = False
        Me.TxtMa_KhoN.CyberActilookupPopup = True
        Me.TxtMa_KhoN.Dv_ListDetail = Nothing
        Me.TxtMa_KhoN.Dv_Master = Nothing
        Me.TxtMa_KhoN.FilterClient = ""
        Me.TxtMa_KhoN.FilterSQL = ""
        Me.TxtMa_KhoN.Location = New System.Drawing.Point(80, 165)
        Me.TxtMa_KhoN.Name = "TxtMa_KhoN"
        Me.TxtMa_KhoN.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_KhoN.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_KhoN.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_KhoN.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_KhoN.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_KhoN.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_KhoN.TabIndex = 13
        Me.TxtMa_KhoN.Table_Name = ""
        '
        'TxtTen_Bp_H
        '
        Me.TxtTen_Bp_H.BackColor = System.Drawing.Color.White
        Me.TxtTen_Bp_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Bp_H.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Bp_H.Location = New System.Drawing.Point(703, 142)
        Me.TxtTen_Bp_H.Name = "TxtTen_Bp_H"
        Me.TxtTen_Bp_H.ReadOnly = True
        Me.TxtTen_Bp_H.Size = New System.Drawing.Size(220, 20)
        Me.TxtTen_Bp_H.TabIndex = 280
        Me.TxtTen_Bp_H.TabStop = False
        '
        'TxtMa_BP_H
        '
        Me.TxtMa_BP_H._ActilookupPopup = False
        Me.TxtMa_BP_H.CyberActilookupPopup = True
        Me.TxtMa_BP_H.Dv_ListDetail = Nothing
        Me.TxtMa_BP_H.Dv_Master = Nothing
        Me.TxtMa_BP_H.FilterClient = ""
        Me.TxtMa_BP_H.FilterSQL = ""
        Me.TxtMa_BP_H.Location = New System.Drawing.Point(586, 142)
        Me.TxtMa_BP_H.Name = "TxtMa_BP_H"
        Me.TxtMa_BP_H.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_BP_H.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_BP_H.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_BP_H.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_BP_H.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_BP_H.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_BP_H.TabIndex = 16
        Me.TxtMa_BP_H.Table_Name = ""
        '
        'TxtTen_HS_H
        '
        Me.TxtTen_HS_H.BackColor = System.Drawing.Color.White
        Me.TxtTen_HS_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_HS_H.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_HS_H.Location = New System.Drawing.Point(703, 165)
        Me.TxtTen_HS_H.Name = "TxtTen_HS_H"
        Me.TxtTen_HS_H.ReadOnly = True
        Me.TxtTen_HS_H.Size = New System.Drawing.Size(220, 20)
        Me.TxtTen_HS_H.TabIndex = 282
        Me.TxtTen_HS_H.TabStop = False
        '
        'TxtMa_HS_H
        '
        Me.TxtMa_HS_H._ActilookupPopup = False
        Me.TxtMa_HS_H.CyberActilookupPopup = True
        Me.TxtMa_HS_H.Dv_ListDetail = Nothing
        Me.TxtMa_HS_H.Dv_Master = Nothing
        Me.TxtMa_HS_H.FilterClient = ""
        Me.TxtMa_HS_H.FilterSQL = ""
        Me.TxtMa_HS_H.Location = New System.Drawing.Point(586, 165)
        Me.TxtMa_HS_H.Name = "TxtMa_HS_H"
        Me.TxtMa_HS_H.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_HS_H.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_HS_H.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_HS_H.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_HS_H.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_HS_H.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_HS_H.TabIndex = 17
        Me.TxtMa_HS_H.Table_Name = ""
        '
        'TxtDien_Giai
        '
        Me.TxtDien_Giai.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDien_Giai.BackColor = System.Drawing.Color.White
        Me.TxtDien_Giai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtDien_Giai.ForeColor = System.Drawing.Color.Navy
        Me.TxtDien_Giai.Location = New System.Drawing.Point(586, 120)
        Me.TxtDien_Giai.Name = "TxtDien_Giai"
        Me.TxtDien_Giai.Size = New System.Drawing.Size(369, 20)
        Me.TxtDien_Giai.TabIndex = 15
        '
        'ChkNonVAT
        '
        Me.ChkNonVAT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNonVAT.AutoSize = True
        Me.ChkNonVAT.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkNonVAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkNonVAT.ForeColor = System.Drawing.Color.Navy
        Me.ChkNonVAT.Location = New System.Drawing.Point(897, 475)
        Me.ChkNonVAT.Name = "ChkNonVAT"
        Me.ChkNonVAT.Size = New System.Drawing.Size(62, 17)
        Me.ChkNonVAT.TabIndex = 2133
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
        Me.CbbMa_TTCP_H.Location = New System.Drawing.Point(761, 1)
        Me.CbbMa_TTCP_H.Name = "CbbMa_TTCP_H"
        Me.CbbMa_TTCP_H.Size = New System.Drawing.Size(194, 23)
        Me.CbbMa_TTCP_H.TabIndex = 2195
        Me.CbbMa_TTCP_H.TabStop = False
        '
        'LabMa_TTCP_H
        '
        Me.LabMa_TTCP_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabMa_TTCP_H.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_TTCP_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMa_TTCP_H.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_TTCP_H.Location = New System.Drawing.Point(652, 2)
        Me.LabMa_TTCP_H.Margin = New System.Windows.Forms.Padding(0)
        Me.LabMa_TTCP_H.Name = "LabMa_TTCP_H"
        Me.LabMa_TTCP_H.Size = New System.Drawing.Size(106, 19)
        Me.LabMa_TTCP_H.TabIndex = 2196
        Me.LabMa_TTCP_H.Tag = "Cost centrer"
        Me.LabMa_TTCP_H.Text = "TTCP"
        Me.LabMa_TTCP_H.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PXJ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(963, 553)
        Me.Controls.Add(Me.LabMa_TTCP_H)
        Me.Controls.Add(Me.CbbMa_TTCP_H)
        Me.Controls.Add(Me.ChkNonVAT)
        Me.Controls.Add(Me.TxtDien_Giai)
        Me.Controls.Add(Me.TxtTen_HS_H)
        Me.Controls.Add(Me.TxtMa_HS_H)
        Me.Controls.Add(Me.TxtTen_Bp_H)
        Me.Controls.Add(Me.TxtMa_BP_H)
        Me.Controls.Add(Me.TxtTen_KhoN)
        Me.Controls.Add(Me.TxtMa_KhoN)
        Me.Controls.Add(Me.TxtTen_Kho)
        Me.Controls.Add(Me.TxtMa_Kho)
        Me.Controls.Add(Me.TxtTen_KH)
        Me.Controls.Add(Me.TxtMa_KH)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtLenh_Vt)
        Me.Controls.Add(Me.LabMa_khoN)
        Me.Controls.Add(Me.LabMa_kho)
        Me.Controls.Add(Me.LabT_So_Luong)
        Me.Controls.Add(Me.TxtT_SO_LUONG)
        Me.Controls.Add(Me.LabLenh_SO)
        Me.Controls.Add(Me.TxtLenh_SO)
        Me.Controls.Add(Me.LabLenh_PO)
        Me.Controls.Add(Me.TxtLenh_PO)
        Me.Controls.Add(Me.LabLenh_RO)
        Me.Controls.Add(Me.TxtLenh_RO)
        Me.Controls.Add(Me.LabT_TT_NT)
        Me.Controls.Add(Me.TxtT_Tien)
        Me.Controls.Add(Me.TxtT_Tien_NT)
        Me.Controls.Add(Me.GroupBoxLine)
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
        Me.Controls.Add(Me.LabDien_Giai)
        Me.Controls.Add(Me.lblLoai_ct)
        Me.Controls.Add(Me.txtOng_ba)
        Me.Controls.Add(Me.LabOng_ba)
        Me.Controls.Add(Me.lblSo_ct)
        Me.Controls.Add(Me.txtSo_ct)
        Me.Controls.Add(Me.LabMa_kh)
        Me.Controls.Add(Me.LabMa_NT)
        Me.Controls.Add(Me.TxtStt_Rec)
        Me.Controls.Add(Me.TxtMa_Dvcs)
        Me.KeyPreview = True
        Me.Name = "PXJ"
        Me.Controls.SetChildIndex(Me.TxtUser_id, 0)
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
        Me.Controls.SetChildIndex(Me.LabMa_kh, 0)
        Me.Controls.SetChildIndex(Me.txtSo_ct, 0)
        Me.Controls.SetChildIndex(Me.lblSo_ct, 0)
        Me.Controls.SetChildIndex(Me.LabOng_ba, 0)
        Me.Controls.SetChildIndex(Me.txtOng_ba, 0)
        Me.Controls.SetChildIndex(Me.lblLoai_ct, 0)
        Me.Controls.SetChildIndex(Me.LabDien_Giai, 0)
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
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Tien_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Tien, 0)
        Me.Controls.SetChildIndex(Me.LabT_TT_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtLenh_RO, 0)
        Me.Controls.SetChildIndex(Me.LabLenh_RO, 0)
        Me.Controls.SetChildIndex(Me.TxtLenh_PO, 0)
        Me.Controls.SetChildIndex(Me.LabLenh_PO, 0)
        Me.Controls.SetChildIndex(Me.TxtLenh_SO, 0)
        Me.Controls.SetChildIndex(Me.LabLenh_SO, 0)
        Me.Controls.SetChildIndex(Me.TxtT_SO_LUONG, 0)
        Me.Controls.SetChildIndex(Me.LabT_So_Luong, 0)
        Me.Controls.SetChildIndex(Me.LabMa_kho, 0)
        Me.Controls.SetChildIndex(Me.LabMa_khoN, 0)
        Me.Controls.SetChildIndex(Me.TxtLenh_Vt, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_KH, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_KH, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kho, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Kho, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_KhoN, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_KhoN, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_BP_H, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Bp_H, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_HS_H, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_HS_H, 0)
        Me.Controls.SetChildIndex(Me.TxtDien_Giai, 0)
        Me.Controls.SetChildIndex(Me.ChkNonVAT, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_TTCP_H, 0)
        Me.Controls.SetChildIndex(Me.LabMa_TTCP_H, 0)
        CType(Me.PopupMenuMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_KH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Kho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_KhoN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_BP_H.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_HS_H.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents LabDien_Giai As System.Windows.Forms.Label
    Friend WithEvents lblLoai_ct As System.Windows.Forms.Label
    Friend WithEvents txtOng_ba As System.Windows.Forms.TextBox
    Friend WithEvents LabOng_ba As System.Windows.Forms.Label
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
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents TxtT_Tien_NT As ClsTextBox.txtTien_NT
    Friend WithEvents TxtT_Tien As ClsTextBox.txtTien_NT
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
    Friend WithEvents LabMa_kho As System.Windows.Forms.Label
    Friend WithEvents LabMa_khoN As System.Windows.Forms.Label
    Friend WithEvents TxtLenh_Vt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_KH As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_KH As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Kho As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Kho As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_KhoN As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_KhoN As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Bp_H As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_BP_H As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_HS_H As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_HS_H As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtDien_Giai As System.Windows.Forms.TextBox
    Friend WithEvents ChkNonVAT As System.Windows.Forms.CheckBox
    Friend WithEvents CbbMa_TTCP_H As System.Windows.Forms.ComboBox
    Friend WithEvents LabMa_TTCP_H As System.Windows.Forms.Label

End Class
