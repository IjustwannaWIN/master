Public Class mdiForm1
    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)
        If m.Msg = &H84 Then
            If m.Result = 2 Then
                m.Result = 1
            End If
        End If
    End Sub
    '使得子窗体不可拖动
    Private Sub mdiForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        '设置子窗体为边框为有属性栏的类型
        Me.MaximizeBox = False
        '把子窗体的最大化按钮关闭
        Me.Size = New Size(1272, 746)
        '重新调整子窗体为适当大小
    End Sub
End Class