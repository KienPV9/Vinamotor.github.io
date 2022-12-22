Imports System.Drawing
Imports System.Windows.Forms
Public Class KC_TONGHOP
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim DtThang, DtNam As DataTable
    Dim Dt_head, Dt_Master As DataTable
    Dim Dv_head, Dv_Master As DataView
    Dim DrDmct As DataRow
    Dim CyberColor As New Cyber.Color.Sys
    Dim List_Ma_CT As String = ""
    Dim M_Ma_CT As String = ""
    Private Sub KC_TONGHOP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        Try
            M_Ma_CT = Me.Para(Me.M_VT_PARA + 2).ToString.Trim
        Catch ex As Exception
        End Try
        Try
            List_Ma_CT = Me.Para(Me.M_VT_PARA + 3).ToString.Trim
        Catch ex As Exception

        End Try
        If List_Ma_CT <> "" Then
            List_Ma_CT = List_Ma_CT.Trim.Replace(" ", "")
        End If
        V_Load()
        V_LoadDatabase()
        V_AddHandler()
        Master.DataSource = Dv_Master
        Me.MasterGRV.GridControl = Me.Master
        CyberFill.V_FillVoucher(MasterGRV, Me.Lan, Dv_head, Dv_Master, DrDmct)
        Me.Text = Me.Para(11).Trim

        MasterGRV_PopupMenuShowing(MasterGRV, Nothing)
        MasterGRV.OptionsMenu.EnableColumnMenu = True

        For Each dc As DevExpress.XtraGrid.Columns.GridColumn In MasterGRV.Columns
            dc.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True
            dc.OptionsFilter.AllowAutoFilter = True
            dc.OptionsFilter.AllowFilter = True
            dc.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Next

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_AddHandler()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        '
        '--TK

        MasterGRV.ViewCaption = ""
        MasterGRV.OptionsView.ShowViewCaption = False
    End Sub

    Private Sub V_Load()
        DtThang = CreateTableMonth()
        DtNam = CreateTableYear()
        CyberFill.V_FillComBoxDefaul(CbbM_Thang1, DtThang, "Thang", IIf(Me.Lan = "V", "Ten_Thang", "Ten_Thang2"), "Default")
        CyberFill.V_FillComBoxDefaul(CbbM_Nam, DtNam, "Nam", IIf(Me.Lan = "V", "Ten_Nam", "Ten_nam2"), "Default")
    End Sub
    Private Sub V_LoadDatabase()
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_LoadAllCuoiKY", M_Ma_Dvcs & "#" & M_User_Name)
        CyberSmodb.SetNotNullTable(DsTmp.Tables(0))
        Dt_Master = DsTmp.Tables(0).Copy
            Dt_head = DsTmp.Tables(1).Copy

            Dv_Master = New DataView(Dt_Master)
            Dv_head = New DataView(Dt_head)
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

            If Now.Date.Year = i Then
                _Default = "1"
            Else
                _Default = "0"
            End If
            _Return.Rows.Add(_Nam.ToString, "Năm " + _Nam, "Year " + _Nam, _Default)
        Next
        CreateTableYear = _Return
    End Function
    Private Sub MasterGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)

    End Sub
    Private Sub DetailGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        If Dt_Master.Columns.Contains("Bold") Then
            Dim _FieldBold As String = ""
            _FieldBold = Dt_Master.Columns("Bold").ColumnName
            Dim _categoryBold As String = MasterGRV.GetRowCellDisplayText(e.RowHandle, _FieldBold).ToString.Trim
            If _categoryBold = "1" Then e.Appearance.Font = New Drawing.Font(Me.Font.FontFamily, Me.Font.Size, FontStyle.Bold)
        End If
        If Not sender.IsCellSelected(e.RowHandle, e.Column) Then
            If Dt_Master.Columns.Contains("BackColor") Then
                Dim _FieldBackColor As String = ""
                _FieldBackColor = Dt_Master.Columns("BackColor").ColumnName
                Dim _categoryBackColor As String = MasterGRV.GetRowCellDisplayText(e.RowHandle, _FieldBackColor).ToString.Trim
                e.Appearance.BackColor = CyberColor.GetBacColorkReports(_categoryBackColor)
            End If
            If Dt_Master.Columns.Contains("BackColor2") Then
                Dim _FieldBackColor2 As String = ""
                _FieldBackColor2 = Dt_Master.Columns("BackColor2").ColumnName
                Dim _categoryBackColor2 As String = MasterGRV.GetRowCellDisplayText(e.RowHandle, _FieldBackColor2).ToString.Trim
                e.Appearance.BackColor2 = CyberColor.GetBacColorkReports(_categoryBackColor2)
            End If
        Else
            e.Appearance.BackColor = System.Drawing.Color.Silver
        End If
    End Sub
