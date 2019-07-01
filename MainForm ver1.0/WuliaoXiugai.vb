Public Class WuliaoXiugai
    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)
        If m.Msg = &H84 Then
            If m.Result = 2 Then
                m.Result = 1
            End If
        End If
    End Sub

    Private Sub WuliaoXiugai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Size = New Size(1272, 746)
    End Sub

    Private Sub WuliaoXiugai_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        If Me.WindowState <> FormWindowState.Minimized Then
            Me.Close()
        End If
    End Sub
End Class