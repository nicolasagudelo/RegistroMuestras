Imports MySql.Data.MySqlClient
Imports System.Configuration

Public Class MainForm

    Dim conn As New MySqlConnection

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()
    End Sub

    Public Sub Connect()

        conn.ConnectionString = ConfigurationManager.ConnectionStrings("cs").ConnectionString
        Try
            conn.Open()
            Console.WriteLine("conectandose a la base de datos")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

    End Sub

    Private Sub CargarDGV(llave)

        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String = "Select Muestras.FechaIngreso, guias.Consecutivo, NumeroGuia, NumeroMuestra, Nombre as Usuario
                                   from guias inner join muestras on guias.GuiaID = muestras.GuiaID inner join usuarios on muestras.usuarioID = usuarios.usuarioID
                                   where muestras.GuiaID = '" & llave & "';"
            Dim cmd As New MySqlCommand(query, conn)
            Console.WriteLine("Cargando Muestras de la guia")

            reader = cmd.ExecuteReader()

            Dim table As New DataTable
            table.Load(reader)
            DGVRegistroMuestras.DataSource = table
            DGVRegistroMuestras.ReadOnly = True
            DGVRegistroMuestras.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            reader.Close()
            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
            conn.Close()
        End Try

    End Sub

    Private Sub BtnNuevaGuia_Click(sender As Object, e As EventArgs) Handles BtnNuevaGuia.Click
        'FormIngresoGuia.Show()
        DGVRegistroMuestras.DataSource = Nothing
        TxtBxNumeroGuia.Text = ""
        TxtBxNumeroMuestra.Text = ""
        TxtBxNumeroGuia.Enabled = True
        TxtBxNumeroGuia.ReadOnly = False
        TxtBxNumeroMuestra.Enabled = False
        LblCantidadMuestras.Text = "Cantidad de muestras" & vbCrLf & "en esta guia:"
    End Sub

    Private Sub TxtBxNumeroGuia_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBxNumeroGuia.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtBxNumeroGuia.Text = TxtBxNumeroGuia.Text.ToUpper
            Try
                If (TxtBxNumeroGuia.Text.Substring(0, 4) = "HTTP") Then
                    MsgBox("Esta Ingresando una muestra como guia", False, "Error")
                    Exit Sub
                End If
            Catch ex As Exception
            End Try

            Dim llave As String

            Try
                conn.Open()
                Dim cmd As New MySqlCommand(String.Format("SELECT MAX(GuiaID)+1 FROM Guias;"), conn)
                llave = Convert.ToString(cmd.ExecuteScalar())
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, False, "Error")
                conn.Close()
                Exit Sub
            End Try

            If llave = Nothing Then
                llave = "1"
            End If

            TxBxGuiaID.Text = llave

            Dim t_creacion As String
            Dim t_creacion_consecutivo As String

            Try
                conn.Open()
                Dim cmd As New MySqlCommand(String.Format("SELECT NOW();"), conn)
                Dim fecha_servidor As DateTime = cmd.ExecuteScalar()
                t_creacion = fecha_servidor.ToString("yyyy-MM-dd HH:mm:ss")
                t_creacion_consecutivo = fecha_servidor.ToString("yyyy-MM-dd")
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, False, "No se puede obtener la fecha de la base de datos")
                conn.Close()
                Exit Sub
            End Try

            Dim consecutivo As String

            Try
                conn.Open()
                Dim cmd As New MySqlCommand(String.Format("select count(*)+1 as c from guias where FechaIngreso like '" & t_creacion_consecutivo & "%';"), conn)
                consecutivo = cmd.ExecuteScalar()
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, False, "Error")
                conn.Close()
                Exit Sub
            End Try

            consecutivo = t_creacion_consecutivo + "-" + consecutivo

            Try
                conn.Open()
                Dim cmd As New MySqlCommand(String.Format("INSERT INTO Guias VALUES ('" & llave & "', '" & t_creacion & "', '" & consecutivo & "', '" & TxtBxNumeroGuia.Text & "', '" & TxBxUsuario.Text & "');"), conn)
                cmd.ExecuteNonQuery()
                MsgBox("Guia Registrada Satisfactoriamente", False, "Guia Registrada")
            Catch ex As MySqlException
                MsgBox(ex.Message, False, "Error")
                conn.Close()
                Exit Sub
            End Try
            conn.Close()
            CargarDGV(llave)
            TxtBxNumeroGuia.Enabled = False
            TxtBxNumeroMuestra.Enabled = True
            muestras_ingresadas = 0
        End If
    End Sub

    Dim muestras_ingresadas As Integer

    Private Sub TxtBxNumeroMuestra_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBxNumeroMuestra.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TxtBxNumeroMuestra.TextLength < 10 Then
                MsgBox("El texto ingresado no tiene la longitud minima necesaria", False, "Error")
                Exit Sub
            Else
                TxtBxNumeroMuestra.Text = TxtBxNumeroMuestra.Text.Substring(TxtBxNumeroMuestra.Text.Length - 10)
            End If

            Dim llave As String

            Try
                conn.Open()
                Dim cmd As New MySqlCommand(String.Format("SELECT MAX(MuestraID)+1 FROM Muestras;"), conn)
                llave = Convert.ToString(cmd.ExecuteScalar())
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, False, "Error")
                conn.Close()
                Exit Sub
            End Try

            If llave = Nothing Then
                llave = "1"
            End If

            Dim t_creacion As String

            Try
                conn.Open()
                Dim cmd As New MySqlCommand(String.Format("SELECT NOW();"), conn)
                Dim fecha_servidor As DateTime = cmd.ExecuteScalar()
                t_creacion = fecha_servidor.ToString("yyyy-MM-dd HH:mm:ss")
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, False, "No se puede obtener la fecha de la base de datos")
                conn.Close()
                Exit Sub
            End Try

            Try
                conn.Open()
                Dim cmd As New MySqlCommand(String.Format("INSERT INTO muestras VALUES ('" & llave & "', '" & TxBxGuiaID.Text & "', '" & TxtBxNumeroMuestra.Text & "', '" & TxBxUsuario.Text & "', '" & t_creacion & "');"), conn)
                cmd.ExecuteNonQuery()
                MsgBox("Muestra Registrada Satisfactoriamente", False, "Muestra Registrada")
                muestras_ingresadas += 1
                LblCantidadMuestras.Text = "Cantidad de muestras" & vbCrLf & "en esta guia: " & muestras_ingresadas
            Catch ex As MySqlException
                MsgBox("Muestra Duplicada", False, "Error")
                conn.Close()
                Exit Sub
            End Try
            conn.Close()
            CargarDGV(TxBxGuiaID.Text)

        End If
    End Sub

    Private Sub BtnBuscarGuia_Click(sender As Object, e As EventArgs) Handles BtnBuscarGuia.Click
        TxtBxNumeroGuia.Text = InputBox("Ingrese el número de guía", "Info").ToUpper
        TxtBxNumeroGuia.Enabled = False
        TxtBxNumeroMuestra.Text = ""

        Dim reader As MySqlDataReader

        Try
            conn.Open()
            Dim query As String = "Select guias.FechaIngreso, Consecutivo, NumeroGuia as 'Numero de Guia', usuarios.Nombre 
                                   from guias inner join usuarios on guias.usuarioId = usuarios.usuarioid
                                   where NumeroGuia LIKE '" & TxtBxNumeroGuia.Text & "%';"
            Dim cmd As New MySqlCommand(query, conn)
            Console.WriteLine("Cargando Guias")

            reader = cmd.ExecuteReader()

            Dim table As New DataTable
            table.Load(reader)
            DGVRegistroMuestras.DataSource = table
            DGVRegistroMuestras.ReadOnly = True
            DGVRegistroMuestras.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DGVRegistroMuestras.Columns(0).Visible = True
            reader.Close()
            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
            conn.Close()
        End Try

    End Sub

    Private Sub BtnBuscarMuestra_Click(sender As Object, e As EventArgs) Handles BtnBuscarMuestra.Click
        TxtBxNumeroMuestra.Text = InputBox("Ingrese el número de muestra", "Info").ToUpper
        TxtBxNumeroGuia.Text = ""
        TxtBxNumeroMuestra.Enabled = False
        Dim reader As MySqlDataReader

        If TxtBxNumeroMuestra.TextLength < 10 Then
            Try
                conn.Open()
                Dim query As String = "Select guias.NumeroGuia, numeromuestra, usuarios.nombre, muestras.FechaIngreso
                                       From usuarios inner Join muestras On muestras.UsuarioID = usuarios.UsuarioID inner Join guias On muestras.GuiaID = guias.GuiaID
                                       Where NumeroMuestra Like '" & TxtBxNumeroMuestra.Text & "%';"
                Dim cmd As New MySqlCommand(query, conn)
                Console.WriteLine("Cargando Muestras de la guia")

                reader = cmd.ExecuteReader()

                Dim table As New DataTable
                table.Load(reader)
                DGVRegistroMuestras.DataSource = table
                DGVRegistroMuestras.ReadOnly = True
                DGVRegistroMuestras.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                DGVRegistroMuestras.Columns(0).Visible = True
                reader.Close()
                conn.Close()
            Catch ex As MySqlException
                MsgBox(ex.Message)
                conn.Close()
            End Try

        Else
            TxtBxNumeroMuestra.Text = TxtBxNumeroMuestra.Text.Substring(TxtBxNumeroMuestra.Text.Length - 10)
            Try
                conn.Open()
                Dim query As String = "Select guias.NumeroGuia, numeromuestra, usuarios.nombre, muestras.FechaIngreso
                                       From usuarios inner Join muestras On muestras.UsuarioID = usuarios.UsuarioID inner Join guias On muestras.GuiaID = guias.GuiaID
                                       Where NumeroMuestra Like '" & TxtBxNumeroMuestra.Text & "%';"
                Dim cmd As New MySqlCommand(query, conn)
                Console.WriteLine("Cargando Muestras de la guia")

                reader = cmd.ExecuteReader()

                Dim table As New DataTable
                table.Load(reader)
                DGVRegistroMuestras.DataSource = table
                DGVRegistroMuestras.ReadOnly = True
                DGVRegistroMuestras.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                DGVRegistroMuestras.Columns(0).Visible = True
                reader.Close()
                conn.Close()
            Catch ex As MySqlException
                MsgBox(ex.Message)
                conn.Close()
            End Try

        End If
    End Sub

    Private Sub BtnExportar_Click(sender As Object, e As EventArgs) Handles BtnExportar.Click
        Dim GuardarCsv As New SaveFileDialog
        GuardarCsv.InitialDirectory = "C:\"
        GuardarCsv.RestoreDirectory = True
        GuardarCsv.DefaultExt = ".csv"
        GuardarCsv.AddExtension = True
        GuardarCsv.Filter = "Archivo separado por comas(*.csv)|*.csv|Archivos de texto(*.txt)|*.txt"
        GuardarCsv.ShowDialog()
        Dim filepath As String

        Try
            filepath = IO.Path.GetFullPath(GuardarCsv.FileName)
        Catch ex As Exception
            MsgBox(ex.Message, False, "Error")
            Exit Sub
        End Try

        Dim headers = (From header As DataGridViewColumn In DGVRegistroMuestras.Columns.Cast(Of DataGridViewColumn)()
                       Select header.HeaderText).ToArray
        Dim rows = From row As DataGridViewRow In DGVRegistroMuestras.Rows.Cast(Of DataGridViewRow)()
                   Where Not row.IsNewRow
                   Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))
        Using sw As New IO.StreamWriter(filepath)
            sw.WriteLine(String.Join(";", headers))
            For Each r In rows
                sw.WriteLine(String.Join(";", r))
            Next
        End Using
        Process.Start(filepath)
    End Sub
End Class
