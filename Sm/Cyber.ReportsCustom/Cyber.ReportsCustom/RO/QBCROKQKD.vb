Public Class QBCROKQKD
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim _Dt_GD, _Dt_post1, _Dt_post2, _Dt_TT, _GroupByTH As DataTable
    Private Sub QBCROKQKD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_AddMenuShorcut()
        V_Load()
        V_Addhander()
    End Sub
#Region "Load"
    Private Sub V_Load()
        Dim _MA_CT As String = ""
        _MA_CT = Me.Para(Me.VT_PARA + 2).Trim

        '' đổ dữ liệu vào cbbmagd
        Dim _DsGroup As New DataSet
        _DsGroup = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetGD", _MA_CT)
        _Dt_GD = _DsGroup.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(Me.CbbMa_GD, _Dt_GD, "ma_gd", "Ten_gd")

        Dim _DsPost As New DataSet
        _DsPost = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetMaPostReports", _MA_CT & "##")
        _Dt_post1 = _DsPost.Tables(0).Copy
        _Dt_post2 = _DsPost.Tables(1).Copy

        CyberFill.V_FillComBoxDefaul(Me.CbbMa_Post1, _Dt_post1, "ma_post", "Ten_post")
        CyberFill.V_FillComBoxDefaul(Me.CbbMa_post2, _Dt_post2, "ma_post", "Ten_post")
        '--------------------------------------------------------------------
        _DsGroup = Nothing
        _DsGroup = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "SysNhapXuat" + "#" + "CP_NAME= N'HDK_HDM_HDP' AND Acti = N'1'" + "#" + "ID")
        _GroupByTH = _DsGroup.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(Me.CbbGroupByTH, _GroupByTH, "NHOM", "Ten_Nhom")
        '--------------------------------------------------------------------
        _DsGroup = Nothing
        _DsGroup = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "SysNhapXuat" + "#" + "CP_NAME= N'LOAI_TT' AND Acti = N'1'" + "#" + "ID")
        _Dt_TT = _DsGroup.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(Me.CbbMa_TT, _Dt_TT, "NHOM", "Ten_Nhom")

        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)

        '----Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date

        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)
        TxtMa_Kx.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Kx)
        TxtMa_vt.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_vt)

        TxtTen_kx.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_kx", "DmKx", "(Ma_kx = N'" + TxtMa_Kx.Text.Trim + "')", CyberSmLib)
        TxtTen_vt.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_Vt", "DmVt", "(Ma_Vt= N'" + TxtMa_vt.Text.Trim + "')", CyberSmLib)
        TxtNh_Vt1.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhVT", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_Vt1.Text.Trim + "')", CyberSmLib)
        TxtNh_Vt2.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhVT", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_Vt2.Text.Trim + "')", CyberSmLib)
        TxtNh_Vt3.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhVT", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_Vt3.Text.Trim + "')", CyberSmLib)
        '
        TxtMa_CV.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_CV)
        TxtMa_HD.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_HD)
        TxtMa_Bp.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Bp)
        TxtMa_Hs.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Hs)

        TxtTen_Cv.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_CV", "DmCv", "(Ma_CV= N'" + TxtMa_CV.Text.Trim + "')", CyberSmLib)
        TxtTen_HD.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_HD", "DmHD", "(Ma_HD= N'" + TxtMa_HD.Text.Trim + "')", CyberSmLib)
        TxtTen_Bp.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_BP", "DmBP", "(Ma_BP= N'" + TxtMa_Bp.Text.Trim + "')", CyberSmLib)
        TxtTen_Hs.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_HS", "DmHS", "(Ma_HS= N'" + TxtMa_Hs.Text.Trim + "')", CyberSmLib)

        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()

        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit

        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit

        '--ma khach hang
        AddHandler Txtma_kh.CyberValiting, AddressOf V_Ma_KH
        AddHandler Txtma_kh.CyberLeave, AddressOf L_Ma_KH
        '-- ma Vt
        AddHandler TxtMa_vt.CyberValiting, AddressOf V_Ma_vt
        AddHandler TxtMa_vt.CyberLeave, AddressOf L_Ma_vt

        '-- ma kho
        AddHandler TxtMa_Kx.CyberValiting, AddressOf V_Ma_kx
        AddHandler TxtMa_Kx.CyberLeave, AddressOf L_Ma_kx

        '-- nh_Vt1
        AddHandler TxtNh_Vt1.CyberValiting, AddressOf V_Nh_Vt1
        AddHandler TxtNh_Vt1.CyberLeave, AddressOf L_Nh_Vt1
        '-- nh_Vt2
        AddHandler TxtNh_Vt2.CyberValiting, AddressOf V_Nh_Vt2
        AddHandler TxtNh_Vt2.CyberLeave, AddressOf L_Nh_Vt2
        '-- nh_Vt3
        AddHandler TxtNh_Vt3.CyberValiting, AddressOf V_Nh_Vt3
        AddHandler TxtNh_Vt3.CyberLeave, AddressOf L_Nh_Vt3
        '-------------------------------------------------------------------
        '--Vv

        AddHandler TxtMa_CV.CyberValiting, AddressOf V_Ma_CV
        AddHandler TxtMa_CV.CyberLeave, AddressOf L_Ma_CV
        '--HD

        AddHandler TxtMa_HD.CyberValiting, AddressOf V_Ma_HD
        AddHandler TxtMa_HD.CyberLeave, AddressOf L_Ma_HD

        '--Bp

        AddHandler TxtMa_Bp.CyberValiting, AddressOf V_Ma_Bp
        AddHandler TxtMa_Bp.CyberLeave, AddressOf L_Ma_Bp

        '--Hs

        AddHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        AddHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs

    End Sub

