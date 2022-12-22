<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMCSCKBH
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
        Me.LabMa_bh = New System.Windows.Forms.Label()
        Me.TxtTen_BH = New System.Windows.Forms.TextBox()
        Me.TxtMa_BH = New Cyber.SmLists.TxtLookup()
        Me.LabNgay_HL = New System.Windows.Forms.Label()
        Me.TxtNgay_HL = New ClsTextBox.txtDate1()
        Me.TxtPT_Nhan_Cong_Hang = New ClsTextBox.txtTy_Gia()
        Me.TxtPT_PT_Hang = New ClsTextBox.txtTy_Gia()
        Me.LabGia_nt2 = New System.Windows.Forms.Label()
        Me.TxtPT_PT_Ngoai = New ClsTextBox.txtTy_Gia()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPT_Nhan_Cong_Ngoai = New ClsTextBox.txtTy_Gia()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtGhi_Chu = New System.Windows.Forms.TextBox()
        CType(Me.TxtMa_BH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(695, 187)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtExit.TabIndex = 9
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(559, 187)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtOK.TabIndex = 8
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(421, 283)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(143, 24)
        Me.TxtMa_Dvcs.TabIndex = 16
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(306, 192)
        Me.ChkActi.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkActi.TabIndex = 7
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 174)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(825, 12)
        Me.GroupBoxLine.TabIndex = 14
        '
        'LabMa_bh
        '
        Me.LabMa_bh.Location = New System.Drawing.Point(6, 26)
        Me.LabMa_bh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_bh.Name = "LabMa_bh"
        Me.LabMa_bh.Size = New System.Drawing.Size(275, 25)
        Me.LabMa_bh.TabIndex = 20
        Me.LabMa_bh.Tag = "Item code"
        Me.LabMa_bh.Text = "Mã đơn vị bảo hiểm"
        '
        'TxtTen_BH
        '
        Me.TxtTen_BH.BackColor = System.Drawing.Color.White
        Me.TxtTen_BH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_BH.Enabled = False
        Me.TxtTen_BH.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_BH.Location = New System.Drawing.Point(418, 23)
        Me.TxtTen_BH.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_BH.Name = "TxtTen_BH"
        Me.TxtTen_BH.ReadOnly = True
        Me.TxtTen_BH.Size = New System.Drawing.Size(402, 17)
        Me.TxtTen_BH.TabIndex = 382
        Me.TxtTen_BH.TabStop = False
        '
        'TxtMa_BH
        '
        Me.TxtMa_BH._ActilookupPopup = False
        Me.TxtMa_BH.CyberActilookupPopup = True
        Me.TxtMa_BH.Dv_ListDetail = Nothing
        Me.TxtMa_BH.Dv_Master = Nothing
        Me.TxtMa_BH.FilterClient = ""
        Me.TxtMa_BH.FilterSQL = ""
        Me.TxtMa_BH.Location = New System.Drawing.Point(211, 21)
        Me.TxtMa_BH.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_BH.Name = "TxtMa_BH"
        Me.TxtMa_BH.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_BH.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_BH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_BH.Size = New System.Drawing.Size(199, 22)
        Me.TxtMa_BH.TabIndex = 0
        Me.TxtMa_BH.Table_Name = ""
        '
        'LabNgay_HL
        '
        Me.LabNgay_HL.Location = New System.Drawing.Point(6, 53)
        Me.LabNgay_HL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabNgay_HL.Name = "LabNgay_HL"
        Me.LabNgay_HL.Size = New System.Drawing.Size(201, 25)
        Me.LabNgay_HL.TabIndex = 29
        Me.LabNgay_HL.Tag = "Date"
        Me.LabNgay_HL.Text = "Ngày hiệu lực"
        '
        'TxtNgay_HL
        '
        Me.TxtNgay_HL.Flags = 65536
        Me.TxtNgay_HL.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_HL.IsAllowResize = False
        Me.TxtNgay_HL.isEmpty = True
        Me.TxtNgay_HL.Location = New System.Drawing.Point(211, 51)
        Me.TxtNgay_HL.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_HL.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_HL.MaxLength = 10
        Me.TxtNgay_HL.Name = "TxtNgay_HL"
        Me.TxtNgay_HL.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_HL.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_HL.ShowDayBeforeMonth = False
        Me.TxtNgay_HL.Size = New System.Drawing.Size(199, 24)
        Me.TxtNgay_HL.TabIndex = 1
        Me.TxtNgay_HL.Text = "07/09/2011"
        Me.TxtNgay_HL.Value = New Date(2011, 9, 7, 0, 0, 0, 0)
        '
        'TxtPT_Nhan_Cong_Hang
        '
        Me.TxtPT_Nhan_Cong_Hang.AllowNegative = True
        Me.TxtPT_Nhan_Cong_Hang.Flags = 7680
        Me.TxtPT_Nhan_Cong_Hang.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPT_Nhan_Cong_Hang.ForeColor = System.Drawing.Color.Navy
        Me.TxtPT_Nhan_Cong_Hang.InputMask = "### ### ### ### ###.##"
        Me.TxtPT_Nhan_Cong_Hang.Location = New System.Drawing.Point(211, 80)
        Me.TxtPT_Nhan_Cong_Hang.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPT_Nhan_Cong_Hang.MaxWholeDigits = 17
        Me.TxtPT_Nhan_Cong_Hang.Name = "TxtPT_Nhan_Cong_Hang"
        Me.TxtPT_Nhan_Cong_Hang.RangeMax = 1.7976931348623157E+308R
        Me.TxtPT_Nhan_Cong_Hang.RangeMin = -1.7976931348623157E+308R
        Me.TxtPT_Nhan_Cong_Hang.Size = New System.Drawing.Size(199, 24)
        Me.TxtPT_Nhan_Cong_Hang.TabIndex = 2
        Me.TxtPT_Nhan_Cong_Hang.Text = "0.00"
        Me.TxtPT_Nhan_Cong_Hang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtPT_PT_Hang
        '
        Me.TxtPT_PT_Hang.AllowNegative = True
        Me.TxtPT_PT_Hang.Flags = 7680
        Me.TxtPT_PT_Hang.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPT_PT_Hang.ForeColor = System.Drawing.Color.Navy
        Me.TxtPT_PT_Hang.InputMask = "### ### ### ### ###.##"
        Me.TxtPT_PT_Hang.Location = New System.Drawing.Point(211, 109)
        Me.TxtPT_PT_Hang.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPT_PT_Hang.MaxWholeDigits = 17
        Me.TxtPT_PT_Hang.Name = "TxtPT_PT_Hang"
        Me.TxtPT_PT_Hang.RangeMax = 1.7976931348623157E+308R
        Me.TxtPT_PT_Hang.RangeMin = -1.7976931348623157E+308R
        Me.TxtPT_PT_Hang.Size = New System.Drawing.Size(199, 24)
        Me.TxtPT_PT_Hang.TabIndex = 3
        Me.TxtPT_PT_Hang.Text = "0.00"
        Me.TxtPT_PT_Hang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabGia_nt2
        '
        Me.LabGia_nt2.Location = New System.Drawing.Point(6, 80)
        Me.LabGia_nt2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabGia_nt2.Name = "LabGia_nt2"
        Me.LabGia_nt2.Size = New System.Drawing.Size(275, 25)
        Me.LabGia_nt2.TabIndex = 30
        Me.LabGia_nt2.Tag = "Saler Honda comission(%)"
        Me.LabGia_nt2.Text = "Hoa hồng nhân công hãng(%)"
        '
        'TxtPT_PT_Ngoai
        '
        Me.TxtPT_PT_Ngoai.AllowNegative = True
        Me.TxtPT_PT_Ngoai.Flags = 7680
        Me.TxtPT_PT_Ngoai.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPT_PT_Ngoai.ForeColor = System.Drawing.Color.Navy
        Me.TxtPT_PT_Ngoai.InputMask = "### ### ### ### ###.##"
        Me.TxtPT_PT_Ngoai.Location = New System.Drawing.Point(625, 110)
        Me.TxtPT_PT_Ngoai.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPT_PT_Ngoai.MaxWholeDigits = 17
        Me.TxtPT_PT_Ngoai.Name = "TxtPT_PT_Ngoai"
        Me.TxtPT_PT_Ngoai.RangeMax = 1.7976931348623157E+308R
        Me.TxtPT_PT_Ngoai.RangeMin = -1.7976931348623157E+308R
        Me.TxtPT_PT_Ngoai.Size = New System.Drawing.Size(199, 24)
        Me.TxtPT_PT_Ngoai.TabIndex = 5
        Me.TxtPT_PT_Ngoai.Text = "0.00"
        Me.TxtPT_PT_Ngoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 109)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(275, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Tag = "Comission Genuine parts(%)"
        Me.Label2.Text = "Hoa hồng phụ tùng hãng(%)"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(420, 108)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(275, 25)
        Me.Label3.TabIndex = 421
        Me.Label3.Tag = "Comission non-genuine parts(%)"
        Me.Label3.Text = "Hoa hồng phụ tùng ngoài(%)"
        '
        'TxtPT_Nhan_Cong_Ngoai
        '
        Me.TxtPT_Nhan_Cong_Ngoai.AllowNegative = True
        Me.TxtPT_Nhan_Cong_Ngoai.Flags = 7680
        Me.TxtPT_Nhan_Cong_Ngoai.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPT_Nhan_Cong_Ngoai.ForeColor = System.Drawing.Color.Navy
        Me.TxtPT_Nhan_Cong_Ngoai.InputMask = "### ### ### ### ###.##"
        Me.TxtPT_Nhan_Cong_Ngoai.Location = New System.Drawing.Point(625, 81)
        Me.TxtPT_Nhan_Cong_Ngoai.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPT_Nhan_Cong_Ngoai.MaxWholeDigits = 17
        Me.TxtPT_Nhan_Cong_Ngoai.Name = "TxtPT_Nhan_Cong_Ngoai"
        Me.TxtPT_Nhan_Cong_Ngoai.RangeMax = 1.7976931348623157E+308R
        Me.TxtPT_Nhan_Cong_Ngoai.RangeMin = -1.7976931348623157E+308R
        Me.TxtPT_Nhan_Cong_Ngoai.Size = New System.Drawing.Size(199, 24)
        Me.TxtPT_Nhan_Cong_Ngoai.TabIndex = 4
        Me.TxtPT_Nhan_Cong_Ngoai.Text = "0.00"
        Me.TxtPT_Nhan_Cong_Ngoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(420, 81)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 25)
        Me.Label1.TabIndex = 423
        Me.Label1.Tag = "Saler non-Honda comission(%)"
        Me.Label1.Text = "Hoa hồng nhân công ngoài(%)"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 139)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 25)
        Me.Label4.TabIndex = 424
        Me.Label4.Tag = "Note"
        Me.Label4.Text = "Ghi chú"
        '
        'TxtGhi_Chu
        '
        Me.TxtGhi_Chu.Location = New System.Drawing.Point(211, 141)
        Me.TxtGhi_Chu.Name = "TxtGhi_Chu"
        Me.TxtGhi_Chu.Size = New System.Drawing.Size(613, 24)
        Me.TxtGhi_Chu.TabIndex = 6
        '
        'DMCSCKBH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(831, 231)
        Me.Controls.Add(Me.TxtGhi_Chu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtPT_Nhan_Cong_Ngoai)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtPT_PT_Ngoai)
        Me.Controls.Add(Me.TxtPT_PT_Hang)
        Me.Controls.Add(Me.TxtPT_Nhan_Cong_Hang)
        Me.Controls.Add(Me.LabGia_nt2)
        Me.Controls.Add(Me.TxtNgay_HL)
        Me.Controls.Add(Me.LabNgay_HL)
        Me.Controls.Add(Me.TxtTen_BH)
        Me.Controls.Add(Me.TxtMa_BH)
        Me.Controls.Add(Me.LabMa_bh)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "DMCSCKBH"
        Me.Text = "Chính sách hoa hồng bảo hiểm"
        Me.Controls.SetChildIndex(Me.LabMa_bh, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_BH, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_BH, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_HL, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_HL, 0)
        Me.Controls.SetChildIndex(Me.LabGia_nt2, 0)
        Me.Controls.SetChildIndex(Me.TxtPT_Nhan_Cong_Hang, 0)
        Me.Controls.SetChildIndex(Me.TxtPT_PT_Hang, 0)
        Me.Controls.SetChildIndex(Me.TxtPT_PT_Ngoai, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtPT_Nhan_Cong_Ngoai, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtGhi_Chu, 0)
        CType(Me.TxtMa_BH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_bh As System.Windows.Forms.Label
    Friend WithEvents TxtTen_BH As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_BH As Cyber.SmLists.TxtLookup
    Friend WithEvents LabNgay_HL As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_HL As ClsTextBox.txtDate1
    Friend WithEvents TxtPT_Nhan_Cong_Hang As ClsTextBox.txtTy_Gia
    Friend WithEvents TxtPT_PT_Hang As ClsTextBox.txtTy_Gia
    Friend WithEvents LabGia_nt2 As System.Windows.Forms.Label
    Friend WithEvents TxtPT_PT_Ngoai As ClsTextBox.txtTy_Gia
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtPT_Nhan_Cong_Ngoai As ClsTextBox.txtTy_Gia
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtGhi_Chu As System.Windows.Forms.TextBox

End Class
