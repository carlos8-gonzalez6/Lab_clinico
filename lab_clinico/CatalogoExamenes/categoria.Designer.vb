<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class categoria
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvcategoria = New System.Windows.Forms.DataGridView()
        Me.btncodigocategoria = New System.Windows.Forms.Button()
        Me.btnnuevacategoria = New System.Windows.Forms.Button()
        Me.btneditarcategoria = New System.Windows.Forms.Button()
        Me.btneliminarcategoria = New System.Windows.Forms.Button()
        Me.btncantexamenes = New System.Windows.Forms.Button()
        Me.btncategoriaexamen = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvcategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(2, 124)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(561, 50)
        Me.Panel2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(229, 11)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Exámenes"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(562, 124)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(551, 50)
        Me.Panel3.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(205, 11)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Categoría"
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
        Me.Label1.Location = New System.Drawing.Point(410, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Catálogo de exámenes"
        '
        'dgvcategoria
        '
        Me.dgvcategoria.BackgroundColor = System.Drawing.Color.White
        Me.dgvcategoria.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvcategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcategoria.Location = New System.Drawing.Point(2, 172)
        Me.dgvcategoria.Name = "dgvcategoria"
        Me.dgvcategoria.RowHeadersWidth = 51
        Me.dgvcategoria.RowTemplate.Height = 24
        Me.dgvcategoria.Size = New System.Drawing.Size(1108, 505)
        Me.dgvcategoria.TabIndex = 5
        '
        'btncodigocategoria
        '
        Me.btncodigocategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btncodigocategoria.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncodigocategoria.ForeColor = System.Drawing.Color.White
        Me.btncodigocategoria.Location = New System.Drawing.Point(197, 220)
        Me.btncodigocategoria.Name = "btncodigocategoria"
        Me.btncodigocategoria.Size = New System.Drawing.Size(141, 46)
        Me.btncodigocategoria.TabIndex = 9
        Me.btncodigocategoria.Text = "Código"
        Me.btncodigocategoria.UseVisualStyleBackColor = False
        '
        'btnnuevacategoria
        '
        Me.btnnuevacategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnnuevacategoria.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevacategoria.ForeColor = System.Drawing.Color.White
        Me.btnnuevacategoria.Location = New System.Drawing.Point(197, 593)
        Me.btnnuevacategoria.Name = "btnnuevacategoria"
        Me.btnnuevacategoria.Size = New System.Drawing.Size(209, 47)
        Me.btnnuevacategoria.TabIndex = 10
        Me.btnnuevacategoria.Text = "Nueva categoría"
        Me.btnnuevacategoria.UseVisualStyleBackColor = False
        '
        'btneditarcategoria
        '
        Me.btneditarcategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btneditarcategoria.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditarcategoria.ForeColor = System.Drawing.Color.White
        Me.btneditarcategoria.Location = New System.Drawing.Point(435, 593)
        Me.btneditarcategoria.Name = "btneditarcategoria"
        Me.btneditarcategoria.Size = New System.Drawing.Size(209, 47)
        Me.btneditarcategoria.TabIndex = 11
        Me.btneditarcategoria.Text = "Editar categoría"
        Me.btneditarcategoria.UseVisualStyleBackColor = False
        '
        'btneliminarcategoria
        '
        Me.btneliminarcategoria.BackColor = System.Drawing.Color.Red
        Me.btneliminarcategoria.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminarcategoria.ForeColor = System.Drawing.Color.White
        Me.btneliminarcategoria.Location = New System.Drawing.Point(669, 593)
        Me.btneliminarcategoria.Name = "btneliminarcategoria"
        Me.btneliminarcategoria.Size = New System.Drawing.Size(209, 47)
        Me.btneliminarcategoria.TabIndex = 12
        Me.btneliminarcategoria.Text = "Eliminar categoría"
        Me.btneliminarcategoria.UseVisualStyleBackColor = False
        '
        'btncantexamenes
        '
        Me.btncantexamenes.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btncantexamenes.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncantexamenes.ForeColor = System.Drawing.Color.White
        Me.btncantexamenes.Location = New System.Drawing.Point(627, 220)
        Me.btncantexamenes.Name = "btncantexamenes"
        Me.btncantexamenes.Size = New System.Drawing.Size(251, 46)
        Me.btncantexamenes.TabIndex = 13
        Me.btncantexamenes.Text = "Cantidad de examenes"
        Me.btncantexamenes.UseVisualStyleBackColor = False
        '
        'btncategoriaexamen
        '
        Me.btncategoriaexamen.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btncategoriaexamen.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncategoriaexamen.ForeColor = System.Drawing.Color.White
        Me.btncategoriaexamen.Location = New System.Drawing.Point(338, 220)
        Me.btncategoriaexamen.Name = "btncategoriaexamen"
        Me.btncategoriaexamen.Size = New System.Drawing.Size(290, 46)
        Me.btncategoriaexamen.TabIndex = 14
        Me.btncategoriaexamen.Text = "Categoría del examen"
        Me.btncategoriaexamen.UseVisualStyleBackColor = False
        '
        'categoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1110, 689)
        Me.Controls.Add(Me.btncategoriaexamen)
        Me.Controls.Add(Me.btncantexamenes)
        Me.Controls.Add(Me.btneliminarcategoria)
        Me.Controls.Add(Me.btneditarcategoria)
        Me.Controls.Add(Me.btnnuevacategoria)
        Me.Controls.Add(Me.btncodigocategoria)
        Me.Controls.Add(Me.dgvcategoria)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "categoria"
        Me.Text = "categoria"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvcategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvcategoria As DataGridView
    Friend WithEvents btncodigocategoria As Button
    Friend WithEvents btnnuevacategoria As Button
    Friend WithEvents btneditarcategoria As Button
    Friend WithEvents btneliminarcategoria As Button
    Friend WithEvents btncantexamenes As Button
    Friend WithEvents btncategoriaexamen As Button
End Class
