Public Class ROVIP01
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim _Dt_GD, _Dt_post1, _Dt_post2, _Dt_TT, _GroupByTH As DataTable
    Private Sub ROVIP01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_AddMenuShorcut()
        V_Load()
        V_Addhander()
    End Sub
#Region "Load"
    Private Sub V_Load()
        'Dim _MA_CT As String = ""
        '_MA_CT = Me.Para(Me.VT_PARA + 2).Trim

        '' đổ dữ liệu vào cbbmagd
        'Dim _DsGroup As New DataSet
        '_DsGroup = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetGD", _MA_CT)
        '_Dt_GD = _DsGroup.Tables(0).Copy
        ''CyberFill.V_FillComBoxDefaul(Me.CbbMa_GD, _Dt_GD, "ma_gd", "Ten_gd")

        'Dim _DsPost As New DataSet
        '_DsPost = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetMaPostReports", _MA_CT & "##")
        '_Dt_post1 = _DsPost.Tables(0).Copy
        '_Dt_post2 = _DsPost.Tables(1).Copy

        ''--------------------------------------------------------------------
        '_DsGroup = Nothing
        '_DsGroup = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "SysNhapXuat" + "#" + "CP_NAME= N'HDK_HDM_HDP' AND Acti = N'1'" + "#" + "ID")
        '_GroupByTH = _DsGroup.Tables(0).Copy
        ''CyberFill.V_FillComBoxDefaul(Me.CbbGroupByTH, _GroupByTH, "NHOM", "Ten_Nhom")
        '--------------------------------------------------------------------
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)

        '----Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date

        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)

        TxtMa_The.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_The)

        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()

        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit

        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit

        '--Hs
        AddHandler TxtMa_The.CyberValiting, AddressOf V_Ma_The
        AddHandler TxtMa_The.CyberLeave, AddressOf L_Ma_The

    End Sub

#End Region
#Region "Valid"
#Region "Vali --- Ma_The"
    Private Sub V_Ma_The(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_The.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_The", "DmTheVip", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_The(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_The.Text = "" Then
            Exit Sub
        End If
        DrReturn = TxtMa_The.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_The.Text = DrReturn.Item("Ma_The")
        Else
            TxtMa_The.Text = ""
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

        Dim M_strParameterStore As String 'Me.Para(Me.VT_PARA + 2).Trim()

        'M_strParameterStore = Me.CbbGroupByTH.SelectedValue.ToString.Trim()
        'M_strParameterStore = M_strParameterStore & "#" & CyberMe.V_GetValueCombox(CbbMa_GD)
        M_strParameterStore = Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        'M_strParameterStore = M_strParameterStore & "#" & txtSo_RO.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & txtMa_xe.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_The.Text.Trim
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
