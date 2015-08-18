<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReplacementStatus
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
        Me.btndel = New System.Windows.Forms.Button()
        Me.btnhome = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(44, 43)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(286, 175)
        Me.DataGridView1.TabIndex = 0
        '
        'btndel
        '
        Me.btndel.Location = New System.Drawing.Point(219, 272)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(75, 23)
        Me.btndel.TabIndex = 1
        Me.btndel.Text = "Delete"
        Me.btndel.UseVisualStyleBackColor = True
        '
        'btnhome
        '
        Me.btnhome.Location = New System.Drawing.Point(59, 271)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(75, 23)
        Me.btnhome.TabIndex = 2
        Me.btnhome.Text = "Home"
        Me.btnhome.UseVisualStyleBackColor = True
        '
        'ReplacementStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 377)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.btndel)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ReplacementStatus"
        Me.Text = "Replacement Status"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btndel As System.Windows.Forms.Button
    Friend WithEvents btnhome As System.Windows.Forms.Button
End Class
