Public Class BCDV49
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim _Dt_GD, _Dt_post1, _Dt_post2, _GroupByTH, _GroupByCT As DataTable
    Dim M_Ma_Post1 As String = ""
    Dim M_Ma_Post2 As String = ""
    Dim CyberVoucher As New Cyber.Voucher.Sys

    Private Sub BH01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_AddMenuShorcut()
        V_Load()
        V_Addhander()
    End Sub
#Region "Load"
    Private Sub V_Load()
        '--------------------------------------------------------------------
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        Dim _DsPost As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetMaPostReports", "HDI" & "##")
        _Dt_post1 = _DsPost.Tables(0).Copy
        _Dt_post2 = _DsPost.Tables(1).Copy
        _DsPost.Dispose()
        '----Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)
        'txtMa_KX.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, txtMa_KX)
        'TxtMa_mau.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_mau)

        'If txtMa_KX.Text.Trim = "" Then TxtTen_kx.Text = "" Else TxtTen_kx.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_kx", "DmKx", "(Ma_kx = N'" + txtMa_KX.Text.Trim + "')", CyberSmLib)
        'If TxtMa_mau.Text.Trim = "" Then txtTen_Mau.Text = "" Else txtTen_Mau.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_mau", "Dmmauxe", "(Ma_mau= N'" + TxtMa_mau.Text.Trim + "')", CyberSmLib)

        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit

        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
        '-- ma xe
        'AddHandler TxtMa_Xe.Leave, AddressOf V_Ma_Xe
        '--Ma_KX
        'AddHandler txtMa_KX.CyberValiting, AddressOf V_Ma_Kx
        'AddHandler txtMa_KX.CyberLeave, AddressOf L_Ma_Kx
        ''-- Ma_Mau
        'AddHandler TxtMa_mau.CyberValiting, AddressOf V_Ma_mau
        'AddHandler TxtMa_mau.CyberLeave, AddressOf L_Ma_mau
        AddHandler Txtma_bh.CyberValiting, AddressOf V_Ma_bh
        AddHandler Txtma_bh.CyberLeave, AddressOf L_Ma_bh


    End Sub
#End Region
#Region "Valid"
#Region "Valid --- Ma_Kx"
    'Private Sub V_Ma_Kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '    txtMa_KX.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Kx", "DmKx", "1=1", "1=1")
    'End Sub
    'Private Sub L_Ma_Kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '    DrReturn = txtMa_KX.GetRowsSelectData(True)
    '    If Not DrReturn Is Nothing Then
    '        txtMa_KX.Text = DrReturn.Item("Ma_Kx")
    '        TxtTen_kx.Text = DrReturn.Item("Ten_Kx")
    '    Else
    '        txtMa_KX.Text = ""
    '        TxtTen_kx.Text = ""
    '        Exit Sub
    '    End If
    'End Sub
#End Region
#Region "Valid ---MA_MAU"
    'Private Sub V_Ma_mau(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '    TxtMa_mau.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_mau", "DmMauxe", "1=1", "1=1")
    'End Sub
    'Private Sub L_Ma_mau(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '    DrReturn = TxtMa_mau.GetRowsSelectData(True)
    '    If Not DrReturn Is Nothing Then
    '        TxtMa_mau.Text = DrReturn.Item("Ma_mau")
    '        txtTen_Mau.Text = DrReturn.Item("Ten_mau")
    '    Else
    '        TxtMa_mau.Text = ""
    '        txtTen_Mau.Text = ""
    '        Exit Sub
    '    End If
    'End Sub
#End Region
#Region "Valid --- Xe"
    Private Sub V_Ma_bh(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Txtma_bh.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_kh", "Dmkh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_bh(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = Txtma_bh.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            Txtma_bh.Text = DrReturn.Item("Ma_kh")
            TxtTen_bh.Text = DrReturn.Item("ten_kh")
        Else
            Txtma_bh.Text = ""
            TxtTen_bh.Text = ""

            Exit Sub
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
        M_strParameterStore = M_strParameterStore & "#" & Txtma_bh.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & IIf(ChkIs_All.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & IIf(ChkIs_C.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & IIf(ChkIs_I.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & IIf(ChkIs_N.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & IIf(ChkIs_W.Checked, "1", "0")

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
