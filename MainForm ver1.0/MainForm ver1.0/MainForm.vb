Public Class MainForm
    Public stTime, curTime As Date
    Public timeDuration As Long

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stTime = Now()
        ToolStripStatusLabel1.Text = "当前用户："
        ToolStripStatusLabel2.Text = ""
        ToolStripStatusLabel4.Text = "已运行时间："
        ToolStripStatusLabel6.Text = "当前时间："
        Me.Timer1.Interval = 1000
        Me.Timer1.Enabled = True
        backImg.MdiParent = Me
        mdiForm1.MdiParent = Me
        '添加 mdiForm1 窗体为子窗体
        backImg.Hide()
        '隐藏背景图片所在的窗体
        mdiForm1.Show()
        '把添加的mdiForm1子窗体显示出来
        Me.ToolStripStatusLabel3.Alignment = ToolStripItemAlignment.Right
        Me.ToolStripStatusLabel4.Alignment = ToolStripItemAlignment.Right
        Me.ToolStripStatusLabel5.Alignment = ToolStripItemAlignment.Right
        Me.ToolStripStatusLabel6.Alignment = ToolStripItemAlignment.Right
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If mdiForm1.Visible = 0 Then
            mdiForm1.MdiParent = Me
            mdiForm1.Show()
            mdiForm1.Top = 0
            mdiForm1.Left = 0
            '添加，显示，重调子窗体位置
        Else
            mdiForm1.Close()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel5.Text = Now()
        '输出现在的时间
        curTime = Now()
        timeDuration = DateDiff("s", stTime, curTime)
        ToolStripStatusLabel3.Text = Int(timeDuration / 3600 Mod 24) & ":" & Int(timeDuration / 60 Mod 60) & ":" & Int(timeDuration Mod 60)
        '输出系统运行的时间
    End Sub
End Class
