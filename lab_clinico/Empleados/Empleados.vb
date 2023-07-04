Imports System.Data.SqlClient

Public Class Empleados
    Dim con As New Conexion
    Dim query As String
    Dim dv As New DataView
    Dim cond As Integer
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
        query = "insert into Empleados(Id_Empleado, Nombre_Empleado, Apellido_Empleado, Dni_Empleado, Fecha_Nacimiento, Direccion_Empleado, Telefono_Empleado, Estatus_Us, Genero) VALUES('" & txtid.Text & "','" & txtempleadonombre.Text & "','" & txtempleadoapellido.Text & "','" & txtdni.Text & "','" & DateTimePicker1.Text & "' ,'" & txtdireccionempleado.Text & "', '" & txtempleadotelef.Text & "', 1,  '" & cmbgenero.Text & "')"
        con.insertar(query)
        MessageBox.Show("Datos insertados exitosamente", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtempleadonombre.Clear()
        txtempleadoapellido.Clear()
        txtdni.Clear()
        txtdireccionempleado.Clear()
        txtempleadotelef.Clear()

        cargar()

    End Sub

    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
        autonum()
        cond = 0
    End Sub

    Private Sub btnempleadoeditar_Click(sender As Object, e As EventArgs) Handles btnempleadoeditar.Click
        cond = 1
        btnempleadoeditar.Text = "Guardar"

    End Sub

    Private Sub dgv_empleados_CellDobleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_empleados.CellDoubleClick
        cond = 2
        btnempleadonuevo.Text = "Actualizar"






    End Sub


End Class