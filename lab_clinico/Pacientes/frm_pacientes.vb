Imports System.Data.SqlClient
Public Class frm_pacientes
    Dim con As New Conexion
    Dim query As String
    Dim dv As New DataView


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
            dg_pacientes.Columns(0).Visible = True
            dg_pacientes.Columns(1).Width = 450
            dg_pacientes.Columns(2).Width = 150
            dg_pacientes.Columns(3).Width = 150

        Else
            MsgBox("No hay registros", MsgBoxStyle.Critical)
        End If
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        dv.RowFilter = "Pacientes LIKE '%" + txtBuscar.Text.Trim + "%'"
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        query = "Update Pacientes(Nombre_Paciente,Apellido_Paciente,Dni_Paciente,Fecha_Nacimiento,Direccion_Paciente,Telefono_Paciente,Genero) VALUES('" & txtNombre.Text & "','" & txtApellido.Text & "','" & txtDni.Text & "','" & DtpFechaNac.Text & "' ,'" & txtDireccion.Text & "', '" & txtTelefono.Text & "', '" & cmbGenero.Text & "')"
        con.insertar(query)
        MessageBox.Show(" Datos  actualizados incorrectamente ", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtNombre.Clear()
        txtApellido.Clear()
        txtDni.Clear()
        txtDireccion.Clear()
        txtTelefono.Clear()

        cargar()
    End Sub



    Private Sub frm_pacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
    End Sub

    
End Class