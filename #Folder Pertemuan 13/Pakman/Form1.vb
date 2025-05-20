Imports System.Drawing
Imports System.Windows.Forms
Public Class Form1
    'map (peta papan permainan) - diperluas untuk 3 hantu
    Dim map = {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
               {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
               {0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0},
               {0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0},
               {0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0},
               {0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0},
               {0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0},
               {0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0},
               {0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0},
               {0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0},
               {0, 1, 1, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 1, 0},
               {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}}

    'kumpulan variabel 
    Dim tsz = 40        'tile size (ukuran grid/tilenya) 
    Dim pacx = 1        'pakman itu di petak x mana sekarang 
    Dim pacy = 1        '              petak y 

    ' Array untuk posisi hantu (x, y) dan mode pergerakan
    ' Mode: 0 = normal chase, 1 = random, 2 = patrol
    Dim ghosts(2, 2) As Integer

    Dim goalx = 13      'goal (pintu keluar pakman di petak x brp 
    Dim goaly = 10      'goal di petak y berapa 
    Dim bmp As Bitmap
    Dim oldpacx = 0
    Dim oldpacy = 0

    ' Variabel untuk mode hantu dan waktu pergantian mode
    Dim ghostModeTicks As Integer = 0
    Dim ghostModeInterval As Integer = 30 ' Ganti mode setiap 30 tick

    ' Variabel untuk arah hadap pakman
    Dim pacDirection As Integer = 1  ' 0 = atas, 1 = kanan, 2 = bawah, 3 = kiri

    ' Variabel untuk nyawa
    Dim lives As Integer = 3  ' Nyawa awal Pakman

    ' Variabel untuk patrol pattern hantu
    Dim patrolPointIndex(2) As Integer
    Dim patrolPoints As New List(Of Point())

    ' Flag untuk menandai apakah game sedang dimulai ulang
    Dim isRestarting As Boolean = False

    'deklarasi sprite citra yang digunakan 
    Dim wall As Image = Image.FromFile("C:\Users\Ivan\OneDrive - Duta Wacana Christian University\SEMESTER 2\Semester 6\Pemrograman Desktop\Latihan\bata.png")
    Dim way As Image = Image.FromFile("C:\Users\Ivan\OneDrive - Duta Wacana Christian University\SEMESTER 2\Semester 6\Pemrograman Desktop\Latihan\rumput.png")

    ' Sprite Pakman dengan arah berbeda
    Dim pacUp As Image = Image.FromFile("C:\Users\Ivan\OneDrive - Duta Wacana Christian University\SEMESTER 2\Semester 6\Pemrograman Desktop\Latihan\pakman_up.png")
    Dim pacRight As Image = Image.FromFile("C:\Users\Ivan\OneDrive - Duta Wacana Christian University\SEMESTER 2\Semester 6\Pemrograman Desktop\Latihan\pakman.png")
    Dim pacDown As Image = Image.FromFile("C:\Users\Ivan\OneDrive - Duta Wacana Christian University\SEMESTER 2\Semester 6\Pemrograman Desktop\Latihan\pakman_down.png")
    Dim pacLeft As Image = Image.FromFile("C:\Users\Ivan\OneDrive - Duta Wacana Christian University\SEMESTER 2\Semester 6\Pemrograman Desktop\Latihan\pakman_left.png")

    ' Array untuk sprite hantu (berbeda warna)
    Dim ghostSprites(2) As Image
    Dim goal As Image = Image.FromFile("C:\Users\Ivan\OneDrive - Duta Wacana Christian University\SEMESTER 2\Semester 6\Pemrograman Desktop\Latihan\omah.jpg")

    ' Sprite untuk nyawa
    Dim lifeSprite As Image = Image.FromFile("C:\Users\Ivan\OneDrive - Duta Wacana Christian University\SEMESTER 2\Semester 6\Pemrograman Desktop\Latihan\pakman.png")

    Private Sub InitializePatrolPoints()
        ' Definisikan jalur patroli untuk masing-masing hantu
        patrolPoints.Add(New Point() {
            New Point(13, 1), New Point(13, 7), New Point(7, 7), New Point(7, 1)
        })

        patrolPoints.Add(New Point() {
            New Point(1, 10), New Point(6, 10), New Point(6, 5), New Point(1, 5)
        })

        patrolPoints.Add(New Point() {
            New Point(1, 1), New Point(13, 1), New Point(13, 10), New Point(1, 10)
        })

        ' Inisialisasi indeks patrol untuk tiap hantu
        For i As Integer = 0 To 2
            patrolPointIndex(i) = 0
        Next
    End Sub

    Private Sub Redraw()
        Dim g As Graphics = Graphics.FromImage(PictureBox1.Image)
        g.Clear(Color.Black)

        ' Dapatkan dimensi peta (rows & columns)
        Dim rows As Integer = map.GetUpperBound(0) + 1
        Dim cols As Integer = map.GetUpperBound(1) + 1

        'gambarkan background (jalan dan tembok) 
        For y As Integer = 0 To rows - 1
            For x As Integer = 0 To cols - 1
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

        'gambarkan hantu-hantu
        For i As Integer = 0 To 2
            g.DrawImage(ghostSprites(i), ghosts(i, 0) * tsz, ghosts(i, 1) * tsz, tsz, tsz)
        Next

        'gambarkan goal 
        g.DrawImage(goal, goalx * tsz, goaly * tsz, tsz, tsz)

        ' Gambar nyawa Pakman di pojok kiri atas
        For i As Integer = 0 To lives - 1
            g.DrawImage(lifeSprite, CInt(i * (tsz / 2)), 0, CInt(tsz / 2), CInt(tsz / 2))
        Next

        PictureBox1.Refresh()
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If isRestarting Then Return ' Jangan proses input saat restarting

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
        ' Load sprite hantu
        ghostSprites(0) = Image.FromFile("C:\Users\Ivan\OneDrive - Duta Wacana Christian University\SEMESTER 2\Semester 6\Pemrograman Desktop\Latihan\hantu1.png")
        ghostSprites(1) = Image.FromFile("C:\Users\Ivan\OneDrive - Duta Wacana Christian University\SEMESTER 2\Semester 6\Pemrograman Desktop\Latihan\hantu2.png")
        ghostSprites(2) = Image.FromFile("C:\Users\Ivan\OneDrive - Duta Wacana Christian University\SEMESTER 2\Semester 6\Pemrograman Desktop\Latihan\hantu3.png")

        ' Inisialisasi posisi hantu dan mode pergerakannya
        ghosts(0, 0) = 13 ' x
        ghosts(0, 1) = 1  ' y
        ghosts(0, 2) = 0  ' mode (chase)

        ghosts(1, 0) = 13 ' x
        ghosts(1, 1) = 5  ' y
        ghosts(1, 2) = 1  ' mode (random)

        ghosts(2, 0) = 13 ' x
        ghosts(2, 1) = 10 ' y
        ghosts(2, 2) = 2  ' mode (patrol)

        ' Inisialisasi patrol points untuk hantu
        InitializePatrolPoints()

        ' Sesuaikan ukuran picturebox dan form berdasarkan ukuran peta
        Dim rows As Integer = map.GetUpperBound(0) + 1
        Dim cols As Integer = map.GetUpperBound(1) + 1

        PictureBox1.Width = cols * tsz
        PictureBox1.Height = rows * tsz
        Me.Width = PictureBox1.Width + tsz
        Me.Height = PictureBox1.Height + tsz + 40 ' Tambahkan ruang untuk title bar dan statusbar

        bmp = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        PictureBox1.Image = bmp

        ' Set judul form
        Me.Text = "Pakman Game - 3 Ghosts"

        ' Aktifkan timer
        Timer1.Enabled = True
        Timer1.Interval = 200 ' Set interval timer (ms)

        Redraw()
    End Sub

    ' Prosedur untuk mereset posisi Pakman dan hantu
    Private Sub ResetPositions()
        isRestarting = True

        ' Kembalikan Pakman ke posisi awal
        pacx = 1
        pacy = 1
        pacDirection = 1  ' Menghadap kanan

        ' Kembalikan hantu ke posisi awal
        ghosts(0, 0) = 13 ' x
        ghosts(0, 1) = 1  ' y

        ghosts(1, 0) = 13 ' x
        ghosts(1, 1) = 5  ' y

        ghosts(2, 0) = 13 ' x
        ghosts(2, 1) = 10 ' y

        ' Tunggu sebentar
        System.Threading.Thread.Sleep(500)

        isRestarting = False
    End Sub

    ' Fungsi untuk mengecek apakah arah gerakan valid untuk hantu
    Private Function IsValidMove(ByVal y As Integer, ByVal x As Integer) As Boolean
        If y < 0 OrElse y >= map.GetUpperBound(0) + 1 OrElse x < 0 OrElse x >= map.GetUpperBound(1) + 1 Then
            Return False
        End If
        Return map(y, x) = 1
    End Function

    ' Fungsi untuk mendapatkan daftar arah yang valid dari posisi tertentu
    Private Function GetValidDirections(ByVal y As Integer, ByVal x As Integer) As List(Of Integer)
        Dim validDirections As New List(Of Integer)

        ' Cek semua arah (0=atas, 1=kanan, 2=bawah, 3=kiri)
        If IsValidMove(y - 1, x) Then validDirections.Add(0) ' Atas
        If IsValidMove(y, x + 1) Then validDirections.Add(1) ' Kanan
        If IsValidMove(y + 1, x) Then validDirections.Add(2) ' Bawah
        If IsValidMove(y, x - 1) Then validDirections.Add(3) ' Kiri

        Return validDirections
    End Function

    ' Fungsi untuk menghitung jarak Manhattan antara dua titik
    Private Function ManhattanDistance(ByVal x1 As Integer, ByVal y1 As Integer, ByVal x2 As Integer, ByVal y2 As Integer) As Integer
        Return Math.Abs(x1 - x2) + Math.Abs(y1 - y2)
    End Function

    ' Fungsi untuk menggerakkan hantu dengan mode chase
    Private Sub MoveGhostChase(ByVal ghostIndex As Integer)
        Dim x As Integer = ghosts(ghostIndex, 0)
        Dim y As Integer = ghosts(ghostIndex, 1)

        ' Dapatkan daftar arah yang valid
        Dim validDirections As List(Of Integer) = GetValidDirections(y, x)

        ' Jika tidak ada arah yang valid, hantu tidak bergerak
        If validDirections.Count = 0 Then Return

        ' Cari arah terbaik untuk mengejar Pakman
        Dim bestDirection As Integer = validDirections(0)
        Dim shortestDistance As Integer = Integer.MaxValue

        For Each direction As Integer In validDirections
            Dim newX As Integer = x
            Dim newY As Integer = y

            Select Case direction
                Case 0 ' Atas
                    newY -= 1
                Case 1 ' Kanan
                    newX += 1
                Case 2 ' Bawah
                    newY += 1
                Case 3 ' Kiri
                    newX -= 1
            End Select

            ' Hitung jarak ke Pakman dari posisi baru
            Dim distance As Integer = ManhattanDistance(newX, newY, pacx, pacy)

            ' Jika jarak lebih dekat, simpan arah ini
            If distance < shortestDistance Then
                shortestDistance = distance
                bestDirection = direction
            End If
        Next

        ' Gerakkan hantu ke arah terbaik
        Select Case bestDirection
            Case 0 ' Atas
                ghosts(ghostIndex, 1) -= 1
            Case 1 ' Kanan
                ghosts(ghostIndex, 0) += 1
            Case 2 ' Bawah
                ghosts(ghostIndex, 1) += 1
            Case 3 ' Kiri
                ghosts(ghostIndex, 0) -= 1
        End Select
    End Sub

    ' Fungsi untuk menggerakkan hantu dengan mode random
    Private Sub MoveGhostRandom(ByVal ghostIndex As Integer)
        Dim x As Integer = ghosts(ghostIndex, 0)
        Dim y As Integer = ghosts(ghostIndex, 1)

        ' Dapatkan daftar arah yang valid
        Dim validDirections As List(Of Integer) = GetValidDirections(y, x)

        ' Jika tidak ada arah yang valid, hantu tidak bergerak
        If validDirections.Count = 0 Then Return

        ' Pilih arah secara acak
        Dim random As New Random()
        Dim randomIndex As Integer = random.Next(0, validDirections.Count)
        Dim direction As Integer = validDirections(randomIndex)

        ' Gerakkan hantu ke arah acak
        Select Case direction
            Case 0 ' Atas
                ghosts(ghostIndex, 1) -= 1
            Case 1 ' Kanan
                ghosts(ghostIndex, 0) += 1
            Case 2 ' Bawah
                ghosts(ghostIndex, 1) += 1
            Case 3 ' Kiri
                ghosts(ghostIndex, 0) -= 1
        End Select
    End Sub

    Private Sub MoveGhostPatrol(ByVal ghostIndex As Integer)
        Dim x As Integer = ghosts(ghostIndex, 0)
        Dim y As Integer = ghosts(ghostIndex, 1)

        ' Dapatkan titik tujuan patroli saat ini
        Dim target As Point = patrolPoints(ghostIndex)(patrolPointIndex(ghostIndex))

        ' Jika hantu sudah di titik tujuan, beralih ke titik berikutnya
        If x = target.X AndAlso y = target.Y Then
            patrolPointIndex(ghostIndex) = (patrolPointIndex(ghostIndex) + 1) Mod patrolPoints(ghostIndex).Length
            target = patrolPoints(ghostIndex)(patrolPointIndex(ghostIndex))
        End If

        ' Dapatkan daftar arah yang valid
        Dim validDirections As List(Of Integer) = GetValidDirections(y, x)

        ' Jika tidak ada arah yang valid, hantu tidak bergerak
        If validDirections.Count = 0 Then Return

        ' Cari arah terbaik untuk menuju titik patroli
        Dim bestDirection As Integer = validDirections(0)
        Dim shortestDistance As Integer = Integer.MaxValue

        For Each direction As Integer In validDirections
            Dim newX As Integer = x
            Dim newY As Integer = y

            Select Case direction
                Case 0 ' Atas
                    newY -= 1
                Case 1 ' Kanan
                    newX += 1
                Case 2 ' Bawah
                    newY += 1
                Case 3 ' Kiri
                    newX -= 1
            End Select

            Dim distance As Integer = ManhattanDistance(newX, newY, target.X, target.Y)

            If distance < shortestDistance Then
                shortestDistance = distance
                bestDirection = direction
            End If
        Next

        ' Gerakkan hantu ke arah terbaik
        Select Case bestDirection
            Case 0 ' Atas
                ghosts(ghostIndex, 1) -= 1
            Case 1 ' Kanan
                ghosts(ghostIndex, 0) += 1
            Case 2 ' Bawah
                ghosts(ghostIndex, 1) += 1
            Case 3 ' Kiri
                ghosts(ghostIndex, 0) -= 1
        End Select
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If isRestarting Then Return

        ghostModeTicks += 1

        ' Ganti mode hantu secara periodik untuk variasi
        If ghostModeTicks >= ghostModeInterval Then
            ghostModeTicks = 0
            ghosts(0, 2) = (ghosts(0, 2) + 1) Mod 3
            ghosts(1, 2) = (ghosts(1, 2) + 1) Mod 3
            ghosts(2, 2) = (ghosts(2, 2) + 1) Mod 3
        End If

        ' Gerakkan hantu-hantu berdasarkan modenya
        For i As Integer = 0 To 2
            Select Case ghosts(i, 2)
                Case 0 ' Chase mode
                    MoveGhostChase(i)
                Case 1 ' Random mode
                    MoveGhostRandom(i)
                Case 2 ' Patrol mode
                    MoveGhostPatrol(i)
            End Select
        Next

        oldpacx = pacx
        oldpacy = pacy
        Redraw()

        ' Cek apakah Pakman tertangkap oleh salah satu hantu
        For i As Integer = 0 To 2
            If (pacx = ghosts(i, 0)) And (pacy = ghosts(i, 1)) Then
                lives = lives - 1

                If lives <= 0 Then
                    Timer1.Enabled = False
                    MsgBox("Pakman Dies! Game Over!")
                Else
                    MsgBox("Pakman tertangkap! Nyawa tersisa: " & lives)
                    ResetPositions()
                    Return
                End If
            End If
        Next

        ' Cek apakah Pakman mencapai goal
        If (pacx = goalx) And (pacy = goaly) Then
            Timer1.Enabled = False
            MsgBox("Pakman safe at Home!")
        End If
    End Sub
End Class