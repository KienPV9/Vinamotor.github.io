﻿Public Class HRLUONGKDHDC
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim _DtGroupBy, _GroupByTH, _GroupByCT ,DtThang, DtNam As DataTable
    Private Sub BEKQKD_HDC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        _DtGroupBy = GetGroupBy()
        V_AddMenuShorcut()
        V_Load()
        V_VisibleCT()
        V_Addhander()
    End Sub
#Region "Chi tiet theo"
    Private Sub V_VisibleCT()

    End Sub
    Private Sub V_Detail_OK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_VisibleCT()
    End Sub
#End Region
#Region "Load"
    Private Function GetGroupBy() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Tinh_dc")
        _Return.Columns.Add("Ten_DC")
        _Return.Columns.Add("Ten_Dc2")
        _Return.Columns.Add("Ngam_Dinh")
        _Return.Rows.Add("1", "Tính phát sinh điều chuyển", "Tính phát sinh điều chuyển", "1")
        _Return.Rows.Add("0", "Không tính phát sinh điều chuyển", "Không tính phát sinh điều chuyển", "0")
        GetGroupBy = _Return
    End Function

    Private Sub V_Load()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '----------
        '----Set
        DtThang = CreateTableMonth()
        DtNam = CreateTableYear()
        CyberFill.V_FillComBoxDefaul(CbbM_Thang, DtThang, "Thang", IIf(Me.LAN = "V", "Ten_Thang", "Ten_Thang2"), "Default")
        CyberFill.V_FillComBoxDefaul(CbbM_Nam, DtNam, "Nam", IIf(Me.LAN = "V", "Ten_Nam", "Ten_nam2"), "Default")

        TxtMa_KX.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_KX)
        TxtMa_mau.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_mau)
        TxtSo_khung.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtSo_khung)

        TxtTen_kx.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_KX", "Dmkx", "(Ma_KX= N'" + TxtMa_KX.Text.Trim + "')", CyberSmLib)
        txtTen_Mau.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_mau", "DmMauxe", "(Ma_mau= N'" + TxtMa_mau.Text.Trim + "')", CyberSmLib)

        TxtNh_Kx1.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_Nh", "DmNhKx", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_Kx1.Text.Trim + "')", CyberSmLib)
        TxtNh_Kx2.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_Nh", "DmNhKx", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_Kx2.Text.Trim + "')", CyberSmLib)
        TxtNh_Kx3.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_Nh", "DmNhKx", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_Kx3.Text.Trim + "')", CyberSmLib)

        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
        '-------------
        '--Ma_VT
        AddHandler TxtMa_KX.CyberValiting, AddressOf V_Ma_Kx
        AddHandler TxtMa_KX.CyberLeave, AddressOf L_Ma_Kx
        '-- Tk vt
        AddHandler TxtMa_mau.CyberValiting, AddressOf V_Ma_mau
        AddHandler TxtMa_mau.CyberLeave, AddressOf L_Ma_mau
        '--Vt1
        RemoveHandler TxtNh_Kx1.CyberValiting, AddressOf V_Nh_kx1
        RemoveHandler TxtNh_Kx1.CyberLeave, AddressOf L_Nh_kx1
        AddHandler TxtNh_Kx1.CyberValiting, AddressOf V_Nh_kx1
        AddHandler TxtNh_Kx1.CyberLeave, AddressOf L_Nh_kx1
        '--VT2
        RemoveHandler TxtNh_Kx2.CyberValiting, AddressOf V_Nh_kx2
        RemoveHandler TxtNh_Kx2.CyberLeave, AddressOf L_Nh_kx2
        AddHandler TxtNh_Kx2.CyberValiting, AddressOf V_Nh_kx2
        AddHandler TxtNh_Kx2.CyberLeave, AddressOf L_Nh_kx2
        '--VT3
        RemoveHandler TxtNh_Kx3.CyberValiting, AddressOf V_Nh_kx3
        RemoveHandler TxtNh_Kx3.CyberLeave, AddressOf L_Nh_kx3
        AddHandler TxtNh_Kx3.CyberValiting, AddressOf V_Nh_kx3
        AddHandler TxtNh_Kx3.CyberLeave, AddressOf L_Nh_kx3
        '----------
        AddHandler TxtMa_Bp.CyberValiting, AddressOf V_Ma_BP
        AddHandler TxtMa_Bp.CyberLeave, AddressOf L_Ma_bp
        '----
        AddHandler TxtMa_HS.CyberValiting, AddressOf V_Ma_hs
        AddHandler TxtMa_HS.CyberLeave, AddressOf L_Ma_HS
    End Sub


#End Region
#Region "Valid"

