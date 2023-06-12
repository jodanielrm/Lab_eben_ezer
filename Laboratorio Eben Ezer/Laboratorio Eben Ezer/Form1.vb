Public Class Form1

    Public Sub AbrirFormEnPanel(ByVal Formhijo As Object)
        PanelContenedor.Visible = True
        If Me.PanelContenedor.Controls.Count > 0 Then Me.PanelContenedor.Controls.RemoveAt(0)
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.PanelContenedor.Controls.Add(fh)
        Me.PanelContenedor.Tag = fh
        fh.Show()

    End Sub

    Private Sub ocultos()
        BtnChagas.Visible = False
        BtnHepaA.Visible = False
        BtnHepaB.Visible = False
        BtnHepaC.Visible = False
        BtnToxo.Visible = False
        BtnOrina.Visible = False
        BtnParasito.Visible = False
        BtnPacientes.Visible = False
        BtnMedicos.Visible = False
        PanelContenedor.Visible = False
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnCerrarSesion.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ocultos()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnPersonas.Click
        ocultos()
        BtnPacientes.Visible = True
        BtnMedicos.Visible = True
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnInmuno.Click
        ocultos()
        BtnChagas.Visible = True
        BtnHepaA.Visible = True
        BtnHepaB.Visible = True
        BtnHepaC.Visible = True
        BtnToxo.Visible = True




    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BtnCitologia.Click
        ocultos()
        AbrirFormEnPanel(New Citologia)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles BtnGenerales.Click
        ocultos()
        BtnOrina.Visible = True
        BtnParasito.Visible = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles BtnDiversos.Click
        ocultos()
        AbrirFormEnPanel(New Diversos)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles BtnSerologia.Click
        ocultos()
        AbrirFormEnPanel(New Serologia)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnQuimicaG.Click
        ocultos()
        AbrirFormEnPanel(New QuimicaGeneral)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles BtnPacientes.Click
        AbrirFormEnPanel(New Clientes)
    End Sub

    Private Sub BtnMedicos_Click(sender As Object, e As EventArgs) Handles BtnMedicos.Click
        AbrirFormEnPanel(New Medicos)
    End Sub

    Private Sub BtnChagas_Click(sender As Object, e As EventArgs) Handles BtnChagas.Click

        ocultos()
        Inmuno = "AC. CHAGAS"
        AbrirFormEnPanel(New Inmunologia)

    End Sub

    Private Sub BtnHepaA_Click(sender As Object, e As EventArgs) Handles BtnHepaA.Click
        ocultos()
        Inmuno = "AC. HEPATITIS 'A'"
        AbrirFormEnPanel(New Inmunologia)

    End Sub

    Private Sub BtnHepaB_Click(sender As Object, e As EventArgs) Handles BtnHepaB.Click
        ocultos()
        Inmuno = "AC. HEPATITIS 'B'"
        AbrirFormEnPanel(New Inmunologia)

    End Sub

    Private Sub BtnHepaC_Click(sender As Object, e As EventArgs) Handles BtnHepaC.Click
        ocultos()
        Inmuno = "AC. HEPATITIS 'C'"
        AbrirFormEnPanel(New Inmunologia)

    End Sub

    Private Sub BtnToxo_Click(sender As Object, e As EventArgs) Handles BtnToxo.Click
        ocultos()
        Inmuno = "TOXOPLASMOSIS"
        AbrirFormEnPanel(New Inmunologia)

    End Sub

    Private Sub BtnOrina_Click(sender As Object, e As EventArgs) Handles BtnOrina.Click
        ocultos()
        AbrirFormEnPanel(New Orina)
    End Sub

    Private Sub BtnParasito_Click(sender As Object, e As EventArgs) Handles BtnParasito.Click
        ocultos()
        AbrirFormEnPanel(New Parasitologia)
    End Sub

    Private Sub BtnResultados_Click(sender As Object, e As EventArgs) Handles BtnResultados.Click
        ocultos()
        AbrirFormEnPanel(New Informes)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ocultos()
        AbrirFormEnPanel(New Hemograma)
    End Sub
End Class
