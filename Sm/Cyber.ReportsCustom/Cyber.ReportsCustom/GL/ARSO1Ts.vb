Public Class ARSO1Ts
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Private Sub ARSO1Ts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChkM_GROUP.Checked = True
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
        TxtMa_kh.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_kh)

        Try
            TxtM_Tk_CN.Text = Me.Para(Me.VT_PARA + 2).ToString.Trim
        Catch ex As Exception

        End Try
        If TxtM_Tk_CN.Text.Trim = "" Then TxtM_Tk_CN.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtM_Tk_CN)
        If TxtM_Tk_CN.Text.Trim = "" Then Txtten_Tk_CN.Text = "" Else Txtten_Tk_CN.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Tk0", "Dmtk0", "Tk0 = N'" + TxtM_Tk_CN.Text.Trim + "'", CyberSmLib)

        '----
        CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
        '--TK
        AddHandler TxtM_Tk_CN.CyberValiting, AddressOf V_Tk
        AddHandler TxtM_Tk_CN.CyberLeave, AddressOf L_Tk
        '-- Chọn list tài khoản
        AddHandler CmdV_Ma_KH.Click, AddressOf V_Ma_KH_List
    End Sub
#End Region
#Region "Valid"
#Region "Valid --- Tk"
    Private Sub V_Tk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtM_Tk_CN.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Tk", "DmTKCN", "1=1", "1=1")
    End Sub
    Private Sub L_Tk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtM_Tk_CN.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtM_Tk_CN.Text = DrReturn.Item("Tk")
            Txtten_Tk_CN.Text = DrReturn.Item("Ten_TK")
        Else
            TxtM_Tk_CN.Text = ""
            Txtten_Tk_CN.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_KH"
#End Region
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtM_Tk_CN.Text.Trim = "" Then
            TxtM_Tk_CN.Focus()
            Exit Sub
        End If
        'If TxtM_Ma_kh.Text.Trim = "" Then
        '    TxtM_Ma_kh.Focus()
        '    Exit Sub
        'End If
        '-----------------------------------------------------------------------------
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value
        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Dim M_strParameterStore As String = TxtM_Tk_CN.Text.Trim.Replace("#", "")
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_kh.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & If(ChkM_GROUP.Checked, "1", "0")
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
#Region "Valid --- Danh sách khách hàng"
    Private Sub V_Ma_KH_List(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim str As String
        str = CyberSupport.V_GetStrSelectList(AppConn, Me.sysvar, Para, "CP_GetListSelect", "DMKH#" & TxtMa_kh.Text.Trim & "#" & "" & "#" & Ma_Dvcs & "#" & User_Name, LAN)
        If str Is Nothing Then Exit Sub
        TxtMa_Kh.Text = str
    End Sub
#End Region
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
