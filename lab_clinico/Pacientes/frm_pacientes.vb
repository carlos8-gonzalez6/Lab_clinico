Imports System.Data.SqlClient
Public Class frm_pacientes
    Dim con As New Conexion
    Dim query As String
    Dim dv As New DataView
    Dim dr As SqlDataReader
    Dim cond As Integer

    Public Sub autonum()
        query = "select Id_Paciente from Pacientes"
        If con.val(query) = True Then
            query = "select Max(Id_Paciente) from Pacientes"
            dr = con.reader(query)
            While dr.Read
                txtDni.Text = dr.GetValue(0) + 1
            End While
            dr.Close()
        Else
            txtDni.Text = 1
        End If
    End Sub

    Public Sub cargar()
        query = "select * from Pacientes"
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
            dg_pacientes.Columns(0).Visible = False
            dg_pacientes.Columns(1).Width = 450
            dg_pacientes.Columns(2).Width = 150
            dg_pacientes.Columns(3).Width = 150

        Else
            MsgBox("No hay registros", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Pacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnGuardar.Location = New Point(681, 624)
        btnEditar.Location = New Point(782, 624)
        btnGuardar.Visible = True
        btnEditar.Visible = True
        btnEditar.Enabled = False
        dg_pacientes.Size = New Size(434, 424)
        gb_Pacientes.Visible = True
        cargar()
        Me.Dock = DockStyle.Fill

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        btnEditar.Location = New Point(883, 402)
        btnGuardar.Visible = True
        btnEditar.Visible = True
        dg_pacientes.Size = New Size(434, 424)
        gb_Pacientes.Visible = True
        btnGuardar.Text = "Actualizar"
        cond = 2
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        btnEditar.Location = New Point(782, 402)
        btnGuardar.Visible = True
        btnEditar.Visible = True
        dg_pacientes.Size = New Size(966, 349)
        gb_Pacientes.Visible = True
        autonum()
        btnGuardar.Text = "Guardar"
        cond = 1
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try


            If cond = 1 Then
                query = "insert into Pacientes values(" & txtDni.Text & ", '" & txtNombre.Text & "', " & txtDireccion.Text & ", " & cmbGenero.SelectedIndex & ", " & txtTelefono.Text & ")"
                con.insertar(query)
                MsgBox("Registro Guardado con Exito", MsgBoxStyle.Information)
            Else
                query = "update Pacientes set Nom_Pac = '" & txtNombre.Text & "', Direccion_Pac =" & txtDireccion.Text & ", Gen_Pac =" & cmbGenero.SelectedIndex & ", Tel_Pac = " & txtTelefono.Text & " Where Id_Pac = " & txtDni.Text
                con.insertar(query)
                MsgBox("Registro Actualizado con Exito", MsgBoxStyle.Information)
            End If
            cargar()
            btnEditar.Location = New Point(681, 624)
            btnGuardar.Location = New Point(782, 624)
            btnEditar.Visible = True
            btnGuardar.Visible = True
            dg_pacientes.Size = New Size(966, 473)
            gb_Pacientes.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub



    Private Sub dg_pacientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_pacientes.CellDoubleClick

        txtNombre.Text = dg_pacientes.CurrentRow.Cells(0).Value
        txtApellido.Text = dg_pacientes.CurrentRow.Cells(1).Value
        txtDni.Text = dg_pacientes.CurrentRow.Cells(2).Value
        cmbGenero.Text = dg_pacientes.CurrentRow.Cells(3).Value
        DtpFechaNac.Text = dg_pacientes.CurrentRow.Cells(4).Value
        txtDireccion.Text = dg_pacientes.CurrentRow.Cells(5).Value
        txtTelefono.Text = dg_pacientes.CurrentRow.Cells(6).Value

        btnGuardar.Enabled = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        dv.RowFilter = "Pacientes LIKE '%" + txtBuscar.Text.Trim + "%'"
    End Sub

    Private Sub gb_Pacientes_Enter(sender As Object, e As EventArgs) Handles gb_Pacientes.Enter

    End Sub

    Private Sub dg_pacientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_pacientes.CellContentClick

    End Sub
End Class