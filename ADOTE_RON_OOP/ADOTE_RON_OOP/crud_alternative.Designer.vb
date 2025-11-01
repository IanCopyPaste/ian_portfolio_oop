<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class crud_alternative
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(crud_alternative))
        CalPanel = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        txtSearch = New TextBox()
        txtProdId = New TextBox()
        DelBtn = New Button()
        updBtn = New Button()
        crtBtn = New Button()
        txtProdName = New TextBox()
        studentTable = New DataGridView()
        ProductID = New DataGridViewTextBoxColumn()
        ProductName = New DataGridViewTextBoxColumn()
        BtnDelete = New Button()
        BtnUpdate = New Button()
        BtnCreate = New Button()
        CalPanel.SuspendLayout()
        CType(studentTable, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CalPanel
        ' 
        CalPanel.BackColor = Color.Transparent
        CalPanel.BackgroundImage = CType(resources.GetObject("CalPanel.BackgroundImage"), Image)
        CalPanel.BackgroundImageLayout = ImageLayout.Stretch
        CalPanel.Controls.Add(Label2)
        CalPanel.Controls.Add(Label1)
        CalPanel.Controls.Add(txtSearch)
        CalPanel.Controls.Add(txtProdId)
        CalPanel.Controls.Add(DelBtn)
        CalPanel.Controls.Add(updBtn)
        CalPanel.Controls.Add(crtBtn)
        CalPanel.Controls.Add(txtProdName)
        CalPanel.Controls.Add(studentTable)
        CalPanel.Controls.Add(BtnDelete)
        CalPanel.Controls.Add(BtnUpdate)
        CalPanel.Controls.Add(BtnCreate)
        CalPanel.Dock = DockStyle.Fill
        CalPanel.Location = New Point(0, 0)
        CalPanel.Name = "CalPanel"
        CalPanel.Size = New Size(881, 520)
        CalPanel.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(144, 292)
        Label2.Name = "Label2"
        Label2.Size = New Size(110, 20)
        Label2.TabIndex = 33
        Label2.Text = "Product Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(156, 217)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 20)
        Label1.TabIndex = 32
        Label1.Text = "ProductID"
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(403, 28)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search Product Name"
        txtSearch.Size = New Size(227, 25)
        txtSearch.TabIndex = 31
        ' 
        ' txtProdId
        ' 
        txtProdId.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtProdId.Location = New Point(96, 189)
        txtProdId.Name = "txtProdId"
        txtProdId.PlaceholderText = "Product ID"
        txtProdId.ReadOnly = True
        txtProdId.Size = New Size(195, 25)
        txtProdId.TabIndex = 30
        ' 
        ' DelBtn
        ' 
        DelBtn.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        DelBtn.FlatAppearance.BorderSize = 0
        DelBtn.FlatStyle = FlatStyle.Popup
        DelBtn.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DelBtn.Location = New Point(256, 352)
        DelBtn.Name = "DelBtn"
        DelBtn.Size = New Size(75, 29)
        DelBtn.TabIndex = 29
        DelBtn.Text = "Delete"
        DelBtn.UseVisualStyleBackColor = False
        ' 
        ' updBtn
        ' 
        updBtn.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        updBtn.FlatAppearance.BorderSize = 0
        updBtn.FlatStyle = FlatStyle.Popup
        updBtn.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        updBtn.Location = New Point(160, 352)
        updBtn.Name = "updBtn"
        updBtn.Size = New Size(75, 29)
        updBtn.TabIndex = 28
        updBtn.Text = "Update"
        updBtn.UseVisualStyleBackColor = False
        ' 
        ' crtBtn
        ' 
        crtBtn.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        crtBtn.FlatAppearance.BorderSize = 0
        crtBtn.FlatStyle = FlatStyle.Popup
        crtBtn.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        crtBtn.Location = New Point(64, 352)
        crtBtn.Name = "crtBtn"
        crtBtn.Size = New Size(75, 29)
        crtBtn.TabIndex = 27
        crtBtn.Text = "Insert"
        crtBtn.UseVisualStyleBackColor = False
        ' 
        ' txtProdName
        ' 
        txtProdName.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtProdName.Location = New Point(96, 264)
        txtProdName.Name = "txtProdName"
        txtProdName.PlaceholderText = "Enter Product Name"
        txtProdName.Size = New Size(195, 25)
        txtProdName.TabIndex = 26
        ' 
        ' studentTable
        ' 
        studentTable.AllowUserToAddRows = False
        studentTable.AllowUserToDeleteRows = False
        studentTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        studentTable.Columns.AddRange(New DataGridViewColumn() {ProductID, ProductName})
        studentTable.Location = New Point(403, 67)
        studentTable.Name = "studentTable"
        studentTable.ReadOnly = True
        studentTable.Size = New Size(412, 361)
        studentTable.TabIndex = 25
        ' 
        ' ProductID
        ' 
        ProductID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ProductID.DataPropertyName = "prod_id"
        ProductID.HeaderText = "ProductID"
        ProductID.Name = "ProductID"
        ProductID.ReadOnly = True
        ' 
        ' ProductName
        ' 
        ProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ProductName.DataPropertyName = "prod_name"
        ProductName.HeaderText = "Product Name"
        ProductName.Name = "ProductName"
        ProductName.ReadOnly = True
        ' 
        ' BtnDelete
        ' 
        BtnDelete.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        BtnDelete.FlatStyle = FlatStyle.Popup
        BtnDelete.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnDelete.ForeColor = SystemColors.ControlText
        BtnDelete.Location = New Point(291, 540)
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
        BtnUpdate.Location = New Point(171, 540)
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.Size = New Size(83, 34)
        BtnUpdate.TabIndex = 23
        BtnUpdate.Text = "Update"
        BtnUpdate.UseVisualStyleBackColor = False
        ' 
        ' BtnCreate
        ' 
        BtnCreate.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        BtnCreate.FlatStyle = FlatStyle.Popup
        BtnCreate.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnCreate.ForeColor = SystemColors.ControlText
        BtnCreate.Location = New Point(50, 540)
        BtnCreate.Name = "BtnCreate"
        BtnCreate.Size = New Size(83, 34)
        BtnCreate.TabIndex = 11
        BtnCreate.Text = "Create"
        BtnCreate.UseVisualStyleBackColor = False
        ' 
        ' crud_alternative
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(881, 520)
        Controls.Add(CalPanel)
        Name = "crud_alternative"
        StartPosition = FormStartPosition.CenterScreen
        Text = "crud_alternative"
        CalPanel.ResumeLayout(False)
        CalPanel.PerformLayout()
        CType(studentTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents CalPanel As Panel
    Friend WithEvents studentTable As DataGridView
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnCreate As Button
    Friend WithEvents crtBtn As Button
    Friend WithEvents txtProdName As TextBox
    Friend WithEvents DelBtn As Button
    Friend WithEvents updBtn As Button
    Friend WithEvents ProductID As DataGridViewTextBoxColumn
    Friend WithEvents ProductName As DataGridViewTextBoxColumn
    Friend WithEvents txtProdId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearch As TextBox
End Class
