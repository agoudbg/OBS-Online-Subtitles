Module Module1
    Public fulltext
    Public path = System.Environment.CurrentDirectory
    Public whattosend = "<p id=" + Chr(34) + "small" + Chr(34) + "></p><p id=" + Chr(34) + "big" + Chr(34) + "></p><style>#little-png,#small {margin-left:2000px;} #title-png {margin-left:2000px;}</style>"
    Public whattosend2 = "<p id=" + Chr(34) + "small" + Chr(34) + "></p><p id=" + Chr(34) + "big" + Chr(34) + "></p><style>#little-png,#small {margin-left:2000px;} #title-png {margin-left:2000px;}</style>"
    Public sendcache
    Public sendcache2
    Public sidelogo = "margin-left:-800px;"
    Dim firstco
    Public lines
    Public titles(1, 1)
    Dim cache
    Public nownum = 0

    Private Declare Function timeGetTime Lib "winmm.dll" () As Long '该声明得到系统开机到现在的时间(单位：毫秒)
    Public Function Sleep2(T As Long)
        Dim Savetime As Long
        Savetime = timeGetTime '记下开始时的时间
        While timeGetTime < Savetime + T '循环等待
        End While

    End Function
    Public Function finish(text)
        fulltext = text
        MsgBox("导入成功")
        lines = (Len(text) - Len(Replace(text, Chr(10), "")))
        ReDim titles(Len(text) - Len(Replace(text, Chr(10), "")), 1)
        For firstco = 0 To Len(text) - Len(Replace(text, Chr(10), ""))
            cache = Split(text, Chr(10))(firstco)
            titles(firstco, 0) = Split(cache, Chr(9))(0)
            titles(firstco, 1) = Split(cache, Chr(9))(1)


        Next firstco

    End Function


End Module
