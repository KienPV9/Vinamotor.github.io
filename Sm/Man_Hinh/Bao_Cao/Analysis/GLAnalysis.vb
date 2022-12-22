﻿Public Class GLAnalysis
    Dim CyberMe As New Sys

    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim DtThang1, DtThang2, DtNam, _DtMa_Ky As DataTable
    Dim _GroupByTH, _GroupByCT As DataTable
    Dim M_Loai_TH As String = "0"

    Dim M_Tk As String = ""
    Dim M_No_Co As String = "1"
    Dim M_Group_By As String = "TK"
    Dim M_So_ky As String = "3"
    Dim CyberVoucher As New Cyber.Voucher.Sys
    Private Sub GLAnalysis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '------------------------------------------------------------
        Dim M_VT_PARA As Integer = CType(Me.Para(0).Trim, Integer)

        Try
            M_Tk = Me.Para(M_VT_PARA + 2)
        Catch ex As Exception
        End Try
        Try
            M_No_Co = Me.Para(M_VT_PARA + 3)
        Catch ex As Exception
        End Try

        Try
            M_Group_By = Me.Para(M_VT_PARA + 4)
        Catch ex As Exception
        End Try

        Try
            M_So_ky = Me.Para(M_VT_PARA + 5)
        Catch ex As Exception
        End Try

        '------------------------------------------------------------
        V_AddMenuShorcut()
        V_Load()
        V_VisibleCT()
        V_Addhander()
        V_VisibleDate()
    End Sub
