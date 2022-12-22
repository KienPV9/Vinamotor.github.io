Imports MayChamCong
Public Class FrmMain
    Dim _ChamCong As MayChamCong.mayChamcong
    Private Sub CmdConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdConnect.Click
        _ChamCong = New MayChamCong.mayChamcong(TxtIP.Text, TxtPort.Text)
        _ChamCong.V_KetnoiMayChamCong()
    End Sub
    Private Sub CmdLoadDmHs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdLoadDmHs.Click
        If Not _ChamCong.V_KetnoiMayChamCong Then Exit Sub
        Dim Tb As New DataTable
        Tb = _ChamCong.V_LayDanhSachNguoiDung
        DataGridView1.DataSource = Tb
    End Sub
    Private Sub CmdLoadData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdLoadData.Click
        If Not _ChamCong.V_KetnoiMayChamCong Then Exit Sub
        Dim Tb As New DataTable
        Tb = _ChamCong.V_LayDanhSachChamCong("", New Date(2017, 11, 1), New Date(2017, 11, 31))
        DataGridView1.DataSource = Tb
    End Sub
    Private Sub CmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSave.Click
        If Not _ChamCong.V_KetnoiMayChamCong Then Exit Sub
        _ChamCong.V_CapNhapNhanvien(TxtMa_Hs.Text.Trim, TxtTen_Hs.Text.Trim, "", True)
    End Sub
End Class
