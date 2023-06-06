<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarCategoria
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
        Me.dgveditarcategoria = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblnombrecategoria = New System.Windows.Forms.Label()
        Me.txtnombrecategoria = New System.Windows.Forms.TextBox()
        Me.btnguardcategoria = New System.Windows.Forms.Button()
        Me.btncancelarcategoria = New System.Windows.Forms.Button()
        CType(Me.dgveditarcategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgveditarcategoria
        '
        Me.dgveditarcategoria.BackgroundColor = System.Drawing.Color.White
        Me.dgveditarcategoria.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgveditarcategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgveditarcategoria.Location = New System.Drawing.Point(1, 49)
        Me.dgveditarcategoria.Name = "dgveditarcategoria"
        Me.dgveditarcategoria.RowHeadersWidth = 51
        Me.dgveditarcategoria.RowTemplate.Height = 24
        Me.dgveditarcategoria.Size = New System.Drawing.Size(796, 400)
        Me.dgveditarcategoria.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(1, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(799, 50)
        Me.Panel2.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(307, 12)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Editar categoría"
        '
        'lblnombrecategoria
        '
        Me.lblnombrecategoria.AutoSize = True
        Me.lblnombrecategoria.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombrecategoria.ForeColor = System.Drawing.Color.Black
        Me.lblnombrecategoria.Location = New System.Drawing.Point(175, 140)
        Me.lblnombrecategoria.Name = "lblnombrecategoria"
        Me.lblnombrecategoria.Size = New System.Drawing.Size(222, 21)
        Me.lblnombrecategoria.TabIndex = 18
        Me.lblnombrecategoria.Text = "Nombre de la categoría"
        '
        'txtnombrecategoria
        '
        Me.txtnombrecategoria.Location = New System.Drawing.Point(179, 164)
        Me.txtnombrecategoria.Name = "txtnombrecategoria"
        Me.txtnombrecategoria.Size = New System.Drawing.Size(451, 22)
        Me.txtnombrecategoria.TabIndex = 19
        '
        'btnguardcategoria
        '
        Me.btnguardcategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnguardcategoria.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardcategoria.ForeColor = System.Drawing.Color.White
        Me.btnguardcategoria.Location = New System.Drawing.Point(179, 311)
        Me.btnguardcategoria.Name = "btnguardcategoria"
        Me.btnguardcategoria.Size = New System.Drawing.Size(209, 47)
        Me.btnguardcategoria.TabIndex = 20
        Me.btnguardcategoria.Text = "Guardar"
        Me.btnguardcategoria.UseVisualStyleBackColor = False
        '
        'btncancelarcategoria
        '
        Me.btncancelarcategoria.BackColor = System.Drawing.Color.Red
        Me.btncancelarcategoria.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelarcategoria.ForeColor = System.Drawing.Color.White
        Me.btncancelarcategoria.Location = New System.Drawing.Point(421, 311)
        Me.btncancelarcategoria.Name = "btncancelarcategoria"
        Me.btncancelarcategoria.Size = New System.Drawing.Size(209, 47)
        Me.btncancelarcategoria.TabIndex = 21
        Me.btncancelarcategoria.Text = "Cancelar"
        Me.btncancelarcategoria.UseVisualStyleBackColor = False
        '
        'EditarCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btncancelarcategoria)
        Me.Controls.Add(Me.btnguardcategoria)
        Me.Controls.Add(Me.txtnombrecategoria)
        Me.Controls.Add(Me.lblnombrecategoria)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgveditarcategoria)
        Me.Name = "EditarCategoria"
        Me.Text = "EditarCategoria"
        CType(Me.dgveditarcategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgveditarcategoria As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblnombrecategoria As Label
    Friend WithEvents txtnombrecategoria As TextBox
    Friend WithEvents btnguardcategoria As Button
    Friend WithEvents btncancelarcategoria As Button
End Class
