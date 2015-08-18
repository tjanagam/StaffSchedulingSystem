<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_Requests
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnaccept = New System.Windows.Forms.Button()
        Me.btnreject = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(52, 26)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(250, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'btnaccept
        '
        Me.btnaccept.Location = New System.Drawing.Point(36, 243)
        Me.btnaccept.Name = "btnaccept"
        Me.btnaccept.Size = New System.Drawing.Size(75, 23)
        Me.btnaccept.TabIndex = 1
        Me.btnaccept.Text = "Accept"
        Me.btnaccept.UseVisualStyleBackColor = True
        '
        'btnreject
        '
        Me.btnreject.Location = New System.Drawing.Point(232, 243)
        Me.btnreject.Name = "btnreject"
        Me.btnreject.Size = New System.Drawing.Size(75, 23)
        Me.btnreject.TabIndex = 2
        Me.btnreject.Text = "Reject"
        Me.btnreject.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(132, 308)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 23)
        Me.btnHome.TabIndex = 3
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'View_Requests
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 343)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnreject)
        Me.Controls.Add(Me.btnaccept)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "View_Requests"
        Me.Text = "View_Requests"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnaccept As System.Windows.Forms.Button
    Friend WithEvents btnreject As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
End Class
