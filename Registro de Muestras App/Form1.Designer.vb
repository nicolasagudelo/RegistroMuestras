<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.BtnNuevaGuia = New System.Windows.Forms.Button()
        Me.BtnBuscarGuia = New System.Windows.Forms.Button()
        Me.BtnBuscarMuestra = New System.Windows.Forms.Button()
        Me.BtnExportar = New System.Windows.Forms.Button()
        Me.LblNumeroGuia = New System.Windows.Forms.Label()
        Me.LblNumeroMuestra = New System.Windows.Forms.Label()
        Me.LblCantidadMuestras = New System.Windows.Forms.Label()
        Me.TxtBxNumeroMuestra = New System.Windows.Forms.TextBox()
        Me.TxtBxNumeroGuia = New System.Windows.Forms.TextBox()
        Me.DGVRegistroMuestras = New System.Windows.Forms.DataGridView()
        CType(Me.DGVRegistroMuestras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnNuevaGuia
        '
        Me.BtnNuevaGuia.Location = New System.Drawing.Point(15, 19)
        Me.BtnNuevaGuia.Name = "BtnNuevaGuia"
        Me.BtnNuevaGuia.Size = New System.Drawing.Size(104, 23)
        Me.BtnNuevaGuia.TabIndex = 0
        Me.BtnNuevaGuia.Text = "Nueva Guia"
        Me.BtnNuevaGuia.UseVisualStyleBackColor = True
        '
        'BtnBuscarGuia
        '
        Me.BtnBuscarGuia.Location = New System.Drawing.Point(125, 19)
        Me.BtnBuscarGuia.Name = "BtnBuscarGuia"
        Me.BtnBuscarGuia.Size = New System.Drawing.Size(104, 23)
        Me.BtnBuscarGuia.TabIndex = 1
        Me.BtnBuscarGuia.Text = "Buscar Guia"
        Me.BtnBuscarGuia.UseVisualStyleBackColor = True
        '
        'BtnBuscarMuestra
        '
        Me.BtnBuscarMuestra.Location = New System.Drawing.Point(235, 19)
        Me.BtnBuscarMuestra.Name = "BtnBuscarMuestra"
        Me.BtnBuscarMuestra.Size = New System.Drawing.Size(104, 23)
        Me.BtnBuscarMuestra.TabIndex = 2
        Me.BtnBuscarMuestra.Text = "Buscar Muestra"
        Me.BtnBuscarMuestra.UseVisualStyleBackColor = True
        '
        'BtnExportar
        '
        Me.BtnExportar.Location = New System.Drawing.Point(460, 19)
        Me.BtnExportar.Name = "BtnExportar"
        Me.BtnExportar.Size = New System.Drawing.Size(89, 23)
        Me.BtnExportar.TabIndex = 3
        Me.BtnExportar.Text = "Exportar"
        Me.BtnExportar.UseVisualStyleBackColor = True
        '
        'LblNumeroGuia
        '
        Me.LblNumeroGuia.AutoSize = True
        Me.LblNumeroGuia.Location = New System.Drawing.Point(12, 55)
        Me.LblNumeroGuia.Name = "LblNumeroGuia"
        Me.LblNumeroGuia.Size = New System.Drawing.Size(87, 13)
        Me.LblNumeroGuia.TabIndex = 4
        Me.LblNumeroGuia.Text = "Número de Guia:"
        '
        'LblNumeroMuestra
        '
        Me.LblNumeroMuestra.AutoSize = True
        Me.LblNumeroMuestra.Location = New System.Drawing.Point(12, 83)
        Me.LblNumeroMuestra.Name = "LblNumeroMuestra"
        Me.LblNumeroMuestra.Size = New System.Drawing.Size(103, 13)
        Me.LblNumeroMuestra.TabIndex = 5
        Me.LblNumeroMuestra.Text = "Número de Muestra:"
        '
        'LblCantidadMuestras
        '
        Me.LblCantidadMuestras.AutoSize = True
        Me.LblCantidadMuestras.Location = New System.Drawing.Point(275, 55)
        Me.LblCantidadMuestras.Name = "LblCantidadMuestras"
        Me.LblCantidadMuestras.Size = New System.Drawing.Size(112, 26)
        Me.LblCantidadMuestras.TabIndex = 6
        Me.LblCantidadMuestras.Text = "Cantidad de muestras " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "en esta guia:"
        '
        'TxtBxNumeroMuestra
        '
        Me.TxtBxNumeroMuestra.Location = New System.Drawing.Point(121, 80)
        Me.TxtBxNumeroMuestra.Name = "TxtBxNumeroMuestra"
        Me.TxtBxNumeroMuestra.Size = New System.Drawing.Size(131, 20)
        Me.TxtBxNumeroMuestra.TabIndex = 7
        '
        'TxtBxNumeroGuia
        '
        Me.TxtBxNumeroGuia.Location = New System.Drawing.Point(121, 55)
        Me.TxtBxNumeroGuia.Name = "TxtBxNumeroGuia"
        Me.TxtBxNumeroGuia.Size = New System.Drawing.Size(131, 20)
        Me.TxtBxNumeroGuia.TabIndex = 8
        '
        'DGVRegistroMuestras
        '
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.DGVRegistroMuestras.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVRegistroMuestras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVRegistroMuestras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVRegistroMuestras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVRegistroMuestras.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGVRegistroMuestras.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVRegistroMuestras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Coral
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVRegistroMuestras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVRegistroMuestras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRegistroMuestras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVRegistroMuestras.GridColor = System.Drawing.Color.DarkRed
        Me.DGVRegistroMuestras.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.DGVRegistroMuestras.Location = New System.Drawing.Point(15, 122)
        Me.DGVRegistroMuestras.Name = "DGVRegistroMuestras"
        Me.DGVRegistroMuestras.Size = New System.Drawing.Size(559, 471)
        Me.DGVRegistroMuestras.TabIndex = 9
        Me.DGVRegistroMuestras.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 605)
        Me.Controls.Add(Me.DGVRegistroMuestras)
        Me.Controls.Add(Me.TxtBxNumeroGuia)
        Me.Controls.Add(Me.TxtBxNumeroMuestra)
        Me.Controls.Add(Me.LblCantidadMuestras)
        Me.Controls.Add(Me.LblNumeroMuestra)
        Me.Controls.Add(Me.LblNumeroGuia)
        Me.Controls.Add(Me.BtnExportar)
        Me.Controls.Add(Me.BtnBuscarMuestra)
        Me.Controls.Add(Me.BtnBuscarGuia)
        Me.Controls.Add(Me.BtnNuevaGuia)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Guias y Muestras"
        CType(Me.DGVRegistroMuestras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnNuevaGuia As Button
    Friend WithEvents BtnBuscarGuia As Button
    Friend WithEvents BtnBuscarMuestra As Button
    Friend WithEvents BtnExportar As Button
    Friend WithEvents LblNumeroGuia As Label
    Friend WithEvents LblNumeroMuestra As Label
    Friend WithEvents LblCantidadMuestras As Label
    Friend WithEvents TxtBxNumeroMuestra As TextBox
    Friend WithEvents TxtBxNumeroGuia As TextBox
    Friend WithEvents DGVRegistroMuestras As DataGridView
End Class
