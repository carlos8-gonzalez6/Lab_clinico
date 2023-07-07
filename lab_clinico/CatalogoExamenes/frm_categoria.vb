Imports System.Data.SqlClient
Public Class frm_categoria
    Dim dv As New DataView
    Dim con As New Conexion
    Dim query As String


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
End Class