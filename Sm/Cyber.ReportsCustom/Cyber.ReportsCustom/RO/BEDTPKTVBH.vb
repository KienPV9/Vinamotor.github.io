Public Class BEDTPKTVBH
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim _DtGetMaBC As DataTable
    Dim DtThang, DtNam As DataTable
    Private Sub BEDTPKTVBH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _DtGetMaBC = GetMaBC()
        V_Load()
        V_Addhander()
    End Sub
#Region "Load"
    Private Sub V_Load()
        CyberFill.V_FillComBoxDefaul(Me.cbbMa_BC, _DtGetMaBC, "Ma_BC", "Ten_BC", "Ngam_Dinh")
        V_AddMenuShorcut()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        DtThang = CreateTableMonth()

        DtNam = CreateTableYear()
        CyberFill.V_FillComBoxDefaul(CbbM_Thang, DtThang, "Thang", IIf(Me.LAN = "V", "Ten_Thang", "Ten_Thang2"), "Default")
        CyberFill.V_FillComBoxDefaul(CbbM_Nam, DtNam, "Nam", IIf(Me.LAN = "V", "Ten_Nam", "Ten_nam2"), "Default")
        '----Set
        'TxtM_Ngay_Ct1.Value = Now.Date
        'TxtM_Ngay_Ct2.Value = Now.Date
        'TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        'TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)
        If TxtMa_HS_H.Text.Trim = "" Then TxtTen_HS_H.Text = "" Else TxtTen_HS_H.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_HS", "DmHS", "( Ma_HS = N'" + TxtMa_HS_H.Text.Trim + "')", CyberSmLib)
        '----
        CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Function GetMaBC() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Ma_BC")
        _Return.Columns.Add("Ten_BC")
        _Return.Columns.Add("Ten_BC2")
        _Return.Columns.Add("Ngam_Dinh")
        _Return.Rows.Add("1", "Tất cả", "Tất cả", "1")
        _Return.Rows.Add("2", "Lệnh đã quyết toán", "Lệnh đã quyết toán", "2")
        _Return.Rows.Add("3", "Lệnh chưa quyết toán", "Lệnh chưa quyết toán", "3")
        GetMaBC = _Return
    End Function
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit

        '--Mau
        AddHandler TxtMa_HS_H.CyberValiting, AddressOf V_Ma_hs_h
        AddHandler TxtMa_HS_H.CyberLeave, AddressOf L_Ma_hs_h

    End Sub
#End Region
#Region "Valid"

#Region "Vali --- HS"
    Private Sub V_Ma_Hs_h(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_HS_H.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_HS", "Dmhs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Hs_h(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_HS_H.Text = "" Then
            TxtTen_HS_H.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_HS_H.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_HS_H.Text = DrReturn.Item("Ma_HS")
            TxtTen_HS_H.Text = DrReturn.Item("Ten_HS")
        Else
            TxtMa_HS_H.Text = ""
            TxtTen_HS_H.Text = ""
        End If
    End Sub
#End Region

#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------
        'Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        'Dim Dt2 As Date = TxtM_Ngay_Ct2.Value
        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        'Dim M_strParameterStore As String = Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        Dim M_strParameterStore = CbbM_Thang.SelectedValue.ToString.Trim & "#" & CbbM_Nam.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_HS_H.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & cbbMa_BC.SelectedValue.ToString.Trim
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
    Private Function CreateTableMonth() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Thang")
        _Return.Columns.Add("Ten_Thang")
        _Return.Columns.Add("Ten_Thang2")
        _Return.Columns.Add("Default")
        Dim _Thang As String = ""
        Dim _Default As String = "0"

        For i As Integer = 1 To 12
            _Thang = Strings.Right("00" + i.ToString.Trim, 2).Trim
            If Now.Date.Month = i Then
                _Default = "1"
            Else
                _Default = "0"
            End If
            _Return.Rows.Add(_Thang.ToString, "Tháng " + _Thang, "Month " + _Thang, _Default)
        Next
        CreateTableMonth = _Return
    End Function
    Private Function CreateTableYear() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Nam")
        _Return.Columns.Add("Ten_Nam")
        _Return.Columns.Add("Ten_Nam2")
        _Return.Columns.Add("Default")

        Dim _CurYear As Integer = Now.Year

        Dim _Nam As String = ""
        Dim _Default As String = "0"

        For i As Integer = _CurYear - 10 To _CurYear + 10
            _Nam = Strings.Right("0000" + i.ToString.Trim, 4).Trim

            If Now.Year = i Then
                _Default = "1"
            Else
                _Default = "0"
            End If
            _Return.Rows.Add(_Nam.ToString, "Năm " + _Nam, "Year " + _Nam, _Default)
        Next
        CreateTableYear = _Return
    End Function
End Class
