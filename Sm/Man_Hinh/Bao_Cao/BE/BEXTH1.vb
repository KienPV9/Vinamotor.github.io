﻿Public Class BEXTH1
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim _DtLoai_Phieu As DataTable
    Private Sub BEXTH1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_AddMenuShorcut()
        V_Load()
        V_Addhander()
    End Sub
#Region "Load"
    Private Sub V_Load()
        Dim _DsGroup As New DataSet

        _DsGroup = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "SysNhapXuat#CP_NAME= N'NHAP_XUAT_KHO_XE" & Me.Para(Me.VT_PARA + 2).ToString.Trim & "' AND Acti = '1'#ID")
        _DtLoai_Phieu = _DsGroup.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(Me.CbbLoai_Phieu, _DtLoai_Phieu, "Nhom", "Ten_nhom")
        'RemoveHandler CbbLoai_Phieu.SelectedIndexChanged, AddressOf CbbLoai_Phieu_SelectedIndexChanged
        'AddHandler CbbLoai_Phieu.SelectedIndexChanged, AddressOf CbbLoai_Phieu_SelectedIndexChanged

        RemoveHandler CbbLoai_Phieu.SelectedValueChanged, AddressOf V_LoadMa_GD
        AddHandler CbbLoai_Phieu.SelectedValueChanged, AddressOf V_LoadMa_GD

        'SelectedValueChanged
        V_LoadMa_GD(New System.Object, New System.EventArgs)
        '--------------------------------------------------------------------
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '----Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)
        TxtMa_kho.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_kho)
        TxtMa_KX.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_KX)
        TxtMa_mau.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_mau)

        TxtTen_kho.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_kho", "DmKho", "(Ma_kho = N'" + TxtMa_kho.Text.Trim + "')", CyberSmLib)
        TxtTen_kx.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_KX", "Dmkx", "(Ma_KX= N'" + TxtMa_KX.Text.Trim + "')", CyberSmLib)
        TxtTen_mau.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_mau", "DmMauxe", "(Ma_mau= N'" + TxtMa_mau.Text.Trim + "')", CyberSmLib)

        TxtNh_kx1.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhVt", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_kx1.Text.Trim + "')", CyberSmLib)
        TxtNh_kx2.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhVt", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_kx2.Text.Trim + "')", CyberSmLib)
        TxtNh_kx3.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhVt", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_kx3.Text.Trim + "')", CyberSmLib)

        '
        TxtMa_Vv.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Vv)
        TxtMa_HD.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_HD)
        TxtMa_phi.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_phi)
        TxtMa_Sp.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Sp)
        Txtma_Ku.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, Txtma_Ku)

        TxtMa_TTLN.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_TTLN)
        TxtMa_TTCP.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_TTCP)
        TxtMa_Bp.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Bp)
        TxtMa_Hs.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Hs)
        TxtMa_CD.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_CD)

        TxtMa_Td1.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Td1)
        TxtMa_Td2.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Td2)
        TxtMa_Td3.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Td3)
        TxtMa_Td4.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Td4)
        TxtMa_Td5.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Td5)
        TxtMa_Db.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Db)
        TxtMa_Lo.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Lo)


        TxtTen_Vv.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_VV", "DmVV", "(Ma_VV= N'" + TxtMa_Vv.Text.Trim + "')", CyberSmLib)
        TxtTen_HD.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_HD", "DmHD", "(Ma_HD= N'" + TxtMa_HD.Text.Trim + "')", CyberSmLib)
        TxtTen_Phi.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Phi", "DmPhi", "(Ma_Phi= N'" + TxtMa_phi.Text.Trim + "')", CyberSmLib)
        TxtTen_Sp.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Sp", "DmSp", "(Ma_Sp= N'" + TxtMa_Sp.Text.Trim + "')", CyberSmLib)
        TxtTen_ku.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Ku", "DmKu", "(Ma_Ku= N'" + Txtma_Ku.Text.Trim + "')", CyberSmLib)

        TxtTen_TTLN.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TTLN", "DmTTLN", "(Ma_TTLN= N'" + TxtMa_TTLN.Text.Trim + "')", CyberSmLib)
        TxtTen_TTCP.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TTCP", "DmTTCP", "(Ma_TTCP= N'" + TxtMa_TTCP.Text.Trim + "')", CyberSmLib)
        TxtTen_Bp.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_BP", "DmBP", "(Ma_BP= N'" + TxtMa_Bp.Text.Trim + "')", CyberSmLib)
        TxtTen_Hs.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_HS", "DmHS", "(Ma_HS= N'" + TxtMa_Hs.Text.Trim + "')", CyberSmLib)
        TxtTen_CD.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_CD", "DmCD", "(Ma_CD= N'" + TxtMa_CD.Text.Trim + "')", CyberSmLib)

        TxtTen_Td1.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TD1", "DmTD1", "(Ma_TD1= N'" + TxtMa_Td1.Text.Trim + "')", CyberSmLib)
        TxtTen_Td2.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TD2", "DmTD2", "(Ma_TD2= N'" + TxtMa_Td2.Text.Trim + "')", CyberSmLib)
        TxtTen_Td3.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TD3", "DmTD3", "(Ma_TD3= N'" + TxtMa_Td3.Text.Trim + "')", CyberSmLib)
        TxtTen_Td4.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TD4", "DmTD4", "(Ma_TD4= N'" + TxtMa_Td4.Text.Trim + "')", CyberSmLib)
        TxtTen_Td5.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TD5", "DmTD5", "(Ma_TD5= N'" + TxtMa_Td5.Text.Trim + "')", CyberSmLib)

        TxtTen_DB.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_DB", "DmDB", "(Ma_DB= N'" + TxtMa_Db.Text.Trim + "')", CyberSmLib)
        TxtTen_lo.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_LO", "DmLO", "(Ma_Lo= N'" + TxtMa_Lo.Text.Trim + "')", CyberSmLib)

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
        '-- ma Vt
        AddHandler TxtMa_KX.CyberValiting, AddressOf V_Ma_kx
        AddHandler TxtMa_KX.CyberLeave, AddressOf L_Ma_kx

        '-- ma kho
        AddHandler TxtMa_kho.CyberValiting, AddressOf V_Ma_KHo
        AddHandler TxtMa_kho.CyberLeave, AddressOf L_Ma_KHo

        '-- Tk_VT
        AddHandler TxtMa_mau.CyberValiting, AddressOf V_ma_mau
        AddHandler TxtMa_mau.CyberLeave, AddressOf L_ma_mau
        '-- nh_Vt1
        AddHandler TxtNh_kx1.CyberValiting, AddressOf V_Nh_kx1
        AddHandler TxtNh_kx1.CyberLeave, AddressOf L_Nh_kx1
        '-- nh_Vt2
        AddHandler TxtNh_kx2.CyberValiting, AddressOf V_Nh_kx2
        AddHandler TxtNh_kx2.CyberLeave, AddressOf L_Nh_kx2
        '-- nh_Vt3
        AddHandler TxtNh_kx3.CyberValiting, AddressOf V_Nh_kx3
        AddHandler TxtNh_kx3.CyberLeave, AddressOf L_Nh_kx3
        '-------------------------------------------------------------------
        '--Vv
        RemoveHandler TxtMa_Vv.CyberValiting, AddressOf V_Ma_Vv
        RemoveHandler TxtMa_Vv.CyberLeave, AddressOf L_Ma_Vv
        AddHandler TxtMa_Vv.CyberValiting, AddressOf V_Ma_Vv
        AddHandler TxtMa_Vv.CyberLeave, AddressOf L_Ma_Vv
        '--HD
        RemoveHandler TxtMa_HD.CyberValiting, AddressOf V_Ma_HD
        RemoveHandler TxtMa_HD.CyberLeave, AddressOf L_Ma_HD
        AddHandler TxtMa_HD.CyberValiting, AddressOf V_Ma_HD
        AddHandler TxtMa_HD.CyberLeave, AddressOf L_Ma_HD
        '--Phi
        RemoveHandler TxtMa_phi.CyberValiting, AddressOf V_Ma_Phi
        RemoveHandler TxtMa_phi.CyberLeave, AddressOf L_Ma_Phi
        AddHandler TxtMa_phi.CyberValiting, AddressOf V_Ma_Phi
        AddHandler TxtMa_phi.CyberLeave, AddressOf L_Ma_Phi
        '--Sp
        RemoveHandler TxtMa_Sp.CyberValiting, AddressOf V_Ma_Sp
        RemoveHandler TxtMa_Sp.CyberLeave, AddressOf L_Ma_Sp
        AddHandler TxtMa_Sp.CyberValiting, AddressOf V_Ma_Sp
        AddHandler TxtMa_Sp.CyberLeave, AddressOf L_Ma_Sp
        '--Ku
        RemoveHandler Txtma_Ku.CyberValiting, AddressOf V_Ma_Ku
        RemoveHandler Txtma_Ku.CyberLeave, AddressOf L_Ma_Ku
        AddHandler Txtma_Ku.CyberValiting, AddressOf V_Ma_Ku
        AddHandler Txtma_Ku.CyberLeave, AddressOf L_Ma_Ku

        '--TTLN
        RemoveHandler TxtMa_TTLN.CyberValiting, AddressOf V_Ma_TTLN
        RemoveHandler TxtMa_TTLN.CyberLeave, AddressOf L_Ma_TTLN
        AddHandler TxtMa_TTLN.CyberValiting, AddressOf V_Ma_TTLN
        AddHandler TxtMa_TTLN.CyberLeave, AddressOf L_Ma_TTLN

        '--TTCP
        RemoveHandler TxtMa_TTCP.CyberValiting, AddressOf V_Ma_TTCP
        RemoveHandler TxtMa_TTCP.CyberLeave, AddressOf L_Ma_TTCP
        AddHandler TxtMa_TTCP.CyberValiting, AddressOf V_Ma_TTCP
        AddHandler TxtMa_TTCP.CyberLeave, AddressOf L_Ma_TTCP


        '--Bp
        RemoveHandler TxtMa_Bp.CyberValiting, AddressOf V_Ma_Bp
        RemoveHandler TxtMa_Bp.CyberLeave, AddressOf L_Ma_Bp
        AddHandler TxtMa_Bp.CyberValiting, AddressOf V_Ma_Bp
        AddHandler TxtMa_Bp.CyberLeave, AddressOf L_Ma_Bp

        '--Hs
        RemoveHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        RemoveHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs
        AddHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        AddHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs

        '--CD
        RemoveHandler TxtMa_CD.CyberValiting, AddressOf V_Ma_CD
        RemoveHandler TxtMa_CD.CyberLeave, AddressOf L_Ma_CD
        AddHandler TxtMa_CD.CyberValiting, AddressOf V_Ma_CD
        AddHandler TxtMa_CD.CyberLeave, AddressOf L_Ma_CD

        '--TD1
        RemoveHandler TxtMa_Td1.CyberValiting, AddressOf V_Ma_TD1
        RemoveHandler TxtMa_Td1.CyberLeave, AddressOf L_Ma_TD1
        AddHandler TxtMa_Td1.CyberValiting, AddressOf V_Ma_TD1
        AddHandler TxtMa_Td1.CyberLeave, AddressOf L_Ma_TD1
        '--TD2
        RemoveHandler TxtMa_Td2.CyberValiting, AddressOf V_Ma_TD2
        RemoveHandler TxtMa_Td2.CyberLeave, AddressOf L_Ma_TD2
        AddHandler TxtMa_Td2.CyberValiting, AddressOf V_Ma_TD2
        AddHandler TxtMa_Td2.CyberLeave, AddressOf L_Ma_TD2
        '--TD3
        RemoveHandler TxtMa_Td3.CyberValiting, AddressOf V_Ma_TD3
        RemoveHandler TxtMa_Td3.CyberLeave, AddressOf L_Ma_TD3
        AddHandler TxtMa_Td3.CyberValiting, AddressOf V_Ma_TD3
        AddHandler TxtMa_Td3.CyberLeave, AddressOf L_Ma_TD3
        '--TD4
        RemoveHandler TxtMa_Td4.CyberValiting, AddressOf V_Ma_TD4
        RemoveHandler TxtMa_Td4.CyberLeave, AddressOf L_Ma_TD4
        AddHandler TxtMa_Td4.CyberValiting, AddressOf V_Ma_TD4
        AddHandler TxtMa_Td4.CyberLeave, AddressOf L_Ma_TD4
        '--TD5
        RemoveHandler TxtMa_Td5.CyberValiting, AddressOf V_Ma_TD5
        RemoveHandler TxtMa_Td5.CyberLeave, AddressOf L_Ma_TD5
        AddHandler TxtMa_Td5.CyberValiting, AddressOf V_Ma_TD5
        AddHandler TxtMa_Td5.CyberLeave, AddressOf L_Ma_TD5
        '--DB
        RemoveHandler TxtMa_Db.CyberValiting, AddressOf V_Ma_DB
        RemoveHandler TxtMa_Db.CyberLeave, AddressOf L_Ma_DB
        AddHandler TxtMa_Db.CyberValiting, AddressOf V_Ma_DB
        AddHandler TxtMa_Db.CyberLeave, AddressOf L_Ma_DB
        '--LO
        RemoveHandler TxtMa_Lo.CyberValiting, AddressOf V_Ma_Lo
        RemoveHandler TxtMa_Lo.CyberLeave, AddressOf L_Ma_Lo
        AddHandler TxtMa_Lo.CyberValiting, AddressOf V_Ma_Lo
        AddHandler TxtMa_Lo.CyberLeave, AddressOf L_Ma_Lo
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
            txtten_kh.Text = DrReturn.Item("Ten_Kh")
        Else
            Txtma_kh.Text = ""
            txtten_kh.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_kx"
    Private Sub V_Ma_kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_KX.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_kx", "Dmkx", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_KX.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_KX.Text = DrReturn.Item("Ma_kx")
            TxtTen_kx.Text = DrReturn.Item("Ten_kx")
        Else
            TxtMa_KX.Text = ""
            TxtTen_kx.Text = ""
            Exit Sub
        End If
    End Sub

