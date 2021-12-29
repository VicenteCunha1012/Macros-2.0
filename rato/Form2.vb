Public Class Form2
    Public quanto, chega As Integer
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If u(1, 1) = 0 Then
            ListBox1.Items.Add("Ainda não selecionou nenhuma ação.")
        End If
        For i = 1 To 150
            If u(1, i) = 0 Then
                chega = i
            End If
        Next
        For i = 1 To 150
            If Not u(1, i) = 0 Then
                ListBox1.Items.Add(u2(i))
            End If
        Next
    End Sub
End Class