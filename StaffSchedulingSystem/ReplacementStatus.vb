Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class ReplacementStatus

    Dim adap As New SqlDataAdapter
    Dim dt As New DataTable
    Private Sub JobsPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'TODO: This line of code loads data into the 'SSMDataSet.Jobs' table. You can move, or remove it, as needed.
        '   Me.JobsTableAdapter.Fill(Me.SSMDataSet.Jobs)

        DataGridView1.AllowUserToAddRows = True
        DataGridView1.AllowUserToDeleteRows = True


        Dim SqlConn As New SqlConnection With {.ConnectionString = "Data Source= MOUNA; Database= SSM ; Integrated Security=  True "}
        adap = New SqlDataAdapter(" select * from [dbo].[replacereq]", SqlConn)

        Dim builder As New SqlCommandBuilder(adap)
        adap.InsertCommand = builder.GetInsertCommand()
        adap.UpdateCommand = builder.GetUpdateCommand()
        adap.DeleteCommand = builder.GetDeleteCommand()

        dt = New DataTable()
        adap.Fill(dt)

        DataGridView1.DataSource = dt

    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        ManagerHome.Show()
        Me.Close()
    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        Try
            DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows(0).Index)
            adap.Update(dt)
        Catch ex As Exception
            MessageBox.Show("Error removing row")
        End Try
    End Sub
End Class