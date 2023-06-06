<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editar_Paciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Editar_Paciente))
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbGenero = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.iconButton3 = New System.Windows.Forms.Button()
        Me.iconButton2 = New System.Windows.Forms.Button()
        Me.pnlTitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.pnlTitulo.Controls.Add(Me.Button1)
        Me.pnlTitulo.Controls.Add(Me.Label1)
        Me.pnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(681, 36)
        Me.pnlTitulo.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 30)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(39, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Editar Paciente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(24, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre del Paciente"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtNombre.Location = New System.Drawing.Point(27, 76)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(223, 27)
        Me.txtNombre.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(24, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 21)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Apellido del Paciente"
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtApellido.Location = New System.Drawing.Point(27, 143)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(223, 27)
        Me.txtApellido.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(24, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 21)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Dni del Paciente"
        '
        'txtDni
        '
        Me.txtDni.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtDni.Location = New System.Drawing.Point(27, 207)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(223, 27)
        Me.txtDni.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(24, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 21)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Genero del Paciente"
        '
        'cmbGenero
        '
        Me.cmbGenero.DropDownWidth = 223
        Me.cmbGenero.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.cmbGenero.FormattingEnabled = True
        Me.cmbGenero.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.cmbGenero.Location = New System.Drawing.Point(27, 270)
        Me.cmbGenero.Name = "cmbGenero"
        Me.cmbGenero.Size = New System.Drawing.Size(223, 29)
        Me.cmbGenero.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(324, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(179, 21)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Fecha de Nacimiento"
        '
        'DtpFechaNac
        '
        Me.DtpFechaNac.CalendarFont = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.DtpFechaNac.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.DtpFechaNac.Location = New System.Drawing.Point(327, 76)
        Me.DtpFechaNac.Name = "DtpFechaNac"
        Me.DtpFechaNac.Size = New System.Drawing.Size(334, 27)
        Me.DtpFechaNac.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(324, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(185, 21)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Direccion del Paciente"
        '
        'txt
        '
        Me.txt.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txt.Location = New System.Drawing.Point(327, 143)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(334, 27)
        Me.txt.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(324, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(178, 21)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Telefono del Paciente"
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtTelefono.Location = New System.Drawing.Point(327, 207)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(334, 27)
        Me.txtTelefono.TabIndex = 24
        '
        'iconButton3
        '
        Me.iconButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.iconButton3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.iconButton3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.iconButton3.ForeColor = System.Drawing.Color.White
        Me.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.iconButton3.Location = New System.Drawing.Point(327, 259)
        Me.iconButton3.Name = "iconButton3"
        Me.iconButton3.Size = New System.Drawing.Size(164, 47)
        Me.iconButton3.TabIndex = 25
        Me.iconButton3.Text = "Guardar"
        Me.iconButton3.UseVisualStyleBackColor = False
        '
        'iconButton2
        '
        Me.iconButton2.BackColor = System.Drawing.Color.Red
        Me.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.iconButton2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.iconButton2.ForeColor = System.Drawing.Color.White
        Me.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.iconButton2.Location = New System.Drawing.Point(497, 259)
        Me.iconButton2.Name = "iconButton2"
        Me.iconButton2.Size = New System.Drawing.Size(164, 47)
        Me.iconButton2.TabIndex = 26
        Me.iconButton2.Text = "Cancelar"
        Me.iconButton2.UseVisualStyleBackColor = False
        '
        'Editar_Paciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 341)
        Me.Controls.Add(Me.iconButton2)
        Me.Controls.Add(Me.iconButton3)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DtpFechaNac)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbGenero)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDni)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Name = "Editar_Paciente"
        Me.Text = "Editar_Paciente"
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents Button1 As Button
    Private WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDni As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbGenero As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DtpFechaNac As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents txt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTelefono As TextBox
    Private WithEvents iconButton3 As Button
    Private WithEvents iconButton2 As Button
End Class
