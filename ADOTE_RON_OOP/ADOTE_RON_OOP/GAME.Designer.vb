<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GAME
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GAME))
        backDropPanel = New Panel()
        LboatImg = New PictureBox()
        LBM3 = New PictureBox()
        LBM2 = New PictureBox()
        LBM1 = New PictureBox()
        LBH3 = New PictureBox()
        LBH2 = New PictureBox()
        LBH1 = New PictureBox()
        txtRislandP = New Label()
        txtBoatM = New Label()
        txtBoatP = New Label()
        txtRislandM = New Label()
        RBM3 = New PictureBox()
        RBM2 = New PictureBox()
        RBM1 = New PictureBox()
        RBH3 = New PictureBox()
        RBH2 = New PictureBox()
        RBH1 = New PictureBox()
        LM3 = New PictureBox()
        LM2 = New PictureBox()
        LM1 = New PictureBox()
        LH3 = New PictureBox()
        LH2 = New PictureBox()
        LH1 = New PictureBox()
        H2 = New PictureBox()
        H3 = New PictureBox()
        H1 = New PictureBox()
        RM3 = New PictureBox()
        RM2 = New PictureBox()
        RM1 = New PictureBox()
        RH3 = New PictureBox()
        RH2 = New PictureBox()
        bgBoat = New PictureBox()
        Label1 = New Label()
        bgPlane = New PictureBox()
        RH1 = New PictureBox()
        leftIslandImg = New PictureBox()
        whateImg = New PictureBox()
        sunImg = New PictureBox()
        RboatImg = New PictureBox()
        rightIslandImg = New PictureBox()
        oceanBg = New PictureBox()
        PlaneTimer = New Timer(components)
        BoatTimer = New Timer(components)
        backDropPanel.SuspendLayout()
        CType(LboatImg, ComponentModel.ISupportInitialize).BeginInit()
        CType(LBM3, ComponentModel.ISupportInitialize).BeginInit()
        CType(LBM2, ComponentModel.ISupportInitialize).BeginInit()
        CType(LBM1, ComponentModel.ISupportInitialize).BeginInit()
        CType(LBH3, ComponentModel.ISupportInitialize).BeginInit()
        CType(LBH2, ComponentModel.ISupportInitialize).BeginInit()
        CType(LBH1, ComponentModel.ISupportInitialize).BeginInit()
        CType(RBM3, ComponentModel.ISupportInitialize).BeginInit()
        CType(RBM2, ComponentModel.ISupportInitialize).BeginInit()
        CType(RBM1, ComponentModel.ISupportInitialize).BeginInit()
        CType(RBH3, ComponentModel.ISupportInitialize).BeginInit()
        CType(RBH2, ComponentModel.ISupportInitialize).BeginInit()
        CType(RBH1, ComponentModel.ISupportInitialize).BeginInit()
        CType(LM3, ComponentModel.ISupportInitialize).BeginInit()
        CType(LM2, ComponentModel.ISupportInitialize).BeginInit()
        CType(LM1, ComponentModel.ISupportInitialize).BeginInit()
        CType(LH3, ComponentModel.ISupportInitialize).BeginInit()
        CType(LH2, ComponentModel.ISupportInitialize).BeginInit()
        CType(LH1, ComponentModel.ISupportInitialize).BeginInit()
        CType(H2, ComponentModel.ISupportInitialize).BeginInit()
        CType(H3, ComponentModel.ISupportInitialize).BeginInit()
        CType(H1, ComponentModel.ISupportInitialize).BeginInit()
        CType(RM3, ComponentModel.ISupportInitialize).BeginInit()
        CType(RM2, ComponentModel.ISupportInitialize).BeginInit()
        CType(RM1, ComponentModel.ISupportInitialize).BeginInit()
        CType(RH3, ComponentModel.ISupportInitialize).BeginInit()
        CType(RH2, ComponentModel.ISupportInitialize).BeginInit()
        CType(bgBoat, ComponentModel.ISupportInitialize).BeginInit()
        CType(bgPlane, ComponentModel.ISupportInitialize).BeginInit()
        CType(RH1, ComponentModel.ISupportInitialize).BeginInit()
        CType(leftIslandImg, ComponentModel.ISupportInitialize).BeginInit()
        CType(whateImg, ComponentModel.ISupportInitialize).BeginInit()
        CType(sunImg, ComponentModel.ISupportInitialize).BeginInit()
        CType(RboatImg, ComponentModel.ISupportInitialize).BeginInit()
        CType(rightIslandImg, ComponentModel.ISupportInitialize).BeginInit()
        CType(oceanBg, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' backDropPanel
        ' 
        backDropPanel.BackColor = Color.Transparent
        backDropPanel.Controls.Add(bgBoat)
        backDropPanel.Controls.Add(LboatImg)
        backDropPanel.Controls.Add(LBM3)
        backDropPanel.Controls.Add(LBM2)
        backDropPanel.Controls.Add(LBM1)
        backDropPanel.Controls.Add(LBH3)
        backDropPanel.Controls.Add(LBH2)
        backDropPanel.Controls.Add(LBH1)
        backDropPanel.Controls.Add(txtRislandP)
        backDropPanel.Controls.Add(txtBoatM)
        backDropPanel.Controls.Add(txtBoatP)
        backDropPanel.Controls.Add(txtRislandM)
        backDropPanel.Controls.Add(RBM3)
        backDropPanel.Controls.Add(RBM2)
        backDropPanel.Controls.Add(RBM1)
        backDropPanel.Controls.Add(RBH3)
        backDropPanel.Controls.Add(RBH2)
        backDropPanel.Controls.Add(RBH1)
        backDropPanel.Controls.Add(LM3)
        backDropPanel.Controls.Add(LM2)
        backDropPanel.Controls.Add(LM1)
        backDropPanel.Controls.Add(LH3)
        backDropPanel.Controls.Add(LH2)
        backDropPanel.Controls.Add(LH1)
        backDropPanel.Controls.Add(H2)
        backDropPanel.Controls.Add(H3)
        backDropPanel.Controls.Add(H1)
        backDropPanel.Controls.Add(RM3)
        backDropPanel.Controls.Add(RM2)
        backDropPanel.Controls.Add(RM1)
        backDropPanel.Controls.Add(RH3)
        backDropPanel.Controls.Add(RH2)
        backDropPanel.Controls.Add(Label1)
        backDropPanel.Controls.Add(bgPlane)
        backDropPanel.Controls.Add(RH1)
        backDropPanel.Controls.Add(leftIslandImg)
        backDropPanel.Controls.Add(whateImg)
        backDropPanel.Controls.Add(sunImg)
        backDropPanel.Controls.Add(RboatImg)
        backDropPanel.Controls.Add(rightIslandImg)
        backDropPanel.Controls.Add(oceanBg)
        backDropPanel.Dock = DockStyle.Fill
        backDropPanel.Location = New Point(0, 0)
        backDropPanel.Name = "backDropPanel"
        backDropPanel.Size = New Size(1253, 751)
        backDropPanel.TabIndex = 0
        ' 
        ' LboatImg
        ' 
        LboatImg.Image = CType(resources.GetObject("LboatImg.Image"), Image)
        LboatImg.Location = New Point(311, 660)
        LboatImg.Name = "LboatImg"
        LboatImg.Size = New Size(183, 88)
        LboatImg.SizeMode = PictureBoxSizeMode.StretchImage
        LboatImg.TabIndex = 6
        LboatImg.TabStop = False
        LboatImg.Visible = False
        ' 
        ' LBM3
        ' 
        LBM3.Image = CType(resources.GetObject("LBM3.Image"), Image)
        LBM3.Location = New Point(336, 621)
        LBM3.Name = "LBM3"
        LBM3.Size = New Size(50, 93)
        LBM3.SizeMode = PictureBoxSizeMode.StretchImage
        LBM3.TabIndex = 41
        LBM3.TabStop = False
        LBM3.Visible = False
        ' 
        ' LBM2
        ' 
        LBM2.Image = CType(resources.GetObject("LBM2.Image"), Image)
        LBM2.Location = New Point(336, 621)
        LBM2.Name = "LBM2"
        LBM2.Size = New Size(50, 93)
        LBM2.SizeMode = PictureBoxSizeMode.StretchImage
        LBM2.TabIndex = 40
        LBM2.TabStop = False
        LBM2.Visible = False
        ' 
        ' LBM1
        ' 
        LBM1.Image = CType(resources.GetObject("LBM1.Image"), Image)
        LBM1.Location = New Point(336, 621)
        LBM1.Name = "LBM1"
        LBM1.Size = New Size(50, 93)
        LBM1.SizeMode = PictureBoxSizeMode.StretchImage
        LBM1.TabIndex = 39
        LBM1.TabStop = False
        LBM1.Visible = False
        ' 
        ' LBH3
        ' 
        LBH3.Image = CType(resources.GetObject("LBH3.Image"), Image)
        LBH3.Location = New Point(336, 621)
        LBH3.Name = "LBH3"
        LBH3.Size = New Size(50, 93)
        LBH3.SizeMode = PictureBoxSizeMode.StretchImage
        LBH3.TabIndex = 38
        LBH3.TabStop = False
        LBH3.Visible = False
        ' 
        ' LBH2
        ' 
        LBH2.Image = CType(resources.GetObject("LBH2.Image"), Image)
        LBH2.Location = New Point(336, 621)
        LBH2.Name = "LBH2"
        LBH2.Size = New Size(50, 93)
        LBH2.SizeMode = PictureBoxSizeMode.StretchImage
        LBH2.TabIndex = 37
        LBH2.TabStop = False
        LBH2.Visible = False
        ' 
        ' LBH1
        ' 
        LBH1.Image = CType(resources.GetObject("LBH1.Image"), Image)
        LBH1.Location = New Point(336, 621)
        LBH1.Name = "LBH1"
        LBH1.Size = New Size(50, 93)
        LBH1.SizeMode = PictureBoxSizeMode.StretchImage
        LBH1.TabIndex = 36
        LBH1.TabStop = False
        LBH1.Visible = False
        ' 
        ' txtRislandP
        ' 
        txtRislandP.AutoSize = True
        txtRislandP.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtRislandP.Location = New Point(1016, 322)
        txtRislandP.Name = "txtRislandP"
        txtRislandP.Size = New Size(53, 20)
        txtRislandP.TabIndex = 35
        txtRislandP.Text = "rIsland"
        ' 
        ' txtBoatM
        ' 
        txtBoatM.AutoSize = True
        txtBoatM.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBoatM.Location = New Point(861, 389)
        txtBoatM.Name = "txtBoatM"
        txtBoatM.Size = New Size(40, 20)
        txtBoatM.TabIndex = 34
        txtBoatM.Text = "boat"
        ' 
        ' txtBoatP
        ' 
        txtBoatP.AutoSize = True
        txtBoatP.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBoatP.Location = New Point(783, 389)
        txtBoatP.Name = "txtBoatP"
        txtBoatP.Size = New Size(40, 20)
        txtBoatP.TabIndex = 33
        txtBoatP.Text = "boat"
        ' 
        ' txtRislandM
        ' 
        txtRislandM.AutoSize = True
        txtRislandM.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtRislandM.Location = New Point(1118, 322)
        txtRislandM.Name = "txtRislandM"
        txtRislandM.Size = New Size(53, 20)
        txtRislandM.TabIndex = 1
        txtRislandM.Text = "rIsland"
        ' 
        ' RBM3
        ' 
        RBM3.Image = CType(resources.GetObject("RBM3.Image"), Image)
        RBM3.Location = New Point(861, 621)
        RBM3.Name = "RBM3"
        RBM3.Size = New Size(50, 93)
        RBM3.SizeMode = PictureBoxSizeMode.StretchImage
        RBM3.TabIndex = 32
        RBM3.TabStop = False
        RBM3.Visible = False
        ' 
        ' RBM2
        ' 
        RBM2.Image = CType(resources.GetObject("RBM2.Image"), Image)
        RBM2.Location = New Point(861, 621)
        RBM2.Name = "RBM2"
        RBM2.Size = New Size(50, 93)
        RBM2.SizeMode = PictureBoxSizeMode.StretchImage
        RBM2.TabIndex = 31
        RBM2.TabStop = False
        RBM2.Visible = False
        ' 
        ' RBM1
        ' 
        RBM1.Image = CType(resources.GetObject("RBM1.Image"), Image)
        RBM1.Location = New Point(861, 621)
        RBM1.Name = "RBM1"
        RBM1.Size = New Size(50, 93)
        RBM1.SizeMode = PictureBoxSizeMode.StretchImage
        RBM1.TabIndex = 30
        RBM1.TabStop = False
        RBM1.Visible = False
        ' 
        ' RBH3
        ' 
        RBH3.Image = CType(resources.GetObject("RBH3.Image"), Image)
        RBH3.Location = New Point(861, 621)
        RBH3.Name = "RBH3"
        RBH3.Size = New Size(50, 93)
        RBH3.SizeMode = PictureBoxSizeMode.StretchImage
        RBH3.TabIndex = 29
        RBH3.TabStop = False
        RBH3.Visible = False
        ' 
        ' RBH2
        ' 
        RBH2.Image = CType(resources.GetObject("RBH2.Image"), Image)
        RBH2.Location = New Point(861, 621)
        RBH2.Name = "RBH2"
        RBH2.Size = New Size(50, 93)
        RBH2.SizeMode = PictureBoxSizeMode.StretchImage
        RBH2.TabIndex = 28
        RBH2.TabStop = False
        RBH2.Visible = False
        ' 
        ' RBH1
        ' 
        RBH1.Image = CType(resources.GetObject("RBH1.Image"), Image)
        RBH1.Location = New Point(861, 621)
        RBH1.Name = "RBH1"
        RBH1.Size = New Size(50, 93)
        RBH1.SizeMode = PictureBoxSizeMode.StretchImage
        RBH1.TabIndex = 27
        RBH1.TabStop = False
        RBH1.Visible = False
        ' 
        ' LM3
        ' 
        LM3.Image = CType(resources.GetObject("LM3.Image"), Image)
        LM3.Location = New Point(255, 549)
        LM3.Name = "LM3"
        LM3.Size = New Size(50, 93)
        LM3.SizeMode = PictureBoxSizeMode.StretchImage
        LM3.TabIndex = 26
        LM3.TabStop = False
        LM3.Visible = False
        ' 
        ' LM2
        ' 
        LM2.Image = CType(resources.GetObject("LM2.Image"), Image)
        LM2.Location = New Point(208, 549)
        LM2.Name = "LM2"
        LM2.Size = New Size(50, 93)
        LM2.SizeMode = PictureBoxSizeMode.StretchImage
        LM2.TabIndex = 25
        LM2.TabStop = False
        LM2.Visible = False
        ' 
        ' LM1
        ' 
        LM1.Image = CType(resources.GetObject("LM1.Image"), Image)
        LM1.Location = New Point(161, 549)
        LM1.Name = "LM1"
        LM1.Size = New Size(50, 93)
        LM1.SizeMode = PictureBoxSizeMode.StretchImage
        LM1.TabIndex = 24
        LM1.TabStop = False
        LM1.Visible = False
        ' 
        ' LH3
        ' 
        LH3.Image = CType(resources.GetObject("LH3.Image"), Image)
        LH3.Location = New Point(96, 549)
        LH3.Name = "LH3"
        LH3.Size = New Size(50, 93)
        LH3.SizeMode = PictureBoxSizeMode.StretchImage
        LH3.TabIndex = 23
        LH3.TabStop = False
        LH3.Visible = False
        ' 
        ' LH2
        ' 
        LH2.Image = CType(resources.GetObject("LH2.Image"), Image)
        LH2.Location = New Point(49, 549)
        LH2.Name = "LH2"
        LH2.Size = New Size(50, 93)
        LH2.SizeMode = PictureBoxSizeMode.StretchImage
        LH2.TabIndex = 22
        LH2.TabStop = False
        LH2.Visible = False
        ' 
        ' LH1
        ' 
        LH1.Image = CType(resources.GetObject("LH1.Image"), Image)
        LH1.Location = New Point(2, 549)
        LH1.Name = "LH1"
        LH1.Size = New Size(50, 93)
        LH1.SizeMode = PictureBoxSizeMode.StretchImage
        LH1.TabIndex = 21
        LH1.TabStop = False
        LH1.Visible = False
        ' 
        ' H2
        ' 
        H2.Image = CType(resources.GetObject("H2.Image"), Image)
        H2.Location = New Point(1105, 21)
        H2.Name = "H2"
        H2.Size = New Size(53, 46)
        H2.SizeMode = PictureBoxSizeMode.StretchImage
        H2.TabIndex = 20
        H2.TabStop = False
        ' 
        ' H3
        ' 
        H3.Image = CType(resources.GetObject("H3.Image"), Image)
        H3.Location = New Point(1164, 21)
        H3.Name = "H3"
        H3.Size = New Size(53, 46)
        H3.SizeMode = PictureBoxSizeMode.StretchImage
        H3.TabIndex = 19
        H3.TabStop = False
        ' 
        ' H1
        ' 
        H1.Image = CType(resources.GetObject("H1.Image"), Image)
        H1.Location = New Point(1046, 21)
        H1.Name = "H1"
        H1.Size = New Size(53, 46)
        H1.SizeMode = PictureBoxSizeMode.StretchImage
        H1.TabIndex = 18
        H1.TabStop = False
        ' 
        ' RM3
        ' 
        RM3.Image = CType(resources.GetObject("RM3.Image"), Image)
        RM3.Location = New Point(1187, 549)
        RM3.Name = "RM3"
        RM3.Size = New Size(50, 93)
        RM3.SizeMode = PictureBoxSizeMode.StretchImage
        RM3.TabIndex = 17
        RM3.TabStop = False
        ' 
        ' RM2
        ' 
        RM2.Image = CType(resources.GetObject("RM2.Image"), Image)
        RM2.Location = New Point(1140, 549)
        RM2.Name = "RM2"
        RM2.Size = New Size(50, 93)
        RM2.SizeMode = PictureBoxSizeMode.StretchImage
        RM2.TabIndex = 16
        RM2.TabStop = False
        ' 
        ' RM1
        ' 
        RM1.Image = CType(resources.GetObject("RM1.Image"), Image)
        RM1.Location = New Point(1093, 549)
        RM1.Name = "RM1"
        RM1.Size = New Size(50, 93)
        RM1.SizeMode = PictureBoxSizeMode.StretchImage
        RM1.TabIndex = 15
        RM1.TabStop = False
        ' 
        ' RH3
        ' 
        RH3.Image = CType(resources.GetObject("RH3.Image"), Image)
        RH3.Location = New Point(1028, 549)
        RH3.Name = "RH3"
        RH3.Size = New Size(50, 93)
        RH3.SizeMode = PictureBoxSizeMode.StretchImage
        RH3.TabIndex = 14
        RH3.TabStop = False
        ' 
        ' RH2
        ' 
        RH2.Image = CType(resources.GetObject("RH2.Image"), Image)
        RH2.Location = New Point(981, 549)
        RH2.Name = "RH2"
        RH2.Size = New Size(50, 93)
        RH2.SizeMode = PictureBoxSizeMode.StretchImage
        RH2.TabIndex = 13
        RH2.TabStop = False
        ' 
        ' bgBoat
        ' 
        bgBoat.Image = CType(resources.GetObject("bgBoat.Image"), Image)
        bgBoat.Location = New Point(-148, 510)
        bgBoat.Name = "bgBoat"
        bgBoat.Size = New Size(181, 81)
        bgBoat.SizeMode = PictureBoxSizeMode.StretchImage
        bgBoat.TabIndex = 8
        bgBoat.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(934, 28)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(10)
        Label1.Size = New Size(106, 39)
        Label1.TabIndex = 12
        Label1.Text = "HEALTH: "
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' bgPlane
        ' 
        bgPlane.Image = CType(resources.GetObject("bgPlane.Image"), Image)
        bgPlane.Location = New Point(1231, 210)
        bgPlane.Name = "bgPlane"
        bgPlane.Size = New Size(153, 105)
        bgPlane.SizeMode = PictureBoxSizeMode.StretchImage
        bgPlane.TabIndex = 11
        bgPlane.TabStop = False
        ' 
        ' RH1
        ' 
        RH1.Image = CType(resources.GetObject("RH1.Image"), Image)
        RH1.Location = New Point(934, 549)
        RH1.Name = "RH1"
        RH1.Size = New Size(50, 93)
        RH1.SizeMode = PictureBoxSizeMode.StretchImage
        RH1.TabIndex = 10
        RH1.TabStop = False
        ' 
        ' leftIslandImg
        ' 
        leftIslandImg.BackColor = Color.Transparent
        leftIslandImg.BackgroundImageLayout = ImageLayout.Stretch
        leftIslandImg.Image = CType(resources.GetObject("leftIslandImg.Image"), Image)
        leftIslandImg.Location = New Point(-31, 639)
        leftIslandImg.Name = "leftIslandImg"
        leftIslandImg.Size = New Size(336, 240)
        leftIslandImg.SizeMode = PictureBoxSizeMode.CenterImage
        leftIslandImg.TabIndex = 9
        leftIslandImg.TabStop = False
        ' 
        ' whateImg
        ' 
        whateImg.Image = CType(resources.GetObject("whateImg.Image"), Image)
        whateImg.Location = New Point(506, 581)
        whateImg.Name = "whateImg"
        whateImg.Size = New Size(118, 93)
        whateImg.SizeMode = PictureBoxSizeMode.StretchImage
        whateImg.TabIndex = 7
        whateImg.TabStop = False
        ' 
        ' sunImg
        ' 
        sunImg.Image = CType(resources.GetObject("sunImg.Image"), Image)
        sunImg.Location = New Point(66, 0)
        sunImg.Name = "sunImg"
        sunImg.Size = New Size(179, 176)
        sunImg.SizeMode = PictureBoxSizeMode.StretchImage
        sunImg.TabIndex = 4
        sunImg.TabStop = False
        ' 
        ' RboatImg
        ' 
        RboatImg.Image = CType(resources.GetObject("RboatImg.Image"), Image)
        RboatImg.Location = New Point(745, 660)
        RboatImg.Name = "RboatImg"
        RboatImg.Size = New Size(183, 88)
        RboatImg.SizeMode = PictureBoxSizeMode.StretchImage
        RboatImg.TabIndex = 5
        RboatImg.TabStop = False
        ' 
        ' rightIslandImg
        ' 
        rightIslandImg.BackColor = Color.Transparent
        rightIslandImg.BackgroundImageLayout = ImageLayout.Stretch
        rightIslandImg.Image = CType(resources.GetObject("rightIslandImg.Image"), Image)
        rightIslandImg.Location = New Point(934, 639)
        rightIslandImg.Name = "rightIslandImg"
        rightIslandImg.Size = New Size(336, 240)
        rightIslandImg.SizeMode = PictureBoxSizeMode.CenterImage
        rightIslandImg.TabIndex = 2
        rightIslandImg.TabStop = False
        ' 
        ' oceanBg
        ' 
        oceanBg.BackColor = Color.Transparent
        oceanBg.BackgroundImageLayout = ImageLayout.None
        oceanBg.Image = CType(resources.GetObject("oceanBg.Image"), Image)
        oceanBg.Location = New Point(0, 0)
        oceanBg.Name = "oceanBg"
        oceanBg.Size = New Size(1265, 751)
        oceanBg.SizeMode = PictureBoxSizeMode.StretchImage
        oceanBg.TabIndex = 0
        oceanBg.TabStop = False
        ' 
        ' PlaneTimer
        ' 
        PlaneTimer.Enabled = True
        PlaneTimer.Interval = 10
        ' 
        ' BoatTimer
        ' 
        BoatTimer.Enabled = True
        BoatTimer.Interval = 40
        ' 
        ' GAME
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1253, 751)
        Controls.Add(backDropPanel)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "GAME"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Game: BrainRot"
        backDropPanel.ResumeLayout(False)
        backDropPanel.PerformLayout()
        CType(LboatImg, ComponentModel.ISupportInitialize).EndInit()
        CType(LBM3, ComponentModel.ISupportInitialize).EndInit()
        CType(LBM2, ComponentModel.ISupportInitialize).EndInit()
        CType(LBM1, ComponentModel.ISupportInitialize).EndInit()
        CType(LBH3, ComponentModel.ISupportInitialize).EndInit()
        CType(LBH2, ComponentModel.ISupportInitialize).EndInit()
        CType(LBH1, ComponentModel.ISupportInitialize).EndInit()
        CType(RBM3, ComponentModel.ISupportInitialize).EndInit()
        CType(RBM2, ComponentModel.ISupportInitialize).EndInit()
        CType(RBM1, ComponentModel.ISupportInitialize).EndInit()
        CType(RBH3, ComponentModel.ISupportInitialize).EndInit()
        CType(RBH2, ComponentModel.ISupportInitialize).EndInit()
        CType(RBH1, ComponentModel.ISupportInitialize).EndInit()
        CType(LM3, ComponentModel.ISupportInitialize).EndInit()
        CType(LM2, ComponentModel.ISupportInitialize).EndInit()
        CType(LM1, ComponentModel.ISupportInitialize).EndInit()
        CType(LH3, ComponentModel.ISupportInitialize).EndInit()
        CType(LH2, ComponentModel.ISupportInitialize).EndInit()
        CType(LH1, ComponentModel.ISupportInitialize).EndInit()
        CType(H2, ComponentModel.ISupportInitialize).EndInit()
        CType(H3, ComponentModel.ISupportInitialize).EndInit()
        CType(H1, ComponentModel.ISupportInitialize).EndInit()
        CType(RM3, ComponentModel.ISupportInitialize).EndInit()
        CType(RM2, ComponentModel.ISupportInitialize).EndInit()
        CType(RM1, ComponentModel.ISupportInitialize).EndInit()
        CType(RH3, ComponentModel.ISupportInitialize).EndInit()
        CType(RH2, ComponentModel.ISupportInitialize).EndInit()
        CType(bgBoat, ComponentModel.ISupportInitialize).EndInit()
        CType(bgPlane, ComponentModel.ISupportInitialize).EndInit()
        CType(RH1, ComponentModel.ISupportInitialize).EndInit()
        CType(leftIslandImg, ComponentModel.ISupportInitialize).EndInit()
        CType(whateImg, ComponentModel.ISupportInitialize).EndInit()
        CType(sunImg, ComponentModel.ISupportInitialize).EndInit()
        CType(RboatImg, ComponentModel.ISupportInitialize).EndInit()
        CType(rightIslandImg, ComponentModel.ISupportInitialize).EndInit()
        CType(oceanBg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents backDropPanel As Panel
    Friend WithEvents oceanBg As PictureBox
    Friend WithEvents rightIslandImg As PictureBox
    Friend WithEvents sunImg As PictureBox
    Friend WithEvents RboatImg As PictureBox
    Friend WithEvents LboatImg As PictureBox
    Friend WithEvents whateImg As PictureBox
    Friend WithEvents leftIslandImg As PictureBox
    Friend WithEvents bgBoat As PictureBox
    Friend WithEvents PlaneTimer As Timer
    Friend WithEvents RH1 As PictureBox
    Friend WithEvents bgPlane As PictureBox
    Friend WithEvents BoatTimer As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents RH3 As PictureBox
    Friend WithEvents RH2 As PictureBox
    Friend WithEvents RM1 As PictureBox
    Friend WithEvents RM3 As PictureBox
    Friend WithEvents RM2 As PictureBox
    Friend WithEvents H1 As PictureBox
    Friend WithEvents H2 As PictureBox
    Friend WithEvents H3 As PictureBox
    Friend WithEvents LM3 As PictureBox
    Friend WithEvents LM2 As PictureBox
    Friend WithEvents LM1 As PictureBox
    Friend WithEvents LH3 As PictureBox
    Friend WithEvents LH2 As PictureBox
    Friend WithEvents LH1 As PictureBox
    Friend WithEvents RBH1 As PictureBox
    Friend WithEvents RBH2 As PictureBox
    Friend WithEvents RBM3 As PictureBox
    Friend WithEvents RBM2 As PictureBox
    Friend WithEvents RBM1 As PictureBox
    Friend WithEvents RBH3 As PictureBox
    Friend WithEvents txtBoatP As Label
    Friend WithEvents txtRislandM As Label
    Friend WithEvents txtBoatM As Label
    Friend WithEvents txtRislandP As Label
    Friend WithEvents LBM3 As PictureBox
    Friend WithEvents LBM2 As PictureBox
    Friend WithEvents LBM1 As PictureBox
    Friend WithEvents LBH3 As PictureBox
    Friend WithEvents LBH2 As PictureBox
    Friend WithEvents LBH1 As PictureBox
End Class
