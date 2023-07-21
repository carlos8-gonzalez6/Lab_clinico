<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_facturacion
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnl_frm_facturacion1 = New System.Windows.Forms.Panel()
        Me.lbl_frm_facturacion1 = New System.Windows.Forms.Label()
        Me.btn_frm_facturacion1 = New System.Windows.Forms.Button()
        Me.dg_facturacion = New System.Windows.Forms.DataGridView()
        Me.gb_facturacion = New System.Windows.Forms.GroupBox()
        Me.txt_examen = New System.Windows.Forms.TextBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_descuento = New System.Windows.Forms.TextBox()
        Me.lbl_examen_medico = New System.Windows.Forms.Label()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.lbl_paciente = New System.Windows.Forms.Label()
        Me.txt_paciente = New System.Windows.Forms.TextBox()
        Me.lbl_precio = New System.Windows.Forms.Label()
        Me.lbl_descuento = New System.Windows.Forms.Label()
        Me.EP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnl_frm_facturacion1.SuspendLayout()
        CType(Me.dg_facturacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_facturacion.SuspendLayout()
        CType(Me.EP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_frm_facturacion1
        '
        Me.pnl_frm_facturacion1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.pnl_frm_facturacion1.Controls.Add(Me.lbl_frm_facturacion1)
        Me.pnl_frm_facturacion1.Location = New System.Drawing.Point(0, 0)
        Me.pnl_frm_facturacion1.Name = "pnl_frm_facturacion1"
        Me.pnl_frm_facturacion1.Size = New System.Drawing.Size(913, 41)
        Me.pnl_frm_facturacion1.TabIndex = 0
        '
        'lbl_frm_facturacion1
        '
        Me.lbl_frm_facturacion1.AutoSize = True
        Me.lbl_frm_facturacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_frm_facturacion1.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_frm_facturacion1.Location = New System.Drawing.Point(12, 9)
        Me.lbl_frm_facturacion1.Name = "lbl_frm_facturacion1"
        Me.lbl_frm_facturacion1.Size = New System.Drawing.Size(125, 25)
        Me.lbl_frm_facturacion1.TabIndex = 0
        Me.lbl_frm_facturacion1.Text = "Facturación"
        '
        'btn_frm_facturacion1
        '
        Me.btn_frm_facturacion1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btn_frm_facturacion1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_frm_facturacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_frm_facturacion1.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_frm_facturacion1.Location = New System.Drawing.Point(46, 207)
        Me.btn_frm_facturacion1.Name = "btn_frm_facturacion1"
        Me.btn_frm_facturacion1.Size = New System.Drawing.Size(196, 50)
        Me.btn_frm_facturacion1.TabIndex = 2
        Me.btn_frm_facturacion1.Text = "Agregar"
        Me.btn_frm_facturacion1.UseVisualStyleBackColor = False
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_facturacion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_facturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dg_facturacion.EnableHeadersVisualStyles = False
        Me.dg_facturacion.GridColor = System.Drawing.Color.SteelBlue
        Me.dg_facturacion.Location = New System.Drawing.Point(17, 47)
        Me.dg_facturacion.Name = "dg_facturacion"
        Me.dg_facturacion.ReadOnly = True
        Me.dg_facturacion.RowHeadersVisible = False
        Me.dg_facturacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_facturacion.Size = New System.Drawing.Size(598, 440)
        Me.dg_facturacion.TabIndex = 25
        '
        'gb_facturacion
        '
        Me.gb_facturacion.Controls.Add(Me.txt_examen)
        Me.gb_facturacion.Controls.Add(Me.btn_buscar)
        Me.gb_facturacion.Controls.Add(Me.btn_frm_facturacion1)
        Me.gb_facturacion.Controls.Add(Me.txt_descuento)
        Me.gb_facturacion.Controls.Add(Me.lbl_examen_medico)
        Me.gb_facturacion.Controls.Add(Me.txt_precio)
        Me.gb_facturacion.Controls.Add(Me.lbl_paciente)
        Me.gb_facturacion.Controls.Add(Me.txt_paciente)
        Me.gb_facturacion.Controls.Add(Me.lbl_precio)
        Me.gb_facturacion.Controls.Add(Me.lbl_descuento)
        Me.gb_facturacion.Location = New System.Drawing.Point(605, 48)
        Me.gb_facturacion.Name = "gb_facturacion"
        Me.gb_facturacion.Size = New System.Drawing.Size(280, 263)
        Me.gb_facturacion.TabIndex = 26
        Me.gb_facturacion.TabStop = False
        Me.gb_facturacion.Text = "Datos de Facturación"
        '
        'txt_examen
        '
        Me.txt_examen.Location = New System.Drawing.Point(10, 40)
        Me.txt_examen.Name = "txt_examen"
        Me.txt_examen.Size = New System.Drawing.Size(259, 20)
        Me.txt_examen.TabIndex = 38
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(134, 13)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 37
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'txt_descuento
        '
        Me.txt_descuento.Location = New System.Drawing.Point(10, 178)
        Me.txt_descuento.Name = "txt_descuento"
        Me.txt_descuento.Size = New System.Drawing.Size(259, 20)
        Me.txt_descuento.TabIndex = 36
        Me.txt_descuento.Text = "0"
        '
        'lbl_examen_medico
        '
        Me.lbl_examen_medico.AutoSize = True
        Me.lbl_examen_medico.BackColor = System.Drawing.Color.White
        Me.lbl_examen_medico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_examen_medico.ForeColor = System.Drawing.Color.Black
        Me.lbl_examen_medico.Location = New System.Drawing.Point(6, 16)
        Me.lbl_examen_medico.Name = "lbl_examen_medico"
        Me.lbl_examen_medico.Size = New System.Drawing.Size(122, 20)
        Me.lbl_examen_medico.TabIndex = 27
        Me.lbl_examen_medico.Text = "Examen Médico"
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(10, 132)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(259, 20)
        Me.txt_precio.TabIndex = 35
        Me.txt_precio.Text = "0"
        '
        'lbl_paciente
        '
        Me.lbl_paciente.AutoSize = True
        Me.lbl_paciente.BackColor = System.Drawing.Color.White
        Me.lbl_paciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_paciente.ForeColor = System.Drawing.Color.Black
        Me.lbl_paciente.Location = New System.Drawing.Point(6, 63)
        Me.lbl_paciente.Name = "lbl_paciente"
        Me.lbl_paciente.Size = New System.Drawing.Size(71, 20)
        Me.lbl_paciente.TabIndex = 28
        Me.lbl_paciente.Text = "Paciente"
        '
        'txt_paciente
        '
        Me.txt_paciente.Location = New System.Drawing.Point(10, 86)
        Me.txt_paciente.Name = "txt_paciente"
        Me.txt_paciente.Size = New System.Drawing.Size(258, 20)
        Me.txt_paciente.TabIndex = 33
        '
        'lbl_precio
        '
        Me.lbl_precio.AutoSize = True
        Me.lbl_precio.BackColor = System.Drawing.Color.White
        Me.lbl_precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_precio.ForeColor = System.Drawing.Color.Black
        Me.lbl_precio.Location = New System.Drawing.Point(6, 109)
        Me.lbl_precio.Name = "lbl_precio"
        Me.lbl_precio.Size = New System.Drawing.Size(53, 20)
        Me.lbl_precio.TabIndex = 30
        Me.lbl_precio.Text = "Precio"
        '
        'lbl_descuento
        '
        Me.lbl_descuento.AutoSize = True
        Me.lbl_descuento.BackColor = System.Drawing.Color.White
        Me.lbl_descuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descuento.ForeColor = System.Drawing.Color.Black
        Me.lbl_descuento.Location = New System.Drawing.Point(6, 155)
        Me.lbl_descuento.Name = "lbl_descuento"
        Me.lbl_descuento.Size = New System.Drawing.Size(87, 20)
        Me.lbl_descuento.TabIndex = 31
        Me.lbl_descuento.Text = "Descuento"
        '
        'EP
        '
        Me.EP.ContainerControl = Me
        '
        'frm_facturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(913, 499)
        Me.Controls.Add(Me.gb_facturacion)
        Me.Controls.Add(Me.dg_facturacion)
        Me.Controls.Add(Me.pnl_frm_facturacion1)
        Me.Name = "frm_facturacion"
        Me.Text = "frm_facturacion"
        Me.pnl_frm_facturacion1.ResumeLayout(False)
        Me.pnl_frm_facturacion1.PerformLayout()
        CType(Me.dg_facturacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_facturacion.ResumeLayout(False)
        Me.gb_facturacion.PerformLayout()
        CType(Me.EP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_frm_facturacion1 As Panel
    Friend WithEvents lbl_frm_facturacion1 As Label
    Friend WithEvents btn_frm_facturacion1 As Button
    Private WithEvents dg_facturacion As DataGridView
    Friend WithEvents gb_facturacion As GroupBox
    Friend WithEvents txt_descuento As TextBox
    Friend WithEvents lbl_examen_medico As Label
    Friend WithEvents txt_precio As TextBox
    Friend WithEvents lbl_paciente As Label
    Friend WithEvents txt_paciente As TextBox
    Friend WithEvents lbl_precio As Label
    Friend WithEvents lbl_descuento As Label
    Friend WithEvents EP As ErrorProvider
    Friend WithEvents txt_examen As TextBox
    Friend WithEvents btn_buscar As Button
End Class
