﻿Imports System.Data.SqlClient
Public Class ROL
#Region "Khai bao bien Property----------------------"
    Dim M_strFilter As String = "1=1"
    Dim M_DrDmct As DataRow
    Dim osysvar As Collection
    Dim M_Para As String() = Me.Para
    Dim M_AppConn As SqlConnection
    Dim M_DsData, M_DsHead, M_DsLookUp As DataSet
    Dim DtThang, DtNam As New DataTable
    Dim _M_Thang_Default As String = Now.Date.Month.ToString.Trim
    Dim _M_Nam_Default As String = Now.Date.Year.ToString.Trim

#End Region
#Region "Khai bao bien Paramater----------------------"
#End Region
#Region "Khai bao bien Dll"
    Dim CyberInput As New Cyber.Input.Sys
    Dim CyberMe As New Cyber.From.Frmvoucher
    Dim CyberFrom As New Cyber.From.Sys
#End Region
#Region "Columns Edit"
    Dim EditMa_Vv_I, EditMa_Phi_i, EditMa_HD_I, EditMa_SP_I, EditMa_Ku_I, EditMa_TTLN_i, EditMa_TTCP_i, EditMa_BP_I, EditMa_HS_I, EditMa_CD_I, EditMa_TD1_I, EditMa_TD2_I, EditMa_TD3_I, EditMa_TD4_I, EditMa_TD5_I, EditDien_Giaii As New Cyber.Fill.CyberColumnGridView
    'Luong_CB
    Dim EditLuong_CB1, EditLuong_CB2, EditLuong_CB3, EditLuong_CB4, EditLuong_CB5, EditLuong_CB6, EditLuong_CB7, EditLuong_CB8, EditLuong_CB9, EditLuong_CB10 As New Cyber.Fill.CyberColumnGridView
    'Doanh_Thu
    Dim EditLuong_DT1, EditLuong_DT2, EditLuong_DT3, EditLuong_DT4, EditLuong_DT5, EditLuong_DT6, EditLuong_DT7, EditLuong_DT8, EditLuong_DT9, EditLuong_DT10 As New Cyber.Fill.CyberColumnGridView
    'Bao_Hiem
    Dim EditLuong_BHXH, EditBHXH1, EditBHXH2, EditBHYT1, EditBHYT2, EditBHTN1, EditBHTN2 As New Cyber.Fill.CyberColumnGridView
    'Giam_Tru
    Dim EditPhat1, EditPhat2, EditPhat3, EditPhat4, EditPhat5 As New Cyber.Fill.CyberColumnGridView
    'Thuong
    Dim EditThuong1, EditThuong2, EditThuong3, EditThuong4, EditThuong5 As New Cyber.Fill.CyberColumnGridView
    'Cham_Cong
    Dim EditCong, EditThem_Gio As New Cyber.Fill.CyberColumnGridView
    'Thue_TNCN
    Dim EditThue_TNCN1, EditThue_TNCN2, EditThue_TNCN3, EditThue_TNCN4, EditThue_TNCN5 As New Cyber.Fill.CyberColumnGridView
#End Region
#Region "Khai bao bien Private"

    Dim M_Ct, M_Ph As String
    Dim DrReturn As DataRow
    Dim M_Count As Integer = 1
    Dim DtPost, DtMaGD As DataTable
#End Region
    Private Sub ROL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        V_GetColumn()
        V_AddHandler()
        V_Databing()
        M_Mode = "X"
        M_Count = Dt_Master.Rows.Count
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_MainSystem()
        GetRound()
        CmdNew.Select()
    End Sub
    Private Sub CreateTableMonth()
        DtThang.Columns.Add("Thang")
        DtThang.Columns.Add("Ten_Thang")
        DtThang.Columns.Add("Ten_Thang2")
        DtThang.Columns.Add("Default")

        Dim _Thang As String = ""
        Dim _Default As String = "0"

        For i As Integer = 1 To 12
            _Thang = i.ToString.Trim.Trim
            If Now.Date.Month = i Then _Default = "1" Else _Default = "0"
            DtThang.Rows.Add(_Thang.ToString, "Tháng " + _Thang, "Month " + _Thang, _Default)
        Next

        DtNam.Columns.Add("Nam")
        DtNam.Columns.Add("Ten_Nam")
        DtNam.Columns.Add("Ten_Nam2")
        DtNam.Columns.Add("Default")

        Dim _CurYear As Integer = Now.Year

        Dim _Nam As String = ""
        _Default = "0"

        For i As Integer = _CurYear - 10 To _CurYear + 10
            _Nam = Strings.Right("0000" + i.ToString.Trim, 4).Trim
            If Now.Date.Year = i Then _Default = "1" Else _Default = "0"
            DtNam.Rows.Add(_Nam.ToString, "Năm " + _Nam, "Year " + _Nam, _Default)
        Next

        CyberFill.V_FillComBoxDefaul(CmbThang, DtThang, "Thang", IIf(Me.Lan = "V", "Ten_Thang", "Ten_Thang2"), "Default")
        CyberFill.V_FillComBoxDefaul(CmbNam, DtNam, "Nam", IIf(Me.Lan = "V", "Ten_Nam", "Ten_nam2"), "Default")
    End Sub
