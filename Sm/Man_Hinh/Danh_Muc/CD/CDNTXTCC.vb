Public Class CDNTXTCC
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim So_Dau_Nam As Boolean = True
    Dim Dt_DmStt As DataTable
    Private Sub CDNTXTCC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNgay_ct.Value = Now.Date
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        TxtMa_Dvcs.Text = M_Ma_Dvcs
        TxtNam.Text = Me.Key_Nam.ToString
        TxtMa_Ct.Text = "PWW"
        If TxtMa_kho.Text.Trim = "" Then TxtTen_kho.Text = "" Else TxtTen_kho.Text = CyberSmodb.SQLGetvalue(Appconn, "ten_kho", "DmKho", "(Ma_kho = N'" + TxtMa_kho.Text.Trim + "')", CyberSmlib)
        'If Not TxtTK.Text.Trim = "" Then TxtMa_NT.Text = CyberSmodb.SQLGetvalue(Appconn, "Ma_NT", "DmTK", "(TK = N'" + TxtTK.Text.Trim + "')", CyberSmlib)
        If TxtTen_vitri.Text.Trim = "" Then TxtTen_vitri.Text = "" Else TxtTen_vitri.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_vitri", "Dmvitri", "(Ma_vitri = N'" + TxtMa_Vitri.Text.Trim + "')", CyberSmlib)
        TxtTen_cc.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_cc", "Dmcc", "(Ma_cc = N'" + TxtMa_cc.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        If TxtMa_Dvcs.Text.Trim = "" Then TxtTen_Dvcs.Text = "" Else TxtTen_Dvcs.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Dvcs", "DmDvcs", "(Ma_Dvcs = N'" + TxtMa_Dvcs.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then txtNgay_ct.Value = Now.Date
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        '--Ma_KH
        AddHandler TxtMa_cc.CyberValiting, AddressOf V_MA_cc
        AddHandler TxtMa_cc.CyberLeave, AddressOf L_Ma_cc
        '--TK
        AddHandler TxtMa_kho.CyberValiting, AddressOf V_Ma_kho
        AddHandler TxtMa_kho.CyberLeave, AddressOf L_MA_Kho
        '---
        AddHandler TxtMa_Vitri.Leave, AddressOf V_MA_Vitri
        AddHandler TxtMa_Vitri.Leave, AddressOf L_Ma_vitri
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Vali --- KH"
    Private Sub V_MA_cc(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "MA_cc", "Dmcc", "a.Gia_Ton = N'3'", "1=1")
    End Sub
    Private Sub L_Ma_cc(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_cc.Text = DrReturn.Item("Ma_cc")
            TxtTen_cc.Text = DrReturn.Item("Ten_cc")
        Else
            TxtMa_cc.Text = ""
            TxtTen_cc.Text = ""
        End If
    End Sub

#End Region
#Region "Vali --- TK"
    Private Sub V_Ma_kho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_kho", "Dmkho", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_kho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_kho.Text = DrReturn.Item("Ma_kho")
            TxtTen_kho.Text = DrReturn.Item("Ten_kho")
        Else
            TxtMa_kho.Text = ""
            TxtTen_kho.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NT"
    Private Sub V_MA_Vitri(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_vitri", "Dmvitri", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_vitri(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Vitri.Text = DrReturn.Item("Ma_vitri")
            TxtTen_vitri.Text = DrReturn.Item("Ten_vitri")
        Else
            TxtMa_Vitri.Text = ""
            TxtTen_vitri.Text = ""
        End If
    End Sub
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi luu du lieu vao truong trinh viet vao day
        TxtTien.Double = TxtTien_NT.Double
        If Me.Mode = "M" Then TxtMa_Ct.Text = "PWW"
        If Me.Mode = "M" Then TxtStt_Rec.Text = Get_Stt_Rec(TxtMa_Ct.Text)
        TxtStt_Rec0.Text = "0001"

        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
    Private Function Get_Stt_Rec(ByVal M_Ma_Ct As String) As String
        Dim _Return As String = ""
        Dim Dstmp As New DataSet
        Dstmp = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_GetSttRecCD", TxtMa_Ct.Text & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        _Return = Dstmp.Tables(0).Rows(0).Item("Stt_Rec").ToString.Trim()
        Get_Stt_Rec = _Return
        Dstmp.Dispose()
    End Function
#End Region
End Class