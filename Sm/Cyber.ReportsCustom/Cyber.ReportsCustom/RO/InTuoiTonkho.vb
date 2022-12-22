﻿Public Class InTuoiTonkho
    Dim CyberMe As New Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim _DtGroupBy As DataTable
    Private Sub InTuoiTonkho_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _DtGroupBy = GetGroupBy()
        V_AddMenuShorcut()
        V_Load()
        V_Addhander()
    End Sub
#Region "Load"
    Private Function GetGroupBy() As DataTable   
        '----------Tổng hợp - Chi tiết
        Dim _TH_CT As New DataTable
        _TH_CT.Columns.Add("Ma_TH_CT")
        _TH_CT.Columns.Add("Ten_TH_CT")
        _TH_CT.Columns.Add("Ngam_Dinh")
        _TH_CT.Rows.Add("0", " Chi tiết theo từng mặt hàng", "1")
        _TH_CT.Rows.Add("1", " Tổng hợp theo từng nhóm vật tư", "0")
        CyberFill.V_FillComBoxDefaul(Me.cbb_TH_CT, _TH_CT, "Ma_TH_CT", "Ten_TH_CT", "Ngam_Dinh")

        '----------Tính giá
        Dim _Return As New DataTable
        _Return.Columns.Add("Ma_PP_Tinh")
        _Return.Columns.Add("Ten_PP_Tinh")
        _Return.Columns.Add("Ngam_Dinh")
        _Return.Rows.Add("0", " Tính giá trị tồn kho theo giá bình quân", "1")
        _Return.Rows.Add("1", " Tính giá trị tồn kho theo giá nhập", "0")
        CyberFill.V_FillComBoxDefaul(Me.CbbPP_Tinh, _Return, "Ma_PP_Tinh", "Ten_PP_Tinh", "Ngam_Dinh")

    End Function

    Private Sub V_Load()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '----Set
        TxtM_Ngay_Ct.Value = Now.Date
        TxtM_Ngay_Ct.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct)

        TxtMa_kho.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_kho)
        TxtMa_Vt.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Vt)

        If TxtMa_kho.Text.Trim = "" Then TxtTen_kho.Text = "" Else TxtTen_kho.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_kho", "DmKho", "(Ma_kho = N'" + TxtMa_kho.Text.Trim + "')", CyberSmLib)
        If TxtMa_Vt.Text.Trim = "" Then TxtTen_Vt.Text = "" Else TxtTen_Vt.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_Vt", "DmVt", "(Ma_Vt= N'" + TxtMa_Vt.Text.Trim + "')", CyberSmLib)
        If TxtTk_Vt.Text.Trim = "" Then txtten_tk0.Text = "" Else TxtTen_Vt.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_TK0", "DmTK0", "(TK0 = N'" + TxtTk_Vt.Text.Trim + "')", CyberSmLib)

        If TxtNh_vt1.Text.Trim = "" Then TxtTen_Nh_Vt1.Text = "" Else TxtTen_Nh_Vt1.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhVt", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_vt1.Text.Trim + "')", CyberSmLib)
        If TxtNh_vt2.Text.Trim = "" Then TxtTen_Nh_Vt2.Text = "" Else TxtTen_Nh_Vt2.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhVt", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_vt2.Text.Trim + "')", CyberSmLib)
        If TxtNh_vt3.Text.Trim = "" Then TxtTen_Nh_Vt3.Text = "" Else TxtTen_Nh_Vt3.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhVt", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_vt3.Text.Trim + "')", CyberSmLib)

        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit

        '--ma_kho
        AddHandler TxtMa_kho.CyberValiting, AddressOf V_Ma_KHo
        AddHandler TxtMa_kho.CyberLeave, AddressOf L_Ma_KHo

        '--Ma_VT
        AddHandler TxtMa_Vt.CyberValiting, AddressOf V_Ma_Vt
        AddHandler TxtMa_Vt.CyberLeave, AddressOf L_Ma_Vt
        '-- Tk vt
        AddHandler TxtTk_Vt.CyberValiting, AddressOf V_Tk_Vt
        AddHandler TxtTk_Vt.CyberLeave, AddressOf L_Tk_Vt
        '--Vt1
        RemoveHandler TxtNh_vt1.CyberValiting, AddressOf V_NH_VT1
        RemoveHandler TxtNh_vt1.CyberLeave, AddressOf L_NH_VT1
        AddHandler TxtNh_vt1.CyberValiting, AddressOf V_NH_VT1
        AddHandler TxtNh_vt1.CyberLeave, AddressOf L_NH_VT1
        '--VT2
        RemoveHandler TxtNh_vt2.CyberValiting, AddressOf V_NH_VT2
        RemoveHandler TxtNh_vt2.CyberLeave, AddressOf L_NH_VT2
        AddHandler TxtNh_vt2.CyberValiting, AddressOf V_NH_VT2
        AddHandler TxtNh_vt2.CyberLeave, AddressOf L_NH_VT2
        '--VT3
        RemoveHandler TxtNh_vt3.CyberValiting, AddressOf V_NH_VT3
        RemoveHandler TxtNh_vt3.CyberLeave, AddressOf L_NH_VT3
        AddHandler TxtNh_vt3.CyberValiting, AddressOf V_NH_VT3
        AddHandler TxtNh_vt3.CyberLeave, AddressOf L_NH_VT3
    End Sub