#Region "Load"
    Private Sub V_VisibleCT()
        If ChkDetail_OK.Checked = True Then CbbGroupByCT.Visible = True Else CbbGroupByCT.Visible = False
    End Sub
    Private Sub V_Detail_OK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_VisibleCT()
    End Sub
    Private Sub V_VisibleDate()
        If CbbMa_Ky.SelectedValue.ToString.Trim < "03" Then
            LabThang.Visible = False
            CbbM_Thang1.Visible = False
            LabNam.Visible = False
            CbbM_Nam.Visible = False
            LabNgay.Visible = True
            TxtM_Ngay_Ct.Visible = True
        Else
            LabThang.Visible = True
            CbbM_Thang1.Visible = True
            LabNam.Visible = True
            CbbM_Nam.Visible = True
            LabNgay.Visible = False
            TxtM_Ngay_Ct.Visible = False
        End If

    End Sub
    Private Sub V_Load()
        TxtM_Ngay_Ct.Value = Now.Date()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '------------------------------------------------------------
        Dim _DsGroup As New DataSet

        _DsGroup = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTH", "TH_GLAnalysis" + "#" + "CT_GLAnalysis" + "#" + "" + "#" + "" + "#" + Me.Ma_Dvcs + "#" + Me.User_Name)
        _GroupByTH = _DsGroup.Tables(0).Copy
        _GroupByCT = _DsGroup.Tables(1).Copy

        CyberFill.V_FillComBoxValue(Me.CbbGroupByTH, _GroupByTH, "Ma", "Ten", M_Group_By)
        CyberFill.V_FillComBoxDefaul(Me.CbbGroupByCT, _GroupByCT, "Ma", "Ten")
        '------------------------------------------------------------
        ' Load loại kỳ
        Dim _DsMaKy As DataSet
        _DsMaKy = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "DmkyBC#Acti = N'1'#ID")
        _DtMa_Ky = _DsMaKy.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(Me.CbbMa_Ky, _DtMa_Ky, "ID", If(Me.LAN = "V", "Title", "Title2"), "Default")
        '------------------------------------------------------------
        'Load PS Nợ / Có
        Dim _Return As New DataTable
        _Return.Columns.Add("Ma_PS")
        _Return.Columns.Add("Ten_PS")
        _Return.Columns.Add("Ngam_Dinh")
        _Return.Rows.Add("1", " Nợ", "1")
        _Return.Rows.Add("2", " Có", "0")
        CyberFill.V_FillComBoxValue(Me.CbbNo_Co, _Return, "Ma_PS", "Ten_PS", M_No_Co)
        '--------------------------------------------------------------------------------------------------------------------------------------
        DtThang1 = CreateTableMonth()
        DtThang2 = CreateTableMonth()
        DtNam = CreateTableYear()
        CyberFill.V_FillComBoxDefaul(CbbM_Thang1, DtThang1, "Thang", IIf(Me.LAN = "V", "Ten_Thang", "Ten_Thang2"), "Default")
        CyberFill.V_FillComBoxDefaul(CbbM_Nam, DtNam, "Nam", IIf(Me.LAN = "V", "Ten_Nam", "Ten_nam2"), "Default")
        '--------------------------------------------------------------------------------------------------------------------------------------
        'Try
        '    CbbGroupByTH.SelectedValue = M_Group_By
        'Catch ex As Exception

        'End Try
        'Try
        '    Cbb_No_Co.SelectedValue = M_No_Co
        'Catch ex As Exception
        'End Try
        TxtSo_Ky.Double = M_So_ky
        '--------------------------------------------------------------------------------------------------------------------------------------
        TxtTK.Text = M_Tk
        If TxtTK.Text.Trim = "" Then TxtTen_TK.Text = "" Else TxtTen_TK.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_TK0", "DmTK0", "(TK0= N'" + TxtTK.Text.Trim + "')", CyberSmLib)
        If TxtTK_Du.Text.Trim = "" Then TxtTen_TK_Du.Text = "" Else TxtTen_TK_Du.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_TK0", "DmTK0", "(TK0= N'" + TxtTK_Du.Text.Trim + "')", CyberSmLib)

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
        TxtMa_CD.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_CD)


        If TxtMa_Vv.Text.Trim = "" Then TxtTen_Vv.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_VV", "DmVV", "(Ma_VV= N'" + TxtMa_Vv.Text.Trim + "')", CyberSmLib)
        If TxtMa_HD.Text.Trim = "" Then TxtTen_HD.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_HD", "DmHD", "(Ma_HD= N'" + TxtMa_HD.Text.Trim + "')", CyberSmLib)
        If TxtMa_phi.Text.Trim = "" Then TxtTen_Phi.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Phi", "DmPhi", "(Ma_Phi= N'" + TxtMa_phi.Text.Trim + "')", CyberSmLib)
        If TxtMa_Sp.Text.Trim = "" Then TxtTen_Sp.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Sp", "DmSp", "(Ma_Sp= N'" + TxtMa_Sp.Text.Trim + "')", CyberSmLib)
        If Txtma_Ku.Text.Trim = "" Then TxtTen_ku.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Ku", "DmKu", "(Ma_Ku= N'" + Txtma_Ku.Text.Trim + "')", CyberSmLib)

        If TxtMa_TTLN.Text.Trim = "" Then TxtTen_TTLN.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TTLN", "DmTTLN", "(Ma_TTLN= N'" + TxtMa_TTLN.Text.Trim + "')", CyberSmLib)
        If TxtMa_TTCP.Text.Trim = "" Then TxtTen_TTCP.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TTCP", "DmTTCP", "(Ma_TTCP= N'" + TxtMa_TTCP.Text.Trim + "')", CyberSmLib)
        If TxtMa_Bp.Text.Trim = "" Then TxtTen_Bp.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_BP", "DmBP", "(Ma_BP= N'" + TxtMa_Bp.Text.Trim + "')", CyberSmLib)
        If TxtMa_Hs.Text.Trim = "" Then TxtTen_Hs.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_HS", "DmHS", "(Ma_HS= N'" + TxtMa_Hs.Text.Trim + "')", CyberSmLib)
        If TxtMa_CD.Text.Trim = "" Then TxtTen_CD.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_CD", "DmCD", "(Ma_CD= N'" + TxtMa_CD.Text.Trim + "')", CyberSmLib)

        If TxtMa_Td1.Text.Trim = "" Then TxtTen_Td1.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TD1", "DmTD1", "(Ma_TD1= N'" + TxtMa_Td1.Text.Trim + "')", CyberSmLib)
        If TxtMa_Td2.Text.Trim = "" Then TxtTen_Td2.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TD2", "DmTD2", "(Ma_TD2= N'" + TxtMa_Td2.Text.Trim + "')", CyberSmLib)
        If TxtMa_Td3.Text.Trim = "" Then TxtTen_Td3.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TD3", "DmTD3", "(Ma_TD3= N'" + TxtMa_Td3.Text.Trim + "')", CyberSmLib)
        If TxtMa_Td4.Text.Trim = "" Then TxtTen_Td4.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TD4", "DmTD4", "(Ma_TD4= N'" + TxtMa_Td4.Text.Trim + "')", CyberSmLib)
        If TxtMa_Td5.Text.Trim = "" Then TxtTen_Td5.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TD5", "DmTD5", "(Ma_TD5= N'" + TxtMa_Td5.Text.Trim + "')", CyberSmLib)

        TxtTen_DB.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_DB", "DmDB", "(Ma_DB= N'" + TxtMa_Db.Text.Trim + "')", CyberSmLib)
        TxtTen_CD.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_CD", "DmCD", "(Ma_CD= N'" + TxtMa_CD.Text.Trim + "')", CyberSmLib)

        If Txtma_kh.Text.Trim = "" Then txtten_kh.Text = "" Else txtten_kh.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_KH", "DmKH", "(Ma_KH = N'" + Txtma_kh.Text.Trim + "')", CyberSmLib)

        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
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
            _Return.Rows.Add(_Nam.ToString, " " + _Nam, "Year " + _Nam, _Default)
        Next
        CreateTableYear = _Return
    End Function
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit

        RemoveHandler ChkDetail_OK.CheckedChanged, AddressOf V_Detail_OK
        AddHandler ChkDetail_OK.CheckedChanged, AddressOf V_Detail_OK

        '--tkno
        AddHandler TxtTK.CyberValiting, AddressOf V_TK_NO
        AddHandler TxtTK.CyberLeave, AddressOf L_TK_No

        '--tkCo
        AddHandler TxtTK_Du.CyberValiting, AddressOf V_TK_Co
        AddHandler TxtTK_Du.CyberLeave, AddressOf L_TK_Co


        RemoveHandler ChkDetail_OK.CheckedChanged, AddressOf V_Detail_OK
        AddHandler ChkDetail_OK.CheckedChanged, AddressOf V_Detail_OK

        RemoveHandler CbbMa_Ky.SelectedIndexChanged, AddressOf V_CbbMa_Ky
        AddHandler CbbMa_Ky.SelectedIndexChanged, AddressOf V_CbbMa_Ky
        '--ma khach hang
        AddHandler Txtma_kh.CyberValiting, AddressOf V_Ma_KH
        AddHandler Txtma_kh.CyberLeave, AddressOf L_Ma_KH
        '--Vv

        AddHandler TxtMa_Vv.CyberValiting, AddressOf V_Ma_Vv
        AddHandler TxtMa_Vv.CyberLeave, AddressOf L_Ma_Vv
        '--HD

        AddHandler TxtMa_HD.CyberValiting, AddressOf V_Ma_HD
        AddHandler TxtMa_HD.CyberLeave, AddressOf L_Ma_HD
        '--Phi

        AddHandler TxtMa_phi.CyberValiting, AddressOf V_Ma_Phi
        AddHandler TxtMa_phi.CyberLeave, AddressOf L_Ma_Phi
        '--Sp

        AddHandler TxtMa_Sp.CyberValiting, AddressOf V_Ma_Sp
        AddHandler TxtMa_Sp.CyberLeave, AddressOf L_Ma_Sp
        '--Ku

        AddHandler Txtma_Ku.CyberValiting, AddressOf V_Ma_Ku
        AddHandler Txtma_Ku.CyberLeave, AddressOf L_Ma_Ku

        '--TTLN

        AddHandler TxtMa_TTLN.CyberValiting, AddressOf V_Ma_TTLN
        AddHandler TxtMa_TTLN.CyberLeave, AddressOf L_Ma_TTLN

        '--TTCP

        AddHandler TxtMa_TTCP.CyberValiting, AddressOf V_Ma_TTCP
        AddHandler TxtMa_TTCP.CyberLeave, AddressOf L_Ma_TTCP


        '--Bp

        AddHandler TxtMa_Bp.CyberValiting, AddressOf V_Ma_Bp
        AddHandler TxtMa_Bp.CyberLeave, AddressOf L_Ma_Bp

        '--Hs

        AddHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        AddHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs

        '--CD

        AddHandler TxtMa_CD.CyberValiting, AddressOf V_Ma_CD
        AddHandler TxtMa_CD.CyberLeave, AddressOf L_Ma_CD

        '--TD1

        AddHandler TxtMa_Td1.CyberValiting, AddressOf V_Ma_TD1
        AddHandler TxtMa_Td1.CyberLeave, AddressOf L_Ma_TD1
        '--TD2

        AddHandler TxtMa_Td2.CyberValiting, AddressOf V_Ma_TD2
        AddHandler TxtMa_Td2.CyberLeave, AddressOf L_Ma_TD2
        '--TD3

        AddHandler TxtMa_Td3.CyberValiting, AddressOf V_Ma_TD3
        AddHandler TxtMa_Td3.CyberLeave, AddressOf L_Ma_TD3
        '--TD4

        AddHandler TxtMa_Td4.CyberValiting, AddressOf V_Ma_TD4
        AddHandler TxtMa_Td4.CyberLeave, AddressOf L_Ma_TD4
        '--TD5

        AddHandler TxtMa_Td5.CyberValiting, AddressOf V_Ma_TD5
        AddHandler TxtMa_Td5.CyberLeave, AddressOf L_Ma_TD5
        '--DB

        AddHandler TxtMa_Db.CyberValiting, AddressOf V_Ma_DB
        AddHandler TxtMa_Db.CyberLeave, AddressOf L_Ma_DB

    End Sub
    Private Sub V_CbbMa_Ky(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_VisibleDate()
    End Sub
#End Region
#Region "Valid"

#Region "Valid --- Ma_vt"
    Private Sub V_TK_NO(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        sender.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "TK0", "DmTK0", "1=1", "1=1")
    End Sub
    Private Sub L_TK_No(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtTK.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTK.Text = DrReturn.Item("TK0")
            TxtTen_TK.Text = DrReturn.Item("Ten_TK0")
        Else
            TxtTK.Text = ""
            TxtTen_TK.Text = ""
            Exit Sub
        End If
    End Sub
#End Region

#Region "Valid --- Ma_vt"
    Private Sub V_TK_Co(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        sender.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "TK0", "DmTK0", "1=1", "1=1")
    End Sub
    Private Sub L_TK_Co(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtTK_Du.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTK_Du.Text = DrReturn.Item("TK0")
            TxtTen_TK_Du.Text = DrReturn.Item("Ten_TK0")
        Else
            TxtTK_Du.Text = ""
            TxtTen_TK_Du.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
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
#Region "Vali --- Ma_Vv"
    Private Sub V_Ma_Vv(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Vv.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Vv", "DmVv", "1=1", "1=1")
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
        TxtMa_HD.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_HD", "DmHD", "1=1", "1=1")
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
        TxtMa_phi.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Phi", "DmPhi", "1=1", "1=1")
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
        TxtMa_Sp.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Sp", "DmSp", "1=1", "1=1")
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
        Txtma_Ku.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Ku", "DmKu", "1=1", "1=1")
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
        TxtMa_TTLN.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_TTLN", "DmTTLN", "1=1", "1=1")
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
        TxtMa_TTCP.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_TTCP", "DmTTCP", "1=1", "1=1")
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
        TxtMa_Hs.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
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
        TxtMa_Td1.V_LookUp(Me.LAN, Me.Para, Me.sysvar, Me.AppConn, DsLookup, "Ma_TD1", "DmTD1", "1=1", "1=1")
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
        TxtMa_Td2.V_LookUp(Me.LAN, Me.Para, Me.sysvar, Me.AppConn, DsLookup, "Ma_TD2", "DmTD2", "1=1", "1=1")
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
        TxtMa_Td3.V_LookUp(Me.LAN, Me.Para, Me.sysvar, Me.AppConn, DsLookup, "Ma_TD3", "DmTD3", "1=1", "1=1")
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
        TxtMa_Td4.V_LookUp(Me.LAN, Me.Para, Me.sysvar, Me.AppConn, DsLookup, "Ma_TD4", "DmTD4", "1=1", "1=1")
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
        TxtMa_Td5.V_LookUp(Me.LAN, Me.Para, Me.sysvar, Me.AppConn, DsLookup, "Ma_TD5", "DmTD5", "1=1", "1=1")
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
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------
        If CyberMe.V_GetValueCombox(CbbGroupByTH).ToString.Trim = "" Then
            MsgBox("Chưa chọn tổng hợp theo tiêu thức nào", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Me.sysvar("M_CYBER_VER"))
            CbbGroupByTH.Focus()
            Exit Sub
        End If
        If ChkDetail_OK.Checked And CyberMe.V_GetValueCombox(CbbGroupByCT).ToString.Trim = "" Then
            MsgBox("Chưa chọn tiêu thức chi tiết", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Me.sysvar("M_CYBER_VER"))
            CbbGroupByCT.Focus()
            Exit Sub
        End If
        If ChkDetail_OK.Checked And CyberMe.V_GetValueCombox(CbbGroupByCT).ToString.Trim.ToUpper = CyberMe.V_GetValueCombox(CbbGroupByTH).ToString.Trim.ToUpper Then
            MsgBox("Hai tiêu thức tổng hợp và chi tiết không thể giống nhau", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Me.sysvar("M_CYBER_VER"))
            CbbGroupByTH.Focus()
            Exit Sub
        End If
        '----------------------------------------------------------------------------

        Dim M_TH_Filter As String = Me.CbbGroupByTH.SelectedValue.ToString.Trim
        Dim M_CT_Filter As String = Me.CbbGroupByCT.SelectedValue.ToString.Trim

        Dim Dt1 As Date = TxtM_Ngay_Ct.Value
        Dim _Ma_Ky As String = Me.CbbMa_Ky.SelectedValue.ToString.Trim
        Dim _Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim

        Dim M_strParameterStore As String = M_TH_Filter
        M_strParameterStore = M_strParameterStore & "#" & If(ChkDetail_OK.Checked, CbbGroupByCT.SelectedValue.ToString.Trim, "")
        M_strParameterStore = M_strParameterStore & "#" & _Ma_Ky
        M_strParameterStore = M_strParameterStore & "#" & TxtSo_Ky.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & Dt1.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & Me.CbbM_Thang1.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & Me.CbbM_Nam.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtTK.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtTK_Du.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & CyberMe.V_GetValueCombox(CbbNo_Co)
        M_strParameterStore = M_strParameterStore & "#" & Txtma_kh.Text.Trim

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