#Region "Load And Set And Default"
    Private Sub V_Load()
        V_Getdefault()
        CreateTableMonth()
        TxtNgay_LCt.Text = Now.Date
        Dt_Detail = M_DsData.Tables(0)
        Dt_DetailTmp = Dt_Detail.Clone
        Dt_Master = M_DsData.Tables(M_DsData.Tables.Count - 1)
        '' Lương 1 
        Dv_Detail = New DataView(Dt_Detail)
        Dv_DetailTmp = New DataView(Dt_DetailTmp)

        ' Ph
        Dv_Master = New DataView(Dt_Master)
        '========= FillData to Gridview Vt
        DetailLuong1.DataSource = Dv_DetailTmp
        Me.DetailGRVluong1.GridControl = Me.DetailLuong1
        CyberFill.V_FillVoucher(DetailGRVluong1, M_LAN, New DataView(M_DsHead.Tables(1)), Dv_DetailTmp, Me.DrDmct)

        DetailLuong2.DataSource = Dv_DetailTmp
        Me.DetailGRVluong2.GridControl = Me.DetailLuong2
        CyberFill.V_FillVoucher(DetailGRVluong2, M_LAN, New DataView(M_DsHead.Tables(2)), Dv_DetailTmp, Me.DrDmct)

        DetailLuong3.DataSource = Dv_DetailTmp
        Me.DetailGRVluong3.GridControl = Me.DetailLuong3
        CyberFill.V_FillVoucher(DetailGRVluong3, M_LAN, New DataView(M_DsHead.Tables(3)), Dv_DetailTmp, Me.DrDmct)

        DetailLuong4.DataSource = Dv_DetailTmp
        Me.DetailGRVluong4.GridControl = Me.DetailLuong4
        CyberFill.V_FillVoucher(DetailGRVluong4, M_LAN, New DataView(M_DsHead.Tables(4)), Dv_DetailTmp, Me.DrDmct)

        DetailLuong5.DataSource = Dv_DetailTmp
        Me.DetailGRVluong5.GridControl = Me.DetailLuong5
        CyberFill.V_FillVoucher(DetailGRVluong5, M_LAN, New DataView(M_DsHead.Tables(5)), Dv_DetailTmp, Me.DrDmct)

        DetailLuong6.DataSource = Dv_DetailTmp
        Me.DetailGRVluong6.GridControl = Me.DetailLuong6
        CyberFill.V_FillVoucher(DetailGRVluong6, M_LAN, New DataView(M_DsHead.Tables(6)), Dv_DetailTmp, Me.DrDmct)

        TxtT_LuongCB.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_LuongCB.InputMask)
        TxtT_Cong.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_Cong.InputMask)
        TxtT_LuongDT.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_LuongDT.InputMask)
        TxtT_BH.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_BH.InputMask)
        TxtT_Phat.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_Phat.InputMask)
        TxtT_Thuong.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_Thuong.InputMask)
        TxtThuc_Linh.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtThuc_Linh.InputMask)
    End Sub
    Private Sub V_Getdefault()
        M_strFilter = Me.strFilter
        M_DrDmct = Me.DrDmct
        M_Ph = M_DrDmct.Item("M_Ph").ToString.Trim
        M_Ct = M_DrDmct.Item("M_Ct").ToString.Trim

        osysvar = Me.SysVar
        M_Stt_Rec = Me.Stt_Rec
        M_LAN = Me.Lan
        M_Para = Me.Para
        AppConn = Me.AppConn
        M_DsData = Me.DsData
        M_DsHead = Me.DsHead
        M_DsLookUp = Me.DsLookup

        Dim M_VT_PARA As Integer = CType(M_Para(0).Trim, Integer)
        K_Tmp = M_Para(1).Trim
        K_System = M_Para(2).Trim
        K_Repo = M_Para(3).Trim
        K_Repo_Nt = M_Para(4).Trim
        M_CYBER_VER = M_Para(5).Trim
        M_User_Name = M_Para(6).Trim
        M_Comment = M_Para(7).Trim
        M_is_Admin = CType(M_Para(8), Boolean)
        M_User_ID = M_Para(9).Trim
        M_Menu_ID0 = M_Para(10).Trim
        M_Bar = M_Para(11).Trim
        M_Bar2 = M_Para(12).Trim
        M_LAN = M_Para(13).Trim
        M_Ma_Dvcs = M_Para(14).Trim
        '---------------------------------------------------------------------------------------------'
        M_Ma_GD = M_Para(M_VT_PARA + 1).Trim
        M_Ma_CT = M_Para(M_VT_PARA + 2).Trim
        'M_Stt_Rec = M_Para(M_Para.Length - 1).Trim
        '---------------------------------------------------------------------------------------------'

        M_Ma_Post = CyberSupport.V_GetMaxPost(AppConn, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib)
        '---
        M_Tk_No = DrDmct.Item("M_Tk_No").ToString.Trim
        M_Tk_Co = DrDmct.Item("M_Tk_Co").ToString.Trim
        M_Tk_Thue = DrDmct.Item("M_Tk_Thue").ToString.Trim
        M_Ma_Nt = DrDmct.Item("Ma_Nt").ToString.Trim
        M_Dien_Giai = DrDmct.Item("Dien_Giai").ToString.Trim

        If M_Tk_No.Trim <> "" Then M_Ten_Tk_No = CyberSmodb.SQLGetvalue(AppConn, "Ten_Tk", "Dmtk", "Tk = N'" + M_Tk_No.Trim + "'", CyberSmlib) Else M_Ten_Tk_No = ""
        If M_Tk_Co.Trim <> "" Then M_Ten_Tk_Co = CyberSmodb.SQLGetvalue(AppConn, "Ten_Tk", "Dmtk", "Tk = N'" + M_Tk_Co.Trim + "'", CyberSmlib) Else M_Ten_Tk_Co = ""
        If M_Tk_Thue.Trim <> "" Then M_Ten_Tk_Thue = CyberSmodb.SQLGetvalue(AppConn, "Ten_Tk", "Dmtk", "Tk = N'" + M_Tk_Thue.Trim + "'", CyberSmlib) Else M_Ten_Tk_Thue = ""

        DtPost = CyberSmodb.OpenTableKey(AppConn, Nothing, "DmPost", "Ma_Post", "Ma_Ct =N'" + M_Ma_CT + "'", CyberSmlib)

        DtMaGD = CyberSmodb.OpenTableKey(AppConn, Nothing, "DmMaGd", "Ma_GD", "Ma_Ct =N'" + M_Ma_CT + "'", CyberSmlib)
        CyberFill.V_FillComBoxValue(Me.CbbMa_Post, DtPost, "Ma_Post", If(M_LAN = "V", "Ten_Post", "Ten_Post2"), M_Ma_Post)

        CyberFill.V_FillComBoxValue(Me.CmbMa_GD, DtMaGD, "Ma_GD", If(M_LAN = "V", "Ten_GD", "Ten_GD2"), M_Ma_GD)
    End Sub
    Private Sub V_SetProperty()
        Me.Mode = M_Mode
        Me.Stt_Rec = M_Stt_Rec
        '---
        Dim FixCol As Integer = -1
        FixCol = DrDmct.Item("ColFrozen_master")
        If FixCol < DetailGRVluong1.Columns.Count And FixCol > 0 Then
            For iCol = 0 To FixCol
                DetailGRVluong1.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
            Next
        End If
        DetailGRVluong1.OptionsNavigation.EnterMoveNextColumn = True
        Me.DetailGRVluong1.Appearance.SelectedRow.BackColor = System.Drawing.Color.Brown
    End Sub
    Private Sub V_GetColumn()
        EditMa_HS_I.GetColumn(DetailGRVluong1, "Ma_Hs_i")

        'Luong_CB
        EditLuong_CB1.GetColumn(DetailGRVluong1, "Luong_CB1")
        EditLuong_CB2.GetColumn(DetailGRVluong1, "Luong_CB2")
        EditLuong_CB3.GetColumn(DetailGRVluong1, "Luong_CB3")
        EditLuong_CB4.GetColumn(DetailGRVluong1, "Luong_CB4")
        EditLuong_CB5.GetColumn(DetailGRVluong1, "Luong_CB5")
        EditLuong_CB6.GetColumn(DetailGRVluong1, "Luong_CB6")
        EditLuong_CB7.GetColumn(DetailGRVluong1, "Luong_CB7")
        EditLuong_CB8.GetColumn(DetailGRVluong1, "Luong_CB8")
        EditLuong_CB9.GetColumn(DetailGRVluong1, "Luong_CB9")
        EditLuong_CB10.GetColumn(DetailGRVluong1, "Luong_CB10")

        'Luong_DT
        EditLuong_DT1.GetColumn(DetailGRVluong2, "Luong_DT1")
        EditLuong_DT2.GetColumn(DetailGRVluong2, "Luong_DT2")
        EditLuong_DT3.GetColumn(DetailGRVluong2, "Luong_DT3")
        EditLuong_DT4.GetColumn(DetailGRVluong2, "Luong_DT4")
        EditLuong_DT5.GetColumn(DetailGRVluong2, "Luong_DT5")
        EditLuong_DT6.GetColumn(DetailGRVluong2, "Luong_DT6")
        EditLuong_DT7.GetColumn(DetailGRVluong2, "Luong_DT7")
        EditLuong_DT8.GetColumn(DetailGRVluong2, "Luong_DT8")
        EditLuong_DT9.GetColumn(DetailGRVluong2, "Luong_DT9")
        EditLuong_DT10.GetColumn(DetailGRVluong2, "Luong_DT10")
       
        'Luong_BHXH
        EditLuong_BHXH.GetColumn(DetailGRVluong3, "Luong_BHXH")
        EditBHXH1.GetColumn(DetailGRVluong3, "BHXH1")
        EditBHXH2.GetColumn(DetailGRVluong3, "BHXH2")
        EditBHYT1.GetColumn(DetailGRVluong3, "BHYT1")
        EditBHYT2.GetColumn(DetailGRVluong3, "BHYT2")
        'Giảm trừ
        EditPhat1.GetColumn(DetailGRVluong4, "Phat1")
        EditPhat2.GetColumn(DetailGRVluong4, "Phat2")
        EditPhat3.GetColumn(DetailGRVluong4, "Phat3")
        EditPhat4.GetColumn(DetailGRVluong4, "Phat4")
        EditPhat5.GetColumn(DetailGRVluong4, "Phat5")
        'Thưởng
        EditThuong1.GetColumn(DetailGRVluong5, "Thuong1")
        EditThuong2.GetColumn(DetailGRVluong5, "Thuong2")
        EditThuong3.GetColumn(DetailGRVluong5, "Thuong3")
        EditThuong4.GetColumn(DetailGRVluong5, "Thuong4")
        EditThuong5.GetColumn(DetailGRVluong5, "Thuong5")
        'Chấm công
        EditCong.GetColumn(DetailGRVluong6, "Cong")
        EditThem_Gio.GetColumn(DetailGRVluong6, "Them_Gio")
        'Thuế TNCN
        EditThue_TNCN1.GetColumn(DetailGRVluong4, "Thue_TNCN1")
        EditThue_TNCN2.GetColumn(DetailGRVluong4, "Thue_TNCN2")
        EditThue_TNCN3.GetColumn(DetailGRVluong4, "Thue_TNCN3")
        EditThue_TNCN4.GetColumn(DetailGRVluong4, "Thue_TNCN4")
        EditThue_TNCN5.GetColumn(DetailGRVluong4, "Thue_TNCN5")
    End Sub
    Private Sub V_SetFocus(ByVal _Loai As String)
        _Loai = _Loai.Trim.ToUpper
        Select Case _Loai
            Case "M"
                If DrDmct.Item("M_Ngay_CT").ToString.Trim <> "1" Then TxtNgay_Ct.Focus() Else TxtDien_Giai.Focus()
            Case "S"
                If DrDmct.Item("M_Ngay_CT").ToString.Trim <> "1" Then TxtNgay_Ct.Focus() Else TxtDien_Giai.Focus()
            Case "L"
                CmdPrint.Select()
        End Select
    End Sub
    Private Sub GetRound()
        M_R_TIEN = DrDmct.Item("M_R_Tien")
        M_R_TIEN_NT = DrDmct.Item("M_R_Tien_NT")
        M_R_GIA = DrDmct.Item("M_R_GIA")
        M_R_GIA_NT = DrDmct.Item("M_R_GIA_NT")
        If TxtMa_NT.Text.Trim = "" Or TxtMa_NT.Text.ToUpper.Trim = osysvar("M_MA_NT0").ToString.Trim.ToUpper Then
            M_R_GIA_NT = M_R_GIA
            M_R_TIEN_NT = M_R_TIEN
        End If
    End Sub
