<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_editar_usuario
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
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nombre_usuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_correo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_dni = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_contraseña = New System.Windows.Forms.TextBox()
        Me.txt_confirmar = New System.Windows.Forms.TextBox()
        Me.gp_validaciones = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.gp_validaciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.Red
        Me.btn_cancelar.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btn_cancelar.ForeColor = System.Drawing.Color.White
        Me.btn_cancelar.Location = New System.Drawing.Point(418, 261)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(179, 39)
        Me.btn_cancelar.TabIndex = 11
        Me.btn_cancelar.Text = "CANCELAR"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btn_guardar.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btn_guardar.ForeColor = System.Drawing.Color.White
        Me.btn_guardar.Location = New System.Drawing.Point(418, 203)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(182, 39)
        Me.btn_guardar.TabIndex = 10
        Me.btn_guardar.Text = "GUARDAR"
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 21)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Nombre de Usuario"
        '
        'txt_nombre_usuario
        '
        Me.txt_nombre_usuario.Location = New System.Drawing.Point(32, 50)
        Me.txt_nombre_usuario.Name = "txt_nombre_usuario"
        Me.txt_nombre_usuario.Size = New System.Drawing.Size(182, 20)
        Me.txt_nombre_usuario.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(32, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 21)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Correo Electronico"
        '
        'txt_correo
        '
        Me.txt_correo.Location = New System.Drawing.Point(32, 111)
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.Size = New System.Drawing.Size(182, 20)
        Me.txt_correo.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(32, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 21)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "DNI"
        '
        'txt_dni
        '
        Me.txt_dni.Location = New System.Drawing.Point(32, 169)
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.Size = New System.Drawing.Size(182, 20)
        Me.txt_dni.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(29, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 21)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Confirmar Contraseña"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(29, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 21)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Contraseña"
        '
        'txt_contraseña
        '
        Me.txt_contraseña.Location = New System.Drawing.Point(32, 231)
        Me.txt_contraseña.Name = "txt_contraseña"
        Me.txt_contraseña.Size = New System.Drawing.Size(182, 20)
        Me.txt_contraseña.TabIndex = 19
        '
        'txt_confirmar
        '
        Me.txt_confirmar.Location = New System.Drawing.Point(32, 295)
        Me.txt_confirmar.Name = "txt_confirmar"
        Me.txt_confirmar.Size = New System.Drawing.Size(182, 20)
        Me.txt_confirmar.TabIndex = 18
        '
        'gp_validaciones
        '
        Me.gp_validaciones.Controls.Add(Me.Label6)
        Me.gp_validaciones.Controls.Add(Me.Label7)
        Me.gp_validaciones.Controls.Add(Me.Label8)
        Me.gp_validaciones.Controls.Add(Me.Label9)
        Me.gp_validaciones.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.gp_validaciones.Location = New System.Drawing.Point(390, 36)
        Me.gp_validaciones.Name = "gp_validaciones"
        Me.gp_validaciones.Size = New System.Drawing.Size(425, 152)
        Me.gp_validaciones.TabIndex = 22
        Me.gp_validaciones.TabStop = False
        Me.gp_validaciones.Text = "VALIDACIONES"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 21)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "1 Caracter Especial"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 21)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "1 Letra Minuscula"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 21)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "1 Letra mayuscula"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(422, 21)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "La Contraseña debe contener al menos 8 caracteres"
        '
        'Editar_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 349)
        Me.Controls.Add(Me.gp_validaciones)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_contraseña)
        Me.Controls.Add(Me.txt_confirmar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_dni)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_correo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_nombre_usuario)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Name = "Editar_Usuario"
        Me.Text = "Editar_Usuario"
        Me.gp_validaciones.ResumeLayout(False)
        Me.gp_validaciones.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nombre_usuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_correo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_dni As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_contraseña As TextBox
    Friend WithEvents txt_confirmar As TextBox
    Friend WithEvents gp_validaciones As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
