Imports System.Data.SqlClient
Public Class Informes
    Dim con As New Conexion
    Dim query As String
    Dim dv As New DataView
    Dim dr As SqlDataReader
    Dim cond As Integer

    Public Sub cargar()

        query = "exec BusquedaExamen " & ComboBox1.SelectedIndex + 1


        If con.val(query) = True Then
            Try
                Dim da As New SqlDataAdapter(query, con.cnn)
                Dim ds As New DataSet
                With DataGridView1
                    ' opcional: Sin selección múltiple  
                    .MultiSelect = False
                    ' seleccioanr fila completa al hacer clic en un registro  
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                End With

                da.Fill(ds)
                dv.Table = ds.Tables(0)
                DataGridView1.DataSource = dv
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(3).Width = 230
            DataGridView1.Columns(5).Width = 230
            DataGridView1.Columns(7).Width = 180

        Else
            MsgBox("No hay registros", MsgBoxStyle.Critical)
            DataGridView1.Columns.Clear()
        End If
    End Sub
    Private Sub Informes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        cargar()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged


        dv.RowFilter = "Cliente LIKE '%" + TextBox1.Text.Trim + "%'"

    End Sub


    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim exa As Integer = ComboBox1.SelectedIndex + 1

        If exa = 1 Then
            resultadoqg = DataGridView1.CurrentRow.Cells(0).Value
            Form1.AbrirFormEnPanel(New RPTQGeneral)
        ElseIf exa = 2 Or exa = 3 Or exa = 4 Or exa = 5 Or exa = 6 Then
            resultadoinmu = DataGridView1.CurrentRow.Cells(0).Value
            Form1.AbrirFormEnPanel(New RptInmunologia)
        ElseIf exa = 7 Then
            resultadocito = DataGridView1.CurrentRow.Cells(0).Value
            Form1.AbrirFormEnPanel(New RptCitologia)
        ElseIf exa = 8 Then
            resultadosero = DataGridView1.CurrentRow.Cells(0).Value
            Form1.AbrirFormEnPanel(New RptSerologia)
        ElseIf exa = 9 Then
            resultadoOrina = DataGridView1.CurrentRow.Cells(0).Value
            Form1.AbrirFormEnPanel(New RptOrina)
        ElseIf exa = 10 Then
            resultadoParasito = DataGridView1.CurrentRow.Cells(0).Value
            Form1.AbrirFormEnPanel(New RptParasitologia)
        ElseIf exa = 11 Then
            resultadoDiversos = DataGridView1.CurrentRow.Cells(0).Value
            Form1.AbrirFormEnPanel(New RptDiversos)
        ElseIf exa = 12 Then
            resultadohemo = DataGridView1.CurrentRow.Cells(0).Value
            Form1.AbrirFormEnPanel(New RptHemograma)
        End If
    End Sub
End Class