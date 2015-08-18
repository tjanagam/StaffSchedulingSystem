Imports System.Data.Sql
Imports System.Data.SqlClient



Public Class Leave_Applications
    Dim adap As New SqlDataAdapter
    Dim dt As New DataTable
    Private Sub Leave_Applications_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SSMDataSet3.sp_leaveApplications' table. You can move, or remove it, as needed.
        Me.Sp_leaveApplicationsTableAdapter.Fill(Me.SSMDataSet3.sp_leaveApplications)
        'TODO: This line of code loads data into the 'SSMDataSet2.leaveapplications' table. You can move, or remove it, as needed.
        'Me.LeaveapplicationsTableAdapter.Fill(Me.SSMDataSet2.leaveapplications)
        DataGridView1.AllowUserToAddRows = True
        DataGridView1.AllowUserToDeleteRows = True


        Dim SqlConn As New SqlConnection With {.ConnectionString = "Data Source= MOUNA; Database= SSM ; Integrated Security=  True "}
        adap = New SqlDataAdapter("select * from [dbo].[leaveapplications]", SqlConn)

        Dim builder As New SqlCommandBuilder(adap)
        'adap.InsertCommand = builder.GetInsertCommand()
        'adap.UpdateCommand = builder.GetUpdateCommand()
        'adap.DeleteCommand = builder.GetDeleteCommand()

        dt = New DataTable()
        adap.Fill(dt)

        DataGridView1.DataSource = dt
      


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Replacements.Show()
        Me.Close()
    End Sub

    Private Sub dtgContactList_RowEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick


        Dim SqlConn As New SqlConnection With {.ConnectionString = "Data Source= MOUNA; Database= SSM ; Integrated Security=  True "}
        Dim i As Integer
        Dim query As String
        i = DataGridView1.CurrentRow.Index


        query = "select * from [dbo].[leaveapplications]"

        ' sqlcmd()
        ' sqlcmd = New SqlCommand(query, sqlc)
        DataGridView1.Rows(e.RowIndex).Selected = True

        '   leavedate = DataGridView1.Rows(e.RowIndex).Cells("leaveDate").Value
        leavedate = DataGridView1.Item(0, i).Value
        reason = DataGridView1.Item(1, i).Value
        leaveempid = DataGridView1.Item(2, i).Value
        '' reason = DataGridView1.Rows(e.RowIndex).Cells("reason").Value

    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        ManagerHome.Show()
        Me.Close()
    End Sub
End Class