Imports System.Windows.Forms
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Drawing
Imports System.Threading
Imports DevExpress.XtraGrid.Columns
Public Class FrmQLThongTinXeDV
    Dim M_Cp_Name As String
    Dim DsData As New DataSet
    Dim ListProperTy As New Dictionary(Of String, DataRow)
    Dim ListGridView As New List(Of GridControl)
    Dim ListMasterData As New List(Of DataTable)
    Dim ListMasterDataTmp As New List(Of DataTable)
    Dim ListMasterDataCopyTmp As New List(Of DataTable)
    Dim ListProcedure As New List(Of String)
    Dim ListTimeRun As New List(Of DateTime)
    Dim ListPanHeader As New List(Of Panel)
    Dim CountRow As Integer
    Dim M_Timer_Delay As Integer
    Dim M_CountGridView As Integer
    Dim M_Timer_QuerySQL As Integer
    Private Sub FrmQLThongTinXeXuatBen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Dim iMonitor As Integer = -1
        'iMonitor = Screen.AllScreens.Length

        'If iMonitor > 1 Then
        '    Dim newLocation = Screen.AllScreens(1).Bounds.Location
        '    newLocation.Offset(100, 100) ' adjust as needed
        '    Me.Location = newLocation
        '    ' Also see Me.Size and Me.Bounds
        'End If
        Me.StatusFooter1.Visible = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        V_Load()
        V_Addhandler()
        For iGrid As Integer = 0 To M_CountGridView - 1
            Dim _Grid As GridControl = ListGridView(iGrid)
            Dim _GridView As GridView = _Grid.MainView
            _GridView.RowHeight = (_Grid.Height) / CountRow
            StatusFooter1.Visible = False
            StatusFooter2.Visible = False
        Next

    End Sub
#Region "Load"
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        M_Cp_Name = Para(M_VT_PARA + 1)
        '----------------------------
    End Sub
    Private Sub V_Addhandler()
        AddHandler Timer1.Tick, AddressOf V_TimeRun
        AddHandler Timer2.Tick, AddressOf V_TimeDongHo
    End Sub
    Private Sub V_Load()
        V_LoadProperty()
        V_CreateGridView()
        V_AddMenuContext()
    End Sub
    Public Sub V_AddMenuContext()
        Dim mnItems As New ContextMenu
        Dim mnItemsAdd As New MenuItem(IIf(M_LAN = "V", "Refresh", "Refresh"), AddressOf V_ReFresh, Shortcut.F4)
        Dim mnItemsMini As New MenuItem(IIf(M_LAN = "V", "Thu nhỏ", "MiniSize"), AddressOf V_Mini, Shortcut.F6)
        Dim mnItemsClose As New MenuItem(IIf(M_LAN = "V", "Đóng", "Close"), AddressOf V_Close, Shortcut.F8)
        Dim mnItemsShow As New MenuItem(IIf(M_LAN = "V", "Hiển thị TV", "Show"), AddressOf lblChuyenSangManTV_Click, Shortcut.F9)
        mnItems.MenuItems.Add(mnItemsAdd)
        mnItems.MenuItems.Add(mnItemsMini)
        mnItems.MenuItems.Add(mnItemsShow)
        mnItems.MenuItems.Add(mnItemsClose)

        Me.ContextMenu = mnItems
    End Sub
