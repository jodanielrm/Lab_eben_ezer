Public Class RptHemograma


    Private Sub RptHemograma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objreporte As New CRHemograma

        objreporte.SetParameterValue("@id", resultadohemo)

        CrystalReportViewer1.ReportSource = objreporte
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class