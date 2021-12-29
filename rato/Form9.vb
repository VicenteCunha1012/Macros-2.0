Public Class Form9
    Public x As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        x += 1
        If w2(1) = Nothing Then
            ListBox1.Items.Add("Ainda não introduziu nenhuma instrução.")

        End If
        ListBox1.Items.Clear()
        If x Mod 2 = 0 Then
            Me.Text = "Vista condensada"
            For i = 1 To 250
                If Not w2(i) = Nothing Then


                    ListBox1.Items.Add(w2(i))
                End If

            Next

        Else
            Me.Text = "Vista descondensada"
            For i = 1 To 250
                If Not w2(i) = Nothing Then
                    ListBox1.Items.Add(w2(i))
                    ListBox1.Items.Add("-----------------------------------------------------------------------")
                End If

            Next

        End If


    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 1 To 250
            If Not w2(i) = Nothing Then


                ListBox1.Items.Add(w2(i))
            End If

        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class