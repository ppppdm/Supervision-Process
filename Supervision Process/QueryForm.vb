Imports System.Data.SqlClient

Public Class QueryForm
    Private Sub QueryForm_load(ByVal sender As Object, ByVal e As EventArgs) _
        Handles Me.Load
        'init
        InitGlobalVariables()

        '加载QueryForm时的初始化工作
        '初始化DataGridView
        DataGridView1.ColumnCount = SwoTrueOptionsCount
        Dim j = 0
        For i = 0 To Swo.GetLength(0) - 1
            If Swo(i, SwoValue) = True Then
                DataGridView1.Columns(j).HeaderText = Swo(i, SwoDataViewName)
                j += 1
            End If
        Next
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

        Dim queryDataTable As DataTable = New DataTable()
        Dim connStr As String = "Server=" & DbServer & ";Database=" & DbDbNamme & _
                                ";User ID=" & DbUser & ";Password=" & DbPawd & _
                                ";"
        Dim connection As New SqlConnection(connStr)

        Try
            '打开数据库
            connection.Open()

            Dim queryString As String = GetQueryString()

            'sqlCommand
            Dim command As New SqlCommand(queryString, connection)

            'sqlDataAdapter
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)

            adapter.Fill(queryDataTable)

            FillDataGridView_dt(queryDataTable)

            'Dim reader As SqlDataReader = command.ExecuteReader()

            'FillDataGridView(reader)

            connection.Close()
        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "DB Error")
        End Try
    End Sub

    Private Function GetQueryString() As String
        Dim queryText As String = TextBoxQuery.Text
        Dim selectList As List(Of String) = New List(Of String)()
        Dim selectStr As String = ""
        Dim queryStr As String

        Console.WriteLine(Swo)
        For i = 0 To Swo.GetLength(0) - 1
            If Swo(i, SwoValue) = True Then
                selectList.Add(Swo(i, SwoDbColumnName))
            End If
        Next

        For i As Integer = 0 To selectList.Count - 1
            If selectList(i) = "tape_status" Then
                selectStr += "tape_status.status,"
            Else
                selectStr += selectList(i) + ","
            End If
        Next
        selectStr = selectStr.Remove(selectStr.Length - 1)

        'Debug
        Console.WriteLine(queryText)
        Console.WriteLine(selectStr)

        queryStr = "SELECT " + selectStr + " FROM tape " + _
                   "INNER JOIN tape_status ON tape.tape_status = tape_status.code " + _
                   "WHERE tape_name LIKE '%" + queryText + "%';"
        Console.WriteLine(queryStr)
        Return queryStr

        'Return "SELECT tape_name, length, tape_status.status FROM tape inner join tape_status ON tape.tape_status = tape_status.code Where tape_name LIKE '%" + queryText + "%';"
    End Function

    Private Sub FillDataGridView(ByRef reader As SqlDataReader)
        '清空原来的查询结果
        DataGridView1.Rows.Clear()

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
            DataGridView1.Rows.Add(row.ItemArray)
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
            Dim reader = New Microsoft.VisualBasic.FileIO.TextFieldParser _
                    (ConfigFile)
            reader.TextFieldType = FileIO.FieldType.Delimited
            reader.SetDelimiters(",")

            Dim currentRow As String()

            Try
                '初始化DSN
                currentRow = reader.ReadFields()

                DbServer = currentRow(0)
                DbDbNamme = currentRow(1)
                DbUser = currentRow(2)
                DbPawd = currentRow(3)

                '初始化db connstr
                ConnStr = "Server=" & DbServer & ";Database=" & DbDbNamme & _
                          ";User ID=" & DbUser & ";Password=" & DbPawd & ";"

            Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                Console.WriteLine _
                    ("Line " & ex.Message & "is not valid and will be skipped.")
            End Try

            '初始化本体自定义设置

        Catch err As Exception
            Console.WriteLine(err.Message)
        End Try

        'jint global variables
        InitSwoTrueOptionsCount()
    End Sub

    Public Sub InitSwoTrueOptionsCount()
        SwoTrueOptionsCount = 0
        For i = 0 To Swo.GetLength(0) - 1
            If Swo(i, SwoValue) = True Then
                SwoTrueOptionsCount += 1
            End If
        Next
    End Sub
End Class
