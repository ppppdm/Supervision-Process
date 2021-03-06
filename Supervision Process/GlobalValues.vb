﻿Module GlobalValues
    Public Xuhao As Integer '用来表征项目的序号
    Public Declare Function CreateWnd Lib "MyDll"() As Double
    Public Declare Function ClearGraphs Lib "MyDll"() As Double
    Public Declare Function OnpStillCapture Lib "MyDll"(ByVal hwnd As Long) _
        As Double
    Public Declare Function InitStillGraph Lib "MyDll"(ByVal hwnd As Long) _
        As Double
    Public Declare Function CloseWnd Lib "MyDll"() As Double
    Public Declare Function CapDlgToFile Lib "MyDll" _
        (ByVal source_hwnd As Long, _
         ByVal picture_hwnd As Long, _
         ByVal thirds As Long) As Long
    Public Declare Function CapDlgTest Lib "MyDll" _
        (ByVal a As Long, ByVal b As Long) As Integer
    Public Declare Function LoadBmpFileToStatic Lib "MyDll" _
        (ByVal a As Long, _
         ByVal b As Long, _
         ByVal c As Long, _
         ByVal d As Long, _
         ByVal e As Long) As Integer
    Public Declare Function EncBmpToJpg Lib "MyDll" _
        (ByVal filename_bmp As String, ByVal filename_jpg As String) As Integer

    'Public Declare Sub Sleep Lib "kernel32" Alias "Sleep" (ByVal dwMilliseconds As Long)
    'Public ppid As Integer '用来表征项目编号，唯一标识
    'Public flag As Integer '用来表征是操作的第几步
    'Public upcutflag As Integer '用来表征上载截图是否按下
    'Public cutpicsrc As Integer '用来表征和截屏幕截图是否按下
    'Public pid As Integer '用来表征节目的序号，唯一标识
    'Public cutcount As Integer '用来表征截图按钮是否被按下，按下为1，没按下为0
    'Public cutcountsrc As Integer '用来表征屏幕截图按钮是否被按下，按下为1，没按下为0
    'Public updown As Integer  '用来表征点击“下一步”是第一次走还是通过点击“上一步”再点击的“下一步”，前者为0，后者为1
    'Public picflag As Integer '用来表征数据库中是否已有截图，如果有则为1，没有则为0.当其为1时，在点击“下一步”时，不用截图
    'Public lookflag = 1  '用来表征回看项目到哪一步了，默认为1，在第一步


    Public _
        piclocation = _
            "D:\MyBackup\我的文档\Visual Studio 2008\Projects\上载管理\WindowsApplication1\bin\Debug\warning.png"

    Public _
        cutscrjpg = _
            "D:\MyBackup\我的文档\Visual Studio 2008\Projects\上载管理\WindowsApplication1\bin\Debug\cutscr.jpg"

    Public _
        cutbmp = _
            "D:\MyBackup\我的文档\Visual Studio 2008\Projects\上载管理\WindowsApplication1\bin\Debug\StillCap0000.bmp"

    Public _
        cutscrbmp = _
            "D:\MyBackup\我的文档\Visual Studio 2008\Projects\上载管理\WindowsApplication1\bin\Debug\CapDLG0000.bmp"

    Public _
        cutjpg = _
            "D:\MyBackup\我的文档\Visual Studio 2008\Projects\上载管理\WindowsApplication1\bin\Debug\cutvideo.jpg"



    '配置文件
    Public ConfigFile As String = ".\config.ini"
    '数据库DB配置
    Public DbServer As String = "localhost"
    Public DbDbNamme As String = "nntv_ps"
    Public DbUser As String = "sa"
    Public DbPawd As String = "nntv@2014"
    Public ConnStr = ""

    '审核点设置
    Public CheckPoint1 As Integer = 30

    '高级查询选项启用 Ao = advanced options
    Public AoNotUpdate As Boolean = True
    Public AoNotCheckUp As Boolean = True
    Public AoHadCheckUp As Boolean = False
    Public AoDateAndTime As Boolean = True

    '查询内容显示设置 Swo = show options
    'Public SwoTapeName = True ' not modify
    'Public SwoTapeStatus = True ' not modify

    'Public SwoTapeLength = True
    'Public SwoTapeSendInTime = True
    'Public SwoTapeSendInSendPer = False
    'Public SwoTapeSendInRecvPer = False
    'Public SwoTapeSendOutTime = True
    'Public SwoTapeSendOutSendPer = False
    'Public SwoTapeSendOutRecvPer = False

    '{"","","",bool} = {该变量名称, 数据库中的列名, 显示在dataGridView中的名字,用户配置是否显示该列}
    Public Const SwoName = 0
    Public Const SwoDbColumnName = 1
    Public Const SwoDataViewName = 2
    Public Const SwoValue = 3
    Public SwoTrueOptionsCount = 0 ' need be init or change if user change swo

    Public Swo As Object(,) = _
            {{"SwoTapeName", "tape_name", "名称", True}, _
             {"SwoTapeStatus", "tape_status", "状态", False}, _
             {"SwoTapeLength", "length", "时长", True}, _
             {"SwoTapeSendInTime", "in_bc_time", "送带时间", True}, _
             {"SwoTapeSendInSendPer", "in_bc_send_per", "送带人", False}, _
             {"SwoTapeSendInRecvPer", "in_bc_recv_per", "接带人", False}, _
             {"SwoTapeSendOutTime", "out_bc_time", "取代时间", False}, _
             {"SwoTapeSendOutSendPer", "out_bc_send_per", "发带人", False}, _
             {"SwoTapeSendOutRecvPer", "out_bc_recv_per", "取带人", False}}
End Module