#End Region
#Region "Tao Doi tuong"
    Public Sub V_SetPropertyControl(ByVal _Ctr As Control)
        For Each _CtrChil As Control In _Ctr.Controls
            Select Case _CtrChil.GetType.Name.ToString.Trim.ToUpper
                Case "Label".ToString.Trim.ToUpper
                    If _CtrChil.Name.Length < 4 Then Continue For
                    If Not ListProperTy.ContainsKey(_CtrChil.Name.Substring(3)) Then Continue For
                    Dim Lbl As Label = _CtrChil
                    Dim Name As String = Lbl.Name.Substring(3)
                    Dim Dr As DataRow = ListProperTy(Name)

                    Dim Font_name As String = Dr("Font_Name")
                    Dim Font_Size As Integer = IIf(Not IsNumeric(Dr("Font_Size")), Lbl.Font.Size, Dr("Font_Size"))
                    Dim Font_slyle As System.Drawing.FontStyle
                    Dim TextAlign As System.Drawing.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft

                    If Dr("Txt_Align").ToString.Trim.ToUpper = "TopLeft".ToUpper Then TextAlign = System.Drawing.ContentAlignment.TopLeft
                    If Dr("Txt_Align").ToString.Trim.ToUpper = "TopCenter".ToUpper Then TextAlign = System.Drawing.ContentAlignment.TopCenter
                    If Dr("Txt_Align").ToString.Trim.ToUpper = "TopRight".ToUpper Then TextAlign = System.Drawing.ContentAlignment.TopRight
                    If Dr("Txt_Align").ToString.Trim.ToUpper = "MiddleLeft".ToUpper Then TextAlign = System.Drawing.ContentAlignment.MiddleLeft
                    If Dr("Txt_Align").ToString.Trim.ToUpper = "MiddleCenter".ToUpper Then TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                    If Dr("Txt_Align").ToString.Trim.ToUpper = "MiddleRight".ToUpper Then TextAlign = System.Drawing.ContentAlignment.MiddleRight
                    If Dr("Txt_Align").ToString.Trim.ToUpper = "BottomLeft".ToUpper Then TextAlign = System.Drawing.ContentAlignment.BottomLeft
                    If Dr("Txt_Align").ToString.Trim.ToUpper = "BottomCenter".ToUpper Then TextAlign = System.Drawing.ContentAlignment.BottomCenter
                    If Dr("Txt_Align").ToString.Trim.ToUpper = "BottomRight".ToUpper Then TextAlign = System.Drawing.ContentAlignment.BottomRight

                    If Dr("Font_Style").ToString.Trim.ToUpper = "BOLD".ToUpper Then Font_slyle = System.Drawing.FontStyle.Bold
                    If Dr("Font_Style").ToString.Trim.ToUpper = "Italic".ToUpper Then Font_slyle = System.Drawing.FontStyle.Italic
                    If Dr("Font_Style").ToString.Trim.ToUpper = "Regular".ToUpper Then Font_slyle = System.Drawing.FontStyle.Regular
                    If Dr("Font_Style").ToString.Trim.ToUpper = "Strikeout".ToUpper Then Font_slyle = System.Drawing.FontStyle.Strikeout
                    If Dr("Font_Style").ToString.Trim.ToUpper = "Underline".ToUpper Then Font_slyle = System.Drawing.FontStyle.Underline

                    Dim FontStyles As New System.Drawing.Font(Font_name, Font_Size, Font_slyle)
                    Lbl.Text = Dr("M_Value").ToString().Trim
                    Lbl.Font = FontStyles
                    Lbl.Width = Dr("Width")
                    Lbl.Height = Dr("Height")

                    Lbl.ForeColor = V_GetColor(Dr("Font_Color"))
                    Lbl.BackColor = V_GetColor(Dr("BackColor"))
                    Lbl.TextAlign = TextAlign
                Case "Panel".ToString.Trim.ToUpper
                    If _CtrChil.Controls.Count > 0 Then V_SetPropertyControl(_CtrChil)
                    If _CtrChil.Name.Length < 4 Then Continue For
                    If Not ListProperTy.ContainsKey(_CtrChil.Name.Substring(3)) Then Continue For
                    Dim Lbl As Panel = _CtrChil
                    Dim Name As String = Lbl.Name.Substring(3)
                    Dim Dr As DataRow = ListProperTy(Name)

                    Dim Font_name As String = Dr("Font_Name")
                    Dim Font_Size As Integer = IIf(Not IsNumeric(Dr("Font_Size")), Lbl.Font.Size, Dr("Font_Size"))
                    Dim Font_slyle As System.Drawing.FontStyle

                    If Dr("Font_Style").ToString.Trim.ToUpper = "BOLD".ToUpper Then Font_slyle = System.Drawing.FontStyle.Bold
                    If Dr("Font_Style").ToString.Trim.ToUpper = "Italic".ToUpper Then Font_slyle = System.Drawing.FontStyle.Italic
                    If Dr("Font_Style").ToString.Trim.ToUpper = "Regular".ToUpper Then Font_slyle = System.Drawing.FontStyle.Regular
                    If Dr("Font_Style").ToString.Trim.ToUpper = "Strikeout".ToUpper Then Font_slyle = System.Drawing.FontStyle.Strikeout
                    If Dr("Font_Style").ToString.Trim.ToUpper = "Underline".ToUpper Then Font_slyle = System.Drawing.FontStyle.Underline

                    Dim FontStyles As New System.Drawing.Font(Font_name, Font_Size, Font_slyle)
                    Lbl.Text = Dr("M_Value").ToString().Trim
                    Lbl.Font = FontStyles
                    Lbl.Width = Dr("Width")
                    Lbl.Height = Dr("Height")

                    Lbl.ForeColor = V_GetColor(Dr("Font_Color"))
                    Lbl.BackColor = V_GetColor(Dr("BackColor"))
            End Select
        Next

    End Sub
    Private Sub V_LoadProperty()
        DsData = CyberSmlib.SQLExcuteStoreProcedure(AppConn, M_Cp_Name, M_Ma_Dvcs & "#" & M_User_Name)
        Dim M_Name As String = ""
        ListProperTy.Clear()
        For Each dr As DataRow In DsData.Tables(0).Rows
            M_Name = dr("M_Name")
            If ListProperTy.ContainsKey(M_Name) Then Continue For
            ListProperTy.Add(M_Name, dr)
        Next
        Me.BackColor = System.Drawing.Color.White
        If ListProperTy.ContainsKey("M_Form") Then
            If ListProperTy("M_Form")("BackColor").ToString.Trim <> "" Then
                Me.BackColor = V_GetColor(ListProperTy("M_Form")("BackColor"))
            End If
        End If
        V_SetPropertyControl(Me)
        If ListProperTy.ContainsKey("M_CountGridView") Then M_CountGridView = ListProperTy("M_CountGridView")("M_Value") Else M_CountGridView = 0
        If ListProperTy.ContainsKey("M_CountRow") Then CountRow = ListProperTy("M_CountRow")("M_Value") Else CountRow = 0
        If ListProperTy.ContainsKey("M_Timer_Delay") Then M_Timer_Delay = ListProperTy("M_Timer_Delay")("M_Value") Else M_Timer_Delay = 20
        If ListProperTy.ContainsKey("M_Timer_QuerySQL") Then M_Timer_QuerySQL = ListProperTy("M_Timer_QuerySQL")("M_Value") Else M_Timer_Delay = 120
        Timer1.Interval = M_Timer_Delay * 1000

        Try
            ListProcedure.Clear()
            ListPanHeader.Clear()
            For i As Integer = 0 To M_CountGridView - 1
                ListProcedure.Add(Para(M_VT_PARA + 2 + i))

            Next
        Catch ex As Exception
            MsgBox("Khai báo có " & M_CountGridView & " Bảng(Gridview) nhưng khai báo(menu chương trình) thủ tục không đủ " & M_CountGridView & " Procedure để chạy chương trình ")
            Me.Close()
        End Try
    End Sub
    Private Sub V_CreateGridView()
        ListGridView.Clear()
        ListMasterData.Clear()
        ListMasterDataTmp.Clear()
        ListMasterDataCopyTmp.Clear()
        PanM_GridviewHeader.Controls.Clear()
        PanM_Main.Controls.Clear()
        For i As Integer = 0 To M_CountGridView - 1
            Dim _Grid01 As New GridControl
            If i = M_CountGridView - 1 Then
                _Grid01.Dock = DockStyle.Fill
            Else
                _Grid01.Dock = DockStyle.Left
                If ListProperTy.ContainsKey("M_Gridview" + Strings.Right("00" & (i + 1), 2)) Then _Grid01.Width = ListProperTy("M_Gridview" + Strings.Right("00" & (i + 1), 2))("Width")
            End If
            PanM_Main.Controls.Add(_Grid01)
            _Grid01.BringToFront()
            ListGridView.Add(_Grid01)

            Dim PanM_GridviewHeaderTmp As New Panel
            PanM_GridviewHeaderTmp.Dock = DockStyle.Left
            If _Grid01.Dock = DockStyle.Fill Then PanM_GridviewHeaderTmp.Dock = DockStyle.Fill Else PanM_GridviewHeaderTmp.Width = _Grid01.Width
            PanM_GridviewHeader.Controls.Add(PanM_GridviewHeaderTmp)
            PanM_GridviewHeaderTmp.BringToFront()
            ListPanHeader.Add(PanM_GridviewHeaderTmp)
            V_Loaddatabases(i, "1")
        Next
    End Sub
    Public Sub V_Loaddatabases(ByVal iGridview As Integer, ByVal status As String)
        Dim M_Cp_NameGridview As String = ListProcedure(iGridview)

        Dim _Grid As GridControl = ListGridView(iGridview)
        Dim _GridView As New GridView
        Dim isLoad As Boolean = False
        Dim DsTmp As New DataSet
        DsTmp = CyberSmlib.SQLExcuteStoreProcedure(AppConn, M_Cp_NameGridview, status.Trim + "#" + M_Ma_Dvcs & "#" & M_User_Name)
        ' Tinh toan So Luong Ban Ghi
        Dim So_Du As Integer = DsTmp.Tables(0).Rows.Count Mod CountRow

        For i As Integer = 0 To CountRow - So_Du - 1
            Dim DrRow As DataRow = DsTmp.Tables(0).NewRow
            If DsTmp.Tables(0).Columns.Contains("BackColor") Then DrRow("BackColor") = "BLUE"
            DsTmp.Tables(0).Rows.Add(DrRow)
        Next

        If ListMasterData.Count < iGridview + 1 Then isLoad = True
        If isLoad Then
            Dim DrHeader As DataRow = Nothing
            Dim DrDetail As DataRow = Nothing

            Dim Font_NameDetail As String = "Tahoma"
            Dim Font_SizeDetail As Integer = 12
            Dim Font_StyleDetail As System.Drawing.FontStyle = System.Drawing.FontStyle.Regular

            If ListProperTy.ContainsKey("M_GridviewRow" + Strings.Right("00" & (iGridview + 1), 2)) Then
                DrDetail = ListProperTy("M_GridviewRow" + Strings.Right("00" & (iGridview + 1), 2))
                If DrDetail("Font_Name").ToString().Trim() <> "" Then Font_NameDetail = DrDetail("Font_Name").ToString().Trim()
                If DrDetail("Font_Size").ToString().Trim() <> "" Then Font_SizeDetail = DrDetail("Font_Size").ToString().Trim()
                If DrDetail("Font_Style").ToString().Trim().ToUpper = "Bold".ToUpper Then Font_StyleDetail = System.Drawing.FontStyle.Bold
                If DrDetail("Font_Style").ToString().Trim().ToUpper = "Italic".ToUpper Then Font_StyleDetail = System.Drawing.FontStyle.Italic
                If DrDetail("Font_Style").ToString().Trim().ToUpper = "Regular".ToUpper Then Font_StyleDetail = System.Drawing.FontStyle.Regular
                If DrDetail("Font_Style").ToString().Trim().ToUpper = "Strikeout".ToUpper Then Font_StyleDetail = System.Drawing.FontStyle.Strikeout
                If DrDetail("Font_Style").ToString().Trim().ToUpper = "Underline".ToUpper Then Font_StyleDetail = System.Drawing.FontStyle.Underline
            End If
            Dim DtHeader As New DataTable
            ListMasterData.Add(DsTmp.Tables(0).Clone)
            ListMasterDataTmp.Add(DsTmp.Tables(0).Clone)
            ListMasterDataCopyTmp.Add(DsTmp.Tables(0).Copy)
            ListTimeRun.Add(Now)
            DtHeader = DsTmp.Tables(1).Copy
            CyberFill.V_FillReports(_Grid.MainView, M_LAN, New DataView(DtHeader), New DataView(ListMasterData(iGridview)))

            _Grid.DataSource = ListMasterData(iGridview)
            _GridView = _Grid.MainView
            _GridView.OptionsView.ShowColumnHeaders = False
            _GridView.OptionsView.ShowGroupPanel = False
            _GridView.OptionsView.RowAutoHeight = False
            _GridView.OptionsView.ColumnAutoWidth = False
            _GridView.OptionsView.ShowIndicator = False

            _GridView.OptionsMenu.EnableColumnMenu = False
            Dim iLeft As Integer = 0
            Dim PanelHeader As Panel = ListPanHeader(iGridview)
            Dim LblHeader As New Label
            For Each ColReturn As GridColumn In _GridView.Columns
                If Not DtHeader.Columns.Contains("TextAglin") Then Continue For
                Dim dr() As DataRow = DtHeader.Select("Field_Name='" + ColReturn.FieldName + "'")
                If dr.Length < 1 Then Continue For
                ColReturn.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
                If dr(0)("TextAglin").ToString.Trim.ToUpper = "CENTER" Then ColReturn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                If dr(0)("TextAglin").ToString.Trim.ToUpper = "RIGHT" Then ColReturn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near

                ColReturn.OptionsColumn.AllowFocus = False

                LblHeader = New Label
                LblHeader.Top = 0
                LblHeader.Left = iLeft

                LblHeader.Width = ColReturn.Width
                LblHeader.Height = PanelHeader.Height
                LblHeader.AutoSize = False
                LblHeader.TextAlign = ContentAlignment.MiddleCenter
                LblHeader.Text = ColReturn.Caption
                LblHeader.Font = PanM_GridviewHeader.Font
                LblHeader.BackColor = PanelHeader.BackColor
                AddHandler LblHeader.Paint, AddressOf Set_BoderLabel

                PanelHeader.Controls.Add(LblHeader)
                iLeft += LblHeader.Width
            Next

            LblHeader.Width += 1
            _GridView.Appearance.Row.Font = New System.Drawing.Font(Font_NameDetail, Font_SizeDetail, Font_StyleDetail)
            _GridView.Appearance.Row.ForeColor = System.Drawing.Color.White

            _GridView.OptionsSelection.EnableAppearanceFocusedCell = False
            _GridView.OptionsSelection.EnableAppearanceFocusedRow = False
            _GridView.OptionsBehavior.Editable = False

            _GridView.RowHeight = (_Grid.Height) / CountRow
            _GridView.ScrollStyle = ScrollStyleFlags.None
            _GridView.HorzScrollVisibility = Views.Base.ScrollVisibility.Never
            _GridView.VertScrollVisibility = Views.Base.ScrollVisibility.Never
            _GridView.ScrollStyle = ScrollStyleFlags.None
            _GridView.Appearance.Empty.BackColor = System.Drawing.Color.White
            PanelHeader.BackColor = _GridView.Appearance.Empty.BackColor
            _GridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder

            RemoveHandler _GridView.RowCellStyle, AddressOf MasterGRV_RowCellStyle
            AddHandler _GridView.RowCellStyle, AddressOf MasterGRV_RowCellStyle

            V_SetDataToGrif(iGridview)
        Else
            ListTimeRun(iGridview) = Now
            ListMasterDataCopyTmp(iGridview) = DsTmp.Tables(0).Copy
        End If
    End Sub
    Private Sub V_SetDataToGrif(ByVal iGridView As Integer)
        If ListMasterDataTmp(iGridView).Rows.Count = 0 Then ListMasterDataTmp(iGridView) = ListMasterDataCopyTmp(iGridView).Copy
        ListMasterData(iGridView).Clear()
        For i As Integer = 0 To CountRow - 1
            If i >= ListMasterDataTmp(iGridView).Rows.Count Then Exit For
            ListMasterData(iGridView).ImportRow(ListMasterDataTmp(iGridView).Rows(i))
        Next

        For i As Integer = CountRow - 1 To 0 Step -1
            If i >= ListMasterDataTmp(iGridView).Rows.Count Then Continue For
            ListMasterDataTmp(iGridView).Rows.RemoveAt(i)
        Next

        If ListMasterDataTmp(iGridView).Rows.Count = 0 Then
            If DateDiff(DateInterval.Second, ListTimeRun(iGridView), Now) > M_Timer_QuerySQL Then V_Loaddatabases(iGridView, "0")
        End If
    End Sub
