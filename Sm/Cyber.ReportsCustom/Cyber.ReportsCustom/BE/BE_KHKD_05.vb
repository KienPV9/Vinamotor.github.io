Public Class BE_KHKD_05
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim _DtLoai_Phieu, _DtGroup, _DtGroupct, _DtMa_TT As DataTable
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim M_Ma_Ct As String = "DT0"
    Dim M_Loai_TH As String = "0"
    Dim CyberVoucher As New Cyber.Voucher.Sys
    Private Sub SysDateToDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_AddMenuShorcut()
        ChkIs_All.Checked = True
        ChkIs_C.Checked = False
        ChkIs_I.Checked = False
        ChkIs_W.Checked = False
        ChkIs_N.Checked = False

        V_Load()
        V_Addhander()
        V_LoadMa_GD(New System.Object, New System.EventArgs)
    End Sub
#Region "Load"
#Region "Chi tiet theo"
#End Region
    Private Sub V_Load()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '--------------------------------------------------------------------

        Dim _DsMa_TT As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "SysNhapXuat#CP_NAME= N'LOAI_TT' AND Acti = N'1'#ID")
        _DtMa_TT = _DsMa_TT.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(Me.Ma_TT, _DtMa_TT, "Nhom", "Ten_nhom")

        '--------------------------------------------------------------------
        '--loai lenh
        Dim _DsLoai_Phieu As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "SysNhapXuat#CP_NAME= N'HDM_HDI' AND Acti = N'1'#ID")
        _DtLoai_Phieu = _DsLoai_Phieu.Tables(0).Copy
        _DsLoai_Phieu.Dispose()
        '--------------------------------------------------------------------
        '----Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)

        TxtMa_Hs.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Hs)
        If TxtMa_Hs.Text.Trim = "" Then TxtTen_Hs.Text = "" Else TxtTen_Hs.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_HS", "vTVBH", "(Ma_HS= N'" + TxtMa_Hs.Text.Trim + "')", CyberSmLib)

        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
        '
        '-- ma HS
        AddHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        AddHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs


        AddHandler ChkIs_All.Click, AddressOf V_Is_All
        AddHandler ChkIs_C.Click, AddressOf V_Ma_TT
        AddHandler ChkIs_I.Click, AddressOf V_Ma_TT
        AddHandler ChkIs_N.Click, AddressOf V_Ma_TT
        AddHandler ChkIs_W.Click, AddressOf V_Ma_TT

    End Sub
    Private Sub V_Is_All(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ChkIs_All.Checked Then
            ChkIs_C.Checked = False
            ChkIs_I.Checked = False
            ChkIs_N.Checked = False
            ChkIs_W.Checked = False
        Else
            If Not ChkIs_C.Checked And Not ChkIs_I.Checked And Not ChkIs_N.Checked And Not ChkIs_W.Checked Then
                ChkIs_C.Checked = True
            End If
        End If
    End Sub
    Private Sub V_Ma_TT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not ChkIs_C.Checked And Not ChkIs_I.Checked And Not ChkIs_N.Checked And Not ChkIs_W.Checked Then
            ChkIs_C.Checked = True
        End If
        ChkIs_All.Checked = False
        'If ChkIs_C.Checked And ChkIs_I.Checked And ChkIs_N.Checked And ChkIs_W.Checked Then
        '    ChkIs_All.Checked = False
        'End If
    End Sub

    Private Sub V_LoadMa_GD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ma_Ct As String = ""
        Try
        Catch ex As Exception
        End Try
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Ma_Hs"
    Private Sub V_Ma_Hs(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Hs.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Hs", "vTVBH", "1=1", "1=1")
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
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------
        '-----------------------------------------------------------------------------
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value

        Dim M_Ma_TT_Filter As String = Me.Ma_TT.SelectedValue.ToString.Trim
        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim

        Dim M_strParameterStore As String = Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & IIf(ChkIs_All.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & IIf(ChkIs_C.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & IIf(ChkIs_I.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & IIf(ChkIs_N.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & IIf(ChkIs_W.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Hs.Text.Trim
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
