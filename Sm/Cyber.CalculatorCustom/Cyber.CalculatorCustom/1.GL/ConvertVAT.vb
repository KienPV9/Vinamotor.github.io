Imports System.Windows.Forms
Public Class ConvertVAT
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim FileName As String
    Dim DsData As New DataSet
    Dim tbMaster, tbHeader As New DataTable
    Dim DvMaster, DvHeader As New DataView
    Dim DtThang1, DtThang2, DtNam As DataTable
    Dim DrDmct As DataRow
    Dim _Tab_Boolean As Boolean = False
    Dim _StrSave As String = ""
    Private Sub ROTINHMIP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtNgay_Ct1.Value = Now.Date
        Me.Save_OK = False
        V_Load()
        V_AddHandler()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()

        TxtNgay_Ct1.Value = Now
        TxtNgay_Ct2.Value = Now
        DtThang1 = CreateTableMonth()
        DtNam = CreateTableYear()
        CyberFill.V_FillComBoxDefaul(CbbM_Thang, DtThang1, "Thang", IIf(Me.Lan = "V", "Ten_Thang", "Ten_Thang2"), "Default")
        CyberFill.V_FillComBoxDefaul(CbbM_Nam, DtNam, "Nam", IIf(Me.Lan = "V", "Ten_Nam", "Ten_nam2"), "Default")

        DsData = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_CONVERTVAT_NB_merc", "0###" & M_Ma_Dvcs & "#" & M_User_Name)
        tbMaster = DsData.Tables(0)
        tbHeader = DsData.Tables(1)
        DvHeader = New DataView(tbHeader)
        DvMaster = New DataView(tbMaster)
        CyberFill.V_FillReports(Master1GRV, M_LAN, DvHeader, DvMaster)
        Master1GRV.GridControl.DataSource = DvMaster


    End Sub
    Private Function CreateTableMonth() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Thang")
        _Return.Columns.Add("Ten_Thang")
        _Return.Columns.Add("Ten_Thang2")
        _Return.Columns.Add("Default")
        Dim _Thang As String = ""
        Dim _Default As String = "0"

        For i As Integer = 1 To 12
            _Thang = Strings.Right("00" + i.ToString.Trim, 2).Trim
            If Now.Date.Month = i Then
                _Default = "1"
            Else
                _Default = "0"
            End If
            _Return.Rows.Add(_Thang.ToString, "Tháng " + _Thang, "Month " + _Thang, _Default)
        Next
        CreateTableMonth = _Return
    End Function
    Private Function CreateTableYear() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Nam")
        _Return.Columns.Add("Ten_Nam")
        _Return.Columns.Add("Ten_Nam2")
        _Return.Columns.Add("Default")

        Dim _CurYear As Integer = Now.Year

        Dim _Nam As String = ""
        Dim _Default As String = "0"

        For i As Integer = _CurYear - 10 To _CurYear + 10
            _Nam = Strings.Right("0000" + i.ToString.Trim, 4).Trim

            If Now.Year = i Then
                _Default = "1"
            Else
                _Default = "0"
            End If
            _Return.Rows.Add(_Nam.ToString, "Năm " + _Nam, "Year " + _Nam, _Default)
        Next
        CreateTableYear = _Return
    End Function
    Private Sub V_AddHandler()
        AddHandler btnLoadData.Click, AddressOf V_LoadData

        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtOK.Click, AddressOf V_Nhan

        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtExit.Click, AddressOf V_Exit

        AddHandler CmdSelectAll.Click, AddressOf V_SelectAll
        AddHandler CmdRemoveAll.Click, AddressOf V_RemoveAll
        AddHandler CmdOk.Click, AddressOf V_CreateBT
        AddHandler CmdDelete.Click, AddressOf V_DeleteBT
        '-------------------------------------------------------------------------------------------------------------------
        '--Tk
        RemoveHandler TxtTk.CyberValiting, AddressOf V_TK
        RemoveHandler TxtTk.CyberLeave, AddressOf L_TK
        AddHandler TxtTk.CyberValiting, AddressOf V_TK
        AddHandler TxtTk.CyberLeave, AddressOf L_TK
        '--Tk_Du
        RemoveHandler TxtTk_Du.CyberValiting, AddressOf V_TK_DU
        RemoveHandler TxtTk_Du.CyberLeave, AddressOf L_TK_DU
        AddHandler TxtTk_Du.CyberValiting, AddressOf V_TK_DU
        AddHandler TxtTk_Du.CyberLeave, AddressOf L_TK_DU
        '--Ma_kh_N
        RemoveHandler TxtMa_Kh_N.CyberValiting, AddressOf V_Ma_KH_N
        RemoveHandler TxtMa_Kh_N.CyberLeave, AddressOf L_Ma_KH_N
        AddHandler TxtMa_Kh_N.CyberValiting, AddressOf V_Ma_KH_N
        AddHandler TxtMa_Kh_N.CyberLeave, AddressOf L_Ma_Kh_N
        '--Ma_kh_C
        RemoveHandler TxtMa_Kh_C.CyberValiting, AddressOf V_Ma_KH_C
        RemoveHandler TxtMa_Kh_C.CyberLeave, AddressOf L_Ma_KH_C
        AddHandler TxtMa_Kh_C.CyberValiting, AddressOf V_Ma_KH_C
        AddHandler TxtMa_Kh_C.CyberLeave, AddressOf L_Ma_Kh_C
     
        '--CT
        RemoveHandler TxtMa_CT.CyberValiting, AddressOf V_Ma_CT
        RemoveHandler TxtMa_CT.CyberLeave, AddressOf L_Ma_CT
        AddHandler TxtMa_CT.CyberValiting, AddressOf V_Ma_CT
        AddHandler TxtMa_CT.CyberLeave, AddressOf L_Ma_CT
        '-------------------------------------------------------------------------------------------------------------------
        '--Sp
        RemoveHandler TxtMa_Sp.CyberValiting, AddressOf V_Ma_Sp
        RemoveHandler TxtMa_Sp.CyberLeave, AddressOf L_Ma_Sp
        AddHandler TxtMa_Sp.CyberValiting, AddressOf V_Ma_Sp
        AddHandler TxtMa_Sp.CyberLeave, AddressOf L_Ma_Sp
        '--ma_dvcs
        RemoveHandler TxtMa_Dvcs.CyberValiting, AddressOf V_Ma_dvcs
        RemoveHandler TxtMa_Dvcs.CyberLeave, AddressOf L_Ma_dvcs
        AddHandler TxtMa_Dvcs.CyberValiting, AddressOf V_Ma_dvcs
        AddHandler TxtMa_Dvcs.CyberLeave, AddressOf L_Ma_dvcs
      

    End Sub
