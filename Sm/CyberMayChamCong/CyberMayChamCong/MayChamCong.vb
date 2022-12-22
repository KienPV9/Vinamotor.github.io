Imports System.Threading
Imports zkemkeeper
Public Class Sys
    Dim DanhSachMayChamCong As New Dictionary(Of Integer, MayChamCong)
    Public Sub Add(ByVal IP As String, ByVal Port As String)
        DanhSachMayChamCong.Add(DanhSachMayChamCong.Count, New mayChamcong(IP, Port))
    End Sub
    Public Sub Remover(ByVal index As Integer)
        DanhSachMayChamCong.Remove(index)
    End Sub
    Public Sub Clear()
        DanhSachMayChamCong.Clear()
    End Sub
    Public Function Item(ByVal Index As String) As MayChamCong
        Return DanhSachMayChamCong(Index)
    End Function
End Class
Public Class MayChamCong
    Private IP As String
    Private Port As String
    Private _chamcong As New objecCzkemTCP
    Public Sub New(ByVal IPAdd As String, ByVal PortAdd As String)
        IP = IPAdd
        Port = PortAdd
    End Sub
    Public Function V_kiemtraketnoi() As Boolean
        Return _chamcong.IConnectDecvice
    End Function
    Public Function V_KetnoiMayChamCong() As Boolean
        Return _chamcong.KetNoiMayChamcongIP(IP, Port)
    End Function
    Public Function V_HuyKetnoi() As Boolean
        Return _chamcong.DisConnectIP
    End Function
    Public Function V_LayDanhSachNguoiDung() As DataTable
        Return _chamcong.LayDanhSachUser
    End Function
    Public Function V_LayDanhSachChamCong(ByVal sUserId As String, ByVal dDate_Begin As Date, ByVal dDate_End As Date) As DataTable
        Return _chamcong.LayDanhSachChamCong(sUserId, dDate_Begin, dDate_End)
    End Function
    Public Function V_CapNhapNhanvien(ByVal IdUserName As String, ByVal Name As String, ByVal Password As String, ByVal Enabled As Boolean) As Boolean
        Return _chamcong.V_CapNhapNhanvien(IdUserName, Name, Password, 0, Enabled)
    End Function
    Public Function V_ClearData() As Boolean
        Return _chamcong.V_ClearData
    End Function
    Public Sub V_Beep()
        _chamcong.Beep()
    End Sub
