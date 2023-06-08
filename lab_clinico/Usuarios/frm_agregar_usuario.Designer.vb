<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_agregar_usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_agregar_usuario))
        Me.txt_nombre_usuario = New System.Windows.Forms.TextBox()
        Me.txt_correo = New System.Windows.Forms.TextBox()
        Me.txt_confirmar = New System.Windows.Forms.TextBox()
        Me.txt_contraseña = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlTitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_nombre_usuario
        '
        Me.txt_nombre_usuario.Location = New System.Drawing.Point(52, 78)
        Me.txt_nombre_usuario.Name = "txt_nombre_usuario"
        Me.txt_nombre_usuario.Size = New System.Drawing.Size(182, 20)
        Me.txt_nombre_usuario.TabIndex = 0
        '
        'txt_correo
        '
        Me.txt_correo.Location = New System.Drawing.Point(52, 159)
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.Size = New System.Drawing.Size(182, 20)
        Me.txt_correo.TabIndex = 1
        '
        'txt_confirmar
        '
        Me.txt_confirmar.Location = New System.Drawing.Point(304, 159)
        Me.txt_confirmar.Name = "txt_confirmar"
        Me.txt_confirmar.Size = New System.Drawing.Size(182, 20)
        Me.txt_confirmar.TabIndex = 2
        '
        'txt_contraseña
        '
        Me.txt_contraseña.Location = New System.Drawing.Point(304, 78)
        Me.txt_contraseña.Name = "txt_contraseña"
        Me.txt_contraseña.Size = New System.Drawing.Size(182, 20)
        Me.txt_contraseña.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(48, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre de Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(301, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Contraseña"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(48, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Correo Electronico"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(301, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Confirmar Contraseña"
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btn_guardar.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btn_guardar.ForeColor = System.Drawing.Color.White
        Me.btn_guardar.Location = New System.Drawing.Point(72, 207)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(182, 39)
        Me.btn_guardar.TabIndex = 8
        Me.btn_guardar.Text = "GUARDAR"
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.Red
        Me.btn_cancelar.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btn_cancelar.ForeColor = System.Drawing.Color.White
        Me.btn_cancelar.Location = New System.Drawing.Point(273, 207)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(179, 39)
        Me.btn_cancelar.TabIndex = 9
        Me.btn_cancelar.Text = "CANCELAR"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.pnlTitulo.Controls.Add(Me.btn_cerrar)
        Me.pnlTitulo.Controls.Add(Me.Label5)
        Me.pnlTitulo.Location = New System.Drawing.Point(0, 1)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(559, 36)
        Me.pnlTitulo.TabIndex = 10
        '
        'btn_cerrar
        '
        Me.btn_cerrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cerrar.Image = CType(resources.GetObject("btn_cerrar.Image"), System.Drawing.Image)
        Me.btn_cerrar.Location = New System.Drawing.Point(3, 3)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(30, 30)
        Me.btn_cerrar.TabIndex = 1
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(39, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 24)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Agregar Usuario"
        '
        'frm_agregar_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 270)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_contraseña)
        Me.Controls.Add(Me.txt_confirmar)
        Me.Controls.Add(Me.txt_correo)
        Me.Controls.Add(Me.txt_nombre_usuario)
        Me.Name = "frm_agregar_usuario"
        Me.Text = "Agregar_Usuario"
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_nombre_usuario As TextBox
    Friend WithEvents txt_correo As TextBox
    Friend WithEvents txt_confirmar As TextBox
    Friend WithEvents txt_contraseña As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents btn_cerrar As Button
    Private WithEvents Label5 As Label
End Class
