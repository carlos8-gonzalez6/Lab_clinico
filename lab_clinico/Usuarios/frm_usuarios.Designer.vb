<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_usuarios))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_agregar_usuarios = New System.Windows.Forms.Button()
        Me.btn_editar_usuarios = New System.Windows.Forms.Button()
        Me.txt_buscar_usuario = New System.Windows.Forms.TextBox()
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_contraseña = New System.Windows.Forms.TextBox()
        Me.txt_confirmar = New System.Windows.Forms.TextBox()
        Me.txt_correo = New System.Windows.Forms.TextBox()
        Me.txt_nombre_usuario = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_dni = New System.Windows.Forms.TextBox()
        Me.dg_facturacion = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gb_usuarios = New System.Windows.Forms.GroupBox()
        Me.pnlTitulo.SuspendLayout()
        CType(Me.dg_facturacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_usuarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_agregar_usuarios
        '
        Me.btn_agregar_usuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btn_agregar_usuarios.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btn_agregar_usuarios.ForeColor = System.Drawing.Color.White
        Me.btn_agregar_usuarios.Location = New System.Drawing.Point(459, 380)
        Me.btn_agregar_usuarios.Name = "btn_agregar_usuarios"
        Me.btn_agregar_usuarios.Size = New System.Drawing.Size(211, 46)
        Me.btn_agregar_usuarios.TabIndex = 2
        Me.btn_agregar_usuarios.Text = "AGREGAR"
        Me.btn_agregar_usuarios.UseVisualStyleBackColor = False
        '
        'btn_editar_usuarios
        '
        Me.btn_editar_usuarios.BackColor = System.Drawing.Color.OrangeRed
        Me.btn_editar_usuarios.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btn_editar_usuarios.ForeColor = System.Drawing.Color.White
        Me.btn_editar_usuarios.Location = New System.Drawing.Point(718, 380)
        Me.btn_editar_usuarios.Name = "btn_editar_usuarios"
        Me.btn_editar_usuarios.Size = New System.Drawing.Size(211, 46)
        Me.btn_editar_usuarios.TabIndex = 3
        Me.btn_editar_usuarios.Text = "EDITAR"
        Me.btn_editar_usuarios.UseVisualStyleBackColor = False
        '
        'txt_buscar_usuario
        '
        Me.txt_buscar_usuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_buscar_usuario.BackColor = System.Drawing.Color.White
        Me.txt_buscar_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_buscar_usuario.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txt_buscar_usuario.ForeColor = System.Drawing.Color.Black
        Me.txt_buscar_usuario.Location = New System.Drawing.Point(12, 53)
        Me.txt_buscar_usuario.Name = "txt_buscar_usuario"
        Me.txt_buscar_usuario.Size = New System.Drawing.Size(549, 27)
        Me.txt_buscar_usuario.TabIndex = 43
        Me.txt_buscar_usuario.Text = "Buscar Usuario"
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.pnlTitulo.Controls.Add(Me.btn_cerrar)
        Me.pnlTitulo.Controls.Add(Me.Label5)
        Me.pnlTitulo.Location = New System.Drawing.Point(-1, 0)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(987, 36)
        Me.pnlTitulo.TabIndex = 45
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(284, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 21)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Confirmar Contraseña"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(283, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 21)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Correo Electronico"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(32, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 21)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(26, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 21)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Nombre de Usuario"
        '
        'txt_contraseña
        '
        Me.txt_contraseña.Location = New System.Drawing.Point(35, 201)
        Me.txt_contraseña.Name = "txt_contraseña"
        Me.txt_contraseña.Size = New System.Drawing.Size(213, 27)
        Me.txt_contraseña.TabIndex = 49
        '
        'txt_confirmar
        '
        Me.txt_confirmar.Location = New System.Drawing.Point(287, 201)
        Me.txt_confirmar.Name = "txt_confirmar"
        Me.txt_confirmar.Size = New System.Drawing.Size(217, 27)
        Me.txt_confirmar.TabIndex = 48
        '
        'txt_correo
        '
        Me.txt_correo.Location = New System.Drawing.Point(287, 57)
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.Size = New System.Drawing.Size(217, 27)
        Me.txt_correo.TabIndex = 47
        '
        'txt_nombre_usuario
        '
        Me.txt_nombre_usuario.Location = New System.Drawing.Point(30, 57)
        Me.txt_nombre_usuario.Name = "txt_nombre_usuario"
        Me.txt_nombre_usuario.Size = New System.Drawing.Size(218, 27)
        Me.txt_nombre_usuario.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(31, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 21)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "DNI"
        '
        'txt_dni
        '
        Me.txt_dni.Location = New System.Drawing.Point(31, 119)
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.Size = New System.Drawing.Size(217, 27)
        Me.txt_dni.TabIndex = 54
        '
        'dg_facturacion
        '
        Me.dg_facturacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_facturacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_facturacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg_facturacion.BackgroundColor = System.Drawing.Color.White
        Me.dg_facturacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_facturacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dg_facturacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_facturacion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dg_facturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dg_facturacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dg_facturacion.EnableHeadersVisualStyles = False
        Me.dg_facturacion.GridColor = System.Drawing.Color.SteelBlue
        Me.dg_facturacion.Location = New System.Drawing.Point(12, 86)
        Me.dg_facturacion.Name = "dg_facturacion"
        Me.dg_facturacion.ReadOnly = True
        Me.dg_facturacion.RowHeadersVisible = False
        Me.dg_facturacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_facturacion.Size = New System.Drawing.Size(426, 473)
        Me.dg_facturacion.TabIndex = 56
        '
        'Column1
        '
        Me.Column1.HeaderText = "#"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 47
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre "
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 112
        '
        'Column3
        '
        Me.Column3.HeaderText = "Correo Electronico"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 202
        '
        'Column4
        '
        Me.Column4.HeaderText = "DNI"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 66
        '
        'gb_usuarios
        '
        Me.gb_usuarios.BackColor = System.Drawing.Color.White
        Me.gb_usuarios.Controls.Add(Me.txt_contraseña)
        Me.gb_usuarios.Controls.Add(Me.txt_nombre_usuario)
        Me.gb_usuarios.Controls.Add(Me.Label6)
        Me.gb_usuarios.Controls.Add(Me.txt_correo)
        Me.gb_usuarios.Controls.Add(Me.txt_dni)
        Me.gb_usuarios.Controls.Add(Me.txt_confirmar)
        Me.gb_usuarios.Controls.Add(Me.Label4)
        Me.gb_usuarios.Controls.Add(Me.Label1)
        Me.gb_usuarios.Controls.Add(Me.Label3)
        Me.gb_usuarios.Controls.Add(Me.Label2)
        Me.gb_usuarios.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_usuarios.ForeColor = System.Drawing.Color.Black
        Me.gb_usuarios.Location = New System.Drawing.Point(444, 86)
        Me.gb_usuarios.Name = "gb_usuarios"
        Me.gb_usuarios.Size = New System.Drawing.Size(512, 239)
        Me.gb_usuarios.TabIndex = 57
        Me.gb_usuarios.TabStop = False
        Me.gb_usuarios.Text = "Datos de Usuario"
        '
        'frm_usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(960, 571)
        Me.Controls.Add(Me.gb_usuarios)
        Me.Controls.Add(Me.dg_facturacion)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Controls.Add(Me.txt_buscar_usuario)
        Me.Controls.Add(Me.btn_editar_usuarios)
        Me.Controls.Add(Me.btn_agregar_usuarios)
        Me.Name = "frm_usuarios"
        Me.Text = "Usuarios"
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        CType(Me.dg_facturacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_usuarios.ResumeLayout(False)
        Me.gb_usuarios.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_agregar_usuarios As Button
    Friend WithEvents btn_editar_usuarios As Button
    Friend WithEvents txt_buscar_usuario As TextBox
    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents btn_cerrar As Button
    Private WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_contraseña As TextBox
    Friend WithEvents txt_confirmar As TextBox
    Friend WithEvents txt_correo As TextBox
    Friend WithEvents txt_nombre_usuario As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_dni As TextBox
    Private WithEvents dg_facturacion As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents gb_usuarios As GroupBox
End Class
