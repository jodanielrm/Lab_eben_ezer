Public Class RptParasitologia
    Private Sub RptParasitologia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objreporte As New CRParasitologia

        objreporte.SetParameterValue("@id", resultadoParasito)

        CrystalReportViewer1.ReportSource = objreporte
    End Sub
End Class