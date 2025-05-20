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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sesuaikan dulu ukuran picturebox dan form 
        PictureBox1.Width = (map.length / (map.GetUpperBound(0) + 1)) * tsz
        PictureBox1.Height = (map.GetUpperBound(0) + 1) * tsz
        Me.Width = Width + tsz
        Me.Height = Height + tsz
        PictureBox1.Width = Width
        PictureBox1.Height = Width
        bmp = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        PictureBox1.Image = bmp
        Redraw()
    End Sub

    'kumpulan variabel 
    Dim tsz = 30        'tile size (ukuran grid/tilenya) 
    Dim pacx = 1        'pakman itu di petak x mana sekarang 
    Dim pacy = 1        '              petak y 
    Dim enmx = 9        'musuh itu di petak x berapa 
    Dim enmy = 7        '             petak y 
    Dim goalx = 1       'goal (pintu keluar pakman di petak x brp 
    Dim goaly = 7       'goal di petak y berapa 
    Dim bmp As Bitmap
    Dim oldpacx = 0
    Dim oldpacy = 0

    Dim health = 3
    Dim healthx = 1
    Dim healthy = 9  'atau 1, supaya gambar terlihat di atas PictureBox


    Dim isImmune As Boolean = False
    Dim immuneCounter As Integer = 0
    Dim immuneDuration As Integer = 10  ' hitungan Tick Timer, misal 10x interval (2 detik kalau interval 200ms)


    'deklarasi sprite citra yang digunakan 
    Dim wall As Image = Image.FromFile("..\..\..\aset_game_pakman\bata.png")
    Dim way As Image = Image.FromFile("..\..\..\aset_game_pakman\rumput.png")
    Dim pac As Image = Image.FromFile("..\..\..\aset_game_pakman\pakman.png")
    Dim pacRight As Image = Image.FromFile("..\..\..\aset_game_pakman\pakman.png")
    Dim pacLeft As Image = Image.FromFile("..\..\..\aset_game_pakman\pakman3.png")
    Dim pacUp As Image = Image.FromFile("..\..\..\aset_game_pakman\pakman4.png")
    Dim pacDown As Image = Image.FromFile("..\..\..\aset_game_pakman\pakman2.png")
    Dim enm As Image = Image.FromFile("..\..\..\aset_game_pakman\hantu3.png")
    Dim goal As Image = Image.FromFile("..\..\..\aset_game_pakman\omah.jpg")
    Dim hearth As Image = Image.FromFile("..\..\..\aset_game_pakman\heart.png")


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
        'gambarkan pacman 
        g.DrawImage(pac, pacx * tsz, pacy * tsz, tsz, tsz)
        'gambarkan musuh 
        g.DrawImage(enm, enmx * tsz, enmy * tsz, tsz, tsz)
        'gambarkan goal 
        g.DrawImage(goal, goalx * tsz, goaly * tsz, tsz, tsz)
        PictureBox1.Refresh()

        'gambarkan health pakman
        For i = 0 To health - 1
            g.DrawImage(hearth, healthx * tsz + i * tsz, healthy * tsz, tsz, tsz)
        Next


    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                If map(pacy - 1, pacx) = 1 Then
                    pac = pacUp
                    pacy = pacy - 1
                End If
            Case Keys.Down
                If map(pacy + 1, pacx) = 1 Then
                    pac = pacDown
                    pacy = pacy + 1
                End If
            Case Keys.Right
                If map(pacy, pacx + 1) = 1 Then
                    pac = pacRight
                    pacx = pacx + 1
                End If
            Case Keys.Left
                If map(pacy, pacx - 1) = 1 Then
                    pac = pacLeft
                    pacx = pacx - 1
                End If
        End Select
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim jarakx, jaraky As Integer
        Dim arah As Integer  'arah musuh, 0 atas, 1 kanan, 2 bawah, 3 kiri 
        'cek jarak pakman dg musuh. kalau lebih jauh di sb x, kejar di x dulu 
        'kalau lebih dekat di sb y, kejar ke sb y dulu 
        jarakx = Math.Abs(pacx - enmx)
        jaraky = Math.Abs(pacy - enmy)
        If jarakx > jaraky Then
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

        ' Update immuneCounter jika sedang kebal
        If isImmune Then
            immuneCounter -= 1
            If immuneCounter <= 0 Then
                isImmune = False
            End If
        End If

        ' Cek tabrakan hanya kalau tidak kebal
        If Not isImmune Then
            If (pacx = enmx) And (pacy = enmy) Then
                health -= 1
                isImmune = True
                immuneCounter = immuneDuration

                If health <= 0 Then
                    MsgBox("Pakman Dies!")
                    Timer1.Enabled = False
                End If
            End If
        End If

        'cek apakah posisi pakman sama dg rumah 
        If (pacx = goalx) And (pacy = goaly) Then
            Timer1.Enabled = False
            MsgBox("Pakman safe at Home!")
        End If

        Redraw()
    End Sub


End Class
