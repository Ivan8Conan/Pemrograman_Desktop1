Public Class FormUtama
    Private Sub AturProfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AturProfilToolStripMenuItem.Click
        Dim FormAturProfil As New Form2()
        FormAturProfil.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim FormLogout As New Form1()
        FormLogout.Show()
        Me.Hide()
    End Sub

    Private Sub LanggananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LanggananToolStripMenuItem.Click
        Dim FormLangganan As New AturParkirLangganan()
        FormLangganan.Show()
        Me.Hide()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        Dim FormLaporan As New LaporanPendapatanParkir()
        FormLaporan.Show()
        Me.Hide()
    End Sub
End Class