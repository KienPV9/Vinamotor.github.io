﻿Imports System.Data.SqlClient
Imports System.IO
Public Class BH1
#Region "Khai bao bien Property----------------------"
    Dim M_strFilter As String = "1=1"
    Dim M_Cp_Name As String
    Dim M_DrDmct As DataRow
    Dim osysvar As Collection
    Dim M_Para As String() = Me.Para
    Dim M_AppConn As SqlConnection
    Dim M_DsData, M_DsHead, M_DsLookUp As DataSet
    Dim filepath As String
    Dim Dt_Master1, Dt_Head1, Dt_Tab1 As DataTable
    Dim Dv_Master1, Dv_Head1 As DataView

#End Region
#Region "Khai bao bien Paramater----------------------"
    Dim M_Ma_THue, M_Mau_BC As String
#End Region
#Region "Khai bao bien Dll"
    Dim CyberInput As New Cyber.Input.Sys
    Dim CyberMe As New Cyber.From.Frmvoucher
    Dim CyberFrom As New Cyber.From.Sys

#End Region
#Region "Columns Edit"
    Dim EditMa_BP_I, EditMa_HS_I, editma_chucvu, editma_chucdanh, editis_nghi, editmA_KX_I, editSL_VP, editDiem_tru, EditMa_Mau, editDiem_con_lai, editSL_VP_QL, editDiem_chuan, editTham_nien As New Cyber.Fill.CyberColumnGridView
    Dim EditLoi_Nhuan, EditTien_nt, EditGia_Mua, editHO_TRO_HVN, editCK, editCK_GDBH, editKM_PK, editKM_PK_GDKD, EditTong_KM_BGD, EditTong_KM, EditLuong_TVBH, EditLOI_NHUAN_CL, EditMa_mau_Nt As New Cyber.Fill.CyberColumnGridView
    Dim editKM_PK_VNMT, editKM_PK_VNMT_GDKD, editKM_BH, editKm_BH_GDKD As New Cyber.Fill.CyberColumnGridView

#End Region
#Region "Khai bao bien Private"
    Dim M_Ct, M_Ph As String
    Dim DrReturn As DataRow
    Dim M_Count As Integer = 1
    Dim DtPost, DtMaGD As DataTable
#End Region
    Private Sub SVB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()

        If DrDmct.Table.Columns.Contains("NonVAT") Then ChkNonVAT.Visible = (DrDmct.Item("NonVAT").ToString.Trim = "1")
        If DrDmct.Table.Columns.Contains("CaptionNonVAT") Then If DrDmct.Item("CaptionNonVAT").ToString.Trim <> "" Then ChkNonVAT.Text = DrDmct.Item("CaptionNonVAT").ToString.Trim
        V_GetColumn()
        V_AddHandler()
        V_Databing()
        M_Mode = "X"
        M_Count = Dt_Master.Rows.Count
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_MainSystem()
        CmdNew.Select()
    End Sub
