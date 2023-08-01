Imports System.Data.SqlClient

Public Class frm_facturacion_examenes
    Dim con As New Conexion
    Dim query As String
    Dim dv As New DataView
    Dim cond As Integer
    Dim dr As SqlDataReader

    Public Sub cargar()
        query = "select em.Id_Examen_Med 'Codigo' ,e.Nombre_Exm 'Nombre del Examen', p.Id_Paciente ,CONCAT(p.Nombre_Paciente,' ',p.Apellido_Paciente) 'Paciente', u.id_usuario , coalesce(CONCAT(emp.Nombre_Empleado,' ',emp.Apellido_Empleado) ,(select concat(Nombres,' ',Apellidos) from Medicos where Dni = u.Dni_Us)) 'Empleado' , em.Fecha_Registro 'Fecha', em.Estatus_Examen 'Estado', a.Nombre_Analisis 'Tipo de Área', e.Costo_Examen 'Precio' from Examenes_Medicos em join Pacientes p on p.Id_Paciente = em.Id_Paciente join Examenes_Medicos_Detalles emd on emd.Id_Examen_Med = em.Id_Examen_Med join Analisis a on a.Id_Analisis = emd.Id_Analisis join Examenes e on e.Id_Examen = emd.Id_Examen join Usuarios u on u.id_usuario = em.Id_Usuario  join Empleados emp on emp.Dni_Empleado = u.Dni_Us"
        If con.val(query) = True Then
            Try
                Dim da As New SqlDataAdapter(query, con.cnn)
                Dim ds As New DataSet
                With dgv_facturacion_examenes
                    ' opcional: Sin selección múltiple  
                    .MultiSelect = False
                    ' seleccioanr fila completa al hacer clic en un registro  
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                End With

                da.Fill(ds)
                dv.Table = ds.Tables(0)
                dgv_facturacion_examenes.DataSource = dv
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("No hay registros", MsgBoxStyle.Critical)
        End If
    End Sub

    ' Evento que se activa al hacer clic en el botón "btn_seleccionar_frm_facturacion_examenes"
    Private Sub btn_seleccionar_frm_facturacion_examenes_Click(sender As Object, e As EventArgs) Handles btn_seleccionar_frm_facturacion_examenes.Click
        ' Comprobamos si se ha seleccionado al menos una fila en el control DataGridView llamado dgv_facturacion_examenes
        If dgv_facturacion_examenes.SelectedRows.Count > 0 Then
            ' Si se seleccionó un registro, cerrar el formulario secundario y devolver DialogResult.OK
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            ' Si no se seleccionó ninguna fila, mostramos un mensaje de advertencia al usuario
            MessageBox.Show("Por favor, seleccione un examen.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub frm_facturacion_examenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
    End Sub
End Class