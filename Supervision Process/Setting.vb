Imports System.Data.SqlClient

Public Class Setting
    Private Sub OK_Button_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles OK_Button.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click _
        (ByVal sender As Object, ByVal e As EventArgs) _
        Handles Cancel_Button.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As Object, ByVal e As EventArgs) _
        Handles TrackBarCheckPoint1.Scroll
        CheckPoint1 = TrackBarCheckPoint1.Value
        Label8.Text = TrackBarCheckPoint1.Value.ToString + "%"
    End Sub

    Private Sub Setting_Load(ByVal sender As Object, ByVal e As EventArgs) _
        Handles MyBase.Load
        Label8.Text = TrackBarCheckPoint1.Value.ToString + "%"

        '初始化数据库
        TextBoxDBAddr.Text = DbServer
        TextBoxDBUser.Text = DbUser
        TextBoxDBPawd.Text = DbPawd
        TextBoxDBName.Text = DbDbNamme

        '初始化审核点
        TrackBarCheckPoint1.Value = CheckPoint1

        '初始化高级选项


        '初始化显示查询设置

    End Sub

    Private Sub ButtonTestDBConn_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonTestDBConn.Click
        Dim connStr As String = "Server=" & DbServer & ";Database=" & DbDbNamme & _
                                ";User ID=" & DbUser & ";Password=" & DbPawd & _
                                ";"
        Dim connection As New SqlConnection(connStr)

        Try
            '打开数据库
            connection.Open()
            MsgBox("连接数据库成功")
            connection.Close()
        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "DB Error")
        End Try
    End Sub
End Class