#Region "Load And Set And Default"
    Private Sub V_Load()
        V_Getdefault()
        '---------------------
        Dt_Detail = M_DsData.Tables(0)
        Dt_DetailTmp = Dt_Detail.Clone
        Dt_Master = M_DsData.Tables(1)
        '-------------------------------------
        Dv_Detail = New DataView(Dt_Detail)
        Dv_DetailTmp = New DataView(Dt_DetailTmp)
        Dv_Master = New DataView(Dt_Master)
        '-------------------------------------
        Detail.DataSource = Dv_DetailTmp
        Me.DetailGRV.GridControl = Me.Detail
        CyberFill.V_FillVoucher(DetailGRV, M_LAN, New DataView(M_DsHead.Tables(1)), Dv_DetailTmp, Me.DrDmct)
        V_SetProperty()
        CyberSupport.Translaste(Me, M_LAN, True)
        V_LoadNam()
        V_LoadThang()
        ' M_Stt_Rec = CyberFrom.V_ViewVoucher(AppConn, osysvar, M_LAN, M_Para, DrDmct, DsData, DsHead, Dslookup, Dv_Master, Dv_Detail, M_Stt_Rec, strFilter, CyberFill, CyberSmlib, CyberSupport, True, True)
    End Sub

    Private Sub V_LoadThang()
        Dim tbNam As DataTable
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_LoadNam", M_Ma_Dvcs & "#" & M_User_Name)
        tbNam = DsTmp.Tables(1).Copy
        CyberFill.V_FillComBoxValue(Me.cmbThang, tbNam, "Ma_thang", "Ten_thang", "")
        cmbThang.Text = Month(Now.Date)
    End Sub
    Private Sub V_LoadNam()
        Dim tbNam As DataTable
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_LoadNam", M_Ma_Dvcs & "#" & M_User_Name)
        tbNam = DsTmp.Tables(0).Copy
        CyberFill.V_FillComBoxValue(Me.cmbnam, tbNam, "Ma_nam", "Ten_nam", "")
        cmbnam.Text = Year(Now.Date)
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
        'M_Ma_THue = M_Para(M_VT_PARA + 3).Trim
        'M_Mau_BC = M_Para(M_VT_PARA + 4).Trim
        'M_Stt_Rec = M_Para(M_Para.Length - 1).Trim
        '---------------------------------------------------------------------------------------------'
        M_Ma_Post = CyberSupport.V_GetMaxPost(AppConn, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib)
        '---
        M_Ma_Nt = DrDmct.Item("Ma_Nt").ToString.Trim
        M_Dien_Giai = DrDmct.Item("Dien_Giai").ToString.Trim

        DtPost = CyberSmodb.OpenTableKey(AppConn, Nothing, "DmPost", "Ma_Post", "Ma_Ct =N'" + M_Ma_CT + "'", CyberSmlib)
        DtMaGD = CyberSmodb.OpenTableKey(AppConn, Nothing, "DmMaGd", "Ma_GD", "Ma_Ct =N'" + M_Ma_CT + "'", CyberSmlib)
        CyberFill.V_FillComBoxValue(Me.CbbMa_Post, DtPost, "Ma_Post", If(M_LAN = "V", "Ten_Post", "Ten_Post2"), M_Ma_Post)
        CyberFill.V_FillComBoxValue(Me.CbbMa_GD, DtMaGD, "Ma_GD", If(M_LAN = "V", "Ten_GD", "Ten_GD2"), M_Ma_GD)

        V_LoadDefault()
    End Sub
    Private Sub V_SetProperty()
        Me.Mode = M_Mode
        Me.Stt_Rec = M_Stt_Rec
        '---
        Dim FixCol As Integer = -1
        FixCol = DrDmct.Item("ColFrozen_master")

        If FixCol < DetailGRV.Columns.Count And FixCol > 0 Then
            For iCol = 0 To FixCol
                DetailGRV.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
            Next
        End If
        DetailGRV.OptionsNavigation.EnterMoveNextColumn = True
        Me.DetailGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Brown
    End Sub
    Private Sub V_GetColumn()
        EditMa_BP_I.GetColumn(DetailGRV, "Ma_BP_I")
        EditMa_HS_I.GetColumn(DetailGRV, "Ma_HS_I")
        editma_chucvu.GetColumn(DetailGRV, "Ma_chucvu")
        EditMa_Mau.GetColumn(DetailGRV, "Ma_Mau")
        editmA_KX_I.GetColumn(DetailGRV, "Ma_KX_i")

        EditTien_nt.GetColumn(DetailGRV, "Tien_NT")
        EditGia_Mua.GetColumn(DetailGRV, "Gia_Mua")
        EditLoi_Nhuan.GetColumn(DetailGRV, "Loi_Nhuan")

        editHO_TRO_HVN.GetColumn(DetailGRV, "Ho_Tro_HVN")


        editCK.GetColumn(DetailGRV, "CK")
        editKM_PK.GetColumn(DetailGRV, "KM_PK")
        editKM_PK_VNMT.GetColumn(DetailGRV, "KM_PK_VNMT")
        editKM_BH.GetColumn(DetailGRV, "KM_BH")

        editCK_GDBH.GetColumn(DetailGRV, "CK_GDBH")
        editKM_PK_GDKD.GetColumn(DetailGRV, "KM_PK_GDKD")
        editKM_PK_VNMT_GDKD.GetColumn(DetailGRV, "KM_PK_VNMT_GDKD")
        editKm_BH_GDKD.GetColumn(DetailGRV, "Km_BH_GDKD")
        EditTong_KM_BGD.GetColumn(DetailGRV, "Tong_KM_BGD")

        EditTong_KM.GetColumn(DetailGRV, "Tong_KM")
        EditLuong_TVBH.GetColumn(DetailGRV, "Luong_TVBH")
        EditLOI_NHUAN_CL.GetColumn(DetailGRV, "Loi_Nhuan_CL")
        EditMa_mau_Nt.GetColumn(DetailGRV, "Ma_mau_Nt")

    End Sub
    Private Sub V_SetFocus(ByVal _Loai As String)
        _Loai = _Loai.Trim.ToUpper
        'TxtTieu_De.Focus()
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
        AddHandler DetailGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        AddHandler DetailGRV.KeyDown, AddressOf MasterGRV_KeyDown
        '---
        'AddHandler CbbMa_GD.SelectedValueChanged, AddressOf L_Ma_GD
    End Sub
    Private Sub L_Ma_GD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
    End Sub
    Private Sub V_AddHandler_Master()
        AddHandler TxtMa_Quyen.Leave, AddressOf L_Ma_Quyen
        AddHandler TxtNgay_Ct.Leave, AddressOf V_Ngay_Ct
        AddHandler TxtNgay_LCt.Leave, AddressOf V_Ngay_LCt
        AddHandler TxtSo_Ct.Enter, AddressOf V_So_Ct
        'AddHandler ChkUntil_Rep.CheckedChanged, AddressOf V_Until_Rep
        'AddHandler TxtMa_BP_H.CyberValiting, AddressOf V_Ma_BP_H
        'AddHandler TxtMa_BP_H.CyberLeave, AddressOf L_Ma_BP_H
        'AddHandler CmdOK.Click, AddressOf V_loadKX

        'AddHandler Txtma_hs_h.CyberValiting, AddressOf V_Ma_hs_H
        'AddHandler Txtma_hs_h.CyberLeave, AddressOf L_Ma_hs_H
        'AddHandler TxtMa_BP_H.CyberValiting, AddressOf V_Ma_chucvu1
        'AddHandler TxtMa_BP_H.CyberLeave, AddressOf L_Ma_chucvu1

        'AddHandler cmdloai_xe.SelectedValueChanged, AddressOf V_LoaiXe
        '
        AddHandler BttTam_Dung.Click, AddressOf V_Tam_Dung
        '----------------------------------------------------------------------------------------------------------
        AddHandler CmdE_Mail_KH.Click, AddressOf V_E_MaiL_KH
    End Sub
    Private Sub V_E_MaiL_KH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If M_Mode = "M" Or M_Mode = "S" Then Return
        If M_Stt_Rec.Trim = "" Then Return
        Dim _LoaiMail As String = "1"
        '---_LoaiMail = 0/ Xin phe duyet
        CyberSupport.V_SendEmailVoucher(AppConn, osysvar, M_Para, M_LAN, _LoaiMail, M_Ma_CT, M_Stt_Rec, M_Ma_Dvcs, M_User_Name, True, True, False)
    End Sub
    Private Sub V_AddHandler_Detail()
        '---Add On
        If Not editSL_VP.Column Is Nothing Then AddHandler editSL_VP.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not editDiem_con_lai.Column Is Nothing Then AddHandler editDiem_con_lai.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not editDiem_tru.Column Is Nothing Then AddHandler editDiem_tru.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not editSL_VP_QL.Column Is Nothing Then AddHandler editSL_VP_QL.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not editDiem_chuan.Column Is Nothing Then AddHandler editDiem_chuan.EditColumn.Leave, AddressOf L_Tinh_Toan
        'If Not editTham_nien.Column Is Nothing Then AddHandler editTham_nien.EditColumn.Leave, AddressOf L_Tinh_Toan
        ' If Not EditNgay_LV.Column Is Nothing Then AddHandler EditNgay_LV.EditColumn.Leave, AddressOf L_Tinh_Toan

        'tính lợi nhuân gộp
        If Not EditTien_nt.Column Is Nothing Then AddHandler EditTien_nt.EditColumn.Leave, AddressOf L_Tinh_Toan_LNGOP
        If Not EditGia_Mua.Column Is Nothing Then AddHandler EditGia_Mua.EditColumn.Leave, AddressOf L_Tinh_Toan_LNGOP
        If Not EditLoi_Nhuan.Column Is Nothing Then AddHandler EditLoi_Nhuan.EditColumn.Leave, AddressOf L_Tinh_Toan_LNGOP
        If Not editHO_TRO_HVN.Column Is Nothing Then AddHandler editHO_TRO_HVN.EditColumn.Leave, AddressOf L_Tinh_Toan_LNGOP

        If Not editCK.Column Is Nothing Then AddHandler editCK.EditColumn.Leave, AddressOf L_Tinh_Toan_LNGOP
        If Not editCK_GDBH.Column Is Nothing Then AddHandler editCK_GDBH.EditColumn.Leave, AddressOf L_Tinh_Toan_LNGOP
        If Not editKM_PK.Column Is Nothing Then AddHandler editKM_PK.EditColumn.Leave, AddressOf L_Tinh_Toan_LNGOP
        If Not editKM_PK_GDKD.Column Is Nothing Then AddHandler editKM_PK_GDKD.EditColumn.Leave, AddressOf L_Tinh_Toan_LNGOP
        If Not EditTong_KM_BGD.Column Is Nothing Then AddHandler EditTong_KM_BGD.EditColumn.Leave, AddressOf L_Tinh_Toan_LNGOP
        If Not EditTong_KM.Column Is Nothing Then AddHandler EditTong_KM.EditColumn.Leave, AddressOf L_Tinh_Toan_LNGOP

        If Not editKM_PK_VNMT.Column Is Nothing Then AddHandler editKM_PK_VNMT.EditColumn.Leave, AddressOf L_Tinh_Toan_LNGOP
        If Not editKM_PK_VNMT_GDKD.Column Is Nothing Then AddHandler editKM_PK_VNMT_GDKD.EditColumn.Leave, AddressOf L_Tinh_Toan_LNGOP
        If Not editKM_BH.Column Is Nothing Then AddHandler editKM_BH.EditColumn.Leave, AddressOf L_Tinh_Toan_LNGOP
        If Not editKm_BH_GDKD.Column Is Nothing Then AddHandler editKm_BH_GDKD.EditColumn.Leave, AddressOf L_Tinh_Toan_LNGOP


        editmA_KX_I.V_ActiLookUpColumn(AddressOf V_Ma_Kx_i, AddressOf L_Ma_KX_i)
        EditMa_Mau.V_ActiLookUpColumn(AddressOf V_Ma_Mau, AddressOf L_Ma_Mau)
        EditMa_mau_Nt.V_ActiLookUpColumn(AddressOf V_Ma_Mau_NT, AddressOf L_Ma_Mau_NT)
        'editma_chucvu.V_ActiLookUpColumn(AddressOf V_Ma_chucvu, AddressOf L_Ma_chucvu)
        ' editma_chucdanh.V_ActiLookUpColumn(AddressOf V_Ma_chucdanh, AddressOf L_Ma_chucdanh)

        AddHandler DetailGRV.RowCellStyle, AddressOf DetailGRV_RowCellStyle
    End Sub
