Public Class Form7
    Dim ok As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        ok = True
        w(1, new1) = 3




    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        new1 += 1

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        ok = True
        w(1, new1) = 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button1.Enabled = False
        Button2.Enabled = False
        Button4.Enabled = False
        ok = True
        w(1, new1) = 2
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        ok = True
        w(1, new1) = 4
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        new1 -= 1
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ok Then
            If Len(TextBox1.Text) > 0 Then
                Dim temp As Integer
                temp = TextBox1.Text
                w(2, new1) = temp
                If Button1.Enabled Then
                    w2(new1) = "O rato vai mover-se " & temp & " píxeis para cima."
                ElseIf Button2.Enabled Then
                    w2(new1) = "O rato vai mover-se " & temp & " píxeis para a esquerda."
                ElseIf Button3.Enabled Then
                    w2(new1) = "o rato vai mover-se " & temp & "  píxeis para a direita."
                ElseIf Button4.Enabled Then
                    w2(new1) = "O rato vai mover-se " & temp & " píxeis para baixo."


                End If
                Me.Close()
            Else
                MessageBox.Show("algo correu mal ")
                Me.Close()
            End If
        Else
            TextBox1.Text = "Selecione uma direção"
        End If
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        If TextBox1.Text = "Selecione uma direção" Then
            TextBox1.Clear()
        End If
    End Sub
End Class