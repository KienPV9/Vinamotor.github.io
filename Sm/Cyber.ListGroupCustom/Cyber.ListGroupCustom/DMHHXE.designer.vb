<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMHHXE
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
        Me.TxtTien_HH = New ClsTextBox.txtTien_NT()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh4 = New System.Windows.Forms.TextBox()
        Me.TxtTen_Nh5 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtTen_Kx = New System.Windows.Forms.TextBox()
        Me.TxtMa_Kx = New Cyber.SmLists.TxtLookup()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtPT_HH = New ClsTextBox.txtTien_NT()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ChkIsDb = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtNam_sx = New ClsTextBox.txtTy_Gia()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNgay_KT = New ClsTextBox.txtDate()
        CType(Me.TxtMa_Kx.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(557, 164)
        Me.ButtExit.TabIndex = 10
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(455, 164)
        Me.ButtOK.TabIndex = 9
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(349, 170)
        Me.TxtMa_Dvcs.TabIndex = 8
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 174)
        Me.ChkActi.TabIndex = 7
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 154)
        Me.GroupBoxLine.Size = New System.Drawing.Size(655, 9)
        Me.GroupBoxLine.TabIndex = 6
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
        Me.LabLs_TH.Location = New System.Drawing.Point(5, 62)
        Me.LabLs_TH.Name = "LabLs_TH"
        Me.LabLs_TH.Size = New System.Drawing.Size(94, 15)
        Me.LabLs_TH.TabIndex = 376
        Me.LabLs_TH.Tag = "term interest rates"
        Me.LabLs_TH.Text = "Tiền hoa hồng"
        '
        'TxtTien_HH
        '
        Me.TxtTien_HH.AllowNegative = True
        Me.TxtTien_HH.Flags = 7680
        Me.TxtTien_HH.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTien_HH.ForeColor = System.Drawing.Color.Navy
        Me.TxtTien_HH.InputMask = "### ###.#0"
        Me.TxtTien_HH.Location = New System.Drawing.Point(110, 58)
        Me.TxtTien_HH.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTien_HH.MaxWholeDigits = 8
        Me.TxtTien_HH.Name = "TxtTien_HH"
        Me.TxtTien_HH.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien_HH.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien_HH.Size = New System.Drawing.Size(124, 21)
        Me.TxtTien_HH.TabIndex = 2
        Me.TxtTien_HH.Text = "0.00"
        Me.TxtTien_HH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.Label9.Location = New System.Drawing.Point(5, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 14)
        Me.Label9.TabIndex = 411
        Me.Label9.Tag = "Group 1"
        Me.Label9.Text = "Kiểu xe"
        '
        'TxtTen_Kx
        '
        Me.TxtTen_Kx.BackColor = System.Drawing.Color.White
        Me.TxtTen_Kx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Kx.Enabled = False
        Me.TxtTen_Kx.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Kx.Location = New System.Drawing.Point(240, 38)
        Me.TxtTen_Kx.Name = "TxtTen_Kx"
        Me.TxtTen_Kx.ReadOnly = True
        Me.TxtTen_Kx.Size = New System.Drawing.Size(412, 14)
        Me.TxtTen_Kx.TabIndex = 10
        Me.TxtTen_Kx.TabStop = False
        '
        'TxtMa_Kx
        '
        Me.TxtMa_Kx._ActilookupPopup = False
        Me.TxtMa_Kx.CyberActilookupPopup = True
        Me.TxtMa_Kx.Dv_ListDetail = Nothing
        Me.TxtMa_Kx.Dv_Master = Nothing
        Me.TxtMa_Kx.FilterClient = ""
        Me.TxtMa_Kx.FilterSQL = ""
        Me.TxtMa_Kx.Location = New System.Drawing.Point(110, 35)
        Me.TxtMa_Kx.Name = "TxtMa_Kx"
        Me.TxtMa_Kx.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kx.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kx.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kx.Size = New System.Drawing.Size(124, 20)
        Me.TxtMa_Kx.TabIndex = 1
        Me.TxtMa_Kx.Table_Name = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(234, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 15)
        Me.Label1.TabIndex = 415
        Me.Label1.Tag = "VND"
        Me.Label1.Text = "%"
        '
        'TxtPT_HH
        '
        Me.TxtPT_HH.AllowNegative = True
        Me.TxtPT_HH.Flags = 7680
        Me.TxtPT_HH.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPT_HH.ForeColor = System.Drawing.Color.Navy
        Me.TxtPT_HH.InputMask = "### ###.#0"
        Me.TxtPT_HH.Location = New System.Drawing.Point(110, 82)
        Me.TxtPT_HH.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPT_HH.MaxWholeDigits = 8
        Me.TxtPT_HH.Name = "TxtPT_HH"
        Me.TxtPT_HH.RangeMax = 1.7976931348623157E+308R
        Me.TxtPT_HH.RangeMin = -1.7976931348623157E+308R
        Me.TxtPT_HH.Size = New System.Drawing.Size(124, 21)
        Me.TxtPT_HH.TabIndex = 3
        Me.TxtPT_HH.Text = "0.00"
        Me.TxtPT_HH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(5, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 15)
        Me.Label3.TabIndex = 414
        Me.Label3.Tag = "term interest rates"
        Me.Label3.Text = "% Hoa hồng"
        '
        'ChkIsDb
        '
        Me.ChkIsDb.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.ChkIsDb.ForeColor = System.Drawing.Color.Navy
        Me.ChkIsDb.Location = New System.Drawing.Point(110, 131)
        Me.ChkIsDb.Name = "ChkIsDb"
        Me.ChkIsDb.Size = New System.Drawing.Size(113, 17)
        Me.ChkIsDb.TabIndex = 5
        Me.ChkIsDb.Tag = "Customer"
        Me.ChkIsDb.Text = "Bản đặc biệt"
        '
        'Label11
        '
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(5, 109)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 14)
        Me.Label11.TabIndex = 437
        Me.Label11.Tag = "Date"
        Me.Label11.Text = "Năm SX"
        '
        'TxtNam_sx
        '
        Me.TxtNam_sx.AllowNegative = True
        Me.TxtNam_sx.Flags = 7680
        Me.TxtNam_sx.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNam_sx.ForeColor = System.Drawing.Color.Navy
        Me.TxtNam_sx.InputMask = "#####"
        Me.TxtNam_sx.Location = New System.Drawing.Point(110, 104)
        Me.TxtNam_sx.MaxWholeDigits = 4
        Me.TxtNam_sx.Name = "TxtNam_sx"
        Me.TxtNam_sx.RangeMax = 1.7976931348623157E+308R
        Me.TxtNam_sx.RangeMin = -1.7976931348623157E+308R
        Me.TxtNam_sx.Size = New System.Drawing.Size(124, 21)
        Me.TxtNam_sx.TabIndex = 4
        Me.TxtNam_sx.Text = "0"
        Me.TxtNam_sx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(270, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 14)
        Me.Label4.TabIndex = 439
        Me.Label4.Tag = "Group 1"
        Me.Label4.Text = "Đến ngày"
        '
        'TxtNgay_KT
        '
        Me.TxtNgay_KT.Flags = 65536
        Me.TxtNgay_KT.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_KT.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_KT.isEmpty = True
        Me.TxtNgay_KT.Location = New System.Drawing.Point(349, 11)
        Me.TxtNgay_KT.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_KT.MaxLength = 10
        Me.TxtNgay_KT.Name = "TxtNgay_KT"
        Me.TxtNgay_KT.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_KT.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_KT.ShowDayBeforeMonth = False
        Me.TxtNgay_KT.Size = New System.Drawing.Size(124, 21)
        Me.TxtNgay_KT.TabIndex = 438
        Me.TxtNgay_KT.Text = "26/07/2011"
        Me.TxtNgay_KT.Value = New Date(2011, 7, 26, 0, 0, 0, 0)
        '
        'DMHHXE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(659, 197)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtNgay_KT)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtNam_sx)
        Me.Controls.Add(Me.ChkIsDb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtPT_HH)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtTen_Kx)
        Me.Controls.Add(Me.TxtMa_Kx)
        Me.Controls.Add(Me.TxtTen_Nh5)
        Me.Controls.Add(Me.TxtTen_Nh4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTien_HH)
        Me.Controls.Add(Me.LabLs_TH)
        Me.Controls.Add(Me.TxtNgay_HL)
        Me.KeyPreview = True
        Me.Name = "DMHHXE"
        Me.Text = "Danh mục đăng ký giảm giá"
        Me.Controls.SetChildIndex(Me.TxtNgay_HL, 0)
        Me.Controls.SetChildIndex(Me.LabLs_TH, 0)
        Me.Controls.SetChildIndex(Me.TxtTien_HH, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh4, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh5, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kx, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Kx, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtPT_HH, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ChkIsDb, 0)
        Me.Controls.SetChildIndex(Me.TxtNam_sx, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_KT, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        CType(Me.TxtMa_Kx.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNgay_HL As ClsTextBox.txtDate
    Friend WithEvents LabLs_TH As System.Windows.Forms.Label
    Friend WithEvents TxtTien_HH As ClsTextBox.txtTien_NT
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh4 As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_Nh5 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Kx As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Kx As Cyber.SmLists.TxtLookup
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtPT_HH As ClsTextBox.txtTien_NT
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ChkIsDb As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtNam_sx As ClsTextBox.txtTy_Gia
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_KT As ClsTextBox.txtDate

End Class
