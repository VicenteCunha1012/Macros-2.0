Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form5 As New Form5
        Form5.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Form3 As New Form3
        Form3.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Form4 As New Form4
        Form4.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Form8 As New Form8
        Form8.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        teclas(1) = "a"
        teclas(2) = "A"
        teclas(3) = "b"
        teclas(4) = "B"
        teclas(5) = "c"
        teclas(6) = "C"
        teclas(7) = "d"
        teclas(8) = "D"
        teclas(9) = "e"
        teclas(10) = "E"
        teclas(11) = "f"
        teclas(12) = "F"
        teclas(13) = "g"
        teclas(14) = "G"
        teclas(15) = "h"
        teclas(16) = "H"
        teclas(17) = "i"
        teclas(18) = "I"
        teclas(19) = "j"
        teclas(20) = "J"
        teclas(21) = "k"
        teclas(22) = "K"
        teclas(23) = "l"
        teclas(24) = "L"
        teclas(25) = "m"
        teclas(26) = "M"
        teclas(27) = "n"
        teclas(28) = "N"
        teclas(29) = "o"
        teclas(30) = "O"
        teclas(31) = "p"
        teclas(32) = "P"
        teclas(33) = "q"
        teclas(34) = "Q"
        teclas(35) = "r"
        teclas(36) = "R"
        teclas(37) = "s"
        teclas(38) = "S"
        teclas(39) = "t"
        teclas(40) = "T"
        teclas(41) = "u"
        teclas(42) = "U"
        teclas(43) = "v"
        teclas(44) = "V"
        teclas(45) = "w"
        teclas(46) = "W"
        teclas(47) = "x"
        teclas(48) = "X"
        teclas(49) = "y"
        teclas(50) = "Y"
        teclas(51) = "z"
        teclas(52) = "Z"
        teclas(53) = "1"
        teclas(54) = "2"
        teclas(55) = "3"
        teclas(57) = "4"
        teclas(58) = "5"
        teclas(59) = "6"
        teclas(60) = "7"
        teclas(61) = "8"
        teclas(62) = "9"
        teclas(63) = "0"
        teclas(64) = "!"
        teclas(65) = ""
        teclas(66) = "#"
        teclas(67) = "$"
        teclas(68) = "%"
        teclas(69) = "&"
        teclas(70) = "/"
        teclas(71) = "("
        teclas(72) = ")"
        teclas(73) = "="
        teclas(74) = "?"
        teclas(75) = "»"
        teclas(76) = "«"
        teclas(77) = "\"
        teclas(78) = "|"
        teclas(79) = "<"
        teclas(80) = ">"
        teclas(81) = ","
        teclas(82) = ";"
        teclas(83) = "."
        teclas(84) = ":"
        teclas(85) = "_"
        teclas(86) = "-"
        teclas(87) = "º"
        teclas(88) = "ª"
        teclas(89) = "*"
        teclas(90) = "+"
        teclas(91) = "¨¨"
        teclas(92) = "´"
        teclas(93) = "`"
        teclas(94) = "~"
        teclas(95) = "^"
        'teclas complexas depois

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Form2 As New Form2
        Form2.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim x, y As Integer
        For i = 1 To 150
            If u(1, i) = 0 Then
            ElseIf u(1, i) = 1 Then
                Me.Cursor = New Cursor(Cursor.Current.Handle)
                Cursor.Position = New Point((x - u(2, i)), y)
                x -= u(2, i)

            ElseIf u(1, i) = 2 Then
                Me.Cursor = New Cursor(Cursor.Current.Handle)
                Cursor.Position = New Point((x + u(2, i)), y)
                x += u(2, i)
                'mover para a direita
            ElseIf u(1, i) = 3 Then
                Me.Cursor = New Cursor(Cursor.Current.Handle)
                Cursor.Position = New Point(x, y - u(2, i))
                y -= u(2, i)
                'mover para cima
            ElseIf u(1, i) = 4 Then
                Me.Cursor = New Cursor(Cursor.Current.Handle)
                Cursor.Position = New Point(x, y + u(2, i))
                y += u(2, i)
                'mover para baixo
            ElseIf u(1, i) = 5 Then
                x = u(2, i)
                y = u(3, i)
            ElseIf u(1, i) = 6 Then
                My.Computer.Keyboard.SendKeys(citacao(i), True)
                'tecla
            ElseIf u(1, i) = 7 Then
                Threading.Thread.Sleep(u(2, i))
                'mimir

            End If
        Next
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        For i = 1 To 150
            u2(i) = Nothing
            citacao(i) = Nothing

            For j = 1 To 4
                u(j, i) = Nothing
            Next
        Next

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        For i = 1 To 150
            u2(i) = Nothing
            citacao(i) = Nothing

            For j = 1 To 4
                u(j, i) = Nothing
            Next
        Next
        Dim Form6 As New Form6
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
