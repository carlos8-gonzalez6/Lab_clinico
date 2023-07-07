Public Class Form1
    Private Sub btnpacientes_Click(sender As Object, e As EventArgs) Handles btnpacientes.Click
        frm_pacientes.Show()

    End Sub

    Private Sub btncatalogo_Click(sender As Object, e As EventArgs) Handles btncatalogo.Click
        frm_categoria.Show()
    End Sub

    Private Sub btnfacturacion_Click(sender As Object, e As EventArgs) Handles btnfacturacion.Click
        frm_facturacion.Show()

    End Sub

    Private Sub btnempleados_Click(sender As Object, e As EventArgs) Handles btnempleados.Click
        Empleados.Show()
    End Sub

    Private Sub btnusuarios_Click(sender As Object, e As EventArgs) Handles btnusuarios.Click
        frm_usuarios.Show()
    End Sub
End Class
