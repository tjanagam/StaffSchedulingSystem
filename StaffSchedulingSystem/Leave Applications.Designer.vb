<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Leave_Applications
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
        Me.LeaveDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReasonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpleaveApplicationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SSMDataSet3 = New StaffSchedulingSystem.SSMDataSet3()
        Me.LeaveapplicationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SSMDataSet2 = New StaffSchedulingSystem.SSMDataSet2()
        Me.LeaveapplicationsTableAdapter = New StaffSchedulingSystem.SSMDataSet2TableAdapters.leaveapplicationsTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Sp_leaveApplicationsTableAdapter = New StaffSchedulingSystem.SSMDataSet3TableAdapters.sp_leaveApplicationsTableAdapter()
        Me.btnhome = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpleaveApplicationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSMDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeaveapplicationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSMDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LeaveDateDataGridViewTextBoxColumn, Me.ReasonDataGridViewTextBoxColumn, Me.EmpIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SpleaveApplicationsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(21, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(345, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'LeaveDateDataGridViewTextBoxColumn
        '
        Me.LeaveDateDataGridViewTextBoxColumn.DataPropertyName = "leaveDate"
        Me.LeaveDateDataGridViewTextBoxColumn.HeaderText = "leaveDate"
        Me.LeaveDateDataGridViewTextBoxColumn.Name = "LeaveDateDataGridViewTextBoxColumn"
        '
        'ReasonDataGridViewTextBoxColumn
        '
        Me.ReasonDataGridViewTextBoxColumn.DataPropertyName = "reason"
        Me.ReasonDataGridViewTextBoxColumn.HeaderText = "reason"
        Me.ReasonDataGridViewTextBoxColumn.Name = "ReasonDataGridViewTextBoxColumn"
        '
        'EmpIDDataGridViewTextBoxColumn
        '
        Me.EmpIDDataGridViewTextBoxColumn.DataPropertyName = "Emp_ID"
        Me.EmpIDDataGridViewTextBoxColumn.HeaderText = "Emp_ID"
        Me.EmpIDDataGridViewTextBoxColumn.Name = "EmpIDDataGridViewTextBoxColumn"
        '
        'SpleaveApplicationsBindingSource
        '
        Me.SpleaveApplicationsBindingSource.DataMember = "sp_leaveApplications"
        Me.SpleaveApplicationsBindingSource.DataSource = Me.SSMDataSet3
        '
        'SSMDataSet3
        '
        Me.SSMDataSet3.DataSetName = "SSMDataSet3"
        Me.SSMDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LeaveapplicationsBindingSource
        '
        Me.LeaveapplicationsBindingSource.DataMember = "leaveapplications"
        Me.LeaveapplicationsBindingSource.DataSource = Me.SSMDataSet2
        '
        'SSMDataSet2
        '
        Me.SSMDataSet2.DataSetName = "SSMDataSet2"
        Me.SSMDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LeaveapplicationsTableAdapter
        '
        Me.LeaveapplicationsTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(113, 254)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Find Replacement"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Sp_leaveApplicationsTableAdapter
        '
        Me.Sp_leaveApplicationsTableAdapter.ClearBeforeFill = True
        '
        'btnhome
        '
        Me.btnhome.Location = New System.Drawing.Point(269, 302)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(75, 23)
        Me.btnhome.TabIndex = 4
        Me.btnhome.Text = "Home"
        Me.btnhome.UseVisualStyleBackColor = True
        '
        'Leave_Applications
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 372)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Leave_Applications"
        Me.Text = "Leave Applications"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpleaveApplicationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSMDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeaveapplicationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSMDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SSMDataSet2 As StaffSchedulingSystem.SSMDataSet2
    Friend WithEvents LeaveapplicationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LeaveapplicationsTableAdapter As StaffSchedulingSystem.SSMDataSet2TableAdapters.leaveapplicationsTableAdapter
    Friend WithEvents LeaveDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReasonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SSMDataSet3 As StaffSchedulingSystem.SSMDataSet3
    Friend WithEvents SpleaveApplicationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_leaveApplicationsTableAdapter As StaffSchedulingSystem.SSMDataSet3TableAdapters.sp_leaveApplicationsTableAdapter
    Friend WithEvents btnhome As System.Windows.Forms.Button
End Class
