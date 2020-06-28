Imports System.ComponentModel

Public Class main

    Public Sub New()
        InitializeComponent()
        BackgroundWorker1.WorkerReportsProgress = True
        BackgroundWorker1.WorkerSupportsCancellation = True
    End Sub


    Function gettitle(num)
        nownum = nownum + num
        If (nownum = -1) Then
            MsgBox("啊哦 这已经是最前一条了")
            nownum = 0
            gettitle(0)
        ElseIf (nownum = 0) Then
            lastsmall.Text = ""
            lastbig.Text = ""
            nowsmall.Text = titles(nownum, 0)
            nowbig.Text = titles(nownum, 1)
            nextsmall.Text = titles(nownum + 1, 0)
            nextbig.Text = titles(nownum + 1, 1)
        ElseIf (nownum = lines) Then
            lastsmall.Text = titles(nownum - 1, 0)
            lastbig.Text = titles(nownum - 1, 1)
            nowsmall.Text = titles(nownum, 0)
            nowbig.Text = titles(nownum, 1)
            nextsmall.Text = ""
            nextbig.Text = ""
        ElseIf (nownum = lines + 1) Then
            MsgBox("啊哦 这已经是最后一条了")
            nownum = lines
        Else
            lastsmall.Text = titles(nownum - 1, 0)
            lastbig.Text = titles(nownum - 1, 1)
            nowsmall.Text = titles(nownum, 0)
            nowbig.Text = titles(nownum, 1)
            nextsmall.Text = titles(nownum + 1, 0)
            nextbig.Text = titles(nownum + 1, 1)
        End If
        Dim bigtext
        Dim smalltext
        Dim bigsta
        Dim smallsta
        bigtext = nowbig.Text
        smalltext = nowsmall.Text
        If bigtext = vbCr Then
            bigsta = "#title-png,#title {margin-left:2000px;}"
        Else
            bigsta = "  "
        End If
        If smalltext = "" Then
            smallsta = "#little-png,#little-title {margin-left:2000px;}"
        Else
            smallsta = "  "
        End If

        pause.Text = "收起"

        whattosend = ("<p id=" + Chr(34) + "big" + Chr(34) + ">" + bigtext + "</p><style>" + bigsta + "</style>")
        whattosend2 = ("<p id=" + Chr(34) + "small" + Chr(34) + ">" + smalltext + "</p><style>" + smallsta + "</style>")
        'MsgBox(path)
        My.Computer.FileSystem.WriteAllText(path + "/config.txt", whattosend, False)
        My.Computer.FileSystem.WriteAllText(path + "/config-s.txt", whattosend2, False)

    End Function
    Private Sub single_clear_Click(sender As Object, e As EventArgs) Handles single_clear.Click
        TextBox2.Text = ""
        TextBox1.Text = ""
    End Sub

    Private Sub single_go_Click(sender As Object, e As EventArgs) Handles single_go.Click
        '单条模式发送
        Dim bigtext
        Dim smalltext
        Dim bigsta
        Dim smallsta
        bigtext = TextBox2.Text
        smalltext = TextBox1.Text
        If TextBox1.Text = "" Then
            bigsta = "#title-png,#title {margin-left:2000px;}"
        Else
            bigsta = "  "
        End If
        If TextBox2.Text = "" Then
            smallsta = "#little-png,#little-title {margin-left:2000px;}"
        Else
            smallsta = "  "
        End If
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            sendcache = whattosend
            sendcache2 = whattosend2
            pause.Text = "撤销"
        Else
            pause.Text = "收起"
        End If
        whattosend = ("<p id=" + Chr(34) + "big" + Chr(34) + ">" + TextBox1.Text + "</p><style>" + bigsta + "</style>")
        whattosend2 = ("<p id=" + Chr(34) + "small" + Chr(34) + ">" + TextBox2.Text + "</p><style>" + smallsta + "</style>")
        'MsgBox(path)
        My.Computer.FileSystem.WriteAllText(path + "/config.txt", whattosend, False)
        My.Computer.FileSystem.WriteAllText(path + "/config-s.txt", whattosend2, False)


    End Sub

    Private Sub side_logo_Click(sender As Object, e As EventArgs) Handles side_logo.Click
        Dim sidesend
        If sidelogo = "margin-left:-800px;" Then
            sidelogo = ""
        Else
            sidelogo = "margin-left:-800px;"
        End If
        sidesend = ("<style>#side {" + sidelogo + " ;}</style>")
        My.Computer.FileSystem.WriteAllText(path + "/side.txt", sidesend, False)

    End Sub





    Private Sub pause_Click(sender As Object, e As EventArgs) Handles pause.Click

        If pause.Text = "收起" Then
            sendcache = whattosend
            sendcache2 = whattosend2

            whattosend = "<p id=" + Chr(34) + "big" + Chr(34) + "></p><style> #title-png,#title {margin-left:2000px;}</style>"
            whattosend2 = "<p id=" + Chr(34) + "small" + Chr(34) + "></p><style> #little-png,#little-title {margin-left:2000px;}</style>"
            pause.Text = "打开"
        Else
            whattosend = sendcache
            whattosend2 = sendcache2
            pause.Text = "收起"
        End If
        My.Computer.FileSystem.WriteAllText(path + "/config.txt", whattosend, False)
        My.Computer.FileSystem.WriteAllText(path + "/config-s.txt", whattosend2, False)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Shell("Rundll32.exe url.dll, FileProtocolHandler https://junbo.wang", vbNormalFocus)
    End Sub


    Private Sub Label4_DoubleClick(sender As Object, e As EventArgs) Handles ver.DoubleClick
        ver.Text = ("开发模式已启用" + ver.Text)
        path = ("D:/项目/网站/229.junbo.wang/test")
    End Sub

    Private Sub ver_Click(sender As Object, e As EventArgs) Handles ver.Click
        ver.Text = ("哈哈 你真聪明 发现彩蛋咯" + ver.Text)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            If BackgroundWorker1.IsBusy <> True Then
                ' Start the asynchronous operation.
                BackgroundWorker1.RunWorkerAsync()
            End If

        Else
            If BackgroundWorker1.WorkerSupportsCancellation = True Then
                ' Cancel the asynchronous operation.
                BackgroundWorker1.CancelAsync()
            End If
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork()

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        While True
            My.Computer.FileSystem.WriteAllText(path + "/side.txt", "<!-->", True)
            My.Computer.FileSystem.WriteAllText(path + "/config.txt", "<!-->", True)
            My.Computer.FileSystem.WriteAllText(path + "/config-s.txt", "<!-->", True)

            Sleep2(2000)
        End While
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Shell("Rundll32.exe url.dll, FileProtocolHandler https://junbo.wang/?page_id=151", vbNormalFocus)
    End Sub

    Private Sub daoru_Click_1(sender As Object, e As EventArgs) Handles daoru.Click
        Dialog1.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MsgBox(titles(1, 1))

    End Sub

    Private Sub nextone_Click(sender As Object, e As EventArgs) Handles nextone.Click

        gettitle(1)
    End Sub

    Private Sub last_Click(sender As Object, e As EventArgs) Handles last.Click
        gettitle(-1)
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Shell("Rundll32.exe url.dll, FileProtocolHandler https://junbo.wang/?p=565", vbNormalFocus)

    End Sub
End Class