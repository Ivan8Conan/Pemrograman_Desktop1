Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport
        Me.ReportViewer3.RefreshReport
        Me.ReportViewer1.RefreshReport
    End Sub
End Class