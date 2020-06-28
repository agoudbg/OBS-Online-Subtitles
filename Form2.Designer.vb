<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.tit = New System.Windows.Forms.Label()
        Me.设置 = New System.Windows.Forms.TabControl()
        Me.Tab = New System.Windows.Forms.TabPage()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.single_clear = New System.Windows.Forms.Button()
        Me.single_go = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.single_label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.single_label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.nextbig = New System.Windows.Forms.Label()
        Me.nextsmall = New System.Windows.Forms.Label()
        Me.lastbig = New System.Windows.Forms.Label()
        Me.lastsmall = New System.Windows.Forms.Label()
        Me.nextone = New System.Windows.Forms.Button()
        Me.last = New System.Windows.Forms.Button()
        Me.nowbig = New System.Windows.Forms.Label()
        Me.nowsmall = New System.Windows.Forms.Label()
        Me.daoru = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ver = New System.Windows.Forms.Label()
        Me.pause = New System.Windows.Forms.Button()
        Me.side_logo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.设置.SuspendLayout()
        Me.Tab.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tit
        '
        Me.tit.AutoSize = True
        Me.tit.Font = New System.Drawing.Font("微软雅黑", 18.0!)
        Me.tit.Location = New System.Drawing.Point(12, 7)
        Me.tit.Name = "tit"
        Me.tit.Size = New System.Drawing.Size(317, 39)
        Me.tit.TabIndex = 0
        Me.tit.Text = "阿狗OBS包装管理系统"
        '
        '设置
        '
        Me.设置.Controls.Add(Me.Tab)
        Me.设置.Controls.Add(Me.TabPage2)
        Me.设置.Controls.Add(Me.TabPage1)
        Me.设置.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.设置.Location = New System.Drawing.Point(12, 51)
        Me.设置.Name = "设置"
        Me.设置.RightToLeftLayout = True
        Me.设置.SelectedIndex = 0
        Me.设置.Size = New System.Drawing.Size(561, 206)
        Me.设置.TabIndex = 1
        '
        'Tab
        '
        Me.Tab.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Tab.Controls.Add(Me.CheckBox1)
        Me.Tab.Controls.Add(Me.single_clear)
        Me.Tab.Controls.Add(Me.single_go)
        Me.Tab.Controls.Add(Me.TextBox1)
        Me.Tab.Controls.Add(Me.single_label2)
        Me.Tab.Controls.Add(Me.TextBox2)
        Me.Tab.Controls.Add(Me.single_label1)
        Me.Tab.Location = New System.Drawing.Point(4, 32)
        Me.Tab.Name = "Tab"
        Me.Tab.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab.Size = New System.Drawing.Size(553, 170)
        Me.Tab.TabIndex = 0
        Me.Tab.Text = "单条模式"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(10, 132)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(134, 27)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "快速更新模式"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'single_clear
        '
        Me.single_clear.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.single_clear.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.single_clear.Location = New System.Drawing.Point(360, 124)
        Me.single_clear.Name = "single_clear"
        Me.single_clear.Size = New System.Drawing.Size(88, 40)
        Me.single_clear.TabIndex = 3
        Me.single_clear.Text = "清除"
        Me.single_clear.UseVisualStyleBackColor = False
        '
        'single_go
        '
        Me.single_go.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.single_go.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.single_go.Location = New System.Drawing.Point(454, 124)
        Me.single_go.Name = "single_go"
        Me.single_go.Size = New System.Drawing.Size(88, 40)
        Me.single_go.TabIndex = 4
        Me.single_go.Text = "应用"
        Me.single_go.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.TextBox1.Location = New System.Drawing.Point(83, 74)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox1.Size = New System.Drawing.Size(350, 29)
        Me.TextBox1.TabIndex = 2
        '
        'single_label2
        '
        Me.single_label2.AutoSize = True
        Me.single_label2.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.single_label2.Location = New System.Drawing.Point(5, 74)
        Me.single_label2.Name = "single_label2"
        Me.single_label2.Size = New System.Drawing.Size(69, 25)
        Me.single_label2.TabIndex = 0
        Me.single_label2.Text = "大标题"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.TextBox2.Location = New System.Drawing.Point(83, 26)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox2.Size = New System.Drawing.Size(350, 29)
        Me.TextBox2.TabIndex = 1
        '
        'single_label1
        '
        Me.single_label1.AutoSize = True
        Me.single_label1.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.single_label1.Location = New System.Drawing.Point(5, 26)
        Me.single_label1.Name = "single_label1"
        Me.single_label1.Size = New System.Drawing.Size(69, 25)
        Me.single_label1.TabIndex = 0
        Me.single_label1.Text = "小标题"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage2.Controls.Add(Me.nextbig)
        Me.TabPage2.Controls.Add(Me.nextsmall)
        Me.TabPage2.Controls.Add(Me.lastbig)
        Me.TabPage2.Controls.Add(Me.lastsmall)
        Me.TabPage2.Controls.Add(Me.nextone)
        Me.TabPage2.Controls.Add(Me.last)
        Me.TabPage2.Controls.Add(Me.nowbig)
        Me.TabPage2.Controls.Add(Me.nowsmall)
        Me.TabPage2.Controls.Add(Me.daoru)
        Me.TabPage2.Location = New System.Drawing.Point(4, 32)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(553, 170)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "串联模式"
        '
        'nextbig
        '
        Me.nextbig.Location = New System.Drawing.Point(228, 117)
        Me.nextbig.Name = "nextbig"
        Me.nextbig.Size = New System.Drawing.Size(226, 23)
        Me.nextbig.TabIndex = 10
        '
        'nextsmall
        '
        Me.nextsmall.Location = New System.Drawing.Point(6, 117)
        Me.nextsmall.Name = "nextsmall"
        Me.nextsmall.Size = New System.Drawing.Size(211, 23)
        Me.nextsmall.TabIndex = 11
        '
        'lastbig
        '
        Me.lastbig.Location = New System.Drawing.Point(228, 17)
        Me.lastbig.Name = "lastbig"
        Me.lastbig.Size = New System.Drawing.Size(226, 23)
        Me.lastbig.TabIndex = 8
        '
        'lastsmall
        '
        Me.lastsmall.Location = New System.Drawing.Point(6, 17)
        Me.lastsmall.Name = "lastsmall"
        Me.lastsmall.Size = New System.Drawing.Size(211, 23)
        Me.lastsmall.TabIndex = 9
        '
        'nextone
        '
        Me.nextone.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.nextone.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.nextone.Location = New System.Drawing.Point(453, 92)
        Me.nextone.Name = "nextone"
        Me.nextone.Size = New System.Drawing.Size(88, 40)
        Me.nextone.TabIndex = 6
        Me.nextone.Text = "下一条"
        Me.nextone.UseVisualStyleBackColor = False
        '
        'last
        '
        Me.last.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.last.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.last.Location = New System.Drawing.Point(453, 46)
        Me.last.Name = "last"
        Me.last.Size = New System.Drawing.Size(88, 40)
        Me.last.TabIndex = 5
        Me.last.Text = "上一条"
        Me.last.UseVisualStyleBackColor = False
        '
        'nowbig
        '
        Me.nowbig.Font = New System.Drawing.Font("微软雅黑", 10.0!, System.Drawing.FontStyle.Bold)
        Me.nowbig.Location = New System.Drawing.Point(228, 58)
        Me.nowbig.Name = "nowbig"
        Me.nowbig.Size = New System.Drawing.Size(226, 60)
        Me.nowbig.TabIndex = 7
        '
        'nowsmall
        '
        Me.nowsmall.Font = New System.Drawing.Font("微软雅黑", 10.0!, System.Drawing.FontStyle.Bold)
        Me.nowsmall.Location = New System.Drawing.Point(6, 58)
        Me.nowsmall.Name = "nowsmall"
        Me.nowsmall.Size = New System.Drawing.Size(211, 60)
        Me.nowsmall.TabIndex = 7
        Me.nowsmall.Text = "还没有导入，请导入，然后点击""上一条"""
        '
        'daoru
        '
        Me.daoru.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.daoru.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.daoru.Location = New System.Drawing.Point(453, 6)
        Me.daoru.Name = "daoru"
        Me.daoru.Size = New System.Drawing.Size(88, 34)
        Me.daoru.TabIndex = 4
        Me.daoru.Text = "导入"
        Me.daoru.UseVisualStyleBackColor = False
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.LinkLabel3)
        Me.TabPage1.Controls.Add(Me.LinkLabel2)
        Me.TabPage1.Controls.Add(Me.LinkLabel1)
        Me.TabPage1.Controls.Add(Me.ver)
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(553, 170)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "关于"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(370, 40)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Copyright 2019-2020 Junbo's Blog. All rights reserved." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "本程序所有功能均为免费，严禁变卖。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LinkLabel3
        '
        Me.LinkLabel3.ActiveLinkColor = System.Drawing.Color.Black
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(20, 95)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(78, 23)
        Me.LinkLabel3.TabIndex = 8
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "支持作者"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.ActiveLinkColor = System.Drawing.Color.Black
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(20, 38)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(146, 23)
        Me.LinkLabel2.TabIndex = 7
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "使用帮助（待写）"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(20, 66)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(112, 23)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "访问作者博客"
        '
        'ver
        '
        Me.ver.AutoSize = True
        Me.ver.Location = New System.Drawing.Point(20, 6)
        Me.ver.Name = "ver"
        Me.ver.Size = New System.Drawing.Size(181, 23)
        Me.ver.TabIndex = 5
        Me.ver.Text = "当前软件版本：0.0.1.2"
        '
        'pause
        '
        Me.pause.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pause.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.pause.Location = New System.Drawing.Point(480, 259)
        Me.pause.Name = "pause"
        Me.pause.Size = New System.Drawing.Size(88, 40)
        Me.pause.TabIndex = 6
        Me.pause.Text = "打开"
        Me.pause.UseVisualStyleBackColor = False
        '
        'side_logo
        '
        Me.side_logo.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.side_logo.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.side_logo.Location = New System.Drawing.Point(16, 259)
        Me.side_logo.Name = "side_logo"
        Me.side_logo.Size = New System.Drawing.Size(88, 40)
        Me.side_logo.TabIndex = 5
        Me.side_logo.Text = "角标"
        Me.side_logo.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(343, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "by 阿狗爱骨头"
        '
        'BackgroundWorker1
        '
        '
        'main
        '
        Me.AcceptButton = Me.single_go
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(580, 306)
        Me.Controls.Add(Me.设置)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.side_logo)
        Me.Controls.Add(Me.tit)
        Me.Controls.Add(Me.pause)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "阿狗OBS包装管理系统"
        Me.TopMost = True
        Me.设置.ResumeLayout(False)
        Me.Tab.ResumeLayout(False)
        Me.Tab.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tit As Label
    Friend WithEvents 设置 As TabControl
    Friend WithEvents Tab As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents single_label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents side_logo As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents single_label2 As Label
    Friend WithEvents single_clear As Button
    Friend WithEvents single_go As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ver As Label
    Friend WithEvents daoru As Button
    Friend WithEvents nextone As Button
    Friend WithEvents last As Button
    Friend WithEvents nowbig As Label
    Friend WithEvents nowsmall As Label
    Friend WithEvents nextbig As Label
    Friend WithEvents nextsmall As Label
    Friend WithEvents lastbig As Label
    Friend WithEvents lastsmall As Label
    Friend WithEvents pause As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label2 As Label
End Class
