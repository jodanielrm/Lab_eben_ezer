Imports System.Data.SqlClient
Public Class Hemograma
    Dim con As New Conexion
    Dim query As String
    Dim dv As New DataView
    Dim dr As SqlDataReader
    Dim cond As Integer

    Public Sub autonumresultados()
        query = "select Id_Resultadoh from Hemograma"
        If con.val(query) = True Then
            query = "select Max(Id_ResultadoH) from Hemograma"
            dr = con.reader(query)
            While dr.Read
                TxtIdResultado.Text = dr.GetValue(0) + 1
            End While
            dr.Close()
        Else
            TxtIdResultado.Text = 1
        End If
    End Sub

    Public Sub cargar()
        If cond = 1 Then
            query = "select * from Ver_Clientes"
        ElseIf cond = 2 Then
            query = "select * from Ver_Medico"
        End If

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
            DataGridView1.Columns(1).Width = 450
            DataGridView1.Columns(2).Width = 150
            DataGridView1.Columns(3).Width = 150

        Else
            MsgBox("No hay registros", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub ocultar()
        LblWbc.Visible = False
        LblLinfocitos.Visible = False
        Lblgranulitos.Visible = False
        LblMonocitos.Visible = False
        LblHemoglobina.Visible = False
        LblRbc.Visible = False
        LblHematocrito.Visible = False
        LblMcv.Visible = False
        LblMch.Visible = False
        LblMchc.Visible = False
        LblPlaquetas.Visible = False
    End Sub

    Private Sub TextBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles TxtWbc.MouseMove
        LblWbc.Visible = True
    End Sub

    Private Sub GroupBox3_MouseMove(sender As Object, e As MouseEventArgs) Handles GroupBox3.MouseMove
        ocultar()
    End Sub

    Private Sub BtnAddClientes_Click(sender As Object, e As EventArgs) Handles BtnAddClientes.Click
        GroupBox6.Visible = True
        cond = 1
        cargar()
    End Sub

    Private Sub BtnAddMedico_Click(sender As Object, e As EventArgs) Handles BtnAddMedico.Click
        GroupBox6.Visible = True
        cond = 2
        cargar()
    End Sub

    Private Sub Hemograma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtFecha.Text = Today
        ocultar()
        GroupBox6.Visible = False
        autonumresultados()
    End Sub



    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If cond = 1 Then
            TxtId.Text = DataGridView1.CurrentRow.Cells(0).Value
            TxtNombre.Text = DataGridView1.CurrentRow.Cells(1).Value
            TxtEdad.Text = DataGridView1.CurrentRow.Cells(2).Value
            CmbGenero.Text = DataGridView1.CurrentRow.Cells(3).Value


        ElseIf cond = 2 Then
            TxtIdMedico.Text = DataGridView1.CurrentRow.Cells(0).Value
            TxtMedico.Text = DataGridView1.CurrentRow.Cells(1).Value
        End If
        GroupBox6.Visible = False
    End Sub

    Private Sub TxtLinfocitos_MouseMove(sender As Object, e As MouseEventArgs) Handles TxtLinfocitos.MouseMove
        LblLinfocitos.Visible = True
    End Sub

    Private Sub TxtGranulocitos_MouseMove(sender As Object, e As MouseEventArgs) Handles TxtGranulocitos.MouseMove
        Lblgranulitos.Visible = True
    End Sub

    Private Sub TxtMonocitos_MouseMove(sender As Object, e As MouseEventArgs) Handles TxtMonocitos.MouseMove
        LblMonocitos.Visible = True
    End Sub

    Private Sub TxtHemoglobina_MouseMove(sender As Object, e As MouseEventArgs) Handles TxtHemoglobina.MouseMove
        LblHemoglobina.Visible = True
    End Sub

    Private Sub TxtRbc_MouseMove(sender As Object, e As MouseEventArgs) Handles TxtRbc.MouseMove
        LblRbc.Visible = True
    End Sub

    Private Sub TxtHematocrito_MouseMove(sender As Object, e As MouseEventArgs) Handles TxtHematocrito.MouseMove
        LblHematocrito.Visible = True
    End Sub

    Private Sub TxtMcv_MouseMove(sender As Object, e As MouseEventArgs) Handles TxtMcv.MouseMove
        LblMcv.Visible = True
    End Sub

    Private Sub TxtMch_MouseMove(sender As Object, e As MouseEventArgs) Handles TxtMch.MouseMove
        LblMch.Visible = True
    End Sub

    Private Sub TxtMchc_MouseMove(sender As Object, e As MouseEventArgs) Handles TxtMchc.MouseMove
        LblMchc.Visible = True
    End Sub

    Private Sub TxtPlaquetas_MouseMove(sender As Object, e As MouseEventArgs) Handles TxtPlaquetas.MouseMove
        LblPlaquetas.Visible = True
    End Sub

    Private Sub BtnQuimicaG_Click(sender As Object, e As EventArgs) Handles BtnQuimicaG.Click
        Dim veractual As Integer = TxtIdResultado.Text
        If TxtIdMedico.Text = "" Then
            TxtIdMedico.Text = "0"
        End If

        If TxtNombre.Text = "" Then
            MsgBox("Por favor ingrese la informacion del paciente", MsgBoxStyle.Exclamation)
        Else
            Try
                query = "INSERT INTO Hemograma VALUES(" & TxtIdResultado.Text & ",'" & TxtFecha.Text & "'," & TxtId.Text & "," & TxtIdMedico.Text & ",12,'" & TxtWbc.Text & " %','" & TxtLinfocitos.Text & " %','" & TxtGranulocitos.Text & " %','" & TxtMonocitos.Text & " %','" & TxtHemoglobina.Text & " g/dl','" & TxtRbc.Text & " 10*/1','" & TxtHematocrito.Text & " %','" & TxtMcv.Text & " fl','" & TxtMch.Text & " pg','" & TxtMchc.Text & " g/dl','" & TxtPlaquetas.Text & " 10*/1', '" & TextBox1.Text & "')"
                con.insertar(query)
                MsgBox("Examen Registrado con exito", MsgBoxStyle.Information)
                autonumresultados()
                Dim ans As String
                ans = MsgBox("¿Desea ver el resultado?", vbYesNo)
                If ans = vbYes Then
                    resultadohemo = veractual
                    Form1.AbrirFormEnPanel(New RPTHemograma)
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try

        End If
    End Sub

End Class