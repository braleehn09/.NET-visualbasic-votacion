Imports MySql.Data.MySqlClient
Public Class Registro
    Dim conectado As New MySqlConnection
    Dim comandos As New MySqlCommand

    Private Sub Btninicio_Click(sender As Object, e As EventArgs) Handles Btninicio.Click
        Inicio.Show()
        Me.Close()
    End Sub

    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conectado.ConnectionString = "server=localhost;user=root;database=modelovotacion"
            conectado.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnRegistar_Click(sender As Object, e As EventArgs) Handles BtnRegistar.Click

        Try
            comandos = New MySqlCommand("INSERT INTO registro(nombre,apellido,ident,tarjeton,propuesta,foto)" & Chr(10) &
                                        "VALUES(@nombre,@apellido,@ident,@tarjeton,@propuesta,@foto)", conectado)
            comandos.Parameters.AddWithValue("@nombre", TxtNombres.Text)
            comandos.Parameters.AddWithValue("@apellido", TxtApellidos.Text)
            comandos.Parameters.AddWithValue("@ident", TxtIdentificacion.Text)

            Dim Tarjeta As Integer


            If RbtnUno.Checked = True Then

                Tarjeta = 1

            ElseIf RbtnDos.Checked = True Then

                Tarjeta = 2

            ElseIf RbtnTres.Checked = True Then

                Tarjeta = 3

            Else

                MsgBox("Seleccionar el número de candidato")

            End If

            'If RbtnUno.Checked = False And RbtnDos.Checked = False And RbtnTres.Checked = False Then

            '    MsgBox("Seleccionar el número de candidato")

            'End If

            comandos.Parameters.AddWithValue("@tarjeton", Tarjeta)
            comandos.Parameters.AddWithValue("@propuesta", RtxtPropuesta.Text)
            comandos.Parameters.AddWithValue("@foto", PbxFoto.Image)

            comandos.ExecuteNonQuery()

            MsgBox("Datos Guardados")

            Dim xregistro As Registro
            xregistro = New Registro()
            xregistro.Show()
            Me.Close()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnSubir_Click(sender As Object, e As EventArgs) Handles BtnSubir.Click

        Subir.Filter = "PNG |*.png|GIF |*.gif|JPG |*.jpg"
        Subir.FileName = "Subir Foto"
        Subir.Title = "Picture"

        If Subir.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim archifoto As String

            archifoto = Subir.FileName
            PbxFoto.Image = System.Drawing.Image.FromFile(archifoto)

        End If

    End Sub
End Class