#Region "Cmd..."
    Private Sub V_SelectAll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Integer
        For i = 0 To tbMaster.Rows.Count - 1
            tbMaster.Rows(i).BeginEdit()
            tbMaster.Rows(i).Item("Tag") = True
            tbMaster.Rows(i).EndEdit()
            tbMaster.AcceptChanges()
        Next
        'BackColorDGVMaster()
        Me.Master1GRV.RefreshData()
    End Sub
    Private Sub V_RemoveAll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Integer
        For i = 0 To tbMaster.Rows.Count - 1
            tbMaster.Rows(i).BeginEdit()
            tbMaster.Rows(i).Item("Tag") = False
            tbMaster.Rows(i).EndEdit()
            tbMaster.AcceptChanges()
        Next
        'BackColorDGVMaster()
        Me.Master1GRV.RefreshData()
    End Sub
    Sub BackColorDGVMaster()
        Dim i As Integer
        For i = 0 To Master1GRV.RowCount - 1
            If tbMaster.Rows(i).Item("Tag") Then

            End If
        Next
    End Sub
    Private Sub V_CreateBT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_CT.Text = "" Then
            If MsgBox("Bạn đang Copy sang bản thuế mà không chọn theo chứng từ nào cả.! Nếu bạn tiếp tục hệ thống sẽ Copy sang bản thuế toàn bộ chứng từ ", MsgBoxStyle.YesNo, "Cyber") = MsgBoxResult.No Then
                Exit Sub
            Else
                Dim _strField, _strValue As String
                CyberSmodb.GetValueControler(Me, _strField, _strValue)

                CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_CONVERTVAT_NB_merc", "1#" & _strField.Trim & "#" & _strValue.Trim & "#" & TxtMa_Dvcs.Text.Trim & "#" & M_User_Name.Trim)
                MsgBox("Đã copy thành công!", MsgBoxStyle.OkOnly)


            End If
            Exit Sub
        End If
        'Copy từng phiếu

        V_Copy_phieu(sender, e)


    End Sub
    Private Sub V_Copy_phieu(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Stt_Rec As String = Tao_update("1", -1)
        If _Stt_Rec.Trim = "" Then Exit Sub
        Me.Master1GRV.RefreshData()
    End Sub
    Private Function Tao_update(ByVal _Loai As String, ByVal iRow As Integer) As String
        _StrSave = ""
        Dim j As Integer = 0
        Dim nCount As Integer = 0
        If iRow = -1 Then
            j = 0
            nCount = DvMaster.Count - 1
        Else
            j = iRow
            nCount = iRow
        End If

        For i = j To nCount

            '_StrSave = _StrSave + ";INSERT KTVKTVKTV SELECT '" & Dv_Ro.Item(i).Item("So_RO").ToString.Trim & "','" & Dv_Ro.Item(i).Item("Ma_VT").ToString.Trim & "'," & Dv_Ro.Item(i).Item("Sl_Xuat").ToString.Trim.Replace(" ", "").Replace(",", ".") & "," & Dv_Ro.Item(i).Item("Sl_Xuat_PICK").ToString.Trim.Replace(" ", "").Replace(",", ".")

            _StrSave = _StrSave + ";INSERT KTVKTVKTV SELECT '" & DvMaster.Item(i).Item("stt_rec").ToString.Trim & "',N'" & DvMaster.Item(i).Item("ma_ct").ToString.Trim & "',N'" & DvMaster.Item(i).Item("TAG").ToString.Trim & "'"
        Next
        If _StrSave = "" Then Return ""

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_CONVERTVAT_NB_Merc_Xu_ly", _Loai + "#" + _StrSave & "#" & TxtMa_CT.Text & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        Dim _Stt_Rec As String = ""

        If CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, M_LAN) = True Then
            _Stt_Rec = DsTmp.Tables(0).Rows(0).Item("Stt_Rec")
            DsTmp.Dispose()
        End If

        MsgBox("Đã copy thành công !", MsgBoxStyle.OkOnly, "Cyber")
        Me.Master1GRV.RefreshData()
        Return _Stt_Rec
    End Function
    Private Sub V_DeleteBT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'hieulv
        Dim dsChk As New DataSet
        Dim strStt_Rec As String = "", strMa_Ct As String = ""
        Dim i, ncount As Integer
        ncount = 0
        For i = 0 To tbMaster.Rows.Count - 1
            If tbMaster.Rows(i).Item("Tag") Then
                ncount = ncount + 1
                strStt_Rec = tbMaster.Rows(i).Item("Stt_Rec").ToString.Trim
                strMa_Ct = tbMaster.Rows(i).Item("Ma_Ct").ToString.Trim
                dsChk = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysDeleteVoucher", strStt_Rec + "#" + strMa_Ct + "#" + M_User_Name.Trim)
                tbMaster.Rows(i).Item("Tag") = False
            End If
        Next

        MsgBox("Đã xóa thành công!", MsgBoxStyle.OkOnly)
        Me.Master1GRV.RefreshData()
    End Sub
