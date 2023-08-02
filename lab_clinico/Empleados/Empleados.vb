Imports System.Data.SqlClient

Public Class Empleados
    Dim con As New Conexion
    Dim query As String
    Dim dv As New DataView
    Dim dr As SqlDataReader


    ''Funcion automun: sirve para asignar de forma automatica el id correspindiente a cada empleado, este valor se muestra en el txtid
    Public Sub autonum()
        ' Preparar la consulta SQL para seleccionar todos los ID de los empleados
        query = "select Id_Empleado from Empleados"
        ' Si la consulta SQL retorna algún valor
        If con.val(query) = True Then
            ' Preparar la consulta SQL para obtener el ID máximo entre los ID de los empleados
            query = "select Max(Id_Empleado) from Empleados"
            ' Ejecutar la consulta SQL
            dr = con.reader(query)
            ' Leer el valor retornado y asignar el próximo número al nuevo empleado
            While dr.Read
                txtid.Text = dr.GetValue(0) + 1
            End While
            ' Cerrar el DataReader
            dr.Close()
        Else ' Si no hay empleados existentes
            ' Asignar 1 como el primer ID
            txtid.Text = 1
        End If
    End Sub


    ' Método cargar para cargar los detalles de los empleados desde la base de datos
    Public Sub cargar()
        ' Preparar la consulta SQL para seleccionar varios campos de todos los empleados
        query = "SELECT Id_Empleado, Nombre_Empleado, Apellido_Empleado, Dni_Empleado, Genero, Fecha_Nacimiento, Direccion_Empleado, Telefono_Empleado FROM Empleados;"
        If con.val(query) = True Then
            Try ' Intentar ejecutar el siguiente bloque de código
                ' Crear un SqlDataAdapter y un DataSet
                Dim da As New SqlDataAdapter(query, con.cnn)
                Dim ds As New DataSet
                With dgv_empleados
                    ' opcional: Sin selección múltiple  
                    .MultiSelect = False
                    ' seleccionar la fila completa al hacer clic en un registro  
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                End With

                ' Llenar el DataSet con los resultados de la consulta SQL
                da.Fill(ds)
                ' Asignar la primera tabla del DataSet a la DataView
                dv.Table = ds.Tables(0)
                ' Establecer la DataView como la fuente de datos para dgv_empleados
                dgv_empleados.DataSource = dv
            Catch ex As Exception ' Si hay un error al ejecutar el bloque de código anterior
                ' Mostrar un mensaje con la descripción del error
                MsgBox(ex.Message)
            End Try

        Else
            MsgBox("No hay registros", MsgBoxStyle.Critical)
        End If
    End Sub


    ' Este subrutina se ejecuta cuando se hace clic en el botón btnempleadonuevo
    Private Sub btnempleadonuevo_Click(sender As Object, e As EventArgs) Handles btnempleadonuevo.Click
        ' Preparar la consulta SQL para insertar un nuevo registro en la tabla de Empleados, usando los datos ingresados en los campos de texto y el combobox
        query = "Insert into Empleados(Id_Empleado, Nombre_Empleado, Apellido_Empleado, Dni_Empleado, Fecha_Nacimiento, Direccion_Empleado, Telefono_Empleado, Estatus_Us, Genero) VALUES('" & txtid.Text & "','" & txtempleadonombre.Text & "','" & txtempleadoapellido.Text & "','" & txtdni.Text & "','" & DateTimePicker1.Text & "' ,'" & txtdireccionempleado.Text & "', '" & txtempleadotelef.Text & "', 1,  '" & cmbgenero.Text & "')"

        ' Ejecutar la consulta SQL para insertar los datos
        con.insertar(query)

        ' Mostrar un mensaje indicando que los datos se insertaron correctamente
        MessageBox.Show("Datos insertados exitosamente", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Limpiar los campos de texto y el combobox para una nueva entrada
        txtempleadonombre.Clear()
        txtempleadoapellido.Clear()
        txtdni.Clear()
        cmbgenero.SelectedIndex = 0  ' Seleccionar el primer elemento del combobox
        txtdireccionempleado.Clear()
        txtempleadotelef.Clear()

        ' Llamar a la subrutina autonum para preparar el próximo ID de empleado
        autonum()

        ' Llamar a la subrutina cargar para cargar los datos de los empleados desde la base de datos
        cargar()
    End Sub


    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
        autonum()
        btnempleadoeditar.Visible = False
    End Sub

    ' Este evento se dispara cuando se hace doble clic en una celda del DataGridView llamado dgv_empleados
    Private Sub dgv_empleados_CellDobleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_empleados.CellDoubleClick
        ' Rellena el campo de texto txtid con el valor de la primera celda (Id_Empleado) de la fila seleccionada
        txtid.Text = dgv_empleados.CurrentRow.Cells(0).Value

        ' Rellena el campo de texto txtempleadonombre con el valor de la segunda celda (Nombre_Empleado) de la fila seleccionada
        txtempleadonombre.Text = dgv_empleados.CurrentRow.Cells(1).Value

        ' Rellena el campo de texto txtempleadoapellido con el valor de la tercera celda (Apellido_Empleado) de la fila seleccionada
        txtempleadoapellido.Text = dgv_empleados.CurrentRow.Cells(2).Value

        ' Rellena el campo de texto txtdni con el valor de la cuarta celda (Dni_Empleado) de la fila seleccionada
        txtdni.Text = dgv_empleados.CurrentRow.Cells(3).Value

        ' Rellena el combo box cmbgenero con el valor de la quinta celda (Genero) de la fila seleccionada
        cmbgenero.Text = dgv_empleados.CurrentRow.Cells(4).Value

        ' Rellena el DateTimePicker DateTimePicker1 con el valor de la sexta celda (Fecha_Nacimiento) de la fila seleccionada
        DateTimePicker1.Text = dgv_empleados.CurrentRow.Cells(5).Value

        ' Rellena el campo de texto txtdireccionempleado con el valor de la séptima celda (Direccion_Empleado) de la fila seleccionada
        txtdireccionempleado.Text = dgv_empleados.CurrentRow.Cells(6).Value

        ' Rellena el campo de texto txtempleadotelef con el valor de la octava celda (Telefono_Empleado) de la fila seleccionada
        txtempleadotelef.Text = dgv_empleados.CurrentRow.Cells(7).Value

        ' Hace visible el botón btnempleadoeditar
        btnempleadoeditar.Visible = True
    End Sub


    ' Este evento se dispara cuando se hace clic en el botón btnempleadoeditar
    Private Sub btnempleadoeditar_Click(sender As Object, e As EventArgs) Handles btnempleadoeditar.Click
        ' Prepara la consulta SQL para actualizar los datos del empleado en la base de datos, usando los datos ingresados en los campos de texto y el combobox
        query = "UPDATE Empleados SET Nombre_Empleado='" & txtempleadonombre.Text & "', Apellido_Empleado='" & txtempleadoapellido.Text & "', Dni_Empleado='" & txtdni.Text & "', Fecha_Nacimiento='" & DateTimePicker1.Text & "', Direccion_Empleado='" & txtdireccionempleado.Text & "', Telefono_Empleado='" & txtempleadotelef.Text & "', Genero='" & cmbgenero.Text & "' WHERE Id_Empleado='" & txtid.Text & "'"

        ' Ejecutar la consulta SQL para actualizar los datos del empleado
        con.insertar(query)

        ' Mostrar un mensaje que indica que los datos se han actualizado correctamente
        MessageBox.Show("Datos actualizados exitosamente", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Limpiar los campos de texto para una nueva entrada
        txtempleadonombre.Clear()
        txtempleadoapellido.Clear()
        txtdni.Clear()
        txtdireccionempleado.Clear()
        txtempleadotelef.Clear()

        ' Ocultar el botón btnempleadoeditar
        btnempleadoeditar.Visible = False

        ' Recargar los datos de los empleados desde la base de datos
        cargar()

        ' Preparar el próximo ID de empleado para una nueva entrada
        autonum()
    End Sub
End Class
