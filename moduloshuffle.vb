Module moduloshuffle
    Sub CheckButton(ByRef but1 As Button, ByRef but2 As Button)
        If but2.Text = "" Then
            but2.Text = but1.Text
            but1.Text = ""
        End If
    End Sub
    Sub solved()

        If frmjuego1636.clicks <= 320 And frmjuego1636.btn1636.Text = "1" And frmjuego1636.btn2636.Text = "2" And frmjuego1636.btn3636.Text = "3" And
            frmjuego1636.btn4636.Text = "4" And frmjuego1636.btn5636.Text = "5" And frmjuego1636.btn6636.Text = "6" And frmjuego1636.btn7636.Text = "7" And
            frmjuego1636.btn8636.Text = "8" And frmjuego1636.btn9636.Text = "9" And frmjuego1636.btn10636.Text = "10" And frmjuego1636.btn11636.Text = "11" And
            frmjuego1636.btn12636.Text = "12" And frmjuego1636.btn13636.Text = "13" And frmjuego1636.btn14636.Text = "14" And frmjuego1636.btn15636.Text = "15" Then
            MsgBox("acabaste en " & frmjuego1636.clicks & " clicks", 0, "ganaste")
            frmjuego1636.Close()
            frmprincipal636.ganado = frmprincipal636.ganado + 1

        End If
        If frmjuego1636.clicks >= 320 Then
            MsgBox("acabaste en " & frmjuego1636.clicks & " clicks", 0, "perdiste")
            frmjuego1636.Close()
            frmprincipal636.perdido = frmprincipal636.perdido + 1

        End If
        frmjuego1636.clicks = frmjuego1636.clicks + 1
        frmjuego1636.clicksrestantes = 321 - frmjuego1636.clicks
        frmjuego1636.lblclicksss636.Text = frmjuego1636.clicksrestantes

    End Sub
    Sub fallas()
        frmjuego2636.fallass = frmjuego2636.fallass + 1
        If frmjuego2636.fallass = 1 Then
            frmjuego2636.pbxahorcado636.Image = My.Resources._6
        End If
        If frmjuego2636.fallass = 2 Then
            frmjuego2636.pbxahorcado636.Image = My.Resources._5
        End If
        If frmjuego2636.fallass = 3 Then
            frmjuego2636.pbxahorcado636.Image = My.Resources._4
        End If
        If frmjuego2636.fallass = 4 Then
            frmjuego2636.pbxahorcado636.Image = My.Resources._3

        End If
        If frmjuego2636.fallass = 5 Then
            frmjuego2636.pbxahorcado636.Image = My.Resources._2
        End If
        If frmjuego2636.fallass = 6 Then
            frmjuego2636.pbxahorcado636.Image = My.Resources._8
            MsgBox("perdiste, no adivinaste al presi", 0, "perdiste")
            frmprincipal636.perdido = frmprincipal636.perdido + 1
            frmjuego2636.cerrar = 1
        End If
    End Sub
    Sub ganar()
        If frmjuego2636.lbla636.Text = "a" And frmjuego2636.lble2636.Text = "e" And frmjuego2636.lbln1636.Text = "n" And
        frmjuego2636.lblr636.Text = "r" And frmjuego2636.lbli1636.Text = "i" And frmjuego2636.lblq636.Text = "q" And
        frmjuego2636.lblu636.Text = "u" And frmjuego2636.lblp636.Text = "P" And frmjuego2636.lblñ636.Text = "ñ" And
        frmjuego2636.lblt636.Text = "t" Then
            MsgBox("ganaste", 0, "ganador")
            frmprincipal636.ganado = frmprincipal636.ganado + 1
            frmjuego2636.cerrar = 1
        End If

    End Sub
End Module
