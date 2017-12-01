Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports System.Security.Cryptography
Imports System.Text

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

    Public Function ComputeHashOfString(Of T As HashAlgorithm)(ByVal str As String,
                                                                             Optional ByVal enc As Encoding = Nothing) As String
        If (enc Is Nothing) Then
            enc = Encoding.Default
        End If
        Using algorithm As HashAlgorithm = DirectCast(Activator.CreateInstance(GetType(T)), HashAlgorithm)
            Dim data As Byte() = enc.GetBytes(str)
            Dim hash As Byte() = algorithm.ComputeHash(data)
            Dim sb As New StringBuilder(capacity:=hash.Length * 2)
            For Each b As Byte In hash
                sb.Append(b.ToString("X2"))
            Next
            Return sb.ToString.ToLower()
        End Using

    End Function

    Private Function GenerateSalt()
        Dim saltsize As Integer = 47
        Dim saltbytes() As Byte
        saltbytes = New Byte(saltsize - 1) {}
        Dim rng As RNGCryptoServiceProvider
        rng = New RNGCryptoServiceProvider
        rng.GetNonZeroBytes(saltbytes)
        Return Convert.ToBase64String(saltbytes)
    End Function

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        'MainForm.TextBoxContraseña.Text = TxBxContraseña.Text
        'MainForm.TextBoxRespuestaForm2.Text = "1"
        Dim usuario As String = TxtBxUsuario.Text
        Dim contraseña As String = TxBxContraseña.Text
        Dim bd_password As String
        Dim salt As String
        Try
            conn.Open()
            Dim cmd As New MySqlCommand(String.Format("Select hash from usuarios where binary usuario = '" & usuario & "';"), conn)
            bd_password = Convert.ToString(cmd.ExecuteScalar())
            Dim cmd2 As New MySqlCommand(String.Format("SELECT Salt from usuarios where binary usuario ='" & usuario & "';"), conn)
            salt = Convert.ToString(cmd2.ExecuteScalar())
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

        contraseña = salt + contraseña

        contraseña = ComputeHashOfString(Of SHA256CryptoServiceProvider)(contraseña)

        If contraseña = bd_password Then
            MsgBox("Bienvenida " & usuario & "", False, "Log-In")
            Dim usuario_id As String
            Try
                conn.Open()
                Dim cmd As New MySqlCommand(String.Format("Select UsuarioID from usuarios where usuario = '" & usuario & "';"), conn)
                Dim cmd2 As New MySqlCommand(String.Format("Select Nombre from usuarios where usuario = '" & usuario & "';"), conn)
                usuario_id = Convert.ToString(cmd.ExecuteScalar())
                Dim nombre As String = Convert.ToString(cmd2.ExecuteScalar())
                MainForm.TxBxUsuario.Text = usuario_id
                MainForm.LabelUsuario.Text = "Sesion actual: " + nombre
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