#End Region

#Region "Valid --- Ma_mau"
    Private Sub V_Ma_mau(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_mau.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "ma_mau", "Dmmauxe", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_mau(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_mau.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_mau.Text = DrReturn.Item("Ma_mau")
            TxtTen_mau.Text = DrReturn.Item("Ten_mau")
        Else
            TxtMa_mau.Text = ""
            TxtTen_mau.Text = ""
            Exit Sub
        End If
    End Sub
#End Region

#Region "Valid --- Nh_kx1"
    Private Sub V_Nh_kx1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_kx1.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "ma_nh", "DmNhKx", "1=1", "loai_nh='1'")
    End Sub
    Private Sub L_Nh_kx1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_kx1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_kx1.Text = DrReturn.Item("ma_nh")
            Txtten_Nh_kx1.Text = DrReturn.Item("Ten_nh")
        Else
            TxtNh_kx1.Text = ""
            Txtten_Nh_kx1.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Nh_kx2"
    Private Sub V_Nh_kx2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_kx2.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "ma_nh", "DmNhKx", "1=1", "loai_nh='2'")
    End Sub
    Private Sub L_Nh_kx2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_kx2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_kx2.Text = DrReturn.Item("ma_nh")
            Txtten_Nh_kx2.Text = DrReturn.Item("Ten_nh")
        Else
            TxtNh_kx2.Text = ""
            Txtten_Nh_kx2.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Nh_kx3"
    Private Sub V_Nh_kx3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_kx3.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "ma_nh", "DmNhKx", "1=1", "loai_nh='3'")
    End Sub
    Private Sub L_Nh_kx3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_kx3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_kx3.Text = DrReturn.Item("ma_nh")
            TxtTen_Nh_kx3.Text = DrReturn.Item("Ten_nh")
        Else
            TxtNh_kx3.Text = ""
            Txtten_Nh_kx3.Text = ""
            Exit Sub
        End If
    End Sub
