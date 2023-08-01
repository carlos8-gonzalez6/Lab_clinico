Imports System.Data.SqlClient

Public Class frm_facturacion
    Dim con As New Conexion
    Dim query As String
    Dim dv As New DataView
    Dim cond As Integer
    Dim dr As SqlDataReader

    Public Sub autonum()
        query = "select Id_Facturacion from Facturacion"
        If con.val(query) = True Then
            query = "select Max(Id_Facturacion) from Facturacion"
            dr = con.reader(query)
            While dr.Read
                txtID.Text = dr.GetValue(0) + 1
            End While
            dr.Close()
        Else
            txtID.Text = 1
        End If
    End Sub

    Public Sub cargar()
        query = "select f.Id_Facturacion 'Código', f.Fecha_Facturacion 'Fecha de Facturacion', (select CONCAT(Nombre_Paciente,' ',Apellido_Paciente) from Pacientes where Id_Paciente = f.Id_Paciente) 'Paciente', coalesce(CONCAT(e.Nombre_Empleado,' ',e.Apellido_Empleado) ,(select concat(Nombres,' ',Apellidos) from Medicos where Dni = u.Dni_Us)) 'Empleado', f.Sub_Total 'Sub Total', f.ISV 'ISV', f.descuento 'Descuento' from Facturacion f join Usuarios u on u.id_usuario = f.Id_Usuario join Empleados e on e.Dni_Empleado = u.Dni_Us"
        If con.val(query) = True Then
            Try
                Dim da As New SqlDataAdapter(query, con.cnn)
                Dim ds As New DataSet
                With dg_facturacion
                    ' opcional: Sin selección múltiple  
                    .MultiSelect = False
                    ' seleccioanr fila completa al hacer clic en un registro  
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                End With

                da.Fill(ds)
                dv.Table = ds.Tables(0)
                dg_facturacion.DataSource = dv
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("No hay registros", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        ' Crear una instancia del formulario secundario (frm_facturacion_examenes)
        Dim examenes As New frm_facturacion_examenes()
        ' Mostrar el formulario secundario como una ventana emergente
        If frm_facturacion_examenes.ShowDialog() = DialogResult.OK Then
            ' El código dentro de esta estructura se ejecuta solo si el formulario secundario es cerrado con DialogResult.OK
            ' Obtener los datos seleccionados en el formulario secundario
            Dim nombreExamen As String = frm_facturacion_examenes.dgv_facturacion_examenes.SelectedRows(0).Cells("Nombre del Examen").Value.ToString()
            Dim id_paciente As String = frm_facturacion_examenes.dgv_facturacion_examenes.SelectedRows(0).Cells("Id_Paciente").Value.ToString()
            Dim id_empleado As String = frm_facturacion_examenes.dgv_facturacion_examenes.SelectedRows(0).Cells("id_usuario").Value.ToString()
            Dim paciente As String = frm_facturacion_examenes.dgv_facturacion_examenes.SelectedRows(0).Cells("Paciente").Value.ToString()
            Dim precio As Decimal = Convert.ToDecimal(frm_facturacion_examenes.dgv_facturacion_examenes.SelectedRows(0).Cells("Precio").Value)

            ' Mostrar los datos en los TextBox correspondientes en frm_facturacion
            txt_examen.Text = nombreExamen.Trim()
            txt_id_paciente.Text = id_paciente.Trim()
            txt_id_empleado.Text = id_empleado.Trim()
            txt_paciente.Text = paciente.Trim()
            txt_precio.Text = precio.ToString().Trim()
        End If
    End Sub

    Private Sub btn_frm_facturacion1_Click(sender As Object, e As EventArgs) Handles btn_frm_facturacion1.Click
        ' Convertir el contenido de los TextBox a valores numéricos
        Dim precio As Decimal = Convert.ToDecimal(txt_precio.Text)
        Dim descuento As Decimal = Convert.ToDecimal(txt_descuento.Text)
        ' Calcular el Impuesto sobre Ventas (ISV) basado en el precio y el descuento
        Dim isv As Decimal = precio - descuento * Convert.ToDecimal(0.15)
        ' Variable para verificar si todos los campos son válidos
        Dim isValid As Boolean = True

        ' Verificar si el campo TextBox está vacío o no es una cadena
        If Not IsString(txt_examen.Text) Then
            ' Mostrar el error utilizando ErrorProvider
            EP.SetError(txt_examen, "El campo debe ser un valor de texto")
            isValid = False
        Else
            ' No hay error, limpiar el ErrorProvider y continuar con la lógica del programa
            EP.SetError(txt_examen, "") ' Limpiar el error
        End If

        ' Verificar si el campo TextBox está vacío o no es una cadena
        If Not IsValidPaciente(txt_paciente.Text) Then
            ' Mostrar el error utilizando ErrorProvider
            EP.SetError(txt_paciente, "El campo debe ser un valor de texto")
            isValid = False
        Else
            ' No hay error, limpiar el ErrorProvider y continuar con la lógica del programa
            EP.SetError(txt_paciente, "") ' Limpiar el error
        End If

        ' Verificar si el campo TextBox está vacío o no es un entero
        If Not IsInteger(txt_precio.Text) And Not IsDecimal(txt_precio.Text) Then
            ' Mostrar el error utilizando ErrorProvider
            EP.SetError(txt_precio, "El campo debe ser un valor entero")
            isValid = False
        Else
            ' No hay error, limpiar el ErrorProvider y continuar con la lógica del programa
            EP.SetError(txt_precio, "") ' Limpiar el error
        End If

        ' Verificar si el campo TextBox está vacío o no es un entero
        If Not IsInteger(txt_descuento.Text) And Not IsDecimal(txt_descuento.Text) Then
            ' Mostrar el error utilizando ErrorProvider
            EP.SetError(txt_descuento, "El campo debe ser un valor entero")
            isValid = False
        Else
            ' No hay error, limpiar el ErrorProvider y continuar con la lógica del programa
            EP.SetError(txt_descuento, "") ' Limpiar el error
        End If

        ' Si isValid es verdadero, significa que todos los campos son válidos.
        If isValid Then
            ' Continuar con la lógica del programa
            ' Crear la consulta SQL para insertar los datos de facturación en la base de datos
            query = "insert into Facturacion(Fecha_Facturacion, Id_Paciente, Id_Usuario, Sub_Total, ISV, descuento) values(GETDATE(), '" & txt_id_paciente.Text & "', '" & txt_id_empleado.Text & "', '" & txt_precio.Text & "', '" & isv & "', '" & txt_descuento.Text & "')"
            con.insertar(query)
            ' Mostrar un mensaje indicando que los datos fueron insertados exitosamente
            MessageBox.Show("Datos insertados exitosamente", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Limpiar los campos de entrada
            txt_examen.Clear()
            txt_paciente.Clear()
            txt_precio.Clear()
            txt_descuento.Clear()
            txt_id_paciente.Clear()
            txt_id_empleado.Clear()
            autonum()
            cargar()
        Else
            ' Mostrar un mensaje o realizar alguna acción si algún campo no es válido.
        End If
    End Sub

    ' Función para verificar si el valor es una cadena no vacía
    Private Function IsString(value As String) As Boolean
        Return Not String.IsNullOrEmpty(value)
    End Function


    ' Función para verificar si el valor es una cadena no vacía
    Private Function IsString2(value As String) As Boolean
        ' Verificar si todos los caracteres son letras
        For Each c As Char In value
            If Not Char.IsLetter(c) Then
                Return False
            End If
        Next
        Return True
    End Function

    ' Función para verificar si el valor es un número entero
    Private Function IsInteger(value As String) As Boolean
        Dim result As Integer
        Return Integer.TryParse(value, result)
    End Function

    ' Función para verificar si el valor es un número decimal
    Private Function IsDecimal(value As String) As Boolean
        Dim result As Decimal
        Return Decimal.TryParse(value, result)
    End Function

    ' Función para verificar si el campo Paciente tiene Nombre y Apellido separados por un espacio
    Private Function IsValidPaciente(value As String) As Boolean
        ' Verificar que el campo no esté vacío y contenga al menos un espacio
        Return Not String.IsNullOrEmpty(value) AndAlso value.Contains(" ")
    End Function

    ' Función principal
    Private Sub frm_facturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
        autonum()
    End Sub
End Class