﻿Public Class DMVV
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FDMVV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtNgay_Vv1.Value = Now.Date
        TxtNgay_Vv2.Value = Now.Date
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        TxtMa_Vv.Focus()
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupGL.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_Vv, TxtNh_Vv1, TxtNh_Vv2, TxtNh_Vv3, TxtNh_Vv4, TxtNh_Vv5)
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()

        If TxtNh_Vv1.Text.Trim = "" Then TxtTen_Nh1.Text = "" Else TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhVv", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_Vv1.Text.Trim + "')", CyberSmlib)
        If TxtNh_Vv2.Text.Trim = "" Then TxtTen_Nh2.Text = "" Else TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhVv", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_Vv2.Text.Trim + "')", CyberSmlib)
        If TxtNh_Vv3.Text.Trim = "" Then TxtTen_Nh3.Text = "" Else TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhVv", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_Vv3.Text.Trim + "')", CyberSmlib)
        If TxtNh_Vv4.Text.Trim = "" Then TxtTen_Nh4.Text = "" Else TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhVv", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_Vv4.Text.Trim + "')", CyberSmlib)
        If TxtNh_Vv5.Text.Trim = "" Then TxtTen_Nh5.Text = "" Else TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhVv", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_Vv5.Text.Trim + "')", CyberSmlib)

        If TxtMa_KH.Text.Trim.Trim = "" Then TxtTen_KH.Text = "" Else TxtTen_KH.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_kh", "Dmkh", "(Ma_kh = N'" + TxtMa_KH.Text.Trim + "')", CyberSmlib)
        If TxtMa_BpKD.Text.Trim = "" Then TxtTen_BpKD.Text = "" Else TxtTen_BpKD.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_bp", "Dmbp", "(Ma_Bp = N'" + TxtMa_BpKD.Text.Trim + "')", CyberSmlib)
        If TxtMa_HSKD.Text.Trim = "" Then TxtTen_HSKD.Text = "" Else TxtTen_HSKD.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_hs", "Dmhs", "(Ma_hs = N'" + TxtMa_HSKD.Text.Trim + "')", CyberSmlib)
        If Txtma_BpTH.Text.Trim = "" Then TxtTen_BpTH.Text = "" Else TxtTen_BpTH.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_bp", "Dmbp", "(Ma_bp = N'" + Txtma_BpTH.Text.Trim + "')", CyberSmlib)
        If TxtMa_HSTH.Text.Trim = "" Then TxtTen_HSTH.Text = "" Else TxtTen_HSTH.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_hs", "Dmhs", "(Ma_hs = N'" + TxtMa_HSTH.Text.Trim + "')", CyberSmlib)



        Dim Dt1 As Date = TxtNgay_Vv1.Value
        Dim Dt2 As Date = TxtNgay_Vv1.Value
        If Dt1.ToString("yyyyMMdd").Trim = "19000101" Then TxtNgay_Vv1.Value = Now.Date
        If Dt2.ToString("yyyyMMdd").Trim = "19000101" Then TxtNgay_Vv2.Value = Now.Date

    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_Vv.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_Vv.KeyPress, AddressOf TxtCodeError_KeyPress
        '--Vv1
        RemoveHandler TxtNh_Vv1.CyberValiting, AddressOf V_NH_Vv1
        RemoveHandler TxtNh_Vv1.CyberLeave, AddressOf L_NH_Vv1
        AddHandler TxtNh_Vv1.CyberValiting, AddressOf V_NH_Vv1
        AddHandler TxtNh_Vv1.CyberLeave, AddressOf L_NH_Vv1
        '--Vv2
        RemoveHandler TxtNh_Vv2.CyberValiting, AddressOf V_NH_Vv2
        RemoveHandler TxtNh_Vv2.CyberLeave, AddressOf L_NH_Vv2
        AddHandler TxtNh_Vv2.CyberValiting, AddressOf V_NH_Vv2
        AddHandler TxtNh_Vv2.CyberLeave, AddressOf L_NH_Vv2
        '--Vv3
        RemoveHandler TxtNh_Vv3.CyberValiting, AddressOf V_NH_Vv3
        RemoveHandler TxtNh_Vv3.CyberLeave, AddressOf L_NH_Vv3
        AddHandler TxtNh_Vv3.CyberValiting, AddressOf V_NH_Vv3
        AddHandler TxtNh_Vv3.CyberLeave, AddressOf L_NH_Vv3
        '--Vv4
        RemoveHandler TxtNh_Vv4.CyberValiting, AddressOf V_NH_Vv4
        RemoveHandler TxtNh_Vv4.CyberLeave, AddressOf L_NH_Vv4
        AddHandler TxtNh_Vv4.CyberValiting, AddressOf V_NH_Vv4
        AddHandler TxtNh_Vv4.CyberLeave, AddressOf L_NH_Vv4
        '--Vv5
        RemoveHandler TxtNh_Vv5.CyberValiting, AddressOf V_NH_Vv5
        RemoveHandler TxtNh_Vv5.CyberLeave, AddressOf L_NH_Vv5
        AddHandler TxtNh_Vv5.CyberValiting, AddressOf V_NH_Vv5
        AddHandler TxtNh_Vv5.CyberLeave, AddressOf L_NH_Vv5
        '--MA_KH
        RemoveHandler TxtMa_KH.CyberValiting, AddressOf V_Ma_KH
        RemoveHandler TxtMa_KH.CyberLeave, AddressOf L_Ma_KH
        AddHandler TxtMa_KH.CyberValiting, AddressOf V_Ma_KH
        AddHandler TxtMa_KH.CyberLeave, AddressOf L_Ma_KH
        '--MA_BPKD
        RemoveHandler TxtMa_BpKD.CyberValiting, AddressOf V_Ma_BPKD
        RemoveHandler TxtMa_BpKD.CyberLeave, AddressOf L_Ma_BPKD
        AddHandler TxtMa_BpKD.CyberValiting, AddressOf V_Ma_BPKD
        AddHandler TxtMa_BpKD.CyberLeave, AddressOf L_Ma_BPKD
        '--MA_HSKD
        RemoveHandler TxtMa_HSKD.CyberValiting, AddressOf V_MA_HSKD
        RemoveHandler TxtMa_HSKD.CyberLeave, AddressOf L_MA_HSKD
        AddHandler TxtMa_HSKD.CyberValiting, AddressOf V_MA_HSKD
        AddHandler TxtMa_HSKD.CyberLeave, AddressOf L_MA_HSKD
        '--MA_BPTH
        RemoveHandler Txtma_BpTH.CyberValiting, AddressOf V_MA_BPTH
        RemoveHandler Txtma_BpTH.CyberLeave, AddressOf L_MA_BPTH
        AddHandler Txtma_BpTH.CyberValiting, AddressOf V_MA_BPTH
        AddHandler Txtma_BpTH.CyberLeave, AddressOf L_MA_BPTH
        '--MA_HSTH
        RemoveHandler TxtMa_HSTH.CyberValiting, AddressOf V_MA_HSTH
        RemoveHandler TxtMa_HSTH.CyberLeave, AddressOf L_MA_HSTH
        AddHandler TxtMa_HSTH.CyberValiting, AddressOf V_MA_HSTH
        AddHandler TxtMa_HSTH.CyberLeave, AddressOf L_MA_HSTH
        '--MA_NT
        RemoveHandler TxtMa_NT.CyberValiting, AddressOf V_MA_NT
        RemoveHandler TxtMa_NT.CyberLeave, AddressOf L_MA_NT
        AddHandler TxtMa_NT.CyberValiting, AddressOf V_MA_NT
        AddHandler TxtMa_NT.CyberLeave, AddressOf L_MA_NT
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- NH_Vv1"
    Private Sub V_NH_Vv1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Vv1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhVv", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_Vv1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_Vv1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Vv1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Vv1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_Vv2"
    Private Sub V_NH_Vv2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Vv2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhVv", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_Vv2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_Vv2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Vv2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Vv2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_Vv3"
    Private Sub V_NH_Vv3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Vv3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhVv", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_Vv3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_Vv3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Vv3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Vv3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_Vv4"
    Private Sub V_NH_Vv4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Vv4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhVv", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_NH_Vv4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_Vv4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Vv4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Vv4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_Vv5"
    Private Sub V_NH_Vv5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Vv5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhVv", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_NH_Vv5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_Vv5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Vv5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Vv5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_KH"
    Private Sub V_Ma_KH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_KH.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_kh", "DmKh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_KH.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_KH.Text = DrReturn.Item("Ma_KH")
            TxtTen_KH.Text = DrReturn.Item("Ten_KH")
        Else
            TxtMa_KH.Text = ""
            TxtTen_KH.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_BPKD"
    Private Sub V_Ma_BPKD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_BpKD.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_BP", "DMBP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_BPKD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_BpKD.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_BpKD.Text = DrReturn.Item("Ma_BP")
            TxtTen_BpKD.Text = DrReturn.Item("Ten_BP")
        Else
            TxtMa_BpKD.Text = ""
            TxtTen_BpKD.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- MA_HSKD"
    Private Sub V_MA_HSKD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_HSKD.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_HS", "DMHS", "1=1", "1=1")
    End Sub
    Private Sub L_MA_HSKD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_HSKD.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_HSKD.Text = DrReturn.Item("Ma_HS")
            TxtTen_HSKD.Text = DrReturn.Item("Ten_HS")
        Else
            TxtMa_HSKD.Text = ""
            TxtTen_HSKD.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- MA_BPTH"
    Private Sub V_MA_BPTH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Txtma_BpTH.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_BP", "DMBP", "1=1", "1=1")
    End Sub
    Private Sub L_MA_BPTH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = Txtma_BpTH.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            Txtma_BpTH.Text = DrReturn.Item("Ma_BP")
            TxtTen_BpTH.Text = DrReturn.Item("Ten_BP")
        Else
            Txtma_BpTH.Text = ""
            TxtTen_BpTH.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- MA_HSTH"
    Private Sub V_MA_HSTH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_HSTH.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_HS", "DMHS", "1=1", "1=1")
    End Sub
    Private Sub L_MA_HSTH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_HSTH.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_HSTH.Text = DrReturn.Item("Ma_HS")
            TxtTen_HSTH.Text = DrReturn.Item("Ten_HS")
        Else
            TxtMa_HSTH.Text = ""
            TxtTen_HSTH.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- MA_NT"
    Private Sub V_MA_NT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_NT.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NT", "DMNT", "1=1", "1=1")
    End Sub
    Private Sub L_MA_NT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_NT.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_NT.Text = DrReturn.Item("Ma_NT")
        Else
            TxtMa_NT.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
      Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_Vv.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
