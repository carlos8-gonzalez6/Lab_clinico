Imports System.Data.SqlClient
Imports System.Windows
Imports System.Windows.Forms.DataFormats

Public Class frm_pacientes
    Dim con As New Conexion
    Dim query As String
    Dim dv As New DataView
    Dim cond As Integer
    Dim dr As SqlDataReader

    Public Sub autonum()
        query = "select Id_Paciente from Pacientes"
        If con.val(query) = True Then
            query = "select Max(Id_Paciente) from Pacientes"
            dr = con.reader(query)
            While dr.Read
                TxtId.Text = dr.GetValue(0) + 1
            End While
            dr.Close()
        Else
            TxtId.Text = 1
        End If
    End Sub

    Public Sub cargar()
        query = "select Id_Paciente, Nombre_Paciente, Apellido_Paciente, Dni_Paciente, Genero, Fecha_Nacimiento, Direccion_Paciente, Telefono_Paciente from Pacientes;"
        If con.val(query) = True Then
            Try
                Dim da As New SqlDataAdapter(query, con.cnn)
                Dim ds As New DataSet
                With dg_pacientes
                    ' opcional: Sin selección múltiple  
                    .MultiSelect = False
                    ' seleccioanr fila completa al hacer clic en un registro  
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                End With

                da.Fill(ds)
                dv.Table = ds.Tables(0)
                dg_pacientes.DataSource = dv
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            MsgBox("No hay registros", MsgBoxStyle.Critical)
        End If
    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' Variable para verificar si todos los campos son válidos
        Dim isValid As Boolean = True

        If isValid Then
            ' Continuar con la lógica del programa
            ' Crear la consulta SQL para insertar los datos de pacientes en la base de datos
            query = "insert into Pacientes(Id_Paciente, Nombre_Paciente, Apellido_Paciente, Dni_Paciente, Fecha_Nacimiento, Direccion_Paciente, Telefono_Paciente, Estatus_Us, Genero) VALUES('" & txtid.Text & "','" & txtNombre.Text & "','" & txtApellido.Text & "','" & txtDni.Text & "','" & DtpFechaNac.Text & "' ,'" & txtDireccion.Text & "', '" & txtTelefono.Text & "', '" & cmbGenero.Text & "')"
            con.insertar(query)
            ' Mostrar un mensaje indicando que los datos fueron insertados exitosamente
            MessageBox.Show("Datos registrados exitosamente ", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Limpiar los campos de entrada
            txtNombre.Clear()
            txtApellido.Clear()
            txtDni.Clear()
            txtDireccion.Clear()
            txtTelefono.Clear()


            autonum()
            cargar()

        Else
            ' Mostrar un mensaje o realizar alguna acción si algún campo no es válido.
            MessageBox.Show("Datos Ingresados Incorrectamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If



        'Nombre del Paciente'

        ' Verificar si el campo TextBox está vacío o no es una cadena
        If Not IsString(txtNombre.Text) Then
            ' Mostrar el error utilizando ErrorProvider
            EP.SetError(txtNombre, "El campo debe ser un valor de texto")
            isValid = False
        Else
            ' No hay error, limpiar el ErrorProvider y continuar con la lógica del programa
            EP.SetError(txtNombre, "") ' Limpiar el error
        End If

        ' Verificar si el campo TextBox está vacío o no es una cadena
        If Not IsValidNombre(txtNombre.Text) Then
            ' Mostrar el error utilizando ErrorProvider
            EP.SetError(txtNombre, "El campo debe ser un valor de texto")
            isValid = False
        Else
            ' No hay error, limpiar el ErrorProvider y continuar con la lógica del programa
            EP.SetError(txtNombre, "") ' Limpiar el error
        End If

        'Apellido del Paciente' 

        ' Verificar si el campo TextBox está vacío o no es una cadena
        If Not IsString(txtApellido.Text) Then
            ' Mostrar el error utilizando ErrorProvider
            EP.SetError(txtApellido, "El campo debe ser un valor de texto")
            isValid = False
        Else
            ' No hay error, limpiar el ErrorProvider y continuar con la lógica del programa
            EP.SetError(txtApellido, "") ' Limpiar el error
        End If

        ' Verificar si el campo TextBox está vacío o no es una cadena
        If Not IsValidApellido(txtApellido.Text) Then
            ' Mostrar el error utilizando ErrorProvider
            EP.SetError(txtApellido, "El campo debe ser un valor de texto")
            isValid = False
        Else
            ' No hay error, limpiar el ErrorProvider y continuar con la lógica del programa
            EP.SetError(txtApellido, "") ' Limpiar el error
        End If


        'Dni del Paciente'

        ' Verificar si el campo TextBox está vacío o no es un entero
        If Not IsInteger(txtDni.Text) And Not IsDecimal(txtDni.Text) Then
            ' Mostrar el error utilizando ErrorProvider
            EP.SetError(txtDni, "El campo debe ser un valor entero")
            isValid = False
        Else
            ' No hay error, limpiar el ErrorProvider y continuar con la lógica del programa
            EP.SetError(txtDni, "") ' Limpiar el error
        End If

        'Genero del Paciente'

        ' Verificar si el campo ComboBox está vacío o no es una cadena
        If Not IsString(cmbGenero.Text) Then
            ' Mostrar el error utilizando ErrorProvider
            EP.SetError(cmbGenero, "El campo debe ser un valor de texto")
            isValid = False
        Else
            ' No hay error, limpiar el ErrorProvider y continuar con la lógica del programa
            EP.SetError(cmbGenero, "") ' Limpiar el error
        End If


        'Direccion del Paciente'

        ' Verificar si el campo TextBox está vacío o no es una cadena
        If Not IsString(txtDireccion.Text) Then
            ' Mostrar el error utilizando ErrorProvider
            EP.SetError(txtDireccion, "El campo debe ser un valor de texto")
            isValid = False
        Else
            ' No hay error, limpiar el ErrorProvider y continuar con la lógica del programa
            EP.SetError(txtDireccion, "") ' Limpiar el error
        End If

        ' Verificar si el campo TextBox está vacío o no es una cadena
        If Not IsValidDireccion(txtDireccion.Text) Then
            ' Mostrar el error utilizando ErrorProvider
            EP.SetError(txtDireccion, "El campo debe ser un valor de texto")
            isValid = False
        Else
            ' No hay error, limpiar el ErrorProvider y continuar con la lógica del programa
            EP.SetError(txtDireccion, "") ' Limpiar el error
        End If

        'Telefono del Paciente'

        ' Verificar si el campo TextBox está vacío o no es un entero
        If Not IsInteger(txtTelefono.Text) And Not IsDecimal(txtDni.Text) Then
            ' Mostrar el error utilizando ErrorProvider
            EP.SetError(txtTelefono, "El campo debe ser un valor entero")
            isValid = False
        Else
            ' No hay error, limpiar el ErrorProvider y continuar con la lógica del programa
            EP.SetError(txtTelefono, "") ' Limpiar el error
        End If

        'Id Pacinte'

        ' Verificar si el campo TextBox está vacío o no es un entero
        If Not IsInteger(txtid.Text) And Not IsDecimal(txtDni.Text) Then
            ' Mostrar el error utilizando ErrorProvider
            EP.SetError(txtid, "El campo debe ser un valor entero")
            isValid = False
        Else
            ' No hay error, limpiar el ErrorProvider y continuar con la lógica del programa
            EP.SetError(txtid, "") ' Limpiar el error
        End If


        ' Si isValid es verdadero, significa que todos los campos son válidos.
        If isValid Then
            ' Continuar con la lógica del programa
        Else
            ' Mostrar un mensaje o realizar alguna acción si algún campo no es válido.
        End If


    End Sub

    ' Función para verificar si el valor es una cadena no vacía
    Private Function IsString(value As String) As Boolean
        Return Not String.IsNullOrEmpty(value)
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

    ' Función para verificar si el campo Nombre tiene mas datos como el segundo nombre del paciente
    Private Function IsValidNombre(value As String) As Boolean
        ' Verificar que el campo no esté vacío y contenga al menos un espacio
        Return Not String.IsNullOrEmpty(value) AndAlso value.Contains(" ")
    End Function

    ' Función para verificar si el campo Apellido tiene mas datos como el segundo Apellido del paciente
    Private Function IsValidApellido(value As String) As Boolean
        ' Verificar que el campo no esté vacío y contenga al menos un espacio
        Return Not String.IsNullOrEmpty(value) AndAlso value.Contains(" ")
    End Function

    ' Función para verificar si el campo Direccion tiene mas datos especificos, como cuadras, avenidas y otros detalles
    Private Function IsValidDireccion(value As String) As Boolean
        ' Verificar que el campo no esté vacío y contenga al menos un espacio
        Return Not String.IsNullOrEmpty(value) AndAlso value.Contains(" ")
    End Function


    Private Sub frm_pacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargar()
        autonum()

        btnEditar.Visible = False

    End Sub

    Private Sub dg_pacientes_CellDobleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_pacientes.CellDoubleClick

        txtid.Text = dg_pacientes.CurrentRow.Cells(0).Value
        txtNombre.Text = dg_pacientes.CurrentRow.Cells(1).Value
        txtApellido.Text = dg_pacientes.CurrentRow.Cells(2).Value
        txtDni.Text = dg_pacientes.CurrentRow.Cells(3).Value
        cmbGenero.Text = dg_pacientes.CurrentRow.Cells(4).Value
        DtpFechaNac.Text = dg_pacientes.CurrentRow.Cells(5).Value
        txtDireccion.Text = dg_pacientes.CurrentRow.Cells(6).Value
        txtTelefono.Text = dg_pacientes.CurrentRow.Cells(7).Value

        btnEditar.Visible = True

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        query = "UPDATE Pacientes SET Nombre_Paciente='" & txtNombre.Text & "', Apellido_Paciente='" & txtApellido.Text & "', Dni_Paciente='" & txtDni.Text & "', Fecha_Nacimiento='" & DtpFechaNac.Text & "', Direccion_Paciente='" & txtDireccion.Text & "', Telefono_Paciente='" & txtTelefono.Text & "', Genero='" & cmbGenero.Text & "' WHERE Id_Paciente='" & txtid.Text & "'"
        con.insertar(query)
        MessageBox.Show("Datos actualizados exitosamente", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtNombre.Clear()
        txtApellido.Clear()
        txtDni.Clear()
        txtDireccion.Clear()
        txtTelefono.Clear()

        btnEditar.Visible = False
        cargar()
        autonum()


    End Sub
End Class