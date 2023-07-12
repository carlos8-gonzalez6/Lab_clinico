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
            dg_pacientes.Columns(0).Visible = True
            dg_pacientes.Columns(1).Width = 450
            dg_pacientes.Columns(2).Width = 150
            dg_pacientes.Columns(3).Width = 150

        Else
            MsgBox("No hay registros", MsgBoxStyle.Critical)
        End If
    End Sub




    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        query = "insert into Pacientes(Id_Paciente, Nombre_Paciente, Apellido_Paciente, Dni_Paciente, Fecha_Nacimiento, Direccion_Paciente, Telefono_Paciente, Estatus_Us, Genero) VALUES('" & txtid.Text & "','" & txtNombre.Text & "','" & txtApellido.Text & "','" & txtDni.Text & "','" & DtpFechaNac.Text & "' ,'" & txtDireccion.Text & "', '" & txtTelefono.Text & "', '" & cmbGenero.Text & "')"
        con.insertar(query)
        MessageBox.Show("Datos registrados exitosamente ", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtNombre.Clear()
        txtApellido.Clear()
        txtDni.Clear()
        txtDireccion.Clear()
        txtTelefono.Clear()

        cargar()
    End Sub



    Private Sub frm_pacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargar()
        autonum()
        cond = 0
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        cond = 1
        btnEditar.Text = "Guardar"
    End Sub


End Class