Public Class frm_pacientes
    Private Sub Pacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub iconButton3_Click(sender As Object, e As EventArgs) Handles iconButton3.Click
        Dim frm_nuevo_pacientes As New frm_nuevo_paciente() ' Reemplaza "Form2" con el nombre de tu formulario
        frm_nuevo_pacientes.Show()


    End Sub

    Private Sub iconButton2_Click(sender As Object, e As EventArgs) Handles iconButton2.Click
        Dim frm_editar_pacientes As New frm_editar_pacientes() ' Reemplaza "Form2" con el nombre de tu formulario
        frm_editar_pacientes.Show()

    End Sub
End Class