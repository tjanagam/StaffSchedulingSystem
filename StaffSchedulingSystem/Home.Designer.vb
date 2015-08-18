<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerHome
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
        Me.btnCrtEmp = New System.Windows.Forms.Button()
        Me.btnJobsPage = New System.Windows.Forms.Button()
        Me.btnLeaveReq = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnViewApp = New System.Windows.Forms.Button()
        Me.btnrepstatus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCrtEmp
        '
        Me.btnCrtEmp.Location = New System.Drawing.Point(82, 119)
        Me.btnCrtEmp.Name = "btnCrtEmp"
        Me.btnCrtEmp.Size = New System.Drawing.Size(113, 23)
        Me.btnCrtEmp.TabIndex = 0
        Me.btnCrtEmp.Text = "Create Employee"
        Me.btnCrtEmp.UseVisualStyleBackColor = True
        '
        'btnJobsPage
        '
        Me.btnJobsPage.Location = New System.Drawing.Point(103, 22)
        Me.btnJobsPage.Name = "btnJobsPage"
        Me.btnJobsPage.Size = New System.Drawing.Size(75, 23)
        Me.btnJobsPage.TabIndex = 1
        Me.btnJobsPage.Text = "Jobs Page"
        Me.btnJobsPage.UseVisualStyleBackColor = True
        '
        'btnLeaveReq
        '
        Me.btnLeaveReq.Location = New System.Drawing.Point(70, 167)
        Me.btnLeaveReq.Name = "btnLeaveReq"
        Me.btnLeaveReq.Size = New System.Drawing.Size(142, 23)
        Me.btnLeaveReq.TabIndex = 2
        Me.btnLeaveReq.Text = "View Leave Requests"
        Me.btnLeaveReq.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(103, 315)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnViewApp
        '
        Me.btnViewApp.Location = New System.Drawing.Point(82, 70)
        Me.btnViewApp.Name = "btnViewApp"
        Me.btnViewApp.Size = New System.Drawing.Size(113, 23)
        Me.btnViewApp.TabIndex = 4
        Me.btnViewApp.Text = "View Applicants"
        Me.btnViewApp.UseVisualStyleBackColor = True
        '
        'btnrepstatus
        '
        Me.btnrepstatus.Location = New System.Drawing.Point(70, 227)
        Me.btnrepstatus.Name = "btnrepstatus"
        Me.btnrepstatus.Size = New System.Drawing.Size(142, 23)
        Me.btnrepstatus.TabIndex = 5
        Me.btnrepstatus.Text = "View Replacement Status"
        Me.btnrepstatus.UseVisualStyleBackColor = True
        '
        'ManagerHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 350)
        Me.Controls.Add(Me.btnrepstatus)
        Me.Controls.Add(Me.btnViewApp)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnLeaveReq)
        Me.Controls.Add(Me.btnJobsPage)
        Me.Controls.Add(Me.btnCrtEmp)
        Me.Name = "ManagerHome"
        Me.Text = "Manager Home"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCrtEmp As System.Windows.Forms.Button
    Friend WithEvents btnJobsPage As System.Windows.Forms.Button
    Friend WithEvents btnLeaveReq As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnViewApp As System.Windows.Forms.Button
    Friend WithEvents btnrepstatus As System.Windows.Forms.Button
End Class
