Imports System.Data.SqlClient
Public Class Inmunologia
    Dim con As New Conexion
    Dim query As String
    Dim dv As New DataView
    Dim dr As SqlDataReader
    Dim cond As Integer
    Public Sub autonumresultados()
        query = "select Id_ResultadoI from Inmunologia"
        If con.val(query) = True Then
            query = "select MAX(Id_ResultadoI) from Inmunologia"
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

    Private Sub Inmunologia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Text = Inmuno
        GroupBox5.Visible = False
        autonumresultados()
    End Sub

    Private Sub BtnAddClientes_Click(sender As Object, e As EventArgs) Handles BtnAddClientes.Click
        GroupBox5.Visible = True
        cond = 1
        cargar()
    End Sub

    Private Sub BtnAddMedico_Click(sender As Object, e As EventArgs) Handles BtnAddMedico.Click
        GroupBox5.Visible = True
        cond = 2
        cargar()
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
        GroupBox5.Visible = False
    End Sub

    Private Sub BtnInmunologia_Click(sender As Object, e As EventArgs) Handles BtnInmunologia.Click
        Dim examen As Integer
        If Inmuno = "AC. CHAGAS" Then
            examen = 2
        ElseIf Inmuno = "AC. HEPATITIS 'A'" Then
            examen = 3
        ElseIf Inmuno = "AC. HEPATITIS 'B'" Then
            examen = 4
        ElseIf Inmuno = "AC. HEPATITIS 'C'" Then
            examen = 5
        ElseIf Inmuno = "TOXOPLASMOSIS" Then
            examen = 6
        End If

        If TxtIdMedico.Text = "" Then
            TxtIdMedico.Text = "0"
        End If

        If TxtNombre.Text = "" Then
            MsgBox("Por favor ingrese la informacion del paciente", MsgBoxStyle.Exclamation)
        Else
            Try
                query = "INSERT INTO Inmunologia VALUES (" & TxtIdResultado.Text & ",CONVERT (date, GETDATE())," & TxtId.Text & "," & TxtIdMedico.Text & "," & CmbIgc.SelectedIndex & "," & CmbIgm.SelectedIndex & "," & examen & ")"
                con.insertar(query)

                MsgBox("Examen Registrado con exito", MsgBoxStyle.Information)
                resultadoinmu = TxtIdResultado.Text
                autonumresultados()
                Dim ans As String
                ans = MsgBox("¿Desea ver el resultado?", vbYesNo)
                If ans = vbYes Then

                    Form1.AbrirFormEnPanel(New RptInmunologia)
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try

        End If
    End Sub

End Class