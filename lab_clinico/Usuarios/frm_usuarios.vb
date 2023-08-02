Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class frm_usuarios
    Dim con As New Conexion
    Dim query As String
    Dim dv As New DataView
    Dim cond As Integer

    Public Sub cargar()
        query = "SELECT id_usuario, Nombre_Us, Dni_Us, Contrasenia_Us, Correo_Us FROM Usuarios;"
        If con.val(query) = True Then
            Try
                Dim da As New SqlDataAdapter(query, con.cnn)
                Dim ds As New DataSet
                With dg_usuarios
                    ' opcional: Sin selección múltiple  
                    .MultiSelect = False
                    ' seleccioanr fila completa al hacer clic en un registro  
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                End With

                da.Fill(ds)
                dv.Table = ds.Tables(0)
                dg_usuarios.DataSource = dv
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            MsgBox("No hay registros", MsgBoxStyle.Critical)
        End If
    End Sub


    Private Sub btn_agregar_usuarios_Click(sender As Object, e As EventArgs) Handles btn_agregar_usuarios.Click
        ' Variable para verificar si todos los campos son válidos
        Dim isValid As Boolean = True
        ' Verificar si el campo TextBox está vacío o no es una cadena
        If Not IsString2(txt_nombre_usuario.Text) Then
            ' Mostrar el error utilizando ErrorProvider
            EP.SetError(txt_nombre_usuario, "El campo debe ser un valor de texto")
            isValid = False
        Else
            ' No hay error, limpiar el ErrorProvider y continuar con la lógica del programa
            EP.SetError(txt_nombre_usuario, "") ' Limpiar el error
        End If

        If Not IsString(txt_correo.Text) Then
            ' Mostrar el error utilizando ErrorProvider
            EP.SetError(txt_correo, "El campo debe ser llenado segun la validacion correspondiente")
            isValid = False
        Else
            ' No hay error, limpiar el ErrorProvider y continuar con la lógica del programa
            EP.SetError(txt_correo, "") ' Limpiar el error
        End If

        ' Verificar si el campo TextBox está vacío o no es un entero
        If Not IsInteger(txt_dni.Text) Then
            ' Mostrar el error utilizando ErrorProvider
            EP.SetError(txt_dni, "El campo debe ser un valor entero")
            isValid = False
        Else
            ' No hay error, limpiar el ErrorProvider y continuar con la lógica del programa
            EP.SetError(txt_dni, "") ' Limpiar el error
        End If

        Dim password As String = txt_contraseña.Text

        'Validamos la contraseña utilizando expresiones regulares
        Dim regex As New Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$")
        Dim isValidcontra As Boolean = regex.IsMatch(password)

        If isValidcontra Then
            'La contraseña es válida, limpiamos cualquier mensaje de error previo
            EP.SetError(txt_contraseña, "")
        Else
            'La contraseña no cumple con los requisitos, mostramos un mensaje de error
            EP.SetError(txt_contraseña, "La contraseña debe tener al menos 8 caracteres, una letra mayúscula, una letra minúscula y un número.")
        End If

        Dim password2 As String = txt_confirmar.Text

        'Validamos la contraseña utilizando expresiones regulares
        Dim isValidcontra2 As Boolean = regex.IsMatch(password)

        If isValidcontra2 Then
            'La contraseña es válida, limpiamos cualquier mensaje de error previo
            EP.SetError(txt_confirmar, "")
        Else
            'La contraseña no cumple con los requisitos, mostramos un mensaje de error
            EP.SetError(txt_confirmar, "La contraseña debe tener al menos 8 caracteres, una letra mayúscula, una letra minúscula y un número.")
        End If

        If txt_contraseña.Text <> txt_confirmar.Text Then
            MessageBox.Show("Las contraseñas no coinsiden", "Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
            isValid = False
        End If

        ' Si isValid es verdadero, significa que todos los campos son válidos.
        If isValid Then
            ' Continuar con la lógica del programa
            ' Crear la consulta SQL para insertar los datos de facturación en la base de datos
            query = "insert into Facturacion(id_usuario, Nombre_Us, Dni_Us, Contrasenia_Us, Correo_Us) values(GETDATE(), '" & txt_nombre_usuario.Text & "', '" & txt_dni.Text & "', '" & txt_contraseña.Text & "', '" & txt_correo.Text & "')"
            con.insertar(query)
            ' Mostrar un mensaje indicando que los datos fueron insertados exitosamente
            MessageBox.Show("Datos insertados exitosamente", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Limpiar los campos de entrada
            txt_nombre_usuario.Clear()
            txt_correo.Clear()
            txt_dni.Clear()
            txt_contraseña.Clear()
            txt_confirmar.Clear()
            cargar()
        Else
            ' Mostrar un mensaje o realizar alguna acción si algún campo no es válido.
        End If


    End Sub

    Private Sub dg_usuarios_CellDobleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_usuarios.CellDoubleClick
        cond = 2
        txt_nombre_usuario.Text = dg_usuarios.CurrentRow.Cells(0).Value
        txt_dni.Text = dg_usuarios.CurrentRow.Cells(1).Value
        txt_contraseña.Text = dg_usuarios.CurrentRow.Cells(2).Value
        txt_correo.Text = dg_usuarios.CurrentRow.Cells(3).Value


    End Sub
    Private Sub frm_usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
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

End Class