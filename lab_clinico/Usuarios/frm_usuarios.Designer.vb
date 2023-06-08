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
        Me.DataGrid_Usuarios = New System.Windows.Forms.DataGridView()
        Me.btn_agregar_usuarios = New System.Windows.Forms.Button()
        Me.btn_editar_usuarios = New System.Windows.Forms.Button()
        Me.txt_buscar_usuario = New System.Windows.Forms.TextBox()
        Me.btn_usuarios = New System.Windows.Forms.Button()
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGrid_Usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGrid_Usuarios
        '
        Me.DataGrid_Usuarios.BackgroundColor = System.Drawing.Color.White
        Me.DataGrid_Usuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGrid_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_Usuarios.Location = New System.Drawing.Point(12, 86)
        Me.DataGrid_Usuarios.Name = "DataGrid_Usuarios"
        Me.DataGrid_Usuarios.Size = New System.Drawing.Size(765, 290)
        Me.DataGrid_Usuarios.TabIndex = 0
        '
        'btn_agregar_usuarios
        '
        Me.btn_agregar_usuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btn_agregar_usuarios.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btn_agregar_usuarios.ForeColor = System.Drawing.Color.White
        Me.btn_agregar_usuarios.Location = New System.Drawing.Point(3, 390)
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
        Me.btn_editar_usuarios.Location = New System.Drawing.Point(238, 390)
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
        Me.txt_buscar_usuario.Location = New System.Drawing.Point(17, 42)
        Me.txt_buscar_usuario.Name = "txt_buscar_usuario"
        Me.txt_buscar_usuario.Size = New System.Drawing.Size(287, 27)
        Me.txt_buscar_usuario.TabIndex = 43
        Me.txt_buscar_usuario.Text = "Buscar Usuario"
        '
        'btn_usuarios
        '
        Me.btn_usuarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_usuarios.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_usuarios.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_usuarios.Location = New System.Drawing.Point(310, 42)
        Me.btn_usuarios.Name = "btn_usuarios"
        Me.btn_usuarios.Size = New System.Drawing.Size(30, 27)
        Me.btn_usuarios.TabIndex = 44
        Me.btn_usuarios.UseVisualStyleBackColor = False
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.pnlTitulo.Controls.Add(Me.btn_cerrar)
        Me.pnlTitulo.Controls.Add(Me.Label5)
        Me.pnlTitulo.Location = New System.Drawing.Point(-1, 0)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(867, 36)
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
        'frm_usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(863, 459)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Controls.Add(Me.btn_usuarios)
        Me.Controls.Add(Me.txt_buscar_usuario)
        Me.Controls.Add(Me.btn_editar_usuarios)
        Me.Controls.Add(Me.btn_agregar_usuarios)
        Me.Controls.Add(Me.DataGrid_Usuarios)
        Me.Name = "frm_usuarios"
        Me.Text = "Usuarios"
        CType(Me.DataGrid_Usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGrid_Usuarios As DataGridView
    Friend WithEvents btn_agregar_usuarios As Button
    Friend WithEvents btn_editar_usuarios As Button
    Friend WithEvents txt_buscar_usuario As TextBox
    Friend WithEvents btn_usuarios As Button
    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents btn_cerrar As Button
    Private WithEvents Label5 As Label
End Class
