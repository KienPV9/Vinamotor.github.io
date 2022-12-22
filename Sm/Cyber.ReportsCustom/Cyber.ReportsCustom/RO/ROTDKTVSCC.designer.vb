<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ROTDKTVSCC
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
        Me.TxtMa_KX = New System.Windows.Forms.TextBox()
        Me.TxtTen_HS = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSo_RO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtMa_HS = New Cyber.SmLists.TxtLookup()
        Me.TxtMa_XE = New Cyber.SmLists.TxtLookup()
        CType(Me.TxtMa_HS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_XE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(492, 193)
        Me.ButtExit.TabIndex = 14
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(107, 159)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(491, 21)
        Me.CBBMa_Dvcs.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(15, 162)
        Me.Label1.TabIndex = 8
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(388, 193)
        Me.ButtOK.TabIndex = 13
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(15, 135)
        Me.LabLoai_NT.TabIndex = 5
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(107, 133)
        Me.ChkVND.TabIndex = 6
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(209, 133)
        Me.ChkNT.TabIndex = 7
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
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(15, 12)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(47, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 13
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(15, 37)
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
        Me.GroupBoxLine.Location = New System.Drawing.Point(15, 178)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(589, 9)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'LabM_Tk
        '
        Me.LabM_Tk.AutoSize = True
        Me.LabM_Tk.Location = New System.Drawing.Point(15, 86)
        Me.LabM_Tk.Name = "LabM_Tk"
        Me.LabM_Tk.Size = New System.Drawing.Size(41, 13)
        Me.LabM_Tk.TabIndex = 17
        Me.LabM_Tk.Tag = "Account"
        Me.LabM_Tk.Text = "Biển số"
        '
        'TxtMa_KX
        '
        Me.TxtMa_KX.BackColor = System.Drawing.SystemColors.Control
        Me.TxtMa_KX.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtMa_KX.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_KX.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_KX.Location = New System.Drawing.Point(227, 86)
        Me.TxtMa_KX.Name = "TxtMa_KX"
        Me.TxtMa_KX.ReadOnly = True
        Me.TxtMa_KX.Size = New System.Drawing.Size(365, 13)
        Me.TxtMa_KX.TabIndex = 144
        Me.TxtMa_KX.TabStop = False
        '
        'TxtTen_HS
        '
        Me.TxtTen_HS.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_HS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_HS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_HS.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_HS.Location = New System.Drawing.Point(227, 111)
        Me.TxtTen_HS.Name = "TxtTen_HS"
        Me.TxtTen_HS.ReadOnly = True
        Me.TxtTen_HS.Size = New System.Drawing.Size(365, 13)
        Me.TxtTen_HS.TabIndex = 148
        Me.TxtTen_HS.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 147
        Me.Label2.Tag = "Customer"
        Me.Label2.Text = "Nhân viên"
        '
        'txtSo_RO
        '
        Me.txtSo_RO.BackColor = System.Drawing.Color.White
        Me.txtSo_RO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSo_RO.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtSo_RO.ForeColor = System.Drawing.Color.Navy
        Me.txtSo_RO.Location = New System.Drawing.Point(107, 59)
        Me.txtSo_RO.Name = "txtSo_RO"
        Me.txtSo_RO.Size = New System.Drawing.Size(114, 21)
        Me.txtSo_RO.TabIndex = 2
        Me.txtSo_RO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 159
        Me.Label4.Tag = "Account"
        Me.Label4.Text = "Số R/O"
        '
        'TxtMa_HS
        '
        Me.TxtMa_HS._ActilookupPopup = False
        Me.TxtMa_HS.CyberActilookupPopup = True
        Me.TxtMa_HS.Dv_ListDetail = Nothing
        Me.TxtMa_HS.Dv_Master = Nothing
        Me.TxtMa_HS.FilterClient = ""
        Me.TxtMa_HS.FilterSQL = ""
        Me.TxtMa_HS.Location = New System.Drawing.Point(107, 107)
        Me.TxtMa_HS.Name = "TxtMa_HS"
        Me.TxtMa_HS.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_HS.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_HS.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_HS.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_HS.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_HS.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_HS.TabIndex = 4
        Me.TxtMa_HS.Table_Name = ""
        '
        'TxtMa_XE
        '
        Me.TxtMa_XE._ActilookupPopup = False
        Me.TxtMa_XE.CyberActilookupPopup = True
        Me.TxtMa_XE.Dv_ListDetail = Nothing
        Me.TxtMa_XE.Dv_Master = Nothing
        Me.TxtMa_XE.FilterClient = ""
        Me.TxtMa_XE.FilterSQL = ""
        Me.TxtMa_XE.Location = New System.Drawing.Point(107, 83)
        Me.TxtMa_XE.Name = "TxtMa_XE"
        Me.TxtMa_XE.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_XE.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_XE.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_XE.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_XE.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_XE.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_XE.TabIndex = 3
        Me.TxtMa_XE.Table_Name = ""
        '
        'ROTDKTVSCC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(596, 252)
        Me.Controls.Add(Me.txtSo_RO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtMa_HS)
        Me.Controls.Add(Me.TxtTen_HS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtMa_XE)
        Me.Controls.Add(Me.TxtMa_KX)
        Me.Controls.Add(Me.LabM_Tk)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Name = "ROTDKTVSCC"
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
        Me.Controls.SetChildIndex(Me.TxtMa_KX, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_XE, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_HS, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_HS, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.txtSo_RO, 0)
        CType(Me.TxtMa_HS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_XE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents LabM_Tk As System.Windows.Forms.Label
    Friend WithEvents TxtMa_XE As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtMa_KX As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_HS As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_HS As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSo_RO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
