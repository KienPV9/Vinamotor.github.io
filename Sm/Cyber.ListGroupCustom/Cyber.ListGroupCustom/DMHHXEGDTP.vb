Public Class DMHHXEGDTP
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub DMDKCK_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        'Cyber.ListGroupCustom.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_KU, TxtNh_KU1, TxtNh_KU2, TxtNh_KU3, TxtNh_KU4, TxtNh_KU5)
        TxtNgay_HL.Focus()
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then
            TxtNgay_HL.Value = Now.Date

            TxtMa_Dvcs.Text = M_Ma_Dvcs
        End If

        TxtTen_Nh_Hs4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_KX", "dmkx", "(Ma_KX = N'" + TxtNh_HS4.Text.Trim + "')", CyberSmlib)
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        '--KH1
        RemoveHandler TxtNh_HS4.CyberValiting, AddressOf V_Nh_Hs4
        RemoveHandler TxtNh_HS4.CyberLeave, AddressOf L_Nh_Hs4
        AddHandler TxtNh_HS4.CyberValiting, AddressOf V_Nh_Hs4
        AddHandler TxtNh_HS4.CyberLeave, AddressOf L_Nh_Hs4

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub

#End Region
#Region "Valid"
    Private Sub V_Nh_Hs4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_HS4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhHS", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_Nh_Hs4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_HS4.Text = "" Then
            TxtTen_Nh_Hs4.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_HS4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_HS4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh_Hs4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_HS4.Text = ""
            TxtTen_Nh_Hs4.Text = ""
        End If
    End Sub
#End Region



#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        'If Not _Value.Trim = "" Then TxtMa_KU.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