#End Region


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
#Region "Vali --- Ma_Vv"
    Private Sub V_Ma_Vv(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Vv.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Vv", "DmVv", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Vv(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Vv.Text = "" Then
            TxtTen_Vv.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Vv.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Vv.Text = DrReturn.Item("Ma_Vv")
            TxtTen_Vv.Text = DrReturn.Item("Ten_Vv")
        Else
            TxtMa_Vv.Text = ""
            TxtTen_Vv.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_HD"
    Private Sub V_Ma_HD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_HD.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_HD", "DmHD", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_HD.Text = "" Then
            TxtTen_HD.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_HD.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_HD.Text = DrReturn.Item("Ma_HD")
            TxtTen_HD.Text = DrReturn.Item("Ten_HD")
        Else
            TxtMa_HD.Text = ""
            TxtTen_HD.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Phi"
    Private Sub V_Ma_Phi(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_phi.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Phi", "DmPhi", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Phi(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_phi.Text = "" Then
            TxtTen_Phi.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_phi.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_phi.Text = DrReturn.Item("Ma_Phi")
            TxtTen_Phi.Text = DrReturn.Item("Ten_Phi")
        Else
            TxtMa_phi.Text = ""
            TxtTen_Phi.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Sp"
    Private Sub V_Ma_Sp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Sp.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Sp", "DmSp", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Sp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Sp.Text = "" Then
            TxtTen_Sp.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Sp.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Sp.Text = DrReturn.Item("Ma_Sp")
            TxtTen_Sp.Text = DrReturn.Item("Ten_Sp")
        Else
            TxtMa_Sp.Text = ""
            TxtTen_Sp.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Ku"
    Private Sub V_Ma_Ku(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Txtma_Ku.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Ku", "DmKu", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Ku(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Txtma_Ku.Text = "" Then
            TxtTen_ku.Text = ""
            Exit Sub
        End If
        DrReturn = Txtma_Ku.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            Txtma_Ku.Text = DrReturn.Item("Ma_Ku")
            TxtTen_ku.Text = DrReturn.Item("Ten_Ku")
        Else
            Txtma_Ku.Text = ""
            TxtTen_ku.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TTLN"
    Private Sub V_Ma_TTLN(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_TTLN.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_TTLN", "DmTTLN", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TTLN(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_TTLN.Text = "" Then
            TxtTen_TTLN.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TTLN.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_TTLN.Text = DrReturn.Item("Ma_TTLN")
            TxtTen_TTLN.Text = DrReturn.Item("Ten_TTLN")
        Else
            TxtMa_TTLN.Text = ""
            TxtTen_TTLN.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TTCP"
    Private Sub V_Ma_TTCP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_TTCP.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_TTCP", "DmTTCP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TTCP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_TTCP.Text = "" Then
            TxtTen_TTCP.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TTCP.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_TTCP.Text = DrReturn.Item("Ma_TTCP")
            TxtTen_TTCP.Text = DrReturn.Item("Ten_TTCP")
        Else
            TxtMa_TTCP.Text = ""
            TxtTen_TTCP.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Bp"
    Private Sub V_Ma_Bp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Bp.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Bp", "DmBp", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Bp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Bp.Text = "" Then
            TxtTen_Bp.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Bp.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Bp.Text = DrReturn.Item("Ma_Bp")
            TxtTen_Bp.Text = DrReturn.Item("Ten_Bp")
        Else
            TxtMa_Bp.Text = ""
            TxtTen_Bp.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Hs"
    Private Sub V_Ma_Hs(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Hs.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Hs(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Hs.Text = "" Then
            TxtTen_Hs.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Hs.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Hs.Text = DrReturn.Item("Ma_Hs")
            TxtTen_Hs.Text = DrReturn.Item("Ten_Hs")
        Else
            TxtMa_Hs.Text = ""
            TxtTen_Hs.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_CD"
    Private Sub V_Ma_CD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_CD.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_CD", "DmCD", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_CD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_CD.Text = "" Then
            TxtTen_CD.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_CD.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_CD.Text = DrReturn.Item("Ma_CD")
            TxtTen_CD.Text = DrReturn.Item("Ten_CD")
        Else
            TxtMa_CD.Text = ""
            TxtTen_CD.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD1"
    Private Sub V_Ma_TD1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_TD1.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, Me.Appconn, DsLookup, "Ma_TD1", "DmTD1", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Td1.Text = "" Then
            TxtTen_Td1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Td1.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Td1.Text = DrReturn.Item("Ma_TD1")
            TxtTen_Td1.Text = DrReturn.Item("Ten_TD1")
        Else
            TxtMa_Td1.Text = ""
            TxtTen_Td1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD2"
    Private Sub V_Ma_TD2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_TD2.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, Me.Appconn, DsLookup, "Ma_TD2", "DmTD2", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Td2.Text = "" Then
            TxtTen_Td2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Td2.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Td2.Text = DrReturn.Item("Ma_TD2")
            TxtTen_Td2.Text = DrReturn.Item("Ten_TD2")
        Else
            TxtMa_Td2.Text = ""
            TxtTen_Td2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD3"
    Private Sub V_Ma_TD3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_TD3.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, Me.Appconn, DsLookup, "Ma_TD3", "DmTD3", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Td3.Text = "" Then
            TxtTen_Td3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Td3.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Td3.Text = DrReturn.Item("Ma_TD3")
            TxtTen_Td3.Text = DrReturn.Item("Ten_TD3")
        Else
            TxtMa_Td3.Text = ""
            TxtTen_Td3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD4"
    Private Sub V_Ma_TD4(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Td4.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, Me.Appconn, DsLookup, "Ma_TD4", "DmTD4", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD4(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Td4.Text = "" Then
            TxtTen_Td4.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Td4.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Td4.Text = DrReturn.Item("Ma_TD4")
            TxtTen_Td4.Text = DrReturn.Item("Ten_TD4")
        Else
            TxtMa_Td4.Text = ""
            TxtTen_Td4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD5"
    Private Sub V_Ma_TD5(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_TD5.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, Me.Appconn, DsLookup, "Ma_TD5", "DmTD5", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD5(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Td5.Text = "" Then
            TxtTen_Td5.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Td5.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Td5.Text = DrReturn.Item("Ma_TD5")
            TxtTen_Td5.Text = DrReturn.Item("Ten_TD5")
        Else
            TxtMa_Td5.Text = ""
            TxtTen_Td5.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_DB"
    Private Sub V_Ma_DB(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Db.V_LookUp(Me.LAN, Me.Para, Me.sysvar, Me.AppConn, DsLookup, "Ma_DB", "DmDB", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_DB(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Db.Text = "" Then
            TxtTen_DB.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Db.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Db.Text = DrReturn.Item("Ma_DB")
            TxtTen_DB.Text = DrReturn.Item("Ten_DB")
        Else
            TxtMa_Db.Text = ""
            TxtTen_DB.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Lo"
    Private Sub V_Ma_Lo(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Lo.V_LookUp(Me.LAN, Me.Para, Me.sysvar, Me.AppConn, DsLookup, "Ma_Lo", "DmLo", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Lo(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Lo.Text = "" Then
            TxtTen_lo.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Lo.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Lo.Text = DrReturn.Item("Ma_Lo")
            TxtTen_lo.Text = DrReturn.Item("Ten_Lo")
        Else
            TxtMa_Lo.Text = ""
            TxtTen_lo.Text = ""
        End If
    End Sub
#End Region
#End Region
    Private Sub V_LoadMa_GD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ma_Ct As String = ""
        Try
            _Ma_Ct = CbbLoai_Phieu.SelectedValue.ToString.Trim
        Catch ex As Exception
        End Try
        CyberMe.V_GetMaGD(AppConn, _Ma_Ct, CbbMa_GD, CyberSmLib, CyberFill)
    End Sub
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value
        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim


        Dim M_strParameterStore As String = Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim


        M_strParameterStore = M_strParameterStore & "#" & CyberMe.V_GetValueCombox(CbbLoai_Phieu)
        M_strParameterStore = M_strParameterStore & "#" & CyberMe.V_GetValueCombox(CbbMa_GD)
        M_strParameterStore = M_strParameterStore & "#" & TxtSo_Ct1.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtSo_Ct2.Text.Trim()
        M_strParameterStore = M_strParameterStore & "#" & Me.Para(Me.VT_PARA + 2).Trim()

        M_strParameterStore = M_strParameterStore & "#" & If(ChkGroup1.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & If(ChkGroup2.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & If(ChkGroup3.Checked, "1", "0")

        M_strParameterStore = M_strParameterStore & "#" & TxtMa_mau.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtSo_khung.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_kx1.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_kx2.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_kx3.Text.Trim

        M_strParameterStore = M_strParameterStore & "#" & Txtma_kh.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_KX.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_kho.Text.Trim

        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Vv.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_HD.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_phi.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Sp.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & Txtma_Ku.Text.Trim

        M_strParameterStore = M_strParameterStore & "#" & TxtMa_TTLN.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_TTCP.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Bp.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Hs.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_CD.Text.Trim

        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Td1.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Td2.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Td3.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Td4.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Td5.Text.Trim

        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Db.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Lo.Text.Trim


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