#End Region
#Region "Event"
    Private Function V_GetColor(ByVal _strColor As String) As System.Drawing.Color
        Try
            If _strColor.Contains(",") Then
                If _strColor.Split(",").Length >= 3 Then Return System.Drawing.Color.FromArgb(_strColor.Split(",")(0), _strColor.Split(",")(1), _strColor.Split(",")(2))
                If _strColor.Split(",").Length = 2 Then Return System.Drawing.Color.FromArgb(_strColor.Split(",")(0), _strColor.Split(",")(1), 0)
                If _strColor.Split(",").Length = 1 Then Return System.Drawing.Color.FromArgb(_strColor.Split(",")(0), 0, 0)
            Else
                Return System.Drawing.Color.FromName(_strColor)
            End If
        Catch ex As Exception
            Return System.Drawing.Color.White
        End Try
    End Function
    Private Sub V_ReFresh()
        V_LoadProperty()
        V_CreateGridView()
    End Sub
    Private Sub V_Close()
        Me.Close()
    End Sub
    Private Sub V_Mini()
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub MasterGRV_setHeader(ByVal sender As Object, ByVal e As ColumnHeaderCustomDrawEventArgs)
        If e.Column Is Nothing Then Return

        Dim _Rectangle As Rectangle = e.Bounds
        Dim brush = e.Cache.GetGradientBrush(_Rectangle, e.Appearance.BackColor, e.Appearance.BackColor, e.Column.AppearanceHeader.GradientMode)

        _Rectangle.Inflate(-1, -0.5)
        e.Graphics.FillRectangle(brush, _Rectangle)
        Dim brushForeColor As New SolidBrush(e.Appearance.BackColor2)
        e.Appearance.DrawString(e.Cache, e.Info.Caption, e.Info.CaptionRect, brushForeColor)
        'e.Handled = True
        'End If
    End Sub
    Private Sub MasterGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        Dim Dt_Master As New DataTable
        Dim vDt_Master As New DataView
        Dim Grid As New DevExpress.XtraGrid.Views.Grid.GridView
        Dim CyberColor As New Cyber.Color.Sys
        Grid = sender
        If Grid.DataSource.GetType.Name.Trim.ToUpper = "DATAVIEW" Then
            vDt_Master = Grid.DataSource
            Dt_Master = vDt_Master.Table
        Else
            Dt_Master = Grid.DataSource
        End If
        If Dt_Master.Columns.Contains("Bold") Then
            Dim _FieldBold As String = ""
            _FieldBold = Dt_Master.Columns("Bold").ColumnName
            Dim _categoryBold As String = Grid.GetRowCellDisplayText(e.RowHandle, _FieldBold).ToString.Trim.ToUpper

            If _categoryBold = "1" Or _categoryBold = "TRUE".ToUpper.Trim Or _categoryBold = "Checked".ToUpper.Trim Then e.Appearance.Font = New Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Bold)
        End If
        If Not sender.IsCellSelected(e.RowHandle, e.Column) Then
            If Dt_Master.Columns.Contains("BackColor") Then
                Dim _FieldBackColor As String = ""
                _FieldBackColor = Dt_Master.Columns("BackColor").ColumnName
                Dim _categoryBackColor As String = Grid.GetRowCellDisplayText(e.RowHandle, _FieldBackColor).ToString.Trim
                e.Appearance.BackColor = CyberColor.GetBacColorkReports(_categoryBackColor)
            End If
            If Dt_Master.Columns.Contains("BackColor2") Then
                Dim _FieldBackColor2 As String = ""
                _FieldBackColor2 = Dt_Master.Columns("BackColor2").ColumnName
                Dim _categoryBackColor2 As String = Grid.GetRowCellDisplayText(e.RowHandle, _FieldBackColor2).ToString.Trim
                e.Appearance.BackColor2 = CyberColor.GetBacColorkReports(_categoryBackColor2)
            End If

            If Dt_Master.Columns.Contains("ForeColor") Then
                Dim _FieldBackColor As String = ""
                _FieldBackColor = Dt_Master.Columns("ForeColor").ColumnName
                Dim _categoryBackColor As String = Grid.GetRowCellDisplayText(e.RowHandle, _FieldBackColor).ToString.Trim
                e.Appearance.ForeColor = CyberColor.GetBacColorkReports(_categoryBackColor)

            End If
        Else
            e.Appearance.BackColor = System.Drawing.Color.FromArgb(51, 153, 255)
            e.Appearance.ForeColor = System.Drawing.Color.White
        End If
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        Me.Close()
    End Sub
    Private Sub V_TimeRun(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For i As Integer = 0 To M_CountGridView - 1
            V_SetDataToGrif(i)
            Application.DoEvents()
        Next
    End Sub
    Private Sub V_TimeDongHo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LblM_Timer.Text = Now.ToString("HH:mm:ss")
        LblM_Footer.Left -= 10
        If LblM_Footer.Right < 0 Then LblM_Footer.Left = Me.Right
    End Sub
    Private Sub lblChuyenSangManTV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ShowOnMonitor(1)
    End Sub
    Private Sub ShowOnMonitor(ByVal showOnMonitor As Integer)
        Dim sc As Screen()
        sc = Screen.AllScreens
        If showOnMonitor >= sc.Length Then
            showOnMonitor = 0
            MessageBox.Show("Không tìm thấy thiết bị để hiện thị, vui lòng kiểm tra lại kết nối !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(sc(showOnMonitor).Bounds.Left, sc(showOnMonitor).Bounds.Top)
        ' If you intend the form to be maximized, change it to normal then maximized.
        Me.WindowState = FormWindowState.Normal
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.TopMost = True
    End Sub
#End Region
#Region "Set Boder"
    Private Sub Set_BoderLabel(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim cBorderColor_Left As System.Drawing.Color = System.Drawing.Color.Silver
        Dim iBorderWidth_Left As Integer = 1
        Dim iBorderStyle_Left As ButtonBorderStyle = ButtonBorderStyle.None

        Dim cBorderColor_Top As System.Drawing.Color = System.Drawing.Color.Silver
        Dim iBorderWidth_Top As Integer = 1
        Dim iBorderStyle_Top As ButtonBorderStyle = ButtonBorderStyle.Solid

        Dim cBorderColor_Right As System.Drawing.Color = System.Drawing.Color.Silver
        Dim iBorderWidth_Right As Integer = 1
        Dim iBorderStyle_Right As ButtonBorderStyle = ButtonBorderStyle.Solid

        Dim cBorderColor_bottom As System.Drawing.Color = System.Drawing.Color.Silver
        Dim iBorderWidth_bottom As Integer = 1
        Dim iBorderStyle_bottom As ButtonBorderStyle = ButtonBorderStyle.Solid

        ControlPaint.DrawBorder(e.Graphics, sender.ClientRectangle, _
                                cBorderColor_Left, iBorderWidth_Left, iBorderStyle_Left, _
                                cBorderColor_Top, iBorderWidth_Top, iBorderStyle_Top, _
                                cBorderColor_Right, iBorderWidth_Right, iBorderStyle_Right, _
                                cBorderColor_bottom, iBorderWidth_bottom, iBorderStyle_bottom)

    End Sub
#End Region


End Class