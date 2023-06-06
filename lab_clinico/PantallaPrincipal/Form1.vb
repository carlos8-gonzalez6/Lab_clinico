Public Class Form1
    Private Sub btnpacientes_Click(sender As Object, e As EventArgs) Handles btnpacientes.Click
        Dim frm_pacientes As New frm_pacientes() ' Reemplaza "Form2" con el nombre de tu formulario
        frm_pacientes.Show()

    End Sub

    Private Sub btncatalogo_Click(sender As Object, e As EventArgs) Handles btncatalogo.Click
        Dim frm_catalogo As New catalogo() ' Reemplaza "Form2" con el nombre de tu formulario
        catalogo.Show()
    End Sub

    Private Sub btnfacturacion_Click(sender As Object, e As EventArgs) Handles btnfacturacion.Click
        Dim frm_facturacion As New frm_facturacion() ' Reemplaza "Form2" con el nombre de tu formulario
        frm_facturacion.Show()

    End Sub

    Private Sub btnempleados_Click(sender As Object, e As EventArgs) Handles btnempleados.Click
        Dim Empleados As New Empleados() ' Reemplaza "Form2" con el nombre de tu formulario
        Empleados.Show()
    End Sub

    Private Sub btnusuarios_Click(sender As Object, e As EventArgs) Handles btnusuarios.Click
        Dim Usuarios As New Usuarios() ' Reemplaza "Form2" con el nombre de tu formulario
        Usuarios.Show()
    End Sub
End Class
