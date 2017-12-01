<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.TxBxNuevaContraseña2 = New System.Windows.Forms.TextBox()
        Me.TxBxNuevaContraseña = New System.Windows.Forms.TextBox()
        Me.TxBxContraseñaAnterior = New System.Windows.Forms.TextBox()
        Me.LabelNuevaContraseña2 = New System.Windows.Forms.Label()
        Me.LabelNuevaContraseña = New System.Windows.Forms.Label()
        Me.LabelContraseñaAnterior = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnCancelar
        '
        Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancelar.Location = New System.Drawing.Point(159, 227)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 38)
        Me.BtnCancelar.TabIndex = 15
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnAceptar.Location = New System.Drawing.Point(46, 227)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 38)
        Me.BtnAceptar.TabIndex = 14
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'TxBxNuevaContraseña2
        '
        Me.TxBxNuevaContraseña2.Location = New System.Drawing.Point(34, 182)
        Me.TxBxNuevaContraseña2.MaxLength = 30
        Me.TxBxNuevaContraseña2.Name = "TxBxNuevaContraseña2"
        Me.TxBxNuevaContraseña2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxBxNuevaContraseña2.Size = New System.Drawing.Size(234, 20)
        Me.TxBxNuevaContraseña2.TabIndex = 13
        '
        'TxBxNuevaContraseña
        '
        Me.TxBxNuevaContraseña.Location = New System.Drawing.Point(34, 114)
        Me.TxBxNuevaContraseña.MaxLength = 30
        Me.TxBxNuevaContraseña.Name = "TxBxNuevaContraseña"
        Me.TxBxNuevaContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxBxNuevaContraseña.Size = New System.Drawing.Size(234, 20)
        Me.TxBxNuevaContraseña.TabIndex = 12
        '
        'TxBxContraseñaAnterior
        '
        Me.TxBxContraseñaAnterior.Location = New System.Drawing.Point(34, 42)
        Me.TxBxContraseñaAnterior.MaxLength = 30
        Me.TxBxContraseñaAnterior.Name = "TxBxContraseñaAnterior"
        Me.TxBxContraseñaAnterior.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxBxContraseñaAnterior.Size = New System.Drawing.Size(234, 20)
        Me.TxBxContraseñaAnterior.TabIndex = 11
        '
        'LabelNuevaContraseña2
        '
        Me.LabelNuevaContraseña2.AutoSize = True
        Me.LabelNuevaContraseña2.Location = New System.Drawing.Point(31, 166)
        Me.LabelNuevaContraseña2.Name = "LabelNuevaContraseña2"
        Me.LabelNuevaContraseña2.Size = New System.Drawing.Size(199, 13)
        Me.LabelNuevaContraseña2.TabIndex = 10
        Me.LabelNuevaContraseña2.Text = "Digite nuevamente su nueva contraseña"
        '
        'LabelNuevaContraseña
        '
        Me.LabelNuevaContraseña.AutoSize = True
        Me.LabelNuevaContraseña.Location = New System.Drawing.Point(31, 98)
        Me.LabelNuevaContraseña.Name = "LabelNuevaContraseña"
        Me.LabelNuevaContraseña.Size = New System.Drawing.Size(140, 13)
        Me.LabelNuevaContraseña.TabIndex = 9
        Me.LabelNuevaContraseña.Text = "Digite su nueva contraseña "
        '
        'LabelContraseñaAnterior
        '
        Me.LabelContraseñaAnterior.AutoSize = True
        Me.LabelContraseñaAnterior.Location = New System.Drawing.Point(31, 26)
        Me.LabelContraseñaAnterior.Name = "LabelContraseñaAnterior"
        Me.LabelContraseñaAnterior.Size = New System.Drawing.Size(142, 13)
        Me.LabelContraseñaAnterior.TabIndex = 8
        Me.LabelContraseñaAnterior.Text = "Digite su contraseña anterior"
        '
        'Form5
        '
        Me.AcceptButton = Me.BtnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancelar
        Me.ClientSize = New System.Drawing.Size(299, 290)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TxBxNuevaContraseña2)
        Me.Controls.Add(Me.TxBxNuevaContraseña)
        Me.Controls.Add(Me.TxBxContraseñaAnterior)
        Me.Controls.Add(Me.LabelNuevaContraseña2)
        Me.Controls.Add(Me.LabelNuevaContraseña)
        Me.Controls.Add(Me.LabelContraseñaAnterior)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form5"
        Me.Text = "Cambiar Contraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents TxBxNuevaContraseña2 As TextBox
    Friend WithEvents TxBxNuevaContraseña As TextBox
    Friend WithEvents TxBxContraseñaAnterior As TextBox
    Friend WithEvents LabelNuevaContraseña2 As Label
    Friend WithEvents LabelNuevaContraseña As Label
    Friend WithEvents LabelContraseñaAnterior As Label
End Class
