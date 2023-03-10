Public Class DMHH_LHBH
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub DMHH_LHBH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtMa_BH.Focus()
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then
            ChkXe_moi.Checked = True
            TxtMa_Dvcs.Text = M_Ma_Dvcs
            TxtNgay_hl.Value = Now.Date
        End If
        TxtTen_BH.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_BH", "DmBH", "(Ma_BH = N'" + TxtMa_BH.Text.Trim + "')", CyberSmlib)
        TxtTen_LHBH.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_LHBH", "DmLHBH", "(Ma_LHBH = N'" + TxtMa_LHBH.Text.Trim + "')", CyberSmlib)
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        '-Ma_VT
        RemoveHandler TxtMa_BH.CyberValiting, AddressOf V_Ma_BH
        RemoveHandler TxtMa_BH.CyberLeave, AddressOf L_Ma_BH
        AddHandler TxtMa_BH.CyberValiting, AddressOf V_Ma_BH
        AddHandler TxtMa_BH.CyberLeave, AddressOf L_Ma_BH

        '-Ma_Kho
        RemoveHandler TxtMa_LHBH.CyberValiting, AddressOf V_Ma_LHBH
        RemoveHandler TxtMa_LHBH.CyberLeave, AddressOf L_Ma_LHBH
        AddHandler TxtMa_LHBH.CyberValiting, AddressOf V_Ma_LHBH
        AddHandler TxtMa_LHBH.CyberLeave, AddressOf L_Ma_LHBH

        RemoveHandler TxtMa_BH.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_BH.KeyPress, AddressOf TxtCodeError_KeyPress
        '
        RemoveHandler TxtNh_kx.CyberValiting, AddressOf V_kx
        RemoveHandler TxtNh_kx.CyberLeave, AddressOf L_kx
        AddHandler TxtNh_kx.CyberValiting, AddressOf V_kx
        AddHandler TxtNh_kx.CyberLeave, AddressOf L_kx

    End Sub
#Region "Vali --- V_kx"
    Private Sub V_kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_kx.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_nh", "DMNHKX", "Loai_nh =1", "1=1")
    End Sub
    Private Sub L_kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_kx.Text = "" Then
            TxtTen_nh.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_kx.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_kx.Text = DrReturn.Item("Ma_nh")
            TxtTen_nh.Text = DrReturn.Item("Ten_nh")
        Else
            TxtNh_kx.Text = ""
            TxtTen_nh.Text = ""
        End If
    End Sub
#End Region
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()

    End Sub
#End Region
#Region "Vali --- Ma_BH"
    Private Sub V_Ma_BH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_BH.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_BH", "DmBH", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_BH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_BH.Text = "" Then
            TxtTen_BH.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_BH.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_BH.Text = DrReturn.Item("Ma_BH")
            TxtTen_BH.Text = DrReturn.Item("Ten_BH")
        Else
            TxtMa_BH.Text = ""
            TxtTen_BH.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_LHBH"
    Private Sub V_Ma_LHBH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_LHBH.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_LHBH", "DmLHBH", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_LHBH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_LHBH.Text = "" Then
            TxtTen_LHBH.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_LHBH.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_LHBH.Text = DrReturn.Item("Ma_LHBH")
            TxtTen_LHBH.Text = DrReturn.Item("Ten_LHBH")
        Else
            TxtMa_LHBH.Text = ""
            TxtTen_LHBH.Text = ""
        End If
    End Sub
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)
        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region

    Private Sub ChkXe_moi_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkXe_moi.CheckedChanged
        If ChkXe_moi.Checked = True Then
            ChkXe_taitung.Checked = False
        End If
    End Sub

    Private Sub ChkXe_taitung_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkXe_taitung.CheckedChanged
        If ChkXe_taitung.Checked = True Then
            ChkXe_moi.Checked = False
        End If
    End Sub
End Class
