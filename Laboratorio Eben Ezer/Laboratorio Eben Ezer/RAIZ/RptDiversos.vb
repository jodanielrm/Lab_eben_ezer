Public Class RptDiversos
    Private Sub RptDiversos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objreporte As New CRDiversos

        objreporte.SetParameterValue("@id", resultadoDiversos)

        CrystalReportViewer1.ReportSource = objreporte
    End Sub
End Class