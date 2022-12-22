Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports Cyber.SmLib
Imports System.IO
Imports System.Net.Mail
Imports CyberMayChamCong
Imports System.Windows.Forms
Public Class FrmLoad
    Dim _ChamCong As CyberMayChamCong.MayChamCong
    Dim AppCon As New SqlConnection
    Dim smlib As New Cyber.SmLib.Sys
    Dim DsTB As New DataSet
    Dim _TbMayCC As New DataTable
    Dim Tb As New DataTable
    Dim M_Auto As String = ""
    Private Sub FDMTD1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Hide()


        V_GetValueParameter()
        AppCon = smlib.GetConn
        oSysvar = smlib.IniSysVar(AppCon, "01", "ABC")
        V_Load()
        TxtNgay_CT1.Value = Now.Date
        TxtNgay_CT2.Value = Now.Date
        AddHandler CbbMayCC.SelectedIndexChanged, AddressOf V_MayCC
        M_User_Name = "ABC"
        Dim _DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppCon, "CP_SETMayCC", M_User_Name)
        CyberSmodb.SetNotNullTable(_DsTmp.Tables(0))
        M_Auto = _DsTmp.Tables(0).Rows(0).Item("AuTo").ToString.Trim
        'M_Auto = "0"
        V_AuToRead()
    End Sub
#Region "Load"
    Private Sub V_AuToRead()
        If Not M_Auto = "1" Then Exit Sub
        Dim _Connect As Boolean
        For i As Integer = 0 To _TbMayCC.Rows.Count - 1
            CbbMayCC.SelectedIndex = i

            V_Ket_Noi()
            _Connect = _ChamCong.V_kiemtraketnoi
            If _Connect = False Then Continue For
            V_Lay_DL()
            V_SaveDL()

        Next
        Me.Close()
    End Sub
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        DsTB = Nothing
        _TbMayCC = CyberSmodb.OpenTable(AppCon, DsTB, "DMMayCC", "1", CyberSmlib)
        CyberFill.V_FillComBoxDefaul(Me.CbbMayCC, _TbMayCC, "Ma_May", "Ten_May", "Ngam_Dinh")

        If CbbMayCC.SelectedValue.ToString.Trim <> "" Then
            TxtIP.Text = CyberSmodb.SQLGetvalue(AppCon, "IP", "DmMayCC", "(Ma_May = N'" + CbbMayCC.SelectedValue.ToString.Trim + "')", CyberSmlib)
            TxtPort.Text = CyberSmodb.SQLGetvalue(AppCon, "Port", "DmMayCC", "(Ma_May = N'" + CbbMayCC.SelectedValue.ToString.Trim + "')", CyberSmlib)
        End If
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Buuton"
    Private Sub ButtKet_Noi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtKet_Noi.Click
        V_Ket_Noi()
        V_Kiemtra_KetNoi()
    End Sub
    Private Sub V_Ket_Noi()
        _ChamCong = New CyberMayChamCong.MayChamCong(TxtIP.Text, TxtPort.Text)
        _ChamCong.V_KetnoiMayChamCong()
    End Sub
    Private Sub V_Kiemtra_KetNoi()
        Dim _Connect As Boolean = _ChamCong.V_kiemtraketnoi
        If _Connect = False Then
            MsgBox("Kết nối không thành công!", MsgBoxStyle.Critical)
            Exit Sub
        End If
    End Sub
    Private Sub ButtLay_DL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtLay_DL.Click
        V_Lay_DL()
    End Sub
    Private Sub V_Lay_DL()
        If Not _ChamCong.V_KetnoiMayChamCong Then Exit Sub
        Tb = _ChamCong.V_LayDanhSachChamCong("", TxtNgay_CT1.Value, TxtNgay_CT2.Value)
        DataGridView1.DataSource = Tb
    End Sub
    Private Sub ButtOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtOK.Click
        V_SaveDL()
    End Sub
    Private Sub V_SaveDL()
        Dim _Key As String = ""
        Dim dt1, dt2 As DateTime
        dt1 = TxtNgay_CT1.Value
        dt2 = TxtNgay_CT2.Value
        _Key = "1=1"
        _Key = "IP = '" + TxtIP.Text.Trim + "' AND dDate BETWEEN '" + dt1.ToString("yyyyMMdd") + "' AND '" + dt2.ToString("yyyyMMdd") + "'"
        M_User_Name = "ABC"
        CyberSmodb.V_SaveToSQL(AppCon, oSysvar, M_User_Name, Tb, "ChamCongInOut", "S", _Key)
    End Sub
    Private Sub V_MayCC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtIP.Text = CyberSmodb.SQLGetvalue(AppCon, "IP", "DmMayCC", "(Ma_May = N'" + CbbMayCC.SelectedValue.ToString.Trim + "')", CyberSmlib)
        TxtPort.Text = CyberSmodb.SQLGetvalue(AppCon, "Port", "DmMayCC", "(Ma_May = N'" + CbbMayCC.SelectedValue.ToString.Trim + "')", CyberSmlib)
    End Sub
#End Region
End Class
