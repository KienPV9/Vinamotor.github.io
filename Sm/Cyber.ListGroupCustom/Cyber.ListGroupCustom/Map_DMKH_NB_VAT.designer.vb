<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Map_DMKH_NB_VAT
    Inherits Cyber.From.FrmList

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
        Me.LabMa_Nh1 = New System.Windows.Forms.Label()
        Me.TxtTen_KH_NB = New System.Windows.Forms.TextBox()
        Me.TxtMa_KH_NB = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_KH_VAT = New System.Windows.Forms.TextBox()
        Me.TxtMa_KH_VAT = New Cyber.SmLists.TxtLookup()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_KH_NB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_KH_VAT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(682, 109)
        Me.ButtExit.TabIndex = 11
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(580, 109)
        Me.ButtOK.TabIndex = 10
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(474, 115)
        Me.TxtMa_Dvcs.TabIndex = 10
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 119)
        Me.ChkActi.TabIndex = 9
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 99)
        Me.GroupBoxLine.TabIndex = 8
        '
        'LabMa_Nh1
        '
        Me.LabMa_Nh1.Location = New System.Drawing.Point(-2, 4)
        Me.LabMa_Nh1.Name = "LabMa_Nh1"
        Me.LabMa_Nh1.Size = New System.Drawing.Size(107, 15)
        Me.LabMa_Nh1.TabIndex = 24
        Me.LabMa_Nh1.Tag = "Group 1"
        Me.LabMa_Nh1.Text = "Đối tượng nội bộ"
        '
        'TxtTen_KH_NB
        '
        Me.TxtTen_KH_NB.BackColor = System.Drawing.Color.White
        Me.TxtTen_KH_NB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_KH_NB.Enabled = False
        Me.TxtTen_KH_NB.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_KH_NB.Location = New System.Drawing.Point(263, 6)
        Me.TxtTen_KH_NB.Name = "TxtTen_KH_NB"
        Me.TxtTen_KH_NB.ReadOnly = True
        Me.TxtTen_KH_NB.Size = New System.Drawing.Size(519, 14)
        Me.TxtTen_KH_NB.TabIndex = 23
        Me.TxtTen_KH_NB.TabStop = False
        '
        'TxtMa_KH_NB
        '
        Me.TxtMa_KH_NB._ActilookupPopup = False
        Me.TxtMa_KH_NB.CyberActilookupPopup = True
        Me.TxtMa_KH_NB.Dv_ListDetail = Nothing
        Me.TxtMa_KH_NB.Dv_Master = Nothing
        Me.TxtMa_KH_NB.FilterClient = ""
        Me.TxtMa_KH_NB.FilterSQL = ""
        Me.TxtMa_KH_NB.Location = New System.Drawing.Point(110, 4)
        Me.TxtMa_KH_NB.Name = "TxtMa_KH_NB"
        Me.TxtMa_KH_NB.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_KH_NB.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_KH_NB.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_KH_NB.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_KH_NB.TabIndex = 0
        Me.TxtMa_KH_NB.Table_Name = ""
        '
        'TxtTen_KH_VAT
        '
        Me.TxtTen_KH_VAT.BackColor = System.Drawing.Color.White
        Me.TxtTen_KH_VAT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_KH_VAT.Enabled = False
        Me.TxtTen_KH_VAT.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_KH_VAT.Location = New System.Drawing.Point(263, 32)
        Me.TxtTen_KH_VAT.Name = "TxtTen_KH_VAT"
        Me.TxtTen_KH_VAT.ReadOnly = True
        Me.TxtTen_KH_VAT.Size = New System.Drawing.Size(519, 14)
        Me.TxtTen_KH_VAT.TabIndex = 26
        Me.TxtTen_KH_VAT.TabStop = False
        '
        'TxtMa_KH_VAT
        '
        Me.TxtMa_KH_VAT._ActilookupPopup = False
        Me.TxtMa_KH_VAT.CyberActilookupPopup = True
        Me.TxtMa_KH_VAT.Dv_ListDetail = Nothing
        Me.TxtMa_KH_VAT.Dv_Master = Nothing
        Me.TxtMa_KH_VAT.FilterClient = ""
        Me.TxtMa_KH_VAT.FilterSQL = ""
        Me.TxtMa_KH_VAT.Location = New System.Drawing.Point(110, 30)
        Me.TxtMa_KH_VAT.Name = "TxtMa_KH_VAT"
        Me.TxtMa_KH_VAT.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_KH_VAT.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_KH_VAT.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_KH_VAT.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_KH_VAT.TabIndex = 1
        Me.TxtMa_KH_VAT.Table_Name = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(-2, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 15)
        Me.Label1.TabIndex = 27
        Me.Label1.Tag = "Group 2"
        Me.Label1.Text = "Đối tượng bản thuế"
        '
        'Map_DMKH_NB_VAT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(784, 142)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTen_KH_VAT)
        Me.Controls.Add(Me.TxtMa_KH_VAT)
        Me.Controls.Add(Me.LabMa_Nh1)
        Me.Controls.Add(Me.TxtTen_KH_NB)
        Me.Controls.Add(Me.TxtMa_KH_NB)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "Map_DMKH_NB_VAT"
        Me.Text = "Danh mục bảo hiểm"
        Me.Controls.SetChildIndex(Me.TxtMa_KH_NB, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_KH_NB, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Nh1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_KH_VAT, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_KH_VAT, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        CType(Me.TxtMa_KH_NB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_KH_VAT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_Nh1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_KH_NB As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_KH_NB As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_KH_VAT As Windows.Forms.TextBox
    Friend WithEvents TxtMa_KH_VAT As SmLists.TxtLookup
    Friend WithEvents Label1 As Windows.Forms.Label
End Class
