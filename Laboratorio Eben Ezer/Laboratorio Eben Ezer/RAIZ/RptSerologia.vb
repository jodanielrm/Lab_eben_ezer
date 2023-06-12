Public Class RptSerologia
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim objreporte As New CRSerologia

        objreporte.SetParameterValue("@id", resultadosero)

        CrystalReportViewer1.ReportSource = objreporte
    End Sub
End Class