#Region "Tạm dừng"
    Private Sub V_Tam_Dung(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub

        Dim _Text As String
            Dim DsKetCa As DataSet
            Dim _ngay As Date = TxtNgay_Ct.Value
            Dim Is_Dung As Integer = 0
            Dim _ma_ttcp As String = CbbMa_TTCP_H.SelectedValue.ToString.Trim
            If ChkIs_Dung.Checked Then
                _Text = "Bạn muốn tiếp tục sử dụng CSBH này không ?"
                Is_Dung = 0
            Else
                _Text = "Bạn muốn ngừng sử dụng CSBH này không ?"
                Is_Dung = 1
            End If

            If MsgBox(_Text, MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "CYBER9.0") = MsgBoxResult.Yes Then
                DsKetCa = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_BH1_DUNG_CSBH", M_Stt_Rec.Trim & "#" & Is_Dung.ToString.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name & "#" & _ma_ttcp)
                If Not CyberSupport.V_MsgChk(DsKetCa.Tables(0), osysvar, M_LAN) Then
                    DsKetCa.Dispose()
                    Exit Sub
                End If
            End If
        '--- load lại
        V_Refresh(M_Stt_Rec)

    End Sub
    Private Sub V_Refresh(_Stt_rec As String)
        If _Stt_rec.Trim = "" Then Exit Sub
        Dim M_strFilter As String = "1###" & _Stt_rec & "#19000101#19000101#0#9#" & M_Ma_CT.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name
        Dim DsTempRefresh As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Filter" + M_Ma_CT.Trim, M_strFilter)

        For i As Integer = 0 To DsTempRefresh.Tables.Count - 1
            CyberSmodb.SetNotNullTable(DsTempRefresh.Tables(i))
        Next
        Dim _Update As Boolean = False
        If DsTempRefresh.Tables(1).Rows.Count >= 1 Then
            M_Stt_Rec = DsTempRefresh.Tables(1).Rows(0).Item("Stt_Rec").ToString.Trim
            For iRow As Integer = 0 To Dt_Master.Rows.Count - 1
                If Dt_Master.Rows(iRow).Item("Stt_Rec").ToString.Trim = M_Stt_Rec.Trim Then
                    CyberSmodb.V_UpdateRowtoRow(DsTempRefresh.Tables(1).Rows(0), Dt_Master, iRow)
                    _Update = True
                    Exit For
                End If
            Next
        End If
        If Not _Update Then
            DsTempRefresh.Dispose()
            Exit Sub
        End If

        CyberSupport.V_DeleteTableVoucher(Dt_Detail, M_Stt_Rec)

        For iRow As Integer = 0 To DsTempRefresh.Tables(0).Rows.Count - 1
            Dt_Detail.ImportRow(DsTempRefresh.Tables(0).Rows(iRow))
        Next
        V_Databing()
        DsTempRefresh.Dispose()
    End Sub
#End Region
#Region "Tính toán"
    Private Sub L_Tinh_Toan_LNGOP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DetailGRV.PostEditor()
        Dim drvCurren As DataRowView
        drvCurren = DetailGRV.GetFocusedRow
        CyberSupport.V_UpdateGRV(DetailGRV)
        V_Tinh_Toan(iRow)
    End Sub
#End Region
    Private Sub V_Tinh_Toan(ByVal iRow As Integer)
        If iRow < 0 Then Exit Sub
        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Loi_Nhuan") = Dv_DetailTmp.Item(iRow).Item("Tien_NT") - Dv_DetailTmp.Item(iRow).Item("Gia_Mua")
        Dv_DetailTmp.Item(iRow).EndEdit()
        '------------------------------------------------------------------------------------------------
        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Tong_KM") = Dv_DetailTmp.Item(iRow).Item("CK") + Dv_DetailTmp.Item(iRow).Item("KM_PK") _
                                                + Dv_DetailTmp.Item(iRow).Item("KM_PK_VNMT") + Dv_DetailTmp.Item(iRow).Item("KM_BH")
        '+ Dv_DetailTmp.Item(iRow).Item("KM_PK_VNMT") * 0.7 + Dv_DetailTmp.Item(iRow).Item("KM_PK_VNMT_GDKD") * 0.7 _
        '+ Dv_DetailTmp.Item(iRow).Item("KM_BH") * 0.7 + Dv_DetailTmp.Item(iRow).Item("KM_BH_GDKD") * 0.7
        '+ Dv_DetailTmp.Item(iRow).Item("CK_GDBH") + Dv_DetailTmp.Item(iRow).Item("KM_PK_GDBH") * 0.7 +
        Dv_DetailTmp.Item(iRow).EndEdit()
        '------------------------------------------------------------------------------------------------
        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Loi_Nhuan_CL") = Dv_DetailTmp.Item(iRow).Item("Loi_Nhuan") + Dv_DetailTmp.Item(iRow).Item("Ho_tro_HVN") _
                                                     - Dv_DetailTmp.Item(iRow).Item("Tong_KM")
        Dv_DetailTmp.Item(iRow).EndEdit()
        '------------------------------------------------------------------------------------------------

        CyberSupport.V_UpdateGRV(DetailGRV)
        UpdateList()
    End Sub
    Dim CyberColor As New Cyber.Color.Sys
    Private Sub DetailGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, DetailGRV, Dt_DetailTmp, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
    Private Sub VisibleColumnMa_NT()
        CyberFill.SetFoCusGRV(DetailGRV, M_Mode)
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
        '------------------------------------
        Dt_DetailTmp.Clear()
        Dt_DetailTmp.AcceptChanges()
        For i = 0 To Dt_Detail.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'").Length - 1
            Dt_DetailTmp.ImportRow(Dt_Detail.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(i))
        Next
        '------------------------------------

        VisibleColumnMa_NT()
        'V_VisibleUntil_Rep()

    End Sub
    Private Sub V_Setstatus()
        If (M_Mode = "M" Or M_Mode = "S") Then
            DetailGRV.OptionsBehavior.Editable = True
            If DrDmct.Item("M_Ngay_LCT").ToString.Trim = "1" Then TxtNgay_LCt.ReadOnly = False Else TxtNgay_LCt.ReadOnly = True 'Ngay chu tu nhap: vao hoac tu dong lay theo may chu
            If DrDmct.Item("M_Ngay_CT").ToString.Trim = "1" Then TxtNgay_Ct.ReadOnly = True Else TxtNgay_Ct.ReadOnly = False 'Ngay chu tu nhap: vao hoac tu dong lay theo may chu
            If DrDmct.Item("M_Au_So_CT").ToString.Trim = "1" Then TxtSo_Ct.ReadOnly = True Else TxtSo_Ct.ReadOnly = False 'Tu dong danh so chung tu
        Else
            DetailGRV.OptionsBehavior.Editable = False
        End If
        If M_Mode = "S" Then CbbMa_GD.Enabled = False
        If M_Mode = "M" Then CbbMa_GD.Enabled = True
        CyberFill.SetFoCusGRV(DetailGRV, M_Mode)
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
#Region "Valid --- Ma_BP_H"
    'Private Sub V_Ma_BP_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '    If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
    '    TxtMa_BP_H.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_BP", "DmBP", "1=1", "1=1")
    'End Sub
    'Private Sub L_Ma_BP_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '    If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
    '    If TxtMa_BP_H.Text = "" Then
    '        TxtLoai_xe.Text = ""
    '        Exit Sub
    '    End If
    '    DrReturn = TxtMa_BP_H.GetRowsSelectData(True)
    '    If Not DrReturn Is Nothing Then
    '        TxtMa_BP_H.Text = DrReturn.Item("Ma_BP")
    '        TxtLoai_xe.Text = DrReturn.Item("Ten_BP")
    '    Else
    '        TxtMa_BP_H.Text = ""
    '        TxtLoai_xe.Text = ""
    '    End If
    'End Sub
    'Private Sub V_Ma_hs_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '    If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
    '    Txtma_hs_h.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_hs", "Dmhs", "1=1", "1=1")
    'End Sub
    'Private Sub L_Ma_hs_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '    If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
    '    If Txtma_hs_h.Text = "" Then
    '        TxtTen_hs_h.Text = ""
    '        Exit Sub
    '    End If
    '    DrReturn = Txtma_hs_h.GetRowsSelectData(True)
    '    If Not DrReturn Is Nothing Then
    '        Txtma_hs_h.Text = DrReturn.Item("Ma_hs")
    '        TxtTen_hs_h.Text = DrReturn.Item("Ten_hs")
    '    Else
    '        Txtma_hs_h.Text = ""
    '        TxtTen_hs_h.Text = ""
    '    End If
    'End Sub
    'Private Sub V_Ma_chucvu1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '    If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
    '    TxtMa_BP_H.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_chucvu", "Dmchucvu", "1=1", "1=1")
    'End Sub
    'Private Sub L_Ma_chucvu1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '    If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
    '    If TxtMa_BP_H.Text = "" Then
    '        TxtTen_BP_H.Text = ""
    '        Exit Sub
    '    End If
    '    DrReturn = TxtMa_BP_H.GetRowsSelectData(True)
    '    If Not DrReturn Is Nothing Then
    '        TxtMa_BP_H.Text = DrReturn.Item("Ma_chucvu")
    '        TxtTen_BP_H.Text = DrReturn.Item("Ten_chucvu")
    '    Else
    '        TxtMa_BP_H.Text = ""
    '        TxtTen_BP_H.Text = ""
    '    End If
    'End Sub
#End Region
#Region "Valid - Detail"


#Region "Valid - Detail - Core"
    Private Sub UpdateList()

        'For iRow As Integer = 0 To Dv_DetailTmp.Count - 1
        '    Dv_DetailTmp.Item(iRow).BeginEdit()
        '    Dv_DetailTmp.Item(iRow).Item("Tham_nien") = DateDiff("m", Dv_DetailTmp.Item(iRow).Item("Ngay_LV"), TxtNgay_Ct.Value)
        '    Dv_DetailTmp.Item(iRow).EndEdit()

        'Next
    End Sub
    Private Sub L_Tinh_Toan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DetailGRV.PostEditor()
        Dim drvCurren As DataRowView
        drvCurren = DetailGRV.GetFocusedRow
        CyberSupport.V_UpdateGRV(DetailGRV)

    End Sub
#End Region
#Region "Valid - Detail - Add On"


    Private Sub V_Ma_kx_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_kx", "DMkx", " 1=1 AND Is_KD = N'1'", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub

    Private Sub L_Ma_kx_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = Nothing
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        Dim iRow As Integer = -1

        If DrReturn Is Nothing Then
            Exit Sub
        End If
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("ma_kx_i") = DrReturn("ma_kx")
        Dv_DetailTmp.Item(iRow).Item("ten_Kx_i") = DrReturn("ten_Kx")
        Dv_DetailTmp.Item(iRow).Item("Phien_ban") = DrReturn("Phien_ban")
        V_GetGiaXe(iRow)
        Dv_DetailTmp.Item(iRow).EndEdit()
        Dv_DetailTmp.Table.AcceptChanges()
    End Sub
    Private Sub V_GetGiaXe(iRow)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If iRow < 0 Then Exit Sub

        Dim Dt As Date = TxtNgay_HL1.Value
        Dim _Ma_Kx As String = If(Dt_DetailTmp.Columns.Contains("MA_KX_I"), Dv_DetailTmp.Item(iRow).Item("MA_KX_I").ToString.Trim, "")
        Dim _Ma_Mau As String = If(Dt_DetailTmp.Columns.Contains("Ma_Mau"), Dv_DetailTmp.Item(iRow).Item("Ma_Mau").ToString.Trim, "")


        Dim DsGia_Ban As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetGiaXe", _Ma_Kx & "#" & _Ma_Mau & "#" & M_Stt_Rec & "#" &
               M_Ma_CT & "#" & M_Mode & "#" & Dt.ToString("yyyyMMdd") & "#" & M_Ma_Dvcs & "#" & M_User_Name)

        If DsGia_Ban.Tables(0).Rows.Count <= 0 Then Exit Sub

        Dt_DetailTmp.Rows(iRow).BeginEdit()
        Dt_DetailTmp.Rows(iRow).Item("NIEM_YET") = DsGia_Ban.Tables(0).Rows(0).Item("NIEM_YET")
        Dt_DetailTmp.Rows(iRow).Item("TIEN_NT") = DsGia_Ban.Tables(0).Rows(0).Item("TIEN_NT")
        Dt_DetailTmp.Rows(iRow).Item("GIA_MUA") = DsGia_Ban.Tables(0).Rows(0).Item("GIA_MUA")
        Dt_DetailTmp.Rows(iRow).Item("GIA_MUA") = DsGia_Ban.Tables(0).Rows(0).Item("GIA_MUA")
        Dt_DetailTmp.Rows(iRow).EndEdit()
    End Sub
    Private Sub V_Ma_Mau(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Ma_Kx As String = ""
        Dim iRow As Integer = -1
        Dim _FilterClient As String = "1=1"
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow >= 0 Then _Ma_Kx = Dv_DetailTmp.Item(iRow).Item("Ma_Kx_i").ToString.Trim
        If Not _Ma_Kx = "" Then _FilterClient = " Ma_Kx = '" + _Ma_Kx + "'"
        CyberSupport.V_Lookup("Ma_Mau", "DmMauKx", "1=1", _FilterClient, M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Mau(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Ma_Mau") = ""
            If Dv_DetailTmp.Table.Columns.Contains("Ten_Mau") Then Dv_DetailTmp.Item(iRow).Item("Ten_Mau") = ""
            Dv_DetailTmp.Item(iRow).EndEdit()
            V_GetGiaXe(iRow)
            Exit Sub
        Else
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Ma_Mau") = DrReturn("Ma_Mau").ToString.Trim
            If Dv_DetailTmp.Table.Columns.Contains("Ten_Mau") Then
                If DrReturn.Table.Columns.Contains("Ten_Mau") Then
                    Dv_DetailTmp.Item(iRow).Item("Ten_Mau") = DrReturn("Ten_Mau").ToString.Trim
                Else
                    Dv_DetailTmp.Item(iRow).Item("Ten_Mau") = CyberSmodb.SQLGetvalue(AppConn, "Ten_Mau", "DmMauXe", "(Ma_Mau = N'" + DrReturn("Ma_Mau").ToString.Trim + "')", CyberSmlib)
                End If
            End If
            Dv_DetailTmp.Item(iRow).EndEdit()
        End If
        V_GetGiaXe(iRow)
        Dv_DetailTmp.Table.AcceptChanges()
        DetailGRV.UpdateCurrentRow()
    End Sub
    Private Sub V_Ma_Mau_NT(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Ma_Kx As String = ""
        Dim iRow As Integer = -1
        Dim _FilterClient As String = "1=1"
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow >= 0 Then _Ma_Kx = Dv_DetailTmp.Item(iRow).Item("Ma_Kx_i").ToString.Trim
        If Not _Ma_Kx = "" Then _FilterClient = " Ma_Kx = '" + _Ma_Kx + "'"
        CyberSupport.V_Lookup("Ma_mau_Nt", "dmmauNtkx", "1=1", _FilterClient, M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Mau_NT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Ma_mau_Nt") = ""
            If Dv_DetailTmp.Table.Columns.Contains("Ten_Mau_nt") Then Dv_DetailTmp.Item(iRow).Item("Ten_Mau_nt") = ""
            Dv_DetailTmp.Item(iRow).EndEdit()
            Exit Sub
        Else
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Ma_Mau_nt") = DrReturn("Ma_Mau_nt").ToString.Trim
            If Dv_DetailTmp.Table.Columns.Contains("Ten_Mau_nt") Then
                If DrReturn.Table.Columns.Contains("Ten_Mau") Then
                    Dv_DetailTmp.Item(iRow).Item("Ten_Mau_nt") = DrReturn("Ten_Mau").ToString.Trim
                Else
                    Dv_DetailTmp.Item(iRow).Item("Ten_Mau_nt") = CyberSmodb.SQLGetvalue(AppConn, "Ten_Mau", "DmMauXeNt", "(Ma_mau_Nt = N'" + DrReturn("Ma_mau_nt").ToString.Trim + "')", CyberSmlib)
                End If
            End If
            Dv_DetailTmp.Item(iRow).EndEdit()
        End If

        Dv_DetailTmp.Table.AcceptChanges()
        DetailGRV.UpdateCurrentRow()
    End Sub
#End Region
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
    Private Sub V_Until_Rep(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        'V_VisibleUntil_Rep()
    End Sub
    'Private Sub V_loadKX(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GETKX", M_Stt_Rec & "#" & M_Ma_CT & "#" & cmdloai_xe.SelectedValue & "#" & M_Mode & "#" & M_Ma_Dvcs & "#" & M_User_Name)
    '        For i As Integer = 0 To DsTmp.Tables.Count - 1
    '            CyberSmodb.SetNotNullTable(DsTmp.Tables(i))
    '        Next
    '        Dt_DetailTmp.Clear()
    '    CyberSmodb.SQLTbToTb(DsTmp.Tables(0), Dt_DetailTmp)

    'End Sub
    'Private Sub V_LoaiXe(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Dt_DetailTmp.Clear()
    'End Sub

#End Region
#Region "Mainform"
    Private Sub V_MainSystem()
        Dim mnItemsMail = New ContextMenu

        Dim mnItemsF4 As New MenuItem(If(M_LAN = "V", "Thêm dòng", "New row"), AddressOf V_ShortAddItem, Keys.F4)
        Dim mnItemsF8 As New MenuItem(If(M_LAN = "V", "Xóa dòng", "Delete row"), AddressOf V_ShortDeleteItem, Keys.F8)

        Dim mnItemsSave As New MenuItem(If(M_LAN = "V", "Lưu chứng từ", "Save"), AddressOf V_ShortSAVE, Keys.Control + Keys.Enter)
        Dim mnItemsPrint As New MenuItem(If(M_LAN = "V", "In chứng từ", "Print"), AddressOf V_ShortPrint, Keys.Control + Keys.P)

        mnItemsMail.MenuItems.Add(mnItemsF4)
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
    Private Sub V_ShortAddItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRV.FocusedRowHandle
        V_AddItem(iRow)
    End Sub
    Private Sub V_ShortDeleteItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRV.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(osysvar, M_LAN, M_Ma_CT, iRow, Dv_DetailTmp, AppConn, DetailGRV) Then Exit Sub
        Dv_DetailTmp.Delete(iRow)
        Dv_DetailTmp.Table.AcceptChanges()

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
        DetailGRV.PostEditor()

        Dv_DetailTmp.Table.AcceptChanges()
        If M_Mode.Trim = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        If M_Mode.Trim = "M" Then TxtUser_id.Text = M_User_ID
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        Dim _Ngay_LCt As Date = TxtNgay_Ct.Value
        '----------------------------------------------------------------------------------------------------------------------
        V_GetDateVoucher(M_Mode, _Ngay_Ct, _Ngay_LCt)
        '----------------------------------------------------------------------------------------------------------------------
        If Not ChkRightsVoucher("L") Then Exit Sub
        '----------------------------------------------------------------------------------------------------------------------
        V_GetNoVoucherAuto() ' Tao So Chung tu tu dong
        '----------------------------------------------------------------------------------------------------------------------
        If Not ChkVsave() Then Exit Sub 'Kiem tra va Update du lieu chuong tri
        '----------------------------------------------------------------------------------------------------------------------
        CyberInput.V_Save_Default_TTCP(Dt_DetailTmp, M_Is_Visible_TTCP, CbbMa_TTCP_H, M_Ma_CT, CyberSmodb)
        '----------------------------------------------------------------------------------------------------------------------
        If Not CyberSupport.V_ChkExistNovoucher(AppConn, osysvar, M_LAN, DrDmct, M_Mode, M_Stt_Rec, M_Ma_CT, TxtSo_Ct.Text.Trim, _Ngay_Ct, _Ngay_LCt, M_Ma_Dvcs, M_User_Name, CyberSmlib) Then Exit Sub '---Kiem tra trung so chung tu
        '----------------------------------------------------------------------------------------------------------------------
        Dim DrMasterOld As DataRow
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
            DrMasterOld = CyberSmodb.V_CopyDataRow(drMaster)

            CyberSmodb.AddValueToRow(drMaster, Me)
            drMaster.BeginEdit()
        End If
        drMaster.Item("Stt_Rec") = M_Stt_Rec.Trim
        drMaster.Item("Ma_Ct") = M_Ma_CT.Trim
        drMaster.Item("So_Ct") = CyberSupport.V_soct(TxtSo_Ct.Text.Trim)
        '---Save Post
        CyberSupport.V_SavePost(AppConn, drMaster, CbbMa_Post.SelectedValue, M_Ma_CT, M_User_Name, M_User_Name, CyberSmlib)
        '---------------------------------------------------
        Dim DsSave As DataSet
        If Not CyberSmodb.V_SysCheckSaveVoucher(AppConn, osysvar, {Dt_DetailTmp, CyberSmodb.V_ConvertDrToTb(drMaster)}, {M_Ct, M_Ph}, M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, CbbMa_GD.SelectedValue, M_Ma_CT, M_Stt_Rec, M_LAN, TxtMa_Dvcs.Text, M_User_Name, CyberSmlib, CyberSupport, DsSave) Then
            If M_Mode = "S" And Not DrMasterOld Is Nothing Then CyberSmodb.V_UpdateRowtoRow(DrMasterOld, Dt_Master, CrrRow)
            Return
        End If
        '---------------------------------------------------
        '---Update Head
        If DsSave.Tables.Count >= 2 Then
            If DsSave.Tables(1).Rows.Count > 0 Then
                CyberSmodb.SetValueTObj_1(Me, DsSave.Tables(1).Rows(0)) '----Chi set Những trường có dữ liệu
                CyberSmodb.AddValueToRow(drMaster, Me)
                drMaster.Item("Stt_Rec") = M_Stt_Rec.Trim
                drMaster.Item("Ma_Ct") = M_Ma_CT.Trim
                drMaster.Item("So_Ct") = CyberSupport.V_soct(TxtSo_Ct.Text.Trim)
            End If
        End If
        If M_Mode.Trim = "M" Then Dt_Master.Rows.Add(drMaster) Else Dt_Master.Rows(CrrRow).EndEdit()
        Dt_Master.AcceptChanges()
        '---Update Chi tiet
        If DsSave.Tables.Count >= 3 Then
            For iRow As Integer = 0 To DsSave.Tables(2).Rows.Count - 1
                Try
                    CyberSmodb.V_UpdateRowtoRow(DsSave.Tables(2).Rows(iRow), Dt_DetailTmp, iRow)
                Catch ex As Exception
                End Try
            Next
        End If
        '---Xoa trong Detail
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_Detail, "Stt_Rec = '" + M_Stt_Rec + "'")
        Dt_Detail.Load(Dt_DetailTmp.CreateDataReader)
        '----------------------------------------------------------------------------------------------------------------------
        '--- Save Dien_Giai

        'Public Function SQLExcuteStoreProcedureFile(ByVal Appconn As SqlConnection, ByVal Cp_Name As String, ByVal SqlParameter As Dictionary(Of String, Object)) As Object
        '    Return cyberAppConnect.SQLExcuteStoreProcedureFile(Appconn, Cp_Name, SqlParameter)
        'End Function
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
            If Dt_DetailTmp.Rows(iRow).Item("Ma_KX_i").ToString.Trim = "" Then
                Dt_DetailTmp.Rows(iRow).Delete()
                Dt_DetailTmp.AcceptChanges()
            End If
        Next
        '---------------------------------------------------------------------------------
        For iRow = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_DetailTmp.Rows(iRow).BeginEdit()
            'Dt_DetailTmp.Rows(iRow).Item("Ma_Dvcs") = M_Ma_Dvcs
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
        '-----

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
        Return CyberSmodb.V_Add2Database(AppConn, osysvar, {Dt_DetailTmp, CyberSmodb.V_ConvertDrToTb(drMaster)}, {M_Ct, M_Ph}, M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, M_Ma_CT, M_Stt_Rec, M_LAN, TxtMa_Dvcs.Text, M_User_Name, CyberSmlib, CyberSupport)
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

        '--------------
        V_New()
        '-----------------------
        '-----------------
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_SetFocus("M")
        CyberSmodb.SetValueFromCombox(CbbMa_TTCP_H, M_Ma_TTCP_H)

        'V_GetNgamDinh()
        '-----------------
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        '       



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
        Dim iCoumnVisible As Integer = DetailGRV.VisibleColumns.Count - 1
        Dim iRowVisible As Integer = DetailGRV.RowCount - 1
        Dim iRowRowFocus As Integer = DetailGRV.FocusedRowHandle
        Dim iColumnRowFocus As Integer = DetailGRV.VisibleColumns.IndexOf(DetailGRV.FocusedColumn)
        Dim iRowOld As Integer = DetailGRV.GetFocusedDataSourceRowIndex
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
        iRow = Dv_DetailTmp.Count - 1
        CyberFill.V_ForcusCell(DetailGRV, iRow, 0)

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
        TbImport = CyberExport.V_ImportDataToGridview(AppConn, osysvar, M_Para, DetailGRV, Dt_DetailTmp, M_LAN)
        If TbImport Is Nothing Then Exit Sub
        '==================== Xu ly du lieu được Import vào
        Dt_DetailTmp.Clear()
        Dt_DetailTmp.AcceptChanges()
        For i = 0 To TbImport.Rows.Count - 1
            Dt_DetailTmp.ImportRow(TbImport.Rows(i))
        Next
        Dt_DetailTmp.AcceptChanges()
    End Sub
    Private Sub SetTxt()
        'txtTen_HS.Enabled = False
        'TxtMa_HS.Enabled = False
        'ChkIs_Dung.Enabled = False
    End Sub
#End Region
#Region "TTCP Default and New/Save _TTCP"
    Dim M_Is_Visible_TTCP As Boolean = False
    Dim DtTTCP As DataTable
    Dim M_Ma_TTCP_H As String = ""
    Dim M_Ten_TTCP_H As String = ""
    Dim M_Ten_TTCP2_H As String = ""

    Dim M_Ma_TTLN_H As String = ""
    Dim M_Ten_TTLN_H As String = ""
    Dim M_Ten_TTLN2_H As String = ""


    Dim M_Ma_HS_H As String = ""
    Dim M_Ten_HS_H As String = ""
    Dim M_Ten_HS2_H As String = ""

    Dim M_Ma_BP_H As String = ""
    Dim M_Ten_BP_H As String = ""
    Dim M_Ten_BP2_H As String = ""
    Private Sub V_LoadDefault()
        If DrDmct.Table.Columns.Contains("Is_Visible_TTCP") Then M_Is_Visible_TTCP = (DrDmct.Item("Is_Visible_TTCP").ToString.Trim = "1")
        LabMa_TTCP_H.Visible = M_Is_Visible_TTCP
        CbbMa_TTCP_H.Visible = M_Is_Visible_TTCP

        If M_Is_Visible_TTCP And DrDmct.Table.Columns.Contains("CaptionTTCP") Then If DrDmct.Item("CaptionTTCP").ToString.Trim <> "" Then LabMa_TTCP_H.Text = DrDmct.Item("CaptionTTCP").ToString.Trim

        If M_Is_Visible_TTCP Then
            Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetDefaultVoucher", M_Ma_CT.Trim & "#" & M_Ma_Dvcs.ToString().Trim() & "#" & M_User_Name.ToString().Trim())

            If DsTmp.Tables.Count = 0 Then
                M_Is_Visible_TTCP = False
                DsTmp.Dispose()
                Return
            End If

            If DsTmp.Tables(0).Columns.Contains("Ma_TTCP_H") Then M_Ma_TTCP_H = DsTmp.Tables(0).Rows(0).Item("Ma_TTCP_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_TTCP_H") Then M_Ten_TTCP_H = DsTmp.Tables(0).Rows(0).Item("Ten_TTCP_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_TTCP2_H") Then M_Ten_TTCP2_H = DsTmp.Tables(0).Rows(0).Item("Ten_TTCP2_H").ToString.Trim

            If DsTmp.Tables(0).Columns.Contains("Ma_TTLN_H") Then M_Ma_TTCP_H = DsTmp.Tables(0).Rows(0).Item("Ma_TTLN_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_TTLN_H") Then M_Ten_TTLN_H = DsTmp.Tables(0).Rows(0).Item("Ten_TTLN_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_TTLN2_H") Then M_Ten_TTLN2_H = DsTmp.Tables(0).Rows(0).Item("Ten_TTLN2_H").ToString.Trim

            If DsTmp.Tables(0).Columns.Contains("Ma_HS_H") Then M_Ma_TTCP_H = DsTmp.Tables(0).Rows(0).Item("Ma_HS_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_HS_H") Then M_Ten_HS_H = DsTmp.Tables(0).Rows(0).Item("Ten_HS_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_HS2_H") Then M_Ten_HS2_H = DsTmp.Tables(0).Rows(0).Item("Ten_HS2_H").ToString.Trim

            If DsTmp.Tables(0).Columns.Contains("Ma_BP_H") Then M_Ma_TTCP_H = DsTmp.Tables(0).Rows(0).Item("Ma_BP_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_BP_H") Then M_Ten_BP_H = DsTmp.Tables(0).Rows(0).Item("Ten_BP_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_BP2_H") Then M_Ten_BP2_H = DsTmp.Tables(0).Rows(0).Item("Ten_BP2_H").ToString.Trim

            If DsTmp.Tables.Count > 1 Then
                DtTTCP = DsTmp.Tables(1).Copy
                CyberFill.V_FillComBoxValue(Me.CbbMa_TTCP_H, DtTTCP, "Ma_TTCP", If(M_LAN = "V", "Ten_TTCP", "Ten_TTCP2"), M_Ma_TTCP_H)
            Else
                M_Is_Visible_TTCP = False
            End If

            DsTmp.Dispose()
        End If
    End Sub
#End Region
End Class


