Imports MySql.Data.MySqlClient
Public Class Votar
    Dim conectado As New MySqlConnection
    Dim comandos As New MySqlCommand

    Private Sub Votar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Rbnuno.Enabled = False
        Rbndos.Enabled = False
        Rbntres.Enabled = False
        Rbnblanco.Enabled = False
        Btnvoto.Enabled = False
        'Txtuno.Enabled = False
        'Txtdos.Enabled = False
        'Txttres.Enabled = False


        Try
            conectado.ConnectionString = "server=localhost;user=root;database=modelovotacion"
            conectado.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btninfo_Click(sender As Object, e As EventArgs) Handles Btninfo.Click

        Try
            comandos = New MySqlCommand("INSERT INTO infovotante(nombre,documento)" & Chr(10) &
                                        "VALUES(@nombre,@documento)", conectado)


            If Txtnombres.Text = "" And Txtdocumento.Text = "" Then

                MsgBox("Rellenar los campos")

            Else

                MsgBox("Datos registrados correctamente")

            End If
            Txtnombres.Text = ""
            Txtdocumento.Text = ""

            comandos.Parameters.AddWithValue("@documento", Txtdocumento.Text)
            comandos.Parameters.AddWithValue("@nombre", Txtdocumento.Text)


            Rbnuno.Enabled = True
            Rbndos.Enabled = True
            Rbntres.Enabled = True
            Rbnblanco.Enabled = True
            Btnvoto.Enabled = True


            comandos.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Try


        '    Dim cmd As New MySqlCommand

        '    Dim cadconex As String = "server=localhost;user=root;database=modelovotacion"
        '    Using cn As New MySqlCommand(cadconex)
        '        conectado.Open()

        '        Dim cSQL As String = "Select imagen from imagenes where id_imagen = 1"

        '        cmd = conectado.CreateCommand()
        '        cmd.CommandType = CommandType.Text
        '        cmd.CommandText = cSQL
        '        Dim CampoImagen As Byte() = cmd.ExecuteScalar()

        '        Dim Bin As New IO.MemoryStream(CampoImagen)
        '        Dim Resultado As Image = Image.FromStream(Bin)

        '        PictureBox1.Image = Resultado






        '    End Using

        'Catch ex As Exception

        'End Try


    End Sub

    Private Sub Btnvoto_Click(sender As Object, e As EventArgs) Handles Btnvoto.Click
        Try

            comandos = New MySqlCommand("INSERT INTO resultados(candidatouno,candidatodos,candidatotres,votoblanco)" & Chr(10) &
                                        "VALUES(@candidatouno,@candidatodos,@candidatotres,@votoblanco)", conectado)

            Dim Tarjeta As String = ""
            Dim Tarjeta2 As String = ""
            Dim Tarjeta3 As String = ""
            Dim Tarjeta5 As String = ""


            If Rbnuno.Checked = True Then

                Tarjeta = "Candidato #1"


            ElseIf Rbndos.Checked = True Then

                Tarjeta2 = "Candidato #2"


            ElseIf Rbntres.Checked = True Then

                Tarjeta3 = "Candidato #3"


            ElseIf Rbnblanco.Checked = True Then

                Tarjeta5 = "Voto en Blanco"


            Else

                MsgBox("Seleccionar a un candidato o votar en blanco")

            End If

            comandos.Parameters.AddWithValue("@candidatouno", Tarjeta)
            comandos.Parameters.AddWithValue("@candidatodos", Tarjeta2)
            comandos.Parameters.AddWithValue("@candidatotres", Tarjeta3)
            comandos.Parameters.AddWithValue("@votoblanco", Tarjeta5)


            comandos.ExecuteNonQuery()

            MsgBox("Voto registrado")

            Dim xvotacion As Votar
            xvotacion = New Votar()
            xvotacion.Show()
            Me.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Btninicio_Click(sender As Object, e As EventArgs) Handles Btninicio.Click
        Inicio.Show()
        Me.Close()
    End Sub

    Private Sub Btndetalleuno_Click(sender As Object, e As EventArgs) Handles Btndetalleuno.Click
        Detalleuno.Show()
    End Sub

    Private Sub Btndetalledos_Click(sender As Object, e As EventArgs) Handles Btndetalledos.Click
        Detalledos.Show()
    End Sub

    Private Sub Btndetalletres_Click(sender As Object, e As EventArgs) Handles Btndetalletres.Click
        Detalletres.Show()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class