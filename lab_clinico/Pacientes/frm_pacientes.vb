Imports System.Data.SqlClient
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
        If cond = 1 Then
            query = "insert into Pacientes(Id_Paciente, Nombre_Paciente, Apellido_Paciente, Dni_Paciente, Fecha_Nacimiento, Direccion_Paciente, Telefono_Paciente, Estatus_Us, Genero) VALUES('" & txtid.Text & "','" & txtNombre.Text & "','" & txtApellido.Text & "','" & txtDni.Text & "','" & DtpFechaNac.Text & "' ,'" & txtDireccion.Text & "', '" & txtTelefono.Text & "', '" & cmbGenero.Text & "')"
            con.insertar(query)
            MessageBox.Show("Datos registrados exitosamente ", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNombre.Clear()
            txtApellido.Clear()
            txtDni.Clear()
            txtDireccion.Clear()
            txtTelefono.Clear()

        ElseIf cond = 2 Then
            query = "UPDATE Pacientes SET Nombre_Paciente='" & txtNombre.Text & "', Apellido_Paciente='" & txtApellido.Text & "', Dni_Paciente='" & txtDni.Text & "', Fecha_Nacimiento='" & DtpFechaNac.Text & "', Direccion_Paciente='" & txtDireccion.Text & "', Telefono_Paciente='" & txtTelefono.Text & "', Genero='" & cmbGenero.Text & "' WHERE Id_Paciente='" & txtid.Text & "'"
            con.insertar(query)
            MessageBox.Show("Datos actualizados exitosamente", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNombre.Clear()
            txtApellido.Clear()
            txtDni.Clear()
            txtDireccion.Clear()
            txtTelefono.Clear()

        End If

        cargar()
        cond = 1

    End Sub



    Private Sub frm_pacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargar()
        autonum()
        cond = 0
        btnGuardar.Text = "Guardar Datos"

    End Sub

    Private Sub dg_pacientes_CellDobleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_pacientes.CellDoubleClick
        cond = 2
        btnGuardar.Text = "Actualizar"
        txtid.Text = dg_pacientes.CurrentRow.Cells(0).Value
        txtNombre.Text = dg_pacientes.CurrentRow.Cells(1).Value
        txtApellido.Text = dg_pacientes.CurrentRow.Cells(2).Value
        txtDni.Text = dg_pacientes.CurrentRow.Cells(3).Value
        cmbGenero.Text = dg_pacientes.CurrentRow.Cells(4).Value
        DtpFechaNac.Text = dg_pacientes.CurrentRow.Cells(5).Value
        txtDireccion.Text = dg_pacientes.CurrentRow.Cells(6).Value
        txtTelefono.Text = dg_pacientes.CurrentRow.Cells(7).Value

    End Sub



End Class