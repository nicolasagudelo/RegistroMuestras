Imports MySql.Data.MySqlClient
Imports System.Configuration

Public Class Form4

    Dim conn As New MySqlConnection

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

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()
        LblNumeroGuia.Text = "Guia No: " & key2
        ContarMuestras()
        CargarDGV()
    End Sub

    Dim key, key2 As String

    Public Sub RecibirGuiaID(ByVal GuiaID As String, ByVal GuiaNo As String)
        key = GuiaID
        key2 = GuiaNo
    End Sub

    Private Sub ContarMuestras()
        Try
            conn.Open()
            Dim query As String = "select count(*)
                                   from muestras inner join usuarios on muestras.usuarioID = usuarios.UsuarioID
                                   where GuiaID = '" & key & "';"
            Dim cmd As New MySqlCommand(query, conn)
            Dim var As String = cmd.ExecuteScalar.ToString
            LblCantidadMuestras.Text = "Cantidad de Muestras" & vbCrLf & "en esta guia: " & var
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
            conn.Close()
        End Try
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

        Dim headers = (From header As DataGridViewColumn In DGVMuestrasGuia.Columns.Cast(Of DataGridViewColumn)()
                       Select header.HeaderText).ToArray
        Dim rows = From row As DataGridViewRow In DGVMuestrasGuia.Rows.Cast(Of DataGridViewRow)()
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

    Private Sub CargarDGV()
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String = "select NumeroMuestra as 'Numero de Muestra', Usuarios.nombre as 'Ingresada Por', FechaIngreso as 'Fecha de Ingreso'
                                   from muestras inner join usuarios on muestras.usuarioID = usuarios.UsuarioID
                                   where GuiaId = '" & key & "';"
            Dim cmd As New MySqlCommand(query, conn)

            reader = cmd.ExecuteReader()

            Dim table As New DataTable
            table.Load(reader)
            DGVMuestrasGuia.DataSource = table
            DGVMuestrasGuia.ReadOnly = True
            DGVMuestrasGuia.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DGVMuestrasGuia.Columns(0).Visible = True
            reader.Close()
            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

End Class