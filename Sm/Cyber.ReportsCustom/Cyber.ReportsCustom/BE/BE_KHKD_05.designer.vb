<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BE_KHKD_05
    Inherits Cyber.From.FilterReport

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
        Me.TxtM_Ngay_Ct1 = New ClsTextBox.txtDate1()
        Me.TxtM_Ngay_Ct2 = New ClsTextBox.txtDate1()
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.LabM_Ngay_Ct2 = New System.Windows.Forms.Label()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Ma_TT = New System.Windows.Forms.ComboBox()
        Me.LabMa_Hs = New System.Windows.Forms.Label()
        Me.TxtTen_Hs = New System.Windows.Forms.TextBox()
        Me.TxtMa_Hs = New Cyber.SmLists.TxtLookup()
        Me.ChkIs_All = New System.Windows.Forms.CheckBox()
        Me.ChkIs_N = New System.Windows.Forms.CheckBox()
        Me.ChkIs_W = New System.Windows.Forms.CheckBox()
        Me.ChkIs_I = New System.Windows.Forms.CheckBox()
        Me.ChkIs_C = New System.Windows.Forms.CheckBox()
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(571, 214)
        Me.ButtExit.TabIndex = 22
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(107, 136)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(560, 21)
        Me.CBBMa_Dvcs.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(15, 139)
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(467, 214)
        Me.ButtOK.TabIndex = 21
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(15, 122)
        Me.LabLoai_NT.Size = New System.Drawing.Size(46, 13)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(107, 119)
        Me.ChkVND.TabIndex = 18
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(221, 119)
        Me.ChkNT.TabIndex = 19
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(107, 3)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct1.TabIndex = 3
        Me.TxtM_Ngay_Ct1.Text = "__/__/____"
        Me.TxtM_Ngay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.isEmpty = True
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(317, 3)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(102, 21)
        Me.TxtM_Ngay_Ct2.TabIndex = 4
        Me.TxtM_Ngay_Ct2.Text = "__/__/____"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(15, 7)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(47, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 13
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(229, 7)
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
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 153)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(668, 9)
        Me.GroupBoxLine.TabIndex = 14
        Me.GroupBoxLine.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 383)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 443
        Me.Label6.Tag = "Payments"
        Me.Label6.Text = "Thanh toán"
        Me.Label6.Visible = False
        '
        'Ma_TT
        '
        Me.Ma_TT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Ma_TT.ForeColor = System.Drawing.Color.Navy
        Me.Ma_TT.FormattingEnabled = True
        Me.Ma_TT.Location = New System.Drawing.Point(107, 379)
        Me.Ma_TT.Name = "Ma_TT"
        Me.Ma_TT.Size = New System.Drawing.Size(213, 21)
        Me.Ma_TT.TabIndex = 17
        Me.Ma_TT.Visible = False
        '
        'LabMa_Hs
        '
        Me.LabMa_Hs.AutoSize = True
        Me.LabMa_Hs.Location = New System.Drawing.Point(15, 30)
        Me.LabMa_Hs.Name = "LabMa_Hs"
        Me.LabMa_Hs.Size = New System.Drawing.Size(32, 13)
        Me.LabMa_Hs.TabIndex = 475
        Me.LabMa_Hs.Tag = "Staff"
        Me.LabMa_Hs.Text = "TVBH"
        '
        'TxtTen_Hs
        '
        Me.TxtTen_Hs.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Hs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Hs.Enabled = False
        Me.TxtTen_Hs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Hs.Location = New System.Drawing.Point(235, 30)
        Me.TxtTen_Hs.Name = "TxtTen_Hs"
        Me.TxtTen_Hs.ReadOnly = True
        Me.TxtTen_Hs.Size = New System.Drawing.Size(432, 14)
        Me.TxtTen_Hs.TabIndex = 453
        Me.TxtTen_Hs.TabStop = False
        '
        'TxtMa_Hs
        '
        Me.TxtMa_Hs._ActilookupPopup = False
        Me.TxtMa_Hs.CyberActilookupPopup = True
        Me.TxtMa_Hs.Dv_ListDetail = Nothing
        Me.TxtMa_Hs.Dv_Master = Nothing
        Me.TxtMa_Hs.FilterClient = ""
        Me.TxtMa_Hs.FilterSQL = ""
        Me.TxtMa_Hs.Location = New System.Drawing.Point(107, 27)
        Me.TxtMa_Hs.Name = "TxtMa_Hs"
        Me.TxtMa_Hs.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Hs.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Hs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Hs.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_Hs.TabIndex = 5
        Me.TxtMa_Hs.Table_Name = ""
        '
        'ChkIs_All
        '
        Me.ChkIs_All.AutoSize = True
        Me.ChkIs_All.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ChkIs_All.Location = New System.Drawing.Point(107, 51)
        Me.ChkIs_All.Name = "ChkIs_All"
        Me.ChkIs_All.Size = New System.Drawing.Size(154, 17)
        Me.ChkIs_All.TabIndex = 621
        Me.ChkIs_All.Text = "Tất cả loại hình thanh toán"
        Me.ChkIs_All.UseVisualStyleBackColor = True
        '
        'ChkIs_N
        '
        Me.ChkIs_N.AutoSize = True
        Me.ChkIs_N.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ChkIs_N.Location = New System.Drawing.Point(329, 94)
        Me.ChkIs_N.Name = "ChkIs_N"
        Me.ChkIs_N.Size = New System.Drawing.Size(130, 17)
        Me.ChkIs_N.TabIndex = 625
        Me.ChkIs_N.Text = "Nội bộ thanh toán (N)"
        Me.ChkIs_N.UseVisualStyleBackColor = True
        '
        'ChkIs_W
        '
        Me.ChkIs_W.AutoSize = True
        Me.ChkIs_W.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ChkIs_W.Location = New System.Drawing.Point(107, 94)
        Me.ChkIs_W.Name = "ChkIs_W"
        Me.ChkIs_W.Size = New System.Drawing.Size(148, 17)
        Me.ChkIs_W.TabIndex = 623
        Me.ChkIs_W.Text = "Bảo hành thanh toán (W)"
        Me.ChkIs_W.UseVisualStyleBackColor = True
        '
        'ChkIs_I
        '
        Me.ChkIs_I.AutoSize = True
        Me.ChkIs_I.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ChkIs_I.Location = New System.Drawing.Point(329, 72)
        Me.ChkIs_I.Name = "ChkIs_I"
        Me.ChkIs_I.Size = New System.Drawing.Size(140, 17)
        Me.ChkIs_I.TabIndex = 624
        Me.ChkIs_I.Text = "Bảo hiểm thanh toán (I)"
        Me.ChkIs_I.UseVisualStyleBackColor = True
        '
        'ChkIs_C
        '
        Me.ChkIs_C.AutoSize = True
        Me.ChkIs_C.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ChkIs_C.Location = New System.Drawing.Point(107, 72)
        Me.ChkIs_C.Name = "ChkIs_C"
        Me.ChkIs_C.Size = New System.Drawing.Size(156, 17)
        Me.ChkIs_C.TabIndex = 622
        Me.ChkIs_C.Text = "Khách hàng thanh toán (C)"
        Me.ChkIs_C.UseVisualStyleBackColor = True
        '
        'BE_KHKD_05
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(675, 267)
        Me.Controls.Add(Me.ChkIs_All)
        Me.Controls.Add(Me.ChkIs_N)
        Me.Controls.Add(Me.ChkIs_W)
        Me.Controls.Add(Me.ChkIs_I)
        Me.Controls.Add(Me.ChkIs_C)
        Me.Controls.Add(Me.LabMa_Hs)
        Me.Controls.Add(Me.TxtTen_Hs)
        Me.Controls.Add(Me.TxtMa_Hs)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Ma_TT)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "BE_KHKD_05"
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Ma_TT, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Hs, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hs, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Hs, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_C, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_I, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_W, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_N, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_All, 0)
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Ma_TT As System.Windows.Forms.ComboBox
    Friend WithEvents LabMa_Hs As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Hs As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Hs As Cyber.SmLists.TxtLookup
    Friend WithEvents ChkIs_All As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_N As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_W As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_I As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_C As System.Windows.Forms.CheckBox
End Class
