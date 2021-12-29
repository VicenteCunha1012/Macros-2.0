Public Class Form3
    Public temp As String
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        novo += 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Dim ok As Boolean
        ' For i = 1 To 95
        'If temp = teclas(i) Then
        ' ok = True
        'u(1, novo) = 6
        'u(2, novo) = i
        'u2(novo) = "A tecla " & temp & " será premida "
        ' End If
        'Next
        '  If Not ok Then
        '  MessageBox.Show("Introduza apenas uma tecla de cada vez")
        ' Else
        ' Me.Close()
        'suficiente = True
        'End If
        If Len(TextBox1.Text) > 0 Then
            temp = TextBox1.Text
            u(1, novo) = 6
            citacao(novo) = temp
            u2(novo) = "Será digitado : ->" & temp & "."
            Me.Close()
        Else
            TextBox1.Text = "Introduza alguma coisa"
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        novo -= 1
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        If TextBox1.Text = "Introduza alguma coisa" Then
            TextBox1.Clear()
        End If
    End Sub
End Class