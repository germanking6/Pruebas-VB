Public Class frmprincipal636
    Public perdido, ganado, juego As Integer

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        pnloculto636.Visible = False
        txtgana636.Text = ganado
        txtperdi636.Text = perdido
    End Sub

    Private Sub btnjuego2636_Click(sender As Object, e As EventArgs) Handles btnjuego2636.Click
        frmjuego2636.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnjuego1636.Click
        frmjuego1636.ShowDialog()
    End Sub
End Class
