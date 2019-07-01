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

    Private Sub 菜品信息查询ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 菜品信息查询ToolStripMenuItem.Click
        If CaipinChaxun.Visible = 0 Then
            CaipinChaxun.MdiParent = Me
            CaipinChaxun.Show()
            CaipinChaxun.Top = 0
            CaipinChaxun.Left = 0
        End If
    End Sub

    Private Sub 菜品信息修改ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 菜品信息修改ToolStripMenuItem.Click
        If CaipinXiugai.Visible = 0 Then
            CaipinXiugai.MdiParent = Me
            CaipinXiugai.Show()
            CaipinXiugai.Top = 0
            CaipinXiugai.Left = 0
        End If
    End Sub

    Private Sub 库存信息查询ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 库存信息查询ToolStripMenuItem.Click
        If WuliaoChaxun.Visible = 0 Then
            WuliaoChaxun.MdiParent = Me
            WuliaoChaxun.Show()
            WuliaoChaxun.Top = 0
            WuliaoChaxun.Left = 0
        End If
    End Sub

    Private Sub 物料信息修改ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 物料信息修改ToolStripMenuItem.Click
        If WuliaoXiugai.Visible = 0 Then
            WuliaoXiugai.MdiParent = Me
            WuliaoXiugai.Show()
            WuliaoXiugai.Top = 0
            WuliaoXiugai.Left = 0
        End If
    End Sub

    Private Sub 个人信息查询ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 个人信息查询ToolStripMenuItem.Click
        If GerenXinxiChaxun.Visible = 0 Then
            GerenXinxiChaxun.MdiParent = Me
            GerenXinxiChaxun.Show()
            GerenXinxiChaxun.Top = 0
            GerenXinxiChaxun.Left = 0
        End If

    End Sub

    Private Sub 个人信息修改ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 个人信息修改ToolStripMenuItem.Click
        If GerenXinxiXiugai.Visible = 0 Then
            GerenXinxiXiugai.MdiParent = Me
            GerenXinxiXiugai.Show()
            GerenXinxiXiugai.Top = 0
            GerenXinxiXiugai.Left = 0
        End If
    End Sub

    Private Sub 餐台预定ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 餐台预定ToolStripMenuItem.Click
        If CantaiYuding.Visible = 0 Then
            CantaiYuding.MdiParent = Me
            CantaiYuding.Show()
            CantaiYuding.Top = 0
            CantaiYuding.Left = 0
        End If
    End Sub

    Private Sub 订单查询ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 订单查询ToolStripMenuItem.Click
        If DingdanChaxun.Visible = 0 Then
            DingdanChaxun.MdiParent = Me
            DingdanChaxun.Show()
            DingdanChaxun.Top = 0
            DingdanChaxun.Left = 0
        End If
    End Sub

    Private Sub 开台管理ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 开台管理ToolStripMenuItem.Click
        If KaitaiGuanli.Visible = 0 Then
            KaitaiGuanli.MdiParent = Me
            KaitaiGuanli.Show()
            KaitaiGuanli.Top = 0
            KaitaiGuanli.Left = 0
        End If
    End Sub

    Private Sub 收银管理ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 收银管理ToolStripMenuItem.Click
        If ShouyinGuanli.Visible = 0 Then
            ShouyinGuanli.MdiParent = Me
            ShouyinGuanli.Show()
            ShouyinGuanli.Top = 0
            ShouyinGuanli.Left = 0
        End If
    End Sub

    Private Sub 账单查询ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 账单查询ToolStripMenuItem.Click
        If ZhangdanChaxun.Visible = 0 Then
            ZhangdanChaxun.MdiParent = Me
            ZhangdanChaxun.Show()
            ZhangdanChaxun.Top = 0
            ZhangdanChaxun.Left = 0
        End If
    End Sub

    Private Sub 权限管理ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 权限管理ToolStripMenuItem.Click
        If QuanxianKongzhi.Visible = 0 Then
            QuanxianKongzhi.MdiParent = Me
            QuanxianKongzhi.Show()
            QuanxianKongzhi.Top = 0
            QuanxianKongzhi.Left = 0
        End If
    End Sub

    Private Sub 报表生成ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 报表生成ToolStripMenuItem.Click
        If BaobiaoShengcheng.Visible = 0 Then
            BaobiaoShengcheng.MdiParent = Me
            BaobiaoShengcheng.Show()
            BaobiaoShengcheng.Top = 0
            BaobiaoShengcheng.Left = 0
        End If
    End Sub

    Private Sub 订单查询ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 订单查询ToolStripMenuItem1.Click
        If DingdanChaxun.Visible = 0 Then
            DingdanChaxun.MdiParent = Me
            DingdanChaxun.Show()
            DingdanChaxun.Top = 0
            DingdanChaxun.Left = 0
        End If
    End Sub

    Private Sub 账单查询ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 账单查询ToolStripMenuItem1.Click
        If ZhangdanChaxun.Visible = 0 Then
            ZhangdanChaxun.MdiParent = Me
            ZhangdanChaxun.Show()
            ZhangdanChaxun.Top = 0
            ZhangdanChaxun.Left = 0
        End If
    End Sub

    Private Sub 查看帮助ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 查看帮助ToolStripMenuItem.Click
        If ChakanBangzhu.Visible = 0 Then
            ChakanBangzhu.MdiParent = Me
            ChakanBangzhu.Show()
            ChakanBangzhu.Top = 0
            ChakanBangzhu.Left = 0
        End If
    End Sub

    Private Sub 关于本程序ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于本程序ToolStripMenuItem.Click
        If Guanyu.Visible = 0 Then
            Guanyu.MdiParent = Me
            Guanyu.Show()
            Guanyu.Top = 0
            Guanyu.Left = 0
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