#End Region
#Region "Valid"
#Region "Valid --- Ma_kx"
    Private Sub V_Ma_kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Kx.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_kx", "DmKx", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Kx.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kx.Text = DrReturn.Item("Ma_kx")
            TxtTen_kx.Text = DrReturn.Item("Ten_kx")
        Else
            TxtMa_Kx.Text = ""
            TxtTen_kx.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
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
#Region "Vali --- Ma_Bp"
    Private Sub V_Ma_Bp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Bp.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Bp", "DmBp", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Bp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Bp.Text = "" Then
            TxtTen_Bp.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Bp.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Bp.Text = DrReturn.Item("Ma_Bp")
            TxtTen_Bp.Text = DrReturn.Item("Ten_Bp")
        Else
            TxtMa_Bp.Text = ""
            TxtTen_Bp.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_HD"
    Private Sub V_Ma_HD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_HD.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_HD", "DmHD", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_HD.Text = "" Then
            TxtTen_HD.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_HD.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_HD.Text = DrReturn.Item("Ma_HD")
            TxtTen_HD.Text = DrReturn.Item("Ten_HD")
        Else
            TxtMa_HD.Text = ""
            TxtTen_HD.Text = ""
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
            txtten_kh.Text = DrReturn.Item("Ten_Kh")
        Else
            Txtma_kh.Text = ""
            txtten_kh.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_vt"
    Private Sub V_Ma_vt(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_vt.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_vt", "Dmvt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_vt(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_vt.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_vt.Text = DrReturn.Item("Ma_vt")
            TxtTen_vt.Text = DrReturn.Item("Ten_vt")
        Else
            TxtMa_vt.Text = ""
            TxtTen_vt.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Nh_Vt1"
    Private Sub V_Nh_Vt1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Vt1.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "ma_nh", "DmnhVt", "1=1", "loai_nh='1'")
    End Sub
    Private Sub L_Nh_Vt1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_Vt1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Vt1.Text = DrReturn.Item("ma_nh")
            TxtTen_Nh_Vt1.Text = DrReturn.Item("Ten_nh")
        Else
            TxtNh_Vt1.Text = ""
            TxtTen_Nh_Vt1.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Nh_Vt2"
    Private Sub V_Nh_Vt2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Vt2.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "ma_nh", "DmnhVt", "1=1", "loai_nh='2'")
    End Sub
    Private Sub L_Nh_Vt2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_Vt2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Vt2.Text = DrReturn.Item("ma_nh")
            TxtTen_Nh_Vt2.Text = DrReturn.Item("Ten_nh")
        Else
            TxtNh_Vt2.Text = ""
            TxtTen_Nh_Vt2.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Nh_Vt3"
    Private Sub V_Nh_Vt3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Vt3.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "ma_nh", "DmnhVt", "1=1", "loai_nh='3'")
    End Sub
    Private Sub L_Nh_Vt3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_Vt3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Vt3.Text = DrReturn.Item("ma_nh")
            TxtTen_Nh_Vt3.Text = DrReturn.Item("Ten_nh")
        Else
            TxtNh_Vt3.Text = ""
            TxtTen_Nh_Vt3.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Vali --- Ma_CV"
    Private Sub V_Ma_CV(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_CV.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_CV", "DmCv", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_CV(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_CV.Text = "" Then
            TxtTen_Cv.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_CV.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_CV.Text = DrReturn.Item("Ma_CV")
            TxtTen_Cv.Text = DrReturn.Item("Ten_CV")
        Else
            TxtMa_CV.Text = ""
            TxtTen_Cv.Text = ""
        End If
    End Sub
#End Region

#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------
        'If CyberMe.V_GetValueCombox(CbbGroupByTH).ToString.Trim = "" Then
        '    MsgBox("Chưa chọn loại lệnh", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Me.sysvar("M_CYBER_VER"))
        '    CbbGroupByTH.Focus()
        '    Exit Sub
        'End If

        '-----------------------------------------------------------------------------
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value
        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim

        Dim M_strParameterStore As String 'Me.Para(Me.VT_PARA + 2).Trim()

        M_strParameterStore = Me.CbbGroupByTH.SelectedValue.ToString.Trim()
        M_strParameterStore = M_strParameterStore & "#" & CyberMe.V_GetValueCombox(CbbMa_GD)
        M_strParameterStore = M_strParameterStore & "#" & Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & CbbMa_TT.SelectedValue.ToString.Trim()
        M_strParameterStore = M_strParameterStore & "#" & TxtSo_RO.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & txtMa_xe.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Kx.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Hs.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Bp.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_HD.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & Txtma_kh.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & CyberMe.V_GetValueCombox(CbbMa_Post1)
        M_strParameterStore = M_strParameterStore & "#" & CyberMe.V_GetValueCombox(CbbMa_post2)
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_vt.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Vt1.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Vt2.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Vt3.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_CV.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & IIf(ChkCV.Checked = True, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & IIf(ChkVT.Checked = True, "1", "0")
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
