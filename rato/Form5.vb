Public Class Form5
    Public temp As Integer
    Public ok As Boolean
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        novo += 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        u(1, novo) = 3
        ok = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Button1.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        u(1, novo) = 1
        ok = True


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button1.Enabled = False
        Button2.Enabled = False
        Button4.Enabled = False
        u(1, novo) = 2
        ok = True

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        u(1, novo) = 4
        ok = True


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If ok Then
            If Len(TextBox1.Text) > 0 Then


                temp = TextBox1.Text
                u(2, novo) = temp
                If Button1.Enabled Then
                    u2(novo) = "O rato vai mover-se " & temp & " píxeis para cima."
                ElseIf Button2.Enabled Then
                    u2(novo) = "O rato vai mover-se " & temp & " píxeis para a esquerda."
                ElseIf Button3.Enabled Then
                    u2(novo) = "o rato vai mover-se " & temp & "  píxeis para a direita."
                ElseIf Button4.Enabled Then
                    u2(novo) = "O rato vai mover-se " & temp & " píxeis para baixo."
                End If
            Else
                TextBox1.Text = "Introduza algum número"
            End If

        End If
        Me.Close()


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        novo -= 1
        Me.Close()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        If TextBox1.Text = "Introduza algum número" Then
            TextBox1.Clear()
        End If
    End Sub
End Class