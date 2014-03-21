Imports System.Data.SqlClient

Public Class tape_send
    Private Sub tape_send_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGetTime.Click
        TextBoxSendTime.Text = Now
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim tape_name = TextBoxTapeName.Text
        Dim start_timecode = TextBoxStartTime.Text
        Dim end_timecode = TextBoxEndTime.Text
        Dim length = TextBoxLength.Text
        Dim in_bc_time = TextBoxSendTime.Text
        Dim in_bc_send_per = TextBoxSendPerson.Text
        Dim in_bc_recv_per = TextBoxRecvPerson.Text
        Dim remark = TextBoxRemark.Text
        Dim identical = CheckBoxTape.Checked

        If tape_name = "" Then
            MsgBox("!")
        ElseIf start_timecode = "" Then
            MsgBox("!")
        ElseIf end_timecode = "" Then
            MsgBox("!")
        ElseIf length = "" Then
            MsgBox("!")
            'ElseIf in_bc_time = "" Then
            '    MsgBox("!")
        ElseIf in_bc_send_per = "" Then
            MsgBox("!")
        ElseIf in_bc_recv_per = "" Then
            MsgBox("!")
        ElseIf identical = False Then
            MsgBox("带芯带盒不同!")
        Else
            '存入数据库
            Dim connectionString As String = "Server=localhost;Database=nntv_ps;User ID=sa;Password=nntv@2014;"
            Dim connection As New SqlConnection(connectionString)

            '打开数据库
            Try
                connection.Open()

                Dim paras() As SqlParameter = _
                        {New SqlParameter("@tape_name", tape_name), New SqlParameter("@start_timecode", start_timecode), _
                         New SqlParameter("@end_timecode", end_timecode), New SqlParameter("@length", length), _
                         New SqlParameter("@in_bc_send_per", in_bc_send_per), _
                         New SqlParameter("@in_bc_recv_per", in_bc_recv_per), New SqlParameter("@identical", identical), _
                         New SqlParameter("@remark", remark), New SqlParameter("@tape_status", 1)}

                '
                Dim queryString As String = _
                        "insert into tape(tape_name,start_timecode,end_timecode,length,in_bc_send_per,in_bc_recv_per,identical,remark,tape_status, in_bc_time) values (@tape_name,@start_timecode,@end_timecode,@length,@in_bc_send_per,@in_bc_recv_per,@identical,@remark,@tape_status, getdate());"
                'Debug
                Console.WriteLine(queryString)

                Dim command As New SqlCommand(queryString, connection)
                command.Parameters.AddRange(paras)

                Console.WriteLine(command.CommandText)

                'cmd.Parameters.AddRange(paras);
                Dim reader As SqlDataReader = command.ExecuteReader()
            Catch ex As Exception
                MsgBox("数据库连接失败!")
            Finally
                connection.Close()
            End Try
        End If
    End Sub
End Class
