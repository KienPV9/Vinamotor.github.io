<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BC_BBDCCN
    Inherits Cyber.From.FilterReport

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
        Me.TxtM_Ngay_Ct1 = New ClsTextBox.txtDate1()
        Me.TxtM_Ngay_Ct2 = New ClsTextBox.txtDate1()
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.LabM_Ngay_Ct2 = New System.Windows.Forms.Label()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.LabM_Tk = New System.Windows.Forms.Label()
        Me.TxtM_Tk_CN = New Cyber.SmLists.TxtLookup()
        Me.Txtten_Tk_CN = New System.Windows.Forms.TextBox()
        Me.TxtM_Ma_kh = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_KH = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTen_DD1 = New System.Windows.Forms.TextBox()
        Me.TxtCV_DD1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTen_DD2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtCV_DD2 = New System.Windows.Forms.TextBox()
        Me.TxtNoi_Dung = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.TxtM_Tk_CN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtM_Ma_kh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(492, 372)
        Me.ButtExit.TabIndex = 14
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(95, 175)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(491, 21)
        Me.CBBMa_Dvcs.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 178)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(388, 372)
        Me.ButtOK.TabIndex = 13
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(9, 153)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(95, 153)
        Me.ChkVND.TabIndex = 8
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(211, 154)
        Me.ChkNT.TabIndex = 9
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(95, 50)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct1.TabIndex = 2
        Me.TxtM_Ngay_Ct1.Text = "01/01/1900"
        Me.TxtM_Ngay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(95, 75)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct2.TabIndex = 3
        Me.TxtM_Ngay_Ct2.Text = "01/01/1900"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(9, 53)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(47, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 13
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(9, 78)
        Me.LabM_Ngay_Ct2.Name = "LabM_Ngay_Ct2"
        Me.LabM_Ngay_Ct2.Size = New System.Drawing.Size(54, 13)
        Me.LabM_Ngay_Ct2.TabIndex = 14
        Me.LabM_Ngay_Ct2.Tag = "Date to"
        Me.LabM_Ngay_Ct2.Text = "Đến ngày"
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 355)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(589, 9)
        Me.GroupBoxLine.TabIndex = 12
        Me.GroupBoxLine.TabStop = False
        '
        'LabM_Tk
        '
        Me.LabM_Tk.AutoSize = True
        Me.LabM_Tk.Location = New System.Drawing.Point(9, 8)
        Me.LabM_Tk.Name = "LabM_Tk"
        Me.LabM_Tk.Size = New System.Drawing.Size(53, 13)
        Me.LabM_Tk.TabIndex = 17
        Me.LabM_Tk.Tag = "Account"
        Me.LabM_Tk.Text = "Tài khoản"
        '
        'TxtM_Tk_CN
        '
        Me.TxtM_Tk_CN._ActilookupPopup = False
        Me.TxtM_Tk_CN.CyberActilookupPopup = True
        Me.TxtM_Tk_CN.Dv_ListDetail = Nothing
        Me.TxtM_Tk_CN.Dv_Master = Nothing
        Me.TxtM_Tk_CN.FilterClient = ""
        Me.TxtM_Tk_CN.FilterSQL = ""
        Me.TxtM_Tk_CN.Location = New System.Drawing.Point(95, 5)
        Me.TxtM_Tk_CN.Name = "TxtM_Tk_CN"
        Me.TxtM_Tk_CN.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.TxtM_Tk_CN.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Tk_CN.Properties.Appearance.Options.UseFont = True
        Me.TxtM_Tk_CN.Properties.Appearance.Options.UseForeColor = True
        Me.TxtM_Tk_CN.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtM_Tk_CN.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtM_Tk_CN.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TxtM_Tk_CN.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtM_Tk_CN.Size = New System.Drawing.Size(114, 22)
        Me.TxtM_Tk_CN.TabIndex = 0
        Me.TxtM_Tk_CN.Table_Name = ""
        '
        'Txtten_Tk_CN
        '
        Me.Txtten_Tk_CN.BackColor = System.Drawing.SystemColors.Control
        Me.Txtten_Tk_CN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtten_Tk_CN.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Txtten_Tk_CN.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_Tk_CN.Location = New System.Drawing.Point(210, 12)
        Me.Txtten_Tk_CN.Name = "Txtten_Tk_CN"
        Me.Txtten_Tk_CN.ReadOnly = True
        Me.Txtten_Tk_CN.Size = New System.Drawing.Size(382, 13)
        Me.Txtten_Tk_CN.TabIndex = 144
        Me.Txtten_Tk_CN.TabStop = False
        '
        'TxtM_Ma_kh
        '
        Me.TxtM_Ma_kh._ActilookupPopup = False
        Me.TxtM_Ma_kh.CyberActilookupPopup = True
        Me.TxtM_Ma_kh.Dv_ListDetail = Nothing
        Me.TxtM_Ma_kh.Dv_Master = Nothing
        Me.TxtM_Ma_kh.FilterClient = ""
        Me.TxtM_Ma_kh.FilterSQL = ""
        Me.TxtM_Ma_kh.Location = New System.Drawing.Point(95, 28)
        Me.TxtM_Ma_kh.Name = "TxtM_Ma_kh"
        Me.TxtM_Ma_kh.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.TxtM_Ma_kh.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ma_kh.Properties.Appearance.Options.UseFont = True
        Me.TxtM_Ma_kh.Properties.Appearance.Options.UseForeColor = True
        Me.TxtM_Ma_kh.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtM_Ma_kh.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtM_Ma_kh.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TxtM_Ma_kh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtM_Ma_kh.Size = New System.Drawing.Size(114, 22)
        Me.TxtM_Ma_kh.TabIndex = 1
        Me.TxtM_Ma_kh.Table_Name = ""
        '
        'TxtTen_KH
        '
        Me.TxtTen_KH.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_KH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_KH.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.TxtTen_KH.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_KH.Location = New System.Drawing.Point(210, 35)
        Me.TxtTen_KH.Name = "TxtTen_KH"
        Me.TxtTen_KH.ReadOnly = True
        Me.TxtTen_KH.Size = New System.Drawing.Size(382, 13)
        Me.TxtTen_KH.TabIndex = 148
        Me.TxtTen_KH.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 147
        Me.Label2.Tag = "Customer"
        Me.Label2.Text = "Mã đối tượng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 159
        Me.Label3.Tag = "Date from"
        Me.Label3.Text = "Đại diện(CT)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(399, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 160
        Me.Label4.Tag = "Date from"
        Me.Label4.Text = "Chức vụ(CT)"
        '
        'TxtTen_DD1
        '
        Me.TxtTen_DD1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_DD1.Location = New System.Drawing.Point(95, 102)
        Me.TxtTen_DD1.Name = "TxtTen_DD1"
        Me.TxtTen_DD1.Size = New System.Drawing.Size(298, 21)
        Me.TxtTen_DD1.TabIndex = 4
        '
        'TxtCV_DD1
        '
        Me.TxtCV_DD1.ForeColor = System.Drawing.Color.Navy
        Me.TxtCV_DD1.Location = New System.Drawing.Point(473, 102)
        Me.TxtCV_DD1.Name = "TxtCV_DD1"
        Me.TxtCV_DD1.Size = New System.Drawing.Size(119, 21)
        Me.TxtCV_DD1.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(12, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 350
        Me.Label6.Tag = "Customer code"
        Me.Label6.Text = "Đại diện (KH)"
        '
        'TxtTen_DD2
        '
        Me.TxtTen_DD2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_DD2.Location = New System.Drawing.Point(95, 126)
        Me.TxtTen_DD2.Name = "TxtTen_DD2"
        Me.TxtTen_DD2.Size = New System.Drawing.Size(298, 21)
        Me.TxtTen_DD2.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(399, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 352
        Me.Label5.Tag = "Customer code"
        Me.Label5.Text = "Chức vụ(KH)"
        '
        'TxtCV_DD2
        '
        Me.TxtCV_DD2.ForeColor = System.Drawing.Color.Navy
        Me.TxtCV_DD2.Location = New System.Drawing.Point(473, 126)
        Me.TxtCV_DD2.Name = "TxtCV_DD2"
        Me.TxtCV_DD2.Size = New System.Drawing.Size(120, 21)
        Me.TxtCV_DD2.TabIndex = 7
        '
        'TxtNoi_Dung
        '
        Me.TxtNoi_Dung.ForeColor = System.Drawing.Color.Navy
        Me.TxtNoi_Dung.Location = New System.Drawing.Point(89, 202)
        Me.TxtNoi_Dung.Multiline = True
        Me.TxtNoi_Dung.Name = "TxtNoi_Dung"
        Me.TxtNoi_Dung.Size = New System.Drawing.Size(497, 147)
        Me.TxtNoi_Dung.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(13, 273)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 355
        Me.Label7.Tag = "Customer code"
        Me.Label7.Text = "Nội dung"
        '
        'BC_BBDCCN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(596, 425)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtNoi_Dung)
        Me.Controls.Add(Me.TxtCV_DD2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTen_DD2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtCV_DD1)
        Me.Controls.Add(Me.TxtTen_DD1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtM_Ma_kh)
        Me.Controls.Add(Me.TxtTen_KH)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtM_Tk_CN)
        Me.Controls.Add(Me.Txtten_Tk_CN)
        Me.Controls.Add(Me.LabM_Tk)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Name = "BC_BBDCCN"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.LabM_Tk, 0)
        Me.Controls.SetChildIndex(Me.Txtten_Tk_CN, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Tk_CN, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_KH, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ma_kh, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_DD1, 0)
        Me.Controls.SetChildIndex(Me.TxtCV_DD1, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_DD2, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtCV_DD2, 0)
        Me.Controls.SetChildIndex(Me.TxtNoi_Dung, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        CType(Me.TxtM_Tk_CN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtM_Ma_kh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents LabM_Tk As System.Windows.Forms.Label
    Friend WithEvents TxtM_Tk_CN As Cyber.SmLists.TxtLookup
    Friend WithEvents Txtten_Tk_CN As System.Windows.Forms.TextBox
    Friend WithEvents TxtM_Ma_kh As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_KH As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_DD1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtCV_DD1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_DD2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtCV_DD2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNoi_Dung As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
