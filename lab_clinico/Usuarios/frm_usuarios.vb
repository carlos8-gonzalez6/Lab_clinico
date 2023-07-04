Imports System.Data.SqlClient

Public Class frm_usuarios
    Dim con As New Conexion
    Dim query As String
    Dim dv As New DataView

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
        query = "INSERT INTO Usuarios(Nombre_Us,Dni_Us,Contrasenia_Us,Correo_Us) VALUES('" & txt_nombre_usuario.Text & "','" & txt_dni.Text & "','" & txt_contraseña.Text & "','" & txt_correo.Text & "')"
        con.insertar(query)
        MessageBox.Show("Datos insertados exitosamente", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txt_nombre_usuario.Clear()
        txt_dni.Clear()
        txt_contraseña.Clear()
        txt_correo.Clear()

        cargar()

    End Sub

    Private Sub frm_usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
    End Sub
End Class