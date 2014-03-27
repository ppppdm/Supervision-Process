Imports System.Data.SqlClient

Public Class QueryForm
    Private Sub QueryForm_load(ByVal sender As Object, ByVal e As EventArgs) _
        Handles Me.Load
        'init
        InitGlobalVariables()

        '加载QueryForm时的初始化工作
        '初始化DataGridView
        DataGridView1.ColumnCount = 4
        DataGridView1.Columns(0).HeaderText = "名称"
        DataGridView1.Columns(1).HeaderText = "时长"
        DataGridView1.Columns(2).HeaderText = "状态"


    End Sub

    Private Sub SendInToolStripMenuItem_Click _
        (ByVal sender As Object, ByVal e As EventArgs) _
        Handles SendInToolStripMenuItem.Click
        'open tape send in windows/dialog
        TapeSend.Show()
    End Sub

    Private Sub SendOutToolStripMenuItem_Click _
        (ByVal sender As Object, ByVal e As EventArgs) _
        Handles SendOutToolStripMenuItem.Click
        'open tape send out windows/dialog
    End Sub

    Private Sub OptionsToolStripMenuItem_Click _
        (ByVal sender As Object, ByVal e As EventArgs) _
        Handles OptionsToolStripMenuItem.Click
        'open setting dialog
        Setting.Show()
    End Sub

    Private Sub AddPeopleToolStripMenuItem1_Click _
        (ByVal sender As Object, ByVal e As EventArgs) _
        Handles AddPeopleToolStripMenuItem1.Click
        'open add_people dialog
        addPerson.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles ButtonQuery.Click
        Const connectionString As String = _
                  "Server=localhost;Database=nntv_ps;User ID=sa;Password=nntv@2014;"
        Dim connection As New SqlConnection(connectionString)

        '清空原来的查询结果
        DataGridView1.Rows.Clear()

        '打开数据库
        connection.Open()

        Dim queryString As String = GetQueryString()
        'Debug
        Console.WriteLine(queryString)

        Dim command As New SqlCommand(queryString, connection)

        'sqlDataAdapter
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)

        Dim queryDataTable As DataTable = New DataTable()
        adapter.Fill(queryDataTable)

        Dim reader As SqlDataReader = command.ExecuteReader()

        FillDataGridView(reader)

        FillDataGridView_dt(queryDataTable)

        connection.Close()
    End Sub

    Private Function GetQueryString() As String
        Dim queryText As String = TextBox1.Text
        'Debug
        Console.WriteLine(queryText)
        Return _
            "SELECT tape_name, length, tape_status.status FROM tape inner join tape_status ON tape.tape_status = tape_status.code Where tape_name LIKE '%" + _
            queryText + "%';"
    End Function

    Private Sub FillDataGridView(ByRef reader As SqlDataReader)

        Try
            While reader.Read()
                'Console.WriteLine(String.Format("{0}, {1}", reader(0), reader(1)))
                DataGridView1.Rows.Add(reader(0), reader(1), reader(2))
            End While
        Finally
            ' Always call Close when done reading.
            reader.Close()
        End Try
    End Sub

    Private Sub FillDataGridView_dt(ByRef dt As DataTable)

        '清空原来的查询结果
        DataGridView1.Rows.Clear()

        Console.WriteLine(dt.Rows.Count)
        Dim row As DataRow
        For i = 0 To dt.Rows.Count - 1
            Console.WriteLine(dt.Rows(i).Item("tape_name"))
            Console.WriteLine(dt.Rows(i).ItemArray.Length)
            row = dt.Rows(i)
            DataGridView1.Rows.Add(row("tape_name"), row("length"), row("status"))
        Next

        For j = 0 To dt.Columns.Count - 1
            Console.WriteLine(dt.Columns(j).ColumnName)
        Next
    End Sub

    Private Sub DataGridView1_CellMouseDown _
        (ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) _
        Handles DataGridView1.CellMouseDown
        If e.Button = MouseButtons.Right Then
            ContextMenuStrip1.Show(MousePosition.X, MousePosition.Y)
        End If
    End Sub

    Private Sub DataGridView1_RowDividerDoubleClick _
        (ByVal sender As Object, _
         ByVal e As DataGridViewRowDividerDoubleClickEventArgs) _
        Handles DataGridView1.RowDividerDoubleClick
    End Sub

    Private Sub UploadToolStripMenuItem_Click _
        (ByVal sender As Object, ByVal e As EventArgs) _
        Handles UploadToolStripMenuItem.Click
        UpLoadForm.Show()
    End Sub

    Private Sub InitGlobalVariables()
        '打开并读取配置文件config.ini
        Console.WriteLine(My.Computer.FileSystem.CurrentDirectory)
        Try
            Dim reader = New Microsoft.VisualBasic.FileIO.TextFieldParser(ConfigFile)
            reader.TextFieldType = FileIO.FieldType.Delimited
            reader.SetDelimiters(",")

            Dim currentRow As String()
            '初始化DSN
            Try
                currentRow = reader.ReadFields()

                DbServer = currentRow(0)
                DbDataBase = currentRow(1)
                DbUser = currentRow(2)
                DbPawd = currentRow(3)

                Conn = "Server=" & DbServer & ";Database=" & DbDataBase & _
                ";User ID=" & DbUser & ";Password=" & DbPawd & ";"
                Console.WriteLine(Conn)

            Catch ex As  _
            Microsoft.VisualBasic.FileIO.MalformedLineException
                Console.WriteLine("Line " & ex.Message & _
                "is not valid and will be skipped.")
            End Try

            '初始化本体自定义设置

        Catch err As Exception
            Console.WriteLine(err.Message)
        End Try
    End Sub

End Class
