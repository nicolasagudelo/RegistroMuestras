<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIngresoGuia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormIngresoGuia))
        Me.TxtBxGuia = New System.Windows.Forms.TextBox()
        Me.LblGuia = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.LabelContraseña = New System.Windows.Forms.Label()
        Me.NumeroMuestrasGuia = New System.Windows.Forms.NumericUpDown()
        CType(Me.NumeroMuestrasGuia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtBxGuia
        '
        Me.TxtBxGuia.Location = New System.Drawing.Point(23, 47)
        Me.TxtBxGuia.MaxLength = 32
        Me.TxtBxGuia.Name = "TxtBxGuia"
        Me.TxtBxGuia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtBxGuia.Size = New System.Drawing.Size(223, 20)
        Me.TxtBxGuia.TabIndex = 1
        '
        'LblGuia
        '
        Me.LblGuia.AutoSize = True
        Me.LblGuia.Location = New System.Drawing.Point(20, 22)
        Me.LblGuia.Name = "LblGuia"
        Me.LblGuia.Size = New System.Drawing.Size(120, 13)
        Me.LblGuia.TabIndex = 0
        Me.LblGuia.Text = "Ingrese numero de Guia"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancelar.Location = New System.Drawing.Point(274, 101)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 4
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnAceptar.Location = New System.Drawing.Point(274, 74)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 3
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'LabelContraseña
        '
        Me.LabelContraseña.AutoSize = True
        Me.LabelContraseña.Location = New System.Drawing.Point(20, 79)
        Me.LabelContraseña.Name = "LabelContraseña"
        Me.LabelContraseña.Size = New System.Drawing.Size(212, 13)
        Me.LabelContraseña.TabIndex = 0
        Me.LabelContraseña.Text = "Ingrese el numero de muestras de esta guia"
        '
        'NumeroMuestrasGuia
        '
        Me.NumeroMuestrasGuia.Location = New System.Drawing.Point(23, 104)
        Me.NumeroMuestrasGuia.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumeroMuestrasGuia.Name = "NumeroMuestrasGuia"
        Me.NumeroMuestrasGuia.Size = New System.Drawing.Size(223, 20)
        Me.NumeroMuestrasGuia.TabIndex = 2
        Me.NumeroMuestrasGuia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FormIngresoGuia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 147)
        Me.Controls.Add(Me.NumeroMuestrasGuia)
        Me.Controls.Add(Me.TxtBxGuia)
        Me.Controls.Add(Me.LblGuia)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.LabelContraseña)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormIngresoGuia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresar Guia"
        CType(Me.NumeroMuestrasGuia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtBxGuia As TextBox
    Friend WithEvents LblGuia As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents LabelContraseña As Label
    Friend WithEvents NumeroMuestrasGuia As NumericUpDown
End Class
