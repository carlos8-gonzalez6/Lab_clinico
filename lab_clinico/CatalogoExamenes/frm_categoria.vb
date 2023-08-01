Imports System.Data.SqlClient
Public Class frm_categoria
    Dim dv As New DataView
    Dim con As New Conexion
    Dim query As String
    Dim cond As Integer


    Public Sub cargar()
        query = "SELECT Id_Analisis, Nombre_Analisis from Analisis;"
        If con.val(query) = True Then
            Try
                Dim da As New SqlDataAdapter(query, con.cnn)
                Dim ds As New DataSet
                With dgv_categoria
                    ' opcional: Sin selección múltiple  
                    .MultiSelect = False
                    ' seleccioanr fila completa al hacer clic en un registro  
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                End With

                da.Fill(ds)
                dv.Table = ds.Tables(0)
                dgv_categoria.DataSource = dv
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            MsgBox("No hay registros", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
    End Sub

    Private Sub btn_categoria_Click(sender As Object, e As EventArgs) Handles btn_categoria.Click
        dgv_categoria.Show()
    End Sub

    Private Sub btnnuevacategoria_Click(sender As Object, e As EventArgs) Handles btnnuevacategoria.Click
        query = "insert into Analisis(Id_Analisis, Nombre_Analisis)"
        con.insertar(query)
        MessageBox.Show("Datos agregados correctamente", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtnombrecategoria.Clear()

        cargar()

    End Sub

    Private Sub btneditarcategoria_Click(sender As Object, e As EventArgs) Handles btneditarcategoria.Click
        If cond = 1 Then
            query = "INSERT INTO Categoria(Id_Analisis, Nombre_Analisis) VALUES ('" & txtnombrecategoria.Text & "')"
            con.insertar(query)
            MessageBox.Show("Datos agregados correctamente", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtnombrecategoria.Clear()

        ElseIf cond = 2 Then
            query = "UPDATE Categoria SET Nombre_Analisis='" & txtnombrecategoria.Text & "')"
            con.insertar(query)
            MessageBox.Show("Datos actualizados exitosamente", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtnombrecategoria.Clear()

        End If
        cargar()
        cond = 1


    End Sub

    Private Sub dgv_categoria_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_categoria.CellContentClick
        cond = 2
        txtnombrecategoria.Text = dgv_categoria.CurrentRow.Cells(0).Value

    End Sub
End Class