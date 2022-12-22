Imports System.Drawing
Imports System.Windows.Forms
Public Class COPYDL
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim DtThang, DtNam As DataTable
    Dim Dt_head, Dt_Master As DataTable
    Dim Dv_head, Dv_Master As DataView
    Dim DrDmct As DataRow
    Dim CyberColor As New Cyber.Color.Sys
    Dim List_Ma_CT As String = ""
    Dim M_Ma_CT As String = ""
    Private Sub COPYDL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        Try
            M_Ma_CT = Me.Para(Me.M_VT_PARA + 2).ToString.Trim
        Catch ex As Exception
        End Try
        Try
            List_Ma_CT = Me.Para(Me.M_VT_PARA + 3).ToString.Trim
        Catch ex As Exception

        End Try
        If List_Ma_CT <> "" Then
            List_Ma_CT = List_Ma_CT.Trim.Replace(" ", "")
        End If
        V_Load()
        V_LoadDatabase("1")
        Master.DataSource = Dv_Master
        Me.MasterGRV.GridControl = Me.Master
        CyberFill.V_FillVoucher(MasterGRV, Me.Lan, Dv_head, Dv_Master, DrDmct)
        MasterGRV.OptionsView.ShowViewCaption = False
        MasterGRV.OptionsSelection.MultiSelect = False
        Me.MasterGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.YellowGreen

        V_AddHandler()
        Me.Text = Me.Para(11).Trim

        MasterGRV_PopupMenuShowing(MasterGRV, Nothing)
        MasterGRV.OptionsMenu.EnableColumnMenu = True

        For Each dc As DevExpress.XtraGrid.Columns.GridColumn In MasterGRV.Columns
            dc.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True
            dc.OptionsFilter.AllowAutoFilter = True
            dc.OptionsFilter.AllowFilter = True
            dc.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Next

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_AddHandler()
        RemoveHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        RemoveHandler MasterGRV.RowCellStyle, AddressOf DetailGRV_RowCellStyle
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler CmdSelectAll.Click, AddressOf V_SelectAll
        RemoveHandler CmdRemoveAll.Click, AddressOf V_RemoveAll
        RemoveHandler CmdDelete.Click, AddressOf V_DeleteBT
        RemoveHandler BttLay_Dl.Click, AddressOf V_LayDl


        AddHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        AddHandler MasterGRV.RowCellStyle, AddressOf DetailGRV_RowCellStyle
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler BttLay_Dl.Click, AddressOf V_LayDL
        AddHandler CmdSelectAll.Click, AddressOf V_SelectAll
        AddHandler CmdRemoveAll.Click, AddressOf V_RemoveAll
        AddHandler CmdDelete.Click, AddressOf V_DeleteBT
        '
        '--TK
        AddHandler TxtTk.CyberValiting, AddressOf V_Tk
        AddHandler TxtTk.CyberLeave, AddressOf L_Tk
        AddHandler TxtTK1.CyberValiting, AddressOf V_Tk1
        AddHandler TxtTK1.CyberLeave, AddressOf L_Tk1

        AddHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_Kh
        AddHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_Kh

        MasterGRV.ViewCaption = ""
        MasterGRV.OptionsView.ShowViewCaption = False
    End Sub
    Private Sub V_Tk(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk.Text = "" Then
            Txtten_Tk.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk.Text = DrReturn.Item("TK")
            Txtten_Tk.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk.Text = ""
            Txtten_Tk.Text = ""
        End If
    End Sub
    Private Sub V_Tk1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTK1.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTK1.Text = "" Then
            TxtTen_Tk1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTK1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTK1.Text = DrReturn.Item("TK")
            TxtTen_Tk1.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTK1.Text = ""
            TxtTen_Tk1.Text = ""
        End If
    End Sub
    Private Sub V_Ma_Kh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Kh.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_kh", "DMKH", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Kh.Text = "" Then
            Txtten_Kh.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kh.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kh.Text = DrReturn.Item("ma_kh")
            Txtten_Kh.Text = DrReturn.Item("Ten_Kh")
        Else
            TxtMa_Kh.Text = ""
            Txtten_Kh.Text = ""
        End If
    End Sub
    Private Sub V_Load()

        Dim Dt As DataTable
        Dim _Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ReviewVoucherLoadDmct", List_Ma_CT & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        Dt = _Dstmp.Tables(0).Copy
        If M_Ma_CT.Trim = "" And Dt.Rows.Count > 0 Then M_Ma_CT = Dt.Rows(0).Item("Ma_Ct").ToString.Trim
        Dim _Chk As Boolean = False
        For i = 0 To Dt.Rows.Count - 1
            If Dt.Rows(i).Item("Ma_Ct").ToString.Trim.ToUpper = M_Ma_CT.Trim.ToUpper Then
                _Chk = True
                '        Exit Sub
            End If
        Next
        If Not _Chk Then
            M_Ma_CT = ""
            If Dt.Rows.Count > 0 Then M_Ma_CT = Dt.Rows(0).Item("Ma_Ct")
        End If
        CyberFill.V_FillComBoxValue(CbbLoai_Chuyen, Dt, "Ma_Ct", If(Me.M_LAN = "V", "ten_Ct", "Ten_Ct2"), M_Ma_CT)

        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmlib.GetKeyValueRegistryDate(Me.Sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmlib.GetKeyValueRegistryDate(Me.Sysvar, TxtM_Ngay_Ct2)
    End Sub
    Private Sub V_LoadDatabase(ByVal Status)
        Dim _D1 As Date = TxtM_Ngay_Ct1.Value
        Dim _D2 As Date = TxtM_Ngay_Ct2.Value
        Dim _Ck As String = "0"
        If ChkAll.Checked = True Then _Ck = "1"
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SMCOPYDL", Status & "#" & CbbLoai_Chuyen.SelectedValue.ToString & "#" & _D1.ToString("yyyyMMdd") & "#" & _D2.ToString("yyyyMMdd").Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name & "#" & TxtTk.Text & "#" & TxtTK1.Text & "#" & TxtMa_Kh.Text & "#" & _Ck & "#" & TxtSo_HD1.Text & "#" & TxtSo_HD2.Text)
        CyberSmodb.SetNotNullTable(DsTmp.Tables(0))
        If Status = "1" Then
            Dt_Master = DsTmp.Tables(0).Copy
            Dt_head = DsTmp.Tables(1).Copy

            Dv_Master = New DataView(Dt_Master)
            Dv_head = New DataView(Dt_head)
        Else
            Dim nCount As Integer = Dt_Master.Rows.Count - 1
            For i As Integer = nCount To 0 Step -1
                Dt_Master.Rows(i).Delete()
            Next
            Dt_Master.AcceptChanges()
            For i = 0 To DsTmp.Tables(0).Rows.Count - 1
                Dt_Master.ImportRow(DsTmp.Tables(0).Rows(i))
            Next
            Dt_Master.AcceptChanges()
        End If
    End Sub
    'Private Function CreateTableMonth() As DataTable
    '    Dim _Return As New DataTable
    '    _Return.Columns.Add("Thang")
    '    _Return.Columns.Add("Ten_Thang")
    '    _Return.Columns.Add("Ten_Thang2")
    '    _Return.Columns.Add("Default")
    '    Dim _Thang As String = ""
    '    Dim _Default As String = "0"

    '    For i As Integer = 1 To 12
    '        _Thang = Strings.Right("00" + i.ToString.Trim, 2).Trim
    '        If Now.Date.Month = i Then
    '            _Default = "1"
    '        Else
    '            _Default = "0"
    '        End If
    '        _Return.Rows.Add(_Thang.ToString, "Tháng " + _Thang, "Month " + _Thang, _Default)
    '    Next
    '    CreateTableMonth = _Return
    'End Function
    'Private Function CreateTableYear() As DataTable
    '    Dim _Return As New DataTable
    '    _Return.Columns.Add("Nam")
    '    _Return.Columns.Add("Ten_Nam")
    '    _Return.Columns.Add("Ten_Nam2")
    '    _Return.Columns.Add("Default")

    '    Dim _CurYear As Integer = Now.Year

    '    Dim _Nam As String = ""
    '    Dim _Default As String = "0"

    '    For i As Integer = _CurYear - 10 To _CurYear + 10
    '        _Nam = Strings.Right("0000" + i.ToString.Trim, 4).Trim

    '        If Now.Date.Year = i Then
    '            _Default = "1"
    '        Else
    '            _Default = "0"
    '        End If
    '        _Return.Rows.Add(_Nam.ToString, "Năm " + _Nam, "Year " + _Nam, _Default)
    '    Next
    '    CreateTableYear = _Return
    'End Function
    Private Sub V_LayDl(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadDatabase("0")
    End Sub
    Private Sub MasterGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If
        PopupMenuMasterGrid.ItemLinks.Clear()
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Tạo bút toán", "Create"), AddressOf V_Nhan, Shortcut.F4, My.Resources.apply_16x16, True, False))
        'PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_LayDl, Shortcut.CtrlF5, My.Resources.refresh2_16x16, True, True), True)
        '--- End Tuy chọn
        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Exits, My.Resources.cancel_16x16, True, True)
        PopupMenuMasterGrid.ItemLinks.Add(MenuExits, True)
        'PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        'End If
    End Sub
    Private Sub DetailGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        If Dt_Master.Columns.Contains("Bold") Then
            Dim _FieldBold As String = ""
            _FieldBold = Dt_Master.Columns("Bold").ColumnName
            Dim _categoryBold As String = MasterGRV.GetRowCellDisplayText(e.RowHandle, _FieldBold).ToString.Trim
            If _categoryBold = "1" Then e.Appearance.Font = New Drawing.Font(Me.Font.FontFamily, Me.Font.Size, FontStyle.Bold)
        End If
        If Not sender.IsCellSelected(e.RowHandle, e.Column) Then
            If Dt_Master.Columns.Contains("BackColor") Then
                Dim _FieldBackColor As String = ""
                _FieldBackColor = Dt_Master.Columns("BackColor").ColumnName
                Dim _categoryBackColor As String = MasterGRV.GetRowCellDisplayText(e.RowHandle, _FieldBackColor).ToString.Trim
                e.Appearance.BackColor = CyberColor.GetBacColorkReports(_categoryBackColor)
            End If
            If Dt_Master.Columns.Contains("BackColor2") Then
                Dim _FieldBackColor2 As String = ""
                _FieldBackColor2 = Dt_Master.Columns("BackColor2").ColumnName
                Dim _categoryBackColor2 As String = MasterGRV.GetRowCellDisplayText(e.RowHandle, _FieldBackColor2).ToString.Trim
                e.Appearance.BackColor2 = CyberColor.GetBacColorkReports(_categoryBackColor2)
            End If
        Else
            e.Appearance.BackColor = System.Drawing.Color.Silver
        End If
    End Sub
#Region "Valid"
#End Region
    'Private Sub V_DeleteBT(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim _Thang As String = CbbM_Thang.SelectedValue.ToString.Trim
    '    Dim _Nam As String = CbbM_Nam.SelectedValue.ToString.Trim

    '    If Not MsgBox("Bạn có muốn xóa khấu hao tháng " + _Thang + " năm " + _Nam, MsgBoxStyle.Critical + MsgBoxStyle.OkCancel, Me.Sysvar("M_CYBER_VER")) = MsgBoxResult.Ok Then Exit Sub

    '    Dim _Title As String = "Đang thực hiện xoát bút toán khấu hao tài sản cố định"
    '    Dim _Title2 As String = "Đang thực hiện xoát bút toán khấu hao tài sản cố định"


    '    If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm(_Title, _Title2, Me.Lan)
    '    Dim _DsDelete As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_FaBTDelete", "X#" & _Thang & "#" & _Nam & "#" & M_Ma_Dvcs & "#" & M_User_Name)
    '    If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()
    '    CyberSupport.V_MsgChk(_DsDelete.Tables(0), Me.Sysvar, Me.Lan)
    'End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Not MsgBox("Bạn có muốn tạo copy toán hạch toán ", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, Me.Sysvar("M_CYBER_VER")) = MsgBoxResult.Ok Then Exit Sub
        Dim _d1, _d2 As Date
        _d1 = TxtM_Ngay_Ct1.Value
        _d2 = TxtM_Ngay_Ct2.Value
        Dim _Title As String = "Đang thực hiện tạo copy số liệu"
        Dim _Title2 As String = "Đang thực hiện tạo copy số liệu"

        If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm(_Title, _Title2, Me.Lan)

        '---- Post du lieu

        Dim strStt_Rec As String = ""
        Dim j As Integer = 0
        Dim nCount As Integer = Dt_Master.Rows.Count
        For i As Integer = 0 To nCount - 1
            If Dt_Master.Rows(i).Item("Tag") = True Then
                j = j + 1
                strStt_Rec = strStt_Rec + IIf(j = 1, "", "!~!") + Dt_Master.Rows(i).Item("Stt_Rec").ToString.Trim
            End If
        Next

        '---- Post du lieu
        Dim strMa_kh As String = ""
        Dim k As Integer = 0
        nCount = Dt_Master.Rows.Count
        For i As Integer = 0 To nCount - 1
            If Dt_Master.Rows(i).Item("Tag") = True Then
                k = k + 1
                strMa_kh = strMa_kh + IIf(k = 1, "", "!~!") + Dt_Master.Rows(i).Item("MA_KH_C").ToString.Trim
            End If
        Next

        '---- Post du lieu
        Dim strTk_no As String = ""
        Dim l As Integer = 0
        nCount = Dt_Master.Rows.Count
        For i As Integer = 0 To nCount - 1
            If Dt_Master.Rows(i).Item("Tag") = True Then
                l = l + 1
                strTk_no = strTk_no + IIf(l = 1, "", "!~!") + Dt_Master.Rows(i).Item("Tk_no").ToString.Trim
            End If
        Next

        '---- Post du lieu
        Dim strTk_co As String = ""
        Dim z As Integer = 0
        nCount = Dt_Master.Rows.Count
        For i As Integer = 0 To nCount - 1
            If Dt_Master.Rows(i).Item("Tag") = True Then
                z = z + 1
                strTk_co = strTk_co + IIf(z = 1, "", "!~!") + Dt_Master.Rows(i).Item("Tk_co").ToString.Trim
            End If
        Next

        Dim _DsTmp As DataSet
        _DsTmp = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SMCOPYDL_CREAT_NEW", CbbLoai_Chuyen.SelectedValue.ToString & "#" & _d1.ToString("yyyyMMdd") & "#" & _d2.ToString("yyyyMMdd") & "#" & j.ToString() & "#" & strStt_Rec & "#" & strMa_kh & "#" & strTk_no & "#" & strTk_co & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If Not _DsTmp Is Nothing Then If _DsTmp.Tables.Count > 0 Then If _DsTmp.Tables(_DsTmp.Tables.Count - 1).Columns.Contains("status") Then CyberSupport.V_MsgChk(_DsTmp.Tables(_DsTmp.Tables.Count - 1), Me.Sysvar, Me.Lan)
        V_RemoveAll(New System.Object, New System.EventArgs)
    End Sub
    Private Sub V_DeleteBT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dsChk As New DataSet
        Dim strStt_Rec As String = "", strMa_Ct As String = ""
        Dim i, ncount As Integer
        ncount = 0
        For i = 0 To Dt_Master.Rows.Count - 1
            If Dt_Master.Rows(i).Item("Tag") Then
                ncount = ncount + 1
                strStt_Rec = Dt_Master.Rows(i).Item("Stt_Rec").ToString.Trim
                strMa_Ct = Dt_Master.Rows(i).Item("Ma_Ct").ToString.Trim
                dsChk = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysDeleteVoucher", strStt_Rec + "#" + strMa_Ct + "#" + M_User_Name.Trim)
                Dt_Master.Rows(i).Item("Tag") = False
            End If
        Next

        MsgBox("Đã xóa thành công!", MsgBoxStyle.OkOnly)
        'Me.Master1GRV.RefreshData()
    End Sub
    Private Sub V_Exits(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Tag = ""
        Me.Save_OK = False
        CyberSmlib.FlushMemorySave()

        Me.Close()
    End Sub
    Private Sub V_SelectAll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Integer
        For i = 0 To Dt_Master.Rows.Count - 1
            Dt_Master.Rows(i).BeginEdit()
            Dt_Master.Rows(i).Item("Tag") = True
            Dt_Master.Rows(i).EndEdit()
            Dt_Master.AcceptChanges()
        Next
    End Sub
    Private Sub V_RemoveAll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Integer
        For i = 0 To Dt_Master.Rows.Count - 1
            Dt_Master.Rows(i).BeginEdit()
            Dt_Master.Rows(i).Item("Tag") = False
            Dt_Master.Rows(i).EndEdit()
            Dt_Master.AcceptChanges()
        Next
    End Sub
   
End Class
