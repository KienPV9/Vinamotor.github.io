Public Class Map_DMKH_NB_VAT
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim DtMuc As New DataTable
    Private Sub FDMBP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        CreateTable()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtTen_KH_NB.Focus()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Private Sub CreateTable()

    End Sub

#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then CyberSmodb.SetValueTObj(Me, Me.DrNew) Else CyberSmodb.SetValueTObj(Me, Me.DrOld)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        '--BP1
        RemoveHandler TxtMa_KH_NB.CyberValiting, AddressOf V_Nh_Bh1
        RemoveHandler TxtMa_KH_NB.CyberLeave, AddressOf L_Nh_Bh1
        AddHandler TxtMa_KH_NB.CyberValiting, AddressOf V_Nh_Bh1
        AddHandler TxtMa_KH_NB.CyberLeave, AddressOf L_Nh_Bh1
        '--BP2
        RemoveHandler TxtMa_KH_VAT.CyberValiting, AddressOf V_Nh_Bh2
        RemoveHandler TxtMa_KH_VAT.CyberLeave, AddressOf L_Nh_Bh2
        AddHandler TxtMa_KH_VAT.CyberValiting, AddressOf V_Nh_Bh2
        AddHandler TxtMa_KH_VAT.CyberLeave, AddressOf L_Nh_Bh2

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Nh_Bh1"
    Private Sub V_Nh_Bh1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_KH_NB.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "ma_kh", "dmkh", "1=1", "1=1")
    End Sub
    Private Sub L_Nh_Bh1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_KH_NB.GetRowsSelectData(True)
        If TxtMa_KH_NB.Text = "" Then
            TxtTen_KH_NB.Text = ""
            Exit Sub
        End If
        If Not DrReturn Is Nothing Then
            TxtMa_KH_NB.Text = DrReturn.Item("ma_kh")
            TxtTen_KH_NB.Text = DrReturn.Item("ten_kh")
        Else
            TxtMa_KH_NB.Text = ""
            TxtTen_KH_NB.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Bh2"
    Private Sub V_Nh_Bh2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_KH_VAT.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "ma_kh", "dmkh", "1=1", "1=1")
    End Sub
    Private Sub L_Nh_Bh2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_KH_VAT.Text = "" Then
            TxtTen_KH_VAT.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_KH_VAT.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_KH_VAT.Text = DrReturn.Item("ma_kh")
            TxtTen_KH_VAT.Text = DrReturn.Item("ten_kh")
        Else
            TxtMa_KH_VAT.Text = ""
            TxtTen_KH_VAT.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        'If Not _Value.Trim = "" Then TxtMa_BH.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
