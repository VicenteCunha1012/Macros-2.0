Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        novo += 1

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Len(TextBox1.Text) > 0 Then
            Dim temp As Integer
            temp = TextBox1.Text

            u(1, novo) = 7
            u(2, novo) = temp
            u2(novo) = "Pedido para esperar " & temp & "ms."
            Me.Close()
        Else
            TextBox1.Text = "Apenas introduza números"
        End If





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        novo -= 1
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        If TextBox1.Text = "Apenas introduza números" Then
            TextBox1.Clear()
        End If

    End Sub
End Class