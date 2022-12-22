Imports System.Data.SqlClient
Public Class BPK
#Region "Khai bao bien Property----------------------"
    Dim M_strFilter As String = "1=1"
    Dim M_DrDmct As DataRow
    Dim osysvar As Collection
    Dim M_Para As String() = Me.Para
    Dim M_AppConn As SqlConnection
    Dim M_DsData, M_DsHead, M_DsLookUp As DataSet

#End Region
#Region "Khai bao bien Dll"
    Dim CyberMe As New Cyber.From.Frmvoucher
    Dim CyberFrom As New Cyber.From.Sys
    Dim CyberInput As New Cyber.Input.Sys

#End Region
#Region "Columns Edit"
    Dim EditMa_Pk, EditTen_PK, EditDVT, EditSo_luong, EditMa_TT, Edit, EditDien_Giaii, EditGia_nt, EditTien_nt, EditTien_nt_TT As New Cyber.Fill.CyberColumnGridView 'DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
#End Region
#Region "Khai bao bien Private"
    Dim M_Ct, M_Ph As String
    Dim DrReturn As DataRow
    Dim M_Count As Integer = 1
    Dim DtPost, DtMaGD As DataTable
    Dim _Para_Ma_HD_H As String = ""
#End Region
    Private Sub LSN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        V_LoadNew(sender, e)
    End Sub
