﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KPI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KPI))
        Me.CbbMa_GD = New System.Windows.Forms.ComboBox()
        Me.TxtMa_Quyen = New System.Windows.Forms.TextBox()
        Me.LabMa_Quyen = New System.Windows.Forms.Label()
        Me.LabNgay_Ct = New System.Windows.Forms.Label()
        Me.lblLoai_ct = New System.Windows.Forms.Label()
        Me.lblSo_ct = New System.Windows.Forms.Label()
        Me.TxtSo_Ct = New System.Windows.Forms.TextBox()
        Me.TxtNgay_Ct = New ClsTextBox.txtDate()
        Me.TxtMa_Dvcs = New System.Windows.Forms.TextBox()
        Me.TxtStt_Rec = New System.Windows.Forms.TextBox()
        Me.PopupMenuMasterGrid = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.TxtLenh_RO = New System.Windows.Forms.TextBox()
        Me.TxtLenh_PO = New System.Windows.Forms.TextBox()
        Me.TxtLenh_Vt = New System.Windows.Forms.TextBox()
        Me.ChkNonVAT = New System.Windows.Forms.CheckBox()
        Me.TxtLenh_SO = New System.Windows.Forms.TextBox()
        Me.txtSo_Seri0 = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.CbbMa_TTCP_H = New System.Windows.Forms.ComboBox()
        Me.LabMa_TTCP_H = New System.Windows.Forms.Label()
        Me.Detail = New DevExpress.XtraGrid.GridControl()
        Me.DetailGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtdien_giai = New System.Windows.Forms.TextBox()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.TxtNgay_LCt = New ClsTextBox.txtDate()
        Me.LabT_So_Luong = New System.Windows.Forms.Label()
        Me.TxtT_KPI = New ClsTextBox.txtTien_NT()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNV_SLVP = New ClsTextBox.txtTien_NT()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNV_DT = New ClsTextBox.txtTien_NT()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtQL_DT = New ClsTextBox.txtTien_NT()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtQL_SLVP = New ClsTextBox.txtTien_NT()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtNV_CL = New ClsTextBox.txtTien_NT()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtQL_CL = New ClsTextBox.txtTien_NT()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_Bp_H = New System.Windows.Forms.TextBox()
        Me.TxtMa_BP_H = New Cyber.SmLists.TxtLookup()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtTen_hs_h = New System.Windows.Forms.TextBox()
        Me.Txtma_hs_h = New Cyber.SmLists.TxtLookup()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtTen_chucvu = New System.Windows.Forms.TextBox()
        Me.TxtMa_chucvu = New Cyber.SmLists.TxtLookup()
        Me.CbbNam = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbbThang = New System.Windows.Forms.ComboBox()
        Me.LabM_month1 = New System.Windows.Forms.Label()
        Me.TxtGio_XacNhan = New System.Windows.Forms.TextBox()
        Me.TxtNgay_XacNhan = New ClsTextBox.txtDate()
        Me.BttXacNhan = New DevExpress.XtraEditors.SimpleButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.PopupMenuMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_BP_H.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txtma_hs_h.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_chucvu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdEdit
        '
        Me.CmdEdit.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdEdit.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdEdit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdEdit.Appearance.Options.UseBackColor = True
        Me.CmdEdit.Appearance.Options.UseFont = True
        Me.CmdEdit.Appearance.Options.UseForeColor = True
        Me.CmdEdit.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdEdit.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdEdit.Location = New System.Drawing.Point(243, 531)
        Me.CmdEdit.Margin = New System.Windows.Forms.Padding(4)
        '
        'CmdSave
        '
        Me.CmdSave.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdSave.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSave.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdSave.Appearance.Options.UseBackColor = True
        Me.CmdSave.Appearance.Options.UseFont = True
        Me.CmdSave.Appearance.Options.UseForeColor = True
        Me.CmdSave.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdSave.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdSave.Location = New System.Drawing.Point(3, 531)
        Me.CmdSave.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdSave.TabIndex = 19
        '
        'CmdView
        '
        Me.CmdView.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdView.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdView.Appearance.Options.UseBackColor = True
        Me.CmdView.Appearance.Options.UseFont = True
        Me.CmdView.Appearance.Options.UseForeColor = True
        Me.CmdView.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdView.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdView.Location = New System.Drawing.Point(482, 531)
        Me.CmdView.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdView.TabIndex = 25
        '
        'LabMa_Post
        '
        Me.LabMa_Post.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMa_Post.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_Post.Location = New System.Drawing.Point(5, 509)
        Me.LabMa_Post.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_Post.Size = New System.Drawing.Size(54, 13)
        Me.LabMa_Post.TabIndex = 19
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
        Me.CmdSms.Location = New System.Drawing.Point(1130, 546)
        Me.CmdSms.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdSms.TabIndex = 15
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
        Me.CmdImport.Location = New System.Drawing.Point(1067, 546)
        Me.CmdImport.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdImport.TabIndex = 23
        '
        'CbbMa_Post
        '
        Me.CbbMa_Post.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa_Post.Location = New System.Drawing.Point(65, 503)
        Me.CbbMa_Post.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbMa_Post.TabIndex = 11
        '
        'CmdExit
        '
        Me.CmdExit.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdExit.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdExit.Appearance.Options.UseBackColor = True
        Me.CmdExit.Appearance.Options.UseFont = True
        Me.CmdExit.Appearance.Options.UseForeColor = True
        Me.CmdExit.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdExit.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdExit.Location = New System.Drawing.Point(641, 531)
        Me.CmdExit.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdExit.TabIndex = 27
        '
        'CmdSearch
        '
        Me.CmdSearch.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdSearch.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSearch.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdSearch.Appearance.Options.UseBackColor = True
        Me.CmdSearch.Appearance.Options.UseFont = True
        Me.CmdSearch.Appearance.Options.UseForeColor = True
        Me.CmdSearch.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdSearch.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdSearch.Location = New System.Drawing.Point(562, 531)
        Me.CmdSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdSearch.TabIndex = 26
        '
        'CmdCopy
        '
        Me.CmdCopy.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdCopy.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCopy.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdCopy.Appearance.Options.UseBackColor = True
        Me.CmdCopy.Appearance.Options.UseFont = True
        Me.CmdCopy.Appearance.Options.UseForeColor = True
        Me.CmdCopy.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdCopy.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdCopy.Location = New System.Drawing.Point(403, 531)
        Me.CmdCopy.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdCopy.TabIndex = 24
        '
        'CmdDelete
        '
        Me.CmdDelete.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdDelete.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdDelete.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdDelete.Appearance.Options.UseBackColor = True
        Me.CmdDelete.Appearance.Options.UseFont = True
        Me.CmdDelete.Appearance.Options.UseForeColor = True
        Me.CmdDelete.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdDelete.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdDelete.Location = New System.Drawing.Point(323, 531)
        Me.CmdDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdDelete.TabIndex = 23
        '
        'CmdPrint
        '
        Me.CmdPrint.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdPrint.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPrint.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdPrint.Appearance.Options.UseBackColor = True
        Me.CmdPrint.Appearance.Options.UseFont = True
        Me.CmdPrint.Appearance.Options.UseForeColor = True
        Me.CmdPrint.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdPrint.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdPrint.Location = New System.Drawing.Point(163, 531)
        Me.CmdPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdPrint.TabIndex = 21
        '
        'CmdNew
        '
        Me.CmdNew.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdNew.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdNew.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdNew.Appearance.Options.UseBackColor = True
        Me.CmdNew.Appearance.Options.UseFont = True
        Me.CmdNew.Appearance.Options.UseForeColor = True
        Me.CmdNew.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdNew.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdNew.Location = New System.Drawing.Point(83, 531)
        Me.CmdNew.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdNew.TabIndex = 20
        '
        'CmdCancel
        '
        Me.CmdCancel.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCancel.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdCancel.Appearance.Options.UseBackColor = True
        Me.CmdCancel.Appearance.Options.UseFont = True
        Me.CmdCancel.Appearance.Options.UseForeColor = True
        Me.CmdCancel.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdCancel.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdCancel.Location = New System.Drawing.Point(243, 531)
        Me.CmdCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdCancel.TabIndex = 22
        '
        'CmdPhan_Bo
        '
        Me.CmdPhan_Bo.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdPhan_Bo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPhan_Bo.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdPhan_Bo.Appearance.Options.UseBackColor = True
        Me.CmdPhan_Bo.Appearance.Options.UseFont = True
        Me.CmdPhan_Bo.Appearance.Options.UseForeColor = True
        Me.CmdPhan_Bo.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdPhan_Bo.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdPhan_Bo.Location = New System.Drawing.Point(933, 547)
        Me.CmdPhan_Bo.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdPhan_Bo.TabIndex = 21
        '
        'TxtUser_id
        '
        Me.TxtUser_id.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUser_id.Location = New System.Drawing.Point(933, 551)
        Me.TxtUser_id.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtUser_id.Size = New System.Drawing.Size(100, 21)
        '
        'CbbMa_GD
        '
        Me.CbbMa_GD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_GD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa_GD.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_GD.FormattingEnabled = True
        Me.CbbMa_GD.Location = New System.Drawing.Point(377, 34)
        Me.CbbMa_GD.Name = "CbbMa_GD"
        Me.CbbMa_GD.Size = New System.Drawing.Size(165, 21)
        Me.CbbMa_GD.TabIndex = 1
        '
        'TxtMa_Quyen
        '
        Me.TxtMa_Quyen.BackColor = System.Drawing.Color.White
        Me.TxtMa_Quyen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Quyen.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtMa_Quyen.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Quyen.Location = New System.Drawing.Point(1105, 33)
        Me.TxtMa_Quyen.Name = "TxtMa_Quyen"
        Me.TxtMa_Quyen.Size = New System.Drawing.Size(108, 21)
        Me.TxtMa_Quyen.TabIndex = 22
        Me.TxtMa_Quyen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtMa_Quyen.Visible = False
        '
        'LabMa_Quyen
        '
        Me.LabMa_Quyen.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_Quyen.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabMa_Quyen.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_Quyen.Location = New System.Drawing.Point(1137, 39)
        Me.LabMa_Quyen.Name = "LabMa_Quyen"
        Me.LabMa_Quyen.Size = New System.Drawing.Size(55, 13)
        Me.LabMa_Quyen.TabIndex = 145
        Me.LabMa_Quyen.Tag = "Book no."
        Me.LabMa_Quyen.Text = "Quyển số"
        Me.LabMa_Quyen.Visible = False
        '
        'LabNgay_Ct
        '
        Me.LabNgay_Ct.BackColor = System.Drawing.Color.Transparent
        Me.LabNgay_Ct.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabNgay_Ct.ForeColor = System.Drawing.Color.Navy
        Me.LabNgay_Ct.Location = New System.Drawing.Point(11, 34)
        Me.LabNgay_Ct.Name = "LabNgay_Ct"
        Me.LabNgay_Ct.Size = New System.Drawing.Size(91, 22)
        Me.LabNgay_Ct.TabIndex = 143
        Me.LabNgay_Ct.Tag = "Voucher date"
        Me.LabNgay_Ct.Text = "Ngày chứng từ"
        '
        'lblLoai_ct
        '
        Me.lblLoai_ct.BackColor = System.Drawing.Color.Transparent
        Me.lblLoai_ct.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoai_ct.ForeColor = System.Drawing.Color.Navy
        Me.lblLoai_ct.Location = New System.Drawing.Point(290, 34)
        Me.lblLoai_ct.Margin = New System.Windows.Forms.Padding(0)
        Me.lblLoai_ct.Name = "lblLoai_ct"
        Me.lblLoai_ct.Size = New System.Drawing.Size(74, 15)
        Me.lblLoai_ct.TabIndex = 21
        Me.lblLoai_ct.Tag = "Vote style"
        Me.lblLoai_ct.Text = "Loại "
        '
        'lblSo_ct
        '
        Me.lblSo_ct.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_ct.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSo_ct.ForeColor = System.Drawing.Color.Navy
        Me.lblSo_ct.Location = New System.Drawing.Point(290, 62)
        Me.lblSo_ct.Name = "lblSo_ct"
        Me.lblSo_ct.Size = New System.Drawing.Size(81, 19)
        Me.lblSo_ct.TabIndex = 22
        Me.lblSo_ct.Tag = "No."
        Me.lblSo_ct.Text = "Số chứng từ"
        '
        'TxtSo_Ct
        '
        Me.TxtSo_Ct.BackColor = System.Drawing.Color.White
        Me.TxtSo_Ct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_Ct.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSo_Ct.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Ct.Location = New System.Drawing.Point(377, 59)
        Me.TxtSo_Ct.Name = "TxtSo_Ct"
        Me.TxtSo_Ct.Size = New System.Drawing.Size(165, 21)
        Me.TxtSo_Ct.TabIndex = 2
        Me.TxtSo_Ct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtNgay_Ct
        '
        Me.TxtNgay_Ct.BackColor = System.Drawing.Color.White
        Me.TxtNgay_Ct.Flags = 65536
        Me.TxtNgay_Ct.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_Ct.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Ct.isEmpty = True
        Me.TxtNgay_Ct.Location = New System.Drawing.Point(124, 34)
        Me.TxtNgay_Ct.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Ct.MaxLength = 10
        Me.TxtNgay_Ct.Name = "TxtNgay_Ct"
        Me.TxtNgay_Ct.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_Ct.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Ct.ReadOnly = True
        Me.TxtNgay_Ct.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct.Size = New System.Drawing.Size(134, 21)
        Me.TxtNgay_Ct.TabIndex = 0
        Me.TxtNgay_Ct.Text = "18/09/2011"
        Me.TxtNgay_Ct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_Ct.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtMa_Dvcs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Dvcs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Dvcs.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(1093, 551)
        Me.TxtMa_Dvcs.Name = "TxtMa_Dvcs"
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(21, 21)
        Me.TxtMa_Dvcs.TabIndex = 24
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
        Me.TxtStt_Rec.Location = New System.Drawing.Point(1065, 551)
        Me.TxtStt_Rec.Name = "TxtStt_Rec"
        Me.TxtStt_Rec.Size = New System.Drawing.Size(21, 21)
        Me.TxtStt_Rec.TabIndex = 22
        Me.TxtStt_Rec.TabStop = False
        Me.TxtStt_Rec.Visible = False
        '
        'PopupMenuMasterGrid
        '
        Me.PopupMenuMasterGrid.Name = "PopupMenuMasterGrid"
        '
        'TxtLenh_RO
        '
        Me.TxtLenh_RO.BackColor = System.Drawing.Color.White
        Me.TxtLenh_RO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLenh_RO.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtLenh_RO.ForeColor = System.Drawing.Color.Navy
        Me.TxtLenh_RO.Location = New System.Drawing.Point(1128, 31)
        Me.TxtLenh_RO.Name = "TxtLenh_RO"
        Me.TxtLenh_RO.Size = New System.Drawing.Size(59, 21)
        Me.TxtLenh_RO.TabIndex = 168
        Me.TxtLenh_RO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLenh_RO.Visible = False
        '
        'TxtLenh_PO
        '
        Me.TxtLenh_PO.BackColor = System.Drawing.Color.White
        Me.TxtLenh_PO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLenh_PO.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtLenh_PO.ForeColor = System.Drawing.Color.Navy
        Me.TxtLenh_PO.Location = New System.Drawing.Point(1140, 36)
        Me.TxtLenh_PO.Name = "TxtLenh_PO"
        Me.TxtLenh_PO.Size = New System.Drawing.Size(59, 21)
        Me.TxtLenh_PO.TabIndex = 170
        Me.TxtLenh_PO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLenh_PO.Visible = False
        '
        'TxtLenh_Vt
        '
        Me.TxtLenh_Vt.BackColor = System.Drawing.Color.White
        Me.TxtLenh_Vt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLenh_Vt.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtLenh_Vt.ForeColor = System.Drawing.Color.Navy
        Me.TxtLenh_Vt.Location = New System.Drawing.Point(1129, 33)
        Me.TxtLenh_Vt.Name = "TxtLenh_Vt"
        Me.TxtLenh_Vt.Size = New System.Drawing.Size(58, 21)
        Me.TxtLenh_Vt.TabIndex = 242
        Me.TxtLenh_Vt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLenh_Vt.Visible = False
        '
        'ChkNonVAT
        '
        Me.ChkNonVAT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNonVAT.AutoSize = True
        Me.ChkNonVAT.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkNonVAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkNonVAT.ForeColor = System.Drawing.Color.Navy
        Me.ChkNonVAT.Location = New System.Drawing.Point(1156, 524)
        Me.ChkNonVAT.Name = "ChkNonVAT"
        Me.ChkNonVAT.Size = New System.Drawing.Size(62, 17)
        Me.ChkNonVAT.TabIndex = 2128
        Me.ChkNonVAT.TabStop = False
        Me.ChkNonVAT.Tag = "Non VAT"
        Me.ChkNonVAT.Text = "NonVat"
        Me.ChkNonVAT.UseVisualStyleBackColor = True
        '
        'TxtLenh_SO
        '
        Me.TxtLenh_SO.BackColor = System.Drawing.Color.White
        Me.TxtLenh_SO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLenh_SO.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtLenh_SO.ForeColor = System.Drawing.Color.Navy
        Me.TxtLenh_SO.Location = New System.Drawing.Point(1137, 55)
        Me.TxtLenh_SO.Name = "TxtLenh_SO"
        Me.TxtLenh_SO.Size = New System.Drawing.Size(43, 21)
        Me.TxtLenh_SO.TabIndex = 172
        Me.TxtLenh_SO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLenh_SO.Visible = False
        '
        'txtSo_Seri0
        '
        Me.txtSo_Seri0.BackColor = System.Drawing.Color.White
        Me.txtSo_Seri0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSo_Seri0.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtSo_Seri0.ForeColor = System.Drawing.Color.Navy
        Me.txtSo_Seri0.Location = New System.Drawing.Point(1098, 35)
        Me.txtSo_Seri0.Name = "txtSo_Seri0"
        Me.txtSo_Seri0.Size = New System.Drawing.Size(105, 21)
        Me.txtSo_Seri0.TabIndex = 5
        Me.txtSo_Seri0.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'CbbMa_TTCP_H
        '
        Me.CbbMa_TTCP_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbbMa_TTCP_H.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_TTCP_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa_TTCP_H.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_TTCP_H.FormattingEnabled = True
        Me.CbbMa_TTCP_H.Location = New System.Drawing.Point(910, 3)
        Me.CbbMa_TTCP_H.Name = "CbbMa_TTCP_H"
        Me.CbbMa_TTCP_H.Size = New System.Drawing.Size(194, 23)
        Me.CbbMa_TTCP_H.TabIndex = 2163
        Me.CbbMa_TTCP_H.TabStop = False
        '
        'LabMa_TTCP_H
        '
        Me.LabMa_TTCP_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabMa_TTCP_H.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_TTCP_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMa_TTCP_H.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_TTCP_H.Location = New System.Drawing.Point(795, 6)
        Me.LabMa_TTCP_H.Margin = New System.Windows.Forms.Padding(0)
        Me.LabMa_TTCP_H.Name = "LabMa_TTCP_H"
        Me.LabMa_TTCP_H.Size = New System.Drawing.Size(106, 19)
        Me.LabMa_TTCP_H.TabIndex = 2164
        Me.LabMa_TTCP_H.Tag = "Cost centrer"
        Me.LabMa_TTCP_H.Text = "TTCP"
        Me.LabMa_TTCP_H.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Detail
        '
        Me.Detail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Detail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Detail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detail.Location = New System.Drawing.Point(4, 140)
        Me.Detail.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Detail.MainView = Me.DetailGRV
        Me.Detail.Name = "Detail"
        Me.Detail.Size = New System.Drawing.Size(1106, 316)
        Me.Detail.TabIndex = 10
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
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(11, 113)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 20)
        Me.Label2.TabIndex = 2185
        Me.Label2.Tag = "Content"
        Me.Label2.Text = "Ý kiến phụ trách"
        '
        'Txtdien_giai
        '
        Me.Txtdien_giai.BackColor = System.Drawing.Color.White
        Me.Txtdien_giai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtdien_giai.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtdien_giai.ForeColor = System.Drawing.Color.Navy
        Me.Txtdien_giai.Location = New System.Drawing.Point(124, 112)
        Me.Txtdien_giai.Name = "Txtdien_giai"
        Me.Txtdien_giai.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Txtdien_giai.Size = New System.Drawing.Size(418, 21)
        Me.Txtdien_giai.TabIndex = 7
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxLine.Location = New System.Drawing.Point(12, 79)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(1095, 8)
        Me.GroupBoxLine.TabIndex = 156
        Me.GroupBoxLine.TabStop = False
        '
        'TxtNgay_LCt
        '
        Me.TxtNgay_LCt.BackColor = System.Drawing.Color.White
        Me.TxtNgay_LCt.Flags = 65536
        Me.TxtNgay_LCt.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_LCt.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_LCt.isEmpty = True
        Me.TxtNgay_LCt.Location = New System.Drawing.Point(851, 35)
        Me.TxtNgay_LCt.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_LCt.MaxLength = 10
        Me.TxtNgay_LCt.Name = "TxtNgay_LCt"
        Me.TxtNgay_LCt.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_LCt.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_LCt.ReadOnly = True
        Me.TxtNgay_LCt.ShowDayBeforeMonth = False
        Me.TxtNgay_LCt.Size = New System.Drawing.Size(85, 21)
        Me.TxtNgay_LCt.TabIndex = 2188
        Me.TxtNgay_LCt.Text = "18/09/2011"
        Me.TxtNgay_LCt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_LCt.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        Me.TxtNgay_LCt.Visible = False
        '
        'LabT_So_Luong
        '
        Me.LabT_So_Luong.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabT_So_Luong.BackColor = System.Drawing.Color.Transparent
        Me.LabT_So_Luong.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabT_So_Luong.ForeColor = System.Drawing.Color.Navy
        Me.LabT_So_Luong.Location = New System.Drawing.Point(521, 482)
        Me.LabT_So_Luong.Margin = New System.Windows.Forms.Padding(0)
        Me.LabT_So_Luong.Name = "LabT_So_Luong"
        Me.LabT_So_Luong.Size = New System.Drawing.Size(84, 16)
        Me.LabT_So_Luong.TabIndex = 2196
        Me.LabT_So_Luong.Tag = "Total"
        Me.LabT_So_Luong.Text = "Tổng điểm KPI"
        '
        'TxtT_KPI
        '
        Me.TxtT_KPI.AllowNegative = True
        Me.TxtT_KPI.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_KPI.BackColor = System.Drawing.Color.White
        Me.TxtT_KPI.Flags = 7680
        Me.TxtT_KPI.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtT_KPI.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_KPI.InputMask = "### ### ### ### ###"
        Me.TxtT_KPI.Location = New System.Drawing.Point(608, 480)
        Me.TxtT_KPI.MaxWholeDigits = 14
        Me.TxtT_KPI.Name = "TxtT_KPI"
        Me.TxtT_KPI.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_KPI.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_KPI.ReadOnly = True
        Me.TxtT_KPI.Size = New System.Drawing.Size(77, 21)
        Me.TxtT_KPI.TabIndex = 12
        Me.TxtT_KPI.Text = "0"
        Me.TxtT_KPI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(722, 480)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 14)
        Me.Label1.TabIndex = 2198
        Me.Label1.Tag = "Total"
        Me.Label1.Text = "SL vi phạm"
        '
        'TxtNV_SLVP
        '
        Me.TxtNV_SLVP.AllowNegative = True
        Me.TxtNV_SLVP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtNV_SLVP.BackColor = System.Drawing.Color.White
        Me.TxtNV_SLVP.Flags = 7680
        Me.TxtNV_SLVP.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNV_SLVP.ForeColor = System.Drawing.Color.Navy
        Me.TxtNV_SLVP.InputMask = "### ### ### ### ###"
        Me.TxtNV_SLVP.Location = New System.Drawing.Point(812, 477)
        Me.TxtNV_SLVP.MaxWholeDigits = 14
        Me.TxtNV_SLVP.Name = "TxtNV_SLVP"
        Me.TxtNV_SLVP.RangeMax = 1.7976931348623157E+308R
        Me.TxtNV_SLVP.RangeMin = -1.7976931348623157E+308R
        Me.TxtNV_SLVP.ReadOnly = True
        Me.TxtNV_SLVP.Size = New System.Drawing.Size(66, 21)
        Me.TxtNV_SLVP.TabIndex = 13
        Me.TxtNV_SLVP.Text = "0"
        Me.TxtNV_SLVP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(722, 503)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 20)
        Me.Label5.TabIndex = 2200
        Me.Label5.Tag = "Total"
        Me.Label5.Text = "Điểm trừ"
        '
        'TxtNV_DT
        '
        Me.TxtNV_DT.AllowNegative = True
        Me.TxtNV_DT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtNV_DT.BackColor = System.Drawing.Color.White
        Me.TxtNV_DT.Flags = 7680
        Me.TxtNV_DT.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNV_DT.ForeColor = System.Drawing.Color.Navy
        Me.TxtNV_DT.InputMask = "### ### ### ### ###"
        Me.TxtNV_DT.Location = New System.Drawing.Point(812, 499)
        Me.TxtNV_DT.MaxWholeDigits = 14
        Me.TxtNV_DT.Name = "TxtNV_DT"
        Me.TxtNV_DT.RangeMax = 1.7976931348623157E+308R
        Me.TxtNV_DT.RangeMin = -1.7976931348623157E+308R
        Me.TxtNV_DT.ReadOnly = True
        Me.TxtNV_DT.Size = New System.Drawing.Size(66, 21)
        Me.TxtNV_DT.TabIndex = 15
        Me.TxtNV_DT.Text = "0"
        Me.TxtNV_DT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(961, 524)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 20)
        Me.Label6.TabIndex = 2206
        Me.Label6.Tag = "Total"
        Me.Label6.Text = "Điểm còn lại"
        '
        'TxtQL_DT
        '
        Me.TxtQL_DT.AllowNegative = True
        Me.TxtQL_DT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtQL_DT.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtQL_DT.Flags = 7680
        Me.TxtQL_DT.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQL_DT.ForeColor = System.Drawing.Color.Navy
        Me.TxtQL_DT.InputMask = "### ### ### ### ###"
        Me.TxtQL_DT.Location = New System.Drawing.Point(1038, 499)
        Me.TxtQL_DT.MaxWholeDigits = 14
        Me.TxtQL_DT.Name = "TxtQL_DT"
        Me.TxtQL_DT.RangeMax = 1.7976931348623157E+308R
        Me.TxtQL_DT.RangeMin = -1.7976931348623157E+308R
        Me.TxtQL_DT.ReadOnly = True
        Me.TxtQL_DT.Size = New System.Drawing.Size(66, 21)
        Me.TxtQL_DT.TabIndex = 16
        Me.TxtQL_DT.Text = "0"
        Me.TxtQL_DT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(961, 480)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 2204
        Me.Label7.Tag = "Total"
        Me.Label7.Text = "SL vi phạm"
        '
        'TxtQL_SLVP
        '
        Me.TxtQL_SLVP.AllowNegative = True
        Me.TxtQL_SLVP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtQL_SLVP.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtQL_SLVP.Flags = 7680
        Me.TxtQL_SLVP.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQL_SLVP.ForeColor = System.Drawing.Color.Navy
        Me.TxtQL_SLVP.InputMask = "### ### ### ### ###"
        Me.TxtQL_SLVP.Location = New System.Drawing.Point(1038, 477)
        Me.TxtQL_SLVP.MaxWholeDigits = 14
        Me.TxtQL_SLVP.Name = "TxtQL_SLVP"
        Me.TxtQL_SLVP.RangeMax = 1.7976931348623157E+308R
        Me.TxtQL_SLVP.RangeMin = -1.7976931348623157E+308R
        Me.TxtQL_SLVP.ReadOnly = True
        Me.TxtQL_SLVP.Size = New System.Drawing.Size(66, 21)
        Me.TxtQL_SLVP.TabIndex = 14
        Me.TxtQL_SLVP.Text = "0"
        Me.TxtQL_SLVP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(723, 524)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 2202
        Me.Label8.Tag = "Total"
        Me.Label8.Text = "Điểm còn lại"
        '
        'TxtNV_CL
        '
        Me.TxtNV_CL.AllowNegative = True
        Me.TxtNV_CL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtNV_CL.BackColor = System.Drawing.Color.White
        Me.TxtNV_CL.Flags = 7680
        Me.TxtNV_CL.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNV_CL.ForeColor = System.Drawing.Color.Navy
        Me.TxtNV_CL.InputMask = "### ### ### ### ###"
        Me.TxtNV_CL.Location = New System.Drawing.Point(812, 522)
        Me.TxtNV_CL.MaxWholeDigits = 14
        Me.TxtNV_CL.Name = "TxtNV_CL"
        Me.TxtNV_CL.RangeMax = 1.7976931348623157E+308R
        Me.TxtNV_CL.RangeMin = -1.7976931348623157E+308R
        Me.TxtNV_CL.ReadOnly = True
        Me.TxtNV_CL.Size = New System.Drawing.Size(66, 21)
        Me.TxtNV_CL.TabIndex = 17
        Me.TxtNV_CL.Text = "0"
        Me.TxtNV_CL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(961, 503)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 14)
        Me.Label9.TabIndex = 2208
        Me.Label9.Tag = "Total"
        Me.Label9.Text = "Điểm trừ"
        '
        'TxtQL_CL
        '
        Me.TxtQL_CL.AllowNegative = True
        Me.TxtQL_CL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtQL_CL.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtQL_CL.Flags = 7680
        Me.TxtQL_CL.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQL_CL.ForeColor = System.Drawing.Color.Navy
        Me.TxtQL_CL.InputMask = "### ### ### ### ###"
        Me.TxtQL_CL.Location = New System.Drawing.Point(1038, 522)
        Me.TxtQL_CL.MaxWholeDigits = 14
        Me.TxtQL_CL.Name = "TxtQL_CL"
        Me.TxtQL_CL.RangeMax = 1.7976931348623157E+308R
        Me.TxtQL_CL.RangeMin = -1.7976931348623157E+308R
        Me.TxtQL_CL.ReadOnly = True
        Me.TxtQL_CL.Size = New System.Drawing.Size(66, 21)
        Me.TxtQL_CL.TabIndex = 18
        Me.TxtQL_CL.Text = "0"
        Me.TxtQL_CL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(619, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 18)
        Me.Label3.TabIndex = 2212
        Me.Label3.Tag = "Voucher date"
        Me.Label3.Text = "Bộ phận"
        '
        'TxtTen_Bp_H
        '
        Me.TxtTen_Bp_H.BackColor = System.Drawing.Color.White
        Me.TxtTen_Bp_H.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTen_Bp_H.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Bp_H.Location = New System.Drawing.Point(812, 113)
        Me.TxtTen_Bp_H.Name = "TxtTen_Bp_H"
        Me.TxtTen_Bp_H.ReadOnly = True
        Me.TxtTen_Bp_H.Size = New System.Drawing.Size(292, 21)
        Me.TxtTen_Bp_H.TabIndex = 4
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
        Me.TxtMa_BP_H.Location = New System.Drawing.Point(691, 113)
        Me.TxtMa_BP_H.Name = "TxtMa_BP_H"
        Me.TxtMa_BP_H.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_BP_H.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_BP_H.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_BP_H.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_BP_H.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_BP_H.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_BP_H.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_BP_H.Size = New System.Drawing.Size(110, 20)
        Me.TxtMa_BP_H.TabIndex = 6
        Me.TxtMa_BP_H.Table_Name = ""
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(12, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 18)
        Me.Label10.TabIndex = 2218
        Me.Label10.Tag = "Voucher date"
        Me.Label10.Text = "Nhân Viên"
        '
        'TxtTen_hs_h
        '
        Me.TxtTen_hs_h.BackColor = System.Drawing.Color.White
        Me.TxtTen_hs_h.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTen_hs_h.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_hs_h.Location = New System.Drawing.Point(263, 90)
        Me.TxtTen_hs_h.Name = "TxtTen_hs_h"
        Me.TxtTen_hs_h.ReadOnly = True
        Me.TxtTen_hs_h.Size = New System.Drawing.Size(279, 21)
        Me.TxtTen_hs_h.TabIndex = 6
        Me.TxtTen_hs_h.TabStop = False
        '
        'Txtma_hs_h
        '
        Me.Txtma_hs_h._ActilookupPopup = False
        Me.Txtma_hs_h.CyberActilookupPopup = True
        Me.Txtma_hs_h.Dv_ListDetail = Nothing
        Me.Txtma_hs_h.Dv_Master = Nothing
        Me.Txtma_hs_h.FilterClient = ""
        Me.Txtma_hs_h.FilterSQL = ""
        Me.Txtma_hs_h.Location = New System.Drawing.Point(124, 90)
        Me.Txtma_hs_h.Name = "Txtma_hs_h"
        Me.Txtma_hs_h.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtma_hs_h.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Txtma_hs_h.Properties.Appearance.Options.UseFont = True
        Me.Txtma_hs_h.Properties.Appearance.Options.UseForeColor = True
        Me.Txtma_hs_h.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.Txtma_hs_h.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.Txtma_hs_h.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.Txtma_hs_h.Size = New System.Drawing.Size(134, 20)
        Me.Txtma_hs_h.TabIndex = 5
        Me.Txtma_hs_h.Table_Name = ""
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(619, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 18)
        Me.Label11.TabIndex = 2221
        Me.Label11.Tag = "Voucher date"
        Me.Label11.Text = "Chức Vụ"
        '
        'TxtTen_chucvu
        '
        Me.TxtTen_chucvu.BackColor = System.Drawing.Color.White
        Me.TxtTen_chucvu.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTen_chucvu.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_chucvu.Location = New System.Drawing.Point(812, 91)
        Me.TxtTen_chucvu.Name = "TxtTen_chucvu"
        Me.TxtTen_chucvu.ReadOnly = True
        Me.TxtTen_chucvu.Size = New System.Drawing.Size(292, 21)
        Me.TxtTen_chucvu.TabIndex = 8
        Me.TxtTen_chucvu.TabStop = False
        '
        'TxtMa_chucvu
        '
        Me.TxtMa_chucvu._ActilookupPopup = False
        Me.TxtMa_chucvu.CyberActilookupPopup = True
        Me.TxtMa_chucvu.Dv_ListDetail = Nothing
        Me.TxtMa_chucvu.Dv_Master = Nothing
        Me.TxtMa_chucvu.FilterClient = ""
        Me.TxtMa_chucvu.FilterSQL = ""
        Me.TxtMa_chucvu.Location = New System.Drawing.Point(691, 91)
        Me.TxtMa_chucvu.Name = "TxtMa_chucvu"
        Me.TxtMa_chucvu.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_chucvu.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_chucvu.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_chucvu.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_chucvu.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_chucvu.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_chucvu.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_chucvu.Size = New System.Drawing.Size(110, 20)
        Me.TxtMa_chucvu.TabIndex = 8
        Me.TxtMa_chucvu.Table_Name = ""
        '
        'CbbNam
        '
        Me.CbbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbNam.ForeColor = System.Drawing.Color.Navy
        Me.CbbNam.FormattingEnabled = True
        Me.CbbNam.Location = New System.Drawing.Point(691, 58)
        Me.CbbNam.Name = "CbbNam"
        Me.CbbNam.Size = New System.Drawing.Size(110, 21)
        Me.CbbNam.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(619, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 2225
        Me.Label4.Tag = "Year"
        Me.Label4.Text = "Năm"
        '
        'CbbThang
        '
        Me.CbbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbThang.ForeColor = System.Drawing.Color.Navy
        Me.CbbThang.FormattingEnabled = True
        Me.CbbThang.Location = New System.Drawing.Point(691, 34)
        Me.CbbThang.Name = "CbbThang"
        Me.CbbThang.Size = New System.Drawing.Size(110, 21)
        Me.CbbThang.TabIndex = 3
        '
        'LabM_month1
        '
        Me.LabM_month1.AutoSize = True
        Me.LabM_month1.Location = New System.Drawing.Point(619, 37)
        Me.LabM_month1.Name = "LabM_month1"
        Me.LabM_month1.Size = New System.Drawing.Size(38, 13)
        Me.LabM_month1.TabIndex = 2224
        Me.LabM_month1.Tag = "Month"
        Me.LabM_month1.Text = "Tháng"
        '
        'TxtGio_XacNhan
        '
        Me.TxtGio_XacNhan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtGio_XacNhan.BackColor = System.Drawing.Color.White
        Me.TxtGio_XacNhan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGio_XacNhan.ForeColor = System.Drawing.Color.Navy
        Me.TxtGio_XacNhan.Location = New System.Drawing.Point(317, 504)
        Me.TxtGio_XacNhan.Name = "TxtGio_XacNhan"
        Me.TxtGio_XacNhan.Size = New System.Drawing.Size(47, 20)
        Me.TxtGio_XacNhan.TabIndex = 2228
        Me.TxtGio_XacNhan.Tag = ""
        Me.TxtGio_XacNhan.Text = "24:44"
        Me.TxtGio_XacNhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtNgay_XacNhan
        '
        Me.TxtNgay_XacNhan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtNgay_XacNhan.BackColor = System.Drawing.Color.White
        Me.TxtNgay_XacNhan.Flags = 65536
        Me.TxtNgay_XacNhan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_XacNhan.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_XacNhan.isEmpty = True
        Me.TxtNgay_XacNhan.Location = New System.Drawing.Point(366, 504)
        Me.TxtNgay_XacNhan.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_XacNhan.MaxLength = 10
        Me.TxtNgay_XacNhan.Name = "TxtNgay_XacNhan"
        Me.TxtNgay_XacNhan.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_XacNhan.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_XacNhan.ReadOnly = True
        Me.TxtNgay_XacNhan.ShowDayBeforeMonth = False
        Me.TxtNgay_XacNhan.Size = New System.Drawing.Size(73, 20)
        Me.TxtNgay_XacNhan.TabIndex = 2227
        Me.TxtNgay_XacNhan.Text = "18/09/2011"
        Me.TxtNgay_XacNhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_XacNhan.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        '
        'BttXacNhan
        '
        Me.BttXacNhan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BttXacNhan.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.BttXacNhan.Appearance.Options.UseForeColor = True
        Me.BttXacNhan.Image = CType(resources.GetObject("BttXacNhan.Image"), System.Drawing.Image)
        Me.BttXacNhan.Location = New System.Drawing.Point(228, 502)
        Me.BttXacNhan.Name = "BttXacNhan"
        Me.BttXacNhan.Size = New System.Drawing.Size(78, 25)
        Me.BttXacNhan.TabIndex = 2226
        Me.BttXacNhan.Text = "Xác nhận"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(795, 458)
        Me.Label12.Margin = New System.Windows.Forms.Padding(0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 16)
        Me.Label12.TabIndex = 2229
        Me.Label12.Tag = "Total"
        Me.Label12.Text = "Tự đánh giá"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(1018, 458)
        Me.Label13.Margin = New System.Windows.Forms.Padding(0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 16)
        Me.Label13.TabIndex = 2230
        Me.Label13.Tag = "Total"
        Me.Label13.Text = "TBP đánh giá"
        '
        'KPI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1112, 591)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtGio_XacNhan)
        Me.Controls.Add(Me.TxtNgay_XacNhan)
        Me.Controls.Add(Me.BttXacNhan)
        Me.Controls.Add(Me.CbbNam)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CbbThang)
        Me.Controls.Add(Me.LabM_month1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtTen_chucvu)
        Me.Controls.Add(Me.TxtMa_chucvu)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtTen_hs_h)
        Me.Controls.Add(Me.Txtma_hs_h)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTen_Bp_H)
        Me.Controls.Add(Me.TxtMa_BP_H)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtQL_CL)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtQL_DT)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtQL_SLVP)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtNV_CL)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtNV_DT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNV_SLVP)
        Me.Controls.Add(Me.LabT_So_Luong)
        Me.Controls.Add(Me.TxtT_KPI)
        Me.Controls.Add(Me.TxtNgay_LCt)
        Me.Controls.Add(Me.Txtdien_giai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Detail)
        Me.Controls.Add(Me.LabMa_TTCP_H)
        Me.Controls.Add(Me.CbbMa_TTCP_H)
        Me.Controls.Add(Me.ChkNonVAT)
        Me.Controls.Add(Me.TxtLenh_Vt)
        Me.Controls.Add(Me.txtSo_Seri0)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.TxtNgay_Ct)
        Me.Controls.Add(Me.CbbMa_GD)
        Me.Controls.Add(Me.LabNgay_Ct)
        Me.Controls.Add(Me.lblLoai_ct)
        Me.Controls.Add(Me.lblSo_ct)
        Me.Controls.Add(Me.TxtSo_Ct)
        Me.Controls.Add(Me.TxtStt_Rec)
        Me.Controls.Add(Me.TxtMa_Dvcs)
        Me.Controls.Add(Me.TxtLenh_SO)
        Me.Controls.Add(Me.TxtLenh_PO)
        Me.Controls.Add(Me.TxtLenh_RO)
        Me.Controls.Add(Me.TxtMa_Quyen)
        Me.Controls.Add(Me.LabMa_Quyen)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1022, 597)
        Me.Name = "KPI"
        Me.Text = "PHIẾU ĐÁNH GIÁ KPIs THÁNG"
        Me.Controls.SetChildIndex(Me.LabMa_Quyen, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Quyen, 0)
        Me.Controls.SetChildIndex(Me.TxtLenh_RO, 0)
        Me.Controls.SetChildIndex(Me.TxtLenh_PO, 0)
        Me.Controls.SetChildIndex(Me.TxtLenh_SO, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.TxtStt_Rec, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Ct, 0)
        Me.Controls.SetChildIndex(Me.lblSo_ct, 0)
        Me.Controls.SetChildIndex(Me.lblLoai_ct, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_Ct, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_GD, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.txtSo_Seri0, 0)
        Me.Controls.SetChildIndex(Me.TxtLenh_Vt, 0)
        Me.Controls.SetChildIndex(Me.ChkNonVAT, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_TTCP_H, 0)
        Me.Controls.SetChildIndex(Me.LabMa_TTCP_H, 0)
        Me.Controls.SetChildIndex(Me.Detail, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Txtdien_giai, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_LCt, 0)
        Me.Controls.SetChildIndex(Me.TxtT_KPI, 0)
        Me.Controls.SetChildIndex(Me.LabT_So_Luong, 0)
        Me.Controls.SetChildIndex(Me.TxtNV_SLVP, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtNV_DT, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtNV_CL, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.TxtQL_SLVP, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.TxtQL_DT, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TxtQL_CL, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_BP_H, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Bp_H, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Txtma_hs_h, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_hs_h, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_chucvu, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_chucvu, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.LabM_month1, 0)
        Me.Controls.SetChildIndex(Me.CbbThang, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.CbbNam, 0)
        Me.Controls.SetChildIndex(Me.BttXacNhan, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_XacNhan, 0)
        Me.Controls.SetChildIndex(Me.TxtGio_XacNhan, 0)
        Me.Controls.SetChildIndex(Me.TxtUser_id, 0)
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
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        CType(Me.PopupMenuMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_BP_H.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txtma_hs_h.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_chucvu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbbMa_GD As System.Windows.Forms.ComboBox
    Friend WithEvents TxtMa_Quyen As System.Windows.Forms.TextBox
    Friend WithEvents LabMa_Quyen As System.Windows.Forms.Label
    Friend WithEvents LabNgay_Ct As System.Windows.Forms.Label
    Friend WithEvents lblLoai_ct As System.Windows.Forms.Label
    Friend WithEvents lblSo_ct As System.Windows.Forms.Label
    Friend WithEvents TxtSo_Ct As System.Windows.Forms.TextBox
    Friend WithEvents TxtNgay_Ct As ClsTextBox.txtDate
    Friend WithEvents TxtMa_Dvcs As System.Windows.Forms.TextBox
    Friend WithEvents TxtStt_Rec As System.Windows.Forms.TextBox
    Friend WithEvents PopupMenuMasterGrid As DevExpress.XtraBars.PopupMenu
    Friend WithEvents TxtLenh_RO As System.Windows.Forms.TextBox
    Friend WithEvents TxtLenh_PO As System.Windows.Forms.TextBox
    Friend WithEvents TxtLenh_Vt As System.Windows.Forms.TextBox
    Friend WithEvents ChkNonVAT As System.Windows.Forms.CheckBox
    Friend WithEvents TxtLenh_SO As TextBox
    Friend WithEvents txtSo_Seri0 As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents CbbMa_TTCP_H As ComboBox
    Friend WithEvents LabMa_TTCP_H As Label
    Friend WithEvents Detail As DevExpress.XtraGrid.GridControl
    Friend WithEvents DetailGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Txtdien_giai As TextBox
    Friend WithEvents GroupBoxLine As GroupBox
    Friend WithEvents TxtNgay_LCt As ClsTextBox.txtDate
    Friend WithEvents LabT_So_Luong As Label
    Friend WithEvents TxtT_KPI As ClsTextBox.txtTien_NT
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNV_SLVP As ClsTextBox.txtTien_NT
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtNV_DT As ClsTextBox.txtTien_NT
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtQL_DT As ClsTextBox.txtTien_NT
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtQL_SLVP As ClsTextBox.txtTien_NT
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtNV_CL As ClsTextBox.txtTien_NT
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtQL_CL As ClsTextBox.txtTien_NT
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtTen_Bp_H As TextBox
    Friend WithEvents TxtMa_BP_H As SmLists.TxtLookup
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtTen_hs_h As TextBox
    Friend WithEvents Txtma_hs_h As SmLists.TxtLookup
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtTen_chucvu As TextBox
    Friend WithEvents TxtMa_chucvu As SmLists.TxtLookup
    Friend WithEvents CbbNam As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CbbThang As ComboBox
    Friend WithEvents LabM_month1 As Label
    Friend WithEvents TxtGio_XacNhan As TextBox
    Friend WithEvents TxtNgay_XacNhan As ClsTextBox.txtDate
    Friend WithEvents BttXacNhan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
