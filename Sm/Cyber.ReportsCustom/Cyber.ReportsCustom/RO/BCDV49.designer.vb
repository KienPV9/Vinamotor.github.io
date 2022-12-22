<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BCDV49
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
        Me.TxtTen_bh = New System.Windows.Forms.Label()
        Me.ChkIs_All = New System.Windows.Forms.CheckBox()
        Me.ChkIs_N = New System.Windows.Forms.CheckBox()
        Me.ChkIs_W = New System.Windows.Forms.CheckBox()
        Me.ChkIs_I = New System.Windows.Forms.CheckBox()
        Me.ChkIs_C = New System.Windows.Forms.CheckBox()
        CType(Me.Txtma_bh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(565, 162)
        Me.ButtExit.TabIndex = 7
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(92, 130)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(573, 21)
        Me.CBBMa_Dvcs.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 133)
        Me.Label1.TabIndex = 17
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(461, 162)
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(6, 111)
        Me.LabLoai_NT.TabIndex = 14
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(92, 109)
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(212, 109)
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
        Me.GroupBoxLine.Location = New System.Drawing.Point(5, 150)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(662, 9)
        Me.GroupBoxLine.TabIndex = 19
        Me.GroupBoxLine.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 13)
        Me.Label11.TabIndex = 509
        Me.Label11.Tag = "License Plate"
        Me.Label11.Text = "Khách hàng"
        '
        'Txtma_bh
        '
        Me.Txtma_bh._ActilookupPopup = False
        Me.Txtma_bh.CyberActilookupPopup = True
        Me.Txtma_bh.Dv_ListDetail = Nothing
        Me.Txtma_bh.Dv_Master = Nothing
        Me.Txtma_bh.FilterClient = ""
        Me.Txtma_bh.FilterSQL = ""
        Me.Txtma_bh.Location = New System.Drawing.Point(93, 74)
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
        'TxtTen_bh
        '
        Me.TxtTen_bh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTen_bh.Location = New System.Drawing.Point(213, 77)
        Me.TxtTen_bh.Name = "TxtTen_bh"
        Me.TxtTen_bh.Size = New System.Drawing.Size(443, 17)
        Me.TxtTen_bh.TabIndex = 530
        '
        'ChkIs_All
        '
        Me.ChkIs_All.AutoSize = True
        Me.ChkIs_All.Checked = True
        Me.ChkIs_All.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkIs_All.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ChkIs_All.Location = New System.Drawing.Point(268, 12)
        Me.ChkIs_All.Name = "ChkIs_All"
        Me.ChkIs_All.Size = New System.Drawing.Size(154, 17)
        Me.ChkIs_All.TabIndex = 531
        Me.ChkIs_All.Text = "Tất cả loại hình thanh toán"
        Me.ChkIs_All.UseVisualStyleBackColor = True
        '
        'ChkIs_N
        '
        Me.ChkIs_N.AutoSize = True
        Me.ChkIs_N.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ChkIs_N.Location = New System.Drawing.Point(490, 55)
        Me.ChkIs_N.Name = "ChkIs_N"
        Me.ChkIs_N.Size = New System.Drawing.Size(130, 17)
        Me.ChkIs_N.TabIndex = 535
        Me.ChkIs_N.Text = "Nội bộ thanh toán (N)"
        Me.ChkIs_N.UseVisualStyleBackColor = True
        '
        'ChkIs_W
        '
        Me.ChkIs_W.AutoSize = True
        Me.ChkIs_W.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ChkIs_W.Location = New System.Drawing.Point(268, 55)
        Me.ChkIs_W.Name = "ChkIs_W"
        Me.ChkIs_W.Size = New System.Drawing.Size(148, 17)
        Me.ChkIs_W.TabIndex = 533
        Me.ChkIs_W.Text = "Bảo hành thanh toán (W)"
        Me.ChkIs_W.UseVisualStyleBackColor = True
        '
        'ChkIs_I
        '
        Me.ChkIs_I.AutoSize = True
        Me.ChkIs_I.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ChkIs_I.Location = New System.Drawing.Point(490, 33)
        Me.ChkIs_I.Name = "ChkIs_I"
        Me.ChkIs_I.Size = New System.Drawing.Size(140, 17)
        Me.ChkIs_I.TabIndex = 534
        Me.ChkIs_I.Text = "Bảo hiểm thanh toán (I)"
        Me.ChkIs_I.UseVisualStyleBackColor = True
        '
        'ChkIs_C
        '
        Me.ChkIs_C.AutoSize = True
        Me.ChkIs_C.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ChkIs_C.Location = New System.Drawing.Point(268, 33)
        Me.ChkIs_C.Name = "ChkIs_C"
        Me.ChkIs_C.Size = New System.Drawing.Size(156, 17)
        Me.ChkIs_C.TabIndex = 532
        Me.ChkIs_C.Text = "Khách hàng thanh toán (C)"
        Me.ChkIs_C.UseVisualStyleBackColor = True
        '
        'BCDV49
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(669, 215)
        Me.Controls.Add(Me.ChkIs_All)
        Me.Controls.Add(Me.ChkIs_N)
        Me.Controls.Add(Me.ChkIs_W)
        Me.Controls.Add(Me.ChkIs_I)
        Me.Controls.Add(Me.ChkIs_C)
        Me.Controls.Add(Me.TxtTen_bh)
        Me.Controls.Add(Me.Txtma_bh)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "BCDV49"
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
        Me.Controls.SetChildIndex(Me.TxtTen_bh, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_C, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_I, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_W, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_N, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_All, 0)
        CType(Me.Txtma_bh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TxtTen_bh As Label
    Friend WithEvents ChkIs_All As CheckBox
    Friend WithEvents ChkIs_N As CheckBox
    Friend WithEvents ChkIs_W As CheckBox
    Friend WithEvents ChkIs_I As CheckBox
    Friend WithEvents ChkIs_C As CheckBox
End Class
