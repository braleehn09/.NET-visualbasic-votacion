Imports MySql.Data.MySqlClient

Public Class Login

    Dim conectado As New MySqlConnection

    Public Sub Conectar()
        Try
            conectado.ConnectionString = "server=localhost;user=root;password=root;database=modelovotacion"
            conectado.Open()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar()
    End Sub

    Private Sub Btninicio_Click(sender As Object, e As EventArgs)
        Inicio.Show()
        Me.Close()
    End Sub

    Private Sub Btningresar_Click(sender As Object, e As EventArgs) Handles Btningresar.Click

        Try
            If conectado.State = ConnectionState.Closed Then
                conectado.Open()
            End If

            Dim query As String = String.Empty

            query = "SELECT * FROM login WHERE NumeroID_Log='" & TxtUser.Text & "' AND Clave_Log='" & TxtPass.Text & "'"

            Dim mysqlcommand As MySqlCommand
            mysqlcommand = New MySqlCommand(query, conectado)
            Dim tabla As MySqlDataReader

            tabla = mysqlcommand.ExecuteReader

            Dim cantidad As Integer = 0

            While tabla.Read
                cantidad += 1
            End While

            If cantidad = 1 Then
                MsgBox("Iniciando Sesion...")
                Me.Close()
                Admin.Show()

            ElseIf TxtUser.Text = "" Or TxtPass.Text = "" Then
                MsgBox("Los campos estan vacios")
            Else
                MsgBox("ERROR: Datos no válidos")
            End If



            conectado.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            conectado.Dispose()
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Inicio.Show()
    End Sub
End Class