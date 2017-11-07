<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DGVMuestrasGuia = New System.Windows.Forms.DataGridView()
        Me.LblNumeroGuia = New System.Windows.Forms.Label()
        Me.LblCantidadMuestras = New System.Windows.Forms.Label()
        Me.BtnExportar = New System.Windows.Forms.Button()
        CType(Me.DGVMuestrasGuia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVMuestrasGuia
        '
        Me.DGVMuestrasGuia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVMuestrasGuia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVMuestrasGuia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVMuestrasGuia.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGVMuestrasGuia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMuestrasGuia.Location = New System.Drawing.Point(12, 66)
        Me.DGVMuestrasGuia.Name = "DGVMuestrasGuia"
        Me.DGVMuestrasGuia.Size = New System.Drawing.Size(564, 532)
        Me.DGVMuestrasGuia.TabIndex = 0
        '
        'LblNumeroGuia
        '
        Me.LblNumeroGuia.AutoSize = True
        Me.LblNumeroGuia.Location = New System.Drawing.Point(12, 9)
        Me.LblNumeroGuia.Name = "LblNumeroGuia"
        Me.LblNumeroGuia.Size = New System.Drawing.Size(46, 13)
        Me.LblNumeroGuia.TabIndex = 1
        Me.LblNumeroGuia.Text = "GuiaNo:"
        '
        'LblCantidadMuestras
        '
        Me.LblCantidadMuestras.AutoSize = True
        Me.LblCantidadMuestras.Location = New System.Drawing.Point(12, 37)
        Me.LblCantidadMuestras.Name = "LblCantidadMuestras"
        Me.LblCantidadMuestras.Size = New System.Drawing.Size(112, 26)
        Me.LblCantidadMuestras.TabIndex = 7
        Me.LblCantidadMuestras.Text = "Cantidad de muestras " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "en esta guia:"
        '
        'BtnExportar
        '
        Me.BtnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExportar.Location = New System.Drawing.Point(487, 9)
        Me.BtnExportar.Name = "BtnExportar"
        Me.BtnExportar.Size = New System.Drawing.Size(89, 23)
        Me.BtnExportar.TabIndex = 8
        Me.BtnExportar.Text = "Exportar"
        Me.BtnExportar.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 610)
        Me.Controls.Add(Me.BtnExportar)
        Me.Controls.Add(Me.LblCantidadMuestras)
        Me.Controls.Add(Me.LblNumeroGuia)
        Me.Controls.Add(Me.DGVMuestrasGuia)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.DGVMuestrasGuia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVMuestrasGuia As DataGridView
    Friend WithEvents LblNumeroGuia As Label
    Friend WithEvents LblCantidadMuestras As Label
    Friend WithEvents BtnExportar As Button
End Class
