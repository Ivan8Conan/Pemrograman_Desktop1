﻿Imports System.Drawing.Drawing2D

Public Class frmUtama
    Dim modegambar As String
    Dim warnatepi As Color = Color.Black
    Dim warnaisian As Color = Color.White
    Dim tepi As New System.Drawing.Pen(warnatepi, 3)
    Dim isian As New System.Drawing.SolidBrush(warnaisian)
    Dim titik As Point = Nothing
    Dim dipencet As Boolean = False
    Dim bmp As Bitmap
    Dim history As New Stack(Of Bitmap)


    Private Sub frmUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnBersihkan.PerformClick()
        tepi.EndCap = LineCap.Round
    End Sub

    Private Sub RadioBebas_CheckedChanged(sender As Object, e As EventArgs) Handles RadioBebas.CheckedChanged
        modegambar = "bebas"
    End Sub

    Private Sub RadioGaris_CheckedChanged(sender As Object, e As EventArgs) Handles RadioGaris.CheckedChanged
        modegambar = "garis"
    End Sub

    Private Sub RadioKotak_CheckedChanged(sender As Object, e As EventArgs) Handles RadioKotak.CheckedChanged
        modegambar = "kotak"
    End Sub

    Private Sub RadioElips_CheckedChanged(sender As Object, e As EventArgs) Handles RadioElips.CheckedChanged
        modegambar = "elips"
    End Sub

    Private Sub RadioKotakIsi_CheckedChanged(sender As Object, e As EventArgs) Handles RadioKotakIsi.CheckedChanged
        modegambar = "kotakisi"
    End Sub

    Private Sub RadioElipsIsi_CheckedChanged(sender As Object, e As EventArgs) Handles RadioElipsIsi.CheckedChanged
        modegambar = "elipsisi"
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        tepi.Width = NumericUpDown1.Value
    End Sub

    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        SimpanKeHistory()
        tepi.Color = warnatepi
        isian.Color = warnaisian
        titik = e.Location
        dipencet = True
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        Select Case modegambar
            Case "bebas"
                If dipencet Then
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.DrawLine(tepi, titik, e.Location)
                    End Using
                    PictureBox1.Invalidate()
                    TextBox1.AppendText("o " + "warnatepi" + " " + warnatepi.R.ToString + " " + warnatepi.G.ToString + " " + warnatepi.B.ToString & vbNewLine)
                    TextBox1.AppendText("o garis " + titik.X.ToString + " " + titik.Y.ToString + " " + e.X.ToString + " " + e.Y.ToString & vbNewLine)
                    titik = e.Location
                End If
        End Select
    End Sub

    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        SimpanKeHistory()
        Select Case modegambar
            Case "garis"
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.DrawLine(tepi, titik, e.Location)
                End Using
            Case "kotak"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.DrawRectangle(tepi, rect)
                End Using
            Case "elips"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.DrawEllipse(tepi, rect)
                End Using
            Case "kotakisi"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.FillRectangle(isian, rect)
                End Using
            Case "elipsisi"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.FillEllipse(isian, rect)
                End Using
        End Select
        PictureBox1.Invalidate()
        dipencet = False
        dipencet = False
        'If (titik.X <> e.X And titik.Y <> e.Y) Then
        '    TextBox1.AppendText("o " + "warnatepi" + " " + warnatepi.R.ToString + " " + warnatepi.G.ToString + " " + warnatepi.B.ToString & vbNewLine)
        '    TextBox1.AppendText("o " + "warnaisian" + " " + warnaisian.R.ToString + " " + warnaisian.G.ToString + " " + warnaisian.B.ToString & vbNewLine)
        '    TextBox1.AppendText("o " + modegambar + " " + titik.X.ToString + " " + titik.Y.ToString + " " + e.X.ToString + " " + e.Y.ToString & vbNewLine)
        'End If
        If (titik.X <> e.X And titik.Y <> e.Y) Then
            TextBox1.AppendText("o " + "warnatepi" + " " + warnatepi.R.ToString + " " + warnatepi.G.ToString + " " + warnatepi.B.ToString & vbNewLine)
            TextBox1.AppendText("o " + "warnaisian" + " " + warnaisian.R.ToString + " " + warnaisian.G.ToString + " " + warnaisian.B.ToString & vbNewLine)
            TextBox1.AppendText("o " + modegambar + " " + titik.X.ToString + " " + titik.Y.ToString + " " + e.X.ToString + " " + e.Y.ToString & vbNewLine)
            TextBox1.AppendText("o " + "ukuran" + " " + tepi.Width.ToString() & vbNewLine) ' Menyimpan ukuran garis tepi
        End If
    End Sub

    Private Sub Warna1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna1.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna1.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = Warna1.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub Warna2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna2.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna2.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = Warna2.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub Warna3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna3.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna3.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = Warna3.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub Warna4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna4.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna4.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = Warna4.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub Warna5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna5.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna5.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = Warna5.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub Warna6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna6.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna6.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = Warna6.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
        bmp = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Color.White)
        End Using
        PictureBox1.Image = bmp
    End Sub

    Private Sub btnGbrUlang_Click(sender As Object, e As EventArgs) Handles btnGbrUlang.Click
        Dim a As Integer = TextBox1.Lines.Count
        For i As Integer = 0 To a
            Dim teksbaris As String = TextBox1.Lines(i)
            Dim pecah() As String
            pecah = teksbaris.Split(" "c)
            On Error Resume Next
            pecah(1) = pecah(1).Trim(" "c)
            Select Case pecah(1)
                Case "warnatepi"
                    warnatepi = Color.FromArgb(CByte(pecah(2)), CByte(pecah(3)), CByte(pecah(4)))
                    tepi.Color = warnatepi
                Case "warnaisian"
                    warnaisian = Color.FromArgb(CByte(pecah(2)), CByte(pecah(3)), CByte(pecah(4)))
                    isian.Color = warnaisian
                Case "garis"
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.DrawLine(tepi, CInt(pecah(2)), CInt(pecah(3)), CInt(pecah(4)), CInt(pecah(5)))
                    End Using
                Case "kotak"
                    Dim rect As New Rectangle(CInt(pecah(2)), CInt(pecah(3)), CInt(pecah(4)) - CInt(pecah(2)), CInt(pecah(5)) - CInt(pecah(3)))
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.DrawRectangle(tepi, rect)
                    End Using
                Case "elips"
                    Dim rect As New Rectangle(CInt(pecah(2)), CInt(pecah(3)), CInt(pecah(4)) - CInt(pecah(2)), CInt(pecah(5)) - CInt(pecah(3)))
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.DrawEllipse(tepi, rect)
                    End Using
                Case "kotakisi"
                    Dim rect As New Rectangle(CInt(pecah(2)), CInt(pecah(3)), CInt(pecah(4)) - CInt(pecah(2)), CInt(pecah(5)) - CInt(pecah(3)))
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.FillRectangle(isian, rect)
                    End Using
                Case "elipsisi"
                    Dim rect As New Rectangle(CInt(pecah(2)), CInt(pecah(3)), CInt(pecah(4)) - CInt(pecah(2)), CInt(pecah(5)) - CInt(pecah(3)))
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.FillEllipse(isian, rect)
                    End Using
            End Select
        Next
        PictureBox1.Invalidate()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub SimpanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanToolStripMenuItem.Click
        Dim simpanDialog As New SaveFileDialog()
        simpanDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp"
        simpanDialog.Title = "Simpan Gambar"

        If simpanDialog.ShowDialog() = DialogResult.OK Then
            Dim path As String = simpanDialog.FileName
            Try
                Dim format As Imaging.ImageFormat = Imaging.ImageFormat.Png
                Select Case System.IO.Path.GetExtension(path).ToLower()
                    Case ".jpg", ".jpeg"
                        format = Imaging.ImageFormat.Jpeg
                    Case ".bmp"
                        format = Imaging.ImageFormat.Bmp
                End Select
                PictureBox1.Image.Save(path, format)
                MessageBox.Show("Gambar berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan saat menyimpan gambar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub SimpanKeHistory()
        If PictureBox1.Image IsNot Nothing Then
            history.Push(New Bitmap(PictureBox1.Image))
        End If
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        If TextBox1.Lines.Length = 0 Then
            MessageBox.Show("Tidak ada aksi yang bisa di-undo.", "Undo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim lines As List(Of String) = TextBox1.Lines.ToList()
        Dim jumlahBarisDihapus As Integer = 0

        For i As Integer = lines.Count - 1 To 0 Step -1
            jumlahBarisDihapus += 1
            Dim baris = lines(i)
            If baris.StartsWith("o ") Then
                Dim kata() = baris.Split(" "c)
                If kata.Length > 1 Then
                    Select Case kata(1)
                        Case "garis", "kotak", "kotakisi", "elips", "elipsisi"
                            Exit For
                    End Select
                End If
            End If
        Next

        lines.RemoveRange(lines.Count - jumlahBarisDihapus, jumlahBarisDihapus)
        TextBox1.Lines = lines.ToArray()

        btnBersihkan.PerformClick()
        btnGbrUlang.PerformClick()
    End Sub

    Private Sub BukaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaToolStripMenuItem.Click
        Dim openDialog As New OpenFileDialog()
        openDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp"
        openDialog.Title = "Buka Gambar"

        If openDialog.ShowDialog() = DialogResult.OK Then
            Try
                Dim path As String = openDialog.FileName
                bmp = New Bitmap(path)
                PictureBox1.Image = bmp

                history.Clear()
                TextBox1.Clear()
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan saat membuka gambar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class
