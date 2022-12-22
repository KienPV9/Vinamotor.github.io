Imports System.Windows.Forms

Public Class FrmPhanQuyen
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim Dt_Head_HisLogin, Dt_Data_HisLogin, Dt_Head_HisVoucher, Dt_Data_HisVoucher, Dt_Head_HisSmList, Dt_Data_HisSmList, Dt_Head_HisReport, Dt_Data_HisReport As DataTable
    Dim Dv_Head_HisLogin, Dv_Data_HisLogin, Dv_Head_HisVoucher, Dv_Data_HisVoucher, Dv_Head_HisSmList, Dv_Data_HisSmList, Dv_Head_HisReport, Dv_Data_HisReport As DataView
    Dim M_Add_Title As String = ""
    Dim osysvar As Collection
    Dim M_Para As String() = Me.Para
    Dim Dt_Head1, Dt_Head2, Dt_Head3, Dt_Head4, Dt_Head5, Dt_Head6, Dt_Head7 As DataTable
    Dim Dt_Tab1, Dt_Tab2, Dt_Tab3, Dt_Tab4, Dt_Tab5, Dt_Tab6, Dt_Tab7 As DataTable
    Dim Dt_Master1, Dt_Master2, Dt_Master3, Dt_Master4, Dt_Master5, Dt_Master6, Dt_Master7 As DataTable
    Dim DtDvcs As DataTable
    Dim _StrSave1 As String = ""
    Dim _StrSave2 As String = ""
    Dim _StrSave3 As String = ""
    Dim _StrSave4 As String = ""
    Dim Dv_Master1, Dv_Head1, Dv_Master2, Dv_Head2, Dv_Master3, Dv_Head3, Dv_Master4, Dv_Head4, Dv_Master5, Dv_Head5, Dv_Master6, Dv_Head6, Dv_Master7, Dv_Head7 As DataView

    Private Sub FrmLogfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        osysvar = Me.Sysvar
        M_LAN = Me.Lan
        TxtNgay_Ct1.Value = Now.Date()
        TxtNgay_Ct2.Value = Now.Date().AddHours(23).AddMinutes(59)
        V_Load("1")
        V_AddHandler()
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
#Region "Load And Set And Default"
    Private Sub V_Load(ByVal status)
        '--Load dữ liệu ban đầu 
        Dim Dt1 As DateTime = TxtNgay_Ct1.Value
        Dim Dt2 As DateTime = TxtNgay_Ct2.Value

        Dim _DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Copy_PhanQuyen", status & "#" & TxtGroup_Old.Text & "#" & TxtUser.Text & "#" & M_Ma_Dvcs & "#" & M_User_Name)

        If status = "1" Then

            Dt_Tab1 = _DsTmp.Tables(0).Copy
            Dt_Master1 = _DsTmp.Tables(1).Copy
            Dt_Head1 = _DsTmp.Tables(2).Copy
            Dv_Head1 = New DataView(Dt_Head1)
            Dv_Master1 = New DataView(Dt_Master1)
            '2
            Dt_Tab2 = _DsTmp.Tables(3).Copy
            Dt_Master2 = _DsTmp.Tables(4).Copy
            Dt_Head2 = _DsTmp.Tables(5).Copy
            Dv_Head2 = New DataView(Dt_Head2)
            Dv_Master2 = New DataView(Dt_Master2)
            '3
            Dt_Tab3 = _DsTmp.Tables(6).Copy
            Dt_Master3 = _DsTmp.Tables(7).Copy
            Dt_Head3 = _DsTmp.Tables(8).Copy
            Dv_Head3 = New DataView(Dt_Head3)
            Dv_Master3 = New DataView(Dt_Master3)
            '4
            Dt_Tab4 = _DsTmp.Tables(9).Copy
            Dt_Master4 = _DsTmp.Tables(10).Copy
            Dt_Head4 = _DsTmp.Tables(11).Copy
            Dv_Head4 = New DataView(Dt_Head4)
            Dv_Master4 = New DataView(Dt_Master4)

            detail1.DataSource = Dv_Master1
            Me.DetailGRV1.GridControl = Me.detail1
            CyberFill.V_FillReports(DetailGRV1, Me.Lan, Dv_Head1, Dv_Master1)
            '2
            Detail2.DataSource = Dv_Master2
            Me.DetailGRV2.GridControl = Me.Detail2
            CyberFill.V_FillReports(DetailGRV2, Me.Lan, Dv_Head2, Dv_Master2)
            '3
            Detail3.DataSource = Dv_Master3
            Me.DetailGRV3.GridControl = Me.Detail3
            CyberFill.V_FillReports(DetailGRV3, Me.Lan, Dv_Head3, Dv_Master3)
            '4
            Detail4.DataSource = Dv_Master4
            Me.DetailGRV4.GridControl = Me.Detail4
            CyberFill.V_FillReports(DetailGRV4, Me.Lan, Dv_Head4, Dv_Master4)

            TabPage1.Text = Dt_Tab1.Rows(0).Item("Title").ToString.Trim
            TabPage2.Text = Dt_Tab2.Rows(0).Item("Title").ToString.Trim
            TabPage3.Text = Dt_Tab3.Rows(0).Item("Title").ToString.Trim
            TabPage4.Text = Dt_Tab4.Rows(0).Item("Title").ToString.Trim

        Else
            Dim nCount As Integer = _DsTmp.Tables.Count
            For i = 0 To nCount - 1
                CyberSmodb.SetNotNullTable(_DsTmp.Tables(i))
            Next
            '1
            Dt_Master1.Clear()
            For i = 0 To _DsTmp.Tables(0).Rows.Count - 1
                Dt_Master1.ImportRow(_DsTmp.Tables(0).Rows(i))
            Next
            Dt_Master1.AcceptChanges()
            '2
            Dt_Master2.Clear()
            For i = 0 To _DsTmp.Tables(1).Rows.Count - 1
                Dt_Master2.ImportRow(_DsTmp.Tables(1).Rows(i))
            Next
            Dt_Master2.AcceptChanges()
            '3
            Dt_Master3.Clear()
            For i = 0 To _DsTmp.Tables(2).Rows.Count - 1
                Dt_Master3.ImportRow(_DsTmp.Tables(2).Rows(i))
            Next
            Dt_Master3.AcceptChanges()
            '4
            Dt_Master4.Clear()
            For i = 0 To _DsTmp.Tables(3).Rows.Count - 1
                Dt_Master4.ImportRow(_DsTmp.Tables(3).Rows(i))
            Next
            Dt_Master4.AcceptChanges()
        End If
    End Sub
    Private Sub V_ReFresh(ByVal sender As System.Object, ByVal e As System.EventArgs)

        V_Load("0")
    End Sub
    Private Sub V_exit(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Close()
    End Sub


    Private Sub V_copy(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'V_update(sender, e)
        If txtGroup_New.Text = "" Then
            MsgBox("Bạn chưa nhập thông tin nhóm mới cần copy phân quyền !", MsgBoxStyle.OkOnly, "Cyber")
            Exit Sub
        End If
        Dim _DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Tao_Nhom", TxtGroup_Old.Text & "#" & txtGroup_New.Text & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        MsgBox("Copy nhóm phân quyền mới thành công !", MsgBoxStyle.OkOnly, "Cyber")


    End Sub
    Private Sub V_update(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Stt_Rec As String = Tao_nhom("1", -1)
        If _Stt_Rec.Trim = "" Then Exit Sub
        V_ReFresh(New System.Object, New System.EventArgs)
    End Sub
    Private Function Tao_nhom(ByVal _Loai As String, ByVal iRow As Integer) As String

        _StrSave1 = ""
        _StrSave2 = ""
        _StrSave3 = ""
        _StrSave4 = ""
        Dim j As Integer = 0
        Dim nCount As Integer = 0
        If iRow = -1 Then
            j = 0
            nCount = Dv_Head1.Count - 1
        Else
            j = iRow
            nCount = iRow
        End If

        For i = j To nCount

            '_StrSave = _StrSave + ";INSERT KTVKTVKTV SELECT '" & Dv_Ro.Item(i).Item("So_RO").ToString.Trim & "','" & Dv_Ro.Item(i).Item("Ma_VT").ToString.Trim & "'," & Dv_Ro.Item(i).Item("Sl_Xuat").ToString.Trim.Replace(" ", "").Replace(",", ".") & "," & Dv_Ro.Item(i).Item("Sl_Xuat_PICK").ToString.Trim.Replace(" ", "").Replace(",", ".")

            _StrSave1 = _StrSave1 + ";INSERT NhanVien SELECT '" & Dv_Head1.Item(i).Item("user_name").ToString.Trim & "'"
        Next
        If _StrSave1 = "" Then Return ""
        '---- bảng 2
        j = 0
        nCount = 0
        If iRow = -1 Then
            j = 0
            nCount = Dv_Head2.Count - 1
        Else
            j = iRow
            nCount = iRow
        End If

        For i = j To nCount

            '_StrSave = _StrSave + ";INSERT KTVKTVKTV SELECT '" & Dv_Ro.Item(i).Item("So_RO").ToString.Trim & "','" & Dv_Ro.Item(i).Item("Ma_VT").ToString.Trim & "'," & Dv_Ro.Item(i).Item("Sl_Xuat").ToString.Trim.Replace(" ", "").Replace(",", ".") & "," & Dv_Ro.Item(i).Item("Sl_Xuat_PICK").ToString.Trim.Replace(" ", "").Replace(",", ".")

            _StrSave2 = _StrSave2 + ";INSERT ChungTu SELECT '" & Dv_Head2.Item(i).Item("ma_ct").ToString.Trim & "'"
        Next
        If _StrSave2 = "" Then Return ""

        '---- bảng 3
        j = 0
        nCount = 0
        If iRow = -1 Then
            j = 0
            nCount = Dv_Head3.Count - 1
        Else
            j = iRow
            nCount = iRow
        End If

        For i = j To nCount

            '_StrSave = _StrSave + ";INSERT KTVKTVKTV SELECT '" & Dv_Ro.Item(i).Item("So_RO").ToString.Trim & "','" & Dv_Ro.Item(i).Item("Ma_VT").ToString.Trim & "'," & Dv_Ro.Item(i).Item("Sl_Xuat").ToString.Trim.Replace(" ", "").Replace(",", ".") & "," & Dv_Ro.Item(i).Item("Sl_Xuat_PICK").ToString.Trim.Replace(" ", "").Replace(",", ".")

            _StrSave3 = _StrSave3 + ";INSERT DanhMuc SELECT '" & Dv_Head3.Item(i).Item("name").ToString.Trim & "'"
        Next
        If _StrSave3 = "" Then Return ""
        '---- bảng 4
        j = 0
        nCount = 0
        If iRow = -1 Then
            j = 0
            nCount = Dv_Head4.Count - 1
        Else
            j = iRow
            nCount = iRow
        End If

        For i = j To nCount

            '_StrSave = _StrSave + ";INSERT KTVKTVKTV SELECT '" & Dv_Ro.Item(i).Item("So_RO").ToString.Trim & "','" & Dv_Ro.Item(i).Item("Ma_VT").ToString.Trim & "'," & Dv_Ro.Item(i).Item("Sl_Xuat").ToString.Trim.Replace(" ", "").Replace(",", ".") & "," & Dv_Ro.Item(i).Item("Sl_Xuat_PICK").ToString.Trim.Replace(" ", "").Replace(",", ".")

            _StrSave4 = _StrSave4 + ";INSERT Baocao SELECT '" & Dv_Head4.Item(i).Item("ma_hs").ToString.Trim & "'"
        Next
        If _StrSave4 = "" Then Return ""
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ApprolGroup", _Loai + "#" + _StrSave1 & "#" & TxtGroup_Old.Text & "#" & txtGroup_New.Text & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        MsgBox("Cập nhật thông tin thành công !", MsgBoxStyle.OkOnly, "Cyber")

    End Function

    Private Sub V_AddHandler()
        AddHandler CmdSearch.Click, AddressOf V_ReFresh
        AddHandler CmdCopy.Click, AddressOf V_copy

        AddHandler ButtExit.Click, AddressOf V_exit
        AddHandler DetailGRV1.RowCellStyle, AddressOf MasterHisLoginGRV_RowCellStyle
        AddHandler DetailGRV2.RowCellStyle, AddressOf MasterHisVoucherGRV_RowCellStyle
        AddHandler DetailGRV3.RowCellStyle, AddressOf MasterHisSmListGRV_RowCellStyle
        AddHandler DetailGRV4.RowCellStyle, AddressOf MasterHisReportGRV_RowCellStyle

        AddHandler DetailGRV1.PopupMenuShowing, AddressOf MasterHisLoginGRV_PopupMenuShowing
        AddHandler DetailGRV2.PopupMenuShowing, AddressOf MasterHisVoucherGRV_PopupMenuShowing
        AddHandler DetailGRV3.PopupMenuShowing, AddressOf MasterHisSmListGRV_PopupMenuShowing
        AddHandler DetailGRV4.PopupMenuShowing, AddressOf MasterHisReportGRV_PopupMenuShowing

        '--User
        AddHandler TxtUser.CyberValiting, AddressOf V_Username
        AddHandler TxtUser.CyberLeave, AddressOf L_Username

        AddHandler TxtGroup_Old.CyberValiting, AddressOf V_group
        AddHandler TxtGroup_Old.CyberLeave, AddressOf L_group

    End Sub
#Region "Valid User"
    Private Sub V_Username(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtUser.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "User_name", "Userinfo", "1=1", "1=1")
    End Sub
    Private Sub L_Username(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtUser.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtUser.Text = DrReturn.Item("User_name")
            TxtComment.Text = DrReturn.Item("Comment")
        Else
            TxtUser.Text = ""
            TxtComment.Text = ""
            Exit Sub
        End If
    End Sub
    Private Sub V_group(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtGroup_Old.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Group", "GroupInfo", "1=1", "1=1")
    End Sub
    Private Sub L_group(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtGroup_Old.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtGroup_Old.Text = DrReturn.Item("Group")
            txtTen_Group_Old.Text = DrReturn.Item("Comment")
        Else
            TxtGroup_Old.Text = ""
            txtTen_Group_Old.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
    Private Sub MasterHisLoginGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, DetailGRV1, Dt_Data_HisLogin, Me.Font)
    End Sub
    Private Sub MasterHisVoucherGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, DetailGRV2, Dt_Data_HisVoucher, Me.Font)
    End Sub
    Private Sub MasterHisSmListGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, DetailGRV3, Dt_Data_HisSmList, Me.Font)
    End Sub
    Private Sub MasterHisReportGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, DetailGRV2, Dt_Data_HisReport, Me.Font)
    End Sub
    Private Sub MasterHisLoginGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then rowHandle = -1 Else rowHandle = e.HitInfo.RowHandle

        PopupMenuMasterGrid.ItemLinks.Clear()
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_ReFresh, Shortcut.F5, My.Resources.refresh2_16x16, True, True), False).BeginGroup = False
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Xuất Excel", "Export to Excel"), AddressOf V_Export_login, Shortcut.F11, My.Resources.edit_16x16, True, True), False).BeginGroup = True
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, Nothing, My.Resources.cancel_16x16, True, True), False).BeginGroup = True

        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
    End Sub
    Private Sub MasterHisVoucherGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If
        PopupMenuMasterGrid.ItemLinks.Clear()
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_ReFresh, Shortcut.F5, My.Resources.refresh2_16x16, True, True), False).BeginGroup = False
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Xuất Excel", "Export to Excel"), AddressOf V_Export_Voucher, Shortcut.F11, My.Resources.edit_16x16, True, True), False).BeginGroup = True
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, Nothing, My.Resources.cancel_16x16, True, True), False).BeginGroup = True

        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
    End Sub
    Private Sub MasterHisSmListGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If
        PopupMenuMasterGrid.ItemLinks.Clear()
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_ReFresh, Shortcut.F5, My.Resources.refresh2_16x16, True, True), False).BeginGroup = False
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Xuất Excel", "Export to Excel"), AddressOf V_Export_SmList, Shortcut.F11, My.Resources.edit_16x16, True, True), False).BeginGroup = True
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, Nothing, My.Resources.cancel_16x16, True, True), False).BeginGroup = True

        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
    End Sub
    Private Sub MasterHisReportGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If
        PopupMenuMasterGrid.ItemLinks.Clear()
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_ReFresh, Shortcut.F5, My.Resources.refresh2_16x16, True, True), False).BeginGroup = False
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Xuất Excel", "Export to Excel"), AddressOf V_Export_Report, Shortcut.F11, My.Resources.edit_16x16, True, True), False).BeginGroup = True
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, Nothing, My.Resources.cancel_16x16, True, True), False).BeginGroup = True

        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
    End Sub