#End Region
#Region "V_AddHandler"
    Private Sub V_AddHandler()
        V_AddHandler_System()
        V_AddHandler_Master()
        V_AddHandler_Detail()
    End Sub
    Private Sub V_AddHandler_System()
        AddHandler Me.KeyDown, AddressOf FrmMain_KeyDown
        '---

        AddHandler CmdSave.Click, AddressOf V_Save
        AddHandler CmdNew.Click, AddressOf V_New
        AddHandler CmdEdit.Click, AddressOf V_Edit
        AddHandler CmdDelete.Click, AddressOf V_Delete
        AddHandler CmdCancel.Click, AddressOf V_Cancel
        AddHandler CmdPrint.Click, AddressOf V_Print
        AddHandler CmdView.Click, AddressOf V_View
        AddHandler CmdSearch.Click, AddressOf V_Search
        AddHandler CmdExit.Click, AddressOf V_Exit

        AddHandler CmdImport.Click, AddressOf V_Import
        AddHandler CmdCopy.Click, AddressOf V_Copy
        '---
        AddHandler DetailGRVluong1.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        AddHandler DetailGRVluong1.KeyDown, AddressOf MasterGRV_KeyDown

        AddHandler CmbMa_GD.SelectedValueChanged, AddressOf L_Ma_GD
    End Sub
    Private Sub L_Ma_GD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        VisibleColumnMa_GD()
    End Sub
    Private Sub V_AddHandler_Master()
        AddHandler TxtMa_Quyen.Leave, AddressOf L_Ma_Quyen
        AddHandler TxtNgay_Ct.Leave, AddressOf V_Ngay_Ct
        AddHandler TxtNgay_LCt.Leave, AddressOf V_Ngay_LCt
        AddHandler TxtSo_Ct.Enter, AddressOf V_So_Ct
        AddHandler TxtMa_NT.Leave, AddressOf L_Ma_NT
        AddHandler TxtTy_Gia.Leave, AddressOf L_Ty_Gia

        '----------------------------------------------------------------------------------------------------------
        AddHandler TxtLenh_SO.Leave, AddressOf L_Lenh_So
        AddHandler TxtLenh_PO.Leave, AddressOf L_Lenh_Po
        AddHandler TxtLenh_RO.Leave, AddressOf L_Lenh_Ro
        AddHandler TxtLenh_Vt.Leave, AddressOf L_Lenh_VT
    End Sub
    Private Sub V_AddHandler_Detail()
        'Luong_CB
        If Not EditLuong_CB1.Column Is Nothing Then AddHandler EditLuong_CB1.EditColumn.Leave, AddressOf V_Tinh_ToanCB
        If Not EditLuong_CB2.Column Is Nothing Then AddHandler EditLuong_CB2.EditColumn.Leave, AddressOf V_Tinh_ToanCB
        If Not EditLuong_CB3.Column Is Nothing Then AddHandler EditLuong_CB3.EditColumn.Leave, AddressOf V_Tinh_ToanCB
        If Not EditLuong_CB4.Column Is Nothing Then AddHandler EditLuong_CB4.EditColumn.Leave, AddressOf V_Tinh_ToanCB
        If Not EditLuong_CB5.Column Is Nothing Then AddHandler EditLuong_CB5.EditColumn.Leave, AddressOf V_Tinh_ToanCB
        If Not EditLuong_CB6.Column Is Nothing Then AddHandler EditLuong_CB6.EditColumn.Leave, AddressOf V_Tinh_ToanCB
        If Not EditLuong_CB7.Column Is Nothing Then AddHandler EditLuong_CB7.EditColumn.Leave, AddressOf V_Tinh_ToanCB
        If Not EditLuong_CB8.Column Is Nothing Then AddHandler EditLuong_CB8.EditColumn.Leave, AddressOf V_Tinh_ToanCB
        If Not EditLuong_CB9.Column Is Nothing Then AddHandler EditLuong_CB9.EditColumn.Leave, AddressOf V_Tinh_ToanCB
        If Not EditLuong_CB10.Column Is Nothing Then AddHandler EditLuong_CB10.EditColumn.Leave, AddressOf V_Tinh_ToanCB
        'Luong_DT
        If Not EditLuong_DT1.Column Is Nothing Then AddHandler EditLuong_DT1.EditColumn.Leave, AddressOf V_Tinh_ToanDT
        If Not EditLuong_DT2.Column Is Nothing Then AddHandler EditLuong_DT2.EditColumn.Leave, AddressOf V_Tinh_ToanDT
        If Not EditLuong_DT3.Column Is Nothing Then AddHandler EditLuong_DT3.EditColumn.Leave, AddressOf V_Tinh_ToanDT
        If Not EditLuong_DT4.Column Is Nothing Then AddHandler EditLuong_DT4.EditColumn.Leave, AddressOf V_Tinh_ToanDT
        If Not EditLuong_DT5.Column Is Nothing Then AddHandler EditLuong_DT5.EditColumn.Leave, AddressOf V_Tinh_ToanDT
        If Not EditLuong_DT6.Column Is Nothing Then AddHandler EditLuong_DT6.EditColumn.Leave, AddressOf V_Tinh_ToanDT
        If Not EditLuong_DT7.Column Is Nothing Then AddHandler EditLuong_DT7.EditColumn.Leave, AddressOf V_Tinh_ToanDT
        If Not EditLuong_DT8.Column Is Nothing Then AddHandler EditLuong_DT8.EditColumn.Leave, AddressOf V_Tinh_ToanDT
        If Not EditLuong_DT9.Column Is Nothing Then AddHandler EditLuong_DT9.EditColumn.Leave, AddressOf V_Tinh_ToanDT
        If Not EditLuong_DT10.Column Is Nothing Then AddHandler EditLuong_DT10.EditColumn.Leave, AddressOf V_Tinh_ToanDT
        'BHXH        
        If Not EditBHXH1.Column Is Nothing Then AddHandler EditBHXH1.EditColumn.Leave, AddressOf V_Tinh_ToanBH
        If Not EditBHXH2.Column Is Nothing Then AddHandler EditBHXH2.EditColumn.Leave, AddressOf V_Tinh_ToanBH
        If Not EditBHYT1.Column Is Nothing Then AddHandler EditBHYT1.EditColumn.Leave, AddressOf V_Tinh_ToanBH
        If Not EditBHYT2.Column Is Nothing Then AddHandler EditBHYT2.EditColumn.Leave, AddressOf V_Tinh_ToanBH
        If Not EditBHTN1.Column Is Nothing Then AddHandler EditBHTN1.EditColumn.Leave, AddressOf V_Tinh_ToanBH
        If Not EditBHTN2.Column Is Nothing Then AddHandler EditBHTN2.EditColumn.Leave, AddressOf V_Tinh_ToanBH
        'Giảm trừ
        If Not EditPhat1.Column Is Nothing Then AddHandler EditPhat1.EditColumn.Leave, AddressOf V_Tinh_ToanGiam
        If Not EditPhat2.Column Is Nothing Then AddHandler EditPhat2.EditColumn.Leave, AddressOf V_Tinh_ToanGiam
        If Not EditPhat3.Column Is Nothing Then AddHandler EditPhat3.EditColumn.Leave, AddressOf V_Tinh_ToanGiam
        If Not EditPhat4.Column Is Nothing Then AddHandler EditPhat4.EditColumn.Leave, AddressOf V_Tinh_ToanGiam
        If Not EditPhat5.Column Is Nothing Then AddHandler EditPhat5.EditColumn.Leave, AddressOf V_Tinh_ToanGiam
        'Thưởng
        If Not EditThuong1.Column Is Nothing Then AddHandler EditThuong1.EditColumn.Leave, AddressOf V_Tinh_ToanThuong
        If Not EditThuong2.Column Is Nothing Then AddHandler EditThuong2.EditColumn.Leave, AddressOf V_Tinh_ToanThuong
        If Not EditThuong3.Column Is Nothing Then AddHandler EditThuong3.EditColumn.Leave, AddressOf V_Tinh_ToanThuong
        If Not EditThuong4.Column Is Nothing Then AddHandler EditThuong4.EditColumn.Leave, AddressOf V_Tinh_ToanThuong
        If Not EditThuong5.Column Is Nothing Then AddHandler EditThuong5.EditColumn.Leave, AddressOf V_Tinh_ToanThuong
        'Chấm công
        If Not EditCong.Column Is Nothing Then AddHandler EditCong.EditColumn.Leave, AddressOf V_Tinh_ToanCong
        If Not EditThem_Gio.Column Is Nothing Then AddHandler EditThem_Gio.EditColumn.Leave, AddressOf V_Tinh_ToanCong
        'Thuế TNCN
        If Not EditThue_TNCN1.Column Is Nothing Then AddHandler EditThue_TNCN1.EditColumn.Leave, AddressOf V_Tinh_ToanThueTNCN
        If Not EditThue_TNCN2.Column Is Nothing Then AddHandler EditThue_TNCN2.EditColumn.Leave, AddressOf V_Tinh_ToanThueTNCN
        If Not EditThue_TNCN3.Column Is Nothing Then AddHandler EditThue_TNCN3.EditColumn.Leave, AddressOf V_Tinh_ToanThueTNCN
        If Not EditThue_TNCN4.Column Is Nothing Then AddHandler EditThue_TNCN4.EditColumn.Leave, AddressOf V_Tinh_ToanThueTNCN
        If Not EditThue_TNCN5.Column Is Nothing Then AddHandler EditThue_TNCN5.EditColumn.Leave, AddressOf V_Tinh_ToanThueTNCN
        'Add on
        EditMa_Vv_I.V_ActiLookUpColumn(AddressOf V_Ma_Vv_i, AddressOf L_Ma_Vv_i)
        EditMa_Phi_i.V_ActiLookUpColumn(AddressOf V_Ma_Phi_i, AddressOf L_Ma_Phi_i)
        EditMa_HD_I.V_ActiLookUpColumn(AddressOf V_Ma_HD_i, AddressOf L_Ma_HD_i)
        EditMa_SP_I.V_ActiLookUpColumn(AddressOf V_Ma_SP_i, AddressOf L_Ma_SP_i)
        EditMa_Ku_I.V_ActiLookUpColumn(AddressOf V_Ma_Ku_i, AddressOf L_Ma_Ku_i)
        EditMa_TTLN_i.V_ActiLookUpColumn(AddressOf V_Ma_TTLN_i, AddressOf L_Ma_TTLN_i)
        EditMa_TTCP_i.V_ActiLookUpColumn(AddressOf V_Ma_TTCP_i, AddressOf L_Ma_TTCP_i)
        EditMa_BP_I.V_ActiLookUpColumn(AddressOf V_Ma_Bp_i, AddressOf L_Ma_Bp_i)
        EditMa_HS_I.V_ActiLookUpColumn(AddressOf V_Ma_HS_i, AddressOf L_Ma_HS_i)
        EditMa_CD_I.V_ActiLookUpColumn(AddressOf V_Ma_CD_i, AddressOf L_Ma_CD_i)
        EditMa_TD1_I.V_ActiLookUpColumn(AddressOf V_Ma_TD1_i, AddressOf L_Ma_TD1_i)
        EditMa_TD2_I.V_ActiLookUpColumn(AddressOf V_Ma_TD2_i, AddressOf L_Ma_TD2_i)
        EditMa_TD3_I.V_ActiLookUpColumn(AddressOf V_Ma_TD3_i, AddressOf L_Ma_TD3_i)
        EditMa_TD4_I.V_ActiLookUpColumn(AddressOf V_Ma_TD4_i, AddressOf L_Ma_TD4_i)
        EditMa_TD5_I.V_ActiLookUpColumn(AddressOf V_Ma_TD5_i, AddressOf L_Ma_TD5_i)
    End Sub
    Private Sub VisibleColumnMa_GD()
    End Sub
    Protected Overrides Sub V_Databing()
        Dim i As Integer
        Dim Drv As DataRowView
        Drv = Nothing

        For i = 0 To Dv_Master.Count - 1
            If Dv_Master.Item(i).Item("Stt_Rec").ToString.Trim = M_Stt_Rec.Trim Then
                Drv = Dv_Master.Item(i)
                Exit For
            End If
        Next

        CyberSmodb.SetValueTObj(Me, Drv)
        If Drv Is Nothing Then
            TxtMa_NT.Text = M_Ma_Nt
            TxtNgay_Ct.Value = Now.Date
            Dim _DT As Date = TxtNgay_Ct.Value
            TxtTy_Gia.Double = CyberSupport.GetRate(_DT, TxtMa_NT.Text, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
            CmbMa_GD.SelectedValue = M_Ma_GD
            CbbMa_Post.SelectedValue = M_Ma_Post
        End If
        '------------------------------------
        Dt_DetailTmp.Clear()
        Dt_DetailTmp.AcceptChanges()
        For i = 0 To Dt_Detail.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'").Length - 1
            Dt_DetailTmp.ImportRow(Dt_Detail.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(i))
        Next
        '------------------------------------

        VisibleColumnMa_GD()
    End Sub
    Private Sub V_Setstatus()
        If (M_Mode = "M" Or M_Mode = "S") Then

            DetailGRVluong1.OptionsBehavior.ReadOnly = False
            DetailGRVluong3.OptionsBehavior.ReadOnly = False
            DetailGRVluong4.OptionsBehavior.ReadOnly = False
            DetailGRVluong5.OptionsBehavior.ReadOnly = False
            DetailGRVluong6.OptionsBehavior.ReadOnly = False
            DetailGRVluong1.OptionsBehavior.ReadOnly = False


            DetailGRVluong1.OptionsBehavior.Editable = True
            DetailGRVluong3.OptionsBehavior.Editable = True
            DetailGRVluong4.OptionsBehavior.Editable = True
            DetailGRVluong5.OptionsBehavior.Editable = True
            DetailGRVluong6.OptionsBehavior.Editable = True
            DetailGRVluong1.OptionsBehavior.Editable = True


            If DrDmct.Item("M_Ngay_LCT").ToString.Trim = "1" Then TxtNgay_LCt.ReadOnly = False Else TxtNgay_LCt.ReadOnly = True 'Ngay chu tu nhap: vao hoac tu dong lay theo may chu
            If DrDmct.Item("M_Ngay_CT").ToString.Trim = "1" Then TxtNgay_Ct.ReadOnly = True Else TxtNgay_Ct.ReadOnly = False 'Ngay chu tu nhap: vao hoac tu dong lay theo may chu
            If DrDmct.Item("M_Au_So_CT").ToString.Trim = "1" Then TxtSo_Ct.ReadOnly = True Else TxtSo_Ct.ReadOnly = False 'Tu dong danh so chung tu
        Else
            DetailGRVluong1.OptionsBehavior.ReadOnly = True
            DetailGRVluong3.OptionsBehavior.ReadOnly = True
            DetailGRVluong4.OptionsBehavior.ReadOnly = True
            DetailGRVluong5.OptionsBehavior.ReadOnly = True
            DetailGRVluong6.OptionsBehavior.ReadOnly = True
            DetailGRVluong1.OptionsBehavior.ReadOnly = True
        End If

        If M_Mode = "S" Then CmbMa_GD.Enabled = False
        If M_Mode = "S" Then CmbThang.Enabled = False
        If M_Mode = "S" Then CmbNam.Enabled = False
        If M_Mode = "M" Then CmbMa_GD.Enabled = True
        CyberFill.SetFoCusGRV(DetailGRVluong1, M_Mode)
        SetTxt()
    End Sub
    Private Sub V_GetDateVoucher(ByVal _Mode As String, ByRef _Ngay_Ct As Date, ByRef _Ngay_LCT As Date)
        Dim _DtReturn As DataTable = CyberSupport.V_GetDateVoucher(_Mode, _Ngay_Ct, _Ngay_LCT, M_Stt_Rec, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
        If _DtReturn Is Nothing Then Exit Sub Else If _DtReturn.Rows.Count <= 0 Then Exit Sub
        If Not _DtReturn.Columns.Contains("Status") Then Exit Sub
        If _DtReturn.Rows(0).Item("Status").ToString.Trim = "N" Then Exit Sub
        If Not DrDmct.Item("M_Ngay_LCt").ToString.Trim = "1" Then TxtNgay_LCt.Value = _DtReturn.Rows(0).Item("Ngay_HT")
        If DrDmct.Item("M_Ngay_Ct").ToString.Trim = "1" Then TxtNgay_Ct.Value = _DtReturn.Rows(0).Item("Ngay_HT")
        _Ngay_Ct = TxtNgay_Ct.Value
        _Ngay_LCT = TxtNgay_Ct.Value
    End Sub
    Private Sub V_GetNoVoucherAuto()
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If Not DrDmct.Item("M_Au_So_Ct").ToString.Trim = "1" And TxtSo_Ct.Text.Trim <> "" Then Exit Sub
        If Not TxtSo_Ct.Text.Trim = "" Then Exit Sub
        Dim _Ngay_LCt As Date = TxtNgay_LCt.Value
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        TxtSo_Ct.Text = CyberSupport.V_GetNoVoucherAuto(M_Mode, TxtSo_Ct.Text, M_Stt_Rec, _Ngay_Ct, _Ngay_LCt, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub
#End Region
#Region "Valid - Master"
#Region "Valid --- DMQuyen"
    Private Sub L_Ma_Quyen(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_Quyen.Text = "" Then Exit Sub
        DrReturn = Nothing
        CyberSmlistSys.Lookup(M_LAN, M_Para, osysvar, AppConn, M_DsLookUp, TxtMa_Quyen.Text, "ma_Quyen", "DmQuyen", DrReturn, "1=1", "1=1", "1")
        If DrReturn Is Nothing Then TxtMa_Quyen.Text = "" Else TxtMa_Quyen.Text = DrReturn.Item("ma_Quyen")
    End Sub
#End Region
#End Region
#Region "Lenh/SO/Po/Ro/Vt"
    Private Sub L_Lenh_So(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Dt As Date = TxtNgay_Ct.Value
        TxtLenh_SO.Text = CyberVoucher.V_GetSo_SO(M_Ma_CT, CmbMa_GD.SelectedValue, CbbMa_Post.SelectedValue, _Dt, TxtLenh_SO.Text, TxtMa_Dvcs.Text)
    End Sub
    Private Sub L_Lenh_Po(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Dt As Date = TxtNgay_Ct.Value
        TxtLenh_PO.Text = CyberVoucher.V_GetSo_PO(M_Ma_CT, CmbMa_GD.SelectedValue, CbbMa_Post.SelectedValue, _Dt, TxtLenh_PO.Text, TxtMa_Dvcs.Text)
    End Sub
    Private Sub L_Lenh_Ro(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Dt As Date = TxtNgay_Ct.Value
        TxtLenh_RO.Text = CyberVoucher.V_GetSo_Ro(M_Ma_CT, CmbMa_GD.SelectedValue, M_Mode, _Dt, TxtLenh_RO.Text, TxtMa_Dvcs.Text)
    End Sub
    Private Sub L_Lenh_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Dt As Date = TxtNgay_Ct.Value
        TxtLenh_Vt.Text = CyberVoucher.V_GetSo_VT(M_Ma_CT, CmbMa_GD.SelectedValue, CbbMa_Post.SelectedValue, _Dt, TxtLenh_Vt.Text, TxtMa_Dvcs.Text)
    End Sub

#End Region
#Region "Valid - Detail"
#Region "Valid - Detail - Core"
    Private Sub UpdateList()       
        Dim nT_LuongCB As Decimal = 0
        Dim nT_LuongDT As Decimal = 0
        Dim nT_BH As Decimal = 0       
        Dim nT_Phat As Decimal = 0
        Dim nT_Thuong As Decimal = 0
        Dim nT_Thuc_Linh As Decimal = 0
        Dim nT_Cong As Decimal = 0

        For iRow As Integer = 0 To Dv_DetailTmp.Count - 1
            'Luong_CB
            nT_LuongCB = nT_LuongCB + If(Dt_DetailTmp.Columns.Contains("Tien_LuongCB"), Dv_DetailTmp.Item(iRow).Item("Tien_LuongCB"), 0)
            'Luong_DT
            nT_LuongDT = nT_LuongDT + If(Dt_DetailTmp.Columns.Contains("Tien_LuongDT"), Dv_DetailTmp.Item(iRow).Item("Tien_LuongDT"), 0)
            'Bảo hiểm
            nT_BH = nT_BH + If(Dt_DetailTmp.Columns.Contains("Tien_BH"), Dv_DetailTmp.Item(iRow).Item("Tien_BH"), 0)
            'Giảm trừ
            nT_Phat = nT_Phat + If(Dt_DetailTmp.Columns.Contains("Tien_Phat"), Dv_DetailTmp.Item(iRow).Item("Tien_Phat"), 0)
            'Thưởng
            nT_Thuong = nT_Thuong + If(Dt_DetailTmp.Columns.Contains("Tien_Thuong"), Dv_DetailTmp.Item(iRow).Item("Tien_Thuong"), 0)
            'Chấm công
            nT_Cong = nT_Cong + If(Dt_DetailTmp.Columns.Contains("T_Cong"), Dv_DetailTmp.Item(iRow).Item("T_Cong"), 0)
        Next
       
        TxtT_LuongCB.Double = nT_LuongCB
        TxtT_LuongDT.Double = nT_LuongDT
        TxtT_BH.Double = nT_BH
        TxtT_Thuong.Double = nT_Thuong
        TxtT_Phat.Double = nT_Phat       
        TxtThuc_Linh.Double = nT_LuongCB + nT_LuongDT - nT_BH + nT_Thuong - nT_Phat
        TxtT_Cong.Double = nT_Cong

        TxtT_LuongCB.Refresh()
        TxtT_LuongDT.Refresh()
        TxtT_BH.Refresh()
        TxtT_Cong.Refresh()
        TxtT_Thuong.Refresh()
        TxtT_Phat.Refresh()
        TxtThuc_Linh.Refresh()
    End Sub
    Private Sub V_Tinh_ToanCB(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim nTy_Gia As Decimal = V_GetTyGia()
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        DetailGRVluong1.PostEditor()

        '--------------------------------------------------------------------------------
        Dim iRow As Integer = -1
        iRow = DetailGRVluong1.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dt_DetailTmp.AcceptChanges()
        '----------------
        Dv_DetailTmp.Item(iRow).Item("Tien_LuongCB") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("Luong_CB1") + Dv_DetailTmp.Item(iRow).Item("Luong_CB2") + Dv_DetailTmp.Item(iRow).Item("Luong_CB3") + Dv_DetailTmp.Item(iRow).Item("Luong_CB4") + _
                                                                         +Dv_DetailTmp.Item(iRow).Item("Luong_CB5") + +Dv_DetailTmp.Item(iRow).Item("Luong_CB6") + +Dv_DetailTmp.Item(iRow).Item("Luong_CB7") + Dv_DetailTmp.Item(iRow).Item("Luong_CB8") + Dv_DetailTmp.Item(iRow).Item("Luong_CB8") + Dv_DetailTmp.Item(iRow).Item("Luong_CB9") + Dv_DetailTmp.Item(iRow).Item("Luong_CB10"), M_R_TIEN)


        Dv_DetailTmp.Item(iRow).EndEdit()

        CyberSupport.V_UpdateGRV(DetailGRVluong1)
        UpdateList()
    End Sub
    Private Sub V_Tinh_ToanDT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim nTy_Gia As Decimal = V_GetTyGia()
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        DetailGRVluong2.PostEditor()

        '--------------------------------------------------------------------------------
        Dim iRow As Integer = -1
        iRow = DetailGRVluong2.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dt_DetailTmp.AcceptChanges()
        '----------------
        Dv_DetailTmp.Item(iRow).Item("Tien_LuongDT") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("Luong_DT1") + Dv_DetailTmp.Item(iRow).Item("Luong_DT2") + Dv_DetailTmp.Item(iRow).Item("Luong_DT3") + Dv_DetailTmp.Item(iRow).Item("Luong_DT4") + _
                                                                         +Dv_DetailTmp.Item(iRow).Item("Luong_DT5") + +Dv_DetailTmp.Item(iRow).Item("Luong_DT6") + +Dv_DetailTmp.Item(iRow).Item("Luong_DT7") + Dv_DetailTmp.Item(iRow).Item("Luong_DT8") + Dv_DetailTmp.Item(iRow).Item("Luong_DT8") + Dv_DetailTmp.Item(iRow).Item("Luong_DT9") + Dv_DetailTmp.Item(iRow).Item("Luong_DT10"), M_R_TIEN)


        Dv_DetailTmp.Item(iRow).EndEdit()

        CyberSupport.V_UpdateGRV(DetailGRVluong2)
        UpdateList()
    End Sub
    Private Sub V_Tinh_ToanBH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim nTy_Gia As Decimal = V_GetTyGia()
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        DetailGRVluong3.PostEditor()

        '--------------------------------------------------------------------------------
        Dim iRow As Integer = -1
        iRow = DetailGRVluong3.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dt_DetailTmp.AcceptChanges()
        '----------------
        Dv_DetailTmp.Item(iRow).Item("Tien_BH") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("BHXH1") + Dv_DetailTmp.Item(iRow).Item("BHXH2") + Dv_DetailTmp.Item(iRow).Item("BHYT1") + Dv_DetailTmp.Item(iRow).Item("BHYT2") _
                                                                       + Dv_DetailTmp.Item(iRow).Item("BHTN1") + Dv_DetailTmp.Item(iRow).Item("BHTN2"), M_R_TIEN)
        Dv_DetailTmp.Item(iRow).EndEdit()
        CyberSupport.V_UpdateGRV(DetailGRVluong3)
        UpdateList()
    End Sub
    Private Sub V_Tinh_ToanGiam(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim nTy_Gia As Decimal = V_GetTyGia()
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        DetailGRVluong4.PostEditor()

        '--------------------------------------------------------------------------------
        Dim iRow As Integer = -1
        iRow = DetailGRVluong4.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dt_DetailTmp.AcceptChanges()
        '----------------
        Dv_DetailTmp.Item(iRow).Item("Tien_Phat") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("Phat1") + Dv_DetailTmp.Item(iRow).Item("Phat2") + Dv_DetailTmp.Item(iRow).Item("Phat3") + Dv_DetailTmp.Item(iRow).Item("Phat4") + Dv_DetailTmp.Item(iRow).Item("Phat5"), M_R_TIEN)
        Dv_DetailTmp.Item(iRow).EndEdit()
        CyberSupport.V_UpdateGRV(DetailGRVluong4)
        UpdateList()
    End Sub
    Private Sub V_Tinh_ToanThuong(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim nTy_Gia As Decimal = V_GetTyGia()
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        DetailGRVluong5.PostEditor()

        '--------------------------------------------------------------------------------
        Dim iRow As Integer = -1
        iRow = DetailGRVluong5.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dt_DetailTmp.AcceptChanges()
        '----------------
        Dv_DetailTmp.Item(iRow).Item("Tien_Thuong") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("Thuong1") + Dv_DetailTmp.Item(iRow).Item("Thuong2") + Dv_DetailTmp.Item(iRow).Item("Thuong3") + Dv_DetailTmp.Item(iRow).Item("Thuong4") + Dv_DetailTmp.Item(iRow).Item("Thuong5"), M_R_TIEN)
        Dv_DetailTmp.Item(iRow).EndEdit()
        CyberSupport.V_UpdateGRV(DetailGRVluong5)
        UpdateList()
    End Sub
    Private Sub V_Tinh_ToanThueTNCN(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim nTy_Gia As Decimal = V_GetTyGia()
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        DetailGRVluong5.PostEditor()

        '--------------------------------------------------------------------------------
        Dim iRow As Integer = -1
        iRow = DetailGRVluong5.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dt_DetailTmp.AcceptChanges()
        '----------------
        Dv_DetailTmp.Item(iRow).Item("Tong_Thue_TNCN") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("Thue_TNCN1") + Dv_DetailTmp.Item(iRow).Item("Thue_TNCN2") + Dv_DetailTmp.Item(iRow).Item("Thue_TNCN3") + Dv_DetailTmp.Item(iRow).Item("Thue_TNCN4") + Dv_DetailTmp.Item(iRow).Item("Thue_TNCN5"), M_R_TIEN)
        Dv_DetailTmp.Item(iRow).EndEdit()
        CyberSupport.V_UpdateGRV(DetailGRVluong5)
        UpdateList()
    End Sub
    Private Sub V_Tinh_ToanCong(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim nTy_Gia As Decimal = V_GetTyGia()
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        DetailGRVluong6.PostEditor()

        '--------------------------------------------------------------------------------
        Dim iRow As Integer = -1
        iRow = DetailGRVluong6.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dt_DetailTmp.AcceptChanges()
        '----------------
        Dv_DetailTmp.Item(iRow).Item("T_Cong") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("Cong") + Dv_DetailTmp.Item(iRow).Item("Them_Gio") / 24, M_R_TIEN)
        Dv_DetailTmp.Item(iRow).EndEdit()
        CyberSupport.V_UpdateGRV(DetailGRVluong6)
        UpdateList()
    End Sub
#End Region
#End Region
#Region "Valid - Detail - Add On"
    Private Sub V_Ma_Vv_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Vv_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Vv_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Vv_i(M_Mode, M_Ma_CT, sender, DetailGRVluong1)
    End Sub
    Private Sub V_Ma_Phi_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Phi_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Phi_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Phi_i(M_Mode, M_Ma_CT, sender, DetailGRVluong1)
    End Sub
    Private Sub V_Ma_HD_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Hd_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_HD_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Hd_i(M_Mode, M_Ma_CT, sender, DetailGRVluong1)
    End Sub
    Private Sub V_Ma_SP_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Sp_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_SP_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Sp_i(M_Mode, M_Ma_CT, sender, DetailGRVluong1)
    End Sub
    Private Sub V_Ma_Ku_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Ku_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Ku_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Ku_i(M_Mode, M_Ma_CT, sender, DetailGRVluong1)
    End Sub
    Private Sub V_Ma_TTLN_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TTLN_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TTLN_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TTLN_i(M_Mode, M_Ma_CT, sender, DetailGRVluong1)
    End Sub
    Private Sub V_Ma_TTCP_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TTCP_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TTCP_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TTCP_i(M_Mode, M_Ma_CT, sender, DetailGRVluong1)
    End Sub
    Private Sub V_Ma_Bp_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Bp_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Bp_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Bp_i(M_Mode, M_Ma_CT, sender, DetailGRVluong1)
    End Sub
    Private Sub V_Ma_HS_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Hs_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_HS_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Hs_i(M_Mode, M_Ma_CT, sender, DetailGRVluong1)
    End Sub
    Private Sub V_Ma_CD_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Cd_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_CD_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Cd_i(M_Mode, M_Ma_CT, sender, DetailGRVluong1)
    End Sub
    Private Sub V_Ma_TD1_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Td1_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TD1_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Td1_i(M_Mode, M_Ma_CT, sender, DetailGRVluong1)
    End Sub
    Private Sub V_Ma_TD2_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD2_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TD2_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD2_i(M_Mode, M_Ma_CT, sender, DetailGRVluong1)
    End Sub
    Private Sub V_Ma_TD3_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD3_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TD3_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD3_i(M_Mode, M_Ma_CT, sender, DetailGRVluong1)
    End Sub
    Private Sub V_Ma_TD4_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD4_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TD4_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD4_i(M_Mode, M_Ma_CT, sender, DetailGRVluong1)
    End Sub
    Private Sub V_Ma_TD5_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD5_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TD5_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.V_Ma_TD5_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
#End Region
#Region "Ngay ct, ngay lap chung tu,so chung tu"

    Private Sub V_Ngay_Ct(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If DrDmct.Item("M_Au_So_Ct").ToString.Trim = "1" Then Exit Sub

        If Not TxtSo_Ct.Text.Trim = "" Then Exit Sub
        Dim _Ngay_LCt As Date = TxtNgay_LCt.Value
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        TxtSo_Ct.Text = CyberSupport.V_GetNoVoucher(M_Mode, TxtSo_Ct.Text, M_Stt_Rec, _Ngay_Ct, _Ngay_LCt, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub
    Private Sub V_Ngay_LCt(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If DrDmct.Item("M_Au_So_Ct").ToString.Trim = "1" Then Exit Sub
        If Not TxtSo_Ct.Text.Trim = "" Then Exit Sub
        Dim _Ngay_LCt As Date = TxtNgay_LCt.Value
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        TxtSo_Ct.Text = CyberSupport.V_GetNoVoucher(M_Mode, TxtSo_Ct.Text, M_Stt_Rec, _Ngay_Ct, _Ngay_LCt, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub
    Private Sub V_So_Ct(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If DrDmct.Item("M_Au_So_Ct").ToString.Trim = "1" Then Exit Sub
        If Not TxtSo_Ct.Text.Trim = "" Then Exit Sub
        Dim _Ngay_LCt As Date = TxtNgay_LCt.Value
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        TxtSo_Ct.Text = CyberSupport.V_GetNoVoucher(M_Mode, TxtSo_Ct.Text, M_Stt_Rec, _Ngay_Ct, _Ngay_LCt, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub
#End Region
#Region "Ty gia -  Ngoai te"
    Private Sub L_Ma_NT(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = Nothing
        CyberSmlistSys.Lookup(M_LAN, M_Para, osysvar, AppConn, DsLookup, TxtMa_NT.Text, "Ma_NT", "DmNT", DrReturn, "1=1", "1=1", "1")
        If Not DrReturn Is Nothing Then TxtMa_NT.Text = DrReturn.Item("Ma_NT") Else TxtMa_NT.Text = ""
        Dim Dt As Date = TxtNgay_Ct.Value
        TxtTy_Gia.Double = CyberSupport.GetRate(Dt, TxtMa_NT.Text, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
        GetRound()
        For iRow As Integer = 0 To Dv_DetailTmp.Count - 1
            'V_Tinh_Toan(iRow)
        Next

        'VisibleColumnMa_NT()
    End Sub
    Private Sub L_Ty_Gia(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_NT.Text.Trim = "" Or TxtMa_NT.Text.Trim.ToUpper = osysvar("M_MA_NT0").ToString.Trim Then TxtTy_Gia.Double = 1
        For iRow As Integer = 0 To Dv_DetailTmp.Count - 1
            'V_Tinh_Toan(iRow)
        Next
        Dv_DetailTmp.Table.AcceptChanges()
    End Sub
    Private Function V_GetTyGia() As Decimal
        Dim nTy_Gia As Decimal = TxtTy_Gia.Double
        If nTy_Gia = 0 Then nTy_Gia = 1
        If TxtMa_NT.Text.Trim = "" Then TxtMa_NT.Text = osysvar("M_MA_NT0")
        If TxtMa_NT.Text.Trim = "" Or TxtMa_NT.Text.Trim.ToUpper = osysvar("M_MA_NT0").ToString.ToUpper.Trim Then TxtTy_Gia.Double = 1
        TxtTy_Gia.Double = nTy_Gia
        V_GetTyGia = nTy_Gia
    End Function
#End Region
#Region "Mainform"
    Private Sub V_MainSystem()
        Dim mnItemsMail = New ContextMenu

        Dim mnItemsF4 As New MenuItem(If(M_LAN = "V", "Thêm dòng", "New row"), AddressOf V_ShortAddItem, Keys.F4)
        Dim mnItemsF5 As New MenuItem(If(M_LAN = "V", "Chọn phiếu nhập", "Select Receipt"), AddressOf V_ShortF5, Keys.F5)
        Dim mnItemsF8 As New MenuItem(If(M_LAN = "V", "Xóa dòng", "Delete row"), AddressOf V_ShortDeleteItem, Keys.F8)

        Dim mnItemsSave As New MenuItem(If(M_LAN = "V", "Lưu chứng từ", "Save"), AddressOf V_ShortSAVE, Keys.Control + Keys.Enter)
        Dim mnItemsPrint As New MenuItem(If(M_LAN = "V", "In chứng từ", "Print"), AddressOf V_ShortPrint, Keys.Control + Keys.P)

        mnItemsMail.MenuItems.Add(mnItemsF4)
        mnItemsMail.MenuItems.Add(mnItemsF5)
        mnItemsMail.MenuItems.Add(mnItemsF8)

        mnItemsMail.MenuItems.Add(mnItemsSave)
        mnItemsMail.MenuItems.Add(mnItemsPrint)
        Me.ContextMenu = mnItemsMail
    End Sub
    Private Sub MasterGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer = e.HitInfo.RowHandle
        If e.MenuType <> DevExpress.XtraGrid.Views.Grid.GridMenuType.Column Then
            PopupMenuMasterGrid.ItemLinks.Clear()
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Thêm dòng", "Add item"), AddressOf V_ShortAddItem, Nothing, True, False))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xóa dòng", "Delete item"), AddressOf V_ShortDeleteItem, Nothing, True, False))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Import", "Delete item"), AddressOf V_Import, Nothing, True, True))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Lưu chứng từ", "Save"), AddressOf V_ShortSAVE, Nothing, True, True))
            PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        End If
    End Sub
    Private Sub V_ShortF5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVluong1.FocusedRowHandle
        If iRow < 0 Then Exit Sub

        Dim _Ma_hs As String = ""

        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value

        If Dt_DetailTmp.Columns.Contains("Ma_hs_i") Then _Ma_hs = Dv_DetailTmp.Item(iRow).Item("Ma_hs_i")

        Dv_DetailTmp.Table.AcceptChanges()
        'V_Tinh_Toan(iRow)
        UpdateList()
    End Sub
    Private Sub V_ShortAddItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVluong1.FocusedRowHandle
        V_AddItem(iRow)
    End Sub
    Private Sub V_ShortDeleteItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVluong1.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(osysvar, M_LAN, M_Ma_CT, iRow, Dv_DetailTmp, AppConn, DetailGRVluong1) Then Exit Sub
        Dv_DetailTmp.Delete(iRow)
        Dv_DetailTmp.Table.AcceptChanges()
        UpdateList()
    End Sub
    Private Sub V_ShortSAVE(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If Me.CmdSave.Enabled Then CmdSave.Focus()
        If Me.CmdSave.Enabled Then CmdSave.PerformClick()
    End Sub
    Private Sub V_ShortPrint(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not M_Mode = "X" Then Exit Sub
        If M_Stt_Rec.Trim = "" Then Exit Sub
        If Me.CmdPrint.Enabled Then V_Print(sender, e)
    End Sub
    Private Sub FrmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If M_Mode.Trim = "X" Then If e.KeyValue = 27 Then V_Exit(sender, e)
        If M_Mode.Trim = "X" Then
            Select Case e.KeyValue
                Case 33 'Pageup
                    V_Prev(sender, e)
                Case 34 'PageDown
                    V_NEXT(sender, e)
                Case 35 'End
                    V_Bottom(sender, e)
                Case 36 'Home
                    V_Top(sender, e)
            End Select
        End If
    End Sub
    Private Function ChkRightsVoucher(ByVal _Mode As String) As Boolean
        Dim _Dt As Date = TxtNgay_Ct.Value
        Dim _Ma_Post As String = CbbMa_Post.SelectedValue.ToString.Trim
        ChkRightsVoucher = CyberSupport.ChkRightsVoucher(_Dt, _Mode, _Ma_Post, M_Stt_Rec, M_Ma_CT, M_Ma_Dvcs, M_User_Name, M_LAN, AppConn, osysvar, CyberSmlib)
    End Function
#End Region
#Region "Button"
    Private Sub V_Save(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DetailGRVluong1.PostEditor()
        DetailGRVluong2.PostEditor()
        DetailGRVluong3.PostEditor()
        DetailGRVluong4.PostEditor()
        DetailGRVluong5.PostEditor()
        DetailGRVluong6.PostEditor()

        Dv_DetailTmp.Table.AcceptChanges()
        If M_Mode.Trim = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        If M_Mode.Trim = "M" Then TxtUser_id.Text = M_User_ID
        If TxtMa_NT.Text.Trim = "" Then V_GetTyGia()
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        Dim _Ngay_LCt As Date = TxtNgay_Ct.Value
        '----------------------------------------------------------------------------------------------------------------------
        V_GetDateVoucher(M_Mode, _Ngay_Ct, _Ngay_LCt)
        '----------------------------------------------------------------------------------------------------------------------

        '----------------------------------------------------------------------------------------------------------------------
        V_GetNoVoucherAuto() ' Tao So Chung tu tu dong
        '----------------------------------------------------------------------------------------------------------------------
        If Not ChkVsave() Then Exit Sub 'Kiem tra va Update du lieu chuong tri
        '----------------------------------------------------------------------------------------------------------------------
        If Not CyberSupport.ChkVoucherInput(Me, AppConn, osysvar, M_LAN, DrDmct, M_Mode, M_Ma_CT, _Ngay_Ct, CmbMa_GD.SelectedValue, M_Stt_Rec, CbbMa_Post.SelectedValue, M_Ma_Dvcs, M_User_Name, Dt_DetailTmp, "Ten_hs", "Ten_hs", CyberSmlib, CyberSupport, CyberSmodb, CyberLoading) Then Exit Sub
        '----------------------------------------------------------------------------------------------------------------------
        If Not CyberSupport.V_ChkExistNovoucher(AppConn, osysvar, M_LAN, DrDmct, M_Mode, M_Stt_Rec, M_Ma_CT, TxtSo_Ct.Text.Trim, _Ngay_Ct, _Ngay_LCt, M_Ma_Dvcs, M_User_Name, CyberSmlib) Then Exit Sub '---Kiem tra trung so chung tu
        '----------------------------------------------------------------------------------------------------------------------

        If Not Add2Database() Then Return
        '----------------------------------------------------------------------------------------------------------------------
        M_Mode = "X"
        M_Count = Dt_Master.Rows.Count
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_SetFocus("L")
        CyberSmlib.FlushMemorySave()

    End Sub
    Private Function ChkVsave() As Boolean
        Dim iRow, nCount As Integer
        nCount = Dt_DetailTmp.Rows.Count
        For iRow = nCount - 1 To 0 Step -1
            If Dt_DetailTmp.Rows(iRow).Item("Ma_hs_i").ToString.Trim = "" Then
                Dt_DetailTmp.Rows(iRow).Delete()
                Dt_DetailTmp.AcceptChanges()
            End If
        Next
        '---------------------------------------------------------------------------------
        For iRow = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_DetailTmp.Rows(iRow).BeginEdit()
            Dt_DetailTmp.Rows(iRow).Item("Stt_Rec") = M_Stt_Rec
            Dt_DetailTmp.Rows(iRow).Item("Ma_Ct") = M_Ma_CT
            Dt_DetailTmp.Rows(iRow).Item("Ngay_Ct") = TxtNgay_Ct.Value
            Dt_DetailTmp.Rows(iRow).Item("So_Ct") = CyberSupport.V_soct(TxtSo_Ct.Text.Trim)
            Dt_DetailTmp.Rows(iRow).Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(iRow + 1)
            Dt_DetailTmp.Rows(iRow).EndEdit()
        Next
        Dt_DetailTmp.AcceptChanges()
        If Not CyberSupport.ChkDetail(Dv_DetailTmp.Count, M_Ma_CT, M_LAN, osysvar) Then Return False
        '---Update: So_RO/So_PO/So_SO
        CyberSupport.V_SaveLenh(Dv_DetailTmp, TxtLenh_RO.Text, TxtLenh_PO.Text, TxtLenh_SO.Text, TxtLenh_Vt.Text)
        UpdateList()
        ChkVsave = True
    End Function
    Private Function Add2Database() As Boolean
        Dim drMaster As DataRow
        Dim CrrRow As Integer = -1
        If M_Mode.Trim = "M" Then
            drMaster = Dt_Master.NewRow
            CyberSmodb.SetValueBlankRow(drMaster)
            CyberSmodb.AddValueToRow(drMaster, Me)
            drMaster.Item("Stt_Rec") = M_Stt_Rec
            drMaster.Item("Ma_Dvcs") = M_Ma_Dvcs
        Else
            CrrRow = Dt_Master.Rows.IndexOf(Dt_Master.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(0))
            drMaster = Dt_Master.Rows(CrrRow)
            CyberSmodb.AddValueToRow(drMaster, Me)
            drMaster.BeginEdit()
        End If
        drMaster.Item("Stt_Rec") = M_Stt_Rec.Trim
        drMaster.Item("Ma_Ct") = M_Ma_CT.Trim
        '--------------drMaster.Item("User_Id") = M_User_ID.Trim
        drMaster.Item("So_Ct") = CyberSupport.V_soct(TxtSo_Ct.Text.Trim)
        '---Save Post
        CyberSupport.V_SavePost(AppConn, drMaster, CbbMa_Post.SelectedValue, M_Ma_CT, M_User_Name, M_User_Name, CyberSmlib)
        If M_Mode.Trim = "M" Then Dt_Master.Rows.Add(drMaster) Else Dt_Master.Rows(CrrRow).EndEdit()
        Dt_Master.AcceptChanges()
        '-----------------------------------------------------------------------------------------------------
        '---Xoa trong Detail
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_Detail, "Stt_Rec = '" + M_Stt_Rec + "'")
        '+Import To Detail 
        For i As Integer = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_Detail.ImportRow(Dt_DetailTmp.Rows(i))
        Next
        '-----------------------------------------------------------------------------------------------------
        Return CyberSmodb.V_Add2Database(AppConn, osysvar, {Dt_DetailTmp, CyberSmodb.V_ConvertDrToTb(drMaster)}, {M_Ct, M_Ph}, M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, M_Ma_CT, M_Stt_Rec, M_LAN, TxtMa_Dvcs.Text, M_User_Name, CyberSmlib, CyberSupport)
        ''---Save: History
        'CyberSupport.V_HistoryVoucher(M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, M_Ma_CT, M_Stt_Rec, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
        ''-----------------------------------------------------------------------------------------------------
        ''---Save: TO SQL
        'If M_Ph.Trim <> "" Then CyberSmodb.V_SaveToSQL(AppConn, osysvar, M_User_Name, drMaster, M_Ph, M_Mode, "Stt_Rec = N'" + M_Stt_Rec + "'", IIf(M_Mode.Trim = "S", True, False))
        'If M_Ct.Trim <> "" Then CyberSmodb.V_CyberSaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailTmp, M_Ct, M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")
        ''-----------------------------------------------------------------------------------------------------
        ''---Save: Post
        'CyberSupport.V_PostVoucher(M_Mode, M_Ma_CT, M_Stt_Rec, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Function
    Private Sub Add2Database_Luu()
        Dim drMaster As DataRow
        Dim CrrRow As Integer = -1
        If M_Mode.Trim = "M" Then
            drMaster = Dt_Master.NewRow
            CyberSmodb.SetValueBlankRow(drMaster)
            CyberSmodb.AddValueToRow(drMaster, Me)
            drMaster.Item("Stt_Rec") = M_Stt_Rec
            drMaster.Item("Ma_Dvcs") = M_Ma_Dvcs
        Else
            CrrRow = Dt_Master.Rows.IndexOf(Dt_Master.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(0))
            drMaster = Dt_Master.Rows(CrrRow)
            CyberSmodb.AddValueToRow(drMaster, Me)
            drMaster.BeginEdit()
        End If
        drMaster.Item("Stt_Rec") = M_Stt_Rec.Trim
        drMaster.Item("Ma_Ct") = M_Ma_CT.Trim
        '--------------drMaster.Item("User_Id") = M_User_ID.Trim
        drMaster.Item("So_Ct") = CyberSupport.V_soct(TxtSo_Ct.Text.Trim)
        '---Save Post
        CyberSupport.V_SavePost(AppConn, drMaster, CbbMa_Post.SelectedValue, M_Ma_CT, M_User_Name, M_User_Name, CyberSmlib)
        If M_Mode.Trim = "M" Then Dt_Master.Rows.Add(drMaster) Else Dt_Master.Rows(CrrRow).EndEdit()
        Dt_Master.AcceptChanges()
        '-----------------------------------------------------------------------------------------------------
        '---Xoa trong Detail
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_Detail, "Stt_Rec = '" + M_Stt_Rec + "'")
        '+Import To Detail 
        For i As Integer = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_Detail.ImportRow(Dt_DetailTmp.Rows(i))
        Next
        '-----------------------------------------------------------------------------------------------------
        '---Save: History
        CyberSupport.V_HistoryVoucher(M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, M_Ma_CT, M_Stt_Rec, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
        '-----------------------------------------------------------------------------------------------------
        '---Save: TO SQL
        If M_Ph.Trim <> "" Then CyberSmodb.V_SaveToSQL(AppConn, osysvar, M_User_Name, drMaster, M_Ph, M_Mode, "Stt_Rec = N'" + M_Stt_Rec + "'", IIf(M_Mode.Trim = "S", True, False))
        If M_Ct.Trim <> "" Then CyberSmodb.V_CyberSaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailTmp, M_Ct, M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")
        '-----------------------------------------------------------------------------------------------------
        '---Save: Post
        CyberSupport.V_PostVoucher(M_Mode, M_Ma_CT, M_Stt_Rec, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub
    Private Sub V_Copy(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If M_Stt_Rec.Trim = "" Then Exit Sub
        If Not ChkRightsVoucher("C") Then Exit Sub

        M_Stt_RecOld = M_Stt_Rec
        M_Stt_Rec = CyberSmlib.V_Get_Stt_Rec(M_Ma_CT, AppConn)

        Dim Frm As Cyber.From.FrmCopy
        Frm = New FrmCopy
        Frm.Para = M_Para
        Frm.Lan = M_LAN
        Frm.Sysvar = osysvar
        Frm.DrDmct = Me.DrDmct
        Frm.So_CT = ""
        Frm.Ngay_CT = Now.Date
        Frm.Ngay_LCT = Now.Date
        Frm.SysApp = AppConn
        Frm.Ma_Dvcs = TxtMa_Dvcs.Text
        Frm.Stt_Rec = M_Stt_Rec
        Frm.ShowDialog()

        If Not Frm.Ok_Copy Then
            M_Stt_Rec = M_Stt_RecOld
            Exit Sub
        End If

        Dim _Ngay_Ct_Copy As Date = Frm.TxtNgay_Ct.Value
        Dim _Ngay_LCt_Copy As Date = Frm.TxtNgay_LCt.Value
        Dim _So_Ct_Copy As String = Frm.txtSo_ct.Text
        Dim _Ma_Quyen_Copy As String = Frm.TxtMa_Quyen.Text

        Dim I As Integer
        For I = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_DetailTmp.Rows(I).BeginEdit()
            Dt_DetailTmp.Rows(I).Item("Stt_Rec") = M_Stt_Rec
            Dt_DetailTmp.Rows(I).Item("Ngay_Ct") = _Ngay_Ct_Copy
            Dt_DetailTmp.Rows(I).Item("So_Ct") = _So_Ct_Copy
            Dt_DetailTmp.Rows(I).EndEdit()
        Next

        TxtStt_Rec.Text = M_Stt_Rec
        TxtNgay_Ct.Value = _Ngay_Ct_Copy
        TxtNgay_LCt.Value = _Ngay_LCt_Copy
        TxtMa_Quyen.Text = _Ma_Quyen_Copy.Trim
        TxtSo_Ct.Text = _So_Ct_Copy.Trim
        M_Mode = "M"
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()

    End Sub
    Private Sub V_New(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Stt_RecOld = M_Stt_Rec
        If Not ChkRightsVoucher("M") Then Exit Sub
        M_Stt_Rec = CyberSmlib.V_Get_Stt_Rec(M_Ma_CT, AppConn)

        M_Mode = "M"
        V_Databing()
        '--------------
        TxtStt_Rec.Text = M_Stt_Rec
        TxtMa_Dvcs.Text = M_Ma_Dvcs
        If TxtDien_Giai.Text.Trim = "" Then TxtDien_Giai.Text = M_Dien_Giai
        V_New()
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_SetFocus("M")
    End Sub
    Private Sub V_New()
        If Dt_DetailTmp.Rows.Count < 1 Then
            Dim DrCurren As DataRow
            Dt_DetailTmp.NewRow()
            DrCurren = Dt_DetailTmp.NewRow
            CyberSmodb.SetValueBlankRow(DrCurren)
            DrCurren.Item("Stt_Rec") = M_Stt_Rec.Trim
            DrCurren.Item("Ma_Ct") = M_Ma_CT.Trim
            DrCurren.Item("Ngay_Ct") = TxtNgay_Ct.Value
            DrCurren.Item("Stt_Rec0") = "0001"

            Dt_DetailTmp.Rows.Add(DrCurren)
            Dt_DetailTmp.AcceptChanges()
        End If

    End Sub
    Private Sub V_Edit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Stt_RecOld = M_Stt_Rec
        If Not ChkRightsVoucher("S") Then Exit Sub
        M_Mode = "S"
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_SetFocus("S")
    End Sub
    Private Sub V_Delete(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If M_Stt_Rec.Trim = "" Then Exit Sub
        If Not ChkRightsVoucher("D") Then Exit Sub
        Dim iMasterRow As Integer = -1
        For iRow As Integer = 0 To Dv_Master.Count - 1
            If Dv_Master.Item(iRow).Item("Stt_Rec").ToString.Trim = M_Stt_Rec Then
                iMasterRow = iRow
                Exit For
            End If
        Next
        If Not CyberSupport.V_DeleteVoucher(AppConn, osysvar, M_LAN, M_Stt_Rec, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib) Then Exit Sub
        CyberSupport.V_DeleteTableVoucher(Dt_Master, M_Stt_Rec)
        CyberSupport.V_DeleteTableVoucher(Dt_Detail, M_Stt_Rec)

        M_Count = Dt_Master.Rows.Count

        If M_Count < 0 Then iMasterRow = -1
        If iMasterRow >= M_Count Then iMasterRow = M_Count - 1

        If iMasterRow >= 0 Then M_Stt_Rec = Dv_Master.Item(iMasterRow).Item("Stt_Rec").ToString.Trim Else M_Stt_Rec = ""

        M_Mode = "X"
        V_Databing()

        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_SetFocus("D")
    End Sub
    Private Sub V_Print(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not ChkRightsVoucher("P") Then Exit Sub
        If M_Stt_Rec.Trim = "" Then Exit Sub
        Dim _Dt As Date = TxtNgay_Ct.Value
        Dim _Ma_Post As String = CbbMa_Post.SelectedValue.ToString.Trim
        CyberVoucher.V_PrintVocuher(AppConn, osysvar, Nothing, M_Stt_Rec, _Dt, _Ma_Post, M_LAN, M_Para, DrDmct, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport)
    End Sub
    Private Sub V_Cancel(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Stt_Rec = M_Stt_RecOld
        V_Databing()
        M_Mode = "X"
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_SetFocus("X")
    End Sub
    Private Sub V_View(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = "X"
        If M_Stt_Rec = "" Then Exit Sub
        M_Stt_Rec = CyberFrom.V_ViewVoucher(AppConn, osysvar, M_LAN, M_Para, DrDmct, DsData, DsHead, DsLookup, Dv_Master, Dv_Detail, M_Stt_Rec, strFilter, CyberFill, CyberSmlib, CyberSupport, False, True)
        V_Databing()
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
    End Sub
    Private Sub V_Search(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not CyberVoucher.V_FilterVocuher(AppConn, osysvar, Me.DsLookup, M_LAN, M_Para, DrDmct, M_strFilter, M_Ma_CT, M_Ma_Dvcs, M_User_Name) Then Exit Sub
        Dim DsRefresh As DataSet = CyberSupport.V_FilterData(AppConn, M_strFilter, CyberSmlib, CyberSmodb, DsData)
        If Not CyberSupport.MsgFilterData(DsRefresh.Tables(1), M_LAN, osysvar) Then Exit Sub

        If DsRefresh.Tables(1).Rows.Count = 1 Then M_Stt_Rec = DsRefresh.Tables(1).Rows(0).Item("Stt_Rec")
        If DsRefresh.Tables(1).Rows.Count > 1 Then M_Stt_Rec = CyberFrom.V_ViewVoucher(AppConn, osysvar, M_LAN, M_Para, DrDmct, Me.DsData, Me.DsHead, Me.DsLookup, Dv_Master, Dv_Detail, M_Stt_Rec, strFilter, CyberFill, CyberSmlib, CyberSupport, False, True)

        V_Databing()
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        M_Mode = "X"
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
    End Sub
    Private Sub V_Exit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not CyberSupport.V_ExitVoucher(osysvar, M_LAN) Then Exit Sub
        Me.Close()
    End Sub
#End Region
#Region "Add Or Detete Item"

    Private Sub MasterGRV_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iCoumnVisible As Integer = sender.VisibleColumns.Count - 1
        Dim iRowVisible As Integer = sender.RowCount - 1
        Dim iRowRowFocus As Integer = sender.FocusedRowHandle
        Dim iColumnRowFocus As Integer = sender.VisibleColumns.IndexOf(sender.FocusedColumn)
        Dim iRowOld As Integer = sender.GetFocusedDataSourceRowIndex
        'If e.KeyCode = Keys.Enter And iRowVisible = iRowRowFocus And iCoumnVisible = iColumnRowFocus Then V_AddItem(iRowOld) '' Cot cuoi cung them dong
        If iRowVisible <> iRowRowFocus Or iCoumnVisible <> iColumnRowFocus Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            V_AddItem(iRowOld) '' Cot cuoi cung them dong
        ElseIf e.KeyCode = Keys.End Then
            SendKeys.Send("^{Tab}")
        End If
    End Sub
    Private Sub V_AddItem(Optional ByVal iRow As Integer = -1)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim DrvOld As DataRowView
        If iRow >= 0 Then DrvOld = Dv_DetailTmp.Item(iRow) Else DrvOld = Nothing
        Dv_DetailTmp.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(Dv_DetailTmp.Table.Rows(Dv_DetailTmp.Table.Rows.Count - 1))
        CyberSupport.SetCarryOn(DrvOld, Dv_DetailTmp.Table.Rows(Dv_DetailTmp.Table.Rows.Count - 1), New DataView(M_DsHead.Tables(1)))
        CarrOn(Dv_DetailTmp.Table.Rows(Dv_DetailTmp.Table.Rows.Count - 1))
        UpdateList()
        iRow = Dv_DetailTmp.Count - 1
        CyberFill.V_ForcusCell(DetailGRVluong1, iRow, 0)

    End Sub
    Private Sub CarrOn(ByVal DvNew As DataRow)
        DvNew.Item("Stt_Rec") = M_Stt_Rec.Trim
        DvNew.Item("Ma_Ct") = M_Ma_CT.Trim
        DvNew.Item("Ngay_Ct") = Me.TxtNgay_Ct.Value
    End Sub
#End Region
#Region "Sms - Import"
    Private Sub V_Import(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim TbImport As New DataTable
        TbImport = CyberExport.V_ImportDataToGridview(AppConn, osysvar, M_Para, DetailGRVluong1, Dt_DetailTmp, M_LAN)      
        If TbImport Is Nothing Then Exit Sub
        '==================== Xu ly du lieu được Import vào
        'Luong_CB
        Dt_DetailTmp.Clear()
        Dt_DetailTmp.AcceptChanges()
        For i = 0 To TbImport.Rows.Count - 1
            Dt_DetailTmp.ImportRow(TbImport.Rows(i))
        Next
        Dt_DetailTmp.AcceptChanges()       
    End Sub
    Private Sub SetTxt()      
    End Sub
#End Region
    Private Sub V_FillDataToGridview(ByVal GRV As DevExpress.XtraGrid.Views.Grid.GridView, ByVal _M_lan As String, ByVal DvHeader As DataView, ByVal DvData As DataView)
        GRV.OptionsBehavior.Editable = False
        CyberFill.V_FillReports(GRV, _M_lan, DvHeader, DvData)
        GRV.GridControl.DataSource = DvData
    End Sub
End Class


