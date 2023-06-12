Public Class RPTQGeneral
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim objreporte As New CRQGeneral

        objreporte.SetParameterValue("@id", resultadoqg)

        CrystalReportViewer1.ReportSource = objreporte
    End Sub
End Class