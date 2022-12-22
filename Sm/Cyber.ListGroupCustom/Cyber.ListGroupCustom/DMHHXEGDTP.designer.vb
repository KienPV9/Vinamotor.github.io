<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMHHXEGDTP
    Inherits Cyber.From.FrmList

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
        Me.TxtNgay_HL = New ClsTextBox.txtDate()
        Me.LabLs_TH = New System.Windows.Forms.Label()
        Me.TxtPT_CT1 = New ClsTextBox.txtTien_NT()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh4 = New System.Windows.Forms.TextBox()
        Me.TxtTen_Nh5 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh_Hs4 = New System.Windows.Forms.TextBox()
        Me.TxtNh_HS4 = New Cyber.SmLists.TxtLookup()
        Me.TxtTien_HH1 = New ClsTextBox.txtTien_NT()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTien_HH2 = New ClsTextBox.txtTien_NT()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPT_CT3 = New ClsTextBox.txtTien_NT()
        Me.TxtTien_HH3 = New ClsTextBox.txtTien_NT()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPT_CT5 = New ClsTextBox.txtTien_NT()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtPT_CT4 = New ClsTextBox.txtTien_NT()
        Me.TxtPT_CT2 = New ClsTextBox.txtTien_NT()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.TxtNh_HS4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(622, 147)
        Me.ButtExit.TabIndex = 13
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(520, 147)
        Me.ButtOK.TabIndex = 12
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(414, 153)
        Me.TxtMa_Dvcs.TabIndex = 5
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 157)
        Me.ChkActi.TabIndex = 11
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 137)
        Me.GroupBoxLine.Size = New System.Drawing.Size(720, 9)
        Me.GroupBoxLine.TabIndex = 10
        '
        'TxtNgay_HL
        '
        Me.TxtNgay_HL.Flags = 65536
        Me.TxtNgay_HL.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_HL.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_HL.isEmpty = True
        Me.TxtNgay_HL.Location = New System.Drawing.Point(110, 11)
        Me.TxtNgay_HL.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_HL.MaxLength = 10
        Me.TxtNgay_HL.Name = "TxtNgay_HL"
        Me.TxtNgay_HL.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_HL.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_HL.ShowDayBeforeMonth = False
        Me.TxtNgay_HL.Size = New System.Drawing.Size(124, 21)
        Me.TxtNgay_HL.TabIndex = 0
        Me.TxtNgay_HL.Text = "26/07/2011"
        Me.TxtNgay_HL.Value = New Date(2011, 7, 26, 0, 0, 0, 0)
        '
        'LabLs_TH
        '
        Me.LabLs_TH.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabLs_TH.ForeColor = System.Drawing.Color.Navy
        Me.LabLs_TH.Location = New System.Drawing.Point(5, 63)
        Me.LabLs_TH.Name = "LabLs_TH"
        Me.LabLs_TH.Size = New System.Drawing.Size(94, 15)
        Me.LabLs_TH.TabIndex = 376
        Me.LabLs_TH.Tag = "term interest rates"
        Me.LabLs_TH.Text = "PT đạt chỉ tiêu 1"
        '
        'TxtPT_CT1
        '
        Me.TxtPT_CT1.AllowNegative = True
        Me.TxtPT_CT1.Flags = 7680
        Me.TxtPT_CT1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPT_CT1.ForeColor = System.Drawing.Color.Navy
        Me.TxtPT_CT1.InputMask = "### ###.#0"
        Me.TxtPT_CT1.Location = New System.Drawing.Point(110, 60)
        Me.TxtPT_CT1.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPT_CT1.MaxWholeDigits = 8
        Me.TxtPT_CT1.Name = "TxtPT_CT1"
        Me.TxtPT_CT1.RangeMax = 1.7976931348623157E+308R
        Me.TxtPT_CT1.RangeMin = -1.7976931348623157E+308R
        Me.TxtPT_CT1.Size = New System.Drawing.Size(124, 21)
        Me.TxtPT_CT1.TabIndex = 2
        Me.TxtPT_CT1.Text = "0.00"
        Me.TxtPT_CT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(5, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 14)
        Me.Label2.TabIndex = 398
        Me.Label2.Tag = "Group 1"
        Me.Label2.Text = "Từ ngày"
        '
        'TxtTen_Nh4
        '
        Me.TxtTen_Nh4.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh4.Enabled = False
        Me.TxtTen_Nh4.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh4.Location = New System.Drawing.Point(242, 222)
        Me.TxtTen_Nh4.Name = "TxtTen_Nh4"
        Me.TxtTen_Nh4.ReadOnly = True
        Me.TxtTen_Nh4.Size = New System.Drawing.Size(412, 14)
        Me.TxtTen_Nh4.TabIndex = 403
        Me.TxtTen_Nh4.TabStop = False
        '
        'TxtTen_Nh5
        '
        Me.TxtTen_Nh5.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh5.Enabled = False
        Me.TxtTen_Nh5.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh5.Location = New System.Drawing.Point(240, 213)
        Me.TxtTen_Nh5.Name = "TxtTen_Nh5"
        Me.TxtTen_Nh5.ReadOnly = True
        Me.TxtTen_Nh5.Size = New System.Drawing.Size(412, 14)
        Me.TxtTen_Nh5.TabIndex = 404
        Me.TxtTen_Nh5.TabStop = False
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(5, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 14)
        Me.Label9.TabIndex = 411
        Me.Label9.Tag = "Group 1"
        Me.Label9.Text = "Chức vụ"
        '
        'TxtTen_Nh_Hs4
        '
        Me.TxtTen_Nh_Hs4.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh_Hs4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh_Hs4.Enabled = False
        Me.TxtTen_Nh_Hs4.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh_Hs4.Location = New System.Drawing.Point(240, 38)
        Me.TxtTen_Nh_Hs4.Name = "TxtTen_Nh_Hs4"
        Me.TxtTen_Nh_Hs4.ReadOnly = True
        Me.TxtTen_Nh_Hs4.Size = New System.Drawing.Size(412, 14)
        Me.TxtTen_Nh_Hs4.TabIndex = 412
        Me.TxtTen_Nh_Hs4.TabStop = False
        '
        'TxtNh_HS4
        '
        Me.TxtNh_HS4._ActilookupPopup = False
        Me.TxtNh_HS4.CyberActilookupPopup = True
        Me.TxtNh_HS4.Dv_ListDetail = Nothing
        Me.TxtNh_HS4.Dv_Master = Nothing
        Me.TxtNh_HS4.FilterClient = ""
        Me.TxtNh_HS4.FilterSQL = ""
        Me.TxtNh_HS4.Location = New System.Drawing.Point(110, 35)
        Me.TxtNh_HS4.Name = "TxtNh_HS4"
        Me.TxtNh_HS4.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_HS4.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_HS4.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_HS4.Size = New System.Drawing.Size(124, 20)
        Me.TxtNh_HS4.TabIndex = 1
        Me.TxtNh_HS4.Table_Name = ""
        '
        'TxtTien_HH1
        '
        Me.TxtTien_HH1.AllowNegative = True
        Me.TxtTien_HH1.Flags = 7680
        Me.TxtTien_HH1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTien_HH1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTien_HH1.InputMask = "### ###.#0"
        Me.TxtTien_HH1.Location = New System.Drawing.Point(595, 60)
        Me.TxtTien_HH1.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTien_HH1.MaxWholeDigits = 8
        Me.TxtTien_HH1.Name = "TxtTien_HH1"
        Me.TxtTien_HH1.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien_HH1.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien_HH1.Size = New System.Drawing.Size(124, 21)
        Me.TxtTien_HH1.TabIndex = 4
        Me.TxtTien_HH1.Text = "0.00"
        Me.TxtTien_HH1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(490, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 15)
        Me.Label1.TabIndex = 414
        Me.Label1.Tag = "term interest rates"
        Me.Label1.Text = "Tiền hoa hồng 1"
        '
        'TxtTien_HH2
        '
        Me.TxtTien_HH2.AllowNegative = True
        Me.TxtTien_HH2.Flags = 7680
        Me.TxtTien_HH2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTien_HH2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTien_HH2.InputMask = "### ###.#0"
        Me.TxtTien_HH2.Location = New System.Drawing.Point(595, 85)
        Me.TxtTien_HH2.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTien_HH2.MaxWholeDigits = 8
        Me.TxtTien_HH2.Name = "TxtTien_HH2"
        Me.TxtTien_HH2.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien_HH2.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien_HH2.Size = New System.Drawing.Size(124, 21)
        Me.TxtTien_HH2.TabIndex = 7
        Me.TxtTien_HH2.Text = "0.00"
        Me.TxtTien_HH2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(490, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 15)
        Me.Label3.TabIndex = 416
        Me.Label3.Tag = "term interest rates"
        Me.Label3.Text = "Tiền hoa hồng 2"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(5, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 15)
        Me.Label4.TabIndex = 416
        Me.Label4.Tag = "term interest rates"
        Me.Label4.Text = "PT đạt chỉ tiêu 3"
        '
        'TxtPT_CT3
        '
        Me.TxtPT_CT3.AllowNegative = True
        Me.TxtPT_CT3.Flags = 7680
        Me.TxtPT_CT3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPT_CT3.ForeColor = System.Drawing.Color.Navy
        Me.TxtPT_CT3.InputMask = "### ###.#0"
        Me.TxtPT_CT3.Location = New System.Drawing.Point(110, 85)
        Me.TxtPT_CT3.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPT_CT3.MaxWholeDigits = 8
        Me.TxtPT_CT3.Name = "TxtPT_CT3"
        Me.TxtPT_CT3.RangeMax = 1.7976931348623157E+308R
        Me.TxtPT_CT3.RangeMin = -1.7976931348623157E+308R
        Me.TxtPT_CT3.Size = New System.Drawing.Size(124, 21)
        Me.TxtPT_CT3.TabIndex = 5
        Me.TxtPT_CT3.Text = "0.00"
        Me.TxtPT_CT3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTien_HH3
        '
        Me.TxtTien_HH3.AllowNegative = True
        Me.TxtTien_HH3.Flags = 7680
        Me.TxtTien_HH3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTien_HH3.ForeColor = System.Drawing.Color.Navy
        Me.TxtTien_HH3.InputMask = "### ###.#0"
        Me.TxtTien_HH3.Location = New System.Drawing.Point(595, 111)
        Me.TxtTien_HH3.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTien_HH3.MaxWholeDigits = 8
        Me.TxtTien_HH3.Name = "TxtTien_HH3"
        Me.TxtTien_HH3.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien_HH3.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien_HH3.Size = New System.Drawing.Size(124, 21)
        Me.TxtTien_HH3.TabIndex = 9
        Me.TxtTien_HH3.Text = "0.00"
        Me.TxtTien_HH3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(490, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 15)
        Me.Label5.TabIndex = 418
        Me.Label5.Tag = "term interest rates"
        Me.Label5.Text = "Tiền hoa hồng 3"
        '
        'TxtPT_CT5
        '
        Me.TxtPT_CT5.AllowNegative = True
        Me.TxtPT_CT5.Flags = 7680
        Me.TxtPT_CT5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPT_CT5.ForeColor = System.Drawing.Color.Navy
        Me.TxtPT_CT5.InputMask = "### ###.#0"
        Me.TxtPT_CT5.Location = New System.Drawing.Point(110, 111)
        Me.TxtPT_CT5.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPT_CT5.MaxWholeDigits = 8
        Me.TxtPT_CT5.Name = "TxtPT_CT5"
        Me.TxtPT_CT5.RangeMax = 1.7976931348623157E+308R
        Me.TxtPT_CT5.RangeMin = -1.7976931348623157E+308R
        Me.TxtPT_CT5.Size = New System.Drawing.Size(124, 21)
        Me.TxtPT_CT5.TabIndex = 8
        Me.TxtPT_CT5.Text = "0.00"
        Me.TxtPT_CT5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(5, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 15)
        Me.Label6.TabIndex = 420
        Me.Label6.Tag = "term interest rates"
        Me.Label6.Text = "PT đạt chỉ tiêu 5"
        '
        'TxtPT_CT4
        '
        Me.TxtPT_CT4.AllowNegative = True
        Me.TxtPT_CT4.Flags = 7680
        Me.TxtPT_CT4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPT_CT4.ForeColor = System.Drawing.Color.Navy
        Me.TxtPT_CT4.InputMask = "### ###.#0"
        Me.TxtPT_CT4.Location = New System.Drawing.Point(352, 85)
        Me.TxtPT_CT4.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPT_CT4.MaxWholeDigits = 8
        Me.TxtPT_CT4.Name = "TxtPT_CT4"
        Me.TxtPT_CT4.RangeMax = 1.7976931348623157E+308R
        Me.TxtPT_CT4.RangeMin = -1.7976931348623157E+308R
        Me.TxtPT_CT4.Size = New System.Drawing.Size(124, 21)
        Me.TxtPT_CT4.TabIndex = 6
        Me.TxtPT_CT4.Text = "0.00"
        Me.TxtPT_CT4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtPT_CT2
        '
        Me.TxtPT_CT2.AllowNegative = True
        Me.TxtPT_CT2.Flags = 7680
        Me.TxtPT_CT2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPT_CT2.ForeColor = System.Drawing.Color.Navy
        Me.TxtPT_CT2.InputMask = "### ###.#0"
        Me.TxtPT_CT2.Location = New System.Drawing.Point(352, 60)
        Me.TxtPT_CT2.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPT_CT2.MaxWholeDigits = 8
        Me.TxtPT_CT2.Name = "TxtPT_CT2"
        Me.TxtPT_CT2.RangeMax = 1.7976931348623157E+308R
        Me.TxtPT_CT2.RangeMin = -1.7976931348623157E+308R
        Me.TxtPT_CT2.Size = New System.Drawing.Size(124, 21)
        Me.TxtPT_CT2.TabIndex = 3
        Me.TxtPT_CT2.Text = "0.00"
        Me.TxtPT_CT2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(247, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 15)
        Me.Label8.TabIndex = 424
        Me.Label8.Tag = "term interest rates"
        Me.Label8.Text = "PT đạt chỉ tiêu 4"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(247, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 15)
        Me.Label10.TabIndex = 422
        Me.Label10.Tag = "term interest rates"
        Me.Label10.Text = "PT đạt chỉ tiêu 2"
        '
        'DMHHXEGDTP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(724, 180)
        Me.Controls.Add(Me.TxtPT_CT4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtPT_CT2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtPT_CT5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtTien_HH3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtPT_CT3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTien_HH2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTien_HH1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtTen_Nh_Hs4)
        Me.Controls.Add(Me.TxtNh_HS4)
        Me.Controls.Add(Me.TxtTen_Nh5)
        Me.Controls.Add(Me.TxtTen_Nh4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtPT_CT1)
        Me.Controls.Add(Me.LabLs_TH)
        Me.Controls.Add(Me.TxtNgay_HL)
        Me.KeyPreview = True
        Me.Name = "DMHHXEGDTP"
        Me.Text = "Danh mục đăng ký giảm giá"
        Me.Controls.SetChildIndex(Me.TxtNgay_HL, 0)
        Me.Controls.SetChildIndex(Me.LabLs_TH, 0)
        Me.Controls.SetChildIndex(Me.TxtPT_CT1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh4, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh5, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_HS4, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh_Hs4, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtTien_HH1, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtTien_HH2, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtPT_CT3, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtTien_HH3, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TxtPT_CT5, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.TxtPT_CT2, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.TxtPT_CT4, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        CType(Me.TxtNh_HS4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNgay_HL As ClsTextBox.txtDate
    Friend WithEvents LabLs_TH As System.Windows.Forms.Label
    Friend WithEvents TxtPT_CT1 As ClsTextBox.txtTien_NT
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh4 As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_Nh5 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh_Hs4 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_HS4 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTien_HH1 As ClsTextBox.txtTien_NT
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTien_HH2 As ClsTextBox.txtTien_NT
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtPT_CT3 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtTien_HH3 As ClsTextBox.txtTien_NT
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtPT_CT5 As ClsTextBox.txtTien_NT
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtPT_CT4 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtPT_CT2 As ClsTextBox.txtTien_NT
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label

End Class
