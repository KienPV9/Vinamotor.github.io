Public Class DMCSCKBH
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FSysList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtMa_BH.Focus()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then
            TxtMa_Dvcs.Text = M_Ma_Dvcs
            TxtNgay_HL.Value = Now.Date
        End If
        TxtTen_BH.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_BH", "DmBH", "(Ma_BH = N'" + TxtMa_BH.Text.Trim + "')", CyberSmlib)

    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        '-Ma_BH
        RemoveHandler TxtMa_BH.CyberValiting, AddressOf V_Ma_BH
        RemoveHandler TxtMa_BH.CyberLeave, AddressOf L_Ma_BH
        AddHandler TxtMa_BH.CyberValiting, AddressOf V_Ma_BH
        AddHandler TxtMa_BH.CyberLeave, AddressOf L_Ma_BH
        RemoveHandler TxtMa_BH.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_BH.KeyPress, AddressOf TxtCodeError_KeyPress

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()

    End Sub
#End Region
#Region "Vali --- Ma_bh"
    Private Sub V_Ma_BH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_BH.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_BH", "Dmbh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_BH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_BH.Text = "" Then
            TxtTen_BH.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_BH.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_BH.Text = DrReturn.Item("Ma_bh")
            TxtTen_BH.Text = DrReturn.Item("Ten_bh")
        Else
            TxtMa_BH.Text = ""
            TxtTen_BH.Text = ""
        End If
    End Sub
#End Region

#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        If TxtTen_BH.Text = "" Then
            Exit Sub
        End If
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)
        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region


End Class
