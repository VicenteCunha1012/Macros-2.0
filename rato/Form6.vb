Public Class Form6
    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Dim Form1 As New Form1
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        MessageBox.Show("De momento esta ação ainda está indisponível.")
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        MessageBox.Show("De momento esta ação ainda está indisponível.")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim Form7 As New Form7
        Form7.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        new1 += 1
        commands(new1) = "Mouse1Down"
        w(1, new1) = 5
        w2(new1) = "Instrução para baixar Mouse1"
        MessageBox.Show("Ação registada.")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        new1 += 1
        commands(new1) = "Mouse1Up"
        w(1, new1) = 6
        w2(new1) = "Instrução para levantar Mouse1"
        MessageBox.Show("Ação registada.")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        new1 += 1
        commands(new1) = "Mouse2Down"
        w(1, new1) = 7
        w2(new1) = "Instrução para baixar Mouse2"
        MessageBox.Show("Ação registada.")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        new1 += 1
        commands(new1) = "Mouse2Up"
        w(1, new1) = 8
        w2(new1) = "Instrução para levantar Mouse2"
        MessageBox.Show("Ação registada")


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        new1 += 1
        commands(new1) = "ScrollDown"
        w(1, new1) = 9
        Dim quantos As Integer
        quantos = InputBox("Quantos Scrolls deseja realizar?")
        w2(new1) = "Instrução para executar " & quantos & " scrolls para baixo."
        w(2, new1) = quantos
        MessageBox.Show("Ação registada.")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        new1 += 1
        commands(new1) = "ScrollUp"
        w(1, new1) = 10
        Dim quantos As Integer
        quantos = InputBox("Quantos Scrolls deseja realizar?")
        w2(new1) = "Instrução para executar " & quantos & " scrolls para cima."
        w(2, new1) = quantos
        MessageBox.Show("Ação registada.")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        new1 += 1
        commands(new1) = "Mouse3Down"
        w(1, new1) = 11
        w2(new1) = "Instrução para baixar Mouse3."
        MessageBox.Show("Ação registada.")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        new1 += 1
        commands(new1) = "Mouse3Up"
        w(1, new1) = 12
        w2(new1) = "Instrução para levantar Mouse3."
        MessageBox.Show("Ação registada.")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim x As Integer
        new1 += 1
        x = InputBox("Quantos segundos de espera deseja adicionar?")
        w(1, new1) = 13
        w2(new1) = "Instrução para esperar " & x & " segundos."
        w(2, new1) = x * 1000
        MessageBox.Show("Ação registada")

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim x As Integer
        new1 += 1
        x = InputBox("Quantos segundos de espera deseja adicionar?")
        w(1, new1) = 13
        w2(new1) = "Instrução para esperar " & x & " milissegundos."
        w(2, new1) = x
        MessageBox.Show("Ação registada")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim temp As String
        new1 += 1
        temp = InputBox("Introduza o texto que deseja introduzir.")
        w(1, new1) = 14
        quotation(new1) = temp
        w2(new1) = "Instrução para escrever " & temp & " ."
        MessageBox.Show("Ação registada")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim temp As String
        Dim ok As Boolean
        Dim qual As Integer
        new1 += 1
        w(1, new1) = 15
        temp = InputBox("Introduza a tecla que quer enviar.")
        For i = 1 To 95
            If temp = teclas(i) Then
                ok = True
                qual = i
            End If
        Next
        If ok Then
            w2(new1) = "O sistema enviará a tecla " & teclas(qual) & " ."

        End If
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim Form9 As New Form9
        Form9.Show()

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs)
        Dim y As Integer
        For i = 1 To 250
            If Not u(1, i) = 0 Then
                y = i

            Else
                y = 1
            End If
        Next
        w(1, y) = Nothing
        w(2, y) = Nothing
        w(3, y) = Nothing
        w(4, y) = Nothing
        w2(y) = Nothing
        quotation(y) = Nothing
        commands(y) = Nothing
        If new1 > 0 Then
            new1 -= 1
        Else
            new1 = 0
        End If
        MessageBox.Show("Último item limpo da lista, a não ser que a lista estivesse vazia.")

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim x As Integer
        x = InputBox("Qual é o número do item que deseja eliminar?")
        w(1, x) = Nothing
        w(2, x) = Nothing
        w(3, x) = Nothing
        w(4, x) = Nothing
        w2(x) = Nothing
        quotation(x) = Nothing
        commands(x) = Nothing
        MessageBox.Show("Item " & x & " da lista foi limpo.")

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        For i = 1 To 250
            w(1, i) = Nothing
            w(2, i) = Nothing
            w(3, i) = Nothing
            w(4, i) = Nothing
            w2(i) = Nothing
            quotation(i) = Nothing
            commands(i) = Nothing
        Next
        MessageBox.Show("Lista completamente limpa.")
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs)

    End Sub

    Public Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dvFlags As Long)


    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim z, aa As Integer
        For i = 1 To 250
            If w(1, i) = 0 Then
            ElseIf w(1, i) = 1 Then
                Me.Cursor = New Cursor(Cursor.Current.Handle)
                Cursor.Position = New Point(z - w(2, i), aa)
                z -= w(2, i)
            ElseIf w(1, i) = 2 Then
                Me.Cursor = New Cursor(Cursor.Current.Handle)
                Cursor.Position = New Point(z + w(2, i), aa)
                z += w(2, i)
            ElseIf w(1, i) = 3 Then
                Me.Cursor = New Cursor(Cursor.Current.Handle)
                Cursor.Position = New Point(z, aa - (w(2, i)))
                aa -= w(2, i)
            ElseIf w(1, i) = 4 Then
                Me.Cursor = New Cursor(Cursor.Current.Handle)
                Cursor.Position = New Point(z, aa + (w(2, i)))
                aa += w(2, i)
            ElseIf w(1, i) = 5 Then
                mouse_event(&H2)
            ElseIf w(1, i) = 6 Then
                mouse_event(&H4)
            ElseIf w(1, i) = 7 Then
                mouse_event(&H8)
            ElseIf w(1, i) = 8 Then
                mouse_event(&H10)
            ElseIf w(1, i) = 9 Then
                mouse_event(&H800)
            ElseIf w(1, i) = 10 Then
                mouse_event(&H1000)
            ElseIf w(1, i) = 11 Then
                mouse_event(&H20)
            ElseIf w(1, i) = 12 Then
                mouse_event(&H40)
            ElseIf w(1, i) = 13 Then
                Threading.Thread.Sleep(w(2, i))
            ElseIf w(1, i) = 14 Then
                My.Computer.Keyboard.SendKeys(w(2, i))
            ElseIf w(1, i) = 15 Then
                My.Computer.Keyboard.SendKeys(w(2, i))
            ElseIf w(1, i) = 16 Then
                z = w(2, i)
                aa = w(3, i)












            End If
        Next

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim Form10 As New Form10
        Form10.Show()
    End Sub
End Class