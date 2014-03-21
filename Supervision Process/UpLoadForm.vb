
Imports System.Data.SqlClient
Imports ADODB

Public Class UpLoadForm
    Private Sub up_ctrl_Load(ByVal sender As Object, ByVal e As EventArgs) _
        Handles MyBase.Load

        Left = My.Computer.Screen.WorkingArea.Width - Width
        Top = My.Computer.Screen.WorkingArea.Height - Height
        Try
            InitStillGraph(PicCapture.Handle) '打开摄像头，实时监控
        Catch err As Exception
            Console.WriteLine(err)
        Finally

        End Try


        uploadtimeTextBox.Text = Now() '获得当前系统时间
        source1.Items.Add("VTR上载")
        source1.Items.Add("DVD上载")
        source1.Items.Add("非编上载")
        source1.Items.Add("定时上载")
    End Sub

    Private Sub TextBox2_TextChanged _
        (ByVal sender As Object, ByVal e As EventArgs) _
        Handles upthour.TextChanged

        If IsNumeric(upthour.Text) = False Then upthour.Text = "00" _
        '如果输入不是数字就显示为0


        If upthour.TextLength = 2 Then '输入时码的光标自动下移
            uptminute.Focus()
        End If

        If upthour.Text > 24 Then '如果输入的数字大于24小时数字为0光标移到最初
            upthour.Text = "00"
            upthour.Focus()
        End If
        '一下是时码时长的比对以及控制下一步按钮的enable
        If _
            upthour.Text = rsthour.Text And uptminute.Text = rstminute.Text And _
            uptsecond.Text = rstsecond.Text And uptframe.Text = rstframe.Text _
            Then

            PB3.Visible = True
            PB5.Visible = False
        Else
            PB5.Visible = True
            PB3.Visible = False
        End If

        If _
            upthour.Text = rsthour.Text And uptminute.Text = rstminute.Text And _
            uptsecond.Text = rstsecond.Text And uptframe.Text = rstframe.Text And _
            uplenhour.Text = rlhour.Text And uplenminute.Text = rlminute.Text And _
            uplensecond.Text = rlsecond.Text And uplenframe.Text = rlframe.Text _
            Then
            Button2.Enabled = True
            Button2.BackColor = Button1.BackColor
        Else

            Button2.Enabled = False
            Button2.BackColor = Color.Empty
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles Button3.Click

        'cutpicsrc = 1
        '实现屏幕截图
        WindowState = 1  '最小化程序窗口
        'Sleep(100) '延迟0.1秒
        Dim bmp As New Bitmap(1024, 768)
        Dim gs As Graphics = Graphics.FromImage(bmp)
        gs.CopyFromScreen(0, 0, 0, 0, My.Computer.Screen.WorkingArea.Size)
        bmp.Save(cutscrbmp)
        'CapDlgTest(My.Computer.Screen.WorkingArea., Picturescr.Handle)
        Dim a As String = cutscrbmp
        Dim b As String = cutscrjpg
        EncBmpToJpg(a, b)
        Picturescr.ImageLocation = (cutscrbmp)
        'If (upcutflag = 1) Then
        '    upnext1.Enabled = True
        'End If
        WindowState = 0  '恢复程序窗口
    End Sub


    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles Button2.Click
        '按下一步推送到上载界面

        '推送到上载数据后，显示屏幕截图
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = True
        Size = Panel3.Size
        Panel3.Location = New Point(0, 0)
    End Sub


    Private Sub Button6_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles Button6.Click
        OnpStillCapture(Pictureup.Handle) '摄像头图像截图
        Dim a As String = cutbmp
        Dim b As String = cutjpg
        EncBmpToJpg(a, b)

        Left = My.Computer.Screen.WorkingArea.Width - Width
        Top = My.Computer.Screen.WorkingArea.Height - Height

        Dim bmp As New Bitmap(1024, 768)
        Dim gs As Graphics = Graphics.FromImage(bmp)
        gs.CopyFromScreen(0, 0, 0, 0, My.Computer.Screen.WorkingArea.Size)
        bmp.Save(cutbmp)

        'upcutflag = 1
        'If (cutpicsrc = 1) Then
        '    upnext1.Enabled = True
        'End If
    End Sub


    Private Sub Button10_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles Button10.Click
        Panel1.Visible = True
        Panel2.Visible = True
        Panel3.Visible = True
        Size = New Size(756, 575)
        Panel3.Location = New Point(368, 3)
    End Sub


    Private Sub Button11_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles Buttoninquiry.Click
        Dim connstr
        connstr = _
            "Server=(local);Database=nntv_ps;User ID=sa;Password=nntv@2014;"

        Dim sqlconn As SqlConnection = New SqlConnection(connstr) _
        '打开数据库,读取磁带交接的内容
        sqlconn.Open()

        Dim com1 As SqlCommand = New SqlCommand
        com1.Connection = sqlconn
        com1.CommandText = _
            "select in_bc_time,start_timecode,end_timecode,length from tape where tape_name='" & _
            tapeNameTextBox.Text & "'"
        Dim readerstcode1 = com1.ExecuteReader()
        Dim inbcsttimecode As String
        Dim inbclengthcode As String
        Dim inbcendtimecode As String
        If (readerstcode1.Read()) Then
            inbctime1.Text = (readerstcode1("in_bc_time"))   '当前编辑的项目的创建时间
            inbcsttimecode = (readerstcode1("start_timecode"))  '当前编辑的项目的创建起始时码
            inbclengthcode = (readerstcode1("length"))    '当前编辑的项目的创建时长
            inbcendtimecode = (readerstcode1("end_timecode"))   '当前编辑的项目的创建终止时码

            rsthour.Text = Mid(inbcsttimecode, 1, 2) '显示创建的起始时码
            rstminute.Text = Mid(inbcsttimecode, 3, 2)
            rstsecond.Text = Mid(inbcsttimecode, 5, 2)
            rstframe.Text = Mid(inbcsttimecode, 7, 2)

            rlhour.Text = Mid(inbclengthcode, 1, 2) '显示创建的时长
            rlminute.Text = Mid(inbclengthcode, 3, 2)
            rlsecond.Text = Mid(inbclengthcode, 5, 2)
            rlframe.Text = Mid(inbclengthcode, 7, 2)

            rendhour.Text = Mid(inbcendtimecode, 1, 2) '显示创建的终止时码
            rendminute.Text = Mid(inbcendtimecode, 3, 2)
            rendsecond.Text = Mid(inbcendtimecode, 5, 2)
            rendframe.Text = Mid(inbcendtimecode, 7, 2)


        Else
            rsthour.Text = "无"
            rstminute.Text = "此"
            rstsecond.Text = "节"
            rstframe.Text = " 目"

            rlhour.Text = "无"
            rlminute.Text = "此"
            rlsecond.Text = "节"
            rlframe.Text = "目"

            rendhour.Text = "无"
            rendminute.Text = "此"
            rendsecond.Text = "节"
            rendframe.Text = "目"


        End If
        readerstcode1.Close()
        sqlconn.Close()
    End Sub

    Private Sub Button9_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles Button9.Click


        Dim sqlconn As SqlConnection = New SqlConnection(connstr) _
        '点击保存按钮的时候将上载信息写入数据库 (正常)
        sqlconn.Open()
        Dim startTimeCode = upthour.Text & uptminute.Text & uptsecond.Text & _
                            uptframe.Text              '将磁带时码写入数据库
        Dim lenght = uplenhour.Text & uplenminute.Text & uplensecond.Text & _
                        uplenframe.Text                       '将磁带时长写入数据库
        Dim endTimeCode = upendhour.Text & upendminute.Text & upendsecond.Text & _
                    upendframe.Text       '将磁带上载时间写入数据库
        Dim source = source1.Text  '将上载类型写入数据库
        Dim upLoadTime = uploadtimeTextBox.Text  '将磁带上载时间写入数据库
        Dim tapeName = tapeNameTextBox.Text   '将磁带名写入数据库'
        Dim remark = remarkTextBox.Text '将备注写入数据库
        Dim volumeCheck            '将音量check写入数据库
        If volumecheck2.Checked = True Then
            volumeCheck = 1
        Else
            volumeCheck = 0
        End If
        Dim imageCheck                 '将图像check写入数据库
        If imagecheck2.Checked = True Then
            imageCheck = 1
        Else
            imageCheck = 0
        End If
        Dim episodeCheck                   '将期数集数check写入数据库
        If episodecheck2.Checked = True Then
            episodeCheck = 1
        Else
            episodeCheck = 0
        End If
        Dim queryString As String = _
                " insert into upload (tape_name, start_timecode,length,upload_time,volume_check,image_check,episode_check,remark,end_timecode,upload_type) values ('" & _
                tapeName & "', '" & startTimeCode & "','" & lenght & "','" & _
                upLoadTime & "', '" & volumeCheck & "','" & imageCheck & _
                "','" & episodeCheck & "','" & remark & "','" & endTimeCode & _
                "','" & source & "')"
        Console.WriteLine(queryString)
        Dim sqlcom As SqlCommand = New SqlCommand(queryString, sqlconn)
        sqlcom.ExecuteNonQuery()
        sqlconn.Close()


        Dim rs As Recordset = New Recordset
        Dim conn As Connection = New Connection
        Dim connstr1
        connstr1 = _
            "Provider=SQLOLEDB;Server=(local);Database=nntv_ps;User ID=sa;Password=nntv@2014;"
        '打开数据库连接
        conn.Open(connstr1)
        '定义查询语句
        Dim sqlstr
        sqlstr = "select screenshot,camerashot from upload where tape_name= '" & _
                 tapeName & "'  "
        rs.Open(sqlstr, conn, 1, 3)
        '数据一个数据流
        Dim s As ADODB.Stream = New ADODB.Stream
        With s
            '设置数据流为：二进制模式  
            .Type = StreamTypeEnum.adTypeBinary
            .Open()
            '向Stream对象中加载图片  
            .LoadFromFile(cutjpg)

        End With

        rs("screenshot").AppendChunk(s.Read)

        Dim s1 As ADODB.Stream = New ADODB.Stream
        With s1
            '设置数据流为：二进制模式  
            .Type = StreamTypeEnum.adTypeBinary
            .Open()
            '向Stream对象中加载图片  "C:\Documents and Settings\Administrator\My Documents\Visual Studio 2008\Projects\Up_ctrl\Up_ctrl\bin\Debug\StillCap0000.bmp")
            .LoadFromFile(cutscrjpg)

        End With
        rs("camerashot").AppendChunk(s1.Read)

        rs.Update()
        rs.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Label17_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles Labelupcode.Click
    End Sub

    Private Sub rsthour_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles rsthour.Click
    End Sub

    Private Sub uptminute_TextChanged _
        (ByVal sender As Object, ByVal e As EventArgs) _
        Handles uptminute.TextChanged
        If IsNumeric(uptminute.Text) = False Then uptminute.Text = "00"

        If uptminute.TextLength = 2 Then
            uptsecond.Focus()
        End If

        If uptminute.Text > 59 Then
            uptminute.Text = "00"
            uptminute.Focus()
        End If

        If _
            upthour.Text = rsthour.Text And uptminute.Text = rstminute.Text And _
            uptsecond.Text = rstsecond.Text And uptframe.Text = rstframe.Text _
            Then

            PB3.Visible = True
            PB5.Visible = False
        Else
            PB5.Visible = True
            PB3.Visible = False

        End If
        If _
            upthour.Text = rsthour.Text And uptminute.Text = rstminute.Text And _
            uptsecond.Text = rstsecond.Text And uptframe.Text = rstframe.Text And _
            uplenhour.Text = rlhour.Text And uplenminute.Text = rlminute.Text And _
            uplensecond.Text = rlsecond.Text And uplenframe.Text = rlframe.Text _
            Then
            Button2.Enabled = True
            Button2.BackColor = Button1.BackColor
        Else

            Button2.Enabled = False
            Button2.BackColor = Color.Empty
        End If
    End Sub

    Private Sub uptsecond_TextChanged _
        (ByVal sender As Object, ByVal e As EventArgs) _
        Handles uptsecond.TextChanged
        If IsNumeric(uptsecond.Text) = False Then uptsecond.Text = "00"
        If uptsecond.TextLength = 2 Then
            uptframe.Focus()
        End If
        If uptsecond.Text > 59 Then
            uptsecond.Text = "00"
            uptsecond.Focus()
        End If
        If _
            upthour.Text = rsthour.Text And uptminute.Text = rstminute.Text And _
            uptsecond.Text = rstsecond.Text And uptframe.Text = rstframe.Text _
            Then

            PB3.Visible = True
            PB5.Visible = False
        Else
            PB5.Visible = True
            PB3.Visible = False


        End If
        If _
            upthour.Text = rsthour.Text And uptminute.Text = rstminute.Text And _
            uptsecond.Text = rstsecond.Text And uptframe.Text = rstframe.Text And _
            uplenhour.Text = rlhour.Text And uplenminute.Text = rlminute.Text And _
            uplensecond.Text = rlsecond.Text And uplenframe.Text = rlframe.Text _
            Then
            Button2.Enabled = True
            Button2.BackColor = Button1.BackColor
        Else

            Button2.Enabled = False
            Button2.BackColor = Color.Empty
        End If
    End Sub

    Private Sub uplenhour_TextChanged _
        (ByVal sender As Object, ByVal e As EventArgs) _
        Handles uplenhour.TextChanged
        If IsNumeric(uplenhour.Text) = False Then uplenhour.Text = "00"

        If uplenhour.TextLength = 2 Then '输入时码的光标自动下移
            uplenminute.Focus()
        End If
        If uplenhour.Text > 24 Then
            uplenhour.Text = "00"
            uplenhour.Focus()
        End If
        If _
            uplenhour.Text = rlhour.Text And uplenminute.Text = rlminute.Text And _
            uplensecond.Text = rlsecond.Text And uplenframe.Text = rlframe.Text _
            Then

            PB4.Visible = True
            PB6.Visible = False
        Else
            PB6.Visible = True
            PB4.Visible = False

        End If
        If _
            upthour.Text = rsthour.Text And uptminute.Text = rstminute.Text And _
            uptsecond.Text = rstsecond.Text And uptframe.Text = rstframe.Text And _
            uplenhour.Text = rlhour.Text And uplenminute.Text = rlminute.Text And _
            uplensecond.Text = rlsecond.Text And uplenframe.Text = rlframe.Text _
            Then
            Button2.Enabled = True
            Button2.BackColor = Button1.BackColor
        Else

            Button2.Enabled = False
            Button2.BackColor = Color.Empty
        End If
    End Sub

    Private Sub uplenminute_TextChanged _
        (ByVal sender As Object, ByVal e As EventArgs) _
        Handles uplenminute.TextChanged
        If IsNumeric(uplenminute.Text) = False Then uplenminute.Text = "00"
        If uplenminute.TextLength = 2 Then
            uplensecond.Focus()
        End If
        If uplenminute.Text > 59 Then
            uplenminute.Text = "00"
            uplenminute.Focus()
        End If

        If _
            uplenhour.Text = rlhour.Text And uplenminute.Text = rlminute.Text And _
            uplensecond.Text = rlsecond.Text And uplenframe.Text = rlframe.Text _
            Then

            PB4.Visible = True
            PB6.Visible = False
        Else
            PB6.Visible = True
            PB4.Visible = False

        End If
        If _
            upthour.Text = rsthour.Text And uptminute.Text = rstminute.Text And _
            uptsecond.Text = rstsecond.Text And uptframe.Text = rstframe.Text And _
            uplenhour.Text = rlhour.Text And uplenminute.Text = rlminute.Text And _
            uplensecond.Text = rlsecond.Text And uplenframe.Text = rlframe.Text _
            Then
            Button2.Enabled = True
            Button2.BackColor = Button1.BackColor
        Else

            Button2.Enabled = False
            Button2.BackColor = Color.Empty
        End If
    End Sub

    Private Sub uplensecond_TextChanged _
        (ByVal sender As Object, ByVal e As EventArgs) _
        Handles uplensecond.TextChanged
        If IsNumeric(uplensecond.Text) = False Then uplensecond.Text = "00"
        If uplensecond.TextLength = 2 Then
            uplenframe.Focus()
        End If
        If uplensecond.Text > 59 Then
            uplensecond.Text = "00"
            uplensecond.Focus()
        End If
        If _
            uplenhour.Text = rlhour.Text And uplenminute.Text = rlminute.Text And _
            uplensecond.Text = rlsecond.Text And uplenframe.Text = rlframe.Text _
            Then

            PB4.Visible = True
            PB6.Visible = False
        Else
            PB6.Visible = True
            PB4.Visible = False

        End If
        If _
            upthour.Text = rsthour.Text And uptminute.Text = rstminute.Text And _
            uptsecond.Text = rstsecond.Text And uptframe.Text = rstframe.Text And _
            uplenhour.Text = rlhour.Text And uplenminute.Text = rlminute.Text And _
            uplensecond.Text = rlsecond.Text And uplenframe.Text = rlframe.Text _
            Then
            Button2.Enabled = True
            Button2.BackColor = Button1.BackColor
        Else

            Button2.Enabled = False
            Button2.BackColor = Color.Empty
        End If
    End Sub

    Private Sub uptframe_TextChanged _
        (ByVal sender As Object, ByVal e As EventArgs) _
        Handles uptframe.TextChanged
        If IsNumeric(uptframe.Text) = False Then uptframe.Text = "00"
        If uptframe.TextLength = 2 Then '输入时码的光标自动下移
            uplenhour.Focus()
        End If
        If uptframe.Text > 24 Then
            uptframe.Text = "00"
            uptframe.Focus()
        End If

        If _
            upthour.Text = rsthour.Text And uptminute.Text = rstminute.Text And _
            uptsecond.Text = rstsecond.Text And uptframe.Text = rstframe.Text _
            Then

            PB3.Visible = True
            PB5.Visible = False
        Else
            PB5.Visible = True
            PB3.Visible = False

        End If
        If _
            upthour.Text = rsthour.Text And uptminute.Text = rstminute.Text And _
            uptsecond.Text = rstsecond.Text And uptframe.Text = rstframe.Text And _
            uplenhour.Text = rlhour.Text And uplenminute.Text = rlminute.Text And _
            uplensecond.Text = rlsecond.Text And uplenframe.Text = rlframe.Text _
            Then
            Button2.Enabled = True
            Button2.BackColor = Button1.BackColor
        Else

            Button2.Enabled = False
            Button2.BackColor = Color.Empty
        End If
    End Sub

    Private Sub uplenframe_TextChanged _
        (ByVal sender As Object, ByVal e As EventArgs) _
        Handles uplenframe.TextChanged
        If IsNumeric(uplenframe.Text) = False Then uplenframe.Text = "00"
        If uplenframe.TextLength = 2 Then '输入时码的光标自动下移
            remarkTextBox.Focus()
            Call CalEndTime()

        End If

        If uplenframe.Text > 24 Then
            uplenframe.Text = "00"
            uplenframe.Focus()
        End If

        If _
            uplenhour.Text = rlhour.Text And uplenminute.Text = rlminute.Text And _
            uplensecond.Text = rlsecond.Text And uplenframe.Text = rlframe.Text _
            Then

            PB4.Visible = True
            PB6.Visible = False
        Else
            PB6.Visible = True
            PB4.Visible = False

        End If
        If _
            upthour.Text = rsthour.Text And uptminute.Text = rstminute.Text And _
            uptsecond.Text = rstsecond.Text And uptframe.Text = rstframe.Text And _
            uplenhour.Text = rlhour.Text And uplenminute.Text = rlminute.Text And _
            uplensecond.Text = rlsecond.Text And uplenframe.Text = rlframe.Text _
            Then
            Button2.Enabled = True
            Button2.BackColor = Button1.BackColor
        Else

            Button2.Enabled = False
            Button2.BackColor = Color.Empty
        End If
    End Sub

    Private Sub volumecheck2_CheckedChanged _
        (ByVal sender As Object, ByVal e As EventArgs) _
        Handles volumecheck2.CheckedChanged
    End Sub

    Private Sub Button7_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles Button7.Click
        tapeNameTextBox.Text = "" '重置页面
        source1.Text = ""
        upthour.Text = ""
        uptminute.Text = ""
        uptsecond.Text = ""
        uptframe.Text = ""
        uplenhour.Text = ""
        uplenminute.Text = ""
        uplensecond.Text = ""
        uplenframe.Text = ""
        upendhour.Text = ""
        upendminute.Text = ""
        upendsecond.Text = ""
        upendframe.Text = ""
        uploadtimeTextBox.Text = Now()
        volumecheck2.Checked = 0
        imagecheck2.Checked = 0
        episodecheck2.Checked = 0
        remarkTextBox.Text = ""
    End Sub

    Private Sub upendframe_TextChanged _
        (ByVal sender As Object, ByVal e As EventArgs) _
        Handles upendframe.TextChanged
    End Sub

    Private Sub CalEndTime()
        Dim endTimeH = 0, _
            endTimeM = 0, _
            endTimeS = 0, _
            endTimeF
        endTimeF = CInt(uptframe.Text) + CInt(uplenframe.Text) - 1 '帧相加
        If endTimeF > 24 Then '进位
            endTimeS += 1
            endTimeF -= 25
        ElseIf endTimeF < 0 Then '借位
            endTimeS -= 1
            endTimeF += 25
        End If
        endTimeS += CInt(uptsecond.Text) + CInt(uplensecond.Text)    '秒相加
        If endTimeS > 59 Then
            endTimeM += 1
            endTimeS -= 60
        ElseIf endTimeS < 0 Then
            endTimeM -= 1
            endTimeS += 60
        End If
        endTimeM += CInt(uptminute.Text) + CInt(uplenminute.Text)    '分相加
        If endTimeM > 59 Then
            endTimeH += 1
            endTimeM -= 60
        ElseIf endTimeM < 0 Then
            endTimeH -= 1
            endTimeM += 60
        End If
        endTimeH += CInt(upthour.Text) + CInt(uplenhour.Text)    '时相加
        If endTimeH < 0 Then '结束时码小于0，输入错误
            MsgBox("时码错误!")
        Else '输出，不足2位的补0
            upendframe.Text = Microsoft.VisualBasic.Right("00" & endTimeF, 2) _
            '帧，结果的左边补2个0后取右边2位
            upendsecond.Text = Microsoft.VisualBasic.Right("00" & endTimeS, 2)
            upendminute.Text = Microsoft.VisualBasic.Right("00" & endTimeM, 2)
            upendhour.Text = Microsoft.VisualBasic.Right("00" & endTimeH, 2)
        End If
    End Sub

    'Private Sub uploadstatus()
    '    Dim uploadsucces As String

    'End Sub
    Private Sub Label13_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles Label13.Click
    End Sub
End Class
