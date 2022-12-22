Public Class QBCROHDI_1
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim _DTLoai_BC As DataTable
    Private Sub QBCROHDI_1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        If TxtMa_BH.Text.Trim = "" Then TxtTen_BH.Text = "" Else TxtTen_Kh.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Bh", "Dmbh", "( Ma_bh = N'" + TxtMa_BH.Text.Trim + "')", CyberSmLib)
        If TxtMa_Kh.Text.Trim = "" Then TxtTen_Kh.Text = "" Else TxtTen_Kh.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Kh", "DmKh", "( Ma_Kh = N'" + TxtMa_Kh.Text.Trim + "')", CyberSmLib)
        If TxtMa_HS.Text.Trim = "" Then TxtTen_HS.Text = "" Else TxtTen_HS.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_HS", "DmHS", "( Ma_HS = N'" + TxtMa_HS.Text.Trim + "')", CyberSmLib)
        '----
        Dim _DsLoai_BC As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "SysNhapXuat#CP_NAME= N'CP_QBCROHDI' AND Acti = N'1'#ID")
        _DTLoai_BC = _DsLoai_BC.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(CbbLoai_BC, _DTLoai_BC, "id", "Ten_nhom")
        _DsLoai_BC.Dispose()
        CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
        '--BH
        AddHandler TxtMa_BH.CyberValiting, AddressOf V_Ma_bh_h
        AddHandler TxtMa_BH.CyberLeave, AddressOf L_Ma_bh_h
        '--KH
        AddHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_Kh_h
        AddHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_Kh_h
        '--HS
        AddHandler TxtMa_HS.CyberValiting, AddressOf V_Ma_HS_h
        AddHandler TxtMa_HS.CyberLeave, AddressOf L_Ma_HS_h

    End Sub
#End Region
#Region "Valid"
#Region "Vali --- BH"
    Private Sub V_Ma_bh_h(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_BH.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_bh", "Dmbh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_bh_h(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_BH.Text = "" Then
            TxtTen_BH.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_BH.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_BH.Text = DrReturn.Item("Ma_bh")
            TxtTen_BH.Text = DrReturn.Item("Ten_bh")
        Else
            TxtMa_BH.Text = ""
            TxtTen_BH.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- KH"
    Private Sub V_Ma_Kh_h(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Kh.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Kh", "DmKh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kh_h(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Kh.Text = "" Then
            TxtTen_Kh.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kh.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kh.Text = DrReturn.Item("Ma_Kh")
            TxtTen_Kh.Text = DrReturn.Item("Ten_Kh")
        Else
            TxtMa_Kh.Text = ""
            TxtTen_Kh.Text = ""
        End If
    End Sub
#End Region

#Region "Vali --- HS"
    Private Sub V_Ma_HS_h(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_HS.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_HS", "DmHS", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HS_h(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
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

#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value
        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Dim _Loai_BC_Filter As String = Me.CbbLoai_BC.SelectedValue.ToString.Trim
        Dim M_strParameterStore As String = Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_BH.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_HS.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Kh.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & _Loai_BC_Filter
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
