Public Class RODTLHCV
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim _Dt_TT As DataTable
    Private Sub RODTLHCV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        V_Addhander()
    End Sub
#Region "Load"
    Private Sub V_Load()
        V_AddMenuShorcut()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '----Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)

        If TxtMa_CV.Text.Trim = "" Then TxtTen_CV.Text = "" Else TxtTen_CV.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_cv", "Dmcv", "( Ma_CV = N'" + TxtMa_CV.Text.Trim + "')", CyberSmLib)
        '--Mã thanh toán:
        Dim _DsGroup As New DataSet
        _DsGroup = Nothing
        _DsGroup = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "SysNhapXuat" + "#" + "CP_NAME= N'LOAI_TT' AND Acti = N'1'" + "#" + "ID")
        _Dt_TT = _DsGroup.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(Me.CbbMa_TT, _Dt_TT, "NHOM", "Ten_Nhom")
        '----
        CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
        '--CV
        AddHandler TxtMa_CV.CyberValiting, AddressOf V_Ma_Cv
        AddHandler TxtMa_CV.CyberLeave, AddressOf L_Ma_Cv
        '--CVDV
        AddHandler TxtMa_Hs_H.CyberValiting, AddressOf V_Ma_Hs
        AddHandler TxtMa_Hs_H.CyberLeave, AddressOf L_Ma_Hs

    End Sub
#End Region
#Region "Valid"
#Region "Vali --- CV"
    Private Sub V_Ma_Cv(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_CV.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_CV", "DmCV", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Cv(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_CV.Text = "" Then
            TxtTen_CV.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_CV.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_CV.Text = DrReturn.Item("Ma_CV")
            TxtTen_CV.Text = DrReturn.Item("Ten_cv")
        Else
            TxtMa_CV.Text = ""
            TxtTen_CV.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- CV"
    Private Sub V_Ma_Hs(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Hs_H.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_HS", "DmHS", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Hs(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Hs_H.Text = "" Then
            TxtTen_Hs_H.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Hs_H.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Hs_H.Text = DrReturn.Item("Ma_HS")
            TxtTen_Hs_H.Text = DrReturn.Item("Ten_HS")
        Else
            TxtMa_Hs_H.Text = ""
            TxtTen_Hs_H.Text = ""
        End If
    End Sub
#End Region

#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value
        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Dim M_strParameterStore As String = Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & IIf(ChkXem_CT.Checked = True, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Hs_H.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & txtSo_ct1.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_CV.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & CbbMa_TT.SelectedValue.ToString.Trim()
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
