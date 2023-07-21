<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_facturacion_examenes
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
        Me.dgv_facturacion_examenes = New System.Windows.Forms.DataGridView()
        Me.btn_seleccionar_frm_facturacion_examenes = New System.Windows.Forms.Button()
        CType(Me.dgv_facturacion_examenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_facturacion_examenes
        '
        Me.dgv_facturacion_examenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_facturacion_examenes.Location = New System.Drawing.Point(13, 13)
        Me.dgv_facturacion_examenes.Name = "dgv_facturacion_examenes"
        Me.dgv_facturacion_examenes.ReadOnly = True
        Me.dgv_facturacion_examenes.Size = New System.Drawing.Size(680, 270)
        Me.dgv_facturacion_examenes.TabIndex = 0
        '
        'btn_seleccionar_frm_facturacion_examenes
        '
        Me.btn_seleccionar_frm_facturacion_examenes.Location = New System.Drawing.Point(618, 289)
        Me.btn_seleccionar_frm_facturacion_examenes.Name = "btn_seleccionar_frm_facturacion_examenes"
        Me.btn_seleccionar_frm_facturacion_examenes.Size = New System.Drawing.Size(75, 23)
        Me.btn_seleccionar_frm_facturacion_examenes.TabIndex = 1
        Me.btn_seleccionar_frm_facturacion_examenes.Text = "Seleccionar"
        Me.btn_seleccionar_frm_facturacion_examenes.UseVisualStyleBackColor = True
        '
        'frm_facturacion_examenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 321)
        Me.Controls.Add(Me.btn_seleccionar_frm_facturacion_examenes)
        Me.Controls.Add(Me.dgv_facturacion_examenes)
        Me.Name = "frm_facturacion_examenes"
        Me.Text = "frm_facturacion_examenes"
        CType(Me.dgv_facturacion_examenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_facturacion_examenes As DataGridView
    Friend WithEvents btn_seleccionar_frm_facturacion_examenes As Button
End Class
