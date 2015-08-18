Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class JobsPage
    Dim adap As New SqlDataAdapter
    Dim dt As New DataTable
    Private Sub JobsPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'TODO: This line of code loads data into the 'SSMDataSet.Jobs' table. You can move, or remove it, as needed.
        '   Me.JobsTableAdapter.Fill(Me.SSMDataSet.Jobs)

        DataGridView1.AllowUserToAddRows = True
        DataGridView1.AllowUserToDeleteRows = True


        Dim SqlConn As New SqlConnection With {.ConnectionString = "Data Source= MOUNA; Database= SSM ; Integrated Security=  True "}
        adap = New SqlDataAdapter(" select * from [dbo].[Jobs]", SqlConn)

        Dim builder As New SqlCommandBuilder(adap)
        adap.InsertCommand = builder.GetInsertCommand()
        adap.UpdateCommand = builder.GetUpdateCommand()
        adap.DeleteCommand = builder.GetDeleteCommand()

        dt = New DataTable()
        adap.Fill(dt)

        DataGridView1.DataSource = dt

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            adap.Update(dt)
            MessageBox.Show("Saved successfully")
        Catch ex As Exception
            MessageBox.Show("Error updating database")
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows(0).Index)
            adap.Update(dt)
        Catch ex As Exception
            MessageBox.Show("Error removing row")
        End Try

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        ManagerHome.Show()
        Me.Close()
    End Sub
End Class