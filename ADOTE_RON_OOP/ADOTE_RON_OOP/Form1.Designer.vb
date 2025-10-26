<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        LogInBtn = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = Color.Black
        TextBox1.Location = New Point(99, 191)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Enter Username"
        TextBox1.Size = New Size(198, 23)
        TextBox1.TabIndex = 0
        TextBox1.Text = "admin"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Verdana", 9.75F)
        TextBox2.ForeColor = Color.Black
        TextBox2.Location = New Point(99, 258)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Enter Password"
        TextBox2.Size = New Size(198, 23)
        TextBox2.TabIndex = 1
        TextBox2.Text = "1234"
        TextBox2.UseSystemPasswordChar = True
        ' 
        ' LogInBtn
        ' 
        LogInBtn.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        LogInBtn.Cursor = Cursors.Hand
        LogInBtn.FlatAppearance.BorderSize = 0
        LogInBtn.FlatAppearance.MouseDownBackColor = Color.Fuchsia
        LogInBtn.FlatStyle = FlatStyle.Flat
        LogInBtn.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LogInBtn.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(64))
        LogInBtn.Location = New Point(144, 316)
        LogInBtn.Name = "LogInBtn"
        LogInBtn.Size = New Size(103, 32)
        LogInBtn.TabIndex = 2
        LogInBtn.Text = "Log in"
        LogInBtn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Malgun Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(131, 69)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 45)
        Label1.TabIndex = 3
        Label1.Text = "LOG IN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(99, 171)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 17)
        Label2.TabIndex = 4
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(99, 238)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 17)
        Label3.TabIndex = 5
        Label3.Text = "Password"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Indigo
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(397, 404)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(LogInBtn)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LOG IN"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LogInBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
