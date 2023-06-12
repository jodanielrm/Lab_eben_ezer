Imports System.Data.SqlClient
Public Class Clientes
    Dim con As New Conexion
    Dim query As String
    Dim dv As New DataView
    Dim dr As SqlDataReader
    Dim cond As Integer

    Public Sub autonum()
        query = "select Id_Cli from Cliente"
        If con.val(query) = True Then
            query = "select Max(Id_Cli) from Cliente"
            dr = con.reader(query)
            While dr.Read
                TxtId.Text = dr.GetValue(0) + 1
            End While
            dr.Close()
        Else
            TxtId.Text = 1
        End If
    End Sub

    Public Sub cargar()
        query = "select * from Ver_Clientes"
        If con.val(query) = True Then
            Try
                Dim da As New SqlDataAdapter(query, con.cnn)
                Dim ds As New DataSet
                With DgvClientes
                    ' opcional: Sin selección múltiple  
                    .MultiSelect = False
                    ' seleccioanr fila completa al hacer clic en un registro  
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                End With

                da.Fill(ds)
                dv.Table = ds.Tables(0)
                DgvClientes.DataSource = dv
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            DgvClientes.Columns(0).Visible = False
            DgvClientes.Columns(1).Width = 450
            DgvClientes.Columns(2).Width = 150
            DgvClientes.Columns(3).Width = 150

        Else
            MsgBox("No hay registros", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnAdd.Location = New Point(681, 624)
        BtnUpdate.Location = New Point(782, 624)
        BtnAdd.Visible = True
        BtnUpdate.Visible = True
        BtnUpdate.Enabled = False
        DgvClientes.Size = New Size(966, 473)
        GroupBox1.Visible = False
        cargar()
        Me.Dock = DockStyle.Fill

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        BtnUpdate.Location = New Point(883, 402)
        BtnAdd.Visible = False
        BtnUpdate.Visible = False
        DgvClientes.Size = New Size(966, 349)
        GroupBox1.Visible = True
        BtnGuardar.Text = "Actualizar"
        cond = 2
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        BtnAdd.Location = New Point(782, 402)
        BtnUpdate.Visible = False
        BtnAdd.Visible = False
        DgvClientes.Size = New Size(966, 349)
        GroupBox1.Visible = True
        autonum()
        BtnGuardar.Text = "Guardar"
        cond = 1
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try


            If cond = 1 Then
                query = "insert into Cliente values(" & TxtId.Text & ", '" & TxtNombre.Text & "', " & TxtEdad.Text & ", " & CmbGenero.SelectedIndex & ", " & TxtTel.Text & ")"
                con.insertar(query)
                MsgBox("Registro Guardado con Exito", MsgBoxStyle.Information)
            Else
                query = "update Cliente set Nom_Cli = '" & TxtNombre.Text & "', Edad_Cli =" & TxtEdad.Text & ", Gen_Cli =" & CmbGenero.SelectedIndex & ", Tel_Cli = " & TxtTel.Text & " Where Id_Cli = " & TxtId.Text
                con.insertar(query)
                MsgBox("Registro Actualizado con Exito", MsgBoxStyle.Information)
            End If
            cargar()
            BtnAdd.Location = New Point(681, 624)
            BtnUpdate.Location = New Point(782, 624)
            BtnAdd.Visible = True
            BtnUpdate.Visible = True
            DgvClientes.Size = New Size(966, 473)
            GroupBox1.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub



    Private Sub DgvClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvClientes.CellDoubleClick
        TxtId.Text = DgvClientes.CurrentRow.Cells(0).Value
        TxtNombre.Text = DgvClientes.CurrentRow.Cells(1).Value
        TxtEdad.Text = DgvClientes.CurrentRow.Cells(2).Value
        CmbGenero.Text = DgvClientes.CurrentRow.Cells(3).Value


        BtnUpdate.Enabled = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        dv.RowFilter = "Cliente LIKE '%" + TextBox1.Text.Trim + "%'"
    End Sub
End Class