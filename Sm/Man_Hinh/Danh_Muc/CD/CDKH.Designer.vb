<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CDKH
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtNam = New System.Windows.Forms.TextBox()
        Me.TxtDu_Co_nt1 = New ClsTextBox.txtTien_NT()
        Me.TxtDu_No_nt1 = New ClsTextBox.txtTien_NT()
        Me.TxtDu_Co1 = New ClsTextBox.txtTien_NT()
        Me.TxtDu_No1 = New ClsTextBox.txtTien_NT()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtDu_Co_NT00 = New ClsTextBox.txtTien_NT()
        Me.TxtDu_No_NT00 = New ClsTextBox.txtTien_NT()
        Me.TxtDu_Co00 = New ClsTextBox.txtTien_NT()
        Me.TxtDu_no00 = New ClsTextBox.txtTien_NT()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_TK = New System.Windows.Forms.TextBox()
        Me.lbMa_Phi = New System.Windows.Forms.Label()
        Me.lbTen_phi2 = New System.Windows.Forms.Label()
        Me.Txtten_DVCS = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtTK = New Cyber.SmLists.TxtLookup()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtMa_NT = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_NT = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtMa_Kh = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_kh = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.TxtTK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_NT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Kh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(909, 320)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 14
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(773, 320)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 13
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(196, 35)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Dvcs.ReadOnly = True
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(179, 24)
        Me.TxtMa_Dvcs.TabIndex = 0
        Me.TxtMa_Dvcs.TabStop = False
        Me.TxtMa_Dvcs.Visible = True
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(147, 333)
        Me.ChkActi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkActi.TabIndex = 12
        Me.ChkActi.Visible = False
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 307)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(780, 10)
        Me.GroupBoxLine.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(7, 5)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(176, 24)
        Me.Label10.TabIndex = 270
        Me.Label10.Tag = "Year"
        Me.Label10.Text = "Năm"
        '
        'TxtNam
        '
        Me.TxtNam.BackColor = System.Drawing.Color.White
        Me.TxtNam.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNam.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNam.ForeColor = System.Drawing.Color.Navy
        Me.TxtNam.Location = New System.Drawing.Point(196, 3)
        Me.TxtNam.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNam.Name = "TxtNam"
        Me.TxtNam.ReadOnly = True
        Me.TxtNam.Size = New System.Drawing.Size(179, 24)
        Me.TxtNam.TabIndex = 250
        Me.TxtNam.TabStop = False
        '
        'TxtDu_Co_nt1
        '
        Me.TxtDu_Co_nt1.AllowNegative = True
        Me.TxtDu_Co_nt1.Flags = 7680
        Me.TxtDu_Co_nt1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDu_Co_nt1.ForeColor = System.Drawing.Color.Blue
        Me.TxtDu_Co_nt1.InputMask = "### ### ### ### ###.##"
        Me.TxtDu_Co_nt1.Location = New System.Drawing.Point(843, 277)
        Me.TxtDu_Co_nt1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtDu_Co_nt1.MaxWholeDigits = 17
        Me.TxtDu_Co_nt1.Name = "TxtDu_Co_nt1"
        Me.TxtDu_Co_nt1.RangeMax = 1.7976931348623157E+308R
        Me.TxtDu_Co_nt1.RangeMin = -1.7976931348623157E+308R
        Me.TxtDu_Co_nt1.Size = New System.Drawing.Size(193, 24)
        Me.TxtDu_Co_nt1.TabIndex = 10
        Me.TxtDu_Co_nt1.Tag = "### ### ### ### ###.##"
        Me.TxtDu_Co_nt1.Text = "0.00"
        Me.TxtDu_Co_nt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDu_No_nt1
        '
        Me.TxtDu_No_nt1.AllowNegative = True
        Me.TxtDu_No_nt1.Flags = 7680
        Me.TxtDu_No_nt1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDu_No_nt1.ForeColor = System.Drawing.Color.Blue
        Me.TxtDu_No_nt1.InputMask = "### ### ### ### ###.##"
        Me.TxtDu_No_nt1.Location = New System.Drawing.Point(843, 246)
        Me.TxtDu_No_nt1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtDu_No_nt1.MaxWholeDigits = 17
        Me.TxtDu_No_nt1.Name = "TxtDu_No_nt1"
        Me.TxtDu_No_nt1.RangeMax = 1.7976931348623157E+308R
        Me.TxtDu_No_nt1.RangeMin = -1.7976931348623157E+308R
        Me.TxtDu_No_nt1.Size = New System.Drawing.Size(193, 24)
        Me.TxtDu_No_nt1.TabIndex = 9
        Me.TxtDu_No_nt1.Tag = "### ### ### ### ###.##"
        Me.TxtDu_No_nt1.Text = "0.00"
        Me.TxtDu_No_nt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDu_Co1
        '
        Me.TxtDu_Co1.AllowNegative = True
        Me.TxtDu_Co1.Flags = 7680
        Me.TxtDu_Co1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDu_Co1.ForeColor = System.Drawing.Color.Blue
        Me.TxtDu_Co1.InputMask = "### ### ### ### ###"
        Me.TxtDu_Co1.Location = New System.Drawing.Point(843, 216)
        Me.TxtDu_Co1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtDu_Co1.MaxWholeDigits = 14
        Me.TxtDu_Co1.Name = "TxtDu_Co1"
        Me.TxtDu_Co1.RangeMax = 1.7976931348623157E+308R
        Me.TxtDu_Co1.RangeMin = -1.7976931348623157E+308R
        Me.TxtDu_Co1.Size = New System.Drawing.Size(193, 24)
        Me.TxtDu_Co1.TabIndex = 8
        Me.TxtDu_Co1.Text = "0"
        Me.TxtDu_Co1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDu_No1
        '
        Me.TxtDu_No1.AllowNegative = True
        Me.TxtDu_No1.Flags = 7680
        Me.TxtDu_No1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDu_No1.ForeColor = System.Drawing.Color.Blue
        Me.TxtDu_No1.InputMask = "### ### ### ### ###"
        Me.TxtDu_No1.Location = New System.Drawing.Point(843, 186)
        Me.TxtDu_No1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtDu_No1.MaxWholeDigits = 14
        Me.TxtDu_No1.Name = "TxtDu_No1"
        Me.TxtDu_No1.RangeMax = 1.7976931348623157E+308R
        Me.TxtDu_No1.RangeMin = -1.7976931348623157E+308R
        Me.TxtDu_No1.Size = New System.Drawing.Size(193, 24)
        Me.TxtDu_No1.TabIndex = 7
        Me.TxtDu_No1.Text = "0"
        Me.TxtDu_No1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(633, 277)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 28)
        Me.Label1.TabIndex = 269
        Me.Label1.Tag = "Y.starts credit balance(FC)"
        Me.Label1.Text = "Dư có đầu năm (NT)"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(633, 218)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(203, 23)
        Me.Label5.TabIndex = 268
        Me.Label5.Tag = "Y.starts credit balance(VND)"
        Me.Label5.Text = "Dư có đầu năm  (VNĐ)"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(633, 248)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(203, 23)
        Me.Label6.TabIndex = 267
        Me.Label6.Tag = "Y.starts debt balance(FC)"
        Me.Label6.Text = "Dư nợ đầu năm (NT)"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(633, 188)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(203, 23)
        Me.Label7.TabIndex = 266
        Me.Label7.Tag = "Y.starts debt balance(VND)"
        Me.Label7.Text = "Dư nợ đầu năm (VNĐ)"
        '
        'TxtDu_Co_NT00
        '
        Me.TxtDu_Co_NT00.AllowNegative = True
        Me.TxtDu_Co_NT00.Flags = 7680
        Me.TxtDu_Co_NT00.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDu_Co_NT00.ForeColor = System.Drawing.Color.Navy
        Me.TxtDu_Co_NT00.InputMask = "### ### ### ### ###.##"
        Me.TxtDu_Co_NT00.Location = New System.Drawing.Point(196, 277)
        Me.TxtDu_Co_NT00.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtDu_Co_NT00.MaxWholeDigits = 17
        Me.TxtDu_Co_NT00.Name = "TxtDu_Co_NT00"
        Me.TxtDu_Co_NT00.RangeMax = 1.7976931348623157E+308R
        Me.TxtDu_Co_NT00.RangeMin = -1.7976931348623157E+308R
        Me.TxtDu_Co_NT00.Size = New System.Drawing.Size(179, 24)
        Me.TxtDu_Co_NT00.TabIndex = 6
        Me.TxtDu_Co_NT00.Tag = "### ### ### ### ###.##"
        Me.TxtDu_Co_NT00.Text = "0.00"
        Me.TxtDu_Co_NT00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDu_No_NT00
        '
        Me.TxtDu_No_NT00.AllowNegative = True
        Me.TxtDu_No_NT00.Flags = 7680
        Me.TxtDu_No_NT00.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDu_No_NT00.ForeColor = System.Drawing.Color.Navy
        Me.TxtDu_No_NT00.InputMask = "### ### ### ### ###.##"
        Me.TxtDu_No_NT00.Location = New System.Drawing.Point(196, 246)
        Me.TxtDu_No_NT00.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtDu_No_NT00.MaxWholeDigits = 17
        Me.TxtDu_No_NT00.Name = "TxtDu_No_NT00"
        Me.TxtDu_No_NT00.RangeMax = 1.7976931348623157E+308R
        Me.TxtDu_No_NT00.RangeMin = -1.7976931348623157E+308R
        Me.TxtDu_No_NT00.Size = New System.Drawing.Size(179, 24)
        Me.TxtDu_No_NT00.TabIndex = 5
        Me.TxtDu_No_NT00.Tag = "### ### ### ### ###.##"
        Me.TxtDu_No_NT00.Text = "0.00"
        Me.TxtDu_No_NT00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDu_Co00
        '
        Me.TxtDu_Co00.AllowNegative = True
        Me.TxtDu_Co00.Flags = 7680
        Me.TxtDu_Co00.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDu_Co00.ForeColor = System.Drawing.Color.Navy
        Me.TxtDu_Co00.InputMask = "### ### ### ### ###"
        Me.TxtDu_Co00.Location = New System.Drawing.Point(196, 216)
        Me.TxtDu_Co00.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtDu_Co00.MaxWholeDigits = 14
        Me.TxtDu_Co00.Name = "TxtDu_Co00"
        Me.TxtDu_Co00.RangeMax = 1.7976931348623157E+308R
        Me.TxtDu_Co00.RangeMin = -1.7976931348623157E+308R
        Me.TxtDu_Co00.Size = New System.Drawing.Size(179, 24)
        Me.TxtDu_Co00.TabIndex = 4
        Me.TxtDu_Co00.Text = "0"
        Me.TxtDu_Co00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDu_no00
        '
        Me.TxtDu_no00.AllowNegative = True
        Me.TxtDu_no00.Flags = 7680
        Me.TxtDu_no00.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDu_no00.ForeColor = System.Drawing.Color.Navy
        Me.TxtDu_no00.InputMask = "### ### ### ### ###"
        Me.TxtDu_no00.Location = New System.Drawing.Point(196, 186)
        Me.TxtDu_no00.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtDu_no00.MaxWholeDigits = 14
        Me.TxtDu_no00.Name = "TxtDu_no00"
        Me.TxtDu_no00.RangeMax = 1.7976931348623157E+308R
        Me.TxtDu_no00.RangeMin = -1.7976931348623157E+308R
        Me.TxtDu_no00.Size = New System.Drawing.Size(179, 24)
        Me.TxtDu_no00.TabIndex = 3
        Me.TxtDu_no00.Text = "0"
        Me.TxtDu_no00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(7, 277)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 29)
        Me.Label4.TabIndex = 265
        Me.Label4.Tag = "Open credit balance(FC)"
        Me.Label4.Text = "Dư có đầu kỳ (NT)"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(7, 218)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 24)
        Me.Label2.TabIndex = 264
        Me.Label2.Tag = "Open credit balance(VND)"
        Me.Label2.Text = "Dư có đầu kỳ (VNĐ)"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(7, 248)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 24)
        Me.Label3.TabIndex = 263
        Me.Label3.Tag = "Open debt balance(FC)"
        Me.Label3.Text = "Dư nợ đầu kỳ (NT)"
        '
        'TxtTen_TK
        '
        Me.TxtTen_TK.BackColor = System.Drawing.Color.White
        Me.TxtTen_TK.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_TK.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_TK.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_TK.Location = New System.Drawing.Point(387, 72)
        Me.TxtTen_TK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_TK.Name = "TxtTen_TK"
        Me.TxtTen_TK.ReadOnly = True
        Me.TxtTen_TK.Size = New System.Drawing.Size(651, 17)
        Me.TxtTen_TK.TabIndex = 260
        Me.TxtTen_TK.TabStop = False
        '
        'lbMa_Phi
        '
        Me.lbMa_Phi.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lbMa_Phi.ForeColor = System.Drawing.Color.Navy
        Me.lbMa_Phi.Location = New System.Drawing.Point(7, 68)
        Me.lbMa_Phi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMa_Phi.Name = "lbMa_Phi"
        Me.lbMa_Phi.Size = New System.Drawing.Size(176, 24)
        Me.lbMa_Phi.TabIndex = 262
        Me.lbMa_Phi.Tag = "Account"
        Me.lbMa_Phi.Text = "Tài khoản"
        '
        'lbTen_phi2
        '
        Me.lbTen_phi2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lbTen_phi2.ForeColor = System.Drawing.Color.Navy
        Me.lbTen_phi2.Location = New System.Drawing.Point(7, 188)
        Me.lbTen_phi2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTen_phi2.Name = "lbTen_phi2"
        Me.lbTen_phi2.Size = New System.Drawing.Size(176, 24)
        Me.lbTen_phi2.TabIndex = 261
        Me.lbTen_phi2.Tag = "Open debt balance(VND)"
        Me.lbTen_phi2.Text = "Dư nợ đầu kỳ (VNĐ)"
        '
        'Txtten_DVCS
        '
        Me.Txtten_DVCS.BackColor = System.Drawing.Color.White
        Me.Txtten_DVCS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtten_DVCS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtten_DVCS.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_DVCS.Location = New System.Drawing.Point(387, 39)
        Me.Txtten_DVCS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtten_DVCS.Name = "Txtten_DVCS"
        Me.Txtten_DVCS.ReadOnly = True
        Me.Txtten_DVCS.Size = New System.Drawing.Size(651, 17)
        Me.Txtten_DVCS.TabIndex = 271
        Me.Txtten_DVCS.TabStop = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(7, 37)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(176, 24)
        Me.Label11.TabIndex = 272
        Me.Label11.Tag = "Acc unit"
        Me.Label11.Text = "Đơn vị hạch toán"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(8, 160)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1032, 14)
        Me.GroupBox1.TabIndex = 273
        Me.GroupBox1.TabStop = False
        '
        'TxtTK
        '
        Me.TxtTK._ActilookupPopup = False
        Me.TxtTK.CyberActilookupPopup = True
        Me.TxtTK.Dv_ListDetail = Nothing
        Me.TxtTK.Dv_Master = Nothing
        Me.TxtTK.FilterClient = ""
        Me.TxtTK.FilterSQL = ""
        Me.TxtTK.Location = New System.Drawing.Point(196, 68)
        Me.TxtTK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTK.Name = "TxtTK"
        Me.TxtTK.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTK.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTK.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTK.Size = New System.Drawing.Size(180, 22)
        Me.TxtTK.TabIndex = 0
        Me.TxtTK.Table_Name = ""
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(7, 327)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(625, 29)
        Me.Label12.TabIndex = 12
        Me.Label12.Tag = "Note: Year starts balance inserts into balance sheet"
        Me.Label12.Text = "Ghi chú: Số dư đầu năm để lên bảng cân đối kế toán"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtMa_NT
        '
        Me.TxtMa_NT._ActilookupPopup = False
        Me.TxtMa_NT.CyberActilookupPopup = True
        Me.TxtMa_NT.Dv_ListDetail = Nothing
        Me.TxtMa_NT.Dv_Master = Nothing
        Me.TxtMa_NT.FilterClient = ""
        Me.TxtMa_NT.FilterSQL = ""
        Me.TxtMa_NT.Location = New System.Drawing.Point(196, 98)
        Me.TxtMa_NT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_NT.Name = "TxtMa_NT"
        Me.TxtMa_NT.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.TxtMa_NT.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_NT.Properties.Appearance.Options.UseBackColor = True
        Me.TxtMa_NT.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_NT.Properties.ReadOnly = True
        Me.TxtMa_NT.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_NT.Size = New System.Drawing.Size(180, 22)
        Me.TxtMa_NT.TabIndex = 1
        Me.TxtMa_NT.Table_Name = ""
        '
        'TxtTen_NT
        '
        Me.TxtTen_NT.BackColor = System.Drawing.Color.White
        Me.TxtTen_NT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_NT.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_NT.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_NT.Location = New System.Drawing.Point(387, 102)
        Me.TxtTen_NT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_NT.Name = "TxtTen_NT"
        Me.TxtTen_NT.ReadOnly = True
        Me.TxtTen_NT.Size = New System.Drawing.Size(651, 17)
        Me.TxtTen_NT.TabIndex = 276
        Me.TxtTen_NT.TabStop = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(7, 98)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(176, 24)
        Me.Label8.TabIndex = 277
        Me.Label8.Tag = "Currency"
        Me.Label8.Text = "Ngoại tệ"
        '
        'TxtMa_Kh
        '
        Me.TxtMa_Kh._ActilookupPopup = False
        Me.TxtMa_Kh.CyberActilookupPopup = True
        Me.TxtMa_Kh.Dv_ListDetail = Nothing
        Me.TxtMa_Kh.Dv_Master = Nothing
        Me.TxtMa_Kh.FilterClient = ""
        Me.TxtMa_Kh.FilterSQL = ""
        Me.TxtMa_Kh.Location = New System.Drawing.Point(196, 129)
        Me.TxtMa_Kh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Kh.Name = "TxtMa_Kh"
        Me.TxtMa_Kh.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kh.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kh.Size = New System.Drawing.Size(180, 22)
        Me.TxtMa_Kh.TabIndex = 2
        Me.TxtMa_Kh.Table_Name = ""
        '
        'TxtTen_kh
        '
        Me.TxtTen_kh.BackColor = System.Drawing.Color.White
        Me.TxtTen_kh.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_kh.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_kh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_kh.Location = New System.Drawing.Point(387, 133)
        Me.TxtTen_kh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_kh.Name = "TxtTen_kh"
        Me.TxtTen_kh.ReadOnly = True
        Me.TxtTen_kh.Size = New System.Drawing.Size(651, 17)
        Me.TxtTen_kh.TabIndex = 279
        Me.TxtTen_kh.TabStop = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(7, 129)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(176, 24)
        Me.Label9.TabIndex = 280
        Me.Label9.Tag = "Object"
        Me.Label9.Text = "Đối tượng"
        '
        'CDKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(1045, 364)
        Me.Controls.Add(Me.TxtMa_Kh)
        Me.Controls.Add(Me.TxtTen_kh)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtMa_NT)
        Me.Controls.Add(Me.TxtTen_NT)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtTK)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Txtten_DVCS)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtNam)
        Me.Controls.Add(Me.TxtDu_Co_nt1)
        Me.Controls.Add(Me.TxtDu_No_nt1)
        Me.Controls.Add(Me.TxtDu_Co1)
        Me.Controls.Add(Me.TxtDu_No1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtDu_Co_NT00)
        Me.Controls.Add(Me.TxtDu_No_NT00)
        Me.Controls.Add(Me.TxtDu_Co00)
        Me.Controls.Add(Me.TxtDu_no00)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTen_TK)
        Me.Controls.Add(Me.lbMa_Phi)
        Me.Controls.Add(Me.lbTen_phi2)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "CDKH"
        Me.Tb_Name = "Open"
        Me.Text = "Số dư đầu kỳ tài khoản"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.lbTen_phi2, 0)
        Me.Controls.SetChildIndex(Me.lbMa_Phi, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_TK, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtDu_no00, 0)
        Me.Controls.SetChildIndex(Me.TxtDu_Co00, 0)
        Me.Controls.SetChildIndex(Me.TxtDu_No_NT00, 0)
        Me.Controls.SetChildIndex(Me.TxtDu_Co_NT00, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtDu_No1, 0)
        Me.Controls.SetChildIndex(Me.TxtDu_Co1, 0)
        Me.Controls.SetChildIndex(Me.TxtDu_No_nt1, 0)
        Me.Controls.SetChildIndex(Me.TxtDu_Co_nt1, 0)
        Me.Controls.SetChildIndex(Me.TxtNam, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.Txtten_DVCS, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.TxtTK, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_NT, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kh, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kh, 0)
        CType(Me.TxtTK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_NT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Kh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtNam As System.Windows.Forms.TextBox
    Friend WithEvents TxtDu_Co_nt1 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtDu_No_nt1 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtDu_Co1 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtDu_No1 As ClsTextBox.txtTien_NT
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtDu_Co_NT00 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtDu_No_NT00 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtDu_Co00 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtDu_no00 As ClsTextBox.txtTien_NT
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_TK As System.Windows.Forms.TextBox
    Friend WithEvents lbMa_Phi As System.Windows.Forms.Label
    Friend WithEvents lbTen_phi2 As System.Windows.Forms.Label
    Friend WithEvents Txtten_DVCS As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtTK As Cyber.SmLists.TxtLookup
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_NT As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_NT As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Kh As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_kh As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
