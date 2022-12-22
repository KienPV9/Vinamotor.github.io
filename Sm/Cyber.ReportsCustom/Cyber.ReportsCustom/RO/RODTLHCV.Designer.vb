<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RODTLHCV
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSo_ct1 = New System.Windows.Forms.TextBox()
        Me.TxtTen_CV = New System.Windows.Forms.TextBox()
        Me.TxtMa_CV = New Cyber.SmLists.TxtLookup()
        Me.LabMa_Nh1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbbMa_TT = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_Hs_H = New System.Windows.Forms.TextBox()
        Me.TxtMa_Hs_H = New Cyber.SmLists.TxtLookup()
        Me.ChkXem_CT = New System.Windows.Forms.CheckBox()
        CType(Me.TxtMa_CV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Hs_H.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(492, 195)
        Me.ButtExit.TabIndex = 8
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(93, 154)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(491, 21)
        Me.CBBMa_Dvcs.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(7, 157)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(388, 195)
        Me.ButtOK.TabIndex = 7
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(7, 130)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(93, 128)
        Me.ChkVND.TabIndex = 4
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(209, 128)
        Me.ChkNT.TabIndex = 5
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(107, 9)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct1.TabIndex = 0
        Me.TxtM_Ngay_Ct1.Text = "01/01/1900"
        Me.TxtM_Ngay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(107, 34)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct2.TabIndex = 1
        Me.TxtM_Ngay_Ct2.Text = "01/01/1900"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(12, 13)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(47, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 13
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(12, 37)
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
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 178)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(589, 9)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 157
        Me.Label4.Tag = "Account"
        Me.Label4.Text = "Số R/o"
        '
        'txtSo_ct1
        '
        Me.txtSo_ct1.BackColor = System.Drawing.Color.White
        Me.txtSo_ct1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSo_ct1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtSo_ct1.ForeColor = System.Drawing.Color.Navy
        Me.txtSo_ct1.Location = New System.Drawing.Point(107, 58)
        Me.txtSo_ct1.Name = "txtSo_ct1"
        Me.txtSo_ct1.Size = New System.Drawing.Size(114, 21)
        Me.txtSo_ct1.TabIndex = 2
        Me.txtSo_ct1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTen_CV
        '
        Me.TxtTen_CV.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_CV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_CV.Enabled = False
        Me.TxtTen_CV.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_CV.Location = New System.Drawing.Point(227, 85)
        Me.TxtTen_CV.Name = "TxtTen_CV"
        Me.TxtTen_CV.ReadOnly = True
        Me.TxtTen_CV.Size = New System.Drawing.Size(365, 14)
        Me.TxtTen_CV.TabIndex = 152
        Me.TxtTen_CV.TabStop = False
        '
        'TxtMa_CV
        '
        Me.TxtMa_CV._ActilookupPopup = False
        Me.TxtMa_CV.CyberActilookupPopup = True
        Me.TxtMa_CV.Dv_ListDetail = Nothing
        Me.TxtMa_CV.Dv_Master = Nothing
        Me.TxtMa_CV.FilterClient = ""
        Me.TxtMa_CV.FilterSQL = ""
        Me.TxtMa_CV.Location = New System.Drawing.Point(107, 82)
        Me.TxtMa_CV.Name = "TxtMa_CV"
        Me.TxtMa_CV.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_CV.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_CV.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_CV.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_CV.TabIndex = 3
        Me.TxtMa_CV.Table_Name = ""
        '
        'LabMa_Nh1
        '
        Me.LabMa_Nh1.Location = New System.Drawing.Point(12, 85)
        Me.LabMa_Nh1.Name = "LabMa_Nh1"
        Me.LabMa_Nh1.Size = New System.Drawing.Size(92, 14)
        Me.LabMa_Nh1.TabIndex = 153
        Me.LabMa_Nh1.Tag = "Group 1"
        Me.LabMa_Nh1.Text = "Mã công việc"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(247, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 452
        Me.Label2.Tag = "Loại lệnh"
        Me.Label2.Text = "Thanh toán"
        '
        'CbbMa_TT
        '
        Me.CbbMa_TT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_TT.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_TT.FormattingEnabled = True
        Me.CbbMa_TT.Location = New System.Drawing.Point(339, 9)
        Me.CbbMa_TT.Name = "CbbMa_TT"
        Me.CbbMa_TT.Size = New System.Drawing.Size(245, 21)
        Me.CbbMa_TT.TabIndex = 451
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 14)
        Me.Label3.TabIndex = 455
        Me.Label3.Tag = "Group 1"
        Me.Label3.Text = "CVDV"
        '
        'TxtTen_Hs_H
        '
        Me.TxtTen_Hs_H.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Hs_H.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Hs_H.Enabled = False
        Me.TxtTen_Hs_H.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Hs_H.Location = New System.Drawing.Point(227, 107)
        Me.TxtTen_Hs_H.Name = "TxtTen_Hs_H"
        Me.TxtTen_Hs_H.ReadOnly = True
        Me.TxtTen_Hs_H.Size = New System.Drawing.Size(365, 14)
        Me.TxtTen_Hs_H.TabIndex = 454
        Me.TxtTen_Hs_H.TabStop = False
        '
        'TxtMa_Hs_H
        '
        Me.TxtMa_Hs_H._ActilookupPopup = False
        Me.TxtMa_Hs_H.CyberActilookupPopup = True
        Me.TxtMa_Hs_H.Dv_ListDetail = Nothing
        Me.TxtMa_Hs_H.Dv_Master = Nothing
        Me.TxtMa_Hs_H.FilterClient = ""
        Me.TxtMa_Hs_H.FilterSQL = ""
        Me.TxtMa_Hs_H.Location = New System.Drawing.Point(107, 104)
        Me.TxtMa_Hs_H.Name = "TxtMa_Hs_H"
        Me.TxtMa_Hs_H.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Hs_H.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Hs_H.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Hs_H.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_Hs_H.TabIndex = 4
        Me.TxtMa_Hs_H.Table_Name = ""
        '
        'ChkXem_CT
        '
        Me.ChkXem_CT.AutoSize = True
        Me.ChkXem_CT.Location = New System.Drawing.Point(339, 37)
        Me.ChkXem_CT.Name = "ChkXem_CT"
        Me.ChkXem_CT.Size = New System.Drawing.Size(81, 17)
        Me.ChkXem_CT.TabIndex = 456
        Me.ChkXem_CT.Text = "Xem chi tiết"
        Me.ChkXem_CT.UseVisualStyleBackColor = True
        '
        'RODTLHCV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(596, 243)
        Me.Controls.Add(Me.ChkXem_CT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTen_Hs_H)
        Me.Controls.Add(Me.TxtMa_Hs_H)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbbMa_TT)
        Me.Controls.Add(Me.txtSo_ct1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LabMa_Nh1)
        Me.Controls.Add(Me.TxtTen_CV)
        Me.Controls.Add(Me.TxtMa_CV)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Name = "RODTLHCV"
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_CV, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_CV, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Nh1, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.txtSo_ct1, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_TT, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Hs_H, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hs_H, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.ChkXem_CT, 0)
        CType(Me.TxtMa_CV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Hs_H.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSo_ct1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_CV As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_CV As Cyber.SmLists.TxtLookup
    Friend WithEvents LabMa_Nh1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CbbMa_TT As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Hs_H As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Hs_H As Cyber.SmLists.TxtLookup
    Friend WithEvents ChkXem_CT As System.Windows.Forms.CheckBox

End Class
