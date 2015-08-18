<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Applicants_List
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
        Me.JobIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApplicantNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApplicantphoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobapplicantsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SSMDataSet1 = New StaffSchedulingSystem.SSMDataSet1()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.JobapplicantsTableAdapter = New StaffSchedulingSystem.SSMDataSet1TableAdapters.jobapplicantsTableAdapter()
        Me.btndelapp = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobapplicantsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSMDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.JobIDDataGridViewTextBoxColumn, Me.ApplicantNameDataGridViewTextBoxColumn, Me.ApplicantphoneDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.JobapplicantsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(22, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(342, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'JobIDDataGridViewTextBoxColumn
        '
        Me.JobIDDataGridViewTextBoxColumn.DataPropertyName = "Job_ID"
        Me.JobIDDataGridViewTextBoxColumn.HeaderText = "Job_ID"
        Me.JobIDDataGridViewTextBoxColumn.Name = "JobIDDataGridViewTextBoxColumn"
        Me.JobIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApplicantNameDataGridViewTextBoxColumn
        '
        Me.ApplicantNameDataGridViewTextBoxColumn.DataPropertyName = "Applicant_Name"
        Me.ApplicantNameDataGridViewTextBoxColumn.HeaderText = "Applicant_Name"
        Me.ApplicantNameDataGridViewTextBoxColumn.Name = "ApplicantNameDataGridViewTextBoxColumn"
        Me.ApplicantNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApplicantphoneDataGridViewTextBoxColumn
        '
        Me.ApplicantphoneDataGridViewTextBoxColumn.DataPropertyName = "Applicant_phone"
        Me.ApplicantphoneDataGridViewTextBoxColumn.HeaderText = "Applicant_phone"
        Me.ApplicantphoneDataGridViewTextBoxColumn.Name = "ApplicantphoneDataGridViewTextBoxColumn"
        Me.ApplicantphoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JobapplicantsBindingSource
        '
        Me.JobapplicantsBindingSource.DataMember = "jobapplicants"
        Me.JobapplicantsBindingSource.DataSource = Me.SSMDataSet1
        '
        'SSMDataSet1
        '
        Me.SSMDataSet1.DataSetName = "SSMDataSet1"
        Me.SSMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(68, 202)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 23)
        Me.btnHome.TabIndex = 1
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'JobapplicantsTableAdapter
        '
        Me.JobapplicantsTableAdapter.ClearBeforeFill = True
        '
        'btndelapp
        '
        Me.btndelapp.Location = New System.Drawing.Point(237, 202)
        Me.btndelapp.Name = "btndelapp"
        Me.btndelapp.Size = New System.Drawing.Size(107, 23)
        Me.btndelapp.TabIndex = 2
        Me.btndelapp.Text = "Delete Applicant"
        Me.btndelapp.UseVisualStyleBackColor = True
        '
        'Applicants_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 261)
        Me.Controls.Add(Me.btndelapp)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Applicants_List"
        Me.Text = "Applicants List"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobapplicantsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSMDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents SSMDataSet1 As StaffSchedulingSystem.SSMDataSet1
    Friend WithEvents JobapplicantsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JobapplicantsTableAdapter As StaffSchedulingSystem.SSMDataSet1TableAdapters.jobapplicantsTableAdapter
    Friend WithEvents JobIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApplicantNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApplicantphoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btndelapp As System.Windows.Forms.Button
End Class