End Class
Public Class objecCzkemTCP
    Dim axCZKEM1 As New zkemkeeper.CZKEM
    Public IConnectDecvice As Boolean = False
    Dim idwErrorCode As String
    Dim iMachineNumber As String
    Dim IPDec As String
    Dim PortDec As String
    Public Function LayDanhSachUser() As DataTable
        If Not IConnectDecvice Then Return Nothing
        Dim TbUser As New DataTable
        TbUser.Columns.Add("IP")
        TbUser.Columns.Add("iMachineNumber")
        TbUser.Columns.Add("sdwEnrollNumber")
        TbUser.Columns.Add("sName")
        TbUser.Columns.Add("sPassword")
        TbUser.Columns.Add("iPrivilege")
        TbUser.Columns.Add("bEnabled")
        Dim sdwEnrollNumber As String = ""
        Dim sName As String = ""
        Dim sPassword As String = ""
        Dim iPrivilege As Integer
        Dim bEnabled As Boolean = False
        Dim sCardnumber As String = ""
        axCZKEM1.EnableDevice(iMachineNumber, False)
        axCZKEM1.ReadAllUserID(iMachineNumber)
        While axCZKEM1.SSR_GetAllUserInfo(iMachineNumber, sdwEnrollNumber, sName, sPassword, iPrivilege, bEnabled) = True
            If axCZKEM1.GetStrCardNumber(sCardnumber) = True Then
                TbUser.Rows.Add(IPDec, iMachineNumber, sdwEnrollNumber, sName, sPassword, iPrivilege, bEnabled)
            End If
        End While
        axCZKEM1.EnableDevice(iMachineNumber, True)
        Return TbUser
    End Function
    Public Function LayDanhSachChamCong(ByVal sUserId As String, ByVal dDate_Begin As Date, ByVal dDate_End As Date) As DataTable
        If Not IConnectDecvice Then Return Nothing
        Dim TbAttLog As New DataTable
        Dim TbReturn As New DataTable
        Dim sFinter As String
        sFinter = "(sdwEnrollNumber='" & sUserId & "' OR '" & sUserId & "' ='') AND (dDate >= #" & dDate_Begin.ToString("MM/dd/yyyy") & "#   AND dDate < #" & dDate_End.AddDays(1).ToString("MM/dd/yyyy") & "#)"
        TbAttLog = Nothing
        TbAttLog = GetAttLog()
        TbReturn = TbAttLog.Clone
        For Each dr As DataRow In TbAttLog.Select(sFinter)
            TbReturn.ImportRow(dr)
        Next

        Return TbReturn
    End Function
    Private Function GetAttLog() As DataTable
        If Not IConnectDecvice Then Return Nothing
        Dim TbAttLog As New DataTable
        TbAttLog.Columns.Add("IP", GetType(String))
        TbAttLog.Columns.Add("iMachineNumber", GetType(String))
        TbAttLog.Columns.Add("sdwEnrollNumber", GetType(String))
        TbAttLog.Columns.Add("idwVerifyMode", GetType(String))
        TbAttLog.Columns.Add("idwInOutMode", GetType(String))
        TbAttLog.Columns.Add("idwYear", GetType(String))
        TbAttLog.Columns.Add("idwMonth", GetType(String))
        TbAttLog.Columns.Add("idwDay", GetType(String))
        TbAttLog.Columns.Add("idwHour", GetType(String))
        TbAttLog.Columns.Add("idwMinute", GetType(String))
        TbAttLog.Columns.Add("idwSecond", GetType(String))
        TbAttLog.Columns.Add("idwWorkcode", GetType(String))
        TbAttLog.Columns.Add("dDate", GetType(Date))

        Dim sdwEnrollNumber As String = ""
        Dim idwVerifyMode As Integer
        Dim idwInOutMode As Integer
        Dim idwYear As Integer
        Dim idwMonth As Integer
        Dim idwDay As Integer
        Dim idwHour As Integer
        Dim idwMinute As Integer
        Dim idwSecond As Integer
        Dim idwWorkcode As Integer
        Dim dDate As Date
        Dim SDate As String = ""
        Dim idwErrorCode As Integer
        Dim iGLCount = 0
        axCZKEM1.EnableDevice(iMachineNumber, False)
        If axCZKEM1.ReadGeneralLogData(iMachineNumber) Then
            While axCZKEM1.SSR_GetGeneralLogData(iMachineNumber, sdwEnrollNumber, idwVerifyMode, idwInOutMode, idwYear, idwMonth, idwDay, idwHour, idwMinute, idwSecond, idwWorkcode)
                iGLCount += 1
                SDate = idwYear.ToString + Right("00" + idwMonth.ToString, 2) + Right("00" + idwDay.ToString, 2) + " " + Right("00" + idwHour.ToString, 2) + ":" + Right("00" + idwMinute.ToString, 2) + ":" + Right("00" + idwSecond.ToString, 2)
                dDate = Date.ParseExact(SDate, "yyyyMMdd HH:mm:ss", Nothing)
                TbAttLog.Rows.Add(IPDec, iMachineNumber, sdwEnrollNumber, idwVerifyMode, idwInOutMode, idwYear, idwMonth, idwDay, idwHour, idwMinute, idwSecond, idwWorkcode, dDate)
            End While
        Else
            axCZKEM1.GetLastError(idwErrorCode)
            If idwErrorCode.ToString.Trim = "" Then idwErrorCode = "Không có dữ liệu"
            Return Nothing
        End If
        axCZKEM1.EnableDevice(iMachineNumber, True)
        Return TbAttLog
    End Function
    Public Function V_CapNhapNhanvien(ByVal IdUserName As String, ByVal Name As String, ByVal Password As String, ByVal Privilege As Integer, ByVal Enabled As Boolean) As Boolean
        Return axCZKEM1.SSR_SetUserInfo(iMachineNumber, IdUserName, Name, Password, Privilege, Enabled)
    End Function
    Public Function V_ClearData() As Boolean
        Return axCZKEM1.ClearKeeperData(iMachineNumber)
    End Function
    '=========================================================Private
    Public Sub Beep()
        axCZKEM1.Beep(100)
    End Sub
    Public Function KetNoiMayChamcongIP(ByVal IP As String, ByVal Port As String) As Boolean
        iMachineNumber = 1
        IPDec = IP
        PortDec = Port
        IConnectDecvice = axCZKEM1.Connect_Net(IP, Port)
        If IConnectDecvice Then axCZKEM1.RegEvent(iMachineNumber, 65535)
        Return IConnectDecvice
    End Function
    Public Function DisConnectIP() As Boolean
        If IConnectDecvice = False Then Return True
        Try
            axCZKEM1.Disconnect()

            Return True
        Catch ex As Exception
            axCZKEM1.GetLastError(idwErrorCode)
            Return False
        End Try
    End Function
End Class