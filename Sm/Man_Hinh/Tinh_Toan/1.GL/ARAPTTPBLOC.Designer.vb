﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ARAPTTPBLOC
    Inherits Cyber.From.FrmCalculator

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
        Me.LabM_Ngay_Ct2 = New System.Windows.Forms.Label()
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.TxtM_Ngay_Ct2 = New ClsTextBox.txtDate1()
        Me.TxtM_Ngay_Ct1 = New ClsTextBox.txtDate1()
        Me.TxtM_Ma_kh = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_KH = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtM_Tk_CN = New Cyber.SmLists.TxtLookup()
        Me.Txtten_Tk_CN = New System.Windows.Forms.TextBox()
        Me.LabM_Tk = New System.Windows.Forms.Label()
        CType(Me.TxtM_Ma_kh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtM_Tk_CN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 105)
        Me.GroupBoxLine.Size = New System.Drawing.Size(667, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(467, 115)
        Me.ButtOK.TabIndex = 4
        Me.ButtOK.Tag = "&Ok"
        Me.ButtOK.Text = "&Chấp nhận"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(569, 115)
        Me.ButtExit.TabIndex = 5
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(15, 33)
        Me.LabM_Ngay_Ct2.Name = "LabM_Ngay_Ct2"
        Me.LabM_Ngay_Ct2.Size = New System.Drawing.Size(53, 13)
        Me.LabM_Ngay_Ct2.TabIndex = 48
        Me.LabM_Ngay_Ct2.Tag = "Date to"
        Me.LabM_Ngay_Ct2.Text = "Đến ngày"
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(15, 8)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(46, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 47
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(101, 30)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(139, 20)
        Me.TxtM_Ngay_Ct2.TabIndex = 1
        Me.TxtM_Ngay_Ct2.Text = "01/01/1900"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(101, 5)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(139, 20)
        Me.TxtM_Ngay_Ct1.TabIndex = 0
        Me.TxtM_Ngay_Ct1.Text = "01/01/1900"
        Me.TxtM_Ngay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtM_Ma_kh
        '
        Me.TxtM_Ma_kh._ActilookupPopup = False
        Me.TxtM_Ma_kh.CyberActilookupPopup = True
        Me.TxtM_Ma_kh.Dv_ListDetail = Nothing
        Me.TxtM_Ma_kh.Dv_Master = Nothing
        Me.TxtM_Ma_kh.FilterClient = ""
        Me.TxtM_Ma_kh.FilterSQL = ""
        Me.TxtM_Ma_kh.Location = New System.Drawing.Point(101, 76)
        Me.TxtM_Ma_kh.Name = "TxtM_Ma_kh"
        Me.TxtM_Ma_kh.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtM_Ma_kh.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ma_kh.Properties.Appearance.Options.UseFont = True
        Me.TxtM_Ma_kh.Properties.Appearance.Options.UseForeColor = True
        Me.TxtM_Ma_kh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtM_Ma_kh.Size = New System.Drawing.Size(139, 20)
        Me.TxtM_Ma_kh.TabIndex = 3
        Me.TxtM_Ma_kh.Table_Name = ""
        '
        'TxtTen_KH
        '
        Me.TxtTen_KH.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_KH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_KH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_KH.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_KH.Location = New System.Drawing.Point(248, 83)
        Me.TxtTen_KH.Name = "TxtTen_KH"
        Me.TxtTen_KH.ReadOnly = True
        Me.TxtTen_KH.Size = New System.Drawing.Size(411, 13)
        Me.TxtTen_KH.TabIndex = 154
        Me.TxtTen_KH.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 153
        Me.Label2.Tag = "Customer"
        Me.Label2.Text = "Mã đối tượng"
        '
        'TxtM_Tk_CN
        '
        Me.TxtM_Tk_CN._ActilookupPopup = False
        Me.TxtM_Tk_CN.CyberActilookupPopup = True
        Me.TxtM_Tk_CN.Dv_ListDetail = Nothing
        Me.TxtM_Tk_CN.Dv_Master = Nothing
        Me.TxtM_Tk_CN.FilterClient = ""
        Me.TxtM_Tk_CN.FilterSQL = ""
        Me.TxtM_Tk_CN.Location = New System.Drawing.Point(101, 53)
        Me.TxtM_Tk_CN.Name = "TxtM_Tk_CN"
        Me.TxtM_Tk_CN.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtM_Tk_CN.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Tk_CN.Properties.Appearance.Options.UseFont = True
        Me.TxtM_Tk_CN.Properties.Appearance.Options.UseForeColor = True
        Me.TxtM_Tk_CN.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtM_Tk_CN.Size = New System.Drawing.Size(139, 20)
        Me.TxtM_Tk_CN.TabIndex = 2
        Me.TxtM_Tk_CN.Table_Name = ""
        '
        'Txtten_Tk_CN
        '
        Me.Txtten_Tk_CN.BackColor = System.Drawing.SystemColors.Control
        Me.Txtten_Tk_CN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtten_Tk_CN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Txtten_Tk_CN.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_Tk_CN.Location = New System.Drawing.Point(248, 60)
        Me.Txtten_Tk_CN.Name = "Txtten_Tk_CN"
        Me.Txtten_Tk_CN.ReadOnly = True
        Me.Txtten_Tk_CN.Size = New System.Drawing.Size(411, 13)
        Me.Txtten_Tk_CN.TabIndex = 152
        Me.Txtten_Tk_CN.TabStop = False
        '
        'LabM_Tk
        '
        Me.LabM_Tk.AutoSize = True
        Me.LabM_Tk.Location = New System.Drawing.Point(15, 56)
        Me.LabM_Tk.Name = "LabM_Tk"
        Me.LabM_Tk.Size = New System.Drawing.Size(55, 13)
        Me.LabM_Tk.TabIndex = 151
        Me.LabM_Tk.Tag = "Account"
        Me.LabM_Tk.Text = "Tài khoản"
        '
        'ARAPTTPBLOC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(671, 169)
        Me.Controls.Add(Me.TxtM_Ma_kh)
        Me.Controls.Add(Me.TxtTen_KH)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtM_Tk_CN)
        Me.Controls.Add(Me.Txtten_Tk_CN)
        Me.Controls.Add(Me.LabM_Tk)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Name = "ARAPTTPBLOC"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Tk, 0)
        Me.Controls.SetChildIndex(Me.Txtten_Tk_CN, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Tk_CN, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_KH, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ma_kh, 0)
        CType(Me.TxtM_Ma_kh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtM_Tk_CN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ma_kh As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_KH As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtM_Tk_CN As Cyber.SmLists.TxtLookup
    Friend WithEvents Txtten_Tk_CN As System.Windows.Forms.TextBox
    Friend WithEvents LabM_Tk As System.Windows.Forms.Label

End Class
