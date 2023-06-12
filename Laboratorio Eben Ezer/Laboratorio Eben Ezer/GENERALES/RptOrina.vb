Public Class RptOrina
    Private Sub RptOrina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objreporte As New CROrina

        objreporte.SetParameterValue("@id", resultadoOrina)

        CrystalReportViewer1.ReportSource = objreporte
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class