Public Class Form10
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        new1 -= 1

    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        new1 += 1
        Call CenterToScreen()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Form10_Click(sender As Object, e As EventArgs) Handles Me.Click

    End Sub

    Private Sub Form10_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        w(1, new1) = 16
        w(2, new1) = e.X
        w(3, new1) = e.Y
        w2(new1) = "Rato captado nas coordenadas X: " & e.X & " Y: " & e.Y & "."
        Me.Close()
    End Sub
End Class