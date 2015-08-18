<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JobsPage
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
        Me.JobIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SSMDataSet = New StaffSchedulingSystem.SSMDataSet()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.JobsTableAdapter = New StaffSchedulingSystem.SSMDataSetTableAdapters.JobsTableAdapter()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.JobIdDataGridViewTextBoxColumn, Me.JobTitleDataGridViewTextBoxColumn, Me.JobDescDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.JobsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(21, 28)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(460, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'JobIdDataGridViewTextBoxColumn
        '
        Me.JobIdDataGridViewTextBoxColumn.DataPropertyName = "jobId"
        Me.JobIdDataGridViewTextBoxColumn.HeaderText = "jobId"
        Me.JobIdDataGridViewTextBoxColumn.Name = "JobIdDataGridViewTextBoxColumn"
        '
        'JobTitleDataGridViewTextBoxColumn
        '
        Me.JobTitleDataGridViewTextBoxColumn.DataPropertyName = "jobTitle"
        Me.JobTitleDataGridViewTextBoxColumn.HeaderText = "jobTitle"
        Me.JobTitleDataGridViewTextBoxColumn.Name = "JobTitleDataGridViewTextBoxColumn"
        '
        'JobDescDataGridViewTextBoxColumn
        '
        Me.JobDescDataGridViewTextBoxColumn.DataPropertyName = "jobDesc"
        Me.JobDescDataGridViewTextBoxColumn.HeaderText = "jobDesc"
        Me.JobDescDataGridViewTextBoxColumn.Name = "JobDescDataGridViewTextBoxColumn"
        '
        'JobsBindingSource
        '
        Me.JobsBindingSource.DataMember = "Jobs"
        Me.JobsBindingSource.DataSource = Me.SSMDataSet
        '
        'SSMDataSet
        '
        Me.SSMDataSet.DataSetName = "SSMDataSet"
        Me.SSMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(76, 247)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 23)
        Me.btnHome.TabIndex = 1
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'JobsTableAdapter
        '
        Me.JobsTableAdapter.ClearBeforeFill = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(180, 218)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(288, 217)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'JobsPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 305)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "JobsPage"
        Me.Text = "Jobs Page"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents SSMDataSet As StaffSchedulingSystem.SSMDataSet
    Friend WithEvents JobsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JobsTableAdapter As StaffSchedulingSystem.SSMDataSetTableAdapters.JobsTableAdapter
    Friend WithEvents JobIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JobTitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JobDescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class
