Public Class AturParkirLangganan
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim FormClose As New FormUtama()
        FormClose.Show()
        Me.Hide()
    End Sub
End Class