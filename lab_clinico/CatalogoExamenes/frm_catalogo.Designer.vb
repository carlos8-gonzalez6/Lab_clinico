<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class catalogo
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvexamenes = New System.Windows.Forms.DataGridView()
        Me.btnnuevoexamen = New System.Windows.Forms.Button()
        Me.btneditarexamen = New System.Windows.Forms.Button()
        Me.btneliminarexamen = New System.Windows.Forms.Button()
        Me.btncodigoexamen = New System.Windows.Forms.Button()
        Me.btnnombreexamen = New System.Windows.Forms.Button()
        Me.btnareaexamen = New System.Windows.Forms.Button()
        Me.btnprecioexamen = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvexamenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(833, 41)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(308, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Catálogo de exámenes"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(0, 102)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(421, 41)
        Me.Panel2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(172, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Exámenes"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(420, 102)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(413, 41)
        Me.Panel3.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(154, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Categoría"
        '
        'dgvexamenes
        '
        Me.dgvexamenes.BackgroundColor = System.Drawing.Color.White
        Me.dgvexamenes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvexamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvexamenes.Location = New System.Drawing.Point(1, 143)
        Me.dgvexamenes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvexamenes.Name = "dgvexamenes"
        Me.dgvexamenes.RowHeadersWidth = 51
        Me.dgvexamenes.RowTemplate.Height = 24
        Me.dgvexamenes.Size = New System.Drawing.Size(833, 421)
        Me.dgvexamenes.TabIndex = 4
        '
        'btnnuevoexamen
        '
        Me.btnnuevoexamen.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnnuevoexamen.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevoexamen.ForeColor = System.Drawing.Color.White
        Me.btnnuevoexamen.Location = New System.Drawing.Point(160, 481)
        Me.btnnuevoexamen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnnuevoexamen.Name = "btnnuevoexamen"
        Me.btnnuevoexamen.Size = New System.Drawing.Size(157, 38)
        Me.btnnuevoexamen.TabIndex = 5
        Me.btnnuevoexamen.Text = "Nuevo examen"
        Me.btnnuevoexamen.UseVisualStyleBackColor = False
        '
        'btneditarexamen
        '
        Me.btneditarexamen.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btneditarexamen.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditarexamen.ForeColor = System.Drawing.Color.White
        Me.btneditarexamen.Location = New System.Drawing.Point(332, 481)
        Me.btneditarexamen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btneditarexamen.Name = "btneditarexamen"
        Me.btneditarexamen.Size = New System.Drawing.Size(157, 38)
        Me.btneditarexamen.TabIndex = 6
        Me.btneditarexamen.Text = "Editar examen"
        Me.btneditarexamen.UseVisualStyleBackColor = False
        '
        'btneliminarexamen
        '
        Me.btneliminarexamen.BackColor = System.Drawing.Color.Red
        Me.btneliminarexamen.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminarexamen.ForeColor = System.Drawing.Color.White
        Me.btneliminarexamen.Location = New System.Drawing.Point(500, 481)
        Me.btneliminarexamen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btneliminarexamen.Name = "btneliminarexamen"
        Me.btneliminarexamen.Size = New System.Drawing.Size(157, 38)
        Me.btneliminarexamen.TabIndex = 7
        Me.btneliminarexamen.Text = "Eliminar examen"
        Me.btneliminarexamen.UseVisualStyleBackColor = False
        '
        'btncodigoexamen
        '
        Me.btncodigoexamen.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btncodigoexamen.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncodigoexamen.ForeColor = System.Drawing.Color.White
        Me.btncodigoexamen.Location = New System.Drawing.Point(160, 172)
        Me.btncodigoexamen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btncodigoexamen.Name = "btncodigoexamen"
        Me.btncodigoexamen.Size = New System.Drawing.Size(106, 37)
        Me.btncodigoexamen.TabIndex = 8
        Me.btncodigoexamen.Text = "Código"
        Me.btncodigoexamen.UseVisualStyleBackColor = False
        '
        'btnnombreexamen
        '
        Me.btnnombreexamen.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnnombreexamen.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnombreexamen.ForeColor = System.Drawing.Color.White
        Me.btnnombreexamen.Location = New System.Drawing.Point(264, 172)
        Me.btnnombreexamen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnnombreexamen.Name = "btnnombreexamen"
        Me.btnnombreexamen.Size = New System.Drawing.Size(172, 37)
        Me.btnnombreexamen.TabIndex = 9
        Me.btnnombreexamen.Text = "Nombre del examen"
        Me.btnnombreexamen.UseVisualStyleBackColor = False
        '
        'btnareaexamen
        '
        Me.btnareaexamen.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnareaexamen.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnareaexamen.ForeColor = System.Drawing.Color.White
        Me.btnareaexamen.Location = New System.Drawing.Point(434, 172)
        Me.btnareaexamen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnareaexamen.Name = "btnareaexamen"
        Me.btnareaexamen.Size = New System.Drawing.Size(119, 37)
        Me.btnareaexamen.TabIndex = 10
        Me.btnareaexamen.Text = "Área"
        Me.btnareaexamen.UseVisualStyleBackColor = False
        '
        'btnprecioexamen
        '
        Me.btnprecioexamen.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnprecioexamen.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprecioexamen.ForeColor = System.Drawing.Color.White
        Me.btnprecioexamen.Location = New System.Drawing.Point(553, 172)
        Me.btnprecioexamen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnprecioexamen.Name = "btnprecioexamen"
        Me.btnprecioexamen.Size = New System.Drawing.Size(104, 37)
        Me.btnprecioexamen.TabIndex = 11
        Me.btnprecioexamen.Text = "Precio"
        Me.btnprecioexamen.UseVisualStyleBackColor = False
        '
        'catalogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(834, 571)
        Me.Controls.Add(Me.btnprecioexamen)
        Me.Controls.Add(Me.btnareaexamen)
        Me.Controls.Add(Me.btnnombreexamen)
        Me.Controls.Add(Me.btncodigoexamen)
        Me.Controls.Add(Me.btneliminarexamen)
        Me.Controls.Add(Me.btneditarexamen)
        Me.Controls.Add(Me.btnnuevoexamen)
        Me.Controls.Add(Me.dgvexamenes)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "catalogo"
        Me.Text = "catalogo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvexamenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvexamenes As DataGridView
    Friend WithEvents btnnuevoexamen As Button
    Friend WithEvents btneditarexamen As Button
    Friend WithEvents btneliminarexamen As Button
    Friend WithEvents btncodigoexamen As Button
    Friend WithEvents btnnombreexamen As Button
    Friend WithEvents btnareaexamen As Button
    Friend WithEvents btnprecioexamen As Button
End Class
