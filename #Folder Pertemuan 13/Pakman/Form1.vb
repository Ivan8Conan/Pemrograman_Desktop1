Imports System.Drawing
Imports System.Windows.Forms
Public Class Form1
    'map (peta papan permainan) 
    Dim map = {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
               {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
               {0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0},
               {0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 0},
               {0, 1, 0, 0, 0, 1, 0, 1, 1, 0, 0},
               {0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0},
               {0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0},
               {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
               {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}}
    'kumpulan variabel 
    Dim tsz = 40        'tile size (ukuran grid/tilenya) 
    Dim pacx = 1        'pakman itu di petak x mana sekarang 
    Dim pacy = 1        '              petak y 
    Dim enmx = 9        'musuh itu di petak x berapa 
    Dim enmy = 7        '             petak y 
    Dim goalx = 1       'goal (pintu keluar pakman di petak x brp 
    Dim goaly = 7       'goal di petak y berapa 
    Dim bmp As Bitmap
    Dim oldpacx = 0
    Dim oldpacy = 0

    ' Variabel untuk arah hadap pakman
    Dim pacDirection As Integer = 1  ' 0 = atas, 1 = kanan, 2 = bawah, 3 = kiri

    ' Variabel untuk nyawa
    Dim lives As Integer = 3  ' Nyawa awal Pakman

    'deklarasi sprite citra yang digunakan 
    Dim wall As Image = Image.FromFile("C:\Users\Ivan\OneDrive - Duta Wacana Christian University\SEMESTER 2\Semester 6\Pemrograman Desktop\Latihan\bata.png")
    Dim way As Image = Image.FromFile("C:\Users\Ivan\OneDrive - Duta Wacana Christian University\SEMESTER 2\Semester 6\Pemrograman Desktop\Latihan\rumput.png")

    ' Sprite Pakman dengan arah berbeda
    Dim pacUp As Image = Image.FromFile("C:\Users\Ivan\OneDrive - Duta Wacana Christian University\SEMESTER 2\Semester 6\Pemrograman Desktop\Latihan\pakman_up.png")
    Dim pacRight As Image = Image.FromFile("C:\Users\Ivan\OneDrive - Duta Wacana Christian University\SEMESTER 2\Semester 6\Pemrograman Desktop\Latihan\pakman.png")
    Dim pacDown As Image = Image.FromFile("C:\Users\Ivan\OneDrive - Duta Wacana Christian University\SEMESTER 2\Semester 6\Pemrograman Desktop\Latihan\pakman_down.png")
    Dim pacLeft As Image = Image.FromFile("C:\Users\Ivan\OneDrive - Duta Wacana Christian University\SEMESTER 2\Semester 6\Pemrograman Desktop\Latihan\pakman_left.png")

    Dim enm As Image = Image.FromFile("C:\Users\Ivan\OneDrive - Duta Wacana Christian University\SEMESTER 2\Semester 6\Pemrograman Desktop\Latihan\hantu3.png")
    Dim goal As Image = Image.FromFile("C:\Users\Ivan\OneDrive - Duta Wacana Christian University\SEMESTER 2\Semester 6\Pemrograman Desktop\Latihan\omah.jpg")

    ' Sprite untuk nyawa
    Dim lifeSprite As Image = Image.FromFile("C:\Users\Ivan\OneDrive - Duta Wacana Christian University\SEMESTER 2\Semester 6\Pemrograman Desktop\Latihan\pakman.png")

    Private Sub Redraw()
        Dim g As Graphics = Graphics.FromImage(PictureBox1.Image)
        'gambarkan background (jalan dan tembok) 
        For y = 0 To 8                   '0 to 8 yaitu tinggi map - 1 
            For x = 0 To 10              '0 to 10 yaitu lebar map - 1 
                If map(y, x) = 0 Then
                    g.DrawImage(wall, x * tsz, y * tsz, tsz, tsz)
                Else
                    g.DrawImage(way, x * tsz, y * tsz, tsz, tsz)
                End If
            Next
        Next

        'gambarkan pacman sesuai arah
        Select Case pacDirection
            Case 0 ' atas
                g.DrawImage(pacUp, pacx * tsz, pacy * tsz, tsz, tsz)
            Case 1 ' kanan
                g.DrawImage(pacRight, pacx * tsz, pacy * tsz, tsz, tsz)
            Case 2 ' bawah
                g.DrawImage(pacDown, pacx * tsz, pacy * tsz, tsz, tsz)
            Case 3 ' kiri
                g.DrawImage(pacLeft, pacx * tsz, pacy * tsz, tsz, tsz)
        End Select

        'gambarkan musuh 
        g.DrawImage(enm, enmx * tsz, enmy * tsz, tsz, tsz)

        'gambarkan goal 
        g.DrawImage(goal, goalx * tsz, goaly * tsz, tsz, tsz)

        ' Gambar nyawa Pakman di pojok kiri atas
        For i As Integer = 0 To lives - 1
            g.DrawImage(lifeSprite, CInt(i * (tsz / 2)), 0, CInt(tsz / 2), CInt(tsz / 2))
        Next

        PictureBox1.Refresh()
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                ' Ubah arah ke atas
                pacDirection = 0
                If map(pacy - 1, pacx) = 1 Then
                    pacy = pacy - 1
                End If
            Case Keys.Down
                ' Ubah arah ke bawah
                pacDirection = 2
                If map(pacy + 1, pacx) = 1 Then
                    pacy = pacy + 1
                End If
            Case Keys.Right
                ' Ubah arah ke kanan
                pacDirection = 1
                If map(pacy, pacx + 1) = 1 Then
                    pacx = pacx + 1
                End If
            Case Keys.Left
                ' Ubah arah ke kiri
                pacDirection = 3
                If map(pacy, pacx - 1) = 1 Then
                    pacx = pacx - 1
                End If
        End Select
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'sesuaikan dulu ukuran picturebox dan form 
        PictureBox1.Width = (map.length / (map.GetUpperBound(0) + 1)) * tsz
        PictureBox1.Height = (map.GetUpperBound(0) + 1) * tsz
        Me.Width = PictureBox1.Width + tsz
        Me.Height = PictureBox1.Height + tsz  ' Ukuran form tidak perlu ditambah banyak karena nyawa sekarang di atas
        bmp = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        PictureBox1.Image = bmp
        Redraw()
    End Sub

    ' Prosedur untuk mereset posisi Pakman dan musuh
    Private Sub ResetPositions()
        ' Kembalikan Pakman ke posisi awal
        pacx = 1
        pacy = 1
        pacDirection = 1  ' Menghadap kanan

        ' Kembalikan musuh ke posisi awal
        enmx = 9
        enmy = 7
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'engine untuk musuh 
        Dim jarakx, jaraky As Integer
        Dim arah As Integer  'arah musuh, 0 atas, 1 kanan, 2 bawah, 3 kiri 
        'cek jarak pakman dg musuh. kalau lebih jauh di sb x, kejar di x dulu 
        'kalau lebih dekat di sb y, kejar ke sb y dulu 
        jarakx = Math.Abs(pacx - enmx)
        jaraky = Math.Abs(pacy - enmy)
        If jarakx > jaraky Then         'jika lebih jauh jarak kejar di x
            If (pacx - enmx > 0) Then   'jika pakman di kanan 
                arah = 1                'arah kanan 
            Else                        'jika tidak 
                arah = 3                'arah kiri 
            End If
        End If
        If jarakx < jaraky Then
            If (pacy - enmy > 0) Then   'jika pakman di bawah 
                arah = 2                'arah bawah 
            Else                        'jika tidak 
                arah = 0                'arah atas 
            End If
        End If
        If (oldpacx = pacx) And (oldpacy = pacy) Then  'jika stop 
            arah = Math.Floor(Rnd() * 4)
        End If
        Select Case arah
            Case 0
                If map(enmy - 1, enmx) = 1 Then
                    enmy = enmy - 1
                End If
            Case 2
                If map(enmy + 1, enmx) = 1 Then
                    enmy = enmy + 1
                End If
            Case 1
                If map(enmy, enmx + 1) = 1 Then
                    enmx = enmx + 1
                End If
            Case 3
                If map(enmy, enmx - 1) = 1 Then
                    enmx = enmx - 1
                End If
        End Select
        oldpacx = pacx
        oldpacy = pacy
        Redraw()

        'cek apakah posisi pakman sama dg musuh 
        If (pacx = enmx) And (pacy = enmy) Then
            lives = lives - 1  ' Kurangi nyawa
            If lives <= 0 Then
                Timer1.Enabled = False
                MsgBox("Pakman Dies! Game Over!")
            Else
                MsgBox("Pakman tertangkap! Nyawa tersisa: " & lives)
                ResetPositions()
            End If
        End If

        If (pacx = goalx) And (pacy = goaly) Then
            Timer1.Enabled = False
            MsgBox("Pakman safe at Home!")
        End If
    End Sub
End Class