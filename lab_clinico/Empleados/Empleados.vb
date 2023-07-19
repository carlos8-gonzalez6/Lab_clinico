Imports System.Data.SqlClient

Public Class Empleados
    Dim con As New Conexion
    Dim query As String
    Dim dv As New DataView
    ''Dim cond As Integer
    Dim dr As SqlDataReader


    Public Sub autonum()
        query = "select Id_Empleado from Empleados"
        If con.val(query) = True Then
            query = "select Max(Id_Empleado) from Empleados"
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
        query = "SELECT Id_Empleado, Nombre_Empleado, Apellido_Empleado, Dni_Empleado, Genero, Fecha_Nacimiento, Direccion_Empleado, Telefono_Empleado FROM Empleados;"
        If con.val(query) = True Then
            Try
                Dim da As New SqlDataAdapter(query, con.cnn)
                Dim ds As New DataSet
                With dgv_empleados
                    ' opcional: Sin selección múltiple  
                    .MultiSelect = False
                    ' seleccioanr fila completa al hacer clic en un registro  
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                End With

                da.Fill(ds)
                dv.Table = ds.Tables(0)
                dgv_empleados.DataSource = dv
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            MsgBox("No hay registros", MsgBoxStyle.Critical)
        End If
    End Sub


    Private Sub btnempleadonuevo_Click(sender As Object, e As EventArgs) Handles btnempleadonuevo.Click
        query = "Insert into Empleados(Id_Empleado, Nombre_Empleado, Apellido_Empleado, Dni_Empleado, Fecha_Nacimiento, Direccion_Empleado, Telefono_Empleado, Estatus_Us, Genero) VALUES('" & txtid.Text & "','" & txtempleadonombre.Text & "','" & txtempleadoapellido.Text & "','" & txtdni.Text & "','" & DateTimePicker1.Text & "' ,'" & txtdireccionempleado.Text & "', '" & txtempleadotelef.Text & "', 1,  '" & cmbgenero.Text & "')"
        con.insertar(query)
        MessageBox.Show("Datos insertados exitosamente", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtempleadonombre.Clear()
        txtempleadoapellido.Clear()
        txtdni.Clear()
        cmbgenero.SelectedIndex = 0
        txtdireccionempleado.Clear()
        txtempleadotelef.Clear()
        autonum()
        cargar()
    End Sub

    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
        autonum()
        btnempleadoeditar.Visible = False
    End Sub

    Private Sub dgv_empleados_CellDobleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_empleados.CellDoubleClick
        txtid.Text = dgv_empleados.CurrentRow.Cells(0).Value
        txtempleadonombre.Text = dgv_empleados.CurrentRow.Cells(1).Value
        txtempleadoapellido.Text = dgv_empleados.CurrentRow.Cells(2).Value
        txtdni.Text = dgv_empleados.CurrentRow.Cells(3).Value
        cmbgenero.Text = dgv_empleados.CurrentRow.Cells(4).Value
        DateTimePicker1.Text = dgv_empleados.CurrentRow.Cells(5).Value
        txtdireccionempleado.Text = dgv_empleados.CurrentRow.Cells(6).Value
        txtempleadotelef.Text = dgv_empleados.CurrentRow.Cells(7).Value

        btnempleadoeditar.Visible = True
    End Sub

    Private Sub btnempleadoeditar_Click(sender As Object, e As EventArgs) Handles btnempleadoeditar.Click

        query = "UPDATE Empleados SET Nombre_Empleado='" & txtempleadonombre.Text & "', Apellido_Empleado='" & txtempleadoapellido.Text & "', Dni_Empleado='" & txtdni.Text & "', Fecha_Nacimiento='" & DateTimePicker1.Text & "', Direccion_Empleado='" & txtdireccionempleado.Text & "', Telefono_Empleado='" & txtempleadotelef.Text & "', Genero='" & cmbgenero.Text & "' WHERE Id_Empleado='" & txtid.Text & "'"
        con.insertar(query)
        MessageBox.Show("Datos actualizados exitosamente", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtempleadonombre.Clear()
        txtempleadoapellido.Clear()
        txtdni.Clear()
        txtdireccionempleado.Clear()
        txtempleadotelef.Clear()

        btnempleadoeditar.Visible = False
        cargar()
        autonum()
    End Sub
End Class