Public Class GLTC2
    Dim CyberMe As New Cyber.Reports.Sys
    Dim DtDmMauBc As DataTable
    Dim _DsTmp As DataSet

    Private Sub GLTC2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DtDmMauBc = CyberSmodb.OpenTableKey(AppConn, _DsTmp, "DmMauBC", "FILE_MauBC", "Acti=N'1' AND Ma_mauBc =N'GLTC2'", CyberSmLib)
        'CyberFill.V_FillComBoxValue(Me.CbbDmMauBc, DtDmMauBc, "File_MauBC", IIf(Me.LAN = "V", "Ten_mauBC", "Ten_MauBc2"), "")
        CyberFill.V_FillComBoxDefaul(Me.CbbDmMauBc, DtDmMauBc, "File_MauBC", IIf(Me.LAN = "V", "Ten_mauBC", "Ten_MauBc2"), "Ngam_Dinh")

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
        TxtM_Ngay_CT3.Value = Now.Date
        TxtM_Ngay_CT4.Value = Now.Date

        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)

        TxtM_Ngay_CT3.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_CT3)
        TxtM_Ngay_CT4.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_CT4)


        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
    End Sub
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value
        Dim Dt3 As Date = TxtM_Ngay_CT3.Value
        Dim Dt4 As Date = TxtM_Ngay_CT4.Value

        Dim _MauBc As String = ""
        Try
            _MauBc = CbbDmMauBc.SelectedValue.ToString.Trim()
        Catch ex As Exception
        End Try
        If _MauBc.Trim = "" Then
            CbbDmMauBc.Focus()
            Exit Sub
        End If

        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim

        Dim M_strParameterStore As String = Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & Dt3.ToString("yyyyMMdd") & "#" & Dt4.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & _MauBc.Trim
        M_strParameterStore = M_strParameterStore & "#" & ""
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
