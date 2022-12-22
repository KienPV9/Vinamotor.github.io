Public Class DMHHXE
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

        TxtTen_Kx.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_KX", "dmkx", "(Ma_KX = N'" + TxtMa_Kx.Text.Trim + "')", CyberSmlib)
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        '--KH1
        RemoveHandler TxtMa_Kx.CyberValiting, AddressOf V_Ma_Kx
        RemoveHandler TxtMa_Kx.CyberLeave, AddressOf L_Ma_KX
        AddHandler TxtMa_Kx.CyberValiting, AddressOf V_Ma_Kx
        AddHandler TxtMa_Kx.CyberLeave, AddressOf L_Ma_KX
        'AddHandler TxtNh_VT4.CyberLeave, AddressOf L_NH_VT4
        'AddHandler TxtNh_VT4.CyberValiting, AddressOf V_NH_VT4
        'AddHandler TxtNh_VT5.CyberLeave, AddressOf L_NH_VT5
        'AddHandler TxtNh_VT5.CyberValiting, AddressOf V_NH_VT5
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub

#End Region
#Region "Valid"
    Private Sub V_Ma_Kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Kx.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Kx", "DmKX", "1=1", "1='1'")
    End Sub
    Private Sub L_Ma_KX(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Kx.Text = "" Then
            TxtTen_Kx.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kx.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kx.Text = DrReturn.Item("Ma_Kx")
            TxtTen_Kx.Text = DrReturn.Item("Ten_kx")
        Else
            TxtMa_Kx.Text = ""
            TxtTen_Kx.Text = ""
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
