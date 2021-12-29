Public Class Form8
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        novo += 1
        Call CenterToScreen()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Form8_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        u(1, novo) = 5
        u(2, novo) = e.X
        u(3, novo) = e.Y
        u2(novo) = "Rato captado nas coordenadas X: " & e.X & " Y: " & e.Y & "."
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        novo -= 1
        Me.Close()
    End Sub
End Class