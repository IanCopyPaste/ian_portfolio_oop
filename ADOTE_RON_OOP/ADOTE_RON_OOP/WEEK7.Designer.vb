<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WEEK7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WEEK7))
        ControlPanek = New Panel()
        Panel3 = New Panel()
        MonthsBtn = New Button()
        Panel5 = New Panel()
        Button4 = New Button()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Button9 = New Button()
        DaysBtn = New Button()
        Label1 = New Label()
        DaysPanel = New Panel()
        dayLabel = New Label()
        Combo1 = New ComboBox()
        Label3 = New Label()
        RichTextBox1 = New RichTextBox()
        Label8 = New Label()
        PictureBox4 = New PictureBox()
        StartUpPanel = New Panel()
        Label5 = New Label()
        PictureBox3 = New PictureBox()
        MonthsPanel = New Panel()
        monthLabel = New Label()
        Label2 = New Label()
        Combo2 = New ComboBox()
        RichTextBox2 = New RichTextBox()
        Label7 = New Label()
        PictureBox1 = New PictureBox()
        ControlPanek.SuspendLayout()
        Panel1.SuspendLayout()
        DaysPanel.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        StartUpPanel.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        MonthsPanel.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ControlPanek
        ' 
        ControlPanek.BackColor = Color.White
        ControlPanek.BackgroundImage = CType(resources.GetObject("ControlPanek.BackgroundImage"), Image)
        ControlPanek.BackgroundImageLayout = ImageLayout.Center
        ControlPanek.Controls.Add(Panel3)
        ControlPanek.Controls.Add(MonthsBtn)
        ControlPanek.Controls.Add(Panel5)
        ControlPanek.Controls.Add(Button4)
        ControlPanek.Controls.Add(Panel1)
        ControlPanek.Controls.Add(DaysBtn)
        ControlPanek.Controls.Add(Label1)
        ControlPanek.Dock = DockStyle.Left
        ControlPanek.Location = New Point(0, 0)
        ControlPanek.Name = "ControlPanek"
        ControlPanek.Size = New Size(193, 564)
        ControlPanek.TabIndex = 2
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.GhostWhite
        Panel3.Location = New Point(-5, 176)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(10, 66)
        Panel3.TabIndex = 10
        ' 
        ' MonthsBtn
        ' 
        MonthsBtn.BackColor = Color.Transparent
        MonthsBtn.BackgroundImageLayout = ImageLayout.None
        MonthsBtn.Cursor = Cursors.Hand
        MonthsBtn.FlatAppearance.BorderSize = 0
        MonthsBtn.FlatAppearance.MouseDownBackColor = Color.Indigo
        MonthsBtn.FlatAppearance.MouseOverBackColor = Color.Fuchsia
        MonthsBtn.FlatStyle = FlatStyle.Flat
        MonthsBtn.Font = New Font("Tahoma", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        MonthsBtn.ForeColor = Color.Transparent
        MonthsBtn.Image = CType(resources.GetObject("MonthsBtn.Image"), Image)
        MonthsBtn.ImageAlign = ContentAlignment.MiddleLeft
        MonthsBtn.Location = New Point(0, 176)
        MonthsBtn.Margin = New Padding(0, 10, 0, 10)
        MonthsBtn.Name = "MonthsBtn"
        MonthsBtn.Padding = New Padding(10, 0, 0, 0)
        MonthsBtn.Size = New Size(193, 60)
        MonthsBtn.TabIndex = 11
        MonthsBtn.Text = "  12 Months in Year"
        MonthsBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        MonthsBtn.UseVisualStyleBackColor = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.GhostWhite
        Panel5.Location = New Point(0, 491)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(5, 41)
        Panel5.TabIndex = 9
        ' 
        ' Button4
        ' 
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
        Button4.Location = New Point(0, 483)
        Button4.Name = "Button4"
        Button4.Padding = New Padding(10, 0, 40, 0)
        Button4.Size = New Size(193, 49)
        Button4.TabIndex = 8
        Button4.Text = "     Back to " & vbCrLf & "  Dashboard"
        Button4.TextImageRelation = TextImageRelation.ImageBeforeText
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.GhostWhite
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Button9)
        Panel1.Location = New Point(0, 115)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(5, 41)
        Panel1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.GhostWhite
        Panel2.Location = New Point(-94, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(5, 41)
        Panel2.TabIndex = 2
        ' 
        ' Button9
        ' 
        Button9.BackColor = Color.Transparent
        Button9.BackgroundImageLayout = ImageLayout.None
        Button9.Cursor = Cursors.Hand
        Button9.FlatAppearance.BorderSize = 0
        Button9.FlatAppearance.MouseDownBackColor = Color.Indigo
        Button9.FlatAppearance.MouseOverBackColor = Color.Fuchsia
        Button9.FlatStyle = FlatStyle.Flat
        Button9.Font = New Font("Tahoma", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button9.ForeColor = Color.Transparent
        Button9.Image = CType(resources.GetObject("Button9.Image"), Image)
        Button9.ImageAlign = ContentAlignment.MiddleLeft
        Button9.Location = New Point(-94, 0)
        Button9.Margin = New Padding(0, 10, 0, 10)
        Button9.Name = "Button9"
        Button9.Padding = New Padding(10, 0, 0, 0)
        Button9.Size = New Size(193, 41)
        Button9.TabIndex = 3
        Button9.Text = "  Data Types"
        Button9.TextImageRelation = TextImageRelation.ImageBeforeText
        Button9.UseVisualStyleBackColor = False
        ' 
        ' DaysBtn
        ' 
        DaysBtn.BackColor = Color.Transparent
        DaysBtn.BackgroundImageLayout = ImageLayout.None
        DaysBtn.Cursor = Cursors.Hand
        DaysBtn.FlatAppearance.BorderSize = 0
        DaysBtn.FlatAppearance.MouseDownBackColor = Color.Indigo
        DaysBtn.FlatAppearance.MouseOverBackColor = Color.Fuchsia
        DaysBtn.FlatStyle = FlatStyle.Flat
        DaysBtn.Font = New Font("Tahoma", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DaysBtn.ForeColor = Color.Transparent
        DaysBtn.Image = CType(resources.GetObject("DaysBtn.Image"), Image)
        DaysBtn.ImageAlign = ContentAlignment.MiddleLeft
        DaysBtn.Location = New Point(0, 115)
        DaysBtn.Margin = New Padding(0, 10, 0, 10)
        DaysBtn.Name = "DaysBtn"
        DaysBtn.Padding = New Padding(10, 0, 0, 0)
        DaysBtn.Size = New Size(193, 41)
        DaysBtn.TabIndex = 1
        DaysBtn.Text = "  7 Days in Week"
        DaysBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        DaysBtn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Cursor = Cursors.Hand
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Trebuchet MS", 15.75F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Image = CType(resources.GetObject("Label1.Image"), Image)
        Label1.ImageAlign = ContentAlignment.MiddleLeft
        Label1.Location = New Point(32, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 27)
        Label1.TabIndex = 0
        Label1.Text = "      ARRAYS"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DaysPanel
        ' 
        DaysPanel.BackColor = Color.Transparent
        DaysPanel.BackgroundImage = CType(resources.GetObject("DaysPanel.BackgroundImage"), Image)
        DaysPanel.BackgroundImageLayout = ImageLayout.Stretch
        DaysPanel.Controls.Add(dayLabel)
        DaysPanel.Controls.Add(Combo1)
        DaysPanel.Controls.Add(Label3)
        DaysPanel.Controls.Add(RichTextBox1)
        DaysPanel.Controls.Add(Label8)
        DaysPanel.Controls.Add(PictureBox4)
        DaysPanel.Dock = DockStyle.Fill
        DaysPanel.Location = New Point(193, 0)
        DaysPanel.Name = "DaysPanel"
        DaysPanel.Size = New Size(765, 564)
        DaysPanel.TabIndex = 3
        ' 
        ' dayLabel
        ' 
        dayLabel.AutoSize = True
        dayLabel.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dayLabel.ForeColor = Color.White
        dayLabel.Location = New Point(454, 385)
        dayLabel.Name = "dayLabel"
        dayLabel.Size = New Size(137, 32)
        dayLabel.TabIndex = 22
        dayLabel.Text = "Today is......"
        ' 
        ' Combo1
        ' 
        Combo1.BackColor = Color.White
        Combo1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Combo1.FormattingEnabled = True
        Combo1.Items.AddRange(New Object() {"MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY", "SUNDAY"})
        Combo1.Location = New Point(468, 253)
        Combo1.Name = "Combo1"
        Combo1.Size = New Size(163, 28)
        Combo1.TabIndex = 21
        Combo1.Text = "Days....."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(459, 182)
        Label3.Name = "Label3"
        Label3.Size = New Size(183, 37)
        Label3.TabIndex = 20
        Label3.Text = "Choose a Day"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RichTextBox1.ForeColor = Color.Purple
        RichTextBox1.Location = New Point(36, 84)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(313, 448)
        RichTextBox1.TabIndex = 9
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Trebuchet MS", 36F, FontStyle.Bold)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(183, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(417, 61)
        Label8.TabIndex = 8
        Label8.Text = "7 DAYS IN A WEEK"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Location = New Point(139, 12)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(48, 44)
        PictureBox4.TabIndex = 3
        PictureBox4.TabStop = False
        ' 
        ' StartUpPanel
        ' 
        StartUpPanel.BackColor = Color.Indigo
        StartUpPanel.Controls.Add(Label5)
        StartUpPanel.Controls.Add(PictureBox3)
        StartUpPanel.Dock = DockStyle.Fill
        StartUpPanel.Location = New Point(193, 0)
        StartUpPanel.Name = "StartUpPanel"
        StartUpPanel.Size = New Size(765, 564)
        StartUpPanel.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.DarkViolet
        Label5.FlatStyle = FlatStyle.Flat
        Label5.Font = New Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(75, 253)
        Label5.Name = "Label5"
        Label5.Size = New Size(623, 59)
        Label5.TabIndex = 0
        Label5.Text = "WELCOME TO ARRAYS"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Dock = DockStyle.Fill
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(0, 0)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(765, 564)
        PictureBox3.TabIndex = 1
        PictureBox3.TabStop = False
        ' 
        ' MonthsPanel
        ' 
        MonthsPanel.BackColor = Color.Transparent
        MonthsPanel.BackgroundImage = CType(resources.GetObject("MonthsPanel.BackgroundImage"), Image)
        MonthsPanel.BackgroundImageLayout = ImageLayout.Stretch
        MonthsPanel.Controls.Add(monthLabel)
        MonthsPanel.Controls.Add(Label2)
        MonthsPanel.Controls.Add(Combo2)
        MonthsPanel.Controls.Add(RichTextBox2)
        MonthsPanel.Controls.Add(Label7)
        MonthsPanel.Controls.Add(PictureBox1)
        MonthsPanel.Dock = DockStyle.Fill
        MonthsPanel.Location = New Point(193, 0)
        MonthsPanel.Name = "MonthsPanel"
        MonthsPanel.Size = New Size(765, 564)
        MonthsPanel.TabIndex = 6
        ' 
        ' monthLabel
        ' 
        monthLabel.AutoSize = True
        monthLabel.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        monthLabel.ForeColor = Color.White
        monthLabel.Location = New Point(445, 399)
        monthLabel.Name = "monthLabel"
        monthLabel.Size = New Size(146, 32)
        monthLabel.TabIndex = 24
        monthLabel.Text = "Month is......"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(445, 176)
        Label2.Name = "Label2"
        Label2.Size = New Size(219, 37)
        Label2.TabIndex = 23
        Label2.Text = "Choose a Month"
        ' 
        ' Combo2
        ' 
        Combo2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Combo2.FormattingEnabled = True
        Combo2.Items.AddRange(New Object() {"JANUARY", "FEBUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY ", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Combo2.Location = New Point(468, 253)
        Combo2.Name = "Combo2"
        Combo2.Size = New Size(163, 28)
        Combo2.TabIndex = 22
        Combo2.Text = "Months....."
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        RichTextBox2.BorderStyle = BorderStyle.None
        RichTextBox2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RichTextBox2.ForeColor = Color.Purple
        RichTextBox2.Location = New Point(36, 84)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.Size = New Size(313, 448)
        RichTextBox2.TabIndex = 9
        RichTextBox2.Text = resources.GetString("RichTextBox2.Text")
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Trebuchet MS", 36F, FontStyle.Bold)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(152, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(511, 61)
        Label7.TabIndex = 8
        Label7.Text = "12 MONTHS IN A YEAR"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(108, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(48, 44)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' WEEK7
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(958, 564)
        Controls.Add(StartUpPanel)
        Controls.Add(DaysPanel)
        Controls.Add(MonthsPanel)
        Controls.Add(ControlPanek)
        Name = "WEEK7"
        StartPosition = FormStartPosition.CenterScreen
        Text = "WEEK7"
        ControlPanek.ResumeLayout(False)
        ControlPanek.PerformLayout()
        Panel1.ResumeLayout(False)
        DaysPanel.ResumeLayout(False)
        DaysPanel.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        StartUpPanel.ResumeLayout(False)
        StartUpPanel.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        MonthsPanel.ResumeLayout(False)
        MonthsPanel.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ControlPanek As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents MonthsBtn As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button9 As Button
    Friend WithEvents DaysBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DaysPanel As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents StartUpPanel As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents MonthsPanel As Panel
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dayLabel As Label
    Friend WithEvents Combo1 As ComboBox
    Friend WithEvents monthLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Combo2 As ComboBox
End Class
