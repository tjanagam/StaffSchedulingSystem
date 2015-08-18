<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Application_Page
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.ApplicatNAme = New System.Windows.Forms.Label()
        Me.ApplicantPhone = New System.Windows.Forms.Label()
        Me.appName = New System.Windows.Forms.TextBox()
        Me.appPhone = New System.Windows.Forms.TextBox()
        Me.SSMDataSet = New StaffSchedulingSystem.SSMDataSet()
        Me.JobsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JobsTableAdapter = New StaffSchedulingSystem.SSMDataSetTableAdapters.JobsTableAdapter()
        Me.JobIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.jobId = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.JobIdDataGridViewTextBoxColumn, Me.JobTitleDataGridViewTextBoxColumn, Me.JobDescDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.JobsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(346, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(95, 297)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 1
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'ApplicatNAme
        '
        Me.ApplicatNAme.AutoSize = True
        Me.ApplicatNAme.Location = New System.Drawing.Point(15, 228)
        Me.ApplicatNAme.Name = "ApplicatNAme"
        Me.ApplicatNAme.Size = New System.Drawing.Size(82, 13)
        Me.ApplicatNAme.TabIndex = 2
        Me.ApplicatNAme.Text = "Applicant Name"
        '
        'ApplicantPhone
        '
        Me.ApplicantPhone.AutoSize = True
        Me.ApplicantPhone.Location = New System.Drawing.Point(15, 259)
        Me.ApplicantPhone.Name = "ApplicantPhone"
        Me.ApplicantPhone.Size = New System.Drawing.Size(85, 13)
        Me.ApplicantPhone.TabIndex = 3
        Me.ApplicantPhone.Text = "Applicant Phone"
        '
        'appName
        '
        Me.appName.Location = New System.Drawing.Point(142, 225)
        Me.appName.Name = "appName"
        Me.appName.Size = New System.Drawing.Size(100, 20)
        Me.appName.TabIndex = 4
        '
        'appPhone
        '
        Me.appPhone.Location = New System.Drawing.Point(142, 259)
        Me.appPhone.Name = "appPhone"
        Me.appPhone.Size = New System.Drawing.Size(100, 20)
        Me.appPhone.TabIndex = 5
        '
        'SSMDataSet
        '
        Me.SSMDataSet.DataSetName = "SSMDataSet"
        Me.SSMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JobsBindingSource
        '
        Me.JobsBindingSource.DataMember = "Jobs"
        Me.JobsBindingSource.DataSource = Me.SSMDataSet
        '
        'JobsTableAdapter
        '
        Me.JobsTableAdapter.ClearBeforeFill = True
        '
        'JobIdDataGridViewTextBoxColumn
        '
        Me.JobIdDataGridViewTextBoxColumn.DataPropertyName = "jobId"
        Me.JobIdDataGridViewTextBoxColumn.HeaderText = "jobId"
        Me.JobIdDataGridViewTextBoxColumn.Name = "JobIdDataGridViewTextBoxColumn"
        Me.JobIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JobTitleDataGridViewTextBoxColumn
        '
        Me.JobTitleDataGridViewTextBoxColumn.DataPropertyName = "jobTitle"
        Me.JobTitleDataGridViewTextBoxColumn.HeaderText = "jobTitle"
        Me.JobTitleDataGridViewTextBoxColumn.Name = "JobTitleDataGridViewTextBoxColumn"
        Me.JobTitleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JobDescDataGridViewTextBoxColumn
        '
        Me.JobDescDataGridViewTextBoxColumn.DataPropertyName = "jobDesc"
        Me.JobDescDataGridViewTextBoxColumn.HeaderText = "jobDesc"
        Me.JobDescDataGridViewTextBoxColumn.Name = "JobDescDataGridViewTextBoxColumn"
        Me.JobDescDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 190)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Job Id"
        '
        'jobId
        '
        Me.jobId.Location = New System.Drawing.Point(142, 187)
        Me.jobId.Name = "jobId"
        Me.jobId.Size = New System.Drawing.Size(100, 20)
        Me.jobId.TabIndex = 7
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(282, 296)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Application_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 332)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.jobId)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.appPhone)
        Me.Controls.Add(Me.appName)
        Me.Controls.Add(Me.ApplicantPhone)
        Me.Controls.Add(Me.ApplicatNAme)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Application_Page"
        Me.Text = "Application_Page"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents ApplicatNAme As System.Windows.Forms.Label
    Friend WithEvents ApplicantPhone As System.Windows.Forms.Label
    Friend WithEvents appName As System.Windows.Forms.TextBox
    Friend WithEvents appPhone As System.Windows.Forms.TextBox
    Friend WithEvents SSMDataSet As StaffSchedulingSystem.SSMDataSet
    Friend WithEvents JobsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JobsTableAdapter As StaffSchedulingSystem.SSMDataSetTableAdapters.JobsTableAdapter
    Friend WithEvents JobIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JobTitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JobDescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents jobId As System.Windows.Forms.TextBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
