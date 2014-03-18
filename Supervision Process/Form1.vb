Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DataGridView1.ColumnCount = 4
        DataGridView1.Columns(0).HeaderText = "名称"
        DataGridView1.Columns(1).HeaderText = "时长"
        DataGridView1.Columns(2).HeaderText = "状态"
        'DataGridView1.Columns(3).HeaderText = "磁带名"
    End Sub

    Private Sub 送带ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 送带ToolStripMenuItem.Click
        '打开送带窗口或对话框
        tape_send.Show()
    End Sub

    Private Sub 发带ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 发带ToolStripMenuItem.Click
        '打开发带窗口或对话框
    End Sub

    Private Sub 选项ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 选项ToolStripMenuItem.Click
        '打开设置对话框
        'Setting.Visible = True
        Setting.Show()
    End Sub

    Private Sub 人员添加ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 人员添加ToolStripMenuItem1.Click
        '打开人员添加对话框
        addPerson.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim connectionString As String = "Server=localhost;Database=nntv_ps;User ID=sa;Password=nntv@2014;"
        Dim connection As New SqlConnection(connectionString)

        '清空原来的查询结果
        DataGridView1.Rows.Clear()

        '打开数据库
        connection.Open()

        Dim queryString As String = GetQueryString()
        'Debug
        Console.WriteLine(queryString)

        Dim command As New SqlCommand(queryString, connection)
        Dim reader As SqlDataReader = command.ExecuteReader()
        Try
            While reader.Read()
                'Console.WriteLine(String.Format("{0}, {1}", reader(0), reader(1)))
                DataGridView1.Rows.Add(reader(0), reader(1), reader(2))
            End While
        Finally
            ' Always call Close when done reading.
            reader.Close()
        End Try
        connection.Close()
    End Sub

    Private Function GetQueryString() As String
        Dim name As String = TextBox1.Text
        'Debug
        Console.WriteLine(name)
        Return "SELECT tape_name, length, tape_status.status FROM tape inner join tape_status ON tape.tape_status = tape_status.code Where tape_name LIKE '%" + name + "%';"
    End Function

    Private Sub DataGridView1_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(MousePosition.X, MousePosition.Y)
        End If
    End Sub
End Class
