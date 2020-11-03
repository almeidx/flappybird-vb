Public Class Form1
    Public Shared BMP As Bitmap

    Public Shared GRX As Graphics

    Public Shared _bird

    Public Shared pipeList = New List(Of Pipe)()

    Public Shared _pipe

    Public Shared counter As Double

    Public Structure Bird
        Public h
        Public vel

        Public Sub Update(force As Double, elapsedTime As Double)
            vel += force * elapsedTime
            h += vel
        End Sub
    End Structure

    Public Class Pipe
        Public x

        Public gap

        Public yOff
    End Class

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BMP = New Bitmap(MainWindow.Width, MainWindow.Height)
        GRX = Graphics.FromImage(BMP)

        ' mid = GetRandom((MainWindow.Height / 2) - 200, (MainWindow.Height / 2) + 200)
        ' gap = GetRandom(100, 200)

        _bird = New Bird() With {.h = 700, .vel = 0}

        pipeList.Add(New Pipe() With {.x = MainWindow.Width, .gap = 200, .yOff = 50})
    End Sub

    Private Sub Render_Tick(sender As Object, e As EventArgs) Handles Render.Tick
        Clear(0, 0, 0, 255)

        Dim change = Render.Interval

        _bird.Update(-20, Render.Interval / 1000)

        Text = $"Flappy Bird - FPS: {1000 / Render.Interval}"

        pipeList(0).x -= 5

        Dim rectTop = New Rectangle(pipeList(0).x, (MainWindow.Height / 2) - (pipeList(0).gap / 2) - 800 + pipeList(0).yOff, 75, 800)
        Dim rectBottom = New Rectangle(pipeList(0).x, (MainWindow.Height / 2) + (pipeList(0).gap / 2) + pipeList(0).yOff, 75, 800)
        GRX.FillRectangle(Brushes.DarkGreen, rectTop)
        GRX.FillRectangle(Brushes.DarkGreen, rectBottom)

        GRX.FillEllipse(Brushes.Red, CInt(MainWindow.Width / 2) - 25, CInt(MainWindow.Height - _bird.h), 25, 25)


        ' GRX.DrawString((MainWindow.Height - (mid - gap / 2)).ToString(), New Font("Arial", 20), Brushes.White, 0, 0)
        ' GRX.DrawString(mid.ToString(), New Font("Arial", 20), Brushes.White, 0, 30)
        ' GRX.DrawString(gap.ToString(), New Font("Arial", 20), Brushes.White, 0, 60)

        MainWindow.Image = BMP
    End Sub

    Private Sub Clear(r, g, b, a)
        Dim brush = New SolidBrush(Color.FromArgb(a, r, g, b))
        GRX.FillRectangle(brush, 0, 0, MainWindow.Width, MainWindow.Height)
    End Sub

    Public Function GetRandom(Min As Integer, Max As Integer) As Integer
        Static Generator As Random = New Random()
        Return Generator.Next(Min, Max)
    End Function

    Public Sub MyBase_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ChrW(Keys.Space) Then
            _bird.vel = 5
        End If
    End Sub
End Class
