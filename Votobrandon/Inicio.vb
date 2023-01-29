Public Class Inicio
    Private Sub Btnvotar_Click(sender As Object, e As EventArgs) Handles Btnvotar.Click
        Votar.Show()
        Me.Hide()
    End Sub

    Private Sub Btnadmin_Click(sender As Object, e As EventArgs) Handles Btnadmin.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Btnregistro_Click(sender As Object, e As EventArgs)
        Registro.Show()
        Me.Hide()
    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
