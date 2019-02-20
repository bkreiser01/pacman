Public Class Form1
    Private Pacman_Left As Boolean = True
    Private Off As Boolean = True
    Private Ghosts_Scared As Boolean = False
    Private Red_Eaten As Boolean = False
    Private Blue_Eaten As Boolean = False
    Private Pink_Eaten As Boolean = False
    Private Orange_Eaten As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load.Start()
    End Sub

    Private Sub Load_Tick(sender As Object, e As EventArgs) Handles Load.Tick
        Static Counter As Integer
        Select Case Counter
            Case = 1
                picRed_Static.Visible = True
            Case = 2
                lblShadow.Visible = True
            Case = 3
                lblBlinky.Visible = True
            Case = 4
                picPink_Static.Visible = True
            Case = 5
                lblSpeedy.Visible = True
            Case = 6
                lblPinky.Visible = True
            Case = 7
                picBlue_Static.Visible = True
            Case = 8
                lblBashful.Visible = True
            Case = 9
                lblInky.Visible = True
            Case = 10
                picOrange_Static.Visible = True
            Case = 11
                lblPokey.Visible = True
            Case = 12
                lblClide.Visible = True
            Case = 13
                picDot.Visible = True
                picPowerup_Static.Visible = True
                lbl10.Visible = True
                lbl10pts.Visible = True
                lbl50.Visible = True
                lbl50pts.Visible = True
            Case = 14
                lblMidway.Visible = True
                pic_Powerup.Visible = True
                Animation()
                Load.Stop()
        End Select
        Counter = Counter + 1
    End Sub

    Private Sub Animation()
        Blinking.Start()
        picPacman.Visible = True
        tmrPacman.Start()
        picRed.Visible = True
        picBlue.Visible = True
        picPink.Visible = True
        picOrange.Visible = True
        tmrGhosts.Start()
    End Sub

    Private Sub Blinking_Tick(sender As Object, e As EventArgs) Handles Blinking.Tick
        Static Shown As Boolean = True
        If Shown = True Then
            picPowerup_Static.Visible = True
            If Off = True Then
                pic_Powerup.Visible = True
            End If
            Shown = False
        ElseIf Shown = False Then
            picPowerup_Static.Visible = False
            If Off = True Then
                pic_Powerup.Visible = False
            End If
            Shown = True
        End If
    End Sub

    Private Sub tmrPacman_Tick(sender As Object, e As EventArgs) Handles tmrPacman.Tick
        Static Open As Boolean

        Collison()

        If Open = False Then
            If Pacman_Left = True Then
                picPacman.Left -= 10
                picPacman.Image = My.Resources.Pacman_Open_Left
                Open = True
            ElseIf Pacman_Left = False Then
                picPacman.Left += 10
                picPacman.Image = My.Resources.Pacman_Open_Right
                Open = True
            End If
        ElseIf Open = True Then
            If Pacman_Left = True Then
                picPacman.Left -= 10
                picPacman.Image = My.Resources.Pacman_Closed
                Open = False
            ElseIf Pacman_Left = False Then
                picPacman.Left += 10
                picPacman.Image = My.Resources.Pacman_Closed
                Open = False
            End If
        End If
    End Sub

    Private Sub tmrGhosts_Tick(sender As Object, e As EventArgs) Handles tmrGhosts.Tick
        Static Open As Boolean = True
        If Ghosts_Scared = False Then
            picRed.Left -= 10
            picBlue.Left -= 10
            picPink.Left -= 10
            picOrange.Left -= 10
            If Open = True Then
                picRed.Image = My.Resources.Red_Ghost_Left_Closed
                picBlue.Image = My.Resources.Blue_Ghost_Left_Closed
                picPink.Image = My.Resources.Pink_Ghost_Left_Closed
                picOrange.Image = My.Resources.Orange_Ghost_Left_Closed
                Open = False
            ElseIf Open = False Then
                picRed.Image = My.Resources.Red_Ghost_Left_Open
                picBlue.Image = My.Resources.Blue_Ghost_Left_Open
                picPink.Image = My.Resources.Pink_Ghost_Left_Open
                picOrange.Image = My.Resources.Orange_Ghost_Left_Open
                Open = True
            End If
        End If
        If Ghosts_Scared = True Then
            picRed.Left += 10
            picBlue.Left += 10
            picPink.Left += 10
            picOrange.Left += 10
            If Open = True Then
                picRed.Image = My.Resources.Scared_Closed_Blue
                picBlue.Image = My.Resources.Scared_Closed_Blue
                picPink.Image = My.Resources.Scared_Closed_Blue
                picOrange.Image = My.Resources.Scared_Closed_Blue
                Open = False
            ElseIf Open = False Then
                picRed.Image = My.Resources.Scared_Open_Blue
                picBlue.Image = My.Resources.Scared_Open_Blue
                picPink.Image = My.Resources.Scared_Open_Blue
                picOrange.Image = My.Resources.Scared_Open_Blue
                Open = True
            End If
        End If
    End Sub

    Private Sub Collison()
        If picPacman.Bounds.IntersectsWith(pic_Powerup.Bounds) Then
            pic_Powerup.Visible = False
            Pacman_Left = False
            Off = False
            Ghosts_Scared = True
            tmrGhosts.Interval = 120
        End If

        If Red_Eaten = False Then
            If picPacman.Bounds.IntersectsWith(picRed.Bounds) Then
                Red_Eaten = True
                tmrPacman.Stop()
                tmrGhosts.Stop()
                lblScore.Text = "200"
                lblScore.Location = picRed.Location
                lblScore.Visible = True
                picPacman.Visible = False
                picRed.Visible = False
                tmrWait.Start()
            End If
        End If
        If Pink_Eaten = False Then
            If picPacman.Bounds.IntersectsWith(picPink.Bounds) Then
                Pink_Eaten = True
                tmrPacman.Stop()
                tmrGhosts.Stop()
                lblScore.Text = "400"
                lblScore.Location = picPink.Location
                lblScore.Visible = True
                picPacman.Visible = False
                picPink.Visible = False
                tmrWait.Start()
            End If
        End If

        If Blue_Eaten = False Then
            If picPacman.Bounds.IntersectsWith(picBlue.Bounds) Then
                Blue_Eaten = True
                tmrPacman.Stop()
                tmrGhosts.Stop()
                lblScore.Text = "800"
                lblScore.Location = picBlue.Location
                lblScore.Visible = True
                picPacman.Visible = False
                picBlue.Visible = False
                tmrWait.Start()
            End If
        End If

        If Orange_Eaten = False Then
            If picPacman.Bounds.IntersectsWith(picOrange.Bounds) Then
                Orange_Eaten = True
                tmrPacman.Stop()
                tmrGhosts.Stop()
                lblScore.Text = "1600"
                lblScore.Location = picOrange.Location
                lblScore.Visible = True
                picPacman.Visible = False
                picOrange.Visible = False
                tmrWait.Start()
                tmrPacman.Stop()
                Move.Start()
            End If
        End If
    End Sub

    Private Sub tmrWait_Tick(sender As Object, e As EventArgs) Handles tmrWait.Tick
        tmrGhosts.Start()
        tmrPacman.Start()
        lblScore.Visible = False
        picPacman.Visible = True
    End Sub

    Private Sub Move_Tick(sender As Object, e As EventArgs) Handles Move.Tick
        Me.Hide()
        Start_Screen_2.Show()
        Move.Stop()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        tmrPacman.Stop()
        Load.Stop()
        Me.Hide()
        Start_Screen_2.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
