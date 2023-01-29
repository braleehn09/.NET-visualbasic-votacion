Public Class Admin
    Private Sub Btnregresar_Click(sender As Object, e As EventArgs) Handles Btnregresar.Click
        Inicio.Show()
        Me.Close()
    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btnregistro_Click(sender As Object, e As EventArgs) Handles Btnregistro.Click
        Me.Hide()
        Inicio.Show()

    End Sub

    Private Sub BtnResultado_Click(sender As Object, e As EventArgs) Handles BtnResultado.Click
        Me.Hide()
        Resultados.Show()

    End Sub
End Class