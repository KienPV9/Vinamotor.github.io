<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TH_KPIQ
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
        Me.LabM_month1 = New System.Windows.Forms.Label()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.CbbM_Quy = New System.Windows.Forms.ComboBox()
        Me.CbbM_Nam = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtMa_hs = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_hs = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_hs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(486, 116)
        Me.ButtExit.TabIndex = 7
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(95, 79)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(491, 21)
        Me.CBBMa_Dvcs.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 82)
        Me.Label1.TabIndex = 22
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(380, 116)
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(10, 60)
        Me.LabLoai_NT.TabIndex = 21
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(95, 57)
        Me.ChkVND.TabIndex = 11
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(219, 57)
        Me.ChkNT.TabIndex = 12
        '
        'LabM_month1
        '
        Me.LabM_month1.AutoSize = True
        Me.LabM_month1.Location = New System.Drawing.Point(10, 14)
        Me.LabM_month1.Name = "LabM_month1"
        Me.LabM_month1.Size = New System.Drawing.Size(27, 13)
        Me.LabM_month1.TabIndex = 16
        Me.LabM_month1.Tag = "Month from"
        Me.LabM_month1.Text = "Quý"
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 101)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(586, 9)
        Me.GroupBoxLine.TabIndex = 23
        Me.GroupBoxLine.TabStop = False
        '
        'CbbM_Quy
        '
        Me.CbbM_Quy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Quy.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Quy.FormattingEnabled = True
        Me.CbbM_Quy.Location = New System.Drawing.Point(95, 9)
        Me.CbbM_Quy.Name = "CbbM_Quy"
        Me.CbbM_Quy.Size = New System.Drawing.Size(104, 21)
        Me.CbbM_Quy.TabIndex = 0
        '
        'CbbM_Nam
        '
        Me.CbbM_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Nam.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Nam.FormattingEnabled = True
        Me.CbbM_Nam.Location = New System.Drawing.Point(281, 9)
        Me.CbbM_Nam.Name = "CbbM_Nam"
        Me.CbbM_Nam.Size = New System.Drawing.Size(95, 21)
        Me.CbbM_Nam.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(233, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Tag = "Year"
        Me.Label2.Text = "Năm"
        '
        'TxtMa_hs
        '
        Me.TxtMa_hs._ActilookupPopup = False
        Me.TxtMa_hs.CyberActilookupPopup = True
        Me.TxtMa_hs.Dv_ListDetail = Nothing
        Me.TxtMa_hs.Dv_Master = Nothing
        Me.TxtMa_hs.FilterClient = ""
        Me.TxtMa_hs.FilterSQL = ""
        Me.TxtMa_hs.Location = New System.Drawing.Point(95, 32)
        Me.TxtMa_hs.Name = "TxtMa_hs"
        Me.TxtMa_hs.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_hs.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_hs.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_hs.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_hs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_hs.Size = New System.Drawing.Size(104, 20)
        Me.TxtMa_hs.TabIndex = 2
        Me.TxtMa_hs.Table_Name = ""
        '
        'TxtTen_hs
        '
        Me.TxtTen_hs.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_hs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_hs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_hs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_hs.Location = New System.Drawing.Point(204, 36)
        Me.TxtTen_hs.Name = "TxtTen_hs"
        Me.TxtTen_hs.ReadOnly = True
        Me.TxtTen_hs.Size = New System.Drawing.Size(385, 13)
        Me.TxtTen_hs.TabIndex = 8
        Me.TxtTen_hs.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Tag = "Sale"
        Me.Label5.Text = "Mã nhân viên"
        '
        'TH_KPIQ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(593, 171)
        Me.Controls.Add(Me.TxtMa_hs)
        Me.Controls.Add(Me.TxtTen_hs)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CbbM_Nam)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbbM_Quy)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_month1)
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "TH_KPIQ"
        Me.Controls.SetChildIndex(Me.LabM_month1, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Quy, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Nam, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_hs, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_hs, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        CType(Me.TxtMa_hs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabM_month1 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents CbbM_Quy As System.Windows.Forms.ComboBox
    Friend WithEvents CbbM_Nam As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_hs As SmLists.TxtLookup
    Friend WithEvents TxtTen_hs As TextBox
    Friend WithEvents Label5 As Label
End Class