#Region "Valid"
#End Region
    'Private Sub V_DeleteBT(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim _Thang As String = CbbM_Thang.SelectedValue.ToString.Trim
    '    Dim _Nam As String = CbbM_Nam.SelectedValue.ToString.Trim

    '    If Not MsgBox("Bạn có muốn xóa khấu hao tháng " + _Thang + " năm " + _Nam, MsgBoxStyle.Critical + MsgBoxStyle.OkCancel, Me.Sysvar("M_CYBER_VER")) = MsgBoxResult.Ok Then Exit Sub

    '    Dim _Title As String = "Đang thực hiện xoát bút toán khấu hao tài sản cố định"
    '    Dim _Title2 As String = "Đang thực hiện xoát bút toán khấu hao tài sản cố định"


    '    If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm(_Title, _Title2, Me.Lan)
    '    Dim _DsDelete As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_FaBTDelete", "X#" & _Thang & "#" & _Nam & "#" & M_Ma_Dvcs & "#" & M_User_Name)
    '    If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()
    '    CyberSupport.V_MsgChk(_DsDelete.Tables(0), Me.Sysvar, Me.Lan)
    'End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not MsgBox("Bạn có muốn thực hiện các bút toán đã chọn?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, Me.Sysvar("M_CYBER_VER")) = MsgBoxResult.Ok Then Exit Sub
        Dim _Title As String = "Đang thực hiện"
        Dim _Title2 As String = "Đang thực hiện"

        If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm(_Title, _Title2, Me.Lan)

        '---- Post du lieu 

        Dim strMa_ButToan As String = ""
        Dim j As Integer = 0
        Dim nCount As Integer = Dt_Master.Rows.Count
        For i As Integer = 0 To nCount - 1
            If Dt_Master.Rows(i).Item("Tag") = True Then
                j = j + 1
                strMa_ButToan = strMa_ButToan + IIf(j = 1, "", "!~!") + Dt_Master.Rows(i).Item("Ma_ButToan").ToString.Trim
            End If
        Next
        Dim _DsTmp As DataSet
        Me.Thang1 = CbbM_Thang1.SelectedValue.ToString.Trim
        Me.Nam = CbbM_Nam.SelectedValue.ToString.Trim
        _DsTmp = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_LoadAllCuoiKY_CREATE", strMa_ButToan & "#" & Me.Thang1 & "#" & Me.Nam & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If Not _DsTmp Is Nothing Then
            If _DsTmp.Tables.Count > 0 Then
                If _DsTmp.Tables(_DsTmp.Tables.Count - 1).Columns.Contains("status") Then
                    CyberSupport.V_MsgChk(_DsTmp.Tables(_DsTmp.Tables.Count - 1), Me.Sysvar, Me.Lan)
                    If _DsTmp.Tables(0).Rows(0).Item("status") = "N" Then
                        Exit Sub
                    End If
                End If
                End If
        End If
        V_RemoveAll(New System.Object, New System.EventArgs)
        MsgBox("Đã thực hiện xong!")
    End Sub
    Private Sub V_DeleteBT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dsChk As New DataSet
        Dim strStt_Rec As String = "", strMa_Ct As String = ""
        Dim i, ncount As Integer
        ncount = 0
        For i = 0 To Dt_Master.Rows.Count - 1
            If Dt_Master.Rows(i).Item("Tag") Then
                ncount = ncount + 1
                strStt_Rec = Dt_Master.Rows(i).Item("Stt_Rec").ToString.Trim
                strMa_Ct = Dt_Master.Rows(i).Item("Ma_Ct").ToString.Trim
                dsChk = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysDeleteVoucher", strStt_Rec + "#" + strMa_Ct + "#" + M_User_Name.Trim)
                Dt_Master.Rows(i).Item("Tag") = False
            End If
        Next

        MsgBox("Đã xóa thành công!", MsgBoxStyle.OkOnly)
        'Me.Master1GRV.RefreshData()
    End Sub
    Private Sub V_Exits(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Tag = ""
        Me.Save_OK = False
        CyberSmlib.FlushMemorySave()

        Me.Close()
    End Sub
    Private Sub V_SelectAll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Integer
        For i = 0 To Dt_Master.Rows.Count - 1
            Dt_Master.Rows(i).BeginEdit()
            Dt_Master.Rows(i).Item("Tag") = True
            Dt_Master.Rows(i).EndEdit()
            Dt_Master.AcceptChanges()
        Next
    End Sub
    Private Sub V_RemoveAll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Integer
        For i = 0 To Dt_Master.Rows.Count - 1
            Dt_Master.Rows(i).BeginEdit()
            Dt_Master.Rows(i).Item("Tag") = False
            Dt_Master.Rows(i).EndEdit()
            Dt_Master.AcceptChanges()
        Next
    End Sub
   
End Class
