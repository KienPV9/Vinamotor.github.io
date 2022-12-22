Public Class HRLUONGHDKBH
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim _Dt_GD, _Dt_post1, _Dt_post2, _DtGroup, _DtGroupct, _DtLoai_Phieu As DataTable
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet

    Dim M_Ma_CT As String = ""
    Dim M_Ma_GD As String = ""
    Dim M_Loai_TH As String = "0"
    Dim M_Ma_Post1 As String = ""
    Dim M_Ma_Post2 As String = ""
    Dim CyberVoucher As New Cyber.Voucher.Sys
    Private Sub SysDateToDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        M_Ma_CT = Me.Para(Me.VT_PARA + 2).Trim
        M_Ma_GD = Me.Para(Me.VT_PARA + 3).Trim
        M_Ma_Post1 = Me.Para(Me.VT_PARA + 4).Trim
        M_Ma_Post2 = Me.Para(Me.VT_PARA + 5).Trim
        If Not (M_Ma_CT = "HDK" Or M_Ma_CT = "HDP" Or M_Ma_CT = "HDM") Then M_Ma_CT = "HDK"
        V_AddMenuShorcut()
        V_Load()
        V_VisibleCT()
        V_Addhander()
    End Sub
#Region "Load"
#Region "Chi tiet theo"
    Private Sub V_VisibleCT()

    End Sub
    Private Sub V_Detail_OK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_VisibleCT()
    End Sub
#End Region
    Private Sub V_Load()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '--------------------------------------------------------------------

        Dim _DsPost As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetMaPostReports", M_Ma_CT & "##")
        _Dt_post1 = _DsPost.Tables(0).Copy
        _Dt_post2 = _DsPost.Tables(1).Copy

        Dim _Ma_Post_Min As String = _Dt_post1.Rows(0).Item("Ma_Post")
        Dim _Ma_Post_Max As String = _Dt_post2.Rows(_Dt_post2.Rows.Count - 1).Item("Ma_Post")

        If _Dt_post1.Select("Ma_Post = '" + M_Ma_Post1.Trim + "'").Length = 0 Then M_Ma_Post1 = _Ma_Post_Min
        If _Dt_post2.Select("Ma_Post = '" + M_Ma_Post2.Trim + "'").Length = 0 Then M_Ma_Post2 = _Ma_Post_Max

        _DsPost.Dispose()
        CyberFill.V_FillComBoxValue(Me.CbbMa_Post1, _Dt_post1, "ma_post", "Ten_post", M_Ma_Post1)
        CyberFill.V_FillComBoxValue(Me.CbbMa_post2, _Dt_post2, "ma_post", "Ten_post", M_Ma_Post2)
        '--------------------------------------------------------------------
        '----Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)

        Txtma_kh.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, Txtma_kh)
        TxtMa_Hs.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Hs)

        If Txtma_kh.Text.Trim = "" Then TxtTen_kh.Text = "" Else TxtTen_kh.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_kh", "DmKh", "(Ma_kh = N'" + Txtma_kh.Text.Trim + "')", CyberSmLib)
        If TxtMa_Hs.Text.Trim = "" Then TxtTen_Hs.Text = "" Else TxtTen_Hs.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_HS", "DmHS", "(Ma_HS= N'" + TxtMa_Hs.Text.Trim + "')", CyberSmLib)

        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
        '--ma bảo hiểm
        AddHandler TxtMa_Bh.CyberValiting, AddressOf V_Ma_Bh
        AddHandler TxtMa_Bh.CyberLeave, AddressOf L_Ma_bh
        '--ma khach hang
        AddHandler TxtMa_Bh.CyberValiting, AddressOf V_Ma_Bh
        AddHandler TxtMa_Bh.CyberLeave, AddressOf L_Ma_Bh
        '-- ma HS
        AddHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        AddHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs
        '-- ma BP
        AddHandler TxtMa_BP.CyberValiting, AddressOf V_Ma_BP
        AddHandler TxtMa_BP.CyberLeave, AddressOf L_Ma_BP
        '-- ma xe
        AddHandler TxtMa_Xe.Leave, AddressOf V_Ma_Xe
        'AddHandler TxtMa_xe.CyberValiting, AddressOf V_Ma_xe
        'AddHandler TxtMa_xe.CyberLeave, AddressOf L_Ma_xe

        AddHandler TxtMa_KX.CyberValiting, AddressOf V_Ma_Kx
        AddHandler TxtMa_KX.CyberLeave, AddressOf L_Ma_Kx
    End Sub
    Private Sub V_LoadMa_GD(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub
#End Region
#Region "Valid"
#Region "Valid --- Ma_KH"
    Private Sub V_Ma_Bh(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Bh.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_BH", "DmBH", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Bh(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Bh.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Bh.Text = DrReturn.Item("Ma_Bh")
            TxtTen_BH.Text = DrReturn.Item("Ten_Bh")
        Else
            Txtma_Bh.Text = ""
            TxtTen_BH.Text = ""
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
            TxtTen_kh.Text = DrReturn.Item("Ten_Kh")
        Else
            Txtma_kh.Text = ""
            TxtTen_kh.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Kx"
    Private Sub V_Ma_Kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_KX.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Kx", "DmKx", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_KX.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_KX.Text = DrReturn.Item("Ma_Kx")
        Else
            TxtMa_KX.Text = ""
            TxtTen_Kx.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
    Private Sub V_Ma_Xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Xe.Text.Trim = "" Then Exit Sub

        TxtMa_Xe.Text = CyberVoucher.V_FormatBien_So(TxtMa_Xe.Text, True)
    End Sub
    '#Region "Valid --- Ma_xe"
    '    Private Sub V_Ma_xe(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '        TxtMa_xe.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_xe", "Dmxe", "1=1", "1=1")
    '    End Sub
    '    Private Sub L_Ma_xe(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '        DrReturn = TxtMa_xe.GetRowsSelectData(True)
    '        If Not DrReturn Is Nothing Then
    '            TxtMa_xe.Text = DrReturn.Item("Ma_xe")
    '        Else
    '            TxtMa_xe.Text = ""
    '            Txtten_xe.Text = ""
    '            Exit Sub
    '        End If
    '    End Sub
    '#End Region
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
#Region "Vali --- Ma_BP"
    Private Sub V_Ma_BP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_BP.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_BP", "DmBP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_BP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_BP.Text = "" Then
            TxtTen_BP.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_BP.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_BP.Text = DrReturn.Item("Ma_BP")
            TxtTen_BP.Text = DrReturn.Item("Ten_BP")
        Else
            TxtMa_BP.Text = ""
            TxtTen_BP.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)

        '-----------------------------------------------------------------------------
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value

        Dim M_Ma_Post1_Filter As String = Me.CbbMa_Post1.SelectedValue.ToString.Trim
        Dim M_Ma_Post2_Filter As String = Me.CbbMa_post2.SelectedValue.ToString.Trim
        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Dim M_strParameterStore As String = Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & Me.Para(Me.VT_PARA + 3).Trim.ToUpper
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Bh.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtSo_ro.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Xe.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_KX.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & Txtma_kh.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Hs.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_BP.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Post1_Filter
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Post2_Filter
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
