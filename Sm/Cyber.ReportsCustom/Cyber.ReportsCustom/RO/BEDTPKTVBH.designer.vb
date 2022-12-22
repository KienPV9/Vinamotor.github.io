<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BEDTPKTVBH
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
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.LabMa_Nh1 = New System.Windows.Forms.Label()
        Me.TxtTen_HS_H = New System.Windows.Forms.TextBox()
        Me.TxtMa_HS_H = New Cyber.SmLists.TxtLookup()
        Me.cbbMa_BC = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CbbM_Nam = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbbM_Thang = New System.Windows.Forms.ComboBox()
        Me.LabM_month1 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_HS_H.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(492, 183)
        Me.ButtExit.TabIndex = 14
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(93, 142)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(491, 21)
        Me.CBBMa_Dvcs.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(7, 145)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(388, 183)
        Me.ButtOK.TabIndex = 13
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(7, 118)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(93, 116)
        Me.ChkVND.TabIndex = 10
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(209, 116)
        Me.ChkNT.TabIndex = 11
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 166)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(589, 9)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'LabMa_Nh1
        '
        Me.LabMa_Nh1.Location = New System.Drawing.Point(7, 62)
        Me.LabMa_Nh1.Name = "LabMa_Nh1"
        Me.LabMa_Nh1.Size = New System.Drawing.Size(92, 14)
        Me.LabMa_Nh1.TabIndex = 153
        Me.LabMa_Nh1.Tag = "Group 1"
        Me.LabMa_Nh1.Text = "Tư vấn bán hàng"
        '
        'TxtTen_HS_H
        '
        Me.TxtTen_HS_H.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_HS_H.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_HS_H.Enabled = False
        Me.TxtTen_HS_H.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_HS_H.Location = New System.Drawing.Point(245, 64)
        Me.TxtTen_HS_H.Name = "TxtTen_HS_H"
        Me.TxtTen_HS_H.ReadOnly = True
        Me.TxtTen_HS_H.Size = New System.Drawing.Size(339, 14)
        Me.TxtTen_HS_H.TabIndex = 152
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
        Me.TxtMa_HS_H.Location = New System.Drawing.Point(107, 59)
        Me.TxtMa_HS_H.Name = "TxtMa_HS_H"
        Me.TxtMa_HS_H.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_HS_H.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_HS_H.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_HS_H.Size = New System.Drawing.Size(132, 20)
        Me.TxtMa_HS_H.TabIndex = 4
        Me.TxtMa_HS_H.Table_Name = ""
        '
        'cbbMa_BC
        '
        Me.cbbMa_BC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbMa_BC.ForeColor = System.Drawing.Color.Navy
        Me.cbbMa_BC.FormattingEnabled = True
        Me.cbbMa_BC.Location = New System.Drawing.Point(107, 84)
        Me.cbbMa_BC.Name = "cbbMa_BC"
        Me.cbbMa_BC.Size = New System.Drawing.Size(477, 21)
        Me.cbbMa_BC.TabIndex = 271
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(7, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 13)
        Me.Label12.TabIndex = 272
        Me.Label12.Tag = "Transfer arising stock"
        Me.Label12.Text = "Loại báo cáo"
        '
        'CbbM_Nam
        '
        Me.CbbM_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Nam.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Nam.FormattingEnabled = True
        Me.CbbM_Nam.Location = New System.Drawing.Point(107, 35)
        Me.CbbM_Nam.Name = "CbbM_Nam"
        Me.CbbM_Nam.Size = New System.Drawing.Size(132, 21)
        Me.CbbM_Nam.TabIndex = 442
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 444
        Me.Label4.Tag = "Year"
        Me.Label4.Text = "Năm"
        '
        'CbbM_Thang
        '
        Me.CbbM_Thang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Thang.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Thang.FormattingEnabled = True
        Me.CbbM_Thang.Location = New System.Drawing.Point(107, 12)
        Me.CbbM_Thang.Name = "CbbM_Thang"
        Me.CbbM_Thang.Size = New System.Drawing.Size(132, 21)
        Me.CbbM_Thang.TabIndex = 441
        '
        'LabM_month1
        '
        Me.LabM_month1.AutoSize = True
        Me.LabM_month1.Location = New System.Drawing.Point(7, 20)
        Me.LabM_month1.Name = "LabM_month1"
        Me.LabM_month1.Size = New System.Drawing.Size(51, 13)
        Me.LabM_month1.TabIndex = 443
        Me.LabM_month1.Tag = "Month from"
        Me.LabM_month1.Text = "Từ tháng"
        '
        'BEDTPKTVBH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(596, 231)
        Me.Controls.Add(Me.CbbM_Nam)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CbbM_Thang)
        Me.Controls.Add(Me.LabM_month1)
        Me.Controls.Add(Me.cbbMa_BC)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.LabMa_Nh1)
        Me.Controls.Add(Me.TxtTen_HS_H)
        Me.Controls.Add(Me.TxtMa_HS_H)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Name = "BEDTPKTVBH"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_HS_H, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_HS_H, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Nh1, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.cbbMa_BC, 0)
        Me.Controls.SetChildIndex(Me.LabM_month1, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Thang, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Nam, 0)
        CType(Me.TxtMa_HS_H.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents LabMa_Nh1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_HS_H As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_HS_H As Cyber.SmLists.TxtLookup
    Friend WithEvents cbbMa_BC As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CbbM_Nam As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CbbM_Thang As System.Windows.Forms.ComboBox
    Friend WithEvents LabM_month1 As System.Windows.Forms.Label

End Class
