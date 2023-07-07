<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_categoria
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnnuevacategoria = New System.Windows.Forms.Button()
        Me.btneditarcategoria = New System.Windows.Forms.Button()
        Me.lblnombrecategoria = New System.Windows.Forms.Label()
        Me.txtnombrecategoria = New System.Windows.Forms.TextBox()
        Me.dgv_categoria = New System.Windows.Forms.DataGridView()
        Me.btn_categoria = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_categoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(2, 59)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(538, 50)
        Me.Panel2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(204, 11)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Exámenes"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1111, 50)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(369, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Catálogo de exámenes"
        '
        'btnnuevacategoria
        '
        Me.btnnuevacategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnnuevacategoria.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevacategoria.ForeColor = System.Drawing.Color.White
        Me.btnnuevacategoria.Location = New System.Drawing.Point(227, 610)
        Me.btnnuevacategoria.Name = "btnnuevacategoria"
        Me.btnnuevacategoria.Size = New System.Drawing.Size(209, 47)
        Me.btnnuevacategoria.TabIndex = 10
        Me.btnnuevacategoria.Text = "Guardar categoría"
        Me.btnnuevacategoria.UseVisualStyleBackColor = False
        '
        'btneditarcategoria
        '
        Me.btneditarcategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btneditarcategoria.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditarcategoria.ForeColor = System.Drawing.Color.White
        Me.btneditarcategoria.Location = New System.Drawing.Point(623, 610)
        Me.btneditarcategoria.Name = "btneditarcategoria"
        Me.btneditarcategoria.Size = New System.Drawing.Size(209, 47)
        Me.btneditarcategoria.TabIndex = 11
        Me.btneditarcategoria.Text = "Editar categoría"
        Me.btneditarcategoria.UseVisualStyleBackColor = False
        '
        'lblnombrecategoria
        '
        Me.lblnombrecategoria.AutoSize = True
        Me.lblnombrecategoria.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombrecategoria.ForeColor = System.Drawing.Color.Black
        Me.lblnombrecategoria.Location = New System.Drawing.Point(41, 182)
        Me.lblnombrecategoria.Name = "lblnombrecategoria"
        Me.lblnombrecategoria.Size = New System.Drawing.Size(222, 21)
        Me.lblnombrecategoria.TabIndex = 18
        Me.lblnombrecategoria.Text = "Nombre de la categoría"
        '
        'txtnombrecategoria
        '
        Me.txtnombrecategoria.Location = New System.Drawing.Point(45, 219)
        Me.txtnombrecategoria.Name = "txtnombrecategoria"
        Me.txtnombrecategoria.Size = New System.Drawing.Size(391, 22)
        Me.txtnombrecategoria.TabIndex = 19
        '
        'dgv_categoria
        '
        Me.dgv_categoria.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_categoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_categoria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_categoria.BackgroundColor = System.Drawing.Color.White
        Me.dgv_categoria.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_categoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_categoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_categoria.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_categoria.ColumnHeadersHeight = 29
        Me.dgv_categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_categoria.EnableHeadersVisualStyles = False
        Me.dgv_categoria.GridColor = System.Drawing.Color.SteelBlue
        Me.dgv_categoria.Location = New System.Drawing.Point(531, 143)
        Me.dgv_categoria.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_categoria.Name = "dgv_categoria"
        Me.dgv_categoria.ReadOnly = True
        Me.dgv_categoria.RowHeadersVisible = False
        Me.dgv_categoria.RowHeadersWidth = 51
        Me.dgv_categoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_categoria.Size = New System.Drawing.Size(470, 411)
        Me.dgv_categoria.TabIndex = 25
        '
        'btn_categoria
        '
        Me.btn_categoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btn_categoria.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_categoria.ForeColor = System.Drawing.Color.White
        Me.btn_categoria.Location = New System.Drawing.Point(531, 58)
        Me.btn_categoria.Name = "btn_categoria"
        Me.btn_categoria.Size = New System.Drawing.Size(517, 51)
        Me.btn_categoria.TabIndex = 26
        Me.btn_categoria.Text = "Categoría"
        Me.btn_categoria.UseVisualStyleBackColor = False
        '
        'frm_categoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1044, 676)
        Me.Controls.Add(Me.btn_categoria)
        Me.Controls.Add(Me.dgv_categoria)
        Me.Controls.Add(Me.txtnombrecategoria)
        Me.Controls.Add(Me.lblnombrecategoria)
        Me.Controls.Add(Me.btneditarcategoria)
        Me.Controls.Add(Me.btnnuevacategoria)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frm_categoria"
        Me.Text = "categoria"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_categoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnnuevacategoria As Button
    Friend WithEvents btneditarcategoria As Button
    Friend WithEvents lblnombrecategoria As Label
    Friend WithEvents txtnombrecategoria As TextBox
    Private WithEvents dgv_categoria As DataGridView
    Friend WithEvents btn_categoria As Button
End Class
