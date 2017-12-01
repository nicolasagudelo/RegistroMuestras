Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports System.Security.Cryptography
Imports System.Text

Public Class Form5

    Dim usuario As Integer
    Dim conn As New MySqlConnection
    Private Sub connect()
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

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        TxBxContraseñaAnterior.Text = ""
        TxBxNuevaContraseña.Text = ""
        TxBxNuevaContraseña2.Text = ""
        TxBxContraseñaAnterior.Focus()
    End Sub

    Public Sub RecibirUsuario(ByVal usu As Integer)
        usuario = usu
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click

        If TxBxContraseñaAnterior.TextLength < 3 Or TxBxNuevaContraseña.TextLength < 3 Or TxBxNuevaContraseña2.TextLength < 3 Then
            MsgBox("Las contraseñas deben tener minimo 3 caracteres", False, "Error")
        Else
            Dim contraseña_anterior As String = TxBxContraseñaAnterior.Text
            Dim bd_password As String
            Dim bd_salt As String
            Dim reader As MySqlDataReader
            Try
                conn.Open()
                Dim cmd As New MySqlCommand(String.Format("Select hash FROM usuarios
                                                       Where UsuarioID = " & usuario & ";"), conn)
                bd_password = Convert.ToString(cmd.ExecuteScalar())
                Dim cmd2 As New MySqlCommand(String.Format("Select salt from usuarios
                                                                where UsuarioID = " & usuario & ";"), conn)
                bd_salt = Convert.ToString(cmd2.ExecuteScalar())
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, False, "Error")
                conn.Close()
                Exit Sub
            End Try

            contraseña_anterior = bd_salt + contraseña_anterior
            contraseña_anterior = ComputeHashOfString(Of SHA256CryptoServiceProvider)(contraseña_anterior)
            If contraseña_anterior = bd_password Then
                Dim contraseña_nueva As String = TxBxNuevaContraseña.Text
                Dim contraseña_nueva2 As String = TxBxNuevaContraseña2.Text
                If contraseña_nueva = contraseña_nueva2 Then

                    Dim new_salt As String = GenerateSalt()
                    contraseña_nueva = new_salt + contraseña_nueva
                    contraseña_nueva = ComputeHashOfString(Of SHA256CryptoServiceProvider)(contraseña_nueva)
                    contraseña_nueva2 = contraseña_nueva

                    Try
                        conn.Open()
                        Dim query As String = "UPDATE usuarios set salt = '" & new_salt & "', hash = '" & contraseña_nueva & "' where UsuarioID = " & usuario
                        Dim cmd As New MySqlCommand(query, conn)
                        reader = cmd.ExecuteReader
                        MsgBox("Contraseña Actualizada", False, "Contraseña Actualizada")
                        conn.Close()
                    Catch ex As MySqlException
                        MsgBox(ex.Message)
                        conn.Close()
                        Exit Sub
                    End Try
                Else
                    MsgBox("Ingreso dos contraseñas diferentes en los campos de contraseña nueva", False, "Error")
                End If
            Else
                MsgBox("La contraseña ingresada es erronea", False, "Error")
                Exit Sub
            End If
        End If
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

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
End Class