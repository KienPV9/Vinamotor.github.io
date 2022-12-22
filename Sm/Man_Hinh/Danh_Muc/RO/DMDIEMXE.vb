﻿Public Class DMDIEMXE
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim CyberColor As New Cyber.Color.Sys
    Private Sub FDMXEUT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()

        CyberSupport.Translaste(Me, M_LAN, True)
        TxtMa_xe.Focus()
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)

    End Sub

#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()

        If Me.Mode = "M" Then
            TxtMa_Dvcs.Text = M_Ma_Dvcs

        End If
       
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        'RemoveHandler TxtMa_xe.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_xe.KeyPress, AddressOf TxtCodeError_KeyPress

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()

    End Sub
#End Region
#Region "Valid"
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
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