#End Region
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = False
        Dim dt As Date
        dt = TxtNgay_Ct1.Value
        '----------------------------------------------------------------------------
        Dim Field As String = ""
        Dim Value As String = ""
        Dim Dstmp As DataSet
        For i As Integer = 0 To tbMaster.Rows.Count - 1
            For j As Integer = i + 1 To tbMaster.Rows.Count - 1
                If tbMaster.Rows(i)("Ma_vt").ToString.Trim = tbMaster.Rows(j)("Ma_vt").ToString.Trim Then
                    MsgBox("Mã " & tbMaster.Rows(i)("Ma_vt").ToString.Trim & " dòng số " & (i + 1).ToString & " và dòng số " & (j + 1).ToString, MsgBoxStyle.Critical, Sysvar("M_CYBER_VER"))
                    Exit Sub
                End If
            Next
        Next
        Dim arr As Object(,) = New Object(tbMaster.Rows.Count, 1) {}
        Dim iRows As Integer = 0
        For Each DrData As DataRow In tbMaster.Rows
            If DrData.Item("MIP_TT") <= 0 Then
                Continue For
            End If
            V_GetValueRowDataTable(DrData, Field, Value)
            arr(iRows, 0) = Field
            arr(iRows, 1) = Value
            iRows += 1
            '  Dstmp = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "Cp_INChkMip", Field & "#" & Value & "#" & M_Ma_Dvcs & "#" & M_User_Name)
            If Dstmp.Tables(0).Rows.Count > 0 Then
                If Dstmp.Tables(0).Rows(0)("Status").ToString.Trim.ToUpper = "N" Then
                    MsgBox(Dstmp.Tables(0).Rows(0)("NOTE").ToString.Trim, MsgBoxStyle.Critical, Sysvar("M_CYBER_VER"))
                    Exit Sub
                End If
            End If
        Next
        iRows = 0
        For Each DrData As DataRow In tbMaster.Rows
            If DrData.Item("MIP_TT") <= 0 Then
                Continue For
            End If
            Dstmp = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "Cp_INSaveMip", arr(iRows, 0) & "#" & arr(iRows, 1) & "#" & TxtMa_Dvcs.Text.Trim & "#" & M_User_Name)
            iRows += 1
        Next

        '----------------------------------------------------------------------------       
        MsgBox("Đã thực hiện xong", MsgBoxStyle.OkOnly, Sysvar("M_CYBER_VER"))
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
#Region "Valid --- Tk"
    Private Sub V_Tk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtTk.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Tk0", "DmTK0", "1=1", "1=1")
    End Sub
    Private Sub L_Tk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtTk.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk.Text = DrReturn.Item("Tk0")
            Txtten_Tk.Text = DrReturn.Item("Ten_TK0")
        Else
            TxtTk.Text = ""
            Txtten_Tk.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Tk_DU"
    Private Sub V_Tk_Du(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtTk_Du.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Tk0", "DmTK0", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_Du(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtTk_Du.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_Du.Text = DrReturn.Item("Tk0")
            TxtTen_Tk_Du.Text = DrReturn.Item("Ten_TK0")
        Else
            TxtTk_Du.Text = ""
            TxtTen_Tk_Du.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Kh_N"
    Private Sub V_Ma_Kh_N(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Kh_N.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_KH", "DmKh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kh_N(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Kh_N.Text = "" Then
            TxtTen_kh_N.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kh_N.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Kh_N.Text = DrReturn.Item("Ma_KH")
            TxtTen_kh_N.Text = DrReturn.Item("Ten_KH")
        Else
            TxtMa_Kh_N.Text = ""
            TxtTen_kh_N.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Kh_C"
    Private Sub V_Ma_Kh_C(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Kh_C.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_KH", "DmKh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kh_C(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Kh_C.Text = "" Then
            TxtTen_kh_C.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kh_C.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Kh_C.Text = DrReturn.Item("Ma_KH")
            TxtTen_kh_C.Text = DrReturn.Item("Ten_KH")
        Else
            TxtMa_Kh_C.Text = ""
            TxtTen_kh_C.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_CT"
    Private Sub V_Ma_CT(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_CT.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_CT", "DmCT", "", "1=1")
    End Sub
    Private Sub L_Ma_CT(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_CT.Text = "" Then
            TxtTen_CT.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_CT.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_CT.Text = DrReturn.Item("Ma_CT")
            TxtTen_CT.Text = DrReturn.Item("Ten_CT")
        Else
            TxtMa_CT.Text = ""
            TxtTen_CT.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Sp"
    Private Sub V_Ma_Sp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Sp.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Sp", "DmSp", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Sp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Sp.Text = "" Then
            TxtTen_Sp.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Sp.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Sp.Text = DrReturn.Item("Ma_Sp")
            TxtTen_Sp.Text = DrReturn.Item("Ten_Sp")
        Else
            TxtMa_Sp.Text = ""
            TxtTen_Sp.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_dvcs"
    Private Sub V_Ma_dvcs(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Dvcs.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_dvcs", "Dmdvcs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_dvcs(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Dvcs.Text = "" Then
            TxtTen_Dvcs.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Dvcs.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Dvcs.Text = DrReturn.Item("Ma_dvcs")
            TxtTen_Dvcs.Text = DrReturn.Item("Ten_dvcs")
        Else
            TxtMa_Dvcs.Text = ""
            TxtTen_Dvcs.Text = ""
        End If
    End Sub
#End Region

#Region "Them, Xoa ...."
    Private Sub V_ShortAddItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = Master1GRV.FocusedRowHandle
        V_AddItem(iRow)
    End Sub
    Private Sub V_ShortDeleteItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = Master1GRV.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(Sysvar, M_LAN, "", iRow, DvMaster, AppConn) Then Exit Sub
        DvMaster.Delete(iRow)
        DvMaster.Table.AcceptChanges()
    End Sub
    Private Sub V_AddItem(Optional ByVal iRow As Integer = -1)
        Dim DrvOld As DataRowView
        If iRow >= 0 Then DrvOld = DvMaster.Item(iRow) Else DrvOld = Nothing
        DvMaster.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(DvMaster.Table.Rows(DvMaster.Table.Rows.Count - 1))
        'CyberSupport.SetCarryOn(DrvOld, DvMaster.Table.Rows(DvMaster.Table.Rows.Count - 1), New DataView(M_DsHead.Tables(1)))
        iRow = DvMaster.Count - 1
        CyberFill.V_ForcusCell(Master1GRV, iRow, 0)

    End Sub
#End Region
    Private Sub V_LoadData(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Tinh_Toan("0")
    End Sub
    Private Sub Tinh_Toan(ByVal M_Loai As String)
        Dim _strField, _strValue As String
        CyberSmodb.GetValueControler(Me, _strField, _strValue)

        Dim _dsTmp As DataSet
        _dsTmp = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_CONVERTVAT_NB_merc", "1#" & _strField.Trim & "#" & _strValue.Trim & "#" & TxtMa_Dvcs.Text.Trim & "#" & M_User_Name.Trim)
        CyberSmodb.SetNotNullTable(_dsTmp.Tables(0))

        tbMaster.Clear()
        For i As Integer = 0 To _dsTmp.Tables(0).Rows.Count - 1
            tbMaster.ImportRow(_dsTmp.Tables(0).Rows(i))
        Next
        DvMaster = New DataView(tbMaster)
        CyberFill.V_FillReports(Master1GRV, M_LAN, DvHeader, DvMaster)
        Master1GRV.GridControl.DataSource = DvMaster
    End Sub
    Sub V_GetValueRowDataTable(ByVal drData As DataRow, ByRef Field As String, ByRef Value As String)
        For Each dcData As DataColumn In drData.Table.Columns
            Field &= dcData.ColumnName.Trim & "!~!"
            Value &= drData(dcData.ColumnName.Trim).ToString.Trim & "!~!"
        Next
    End Sub
    Private Sub V_Exit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
End Class
