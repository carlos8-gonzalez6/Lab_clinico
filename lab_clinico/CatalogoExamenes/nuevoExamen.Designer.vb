<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nuevoExamen
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
        Me.dgvnuevoexamen = New System.Windows.Forms.DataGridView()
        Me.lblnombreexamen = New System.Windows.Forms.Label()
        Me.txtnombreexamen = New System.Windows.Forms.TextBox()
        Me.lblprecioexamen = New System.Windows.Forms.Label()
        Me.txtprecioexamen = New System.Windows.Forms.TextBox()
        Me.lblcategoriaexamen = New System.Windows.Forms.Label()
        Me.cbcategoria = New System.Windows.Forms.ComboBox()
        Me.btnguardarexamen = New System.Windows.Forms.Button()
        Me.btncancelarexamen = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvnuevoexamen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(1, 1)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(799, 50)
        Me.Panel2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(314, 12)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nuevo examen"
        '
        'dgvnuevoexamen
        '
        Me.dgvnuevoexamen.BackgroundColor = System.Drawing.Color.White
        Me.dgvnuevoexamen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvnuevoexamen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvnuevoexamen.Location = New System.Drawing.Point(1, 55)
        Me.dgvnuevoexamen.Name = "dgvnuevoexamen"
        Me.dgvnuevoexamen.RowHeadersWidth = 51
        Me.dgvnuevoexamen.RowTemplate.Height = 24
        Me.dgvnuevoexamen.Size = New System.Drawing.Size(799, 402)
        Me.dgvnuevoexamen.TabIndex = 5
        '
        'lblnombreexamen
        '
        Me.lblnombreexamen.AutoSize = True
        Me.lblnombreexamen.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombreexamen.ForeColor = System.Drawing.Color.Black
        Me.lblnombreexamen.Location = New System.Drawing.Point(122, 124)
        Me.lblnombreexamen.Name = "lblnombreexamen"
        Me.lblnombreexamen.Size = New System.Drawing.Size(191, 21)
        Me.lblnombreexamen.TabIndex = 6
        Me.lblnombreexamen.Text = "Nombre del examen"
        '
        'txtnombreexamen
        '
        Me.txtnombreexamen.Location = New System.Drawing.Point(126, 157)
        Me.txtnombreexamen.Name = "txtnombreexamen"
        Me.txtnombreexamen.Size = New System.Drawing.Size(176, 22)
        Me.txtnombreexamen.TabIndex = 7
        '
        'lblprecioexamen
        '
        Me.lblprecioexamen.AutoSize = True
        Me.lblprecioexamen.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprecioexamen.ForeColor = System.Drawing.Color.Black
        Me.lblprecioexamen.Location = New System.Drawing.Point(122, 239)
        Me.lblprecioexamen.Name = "lblprecioexamen"
        Me.lblprecioexamen.Size = New System.Drawing.Size(175, 21)
        Me.lblprecioexamen.TabIndex = 8
        Me.lblprecioexamen.Text = "Precio del examen"
        '
        'txtprecioexamen
        '
        Me.txtprecioexamen.Location = New System.Drawing.Point(126, 272)
        Me.txtprecioexamen.Name = "txtprecioexamen"
        Me.txtprecioexamen.Size = New System.Drawing.Size(176, 22)
        Me.txtprecioexamen.TabIndex = 9
        '
        'lblcategoriaexamen
        '
        Me.lblcategoriaexamen.AutoSize = True
        Me.lblcategoriaexamen.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcategoriaexamen.ForeColor = System.Drawing.Color.Black
        Me.lblcategoriaexamen.Location = New System.Drawing.Point(452, 124)
        Me.lblcategoriaexamen.Name = "lblcategoriaexamen"
        Me.lblcategoriaexamen.Size = New System.Drawing.Size(100, 21)
        Me.lblcategoriaexamen.TabIndex = 10
        Me.lblcategoriaexamen.Text = "Categoría"
        '
        'cbcategoria
        '
        Me.cbcategoria.FormattingEnabled = True
        Me.cbcategoria.Location = New System.Drawing.Point(456, 155)
        Me.cbcategoria.Name = "cbcategoria"
        Me.cbcategoria.Size = New System.Drawing.Size(176, 24)
        Me.cbcategoria.TabIndex = 11
        '
        'btnguardarexamen
        '
        Me.btnguardarexamen.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnguardarexamen.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardarexamen.ForeColor = System.Drawing.Color.White
        Me.btnguardarexamen.Location = New System.Drawing.Point(164, 368)
        Me.btnguardarexamen.Name = "btnguardarexamen"
        Me.btnguardarexamen.Size = New System.Drawing.Size(209, 47)
        Me.btnguardarexamen.TabIndex = 12
        Me.btnguardarexamen.Text = "Guardar"
        Me.btnguardarexamen.UseVisualStyleBackColor = False
        '
        'btncancelarexamen
        '
        Me.btncancelarexamen.BackColor = System.Drawing.Color.Red
        Me.btncancelarexamen.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelarexamen.ForeColor = System.Drawing.Color.White
        Me.btncancelarexamen.Location = New System.Drawing.Point(409, 368)
        Me.btncancelarexamen.Name = "btncancelarexamen"
        Me.btncancelarexamen.Size = New System.Drawing.Size(209, 47)
        Me.btncancelarexamen.TabIndex = 13
        Me.btncancelarexamen.Text = "Cancelar"
        Me.btncancelarexamen.UseVisualStyleBackColor = False
        '
        'nuevoExamen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btncancelarexamen)
        Me.Controls.Add(Me.btnguardarexamen)
        Me.Controls.Add(Me.cbcategoria)
        Me.Controls.Add(Me.lblcategoriaexamen)
        Me.Controls.Add(Me.txtprecioexamen)
        Me.Controls.Add(Me.lblprecioexamen)
        Me.Controls.Add(Me.txtnombreexamen)
        Me.Controls.Add(Me.lblnombreexamen)
        Me.Controls.Add(Me.dgvnuevoexamen)
        Me.Controls.Add(Me.Panel2)
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Name = "nuevoExamen"
        Me.Text = "nuevoExamen"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvnuevoexamen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvnuevoexamen As DataGridView
    Friend WithEvents lblnombreexamen As Label
    Friend WithEvents txtnombreexamen As TextBox
    Friend WithEvents lblprecioexamen As Label
    Friend WithEvents txtprecioexamen As TextBox
    Friend WithEvents lblcategoriaexamen As Label
    Friend WithEvents cbcategoria As ComboBox
    Friend WithEvents btnguardarexamen As Button
    Friend WithEvents btncancelarexamen As Button
End Class
