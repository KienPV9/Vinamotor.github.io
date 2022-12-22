﻿Public Class ROPT5BK1
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim _Dt_post1, _Dt_post2, _DtMa_TT As DataTable
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet

    Dim M_Ma_CT As String = ""
    Dim M_Ma_Post1 As String = ""
    Dim M_Ma_Post2 As String = ""
    Dim CyberVoucher As New Cyber.Voucher.Sys
    Private Sub ROPT5BK1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        M_Ma_CT = Me.Para(Me.VT_PARA + 2).Trim
        M_Ma_Post1 = Me.Para(Me.VT_PARA + 3).Trim
        M_Ma_Post2 = Me.Para(Me.VT_PARA + 4).Trim
        V_AddMenuShorcut()
        V_Load()
        V_Addhander()

    End Sub
#Region "Load"
#Region "Chi tiet theo"
#End Region
    Private Sub V_Load()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '--------------------------------------------------------------------------------------------------------------------------------------

        Dim _DsMa_TT As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "SysNhapXuat#CP_NAME= N'LOAI_TT' AND Acti = N'1'#ID")
        _DtMa_TT = _DsMa_TT.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(CbbMa_TT, _DtMa_TT, "Nhom", "Ten_nhom")
        _DsMa_TT.Dispose()

        Dim _DsPost As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetMaPostReports", M_Ma_CT & "##")
        _Dt_post1 = _DsPost.Tables(0).Copy
        _Dt_post2 = _DsPost.Tables(1).Copy
        _DsPost.Dispose()
        CyberFill.V_FillComBoxValue(Me.CbbMa_Post1, _Dt_post1, "ma_post", "Ten_post", M_Ma_Post1)
        CyberFill.V_FillComBoxValue(Me.CbbMa_post2, _Dt_post2, "ma_post", "Ten_post", M_Ma_Post2)
        '--------------------------------------------------------------------------------------------------------------------------------------
        '----Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)

        Txtma_kh.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, Txtma_kh)

        If Txtma_kh.Text.Trim = "" Then TxtTen_kh.Text = "" Else TxtTen_kh.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_kh", "DmKh", "(Ma_kh = N'" + Txtma_kh.Text.Trim + "')", CyberSmLib)
   
        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit

        '--ma khach hang
        AddHandler Txtma_kh.CyberValiting, AddressOf V_Ma_KH
        AddHandler Txtma_kh.CyberLeave, AddressOf L_Ma_KH
        '-- ma HS
       
        '-- ma xe
        AddHandler TxtMa_Xe.Leave, AddressOf V_Ma_Xe
        'AddHandler TxtMa_xe.CyberValiting, AddressOf V_Ma_xe
        'AddHandler TxtMa_xe.CyberLeave, AddressOf L_Ma_xe

       

    End Sub
   
#End Region
#Region "Valid"
#Region "Valid --- Ma_KH"
    Private Sub V_Ma_KH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Txtma_kh.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_KH", "DmKH", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = Txtma_kh.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            Txtma_kh.Text = DrReturn.Item("Ma_kh")
            TxtTen_kh.Text = DrReturn.Item("Ten_Kh")
        Else
            Txtma_kh.Text = ""
            TxtTen_kh.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Xe"
    Private Sub V_Ma_Xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Xe.Text.Trim = "" Then Exit Sub
        TxtMa_Xe.Text = CyberVoucher.V_FormatBien_So(TxtMa_Xe.Text, True)
    End Sub
#End Region
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value
        Dim _Ma_TT_Filter As String = Me.CbbMa_TT.SelectedValue.ToString.Trim
        Dim _Ma_Post1_Filter As String = Me.CbbMa_Post1.SelectedValue.ToString.Trim
        Dim _Ma_Post2_Filter As String = Me.CbbMa_post2.SelectedValue.ToString.Trim
        Dim _Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim

        Dim M_strParameterStore As String = _Ma_TT_Filter
        M_strParameterStore = M_strParameterStore & "#" & Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim

        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Xe.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtSo_RO.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & Txtma_kh.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & _Ma_Post1_Filter
        M_strParameterStore = M_strParameterStore & "#" & _Ma_Post2_Filter
        M_strParameterStore = M_strParameterStore & "#" & CyberMe.GetLoai_BC(ChkVND, ChkNT)
        M_strParameterStore = M_strParameterStore & "#" & _Ma_Dvcs_Filter
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
