<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQLThongTinXeDV
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
        Me.PanM_Title = New System.Windows.Forms.Panel()
        Me.LblM_Title = New System.Windows.Forms.Label()
        Me.PanM_Timer = New System.Windows.Forms.Panel()
        Me.LblM_Timer = New System.Windows.Forms.Label()
        Me.PanM_Pic = New System.Windows.Forms.Panel()
        Me.PanM_Footer = New System.Windows.Forms.Panel()
        Me.LblM_Footer = New System.Windows.Forms.Label()
        Me.PanM_Main = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer()
        Me.Timer2 = New System.Windows.Forms.Timer()
        Me.PanM_GridviewHeader = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanM_Title.SuspendLayout()
        Me.PanM_Timer.SuspendLayout()
        Me.PanM_Footer.SuspendLayout()
        Me.PanM_GridviewHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(-10, 533)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1023, 8)
        Me.GroupBoxLine.Visible = False
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(813, 511)
        Me.ButtOK.Visible = False
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(915, 511)
        Me.ButtExit.Visible = False
        '
        'PanM_Title
        '
        Me.PanM_Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanM_Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanM_Title.Controls.Add(Me.LblM_Title)
        Me.PanM_Title.Controls.Add(Me.PanM_Timer)
        Me.PanM_Title.Controls.Add(Me.PanM_Pic)
        Me.PanM_Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanM_Title.Location = New System.Drawing.Point(0, 0)
        Me.PanM_Title.Name = "PanM_Title"
        Me.PanM_Title.Size = New System.Drawing.Size(1027, 105)
        Me.PanM_Title.TabIndex = 45
        '
        'LblM_Title
        '
        Me.LblM_Title.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LblM_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblM_Title.ForeColor = System.Drawing.Color.White
        Me.LblM_Title.Location = New System.Drawing.Point(0, 0)
        Me.LblM_Title.Name = "LblM_Title"
        Me.LblM_Title.Size = New System.Drawing.Size(902, 105)
        Me.LblM_Title.TabIndex = 1
        Me.LblM_Title.Text = "DISPLAY SERVICE ORDER ON TV"
        Me.LblM_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanM_Timer
        '
        Me.PanM_Timer.Controls.Add(Me.LblM_Timer)
        Me.PanM_Timer.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanM_Timer.Location = New System.Drawing.Point(902, 0)
        Me.PanM_Timer.Name = "PanM_Timer"
        Me.PanM_Timer.Size = New System.Drawing.Size(125, 105)
        Me.PanM_Timer.TabIndex = 1
        '
        'LblM_Timer
        '
        Me.LblM_Timer.Dock = System.Windows.Forms.DockStyle.Right
        Me.LblM_Timer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.LblM_Timer.ForeColor = System.Drawing.Color.White
        Me.LblM_Timer.Location = New System.Drawing.Point(0, 0)
        Me.LblM_Timer.Name = "LblM_Timer"
        Me.LblM_Timer.Size = New System.Drawing.Size(125, 105)
        Me.LblM_Timer.TabIndex = 2
        Me.LblM_Timer.Text = "09:53:12"
        Me.LblM_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanM_Pic
        '
        Me.PanM_Pic.Location = New System.Drawing.Point(0, 0)
        Me.PanM_Pic.Name = "PanM_Pic"
        Me.PanM_Pic.Size = New System.Drawing.Size(10, 105)
        Me.PanM_Pic.TabIndex = 0
        '
        'PanM_Footer
        '
        Me.PanM_Footer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanM_Footer.Controls.Add(Me.LblM_Footer)
        Me.PanM_Footer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanM_Footer.Location = New System.Drawing.Point(0, 438)
        Me.PanM_Footer.Name = "PanM_Footer"
        Me.PanM_Footer.Size = New System.Drawing.Size(1027, 37)
        Me.PanM_Footer.TabIndex = 46
        '
        'LblM_Footer
        '
        Me.LblM_Footer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblM_Footer.ForeColor = System.Drawing.Color.Navy
        Me.LblM_Footer.Location = New System.Drawing.Point(3, 6)
        Me.LblM_Footer.Name = "LblM_Footer"
        Me.LblM_Footer.Size = New System.Drawing.Size(1019, 30)
        Me.LblM_Footer.TabIndex = 0
        Me.LblM_Footer.Text = "HONDA THÁI NGUYÊN KÍNH CHÀO QUÝ KHÁCH"
        Me.LblM_Footer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanM_Main
        '
        Me.PanM_Main.BackColor = System.Drawing.Color.Silver
        Me.PanM_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanM_Main.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanM_Main.ForeColor = System.Drawing.Color.Black
        Me.PanM_Main.Location = New System.Drawing.Point(0, 174)
        Me.PanM_Main.Name = "PanM_Main"
        Me.PanM_Main.Size = New System.Drawing.Size(1027, 264)
        Me.PanM_Main.TabIndex = 48
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'PanM_GridviewHeader
        '
        Me.PanM_GridviewHeader.BackColor = System.Drawing.Color.Silver
        Me.PanM_GridviewHeader.Controls.Add(Me.Panel1)
        Me.PanM_GridviewHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanM_GridviewHeader.ForeColor = System.Drawing.Color.Black
        Me.PanM_GridviewHeader.Location = New System.Drawing.Point(0, 105)
        Me.PanM_GridviewHeader.Name = "PanM_GridviewHeader"
        Me.PanM_GridviewHeader.Size = New System.Drawing.Size(1027, 69)
        Me.PanM_GridviewHeader.TabIndex = 49
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 68)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1027, 1)
        Me.Panel1.TabIndex = 50
        '
        'FrmQLThongTinXeDV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1027, 497)
        Me.Controls.Add(Me.PanM_Main)
        Me.Controls.Add(Me.PanM_GridviewHeader)
        Me.Controls.Add(Me.PanM_Footer)
        Me.Controls.Add(Me.PanM_Title)
        Me.Name = "FrmQLThongTinXeDV"
        Me.Controls.SetChildIndex(Me.PanM_Title, 0)
        Me.Controls.SetChildIndex(Me.PanM_Footer, 0)
        Me.Controls.SetChildIndex(Me.PanM_GridviewHeader, 0)
        Me.Controls.SetChildIndex(Me.PanM_Main, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.PanM_Title.ResumeLayout(False)
        Me.PanM_Timer.ResumeLayout(False)
        Me.PanM_Footer.ResumeLayout(False)
        Me.PanM_GridviewHeader.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanM_Title As System.Windows.Forms.Panel
    Friend WithEvents PanM_Footer As System.Windows.Forms.Panel
    Friend WithEvents LblM_Footer As System.Windows.Forms.Label
    Friend WithEvents PanM_Main As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PanM_Timer As System.Windows.Forms.Panel
    Friend WithEvents PanM_Pic As System.Windows.Forms.Panel
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents PanM_GridviewHeader As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LblM_Title As System.Windows.Forms.Label
    Friend WithEvents LblM_Timer As System.Windows.Forms.Label

End Class
