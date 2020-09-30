Public Class frmjuego1636
    Public clicks, clicksrestantes As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1636.Click
        CheckButton(btn1636, btn2636)
        CheckButton(btn1636, btn5636)
        solved()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn2636.Click
        CheckButton(btn2636, btn1636)
        CheckButton(btn2636, btn3636)
        CheckButton(btn2636, btn6636)
        solved()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn3636.Click
        CheckButton(btn3636, btn2636)
        CheckButton(btn3636, btn7636)
        CheckButton(btn3636, btn4636)
        solved()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles btn4636.Click
        CheckButton(btn4636, btn8636)
        CheckButton(btn4636, btn3636)
        solved()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btn5636.Click
        CheckButton(btn5636, btn1636)
        CheckButton(btn5636, btn9636)
        CheckButton(btn5636, btn6636)
        solved()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn6636.Click
        CheckButton(btn6636, btn2636)
        CheckButton(btn6636, btn7636)
        CheckButton(btn6636, btn5636)
        CheckButton(btn6636, btn10636)
        solved()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn7636.Click
        CheckButton(btn7636, btn3636)
        CheckButton(btn7636, btn8636)
        CheckButton(btn7636, btn6636)
        CheckButton(btn7636, btn11636)
        solved()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles btn8636.Click
        CheckButton(btn8636, btn12636)
        CheckButton(btn8636, btn7636)
        CheckButton(btn8636, btn4636)
        solved()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btn9636.Click
        CheckButton(btn9636, btn5636)
        CheckButton(btn9636, btn10636)
        CheckButton(btn9636, btn13636)
        solved()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btn10636.Click
        CheckButton(btn10636, btn6636)
        CheckButton(btn10636, btn9636)
        CheckButton(btn10636, btn14636)
        CheckButton(btn10636, btn11636)
        solved()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btn11636.Click
        CheckButton(btn11636, btn7636)
        CheckButton(btn11636, btn10636)
        CheckButton(btn11636, btn12636)
        CheckButton(btn11636, btn15636)
        solved()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btn12636.Click
        CheckButton(btn12636, btn8636)
        CheckButton(btn12636, btn11636)
        CheckButton(btn12636, btn0636)
        solved()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles btn13636.Click
        CheckButton(btn13636, btn14636)
        CheckButton(btn13636, btn9636)
        solved()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles btn14636.Click
        CheckButton(btn14636, btn10636)
        CheckButton(btn14636, btn13636)
        CheckButton(btn14636, btn15636)
        solved()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles btn15636.Click
        CheckButton(btn15636, btn14636)
        CheckButton(btn15636, btn11636)
        CheckButton(btn15636, btn0636)
        solved()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnocultar636.Click
        pnlinstrucciones636.Visible = False
    End Sub

    Private Sub pnlinstrucciones636_Paint(sender As Object, e As PaintEventArgs) Handles pnlinstrucciones636.Paint

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles btn0636.Click
        CheckButton(btn0636, btn15636)
        CheckButton(btn0636, btn12636)
        solved()
    End Sub
End Class