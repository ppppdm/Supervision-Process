Module GlobalValues

    Public Xuhao As Integer '用来表征项目的序号
    Public Declare Function CreateWnd Lib "MyDll" () As Double
    Public Declare Function ClearGraphs Lib "MyDll" () As Double
    Public Declare Function OnpStillCapture Lib "MyDll" (ByVal hwnd As Long) As Double
    Public Declare Function InitStillGraph Lib "MyDll" (ByVal hwnd As Long) As Double
    Public Declare Function CloseWnd Lib "MyDll" () As Double
    Public Declare Function CapDlgToFile Lib "MyDll" (ByVal source_hwnd As Long, ByVal picture_hwnd As Long, ByVal thirds As Long) As Long
    Public Declare Function CapDlgTest Lib "MyDll" (ByVal a As Long, ByVal b As Long) As Integer
    Public Declare Function LoadBmpFileToStatic Lib "MyDll" (ByVal a As Long, ByVal b As Long, ByVal c As Long, ByVal d As Long, ByVal e As Long) As Integer
    Public Declare Function EncBmpToJpg Lib "MyDll" (ByVal filename_bmp As String, ByVal filename_jpg As String) As Integer

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


    Public piclocation = "D:\MyBackup\我的文档\Visual Studio 2008\Projects\上载管理\WindowsApplication1\bin\Debug\warning.png"
    Public cutscrjpg = "D:\MyBackup\我的文档\Visual Studio 2008\Projects\上载管理\WindowsApplication1\bin\Debug\cutscr.jpg"
    Public cutbmp = "D:\MyBackup\我的文档\Visual Studio 2008\Projects\上载管理\WindowsApplication1\bin\Debug\StillCap0000.bmp"
    Public cutscrbmp = "D:\MyBackup\我的文档\Visual Studio 2008\Projects\上载管理\WindowsApplication1\bin\Debug\CapDLG0000.bmp"
    Public cutjpg = "D:\MyBackup\我的文档\Visual Studio 2008\Projects\上载管理\WindowsApplication1\bin\Debug\cutvideo.jpg"

    Public connstr = "Server=localhost;Database=nntv_ps;User ID=sa;Password=12345;"

End Module
