Public Class Map_DMTK_NB_VAT
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim DtMuc As New DataTable
    Private Sub FDMBP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        CreateTable()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtTen_TK_NB.Focus()
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
        RemoveHandler TxtTK_NB.CyberValiting, AddressOf V_Nh_Bh1
        RemoveHandler TxtTK_NB.CyberLeave, AddressOf L_Nh_Bh1
        AddHandler TxtTK_NB.CyberValiting, AddressOf V_Nh_Bh1
        AddHandler TxtTK_NB.CyberLeave, AddressOf L_Nh_Bh1
        '--BP2
        RemoveHandler TxtTK_VAT.CyberValiting, AddressOf V_Nh_Bh2
        RemoveHandler TxtTK_VAT.CyberLeave, AddressOf L_Nh_Bh2
        AddHandler TxtTK_VAT.CyberValiting, AddressOf V_Nh_Bh2
        AddHandler TxtTK_VAT.CyberLeave, AddressOf L_Nh_Bh2

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Nh_Bh1"
    Private Sub V_Nh_Bh1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTK_NB.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Tk0", "DmTk0", "1=1", "1=1")
    End Sub
    Private Sub L_Nh_Bh1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtTK_NB.GetRowsSelectData(True)
        If TxtTK_NB.Text = "" Then
            TxtTen_TK_NB.Text = ""
            Exit Sub
        End If
        If Not DrReturn Is Nothing Then
            TxtTK_NB.Text = DrReturn.Item("Tk0")
            TxtTen_TK_NB.Text = DrReturn.Item("Ten_Tk0")
        Else
            TxtTK_NB.Text = ""
            TxtTen_TK_NB.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Bh2"
    Private Sub V_Nh_Bh2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTK_VAT.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Tk0", "DmTk0", "1=1", "1=1")
    End Sub
    Private Sub L_Nh_Bh2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTK_VAT.Text = "" Then
            TxtTen_TK_VAT.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTK_VAT.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTK_VAT.Text = DrReturn.Item("Tk0")
            TxtTen_TK_VAT.Text = DrReturn.Item("Ten_Tk0")
        Else
            TxtTK_VAT.Text = ""
            TxtTen_TK_VAT.Text = ""
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