#Region "Valid --- Ma_Kx"
    Private Sub V_Ma_Kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_KX.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Kx", "DmKx", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_KX.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_KX.Text = DrReturn.Item("Ma_Kx")
            TxtTen_kx.Text = DrReturn.Item("Ten_Kx")
        Else
            TxtMa_KX.Text = ""
            TxtTen_kx.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid ---MA_MAU"
    Private Sub V_Ma_mau(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_mau.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_mau", "DmMauxe", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_mau(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_mau.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_mau.Text = DrReturn.Item("Ma_mau")
            txtTen_Mau.Text = DrReturn.Item("Ten_mau")
        Else
            TxtMa_mau.Text = ""
            txtTen_Mau.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid ---MA_HS"
    Private Sub V_Ma_HS(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_HS.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_HS", "dmhs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HS(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_HS.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_HS.Text = DrReturn.Item("Ma_HS")
            txtTen_Hs.Text = DrReturn.Item("Ten_Hs")
        Else
            TxtMa_HS.Text = ""
            txtTen_Hs.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid ---MA_BP"
    Private Sub V_Ma_Bp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Bp.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Bp", "dmBP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Bp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Bp.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Bp.Text = DrReturn.Item("Ma_Bp")
            txtTen_bp.Text = DrReturn.Item("Ten_bp")
        Else
            TxtMa_Bp.Text = ""
            txtTen_bp.Text = ""
            Exit Sub
        End If
    End Sub
#End Region

#Region "Vali --- Nh_kx1"
    Private Sub V_Nh_kx1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        sender.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_nh", "DmNhKx", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_Nh_kx1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_Kx1.Text = "" Then
            txtten_nhKX1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Kx1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx1.Text = DrReturn.Item("Ma_Nh")
            txtten_nhKX1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kx1.Text = ""
            txtten_nhKX1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_kx2"
    Private Sub V_Nh_kx2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        sender.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_nh", "DmNhKx", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_Nh_kx2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_Kx2.Text = "" Then
            txtten_nhkx2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Kx2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx2.Text = DrReturn.Item("Ma_Nh")
            txtten_nhkx2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kx2.Text = ""
            txtten_nhkx2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_kx3"
    Private Sub V_Nh_kx3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Kx3.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_NH", "DmNhKx", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_Nh_kx3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_Kx3.Text = "" Then
            txtten_nhKX3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Kx3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx3.Text = DrReturn.Item("Ma_Nh")
            txtten_nhKX3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kx3.Text = ""
            txtten_nhKX3.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------
        '-----------------------------------------------------------------------------
       

        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Dim M_strParameterStore = CbbM_Thang.SelectedValue.ToString.Trim & "#" & CbbM_Nam.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_KX.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_mau.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtSo_khung.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_HS.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Bp.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Kx1.Text.Trim()
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Kx2.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Kx3.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & CyberMe.GetLoai_BC(ChkVND, ChkNT)
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs_Filter
        M_strParameterStore = M_strParameterStore & "#" & Me.User_Name.Trim
        '-----------------------------------------------------------------------------
        Me.is_continue = True
        Dim M_strFieldValue As String = ""
        Dim M_strFieldName As String = ""
        CyberSmodb.GetValueControler(Me, M_strFieldName, M_strFieldValue, "")
        Me.Tag_Field = M_strFieldName
        Me.Tag_Value = M_strFieldValue
        CyberSmLib.SaveRegistry(Me, Me.sysvar)
        Me.Tag = M_strParameterStore
        Me.Close()
    End Sub
    Private Sub V_Exit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub V_AddMenuShorcut()
        Dim mnItems = New ContextMenu
        Dim mnItemsNhan As New MenuItem(IIf(Me.LAN = "V", "Chấp nhận", "OK"), AddressOf V_Nhan, Keys.Control + Keys.Enter)
        Dim mnItemsExit As New MenuItem(IIf(Me.LAN = "V", "Quay ra", "Exit"), AddressOf V_Exit, Keys.Escape)
        mnItems.MenuItems.Add(mnItemsNhan)
        mnItems.MenuItems.Add(mnItemsExit)
        Me.ContextMenu = mnItems
    End Sub
#End Region
    Private Function CreateTableMonth() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Thang")
        _Return.Columns.Add("Ten_Thang")
        _Return.Columns.Add("Ten_Thang2")
        _Return.Columns.Add("Default")
        Dim _Thang As String = ""
        Dim _Default As String = "0"

        For i As Integer = 1 To 12
            _Thang = Strings.Right("00" + i.ToString.Trim, 2).Trim
            If Now.Date.Month = i Then
                _Default = "1"
            Else
                _Default = "0"
            End If
            _Return.Rows.Add(_Thang.ToString, "Tháng " + _Thang, "Month " + _Thang, _Default)
        Next
        CreateTableMonth = _Return
    End Function
    Private Function CreateTableYear() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Nam")
        _Return.Columns.Add("Ten_Nam")
        _Return.Columns.Add("Ten_Nam2")
        _Return.Columns.Add("Default")

        Dim _CurYear As Integer = Now.Year

        Dim _Nam As String = ""
        Dim _Default As String = "0"

        For i As Integer = _CurYear - 10 To _CurYear + 10
            _Nam = Strings.Right("0000" + i.ToString.Trim, 4).Trim

            If Now.Year = i Then
                _Default = "1"
            Else
                _Default = "0"
            End If
            _Return.Rows.Add(_Nam.ToString, "Năm " + _Nam, "Year " + _Nam, _Default)
        Next
        CreateTableYear = _Return
    End Function
End Class
