<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CRUD___Simple_Management_System
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CRUD___Simple_Management_System))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        CalPanel = New Panel()
        txtDobb = New TextBox()
        txtDob = New DateTimePicker()
        BtnUploadPhoto = New Button()
        BtnDelete = New Button()
        BtnUpdate = New Button()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtSearch = New TextBox()
        BtnCreate = New Button()
        txtPhoneNumber = New TextBox()
        txtAge = New TextBox()
        txtSuffix = New TextBox()
        txtMname = New TextBox()
        txtFname = New TextBox()
        txtLname = New TextBox()
        txtID = New TextBox()
        picBox = New PictureBox()
        studentTable = New DataGridView()
        Student_ID = New DataGridViewTextBoxColumn()
        Fullname = New DataGridViewTextBoxColumn()
        Phone = New DataGridViewTextBoxColumn()
        DateOfBirth = New DataGridViewTextBoxColumn()
        age = New DataGridViewTextBoxColumn()
        OpenFileDialog1 = New OpenFileDialog()
        btnClear = New Button()
        CalPanel.SuspendLayout()
        CType(picBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(studentTable, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CalPanel
        ' 
        CalPanel.BackColor = Color.Transparent
        CalPanel.BackgroundImage = CType(resources.GetObject("CalPanel.BackgroundImage"), Image)
        CalPanel.BackgroundImageLayout = ImageLayout.Stretch
        CalPanel.Controls.Add(btnClear)
        CalPanel.Controls.Add(txtDobb)
        CalPanel.Controls.Add(txtDob)
        CalPanel.Controls.Add(BtnUploadPhoto)
        CalPanel.Controls.Add(BtnDelete)
        CalPanel.Controls.Add(BtnUpdate)
        CalPanel.Controls.Add(Label8)
        CalPanel.Controls.Add(Label7)
        CalPanel.Controls.Add(Label6)
        CalPanel.Controls.Add(Label5)
        CalPanel.Controls.Add(Label4)
        CalPanel.Controls.Add(Label3)
        CalPanel.Controls.Add(Label2)
        CalPanel.Controls.Add(Label1)
        CalPanel.Controls.Add(txtSearch)
        CalPanel.Controls.Add(BtnCreate)
        CalPanel.Controls.Add(txtPhoneNumber)
        CalPanel.Controls.Add(txtAge)
        CalPanel.Controls.Add(txtSuffix)
        CalPanel.Controls.Add(txtMname)
        CalPanel.Controls.Add(txtFname)
        CalPanel.Controls.Add(txtLname)
        CalPanel.Controls.Add(txtID)
        CalPanel.Controls.Add(picBox)
        CalPanel.Controls.Add(studentTable)
        CalPanel.Dock = DockStyle.Fill
        CalPanel.Location = New Point(0, 0)
        CalPanel.Name = "CalPanel"
        CalPanel.Size = New Size(1089, 619)
        CalPanel.TabIndex = 4
        ' 
        ' txtDobb
        ' 
        txtDobb.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtDobb.Location = New Point(23, 456)
        txtDobb.Name = "txtDobb"
        txtDobb.Size = New Size(176, 25)
        txtDobb.TabIndex = 27
        ' 
        ' txtDob
        ' 
        txtDob.CalendarFont = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtDob.Location = New Point(23, 487)
        txtDob.Name = "txtDob"
        txtDob.Size = New Size(176, 23)
        txtDob.TabIndex = 26
        ' 
        ' BtnUploadPhoto
        ' 
        BtnUploadPhoto.BackColor = Color.White
        BtnUploadPhoto.FlatStyle = FlatStyle.Popup
        BtnUploadPhoto.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnUploadPhoto.ForeColor = SystemColors.ControlText
        BtnUploadPhoto.Location = New Point(134, 129)
        BtnUploadPhoto.Name = "BtnUploadPhoto"
        BtnUploadPhoto.Size = New Size(137, 34)
        BtnUploadPhoto.TabIndex = 25
        BtnUploadPhoto.Text = "Upload Photo"
        BtnUploadPhoto.UseVisualStyleBackColor = False
        ' 
        ' BtnDelete
        ' 
        BtnDelete.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        BtnDelete.FlatStyle = FlatStyle.Popup
        BtnDelete.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnDelete.ForeColor = SystemColors.ControlText
        BtnDelete.Location = New Point(292, 553)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(83, 34)
        BtnDelete.TabIndex = 24
        BtnDelete.Text = "Delete"
        BtnDelete.UseVisualStyleBackColor = False
        ' 
        ' BtnUpdate
        ' 
        BtnUpdate.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        BtnUpdate.FlatStyle = FlatStyle.Popup
        BtnUpdate.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnUpdate.ForeColor = SystemColors.ControlText
        BtnUpdate.Location = New Point(172, 553)
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.Size = New Size(83, 34)
        BtnUpdate.TabIndex = 23
        BtnUpdate.Text = "Update"
        BtnUpdate.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(259, 484)
        Label8.Name = "Label8"
        Label8.Size = New Size(115, 20)
        Label8.TabIndex = 22
        Label8.Text = "Phone Number"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(61, 513)
        Label7.Name = "Label7"
        Label7.Size = New Size(102, 20)
        Label7.TabIndex = 21
        Label7.Text = "Date Of Birth"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(337, 417)
        Label6.Name = "Label6"
        Label6.Size = New Size(37, 20)
        Label6.TabIndex = 20
        Label6.Text = "Age"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(248, 417)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 20)
        Label5.TabIndex = 19
        Label5.Text = "Suffix"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(67, 417)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 20)
        Label4.TabIndex = 18
        Label4.Text = "Middlename"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(70, 352)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 20)
        Label3.TabIndex = 17
        Label3.Text = "Lastname"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(268, 352)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 20)
        Label2.TabIndex = 16
        Label2.Text = "Firstname"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(103, 244)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 20)
        Label1.TabIndex = 15
        Label1.Text = "StudentID"
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(446, 29)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search Table"
        txtSearch.Size = New Size(324, 25)
        txtSearch.TabIndex = 14
        ' 
        ' BtnCreate
        ' 
        BtnCreate.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        BtnCreate.FlatStyle = FlatStyle.Popup
        BtnCreate.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnCreate.ForeColor = SystemColors.ControlText
        BtnCreate.Location = New Point(51, 553)
        BtnCreate.Name = "BtnCreate"
        BtnCreate.Size = New Size(83, 34)
        BtnCreate.TabIndex = 11
        BtnCreate.Text = "Create"
        BtnCreate.UseVisualStyleBackColor = False
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPhoneNumber.Location = New Point(222, 456)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(176, 25)
        txtPhoneNumber.TabIndex = 5
        ' 
        ' txtAge
        ' 
        txtAge.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtAge.Location = New Point(315, 389)
        txtAge.Name = "txtAge"
        txtAge.ReadOnly = True
        txtAge.Size = New Size(83, 25)
        txtAge.TabIndex = 8
        ' 
        ' txtSuffix
        ' 
        txtSuffix.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSuffix.Location = New Point(222, 389)
        txtSuffix.Name = "txtSuffix"
        txtSuffix.Size = New Size(87, 25)
        txtSuffix.TabIndex = 3
        ' 
        ' txtMname
        ' 
        txtMname.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtMname.Location = New Point(23, 389)
        txtMname.Name = "txtMname"
        txtMname.Size = New Size(176, 25)
        txtMname.TabIndex = 2
        ' 
        ' txtFname
        ' 
        txtFname.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtFname.Location = New Point(222, 324)
        txtFname.Name = "txtFname"
        txtFname.Size = New Size(176, 25)
        txtFname.TabIndex = 1
        ' 
        ' txtLname
        ' 
        txtLname.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtLname.Location = New Point(23, 324)
        txtLname.Name = "txtLname"
        txtLname.Size = New Size(176, 25)
        txtLname.TabIndex = 0
        ' 
        ' txtID
        ' 
        txtID.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtID.Location = New Point(189, 239)
        txtID.Name = "txtID"
        txtID.ReadOnly = True
        txtID.Size = New Size(100, 25)
        txtID.TabIndex = 3
        ' 
        ' picBox
        ' 
        picBox.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        picBox.Location = New Point(103, 60)
        picBox.Name = "picBox"
        picBox.Size = New Size(195, 168)
        picBox.SizeMode = PictureBoxSizeMode.StretchImage
        picBox.TabIndex = 2
        picBox.TabStop = False
        ' 
        ' studentTable
        ' 
        studentTable.AllowUserToAddRows = False
        studentTable.AllowUserToDeleteRows = False
        studentTable.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        studentTable.BackgroundColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        DataGridViewCellStyle1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        studentTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        studentTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        studentTable.Columns.AddRange(New DataGridViewColumn() {Student_ID, Fullname, Phone, DateOfBirth, age})
        studentTable.GridColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        studentTable.Location = New Point(446, 60)
        studentTable.Name = "studentTable"
        studentTable.ReadOnly = True
        studentTable.Size = New Size(631, 514)
        studentTable.TabIndex = 0
        ' 
        ' Student_ID
        ' 
        Student_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Student_ID.DataPropertyName = "ID"
        Student_ID.HeaderText = "ID"
        Student_ID.Name = "Student_ID"
        Student_ID.ReadOnly = True
        ' 
        ' Fullname
        ' 
        Fullname.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Fullname.DataPropertyName = "FULLNAME"
        Fullname.HeaderText = "Fullname"
        Fullname.Name = "Fullname"
        Fullname.ReadOnly = True
        Fullname.Width = 88
        ' 
        ' Phone
        ' 
        Phone.DataPropertyName = "Phone"
        Phone.HeaderText = "Phone"
        Phone.Name = "Phone"
        Phone.ReadOnly = True
        ' 
        ' DateOfBirth
        ' 
        DateOfBirth.DataPropertyName = "DateOfBirth"
        DateOfBirth.HeaderText = "DateOfBirth"
        DateOfBirth.Name = "DateOfBirth"
        DateOfBirth.ReadOnly = True
        ' 
        ' age
        ' 
        age.DataPropertyName = "age"
        age.HeaderText = "Age"
        age.Name = "age"
        age.ReadOnly = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        btnClear.FlatStyle = FlatStyle.Popup
        btnClear.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = SystemColors.ControlText
        btnClear.Location = New Point(23, 284)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(83, 27)
        btnClear.TabIndex = 28
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' CRUD___Simple_Management_System
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1089, 619)
        Controls.Add(CalPanel)
        FormBorderStyle = FormBorderStyle.FixedSingle
        KeyPreview = True
        Name = "CRUD___Simple_Management_System"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CRUD___Simple_Management_System"
        CalPanel.ResumeLayout(False)
        CalPanel.PerformLayout()
        CType(picBox, ComponentModel.ISupportInitialize).EndInit()
        CType(studentTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents CalPanel As Panel
    Friend WithEvents studentTable As DataGridView
    Friend WithEvents picBox As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtMname As TextBox
    Friend WithEvents txtSuffix As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents BtnCreate As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnUploadPhoto As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents txtDob As DateTimePicker
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Student_ID As DataGridViewTextBoxColumn
    Friend WithEvents Fullname As DataGridViewTextBoxColumn
    Friend WithEvents Phone As DataGridViewTextBoxColumn
    Friend WithEvents DateOfBirth As DataGridViewTextBoxColumn
    Friend WithEvents age As DataGridViewTextBoxColumn
    Friend WithEvents txtDobb As TextBox
    Friend WithEvents btnClear As Button
End Class