#Region "Load And Set And Default"
    Private Sub V_LoadNew(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If _Para_Ma_HD_H.Trim = "" Then Exit Sub
        Dim nCount As Integer = 0
        Dim irow As Integer = -1
        Dim dtMasterRf, dtDetailRf, dtDetailBhRf, dtDetailKhacRf As DataTable

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetDefaultPPK", _Para_Ma_HD_H.ToString.Trim & "#" & M_Ma_CT & "#" & M_Mode & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If DsTmp.Tables(1).Rows.Count = 1 Then

            M_Stt_Rec = DsTmp.Tables(1).Rows(0).Item("Stt_Rec")
            dtMasterRf = DsTmp.Tables(1)
            dtDetailRf = DsTmp.Tables(0)
            dtDetailBhRf = DsTmp.Tables(2)
            dtDetailKhacRf = DsTmp.Tables(3)
            '-------------------------------------
            nCount = Dt_Master.Rows.Count
            For irow = nCount - 1 To 0 Step -1
                If Dt_Master.Rows(irow).Item("Stt_Rec").ToString.Trim = M_Stt_Rec Then
                    Dt_Master.Rows(irow).Delete()
                    Dt_Master.AcceptChanges()
                End If
            Next
            nCount = Dt_Detail.Rows.Count
            For irow = nCount - 1 To 0 Step -1
                If Dt_Detail.Rows(irow).Item("Stt_Rec").ToString.Trim = M_Stt_Rec Then
                    Dt_Detail.Rows(irow).Delete()
                    Dt_Detail.AcceptChanges()
                End If
            Next
            '-------------------------------------
            For irow = 0 To dtMasterRf.Rows.Count - 1
                Dt_Master.ImportRow(dtMasterRf.Rows(irow))
            Next
            For irow = 0 To dtDetailRf.Rows.Count - 1
                Dt_Detail.ImportRow(dtDetailRf.Rows(irow))
            Next
            V_Databing()
            V_Edit(sender, e)
        Else
            V_New(sender, e)
            'V_GetMaBP()
            If Not M_Mode = "M" Then Exit Sub
            If _Para_Ma_HD_H.Trim <> "" Then
                TxtMa_HD.Text = _Para_Ma_HD_H
                L_Ma_HD_LoadNew()
                Return
            End If
        End If
    End Sub
    Private Sub V_Load()

        V_Getdefault()
        V_LoadDefault()

        TxtTen_HS.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_hs", "Dmhs", "( Ma_hs = N'" + TxtMa_HS.Text.Trim + "')", CyberSmlib)

        Dt_Detail = M_DsData.Tables(0)
        Dt_DetailTmp = Dt_Detail.Clone
        Dt_Master = M_DsData.Tables(1)

        Dv_Detail = New DataView(Dt_Detail)
        Dv_DetailTmp = New DataView(Dt_DetailTmp)
        Dv_Master = New DataView(Dt_Master)

        Detail.DataSource = Dv_DetailTmp
        Me.DetailGRV.GridControl = Me.Detail
        CyberFill.V_FillVoucher(DetailGRV, M_LAN, New DataView(M_DsHead.Tables(1)), Dv_DetailTmp, Me.DrDmct)
        V_SetProperty()
        CyberSupport.Translaste(Me, M_LAN, True)
        'M_Stt_Rec = CyberFrom.V_ViewVoucher(AppConn, osysvar, M_LAN, M_Para, DrDmct, DsData, DsHead, DsLookup, Dv_Master, Dv_Detail, M_Stt_Rec, strFilter, CyberFill, CyberSmlib, CyberSupport, True, True)
        'TxtTy_Gia.InputMask = IIf(DrDmct.Item("M_IP_MK_TG").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TG").ToString.Trim, TxtTy_Gia.InputMask)

        TxtT_SL.InputMask = IIf(DrDmct.Item("M_IP_MK_SL").ToString.Trim <> "", DrDmct.Item("M_IP_MK_SL").ToString.Trim, TxtT_SL.InputMask)
        TxtT_Tien_nt.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim, TxtT_Tien_nt.InputMask)
        TxtT_Tien_nt_TT.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_Tien_nt_TT.InputMask)
        TxtTong_N.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim, TxtTong_N.InputMask)
        TxtTong_C.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim, TxtTong_C.InputMask)
        TxtTien_TT.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim, TxtTien_TT.InputMask)
        TxtTien_Thue.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim, TxtTien_Thue.InputMask)
        TxtTien_ST.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim, TxtTien_ST.InputMask)
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

        Dim M_Ve_PARA As Integer = CType(M_Para(0).Trim, Integer)
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
        M_Ma_GD = M_Para(M_Ve_PARA + 1).Trim
        M_Ma_CT = M_Para(M_Ve_PARA + 2).Trim
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

        CyberFill.V_FillComBoxDefaul(Me.CbbMa_GD, DtMaGD, "Ma_GD", If(M_LAN = "V", "Ten_GD", "Ten_GD2"), M_Ma_GD)
        '--------------------------------------------------------------------------------------------
        _Para_Ma_HD_H = ""
        Try
            _Para_Ma_HD_H = M_Para(M_Ve_PARA + 3).Trim
        Catch ex As Exception

        End Try
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
        EditMa_Pk.GetColumn(DetailGRV, "Ma_PK")
        EditTen_PK.GetColumn(DetailGRV, "Ten_PK")
        EditDVT.GetColumn(DetailGRV, "DVT")
        EditSo_luong.GetColumn(DetailGRV, "So_luong")
        EditMa_TT.GetColumn(DetailGRV, "Ma_TT")
        EditGia_nt.GetColumn(DetailGRV, "Gia_nt")
        EditTien_nt.GetColumn(DetailGRV, "Tien_nt")
        EditDien_Giaii.GetColumn(DetailGRV, "DIEN_GIAII")
    End Sub
    Private Sub V_SetFocus(ByVal _Loai As String)
        _Loai = _Loai.Trim.ToUpper
        Select Case _Loai
            Case "M"
                If DrDmct.Item("M_Ngay_CT").ToString.Trim <> "1" Then TxtNgay_CT.Focus() Else TxtMa_HS.Focus()
            Case "S"
                If DrDmct.Item("M_Ngay_CT").ToString.Trim <> "1" Then TxtNgay_CT.Focus() Else TxtMa_HS.Focus()
            Case "L"
                CmdPrint.Select()
        End Select
    End Sub
    Private Sub GetRound()
        M_R_TIEN = DrDmct.Item("M_R_Tien")
        M_R_TIEN_NT = DrDmct.Item("M_R_Tien_NT")
        M_R_GIA = DrDmct.Item("M_R_GIA")
        M_R_GIA_NT = DrDmct.Item("M_R_GIA_NT")
        M_R_GIA_NT = M_R_GIA
        M_R_TIEN_NT = M_R_TIEN
        'End If
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
        AddHandler CbbMa_GD.SelectedValueChanged, AddressOf L_Ma_GD
    End Sub
    Private Sub L_Ma_GD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        'VisibleColumnMa_GD()
    End Sub
    Private Sub V_AddHandler_Master()

        AddHandler TxtNgay_CT.Leave, AddressOf V_Ngay_Ct
        AddHandler txtSo_ct.Enter, AddressOf V_So_Ct

        AddHandler TxtMa_HS.CyberValiting, AddressOf V_Ma_hs
        AddHandler TxtMa_HS.CyberLeave, AddressOf L_Ma_HS

        AddHandler TxtMa_HD.CyberValiting, AddressOf V_Ma_HD
        AddHandler TxtMa_HD.CyberLeave, AddressOf L_Ma_HD

        '--LhKh
        AddHandler TxtMa_LHKH.CyberValiting, AddressOf V_Ma_LhKh
        AddHandler TxtMa_LHKH.CyberLeave, AddressOf L_Ma_LhKh

        AddHandler TxtMa_Xe.Leave, AddressOf V_Ma_Xe
        AddHandler LabMa_Xe.Click, AddressOf V_Ma_Xe_Click

        '--LhKx
        AddHandler TxtMa_Kx.CyberValiting, AddressOf V_Ma_Kx
        AddHandler TxtMa_Kx.CyberLeave, AddressOf L_Ma_Kx
        '--LhMau
        AddHandler TxtMa_Mau.CyberValiting, AddressOf V_Ma_Mau
        AddHandler TxtMa_Mau.CyberLeave, AddressOf L_Ma_Mau
        AddHandler TxtGio_Gx.Leave, AddressOf V_Gio_Gx
    End Sub
    Private Sub V_AddHandler_Detail()
        If Not EditDien_Giaii.Column Is Nothing Then AddHandler EditDien_Giaii.EditColumn.Enter, AddressOf E_Dien_Giaii
        '--Vat tu-kho
        EditMa_Pk.V_ActiLookUpColumn(AddressOf V_Ma_pk, AddressOf L_Ma_pk)
        If Not EditGia_nt.Column Is Nothing Then AddHandler EditGia_nt.EditColumn.Leave, AddressOf V_Tinh_Toan
        If Not EditTien_nt.Column Is Nothing Then AddHandler EditTien_nt.EditColumn.Leave, AddressOf V_Tinh_Toan
        If Not EditSo_luong.Column Is Nothing Then AddHandler EditSo_luong.EditColumn.Leave, AddressOf V_Tinh_Toan
        EditMa_TT.V_ActiLookUpColumn(AddressOf V_Ma_TT, AddressOf L_Ma_TT)
        '-------------------------------------
    End Sub
    'Private Sub VisibleColumnMa_NT()

    '    If TxtMa_NT.Text.Trim = "" Or TxtMa_NT.Text.Trim.ToUpper = osysvar("M_Ma_NT0").ToString.Trim.ToUpper Then
    '        EditTien.Visible = False
    '        EditGia.Visible = False
    '        TxtT_Tien.Visible = False
    '    Else
    '        EditTien.Visible = True
    '        EditGia.Visible = True
    '        TxtT_Tien.Visible = True
    '    End If
    '    CyberFill.SetFoCusGRV(DetailGRV, M_Mode)
    'End Sub

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
            'TxtMa_NT.Text = M_Ma_Nt
            TxtNgay_CT.Value = Now.Date
            Dim _DT As Date = TxtNgay_CT.Value
            'TxtTy_Gia.Double = CyberSupport.GetRate(_DT, TxtMa_NT.Text, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
            CbbMa_GD.SelectedValue = M_Ma_GD
            CbbMa_Post.SelectedValue = M_Ma_Post
        End If
        Dt_DetailTmp.Clear()
        Dt_DetailTmp.AcceptChanges()

        For i = 0 To Dt_Detail.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'").Length - 1
            Dt_DetailTmp.ImportRow(Dt_Detail.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(i))
        Next
        'If TxtMa_NT.Text.Trim = "" Then TxtMa_NT.Text = osysvar("M_Ma_NT0").ToString.Trim.ToUpper
        UpdateList()
        'VisibleColumnMa_NT()

    End Sub
    Private Sub V_Setstatus()
        If (M_Mode = "M" Or M_Mode = "S") Then
            DetailGRV.OptionsBehavior.Editable = True
            If DrDmct.Item("M_Ngay_LCT").ToString.Trim = "1" Then TxtNgay_CT.ReadOnly = False Else TxtNgay_CT.ReadOnly = True 'Ngay chu tu nhap: vao hoac tu dong lay theo may chu
            If DrDmct.Item("M_Ngay_CT").ToString.Trim = "1" Then TxtNgay_CT.ReadOnly = True Else TxtNgay_CT.ReadOnly = False 'Ngay chu tu nhap: vao hoac tu dong lay theo may chu
            If DrDmct.Item("M_Au_So_CT").ToString.Trim = "1" Then txtSo_ct.ReadOnly = True Else txtSo_ct.ReadOnly = False 'Tu dong danh so chung tu
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
        If Not DrDmct.Item("M_Ngay_LCt").ToString.Trim = "1" Then TxtNgay_CT.Value = _DtReturn.Rows(0).Item("Ngay_HT")
        If DrDmct.Item("M_Ngay_Ct").ToString.Trim = "1" Then TxtNgay_CT.Value = _DtReturn.Rows(0).Item("Ngay_HT")
        _Ngay_Ct = TxtNgay_CT.Value
        _Ngay_LCT = TxtNgay_CT.Value
    End Sub
    Private Sub V_GetNoVoucherAuto()
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If Not DrDmct.Item("M_Au_So_Ct").ToString.Trim = "1" And txtSo_ct.Text.Trim <> "" Then Exit Sub
        If Not txtSo_ct.Text.Trim = "" Then Exit Sub
        Dim _Ngay_LCt As Date = TxtNgay_CT.Value
        Dim _Ngay_Ct As Date = TxtNgay_CT.Value
        txtSo_ct.Text = CyberSupport.V_GetNoVoucherAuto(M_Mode, txtSo_ct.Text, M_Stt_Rec, _Ngay_Ct, _Ngay_LCt, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub
#End Region
#Region "Valid Ma_HS"
    Private Sub V_Ma_hs(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_HS.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_hs", "DmHS", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HS(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_HS.Text = "" Then
            TxtTen_HS.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_HS.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_HS.Text = DrReturn.Item("Ma_HS")
            TxtTen_HS.Text = DrReturn.Item("Ten_HS")
        Else
            TxtMa_HS.Text = ""
            TxtTen_HS.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Ma_LhKh"
    Private Sub V_Ma_LhKh(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_LhKh", "DmLhKh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_LhKh(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_LHKH.Text = DrReturn.Item("Ma_LhKh")
            TxtTen_LHKH.Text = DrReturn.Item("Ten_LhKh")
        Else
            TxtMa_LHKH.Text = ""
            TxtTen_LHKH.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Kx"
    Private Sub V_Ma_Kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_Kx", "DmKx", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kx.Text = DrReturn.Item("Ma_Kx")
            TxtTen_Kx.Text = DrReturn.Item("Ten_Kx")
        Else
            TxtMa_Kx.Text = ""
            TxtTen_Kx.Text = ""
        End If
    End Sub
#End Region
    Private Sub V_Gio_Gx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtGio_Gx.Text = CyberVoucher.V_GetTG(TxtGio_Gx.Text, 0)
    End Sub
#Region "Valid --- Ma_Mau"
    Private Sub V_Ma_Mau(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_Mau", "DmMauXe", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Mau(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Mau.Text = DrReturn.Item("Ma_Mau")
            TxtTen_Mau.Text = DrReturn.Item("Ten_Mau")
        Else
            TxtMa_Mau.Text = ""
            TxtTen_Mau.Text = ""
        End If
    End Sub
#End Region
    Private Sub V_Ma_Xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_Xe.Text = CyberVoucher.V_FormatBien_So(TxtMa_Xe.Text, True)
        If TxtMa_Xe.Text.Trim = "" Then Exit Sub
        Dim Dr = CyberSmlistSys.V_CheckAndAddRowList(M_LAN, M_Para, osysvar, AppConn, "DMXE", "Ma_Xe= N'" & TxtMa_Xe.Text.Trim.Replace("'", "").Replace("#", "") & "'", "MA_XE#", TxtMa_Xe.Text.Trim)
        If Dr Is Nothing Then Exit Sub
        V_Fill_TT(Dr, "1")
    End Sub
    Private Sub V_Ma_Xe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_Xe.Text = CyberVoucher.V_FormatBien_So(TxtMa_Xe.Text, True)
        If TxtMa_Xe.Text.Trim = "" Then Exit Sub
        Dim Dr = CyberSmlistSys.V_CheckAndAddRowList(M_LAN, M_Para, osysvar, AppConn, "DMXE", "Ma_Xe= N'" & TxtMa_Xe.Text.Trim.Replace("'", "").Replace("#", "") & "'", "MA_XE#", TxtMa_Xe.Text.Trim, True)
        If Dr Is Nothing Then Exit Sub
        If Dr.Item("Ma_Xe").ToString.Trim = TxtMa_Xe.Text.Trim Then V_Fill_TT(Dr, "1")
    End Sub
    Private Sub V_Fill_TT(ByVal Dr As DataRow, ByVal Is_Xe As String)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If Dr Is Nothing Then Exit Sub

        If V_IsFieldExist("Ma_Xe", Dr) Then
            If Is_Xe = "1" Then TxtMa_Xe.Text = Dr.Item("Ma_Xe").ToString.Trim
            If Is_Xe = "2" And TxtMa_Xe.Text.Trim = "" Then TxtMa_Xe.Text = Dr.Item("Ma_Xe").ToString.Trim
            If Is_Xe = "3" And TxtMa_Xe.Text.Trim = "" Then TxtMa_Xe.Text = Dr.Item("Ma_Xe").ToString.Trim
        End If

        If V_IsFieldExist("So_khung", Dr) Then If Not Dr.Item("So_khung").ToString.Trim = "" Then TxtSo_khung.Text = Dr.Item("So_khung").ToString.Trim
        If V_IsFieldExist("So_May", Dr) Then If Not Dr.Item("So_May").ToString.Trim = "" Then TxtSo_May.Text = Dr.Item("So_May").ToString.Trim

        If V_IsFieldExist("Ma_Mau", Dr) Then
            If Not Dr.Item("Ma_Mau").ToString.Trim = "" Then TxtMa_Mau.Text = Dr.Item("Ma_Mau").ToString.Trim
            TxtTen_Mau.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Mau", "DmMauxe", "Ma_Mau = N'" + TxtMa_Mau.Text.Trim + "'", CyberSmlib)
        End If
        If V_IsFieldExist("Ma_Kx", Dr) Then
            If Not Dr.Item("Ma_Kx").ToString.Trim.Trim = "" Then TxtMa_Kx.Text = Dr.Item("Ma_Kx").ToString.Trim
            TxtTen_Kx.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Kx", "DmKx", "Ma_Kx = N'" + TxtMa_Kx.Text.Trim + "'", CyberSmlib)
        End If


        'If M_Mode = "M" And V_IsFieldExist("So_Km", Dr) And Is_Xe = "1" Then TxtSo_Km_Cu.Double = Dr.Item("So_Km")

        If V_IsFieldExist("E_Mail", Dr) Then If Not Dr.Item("E_mail").ToString.Trim = "" Then TxtE_mail.Text = Dr.Item("E_mail").ToString.Trim
        'If V_IsFieldExist("Ma_Nthat", Dr) Then If Not Dr.Item("Ma_Nthat").ToString.Trim = "" Then TxtMa_nthat.Text = Dr.Item("Ma_Nthat").ToString.Trim

        If V_IsFieldExist("Ten_Kh", Dr) Then If Not Dr.Item("Ten_Kh").ToString.Trim = "" Then TxtTen_kh.Text = Dr.Item("Ten_Kh").ToString.Trim
        If V_IsFieldExist("Dia_Chi", Dr) Then If Not Dr.Item("Dia_Chi").ToString.Trim = "" Then TxtDia_Chi.Text = Dr.Item("Dia_Chi").ToString.Trim

        'If V_IsFieldExist("Ten_KhVAT", Dr) Then If Not Dr.Item("Ten_KhVAT").ToString.Trim = "" Then TxtTen_khVAT.Text = Dr.Item("Ten_KhVAT").ToString.Trim
        'If V_IsFieldExist("Dia_ChiVAT", Dr) Then If Not Dr.Item("Dia_ChiVAT").ToString.Trim = "" Then TxtDia_ChiVAT.Text = Dr.Item("Dia_ChiVAT").ToString.Trim
        'If V_IsFieldExist("Ma_So_Thue", Dr) Then If Not Dr.Item("Ma_So_Thue").ToString.Trim = "" Then TxtMa_So_Thue.Text = Dr.Item("Ma_So_Thue").ToString.Trim
        'If V_IsFieldExist("Ten_Lx", Dr) Then If Not Dr.Item("Ten_Lx").ToString.Trim = "" Then txtTen_Lx.Text = Dr.Item("Ten_Lx").ToString.Trim

        'If V_IsFieldExist("Ma_TP", Dr) Then If Not Dr.Item("Ma_TP").ToString.Trim = "" Then CmbMa_TP.SelectedValue = Dr.Item("Ma_TP").ToString.Trim
        'If V_IsFieldExist("Ma_Quan", Dr) Then If Not Dr.Item("Ma_Quan").ToString.Trim = "" Then CmbMa_Quan.SelectedValue = Dr.Item("Ma_Quan").ToString.Trim
        'If V_IsFieldExist("Ma_Xa", Dr) Then If Not Dr.Item("Ma_Xa").ToString.Trim = "" Then CmbMa_Xa.SelectedValue = Dr.Item("Ma_Xa").ToString.Trim

        If V_IsFieldExist("Dien_Thoai", Dr) Then If Not Dr.Item("Dien_Thoai").ToString.Trim = "" Then TxtDien_Thoai.Text = Dr.Item("Dien_Thoai").ToString.Trim
        'If V_IsFieldExist("Dt_LX", Dr) Then If Not Dr.Item("Dt_LX").ToString.Trim = "" Then TxtDt_LX.Text = Dr.Item("Dt_LX").ToString.Trim
        'If V_IsFieldExist("Fax", Dr) Then If Not Dr.Item("Fax").ToString.Trim = "" Then TxtFax.Text = Dr.Item("Fax").ToString.Trim

        'If V_IsFieldExist("Vai_Tro", Dr) Then
        '    If Not Dr.Item("Vai_Tro").ToString.Trim = "" And M_Mode = "M" Then
        '        Try
        '            CmbVai_Tro.SelectedValue = Dr.Item("Vai_Tro").ToString.Trim
        '        Catch ex As Exception
        '        End Try
        '    End If
        'End If
        'If V_IsFieldExist("Ma_HTLL", Dr) Then
        '    If Not Dr.Item("Ma_HTLL").ToString.Trim = "" And M_Mode = "M" Then
        '        Try
        '            CmbMa_HTLL.SelectedValue = Dr.Item("Ma_HTLL").ToString.Trim
        '        Catch ex As Exception
        '        End Try
        '    End If
        'End If

        'CmbNam_Sx.SelectedValue = Dr.Item("Nam_Sx").ToString.Trim

        'V_Fax(New System.Object, New System.EventArgs)
        'V_Dien_Thoai(New System.Object, New System.EventArgs)
        'V_Ten_kh(New System.Object, New System.EventArgs)
        'V_Dia_Chi(New System.Object, New System.EventArgs)
        'V_Ten_khVat(New System.Object, New System.EventArgs)
        'V_Dia_ChiVat(New System.Object, New System.EventArgs)
    End Sub
    Private Function V_IsFieldExist(ByVal Field_Name As String, ByVal Dr As DataRow) As Boolean
        Dim _Return As Boolean = False
        If Dr Is Nothing Then Return False
        Field_Name = Field_Name.Trim
        If Dr.Table.Columns.Contains(Field_Name) Then _Return = True
        V_IsFieldExist = _Return
    End Function
#Region "Valid Ma_HD"
    Private Sub V_Ma_HD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_HD.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_td3", "Dmtd3", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_HD.Text = "" Then
            TxtTen_HD.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_HD.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_HD.Text = DrReturn.Item("Ma_td3")
            TxtTen_HD.Text = DrReturn.Item("Ten_td3")
        Else
            TxtMa_HD.Text = ""
            TxtTen_HD.Text = ""
        End If
        Dim DsTTHD As DataSet
        DsTTHD = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetTTHDBX", TxtMa_HD.Text.Trim & "#" & M_Mode.Trim() & "#" & M_Ma_Dvcs.ToString().Trim() & "#" & M_User_Name.ToString().Trim())
        If DsTTHD.Tables(0).Rows.Count < 1 Then Exit Sub
        TxtSo_khung.Text = DsTTHD.Tables(0).Rows(0).Item("So_khung")
        TxtSo_may.Text = DsTTHD.Tables(0).Rows(0).Item("So_May")
        TxtMa_HS.Text = DsTTHD.Tables(0).Rows(0).Item("Ma_Hs")
        TxtTen_HS.Text = DsTTHD.Tables(0).Rows(0).Item("Ten_Hs")
        TxtMa_Mau.Text = DsTTHD.Tables(0).Rows(0).Item("Ma_Mau")
        TxtTen_Mau.Text = DsTTHD.Tables(0).Rows(0).Item("Ten_Mau")
        TxtMa_Kx.Text = DsTTHD.Tables(0).Rows(0).Item("Ma_Kx")
        TxtTen_Kx.Text = DsTTHD.Tables(0).Rows(0).Item("Ten_Kx")
        TxtTen_kh.Text = DsTTHD.Tables(0).Rows(0).Item("Ten_Kh")
        TxtDia_Chi.Text = DsTTHD.Tables(0).Rows(0).Item("Dia_Chi")

        DsTTHD.Dispose()
    End Sub
    Private Sub L_Ma_HD_LoadNew()
        Dim DsTTHD As DataSet
        DsTTHD = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetTTHDBX", TxtMa_HD.Text.Trim & "#" & M_Mode.Trim() & "#" & M_Ma_Dvcs.ToString().Trim() & "#" & M_User_Name.ToString().Trim())
        If DsTTHD.Tables(0).Rows.Count < 1 Then Exit Sub
        TxtSo_khung.Text = DsTTHD.Tables(0).Rows(0).Item("So_khung")
        TxtSo_may.Text = DsTTHD.Tables(0).Rows(0).Item("So_May")
        TxtMa_HS.Text = DsTTHD.Tables(0).Rows(0).Item("Ma_Hs")
        TxtTen_HS.Text = DsTTHD.Tables(0).Rows(0).Item("Ten_Hs")
        TxtMa_Mau.Text = DsTTHD.Tables(0).Rows(0).Item("Ma_Mau")
        TxtTen_Mau.Text = DsTTHD.Tables(0).Rows(0).Item("Ten_Mau")
        TxtMa_Kx.Text = DsTTHD.Tables(0).Rows(0).Item("Ma_Kx")
        TxtTen_Kx.Text = DsTTHD.Tables(0).Rows(0).Item("Ten_Kx")
        TxtTen_kh.Text = DsTTHD.Tables(0).Rows(0).Item("Ten_Kh")
        TxtDia_Chi.Text = DsTTHD.Tables(0).Rows(0).Item("Dia_Chi")
        TxtTen_HD.Text = DsTTHD.Tables(0).Rows(0).Item("Ten_Hd")

        DsTTHD.Dispose()
    End Sub
#End Region
#Region "Valid - Detail"
#Region "Valid - Detail - Core"
    Private Sub UpdateList()
        Dim nT_Tien_TT As Decimal = 0
        Dim nT_Tien_nt As Decimal = 0
        Dim nTong_N As Decimal = 0
        Dim nTong_C As Decimal = 0
        Dim nTien_CV As Decimal = 0
        Dim nTien_Son As Decimal = 0
        Dim nTien_VtSon As Decimal = 0
        Dim nT_Sl As Decimal = 0
        Dim nT_Sl_TT As Decimal = 0
        Dim nT_thue As Decimal = 0

        For iRow As Integer = 0 To Dv_DetailTmp.Count - 1
            Dv_DetailTmp.Item(iRow).Item("Tien_nt") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("So_luong") * Dv_DetailTmp.Item(iRow).Item("Gia_nt"), 0)

            nT_Tien_nt = nT_Tien_nt + Dv_DetailTmp.Item(iRow).Item("Tien_nt")
            nTong_N = nTong_N + IIf(Dv_DetailTmp.Item(iRow).Item("Ma_TT") = "N", Dv_DetailTmp.Item(iRow).Item("Tien_nt") + (Dv_DetailTmp.Item(iRow).Item("Tien_PT_CO_V") - Dv_DetailTmp.Item(iRow).Item("Tien_PT_CHUA_V")), 0)
            nTong_C = nTong_C + IIf(Dv_DetailTmp.Item(iRow).Item("Ma_TT") = "C", Dv_DetailTmp.Item(iRow).Item("Tien_nt") + (Dv_DetailTmp.Item(iRow).Item("Tien_PT_CO_V") - Dv_DetailTmp.Item(iRow).Item("Tien_PT_CHUA_V")), 0)
            nTien_CV = nTien_CV + Dv_DetailTmp.Item(iRow).Item("Tien_CV")
            nTien_Son = nTien_Son + Dv_DetailTmp.Item(iRow).Item("Tien_Son")
            nTien_VtSon = nTien_VtSon + Dv_DetailTmp.Item(iRow).Item("Tien_VtSon")
            nT_Sl = nT_Sl + Dv_DetailTmp.Item(iRow).Item("So_luong")
            nT_thue = nT_thue + (Dv_DetailTmp.Item(iRow).Item("Tien_PT_CO_V") - Dv_DetailTmp.Item(iRow).Item("Tien_PT_CHUA_V"))

        Next
        TxtT_SL.Double = nT_Sl

        TxtT_Tien_nt_TT.Double = nT_Tien_TT
        TxtTong_N.Double = nTong_N
        TxtTong_C.Double = nTong_C
       
        TxtTien_TT.Double = nT_Tien_nt + nTien_CV + nTien_Son + nTien_VtSon
        TxtTien_Thue.Double = nT_thue
        TxtTien_ST.Double = nT_Tien_nt + nT_thue
        TxtT_Tien_nt.Double = TxtTien_ST.Double
    End Sub

    Private Sub E_Dien_Giaii(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M") Then Exit Sub
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRV.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Dv_DetailTmp.Item(iRow).Item("Dien_Giaii").ToString.Trim = "" Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Dien_Giaii") = TxtDien_Giai.Text
            Dv_DetailTmp.Item(iRow).EndEdit()
        End If

        DetailGRV.ShowEditor()
    End Sub
#End Region
#Region "Phu kien "
    Private Sub V_Ma_pk(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_pk", "Dmpk", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_pk(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then
            Exit Sub
        End If
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dt_DetailTmp.Rows(iRow).BeginEdit()
            Dt_DetailTmp.Rows(iRow).Item("ma_pk") = ""
            Dt_DetailTmp.Rows(iRow).Item("ten_pk") = ""
            Dt_DetailTmp.Rows(iRow).Item("DVT") = ""
            Dt_DetailTmp.Rows(iRow).Item("thue_suat") = ""
            Dt_DetailTmp.Rows(iRow).EndEdit()
            Exit Sub
        Else
            Dt_DetailTmp.Rows(iRow).BeginEdit()
            Dt_DetailTmp.Rows(iRow).Item("ma_pk") = DrReturn("ma_pk").ToString.Trim
            Dt_DetailTmp.Rows(iRow).Item("thue_suat") = DrReturn("thue_suat").ToString.Trim

            Dt_DetailTmp.Rows(iRow).Item("ten_pk") = DrReturn("ten_pk" + IIf(M_LAN = "V", "", "2")).ToString.Trim
            Dt_DetailTmp.Rows(iRow).Item("Dvt") = DrReturn("DVT").ToString.Trim
            Dt_DetailTmp.Rows(iRow).Item("Ma_TT") = IIf(Dt_DetailTmp.Rows(iRow).Item("Ma_TT") = "", "C", Dt_DetailTmp.Rows(iRow).Item("Ma_TT"))
        End If
        V_SetPricePK(iRow)
        V_SetSD(iRow)
        Dt_DetailTmp.AcceptChanges()
        DetailGRV.UpdateCurrentRow()
    End Sub
    Private Sub V_SetPricePK(ByVal iRow As Integer)
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        If iRow < 0 Then Exit Sub
        Dim _Ma_PK As String = Dv_DetailTmp.Item(iRow).Item("Ma_PK").ToString.Trim
        Dim _Ma_TT As String = Dv_DetailTmp.Item(iRow).Item("Ma_TT").ToString.Trim
        Dim _So_Luong As Decimal = Dv_DetailTmp.Item(iRow).Item("So_Luong")
        Dim _Gia_nt As Decimal = Dv_DetailTmp.Item(iRow).Item("Gia_nt")
        Dim _Tien_Nt As Decimal = Dv_DetailTmp.Item(iRow).Item("Tien_NT")
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        Dim DsgetPrice As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetPricePKDX", _Ma_PK.Trim + "#" + _Ma_TT.Trim + "#" + "" + "#" + _
        _Ngay_Ct.ToString("yyyyMMdd") + "#" + _So_Luong.ToString.Trim.Replace(",", ".") + "#" + _Gia_nt.ToString.Trim.Replace(",", ".") + "#" + _Tien_Nt.ToString.Trim.Replace(",", ".") + "#" + _
        M_Mode.Trim + "#" + M_Stt_Rec + "#" + M_Ma_CT.Trim + "#" + TxtMa_Dvcs.Text.Trim + "#" + M_User_Name.Trim)

        If DsgetPrice.Tables(0).Rows.Count <= 0 Then
            DsgetPrice.Dispose()
            Exit Sub
        End If
        Dim _DtGia As DataTable = DsgetPrice.Tables(0)
        Dv_DetailTmp.Item(iRow).BeginEdit()

        If _DtGia.Columns.Contains("So_Luong") Then Dv_DetailTmp.Item(iRow).Item("So_Luong") = _DtGia.Rows(0).Item("So_Luong")
        If _DtGia.Columns.Contains("Gia_nt") Then Dv_DetailTmp.Item(iRow).Item("Gia_nt") = _DtGia.Rows(0).Item("Gia_nt")

        If _DtGia.Columns.Contains("Tien_Nt") Then Dv_DetailTmp.Item(iRow).Item("Tien_Nt") = _DtGia.Rows(0).Item("Tien_Nt")
        If Dt_DetailTmp.Columns.Contains("Gia_LD") Then Dv_DetailTmp.Item(iRow).Item("Gia_LD") = _DtGia.Rows(0).Item("Gia_LD")
        If Dt_DetailTmp.Columns.Contains("Gia_son") Then Dv_DetailTmp.Item(iRow).Item("Gia_son") = _DtGia.Rows(0).Item("Gia_son")
        If Dt_DetailTmp.Columns.Contains("Gia_Vtson") Then Dv_DetailTmp.Item(iRow).Item("Gia_Vtson") = _DtGia.Rows(0).Item("Gia_Vtson")

        Dv_DetailTmp.Item(iRow).EndEdit()
        DsgetPrice.Dispose()
        Dv_DetailTmp.Table.AcceptChanges()
        Tinh_Tien(iRow)
    End Sub
    Private Sub V_SetSD(ByVal iRow As Integer)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If iRow < 0 Then Exit Sub
        Dim _Ma_Vt As String = Dv_DetailTmp.Item(iRow).Item("Ma_pk").ToString.Trim
        Dim _Ma_kho As String = ""
        Dim _Ma_Vitri As String = ""
        Dim _Ma_Lo As String = ""
        Dim _Return As DataRow = CyberSupport.V_SetSD(StatusFooter1, AppConn, "VT", M_Mode, _Ma_Vt, _Ma_kho, _Ma_Vitri, _Ma_Lo, M_Stt_Rec, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib)
        If Dv_DetailTmp.Table.Columns.Contains("Ton13") Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Ton13") = If(_Return Is Nothing, 0, _Return("SL"))
            Dv_DetailTmp.Item(iRow).EndEdit()
        End If
    End Sub
    Private Sub V_Tinh_Toan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dt_DetailTmp.AcceptChanges()
        Tinh_Tien(iRow)
    End Sub
    Private Sub Tinh_Tien(ByVal iRow As Integer)
        If iRow < 0 Then Exit Sub

        'Thanh Tien---------------------------------------------------------------------------------------
        Dv_DetailTmp.Item(iRow).BeginEdit()
        If Dv_DetailTmp.Item(iRow).Item("So_luong") * Dv_DetailTmp.Item(iRow).Item("Gia_nt") <> 0 Then
            Dv_DetailTmp.Item(iRow).Item("Tien_nt") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("So_luong") * Dv_DetailTmp.Item(iRow).Item("Gia_nt"), 0)
        End If
        If Dv_DetailTmp.Item(iRow).Item("So_luong") * Dv_DetailTmp.Item(iRow).Item("Gia_LD") <> 0 Then
            Dv_DetailTmp.Item(iRow).Item("Tien_CV") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("So_luong") * Dv_DetailTmp.Item(iRow).Item("Gia_LD"), 0)
        End If
        If Dv_DetailTmp.Item(iRow).Item("So_luong") * Dv_DetailTmp.Item(iRow).Item("Gia_son") <> 0 Then
            Dv_DetailTmp.Item(iRow).Item("Tien_son") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("So_luong") * Dv_DetailTmp.Item(iRow).Item("Gia_son"), 0)
        End If
        If Dv_DetailTmp.Item(iRow).Item("So_luong") * Dv_DetailTmp.Item(iRow).Item("Gia_Vtson") <> 0 Then
            Dv_DetailTmp.Item(iRow).Item("Tien_Vtson") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("So_luong") * Dv_DetailTmp.Item(iRow).Item("Gia_Vtson"), 0)
        End If
        Dv_DetailTmp.Item(iRow).Item("Tien_PT_CHUA_V") = Dv_DetailTmp.Item(iRow).Item("Tien_nt") + Dv_DetailTmp.Item(iRow).Item("Tien_CV") + Dv_DetailTmp.Item(iRow).Item("Tien_son") + Dv_DetailTmp.Item(iRow).Item("Tien_Vtson")
        Dv_DetailTmp.Item(iRow).Item("Tien_PT_CO_V") = CyberSupport.V_Round((Dv_DetailTmp.Item(iRow).Item("thue_suat") * CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("Tien_nt"), 0) / 100), 0) + CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("Tien_nt"), 0)
        Dv_DetailTmp.Item(iRow).EndEdit()
        '-------------------------------------------------------------------------------------------------
        UpdateList()
    End Sub
