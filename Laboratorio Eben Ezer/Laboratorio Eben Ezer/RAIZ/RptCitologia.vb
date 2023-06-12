Public Class RptCitologia
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim objreporte As New CRCitologia

        objreporte.SetParameterValue("@id", resultadocito)

        CrystalReportViewer1.ReportSource = objreporte
    End Sub
End Class