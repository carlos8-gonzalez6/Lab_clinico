<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empleados))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnempleadonuevo = New System.Windows.Forms.Button()
        Me.btnempleadoeditar = New System.Windows.Forms.Button()
        Me.dgv_empleados = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtempleadotelef = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdireccionempleado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtempleadoapellido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtempleadonombre = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.gb_empleados = New System.Windows.Forms.GroupBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.cmbgenero = New System.Windows.Forms.ComboBox()
        Me.pnlTitulo.SuspendLayout()
        CType(Me.dgv_empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_empleados.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.pnlTitulo.Controls.Add(Me.Button1)
        Me.pnlTitulo.Controls.Add(Me.Label1)
        Me.pnlTitulo.Location = New System.Drawing.Point(1, 1)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(1409, 42)
        Me.pnlTitulo.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(3, 5)
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
        Me.Label1.Location = New System.Drawing.Point(31, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Listado de Empleados"
        '
        'btnempleadonuevo
        '
        Me.btnempleadonuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnempleadonuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnempleadonuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnempleadonuevo.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnempleadonuevo.ForeColor = System.Drawing.Color.White
        Me.btnempleadonuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnempleadonuevo.Location = New System.Drawing.Point(464, 455)
        Me.btnempleadonuevo.Name = "btnempleadonuevo"
        Me.btnempleadonuevo.Size = New System.Drawing.Size(197, 47)
        Me.btnempleadonuevo.TabIndex = 23
        Me.btnempleadonuevo.Text = "Guardar Datos"
        Me.btnempleadonuevo.UseVisualStyleBackColor = False
        '
        'btnempleadoeditar
        '
        Me.btnempleadoeditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnempleadoeditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnempleadoeditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnempleadoeditar.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnempleadoeditar.ForeColor = System.Drawing.Color.White
        Me.btnempleadoeditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnempleadoeditar.Location = New System.Drawing.Point(692, 455)
        Me.btnempleadoeditar.Name = "btnempleadoeditar"
        Me.btnempleadoeditar.Size = New System.Drawing.Size(197, 47)
        Me.btnempleadoeditar.TabIndex = 24
        Me.btnempleadoeditar.Text = "Editar Empleado"
        Me.btnempleadoeditar.UseVisualStyleBackColor = False
        '
        'dgv_empleados
        '
        Me.dgv_empleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_empleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_empleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_empleados.BackgroundColor = System.Drawing.Color.White
        Me.dgv_empleados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_empleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_empleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_empleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_empleados.EnableHeadersVisualStyles = False
        Me.dgv_empleados.GridColor = System.Drawing.Color.SteelBlue
        Me.dgv_empleados.Location = New System.Drawing.Point(12, 61)
        Me.dgv_empleados.Name = "dgv_empleados"
        Me.dgv_empleados.RowHeadersVisible = False
        Me.dgv_empleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_empleados.Size = New System.Drawing.Size(434, 481)
        Me.dgv_empleados.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(227, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 21)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Teléfono"
        '
        'txtempleadotelef
        '
        Me.txtempleadotelef.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtempleadotelef.Location = New System.Drawing.Point(231, 200)
        Me.txtempleadotelef.Name = "txtempleadotelef"
        Me.txtempleadotelef.Size = New System.Drawing.Size(226, 27)
        Me.txtempleadotelef.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(227, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 21)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Dirección"
        '
        'txtdireccionempleado
        '
        Me.txtdireccionempleado.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdireccionempleado.Location = New System.Drawing.Point(231, 120)
        Me.txtdireccionempleado.Name = "txtdireccionempleado"
        Me.txtdireccionempleado.Size = New System.Drawing.Size(226, 27)
        Me.txtdireccionempleado.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(227, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 21)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Fecha de nacimiento"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(231, 44)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(226, 27)
        Me.DateTimePicker1.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 21)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Género"
        '
        'txtdni
        '
        Me.txtdni.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdni.Location = New System.Drawing.Point(13, 200)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(200, 27)
        Me.txtdni.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 21)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "DNI"
        '
        'txtempleadoapellido
        '
        Me.txtempleadoapellido.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtempleadoapellido.Location = New System.Drawing.Point(13, 120)
        Me.txtempleadoapellido.Name = "txtempleadoapellido"
        Me.txtempleadoapellido.Size = New System.Drawing.Size(200, 27)
        Me.txtempleadoapellido.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 21)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Apellido"
        '
        'txtempleadonombre
        '
        Me.txtempleadonombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtempleadonombre.Location = New System.Drawing.Point(13, 44)
        Me.txtempleadonombre.Name = "txtempleadonombre"
        Me.txtempleadonombre.Size = New System.Drawing.Size(200, 27)
        Me.txtempleadonombre.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 21)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Nombre"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(563, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(249, 30)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Datos del Empleado"
        '
        'gb_empleados
        '
        Me.gb_empleados.Controls.Add(Me.cmbgenero)
        Me.gb_empleados.Controls.Add(Me.txtid)
        Me.gb_empleados.Controls.Add(Me.Label7)
        Me.gb_empleados.Controls.Add(Me.txtempleadotelef)
        Me.gb_empleados.Controls.Add(Me.Label6)
        Me.gb_empleados.Controls.Add(Me.txtdireccionempleado)
        Me.gb_empleados.Controls.Add(Me.Label5)
        Me.gb_empleados.Controls.Add(Me.DateTimePicker1)
        Me.gb_empleados.Controls.Add(Me.Label4)
        Me.gb_empleados.Controls.Add(Me.txtdni)
        Me.gb_empleados.Controls.Add(Me.Label3)
        Me.gb_empleados.Controls.Add(Me.txtempleadoapellido)
        Me.gb_empleados.Controls.Add(Me.Label2)
        Me.gb_empleados.Controls.Add(Me.txtempleadonombre)
        Me.gb_empleados.Controls.Add(Me.Label8)
        Me.gb_empleados.Location = New System.Drawing.Point(445, 90)
        Me.gb_empleados.Name = "gb_empleados"
        Me.gb_empleados.Size = New System.Drawing.Size(476, 352)
        Me.gb_empleados.TabIndex = 41
        Me.gb_empleados.TabStop = False
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(231, 280)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(200, 27)
        Me.txtid.TabIndex = 40
        Me.txtid.Visible = False
        '
        'cmbgenero
        '
        Me.cmbgenero.FormattingEnabled = True
        Me.cmbgenero.Items.AddRange(New Object() {"MASCULINO", "FEMENINO"})
        Me.cmbgenero.Location = New System.Drawing.Point(19, 286)
        Me.cmbgenero.Name = "cmbgenero"
        Me.cmbgenero.Size = New System.Drawing.Size(194, 21)
        Me.cmbgenero.TabIndex = 41
        '
        'Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(960, 571)
        Me.Controls.Add(Me.gb_empleados)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dgv_empleados)
        Me.Controls.Add(Me.btnempleadoeditar)
        Me.Controls.Add(Me.btnempleadonuevo)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Name = "Empleados"
        Me.Text = "Empleados"
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        CType(Me.dgv_empleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_empleados.ResumeLayout(False)
        Me.gb_empleados.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents Button1 As Button
    Private WithEvents Label1 As Label
    Private WithEvents btnempleadonuevo As Button
    Private WithEvents btnempleadoeditar As Button
    Private WithEvents dgv_empleados As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents txtempleadotelef As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtdireccionempleado As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents txtdni As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtempleadoapellido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtempleadonombre As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents gb_empleados As GroupBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents cmbgenero As ComboBox
End Class
