Public Class ROTDKTVSCC_TT
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim _DTLoai_BC As DataTable
    Dim _DtGroupBy, DtMaGD As DataTable
    Private Sub ROTDKTVSCC_TT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_AddMenuShorcut()
        V_Load()
        V_Addhander()
    End Sub
#Region "Load"


    Private Sub V_Load()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '----Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)

        TxtMa_HS.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_HS)
        TxtTen_HS.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_HS", "Dmhs", "(Ma_hs= N'" + TxtMa_HS.Text.Trim + "')", CyberSmLib)

        Dim _DsLoai_BC As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "SysNhapXuat#CP_NAME= N'LOAI_BC' AND Acti = N'1'#ID")
        _DTLoai_BC = _DsLoai_BC.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(CbbLoai_BC, _DTLoai_BC, "Nhom", "Ten_nhom")
        _DsLoai_BC.Dispose()
        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit

        '--Ma_VT
        AddHandler TxtMa_HS.CyberValiting, AddressOf V_Ma_HS
        AddHandler TxtMa_HS.CyberLeave, AddressOf L_Ma_HS

        '--Ma_VT
        AddHandler txtMa_Xe.CyberValiting, AddressOf V_Ma_Xe
        AddHandler TxtMa_XE.CyberLeave, AddressOf L_Ma_Xe

        AddHandler txtSo_RO.Leave, AddressOf L_Lenh_Ro
    End Sub


#End Region
#Region "Valid"

#Region "Valid --- Ma_HS"
    Private Sub V_Ma_HS(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_HS.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_hs", "DmHS", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HS(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_HS.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_HS.Text = DrReturn.Item("Ma_HS")
            TxtTen_HS.Text = DrReturn.Item("Ten_HS")
        Else
            TxtMa_HS.Text = ""
            TxtTen_HS.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Xe"
    Private Sub V_Ma_Xe(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        txtMa_Xe.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Xe", "DmXe", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Xe(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = txtMa_Xe.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            txtMa_Xe.Text = DrReturn.Item("Ma_Xe")
            txtMa_kx.Text = DrReturn.Item("Ma_KX")
        Else
            txtMa_Xe.Text = ""
            txtMa_kx.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
    Private Sub L_Lenh_Ro(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Dt As Date = Date.Now
        Dim CyberVoucher As New Cyber.Voucher.Sys
        TxtSo_RO.Text = CyberVoucher.V_GetSo_RO("HDK", "S", "S", _Dt, TxtSo_RO.Text, "")
    End Sub
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value

        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Dim _Loai_BC_Filter As String = Me.CbbLoai_BC.SelectedValue.ToString.Trim
        Dim M_strParameterStore As String = ""
        M_strParameterStore = Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & txtSo_RO.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_XE.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_HS.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & _Loai_BC_Filter
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