#End Region
#Region "Export  + Exit"
    Private Sub V_Quay_Ra(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub V_Export_login(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Dt_Title As New DataTable
        _Dt_Title.Columns.Add("Title1")
        _Dt_Title.Columns.Add("Title2")
        _Dt_Title.Columns.Add("Tu_ngay")
        Dim _Title As String = "DANH SÁCH TÀI KHOẢN TRUY CẬP PHẦN MỀM"
        Dim _Tu_Ngay As String = "Từ ngày" & TxtNgay_Ct1.Text & " đến ngày" & TxtNgay_Ct2.Text
        _Title = _Title.ToUpper
        _Tu_Ngay = _Tu_Ngay.ToUpper
        _Dt_Title.Rows.Add(_Title, _Title, _Tu_Ngay)
        Dim _Dv_Title As DataView = New DataView(_Dt_Title)
        If CyberExport Is Nothing Then CyberExport = New Cyber.Export.Sys
        CyberExport.V_ExportToXlsx(AppConn, Me.DetailGRV1, _Dv_Title, Dv_Data_HisLogin, Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name)

    End Sub
    Private Sub V_Export_Voucher(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Dt_Title As New DataTable
        _Dt_Title.Columns.Add("Title1")
        _Dt_Title.Columns.Add("Title2")
        _Dt_Title.Columns.Add("Tu_ngay")
        Dim _Title As String = "DANH SÁCH TÀI KHOẢN THAO TÁC TRÊN CHỨNG TỪ"
        Dim _Tu_Ngay As String = "Từ ngày" & TxtNgay_Ct1.Text & " đến ngày" & TxtNgay_Ct2.Text
        _Title = _Title.ToUpper
        _Tu_Ngay = _Tu_Ngay.ToUpper
        _Dt_Title.Rows.Add(_Title, _Title, _Tu_Ngay)
        Dim _Dv_Title As DataView = New DataView(_Dt_Title)
        If CyberExport Is Nothing Then CyberExport = New Cyber.Export.Sys
        CyberExport.V_ExportToXlsx(AppConn, Me.DetailGRV2, _Dv_Title, Dv_Data_HisVoucher, Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name)

    End Sub
    Private Sub V_Export_SmList(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Dt_Title As New DataTable
        _Dt_Title.Columns.Add("Title1")
        _Dt_Title.Columns.Add("Title2")
        _Dt_Title.Columns.Add("Tu_ngay")
        Dim _Title As String = "DANH SÁCH TÀI KHOẢN THAO TÁC TRÊN DANH MỤC"
        Dim _Tu_Ngay As String = "Từ ngày" & TxtNgay_Ct1.Text & " đến ngày" & TxtNgay_Ct2.Text
        _Title = _Title.ToUpper
        _Tu_Ngay = _Tu_Ngay.ToUpper
        _Dt_Title.Rows.Add(_Title, _Title, _Tu_Ngay)
        Dim _Dv_Title As DataView = New DataView(_Dt_Title)
        If CyberExport Is Nothing Then CyberExport = New Cyber.Export.Sys
        CyberExport.V_ExportToXlsx(AppConn, Me.DetailGRV3, _Dv_Title, Dv_Data_HisSmList, Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name)

    End Sub
    Private Sub V_Export_Report(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Dt_Title As New DataTable
        _Dt_Title.Columns.Add("Title1")
        _Dt_Title.Columns.Add("Title2")
        _Dt_Title.Columns.Add("Tu_ngay")
        Dim _Title As String = "DANH SÁCH TÀI KHOẢN THAO TÁC TRÊN BÁO CÁO"
        Dim _Tu_Ngay As String = "Từ ngày" & TxtNgay_Ct1.Text & " đến ngày" & TxtNgay_Ct2.Text
        _Title = _Title.ToUpper
        _Tu_Ngay = _Tu_Ngay.ToUpper
        _Dt_Title.Rows.Add(_Title, _Title, _Tu_Ngay)
        Dim _Dv_Title As DataView = New DataView(_Dt_Title)
        If CyberExport Is Nothing Then CyberExport = New Cyber.Export.Sys
        CyberExport.V_ExportToXlsx(AppConn, Me.DetailGRV4, _Dv_Title, Dv_Data_HisReport, Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name)

    End Sub
#End Region
End Class
