Public Class Gameboard
    'Lives and Levels
    Private Score As Integer = 0
    Private Lifes As Integer = 5
    Private Level As Integer = 1
    'Pacman
    Private Pacman_Up As Boolean = False
    Private Pacman_Down As Boolean = False
    Private Pacman_Right As Boolean = False
    Private Pacman_Left As Boolean = True
    Private Pacman_Up_Locked As Boolean = True
    Private Pacman_Down_Locked As Boolean = True
    Private Pacman_Right_Locked As Boolean = False
    Private Pacman_Left_Locked As Boolean = False
    Private Pacman_Key_Up As Boolean = False
    Private Pacman_Key_Down As Boolean = False
    Private Pacman_Key_Right As Boolean = False
    Private Pacman_Key_Left As Boolean = True
    Private Pacman_Able_Left_Right = True
    Private Pacman_Able_Up_Down = False
    'Red Ghost
    Private Red_Up As Boolean = False
    Private Red_Down As Boolean = False
    Private Red_Right As Boolean = False
    Private Red_Left As Boolean = False
    Private Red_Home As Boolean = False
    Private Red_Leave As Boolean = False
    Private Red_Scared As Boolean = False
    'Pink Ghost
    Private Pink_Up As Boolean = False
    Private Pink_Down As Boolean = False
    Private Pink_Right As Boolean = False
    Private Pink_Left As Boolean = False
    Private Pink_Home As Boolean = True
    Private Pink_Leave As Boolean = False
    Private Pink_Scared As Boolean = False
    'Blue Ghost
    Private Blue_Up As Boolean = False
    Private Blue_Down As Boolean = False
    Private Blue_Right As Boolean = False
    Private Blue_Left As Boolean = False
    Private Blue_Home As Boolean = True
    Private Blue_Leave As Boolean = False
    Private Blue_Scared As Boolean = False
    'Orange Ghost
    Private Orange_Up As Boolean = False
    Private Orange_Down As Boolean = False
    Private Orange_Right As Boolean = False
    Private Orange_Left As Boolean = False
    Private Orange_Home As Boolean = True
    Private Orange_Leave As Boolean = False
    Private Orange_Scared As Boolean = False
    'Direction Pictureboxes
    Private Down_Right(8) As PictureBox
    Private Down_Left(8) As PictureBox
    Private Down_Left_Right(5) As PictureBox
    Private All(5) As PictureBox
    Private Up_Left_Right(11) As PictureBox
    Private Up_Down_Left(4) As PictureBox
    Private Up_Down_Right(4) As PictureBox
    Private Up_Left(5) As PictureBox
    Private Up_Right(5) As PictureBox
    'Fruit
    Private Fruit_Eaten As Boolean = True
    Private Fruit_Val As Integer
    'Picturebox arrays
    Private Ghosts(3) As PictureBox
    Private Dots(166) As PictureBox
    Private Dots_Eaten(166) As Boolean
    Private Powerup(3) As PictureBox
    Private Powerup_Eaten(3) As Boolean
    'Other variables
    Private Bonus_Score As Integer = 100
    Private Wait As Boolean = True 'Doesnt allow the user to move

    Private Sub Gameboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Starts the start screen animation
        tmrLoad.Start()
    End Sub

    Private Sub tmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        Randomize()
        Static Counter As Integer
        'Start Screen Animation
        Select Case Counter
            Case = 1
                lblP1.Visible = False
            Case = 2
                lblReady.Visible = False
            Case = 3
                picRed.Visible = True
                picPink.Visible = True
                picBlue.Visible = True
                picOrange.Visible = True
                picPacman.Visible = True
                'Decares Picturbox arrays
                For x = 0 To 166
                    Dots(x) = New PictureBox
                Next

                Dots(0) = PictureBox47
                Dots(1) = PictureBox48
                Dots(2) = PictureBox49
                Dots(3) = PictureBox50
                Dots(4) = PictureBox51
                Dots(5) = PictureBox52
                Dots(6) = PictureBox53
                Dots(7) = PictureBox54
                Dots(8) = PictureBox55
                Dots(9) = PictureBox56
                Dots(10) = PictureBox57
                Dots(11) = PictureBox58
                Dots(12) = PictureBox59
                Dots(13) = PictureBox60
                Dots(14) = PictureBox61
                Dots(15) = PictureBox62
                Dots(16) = PictureBox63
                Dots(17) = PictureBox64
                Dots(18) = PictureBox65
                Dots(19) = PictureBox66
                Dots(20) = PictureBox67
                Dots(21) = PictureBox68
                Dots(22) = PictureBox69
                Dots(23) = PictureBox70
                Dots(24) = PictureBox71
                Dots(25) = PictureBox72
                Dots(26) = PictureBox73
                Dots(27) = PictureBox74
                Dots(28) = PictureBox75
                Dots(29) = PictureBox76
                Dots(30) = PictureBox77
                Dots(31) = PictureBox78
                Dots(32) = PictureBox79
                Dots(33) = PictureBox80
                Dots(34) = PictureBox81
                Dots(35) = PictureBox82
                Dots(36) = PictureBox83
                Dots(37) = PictureBox84
                Dots(38) = PictureBox85
                Dots(39) = PictureBox86
                Dots(40) = PictureBox87
                Dots(41) = PictureBox88
                Dots(42) = PictureBox89
                Dots(43) = PictureBox90
                Dots(44) = PictureBox91
                Dots(45) = PictureBox92
                Dots(46) = PictureBox93
                Dots(47) = PictureBox94
                Dots(48) = PictureBox95
                Dots(49) = PictureBox96
                Dots(50) = PictureBox97
                Dots(51) = PictureBox98
                Dots(52) = PictureBox99
                Dots(53) = PictureBox100
                Dots(54) = PictureBox101
                Dots(55) = PictureBox102
                Dots(56) = PictureBox103
                Dots(57) = PictureBox104
                Dots(58) = PictureBox105
                Dots(59) = PictureBox106
                Dots(60) = PictureBox107
                Dots(61) = PictureBox108
                Dots(62) = PictureBox109
                Dots(63) = PictureBox110
                Dots(64) = PictureBox111
                Dots(65) = PictureBox112
                Dots(66) = PictureBox113
                Dots(67) = PictureBox114
                Dots(68) = PictureBox115
                Dots(69) = PictureBox116
                Dots(70) = PictureBox117
                Dots(71) = PictureBox118
                Dots(72) = PictureBox119
                Dots(73) = PictureBox120
                Dots(74) = PictureBox121
                Dots(75) = PictureBox122
                Dots(76) = PictureBox123
                Dots(77) = PictureBox124
                Dots(78) = PictureBox125
                Dots(79) = PictureBox126
                Dots(80) = PictureBox127
                Dots(81) = PictureBox128
                Dots(82) = PictureBox129
                Dots(83) = PictureBox130
                Dots(84) = PictureBox131
                Dots(85) = PictureBox132
                Dots(86) = PictureBox133
                Dots(87) = PictureBox134
                Dots(88) = PictureBox135
                Dots(90) = PictureBox136
                Dots(91) = PictureBox137
                Dots(92) = PictureBox138
                Dots(93) = PictureBox139
                Dots(94) = PictureBox140
                Dots(95) = PictureBox141
                Dots(96) = PictureBox142
                Dots(97) = PictureBox143
                Dots(98) = PictureBox144
                Dots(99) = PictureBox145
                Dots(100) = PictureBox146
                Dots(101) = PictureBox147
                Dots(102) = PictureBox148
                Dots(103) = PictureBox149
                Dots(104) = PictureBox150
                Dots(105) = PictureBox151
                Dots(106) = PictureBox152
                Dots(107) = PictureBox153
                Dots(108) = PictureBox154
                Dots(109) = PictureBox155
                Dots(110) = PictureBox156
                Dots(111) = PictureBox157
                Dots(112) = PictureBox158
                Dots(113) = PictureBox159
                Dots(114) = PictureBox160
                Dots(115) = PictureBox161
                Dots(116) = PictureBox162
                Dots(117) = PictureBox163
                Dots(118) = PictureBox164
                Dots(119) = PictureBox165
                Dots(120) = PictureBox166
                Dots(121) = PictureBox167
                Dots(122) = PictureBox168
                Dots(123) = PictureBox169
                Dots(124) = PictureBox170
                Dots(125) = PictureBox171
                Dots(126) = PictureBox172
                Dots(127) = PictureBox173
                Dots(128) = PictureBox174
                Dots(129) = PictureBox175
                Dots(130) = PictureBox176
                Dots(131) = PictureBox177
                Dots(132) = PictureBox178
                Dots(133) = PictureBox179
                Dots(134) = PictureBox180
                Dots(135) = PictureBox181
                Dots(136) = PictureBox182
                Dots(137) = PictureBox183
                Dots(138) = PictureBox184
                Dots(139) = PictureBox185
                Dots(140) = PictureBox186
                Dots(141) = PictureBox187
                Dots(142) = PictureBox188
                Dots(143) = PictureBox189
                Dots(144) = PictureBox190
                Dots(145) = PictureBox191
                Dots(146) = PictureBox192
                Dots(147) = PictureBox193
                Dots(148) = PictureBox194
                Dots(149) = PictureBox195
                Dots(150) = PictureBox196
                Dots(151) = PictureBox197
                Dots(152) = PictureBox198
                Dots(153) = PictureBox199
                Dots(154) = PictureBox200
                Dots(155) = PictureBox201
                Dots(156) = PictureBox202
                Dots(157) = PictureBox203
                Dots(158) = PictureBox204
                Dots(159) = PictureBox205
                Dots(160) = PictureBox206
                Dots(161) = PictureBox207
                Dots(162) = PictureBox208
                Dots(163) = PictureBox209
                Dots(164) = PictureBox210
                Dots(165) = PictureBox211
                Dots(166) = PictureBox212
                For x = 0 To 8
                    Down_Right(x) = New PictureBox
                Next
                Down_Right(0) = PictureBox213
                Down_Right(1) = PictureBox214
                Down_Right(2) = PictureBox215
                Down_Right(3) = PictureBox216
                Down_Right(4) = PictureBox217
                Down_Right(5) = PictureBox218
                Down_Right(6) = PictureBox219
                Down_Right(7) = PictureBox220
                Down_Right(8) = PictureBox221
                For x = 0 To 8
                    Down_Left(x) = New PictureBox
                Next
                Down_Left(0) = PictureBox222
                Down_Left(1) = PictureBox223
                Down_Left(2) = PictureBox224
                Down_Left(3) = PictureBox225
                Down_Left(4) = PictureBox226
                Down_Left(5) = PictureBox227
                Down_Left(6) = PictureBox228
                Down_Left(7) = PictureBox229
                Down_Left(8) = PictureBox275
                For x = 0 To 5
                    Down_Left_Right(x) = New PictureBox
                Next
                Down_Left_Right(0) = PictureBox230
                Down_Left_Right(1) = PictureBox231
                Down_Left_Right(2) = PictureBox232
                Down_Left_Right(3) = PictureBox233
                Down_Left_Right(4) = PictureBox234
                Down_Left_Right(5) = PictureBox235
                For x = 0 To 5
                    All(x) = New PictureBox
                Next
                All(0) = PictureBox236
                All(1) = PictureBox237
                All(2) = PictureBox238
                All(3) = PictureBox239
                All(4) = PictureBox240
                All(5) = PictureBox241
                For x = 0 To 11
                    Up_Left_Right(x) = New PictureBox
                Next
                Up_Left_Right(0) = PictureBox242
                Up_Left_Right(1) = PictureBox243
                Up_Left_Right(2) = PictureBox244
                Up_Left_Right(3) = PictureBox245
                Up_Left_Right(4) = PictureBox246
                Up_Left_Right(5) = PictureBox247
                Up_Left_Right(6) = PictureBox248
                Up_Left_Right(7) = PictureBox249
                Up_Left_Right(8) = PictureBox250
                Up_Left_Right(9) = PictureBox251
                Up_Left_Right(10) = PictureBox252
                Up_Left_Right(11) = PictureBox253
                For X = 0 To 4
                    Up_Down_Left(X) = New PictureBox
                Next
                Up_Down_Left(0) = PictureBox254
                Up_Down_Left(1) = PictureBox255
                Up_Down_Left(2) = PictureBox256
                Up_Down_Left(3) = PictureBox257
                Up_Down_Left(4) = PictureBox258
                For x = 0 To 4
                    Up_Down_Right(x) = New PictureBox
                Next
                Up_Down_Right(0) = PictureBox259
                Up_Down_Right(1) = PictureBox260
                Up_Down_Right(2) = PictureBox261
                Up_Down_Right(3) = PictureBox262
                Up_Down_Right(4) = PictureBox276
                For x = 0 To 5
                    Up_Left(x) = New PictureBox
                Next
                Up_Left(0) = PictureBox263
                Up_Left(1) = PictureBox264
                Up_Left(2) = PictureBox265
                Up_Left(3) = PictureBox266
                Up_Left(4) = PictureBox267
                Up_Left(5) = PictureBox274
                For x = 0 To 5
                    Up_Right(x) = New PictureBox
                Next
                Up_Right(0) = PictureBox268
                Up_Right(1) = PictureBox269
                Up_Right(2) = PictureBox270
                Up_Right(3) = PictureBox271
                Up_Right(4) = PictureBox272
                Up_Right(5) = PictureBox273
                For x = 0 To 3
                    Ghosts(x) = New PictureBox
                Next
                Ghosts(0) = picRed
                Ghosts(1) = picBlue
                Ghosts(2) = picPink
                Ghosts(3) = picOrange
                For x = 0 To 3
                    Powerup(x) = New PictureBox
                Next
                Powerup(0) = picPowerup_1
                Powerup(1) = picPowerup_2
                Powerup(2) = picPowerup_3
                Powerup(3) = picPowerup_4

                picLife_6.Visible = False
                Wait = False 'Allows the user to move
                tmrFruit.Start()
                'Starts movement
                tmrPacman.Start()
                tmrRed.Start()
                tmrPink.Start()
                tmrBlue.Start()
                tmrOrange.Start()
                tmrGhosts_Leave.Start() 'Makes the ghost leave
                tmrLoad.Stop() 'Stops the load timer
        End Select
        Counter = Counter + 1
    End Sub

    Private Sub tmrPacman_Tick(sender As Object, e As EventArgs) Handles tmrPacman.Tick
        Static Index As Integer = 0              'Used to count how many times the move timer has run through
        Static Powerup_Show As Boolean = True    'Used to decide whether to show the powerup or not
        Static Open As Boolean = False
        'Checks all directions
        Pacman_Direction()
        'Checks for Pac-Man Collision
        Collision()

        'Pacman Movement
        If Pacman_Up = True Then
            picPacman.Top -= 1
            If Open = True Then
                picPacman.Image = My.Resources.Pacman_Closed
            ElseIf Open = False Then
                picPacman.Image = My.Resources.Pacman_Open_Up
            End If
        ElseIf Pacman_Down = True Then
            picPacman.Top += 1
            If Open = True Then
                picPacman.Image = My.Resources.Pacman_Closed
            ElseIf Open = False Then
                picPacman.Image = My.Resources.Pacman_Open_Down
            End If
        ElseIf Pacman_Right = True Then
            picPacman.Left += 1
            If Open = True Then
                picPacman.Image = My.Resources.Pacman_Closed
            ElseIf Open = False Then
                picPacman.Image = My.Resources.Pacman_Open_Right
            End If
        ElseIf Pacman_Left = True Then
            picPacman.Left -= 1
            If Open = True Then
                picPacman.Image = My.Resources.Pacman_Closed
            ElseIf Open = False Then
                picPacman.Image = My.Resources.Pacman_Open_Left
            End If
        End If

        For x = 0 To 3
            If Powerup_Show = True Then
                If Powerup_Eaten(x) = True Then
                Else
                    Powerup(x).Visible = False
                End If
            ElseIf Powerup_Show = False Then
                If Powerup_Eaten(x) = True Then
                Else
                    Powerup(x).Visible = True
                End If
            End If
        Next
        'Makes the Poweup Dots flash
        If Index Mod 20 = 0 Then
            If Powerup_Show = True Then
                Powerup_Show = False
            ElseIf Powerup_Show = False Then
                Powerup_Show = True
            End If
        End If

        'Used to control the open/closed animation variable
        If Index Mod 5 = 0 Then
            If Open = True Then
                Open = False
            ElseIf Open = False Then
                Open = True
            End If
        End If
        Index = Index + 1
    End Sub

    Private Sub tmrRed_Tick(sender As Object, e As EventArgs) Handles tmrRed.Tick
        Static Index As Integer = 0              'Used to count how many times the move timer has run through
        Static Open As Boolean = True            'Tells if animation is open/closed
        'Checks all directions
        Red_Direction()

        'Red Movements (Same for all other ghosts)
        ''Makes Red Bounce off the home walls
        If Red_Home = True Then
            If picRed.Bounds.IntersectsWith(GhostWall.Bounds) Then
                Red_Up = False
                Red_Down = True
            ElseIf picRed.Bounds.IntersectsWith(PictureBox44.Bounds) Then
                Red_Up = True
                Red_Down = False
            End If
        End If
        'Tells the red ghost to leave the home
        If Red_Leave = True Then
            If picRed.Location = picPink_Home.Location Then
                Red_Up = True
                Red_Down = False
                Red_Home = False
            End If
            If picRed.Location = picGhost_Exit.Location Then
                Red_Up = False
                Red_Left = True
                Red_Leave = False
            End If
        End If
        'Moves Red Up 1 pixel, then changes the image according to all variables
        If Red_Up = True Then
            If Open = False Then
                picRed.Top -= 1
                If Red_Scared = True Then
                    picRed.Image = My.Resources.Scared_Open_Blue
                ElseIf Red_Scared = False Then
                    picRed.Image = My.Resources.Red_Ghost_Up_Open
                End If
            ElseIf Open = True Then
                picRed.Top -= 1
                If Red_Scared = True Then
                    picRed.Image = My.Resources.Scared_Closed_Blue
                ElseIf Red_Scared = False Then
                    picRed.Image = My.Resources.Red_Ghost_Up_Closed
                End If
            End If
        ElseIf Red_Down = True Then
            If Open = False Then
                picRed.Top += 1
                If Red_Scared = True Then
                    picRed.Image = My.Resources.Scared_Open_Blue
                ElseIf Red_Scared = False Then
                    picRed.Image = My.Resources.Red_Ghost_Down_Open
                End If
            ElseIf Open = True Then
                picRed.Top += 1
                If Red_Scared = True Then
                    picRed.Image = My.Resources.Scared_Closed_Blue
                ElseIf Red_Scared = False Then
                    picRed.Image = My.Resources.Red_Ghost_Down_Closed
                End If
            End If
        ElseIf Red_Right = True Then
            If Open = False Then
                picRed.Left += 1
                If Red_Scared = True Then
                    picRed.Image = My.Resources.Scared_Open_Blue
                ElseIf Red_Scared = False Then
                    picRed.Image = My.Resources.Red_Ghost_Right_Open
                End If
            ElseIf Open = True Then
                picRed.Left += 1
                If Red_Scared = True Then
                    picRed.Image = My.Resources.Scared_Closed_Blue
                ElseIf Red_Scared = False Then
                    picRed.Image = My.Resources.Red_Ghost_Right_Closed
                End If
            End If
        ElseIf Red_Left = True Then
            If Open = False Then
                picRed.Left -= 1
                If Red_Scared = True Then
                    picRed.Image = My.Resources.Scared_Open_Blue
                ElseIf Red_Scared = False Then
                    picRed.Image = My.Resources.Red_Ghost_Left_Open
                End If
            ElseIf Open = True Then
                picRed.Left -= 1
                If Red_Scared = True Then
                    picRed.Image = My.Resources.Scared_Closed_Blue
                ElseIf Red_Scared = False Then
                    picRed.Image = My.Resources.Red_Ghost_Left_Closed
                End If
            End If
        End If

        'Controls speed (Scared/Not Scared)
        If Red_Scared = True Then
            tmrRed.Interval = 30
        ElseIf Red_Scared = False Then
            tmrRed.Interval = 10
        End If

        'Used to control the open/closed animation variable
        If Index Mod 5 = 0 Then
            If Open = True Then
                Open = False
            ElseIf Open = False Then
                Open = True
            End If
        End If
        Index = Index + 1
    End Sub

    Private Sub tmrBlue_Tick(sender As Object, e As EventArgs) Handles tmrBlue.Tick
        Static Index As Integer = 0              'Used to count how many times the move timer has run through
        Static Open As Boolean = True            'Tells if animation is open/closed
        'Checks all directions
        Blue_Direction()

        'Blue Movements
        If Blue_Home = True Then
            If picBlue.Bounds.IntersectsWith(PictureBox46.Bounds) Then
                Blue_Up = False
                Blue_Down = True
            End If
            If picBlue.Bounds.IntersectsWith(PictureBox44.Bounds) Then
                Blue_Up = True
                Blue_Down = False
            End If
        End If

        If Blue_Leave = True Then
            If picBlue.Location = picBlue_Home.Location Then
                Blue_Up = False
                Blue_Down = False
                Blue_Right = True
                Blue_Home = False
            End If
            If picBlue.Location = picPink_Home.Location Then
                Blue_Right = False
                Blue_Up = True
            End If
            If picBlue.Location = picGhost_Exit.Location Then
                Blue_Up = False
                Blue_Left = True
                Blue_Leave = False
            End If
        End If

        If Blue_Up = True Then
            If Open = False Then
                picBlue.Top -= 1
                If Blue_Scared = True Then
                    picBlue.Image = My.Resources.Scared_Open_Blue
                ElseIf Blue_Scared = False Then
                    picBlue.Image = My.Resources.Blue_Ghost_Up_Open
                End If
            ElseIf Open = True Then
                picBlue.Top -= 1
                If Blue_Scared = True Then
                    picBlue.Image = My.Resources.Scared_Closed_Blue
                ElseIf Blue_Scared = False Then
                    picBlue.Image = My.Resources.Blue_Ghost_Up_Closed
                End If
            End If
        ElseIf Blue_Down = True Then
            If Open = False Then
                picBlue.Top += 1
                If Blue_Scared = True Then
                    picBlue.Image = My.Resources.Scared_Open_Blue
                ElseIf Blue_Scared = False Then
                    picBlue.Image = My.Resources.Blue_Ghost_Down_Open
                End If
            ElseIf Open = True Then
                picBlue.Top += 1
                If Blue_Scared = True Then
                    picBlue.Image = My.Resources.Scared_Closed_Blue
                ElseIf Blue_Scared = False Then
                    picBlue.Image = My.Resources.Blue_Ghost_Down_Closed
                End If
            End If
        ElseIf Blue_Right = True Then
            If Open = False Then
                picBlue.Left += 1
                If Blue_Scared = True Then
                    picBlue.Image = My.Resources.Scared_Open_Blue
                ElseIf Blue_Scared = False Then
                    picBlue.Image = My.Resources.Blue_Ghost_Right_Open
                End If
            ElseIf Open = True Then
                picBlue.Left += 1
                If Blue_Scared = True Then
                    picBlue.Image = My.Resources.Scared_Closed_Blue
                ElseIf Blue_Scared = False Then
                    picBlue.Image = My.Resources.Blue_Ghost_Right_Closed
                End If
            End If
        ElseIf Blue_Left = True Then
            If Open = False Then
                picBlue.Left -= 1
                If Blue_Scared = True Then
                    picBlue.Image = My.Resources.Scared_Open_Blue
                ElseIf Blue_Scared = False Then
                    picBlue.Image = My.Resources.Blue_Ghost_Left_Open
                End If
            ElseIf Open = True Then
                picBlue.Left -= 1
                If Blue_Scared = True Then
                    picBlue.Image = My.Resources.Scared_Closed_Blue
                ElseIf Blue_Scared = False Then
                    picBlue.Image = My.Resources.Blue_Ghost_Left_Closed
                End If
            End If
        End If

        'Controls speed (Scared/Not Scared)
        If Blue_Scared = True Then
            tmrBlue.Interval = 30
        ElseIf Blue_Scared = False Then
            tmrBlue.Interval = 10
        End If

        'Used to control the open/closed animation variable
        If Index Mod 5 = 0 Then
            If Open = True Then
                Open = False
            ElseIf Open = False Then
                Open = True
            End If
        End If
        Index = Index + 1
    End Sub

    Private Sub tmrPink_Tick(sender As Object, e As EventArgs) Handles tmrPink.Tick
        Static Index As Integer = 0              'Used to count how many times the move timer has run through
        Static Open As Boolean = True            'Tells if animation is open/closed
        'Checks all directions
        Pink_Direction()

        'Pink Movements
        If Pink_Home = True Then
            If picPink.Bounds.IntersectsWith(GhostWall.Bounds) Then
                Pink_Up = False
                Pink_Down = True
            ElseIf picPink.Bounds.IntersectsWith(PictureBox44.Bounds) Then
                Pink_Up = True
                Pink_Down = False
            End If
        End If

        If Pink_Leave = True Then
            If picPink.Location = picPink_Home.Location Then
                Pink_Up = True
                Pink_Down = False
                Pink_Home = False
            End If
            If picPink.Location = picGhost_Exit.Location Then
                Pink_Up = False
                Pink_Left = True
                Pink_Leave = False
            End If
        End If

        If Pink_Up = True Then
            If Open = False Then
                picPink.Top -= 1
                If Pink_Scared = True Then
                    picPink.Image = My.Resources.Scared_Open_Blue
                ElseIf Pink_Scared = False Then
                    picPink.Image = My.Resources.Pink_Ghost_Up_Open
                End If
            ElseIf Open = True Then
                picPink.Top -= 1
                If Pink_Scared = True Then
                    picPink.Image = My.Resources.Scared_Closed_Blue
                ElseIf Pink_Scared = False Then
                    picPink.Image = My.Resources.Pink_Ghost_Up_Closed
                End If
            End If
        ElseIf Pink_Down = True Then
            If Open = False Then
                picPink.Top += 1
                If Pink_Scared = True Then
                    picPink.Image = My.Resources.Scared_Open_Blue
                ElseIf Pink_Scared = False Then
                    picPink.Image = My.Resources.Pink_Ghost_Down_Open
                End If
            ElseIf Open = True Then
                picPink.Top += 1
                If Pink_Scared = True Then
                    picPink.Image = My.Resources.Scared_Closed_Blue
                ElseIf Pink_Scared = False Then
                    picPink.Image = My.Resources.Pink_Ghost_Down_Closed
                End If
            End If
        ElseIf Pink_Right = True Then
            If Open = False Then
                picPink.Left += 1
                If Pink_Scared = True Then
                    picPink.Image = My.Resources.Scared_Open_Blue
                ElseIf Pink_Scared = False Then
                    picPink.Image = My.Resources.Pink_Ghost_Right_Open
                End If
            ElseIf Open = True Then
                picPink.Left += 1
                If Pink_Scared = True Then
                    picPink.Image = My.Resources.Scared_Closed_Blue
                ElseIf Pink_Scared = False Then
                    picPink.Image = My.Resources.Pink_Ghost_Right_Closed
                End If
            End If
        ElseIf Pink_Left = True Then
            If Open = False Then
                picPink.Left -= 1
                If Pink_Scared = True Then
                    picPink.Image = My.Resources.Scared_Open_Blue
                ElseIf Pink_Scared = False Then
                    picPink.Image = My.Resources.Pink_Ghost_Left_Open
                End If
            ElseIf Open = True Then
                picPink.Left -= 1
                If Pink_Scared = True Then
                    picPink.Image = My.Resources.Scared_Closed_Blue
                ElseIf Pink_Scared = False Then
                    picPink.Image = My.Resources.Pink_Ghost_Left_Closed
                End If
            End If
        End If

        'Controls speed (Scared/Not Scared)
        If Pink_Scared = True Then
            tmrPink.Interval = 30
        ElseIf Pink_Scared = False Then
            tmrPink.Interval = 10
        End If

        'Used to control the open/closed animation variable
        If Index Mod 5 = 0 Then
            If Open = True Then
                Open = False
            ElseIf Open = False Then
                Open = True
            End If
        End If
        Index = Index + 1
    End Sub

    Private Sub tmrOrange_Tick(sender As Object, e As EventArgs) Handles tmrOrange.Tick
        Static Index As Integer = 0              'Used to count how many times the move timer has run through
        Static Open As Boolean = True            'Tells if animation is open/closed
        'Checks all directions
        Orange_Direction()

        'Orange Movements
        If Orange_Home = True Then
            If picOrange.Bounds.IntersectsWith(PictureBox45.Bounds) Then
                Orange_Up = False
                Orange_Down = True
            ElseIf picOrange.Bounds.IntersectsWith(PictureBox44.Bounds) Then
                Orange_Up = True
                Orange_Down = False
            End If
        End If

        If Orange_Leave = True Then
            If picOrange.Location = picOrange_Home.Location Then
                Orange_Up = False
                Orange_Down = False
                Orange_Left = True
                Orange_Home = False
            End If
            If picOrange.Location = picPink_Home.Location Then
                Orange_Left = False
                Orange_Up = True
            End If
            If picOrange.Location = picGhost_Exit.Location Then
                Orange_Up = False
                Orange_Left = True
                Orange_Leave = False
            End If
        End If

        If Orange_Up = True Then
            If Open = False Then
                picOrange.Top -= 1
                If Orange_Scared = True Then
                    picOrange.Image = My.Resources.Scared_Open_Blue
                ElseIf Orange_Scared = False Then
                    picOrange.Image = My.Resources.Orange_Ghost_Up_Open
                End If
            ElseIf Open = True Then
                picOrange.Top -= 1
                If Orange_Scared = True Then
                    picOrange.Image = My.Resources.Scared_Closed_Blue
                ElseIf Orange_Scared = False Then
                    picOrange.Image = My.Resources.Orange_Ghost_Up_Closed
                End If
            End If
        ElseIf Orange_Down = True Then
            If Open = False Then
                picOrange.Top += 1
                If Orange_Scared = True Then
                    picOrange.Image = My.Resources.Scared_Open_Blue
                ElseIf Orange_Scared = False Then
                    picOrange.Image = My.Resources.Orange_Ghost_Down_Open
                End If
            ElseIf Open = True Then
                picOrange.Top += 1
                If Orange_Scared = True Then
                    picOrange.Image = My.Resources.Scared_Closed_Blue
                ElseIf Orange_Scared = False Then
                    picOrange.Image = My.Resources.Orange_Ghost_Down_Closed
                End If
            End If
        ElseIf Orange_Right = True Then
            If Open = False Then
                picOrange.Left += 1
                If Orange_Scared = True Then
                    picOrange.Image = My.Resources.Scared_Open_Blue
                ElseIf Orange_Scared = False Then
                    picOrange.Image = My.Resources.Orange_Ghost_Right_Open
                End If
            ElseIf Open = True Then
                picOrange.Left += 1
                If Orange_Scared = True Then
                    picOrange.Image = My.Resources.Scared_Closed_Blue
                ElseIf Orange_Scared = False Then
                    picOrange.Image = My.Resources.Orange_Ghost_Right_Closed
                End If
            End If
        ElseIf Orange_Left = True Then
            If Open = False Then
                picOrange.Left -= 1
                If Orange_Scared = True Then
                    picOrange.Image = My.Resources.Scared_Open_Blue
                ElseIf Orange_Scared = False Then
                    picOrange.Image = My.Resources.Orange_Ghost_Left_Open
                End If
            ElseIf Open = True Then
                picOrange.Left -= 1
                If Orange_Scared = True Then
                    picOrange.Image = My.Resources.Scared_Closed_Blue
                ElseIf Orange_Scared = False Then
                    picOrange.Image = My.Resources.Orange_Ghost_Left_Closed
                End If
            End If
        End If

        'Controls speed (Scared/Not Scared)
        If Orange_Scared = True Then
            tmrOrange.Interval = 30
        ElseIf Orange_Scared = False Then
            tmrOrange.Interval = 10
        End If

        'Used to control the open/closed animation variable
        If Index Mod 5 = 0 Then
            If Open = True Then
                Open = False
            ElseIf Open = False Then
                Open = True
            End If
        End If
        Index = Index + 1
    End Sub
    Private Sub Gameboard_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'If wait is true you cannot move
        If Wait = False Then
            Select Case e.KeyCode
                'Moves pacman according to the key pressed
                Case Keys.W
                    Pacman_Key_Up = True
                    Pacman_Key_Down = False
                    Pacman_Key_Right = False
                    Pacman_Key_Left = False
                    'If pacman is able to move both up and down in the secenario this will make pacman go up,
                    'even if he doesnt hit a picturbox that contols movement
                    If Pacman_Able_Up_Down = True Then
                        Pacman_Up = True
                        Pacman_Down = False
                    End If
                Case Keys.S
                    Pacman_Key_Up = False
                    Pacman_Key_Down = True
                    Pacman_Key_Right = False
                    Pacman_Key_Left = False
                    If Pacman_Able_Up_Down = True Then
                        Pacman_Up = False
                        Pacman_Down = True
                    End If
                Case Keys.D
                    Pacman_Key_Up = False
                    Pacman_Key_Down = False
                    Pacman_Key_Right = True
                    Pacman_Key_Left = False
                    If Pacman_Able_Left_Right = True Then
                        Pacman_Left = False
                        Pacman_Right = True
                    End If
                Case Keys.A
                    Pacman_Key_Up = False
                    Pacman_Key_Down = False
                    Pacman_Key_Right = False
                    Pacman_Key_Left = True
                    If Pacman_Able_Left_Right = True Then
                        Pacman_Left = True
                        Pacman_Right = False
                    End If
            End Select
            Select Case e.KeyCode
                Case Keys.Up
                    Pacman_Key_Up = True
                    Pacman_Key_Down = False
                    Pacman_Key_Right = False
                    Pacman_Key_Left = False
                    If Pacman_Able_Up_Down = True Then
                        Pacman_Up = True
                        Pacman_Down = False
                    End If
                Case Keys.Down
                    Pacman_Key_Up = False
                    Pacman_Key_Down = True
                    Pacman_Key_Right = False
                    Pacman_Key_Left = False
                    If Pacman_Able_Up_Down = True Then
                        Pacman_Up = False
                        Pacman_Down = True
                    End If
                Case Keys.Right
                    Pacman_Key_Up = False
                    Pacman_Key_Down = False
                    Pacman_Key_Right = True
                    Pacman_Key_Left = False
                    If Pacman_Able_Left_Right = True Then
                        Pacman_Left = False
                        Pacman_Right = True
                    End If
                Case Keys.Left
                    Pacman_Key_Up = False
                    Pacman_Key_Down = False
                    Pacman_Key_Right = False
                    Pacman_Key_Left = True
                    If Pacman_Able_Left_Right = True Then
                        Pacman_Left = True
                        Pacman_Right = False
                    End If
            End Select
        End If
    End Sub
    Private Sub tmrFruit_Tick(sender As Object, e As EventArgs) Handles tmrFruit.Tick
        Static Counter As Integer
        Counter = Counter + 1
        Select Case Counter
            Case 200
                If Level = 1 Then
                    picFruit.Image = My.Resources.Cherry
                    Fruit_Val = 100
                ElseIf Level = 2 Then
                    picFruit.Image = My.Resources.Strawberry
                    Fruit_Val = 300
                ElseIf Level = 3 Or 4 Then
                    picFruit.Image = My.Resources.Pear
                    Fruit_Val = 500
                ElseIf Level = 5 Or 6 Then
                    picFruit.Image = My.Resources.Apple
                    Fruit_Val = 700
                ElseIf Level = 7 Or 8 Then
                    picFruit.Image = My.Resources.Mellon
                    Fruit_Val = 100
                ElseIf Level = 8 Or 9 Then
                    picFruit.Image = My.Resources.Boss
                    Fruit_Val = 2000
                ElseIf Level = 10 Or 11 Then
                    picFruit.Image = My.Resources.Bell
                    Fruit_Val = 3000
                ElseIf Level > 11 Then
                    picFruit.Image = My.Resources.Key
                    Fruit_Val = 5000
                End If
                Fruit_Eaten = False
                picFruit.Visible = True
            Case = 800
                Fruit_Eaten = True
                picFruit.Visible = False
                tmrFruit.Stop()
                Counter = 0
        End Select
    End Sub
    Private Sub tmrGhosts_Leave_Tick(sender As Object, e As EventArgs) Handles tmrGhosts_Leave.Tick
        Static Counter As Integer
        Select Case Counter
            'Contols when the ghosts leave
            Case 0
                Red_Left = True
                Pink_Down = True
                Blue_Up = True
                Orange_Up = True
            Case 10
                Pink_Leave = True
            Case 20
                Blue_Leave = True
            Case 30
                Orange_Leave = True
                tmrGhosts_Leave.Stop()
                Counter = 0
        End Select
        Counter = Counter + 1
    End Sub
    Private Sub Collision()
        'Checks to see if all dots have been eaten
        Dim Eaten As Integer = -1 '<--- That solved a problem where there was an extra dot, making the program end early
        For x = 0 To 166
            If Dots_Eaten(x) = True Then
                Eaten = Eaten + 1
            End If
        Next
        If Eaten = 166 Then
            Eaten = Eaten + 1
            Level = Level + 1
            tmrPacman.Stop()
            tmrRed.Stop()
            tmrPink.Stop()
            tmrBlue.Stop()
            tmrOrange.Stop()
            tmrLevel_Change.Start()
        End If
        'Checks to see if pacman has hit a powerup. If so it adds 50pts to the score and activates the scared state.
        For x = 0 To 3
            If picPacman.Bounds.IntersectsWith(Powerup(x).Bounds) Then
                If Powerup_Eaten(x) = False Then
                    Score = Score + 50
                    lblScore.Text = Score
                    Powerup(x).Visible = False
                    Powerup_Eaten(x) = True
                    tmrScared.Start()
                    Red_Scared = True
                    Blue_Scared = True
                    Pink_Scared = True
                    Orange_Scared = True
                End If
            End If
        Next
        'Checks to see if pacman has hit a dot. If so it adds 10pts, makes the dot invisible, and tells the computer
        'that the dot has been eaten. Ensuring that the 10pts are not added until the dots are visible on the next
        'level. The same method used here is used with the powerup dots in the code above.
        For x = 0 To 166
            If picPacman.Bounds.IntersectsWith(Dots(x).Bounds) Then
                If Dots_Eaten(x) = False Then
                    Dots(x).Visible = False
                    Score = Score + 10
                    lblScore.Text = Score
                    Dots_Eaten(x) = True
                End If
            End If
        Next
        'Checks to see if pacman has collided with a ghost. If so it checks to see which ghost pacman has collided with.
        'If the ghost is scared it will activate the corrisponding ghosts death timer. Otherwise it will activate the
        'Life lost code to take a life from pacman, and play his death animation.
        For x = 0 To 3
            If picPacman.Bounds.IntersectsWith(Ghosts(x).Bounds) Then
                If x = 0 Then
                    If Red_Scared = True Then
                        tmrRed_Death.Start()
                    ElseIf Red_Scared = False Then
                        Life_Loss()
                    End If
                ElseIf x = 1 Then
                    If Blue_Scared = True Then
                        tmrBlue_Death.Start()
                    ElseIf Blue_Scared = False Then
                        Life_Loss()
                    End If

                ElseIf x = 2 Then
                    If Pink_Scared = True Then
                        tmrPink_Death.Start()
                    ElseIf Pink_Scared = False Then
                        Life_Loss()
                    End If
                ElseIf x = 3 Then
                    If Orange_Scared = True Then
                        tmrOrange_Death.Start()
                    ElseIf Orange_Scared = False Then
                        Life_Loss()
                    End If
                End If
            End If
        Next

        If picPacman.Bounds.IntersectsWith(picFruit.Bounds) Then
            If Fruit_Eaten = False Then
                Fruit_Eaten = True
                picFruit.Visible = False
                Score = Score + Fruit_Val
                lblScore.Text = Score
                tmrFruit_Display.Start()
            End If
        End If
    End Sub
    Private Sub tmrFruit_Display_Tick(sender As Object, e As EventArgs) Handles tmrFruit_Display.Tick
        Static Counter As Integer = 0
        Counter = Counter + 1
        Select Case Counter
            Case 1
                lblFruit_Score.Visible = True
                lblFruit_Score.Text = Fruit_Val
            Case 20
                lblFruit_Score.Visible = False
                tmrFruit_Display.Stop()
                Counter = 0
        End Select
    End Sub
    Private Sub tmrScared_Tick(sender As Object, e As EventArgs) Handles tmrScared.Tick
        'Used to contol how long the ghosts are in the scared state (5,000 ms). After 3,800 ms the gameboard flashes
        'white to indicate that the ghosts will soon get out of their scared state. The board will flash white in intervals
        'of 200ms.
        Static Counter As Integer
        Select Case Counter
            Case 38
                picGameboard_Blue.Image = My.Resources.Gameboard_2
            Case 40
                picGameboard_Blue.Image = My.Resources.Gameboard
            Case 42
                picGameboard_Blue.Image = My.Resources.Gameboard_2
            Case 44
                picGameboard_Blue.Image = My.Resources.Gameboard
            Case 46
                picGameboard_Blue.Image = My.Resources.Gameboard_2
            Case 48
                picGameboard_Blue.Image = My.Resources.Gameboard
            Case 50
                Bonus_Score = 100
                Red_Scared = False
                Blue_Scared = False
                Pink_Scared = False
                Orange_Scared = False
                Counter = 0
                tmrScared.Stop()
        End Select
        Counter = Counter + 1
    End Sub
    Private Sub tmrRed_Death_Tick(sender As Object, e As EventArgs) Handles tmrRed_Death.Tick
        'This timer is used to contol the death of the red ghosts. (*The same rules here apply for all other ghost deaths*)
        'It first stops all movement and makes both pacman and the red ghost invisible. It then calclates the necessary
        'bonus points by doubleing the last value in the Bonus_Score variable. It then adds it to the current score, and
        'displays the ammount added on the total score, and the ponts obatained in that "kill". The program then goes on to
        'move the red ghost back to the home, turns off his scared variable, then releases him back onto the board.
        Static Counter As Integer
        Select Case Counter
            Case 1
                tmrPacman.Stop()
                tmrRed.Stop()
                tmrPink.Stop()
                tmrBlue.Stop()
                tmrOrange.Stop()
                picRed.Visible = False
                picPacman.Visible = False
                Bonus_Score = Bonus_Score * 2
                Score = Score + (Bonus_Score)
                lblScore.Text = Score
                lblBonus.Location = picRed.Location
                lblBonus.Text = Bonus_Score
                lblBonus.Visible = True
            Case 6
                picRed.Location = picPink_Home.Location
                Red_Scared = False
                Red_Up = True
                Red_Down = False
                Red_Left = False
                Red_Right = False
                Red_Home = True
                Red_Leave = True
                lblBonus.Visible = False
                picRed.Visible = True
                picPacman.Visible = True
                tmrPacman.Start()
                tmrRed.Start()
                tmrPink.Start()
                tmrBlue.Start()
                tmrOrange.Start()
                Counter = 0
                tmrRed_Death.Stop()
        End Select
        Counter = Counter + 1
    End Sub
    Private Sub tmrPink_Death_Tick(sender As Object, e As EventArgs) Handles tmrPink_Death.Tick
        Static Counter As Integer
        Select Case Counter
            Case 1
                tmrPacman.Stop()
                tmrRed.Stop()
                tmrPink.Stop()
                tmrBlue.Stop()
                tmrOrange.Stop()
                picPink.Visible = False
                picPacman.Visible = False
                Bonus_Score = Bonus_Score * 2
                Score = Score + (Bonus_Score)
                lblScore.Text = Score
                lblBonus.Location = picPink.Location
                lblBonus.Text = Bonus_Score
                lblBonus.Visible = True
            Case 6
                picPink.Location = picPink_Home.Location
                Pink_Scared = False
                Pink_Up = True
                Pink_Down = False
                Pink_Left = False
                Pink_Right = False
                Pink_Home = True
                Pink_Leave = True
                lblBonus.Visible = False
                picPink.Visible = True
                picPacman.Visible = True
                Counter = 0
                tmrPacman.Start()
                tmrRed.Start()
                tmrPink.Start()
                tmrBlue.Start()
                tmrOrange.Start()
                tmrPink_Death.Stop()
        End Select
        Counter = Counter + 1
    End Sub

    Private Sub tmrBlue_Death_Tick(sender As Object, e As EventArgs) Handles tmrBlue_Death.Tick
        Static Counter As Integer
        Select Case Counter
            Case 1
                tmrPacman.Stop()
                tmrRed.Stop()
                tmrPink.Stop()
                tmrBlue.Stop()
                tmrOrange.Stop()
                picBlue.Visible = False
                picPacman.Visible = False
                Bonus_Score = Bonus_Score * 2
                Score = Score + (Bonus_Score)
                lblScore.Text = Score
                lblBonus.Location = picBlue.Location
                lblBonus.Text = Bonus_Score
                lblBonus.Visible = True
            Case 6
                picBlue.Location = picPink_Home.Location
                Blue_Scared = False
                Blue_Up = True
                Blue_Down = False
                Blue_Left = False
                Blue_Right = False
                Blue_Home = True
                Blue_Leave = True
                lblBonus.Visible = False
                picBlue.Visible = True
                picPacman.Visible = True
                Counter = 0
                tmrPacman.Start()
                tmrRed.Start()
                tmrPink.Start()
                tmrBlue.Start()
                tmrOrange.Start()
                tmrBlue_Death.Stop()
        End Select
        Counter = Counter + 1
    End Sub

    Private Sub tmrOrange_Death_Tick(sender As Object, e As EventArgs) Handles tmrOrange_Death.Tick
        Static Counter As Integer
        Select Case Counter
            Case 1
                tmrPacman.Stop()
                tmrRed.Stop()
                tmrPink.Stop()
                tmrBlue.Stop()
                tmrOrange.Stop()
                picOrange.Visible = False
                picPacman.Visible = False
                Bonus_Score = Bonus_Score * 2
                Score = Score + (Bonus_Score)
                lblScore.Text = Score
                lblBonus.Location = picOrange.Location
                lblBonus.Text = Bonus_Score
                lblBonus.Visible = True
            Case 6
                picOrange.Location = picOrange_Home.Location
                Orange_Scared = False
                Orange_Up = True
                Orange_Down = False
                Orange_Left = False
                Orange_Right = False
                Orange_Home = True
                Orange_Leave = True
                lblBonus.Visible = False
                picOrange.Visible = True
                picPacman.Visible = True
                Counter = 0
                tmrPacman.Start()
                tmrRed.Start()
                tmrPink.Start()
                tmrBlue.Start()
                tmrOrange.Start()
                tmrOrange_Death.Stop()
        End Select
        Counter = Counter + 1
    End Sub
    Private Sub Life_Loss()
        'Makes pacman loose a life
        Wait = True
        tmrPacman.Stop()
        tmrRed.Stop()
        tmrPink.Stop()
        tmrBlue.Stop()
        tmrOrange.Stop()

        Lifes = Lifes - 1

        If Lifes = 5 Then
            picLife_6.Visible = False
        ElseIf Lifes = 4 Then
            picLife_5.Visible = False
        ElseIf Lifes = 3 Then
            picLife_4.Visible = False
        ElseIf Lifes = 2 Then
            picLife_3.Visible = False
        ElseIf Lifes = 1 Then
            picLife_2.Visible = False
        ElseIf Lifes = 0 Then
        End If
        picRed.Visible = False
        picBlue.Visible = False
        picPink.Visible = False
        picOrange.Visible = False
        tmrDeath.Start()
    End Sub
    Private Sub tmrDeath_Tick(sender As Object, e As EventArgs) Handles tmrDeath.Tick
        'Plays the pacman death animation, then resets the ghosts to their respective homes, and returns pacman back
        'to his
        Static Counter As Integer
        Select Case Counter
            Case 1
                picPacman.Image = My.Resources.Pacman_Death_1
            Case = 2
                picPacman.Image = My.Resources.Pacman_Death_2
            Case = 3
                picPacman.Image = My.Resources.Pacman_Death_3
            Case = 4
                picPacman.Image = My.Resources.Pacman_Death_4
            Case = 5
                picPacman.Image = My.Resources.Pacman_Death__51
            Case = 6
                picPacman.Image = My.Resources.Pacman_Death_6
            Case = 7
                picPacman.Image = My.Resources.Pacman_Death_7
            Case = 8
                picPacman.Image = My.Resources.Pacman_Death_8
            Case 10
                If Lifes = 0 Then
                    Counter = 99
                Else
                    picPacman.Visible = False
                    Entities_Reset()
                End If
            Case 11
                lblReady.Visible = True
            Case 21
                lblReady.Visible = False
                tmrPacman.Start()
                tmrRed.Start()
                tmrPink.Start()
                tmrBlue.Start()
                tmrOrange.Start()
                tmrGhosts_Leave.Start()
                Wait = False
            Case 30
                Counter = 0
                tmrDeath.Stop()
            Case 100
                picPacman.Visible = False
                picRed.Visible = False
                picPink.Visible = False
                picBlue.Visible = False
                picOrange.Visible = False
                lblGameOver.Visible = True
                btnExit.Enabled = True
        End Select
        Counter = Counter + 1
    End Sub
    Private Sub tmrLevel_Change_Tick(sender As Object, e As EventArgs) Handles tmrLevel_Change.Tick
        'Resets the entire board back to the origianl load state
        Static Counter As Integer = 0
        Select Case Counter
            Case = 0
                tmrScared.Stop()
                Bonus_Score = 100
                Red_Scared = False
                Pink_Scared = False
                Blue_Scared = False
                Orange_Scared = False
                picRed.Visible = False
                picPink.Visible = False
                picBlue.Visible = False
                picOrange.Visible = False
            Case 1
                picGameboard_Blue.Image = My.Resources.Gameboard_2
            Case 3
                picGameboard_Blue.Image = My.Resources.Gameboard
            Case 5
                picGameboard_Blue.Image = My.Resources.Gameboard_2
            Case 7
                picGameboard_Blue.Image = My.Resources.Gameboard
            Case 9
                picGameboard_Blue.Image = My.Resources.Gameboard_2
            Case 11
                picGameboard_Blue.Image = My.Resources.Gameboard
            Case 13
                Entities_Reset()
                For x = 0 To 166
                    Dots(x).Visible = True
                    Dots_Eaten(x) = False
                Next
                For x = 0 To 3
                    Powerup(x).Visible = True
                    Powerup_Eaten(x) = False
                Next
            Case 14
                Fruit()
                lblReady.Visible = True
            Case 25
                lblReady.Visible = False
                tmrPacman.Start()
                tmrRed.Start()
                tmrPink.Start()
                tmrBlue.Start()
                tmrOrange.Start()
                tmrGhosts_Leave.Start()
                tmrFruit.Start()
                Counter = 0
                tmrLevel_Change.Stop()
        End Select
        Counter = Counter + 1
    End Sub
    Private Sub Fruit()
        If Level = 2 Then
            picFruit_2.Image = My.Resources.Strawberry
        ElseIf Level = 3 Then
            picFruit_3.Image = My.Resources.Pear
        ElseIf Level = 4 Then
            picFruit_4.Image = My.Resources.Pear
        ElseIf Level = 5 Then
            picFruit_5.Image = My.Resources.Apple
        ElseIf Level = 6 Then
            picFruit_6.Image = My.Resources.Mellon
        ElseIf Level = 7 Then
            picFruit_7.Image = My.Resources.Boss
        ElseIf Level = 8 Then
            picFruit_1.Image = picFruit_2.Image
            picFruit_2.Image = picFruit_3.Image
            picFruit_3.Image = picFruit_4.Image
            picFruit_4.Image = picFruit_5.Image
            picFruit_5.Image = picFruit_6.Image
            picFruit_6.Image = picFruit_7.Image
            picFruit_7.Image = My.Resources.Key
        ElseIf Level >= 9 Then
            picFruit_1.Image = picFruit_2.Image
            picFruit_2.Image = picFruit_3.Image
            picFruit_3.Image = picFruit_4.Image
            picFruit_4.Image = picFruit_5.Image
            picFruit_5.Image = picFruit_6.Image
            picFruit_6.Image = picFruit_7.Image
            picFruit_7.Image = My.Resources.Key
        End If
    End Sub
    Private Sub Entities_Reset()
        'Resets only the entites
        picPacman.Location = picPacman_Home.Location
        picRed.Location = picGhost_Exit.Location
        picPink.Location = picPink_Home.Location
        picBlue.Location = picBlue_Home.Location
        picOrange.Location = picOrange_Home.Location

        picPacman.Image = My.Resources.Pacman_Closed

        Red_Home = True
        Pink_Home = True
        Blue_Home = True
        Orange_Home = True

        Pacman_Up = False
        Pacman_Down = False
        Pacman_Left = False
        Pacman_Right = False
        Pacman_Able_Left_Right = True
        Pacman_Able_Up_Down = False
        Pacman_Key_Up = False
        Pacman_Key_Down = False
        Pacman_Key_Right = False
        Pacman_Key_Left = False

        Red_Up = False
        Red_Down = False
        Red_Left = True
        Red_Right = False
        picRed.Image = My.Resources.Red_Ghost_Left_Open

        Pink_Up = False
        Pink_Down = True
        Pink_Left = False
        Pink_Right = False
        picPink.Image = My.Resources.Pink_Ghost_Down_Open

        Blue_Up = True
        Blue_Down = False
        Blue_Left = False
        Blue_Right = False
        picBlue.Image = My.Resources.Blue_Ghost_Up_Open

        Orange_Up = True
        Orange_Down = False
        Orange_Left = False
        Orange_Right = False
        picOrange.Image = My.Resources.Orange_Ghost_Up_Open

        picPacman.Visible = True
        picRed.Visible = True
        picPink.Visible = True
        picBlue.Visible = True
        picOrange.Visible = True
    End Sub
    Private Sub Pacman_Direction()
        For x = 0 To 11
            'Up Left Right   <----- Indicates where pacman can move (Same theory applies to the ghosts)
            If picPacman.Location = Up_Left_Right(x).Location Then
                'This is Repeated throught all the pacman movement
                If Pacman_Key_Up = True Then
                    'Makes pacman move up if the player has last pressed either the "w" or "Up Arrow" Keys
                    Pacman_Up = True
                    Pacman_Down = False
                    Pacman_Left = False
                    Pacman_Right = False
                    'Using logic we can deduce that if pacman is going up he will be able to move both up before he hits
                    'the next picture box. So we allow him to do this (Thats what this code does)
                    Pacman_Able_Up_Down = True
                    Pacman_Able_Left_Right = False
                ElseIf Pacman_Key_Down = True Then
                    If Pacman_Left = True Or Pacman_Right = True Then
                    Else
                        Pacman_Up = False
                        Pacman_Down = False
                        Pacman_Left = False
                        Pacman_Right = False
                        Pacman_Able_Up_Down = False
                        Pacman_Able_Left_Right = False
                    End If
                ElseIf Pacman_Key_Left = True Then
                        Pacman_Up = False
                        Pacman_Down = False
                        Pacman_Left = True
                        Pacman_Right = False
                        Pacman_Able_Up_Down = False
                        Pacman_Able_Left_Right = True
                    ElseIf Pacman_Key_Right = True Then
                        Pacman_Up = False
                    Pacman_Down = False
                    Pacman_Left = False
                    Pacman_Right = True
                    Pacman_Able_Up_Down = False
                    Pacman_Able_Left_Right = True
                End If
            End If

        Next
        For x = 0 To 8
            'Down Right
            If picPacman.Location = Down_Right(x).Location Then
                If Pacman_Key_Up = True Then
                    Pacman_Up = False
                    Pacman_Down = False
                    Pacman_Left = False
                    Pacman_Right = False
                    Pacman_Able_Up_Down = False
                    Pacman_Able_Left_Right = False
                ElseIf Pacman_Key_Down = True Then
                    Pacman_Up = False
                    Pacman_Down = True
                    Pacman_Left = False
                    Pacman_Right = False
                    Pacman_Able_Up_Down = True
                    Pacman_Able_Left_Right = False
                ElseIf Pacman_Key_Left = True Then
                    Pacman_Up = False
                    Pacman_Down = False
                    Pacman_Left = False
                    Pacman_Right = False
                    Pacman_Able_Up_Down = False
                    Pacman_Able_Left_Right = False
                ElseIf Pacman_Key_Right = True Then
                    Pacman_Up = False
                    Pacman_Down = False
                    Pacman_Left = False
                    Pacman_Right = True
                    Pacman_Able_Up_Down = False
                    Pacman_Able_Left_Right = True
                End If
            End If
            'Down Left
            If picPacman.Location = Down_Left(x).Location Then
                If Pacman_Key_Up = True Then
                    Pacman_Up = False
                    Pacman_Down = False
                    Pacman_Left = False
                    Pacman_Right = False
                    Pacman_Able_Up_Down = False
                    Pacman_Able_Left_Right = False
                ElseIf Pacman_Key_Down = True Then
                    Pacman_Up = False
                    Pacman_Down = True
                    Pacman_Left = False
                    Pacman_Right = False
                    Pacman_Able_Up_Down = True
                    Pacman_Able_Left_Right = False
                ElseIf Pacman_Key_Left = True Then
                    Pacman_Up = False
                    Pacman_Down = False
                    Pacman_Left = True
                    Pacman_Right = False
                    Pacman_Able_Up_Down = False
                    Pacman_Able_Left_Right = True
                ElseIf Pacman_Key_Right = True Then
                    Pacman_Up = False
                    Pacman_Down = False
                    Pacman_Left = False
                    Pacman_Right = False
                    Pacman_Able_Up_Down = False
                    Pacman_Able_Left_Right = False
                End If
            End If
        Next
        For x = 0 To 5
            'Down Left Right
            If picPacman.Location = Down_Left_Right(x).Location Then
                If Pacman_Key_Up = True Then
                    If Pacman_Left = True Or Pacman_Right = True Then
                    Else
                        Pacman_Up = False
                        Pacman_Down = False
                        Pacman_Left = False
                        Pacman_Right = False
                        Pacman_Able_Up_Down = False
                        Pacman_Able_Left_Right = False
                    End If
                ElseIf Pacman_Key_Down = True Then
                    Pacman_Up = False
                    Pacman_Down = True
                    Pacman_Left = False
                    Pacman_Right = False
                ElseIf Pacman_Key_Left = True Then
                    Pacman_Up = False
                    Pacman_Down = False
                    Pacman_Left = True
                    Pacman_Right = False
                    Pacman_Able_Up_Down = False
                    Pacman_Able_Left_Right = True
                ElseIf Pacman_Key_Right = True Then
                    Pacman_Up = False
                    Pacman_Down = False
                    Pacman_Left = False
                    Pacman_Right = True
                    Pacman_Able_Up_Down = False
                    Pacman_Able_Left_Right = True
                End If
            End If
            'All
            If picPacman.Location = All(x).Location Then
                If Pacman_Key_Up = True Then
                    Pacman_Up = True
                    Pacman_Down = False
                    Pacman_Left = False
                    Pacman_Right = False
                    Pacman_Able_Up_Down = True
                    Pacman_Able_Left_Right = False
                ElseIf Pacman_Key_Down = True Then
                    Pacman_Up = False
                    Pacman_Down = True
                    Pacman_Left = False
                    Pacman_Right = False
                    Pacman_Able_Up_Down = True
                    Pacman_Able_Left_Right = False
                ElseIf Pacman_Key_Left = True Then
                    Pacman_Up = False
                    Pacman_Down = False
                    Pacman_Left = True
                    Pacman_Right = False
                    Pacman_Able_Up_Down = False
                    Pacman_Able_Left_Right = True
                ElseIf Pacman_Key_Right = True Then
                    Pacman_Up = False
                    Pacman_Down = False
                    Pacman_Left = False
                    Pacman_Right = True
                    Pacman_Able_Up_Down = False
                    Pacman_Able_Left_Right = True
                End If
            End If
            'Up Left
            If picPacman.Location = Up_Left(x).Location Then
                If Pacman_Key_Up = True Then
                    Pacman_Up = True
                    Pacman_Down = False
                    Pacman_Left = False
                    Pacman_Right = False
                    Pacman_Able_Up_Down = True
                    Pacman_Able_Left_Right = False
                ElseIf Pacman_Key_Down = True Then
                    Pacman_Up = False
                    Pacman_Down = False
                    Pacman_Left = False
                    Pacman_Right = False
                    Pacman_Able_Up_Down = False
                    Pacman_Able_Left_Right = False
                ElseIf Pacman_Key_Left = True Then
                    Pacman_Up = False
                    Pacman_Down = False
                    Pacman_Left = True
                    Pacman_Right = False
                    Pacman_Able_Up_Down = False
                    Pacman_Able_Left_Right = True
                ElseIf Pacman_Key_Right = True Then
                    Pacman_Up = False
                    Pacman_Down = False
                    Pacman_Left = False
                    Pacman_Right = False
                    Pacman_Able_Up_Down = False
                    Pacman_Able_Left_Right = False
                End If
            End If
            'Up Right
            If picPacman.Location = Up_Right(x).Location Then
                If Pacman_Key_Up = True Then
                    Pacman_Up = True
                    Pacman_Down = False
                    Pacman_Left = False
                    Pacman_Right = False
                    Pacman_Able_Up_Down = True
                    Pacman_Able_Left_Right = False
                ElseIf Pacman_Key_Down = True Then
                    Pacman_Up = False
                    Pacman_Down = False
                    Pacman_Left = False
                    Pacman_Right = False
                    Pacman_Able_Up_Down = False
                    Pacman_Able_Left_Right = False
                ElseIf Pacman_Key_Left = True Then
                    Pacman_Up = False
                    Pacman_Down = False
                    Pacman_Left = False
                    Pacman_Right = False
                    Pacman_Able_Up_Down = False
                    Pacman_Able_Left_Right = False
                ElseIf Pacman_Key_Right = True Then
                    Pacman_Up = False
                    Pacman_Down = False
                    Pacman_Left = False
                    Pacman_Right = True
                    Pacman_Able_Up_Down = False
                    Pacman_Able_Left_Right = True
                End If
            End If
        Next
        For x = 0 To 4
            'Up Down Left
            If picPacman.Location = Up_Down_Left(x).Location Then
                If Pacman_Key_Up = True Then
                    Pacman_Up = True
                    Pacman_Down = False
                    Pacman_Left = False
                    Pacman_Right = False
                    Pacman_Able_Up_Down = True
                    Pacman_Able_Left_Right = False
                ElseIf Pacman_Key_Down = True Then
                    Pacman_Up = False
                    Pacman_Down = True
                    Pacman_Left = False
                    Pacman_Right = False
                    Pacman_Able_Up_Down = True
                    Pacman_Able_Left_Right = False
                ElseIf Pacman_Key_Left = True Then
                    Pacman_Up = False
                    Pacman_Down = False
                    Pacman_Left = True
                    Pacman_Right = False
                    Pacman_Able_Up_Down = False
                    Pacman_Able_Left_Right = True
                ElseIf Pacman_Key_Right = True Then
                    If Pacman_Up = True Or Pacman_Down = True Then
                    Else
                        Pacman_Up = False
                        Pacman_Down = False
                        Pacman_Left = False
                        Pacman_Right = False
                        Pacman_Able_Up_Down = False
                        Pacman_Able_Left_Right = False
                    End If
                End If
                End If
            'Up Down Right
            If picPacman.Location = Up_Down_Right(x).Location Then
                If Pacman_Key_Up = True Then
                    Pacman_Up = True
                    Pacman_Down = False
                    Pacman_Left = False
                    Pacman_Right = False
                    Pacman_Able_Up_Down = True
                    Pacman_Able_Left_Right = False
                ElseIf Pacman_Key_Down = True Then
                    Pacman_Up = False
                    Pacman_Down = True
                    Pacman_Left = False
                    Pacman_Right = False
                    Pacman_Able_Up_Down = True
                    Pacman_Able_Left_Right = False
                ElseIf Pacman_Key_Left = True Then
                    If Pacman_Up = True Or Pacman_Down = True Then
                    Else
                        Pacman_Up = False
                        Pacman_Down = False
                        Pacman_Left = False
                        Pacman_Right = False
                        Pacman_Able_Up_Down = False
                        Pacman_Able_Left_Right = False
                    End If
                ElseIf Pacman_Key_Right = True Then
                        Pacman_Up = False
                    Pacman_Down = False
                    Pacman_Left = False
                    Pacman_Right = True
                    Pacman_Able_Up_Down = False
                    Pacman_Able_Left_Right = True
                End If
            End If
        Next
        'Teleports pacman to the other side of the screen when he enters the portal
        If picPacman.Bounds.IntersectsWith(Portal_Right.Bounds) Then
            picPacman.Location = Portal_Left_Exit.Location
        ElseIf picPacman.Bounds.IntersectsWith(Portal_Left.Bounds) Then
            picPacman.Location = Portal_Right_Exit.Location
        End If
    End Sub
    Private Sub Red_Direction()
        Dim Random As Decimal
        Dim Retry As Boolean = False
        For x = 0 To 11
            'Up Left Right
            If picRed.Location = Up_Left_Right(x).Location Then
                'Again this applies for all code gost code
                'Selects a random number
                Random = Int(3 * Rnd())
                'Uses the Random number to choose a direction
                Do
                    Select Case Random
                        Case = 0
                            If Red_Down = True Then
                                'Since this will make the ghost go backwards the code adds one to the currents random
                                'Number. This is done to ensure that there isnt a infinte loop of "wrong" numbers
                                Random = Random + 1
                                Retry = True 'Makes the code retry and choose another direction
                            Else
                                Red_Up = True
                                Red_Down = False
                                Red_Left = False
                                Red_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Red_Right = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Red_Up = False
                                Red_Down = False
                                Red_Left = True
                                Red_Right = False
                                Retry = False
                            End If
                        Case = 2
                            If Red_Left = True Then
                                Random = Random - 1
                                Retry = True
                            Else
                                Red_Down = False
                                Red_Left = False
                                Red_Right = True
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
        Next
        For x = 0 To 8
            'Down Right
            If picRed.Location = Down_Right(x).Location Then
                Random = Int(2 * Rnd())
                Do
                    Select Case Random
                        Case = 0
                            If Red_Up = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Red_Up = False
                                Red_Down = True
                                Red_Left = False
                                Red_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Red_Left = True Then
                                Random = Random - 1
                                Retry = True
                            ElseIf Red_Up = True Then
                                Red_Up = False
                                Red_Down = False
                                Red_Left = False
                                Red_Right = True
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
            'Down Left
            If picRed.Location = Down_Left(x).Location Then
                Random = Int(2 * Rnd())
                Do
                    Select Case Random
                        Case = 0
                            If Red_Up = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Red_Up = False
                                Red_Down = True
                                Red_Left = False
                                Red_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Red_Right = True Then
                                Random = Random - 1
                                Retry = True
                            Else
                                Red_Up = False
                                Red_Down = False
                                Red_Left = True
                                Red_Right = False
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
        Next
        For x = 0 To 5
            'Down Left Right
            If picRed.Location = Down_Left_Right(x).Location Then
                Random = Int(3 * Rnd())
                Do
                    Select Case Random
                        Case = 0
                            If Red_Up = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Red_Up = False
                                Red_Down = True
                                Red_Left = False
                                Red_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Red_Right = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Red_Up = False
                                Red_Down = False
                                Red_Left = True
                                Red_Right = False
                                Retry = False
                            End If
                        Case = 2
                            If Red_Left = True Then
                                Random = Random - 1
                                Retry = True
                            Else
                                Red_Up = False
                                Red_Down = False
                                Red_Left = False
                                Red_Right = True
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
            'All
            If picRed.Location = All(x).Location Then
                Random = Int(4 * Rnd())
                Do
                    Select Case Random
                        Case = 0
                            If Red_Down = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Red_Up = True
                                Red_Down = False
                                Red_Left = False
                                Red_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Red_Up = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Red_Up = False
                                Red_Down = True
                                Red_Left = False
                                Red_Right = False
                                Retry = False
                            End If
                        Case = 2
                            If Red_Right = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Red_Up = False
                                Red_Down = False
                                Red_Left = True
                                Red_Right = False
                                Retry = False
                            End If
                        Case = 3
                            If Red_Left = True Then
                                Random = Random - 1
                                Retry = True
                            Else
                                Red_Up = False
                                Red_Down = False
                                Red_Left = False
                                Red_Right = True
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
            'Up Left
            If picRed.Location = Up_Left(x).Location Then
                Random = Int(2 * Rnd())
                Do
                    Select Case Random
                        Case = 0
                            If Red_Down = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Red_Up = True
                                Red_Down = False
                                Red_Left = False
                                Red_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Red_Right = True Then
                                Random = Random - 1
                                Retry = True
                            Else
                                Red_Up = False
                                Red_Down = False
                                Red_Left = True
                                Red_Right = False
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
            'Up Right
            If picRed.Location = Up_Right(x).Location Then
                Random = Int(2 * Rnd())
                Do
                    Select Case Random
                        Case = 0
                            If Red_Down = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Red_Up = True
                                Red_Down = False
                                Red_Left = False
                                Red_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Red_Left = True Then
                                Random = Random - 1
                                Retry = True
                            Else
                                Red_Up = False
                                Red_Down = False
                                Red_Left = False
                                Red_Right = True
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
        Next
        For x = 0 To 4
            'Up Down Left
            If picRed.Location = Up_Down_Left(x).Location Then
                Random = Int(3 * Rnd())
                Do
                    Select Case Random
                        Case = 0
                            If Red_Down = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Red_Up = True
                                Red_Down = False
                                Red_Left = False
                                Red_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Red_Up = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Red_Up = False
                                Red_Down = True
                                Red_Left = False
                                Red_Right = False
                                Retry = False
                            End If
                        Case = 2
                            If Red_Right = True Then
                                Random = Random - 1
                                Retry = True
                            Else
                                Red_Up = False
                                Red_Down = False
                                Red_Left = True
                                Red_Right = False
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
            'Up Down Right
            If picRed.Location = Up_Down_Right(x).Location Then
                Random = Int(3 * Rnd())
                Do
                    Select Case Random
                        Case = 0
                            If Red_Down = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Red_Up = True
                                Red_Down = False
                                Red_Left = False
                                Red_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Red_Up = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Red_Up = False
                                Red_Down = True
                                Red_Left = False
                                Red_Right = False
                                Retry = False
                            End If
                        Case = 2
                            If Red_Left = True Then
                                Random = Random - 1
                                Retry = True
                            Else
                                Red_Up = False
                                Red_Down = False
                                Red_Left = False
                                Red_Right = True
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
        Next
        If picRed.Bounds.IntersectsWith(Portal_Right.Bounds) Then
            picRed.Location = Portal_Left_Exit.Location
        ElseIf picRed.Bounds.IntersectsWith(Portal_Left.Bounds) Then
            picRed.Location = Portal_Right_Exit.Location
        End If
    End Sub
    Private Sub Pink_Direction()
        Dim Random As Decimal
        Dim Retry As Boolean = False
        For x = 0 To 11
            'Up Left Right
            If picPink.Location = Up_Left_Right(x).Location Then
                'Selects a random number
                Random = Int(3 * Rnd())
                'Uses the Random number to choose a direction
                Do
                    Select Case Random
                        Case = 0
                            If Pink_Down = True Then
                                'Since this will make the ghost go backwards
                                'this forces the code to make a New number
                                Random = Random + 1
                                Retry = True
                            Else
                                Pink_Up = True
                                Pink_Down = False
                                Pink_Left = False
                                Pink_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Pink_Right = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Pink_Up = False
                                Pink_Down = False
                                Pink_Left = True
                                Pink_Right = False
                                Retry = False
                            End If
                        Case = 2
                            If Pink_Left = True Then
                                Random = Random - 1
                                Retry = True
                            Else
                                Pink_Down = False
                                Pink_Left = False
                                Pink_Right = True
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
        Next
        For x = 0 To 8
            'Down Right
            If picPink.Location = Down_Right(x).Location Then
                Random = Int(2 * Rnd())
                Do
                    Select Case Random
                        Case = 0
                            If Pink_Up = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Pink_Up = False
                                Pink_Down = True
                                Pink_Left = False
                                Pink_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Pink_Left = True Then
                                Random = Random - 1
                                Retry = True
                            ElseIf Pink_Up = True Then
                                Pink_Up = False
                                Pink_Down = False
                                Pink_Left = False
                                Pink_Right = True
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
            'Down Left
            If picPink.Location = Down_Left(x).Location Then
                Random = Int(2 * Rnd())
                Do
                    Select Case Random
                        Case = 0
                            If Pink_Up = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Pink_Up = False
                                Pink_Down = True
                                Pink_Left = False
                                Pink_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Pink_Right = True Then
                                Random = Random - 1
                                Retry = True
                            Else
                                Pink_Up = False
                                Pink_Down = False
                                Pink_Left = True
                                Pink_Right = False
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
        Next
        For x = 0 To 5
            'Down Left Right
            If picPink.Location = Down_Left_Right(x).Location Then
                Random = Int(3 * Rnd())
                Do
                    Select Case Random
                        Case = 0
                            If Pink_Up = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Pink_Up = False
                                Pink_Down = True
                                Pink_Left = False
                                Pink_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Pink_Right = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Pink_Up = False
                                Pink_Down = False
                                Pink_Left = True
                                Pink_Right = False
                                Retry = False
                            End If
                        Case = 2
                            If Pink_Left = True Then
                                Random = Random - 1
                                Retry = True
                            Else
                                Pink_Up = False
                                Pink_Down = False
                                Pink_Left = False
                                Pink_Right = True
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
            'All
            If picPink.Location = All(x).Location Then
                Random = Int(4 * Rnd())
                Do
                    Select Case Random
                        Case = 0
                            If Pink_Down = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Pink_Up = True
                                Pink_Down = False
                                Pink_Left = False
                                Pink_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Pink_Up = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Pink_Up = False
                                Pink_Down = True
                                Pink_Left = False
                                Pink_Right = False
                                Retry = False
                            End If
                        Case = 2
                            If Pink_Right = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Pink_Up = False
                                Pink_Down = False
                                Pink_Left = True
                                Pink_Right = False
                                Retry = False
                            End If
                        Case = 3
                            If Pink_Left = True Then
                                Random = Random - 1
                                Retry = True
                            Else
                                Pink_Up = False
                                Pink_Down = False
                                Pink_Left = False
                                Pink_Right = True
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
            'Up Left
            If picPink.Location = Up_Left(x).Location Then
                Random = Int(2 * Rnd())
                Do
                    Select Case Random
                        Case = 0
                            If Pink_Down = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Pink_Up = True
                                Pink_Down = False
                                Pink_Left = False
                                Pink_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Pink_Right = True Then
                                Random = Random - 1
                                Retry = True
                            Else
                                Pink_Up = False
                                Pink_Down = False
                                Pink_Left = True
                                Pink_Right = False
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
            'Up Right
            If picPink.Location = Up_Right(x).Location Then
                Random = Int(2 * Rnd())
                Do
                    Select Case Random
                        Case = 0
                            If Pink_Down = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Pink_Up = True
                                Pink_Down = False
                                Pink_Left = False
                                Pink_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Pink_Left = True Then
                                Random = Random - 1
                                Retry = True
                            Else
                                Pink_Up = False
                                Pink_Down = False
                                Pink_Left = False
                                Pink_Right = True
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
        Next
        For x = 0 To 4
            'Up Down Left
            If picPink.Location = Up_Down_Left(x).Location Then
                Random = Int(3 * Rnd())
                Do
                    Select Case Random
                        Case = 0
                            If Pink_Down = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Pink_Up = True
                                Pink_Down = False
                                Pink_Left = False
                                Pink_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Pink_Up = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Pink_Up = False
                                Pink_Down = True
                                Pink_Left = False
                                Pink_Right = False
                                Retry = False
                            End If
                        Case = 2
                            If Pink_Right = True Then
                                Random = Random - 1
                                Retry = True
                            Else
                                Pink_Up = False
                                Pink_Down = False
                                Pink_Left = True
                                Pink_Right = False
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
            'Up Down Right
            If picPink.Location = Up_Down_Right(x).Location Then
                Random = Int(3 * Rnd())
                Do
                    Select Case Random
                        Case = 0
                            If Pink_Down = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Pink_Up = True
                                Pink_Down = False
                                Pink_Left = False
                                Pink_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Pink_Up = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Pink_Up = False
                                Pink_Down = True
                                Pink_Left = False
                                Pink_Right = False
                                Retry = False
                            End If
                        Case = 2
                            If Pink_Left = True Then
                                Random = Random - 1
                                Retry = True
                            Else
                                Pink_Up = False
                                Pink_Down = False
                                Pink_Left = False
                                Pink_Right = True
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
        Next
        If picPink.Bounds.IntersectsWith(Portal_Right.Bounds) Then
            picPink.Location = Portal_Left_Exit.Location
        ElseIf picPink.Bounds.IntersectsWith(Portal_Left.Bounds) Then
            picPink.Location = Portal_Right_Exit.Location
        End If
    End Sub
    Private Sub Blue_Direction()
        Dim Random As Decimal
        Dim Retry As Boolean = False
        For x = 0 To 11
            'Up Left Right
            If picBlue.Location = Up_Left_Right(x).Location Then
                'Selects a random number
                Random = Int(3 * Rnd())
                'Uses the Random number to choose a direction
                Do
                    Select Case Random
                        Case = 0
                            If Blue_Down = True Then
                                'Since this will make the ghost go backwards
                                'this forces the code to make a New number
                                Random = Random + 1
                                Retry = True
                            Else
                                Blue_Up = True
                                Blue_Down = False
                                Blue_Left = False
                                Blue_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Blue_Right = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Blue_Up = False
                                Blue_Down = False
                                Blue_Left = True
                                Blue_Right = False
                                Retry = False
                            End If
                        Case = 2
                            If Blue_Left = True Then
                                Random = Random - 1
                                Retry = True
                            Else
                                Blue_Down = False
                                Blue_Left = False
                                Blue_Right = True
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
        Next
        For x = 0 To 8
            'Down Right
            If picBlue.Location = Down_Right(x).Location Then
                Random = Int(2 * Rnd())
                Do
                    Select Case Random
                        Case = 0
                            If Blue_Up = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Blue_Up = False
                                Blue_Down = True
                                Blue_Left = False
                                Blue_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Blue_Left = True Then
                                Random = Random - 1
                                Retry = True
                            ElseIf Blue_Up = True Then
                                Blue_Up = False
                                Blue_Down = False
                                Blue_Left = False
                                Blue_Right = True
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
            'Down Left
            If picBlue.Location = Down_Left(x).Location Then
                Random = Int(2 * Rnd())
                Do
                    Select Case Random
                        Case = 0
                            If Blue_Up = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Blue_Up = False
                                Blue_Down = True
                                Blue_Left = False
                                Blue_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Blue_Right = True Then
                                Random = Random - 1
                                Retry = True
                            Else
                                Blue_Up = False
                                Blue_Down = False
                                Blue_Left = True
                                Blue_Right = False
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
        Next
        For x = 0 To 5
            'Down Left Right
            If picBlue.Location = Down_Left_Right(x).Location Then
                Random = Int(3 * Rnd())
                Do
                    Select Case Random
                        Case = 0
                            If Blue_Up = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Blue_Up = False
                                Blue_Down = True
                                Blue_Left = False
                                Blue_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Blue_Right = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Blue_Up = False
                                Blue_Down = False
                                Blue_Left = True
                                Blue_Right = False
                                Retry = False
                            End If
                        Case = 2
                            If Blue_Left = True Then
                                Random = Random - 1
                                Retry = True
                            Else
                                Blue_Up = False
                                Blue_Down = False
                                Blue_Left = False
                                Blue_Right = True
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
            'All
            If picBlue.Location = All(x).Location Then
                Random = Int(4 * Rnd())
                Do
                    Select Case Random
                        Case = 0
                            If Blue_Down = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Blue_Up = True
                                Blue_Down = False
                                Blue_Left = False
                                Blue_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Blue_Up = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Blue_Up = False
                                Blue_Down = True
                                Blue_Left = False
                                Blue_Right = False
                                Retry = False
                            End If
                        Case = 2
                            If Blue_Right = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Blue_Up = False
                                Blue_Down = False
                                Blue_Left = True
                                Blue_Right = False
                                Retry = False
                            End If
                        Case = 3
                            If Blue_Left = True Then
                                Random = Random - 1
                                Retry = True
                            Else
                                Blue_Up = False
                                Blue_Down = False
                                Blue_Left = False
                                Blue_Right = True
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
            'Up Left
            If picBlue.Location = Up_Left(x).Location Then
                Random = Int(2 * Rnd())
                Do
                    Select Case Random
                        Case = 0
                            If Blue_Down = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Blue_Up = True
                                Blue_Down = False
                                Blue_Left = False
                                Blue_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Blue_Right = True Then
                                Random = Random - 1
                                Retry = True
                            Else
                                Blue_Up = False
                                Blue_Down = False
                                Blue_Left = True
                                Blue_Right = False
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
            'Up Right
            If picBlue.Location = Up_Right(x).Location Then
                Random = Int(2 * Rnd())
                Do
                    Select Case Random
                        Case = 0
                            If Blue_Down = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Blue_Up = True
                                Blue_Down = False
                                Blue_Left = False
                                Blue_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Blue_Left = True Then
                                Random = Random - 1
                                Retry = True
                            Else
                                Blue_Up = False
                                Blue_Down = False
                                Blue_Left = False
                                Blue_Right = True
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
        Next
        For x = 0 To 4
            'Up Down Left
            If picBlue.Location = Up_Down_Left(x).Location Then
                Random = Int(3 * Rnd())
                Do
                    Select Case Random
                        Case = 0
                            If Blue_Down = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Blue_Up = True
                                Blue_Down = False
                                Blue_Left = False
                                Blue_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Blue_Up = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Blue_Up = False
                                Blue_Down = True
                                Blue_Left = False
                                Blue_Right = False
                                Retry = False
                            End If
                        Case = 2
                            If Blue_Right = True Then
                                Random = Random - 1
                                Retry = True
                            Else
                                Blue_Up = False
                                Blue_Down = False
                                Blue_Left = True
                                Blue_Right = False
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
            'Up Down Right
            If picBlue.Location = Up_Down_Right(x).Location Then
                Random = Int(3 * Rnd())
                Do
                    Select Case Random
                        Case = 0
                            If Blue_Down = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Blue_Up = True
                                Blue_Down = False
                                Blue_Left = False
                                Blue_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Blue_Up = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Blue_Up = False
                                Blue_Down = True
                                Blue_Left = False
                                Blue_Right = False
                                Retry = False
                            End If
                        Case = 2
                            If Blue_Left = True Then
                                Random = Random - 1
                                Retry = True
                            Else
                                Blue_Up = False
                                Blue_Down = False
                                Blue_Left = False
                                Blue_Right = True
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
        Next
        If picBlue.Bounds.IntersectsWith(Portal_Right.Bounds) Then
            picBlue.Location = Portal_Left_Exit.Location
        ElseIf picBlue.Bounds.IntersectsWith(Portal_Left.Bounds) Then
            picBlue.Location = Portal_Right_Exit.Location
        End If
    End Sub
    Private Sub Orange_Direction()
        Dim Random As Decimal
        Dim Retry As Boolean = False
        For x = 0 To 11
            'Up Left Right
            If picOrange.Location = Up_Left_Right(x).Location Then
                'Selects a random number
                Random = Int(3 * Rnd())
                'Uses the Random number to choose a direction
                Do
                    Select Case Random
                        Case = 0
                            If Orange_Down = True Then
                                'Since this will make the ghost go backwards
                                'this forces the code to make a New number
                                Random = Random + 1
                                Retry = True
                            Else
                                Orange_Up = True
                                Orange_Down = False
                                Orange_Left = False
                                Orange_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Orange_Right = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Orange_Up = False
                                Orange_Down = False
                                Orange_Left = True
                                Orange_Right = False
                                Retry = False
                            End If
                        Case = 2
                            If Orange_Left = True Then
                                Random = Random - 1
                                Retry = True
                            Else
                                Orange_Down = False
                                Orange_Left = False
                                Orange_Right = True
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
        Next
        For x = 0 To 8
            'Down Right
            If picOrange.Location = Down_Right(x).Location Then
                Random = Int(2 * Rnd())
                Do
                    Select Case Random
                        Case = 0
                            If Orange_Up = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Orange_Up = False
                                Orange_Down = True
                                Orange_Left = False
                                Orange_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Orange_Left = True Then
                                Random = Random - 1
                                Retry = True
                            ElseIf Orange_Up = True Then
                                Orange_Up = False
                                Orange_Down = False
                                Orange_Left = False
                                Orange_Right = True
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
            'Down Left
            If picOrange.Location = Down_Left(x).Location Then
                Random = Int(2 * Rnd())
                Do
                    Select Case Random
                        Case = 0
                            If Orange_Up = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Orange_Up = False
                                Orange_Down = True
                                Orange_Left = False
                                Orange_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Orange_Right = True Then
                                Random = Random - 1
                                Retry = True
                            Else
                                Orange_Up = False
                                Orange_Down = False
                                Orange_Left = True
                                Orange_Right = False
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
        Next
        For x = 0 To 5
            'Down Left Right
            If picOrange.Location = Down_Left_Right(x).Location Then
                Random = Int(3 * Rnd())
                Do
                    Select Case Random
                        Case = 0
                            If Orange_Up = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Orange_Up = False
                                Orange_Down = True
                                Orange_Left = False
                                Orange_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Orange_Right = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Orange_Up = False
                                Orange_Down = False
                                Orange_Left = True
                                Orange_Right = False
                                Retry = False
                            End If
                        Case = 2
                            If Orange_Left = True Then
                                Random = Random - 1
                                Retry = True
                            Else
                                Orange_Up = False
                                Orange_Down = False
                                Orange_Left = False
                                Orange_Right = True
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
            'All
            If picOrange.Location = All(x).Location Then
                Random = Int(4 * Rnd())
                Do
                    Select Case Random
                        Case = 0
                            If Orange_Down = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Orange_Up = True
                                Orange_Down = False
                                Orange_Left = False
                                Orange_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Orange_Up = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Orange_Up = False
                                Orange_Down = True
                                Orange_Left = False
                                Orange_Right = False
                                Retry = False
                            End If
                        Case = 2
                            If Orange_Right = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Orange_Up = False
                                Orange_Down = False
                                Orange_Left = True
                                Orange_Right = False
                                Retry = False
                            End If
                        Case = 3
                            If Orange_Left = True Then
                                Random = Random - 1
                                Retry = True
                            Else
                                Orange_Up = False
                                Orange_Down = False
                                Orange_Left = False
                                Orange_Right = True
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
            'Up Left
            If picOrange.Location = Up_Left(x).Location Then
                Random = Int(2 * Rnd())
                Do
                    Select Case Random
                        Case = 0
                            If Orange_Down = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Orange_Up = True
                                Orange_Down = False
                                Orange_Left = False
                                Orange_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Orange_Right = True Then
                                Random = Random - 1
                                Retry = True
                            Else
                                Orange_Up = False
                                Orange_Down = False
                                Orange_Left = True
                                Orange_Right = False
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
            'Up Right
            If picOrange.Location = Up_Right(x).Location Then
                Random = Int(2 * Rnd())
                Do
                    Select Case Random
                        Case = 0
                            If Orange_Down = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Orange_Up = True
                                Orange_Down = False
                                Orange_Left = False
                                Orange_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Orange_Left = True Then
                                Random = Random - 1
                                Retry = True
                            Else
                                Orange_Up = False
                                Orange_Down = False
                                Orange_Left = False
                                Orange_Right = True
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
        Next
        For x = 0 To 4
            'Up Down Left
            If picOrange.Location = Up_Down_Left(x).Location Then
                Random = Int(3 * Rnd())
                Do
                    Select Case Random
                        Case = 0
                            If Orange_Down = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Orange_Up = True
                                Orange_Down = False
                                Orange_Left = False
                                Orange_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Orange_Up = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Orange_Up = False
                                Orange_Down = True
                                Orange_Left = False
                                Orange_Right = False
                                Retry = False
                            End If
                        Case = 2
                            If Orange_Right = True Then
                                Random = Random - 1
                                Retry = True
                            Else
                                Orange_Up = False
                                Orange_Down = False
                                Orange_Left = True
                                Orange_Right = False
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
            'Up Down Right
            If picOrange.Location = Up_Down_Right(x).Location Then
                Random = Int(3 * Rnd())
                Do
                    Select Case Random
                        Case = 0
                            If Orange_Down = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Orange_Up = True
                                Orange_Down = False
                                Orange_Left = False
                                Orange_Right = False
                                Retry = False
                            End If
                        Case = 1
                            If Orange_Up = True Then
                                Random = Random + 1
                                Retry = True
                            Else
                                Orange_Up = False
                                Orange_Down = True
                                Orange_Left = False
                                Orange_Right = False
                                Retry = False
                            End If
                        Case = 2
                            If Orange_Left = True Then
                                Random = Random - 1
                                Retry = True
                            Else
                                Orange_Up = False
                                Orange_Down = False
                                Orange_Left = False
                                Orange_Right = True
                                Retry = False
                            End If
                    End Select
                Loop Until Retry = False
            End If
        Next
        If picOrange.Bounds.IntersectsWith(Portal_Right.Bounds) Then
            picOrange.Location = Portal_Left_Exit.Location
        ElseIf picOrange.Bounds.IntersectsWith(Portal_Left.Bounds) Then
            picOrange.Location = Portal_Right_Exit.Location
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the Gameboard and shows the startscreen. This can only happen after a game over.
        Me.Close()
        Start_Screen_2.Show()
    End Sub
End Class