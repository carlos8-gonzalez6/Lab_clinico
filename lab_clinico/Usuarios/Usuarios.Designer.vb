<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Me.DataGrid_Usuarios = New System.Windows.Forms.DataGridView()
        Me.Txt_buscar_usuarios = New System.Windows.Forms.TextBox()
        Me.btn_agregar_usuarios = New System.Windows.Forms.Button()
        Me.btn_editar_usuarios = New System.Windows.Forms.Button()
        CType(Me.DataGrid_Usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid_Usuarios
        '
        Me.DataGrid_Usuarios.BackgroundColor = System.Drawing.Color.White
        Me.DataGrid_Usuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGrid_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_Usuarios.Location = New System.Drawing.Point(12, 45)
        Me.DataGrid_Usuarios.Name = "DataGrid_Usuarios"
        Me.DataGrid_Usuarios.Size = New System.Drawing.Size(765, 290)
        Me.DataGrid_Usuarios.TabIndex = 0
        '
        'Txt_buscar_usuarios
        '
        Me.Txt_buscar_usuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_buscar_usuarios.Location = New System.Drawing.Point(13, 13)
        Me.Txt_buscar_usuarios.Name = "Txt_buscar_usuarios"
        Me.Txt_buscar_usuarios.Size = New System.Drawing.Size(504, 20)
        Me.Txt_buscar_usuarios.TabIndex = 1
        '
        'btn_agregar_usuarios
        '
        Me.btn_agregar_usuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btn_agregar_usuarios.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btn_agregar_usuarios.ForeColor = System.Drawing.Color.White
        Me.btn_agregar_usuarios.Location = New System.Drawing.Point(13, 355)
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
        Me.btn_editar_usuarios.Location = New System.Drawing.Point(248, 355)
        Me.btn_editar_usuarios.Name = "btn_editar_usuarios"
        Me.btn_editar_usuarios.Size = New System.Drawing.Size(211, 46)
        Me.btn_editar_usuarios.TabIndex = 3
        Me.btn_editar_usuarios.Text = "EDITAR"
        Me.btn_editar_usuarios.UseVisualStyleBackColor = False
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(811, 413)
        Me.Controls.Add(Me.btn_editar_usuarios)
        Me.Controls.Add(Me.btn_agregar_usuarios)
        Me.Controls.Add(Me.Txt_buscar_usuarios)
        Me.Controls.Add(Me.DataGrid_Usuarios)
        Me.Name = "Usuarios"
        Me.Text = "Usuarios"
        CType(Me.DataGrid_Usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGrid_Usuarios As DataGridView
    Friend WithEvents Txt_buscar_usuarios As TextBox
    Friend WithEvents btn_agregar_usuarios As Button
    Friend WithEvents btn_editar_usuarios As Button
End Class
