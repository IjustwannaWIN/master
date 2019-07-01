Public Class backImg
    Private Sub backImg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        '边框样式，none为无边框
        'Me.BackgroundImage = System.Drawing.Image.FromFile("")
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.Size = New Size(1272, 746)
    End Sub
End Class