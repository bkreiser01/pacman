<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lbl1Up = New System.Windows.Forms.Label()
        Me.lblHighScore = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl2Up = New System.Windows.Forms.Label()
        Me.lblInto = New System.Windows.Forms.Label()
        Me.lblShadow = New System.Windows.Forms.Label()
        Me.lblBlinky = New System.Windows.Forms.Label()
        Me.lblSpeedy = New System.Windows.Forms.Label()
        Me.lblPinky = New System.Windows.Forms.Label()
        Me.lblBashful = New System.Windows.Forms.Label()
        Me.lblInky = New System.Windows.Forms.Label()
        Me.lblPokey = New System.Windows.Forms.Label()
        Me.lbl10pts = New System.Windows.Forms.Label()
        Me.lbl50pts = New System.Windows.Forms.Label()
        Me.lbl10 = New System.Windows.Forms.Label()
        Me.lbl50 = New System.Windows.Forms.Label()
        Me.lblMidway = New System.Windows.Forms.Label()
        Me.lblCredits = New System.Windows.Forms.Label()
        Me.lblClide = New System.Windows.Forms.Label()
        Me.Load = New System.Windows.Forms.Timer(Me.components)
        Me.Blinking = New System.Windows.Forms.Timer(Me.components)
        Me.picPacman = New System.Windows.Forms.PictureBox()
        Me.picOrange = New System.Windows.Forms.PictureBox()
        Me.picBlue = New System.Windows.Forms.PictureBox()
        Me.picPink = New System.Windows.Forms.PictureBox()
        Me.picRed = New System.Windows.Forms.PictureBox()
        Me.pic_Powerup = New System.Windows.Forms.PictureBox()
        Me.picOrange_Static = New System.Windows.Forms.PictureBox()
        Me.picBlue_Static = New System.Windows.Forms.PictureBox()
        Me.picPink_Static = New System.Windows.Forms.PictureBox()
        Me.picRed_Static = New System.Windows.Forms.PictureBox()
        Me.picPowerup_Static = New System.Windows.Forms.PictureBox()
        Me.picDot = New System.Windows.Forms.PictureBox()
        Me.tmrPacman = New System.Windows.Forms.Timer(Me.components)
        Me.tmrWait = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGhosts = New System.Windows.Forms.Timer(Me.components)
        Me.lblScore = New System.Windows.Forms.Label()
        Me.Move = New System.Windows.Forms.Timer(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        CType(Me.picPacman, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOrange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Powerup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOrange_Static, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBlue_Static, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPink_Static, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRed_Static, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPowerup_Static, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl1Up
        '
        Me.lbl1Up.AutoSize = True
        Me.lbl1Up.Font = New System.Drawing.Font("Lucida Console", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1Up.Location = New System.Drawing.Point(58, 31)
        Me.lbl1Up.Name = "lbl1Up"
        Me.lbl1Up.Size = New System.Drawing.Size(78, 34)
        Me.lbl1Up.TabIndex = 1
        Me.lbl1Up.Text = "1UP"
        '
        'lblHighScore
        '
        Me.lblHighScore.AutoSize = True
        Me.lblHighScore.Font = New System.Drawing.Font("Lucida Console", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighScore.Location = New System.Drawing.Point(340, 31)
        Me.lblHighScore.Name = "lblHighScore"
        Me.lblHighScore.Size = New System.Drawing.Size(225, 34)
        Me.lblHighScore.TabIndex = 2
        Me.lblHighScore.Text = "HIGH SCORE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Console", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(105, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 34)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "00"
        '
        'lbl2Up
        '
        Me.lbl2Up.AutoSize = True
        Me.lbl2Up.Font = New System.Drawing.Font("Lucida Console", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2Up.Location = New System.Drawing.Point(768, 31)
        Me.lbl2Up.Name = "lbl2Up"
        Me.lbl2Up.Size = New System.Drawing.Size(78, 34)
        Me.lbl2Up.TabIndex = 10
        Me.lbl2Up.Text = "2UP"
        '
        'lblInto
        '
        Me.lblInto.AutoSize = True
        Me.lblInto.Font = New System.Drawing.Font("Lucida Console", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInto.Location = New System.Drawing.Point(150, 140)
        Me.lblInto.Name = "lblInto"
        Me.lblInto.Size = New System.Drawing.Size(603, 34)
        Me.lblInto.TabIndex = 11
        Me.lblInto.Text = "CHARACTER     /     NICKNAME"
        '
        'lblShadow
        '
        Me.lblShadow.AutoSize = True
        Me.lblShadow.Font = New System.Drawing.Font("Lucida Console", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShadow.ForeColor = System.Drawing.Color.Red
        Me.lblShadow.Location = New System.Drawing.Point(190, 211)
        Me.lblShadow.Name = "lblShadow"
        Me.lblShadow.Size = New System.Drawing.Size(162, 34)
        Me.lblShadow.TabIndex = 12
        Me.lblShadow.Text = "-SHADOW"
        Me.lblShadow.Visible = False
        '
        'lblBlinky
        '
        Me.lblBlinky.AutoSize = True
        Me.lblBlinky.Font = New System.Drawing.Font("Lucida Console", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlinky.ForeColor = System.Drawing.Color.Red
        Me.lblBlinky.Location = New System.Drawing.Point(533, 211)
        Me.lblBlinky.Name = "lblBlinky"
        Me.lblBlinky.Size = New System.Drawing.Size(183, 34)
        Me.lblBlinky.TabIndex = 13
        Me.lblBlinky.Text = """BLINKY"""
        Me.lblBlinky.Visible = False
        '
        'lblSpeedy
        '
        Me.lblSpeedy.AutoSize = True
        Me.lblSpeedy.Font = New System.Drawing.Font("Lucida Console", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpeedy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblSpeedy.Location = New System.Drawing.Point(190, 285)
        Me.lblSpeedy.Name = "lblSpeedy"
        Me.lblSpeedy.Size = New System.Drawing.Size(162, 34)
        Me.lblSpeedy.TabIndex = 14
        Me.lblSpeedy.Text = "-SPEEDY"
        Me.lblSpeedy.Visible = False
        '
        'lblPinky
        '
        Me.lblPinky.AutoSize = True
        Me.lblPinky.Font = New System.Drawing.Font("Lucida Console", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPinky.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPinky.Location = New System.Drawing.Point(533, 285)
        Me.lblPinky.Name = "lblPinky"
        Me.lblPinky.Size = New System.Drawing.Size(162, 34)
        Me.lblPinky.TabIndex = 15
        Me.lblPinky.Text = """PINKY"""
        Me.lblPinky.Visible = False
        '
        'lblBashful
        '
        Me.lblBashful.AutoSize = True
        Me.lblBashful.Font = New System.Drawing.Font("Lucida Console", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBashful.ForeColor = System.Drawing.Color.Aqua
        Me.lblBashful.Location = New System.Drawing.Point(190, 351)
        Me.lblBashful.Name = "lblBashful"
        Me.lblBashful.Size = New System.Drawing.Size(183, 34)
        Me.lblBashful.TabIndex = 16
        Me.lblBashful.Text = "-BASHFUL"
        Me.lblBashful.Visible = False
        '
        'lblInky
        '
        Me.lblInky.AutoSize = True
        Me.lblInky.Font = New System.Drawing.Font("Lucida Console", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInky.ForeColor = System.Drawing.Color.Aqua
        Me.lblInky.Location = New System.Drawing.Point(533, 351)
        Me.lblInky.Name = "lblInky"
        Me.lblInky.Size = New System.Drawing.Size(141, 34)
        Me.lblInky.TabIndex = 17
        Me.lblInky.Text = """INKY"""
        Me.lblInky.Visible = False
        '
        'lblPokey
        '
        Me.lblPokey.AutoSize = True
        Me.lblPokey.Font = New System.Drawing.Font("Lucida Console", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPokey.ForeColor = System.Drawing.Color.Orange
        Me.lblPokey.Location = New System.Drawing.Point(190, 417)
        Me.lblPokey.Name = "lblPokey"
        Me.lblPokey.Size = New System.Drawing.Size(141, 34)
        Me.lblPokey.TabIndex = 18
        Me.lblPokey.Text = "-POKEY"
        Me.lblPokey.Visible = False
        '
        'lbl10pts
        '
        Me.lbl10pts.AutoSize = True
        Me.lbl10pts.Font = New System.Drawing.Font("Lucida Console", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl10pts.Location = New System.Drawing.Point(505, 575)
        Me.lbl10pts.Name = "lbl10pts"
        Me.lbl10pts.Size = New System.Drawing.Size(60, 27)
        Me.lbl10pts.TabIndex = 19
        Me.lbl10pts.Text = "PTS"
        Me.lbl10pts.Visible = False
        '
        'lbl50pts
        '
        Me.lbl50pts.AutoSize = True
        Me.lbl50pts.Font = New System.Drawing.Font("Lucida Console", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl50pts.Location = New System.Drawing.Point(505, 636)
        Me.lbl50pts.Name = "lbl50pts"
        Me.lbl50pts.Size = New System.Drawing.Size(60, 27)
        Me.lbl50pts.TabIndex = 20
        Me.lbl50pts.Text = "PTS"
        Me.lbl50pts.Visible = False
        '
        'lbl10
        '
        Me.lbl10.AutoSize = True
        Me.lbl10.Font = New System.Drawing.Font("Lucida Console", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl10.Location = New System.Drawing.Point(442, 568)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(57, 34)
        Me.lbl10.TabIndex = 21
        Me.lbl10.Text = "10"
        Me.lbl10.Visible = False
        '
        'lbl50
        '
        Me.lbl50.AutoSize = True
        Me.lbl50.Font = New System.Drawing.Font("Lucida Console", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl50.Location = New System.Drawing.Point(442, 636)
        Me.lbl50.Name = "lbl50"
        Me.lbl50.Size = New System.Drawing.Size(57, 34)
        Me.lbl50.TabIndex = 22
        Me.lbl50.Text = "50"
        Me.lbl50.Visible = False
        '
        'lblMidway
        '
        Me.lblMidway.AutoSize = True
        Me.lblMidway.Font = New System.Drawing.Font("Lucida Console", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMidway.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblMidway.Location = New System.Drawing.Point(197, 690)
        Me.lblMidway.Name = "lblMidway"
        Me.lblMidway.Size = New System.Drawing.Size(477, 34)
        Me.lblMidway.TabIndex = 23
        Me.lblMidway.Text = "© 1980 MIDWAY MFG. CO."
        Me.lblMidway.Visible = False
        '
        'lblCredits
        '
        Me.lblCredits.AutoSize = True
        Me.lblCredits.Font = New System.Drawing.Font("Lucida Console", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredits.Location = New System.Drawing.Point(3, 743)
        Me.lblCredits.Name = "lblCredits"
        Me.lblCredits.Size = New System.Drawing.Size(267, 34)
        Me.lblCredits.TabIndex = 24
        Me.lblCredits.Text = "CREDITS    0"
        '
        'lblClide
        '
        Me.lblClide.AutoSize = True
        Me.lblClide.Font = New System.Drawing.Font("Lucida Console", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClide.ForeColor = System.Drawing.Color.Orange
        Me.lblClide.Location = New System.Drawing.Point(533, 417)
        Me.lblClide.Name = "lblClide"
        Me.lblClide.Size = New System.Drawing.Size(162, 34)
        Me.lblClide.TabIndex = 25
        Me.lblClide.Text = """CLYDE"""
        Me.lblClide.Visible = False
        '
        'Load
        '
        Me.Load.Interval = 500
        '
        'Blinking
        '
        '
        'picPacman
        '
        Me.picPacman.Image = Global.Pacman.My.Resources.Resources.Pacman_Open_Left
        Me.picPacman.Location = New System.Drawing.Point(900, 491)
        Me.picPacman.Name = "picPacman"
        Me.picPacman.Size = New System.Drawing.Size(50, 50)
        Me.picPacman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPacman.TabIndex = 37
        Me.picPacman.TabStop = False
        Me.picPacman.Visible = False
        '
        'picOrange
        '
        Me.picOrange.Image = Global.Pacman.My.Resources.Resources.Orange_Ghost_Left_Open
        Me.picOrange.Location = New System.Drawing.Point(1150, 491)
        Me.picOrange.Name = "picOrange"
        Me.picOrange.Size = New System.Drawing.Size(50, 50)
        Me.picOrange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOrange.TabIndex = 36
        Me.picOrange.TabStop = False
        Me.picOrange.Visible = False
        '
        'picBlue
        '
        Me.picBlue.Image = Global.Pacman.My.Resources.Resources.Blue_Ghost_Left_Open
        Me.picBlue.Location = New System.Drawing.Point(1094, 491)
        Me.picBlue.Name = "picBlue"
        Me.picBlue.Size = New System.Drawing.Size(50, 50)
        Me.picBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBlue.TabIndex = 35
        Me.picBlue.TabStop = False
        Me.picBlue.Visible = False
        '
        'picPink
        '
        Me.picPink.Image = Global.Pacman.My.Resources.Resources.Pink_Ghost_Left_Open
        Me.picPink.Location = New System.Drawing.Point(1038, 491)
        Me.picPink.Name = "picPink"
        Me.picPink.Size = New System.Drawing.Size(50, 50)
        Me.picPink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPink.TabIndex = 34
        Me.picPink.TabStop = False
        Me.picPink.Visible = False
        '
        'picRed
        '
        Me.picRed.Image = Global.Pacman.My.Resources.Resources.Red_Ghost_Left_Open
        Me.picRed.Location = New System.Drawing.Point(982, 491)
        Me.picRed.Name = "picRed"
        Me.picRed.Size = New System.Drawing.Size(50, 50)
        Me.picRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRed.TabIndex = 33
        Me.picRed.TabStop = False
        Me.picRed.Visible = False
        '
        'pic_Powerup
        '
        Me.pic_Powerup.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.pic_Powerup.Location = New System.Drawing.Point(64, 501)
        Me.pic_Powerup.Name = "pic_Powerup"
        Me.pic_Powerup.Size = New System.Drawing.Size(30, 30)
        Me.pic_Powerup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Powerup.TabIndex = 32
        Me.pic_Powerup.TabStop = False
        Me.pic_Powerup.Visible = False
        '
        'picOrange_Static
        '
        Me.picOrange_Static.Image = Global.Pacman.My.Resources.Resources.Orange_Ghost_Right_Open
        Me.picOrange_Static.Location = New System.Drawing.Point(134, 409)
        Me.picOrange_Static.Name = "picOrange_Static"
        Me.picOrange_Static.Size = New System.Drawing.Size(50, 50)
        Me.picOrange_Static.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOrange_Static.TabIndex = 31
        Me.picOrange_Static.TabStop = False
        Me.picOrange_Static.Visible = False
        '
        'picBlue_Static
        '
        Me.picBlue_Static.Image = Global.Pacman.My.Resources.Resources.Blue_Ghost_Right_Open
        Me.picBlue_Static.Location = New System.Drawing.Point(134, 342)
        Me.picBlue_Static.Name = "picBlue_Static"
        Me.picBlue_Static.Size = New System.Drawing.Size(50, 50)
        Me.picBlue_Static.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBlue_Static.TabIndex = 30
        Me.picBlue_Static.TabStop = False
        Me.picBlue_Static.Visible = False
        '
        'picPink_Static
        '
        Me.picPink_Static.Image = Global.Pacman.My.Resources.Resources.Pink_Ghost_Right_Open
        Me.picPink_Static.Location = New System.Drawing.Point(134, 275)
        Me.picPink_Static.Name = "picPink_Static"
        Me.picPink_Static.Size = New System.Drawing.Size(50, 50)
        Me.picPink_Static.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPink_Static.TabIndex = 29
        Me.picPink_Static.TabStop = False
        Me.picPink_Static.Visible = False
        '
        'picRed_Static
        '
        Me.picRed_Static.Image = Global.Pacman.My.Resources.Resources.Red_Ghost_Right_Open
        Me.picRed_Static.Location = New System.Drawing.Point(134, 200)
        Me.picRed_Static.Name = "picRed_Static"
        Me.picRed_Static.Size = New System.Drawing.Size(50, 50)
        Me.picRed_Static.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRed_Static.TabIndex = 28
        Me.picRed_Static.TabStop = False
        Me.picRed_Static.Visible = False
        '
        'picPowerup_Static
        '
        Me.picPowerup_Static.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.picPowerup_Static.Location = New System.Drawing.Point(406, 636)
        Me.picPowerup_Static.Name = "picPowerup_Static"
        Me.picPowerup_Static.Size = New System.Drawing.Size(30, 30)
        Me.picPowerup_Static.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPowerup_Static.TabIndex = 27
        Me.picPowerup_Static.TabStop = False
        Me.picPowerup_Static.Visible = False
        '
        'picDot
        '
        Me.picDot.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.picDot.Location = New System.Drawing.Point(413, 578)
        Me.picDot.Name = "picDot"
        Me.picDot.Size = New System.Drawing.Size(10, 10)
        Me.picDot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDot.TabIndex = 26
        Me.picDot.TabStop = False
        Me.picDot.Visible = False
        '
        'tmrPacman
        '
        Me.tmrPacman.Interval = 70
        '
        'tmrWait
        '
        Me.tmrWait.Interval = 1000
        '
        'tmrGhosts
        '
        Me.tmrGhosts.Interval = 64
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Lucida Console", 9.857143!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblScore.Location = New System.Drawing.Point(799, -2)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(80, 24)
        Me.lblScore.TabIndex = 38
        Me.lblScore.Text = "Score"
        Me.lblScore.Visible = False
        '
        'Move
        '
        Me.Move.Interval = 500
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(731, 736)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(136, 53)
        Me.btnExit.TabIndex = 39
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnter.ForeColor = System.Drawing.Color.Black
        Me.btnEnter.Location = New System.Drawing.Point(731, 685)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(136, 50)
        Me.btnEnter.TabIndex = 1
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(879, 795)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.picPacman)
        Me.Controls.Add(Me.picOrange)
        Me.Controls.Add(Me.picBlue)
        Me.Controls.Add(Me.picPink)
        Me.Controls.Add(Me.picRed)
        Me.Controls.Add(Me.pic_Powerup)
        Me.Controls.Add(Me.picOrange_Static)
        Me.Controls.Add(Me.picBlue_Static)
        Me.Controls.Add(Me.picPink_Static)
        Me.Controls.Add(Me.picRed_Static)
        Me.Controls.Add(Me.picPowerup_Static)
        Me.Controls.Add(Me.picDot)
        Me.Controls.Add(Me.lblClide)
        Me.Controls.Add(Me.lblCredits)
        Me.Controls.Add(Me.lblMidway)
        Me.Controls.Add(Me.lbl50)
        Me.Controls.Add(Me.lbl10)
        Me.Controls.Add(Me.lbl50pts)
        Me.Controls.Add(Me.lbl10pts)
        Me.Controls.Add(Me.lblPokey)
        Me.Controls.Add(Me.lblInky)
        Me.Controls.Add(Me.lblBashful)
        Me.Controls.Add(Me.lblPinky)
        Me.Controls.Add(Me.lblSpeedy)
        Me.Controls.Add(Me.lblBlinky)
        Me.Controls.Add(Me.lblShadow)
        Me.Controls.Add(Me.lblInto)
        Me.Controls.Add(Me.lbl2Up)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblHighScore)
        Me.Controls.Add(Me.lbl1Up)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Form1"
        Me.Text = "Pacman"
        CType(Me.picPacman, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOrange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Powerup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOrange_Static, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBlue_Static, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPink_Static, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRed_Static, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPowerup_Static, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl1Up As Label
    Friend WithEvents lblHighScore As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl2Up As Label
    Friend WithEvents lblInto As Label
    Friend WithEvents lblShadow As Label
    Friend WithEvents lblBlinky As Label
    Friend WithEvents lblSpeedy As Label
    Friend WithEvents lblPinky As Label
    Friend WithEvents lblBashful As Label
    Friend WithEvents lblInky As Label
    Friend WithEvents lblPokey As Label
    Friend WithEvents lbl10pts As Label
    Friend WithEvents lbl50pts As Label
    Friend WithEvents lbl10 As Label
    Friend WithEvents lbl50 As Label
    Friend WithEvents lblMidway As Label
    Friend WithEvents lblCredits As Label
    Friend WithEvents lblClide As Label
    Friend WithEvents picDot As PictureBox
    Friend WithEvents picPowerup_Static As PictureBox
    Friend WithEvents picRed_Static As PictureBox
    Friend WithEvents picPink_Static As PictureBox
    Friend WithEvents picBlue_Static As PictureBox
    Friend WithEvents picOrange_Static As PictureBox
    Friend WithEvents pic_Powerup As PictureBox
    Friend WithEvents Load As Timer
    Friend WithEvents Blinking As Timer
    Friend WithEvents picRed As PictureBox
    Friend WithEvents picPink As PictureBox
    Friend WithEvents picBlue As PictureBox
    Friend WithEvents picOrange As PictureBox
    Friend WithEvents picPacman As PictureBox
    Friend WithEvents tmrPacman As Timer
    Friend WithEvents tmrWait As Timer
    Friend WithEvents tmrGhosts As Timer
    Friend WithEvents lblScore As Label
    Friend WithEvents Move As Timer
    Friend WithEvents btnExit As Button
    Friend WithEvents btnEnter As Button
End Class
