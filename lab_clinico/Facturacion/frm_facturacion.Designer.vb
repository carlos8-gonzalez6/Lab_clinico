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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnl_frm_facturacion1 = New System.Windows.Forms.Panel()
        Me.lbl_frm_facturacion1 = New System.Windows.Forms.Label()
        Me.btn_frm_facturacion1 = New System.Windows.Forms.Button()
        Me.dg_pacientes = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnl_frm_facturacion1.SuspendLayout()
        CType(Me.dg_pacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_frm_facturacion1
        '
        Me.pnl_frm_facturacion1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.pnl_frm_facturacion1.Controls.Add(Me.lbl_frm_facturacion1)
        Me.pnl_frm_facturacion1.Location = New System.Drawing.Point(0, 0)
        Me.pnl_frm_facturacion1.Name = "pnl_frm_facturacion1"
        Me.pnl_frm_facturacion1.Size = New System.Drawing.Size(834, 41)
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
        Me.btn_frm_facturacion1.Location = New System.Drawing.Point(12, 388)
        Me.btn_frm_facturacion1.Name = "btn_frm_facturacion1"
        Me.btn_frm_facturacion1.Size = New System.Drawing.Size(196, 50)
        Me.btn_frm_facturacion1.TabIndex = 2
        Me.btn_frm_facturacion1.Text = "Nueva Factura"
        Me.btn_frm_facturacion1.UseVisualStyleBackColor = False
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
        Me.dg_pacientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dg_pacientes.EnableHeadersVisualStyles = False
        Me.dg_pacientes.GridColor = System.Drawing.Color.SteelBlue
        Me.dg_pacientes.Location = New System.Drawing.Point(17, 47)
        Me.dg_pacientes.Name = "dg_pacientes"
        Me.dg_pacientes.ReadOnly = True
        Me.dg_pacientes.RowHeadersVisible = False
        Me.dg_pacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_pacientes.Size = New System.Drawing.Size(797, 319)
        Me.dg_pacientes.TabIndex = 25
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
        Me.Column2.HeaderText = "Codigo"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 101
        '
        'Column3
        '
        Me.Column3.HeaderText = "Fecha de Facturación"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 237
        '
        'Column4
        '
        Me.Column4.HeaderText = "Paciente"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 115
        '
        'Column5
        '
        Me.Column5.HeaderText = "Empleado"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 126
        '
        'Column6
        '
        Me.Column6.HeaderText = "Subtotal"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 109
        '
        'Column7
        '
        Me.Column7.HeaderText = "ISV"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 62
        '
        'frm_facturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(831, 450)
        Me.Controls.Add(Me.dg_pacientes)
        Me.Controls.Add(Me.btn_frm_facturacion1)
        Me.Controls.Add(Me.pnl_frm_facturacion1)
        Me.Name = "frm_facturacion"
        Me.Text = "frm_facturacion"
        Me.pnl_frm_facturacion1.ResumeLayout(False)
        Me.pnl_frm_facturacion1.PerformLayout()
        CType(Me.dg_pacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_frm_facturacion1 As Panel
    Friend WithEvents lbl_frm_facturacion1 As Label
    Friend WithEvents btn_frm_facturacion1 As Button
    Private WithEvents dg_pacientes As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
