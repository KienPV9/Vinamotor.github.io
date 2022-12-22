Public Class DmLuongcty
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FDMBP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        'Cyber.ListGroupCustom.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_Nv)
        TxtMa_NV.Focus()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()

        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        If TxtMa_NV.Text.Trim = "" Then TxtTen_hs.Text = "" Else TxtTen_hs.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_hs", "Dmhs", "(Ma_hs = N'" + TxtMa_NV.Text.Trim + "')", CyberSmlib)

    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_Nv.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_Nv.KeyPress, AddressOf TxtCodeError_KeyPress

        AddHandler TxtMa_NV.CyberValiting, AddressOf V_Ma_nv
        AddHandler TxtMa_NV.CyberLeave, AddressOf L_Ma_nv

    End Sub
#Region "Vali --- Ma_BP"
    Private Sub V_Ma_nv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_hs", "Dmhs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_nv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_NV.Text = DrReturn.Item("Ma_hs")
            TxtTen_hs.Text = DrReturn.Item("Ten_hs")
        Else
            TxtMa_NV.Text = ""
            TxtTen_hs.Text = ""
        End If
    End Sub
#End Region
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region

#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi luu du lieu vao truong trinh viet vao day
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_Nv.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub


#End Region
End Class
