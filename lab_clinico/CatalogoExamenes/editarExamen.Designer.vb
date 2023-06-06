<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class editarExamen
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgveditarexamen = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblcategoria = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.cbcategoria = New System.Windows.Forms.ComboBox()
        Me.btnguardarexamen = New System.Windows.Forms.Button()
        Me.btncancelarexamen = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.dgveditarexamen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(1, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(799, 50)
        Me.Panel2.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(319, 12)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Editar examen"
        '
        'dgveditarexamen
        '
        Me.dgveditarexamen.BackgroundColor = System.Drawing.Color.White
        Me.dgveditarexamen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgveditarexamen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgveditarexamen.Location = New System.Drawing.Point(2, 53)
        Me.dgveditarexamen.Name = "dgveditarexamen"
        Me.dgveditarexamen.RowHeadersWidth = 51
        Me.dgveditarexamen.RowTemplate.Height = 24
        Me.dgveditarexamen.Size = New System.Drawing.Size(796, 390)
        Me.dgveditarexamen.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(143, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 21)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Precio del examen"
        '
        'lblcategoria
        '
        Me.lblcategoria.AutoSize = True
        Me.lblcategoria.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcategoria.ForeColor = System.Drawing.Color.Black
        Me.lblcategoria.Location = New System.Drawing.Point(462, 124)
        Me.lblcategoria.Name = "lblcategoria"
        Me.lblcategoria.Size = New System.Drawing.Size(100, 21)
        Me.lblcategoria.TabIndex = 9
        Me.lblcategoria.Text = "Categoría"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(143, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 21)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Nombre del examen"
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(147, 256)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(176, 22)
        Me.txtprecio.TabIndex = 11
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(147, 148)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(176, 22)
        Me.txtnombre.TabIndex = 12
        '
        'cbcategoria
        '
        Me.cbcategoria.FormattingEnabled = True
        Me.cbcategoria.Location = New System.Drawing.Point(466, 148)
        Me.cbcategoria.Name = "cbcategoria"
        Me.cbcategoria.Size = New System.Drawing.Size(176, 24)
        Me.cbcategoria.TabIndex = 13
        '
        'btnguardarexamen
        '
        Me.btnguardarexamen.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnguardarexamen.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardarexamen.ForeColor = System.Drawing.Color.White
        Me.btnguardarexamen.Location = New System.Drawing.Point(167, 368)
        Me.btnguardarexamen.Name = "btnguardarexamen"
        Me.btnguardarexamen.Size = New System.Drawing.Size(209, 47)
        Me.btnguardarexamen.TabIndex = 14
        Me.btnguardarexamen.Text = "Guardar"
        Me.btnguardarexamen.UseVisualStyleBackColor = False
        '
        'btncancelarexamen
        '
        Me.btncancelarexamen.BackColor = System.Drawing.Color.Red
        Me.btncancelarexamen.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelarexamen.ForeColor = System.Drawing.Color.White
        Me.btncancelarexamen.Location = New System.Drawing.Point(417, 368)
        Me.btncancelarexamen.Name = "btncancelarexamen"
        Me.btncancelarexamen.Size = New System.Drawing.Size(209, 47)
        Me.btncancelarexamen.TabIndex = 15
        Me.btncancelarexamen.Text = "Cancelar"
        Me.btncancelarexamen.UseVisualStyleBackColor = False
        '
        'editarExamen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btncancelarexamen)
        Me.Controls.Add(Me.btnguardarexamen)
        Me.Controls.Add(Me.cbcategoria)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblcategoria)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgveditarexamen)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "editarExamen"
        Me.Text = "editarExamen"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgveditarexamen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dgveditarexamen As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lblcategoria As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents cbcategoria As ComboBox
    Friend WithEvents btnguardarexamen As Button
    Friend WithEvents btncancelarexamen As Button
End Class
