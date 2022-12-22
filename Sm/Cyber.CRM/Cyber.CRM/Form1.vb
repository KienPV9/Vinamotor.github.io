Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports Cyber.SmLib
Imports System.IO
Imports System.Net.Mail
Imports CyberMayChamCong
Imports Cyber.From
Public Class Form1
    Dim AppConn As New SqlConnection
    Dim smlib As New Cyber.SmLib.Sys
    Dim CyberSmodb As New Cyber.Smodb.Sys
    Dim _ChamCong As CyberMayChamCong.MayChamCong
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Hide()
        TxtNgay_CT1.Value = Now.Date
        TxtNgay_CT2.Value = Now.Date
        AppConn = smlib.GetConn
    End Sub

    Private Sub ButtKet_Noi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtKet_Noi.Click
        _ChamCong = New CyberMayChamCong.MayChamCong(TxtIP.Text, TxtPort.Text)
        _ChamCong.V_KetnoiMayChamCong()
    End Sub

    Private Sub ButtLay_DL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtLay_DL.Click
        If Not _ChamCong.V_KetnoiMayChamCong Then Exit Sub
        Dim Tb As New DataTable
        Dim _Key As String = ""
        Tb = _ChamCong.V_LayDanhSachChamCong("", TxtNgay_CT1.Value, TxtNgay_CT2.Value)
        DataGridView1.DataSource = Tb
        _Key = "1=1"
    End Sub
End Class
