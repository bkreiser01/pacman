<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Gameboard
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblReady = New System.Windows.Forms.Label()
        Me.lblP1 = New System.Windows.Forms.Label()
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGhosts_Leave = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDeath = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMove = New System.Windows.Forms.Timer(Me.components)
        Me.lblGameOver = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tmrLevel_Change = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRed_Death = New System.Windows.Forms.Timer(Me.components)
        Me.lblBonus = New System.Windows.Forms.Label()
        Me.tmrPink_Death = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBlue_Death = New System.Windows.Forms.Timer(Me.components)
        Me.tmrOrange_Death = New System.Windows.Forms.Timer(Me.components)
        Me.tmrScared = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPacman = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGhost = New System.Windows.Forms.Timer(Me.components)
        Me.tmrOrange = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPink = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBlue = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRed = New System.Windows.Forms.Timer(Me.components)
        Me.tmrFruit = New System.Windows.Forms.Timer(Me.components)
        Me.lblFruit_Score = New System.Windows.Forms.Label()
        Me.tmrFruit_Display = New System.Windows.Forms.Timer(Me.components)
        Me.picFruit = New System.Windows.Forms.PictureBox()
        Me.picFruit_1 = New System.Windows.Forms.PictureBox()
        Me.picFruit_2 = New System.Windows.Forms.PictureBox()
        Me.picFruit_3 = New System.Windows.Forms.PictureBox()
        Me.picFruit_4 = New System.Windows.Forms.PictureBox()
        Me.picFruit_5 = New System.Windows.Forms.PictureBox()
        Me.picFruit_6 = New System.Windows.Forms.PictureBox()
        Me.picFruit_7 = New System.Windows.Forms.PictureBox()
        Me.picPacman = New System.Windows.Forms.PictureBox()
        Me.picOrange = New System.Windows.Forms.PictureBox()
        Me.picBlue = New System.Windows.Forms.PictureBox()
        Me.picPink = New System.Windows.Forms.PictureBox()
        Me.picRed = New System.Windows.Forms.PictureBox()
        Me.picPowerup_2 = New System.Windows.Forms.PictureBox()
        Me.picPowerup_1 = New System.Windows.Forms.PictureBox()
        Me.picPowerup_3 = New System.Windows.Forms.PictureBox()
        Me.picPowerup_4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox276 = New System.Windows.Forms.PictureBox()
        Me.PictureBox275 = New System.Windows.Forms.PictureBox()
        Me.PictureBox274 = New System.Windows.Forms.PictureBox()
        Me.PictureBox272 = New System.Windows.Forms.PictureBox()
        Me.PictureBox271 = New System.Windows.Forms.PictureBox()
        Me.PictureBox269 = New System.Windows.Forms.PictureBox()
        Me.PictureBox268 = New System.Windows.Forms.PictureBox()
        Me.PictureBox267 = New System.Windows.Forms.PictureBox()
        Me.PictureBox266 = New System.Windows.Forms.PictureBox()
        Me.PictureBox264 = New System.Windows.Forms.PictureBox()
        Me.PictureBox262 = New System.Windows.Forms.PictureBox()
        Me.PictureBox261 = New System.Windows.Forms.PictureBox()
        Me.PictureBox260 = New System.Windows.Forms.PictureBox()
        Me.PictureBox259 = New System.Windows.Forms.PictureBox()
        Me.PictureBox258 = New System.Windows.Forms.PictureBox()
        Me.PictureBox257 = New System.Windows.Forms.PictureBox()
        Me.PictureBox256 = New System.Windows.Forms.PictureBox()
        Me.PictureBox255 = New System.Windows.Forms.PictureBox()
        Me.PictureBox254 = New System.Windows.Forms.PictureBox()
        Me.PictureBox253 = New System.Windows.Forms.PictureBox()
        Me.PictureBox252 = New System.Windows.Forms.PictureBox()
        Me.PictureBox251 = New System.Windows.Forms.PictureBox()
        Me.PictureBox250 = New System.Windows.Forms.PictureBox()
        Me.PictureBox249 = New System.Windows.Forms.PictureBox()
        Me.PictureBox248 = New System.Windows.Forms.PictureBox()
        Me.PictureBox247 = New System.Windows.Forms.PictureBox()
        Me.PictureBox246 = New System.Windows.Forms.PictureBox()
        Me.PictureBox245 = New System.Windows.Forms.PictureBox()
        Me.PictureBox244 = New System.Windows.Forms.PictureBox()
        Me.PictureBox243 = New System.Windows.Forms.PictureBox()
        Me.PictureBox242 = New System.Windows.Forms.PictureBox()
        Me.PictureBox241 = New System.Windows.Forms.PictureBox()
        Me.PictureBox240 = New System.Windows.Forms.PictureBox()
        Me.PictureBox239 = New System.Windows.Forms.PictureBox()
        Me.PictureBox238 = New System.Windows.Forms.PictureBox()
        Me.PictureBox237 = New System.Windows.Forms.PictureBox()
        Me.PictureBox236 = New System.Windows.Forms.PictureBox()
        Me.PictureBox235 = New System.Windows.Forms.PictureBox()
        Me.PictureBox234 = New System.Windows.Forms.PictureBox()
        Me.PictureBox233 = New System.Windows.Forms.PictureBox()
        Me.PictureBox232 = New System.Windows.Forms.PictureBox()
        Me.PictureBox231 = New System.Windows.Forms.PictureBox()
        Me.PictureBox230 = New System.Windows.Forms.PictureBox()
        Me.PictureBox229 = New System.Windows.Forms.PictureBox()
        Me.PictureBox228 = New System.Windows.Forms.PictureBox()
        Me.PictureBox227 = New System.Windows.Forms.PictureBox()
        Me.PictureBox226 = New System.Windows.Forms.PictureBox()
        Me.PictureBox224 = New System.Windows.Forms.PictureBox()
        Me.PictureBox223 = New System.Windows.Forms.PictureBox()
        Me.PictureBox222 = New System.Windows.Forms.PictureBox()
        Me.PictureBox221 = New System.Windows.Forms.PictureBox()
        Me.PictureBox220 = New System.Windows.Forms.PictureBox()
        Me.PictureBox218 = New System.Windows.Forms.PictureBox()
        Me.PictureBox217 = New System.Windows.Forms.PictureBox()
        Me.PictureBox216 = New System.Windows.Forms.PictureBox()
        Me.PictureBox215 = New System.Windows.Forms.PictureBox()
        Me.PictureBox213 = New System.Windows.Forms.PictureBox()
        Me.PictureBox212 = New System.Windows.Forms.PictureBox()
        Me.PictureBox211 = New System.Windows.Forms.PictureBox()
        Me.PictureBox210 = New System.Windows.Forms.PictureBox()
        Me.PictureBox209 = New System.Windows.Forms.PictureBox()
        Me.PictureBox208 = New System.Windows.Forms.PictureBox()
        Me.PictureBox207 = New System.Windows.Forms.PictureBox()
        Me.PictureBox206 = New System.Windows.Forms.PictureBox()
        Me.PictureBox205 = New System.Windows.Forms.PictureBox()
        Me.PictureBox204 = New System.Windows.Forms.PictureBox()
        Me.PictureBox203 = New System.Windows.Forms.PictureBox()
        Me.PictureBox202 = New System.Windows.Forms.PictureBox()
        Me.PictureBox201 = New System.Windows.Forms.PictureBox()
        Me.PictureBox200 = New System.Windows.Forms.PictureBox()
        Me.PictureBox199 = New System.Windows.Forms.PictureBox()
        Me.PictureBox198 = New System.Windows.Forms.PictureBox()
        Me.PictureBox197 = New System.Windows.Forms.PictureBox()
        Me.PictureBox196 = New System.Windows.Forms.PictureBox()
        Me.PictureBox195 = New System.Windows.Forms.PictureBox()
        Me.PictureBox194 = New System.Windows.Forms.PictureBox()
        Me.PictureBox193 = New System.Windows.Forms.PictureBox()
        Me.PictureBox192 = New System.Windows.Forms.PictureBox()
        Me.PictureBox191 = New System.Windows.Forms.PictureBox()
        Me.PictureBox190 = New System.Windows.Forms.PictureBox()
        Me.PictureBox189 = New System.Windows.Forms.PictureBox()
        Me.PictureBox188 = New System.Windows.Forms.PictureBox()
        Me.PictureBox187 = New System.Windows.Forms.PictureBox()
        Me.PictureBox186 = New System.Windows.Forms.PictureBox()
        Me.PictureBox185 = New System.Windows.Forms.PictureBox()
        Me.PictureBox184 = New System.Windows.Forms.PictureBox()
        Me.PictureBox183 = New System.Windows.Forms.PictureBox()
        Me.PictureBox182 = New System.Windows.Forms.PictureBox()
        Me.PictureBox181 = New System.Windows.Forms.PictureBox()
        Me.PictureBox180 = New System.Windows.Forms.PictureBox()
        Me.PictureBox179 = New System.Windows.Forms.PictureBox()
        Me.PictureBox178 = New System.Windows.Forms.PictureBox()
        Me.PictureBox177 = New System.Windows.Forms.PictureBox()
        Me.PictureBox176 = New System.Windows.Forms.PictureBox()
        Me.PictureBox175 = New System.Windows.Forms.PictureBox()
        Me.PictureBox174 = New System.Windows.Forms.PictureBox()
        Me.PictureBox173 = New System.Windows.Forms.PictureBox()
        Me.PictureBox172 = New System.Windows.Forms.PictureBox()
        Me.PictureBox171 = New System.Windows.Forms.PictureBox()
        Me.PictureBox170 = New System.Windows.Forms.PictureBox()
        Me.PictureBox169 = New System.Windows.Forms.PictureBox()
        Me.PictureBox168 = New System.Windows.Forms.PictureBox()
        Me.PictureBox167 = New System.Windows.Forms.PictureBox()
        Me.PictureBox166 = New System.Windows.Forms.PictureBox()
        Me.PictureBox165 = New System.Windows.Forms.PictureBox()
        Me.PictureBox164 = New System.Windows.Forms.PictureBox()
        Me.PictureBox163 = New System.Windows.Forms.PictureBox()
        Me.PictureBox162 = New System.Windows.Forms.PictureBox()
        Me.PictureBox161 = New System.Windows.Forms.PictureBox()
        Me.PictureBox160 = New System.Windows.Forms.PictureBox()
        Me.PictureBox159 = New System.Windows.Forms.PictureBox()
        Me.PictureBox158 = New System.Windows.Forms.PictureBox()
        Me.PictureBox157 = New System.Windows.Forms.PictureBox()
        Me.PictureBox156 = New System.Windows.Forms.PictureBox()
        Me.PictureBox155 = New System.Windows.Forms.PictureBox()
        Me.PictureBox154 = New System.Windows.Forms.PictureBox()
        Me.PictureBox153 = New System.Windows.Forms.PictureBox()
        Me.PictureBox152 = New System.Windows.Forms.PictureBox()
        Me.PictureBox151 = New System.Windows.Forms.PictureBox()
        Me.PictureBox150 = New System.Windows.Forms.PictureBox()
        Me.PictureBox149 = New System.Windows.Forms.PictureBox()
        Me.PictureBox148 = New System.Windows.Forms.PictureBox()
        Me.PictureBox147 = New System.Windows.Forms.PictureBox()
        Me.PictureBox146 = New System.Windows.Forms.PictureBox()
        Me.PictureBox145 = New System.Windows.Forms.PictureBox()
        Me.PictureBox144 = New System.Windows.Forms.PictureBox()
        Me.PictureBox143 = New System.Windows.Forms.PictureBox()
        Me.PictureBox142 = New System.Windows.Forms.PictureBox()
        Me.PictureBox141 = New System.Windows.Forms.PictureBox()
        Me.PictureBox140 = New System.Windows.Forms.PictureBox()
        Me.PictureBox139 = New System.Windows.Forms.PictureBox()
        Me.PictureBox138 = New System.Windows.Forms.PictureBox()
        Me.PictureBox137 = New System.Windows.Forms.PictureBox()
        Me.PictureBox136 = New System.Windows.Forms.PictureBox()
        Me.PictureBox135 = New System.Windows.Forms.PictureBox()
        Me.PictureBox134 = New System.Windows.Forms.PictureBox()
        Me.PictureBox133 = New System.Windows.Forms.PictureBox()
        Me.PictureBox132 = New System.Windows.Forms.PictureBox()
        Me.PictureBox131 = New System.Windows.Forms.PictureBox()
        Me.PictureBox130 = New System.Windows.Forms.PictureBox()
        Me.PictureBox129 = New System.Windows.Forms.PictureBox()
        Me.PictureBox128 = New System.Windows.Forms.PictureBox()
        Me.PictureBox127 = New System.Windows.Forms.PictureBox()
        Me.PictureBox126 = New System.Windows.Forms.PictureBox()
        Me.PictureBox125 = New System.Windows.Forms.PictureBox()
        Me.PictureBox124 = New System.Windows.Forms.PictureBox()
        Me.PictureBox123 = New System.Windows.Forms.PictureBox()
        Me.PictureBox122 = New System.Windows.Forms.PictureBox()
        Me.PictureBox121 = New System.Windows.Forms.PictureBox()
        Me.PictureBox120 = New System.Windows.Forms.PictureBox()
        Me.PictureBox119 = New System.Windows.Forms.PictureBox()
        Me.PictureBox118 = New System.Windows.Forms.PictureBox()
        Me.PictureBox117 = New System.Windows.Forms.PictureBox()
        Me.PictureBox116 = New System.Windows.Forms.PictureBox()
        Me.PictureBox115 = New System.Windows.Forms.PictureBox()
        Me.PictureBox114 = New System.Windows.Forms.PictureBox()
        Me.PictureBox113 = New System.Windows.Forms.PictureBox()
        Me.PictureBox112 = New System.Windows.Forms.PictureBox()
        Me.PictureBox111 = New System.Windows.Forms.PictureBox()
        Me.PictureBox110 = New System.Windows.Forms.PictureBox()
        Me.PictureBox109 = New System.Windows.Forms.PictureBox()
        Me.PictureBox108 = New System.Windows.Forms.PictureBox()
        Me.PictureBox107 = New System.Windows.Forms.PictureBox()
        Me.PictureBox106 = New System.Windows.Forms.PictureBox()
        Me.PictureBox105 = New System.Windows.Forms.PictureBox()
        Me.PictureBox104 = New System.Windows.Forms.PictureBox()
        Me.PictureBox103 = New System.Windows.Forms.PictureBox()
        Me.PictureBox102 = New System.Windows.Forms.PictureBox()
        Me.PictureBox101 = New System.Windows.Forms.PictureBox()
        Me.PictureBox100 = New System.Windows.Forms.PictureBox()
        Me.PictureBox99 = New System.Windows.Forms.PictureBox()
        Me.PictureBox98 = New System.Windows.Forms.PictureBox()
        Me.PictureBox97 = New System.Windows.Forms.PictureBox()
        Me.PictureBox96 = New System.Windows.Forms.PictureBox()
        Me.PictureBox95 = New System.Windows.Forms.PictureBox()
        Me.PictureBox94 = New System.Windows.Forms.PictureBox()
        Me.PictureBox93 = New System.Windows.Forms.PictureBox()
        Me.PictureBox92 = New System.Windows.Forms.PictureBox()
        Me.PictureBox91 = New System.Windows.Forms.PictureBox()
        Me.PictureBox90 = New System.Windows.Forms.PictureBox()
        Me.PictureBox89 = New System.Windows.Forms.PictureBox()
        Me.PictureBox88 = New System.Windows.Forms.PictureBox()
        Me.PictureBox87 = New System.Windows.Forms.PictureBox()
        Me.PictureBox86 = New System.Windows.Forms.PictureBox()
        Me.PictureBox85 = New System.Windows.Forms.PictureBox()
        Me.PictureBox84 = New System.Windows.Forms.PictureBox()
        Me.PictureBox83 = New System.Windows.Forms.PictureBox()
        Me.PictureBox82 = New System.Windows.Forms.PictureBox()
        Me.PictureBox81 = New System.Windows.Forms.PictureBox()
        Me.PictureBox80 = New System.Windows.Forms.PictureBox()
        Me.PictureBox79 = New System.Windows.Forms.PictureBox()
        Me.PictureBox78 = New System.Windows.Forms.PictureBox()
        Me.PictureBox77 = New System.Windows.Forms.PictureBox()
        Me.PictureBox76 = New System.Windows.Forms.PictureBox()
        Me.PictureBox75 = New System.Windows.Forms.PictureBox()
        Me.PictureBox74 = New System.Windows.Forms.PictureBox()
        Me.PictureBox73 = New System.Windows.Forms.PictureBox()
        Me.PictureBox72 = New System.Windows.Forms.PictureBox()
        Me.PictureBox71 = New System.Windows.Forms.PictureBox()
        Me.PictureBox70 = New System.Windows.Forms.PictureBox()
        Me.PictureBox69 = New System.Windows.Forms.PictureBox()
        Me.PictureBox68 = New System.Windows.Forms.PictureBox()
        Me.PictureBox67 = New System.Windows.Forms.PictureBox()
        Me.PictureBox66 = New System.Windows.Forms.PictureBox()
        Me.PictureBox65 = New System.Windows.Forms.PictureBox()
        Me.PictureBox64 = New System.Windows.Forms.PictureBox()
        Me.PictureBox63 = New System.Windows.Forms.PictureBox()
        Me.PictureBox62 = New System.Windows.Forms.PictureBox()
        Me.PictureBox61 = New System.Windows.Forms.PictureBox()
        Me.PictureBox60 = New System.Windows.Forms.PictureBox()
        Me.PictureBox59 = New System.Windows.Forms.PictureBox()
        Me.PictureBox58 = New System.Windows.Forms.PictureBox()
        Me.PictureBox57 = New System.Windows.Forms.PictureBox()
        Me.PictureBox56 = New System.Windows.Forms.PictureBox()
        Me.PictureBox55 = New System.Windows.Forms.PictureBox()
        Me.PictureBox54 = New System.Windows.Forms.PictureBox()
        Me.PictureBox53 = New System.Windows.Forms.PictureBox()
        Me.PictureBox52 = New System.Windows.Forms.PictureBox()
        Me.PictureBox51 = New System.Windows.Forms.PictureBox()
        Me.PictureBox50 = New System.Windows.Forms.PictureBox()
        Me.PictureBox49 = New System.Windows.Forms.PictureBox()
        Me.PictureBox48 = New System.Windows.Forms.PictureBox()
        Me.PictureBox47 = New System.Windows.Forms.PictureBox()
        Me.GhostWall = New System.Windows.Forms.PictureBox()
        Me.PictureBox46 = New System.Windows.Forms.PictureBox()
        Me.PictureBox45 = New System.Windows.Forms.PictureBox()
        Me.PictureBox44 = New System.Windows.Forms.PictureBox()
        Me.PictureBox43 = New System.Windows.Forms.PictureBox()
        Me.PictureBox42 = New System.Windows.Forms.PictureBox()
        Me.PictureBox41 = New System.Windows.Forms.PictureBox()
        Me.PictureBox40 = New System.Windows.Forms.PictureBox()
        Me.PictureBox39 = New System.Windows.Forms.PictureBox()
        Me.PictureBox38 = New System.Windows.Forms.PictureBox()
        Me.PictureBox37 = New System.Windows.Forms.PictureBox()
        Me.PictureBox36 = New System.Windows.Forms.PictureBox()
        Me.PictureBox35 = New System.Windows.Forms.PictureBox()
        Me.PictureBox34 = New System.Windows.Forms.PictureBox()
        Me.PictureBox33 = New System.Windows.Forms.PictureBox()
        Me.PictureBox32 = New System.Windows.Forms.PictureBox()
        Me.PictureBox31 = New System.Windows.Forms.PictureBox()
        Me.PictureBox30 = New System.Windows.Forms.PictureBox()
        Me.PictureBox29 = New System.Windows.Forms.PictureBox()
        Me.PictureBox28 = New System.Windows.Forms.PictureBox()
        Me.PictureBox27 = New System.Windows.Forms.PictureBox()
        Me.PictureBox26 = New System.Windows.Forms.PictureBox()
        Me.PictureBox25 = New System.Windows.Forms.PictureBox()
        Me.PictureBox24 = New System.Windows.Forms.PictureBox()
        Me.PictureBox23 = New System.Windows.Forms.PictureBox()
        Me.PictureBox22 = New System.Windows.Forms.PictureBox()
        Me.PictureBox21 = New System.Windows.Forms.PictureBox()
        Me.PictureBox20 = New System.Windows.Forms.PictureBox()
        Me.PictureBox19 = New System.Windows.Forms.PictureBox()
        Me.PictureBox18 = New System.Windows.Forms.PictureBox()
        Me.PictureBox17 = New System.Windows.Forms.PictureBox()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Portal_Right_Exit = New System.Windows.Forms.PictureBox()
        Me.Portal_Left_Exit = New System.Windows.Forms.PictureBox()
        Me.Portal_Left = New System.Windows.Forms.PictureBox()
        Me.Portal_Right = New System.Windows.Forms.PictureBox()
        Me.picLife_3 = New System.Windows.Forms.PictureBox()
        Me.picLife_4 = New System.Windows.Forms.PictureBox()
        Me.picLife_5 = New System.Windows.Forms.PictureBox()
        Me.picLife_6 = New System.Windows.Forms.PictureBox()
        Me.picLife_2 = New System.Windows.Forms.PictureBox()
        Me.picGameboard_Blue = New System.Windows.Forms.PictureBox()
        Me.PictureBox225 = New System.Windows.Forms.PictureBox()
        Me.PictureBox263 = New System.Windows.Forms.PictureBox()
        Me.PictureBox273 = New System.Windows.Forms.PictureBox()
        Me.PictureBox270 = New System.Windows.Forms.PictureBox()
        Me.PictureBox265 = New System.Windows.Forms.PictureBox()
        Me.PictureBox219 = New System.Windows.Forms.PictureBox()
        Me.PictureBox214 = New System.Windows.Forms.PictureBox()
        Me.picBlue_Home = New System.Windows.Forms.PictureBox()
        Me.picPink_Home = New System.Windows.Forms.PictureBox()
        Me.picOrange_Home = New System.Windows.Forms.PictureBox()
        Me.picGhost_Exit = New System.Windows.Forms.PictureBox()
        Me.picPacman_Home = New System.Windows.Forms.PictureBox()
        CType(Me.picFruit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFruit_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFruit_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFruit_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFruit_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFruit_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFruit_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFruit_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPacman, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOrange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPowerup_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPowerup_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPowerup_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPowerup_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox276, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox275, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox274, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox272, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox271, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox269, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox268, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox267, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox266, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox264, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox262, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox261, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox260, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox259, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox258, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox257, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox256, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox255, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox254, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox253, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox252, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox251, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox250, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox249, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox248, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox247, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox246, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox245, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox244, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox243, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox242, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox241, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox240, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox239, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox238, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox237, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox236, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox235, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox234, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox233, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox232, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox231, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox230, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox229, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox228, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox227, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox226, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox224, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox223, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox222, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox221, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox220, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox218, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox217, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox216, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox215, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox213, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox212, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox211, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox210, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox209, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox208, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox207, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox206, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox205, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox204, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox203, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox202, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox201, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox200, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox199, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox198, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox197, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox196, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox195, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox194, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox193, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox192, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox191, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox190, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox189, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox188, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox187, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox186, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox185, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox184, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox183, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox182, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox181, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox180, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox179, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox178, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox177, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox176, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox175, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox174, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox173, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox172, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox171, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox170, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox169, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox168, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox167, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox166, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox165, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox164, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox163, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox162, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox161, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox160, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox159, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox158, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox157, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox156, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox155, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox154, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox153, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox152, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox151, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox150, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox149, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox148, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox147, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox146, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox145, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox144, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox143, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox142, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox141, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox140, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox139, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox138, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox137, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox136, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox135, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox134, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox133, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox132, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox131, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox130, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox129, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox128, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox127, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox126, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox125, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox124, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox123, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox122, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox121, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox120, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox119, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox118, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox117, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox116, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox115, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox114, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox113, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox112, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox111, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox110, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox109, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox108, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox107, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox106, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox105, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox104, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox103, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox102, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox101, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox100, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox99, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox98, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox97, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox96, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox95, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox94, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox93, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox92, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox91, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox90, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox89, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox88, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox87, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox86, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox85, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox84, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox83, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox82, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox81, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox80, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox79, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox78, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox77, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox76, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox75, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox74, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox73, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox72, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox71, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox70, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox69, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox68, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox67, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox66, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox65, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox64, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox63, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox62, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox61, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox60, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox59, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox58, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox57, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox55, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox49, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GhostWall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Portal_Right_Exit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Portal_Left_Exit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Portal_Left, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Portal_Right, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLife_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLife_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLife_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLife_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLife_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGameboard_Blue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox225, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox263, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox273, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox270, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox265, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox219, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox214, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBlue_Home, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPink_Home, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOrange_Home, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGhost_Exit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPacman_Home, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Console", 11.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(279, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 27)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "SCORE:"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Lucida Console", 11.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(399, 13)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(29, 27)
        Me.lblScore.TabIndex = 8
        Me.lblScore.Text = "0"
        '
        'lblReady
        '
        Me.lblReady.AutoSize = True
        Me.lblReady.BackColor = System.Drawing.Color.Transparent
        Me.lblReady.Font = New System.Drawing.Font("Lucida Console", 15.85714!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReady.ForeColor = System.Drawing.Color.Yellow
        Me.lblReady.Location = New System.Drawing.Point(348, 424)
        Me.lblReady.Name = "lblReady"
        Me.lblReady.Size = New System.Drawing.Size(178, 37)
        Me.lblReady.TabIndex = 15
        Me.lblReady.Text = "READY !"
        '
        'lblP1
        '
        Me.lblP1.AutoSize = True
        Me.lblP1.BackColor = System.Drawing.Color.Transparent
        Me.lblP1.Font = New System.Drawing.Font("Lucida Console", 15.85714!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP1.ForeColor = System.Drawing.Color.Aqua
        Me.lblP1.Location = New System.Drawing.Point(309, 291)
        Me.lblP1.Name = "lblP1"
        Me.lblP1.Size = New System.Drawing.Size(247, 37)
        Me.lblP1.TabIndex = 16
        Me.lblP1.Text = "PLAYER ONE"
        '
        'tmrLoad
        '
        Me.tmrLoad.Interval = 700
        '
        'tmrGhosts_Leave
        '
        '
        'tmrDeath
        '
        '
        'tmrMove
        '
        Me.tmrMove.Interval = 10
        '
        'lblGameOver
        '
        Me.lblGameOver.AutoSize = True
        Me.lblGameOver.BackColor = System.Drawing.Color.Transparent
        Me.lblGameOver.Font = New System.Drawing.Font("Lucida Console", 15.85714!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameOver.ForeColor = System.Drawing.Color.Red
        Me.lblGameOver.Location = New System.Drawing.Point(332, 430)
        Me.lblGameOver.Name = "lblGameOver"
        Me.lblGameOver.Size = New System.Drawing.Size(224, 37)
        Me.lblGameOver.TabIndex = 303
        Me.lblGameOver.Text = "GAME OVER"
        Me.lblGameOver.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Enabled = False
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(25, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 304
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'tmrLevel_Change
        '
        '
        'tmrRed_Death
        '
        '
        'lblBonus
        '
        Me.lblBonus.AutoSize = True
        Me.lblBonus.Font = New System.Drawing.Font("Lucida Console", 9.857143!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBonus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBonus.Location = New System.Drawing.Point(787, 13)
        Me.lblBonus.Name = "lblBonus"
        Me.lblBonus.Size = New System.Drawing.Size(80, 24)
        Me.lblBonus.TabIndex = 309
        Me.lblBonus.Text = "Score"
        Me.lblBonus.Visible = False
        '
        'tmrPink_Death
        '
        '
        'tmrBlue_Death
        '
        '
        'tmrOrange_Death
        '
        '
        'tmrScared
        '
        '
        'tmrPacman
        '
        Me.tmrPacman.Interval = 10
        '
        'tmrGhost
        '
        Me.tmrGhost.Interval = 10
        '
        'tmrOrange
        '
        Me.tmrOrange.Interval = 10
        '
        'tmrPink
        '
        Me.tmrPink.Interval = 10
        '
        'tmrBlue
        '
        Me.tmrBlue.Interval = 10
        '
        'tmrRed
        '
        Me.tmrRed.Interval = 10
        '
        'tmrFruit
        '
        '
        'lblFruit_Score
        '
        Me.lblFruit_Score.AutoSize = True
        Me.lblFruit_Score.Font = New System.Drawing.Font("Lucida Console", 9.857143!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFruit_Score.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblFruit_Score.Location = New System.Drawing.Point(414, 435)
        Me.lblFruit_Score.Name = "lblFruit_Score"
        Me.lblFruit_Score.Size = New System.Drawing.Size(52, 24)
        Me.lblFruit_Score.TabIndex = 320
        Me.lblFruit_Score.Text = "100"
        Me.lblFruit_Score.Visible = False
        '
        'tmrFruit_Display
        '
        '
        'picFruit
        '
        Me.picFruit.Location = New System.Drawing.Point(418, 424)
        Me.picFruit.Name = "picFruit"
        Me.picFruit.Size = New System.Drawing.Size(44, 44)
        Me.picFruit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFruit.TabIndex = 319
        Me.picFruit.TabStop = False
        Me.picFruit.Visible = False
        '
        'picFruit_1
        '
        Me.picFruit_1.Image = Global.Pacman.My.Resources.Resources.Cherry
        Me.picFruit_1.Location = New System.Drawing.Point(737, 748)
        Me.picFruit_1.Name = "picFruit_1"
        Me.picFruit_1.Size = New System.Drawing.Size(44, 44)
        Me.picFruit_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFruit_1.TabIndex = 318
        Me.picFruit_1.TabStop = False
        '
        'picFruit_2
        '
        Me.picFruit_2.Location = New System.Drawing.Point(687, 748)
        Me.picFruit_2.Name = "picFruit_2"
        Me.picFruit_2.Size = New System.Drawing.Size(44, 44)
        Me.picFruit_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFruit_2.TabIndex = 317
        Me.picFruit_2.TabStop = False
        '
        'picFruit_3
        '
        Me.picFruit_3.Location = New System.Drawing.Point(637, 748)
        Me.picFruit_3.Name = "picFruit_3"
        Me.picFruit_3.Size = New System.Drawing.Size(44, 44)
        Me.picFruit_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFruit_3.TabIndex = 316
        Me.picFruit_3.TabStop = False
        '
        'picFruit_4
        '
        Me.picFruit_4.Location = New System.Drawing.Point(587, 748)
        Me.picFruit_4.Name = "picFruit_4"
        Me.picFruit_4.Size = New System.Drawing.Size(44, 44)
        Me.picFruit_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFruit_4.TabIndex = 315
        Me.picFruit_4.TabStop = False
        '
        'picFruit_5
        '
        Me.picFruit_5.Location = New System.Drawing.Point(537, 748)
        Me.picFruit_5.Name = "picFruit_5"
        Me.picFruit_5.Size = New System.Drawing.Size(44, 44)
        Me.picFruit_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFruit_5.TabIndex = 314
        Me.picFruit_5.TabStop = False
        '
        'picFruit_6
        '
        Me.picFruit_6.Location = New System.Drawing.Point(487, 748)
        Me.picFruit_6.Name = "picFruit_6"
        Me.picFruit_6.Size = New System.Drawing.Size(44, 44)
        Me.picFruit_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFruit_6.TabIndex = 313
        Me.picFruit_6.TabStop = False
        '
        'picFruit_7
        '
        Me.picFruit_7.Location = New System.Drawing.Point(431, 748)
        Me.picFruit_7.Name = "picFruit_7"
        Me.picFruit_7.Size = New System.Drawing.Size(44, 44)
        Me.picFruit_7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFruit_7.TabIndex = 312
        Me.picFruit_7.TabStop = False
        '
        'picPacman
        '
        Me.picPacman.Image = Global.Pacman.My.Resources.Resources.Pacman_Closed
        Me.picPacman.Location = New System.Drawing.Point(418, 553)
        Me.picPacman.Name = "picPacman"
        Me.picPacman.Size = New System.Drawing.Size(44, 44)
        Me.picPacman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPacman.TabIndex = 9
        Me.picPacman.TabStop = False
        Me.picPacman.Visible = False
        '
        'picOrange
        '
        Me.picOrange.Image = Global.Pacman.My.Resources.Resources.Orange_Ghost_Up_Open
        Me.picOrange.Location = New System.Drawing.Point(468, 352)
        Me.picOrange.Name = "picOrange"
        Me.picOrange.Size = New System.Drawing.Size(44, 44)
        Me.picOrange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOrange.TabIndex = 5
        Me.picOrange.TabStop = False
        Me.picOrange.Visible = False
        '
        'picBlue
        '
        Me.picBlue.Image = Global.Pacman.My.Resources.Resources.Blue_Ghost_Up_Open
        Me.picBlue.Location = New System.Drawing.Point(368, 352)
        Me.picBlue.Name = "picBlue"
        Me.picBlue.Size = New System.Drawing.Size(44, 44)
        Me.picBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBlue.TabIndex = 3
        Me.picBlue.TabStop = False
        Me.picBlue.Visible = False
        '
        'picPink
        '
        Me.picPink.Image = Global.Pacman.My.Resources.Resources.Pink_Ghost_Down_Open
        Me.picPink.Location = New System.Drawing.Point(418, 352)
        Me.picPink.Name = "picPink"
        Me.picPink.Size = New System.Drawing.Size(44, 44)
        Me.picPink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPink.TabIndex = 4
        Me.picPink.TabStop = False
        Me.picPink.Visible = False
        '
        'picRed
        '
        Me.picRed.Image = Global.Pacman.My.Resources.Resources.Red_Ghost_Left_Open
        Me.picRed.Location = New System.Drawing.Point(418, 284)
        Me.picRed.Name = "picRed"
        Me.picRed.Size = New System.Drawing.Size(44, 44)
        Me.picRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRed.TabIndex = 6
        Me.picRed.TabStop = False
        Me.picRed.Visible = False
        '
        'picPowerup_2
        '
        Me.picPowerup_2.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.picPowerup_2.Location = New System.Drawing.Point(726, 74)
        Me.picPowerup_2.Name = "picPowerup_2"
        Me.picPowerup_2.Size = New System.Drawing.Size(30, 30)
        Me.picPowerup_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPowerup_2.TabIndex = 308
        Me.picPowerup_2.TabStop = False
        '
        'picPowerup_1
        '
        Me.picPowerup_1.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.picPowerup_1.Location = New System.Drawing.Point(122, 74)
        Me.picPowerup_1.Name = "picPowerup_1"
        Me.picPowerup_1.Size = New System.Drawing.Size(30, 30)
        Me.picPowerup_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPowerup_1.TabIndex = 307
        Me.picPowerup_1.TabStop = False
        '
        'picPowerup_3
        '
        Me.picPowerup_3.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.picPowerup_3.Location = New System.Drawing.Point(122, 558)
        Me.picPowerup_3.Name = "picPowerup_3"
        Me.picPowerup_3.Size = New System.Drawing.Size(30, 30)
        Me.picPowerup_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPowerup_3.TabIndex = 306
        Me.picPowerup_3.TabStop = False
        '
        'picPowerup_4
        '
        Me.picPowerup_4.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.picPowerup_4.Location = New System.Drawing.Point(726, 558)
        Me.picPowerup_4.Name = "picPowerup_4"
        Me.picPowerup_4.Size = New System.Drawing.Size(30, 30)
        Me.picPowerup_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPowerup_4.TabIndex = 305
        Me.picPowerup_4.TabStop = False
        '
        'PictureBox276
        '
        Me.PictureBox276.Location = New System.Drawing.Point(307, 424)
        Me.PictureBox276.Name = "PictureBox276"
        Me.PictureBox276.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox276.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox276.TabIndex = 297
        Me.PictureBox276.TabStop = False
        Me.PictureBox276.Visible = False
        '
        'PictureBox275
        '
        Me.PictureBox275.Location = New System.Drawing.Point(168, 553)
        Me.PictureBox275.Name = "PictureBox275"
        Me.PictureBox275.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox275.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox275.TabIndex = 296
        Me.PictureBox275.TabStop = False
        Me.PictureBox275.Visible = False
        '
        'PictureBox274
        '
        Me.PictureBox274.Location = New System.Drawing.Point(526, 624)
        Me.PictureBox274.Name = "PictureBox274"
        Me.PictureBox274.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox274.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox274.TabIndex = 295
        Me.PictureBox274.TabStop = False
        Me.PictureBox274.Visible = False
        '
        'PictureBox272
        '
        Me.PictureBox272.Location = New System.Drawing.Point(307, 619)
        Me.PictureBox272.Name = "PictureBox272"
        Me.PictureBox272.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox272.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox272.TabIndex = 293
        Me.PictureBox272.TabStop = False
        Me.PictureBox272.Visible = False
        '
        'PictureBox271
        '
        Me.PictureBox271.Location = New System.Drawing.Point(600, 624)
        Me.PictureBox271.Name = "PictureBox271"
        Me.PictureBox271.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox271.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox271.TabIndex = 292
        Me.PictureBox271.TabStop = False
        Me.PictureBox271.Visible = False
        '
        'PictureBox269
        '
        Me.PictureBox269.Location = New System.Drawing.Point(307, 220)
        Me.PictureBox269.Name = "PictureBox269"
        Me.PictureBox269.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox269.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox269.TabIndex = 290
        Me.PictureBox269.TabStop = False
        Me.PictureBox269.Visible = False
        '
        'PictureBox268
        '
        Me.PictureBox268.Location = New System.Drawing.Point(117, 220)
        Me.PictureBox268.Name = "PictureBox268"
        Me.PictureBox268.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox268.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox268.TabIndex = 289
        Me.PictureBox268.TabStop = False
        Me.PictureBox268.Visible = False
        '
        'PictureBox267
        '
        Me.PictureBox267.Location = New System.Drawing.Point(526, 220)
        Me.PictureBox267.Name = "PictureBox267"
        Me.PictureBox267.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox267.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox267.TabIndex = 288
        Me.PictureBox267.TabStop = False
        Me.PictureBox267.Visible = False
        '
        'PictureBox266
        '
        Me.PictureBox266.Location = New System.Drawing.Point(234, 619)
        Me.PictureBox266.Name = "PictureBox266"
        Me.PictureBox266.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox266.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox266.TabIndex = 287
        Me.PictureBox266.TabStop = False
        Me.PictureBox266.Visible = False
        '
        'PictureBox264
        '
        Me.PictureBox264.Location = New System.Drawing.Point(717, 220)
        Me.PictureBox264.Name = "PictureBox264"
        Me.PictureBox264.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox264.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox264.TabIndex = 285
        Me.PictureBox264.TabStop = False
        Me.PictureBox264.Visible = False
        '
        'PictureBox262
        '
        Me.PictureBox262.Location = New System.Drawing.Point(600, 220)
        Me.PictureBox262.Name = "PictureBox262"
        Me.PictureBox262.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox262.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox262.TabIndex = 283
        Me.PictureBox262.TabStop = False
        Me.PictureBox262.Visible = False
        '
        'PictureBox261
        '
        Me.PictureBox261.Location = New System.Drawing.Point(234, 553)
        Me.PictureBox261.Name = "PictureBox261"
        Me.PictureBox261.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox261.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox261.TabIndex = 282
        Me.PictureBox261.TabStop = False
        Me.PictureBox261.Visible = False
        '
        'PictureBox260
        '
        Me.PictureBox260.Location = New System.Drawing.Point(526, 352)
        Me.PictureBox260.Name = "PictureBox260"
        Me.PictureBox260.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox260.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox260.TabIndex = 281
        Me.PictureBox260.TabStop = False
        Me.PictureBox260.Visible = False
        '
        'PictureBox259
        '
        Me.PictureBox259.Location = New System.Drawing.Point(117, 154)
        Me.PictureBox259.Name = "PictureBox259"
        Me.PictureBox259.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox259.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox259.TabIndex = 280
        Me.PictureBox259.TabStop = False
        Me.PictureBox259.Visible = False
        '
        'PictureBox258
        '
        Me.PictureBox258.Location = New System.Drawing.Point(526, 424)
        Me.PictureBox258.Name = "PictureBox258"
        Me.PictureBox258.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox258.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox258.TabIndex = 279
        Me.PictureBox258.TabStop = False
        Me.PictureBox258.Visible = False
        '
        'PictureBox257
        '
        Me.PictureBox257.Location = New System.Drawing.Point(307, 352)
        Me.PictureBox257.Name = "PictureBox257"
        Me.PictureBox257.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox257.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox257.TabIndex = 278
        Me.PictureBox257.TabStop = False
        Me.PictureBox257.Visible = False
        '
        'PictureBox256
        '
        Me.PictureBox256.Location = New System.Drawing.Point(234, 220)
        Me.PictureBox256.Name = "PictureBox256"
        Me.PictureBox256.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox256.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox256.TabIndex = 277
        Me.PictureBox256.TabStop = False
        Me.PictureBox256.Visible = False
        '
        'PictureBox255
        '
        Me.PictureBox255.Location = New System.Drawing.Point(600, 553)
        Me.PictureBox255.Name = "PictureBox255"
        Me.PictureBox255.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox255.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox255.TabIndex = 276
        Me.PictureBox255.TabStop = False
        Me.PictureBox255.Visible = False
        '
        'PictureBox254
        '
        Me.PictureBox254.Location = New System.Drawing.Point(717, 154)
        Me.PictureBox254.Name = "PictureBox254"
        Me.PictureBox254.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox254.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox254.TabIndex = 275
        Me.PictureBox254.TabStop = False
        Me.PictureBox254.Visible = False
        '
        'PictureBox253
        '
        Me.PictureBox253.Location = New System.Drawing.Point(454, 284)
        Me.PictureBox253.Name = "PictureBox253"
        Me.PictureBox253.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox253.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox253.TabIndex = 274
        Me.PictureBox253.TabStop = False
        Me.PictureBox253.Visible = False
        '
        'PictureBox252
        '
        Me.PictureBox252.Location = New System.Drawing.Point(381, 284)
        Me.PictureBox252.Name = "PictureBox252"
        Me.PictureBox252.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox252.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox252.TabIndex = 273
        Me.PictureBox252.TabStop = False
        Me.PictureBox252.Visible = False
        '
        'PictureBox251
        '
        Me.PictureBox251.Location = New System.Drawing.Point(307, 492)
        Me.PictureBox251.Name = "PictureBox251"
        Me.PictureBox251.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox251.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox251.TabIndex = 272
        Me.PictureBox251.TabStop = False
        Me.PictureBox251.Visible = False
        '
        'PictureBox250
        '
        Me.PictureBox250.Location = New System.Drawing.Point(526, 492)
        Me.PictureBox250.Name = "PictureBox250"
        Me.PictureBox250.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox250.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox250.TabIndex = 271
        Me.PictureBox250.TabStop = False
        Me.PictureBox250.Visible = False
        '
        'PictureBox249
        '
        Me.PictureBox249.Location = New System.Drawing.Point(454, 687)
        Me.PictureBox249.Name = "PictureBox249"
        Me.PictureBox249.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox249.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox249.TabIndex = 270
        Me.PictureBox249.TabStop = False
        Me.PictureBox249.Visible = False
        '
        'PictureBox248
        '
        Me.PictureBox248.Location = New System.Drawing.Point(384, 687)
        Me.PictureBox248.Name = "PictureBox248"
        Me.PictureBox248.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox248.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox248.TabIndex = 269
        Me.PictureBox248.TabStop = False
        Me.PictureBox248.Visible = False
        '
        'PictureBox247
        '
        Me.PictureBox247.Location = New System.Drawing.Point(673, 624)
        Me.PictureBox247.Name = "PictureBox247"
        Me.PictureBox247.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox247.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox247.TabIndex = 268
        Me.PictureBox247.TabStop = False
        Me.PictureBox247.Visible = False
        '
        'PictureBox246
        '
        Me.PictureBox246.Location = New System.Drawing.Point(168, 619)
        Me.PictureBox246.Name = "PictureBox246"
        Me.PictureBox246.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox246.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox246.TabIndex = 267
        Me.PictureBox246.TabStop = False
        Me.PictureBox246.Visible = False
        '
        'PictureBox245
        '
        Me.PictureBox245.Location = New System.Drawing.Point(454, 553)
        Me.PictureBox245.Name = "PictureBox245"
        Me.PictureBox245.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox245.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox245.TabIndex = 266
        Me.PictureBox245.TabStop = False
        Me.PictureBox245.Visible = False
        '
        'PictureBox244
        '
        Me.PictureBox244.Location = New System.Drawing.Point(381, 553)
        Me.PictureBox244.Name = "PictureBox244"
        Me.PictureBox244.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox244.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox244.TabIndex = 265
        Me.PictureBox244.TabStop = False
        Me.PictureBox244.Visible = False
        '
        'PictureBox243
        '
        Me.PictureBox243.Location = New System.Drawing.Point(381, 154)
        Me.PictureBox243.Name = "PictureBox243"
        Me.PictureBox243.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox243.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox243.TabIndex = 264
        Me.PictureBox243.TabStop = False
        Me.PictureBox243.Visible = False
        '
        'PictureBox242
        '
        Me.PictureBox242.Location = New System.Drawing.Point(454, 154)
        Me.PictureBox242.Name = "PictureBox242"
        Me.PictureBox242.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox242.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox242.TabIndex = 263
        Me.PictureBox242.TabStop = False
        Me.PictureBox242.Visible = False
        '
        'PictureBox241
        '
        Me.PictureBox241.Location = New System.Drawing.Point(234, 153)
        Me.PictureBox241.Name = "PictureBox241"
        Me.PictureBox241.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox241.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox241.TabIndex = 262
        Me.PictureBox241.TabStop = False
        Me.PictureBox241.Visible = False
        '
        'PictureBox240
        '
        Me.PictureBox240.Location = New System.Drawing.Point(600, 154)
        Me.PictureBox240.Name = "PictureBox240"
        Me.PictureBox240.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox240.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox240.TabIndex = 261
        Me.PictureBox240.TabStop = False
        Me.PictureBox240.Visible = False
        '
        'PictureBox239
        '
        Me.PictureBox239.Location = New System.Drawing.Point(600, 492)
        Me.PictureBox239.Name = "PictureBox239"
        Me.PictureBox239.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox239.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox239.TabIndex = 260
        Me.PictureBox239.TabStop = False
        Me.PictureBox239.Visible = False
        '
        'PictureBox238
        '
        Me.PictureBox238.Location = New System.Drawing.Point(234, 492)
        Me.PictureBox238.Name = "PictureBox238"
        Me.PictureBox238.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox238.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox238.TabIndex = 259
        Me.PictureBox238.TabStop = False
        Me.PictureBox238.Visible = False
        '
        'PictureBox237
        '
        Me.PictureBox237.Location = New System.Drawing.Point(234, 352)
        Me.PictureBox237.Name = "PictureBox237"
        Me.PictureBox237.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox237.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox237.TabIndex = 258
        Me.PictureBox237.TabStop = False
        Me.PictureBox237.Visible = False
        '
        'PictureBox236
        '
        Me.PictureBox236.Location = New System.Drawing.Point(600, 352)
        Me.PictureBox236.Name = "PictureBox236"
        Me.PictureBox236.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox236.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox236.TabIndex = 257
        Me.PictureBox236.TabStop = False
        Me.PictureBox236.Visible = False
        '
        'PictureBox235
        '
        Me.PictureBox235.Location = New System.Drawing.Point(526, 553)
        Me.PictureBox235.Name = "PictureBox235"
        Me.PictureBox235.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox235.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox235.TabIndex = 256
        Me.PictureBox235.TabStop = False
        Me.PictureBox235.Visible = False
        '
        'PictureBox234
        '
        Me.PictureBox234.Location = New System.Drawing.Point(307, 553)
        Me.PictureBox234.Name = "PictureBox234"
        Me.PictureBox234.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox234.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox234.TabIndex = 255
        Me.PictureBox234.TabStop = False
        Me.PictureBox234.Visible = False
        '
        'PictureBox233
        '
        Me.PictureBox233.Location = New System.Drawing.Point(526, 153)
        Me.PictureBox233.Name = "PictureBox233"
        Me.PictureBox233.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox233.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox233.TabIndex = 254
        Me.PictureBox233.TabStop = False
        Me.PictureBox233.Visible = False
        '
        'PictureBox232
        '
        Me.PictureBox232.Location = New System.Drawing.Point(307, 154)
        Me.PictureBox232.Name = "PictureBox232"
        Me.PictureBox232.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox232.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox232.TabIndex = 253
        Me.PictureBox232.TabStop = False
        Me.PictureBox232.Visible = False
        '
        'PictureBox231
        '
        Me.PictureBox231.Location = New System.Drawing.Point(600, 70)
        Me.PictureBox231.Name = "PictureBox231"
        Me.PictureBox231.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox231.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox231.TabIndex = 252
        Me.PictureBox231.TabStop = False
        Me.PictureBox231.Visible = False
        '
        'PictureBox230
        '
        Me.PictureBox230.Location = New System.Drawing.Point(234, 70)
        Me.PictureBox230.Name = "PictureBox230"
        Me.PictureBox230.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox230.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox230.TabIndex = 251
        Me.PictureBox230.TabStop = False
        Me.PictureBox230.Visible = False
        '
        'PictureBox229
        '
        Me.PictureBox229.Location = New System.Drawing.Point(381, 492)
        Me.PictureBox229.Name = "PictureBox229"
        Me.PictureBox229.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox229.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox229.TabIndex = 250
        Me.PictureBox229.TabStop = False
        Me.PictureBox229.Visible = False
        '
        'PictureBox228
        '
        Me.PictureBox228.Location = New System.Drawing.Point(384, 619)
        Me.PictureBox228.Name = "PictureBox228"
        Me.PictureBox228.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox228.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox228.TabIndex = 249
        Me.PictureBox228.TabStop = False
        Me.PictureBox228.Visible = False
        '
        'PictureBox227
        '
        Me.PictureBox227.Location = New System.Drawing.Point(381, 220)
        Me.PictureBox227.Name = "PictureBox227"
        Me.PictureBox227.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox227.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox227.TabIndex = 248
        Me.PictureBox227.TabStop = False
        Me.PictureBox227.Visible = False
        '
        'PictureBox226
        '
        Me.PictureBox226.Location = New System.Drawing.Point(381, 70)
        Me.PictureBox226.Name = "PictureBox226"
        Me.PictureBox226.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox226.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox226.TabIndex = 247
        Me.PictureBox226.TabStop = False
        Me.PictureBox226.Visible = False
        '
        'PictureBox224
        '
        Me.PictureBox224.Location = New System.Drawing.Point(721, 624)
        Me.PictureBox224.Name = "PictureBox224"
        Me.PictureBox224.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox224.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox224.TabIndex = 245
        Me.PictureBox224.TabStop = False
        Me.PictureBox224.Visible = False
        '
        'PictureBox223
        '
        Me.PictureBox223.Location = New System.Drawing.Point(717, 492)
        Me.PictureBox223.Name = "PictureBox223"
        Me.PictureBox223.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox223.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox223.TabIndex = 244
        Me.PictureBox223.TabStop = False
        Me.PictureBox223.Visible = False
        '
        'PictureBox222
        '
        Me.PictureBox222.Location = New System.Drawing.Point(526, 284)
        Me.PictureBox222.Name = "PictureBox222"
        Me.PictureBox222.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox222.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox222.TabIndex = 243
        Me.PictureBox222.TabStop = False
        Me.PictureBox222.Visible = False
        '
        'PictureBox221
        '
        Me.PictureBox221.Location = New System.Drawing.Point(454, 220)
        Me.PictureBox221.Name = "PictureBox221"
        Me.PictureBox221.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox221.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox221.TabIndex = 242
        Me.PictureBox221.TabStop = False
        Me.PictureBox221.Visible = False
        '
        'PictureBox220
        '
        Me.PictureBox220.Location = New System.Drawing.Point(454, 624)
        Me.PictureBox220.Name = "PictureBox220"
        Me.PictureBox220.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox220.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox220.TabIndex = 241
        Me.PictureBox220.TabStop = False
        Me.PictureBox220.Visible = False
        '
        'PictureBox218
        '
        Me.PictureBox218.Location = New System.Drawing.Point(454, 492)
        Me.PictureBox218.Name = "PictureBox218"
        Me.PictureBox218.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox218.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox218.TabIndex = 239
        Me.PictureBox218.TabStop = False
        Me.PictureBox218.Visible = False
        '
        'PictureBox217
        '
        Me.PictureBox217.Location = New System.Drawing.Point(454, 70)
        Me.PictureBox217.Name = "PictureBox217"
        Me.PictureBox217.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox217.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox217.TabIndex = 238
        Me.PictureBox217.TabStop = False
        Me.PictureBox217.Visible = False
        '
        'PictureBox216
        '
        Me.PictureBox216.Location = New System.Drawing.Point(117, 619)
        Me.PictureBox216.Name = "PictureBox216"
        Me.PictureBox216.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox216.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox216.TabIndex = 237
        Me.PictureBox216.TabStop = False
        Me.PictureBox216.Visible = False
        '
        'PictureBox215
        '
        Me.PictureBox215.Location = New System.Drawing.Point(117, 492)
        Me.PictureBox215.Name = "PictureBox215"
        Me.PictureBox215.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox215.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox215.TabIndex = 236
        Me.PictureBox215.TabStop = False
        Me.PictureBox215.Visible = False
        '
        'PictureBox213
        '
        Me.PictureBox213.Location = New System.Drawing.Point(307, 284)
        Me.PictureBox213.Name = "PictureBox213"
        Me.PictureBox213.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox213.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox213.TabIndex = 234
        Me.PictureBox213.TabStop = False
        Me.PictureBox213.Visible = False
        '
        'PictureBox212
        '
        Me.PictureBox212.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox212.Location = New System.Drawing.Point(130, 503)
        Me.PictureBox212.Name = "PictureBox212"
        Me.PictureBox212.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox212.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox212.TabIndex = 233
        Me.PictureBox212.TabStop = False
        '
        'PictureBox211
        '
        Me.PictureBox211.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox211.Location = New System.Drawing.Point(158, 703)
        Me.PictureBox211.Name = "PictureBox211"
        Me.PictureBox211.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox211.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox211.TabIndex = 232
        Me.PictureBox211.TabStop = False
        '
        'PictureBox210
        '
        Me.PictureBox210.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox210.Location = New System.Drawing.Point(130, 674)
        Me.PictureBox210.Name = "PictureBox210"
        Me.PictureBox210.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox210.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox210.TabIndex = 231
        Me.PictureBox210.TabStop = False
        '
        'PictureBox209
        '
        Me.PictureBox209.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox209.Location = New System.Drawing.Point(130, 637)
        Me.PictureBox209.Name = "PictureBox209"
        Me.PictureBox209.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox209.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox209.TabIndex = 230
        Me.PictureBox209.TabStop = False
        '
        'PictureBox208
        '
        Me.PictureBox208.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox208.Location = New System.Drawing.Point(158, 637)
        Me.PictureBox208.Name = "PictureBox208"
        Me.PictureBox208.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox208.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox208.TabIndex = 229
        Me.PictureBox208.TabStop = False
        '
        'PictureBox207
        '
        Me.PictureBox207.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox207.Location = New System.Drawing.Point(130, 703)
        Me.PictureBox207.Name = "PictureBox207"
        Me.PictureBox207.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox207.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox207.TabIndex = 228
        Me.PictureBox207.TabStop = False
        '
        'PictureBox206
        '
        Me.PictureBox206.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox206.Location = New System.Drawing.Point(158, 570)
        Me.PictureBox206.Name = "PictureBox206"
        Me.PictureBox206.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox206.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox206.TabIndex = 227
        Me.PictureBox206.TabStop = False
        '
        'PictureBox205
        '
        Me.PictureBox205.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox205.Location = New System.Drawing.Point(183, 603)
        Me.PictureBox205.Name = "PictureBox205"
        Me.PictureBox205.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox205.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox205.TabIndex = 226
        Me.PictureBox205.TabStop = False
        '
        'PictureBox204
        '
        Me.PictureBox204.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox204.Location = New System.Drawing.Point(183, 570)
        Me.PictureBox204.Name = "PictureBox204"
        Me.PictureBox204.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox204.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox204.TabIndex = 225
        Me.PictureBox204.TabStop = False
        '
        'PictureBox203
        '
        Me.PictureBox203.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox203.Location = New System.Drawing.Point(130, 537)
        Me.PictureBox203.Name = "PictureBox203"
        Me.PictureBox203.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox203.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox203.TabIndex = 224
        Me.PictureBox203.TabStop = False
        '
        'PictureBox202
        '
        Me.PictureBox202.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox202.Location = New System.Drawing.Point(158, 503)
        Me.PictureBox202.Name = "PictureBox202"
        Me.PictureBox202.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox202.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox202.TabIndex = 223
        Me.PictureBox202.TabStop = False
        '
        'PictureBox201
        '
        Me.PictureBox201.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox201.Location = New System.Drawing.Point(187, 703)
        Me.PictureBox201.Name = "PictureBox201"
        Me.PictureBox201.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox201.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox201.TabIndex = 222
        Me.PictureBox201.TabStop = False
        '
        'PictureBox200
        '
        Me.PictureBox200.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox200.Location = New System.Drawing.Point(187, 503)
        Me.PictureBox200.Name = "PictureBox200"
        Me.PictureBox200.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox200.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox200.TabIndex = 221
        Me.PictureBox200.TabStop = False
        '
        'PictureBox199
        '
        Me.PictureBox199.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox199.Location = New System.Drawing.Point(218, 503)
        Me.PictureBox199.Name = "PictureBox199"
        Me.PictureBox199.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox199.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox199.TabIndex = 220
        Me.PictureBox199.TabStop = False
        '
        'PictureBox198
        '
        Me.PictureBox198.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox198.Location = New System.Drawing.Point(183, 637)
        Me.PictureBox198.Name = "PictureBox198"
        Me.PictureBox198.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox198.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox198.TabIndex = 219
        Me.PictureBox198.TabStop = False
        '
        'PictureBox197
        '
        Me.PictureBox197.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox197.Location = New System.Drawing.Point(218, 637)
        Me.PictureBox197.Name = "PictureBox197"
        Me.PictureBox197.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox197.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox197.TabIndex = 218
        Me.PictureBox197.TabStop = False
        '
        'PictureBox196
        '
        Me.PictureBox196.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox196.Location = New System.Drawing.Point(218, 703)
        Me.PictureBox196.Name = "PictureBox196"
        Me.PictureBox196.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox196.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox196.TabIndex = 217
        Me.PictureBox196.TabStop = False
        '
        'PictureBox195
        '
        Me.PictureBox195.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox195.Location = New System.Drawing.Point(737, 674)
        Me.PictureBox195.Name = "PictureBox195"
        Me.PictureBox195.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox195.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox195.TabIndex = 216
        Me.PictureBox195.TabStop = False
        '
        'PictureBox194
        '
        Me.PictureBox194.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox194.Location = New System.Drawing.Point(255, 637)
        Me.PictureBox194.Name = "PictureBox194"
        Me.PictureBox194.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox194.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox194.TabIndex = 215
        Me.PictureBox194.TabStop = False
        '
        'PictureBox193
        '
        Me.PictureBox193.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox193.Location = New System.Drawing.Point(255, 703)
        Me.PictureBox193.Name = "PictureBox193"
        Me.PictureBox193.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox193.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox193.TabIndex = 214
        Me.PictureBox193.TabStop = False
        '
        'PictureBox192
        '
        Me.PictureBox192.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox192.Location = New System.Drawing.Point(290, 703)
        Me.PictureBox192.Name = "PictureBox192"
        Me.PictureBox192.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox192.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox192.TabIndex = 213
        Me.PictureBox192.TabStop = False
        '
        'PictureBox191
        '
        Me.PictureBox191.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox191.Location = New System.Drawing.Point(325, 703)
        Me.PictureBox191.Name = "PictureBox191"
        Me.PictureBox191.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox191.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox191.TabIndex = 212
        Me.PictureBox191.TabStop = False
        '
        'PictureBox190
        '
        Me.PictureBox190.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox190.Location = New System.Drawing.Point(363, 703)
        Me.PictureBox190.Name = "PictureBox190"
        Me.PictureBox190.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox190.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox190.TabIndex = 211
        Me.PictureBox190.TabStop = False
        '
        'PictureBox189
        '
        Me.PictureBox189.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox189.Location = New System.Drawing.Point(398, 703)
        Me.PictureBox189.Name = "PictureBox189"
        Me.PictureBox189.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox189.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox189.TabIndex = 210
        Me.PictureBox189.TabStop = False
        '
        'PictureBox188
        '
        Me.PictureBox188.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox188.Location = New System.Drawing.Point(398, 674)
        Me.PictureBox188.Name = "PictureBox188"
        Me.PictureBox188.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox188.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox188.TabIndex = 209
        Me.PictureBox188.TabStop = False
        '
        'PictureBox187
        '
        Me.PictureBox187.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox187.Location = New System.Drawing.Point(398, 637)
        Me.PictureBox187.Name = "PictureBox187"
        Me.PictureBox187.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox187.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox187.TabIndex = 208
        Me.PictureBox187.TabStop = False
        '
        'PictureBox186
        '
        Me.PictureBox186.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox186.Location = New System.Drawing.Point(363, 637)
        Me.PictureBox186.Name = "PictureBox186"
        Me.PictureBox186.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox186.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox186.TabIndex = 207
        Me.PictureBox186.TabStop = False
        '
        'PictureBox185
        '
        Me.PictureBox185.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox185.Location = New System.Drawing.Point(325, 637)
        Me.PictureBox185.Name = "PictureBox185"
        Me.PictureBox185.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox185.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox185.TabIndex = 206
        Me.PictureBox185.TabStop = False
        '
        'PictureBox184
        '
        Me.PictureBox184.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox184.Location = New System.Drawing.Point(325, 603)
        Me.PictureBox184.Name = "PictureBox184"
        Me.PictureBox184.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox184.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox184.TabIndex = 205
        Me.PictureBox184.TabStop = False
        '
        'PictureBox183
        '
        Me.PictureBox183.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox183.Location = New System.Drawing.Point(255, 603)
        Me.PictureBox183.Name = "PictureBox183"
        Me.PictureBox183.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox183.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox183.TabIndex = 204
        Me.PictureBox183.TabStop = False
        '
        'PictureBox182
        '
        Me.PictureBox182.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox182.Location = New System.Drawing.Point(255, 570)
        Me.PictureBox182.Name = "PictureBox182"
        Me.PictureBox182.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox182.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox182.TabIndex = 203
        Me.PictureBox182.TabStop = False
        '
        'PictureBox181
        '
        Me.PictureBox181.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox181.Location = New System.Drawing.Point(255, 537)
        Me.PictureBox181.Name = "PictureBox181"
        Me.PictureBox181.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox181.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox181.TabIndex = 202
        Me.PictureBox181.TabStop = False
        '
        'PictureBox180
        '
        Me.PictureBox180.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox180.Location = New System.Drawing.Point(290, 570)
        Me.PictureBox180.Name = "PictureBox180"
        Me.PictureBox180.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox180.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox180.TabIndex = 201
        Me.PictureBox180.TabStop = False
        '
        'PictureBox179
        '
        Me.PictureBox179.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox179.Location = New System.Drawing.Point(325, 570)
        Me.PictureBox179.Name = "PictureBox179"
        Me.PictureBox179.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox179.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox179.TabIndex = 200
        Me.PictureBox179.TabStop = False
        '
        'PictureBox178
        '
        Me.PictureBox178.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox178.Location = New System.Drawing.Point(360, 570)
        Me.PictureBox178.Name = "PictureBox178"
        Me.PictureBox178.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox178.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox178.TabIndex = 199
        Me.PictureBox178.TabStop = False
        '
        'PictureBox177
        '
        Me.PictureBox177.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox177.Location = New System.Drawing.Point(398, 570)
        Me.PictureBox177.Name = "PictureBox177"
        Me.PictureBox177.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox177.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox177.TabIndex = 198
        Me.PictureBox177.TabStop = False
        '
        'PictureBox176
        '
        Me.PictureBox176.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox176.Location = New System.Drawing.Point(398, 537)
        Me.PictureBox176.Name = "PictureBox176"
        Me.PictureBox176.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox176.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox176.TabIndex = 197
        Me.PictureBox176.TabStop = False
        '
        'PictureBox175
        '
        Me.PictureBox175.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox175.Location = New System.Drawing.Point(398, 503)
        Me.PictureBox175.Name = "PictureBox175"
        Me.PictureBox175.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox175.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox175.TabIndex = 196
        Me.PictureBox175.TabStop = False
        '
        'PictureBox174
        '
        Me.PictureBox174.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox174.Location = New System.Drawing.Point(360, 503)
        Me.PictureBox174.Name = "PictureBox174"
        Me.PictureBox174.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox174.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox174.TabIndex = 195
        Me.PictureBox174.TabStop = False
        '
        'PictureBox173
        '
        Me.PictureBox173.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox173.Location = New System.Drawing.Point(325, 503)
        Me.PictureBox173.Name = "PictureBox173"
        Me.PictureBox173.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox173.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox173.TabIndex = 194
        Me.PictureBox173.TabStop = False
        '
        'PictureBox172
        '
        Me.PictureBox172.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox172.Location = New System.Drawing.Point(290, 503)
        Me.PictureBox172.Name = "PictureBox172"
        Me.PictureBox172.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox172.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox172.TabIndex = 193
        Me.PictureBox172.TabStop = False
        '
        'PictureBox171
        '
        Me.PictureBox171.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox171.Location = New System.Drawing.Point(255, 503)
        Me.PictureBox171.Name = "PictureBox171"
        Me.PictureBox171.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox171.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox171.TabIndex = 192
        Me.PictureBox171.TabStop = False
        '
        'PictureBox170
        '
        Me.PictureBox170.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox170.Location = New System.Drawing.Point(255, 470)
        Me.PictureBox170.Name = "PictureBox170"
        Me.PictureBox170.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox170.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox170.TabIndex = 191
        Me.PictureBox170.TabStop = False
        '
        'PictureBox169
        '
        Me.PictureBox169.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox169.Location = New System.Drawing.Point(255, 439)
        Me.PictureBox169.Name = "PictureBox169"
        Me.PictureBox169.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox169.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox169.TabIndex = 190
        Me.PictureBox169.TabStop = False
        '
        'PictureBox168
        '
        Me.PictureBox168.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox168.Location = New System.Drawing.Point(255, 402)
        Me.PictureBox168.Name = "PictureBox168"
        Me.PictureBox168.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox168.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox168.TabIndex = 189
        Me.PictureBox168.TabStop = False
        '
        'PictureBox167
        '
        Me.PictureBox167.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox167.Location = New System.Drawing.Point(255, 370)
        Me.PictureBox167.Name = "PictureBox167"
        Me.PictureBox167.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox167.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox167.TabIndex = 188
        Me.PictureBox167.TabStop = False
        '
        'PictureBox166
        '
        Me.PictureBox166.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox166.Location = New System.Drawing.Point(255, 336)
        Me.PictureBox166.Name = "PictureBox166"
        Me.PictureBox166.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox166.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox166.TabIndex = 187
        Me.PictureBox166.TabStop = False
        '
        'PictureBox165
        '
        Me.PictureBox165.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox165.Location = New System.Drawing.Point(255, 305)
        Me.PictureBox165.Name = "PictureBox165"
        Me.PictureBox165.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox165.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox165.TabIndex = 186
        Me.PictureBox165.TabStop = False
        '
        'PictureBox164
        '
        Me.PictureBox164.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox164.Location = New System.Drawing.Point(255, 270)
        Me.PictureBox164.Name = "PictureBox164"
        Me.PictureBox164.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox164.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox164.TabIndex = 185
        Me.PictureBox164.TabStop = False
        '
        'PictureBox163
        '
        Me.PictureBox163.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox163.Location = New System.Drawing.Point(255, 235)
        Me.PictureBox163.Name = "PictureBox163"
        Me.PictureBox163.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox163.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox163.TabIndex = 184
        Me.PictureBox163.TabStop = False
        '
        'PictureBox162
        '
        Me.PictureBox162.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox162.Location = New System.Drawing.Point(398, 235)
        Me.PictureBox162.Name = "PictureBox162"
        Me.PictureBox162.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox162.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox162.TabIndex = 183
        Me.PictureBox162.TabStop = False
        '
        'PictureBox161
        '
        Me.PictureBox161.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox161.Location = New System.Drawing.Point(360, 235)
        Me.PictureBox161.Name = "PictureBox161"
        Me.PictureBox161.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox161.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox161.TabIndex = 182
        Me.PictureBox161.TabStop = False
        '
        'PictureBox160
        '
        Me.PictureBox160.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox160.Location = New System.Drawing.Point(325, 235)
        Me.PictureBox160.Name = "PictureBox160"
        Me.PictureBox160.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox160.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox160.TabIndex = 181
        Me.PictureBox160.TabStop = False
        '
        'PictureBox159
        '
        Me.PictureBox159.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox159.Location = New System.Drawing.Point(325, 204)
        Me.PictureBox159.Name = "PictureBox159"
        Me.PictureBox159.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox159.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox159.TabIndex = 180
        Me.PictureBox159.TabStop = False
        '
        'PictureBox158
        '
        Me.PictureBox158.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox158.Location = New System.Drawing.Point(255, 204)
        Me.PictureBox158.Name = "PictureBox158"
        Me.PictureBox158.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox158.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox158.TabIndex = 179
        Me.PictureBox158.TabStop = False
        '
        'PictureBox157
        '
        Me.PictureBox157.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox157.Location = New System.Drawing.Point(218, 235)
        Me.PictureBox157.Name = "PictureBox157"
        Me.PictureBox157.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox157.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox157.TabIndex = 178
        Me.PictureBox157.TabStop = False
        '
        'PictureBox156
        '
        Me.PictureBox156.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox156.Location = New System.Drawing.Point(187, 235)
        Me.PictureBox156.Name = "PictureBox156"
        Me.PictureBox156.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox156.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox156.TabIndex = 177
        Me.PictureBox156.TabStop = False
        '
        'PictureBox155
        '
        Me.PictureBox155.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox155.Location = New System.Drawing.Point(158, 235)
        Me.PictureBox155.Name = "PictureBox155"
        Me.PictureBox155.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox155.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox155.TabIndex = 176
        Me.PictureBox155.TabStop = False
        '
        'PictureBox154
        '
        Me.PictureBox154.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox154.Location = New System.Drawing.Point(130, 235)
        Me.PictureBox154.Name = "PictureBox154"
        Me.PictureBox154.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox154.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox154.TabIndex = 175
        Me.PictureBox154.TabStop = False
        '
        'PictureBox153
        '
        Me.PictureBox153.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox153.Location = New System.Drawing.Point(130, 204)
        Me.PictureBox153.Name = "PictureBox153"
        Me.PictureBox153.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox153.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox153.TabIndex = 174
        Me.PictureBox153.TabStop = False
        '
        'PictureBox152
        '
        Me.PictureBox152.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox152.Location = New System.Drawing.Point(398, 83)
        Me.PictureBox152.Name = "PictureBox152"
        Me.PictureBox152.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox152.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox152.TabIndex = 173
        Me.PictureBox152.TabStop = False
        '
        'PictureBox151
        '
        Me.PictureBox151.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox151.Location = New System.Drawing.Point(360, 83)
        Me.PictureBox151.Name = "PictureBox151"
        Me.PictureBox151.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox151.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox151.TabIndex = 172
        Me.PictureBox151.TabStop = False
        '
        'PictureBox150
        '
        Me.PictureBox150.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox150.Location = New System.Drawing.Point(325, 83)
        Me.PictureBox150.Name = "PictureBox150"
        Me.PictureBox150.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox150.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox150.TabIndex = 171
        Me.PictureBox150.TabStop = False
        '
        'PictureBox149
        '
        Me.PictureBox149.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox149.Location = New System.Drawing.Point(290, 83)
        Me.PictureBox149.Name = "PictureBox149"
        Me.PictureBox149.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox149.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox149.TabIndex = 170
        Me.PictureBox149.TabStop = False
        '
        'PictureBox148
        '
        Me.PictureBox148.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox148.Location = New System.Drawing.Point(255, 83)
        Me.PictureBox148.Name = "PictureBox148"
        Me.PictureBox148.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox148.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox148.TabIndex = 169
        Me.PictureBox148.TabStop = False
        '
        'PictureBox147
        '
        Me.PictureBox147.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox147.Location = New System.Drawing.Point(218, 83)
        Me.PictureBox147.Name = "PictureBox147"
        Me.PictureBox147.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox147.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox147.TabIndex = 168
        Me.PictureBox147.TabStop = False
        '
        'PictureBox146
        '
        Me.PictureBox146.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox146.Location = New System.Drawing.Point(187, 83)
        Me.PictureBox146.Name = "PictureBox146"
        Me.PictureBox146.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox146.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox146.TabIndex = 167
        Me.PictureBox146.TabStop = False
        '
        'PictureBox145
        '
        Me.PictureBox145.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox145.Location = New System.Drawing.Point(158, 83)
        Me.PictureBox145.Name = "PictureBox145"
        Me.PictureBox145.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox145.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox145.TabIndex = 166
        Me.PictureBox145.TabStop = False
        '
        'PictureBox144
        '
        Me.PictureBox144.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox144.Location = New System.Drawing.Point(398, 110)
        Me.PictureBox144.Name = "PictureBox144"
        Me.PictureBox144.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox144.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox144.TabIndex = 165
        Me.PictureBox144.TabStop = False
        '
        'PictureBox143
        '
        Me.PictureBox143.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox143.Location = New System.Drawing.Point(255, 110)
        Me.PictureBox143.Name = "PictureBox143"
        Me.PictureBox143.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox143.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox143.TabIndex = 164
        Me.PictureBox143.TabStop = False
        '
        'PictureBox142
        '
        Me.PictureBox142.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox142.Location = New System.Drawing.Point(130, 110)
        Me.PictureBox142.Name = "PictureBox142"
        Me.PictureBox142.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox142.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox142.TabIndex = 163
        Me.PictureBox142.TabStop = False
        '
        'PictureBox141
        '
        Me.PictureBox141.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox141.Location = New System.Drawing.Point(130, 137)
        Me.PictureBox141.Name = "PictureBox141"
        Me.PictureBox141.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox141.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox141.TabIndex = 162
        Me.PictureBox141.TabStop = False
        '
        'PictureBox140
        '
        Me.PictureBox140.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox140.Location = New System.Drawing.Point(255, 137)
        Me.PictureBox140.Name = "PictureBox140"
        Me.PictureBox140.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox140.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox140.TabIndex = 161
        Me.PictureBox140.TabStop = False
        '
        'PictureBox139
        '
        Me.PictureBox139.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox139.Location = New System.Drawing.Point(398, 137)
        Me.PictureBox139.Name = "PictureBox139"
        Me.PictureBox139.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox139.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox139.TabIndex = 160
        Me.PictureBox139.TabStop = False
        '
        'PictureBox138
        '
        Me.PictureBox138.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox138.Location = New System.Drawing.Point(130, 171)
        Me.PictureBox138.Name = "PictureBox138"
        Me.PictureBox138.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox138.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox138.TabIndex = 159
        Me.PictureBox138.TabStop = False
        '
        'PictureBox137
        '
        Me.PictureBox137.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox137.Location = New System.Drawing.Point(158, 171)
        Me.PictureBox137.Name = "PictureBox137"
        Me.PictureBox137.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox137.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox137.TabIndex = 158
        Me.PictureBox137.TabStop = False
        '
        'PictureBox136
        '
        Me.PictureBox136.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox136.Location = New System.Drawing.Point(187, 171)
        Me.PictureBox136.Name = "PictureBox136"
        Me.PictureBox136.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox136.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox136.TabIndex = 157
        Me.PictureBox136.TabStop = False
        '
        'PictureBox135
        '
        Me.PictureBox135.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox135.Location = New System.Drawing.Point(218, 171)
        Me.PictureBox135.Name = "PictureBox135"
        Me.PictureBox135.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox135.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox135.TabIndex = 156
        Me.PictureBox135.TabStop = False
        '
        'PictureBox134
        '
        Me.PictureBox134.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox134.Location = New System.Drawing.Point(255, 171)
        Me.PictureBox134.Name = "PictureBox134"
        Me.PictureBox134.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox134.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox134.TabIndex = 155
        Me.PictureBox134.TabStop = False
        '
        'PictureBox133
        '
        Me.PictureBox133.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox133.Location = New System.Drawing.Point(290, 171)
        Me.PictureBox133.Name = "PictureBox133"
        Me.PictureBox133.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox133.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox133.TabIndex = 154
        Me.PictureBox133.TabStop = False
        '
        'PictureBox132
        '
        Me.PictureBox132.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox132.Location = New System.Drawing.Point(325, 171)
        Me.PictureBox132.Name = "PictureBox132"
        Me.PictureBox132.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox132.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox132.TabIndex = 153
        Me.PictureBox132.TabStop = False
        '
        'PictureBox131
        '
        Me.PictureBox131.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox131.Location = New System.Drawing.Point(360, 171)
        Me.PictureBox131.Name = "PictureBox131"
        Me.PictureBox131.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox131.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox131.TabIndex = 152
        Me.PictureBox131.TabStop = False
        '
        'PictureBox130
        '
        Me.PictureBox130.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox130.Location = New System.Drawing.Point(398, 171)
        Me.PictureBox130.Name = "PictureBox130"
        Me.PictureBox130.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox130.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox130.TabIndex = 151
        Me.PictureBox130.TabStop = False
        '
        'PictureBox129
        '
        Me.PictureBox129.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox129.Location = New System.Drawing.Point(437, 171)
        Me.PictureBox129.Name = "PictureBox129"
        Me.PictureBox129.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox129.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox129.TabIndex = 150
        Me.PictureBox129.TabStop = False
        '
        'PictureBox128
        '
        Me.PictureBox128.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox128.Location = New System.Drawing.Point(582, 83)
        Me.PictureBox128.Name = "PictureBox128"
        Me.PictureBox128.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox128.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox128.TabIndex = 149
        Me.PictureBox128.TabStop = False
        '
        'PictureBox127
        '
        Me.PictureBox127.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox127.Location = New System.Drawing.Point(546, 83)
        Me.PictureBox127.Name = "PictureBox127"
        Me.PictureBox127.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox127.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox127.TabIndex = 148
        Me.PictureBox127.TabStop = False
        '
        'PictureBox126
        '
        Me.PictureBox126.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox126.Location = New System.Drawing.Point(510, 83)
        Me.PictureBox126.Name = "PictureBox126"
        Me.PictureBox126.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox126.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox126.TabIndex = 147
        Me.PictureBox126.TabStop = False
        '
        'PictureBox125
        '
        Me.PictureBox125.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox125.Location = New System.Drawing.Point(473, 83)
        Me.PictureBox125.Name = "PictureBox125"
        Me.PictureBox125.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox125.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox125.TabIndex = 146
        Me.PictureBox125.TabStop = False
        '
        'PictureBox124
        '
        Me.PictureBox124.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox124.Location = New System.Drawing.Point(473, 110)
        Me.PictureBox124.Name = "PictureBox124"
        Me.PictureBox124.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox124.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox124.TabIndex = 145
        Me.PictureBox124.TabStop = False
        '
        'PictureBox123
        '
        Me.PictureBox123.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox123.Location = New System.Drawing.Point(473, 137)
        Me.PictureBox123.Name = "PictureBox123"
        Me.PictureBox123.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox123.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox123.TabIndex = 144
        Me.PictureBox123.TabStop = False
        '
        'PictureBox122
        '
        Me.PictureBox122.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox122.Location = New System.Drawing.Point(473, 171)
        Me.PictureBox122.Name = "PictureBox122"
        Me.PictureBox122.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox122.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox122.TabIndex = 143
        Me.PictureBox122.TabStop = False
        '
        'PictureBox121
        '
        Me.PictureBox121.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox121.Location = New System.Drawing.Point(510, 171)
        Me.PictureBox121.Name = "PictureBox121"
        Me.PictureBox121.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox121.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox121.TabIndex = 142
        Me.PictureBox121.TabStop = False
        '
        'PictureBox120
        '
        Me.PictureBox120.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox120.Location = New System.Drawing.Point(437, 703)
        Me.PictureBox120.Name = "PictureBox120"
        Me.PictureBox120.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox120.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox120.TabIndex = 141
        Me.PictureBox120.TabStop = False
        '
        'PictureBox119
        '
        Me.PictureBox119.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox119.Location = New System.Drawing.Point(582, 171)
        Me.PictureBox119.Name = "PictureBox119"
        Me.PictureBox119.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox119.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox119.TabIndex = 140
        Me.PictureBox119.TabStop = False
        '
        'PictureBox118
        '
        Me.PictureBox118.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox118.Location = New System.Drawing.Point(546, 171)
        Me.PictureBox118.Name = "PictureBox118"
        Me.PictureBox118.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox118.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox118.TabIndex = 139
        Me.PictureBox118.TabStop = False
        '
        'PictureBox117
        '
        Me.PictureBox117.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox117.Location = New System.Drawing.Point(546, 204)
        Me.PictureBox117.Name = "PictureBox117"
        Me.PictureBox117.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox117.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox117.TabIndex = 138
        Me.PictureBox117.TabStop = False
        '
        'PictureBox116
        '
        Me.PictureBox116.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox116.Location = New System.Drawing.Point(546, 235)
        Me.PictureBox116.Name = "PictureBox116"
        Me.PictureBox116.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox116.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox116.TabIndex = 137
        Me.PictureBox116.TabStop = False
        '
        'PictureBox115
        '
        Me.PictureBox115.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox115.Location = New System.Drawing.Point(510, 235)
        Me.PictureBox115.Name = "PictureBox115"
        Me.PictureBox115.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox115.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox115.TabIndex = 136
        Me.PictureBox115.TabStop = False
        '
        'PictureBox114
        '
        Me.PictureBox114.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox114.Location = New System.Drawing.Point(473, 235)
        Me.PictureBox114.Name = "PictureBox114"
        Me.PictureBox114.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox114.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox114.TabIndex = 135
        Me.PictureBox114.TabStop = False
        '
        'PictureBox113
        '
        Me.PictureBox113.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox113.Location = New System.Drawing.Point(710, 703)
        Me.PictureBox113.Name = "PictureBox113"
        Me.PictureBox113.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox113.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox113.TabIndex = 134
        Me.PictureBox113.TabStop = False
        '
        'PictureBox112
        '
        Me.PictureBox112.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox112.Location = New System.Drawing.Point(676, 703)
        Me.PictureBox112.Name = "PictureBox112"
        Me.PictureBox112.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox112.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox112.TabIndex = 133
        Me.PictureBox112.TabStop = False
        '
        'PictureBox111
        '
        Me.PictureBox111.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox111.Location = New System.Drawing.Point(648, 703)
        Me.PictureBox111.Name = "PictureBox111"
        Me.PictureBox111.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox111.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox111.TabIndex = 132
        Me.PictureBox111.TabStop = False
        '
        'PictureBox110
        '
        Me.PictureBox110.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox110.Location = New System.Drawing.Point(616, 703)
        Me.PictureBox110.Name = "PictureBox110"
        Me.PictureBox110.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox110.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox110.TabIndex = 131
        Me.PictureBox110.TabStop = False
        '
        'PictureBox109
        '
        Me.PictureBox109.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox109.Location = New System.Drawing.Point(582, 703)
        Me.PictureBox109.Name = "PictureBox109"
        Me.PictureBox109.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox109.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox109.TabIndex = 130
        Me.PictureBox109.TabStop = False
        '
        'PictureBox108
        '
        Me.PictureBox108.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox108.Location = New System.Drawing.Point(546, 703)
        Me.PictureBox108.Name = "PictureBox108"
        Me.PictureBox108.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox108.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox108.TabIndex = 129
        Me.PictureBox108.TabStop = False
        '
        'PictureBox107
        '
        Me.PictureBox107.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox107.Location = New System.Drawing.Point(510, 703)
        Me.PictureBox107.Name = "PictureBox107"
        Me.PictureBox107.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox107.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox107.TabIndex = 128
        Me.PictureBox107.TabStop = False
        '
        'PictureBox106
        '
        Me.PictureBox106.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox106.Location = New System.Drawing.Point(473, 703)
        Me.PictureBox106.Name = "PictureBox106"
        Me.PictureBox106.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox106.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox106.TabIndex = 127
        Me.PictureBox106.TabStop = False
        '
        'PictureBox105
        '
        Me.PictureBox105.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox105.Location = New System.Drawing.Point(473, 674)
        Me.PictureBox105.Name = "PictureBox105"
        Me.PictureBox105.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox105.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox105.TabIndex = 126
        Me.PictureBox105.TabStop = False
        '
        'PictureBox104
        '
        Me.PictureBox104.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox104.Location = New System.Drawing.Point(737, 637)
        Me.PictureBox104.Name = "PictureBox104"
        Me.PictureBox104.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox104.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox104.TabIndex = 125
        Me.PictureBox104.TabStop = False
        '
        'PictureBox103
        '
        Me.PictureBox103.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox103.Location = New System.Drawing.Point(710, 637)
        Me.PictureBox103.Name = "PictureBox103"
        Me.PictureBox103.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox103.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox103.TabIndex = 124
        Me.PictureBox103.TabStop = False
        '
        'PictureBox102
        '
        Me.PictureBox102.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox102.Location = New System.Drawing.Point(685, 637)
        Me.PictureBox102.Name = "PictureBox102"
        Me.PictureBox102.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox102.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox102.TabIndex = 123
        Me.PictureBox102.TabStop = False
        '
        'PictureBox101
        '
        Me.PictureBox101.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox101.Location = New System.Drawing.Point(648, 637)
        Me.PictureBox101.Name = "PictureBox101"
        Me.PictureBox101.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox101.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox101.TabIndex = 122
        Me.PictureBox101.TabStop = False
        '
        'PictureBox100
        '
        Me.PictureBox100.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox100.Location = New System.Drawing.Point(616, 637)
        Me.PictureBox100.Name = "PictureBox100"
        Me.PictureBox100.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox100.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox100.TabIndex = 121
        Me.PictureBox100.TabStop = False
        '
        'PictureBox99
        '
        Me.PictureBox99.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox99.Location = New System.Drawing.Point(685, 603)
        Me.PictureBox99.Name = "PictureBox99"
        Me.PictureBox99.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox99.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox99.TabIndex = 120
        Me.PictureBox99.TabStop = False
        '
        'PictureBox98
        '
        Me.PictureBox98.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox98.Location = New System.Drawing.Point(616, 603)
        Me.PictureBox98.Name = "PictureBox98"
        Me.PictureBox98.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox98.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox98.TabIndex = 119
        Me.PictureBox98.TabStop = False
        '
        'PictureBox97
        '
        Me.PictureBox97.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox97.Location = New System.Drawing.Point(685, 570)
        Me.PictureBox97.Name = "PictureBox97"
        Me.PictureBox97.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox97.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox97.TabIndex = 118
        Me.PictureBox97.TabStop = False
        '
        'PictureBox96
        '
        Me.PictureBox96.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox96.Location = New System.Drawing.Point(710, 570)
        Me.PictureBox96.Name = "PictureBox96"
        Me.PictureBox96.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox96.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox96.TabIndex = 117
        Me.PictureBox96.TabStop = False
        '
        'PictureBox95
        '
        Me.PictureBox95.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox95.Location = New System.Drawing.Point(737, 703)
        Me.PictureBox95.Name = "PictureBox95"
        Me.PictureBox95.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox95.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox95.TabIndex = 116
        Me.PictureBox95.TabStop = False
        '
        'PictureBox94
        '
        Me.PictureBox94.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox94.Location = New System.Drawing.Point(737, 537)
        Me.PictureBox94.Name = "PictureBox94"
        Me.PictureBox94.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox94.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox94.TabIndex = 115
        Me.PictureBox94.TabStop = False
        '
        'PictureBox93
        '
        Me.PictureBox93.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox93.Location = New System.Drawing.Point(737, 503)
        Me.PictureBox93.Name = "PictureBox93"
        Me.PictureBox93.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox93.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox93.TabIndex = 114
        Me.PictureBox93.TabStop = False
        '
        'PictureBox92
        '
        Me.PictureBox92.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox92.Location = New System.Drawing.Point(707, 503)
        Me.PictureBox92.Name = "PictureBox92"
        Me.PictureBox92.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox92.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox92.TabIndex = 113
        Me.PictureBox92.TabStop = False
        '
        'PictureBox91
        '
        Me.PictureBox91.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox91.Location = New System.Drawing.Point(676, 503)
        Me.PictureBox91.Name = "PictureBox91"
        Me.PictureBox91.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox91.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox91.TabIndex = 112
        Me.PictureBox91.TabStop = False
        '
        'PictureBox90
        '
        Me.PictureBox90.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox90.Location = New System.Drawing.Point(648, 503)
        Me.PictureBox90.Name = "PictureBox90"
        Me.PictureBox90.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox90.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox90.TabIndex = 111
        Me.PictureBox90.TabStop = False
        '
        'PictureBox89
        '
        Me.PictureBox89.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox89.Location = New System.Drawing.Point(473, 637)
        Me.PictureBox89.Name = "PictureBox89"
        Me.PictureBox89.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox89.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox89.TabIndex = 110
        Me.PictureBox89.TabStop = False
        '
        'PictureBox88
        '
        Me.PictureBox88.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox88.Location = New System.Drawing.Point(510, 637)
        Me.PictureBox88.Name = "PictureBox88"
        Me.PictureBox88.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox88.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox88.TabIndex = 109
        Me.PictureBox88.TabStop = False
        '
        'PictureBox87
        '
        Me.PictureBox87.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox87.Location = New System.Drawing.Point(546, 637)
        Me.PictureBox87.Name = "PictureBox87"
        Me.PictureBox87.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox87.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox87.TabIndex = 108
        Me.PictureBox87.TabStop = False
        '
        'PictureBox86
        '
        Me.PictureBox86.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox86.Location = New System.Drawing.Point(546, 603)
        Me.PictureBox86.Name = "PictureBox86"
        Me.PictureBox86.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox86.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox86.TabIndex = 107
        Me.PictureBox86.TabStop = False
        '
        'PictureBox85
        '
        Me.PictureBox85.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox85.Location = New System.Drawing.Point(616, 570)
        Me.PictureBox85.Name = "PictureBox85"
        Me.PictureBox85.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox85.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox85.TabIndex = 106
        Me.PictureBox85.TabStop = False
        '
        'PictureBox84
        '
        Me.PictureBox84.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox84.Location = New System.Drawing.Point(582, 570)
        Me.PictureBox84.Name = "PictureBox84"
        Me.PictureBox84.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox84.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox84.TabIndex = 105
        Me.PictureBox84.TabStop = False
        '
        'PictureBox83
        '
        Me.PictureBox83.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox83.Location = New System.Drawing.Point(546, 570)
        Me.PictureBox83.Name = "PictureBox83"
        Me.PictureBox83.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox83.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox83.TabIndex = 104
        Me.PictureBox83.TabStop = False
        '
        'PictureBox82
        '
        Me.PictureBox82.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox82.Location = New System.Drawing.Point(510, 570)
        Me.PictureBox82.Name = "PictureBox82"
        Me.PictureBox82.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox82.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox82.TabIndex = 103
        Me.PictureBox82.TabStop = False
        '
        'PictureBox81
        '
        Me.PictureBox81.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox81.Location = New System.Drawing.Point(473, 570)
        Me.PictureBox81.Name = "PictureBox81"
        Me.PictureBox81.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox81.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox81.TabIndex = 102
        Me.PictureBox81.TabStop = False
        '
        'PictureBox80
        '
        Me.PictureBox80.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox80.Location = New System.Drawing.Point(473, 537)
        Me.PictureBox80.Name = "PictureBox80"
        Me.PictureBox80.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox80.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox80.TabIndex = 101
        Me.PictureBox80.TabStop = False
        '
        'PictureBox79
        '
        Me.PictureBox79.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox79.Location = New System.Drawing.Point(616, 537)
        Me.PictureBox79.Name = "PictureBox79"
        Me.PictureBox79.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox79.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox79.TabIndex = 100
        Me.PictureBox79.TabStop = False
        '
        'PictureBox78
        '
        Me.PictureBox78.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox78.Location = New System.Drawing.Point(473, 503)
        Me.PictureBox78.Name = "PictureBox78"
        Me.PictureBox78.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox78.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox78.TabIndex = 99
        Me.PictureBox78.TabStop = False
        '
        'PictureBox77
        '
        Me.PictureBox77.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox77.Location = New System.Drawing.Point(510, 503)
        Me.PictureBox77.Name = "PictureBox77"
        Me.PictureBox77.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox77.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox77.TabIndex = 98
        Me.PictureBox77.TabStop = False
        '
        'PictureBox76
        '
        Me.PictureBox76.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox76.Location = New System.Drawing.Point(546, 503)
        Me.PictureBox76.Name = "PictureBox76"
        Me.PictureBox76.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox76.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox76.TabIndex = 97
        Me.PictureBox76.TabStop = False
        '
        'PictureBox75
        '
        Me.PictureBox75.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox75.Location = New System.Drawing.Point(582, 503)
        Me.PictureBox75.Name = "PictureBox75"
        Me.PictureBox75.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox75.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox75.TabIndex = 96
        Me.PictureBox75.TabStop = False
        '
        'PictureBox74
        '
        Me.PictureBox74.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox74.Location = New System.Drawing.Point(616, 503)
        Me.PictureBox74.Name = "PictureBox74"
        Me.PictureBox74.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox74.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox74.TabIndex = 95
        Me.PictureBox74.TabStop = False
        '
        'PictureBox73
        '
        Me.PictureBox73.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox73.Location = New System.Drawing.Point(616, 470)
        Me.PictureBox73.Name = "PictureBox73"
        Me.PictureBox73.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox73.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox73.TabIndex = 94
        Me.PictureBox73.TabStop = False
        '
        'PictureBox72
        '
        Me.PictureBox72.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox72.Location = New System.Drawing.Point(616, 439)
        Me.PictureBox72.Name = "PictureBox72"
        Me.PictureBox72.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox72.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox72.TabIndex = 93
        Me.PictureBox72.TabStop = False
        '
        'PictureBox71
        '
        Me.PictureBox71.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox71.Location = New System.Drawing.Point(616, 402)
        Me.PictureBox71.Name = "PictureBox71"
        Me.PictureBox71.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox71.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox71.TabIndex = 92
        Me.PictureBox71.TabStop = False
        '
        'PictureBox70
        '
        Me.PictureBox70.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox70.Location = New System.Drawing.Point(616, 370)
        Me.PictureBox70.Name = "PictureBox70"
        Me.PictureBox70.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox70.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox70.TabIndex = 91
        Me.PictureBox70.TabStop = False
        '
        'PictureBox69
        '
        Me.PictureBox69.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox69.Location = New System.Drawing.Point(616, 336)
        Me.PictureBox69.Name = "PictureBox69"
        Me.PictureBox69.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox69.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox69.TabIndex = 90
        Me.PictureBox69.TabStop = False
        '
        'PictureBox68
        '
        Me.PictureBox68.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox68.Location = New System.Drawing.Point(616, 305)
        Me.PictureBox68.Name = "PictureBox68"
        Me.PictureBox68.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox68.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox68.TabIndex = 89
        Me.PictureBox68.TabStop = False
        '
        'PictureBox67
        '
        Me.PictureBox67.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox67.Location = New System.Drawing.Point(616, 270)
        Me.PictureBox67.Name = "PictureBox67"
        Me.PictureBox67.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox67.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox67.TabIndex = 88
        Me.PictureBox67.TabStop = False
        '
        'PictureBox66
        '
        Me.PictureBox66.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox66.Location = New System.Drawing.Point(707, 83)
        Me.PictureBox66.Name = "PictureBox66"
        Me.PictureBox66.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox66.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox66.TabIndex = 87
        Me.PictureBox66.TabStop = False
        '
        'PictureBox65
        '
        Me.PictureBox65.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox65.Location = New System.Drawing.Point(676, 83)
        Me.PictureBox65.Name = "PictureBox65"
        Me.PictureBox65.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox65.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox65.TabIndex = 86
        Me.PictureBox65.TabStop = False
        '
        'PictureBox64
        '
        Me.PictureBox64.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox64.Location = New System.Drawing.Point(648, 83)
        Me.PictureBox64.Name = "PictureBox64"
        Me.PictureBox64.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox64.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox64.TabIndex = 85
        Me.PictureBox64.TabStop = False
        '
        'PictureBox63
        '
        Me.PictureBox63.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox63.Location = New System.Drawing.Point(616, 83)
        Me.PictureBox63.Name = "PictureBox63"
        Me.PictureBox63.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox63.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox63.TabIndex = 84
        Me.PictureBox63.TabStop = False
        '
        'PictureBox62
        '
        Me.PictureBox62.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox62.Location = New System.Drawing.Point(616, 110)
        Me.PictureBox62.Name = "PictureBox62"
        Me.PictureBox62.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox62.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox62.TabIndex = 83
        Me.PictureBox62.TabStop = False
        '
        'PictureBox61
        '
        Me.PictureBox61.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox61.Location = New System.Drawing.Point(616, 137)
        Me.PictureBox61.Name = "PictureBox61"
        Me.PictureBox61.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox61.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox61.TabIndex = 82
        Me.PictureBox61.TabStop = False
        '
        'PictureBox60
        '
        Me.PictureBox60.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox60.Location = New System.Drawing.Point(737, 110)
        Me.PictureBox60.Name = "PictureBox60"
        Me.PictureBox60.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox60.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox60.TabIndex = 81
        Me.PictureBox60.TabStop = False
        '
        'PictureBox59
        '
        Me.PictureBox59.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox59.Location = New System.Drawing.Point(737, 137)
        Me.PictureBox59.Name = "PictureBox59"
        Me.PictureBox59.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox59.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox59.TabIndex = 80
        Me.PictureBox59.TabStop = False
        '
        'PictureBox58
        '
        Me.PictureBox58.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox58.Location = New System.Drawing.Point(737, 171)
        Me.PictureBox58.Name = "PictureBox58"
        Me.PictureBox58.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox58.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox58.TabIndex = 79
        Me.PictureBox58.TabStop = False
        '
        'PictureBox57
        '
        Me.PictureBox57.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox57.Location = New System.Drawing.Point(707, 171)
        Me.PictureBox57.Name = "PictureBox57"
        Me.PictureBox57.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox57.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox57.TabIndex = 78
        Me.PictureBox57.TabStop = False
        '
        'PictureBox56
        '
        Me.PictureBox56.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox56.Location = New System.Drawing.Point(737, 204)
        Me.PictureBox56.Name = "PictureBox56"
        Me.PictureBox56.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox56.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox56.TabIndex = 77
        Me.PictureBox56.TabStop = False
        '
        'PictureBox55
        '
        Me.PictureBox55.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox55.Location = New System.Drawing.Point(676, 171)
        Me.PictureBox55.Name = "PictureBox55"
        Me.PictureBox55.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox55.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox55.TabIndex = 76
        Me.PictureBox55.TabStop = False
        '
        'PictureBox54
        '
        Me.PictureBox54.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox54.Location = New System.Drawing.Point(648, 171)
        Me.PictureBox54.Name = "PictureBox54"
        Me.PictureBox54.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox54.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox54.TabIndex = 75
        Me.PictureBox54.TabStop = False
        '
        'PictureBox53
        '
        Me.PictureBox53.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox53.Location = New System.Drawing.Point(616, 204)
        Me.PictureBox53.Name = "PictureBox53"
        Me.PictureBox53.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox53.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox53.TabIndex = 74
        Me.PictureBox53.TabStop = False
        '
        'PictureBox52
        '
        Me.PictureBox52.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox52.Location = New System.Drawing.Point(616, 171)
        Me.PictureBox52.Name = "PictureBox52"
        Me.PictureBox52.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox52.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox52.TabIndex = 73
        Me.PictureBox52.TabStop = False
        '
        'PictureBox51
        '
        Me.PictureBox51.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox51.Location = New System.Drawing.Point(648, 235)
        Me.PictureBox51.Name = "PictureBox51"
        Me.PictureBox51.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox51.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox51.TabIndex = 72
        Me.PictureBox51.TabStop = False
        '
        'PictureBox50
        '
        Me.PictureBox50.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox50.Location = New System.Drawing.Point(616, 235)
        Me.PictureBox50.Name = "PictureBox50"
        Me.PictureBox50.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox50.TabIndex = 71
        Me.PictureBox50.TabStop = False
        '
        'PictureBox49
        '
        Me.PictureBox49.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox49.Location = New System.Drawing.Point(676, 235)
        Me.PictureBox49.Name = "PictureBox49"
        Me.PictureBox49.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox49.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox49.TabIndex = 70
        Me.PictureBox49.TabStop = False
        '
        'PictureBox48
        '
        Me.PictureBox48.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox48.Location = New System.Drawing.Point(707, 235)
        Me.PictureBox48.Name = "PictureBox48"
        Me.PictureBox48.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox48.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox48.TabIndex = 69
        Me.PictureBox48.TabStop = False
        '
        'PictureBox47
        '
        Me.PictureBox47.Image = Global.Pacman.My.Resources.Resources.Dot
        Me.PictureBox47.Location = New System.Drawing.Point(737, 235)
        Me.PictureBox47.Name = "PictureBox47"
        Me.PictureBox47.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox47.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox47.TabIndex = 68
        Me.PictureBox47.TabStop = False
        '
        'GhostWall
        '
        Me.GhostWall.BackColor = System.Drawing.Color.Transparent
        Me.GhostWall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GhostWall.Location = New System.Drawing.Point(418, 334)
        Me.GhostWall.Name = "GhostWall"
        Me.GhostWall.Size = New System.Drawing.Size(49, 3)
        Me.GhostWall.TabIndex = 67
        Me.GhostWall.TabStop = False
        Me.GhostWall.Visible = False
        '
        'PictureBox46
        '
        Me.PictureBox46.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox46.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox46.Location = New System.Drawing.Point(363, 331)
        Me.PictureBox46.Name = "PictureBox46"
        Me.PictureBox46.Size = New System.Drawing.Size(49, 3)
        Me.PictureBox46.TabIndex = 66
        Me.PictureBox46.TabStop = False
        Me.PictureBox46.Visible = False
        '
        'PictureBox45
        '
        Me.PictureBox45.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox45.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox45.Location = New System.Drawing.Point(468, 331)
        Me.PictureBox45.Name = "PictureBox45"
        Me.PictureBox45.Size = New System.Drawing.Size(49, 3)
        Me.PictureBox45.TabIndex = 65
        Me.PictureBox45.TabStop = False
        Me.PictureBox45.Visible = False
        '
        'PictureBox44
        '
        Me.PictureBox44.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox44.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox44.Location = New System.Drawing.Point(363, 416)
        Me.PictureBox44.Name = "PictureBox44"
        Me.PictureBox44.Size = New System.Drawing.Size(149, 2)
        Me.PictureBox44.TabIndex = 64
        Me.PictureBox44.TabStop = False
        Me.PictureBox44.Visible = False
        '
        'PictureBox43
        '
        Me.PictureBox43.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox43.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox43.Location = New System.Drawing.Point(355, 334)
        Me.PictureBox43.Name = "PictureBox43"
        Me.PictureBox43.Size = New System.Drawing.Size(3, 84)
        Me.PictureBox43.TabIndex = 63
        Me.PictureBox43.TabStop = False
        Me.PictureBox43.Visible = False
        '
        'PictureBox42
        '
        Me.PictureBox42.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox42.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox42.Location = New System.Drawing.Point(520, 334)
        Me.PictureBox42.Name = "PictureBox42"
        Me.PictureBox42.Size = New System.Drawing.Size(3, 84)
        Me.PictureBox42.TabIndex = 62
        Me.PictureBox42.TabStop = False
        Me.PictureBox42.Visible = False
        '
        'PictureBox41
        '
        Me.PictureBox41.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox41.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox41.Location = New System.Drawing.Point(721, 603)
        Me.PictureBox41.Name = "PictureBox41"
        Me.PictureBox41.Size = New System.Drawing.Size(60, 15)
        Me.PictureBox41.TabIndex = 61
        Me.PictureBox41.TabStop = False
        Me.PictureBox41.Visible = False
        '
        'PictureBox40
        '
        Me.PictureBox40.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox40.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox40.Location = New System.Drawing.Point(100, 608)
        Me.PictureBox40.Name = "PictureBox40"
        Me.PictureBox40.Size = New System.Drawing.Size(49, 10)
        Me.PictureBox40.TabIndex = 60
        Me.PictureBox40.TabStop = False
        Me.PictureBox40.Visible = False
        '
        'PictureBox39
        '
        Me.PictureBox39.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox39.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox39.Location = New System.Drawing.Point(89, 484)
        Me.PictureBox39.Name = "PictureBox39"
        Me.PictureBox39.Size = New System.Drawing.Size(10, 258)
        Me.PictureBox39.TabIndex = 59
        Me.PictureBox39.TabStop = False
        Me.PictureBox39.Visible = False
        '
        'PictureBox38
        '
        Me.PictureBox38.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox38.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox38.Location = New System.Drawing.Point(771, 484)
        Me.PictureBox38.Name = "PictureBox38"
        Me.PictureBox38.Size = New System.Drawing.Size(10, 258)
        Me.PictureBox38.TabIndex = 58
        Me.PictureBox38.TabStop = False
        Me.PictureBox38.Visible = False
        '
        'PictureBox37
        '
        Me.PictureBox37.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox37.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox37.Location = New System.Drawing.Point(105, 737)
        Me.PictureBox37.Name = "PictureBox37"
        Me.PictureBox37.Size = New System.Drawing.Size(667, 5)
        Me.PictureBox37.TabIndex = 57
        Me.PictureBox37.TabStop = False
        Me.PictureBox37.Visible = False
        '
        'PictureBox36
        '
        Me.PictureBox36.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox36.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox36.Location = New System.Drawing.Point(167, 537)
        Me.PictureBox36.Name = "PictureBox36"
        Me.PictureBox36.Size = New System.Drawing.Size(61, 15)
        Me.PictureBox36.TabIndex = 56
        Me.PictureBox36.TabStop = False
        Me.PictureBox36.Visible = False
        '
        'PictureBox35
        '
        Me.PictureBox35.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox35.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox35.Location = New System.Drawing.Point(650, 537)
        Me.PictureBox35.Name = "PictureBox35"
        Me.PictureBox35.Size = New System.Drawing.Size(61, 15)
        Me.PictureBox35.TabIndex = 55
        Me.PictureBox35.TabStop = False
        Me.PictureBox35.Visible = False
        '
        'PictureBox34
        '
        Me.PictureBox34.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox34.Location = New System.Drawing.Point(650, 537)
        Me.PictureBox34.Name = "PictureBox34"
        Me.PictureBox34.Size = New System.Drawing.Size(16, 81)
        Me.PictureBox34.TabIndex = 54
        Me.PictureBox34.TabStop = False
        Me.PictureBox34.Visible = False
        '
        'PictureBox33
        '
        Me.PictureBox33.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox33.Location = New System.Drawing.Point(218, 537)
        Me.PictureBox33.Name = "PictureBox33"
        Me.PictureBox33.Size = New System.Drawing.Size(10, 81)
        Me.PictureBox33.TabIndex = 53
        Me.PictureBox33.TabStop = False
        Me.PictureBox33.Visible = False
        '
        'PictureBox32
        '
        Me.PictureBox32.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox32.Location = New System.Drawing.Point(285, 603)
        Me.PictureBox32.Name = "PictureBox32"
        Me.PictureBox32.Size = New System.Drawing.Size(16, 65)
        Me.PictureBox32.TabIndex = 52
        Me.PictureBox32.TabStop = False
        Me.PictureBox32.Visible = False
        '
        'PictureBox31
        '
        Me.PictureBox31.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox31.Location = New System.Drawing.Point(576, 603)
        Me.PictureBox31.Name = "PictureBox31"
        Me.PictureBox31.Size = New System.Drawing.Size(16, 65)
        Me.PictureBox31.TabIndex = 51
        Me.PictureBox31.TabStop = False
        Me.PictureBox31.Visible = False
        '
        'PictureBox30
        '
        Me.PictureBox30.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox30.Location = New System.Drawing.Point(508, 674)
        Me.PictureBox30.Name = "PictureBox30"
        Me.PictureBox30.Size = New System.Drawing.Size(207, 10)
        Me.PictureBox30.TabIndex = 50
        Me.PictureBox30.TabStop = False
        Me.PictureBox30.Visible = False
        '
        'PictureBox29
        '
        Me.PictureBox29.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox29.Location = New System.Drawing.Point(163, 676)
        Me.PictureBox29.Name = "PictureBox29"
        Me.PictureBox29.Size = New System.Drawing.Size(210, 2)
        Me.PictureBox29.TabIndex = 49
        Me.PictureBox29.TabStop = False
        Me.PictureBox29.Visible = False
        '
        'PictureBox28
        '
        Me.PictureBox28.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox28.Location = New System.Drawing.Point(504, 532)
        Me.PictureBox28.Name = "PictureBox28"
        Me.PictureBox28.Size = New System.Drawing.Size(88, 15)
        Me.PictureBox28.TabIndex = 48
        Me.PictureBox28.TabStop = False
        Me.PictureBox28.Visible = False
        '
        'PictureBox27
        '
        Me.PictureBox27.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox27.Location = New System.Drawing.Point(284, 532)
        Me.PictureBox27.Name = "PictureBox27"
        Me.PictureBox27.Size = New System.Drawing.Size(91, 15)
        Me.PictureBox27.TabIndex = 47
        Me.PictureBox27.TabStop = False
        Me.PictureBox27.Visible = False
        '
        'PictureBox26
        '
        Me.PictureBox26.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox26.Location = New System.Drawing.Point(431, 484)
        Me.PictureBox26.Name = "PictureBox26"
        Me.PictureBox26.Size = New System.Drawing.Size(16, 63)
        Me.PictureBox26.TabIndex = 46
        Me.PictureBox26.TabStop = False
        Me.PictureBox26.Visible = False
        '
        'PictureBox25
        '
        Me.PictureBox25.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox25.Location = New System.Drawing.Point(431, 603)
        Me.PictureBox25.Name = "PictureBox25"
        Me.PictureBox25.Size = New System.Drawing.Size(16, 65)
        Me.PictureBox25.TabIndex = 45
        Me.PictureBox25.TabStop = False
        Me.PictureBox25.Visible = False
        '
        'PictureBox24
        '
        Me.PictureBox24.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox24.Location = New System.Drawing.Point(356, 603)
        Me.PictureBox24.Name = "PictureBox24"
        Me.PictureBox24.Size = New System.Drawing.Size(164, 15)
        Me.PictureBox24.TabIndex = 44
        Me.PictureBox24.TabStop = False
        Me.PictureBox24.Visible = False
        '
        'PictureBox23
        '
        Me.PictureBox23.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox23.Location = New System.Drawing.Point(356, 470)
        Me.PictureBox23.Name = "PictureBox23"
        Me.PictureBox23.Size = New System.Drawing.Size(164, 10)
        Me.PictureBox23.TabIndex = 43
        Me.PictureBox23.TabStop = False
        Me.PictureBox23.Visible = False
        '
        'PictureBox22
        '
        Me.PictureBox22.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox22.Location = New System.Drawing.Point(576, 402)
        Me.PictureBox22.Name = "PictureBox22"
        Me.PictureBox22.Size = New System.Drawing.Size(16, 76)
        Me.PictureBox22.TabIndex = 42
        Me.PictureBox22.TabStop = False
        Me.PictureBox22.Visible = False
        '
        'PictureBox21
        '
        Me.PictureBox21.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox21.Location = New System.Drawing.Point(284, 402)
        Me.PictureBox21.Name = "PictureBox21"
        Me.PictureBox21.Size = New System.Drawing.Size(16, 76)
        Me.PictureBox21.TabIndex = 41
        Me.PictureBox21.TabStop = False
        Me.PictureBox21.Visible = False
        '
        'PictureBox20
        '
        Me.PictureBox20.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox20.Location = New System.Drawing.Point(650, 402)
        Me.PictureBox20.Name = "PictureBox20"
        Me.PictureBox20.Size = New System.Drawing.Size(122, 76)
        Me.PictureBox20.TabIndex = 40
        Me.PictureBox20.TabStop = False
        Me.PictureBox20.Visible = False
        '
        'PictureBox19
        '
        Me.PictureBox19.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox19.Location = New System.Drawing.Point(105, 402)
        Me.PictureBox19.Name = "PictureBox19"
        Me.PictureBox19.Size = New System.Drawing.Size(122, 76)
        Me.PictureBox19.TabIndex = 39
        Me.PictureBox19.TabStop = False
        Me.PictureBox19.Visible = False
        '
        'PictureBox18
        '
        Me.PictureBox18.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox18.Location = New System.Drawing.Point(284, 267)
        Me.PictureBox18.Name = "PictureBox18"
        Me.PictureBox18.Size = New System.Drawing.Size(91, 10)
        Me.PictureBox18.TabIndex = 38
        Me.PictureBox18.TabStop = False
        Me.PictureBox18.Visible = False
        '
        'PictureBox17
        '
        Me.PictureBox17.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox17.Location = New System.Drawing.Point(504, 267)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(91, 10)
        Me.PictureBox17.TabIndex = 37
        Me.PictureBox17.TabStop = False
        Me.PictureBox17.Visible = False
        '
        'PictureBox16
        '
        Me.PictureBox16.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox16.Location = New System.Drawing.Point(576, 199)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(16, 147)
        Me.PictureBox16.TabIndex = 36
        Me.PictureBox16.TabStop = False
        Me.PictureBox16.Visible = False
        '
        'PictureBox15
        '
        Me.PictureBox15.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox15.Location = New System.Drawing.Point(285, 199)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(16, 147)
        Me.PictureBox15.TabIndex = 35
        Me.PictureBox15.TabStop = False
        Me.PictureBox15.Visible = False
        '
        'PictureBox14
        '
        Me.PictureBox14.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox14.Location = New System.Drawing.Point(431, 199)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(16, 78)
        Me.PictureBox14.TabIndex = 34
        Me.PictureBox14.TabStop = False
        Me.PictureBox14.Visible = False
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox13.Location = New System.Drawing.Point(431, 51)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(16, 96)
        Me.PictureBox13.TabIndex = 33
        Me.PictureBox13.TabStop = False
        Me.PictureBox13.Visible = False
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox12.Location = New System.Drawing.Point(356, 199)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(164, 15)
        Me.PictureBox12.TabIndex = 32
        Me.PictureBox12.TabStop = False
        Me.PictureBox12.Visible = False
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox11.Location = New System.Drawing.Point(650, 199)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(65, 15)
        Me.PictureBox11.TabIndex = 31
        Me.PictureBox11.TabStop = False
        Me.PictureBox11.Visible = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox10.Location = New System.Drawing.Point(167, 199)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(56, 15)
        Me.PictureBox10.TabIndex = 30
        Me.PictureBox10.TabStop = False
        Me.PictureBox10.Visible = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox9.Location = New System.Drawing.Point(285, 110)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(88, 37)
        Me.PictureBox9.TabIndex = 29
        Me.PictureBox9.TabStop = False
        Me.PictureBox9.Visible = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox8.Location = New System.Drawing.Point(504, 110)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(88, 37)
        Me.PictureBox8.TabIndex = 28
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Visible = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox7.Location = New System.Drawing.Point(650, 110)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(65, 37)
        Me.PictureBox7.TabIndex = 27
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Visible = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox6.Location = New System.Drawing.Point(167, 110)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(61, 37)
        Me.PictureBox6.TabIndex = 26
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox5.Location = New System.Drawing.Point(650, 270)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(122, 76)
        Me.PictureBox5.TabIndex = 25
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox4.Location = New System.Drawing.Point(106, 270)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(122, 76)
        Me.PictureBox4.TabIndex = 24
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox3.Location = New System.Drawing.Point(90, 54)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(10, 223)
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Location = New System.Drawing.Point(105, 43)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(667, 10)
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(771, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(10, 223)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Portal_Right_Exit
        '
        Me.Portal_Right_Exit.Location = New System.Drawing.Point(728, 352)
        Me.Portal_Right_Exit.Name = "Portal_Right_Exit"
        Me.Portal_Right_Exit.Size = New System.Drawing.Size(44, 44)
        Me.Portal_Right_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Portal_Right_Exit.TabIndex = 20
        Me.Portal_Right_Exit.TabStop = False
        Me.Portal_Right_Exit.Visible = False
        '
        'Portal_Left_Exit
        '
        Me.Portal_Left_Exit.Location = New System.Drawing.Point(105, 352)
        Me.Portal_Left_Exit.Name = "Portal_Left_Exit"
        Me.Portal_Left_Exit.Size = New System.Drawing.Size(44, 44)
        Me.Portal_Left_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Portal_Left_Exit.TabIndex = 19
        Me.Portal_Left_Exit.TabStop = False
        Me.Portal_Left_Exit.Visible = False
        '
        'Portal_Left
        '
        Me.Portal_Left.Location = New System.Drawing.Point(-1, 334)
        Me.Portal_Left.Name = "Portal_Left"
        Me.Portal_Left.Size = New System.Drawing.Size(100, 84)
        Me.Portal_Left.TabIndex = 18
        Me.Portal_Left.TabStop = False
        '
        'Portal_Right
        '
        Me.Portal_Right.Location = New System.Drawing.Point(778, 334)
        Me.Portal_Right.Name = "Portal_Right"
        Me.Portal_Right.Size = New System.Drawing.Size(100, 84)
        Me.Portal_Right.TabIndex = 17
        Me.Portal_Right.TabStop = False
        '
        'picLife_3
        '
        Me.picLife_3.Image = Global.Pacman.My.Resources.Resources.Pacman_Open_Left
        Me.picLife_3.Location = New System.Drawing.Point(172, 748)
        Me.picLife_3.Name = "picLife_3"
        Me.picLife_3.Size = New System.Drawing.Size(45, 45)
        Me.picLife_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLife_3.TabIndex = 14
        Me.picLife_3.TabStop = False
        '
        'picLife_4
        '
        Me.picLife_4.Image = Global.Pacman.My.Resources.Resources.Pacman_Open_Left
        Me.picLife_4.Location = New System.Drawing.Point(223, 748)
        Me.picLife_4.Name = "picLife_4"
        Me.picLife_4.Size = New System.Drawing.Size(45, 45)
        Me.picLife_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLife_4.TabIndex = 13
        Me.picLife_4.TabStop = False
        '
        'picLife_5
        '
        Me.picLife_5.Image = Global.Pacman.My.Resources.Resources.Pacman_Open_Left
        Me.picLife_5.Location = New System.Drawing.Point(274, 748)
        Me.picLife_5.Name = "picLife_5"
        Me.picLife_5.Size = New System.Drawing.Size(45, 45)
        Me.picLife_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLife_5.TabIndex = 12
        Me.picLife_5.TabStop = False
        '
        'picLife_6
        '
        Me.picLife_6.Image = Global.Pacman.My.Resources.Resources.Pacman_Open_Left
        Me.picLife_6.Location = New System.Drawing.Point(325, 748)
        Me.picLife_6.Name = "picLife_6"
        Me.picLife_6.Size = New System.Drawing.Size(45, 45)
        Me.picLife_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLife_6.TabIndex = 11
        Me.picLife_6.TabStop = False
        '
        'picLife_2
        '
        Me.picLife_2.Image = Global.Pacman.My.Resources.Resources.Pacman_Open_Left
        Me.picLife_2.Location = New System.Drawing.Point(121, 748)
        Me.picLife_2.Name = "picLife_2"
        Me.picLife_2.Size = New System.Drawing.Size(45, 45)
        Me.picLife_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLife_2.TabIndex = 10
        Me.picLife_2.TabStop = False
        '
        'picGameboard_Blue
        '
        Me.picGameboard_Blue.Image = Global.Pacman.My.Resources.Resources.Gameboard
        Me.picGameboard_Blue.Location = New System.Drawing.Point(12, -4)
        Me.picGameboard_Blue.Name = "picGameboard_Blue"
        Me.picGameboard_Blue.Size = New System.Drawing.Size(836, 800)
        Me.picGameboard_Blue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGameboard_Blue.TabIndex = 0
        Me.picGameboard_Blue.TabStop = False
        '
        'PictureBox225
        '
        Me.PictureBox225.Location = New System.Drawing.Point(717, 70)
        Me.PictureBox225.Name = "PictureBox225"
        Me.PictureBox225.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox225.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox225.TabIndex = 246
        Me.PictureBox225.TabStop = False
        Me.PictureBox225.Visible = False
        '
        'PictureBox263
        '
        Me.PictureBox263.Location = New System.Drawing.Point(721, 687)
        Me.PictureBox263.Name = "PictureBox263"
        Me.PictureBox263.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox263.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox263.TabIndex = 284
        Me.PictureBox263.TabStop = False
        Me.PictureBox263.Visible = False
        '
        'PictureBox273
        '
        Me.PictureBox273.Location = New System.Drawing.Point(117, 553)
        Me.PictureBox273.Name = "PictureBox273"
        Me.PictureBox273.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox273.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox273.TabIndex = 294
        Me.PictureBox273.TabStop = False
        Me.PictureBox273.Visible = False
        '
        'PictureBox270
        '
        Me.PictureBox270.Location = New System.Drawing.Point(117, 687)
        Me.PictureBox270.Name = "PictureBox270"
        Me.PictureBox270.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox270.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox270.TabIndex = 291
        Me.PictureBox270.TabStop = False
        Me.PictureBox270.Visible = False
        '
        'PictureBox265
        '
        Me.PictureBox265.Location = New System.Drawing.Point(717, 558)
        Me.PictureBox265.Name = "PictureBox265"
        Me.PictureBox265.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox265.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox265.TabIndex = 286
        Me.PictureBox265.TabStop = False
        Me.PictureBox265.Visible = False
        '
        'PictureBox219
        '
        Me.PictureBox219.Location = New System.Drawing.Point(673, 558)
        Me.PictureBox219.Name = "PictureBox219"
        Me.PictureBox219.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox219.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox219.TabIndex = 240
        Me.PictureBox219.TabStop = False
        Me.PictureBox219.Visible = False
        '
        'PictureBox214
        '
        Me.PictureBox214.Location = New System.Drawing.Point(117, 70)
        Me.PictureBox214.Name = "PictureBox214"
        Me.PictureBox214.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox214.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox214.TabIndex = 235
        Me.PictureBox214.TabStop = False
        Me.PictureBox214.Visible = False
        '
        'picBlue_Home
        '
        Me.picBlue_Home.Location = New System.Drawing.Point(368, 352)
        Me.picBlue_Home.Name = "picBlue_Home"
        Me.picBlue_Home.Size = New System.Drawing.Size(44, 44)
        Me.picBlue_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBlue_Home.TabIndex = 299
        Me.picBlue_Home.TabStop = False
        Me.picBlue_Home.Visible = False
        '
        'picPink_Home
        '
        Me.picPink_Home.Location = New System.Drawing.Point(418, 352)
        Me.picPink_Home.Name = "picPink_Home"
        Me.picPink_Home.Size = New System.Drawing.Size(44, 44)
        Me.picPink_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPink_Home.TabIndex = 300
        Me.picPink_Home.TabStop = False
        Me.picPink_Home.Visible = False
        '
        'picOrange_Home
        '
        Me.picOrange_Home.Location = New System.Drawing.Point(468, 352)
        Me.picOrange_Home.Name = "picOrange_Home"
        Me.picOrange_Home.Size = New System.Drawing.Size(44, 44)
        Me.picOrange_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOrange_Home.TabIndex = 301
        Me.picOrange_Home.TabStop = False
        Me.picOrange_Home.Visible = False
        '
        'picGhost_Exit
        '
        Me.picGhost_Exit.Location = New System.Drawing.Point(418, 284)
        Me.picGhost_Exit.Name = "picGhost_Exit"
        Me.picGhost_Exit.Size = New System.Drawing.Size(44, 44)
        Me.picGhost_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGhost_Exit.TabIndex = 298
        Me.picGhost_Exit.TabStop = False
        Me.picGhost_Exit.Visible = False
        '
        'picPacman_Home
        '
        Me.picPacman_Home.Location = New System.Drawing.Point(418, 553)
        Me.picPacman_Home.Name = "picPacman_Home"
        Me.picPacman_Home.Size = New System.Drawing.Size(44, 44)
        Me.picPacman_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPacman_Home.TabIndex = 302
        Me.picPacman_Home.TabStop = False
        Me.picPacman_Home.Visible = False
        '
        'Gameboard
        '
        Me.AcceptButton = Me.btnExit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(879, 795)
        Me.Controls.Add(Me.lblReady)
        Me.Controls.Add(Me.picPacman)
        Me.Controls.Add(Me.picRed)
        Me.Controls.Add(Me.picPink)
        Me.Controls.Add(Me.picBlue)
        Me.Controls.Add(Me.picOrange)
        Me.Controls.Add(Me.lblFruit_Score)
        Me.Controls.Add(Me.picFruit)
        Me.Controls.Add(Me.picFruit_1)
        Me.Controls.Add(Me.picFruit_2)
        Me.Controls.Add(Me.picFruit_3)
        Me.Controls.Add(Me.picFruit_4)
        Me.Controls.Add(Me.picFruit_5)
        Me.Controls.Add(Me.picFruit_6)
        Me.Controls.Add(Me.picFruit_7)
        Me.Controls.Add(Me.lblBonus)
        Me.Controls.Add(Me.picPowerup_2)
        Me.Controls.Add(Me.picPowerup_1)
        Me.Controls.Add(Me.picPowerup_3)
        Me.Controls.Add(Me.picPowerup_4)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblGameOver)
        Me.Controls.Add(Me.PictureBox276)
        Me.Controls.Add(Me.PictureBox275)
        Me.Controls.Add(Me.PictureBox274)
        Me.Controls.Add(Me.PictureBox272)
        Me.Controls.Add(Me.PictureBox271)
        Me.Controls.Add(Me.PictureBox269)
        Me.Controls.Add(Me.PictureBox268)
        Me.Controls.Add(Me.PictureBox267)
        Me.Controls.Add(Me.PictureBox266)
        Me.Controls.Add(Me.PictureBox264)
        Me.Controls.Add(Me.PictureBox262)
        Me.Controls.Add(Me.PictureBox261)
        Me.Controls.Add(Me.PictureBox260)
        Me.Controls.Add(Me.PictureBox259)
        Me.Controls.Add(Me.PictureBox258)
        Me.Controls.Add(Me.PictureBox257)
        Me.Controls.Add(Me.PictureBox256)
        Me.Controls.Add(Me.PictureBox255)
        Me.Controls.Add(Me.PictureBox254)
        Me.Controls.Add(Me.PictureBox253)
        Me.Controls.Add(Me.PictureBox252)
        Me.Controls.Add(Me.PictureBox251)
        Me.Controls.Add(Me.PictureBox250)
        Me.Controls.Add(Me.PictureBox249)
        Me.Controls.Add(Me.PictureBox248)
        Me.Controls.Add(Me.PictureBox247)
        Me.Controls.Add(Me.PictureBox246)
        Me.Controls.Add(Me.PictureBox245)
        Me.Controls.Add(Me.PictureBox244)
        Me.Controls.Add(Me.PictureBox243)
        Me.Controls.Add(Me.PictureBox242)
        Me.Controls.Add(Me.PictureBox241)
        Me.Controls.Add(Me.PictureBox240)
        Me.Controls.Add(Me.PictureBox239)
        Me.Controls.Add(Me.PictureBox238)
        Me.Controls.Add(Me.PictureBox237)
        Me.Controls.Add(Me.PictureBox236)
        Me.Controls.Add(Me.PictureBox235)
        Me.Controls.Add(Me.PictureBox234)
        Me.Controls.Add(Me.PictureBox233)
        Me.Controls.Add(Me.PictureBox232)
        Me.Controls.Add(Me.PictureBox231)
        Me.Controls.Add(Me.PictureBox230)
        Me.Controls.Add(Me.PictureBox229)
        Me.Controls.Add(Me.PictureBox228)
        Me.Controls.Add(Me.PictureBox227)
        Me.Controls.Add(Me.PictureBox226)
        Me.Controls.Add(Me.PictureBox224)
        Me.Controls.Add(Me.PictureBox223)
        Me.Controls.Add(Me.PictureBox222)
        Me.Controls.Add(Me.PictureBox221)
        Me.Controls.Add(Me.PictureBox220)
        Me.Controls.Add(Me.PictureBox218)
        Me.Controls.Add(Me.PictureBox217)
        Me.Controls.Add(Me.PictureBox216)
        Me.Controls.Add(Me.PictureBox215)
        Me.Controls.Add(Me.PictureBox213)
        Me.Controls.Add(Me.PictureBox212)
        Me.Controls.Add(Me.PictureBox211)
        Me.Controls.Add(Me.PictureBox210)
        Me.Controls.Add(Me.PictureBox209)
        Me.Controls.Add(Me.PictureBox208)
        Me.Controls.Add(Me.PictureBox207)
        Me.Controls.Add(Me.PictureBox206)
        Me.Controls.Add(Me.PictureBox205)
        Me.Controls.Add(Me.PictureBox204)
        Me.Controls.Add(Me.PictureBox203)
        Me.Controls.Add(Me.PictureBox202)
        Me.Controls.Add(Me.PictureBox201)
        Me.Controls.Add(Me.PictureBox200)
        Me.Controls.Add(Me.PictureBox199)
        Me.Controls.Add(Me.PictureBox198)
        Me.Controls.Add(Me.PictureBox197)
        Me.Controls.Add(Me.PictureBox196)
        Me.Controls.Add(Me.PictureBox195)
        Me.Controls.Add(Me.PictureBox194)
        Me.Controls.Add(Me.PictureBox193)
        Me.Controls.Add(Me.PictureBox192)
        Me.Controls.Add(Me.PictureBox191)
        Me.Controls.Add(Me.PictureBox190)
        Me.Controls.Add(Me.PictureBox189)
        Me.Controls.Add(Me.PictureBox188)
        Me.Controls.Add(Me.PictureBox187)
        Me.Controls.Add(Me.PictureBox186)
        Me.Controls.Add(Me.PictureBox185)
        Me.Controls.Add(Me.PictureBox184)
        Me.Controls.Add(Me.PictureBox183)
        Me.Controls.Add(Me.PictureBox182)
        Me.Controls.Add(Me.PictureBox181)
        Me.Controls.Add(Me.PictureBox180)
        Me.Controls.Add(Me.PictureBox179)
        Me.Controls.Add(Me.PictureBox178)
        Me.Controls.Add(Me.PictureBox177)
        Me.Controls.Add(Me.PictureBox176)
        Me.Controls.Add(Me.PictureBox175)
        Me.Controls.Add(Me.PictureBox174)
        Me.Controls.Add(Me.PictureBox173)
        Me.Controls.Add(Me.PictureBox172)
        Me.Controls.Add(Me.PictureBox171)
        Me.Controls.Add(Me.PictureBox170)
        Me.Controls.Add(Me.PictureBox169)
        Me.Controls.Add(Me.PictureBox168)
        Me.Controls.Add(Me.PictureBox167)
        Me.Controls.Add(Me.PictureBox166)
        Me.Controls.Add(Me.PictureBox165)
        Me.Controls.Add(Me.PictureBox164)
        Me.Controls.Add(Me.PictureBox163)
        Me.Controls.Add(Me.PictureBox162)
        Me.Controls.Add(Me.PictureBox161)
        Me.Controls.Add(Me.PictureBox160)
        Me.Controls.Add(Me.PictureBox159)
        Me.Controls.Add(Me.PictureBox158)
        Me.Controls.Add(Me.PictureBox157)
        Me.Controls.Add(Me.PictureBox156)
        Me.Controls.Add(Me.PictureBox155)
        Me.Controls.Add(Me.PictureBox154)
        Me.Controls.Add(Me.PictureBox153)
        Me.Controls.Add(Me.PictureBox152)
        Me.Controls.Add(Me.PictureBox151)
        Me.Controls.Add(Me.PictureBox150)
        Me.Controls.Add(Me.PictureBox149)
        Me.Controls.Add(Me.PictureBox148)
        Me.Controls.Add(Me.PictureBox147)
        Me.Controls.Add(Me.PictureBox146)
        Me.Controls.Add(Me.PictureBox145)
        Me.Controls.Add(Me.PictureBox144)
        Me.Controls.Add(Me.PictureBox143)
        Me.Controls.Add(Me.PictureBox142)
        Me.Controls.Add(Me.PictureBox141)
        Me.Controls.Add(Me.PictureBox140)
        Me.Controls.Add(Me.PictureBox139)
        Me.Controls.Add(Me.PictureBox138)
        Me.Controls.Add(Me.PictureBox137)
        Me.Controls.Add(Me.PictureBox136)
        Me.Controls.Add(Me.PictureBox135)
        Me.Controls.Add(Me.PictureBox134)
        Me.Controls.Add(Me.PictureBox133)
        Me.Controls.Add(Me.PictureBox132)
        Me.Controls.Add(Me.PictureBox131)
        Me.Controls.Add(Me.PictureBox130)
        Me.Controls.Add(Me.PictureBox129)
        Me.Controls.Add(Me.PictureBox128)
        Me.Controls.Add(Me.PictureBox127)
        Me.Controls.Add(Me.PictureBox126)
        Me.Controls.Add(Me.PictureBox125)
        Me.Controls.Add(Me.PictureBox124)
        Me.Controls.Add(Me.PictureBox123)
        Me.Controls.Add(Me.PictureBox122)
        Me.Controls.Add(Me.PictureBox121)
        Me.Controls.Add(Me.PictureBox120)
        Me.Controls.Add(Me.PictureBox119)
        Me.Controls.Add(Me.PictureBox118)
        Me.Controls.Add(Me.PictureBox117)
        Me.Controls.Add(Me.PictureBox116)
        Me.Controls.Add(Me.PictureBox115)
        Me.Controls.Add(Me.PictureBox114)
        Me.Controls.Add(Me.PictureBox113)
        Me.Controls.Add(Me.PictureBox112)
        Me.Controls.Add(Me.PictureBox111)
        Me.Controls.Add(Me.PictureBox110)
        Me.Controls.Add(Me.PictureBox109)
        Me.Controls.Add(Me.PictureBox108)
        Me.Controls.Add(Me.PictureBox107)
        Me.Controls.Add(Me.PictureBox106)
        Me.Controls.Add(Me.PictureBox105)
        Me.Controls.Add(Me.PictureBox104)
        Me.Controls.Add(Me.PictureBox103)
        Me.Controls.Add(Me.PictureBox102)
        Me.Controls.Add(Me.PictureBox101)
        Me.Controls.Add(Me.PictureBox100)
        Me.Controls.Add(Me.PictureBox99)
        Me.Controls.Add(Me.PictureBox98)
        Me.Controls.Add(Me.PictureBox97)
        Me.Controls.Add(Me.PictureBox96)
        Me.Controls.Add(Me.PictureBox95)
        Me.Controls.Add(Me.PictureBox94)
        Me.Controls.Add(Me.PictureBox93)
        Me.Controls.Add(Me.PictureBox92)
        Me.Controls.Add(Me.PictureBox91)
        Me.Controls.Add(Me.PictureBox90)
        Me.Controls.Add(Me.PictureBox89)
        Me.Controls.Add(Me.PictureBox88)
        Me.Controls.Add(Me.PictureBox87)
        Me.Controls.Add(Me.PictureBox86)
        Me.Controls.Add(Me.PictureBox85)
        Me.Controls.Add(Me.PictureBox84)
        Me.Controls.Add(Me.PictureBox83)
        Me.Controls.Add(Me.PictureBox82)
        Me.Controls.Add(Me.PictureBox81)
        Me.Controls.Add(Me.PictureBox80)
        Me.Controls.Add(Me.PictureBox79)
        Me.Controls.Add(Me.PictureBox78)
        Me.Controls.Add(Me.PictureBox77)
        Me.Controls.Add(Me.PictureBox76)
        Me.Controls.Add(Me.PictureBox75)
        Me.Controls.Add(Me.PictureBox74)
        Me.Controls.Add(Me.PictureBox73)
        Me.Controls.Add(Me.PictureBox72)
        Me.Controls.Add(Me.PictureBox71)
        Me.Controls.Add(Me.PictureBox70)
        Me.Controls.Add(Me.PictureBox69)
        Me.Controls.Add(Me.PictureBox68)
        Me.Controls.Add(Me.PictureBox67)
        Me.Controls.Add(Me.PictureBox66)
        Me.Controls.Add(Me.PictureBox65)
        Me.Controls.Add(Me.PictureBox64)
        Me.Controls.Add(Me.PictureBox63)
        Me.Controls.Add(Me.PictureBox62)
        Me.Controls.Add(Me.PictureBox61)
        Me.Controls.Add(Me.PictureBox60)
        Me.Controls.Add(Me.PictureBox59)
        Me.Controls.Add(Me.PictureBox58)
        Me.Controls.Add(Me.PictureBox57)
        Me.Controls.Add(Me.PictureBox56)
        Me.Controls.Add(Me.PictureBox55)
        Me.Controls.Add(Me.PictureBox54)
        Me.Controls.Add(Me.PictureBox53)
        Me.Controls.Add(Me.PictureBox52)
        Me.Controls.Add(Me.PictureBox51)
        Me.Controls.Add(Me.PictureBox50)
        Me.Controls.Add(Me.PictureBox49)
        Me.Controls.Add(Me.PictureBox48)
        Me.Controls.Add(Me.PictureBox47)
        Me.Controls.Add(Me.GhostWall)
        Me.Controls.Add(Me.PictureBox46)
        Me.Controls.Add(Me.PictureBox45)
        Me.Controls.Add(Me.PictureBox44)
        Me.Controls.Add(Me.PictureBox43)
        Me.Controls.Add(Me.PictureBox42)
        Me.Controls.Add(Me.PictureBox41)
        Me.Controls.Add(Me.PictureBox40)
        Me.Controls.Add(Me.PictureBox39)
        Me.Controls.Add(Me.PictureBox38)
        Me.Controls.Add(Me.PictureBox37)
        Me.Controls.Add(Me.PictureBox36)
        Me.Controls.Add(Me.PictureBox35)
        Me.Controls.Add(Me.PictureBox34)
        Me.Controls.Add(Me.PictureBox33)
        Me.Controls.Add(Me.PictureBox32)
        Me.Controls.Add(Me.PictureBox31)
        Me.Controls.Add(Me.PictureBox30)
        Me.Controls.Add(Me.PictureBox29)
        Me.Controls.Add(Me.PictureBox28)
        Me.Controls.Add(Me.PictureBox27)
        Me.Controls.Add(Me.PictureBox26)
        Me.Controls.Add(Me.PictureBox25)
        Me.Controls.Add(Me.PictureBox24)
        Me.Controls.Add(Me.PictureBox23)
        Me.Controls.Add(Me.PictureBox22)
        Me.Controls.Add(Me.PictureBox21)
        Me.Controls.Add(Me.PictureBox20)
        Me.Controls.Add(Me.PictureBox19)
        Me.Controls.Add(Me.PictureBox18)
        Me.Controls.Add(Me.PictureBox17)
        Me.Controls.Add(Me.PictureBox16)
        Me.Controls.Add(Me.PictureBox15)
        Me.Controls.Add(Me.PictureBox14)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Portal_Right_Exit)
        Me.Controls.Add(Me.Portal_Left_Exit)
        Me.Controls.Add(Me.Portal_Left)
        Me.Controls.Add(Me.Portal_Right)
        Me.Controls.Add(Me.picLife_3)
        Me.Controls.Add(Me.picLife_4)
        Me.Controls.Add(Me.picLife_5)
        Me.Controls.Add(Me.picLife_6)
        Me.Controls.Add(Me.picLife_2)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblP1)
        Me.Controls.Add(Me.picGameboard_Blue)
        Me.Controls.Add(Me.PictureBox225)
        Me.Controls.Add(Me.PictureBox263)
        Me.Controls.Add(Me.PictureBox273)
        Me.Controls.Add(Me.PictureBox270)
        Me.Controls.Add(Me.PictureBox265)
        Me.Controls.Add(Me.PictureBox219)
        Me.Controls.Add(Me.PictureBox214)
        Me.Controls.Add(Me.picBlue_Home)
        Me.Controls.Add(Me.picPink_Home)
        Me.Controls.Add(Me.picOrange_Home)
        Me.Controls.Add(Me.picGhost_Exit)
        Me.Controls.Add(Me.picPacman_Home)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Gameboard"
        Me.Text = "Gameboard"
        CType(Me.picFruit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFruit_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFruit_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFruit_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFruit_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFruit_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFruit_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFruit_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPacman, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOrange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPowerup_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPowerup_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPowerup_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPowerup_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox276, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox275, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox274, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox272, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox271, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox269, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox268, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox267, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox266, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox264, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox262, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox261, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox260, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox259, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox258, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox257, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox256, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox255, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox254, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox253, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox252, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox251, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox250, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox249, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox248, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox247, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox246, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox245, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox244, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox243, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox242, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox241, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox240, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox239, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox238, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox237, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox236, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox235, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox234, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox233, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox232, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox231, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox230, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox229, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox228, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox227, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox226, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox224, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox223, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox222, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox221, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox220, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox218, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox217, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox216, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox215, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox213, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox212, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox211, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox210, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox209, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox208, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox207, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox206, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox205, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox204, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox203, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox202, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox201, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox200, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox199, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox198, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox197, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox196, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox195, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox194, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox193, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox192, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox191, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox190, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox189, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox188, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox187, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox186, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox185, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox184, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox183, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox182, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox181, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox180, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox179, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox178, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox177, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox176, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox175, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox174, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox173, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox172, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox171, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox170, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox169, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox168, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox167, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox166, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox165, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox164, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox163, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox162, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox161, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox160, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox159, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox158, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox157, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox156, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox155, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox154, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox153, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox152, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox151, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox150, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox149, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox148, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox147, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox146, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox145, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox144, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox143, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox142, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox141, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox140, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox139, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox138, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox137, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox136, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox135, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox134, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox133, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox132, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox131, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox130, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox129, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox128, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox127, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox126, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox125, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox124, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox123, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox122, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox121, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox120, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox119, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox118, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox117, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox116, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox115, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox114, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox113, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox112, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox111, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox110, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox109, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox108, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox107, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox106, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox105, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox104, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox103, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox102, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox101, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox100, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox99, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox98, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox97, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox96, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox95, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox94, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox93, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox92, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox91, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox90, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox89, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox88, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox87, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox86, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox85, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox84, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox83, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox82, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox81, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox80, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox79, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox78, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox77, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox76, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox75, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox74, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox73, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox72, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox71, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox70, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox69, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox68, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox67, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox66, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox65, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox64, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox63, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox62, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox61, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox60, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox59, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox58, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox57, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox55, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox49, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GhostWall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Portal_Right_Exit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Portal_Left_Exit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Portal_Left, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Portal_Right, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLife_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLife_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLife_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLife_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLife_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGameboard_Blue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox225, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox263, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox273, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox270, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox265, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox219, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox214, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBlue_Home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPink_Home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOrange_Home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGhost_Exit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPacman_Home, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picGameboard_Blue As PictureBox
    Friend WithEvents picBlue As PictureBox
    Friend WithEvents picPink As PictureBox
    Friend WithEvents picOrange As PictureBox
    Friend WithEvents picRed As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents picPacman As PictureBox
    Friend WithEvents picLife_2 As PictureBox
    Friend WithEvents picLife_6 As PictureBox
    Friend WithEvents picLife_5 As PictureBox
    Friend WithEvents picLife_4 As PictureBox
    Friend WithEvents picLife_3 As PictureBox
    Friend WithEvents lblReady As Label
    Friend WithEvents lblP1 As Label
    Friend WithEvents tmrLoad As Timer
    Friend WithEvents Portal_Right As PictureBox
    Friend WithEvents Portal_Left As PictureBox
    Friend WithEvents Portal_Left_Exit As PictureBox
    Friend WithEvents Portal_Right_Exit As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents PictureBox17 As PictureBox
    Friend WithEvents PictureBox18 As PictureBox
    Friend WithEvents PictureBox19 As PictureBox
    Friend WithEvents PictureBox20 As PictureBox
    Friend WithEvents PictureBox21 As PictureBox
    Friend WithEvents PictureBox22 As PictureBox
    Friend WithEvents PictureBox23 As PictureBox
    Friend WithEvents PictureBox24 As PictureBox
    Friend WithEvents PictureBox25 As PictureBox
    Friend WithEvents PictureBox26 As PictureBox
    Friend WithEvents PictureBox27 As PictureBox
    Friend WithEvents PictureBox28 As PictureBox
    Friend WithEvents PictureBox29 As PictureBox
    Friend WithEvents PictureBox30 As PictureBox
    Friend WithEvents PictureBox31 As PictureBox
    Friend WithEvents PictureBox32 As PictureBox
    Friend WithEvents PictureBox33 As PictureBox
    Friend WithEvents PictureBox34 As PictureBox
    Friend WithEvents PictureBox35 As PictureBox
    Friend WithEvents PictureBox36 As PictureBox
    Friend WithEvents PictureBox37 As PictureBox
    Friend WithEvents PictureBox38 As PictureBox
    Friend WithEvents PictureBox39 As PictureBox
    Friend WithEvents PictureBox40 As PictureBox
    Friend WithEvents PictureBox41 As PictureBox
    Friend WithEvents PictureBox42 As PictureBox
    Friend WithEvents PictureBox43 As PictureBox
    Friend WithEvents PictureBox44 As PictureBox
    Friend WithEvents PictureBox45 As PictureBox
    Friend WithEvents PictureBox46 As PictureBox
    Friend WithEvents GhostWall As PictureBox
    Friend WithEvents PictureBox47 As PictureBox
    Friend WithEvents PictureBox48 As PictureBox
    Friend WithEvents PictureBox49 As PictureBox
    Friend WithEvents PictureBox50 As PictureBox
    Friend WithEvents PictureBox51 As PictureBox
    Friend WithEvents PictureBox52 As PictureBox
    Friend WithEvents PictureBox53 As PictureBox
    Friend WithEvents PictureBox54 As PictureBox
    Friend WithEvents PictureBox55 As PictureBox
    Friend WithEvents PictureBox56 As PictureBox
    Friend WithEvents PictureBox57 As PictureBox
    Friend WithEvents PictureBox58 As PictureBox
    Friend WithEvents PictureBox59 As PictureBox
    Friend WithEvents PictureBox60 As PictureBox
    Friend WithEvents PictureBox61 As PictureBox
    Friend WithEvents PictureBox62 As PictureBox
    Friend WithEvents PictureBox63 As PictureBox
    Friend WithEvents PictureBox64 As PictureBox
    Friend WithEvents PictureBox65 As PictureBox
    Friend WithEvents PictureBox66 As PictureBox
    Friend WithEvents PictureBox67 As PictureBox
    Friend WithEvents PictureBox68 As PictureBox
    Friend WithEvents PictureBox69 As PictureBox
    Friend WithEvents PictureBox70 As PictureBox
    Friend WithEvents PictureBox71 As PictureBox
    Friend WithEvents PictureBox72 As PictureBox
    Friend WithEvents PictureBox73 As PictureBox
    Friend WithEvents PictureBox74 As PictureBox
    Friend WithEvents PictureBox75 As PictureBox
    Friend WithEvents PictureBox76 As PictureBox
    Friend WithEvents PictureBox77 As PictureBox
    Friend WithEvents PictureBox78 As PictureBox
    Friend WithEvents PictureBox79 As PictureBox
    Friend WithEvents PictureBox80 As PictureBox
    Friend WithEvents PictureBox81 As PictureBox
    Friend WithEvents PictureBox82 As PictureBox
    Friend WithEvents PictureBox83 As PictureBox
    Friend WithEvents PictureBox84 As PictureBox
    Friend WithEvents PictureBox85 As PictureBox
    Friend WithEvents PictureBox86 As PictureBox
    Friend WithEvents PictureBox87 As PictureBox
    Friend WithEvents PictureBox88 As PictureBox
    Friend WithEvents PictureBox89 As PictureBox
    Friend WithEvents PictureBox90 As PictureBox
    Friend WithEvents PictureBox91 As PictureBox
    Friend WithEvents PictureBox92 As PictureBox
    Friend WithEvents PictureBox93 As PictureBox
    Friend WithEvents PictureBox94 As PictureBox
    Friend WithEvents PictureBox95 As PictureBox
    Friend WithEvents PictureBox97 As PictureBox
    Friend WithEvents PictureBox98 As PictureBox
    Friend WithEvents PictureBox99 As PictureBox
    Friend WithEvents PictureBox100 As PictureBox
    Friend WithEvents PictureBox101 As PictureBox
    Friend WithEvents PictureBox102 As PictureBox
    Friend WithEvents PictureBox103 As PictureBox
    Friend WithEvents PictureBox104 As PictureBox
    Friend WithEvents PictureBox96 As PictureBox
    Friend WithEvents PictureBox105 As PictureBox
    Friend WithEvents PictureBox106 As PictureBox
    Friend WithEvents PictureBox107 As PictureBox
    Friend WithEvents PictureBox108 As PictureBox
    Friend WithEvents PictureBox109 As PictureBox
    Friend WithEvents PictureBox110 As PictureBox
    Friend WithEvents PictureBox111 As PictureBox
    Friend WithEvents PictureBox112 As PictureBox
    Friend WithEvents PictureBox113 As PictureBox
    Friend WithEvents PictureBox114 As PictureBox
    Friend WithEvents PictureBox115 As PictureBox
    Friend WithEvents PictureBox116 As PictureBox
    Friend WithEvents PictureBox117 As PictureBox
    Friend WithEvents PictureBox118 As PictureBox
    Friend WithEvents PictureBox119 As PictureBox
    Friend WithEvents PictureBox120 As PictureBox
    Friend WithEvents PictureBox121 As PictureBox
    Friend WithEvents PictureBox122 As PictureBox
    Friend WithEvents PictureBox123 As PictureBox
    Friend WithEvents PictureBox124 As PictureBox
    Friend WithEvents PictureBox125 As PictureBox
    Friend WithEvents PictureBox126 As PictureBox
    Friend WithEvents PictureBox127 As PictureBox
    Friend WithEvents PictureBox128 As PictureBox
    Friend WithEvents PictureBox129 As PictureBox
    Friend WithEvents PictureBox130 As PictureBox
    Friend WithEvents PictureBox131 As PictureBox
    Friend WithEvents PictureBox132 As PictureBox
    Friend WithEvents PictureBox133 As PictureBox
    Friend WithEvents PictureBox134 As PictureBox
    Friend WithEvents PictureBox135 As PictureBox
    Friend WithEvents PictureBox136 As PictureBox
    Friend WithEvents PictureBox137 As PictureBox
    Friend WithEvents PictureBox138 As PictureBox
    Friend WithEvents PictureBox139 As PictureBox
    Friend WithEvents PictureBox140 As PictureBox
    Friend WithEvents PictureBox141 As PictureBox
    Friend WithEvents PictureBox142 As PictureBox
    Friend WithEvents PictureBox143 As PictureBox
    Friend WithEvents PictureBox144 As PictureBox
    Friend WithEvents PictureBox145 As PictureBox
    Friend WithEvents PictureBox146 As PictureBox
    Friend WithEvents PictureBox147 As PictureBox
    Friend WithEvents PictureBox148 As PictureBox
    Friend WithEvents PictureBox149 As PictureBox
    Friend WithEvents PictureBox150 As PictureBox
    Friend WithEvents PictureBox151 As PictureBox
    Friend WithEvents PictureBox152 As PictureBox
    Friend WithEvents PictureBox153 As PictureBox
    Friend WithEvents PictureBox154 As PictureBox
    Friend WithEvents PictureBox155 As PictureBox
    Friend WithEvents PictureBox156 As PictureBox
    Friend WithEvents PictureBox157 As PictureBox
    Friend WithEvents PictureBox158 As PictureBox
    Friend WithEvents PictureBox159 As PictureBox
    Friend WithEvents PictureBox160 As PictureBox
    Friend WithEvents PictureBox161 As PictureBox
    Friend WithEvents PictureBox162 As PictureBox
    Friend WithEvents PictureBox163 As PictureBox
    Friend WithEvents PictureBox164 As PictureBox
    Friend WithEvents PictureBox165 As PictureBox
    Friend WithEvents PictureBox166 As PictureBox
    Friend WithEvents PictureBox167 As PictureBox
    Friend WithEvents PictureBox168 As PictureBox
    Friend WithEvents PictureBox169 As PictureBox
    Friend WithEvents PictureBox170 As PictureBox
    Friend WithEvents PictureBox171 As PictureBox
    Friend WithEvents PictureBox172 As PictureBox
    Friend WithEvents PictureBox173 As PictureBox
    Friend WithEvents PictureBox174 As PictureBox
    Friend WithEvents PictureBox175 As PictureBox
    Friend WithEvents PictureBox176 As PictureBox
    Friend WithEvents PictureBox177 As PictureBox
    Friend WithEvents PictureBox178 As PictureBox
    Friend WithEvents PictureBox179 As PictureBox
    Friend WithEvents PictureBox180 As PictureBox
    Friend WithEvents PictureBox181 As PictureBox
    Friend WithEvents PictureBox182 As PictureBox
    Friend WithEvents PictureBox183 As PictureBox
    Friend WithEvents PictureBox184 As PictureBox
    Friend WithEvents PictureBox185 As PictureBox
    Friend WithEvents PictureBox186 As PictureBox
    Friend WithEvents PictureBox187 As PictureBox
    Friend WithEvents PictureBox188 As PictureBox
    Friend WithEvents PictureBox189 As PictureBox
    Friend WithEvents PictureBox190 As PictureBox
    Friend WithEvents PictureBox191 As PictureBox
    Friend WithEvents PictureBox192 As PictureBox
    Friend WithEvents PictureBox193 As PictureBox
    Friend WithEvents PictureBox194 As PictureBox
    Friend WithEvents PictureBox195 As PictureBox
    Friend WithEvents PictureBox196 As PictureBox
    Friend WithEvents PictureBox197 As PictureBox
    Friend WithEvents PictureBox198 As PictureBox
    Friend WithEvents PictureBox199 As PictureBox
    Friend WithEvents PictureBox200 As PictureBox
    Friend WithEvents PictureBox201 As PictureBox
    Friend WithEvents PictureBox202 As PictureBox
    Friend WithEvents PictureBox203 As PictureBox
    Friend WithEvents PictureBox204 As PictureBox
    Friend WithEvents PictureBox205 As PictureBox
    Friend WithEvents PictureBox206 As PictureBox
    Friend WithEvents PictureBox207 As PictureBox
    Friend WithEvents PictureBox208 As PictureBox
    Friend WithEvents PictureBox209 As PictureBox
    Friend WithEvents PictureBox210 As PictureBox
    Friend WithEvents PictureBox211 As PictureBox
    Friend WithEvents PictureBox212 As PictureBox
    Friend WithEvents PictureBox213 As PictureBox
    Friend WithEvents PictureBox214 As PictureBox
    Friend WithEvents PictureBox215 As PictureBox
    Friend WithEvents PictureBox216 As PictureBox
    Friend WithEvents PictureBox217 As PictureBox
    Friend WithEvents PictureBox218 As PictureBox
    Friend WithEvents PictureBox219 As PictureBox
    Friend WithEvents PictureBox220 As PictureBox
    Friend WithEvents PictureBox221 As PictureBox
    Friend WithEvents PictureBox222 As PictureBox
    Friend WithEvents PictureBox223 As PictureBox
    Friend WithEvents PictureBox224 As PictureBox
    Friend WithEvents PictureBox225 As PictureBox
    Friend WithEvents PictureBox226 As PictureBox
    Friend WithEvents PictureBox227 As PictureBox
    Friend WithEvents PictureBox228 As PictureBox
    Friend WithEvents PictureBox229 As PictureBox
    Friend WithEvents PictureBox230 As PictureBox
    Friend WithEvents PictureBox231 As PictureBox
    Friend WithEvents PictureBox232 As PictureBox
    Friend WithEvents PictureBox233 As PictureBox
    Friend WithEvents PictureBox234 As PictureBox
    Friend WithEvents PictureBox235 As PictureBox
    Friend WithEvents PictureBox236 As PictureBox
    Friend WithEvents PictureBox237 As PictureBox
    Friend WithEvents PictureBox238 As PictureBox
    Friend WithEvents PictureBox239 As PictureBox
    Friend WithEvents PictureBox240 As PictureBox
    Friend WithEvents PictureBox241 As PictureBox
    Friend WithEvents PictureBox242 As PictureBox
    Friend WithEvents PictureBox243 As PictureBox
    Friend WithEvents PictureBox244 As PictureBox
    Friend WithEvents PictureBox245 As PictureBox
    Friend WithEvents PictureBox246 As PictureBox
    Friend WithEvents PictureBox247 As PictureBox
    Friend WithEvents PictureBox248 As PictureBox
    Friend WithEvents PictureBox249 As PictureBox
    Friend WithEvents PictureBox250 As PictureBox
    Friend WithEvents PictureBox251 As PictureBox
    Friend WithEvents PictureBox252 As PictureBox
    Friend WithEvents PictureBox253 As PictureBox
    Friend WithEvents PictureBox254 As PictureBox
    Friend WithEvents PictureBox255 As PictureBox
    Friend WithEvents PictureBox256 As PictureBox
    Friend WithEvents PictureBox257 As PictureBox
    Friend WithEvents PictureBox258 As PictureBox
    Friend WithEvents PictureBox259 As PictureBox
    Friend WithEvents PictureBox260 As PictureBox
    Friend WithEvents PictureBox261 As PictureBox
    Friend WithEvents PictureBox262 As PictureBox
    Friend WithEvents PictureBox263 As PictureBox
    Friend WithEvents PictureBox264 As PictureBox
    Friend WithEvents PictureBox265 As PictureBox
    Friend WithEvents PictureBox266 As PictureBox
    Friend WithEvents PictureBox267 As PictureBox
    Friend WithEvents PictureBox268 As PictureBox
    Friend WithEvents PictureBox269 As PictureBox
    Friend WithEvents PictureBox270 As PictureBox
    Friend WithEvents PictureBox271 As PictureBox
    Friend WithEvents PictureBox272 As PictureBox
    Friend WithEvents PictureBox273 As PictureBox
    Friend WithEvents PictureBox274 As PictureBox
    Friend WithEvents PictureBox275 As PictureBox
    Friend WithEvents PictureBox276 As PictureBox
    Friend WithEvents picGhost_Exit As PictureBox
    Friend WithEvents picBlue_Home As PictureBox
    Friend WithEvents picPink_Home As PictureBox
    Friend WithEvents picOrange_Home As PictureBox
    Friend WithEvents tmrGhosts_Leave As Timer
    Friend WithEvents tmrDeath As Timer
    Friend WithEvents picPacman_Home As PictureBox
    Friend WithEvents tmrMove As Timer
    Friend WithEvents lblGameOver As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents tmrLevel_Change As Timer
    Friend WithEvents picPowerup_4 As PictureBox
    Friend WithEvents picPowerup_3 As PictureBox
    Friend WithEvents picPowerup_1 As PictureBox
    Friend WithEvents picPowerup_2 As PictureBox
    Friend WithEvents tmrRed_Death As Timer
    Friend WithEvents lblBonus As Label
    Friend WithEvents tmrPink_Death As Timer
    Friend WithEvents tmrBlue_Death As Timer
    Friend WithEvents tmrOrange_Death As Timer
    Friend WithEvents tmrScared As Timer
    Friend WithEvents picFruit_7 As PictureBox
    Friend WithEvents picFruit_6 As PictureBox
    Friend WithEvents picFruit_5 As PictureBox
    Friend WithEvents picFruit_4 As PictureBox
    Friend WithEvents picFruit_3 As PictureBox
    Friend WithEvents picFruit_2 As PictureBox
    Friend WithEvents picFruit_1 As PictureBox
    Friend WithEvents picFruit As PictureBox
    Friend WithEvents tmrPacman As Timer
    Friend WithEvents tmrGhost As Timer
    Friend WithEvents tmrOrange As Timer
    Friend WithEvents tmrPink As Timer
    Friend WithEvents tmrBlue As Timer
    Friend WithEvents tmrRed As Timer
    Friend WithEvents tmrFruit As Timer
    Friend WithEvents lblFruit_Score As Label
    Friend WithEvents tmrFruit_Display As Timer
End Class
