<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_pacientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_pacientes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.dg_pacientes = New System.Windows.Forms.DataGridView()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.gb_Pacientes = New System.Windows.Forms.GroupBox()
        Me.DtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbGenero = New System.Windows.Forms.ComboBox()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlTitulo.SuspendLayout()
        CType(Me.dg_pacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_Pacientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.pnlTitulo.Controls.Add(Me.Button1)
        Me.pnlTitulo.Controls.Add(Me.Label1)
        Me.pnlTitulo.Location = New System.Drawing.Point(1, 1)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(958, 42)
        Me.pnlTitulo.TabIndex = 2
        Me.pnlTitulo.UseWaitCursor = True
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
        Me.Button1.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(39, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Listado de Pacientes"
        Me.Label1.UseWaitCursor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(471, 400)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(197, 47)
        Me.btnGuardar.TabIndex = 22
        Me.btnGuardar.Text = "Guardar Paciente"
        Me.btnGuardar.UseVisualStyleBackColor = False
        Me.btnGuardar.UseWaitCursor = True
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(689, 400)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(197, 47)
        Me.btnEditar.TabIndex = 23
        Me.btnEditar.Text = "Editar Paciente"
        Me.btnEditar.UseVisualStyleBackColor = False
        Me.btnEditar.UseWaitCursor = True
        '
        'dg_pacientes
        '
        Me.dg_pacientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_pacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_pacientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg_pacientes.BackgroundColor = System.Drawing.Color.White
        Me.dg_pacientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_pacientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dg_pacientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_pacientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dg_pacientes.EnableHeadersVisualStyles = False
        Me.dg_pacientes.GridColor = System.Drawing.Color.SteelBlue
        Me.dg_pacientes.Location = New System.Drawing.Point(4, 82)
        Me.dg_pacientes.Name = "dg_pacientes"
        Me.dg_pacientes.ReadOnly = True
        Me.dg_pacientes.RowHeadersVisible = False
        Me.dg_pacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_pacientes.Size = New System.Drawing.Size(434, 424)
        Me.dg_pacientes.TabIndex = 24
        Me.dg_pacientes.UseWaitCursor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscar.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtBuscar.Location = New System.Drawing.Point(10, 45)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(250, 27)
        Me.txtBuscar.TabIndex = 42
        Me.txtBuscar.Text = "Buscar Paciente"
        Me.txtBuscar.UseWaitCursor = True
        '
        'gb_Pacientes
        '
        Me.gb_Pacientes.Controls.Add(Me.DtpFechaNac)
        Me.gb_Pacientes.Controls.Add(Me.txtTelefono)
        Me.gb_Pacientes.Controls.Add(Me.txtDireccion)
        Me.gb_Pacientes.Controls.Add(Me.Label8)
        Me.gb_Pacientes.Controls.Add(Me.Label7)
        Me.gb_Pacientes.Controls.Add(Me.Label6)
        Me.gb_Pacientes.Controls.Add(Me.cmbGenero)
        Me.gb_Pacientes.Controls.Add(Me.txtDni)
        Me.gb_Pacientes.Controls.Add(Me.txtApellido)
        Me.gb_Pacientes.Controls.Add(Me.txtNombre)
        Me.gb_Pacientes.Controls.Add(Me.Label5)
        Me.gb_Pacientes.Controls.Add(Me.Label4)
        Me.gb_Pacientes.Controls.Add(Me.Label3)
        Me.gb_Pacientes.Controls.Add(Me.Label2)
        Me.gb_Pacientes.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.gb_Pacientes.Location = New System.Drawing.Point(444, 82)
        Me.gb_Pacientes.Name = "gb_Pacientes"
        Me.gb_Pacientes.Size = New System.Drawing.Size(504, 303)
        Me.gb_Pacientes.TabIndex = 59
        Me.gb_Pacientes.TabStop = False
        Me.gb_Pacientes.Text = "Datos Personales"
        Me.gb_Pacientes.UseWaitCursor = True
        '
        'DtpFechaNac
        '
        Me.DtpFechaNac.CalendarFont = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.DtpFechaNac.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.DtpFechaNac.Location = New System.Drawing.Point(267, 67)
        Me.DtpFechaNac.Name = "DtpFechaNac"
        Me.DtpFechaNac.Size = New System.Drawing.Size(226, 27)
        Me.DtpFechaNac.TabIndex = 71
        Me.DtpFechaNac.UseWaitCursor = True
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtTelefono.Location = New System.Drawing.Point(267, 198)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(226, 27)
        Me.txtTelefono.TabIndex = 70
        Me.txtTelefono.UseWaitCursor = True
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtDireccion.Location = New System.Drawing.Point(267, 134)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(226, 27)
        Me.txtDireccion.TabIndex = 69
        Me.txtDireccion.UseWaitCursor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(264, 177)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(178, 21)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Telefono del Paciente"
        Me.Label8.UseWaitCursor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(264, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(185, 21)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Direccion del Paciente"
        Me.Label7.UseWaitCursor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(264, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(179, 21)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Fecha de Nacimiento"
        Me.Label6.UseWaitCursor = True
        '
        'cmbGenero
        '
        Me.cmbGenero.DropDownWidth = 223
        Me.cmbGenero.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.cmbGenero.FormattingEnabled = True
        Me.cmbGenero.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.cmbGenero.Location = New System.Drawing.Point(17, 261)
        Me.cmbGenero.Name = "cmbGenero"
        Me.cmbGenero.Size = New System.Drawing.Size(223, 29)
        Me.cmbGenero.TabIndex = 65
        Me.cmbGenero.UseWaitCursor = True
        '
        'txtDni
        '
        Me.txtDni.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtDni.Location = New System.Drawing.Point(17, 198)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(223, 27)
        Me.txtDni.TabIndex = 64
        Me.txtDni.UseWaitCursor = True
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtApellido.Location = New System.Drawing.Point(17, 134)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(223, 27)
        Me.txtApellido.TabIndex = 63
        Me.txtApellido.UseWaitCursor = True
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtNombre.Location = New System.Drawing.Point(17, 67)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(223, 27)
        Me.txtNombre.TabIndex = 62
        Me.txtNombre.UseWaitCursor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(14, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 21)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Genero del Paciente"
        Me.Label5.UseWaitCursor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(14, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 21)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Apellido del Paciente"
        Me.Label4.UseWaitCursor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(14, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 21)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Dni del Paciente"
        Me.Label3.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(14, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 21)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Nombre del Paciente"
        Me.Label2.UseWaitCursor = True
        '
        'frm_pacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(960, 571)
        Me.Controls.Add(Me.gb_Pacientes)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.dg_pacientes)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Name = "frm_pacientes"
        Me.Text = "Pacientes"
        Me.UseWaitCursor = True
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        CType(Me.dg_pacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_Pacientes.ResumeLayout(False)
        Me.gb_Pacientes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents Button1 As Button
    Private WithEvents Label1 As Label
    Private WithEvents btnGuardar As Button
    Private WithEvents btnEditar As Button
    Private WithEvents dg_pacientes As DataGridView
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents gb_Pacientes As GroupBox
    Friend WithEvents DtpFechaNac As DateTimePicker
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbGenero As ComboBox
    Friend WithEvents txtDni As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
