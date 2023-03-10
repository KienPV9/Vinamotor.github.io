Public Class DMTKNH
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FDMTKNH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtTk.Focus()
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If TxtTen_Tk.Text.Trim = "" Then TxtTen_Tk.Text = "" Else TxtTen_Tk.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk", "DmTk", "(TK = N'" + TxtTk.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        '--TK
        RemoveHandler TxtTk.CyberValiting, AddressOf V_tK
        RemoveHandler TxtTk.CyberLeave, AddressOf L_tK
        AddHandler TxtTk.CyberValiting, AddressOf V_tK
        AddHandler TxtTk.CyberLeave, AddressOf L_tK
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Valid --- tK"
    Private Sub V_tK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Tk", "Dmtk", "1=1", "1=1")
    End Sub
    Private Sub L_tK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtTk.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk.Text = DrReturn.Item("Tk")
            TxtTen_Tk.Text = DrReturn.Item("Ten_Tk")
        Else
            TxtTk.Text = ""
            TxtTen_Tk.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
