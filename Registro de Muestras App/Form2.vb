Imports MySql.Data.MySqlClient
Imports System.Configuration

Public Class FormContraseña
    Dim conn As New MySqlConnection
    Private Sub FormContraseña_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()
        TxBxContraseña.Text = ""
        TxtBxUsuario.Text = ""
    End Sub

    Public Sub Connect()

        conn.ConnectionString = ConfigurationManager.ConnectionStrings("cs").ConnectionString
        Try
            conn.Open()
            Console.WriteLine("conectandose a la base de datos")
        Catch ex As Exception
            MsgBox(ex.Message)
            End
        End Try
        conn.Close()

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        'MainForm.TextBoxContraseña.Text = TxBxContraseña.Text
        'MainForm.TextBoxRespuestaForm2.Text = "1"
        Dim usuario As String = TxtBxUsuario.Text
        Dim contraseña As String = TxBxContraseña.Text
        Dim bd_password As String
        Try
            conn.Open()
            Dim cmd As New MySqlCommand(String.Format("Select contraseña from usuarios where usuario = '" & usuario & "';"), conn)
            bd_password = Convert.ToString(cmd.ExecuteScalar())
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, False, "Error")
            conn.Close()
            Exit Sub
        End Try

        If bd_password = Nothing Then
            MsgBox("Credenciales de inicio de sesion no validas")
            Exit Sub
        End If

        If contraseña = bd_password Then
            MsgBox("Bienvenida " & usuario & "", False, "Log-In")
            Dim usuario_id As String
            Try
                conn.Open()
                Dim cmd As New MySqlCommand(String.Format("Select UsuarioID from usuarios where usuario = '" & usuario & "';"), conn)
                usuario_id = Convert.ToString(cmd.ExecuteScalar())
                MainForm.TxBxUsuario.Text = usuario_id
                MainForm.LabelUsuario.Text = "Sesion actual: " + usuario
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, False, "Error")
                conn.Close()
                Exit Sub
            End Try
            Me.Hide()
            MainForm.ShowDialog()
        Else
            MsgBox("Credenciales de inicio de sesion no validas")
            TxBxContraseña.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        MainForm.Close()
        Me.Close()
    End Sub
End Class