#End Region
#Region "L_Ma_TT"
    Private Sub V_Ma_TT(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_TT", "DmTT", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow)("Ma_TT") = ""
            Dv_DetailTmp.Item(iRow).EndEdit()
            Exit Sub
        End If
        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Ma_TT") = DrReturn("Ma_TT").ToString.Trim
        Dv_DetailTmp.Item(iRow).EndEdit()
        V_SetPricePK(iRow)
    End Sub
#End Region
#End Region
#Region "Ngay ct, ngay lap chung tu,so chung tu"
    Private Sub V_Ngay_Ct(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If DrDmct.Item("M_Au_So_Ct").ToString.Trim = "1" Then Exit Sub

        If Not txtSo_ct.Text.Trim = "" Then Exit Sub
        Dim _Ngay_LCt As Date = TxtNgay_CT.Value
        Dim _Ngay_Ct As Date = TxtNgay_CT.Value
        txtSo_ct.Text = CyberSupport.V_GetNoVoucher(M_Mode, txtSo_ct.Text, M_Stt_Rec, _Ngay_Ct, _Ngay_LCt, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub
    Private Sub V_Ngay_LCt(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If DrDmct.Item("M_Au_So_Ct").ToString.Trim = "1" Then Exit Sub
        If Not txtSo_ct.Text.Trim = "" Then Exit Sub
        Dim _Ngay_LCt As Date = TxtNgay_CT.Value
        Dim _Ngay_Ct As Date = TxtNgay_CT.Value
        txtSo_ct.Text = CyberSupport.V_GetNoVoucher(M_Mode, txtSo_ct.Text, M_Stt_Rec, _Ngay_Ct, _Ngay_LCt, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub
    Private Sub V_So_Ct(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If DrDmct.Item("M_Au_So_Ct").ToString.Trim = "1" Then Exit Sub
        If Not txtSo_ct.Text.Trim = "" Then Exit Sub
        Dim _Ngay_LCt As Date = TxtNgay_CT.Value
        Dim _Ngay_Ct As Date = TxtNgay_CT.Value
        txtSo_ct.Text = CyberSupport.V_GetNoVoucher(M_Mode, txtSo_ct.Text, M_Stt_Rec, _Ngay_Ct, _Ngay_LCt, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub
#End Region
    Private Sub V_NgayDK(ByVal sender As System.Object, ByVal e As System.EventArgs)

        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then
            Exit Sub
        End If

        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then
            Exit Sub
        End If
        Dt_DetailTmp.AcceptChanges()
    End Sub
#Region "Ty gia -  Ngoai te"
    Private Sub L_Ma_NT(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = Nothing
        Dim Dt As Date = TxtNgay_CT.Value
        GetRound()
        For iRow As Integer = 0 To Dv_DetailTmp.Count - 1
            Tinh_Tien(iRow)
        Next

        'VisibleColumnMa_NT()
    End Sub
    Private Sub L_Ty_Gia(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        'If TxtMa_NT.Text.Trim = "" Or TxtMa_NT.Text.Trim.ToUpper = osysvar("M_MA_NT0").ToString.Trim Then TxtTy_Gia.Double = 1
        For iRow As Integer = 0 To Dv_DetailTmp.Count - 1
            Tinh_Tien(iRow)
        Next
        Dv_DetailTmp.Table.AcceptChanges()
    End Sub

#End Region
#Region "Mainform"
    Private Sub V_MainSystem()
        Dim mnItemsMail = New ContextMenu

        Dim mnItemsF4 As New MenuItem("Thêm dòng", AddressOf V_ShortAddItem, Keys.F4)
        Dim mnItemsF8 As New MenuItem("Xóa dòng", AddressOf V_ShortDeleteItem, Keys.F8)

        Dim mnItemsSave As New MenuItem("Lưu chứng tư", AddressOf V_ShortSAVE, Keys.Control + Keys.Enter)
        Dim mnItemsPrint As New MenuItem("In chứng từ", AddressOf V_ShortPrint, Keys.Control + Keys.P)

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
        UpdateList()
    End Sub
    Private Sub V_ShortSAVE(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If Me.CmdSave.Enabled Then CmdSave.Focus()
        If Me.CmdSave.Enabled Then CmdSave.PerformClick()
    End Sub
    Private Sub V_ShortPrint(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "X") Then Exit Sub
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
        Dim _Dt As Date = TxtNgay_CT.Value
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
        ''If TxtMa_NT.Text.Trim = "" Then V_GetTyGia()
        Dim _Ngay_Ct As Date = TxtNgay_CT.Value
        Dim _Ngay_LCt As Date = TxtNgay_CT.Value
        '----------------------------------------------------------------------------------------------------------------------
        V_GetDateVoucher(M_Mode, _Ngay_Ct, _Ngay_LCt)
        '----------------------------------------------------------------------------------------------------------------------
        If Not ChkRightsVoucher("L") Then Exit Sub
        '----------------------------------------------------------------------------------------------------------------------
        V_GetNoVoucherAuto() ' Tao So Chung tu tu dong        
        '----------------------------------------------------------------------------------------------------------------------
        If Not ChkVsave() Then Exit Sub 'Kiem tra va Update du lieu chuong tri   
        '----------------------------------------------------------------------------------------------------------------------
        CyberInput.V_Save_Default_TTCP(Dt_DetailTmp, M_Is_Visible_TTCP, CmbMa_TTCP_H, M_Ma_CT, CyberSmodb)
        CyberInput.V_Save_Default_TTCP(Dt_DetailVaTTmp, M_Is_Visible_TTCP, CmbMa_TTCP_H, M_Ma_CT, CyberSmodb)
        '----------------------------------------------------------------------------------------------------------------------
        If Not CyberSupport.V_ChkExistNovoucher(AppConn, osysvar, M_LAN, DrDmct, M_Mode, M_Stt_Rec, M_Ma_CT, txtSo_ct.Text.Trim, _Ngay_Ct, _Ngay_LCt, M_Ma_Dvcs, M_User_Name, CyberSmlib) Then Exit Sub '---Kiem tra trung so chung tu
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
        drMaster.Item("So_Ct") = CyberSupport.V_soct(txtSo_ct.Text.Trim)
        '---Save Post
        CyberSupport.V_SavePost(AppConn, drMaster, CbbMa_Post.SelectedValue, M_Ma_CT, M_User_Name, M_User_Name, CyberSmlib)
        '---------------------------------------------------
        Dim DsSave As DataSet
        If Not CyberSmodb.V_SysCheckSaveVoucher(AppConn, osysvar, {Dt_DetailTmp, CyberSmodb.V_ConvertDrToTb(drMaster)}, {M_Ct, M_Ph}, M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, "", M_Ma_CT, M_Stt_Rec, M_LAN, TxtMa_Dvcs.Text, M_User_Name, CyberSmlib, CyberSupport, DsSave) Then
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
                drMaster.Item("So_Ct") = CyberSupport.V_soct(txtSo_ct.Text.Trim)
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
        M_Mode = "X"
        M_Count = Dt_Master.Rows.Count
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        ''V_SetFocus("L")
        CyberSmlib.FlushMemorySave()

    End Sub
    Private Function ChkVsave() As Boolean
        Dim iRow, nCount As Integer
        nCount = Dt_DetailTmp.Rows.Count
        For iRow = nCount - 1 To 0 Step -1
            If Dt_DetailTmp.Rows(iRow).Item("Ma_PK").ToString.Trim = "" Then
                Dt_DetailTmp.Rows(iRow).Delete()
                Dt_DetailTmp.AcceptChanges()
            End If
        Next
        '---------------------------------------------------------------------------------
        For iRow = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_DetailTmp.Rows(iRow).BeginEdit()
            Dt_DetailTmp.Rows(iRow).Item("Stt_Rec") = M_Stt_Rec
            Dt_DetailTmp.Rows(iRow).Item("Ma_Ct") = M_Ma_CT
            Dt_DetailTmp.Rows(iRow).Item("Ngay_Ct") = TxtNgay_CT.Value
            Dt_DetailTmp.Rows(iRow).Item("So_Ct") = CyberSupport.V_soct(txtSo_ct.Text.Trim)
            Dt_DetailTmp.Rows(iRow).Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(iRow + 1)
            Dt_DetailTmp.Rows(iRow).EndEdit()
        Next
        Dt_DetailTmp.AcceptChanges()
        If Not CyberSupport.ChkDetail(Dv_DetailTmp.Count, M_Ma_CT, M_LAN, osysvar) Then Return False
        '---Update: So_RO/So_PO/So_SO
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
        'drMaster.Item("User_Id") = M_User_ID.Trim
        drMaster.Item("So_Ct") = CyberSupport.V_soct(txtSo_ct.Text.Trim)
        '---Save Post
        CyberSupport.V_SavePost(AppConn, drMaster, CbbMa_Post.SelectedValue, M_Ma_CT, M_User_Name, M_User_Name, CyberSmlib)
        If M_Mode.Trim = "M" Then Dt_Master.Rows.Add(drMaster) Else Dt_Master.Rows(CrrRow).EndEdit()
        Dt_Master.AcceptChanges()
        '-----------------------------------------------------------------------------------------------------
        '---Xoa trong Detail
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_Detail, "Stt_Rec = '" + M_Stt_Rec + "'")
        'If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_DetailCv, "Stt_Rec = '" + M_Stt_Rec + "'")
        '+Import To Detail 
        For i As Integer = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_Detail.ImportRow(Dt_DetailTmp.Rows(i))
        Next
        'For i As Integer = 0 To Dt_DetailCvTmp.Rows.Count - 1
        '    Dt_DetailCv.ImportRow(Dt_DetailCvTmp.Rows(i))
        'Next
        'Return CyberSmodb.V_Add2Database(AppConn, osysvar, {Dt_DetailTmp, CyberSmodb.V_ConvertDrToTb(drMaster), Dt_DetailCvTmp}, {M_Ct, M_Ph, "CTGT40"}, M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, M_Ma_CT, M_Stt_Rec, M_LAN, TxtMa_Dvcs.Text, M_User_Name, CyberSmlib, CyberSupport)
        Return CyberSmodb.V_Add2Database(AppConn, osysvar, {Dt_DetailTmp, CyberSmodb.V_ConvertDrToTb(drMaster)}, {M_Ct, M_Ph}, M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, M_Ma_CT, M_Stt_Rec, M_LAN, TxtMa_Dvcs.Text, M_User_Name, CyberSmlib, CyberSupport)
        ''-----------------------------------------------------------------------------------------------------
        ''---Save: History
        'CyberSupport.V_HistoryVoucher(M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, M_Ma_CT, M_Stt_Rec, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
        ''-----------------------------------------------------------------------------------------------------
        ''---Save: TO SQL

        'CyberSmodb.V_SaveToSQL(AppConn, osysvar, M_User_Name, drMaster, M_Ph, M_Mode, "Stt_Rec = N'" + M_Stt_Rec + "'", IIf(M_Mode.Trim = "S", True, False))
        ''V_CyberSaveToSQL()

        'CyberSmodb.V_CyberSaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailTmp, M_Ct, M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")
        'CyberSmodb.V_CyberSaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailCvTmp, "CTGT40", M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")

        '' CyberSmodb.V_CyberSaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailTmp, M_Ct, M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")
        ''CyberSmodb.V_SaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailCvTmp, "CTGT40", M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")
        ''-----------------------------------------------------------------------------------------------------
        ''---Save: Post
        'CyberSupport.V_PostVoucher(M_Mode, M_Ma_CT, M_Stt_Rec, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Function
    Private Sub Add2DatabaseLuu()
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
        drMaster.Item("So_Ct") = CyberSupport.V_soct(txtSo_ct.Text.Trim)
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

        If Not Frm.Ok_Copy Then Exit Sub
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
        TxtNgay_CT.Value = _Ngay_Ct_Copy
        txtSo_ct.Text = _So_Ct_Copy.Trim
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

            If Not M_Tk_Co.Trim = "" Then
                DrCurren.Item("Ma_Nx_I") = M_Tk_Co.Trim
                If DrCurren.Table.Columns.Contains("Ten_Nx_I") Then DrCurren.Item("Ten_Nx_I") = M_Ten_Tk_Co.Trim
            End If

            DrCurren.Item("Stt_Rec") = M_Stt_Rec.Trim
            DrCurren.Item("Ma_Ct") = M_Ma_CT.Trim
            DrCurren.Item("Ngay_Ct") = TxtNgay_CT.Value
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
        Dim _Dt As Date = TxtNgay_CT.Value
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
        UpdateList()
        iRow = Dv_DetailTmp.Count - 1
        CyberFill.V_ForcusCell(DetailGRV, iRow, 0)

    End Sub
    Private Sub CarrOn(ByVal DvNew As DataRow)
        DvNew.Item("Stt_Rec") = M_Stt_Rec.Trim
        DvNew.Item("Ma_Ct") = M_Ma_CT.Trim
        DvNew.Item("Ngay_Ct") = Me.TxtNgay_CT.Value
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
        TxtT_Tien_nt.ReadOnly = True
        TxtT_Tien_nt_TT.ReadOnly = True
        TxtTen_HS.ReadOnly = True
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

    Dim M_Ma_Hs_H As String = ""
    Dim M_Ten_Hs_H As String = ""
    Dim M_Ten_Hs2_H As String = ""

    Dim M_Ma_BP_H As String = ""
    Dim M_Ten_BP_H As String = ""
    Dim M_Ten_BP2_H As String = ""
    Private Sub V_LoadDefault()
        If DrDmct.Table.Columns.Contains("Is_Visible_TTCP") Then M_Is_Visible_TTCP = (DrDmct.Item("Is_Visible_TTCP").ToString.Trim = "1")
        LabMa_TTCP_H.Visible = M_Is_Visible_TTCP
        CmbMa_TTCP_H.Visible = M_Is_Visible_TTCP
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

            If DsTmp.Tables(0).Columns.Contains("Ma_Hs_H") Then M_Ma_TTCP_H = DsTmp.Tables(0).Rows(0).Item("Ma_Hs_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_Hs_H") Then M_Ten_Hs_H = DsTmp.Tables(0).Rows(0).Item("Ten_Hs_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_Hs2_H") Then M_Ten_Hs2_H = DsTmp.Tables(0).Rows(0).Item("Ten_Hs2_H").ToString.Trim

            If DsTmp.Tables(0).Columns.Contains("Ma_BP_H") Then M_Ma_TTCP_H = DsTmp.Tables(0).Rows(0).Item("Ma_BP_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_BP_H") Then M_Ten_BP_H = DsTmp.Tables(0).Rows(0).Item("Ten_BP_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_BP2_H") Then M_Ten_BP2_H = DsTmp.Tables(0).Rows(0).Item("Ten_BP2_H").ToString.Trim

            If DsTmp.Tables.Count > 1 Then
                DtTTCP = DsTmp.Tables(1).Copy
                CyberFill.V_FillComBoxValue(Me.CmbMa_TTCP_H, DtTTCP, "Ma_TTCP", If(M_LAN = "V", "Ten_TTCP", "Ten_TTCP2"), M_Ma_TTCP_H)
            Else
                M_Is_Visible_TTCP = False
            End If

            DsTmp.Dispose()
        End If
    End Sub
#End Region
End Class