#End Region
#Region "Valid"
#Region "Valid --- Ma_KHo"
    Private Sub V_Ma_KHo(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_kho.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_KHo", "DmKHo", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KHo(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_kho.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_kho.Text = DrReturn.Item("Ma_kho")
            TxtTen_kho.Text = DrReturn.Item("Ten_Kho")
        Else
            TxtMa_kho.Text = ""
            TxtTen_kho.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Vt"
    Private Sub V_Ma_Vt(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Vt.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Vt", "DmVt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Vt(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Vt.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Vt.Text = DrReturn.Item("Ma_Vt")
            TxtTen_Vt.Text = DrReturn.Item("Ten_Vt")
        Else
            TxtMa_Vt.Text = ""
            TxtTen_Vt.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid ---TK_VT"
    Private Sub V_Tk_Vt(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtTk_Vt.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "tk0", "Dmtk0", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_Vt(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtTk_Vt.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_Vt.Text = DrReturn.Item("tk0")
            txtten_tk0.Text = DrReturn.Item("Ten_tk0")
        Else
            TxtTk_Vt.Text = ""
            txtten_tk0.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Vali --- NH_VT1"
    Private Sub V_NH_VT1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        sender.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_nh", "DmNhVT", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_VT1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_vt1.Text = "" Then
            txtten_nh_vt1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_vt1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_vt1.Text = DrReturn.Item("Ma_Nh")
            txtten_nh_vt1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_vt1.Text = ""
            txtten_nh_vt1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_VT2"
    Private Sub V_NH_VT2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        sender.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_nh", "DmNhVT", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_VT2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_vt2.Text = "" Then
            txtten_nh_vt2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_vt2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_vt2.Text = DrReturn.Item("Ma_Nh")
            txtten_nh_vt2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_vt2.Text = ""
            txtten_nh_vt2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_VT3"
    Private Sub V_NH_VT3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_vt3.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_NH", "DmNhVT", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_VT3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_vt3.Text = "" Then
            txtten_nh_vt3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_vt3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_vt3.Text = DrReturn.Item("Ma_Nh")
            txtten_nh_vt3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_vt3.Text = ""
            txtten_nh_vt3.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------
        Dim Dt As Date = TxtM_Ngay_Ct.Value

        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Dim M_strParameterStore As String = ""
        M_strParameterStore = Dt.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & Me.CbbPP_Tinh.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & Me.cbb_TH_CT.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtTk_Vt.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_vt1.Text.Trim()
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_vt2.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_vt3.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Vt.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_kho.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & If(ChkGroup1.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & If(ChkGroup2.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & If(ChkGroup3.Checked, "1", "0")
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
End Class
