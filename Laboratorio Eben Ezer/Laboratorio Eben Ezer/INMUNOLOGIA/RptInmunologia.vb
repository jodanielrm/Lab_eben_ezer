﻿Public Class RptInmunologia
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim objreporte As New CRInmunologia

        objreporte.SetParameterValue("@id", resultadoinmu)

        CrystalReportViewer1.ReportSource = objreporte
    End Sub
End Class