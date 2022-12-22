<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BCDV10_HTN
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Txtma_bh = New Cyber.SmLists.TxtLookup()
        Me.Txtma_xe = New Cyber.SmLists.TxtLookup()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTen_bh = New System.Windows.Forms.Label()
        Me.TxtSo_Ro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Chkis_Hd = New System.Windows.Forms.CheckBox()
        CType(Me.Txtma_bh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txtma_xe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(565, 186)
        Me.ButtExit.TabIndex = 7
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(92, 154)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(573, 21)
        Me.CBBMa_Dvcs.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 157)
        Me.Label1.TabIndex = 17
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(461, 186)
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(6, 135)
        Me.LabLoai_NT.TabIndex = 14
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(92, 133)
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(212, 133)
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(92, 9)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(116, 21)
        Me.TxtM_Ngay_Ct1.TabIndex = 0
        Me.TxtM_Ngay_Ct1.Text = "__/__/____"
        Me.TxtM_Ngay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.isEmpty = True
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(92, 33)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(116, 21)
        Me.TxtM_Ngay_Ct2.TabIndex = 1
        Me.TxtM_Ngay_Ct2.Text = "__/__/____"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(6, 13)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(47, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 13
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(6, 37)
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
        Me.GroupBoxLine.Location = New System.Drawing.Point(5, 174)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(662, 9)
        Me.GroupBoxLine.TabIndex = 19
        Me.GroupBoxLine.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 509
        Me.Label11.Tag = "License Plate"
        Me.Label11.Text = "Đơn vị BH"
        '
        'Txtma_bh
        '
        Me.Txtma_bh._ActilookupPopup = False
        Me.Txtma_bh.CyberActilookupPopup = True
        Me.Txtma_bh.Dv_ListDetail = Nothing
        Me.Txtma_bh.Dv_Master = Nothing
        Me.Txtma_bh.FilterClient = ""
        Me.Txtma_bh.FilterSQL = ""
        Me.Txtma_bh.Location = New System.Drawing.Point(92, 57)
        Me.Txtma_bh.Name = "Txtma_bh"
        Me.Txtma_bh.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Txtma_bh.Properties.Appearance.Options.UseForeColor = True
        Me.Txtma_bh.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.Txtma_bh.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.Txtma_bh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.Txtma_bh.Size = New System.Drawing.Size(116, 20)
        Me.Txtma_bh.TabIndex = 2
        Me.Txtma_bh.Table_Name = ""
        '
        'Txtma_xe
        '
        Me.Txtma_xe._ActilookupPopup = False
        Me.Txtma_xe.CyberActilookupPopup = True
        Me.Txtma_xe.Dv_ListDetail = Nothing
        Me.Txtma_xe.Dv_Master = Nothing
        Me.Txtma_xe.FilterClient = ""
        Me.Txtma_xe.FilterSQL = ""
        Me.Txtma_xe.Location = New System.Drawing.Point(92, 79)
        Me.Txtma_xe.Name = "Txtma_xe"
        Me.Txtma_xe.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Txtma_xe.Properties.Appearance.Options.UseForeColor = True
        Me.Txtma_xe.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.Txtma_xe.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.Txtma_xe.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.Txtma_xe.Size = New System.Drawing.Size(116, 20)
        Me.Txtma_xe.TabIndex = 3
        Me.Txtma_xe.Table_Name = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 528
        Me.Label2.Tag = "License Plate"
        Me.Label2.Text = "Biển số"
        '
        'TxtTen_bh
        '
        Me.TxtTen_bh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTen_bh.Location = New System.Drawing.Point(214, 60)
        Me.TxtTen_bh.Name = "TxtTen_bh"
        Me.TxtTen_bh.Size = New System.Drawing.Size(443, 17)
        Me.TxtTen_bh.TabIndex = 530
        '
        'TxtSo_Ro
        '
        Me.TxtSo_Ro.Location = New System.Drawing.Point(92, 103)
        Me.TxtSo_Ro.Name = "TxtSo_Ro"
        Me.TxtSo_Ro.Size = New System.Drawing.Size(116, 21)
        Me.TxtSo_Ro.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 533
        Me.Label3.Tag = "License Plate"
        Me.Label3.Text = "Số lệnh"
        '
        'Chkis_Hd
        '
        Me.Chkis_Hd.AutoSize = True
        Me.Chkis_Hd.ForeColor = System.Drawing.Color.Red
        Me.Chkis_Hd.Location = New System.Drawing.Point(244, 107)
        Me.Chkis_Hd.Name = "Chkis_Hd"
        Me.Chkis_Hd.Size = New System.Drawing.Size(86, 17)
        Me.Chkis_Hd.TabIndex = 5
        Me.Chkis_Hd.Tag = "Group 1 "
        Me.Chkis_Hd.Text = "Viết hóa đơn"
        Me.Chkis_Hd.UseVisualStyleBackColor = True
        '
        'BCDV10_HTN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(669, 239)
        Me.Controls.Add(Me.Chkis_Hd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtSo_Ro)
        Me.Controls.Add(Me.TxtTen_bh)
        Me.Controls.Add(Me.Txtma_xe)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txtma_bh)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "BCDV10_HTN"
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.Txtma_bh, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Txtma_xe, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_bh, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Ro, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Chkis_Hd, 0)
        CType(Me.Txtma_bh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txtma_xe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Txtma_bh As SmLists.TxtLookup
    Friend WithEvents Txtma_xe As SmLists.TxtLookup
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtTen_bh As Label
    Friend WithEvents TxtSo_Ro As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Chkis_Hd As CheckBox
End Class
