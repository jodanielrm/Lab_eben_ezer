Imports System.Data.SqlClient
Public Class QuimicaGeneral
    Dim con As New Conexion
    Dim query As String
    Dim dv As New DataView
    Dim dr As SqlDataReader
    Dim cond As Integer

    Public Sub autonumresultados()
        query = "select Id_ResultadoQG from QGeneral"
        If con.val(query) = True Then
            query = "select Max(Id_ResultadoQG) from QGeneral"
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

    Private Sub TextBox9_MouseMove(sender As Object, e As MouseEventArgs) Handles TxtAU.MouseMove
        lbliacido.Visible = True
    End Sub

    Private Sub QuimicaGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtFecha.Text = Today
        lbliacido.Visible = False
        lblicolesterolt.Visible = False
        lblihdl.Visible = False
        lblildl.Visible = False
        lblicreatinina.Visible = False
        lbliglucosa.Visible = False
        lbliurea.Visible = False
        lblitri.Visible = False
        lblisgot.Visible = False
        lblisgpt.Visible = False
        GroupBox5.Visible = False
        autonumresultados()

    End Sub


    Private Sub GroupBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles GroupBox2.MouseMove
        lbliacido.Visible = False
        lblicolesterolt.Visible = False
        lblihdl.Visible = False
        lblildl.Visible = False
        lblicreatinina.Visible = False
    End Sub

    Private Sub TextBox7_MouseMove(sender As Object, e As MouseEventArgs) Handles TxtColesterolT.MouseMove
        lblicolesterolt.Visible = True
    End Sub

    Private Sub TextBox11_MouseMove(sender As Object, e As MouseEventArgs) Handles TxtHDL.MouseMove
        lblihdl.Visible = True
    End Sub

    Private Sub TextBox10_MouseMove(sender As Object, e As MouseEventArgs) Handles TxtLDL.MouseMove
        lblildl.Visible = True
    End Sub

    Private Sub TextBox12_MouseMove(sender As Object, e As MouseEventArgs) Handles TxtCreatinina.MouseMove
        lblicreatinina.Visible = True
    End Sub

    Private Sub GroupBox3_MouseMove(sender As Object, e As MouseEventArgs) Handles GroupBox3.MouseMove
        lbliglucosa.Visible = False
        lbliurea.Visible = False
        lblitri.Visible = False
        lblisgot.Visible = False
        lblisgpt.Visible = False
    End Sub

    Private Sub TextBox21_MouseMove(sender As Object, e As MouseEventArgs) Handles TxtGluco.MouseMove
        lbliglucosa.Visible = True
    End Sub

    Private Sub TextBox20_MouseMove(sender As Object, e As MouseEventArgs) Handles TxtUrea.MouseMove
        lbliurea.Visible = True
    End Sub

    Private Sub TextBox19_MouseMove(sender As Object, e As MouseEventArgs) Handles TxtTrigli.MouseMove
        lblitri.Visible = True
    End Sub

    Private Sub TextBox18_MouseMove(sender As Object, e As MouseEventArgs) Handles TxtSGOT.MouseMove
        lblisgot.Visible = True
    End Sub

    Private Sub TextBox17_MouseMove(sender As Object, e As MouseEventArgs) Handles TxtSGPT.MouseMove
        lblisgpt.Visible = True
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

            If CmbGenero.Text = "Masculino" Then
                lbliacido.Text = "Hombres = 3.5  -  7.2"
                lblihdl.Text = "Hombres = 40  -  60"
                lblicreatinina.Text = "Hombres = 0.6  -  1.4"
                lblisgot.Text = "Hombres: <= 37"
                lblisgpt.Text = "Hombres: <= 45"
            ElseIf CmbGenero.Text = "Femenino" Then
                lbliacido.Text = "Mujeres = 2.6  -  6.0"
                lblihdl.Text = "Mujeres = 50  -  60"
                lblicreatinina.Text = "Mujeres = 0.6  -  1.2"
                lblisgot.Text = "Mujeres:   <= 31"
                lblisgpt.Text = "Mujeres:   <= 34"
            End If
        ElseIf cond = 2 Then
            TxtIdMedico.Text = DataGridView1.CurrentRow.Cells(0).Value
            TxtMedico.Text = DataGridView1.CurrentRow.Cells(1).Value
        End If
        GroupBox5.Visible = False
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
                query = "INSERT INTO QGeneral VALUES(" & TxtIdResultado.Text & ",'" & TxtFecha.Text & "'," & TxtId.Text & "," & TxtIdMedico.Text & ",1,'" & TxtAU.Text & " mg/dl','" & TxtColesterolT.Text & " mg/dl','" & TxtHDL.Text & " mg/dl','" & TxtLDL.Text & " mg/dl','" & TxtCreatinina.Text & " mg/dl','" & TxtGluco.Text & " mg/dl','" & TxtUrea.Text & " mg/dl','" & TxtTrigli.Text & " mg/dl','" & TxtSGOT.Text & " U/L','" & TxtSGPT.Text & " U/L','" & TxtNota.Text & "')"
                con.insertar(query)
                MsgBox("Examen Registrado con exito", MsgBoxStyle.Information)
                autonumresultados()
                Dim ans As String
                ans = MsgBox("¿Desea ver el resultado?", vbYesNo)
                If ans = vbYes Then
                    resultadoqg = veractual
                    Form1.AbrirFormEnPanel(New RPTQGeneral)
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try

        End If
    End Sub


End Class