Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim FormSimpanProfil As New FormUtama()
        FormSimpanProfil.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim FormCloseProfil As New FormUtama()
        FormCloseProfil.Show()
        Me.Hide()
    End Sub
End Class