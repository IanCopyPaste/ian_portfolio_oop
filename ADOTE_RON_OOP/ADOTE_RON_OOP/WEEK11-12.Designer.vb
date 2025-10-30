<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WEEK11_12
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WEEK11_12))
        Button4 = New Button()
        AllPanel = New Panel()
        filterPanel = New Panel()
        Label10 = New Label()
        TextBox1 = New TextBox()
        Label11 = New Label()
        TextBox2 = New TextBox()
        Button2 = New Button()
        Label12 = New Label()
        TextBox3 = New TextBox()
        Label13 = New Label()
        TextBox4 = New TextBox()
        Button3 = New Button()
        characterPanel = New Panel()
        Label5 = New Label()
        txtCHRWresult = New TextBox()
        Label6 = New Label()
        txtCHRW = New TextBox()
        CHRW = New Button()
        Label8 = New Label()
        txtCHRresult = New TextBox()
        Label9 = New Label()
        txtCHR = New TextBox()
        chrConvert = New Button()
        AscPanel = New Panel()
        Label3 = New Label()
        txtASCWresult = New TextBox()
        Label4 = New Label()
        txtASCW = New TextBox()
        Button1 = New Button()
        Label2 = New Label()
        txtASCresult = New TextBox()
        Label1 = New Label()
        txtASC = New TextBox()
        ascConvertBtn = New Button()
        Panel5 = New Panel()
        Label7 = New Label()
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        ucaseBtn = New Button()
        trimBtn = New Button()
        strReverseBtn = New Button()
        StrDupBtn = New Button()
        StrConvBtn = New Button()
        strCompBtn = New Button()
        splitBtn = New Button()
        spaceBtn = New Button()
        rtimBtn = New Button()
        rsetBtn = New Button()
        rightBtn = New Button()
        formatPercentbtn = New Button()
        formatNumberBtn = New Button()
        formatDateTimeBtn = New Button()
        formatCurBtn = New Button()
        formatBtn = New Button()
        filterBtn = New Button()
        chrBtn = New Button()
        AscBtn = New Button()
        AllPanel.SuspendLayout()
        filterPanel.SuspendLayout()
        characterPanel.SuspendLayout()
        AscPanel.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Button4.BackColor = Color.Transparent
        Button4.BackgroundImageLayout = ImageLayout.None
        Button4.Cursor = Cursors.Hand
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseDownBackColor = Color.Indigo
        Button4.FlatAppearance.MouseOverBackColor = Color.Fuchsia
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Tahoma", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.Transparent
        Button4.Image = CType(resources.GetObject("Button4.Image"), Image)
        Button4.ImageAlign = ContentAlignment.MiddleRight
        Button4.Location = New Point(-73, 0)
        Button4.Name = "Button4"
        Button4.Padding = New Padding(10, 0, 40, 0)
        Button4.Size = New Size(351, 49)
        Button4.TabIndex = 8
        Button4.Text = "     Back to " & vbCrLf & "  Dashboard"
        Button4.TextImageRelation = TextImageRelation.ImageBeforeText
        Button4.UseVisualStyleBackColor = False
        ' 
        ' AllPanel
        ' 
        AllPanel.BackColor = Color.Transparent
        AllPanel.BackgroundImage = CType(resources.GetObject("AllPanel.BackgroundImage"), Image)
        AllPanel.BackgroundImageLayout = ImageLayout.Stretch
        AllPanel.Controls.Add(filterPanel)
        AllPanel.Controls.Add(characterPanel)
        AllPanel.Controls.Add(AscPanel)
        AllPanel.Controls.Add(Panel5)
        AllPanel.Controls.Add(Label7)
        AllPanel.Controls.Add(PictureBox1)
        AllPanel.Controls.Add(Button4)
        AllPanel.Controls.Add(GroupBox1)
        AllPanel.Dock = DockStyle.Fill
        AllPanel.Location = New Point(0, 0)
        AllPanel.Name = "AllPanel"
        AllPanel.Size = New Size(930, 494)
        AllPanel.TabIndex = 7
        ' 
        ' filterPanel
        ' 
        filterPanel.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        filterPanel.Controls.Add(Label10)
        filterPanel.Controls.Add(TextBox1)
        filterPanel.Controls.Add(Label11)
        filterPanel.Controls.Add(TextBox2)
        filterPanel.Controls.Add(Button2)
        filterPanel.Controls.Add(Label12)
        filterPanel.Controls.Add(TextBox3)
        filterPanel.Controls.Add(Label13)
        filterPanel.Controls.Add(TextBox4)
        filterPanel.Controls.Add(Button3)
        filterPanel.Location = New Point(295, 67)
        filterPanel.Name = "filterPanel"
        filterPanel.Size = New Size(623, 415)
        filterPanel.TabIndex = 13
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(3, 222)
        Label10.Name = "Label10"
        Label10.Size = New Size(399, 21)
        Label10.TabIndex = 28
        Label10.Text = "CHRW= Can convert variety of characters to numbers"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(331, 275)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(130, 25)
        TextBox1.TabIndex = 27
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(294, 281)
        Label11.Name = "Label11"
        Label11.Size = New Size(31, 15)
        Label11.TabIndex = 26
        Label11.Text = "==>"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(95, 276)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Enter Text Here"
        TextBox2.Size = New Size(193, 25)
        TextBox2.TabIndex = 25
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        Button2.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        Button2.FlatAppearance.MouseDownBackColor = Color.Purple
        Button2.FlatAppearance.MouseOverBackColor = Color.Fuchsia
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Tahoma", 9.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(219, 327)
        Button2.Name = "Button2"
        Button2.Size = New Size(154, 29)
        Button2.TabIndex = 24
        Button2.Text = "CHRW Convert"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.Black
        Label12.Location = New Point(3, 14)
        Label12.Name = "Label12"
        Label12.Size = New Size(49, 21)
        Label12.TabIndex = 23
        Label12.Text = "fiilter"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(331, 67)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(130, 25)
        TextBox3.TabIndex = 22
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(294, 73)
        Label13.Name = "Label13"
        Label13.Size = New Size(31, 15)
        Label13.TabIndex = 21
        Label13.Text = "==>"
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(95, 68)
        TextBox4.Name = "TextBox4"
        TextBox4.PlaceholderText = "Enter Text Here"
        TextBox4.Size = New Size(193, 25)
        TextBox4.TabIndex = 20
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        Button3.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        Button3.FlatAppearance.MouseDownBackColor = Color.Purple
        Button3.FlatAppearance.MouseOverBackColor = Color.Fuchsia
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Tahoma", 9.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.Black
        Button3.Location = New Point(219, 119)
        Button3.Name = "Button3"
        Button3.Size = New Size(154, 29)
        Button3.TabIndex = 19
        Button3.Text = "CHR Convert"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' characterPanel
        ' 
        characterPanel.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        characterPanel.Controls.Add(Label5)
        characterPanel.Controls.Add(txtCHRWresult)
        characterPanel.Controls.Add(Label6)
        characterPanel.Controls.Add(txtCHRW)
        characterPanel.Controls.Add(CHRW)
        characterPanel.Controls.Add(Label8)
        characterPanel.Controls.Add(txtCHRresult)
        characterPanel.Controls.Add(Label9)
        characterPanel.Controls.Add(txtCHR)
        characterPanel.Controls.Add(chrConvert)
        characterPanel.Location = New Point(295, 67)
        characterPanel.Name = "characterPanel"
        characterPanel.Size = New Size(623, 415)
        characterPanel.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(3, 222)
        Label5.Name = "Label5"
        Label5.Size = New Size(399, 21)
        Label5.TabIndex = 28
        Label5.Text = "CHRW= Can convert variety of characters to numbers"
        ' 
        ' txtCHRWresult
        ' 
        txtCHRWresult.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCHRWresult.Location = New Point(331, 275)
        txtCHRWresult.Name = "txtCHRWresult"
        txtCHRWresult.ReadOnly = True
        txtCHRWresult.Size = New Size(130, 25)
        txtCHRWresult.TabIndex = 27
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(294, 281)
        Label6.Name = "Label6"
        Label6.Size = New Size(31, 15)
        Label6.TabIndex = 26
        Label6.Text = "==>"
        ' 
        ' txtCHRW
        ' 
        txtCHRW.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCHRW.Location = New Point(95, 276)
        txtCHRW.Name = "txtCHRW"
        txtCHRW.PlaceholderText = "Enter Text Here"
        txtCHRW.Size = New Size(193, 25)
        txtCHRW.TabIndex = 25
        ' 
        ' CHRW
        ' 
        CHRW.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        CHRW.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        CHRW.FlatAppearance.MouseDownBackColor = Color.Purple
        CHRW.FlatAppearance.MouseOverBackColor = Color.Fuchsia
        CHRW.FlatStyle = FlatStyle.Flat
        CHRW.Font = New Font("Tahoma", 9.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        CHRW.ForeColor = Color.Black
        CHRW.Location = New Point(219, 327)
        CHRW.Name = "CHRW"
        CHRW.Size = New Size(154, 29)
        CHRW.TabIndex = 24
        CHRW.Text = "CHRW Convert"
        CHRW.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(3, 14)
        Label8.Name = "Label8"
        Label8.Size = New Size(390, 21)
        Label8.TabIndex = 23
        Label8.Text = "Chr = Mainly converts english chars to numbers only"
        ' 
        ' txtCHRresult
        ' 
        txtCHRresult.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCHRresult.Location = New Point(331, 67)
        txtCHRresult.Name = "txtCHRresult"
        txtCHRresult.ReadOnly = True
        txtCHRresult.Size = New Size(130, 25)
        txtCHRresult.TabIndex = 22
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(294, 73)
        Label9.Name = "Label9"
        Label9.Size = New Size(31, 15)
        Label9.TabIndex = 21
        Label9.Text = "==>"
        ' 
        ' txtCHR
        ' 
        txtCHR.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCHR.Location = New Point(95, 68)
        txtCHR.Name = "txtCHR"
        txtCHR.PlaceholderText = "Enter Text Here"
        txtCHR.Size = New Size(193, 25)
        txtCHR.TabIndex = 20
        ' 
        ' chrConvert
        ' 
        chrConvert.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        chrConvert.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        chrConvert.FlatAppearance.MouseDownBackColor = Color.Purple
        chrConvert.FlatAppearance.MouseOverBackColor = Color.Fuchsia
        chrConvert.FlatStyle = FlatStyle.Flat
        chrConvert.Font = New Font("Tahoma", 9.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        chrConvert.ForeColor = Color.Black
        chrConvert.Location = New Point(219, 119)
        chrConvert.Name = "chrConvert"
        chrConvert.Size = New Size(154, 29)
        chrConvert.TabIndex = 19
        chrConvert.Text = "CHR Convert"
        chrConvert.UseVisualStyleBackColor = False
        ' 
        ' AscPanel
        ' 
        AscPanel.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        AscPanel.Controls.Add(Label3)
        AscPanel.Controls.Add(txtASCWresult)
        AscPanel.Controls.Add(Label4)
        AscPanel.Controls.Add(txtASCW)
        AscPanel.Controls.Add(Button1)
        AscPanel.Controls.Add(Label2)
        AscPanel.Controls.Add(txtASCresult)
        AscPanel.Controls.Add(Label1)
        AscPanel.Controls.Add(txtASC)
        AscPanel.Controls.Add(ascConvertBtn)
        AscPanel.Location = New Point(295, 67)
        AscPanel.Name = "AscPanel"
        AscPanel.Size = New Size(623, 415)
        AscPanel.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(3, 222)
        Label3.Name = "Label3"
        Label3.Size = New Size(309, 21)
        Label3.TabIndex = 28
        Label3.Text = "ASCW= Can convert variety of characters"
        ' 
        ' txtASCWresult
        ' 
        txtASCWresult.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtASCWresult.Location = New Point(331, 275)
        txtASCWresult.Name = "txtASCWresult"
        txtASCWresult.ReadOnly = True
        txtASCWresult.Size = New Size(130, 25)
        txtASCWresult.TabIndex = 27
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(294, 281)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 15)
        Label4.TabIndex = 26
        Label4.Text = "==>"
        ' 
        ' txtASCW
        ' 
        txtASCW.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtASCW.Location = New Point(95, 276)
        txtASCW.Name = "txtASCW"
        txtASCW.PlaceholderText = "Enter Text Here"
        txtASCW.Size = New Size(193, 25)
        txtASCW.TabIndex = 25
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        Button1.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        Button1.FlatAppearance.MouseDownBackColor = Color.Purple
        Button1.FlatAppearance.MouseOverBackColor = Color.Fuchsia
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Tahoma", 9.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(219, 327)
        Button1.Name = "Button1"
        Button1.Size = New Size(154, 29)
        Button1.TabIndex = 24
        Button1.Text = "ASCW Convert"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(3, 14)
        Label2.Name = "Label2"
        Label2.Size = New Size(307, 21)
        Label2.TabIndex = 23
        Label2.Text = "ASC = Mainly converts english chars only"
        ' 
        ' txtASCresult
        ' 
        txtASCresult.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtASCresult.Location = New Point(331, 67)
        txtASCresult.Name = "txtASCresult"
        txtASCresult.ReadOnly = True
        txtASCresult.Size = New Size(130, 25)
        txtASCresult.TabIndex = 22
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(294, 73)
        Label1.Name = "Label1"
        Label1.Size = New Size(31, 15)
        Label1.TabIndex = 21
        Label1.Text = "==>"
        ' 
        ' txtASC
        ' 
        txtASC.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtASC.Location = New Point(95, 68)
        txtASC.Name = "txtASC"
        txtASC.PlaceholderText = "Enter Text Here"
        txtASC.Size = New Size(193, 25)
        txtASC.TabIndex = 20
        ' 
        ' ascConvertBtn
        ' 
        ascConvertBtn.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        ascConvertBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        ascConvertBtn.FlatAppearance.MouseDownBackColor = Color.Purple
        ascConvertBtn.FlatAppearance.MouseOverBackColor = Color.Fuchsia
        ascConvertBtn.FlatStyle = FlatStyle.Flat
        ascConvertBtn.Font = New Font("Tahoma", 9.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        ascConvertBtn.ForeColor = Color.Black
        ascConvertBtn.Location = New Point(219, 119)
        ascConvertBtn.Name = "ascConvertBtn"
        ascConvertBtn.Size = New Size(154, 29)
        ascConvertBtn.TabIndex = 19
        ascConvertBtn.Text = "ASC Convert"
        ascConvertBtn.UseVisualStyleBackColor = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.GhostWhite
        Panel5.Location = New Point(0, 3)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(5, 41)
        Panel5.TabIndex = 9
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Trebuchet MS", 36F, FontStyle.Bold)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(295, 3)
        Label7.Name = "Label7"
        Label7.Size = New Size(433, 61)
        Label7.TabIndex = 8
        Label7.Text = "MDI and Functions"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(251, 6)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(48, 44)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        GroupBox1.Controls.Add(ucaseBtn)
        GroupBox1.Controls.Add(trimBtn)
        GroupBox1.Controls.Add(strReverseBtn)
        GroupBox1.Controls.Add(StrDupBtn)
        GroupBox1.Controls.Add(StrConvBtn)
        GroupBox1.Controls.Add(strCompBtn)
        GroupBox1.Controls.Add(splitBtn)
        GroupBox1.Controls.Add(spaceBtn)
        GroupBox1.Controls.Add(rtimBtn)
        GroupBox1.Controls.Add(rsetBtn)
        GroupBox1.Controls.Add(rightBtn)
        GroupBox1.Controls.Add(formatPercentbtn)
        GroupBox1.Controls.Add(formatNumberBtn)
        GroupBox1.Controls.Add(formatDateTimeBtn)
        GroupBox1.Controls.Add(formatCurBtn)
        GroupBox1.Controls.Add(formatBtn)
        GroupBox1.Controls.Add(filterBtn)
        GroupBox1.Controls.Add(chrBtn)
        GroupBox1.Controls.Add(AscBtn)
        GroupBox1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(12, 81)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(266, 382)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        GroupBox1.Text = "Click the Functions Pls"
        ' 
        ' ucaseBtn
        ' 
        ucaseBtn.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        ucaseBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        ucaseBtn.FlatAppearance.MouseDownBackColor = Color.Purple
        ucaseBtn.FlatAppearance.MouseOverBackColor = Color.Fuchsia
        ucaseBtn.FlatStyle = FlatStyle.Popup
        ucaseBtn.Font = New Font("Tahoma", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        ucaseBtn.ForeColor = Color.Black
        ucaseBtn.Location = New Point(94, 339)
        ucaseBtn.Name = "ucaseBtn"
        ucaseBtn.Size = New Size(69, 29)
        ucaseBtn.TabIndex = 18
        ucaseBtn.Text = "UCase"
        ucaseBtn.UseVisualStyleBackColor = False
        ' 
        ' trimBtn
        ' 
        trimBtn.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        trimBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        trimBtn.FlatAppearance.MouseDownBackColor = Color.Purple
        trimBtn.FlatAppearance.MouseOverBackColor = Color.Fuchsia
        trimBtn.FlatStyle = FlatStyle.Popup
        trimBtn.Font = New Font("Tahoma", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        trimBtn.ForeColor = Color.Black
        trimBtn.Location = New Point(182, 287)
        trimBtn.Name = "trimBtn"
        trimBtn.Size = New Size(69, 29)
        trimBtn.TabIndex = 17
        trimBtn.Text = "Trim"
        trimBtn.UseVisualStyleBackColor = False
        ' 
        ' strReverseBtn
        ' 
        strReverseBtn.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        strReverseBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        strReverseBtn.FlatAppearance.MouseDownBackColor = Color.Purple
        strReverseBtn.FlatAppearance.MouseOverBackColor = Color.Fuchsia
        strReverseBtn.FlatStyle = FlatStyle.Popup
        strReverseBtn.Font = New Font("Tahoma", 8.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        strReverseBtn.ForeColor = Color.Black
        strReverseBtn.Location = New Point(94, 287)
        strReverseBtn.Name = "strReverseBtn"
        strReverseBtn.Size = New Size(69, 29)
        strReverseBtn.TabIndex = 16
        strReverseBtn.Text = "StrReverse"
        strReverseBtn.UseVisualStyleBackColor = False
        ' 
        ' StrDupBtn
        ' 
        StrDupBtn.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        StrDupBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        StrDupBtn.FlatAppearance.MouseDownBackColor = Color.Purple
        StrDupBtn.FlatAppearance.MouseOverBackColor = Color.Fuchsia
        StrDupBtn.FlatStyle = FlatStyle.Popup
        StrDupBtn.Font = New Font("Tahoma", 9F, FontStyle.Italic)
        StrDupBtn.ForeColor = Color.Black
        StrDupBtn.Location = New Point(6, 287)
        StrDupBtn.Name = "StrDupBtn"
        StrDupBtn.Size = New Size(69, 29)
        StrDupBtn.TabIndex = 15
        StrDupBtn.Text = "StrDup"
        StrDupBtn.UseVisualStyleBackColor = False
        ' 
        ' StrConvBtn
        ' 
        StrConvBtn.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        StrConvBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        StrConvBtn.FlatAppearance.MouseDownBackColor = Color.Purple
        StrConvBtn.FlatAppearance.MouseOverBackColor = Color.Fuchsia
        StrConvBtn.FlatStyle = FlatStyle.Popup
        StrConvBtn.Font = New Font("Tahoma", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        StrConvBtn.ForeColor = Color.Black
        StrConvBtn.Location = New Point(182, 234)
        StrConvBtn.Name = "StrConvBtn"
        StrConvBtn.Size = New Size(69, 29)
        StrConvBtn.TabIndex = 14
        StrConvBtn.Text = "StrConv"
        StrConvBtn.UseVisualStyleBackColor = False
        ' 
        ' strCompBtn
        ' 
        strCompBtn.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        strCompBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        strCompBtn.FlatAppearance.MouseDownBackColor = Color.Purple
        strCompBtn.FlatAppearance.MouseOverBackColor = Color.Fuchsia
        strCompBtn.FlatStyle = FlatStyle.Popup
        strCompBtn.Font = New Font("Tahoma", 9F, FontStyle.Italic)
        strCompBtn.ForeColor = Color.Black
        strCompBtn.Location = New Point(94, 234)
        strCompBtn.Name = "strCompBtn"
        strCompBtn.Size = New Size(69, 29)
        strCompBtn.TabIndex = 13
        strCompBtn.Text = "StrComp"
        strCompBtn.UseVisualStyleBackColor = False
        ' 
        ' splitBtn
        ' 
        splitBtn.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        splitBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        splitBtn.FlatAppearance.MouseDownBackColor = Color.Purple
        splitBtn.FlatAppearance.MouseOverBackColor = Color.Fuchsia
        splitBtn.FlatStyle = FlatStyle.Popup
        splitBtn.Font = New Font("Tahoma", 9F, FontStyle.Italic)
        splitBtn.ForeColor = Color.Black
        splitBtn.Location = New Point(6, 234)
        splitBtn.Name = "splitBtn"
        splitBtn.Size = New Size(69, 29)
        splitBtn.TabIndex = 12
        splitBtn.Text = "Split"
        splitBtn.UseVisualStyleBackColor = False
        ' 
        ' spaceBtn
        ' 
        spaceBtn.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        spaceBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        spaceBtn.FlatAppearance.MouseDownBackColor = Color.Purple
        spaceBtn.FlatAppearance.MouseOverBackColor = Color.Fuchsia
        spaceBtn.FlatStyle = FlatStyle.Popup
        spaceBtn.Font = New Font("Tahoma", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        spaceBtn.ForeColor = Color.Black
        spaceBtn.Location = New Point(182, 180)
        spaceBtn.Name = "spaceBtn"
        spaceBtn.Size = New Size(69, 29)
        spaceBtn.TabIndex = 11
        spaceBtn.Text = "Space"
        spaceBtn.UseVisualStyleBackColor = False
        ' 
        ' rtimBtn
        ' 
        rtimBtn.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        rtimBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        rtimBtn.FlatAppearance.MouseDownBackColor = Color.Purple
        rtimBtn.FlatAppearance.MouseOverBackColor = Color.Fuchsia
        rtimBtn.FlatStyle = FlatStyle.Popup
        rtimBtn.Font = New Font("Tahoma", 9F, FontStyle.Italic)
        rtimBtn.ForeColor = Color.Black
        rtimBtn.Location = New Point(94, 180)
        rtimBtn.Name = "rtimBtn"
        rtimBtn.Size = New Size(69, 29)
        rtimBtn.TabIndex = 10
        rtimBtn.Text = "RTrim"
        rtimBtn.UseVisualStyleBackColor = False
        ' 
        ' rsetBtn
        ' 
        rsetBtn.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        rsetBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        rsetBtn.FlatAppearance.MouseDownBackColor = Color.Purple
        rsetBtn.FlatAppearance.MouseOverBackColor = Color.Fuchsia
        rsetBtn.FlatStyle = FlatStyle.Popup
        rsetBtn.Font = New Font("Tahoma", 9F, FontStyle.Italic)
        rsetBtn.ForeColor = Color.Black
        rsetBtn.Location = New Point(6, 180)
        rsetBtn.Name = "rsetBtn"
        rsetBtn.Size = New Size(69, 29)
        rsetBtn.TabIndex = 9
        rsetBtn.Text = "RSet"
        rsetBtn.UseVisualStyleBackColor = False
        ' 
        ' rightBtn
        ' 
        rightBtn.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        rightBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        rightBtn.FlatAppearance.MouseDownBackColor = Color.Purple
        rightBtn.FlatAppearance.MouseOverBackColor = Color.Fuchsia
        rightBtn.FlatStyle = FlatStyle.Popup
        rightBtn.Font = New Font("Tahoma", 9F, FontStyle.Italic)
        rightBtn.ForeColor = Color.Black
        rightBtn.Location = New Point(182, 127)
        rightBtn.Name = "rightBtn"
        rightBtn.Size = New Size(69, 29)
        rightBtn.TabIndex = 8
        rightBtn.Text = "Right"
        rightBtn.UseVisualStyleBackColor = False
        ' 
        ' formatPercentbtn
        ' 
        formatPercentbtn.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        formatPercentbtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        formatPercentbtn.FlatAppearance.MouseDownBackColor = Color.Purple
        formatPercentbtn.FlatAppearance.MouseOverBackColor = Color.Fuchsia
        formatPercentbtn.FlatStyle = FlatStyle.Popup
        formatPercentbtn.Font = New Font("Tahoma", 9F, FontStyle.Italic)
        formatPercentbtn.ForeColor = Color.Black
        formatPercentbtn.Location = New Point(94, 127)
        formatPercentbtn.Name = "formatPercentbtn"
        formatPercentbtn.Size = New Size(69, 29)
        formatPercentbtn.TabIndex = 7
        formatPercentbtn.Text = "FormatP"
        formatPercentbtn.UseVisualStyleBackColor = False
        ' 
        ' formatNumberBtn
        ' 
        formatNumberBtn.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        formatNumberBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        formatNumberBtn.FlatAppearance.MouseDownBackColor = Color.Purple
        formatNumberBtn.FlatAppearance.MouseOverBackColor = Color.Fuchsia
        formatNumberBtn.FlatStyle = FlatStyle.Popup
        formatNumberBtn.Font = New Font("Tahoma", 9F, FontStyle.Italic)
        formatNumberBtn.ForeColor = Color.Black
        formatNumberBtn.Location = New Point(6, 127)
        formatNumberBtn.Name = "formatNumberBtn"
        formatNumberBtn.Size = New Size(69, 29)
        formatNumberBtn.TabIndex = 6
        formatNumberBtn.Text = "FormatN"
        formatNumberBtn.UseVisualStyleBackColor = False
        ' 
        ' formatDateTimeBtn
        ' 
        formatDateTimeBtn.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        formatDateTimeBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        formatDateTimeBtn.FlatAppearance.MouseDownBackColor = Color.Purple
        formatDateTimeBtn.FlatAppearance.MouseOverBackColor = Color.Fuchsia
        formatDateTimeBtn.FlatStyle = FlatStyle.Popup
        formatDateTimeBtn.Font = New Font("Tahoma", 8.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        formatDateTimeBtn.ForeColor = Color.Black
        formatDateTimeBtn.Location = New Point(182, 75)
        formatDateTimeBtn.Name = "formatDateTimeBtn"
        formatDateTimeBtn.Size = New Size(69, 29)
        formatDateTimeBtn.TabIndex = 5
        formatDateTimeBtn.Text = "FormatD/T"
        formatDateTimeBtn.UseVisualStyleBackColor = False
        ' 
        ' formatCurBtn
        ' 
        formatCurBtn.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        formatCurBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        formatCurBtn.FlatAppearance.MouseDownBackColor = Color.Purple
        formatCurBtn.FlatAppearance.MouseOverBackColor = Color.Fuchsia
        formatCurBtn.FlatStyle = FlatStyle.Popup
        formatCurBtn.Font = New Font("Tahoma", 8.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        formatCurBtn.ForeColor = Color.Black
        formatCurBtn.Location = New Point(94, 75)
        formatCurBtn.Name = "formatCurBtn"
        formatCurBtn.Size = New Size(69, 29)
        formatCurBtn.TabIndex = 4
        formatCurBtn.Text = "FormatCur"
        formatCurBtn.UseVisualStyleBackColor = False
        ' 
        ' formatBtn
        ' 
        formatBtn.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        formatBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        formatBtn.FlatAppearance.MouseDownBackColor = Color.Purple
        formatBtn.FlatAppearance.MouseOverBackColor = Color.Fuchsia
        formatBtn.FlatStyle = FlatStyle.Popup
        formatBtn.Font = New Font("Tahoma", 9.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        formatBtn.ForeColor = Color.Black
        formatBtn.Location = New Point(6, 75)
        formatBtn.Name = "formatBtn"
        formatBtn.Size = New Size(69, 29)
        formatBtn.TabIndex = 3
        formatBtn.Text = "Format"
        formatBtn.UseVisualStyleBackColor = False
        ' 
        ' filterBtn
        ' 
        filterBtn.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        filterBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        filterBtn.FlatAppearance.MouseDownBackColor = Color.Purple
        filterBtn.FlatAppearance.MouseOverBackColor = Color.Fuchsia
        filterBtn.FlatStyle = FlatStyle.Popup
        filterBtn.Font = New Font("Tahoma", 9.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        filterBtn.ForeColor = Color.Black
        filterBtn.Location = New Point(182, 26)
        filterBtn.Name = "filterBtn"
        filterBtn.Size = New Size(69, 29)
        filterBtn.TabIndex = 2
        filterBtn.Text = "Filter"
        filterBtn.UseVisualStyleBackColor = False
        ' 
        ' chrBtn
        ' 
        chrBtn.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        chrBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        chrBtn.FlatAppearance.MouseDownBackColor = Color.Purple
        chrBtn.FlatAppearance.MouseOverBackColor = Color.Fuchsia
        chrBtn.FlatStyle = FlatStyle.Popup
        chrBtn.Font = New Font("Tahoma", 9.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        chrBtn.ForeColor = Color.Black
        chrBtn.Location = New Point(94, 26)
        chrBtn.Name = "chrBtn"
        chrBtn.Size = New Size(69, 29)
        chrBtn.TabIndex = 1
        chrBtn.Text = "Chr/W"
        chrBtn.UseVisualStyleBackColor = False
        ' 
        ' AscBtn
        ' 
        AscBtn.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        AscBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        AscBtn.FlatAppearance.MouseDownBackColor = Color.Purple
        AscBtn.FlatAppearance.MouseOverBackColor = Color.Fuchsia
        AscBtn.FlatStyle = FlatStyle.Popup
        AscBtn.Font = New Font("Tahoma", 9.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        AscBtn.ForeColor = Color.Black
        AscBtn.Location = New Point(6, 26)
        AscBtn.Name = "AscBtn"
        AscBtn.Size = New Size(69, 29)
        AscBtn.TabIndex = 0
        AscBtn.Text = "Asc/W"
        AscBtn.UseVisualStyleBackColor = False
        ' 
        ' WEEK11_12
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(930, 494)
        Controls.Add(AllPanel)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "WEEK11_12"
        StartPosition = FormStartPosition.CenterScreen
        Text = "WEEK11_12 - MDI Simulate"
        AllPanel.ResumeLayout(False)
        AllPanel.PerformLayout()
        filterPanel.ResumeLayout(False)
        filterPanel.PerformLayout()
        characterPanel.ResumeLayout(False)
        characterPanel.PerformLayout()
        AscPanel.ResumeLayout(False)
        AscPanel.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Button4 As Button
    Friend WithEvents AllPanel As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents AscPanel As Panel
    Friend WithEvents rightBtn As Button
    Friend WithEvents formatPercentbtn As Button
    Friend WithEvents formatNumberBtn As Button
    Friend WithEvents formatDateTimeBtn As Button
    Friend WithEvents formatCurBtn As Button
    Friend WithEvents formatBtn As Button
    Friend WithEvents filterBtn As Button
    Friend WithEvents chrBtn As Button
    Friend WithEvents AscBtn As Button
    Friend WithEvents spaceBtn As Button
    Friend WithEvents rtimBtn As Button
    Friend WithEvents rsetBtn As Button
    Friend WithEvents ucaseBtn As Button
    Friend WithEvents trimBtn As Button
    Friend WithEvents strReverseBtn As Button
    Friend WithEvents StrDupBtn As Button
    Friend WithEvents StrConvBtn As Button
    Friend WithEvents strCompBtn As Button
    Friend WithEvents splitBtn As Button
    Friend WithEvents txtASC As TextBox
    Friend WithEvents ascConvertBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtASCresult As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtASCWresult As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtASCW As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents characterPanel As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCHRWresult As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCHRW As TextBox
    Friend WithEvents CHRW As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCHRresult As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCHR As TextBox
    Friend WithEvents chrConvert As Button
    Friend WithEvents filterPanel As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button3 As Button
End Class
