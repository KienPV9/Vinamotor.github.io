Public Class SMAUTOSOCT
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim DtDmPost, DtDmCt As DataTable
    Dim M_Ma_CT As String = ""
    Dim List_Ma_CT As String = ""
    Dim CyberFrom As New Cyber.From.Sys
    Dim DtThang1, DtThang2, DtNam As DataTable
    Private Sub SMAUTOSOCT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Me.Save_OK = False
        V_Load()
        AddHandler ButtOK.Click, AddressOf V_Nhan
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        DtThang1 = CreateTableMonth()
        DtThang2 = CreateTableMonth()
        DtNam = CreateTableYear()
        CyberFill.V_FillComBoxDefaul(CbbM_Thang1, DtThang1, "Thang", IIf(Me.Lan = "V", "Ten_Thang", "Ten_Thang2"), "Default")
        CyberFill.V_FillComBoxDefaul(CbbM_Thang2, DtThang2, "Thang", IIf(Me.Lan = "V", "Ten_Thang", "Ten_Thang2"), "Default")
        CyberFill.V_FillComBoxDefaul(CbbM_Nam, DtNam, "Nam", IIf(Me.Lan = "V", "Ten_Nam", "Ten_nam2"), "Default")

        Dim _Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetComboboxMa_ctConvert", "1=1")
        DtDmCt = _Dstmp.Tables(0).Copy
        If M_Ma_CT.Trim = "" And DtDmCt.Rows.Count > 0 Then M_Ma_CT = DtDmCt.Rows(0).Item("Ma_Ct").ToString.Trim
        CyberFill.V_FillComBoxValue(CbbMa_Ct, DtDmCt, "Ma_Ct", If(Me.M_LAN = "V", "ten_Ct", "Ten_Ct2"), M_Ma_CT)
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm(M_LAN)
        Dim M_DsData As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SMAutoSoCt", CbbM_Thang1.SelectedValue.ToString & "#" & CbbM_Thang2.SelectedValue.ToString & "#" & CbbM_Nam.SelectedValue.ToString & "#" & CbbMa_Ct.SelectedValue & "#" & TxtSo_Ct.Text.ToString & "#" & M_Ma_Dvcs & "#" & M_User_Name)

        MsgBox(M_DsData.Tables(0).Rows(0).Item("Note"), MsgBoxStyle.OkOnly + MsgBoxStyle.Information, M_CYBER_VER)
        '------------------------------------------------------------------------------------
        If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()
        ''------------------------------------------------------------------------------------
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
End Class
